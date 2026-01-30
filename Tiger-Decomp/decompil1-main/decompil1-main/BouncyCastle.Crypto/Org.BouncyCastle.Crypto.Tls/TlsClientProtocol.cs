using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsClientProtocol : TlsProtocol
{
	protected TlsClient mTlsClient;

	internal TlsClientContextImpl mTlsClientContext;

	protected byte[] mSelectedSessionID;

	protected TlsKeyExchange mKeyExchange;

	protected TlsAuthentication mAuthentication;

	protected CertificateStatus mCertificateStatus;

	protected CertificateRequest mCertificateRequest;

	protected override TlsContext Context => mTlsClientContext;

	internal override AbstractTlsContext ContextAdmin => mTlsClientContext;

	protected override TlsPeer Peer => mTlsClient;

	public TlsClientProtocol(Stream stream, SecureRandom secureRandom)
		: base(stream, secureRandom)
	{
	}

	public TlsClientProtocol(Stream input, Stream output, SecureRandom secureRandom)
		: base(input, output, secureRandom)
	{
	}

	public TlsClientProtocol(SecureRandom secureRandom)
		: base(secureRandom)
	{
	}

	public virtual void Connect(TlsClient tlsClient)
	{
		if (tlsClient == null)
		{
			throw new ArgumentNullException("tlsClient");
		}
		if (mTlsClient != null)
		{
			throw new InvalidOperationException("'Connect' can only be called once");
		}
		mTlsClient = tlsClient;
		mSecurityParameters = new SecurityParameters();
		mSecurityParameters.entity = 1;
		mTlsClientContext = new TlsClientContextImpl(mSecureRandom, mSecurityParameters);
		mSecurityParameters.clientRandom = TlsProtocol.CreateRandomBlock(tlsClient.ShouldUseGmtUnixTime(), mTlsClientContext.NonceRandomGenerator);
		mTlsClient.Init(mTlsClientContext);
		mRecordStream.Init(mTlsClientContext);
		tlsClient.NotifyCloseHandle(this);
		TlsSession sessionToResume = tlsClient.GetSessionToResume();
		if (sessionToResume != null && sessionToResume.IsResumable)
		{
			SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters != null && sessionParameters.IsExtendedMasterSecret)
			{
				mTlsSession = sessionToResume;
				mSessionParameters = sessionParameters;
			}
		}
		SendClientHelloMessage();
		mConnectionState = 1;
		BlockForHandshake();
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		mSelectedSessionID = null;
		mKeyExchange = null;
		mAuthentication = null;
		mCertificateStatus = null;
		mCertificateRequest = null;
	}

	protected override void HandleHandshakeMessage(byte type, MemoryStream buf)
	{
		if (mResumedSession)
		{
			if (type != 20 || mConnectionState != 2)
			{
				throw new TlsFatalAlert(10);
			}
			ProcessFinishedMessage(buf);
			mConnectionState = 15;
			SendChangeCipherSpecMessage();
			SendFinishedMessage();
			mConnectionState = 13;
			CompleteHandshake();
			return;
		}
		switch (type)
		{
		case 11:
		{
			short num = mConnectionState;
			if ((uint)(num - 2) <= 1u)
			{
				if (mConnectionState == 2)
				{
					HandleSupplementalData(null);
				}
				mPeerCertificate = Certificate.Parse(buf);
				TlsProtocol.AssertEmpty(buf);
				if (mPeerCertificate == null || mPeerCertificate.IsEmpty)
				{
					mAllowCertificateStatus = false;
				}
				mKeyExchange.ProcessServerCertificate(mPeerCertificate);
				mAuthentication = mTlsClient.GetAuthentication();
				mAuthentication.NotifyServerCertificate(mPeerCertificate);
				mConnectionState = 4;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 22:
			if (mConnectionState == 4)
			{
				if (!mAllowCertificateStatus)
				{
					throw new TlsFatalAlert(10);
				}
				mCertificateStatus = CertificateStatus.Parse(buf);
				TlsProtocol.AssertEmpty(buf);
				mConnectionState = 5;
				break;
			}
			throw new TlsFatalAlert(10);
		case 20:
		{
			short num = mConnectionState;
			if ((uint)(num - 13) <= 1u)
			{
				if (mConnectionState == 13 && mExpectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				mConnectionState = 15;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 2:
			if (mConnectionState == 1)
			{
				ReceiveServerHelloMessage(buf);
				mConnectionState = 2;
				mRecordStream.NotifyHelloComplete();
				ApplyMaxFragmentLengthExtension();
				if (mResumedSession)
				{
					mSecurityParameters.masterSecret = Arrays.Clone(mSessionParameters.MasterSecret);
					mRecordStream.SetPendingConnectionState(Peer.GetCompression(), Peer.GetCipher());
					break;
				}
				InvalidateSession();
				if (mSelectedSessionID.Length != 0)
				{
					mTlsSession = new TlsSessionImpl(mSelectedSessionID, null);
				}
				break;
			}
			throw new TlsFatalAlert(10);
		case 23:
			if (mConnectionState == 2)
			{
				HandleSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
				break;
			}
			throw new TlsFatalAlert(10);
		case 14:
		{
			short num = mConnectionState;
			if ((uint)(num - 2) <= 5u)
			{
				if (mConnectionState < 3)
				{
					HandleSupplementalData(null);
				}
				if (mConnectionState < 4)
				{
					mKeyExchange.SkipServerCredentials();
					mAuthentication = null;
				}
				if (mConnectionState < 6)
				{
					mKeyExchange.SkipServerKeyExchange();
				}
				TlsProtocol.AssertEmpty(buf);
				mConnectionState = 8;
				mRecordStream.HandshakeHash.SealHashAlgorithms();
				IList clientSupplementalData = mTlsClient.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					SendSupplementalDataMessage(clientSupplementalData);
				}
				mConnectionState = 9;
				TlsCredentials clientCreds = null;
				if (mCertificateRequest == null)
				{
					mKeyExchange.SkipClientCredentials();
				}
				else
				{
					clientCreds = mAuthentication.GetClientCredentials(mCertificateRequest);
					if (clientCreds == null)
					{
						mKeyExchange.SkipClientCredentials();
						SendCertificateMessage(Certificate.EmptyChain);
					}
					else
					{
						mKeyExchange.ProcessClientCredentials(clientCreds);
						SendCertificateMessage(clientCreds.Certificate);
					}
				}
				mConnectionState = 10;
				SendClientKeyExchangeMessage();
				mConnectionState = 11;
				if (TlsUtilities.IsSsl(Context))
				{
					TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
				}
				TlsHandshakeHash prepareFinishHash = mRecordStream.PrepareToFinish();
				mSecurityParameters.sessionHash = TlsProtocol.GetCurrentPrfHash(Context, prepareFinishHash, null);
				if (!TlsUtilities.IsSsl(Context))
				{
					TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
				}
				mRecordStream.SetPendingConnectionState(Peer.GetCompression(), Peer.GetCipher());
				if (clientCreds != null && clientCreds is TlsSignerCredentials)
				{
					TlsSignerCredentials signerCredentials = (TlsSignerCredentials)clientCreds;
					SignatureAndHashAlgorithm signatureAndHashAlgorithm = TlsUtilities.GetSignatureAndHashAlgorithm(Context, signerCredentials);
					byte[] hash = ((signatureAndHashAlgorithm != null) ? prepareFinishHash.GetFinalHash(signatureAndHashAlgorithm.Hash) : mSecurityParameters.SessionHash);
					byte[] signature = signerCredentials.GenerateCertificateSignature(hash);
					DigitallySigned certificateVerify = new DigitallySigned(signatureAndHashAlgorithm, signature);
					SendCertificateVerifyMessage(certificateVerify);
					mConnectionState = 12;
				}
				SendChangeCipherSpecMessage();
				SendFinishedMessage();
				mConnectionState = 13;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 12:
		{
			short num = mConnectionState;
			if ((uint)(num - 2) <= 3u)
			{
				if (mConnectionState < 3)
				{
					HandleSupplementalData(null);
				}
				if (mConnectionState < 4)
				{
					mKeyExchange.SkipServerCredentials();
					mAuthentication = null;
				}
				mKeyExchange.ProcessServerKeyExchange(buf);
				TlsProtocol.AssertEmpty(buf);
				mConnectionState = 6;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 13:
		{
			short num = mConnectionState;
			if ((uint)(num - 4) <= 2u)
			{
				if (mConnectionState != 6)
				{
					mKeyExchange.SkipServerKeyExchange();
				}
				if (mAuthentication == null)
				{
					throw new TlsFatalAlert(40);
				}
				mCertificateRequest = CertificateRequest.Parse(Context, buf);
				TlsProtocol.AssertEmpty(buf);
				mKeyExchange.ValidateCertificateRequest(mCertificateRequest);
				TlsUtilities.TrackHashAlgorithms(mRecordStream.HandshakeHash, mCertificateRequest.SupportedSignatureAlgorithms);
				mConnectionState = 7;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 4:
			if (mConnectionState == 13)
			{
				if (!mExpectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				InvalidateSession();
				ReceiveNewSessionTicketMessage(buf);
				mConnectionState = 14;
				break;
			}
			throw new TlsFatalAlert(10);
		case 0:
			TlsProtocol.AssertEmpty(buf);
			if (mConnectionState == 16)
			{
				RefuseRenegotiation();
			}
			break;
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void HandleSupplementalData(IList serverSupplementalData)
	{
		mTlsClient.ProcessServerSupplementalData(serverSupplementalData);
		mConnectionState = 3;
		mKeyExchange = mTlsClient.GetKeyExchange();
		mKeyExchange.Init(Context);
	}

	protected virtual void ReceiveNewSessionTicketMessage(MemoryStream buf)
	{
		NewSessionTicket newSessionTicket = NewSessionTicket.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
		mTlsClient.NotifyNewSessionTicket(newSessionTicket);
	}

	protected virtual void ReceiveServerHelloMessage(MemoryStream buf)
	{
		ProtocolVersion server_version = TlsUtilities.ReadVersion(buf);
		if (server_version.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		if (!server_version.Equals(mRecordStream.ReadVersion))
		{
			throw new TlsFatalAlert(47);
		}
		ProtocolVersion client_version = Context.ClientVersion;
		if (!server_version.IsEqualOrEarlierVersionOf(client_version))
		{
			throw new TlsFatalAlert(47);
		}
		mRecordStream.SetWriteVersion(server_version);
		ContextAdmin.SetServerVersion(server_version);
		mTlsClient.NotifyServerVersion(server_version);
		mSecurityParameters.serverRandom = TlsUtilities.ReadFully(32, buf);
		mSelectedSessionID = TlsUtilities.ReadOpaque8(buf);
		if (mSelectedSessionID.Length > 32)
		{
			throw new TlsFatalAlert(47);
		}
		mTlsClient.NotifySessionID(mSelectedSessionID);
		mResumedSession = mSelectedSessionID.Length != 0 && mTlsSession != null && Arrays.AreEqual(mSelectedSessionID, mTlsSession.SessionID);
		int selectedCipherSuite = TlsUtilities.ReadUint16(buf);
		if (!Arrays.Contains(mOfferedCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || CipherSuite.IsScsv(selectedCipherSuite) || !TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, Context.ServerVersion))
		{
			throw new TlsFatalAlert(47);
		}
		mTlsClient.NotifySelectedCipherSuite(selectedCipherSuite);
		byte selectedCompressionMethod = TlsUtilities.ReadUint8(buf);
		if (!Arrays.Contains(mOfferedCompressionMethods, selectedCompressionMethod))
		{
			throw new TlsFatalAlert(47);
		}
		mTlsClient.NotifySelectedCompressionMethod(selectedCompressionMethod);
		mServerExtensions = TlsProtocol.ReadExtensions(buf);
		mSecurityParameters.extendedMasterSecret = !TlsUtilities.IsSsl(mTlsClientContext) && TlsExtensionsUtilities.HasExtendedMasterSecretExtension(mServerExtensions);
		if (!mSecurityParameters.IsExtendedMasterSecret && (mResumedSession || mTlsClient.RequiresExtendedMasterSecret()))
		{
			throw new TlsFatalAlert(40);
		}
		if (mServerExtensions != null)
		{
			foreach (int extType in mServerExtensions.Keys)
			{
				if (extType != 65281)
				{
					if (TlsUtilities.GetExtensionData(mClientExtensions, extType) == null)
					{
						throw new TlsFatalAlert(110);
					}
					_ = mResumedSession;
				}
			}
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(mServerExtensions, 65281);
		if (renegExtData != null)
		{
			mSecureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		mTlsClient.NotifySecureRenegotiation(mSecureRenegotiation);
		IDictionary sessionClientExtensions = mClientExtensions;
		IDictionary sessionServerExtensions = mServerExtensions;
		if (mResumedSession)
		{
			if (selectedCipherSuite != mSessionParameters.CipherSuite || selectedCompressionMethod != mSessionParameters.CompressionAlgorithm)
			{
				throw new TlsFatalAlert(47);
			}
			sessionClientExtensions = null;
			sessionServerExtensions = mSessionParameters.ReadServerExtensions();
		}
		mSecurityParameters.cipherSuite = selectedCipherSuite;
		mSecurityParameters.compressionAlgorithm = selectedCompressionMethod;
		if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
		{
			bool serverSentEncryptThenMAC = TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
			if (serverSentEncryptThenMAC && !TlsUtilities.IsBlockCipherSuite(selectedCipherSuite))
			{
				throw new TlsFatalAlert(47);
			}
			mSecurityParameters.encryptThenMac = serverSentEncryptThenMAC;
			mSecurityParameters.maxFragmentLength = ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
			mSecurityParameters.truncatedHMac = TlsExtensionsUtilities.HasTruncatedHMacExtension(sessionServerExtensions);
			mAllowCertificateStatus = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47);
			mExpectSessionTicket = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47);
		}
		if (sessionClientExtensions != null)
		{
			mTlsClient.ProcessServerExtensions(sessionServerExtensions);
		}
		mSecurityParameters.prfAlgorithm = TlsProtocol.GetPrfAlgorithm(Context, mSecurityParameters.CipherSuite);
		mSecurityParameters.verifyDataLength = 12;
	}

	protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
	{
		HandshakeMessage message = new HandshakeMessage(15);
		certificateVerify.Encode(message);
		message.WriteToRecordStream(this);
	}

	protected virtual void SendClientHelloMessage()
	{
		mRecordStream.SetWriteVersion(mTlsClient.ClientHelloRecordLayerVersion);
		ProtocolVersion client_version = mTlsClient.ClientVersion;
		if (client_version.IsDtls)
		{
			throw new TlsFatalAlert(80);
		}
		ContextAdmin.SetClientVersion(client_version);
		byte[] session_id = TlsUtilities.EmptyBytes;
		if (mTlsSession != null)
		{
			session_id = mTlsSession.SessionID;
			if (session_id == null || session_id.Length > 32)
			{
				session_id = TlsUtilities.EmptyBytes;
			}
		}
		bool isFallback = mTlsClient.IsFallback;
		mOfferedCipherSuites = mTlsClient.GetCipherSuites();
		mOfferedCompressionMethods = mTlsClient.GetCompressionMethods();
		if (session_id.Length != 0 && mSessionParameters != null && (!mSessionParameters.IsExtendedMasterSecret || !Arrays.Contains(mOfferedCipherSuites, mSessionParameters.CipherSuite) || !Arrays.Contains(mOfferedCompressionMethods, mSessionParameters.CompressionAlgorithm)))
		{
			session_id = TlsUtilities.EmptyBytes;
		}
		mClientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(mTlsClient.GetClientExtensions());
		if (!client_version.IsSsl)
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(mClientExtensions);
		}
		HandshakeMessage message = new HandshakeMessage(1);
		TlsUtilities.WriteVersion(client_version, message);
		message.Write(mSecurityParameters.ClientRandom);
		TlsUtilities.WriteOpaque8(session_id, message);
		byte[] renegExtData = TlsUtilities.GetExtensionData(mClientExtensions, 65281);
		bool num = renegExtData == null;
		bool noRenegScsv = !Arrays.Contains(mOfferedCipherSuites, 255);
		if (num && noRenegScsv)
		{
			mOfferedCipherSuites = Arrays.Append(mOfferedCipherSuites, 255);
		}
		if (isFallback && !Arrays.Contains(mOfferedCipherSuites, 22016))
		{
			mOfferedCipherSuites = Arrays.Append(mOfferedCipherSuites, 22016);
		}
		TlsUtilities.WriteUint16ArrayWithUint16Length(mOfferedCipherSuites, message);
		TlsUtilities.WriteUint8ArrayWithUint8Length(mOfferedCompressionMethods, message);
		TlsProtocol.WriteExtensions(message, mClientExtensions);
		message.WriteToRecordStream(this);
	}

	protected virtual void SendClientKeyExchangeMessage()
	{
		HandshakeMessage message = new HandshakeMessage(16);
		mKeyExchange.GenerateClientKeyExchange(message);
		message.WriteToRecordStream(this);
	}
}
