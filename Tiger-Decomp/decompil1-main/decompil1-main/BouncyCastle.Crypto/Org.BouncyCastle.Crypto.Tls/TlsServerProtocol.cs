using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class TlsServerProtocol : TlsProtocol
{
	protected TlsServer mTlsServer;

	internal TlsServerContextImpl mTlsServerContext;

	protected TlsKeyExchange mKeyExchange;

	protected TlsCredentials mServerCredentials;

	protected CertificateRequest mCertificateRequest;

	protected short mClientCertificateType = -1;

	protected TlsHandshakeHash mPrepareFinishHash;

	protected override TlsContext Context => mTlsServerContext;

	internal override AbstractTlsContext ContextAdmin => mTlsServerContext;

	protected override TlsPeer Peer => mTlsServer;

	public TlsServerProtocol(Stream stream, SecureRandom secureRandom)
		: base(stream, secureRandom)
	{
	}

	public TlsServerProtocol(Stream input, Stream output, SecureRandom secureRandom)
		: base(input, output, secureRandom)
	{
	}

	public TlsServerProtocol(SecureRandom secureRandom)
		: base(secureRandom)
	{
	}

	public virtual void Accept(TlsServer tlsServer)
	{
		if (tlsServer == null)
		{
			throw new ArgumentNullException("tlsServer");
		}
		if (mTlsServer != null)
		{
			throw new InvalidOperationException("'Accept' can only be called once");
		}
		mTlsServer = tlsServer;
		mSecurityParameters = new SecurityParameters();
		mSecurityParameters.entity = 0;
		mTlsServerContext = new TlsServerContextImpl(mSecureRandom, mSecurityParameters);
		mSecurityParameters.serverRandom = TlsProtocol.CreateRandomBlock(tlsServer.ShouldUseGmtUnixTime(), mTlsServerContext.NonceRandomGenerator);
		mTlsServer.Init(mTlsServerContext);
		mRecordStream.Init(mTlsServerContext);
		tlsServer.NotifyCloseHandle(this);
		mRecordStream.SetRestrictReadVersion(enabled: false);
		BlockForHandshake();
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		mKeyExchange = null;
		mServerCredentials = null;
		mCertificateRequest = null;
		mPrepareFinishHash = null;
	}

	protected override void HandleHandshakeMessage(byte type, MemoryStream buf)
	{
		switch (type)
		{
		case 1:
			switch (mConnectionState)
			{
			case 0:
			{
				ReceiveClientHelloMessage(buf);
				mConnectionState = 1;
				SendServerHelloMessage();
				mConnectionState = 2;
				mRecordStream.NotifyHelloComplete();
				IList serverSupplementalData = mTlsServer.GetServerSupplementalData();
				if (serverSupplementalData != null)
				{
					SendSupplementalDataMessage(serverSupplementalData);
				}
				mConnectionState = 3;
				mKeyExchange = mTlsServer.GetKeyExchange();
				mKeyExchange.Init(Context);
				mServerCredentials = mTlsServer.GetCredentials();
				Certificate serverCertificate = null;
				if (mServerCredentials == null)
				{
					mKeyExchange.SkipServerCredentials();
				}
				else
				{
					mKeyExchange.ProcessServerCredentials(mServerCredentials);
					serverCertificate = mServerCredentials.Certificate;
					SendCertificateMessage(serverCertificate);
				}
				mConnectionState = 4;
				if (serverCertificate == null || serverCertificate.IsEmpty)
				{
					mAllowCertificateStatus = false;
				}
				if (mAllowCertificateStatus)
				{
					CertificateStatus certificateStatus = mTlsServer.GetCertificateStatus();
					if (certificateStatus != null)
					{
						SendCertificateStatusMessage(certificateStatus);
					}
				}
				mConnectionState = 5;
				byte[] serverKeyExchange = mKeyExchange.GenerateServerKeyExchange();
				if (serverKeyExchange != null)
				{
					SendServerKeyExchangeMessage(serverKeyExchange);
				}
				mConnectionState = 6;
				if (mServerCredentials != null)
				{
					mCertificateRequest = mTlsServer.GetCertificateRequest();
					if (mCertificateRequest != null)
					{
						if (TlsUtilities.IsTlsV12(Context) != (mCertificateRequest.SupportedSignatureAlgorithms != null))
						{
							throw new TlsFatalAlert(80);
						}
						mKeyExchange.ValidateCertificateRequest(mCertificateRequest);
						SendCertificateRequestMessage(mCertificateRequest);
						TlsUtilities.TrackHashAlgorithms(mRecordStream.HandshakeHash, mCertificateRequest.SupportedSignatureAlgorithms);
					}
				}
				mConnectionState = 7;
				SendServerHelloDoneMessage();
				mConnectionState = 8;
				mRecordStream.HandshakeHash.SealHashAlgorithms();
				break;
			}
			case 16:
				RefuseRenegotiation();
				break;
			default:
				throw new TlsFatalAlert(10);
			}
			break;
		case 23:
			if (mConnectionState == 8)
			{
				mTlsServer.ProcessClientSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
				mConnectionState = 9;
				break;
			}
			throw new TlsFatalAlert(10);
		case 11:
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 1u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				if (mCertificateRequest == null)
				{
					throw new TlsFatalAlert(10);
				}
				ReceiveCertificateMessage(buf);
				mConnectionState = 10;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 16:
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 2u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				if (mConnectionState < 10)
				{
					if (mCertificateRequest == null)
					{
						mKeyExchange.SkipClientCredentials();
					}
					else
					{
						if (TlsUtilities.IsTlsV12(Context))
						{
							throw new TlsFatalAlert(10);
						}
						if (TlsUtilities.IsSsl(Context))
						{
							if (mPeerCertificate == null)
							{
								throw new TlsFatalAlert(10);
							}
						}
						else
						{
							NotifyClientCertificate(Certificate.EmptyChain);
						}
					}
				}
				ReceiveClientKeyExchangeMessage(buf);
				mConnectionState = 11;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 15:
			if (mConnectionState == 11)
			{
				if (!ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ReceiveCertificateVerifyMessage(buf);
				mConnectionState = 12;
				break;
			}
			throw new TlsFatalAlert(10);
		case 20:
		{
			short num = mConnectionState;
			if ((uint)(num - 11) <= 1u)
			{
				if (mConnectionState < 12 && ExpectCertificateVerifyMessage())
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				mConnectionState = 13;
				if (mExpectSessionTicket)
				{
					SendNewSessionTicketMessage(mTlsServer.GetNewSessionTicket());
				}
				mConnectionState = 14;
				SendChangeCipherSpecMessage();
				SendFinishedMessage();
				mConnectionState = 15;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected override void HandleAlertWarningMessage(byte alertDescription)
	{
		if (41 == alertDescription && mCertificateRequest != null && TlsUtilities.IsSsl(mTlsServerContext))
		{
			short num = mConnectionState;
			if ((uint)(num - 8) <= 1u)
			{
				if (mConnectionState < 9)
				{
					mTlsServer.ProcessClientSupplementalData(null);
				}
				NotifyClientCertificate(Certificate.EmptyChain);
				mConnectionState = 10;
				return;
			}
		}
		base.HandleAlertWarningMessage(alertDescription);
	}

	protected virtual void NotifyClientCertificate(Certificate clientCertificate)
	{
		if (mCertificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		if (mPeerCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		mPeerCertificate = clientCertificate;
		if (clientCertificate.IsEmpty)
		{
			mKeyExchange.SkipClientCredentials();
		}
		else
		{
			mClientCertificateType = TlsUtilities.GetClientCertificateType(clientCertificate, mServerCredentials.Certificate);
			mKeyExchange.ProcessClientCertificate(clientCertificate);
		}
		mTlsServer.NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ReceiveCertificateMessage(MemoryStream buf)
	{
		Certificate clientCertificate = Certificate.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
		NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ReceiveCertificateVerifyMessage(MemoryStream buf)
	{
		if (mCertificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		DigitallySigned clientCertificateVerify = DigitallySigned.Parse(Context, buf);
		TlsProtocol.AssertEmpty(buf);
		try
		{
			SignatureAndHashAlgorithm signatureAlgorithm = clientCertificateVerify.Algorithm;
			byte[] hash;
			if (TlsUtilities.IsTlsV12(Context))
			{
				TlsUtilities.VerifySupportedSignatureAlgorithm(mCertificateRequest.SupportedSignatureAlgorithms, signatureAlgorithm);
				hash = mPrepareFinishHash.GetFinalHash(signatureAlgorithm.Hash);
			}
			else
			{
				hash = mSecurityParameters.SessionHash;
			}
			AsymmetricKeyParameter publicKey = PublicKeyFactory.CreateKey(mPeerCertificate.GetCertificateAt(0).SubjectPublicKeyInfo);
			TlsSigner tlsSigner = TlsUtilities.CreateTlsSigner((byte)mClientCertificateType);
			tlsSigner.Init(Context);
			if (!tlsSigner.VerifyRawSignature(signatureAlgorithm, clientCertificateVerify.Signature, publicKey, hash))
			{
				throw new TlsFatalAlert(51);
			}
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			throw tlsFatalAlert;
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(51, alertCause);
		}
	}

	protected virtual void ReceiveClientHelloMessage(MemoryStream buf)
	{
		ProtocolVersion client_version = TlsUtilities.ReadVersion(buf);
		mRecordStream.SetWriteVersion(client_version);
		if (client_version.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		byte[] client_random = TlsUtilities.ReadFully(32, buf);
		if (TlsUtilities.ReadOpaque8(buf).Length > 32)
		{
			throw new TlsFatalAlert(47);
		}
		int cipher_suites_length = TlsUtilities.ReadUint16(buf);
		if (cipher_suites_length < 2 || (cipher_suites_length & 1) != 0)
		{
			throw new TlsFatalAlert(50);
		}
		mOfferedCipherSuites = TlsUtilities.ReadUint16Array(cipher_suites_length / 2, buf);
		int compression_methods_length = TlsUtilities.ReadUint8(buf);
		if (compression_methods_length < 1)
		{
			throw new TlsFatalAlert(47);
		}
		mOfferedCompressionMethods = TlsUtilities.ReadUint8Array(compression_methods_length, buf);
		mClientExtensions = TlsProtocol.ReadExtensions(buf);
		mSecurityParameters.extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(mClientExtensions);
		if (!mSecurityParameters.IsExtendedMasterSecret && mTlsServer.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(40);
		}
		ContextAdmin.SetClientVersion(client_version);
		mTlsServer.NotifyClientVersion(client_version);
		mTlsServer.NotifyFallback(Arrays.Contains(mOfferedCipherSuites, 22016));
		mSecurityParameters.clientRandom = client_random;
		mTlsServer.NotifyOfferedCipherSuites(mOfferedCipherSuites);
		mTlsServer.NotifyOfferedCompressionMethods(mOfferedCompressionMethods);
		if (Arrays.Contains(mOfferedCipherSuites, 255))
		{
			mSecureRenegotiation = true;
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(mClientExtensions, 65281);
		if (renegExtData != null)
		{
			mSecureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		mTlsServer.NotifySecureRenegotiation(mSecureRenegotiation);
		if (mClientExtensions != null)
		{
			TlsExtensionsUtilities.GetPaddingExtension(mClientExtensions);
			mTlsServer.ProcessClientExtensions(mClientExtensions);
		}
	}

	protected virtual void ReceiveClientKeyExchangeMessage(MemoryStream buf)
	{
		mKeyExchange.ProcessClientKeyExchange(buf);
		TlsProtocol.AssertEmpty(buf);
		if (TlsUtilities.IsSsl(Context))
		{
			TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
		}
		mPrepareFinishHash = mRecordStream.PrepareToFinish();
		mSecurityParameters.sessionHash = TlsProtocol.GetCurrentPrfHash(Context, mPrepareFinishHash, null);
		if (!TlsUtilities.IsSsl(Context))
		{
			TlsProtocol.EstablishMasterSecret(Context, mKeyExchange);
		}
		mRecordStream.SetPendingConnectionState(Peer.GetCompression(), Peer.GetCipher());
	}

	protected virtual void SendCertificateRequestMessage(CertificateRequest certificateRequest)
	{
		HandshakeMessage message = new HandshakeMessage(13);
		certificateRequest.Encode(message);
		message.WriteToRecordStream(this);
	}

	protected virtual void SendCertificateStatusMessage(CertificateStatus certificateStatus)
	{
		HandshakeMessage message = new HandshakeMessage(22);
		certificateStatus.Encode(message);
		message.WriteToRecordStream(this);
	}

	protected virtual void SendNewSessionTicketMessage(NewSessionTicket newSessionTicket)
	{
		if (newSessionTicket == null)
		{
			throw new TlsFatalAlert(80);
		}
		HandshakeMessage message = new HandshakeMessage(4);
		newSessionTicket.Encode(message);
		message.WriteToRecordStream(this);
	}

	protected virtual void SendServerHelloMessage()
	{
		HandshakeMessage message = new HandshakeMessage(2);
		ProtocolVersion server_version = mTlsServer.GetServerVersion();
		if (!server_version.IsEqualOrEarlierVersionOf(Context.ClientVersion))
		{
			throw new TlsFatalAlert(80);
		}
		mRecordStream.ReadVersion = server_version;
		mRecordStream.SetWriteVersion(server_version);
		mRecordStream.SetRestrictReadVersion(enabled: true);
		ContextAdmin.SetServerVersion(server_version);
		TlsUtilities.WriteVersion(server_version, message);
		message.Write(mSecurityParameters.serverRandom);
		TlsUtilities.WriteOpaque8(TlsUtilities.EmptyBytes, message);
		int selectedCipherSuite = mTlsServer.GetSelectedCipherSuite();
		if (!Arrays.Contains(mOfferedCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || CipherSuite.IsScsv(selectedCipherSuite) || !TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, Context.ServerVersion))
		{
			throw new TlsFatalAlert(80);
		}
		mSecurityParameters.cipherSuite = selectedCipherSuite;
		byte selectedCompressionMethod = mTlsServer.GetSelectedCompressionMethod();
		if (!Arrays.Contains(mOfferedCompressionMethods, selectedCompressionMethod))
		{
			throw new TlsFatalAlert(80);
		}
		mSecurityParameters.compressionAlgorithm = selectedCompressionMethod;
		TlsUtilities.WriteUint16(selectedCipherSuite, message);
		TlsUtilities.WriteUint8(selectedCompressionMethod, message);
		mServerExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(mTlsServer.GetServerExtensions());
		if (mSecureRenegotiation)
		{
			byte[] renegExtData = TlsUtilities.GetExtensionData(mServerExtensions, 65281);
			if (renegExtData == null)
			{
				mServerExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
			}
		}
		if (TlsUtilities.IsSsl(mTlsServerContext))
		{
			mSecurityParameters.extendedMasterSecret = false;
		}
		else if (mSecurityParameters.IsExtendedMasterSecret)
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(mServerExtensions);
		}
		if (mServerExtensions.Count > 0)
		{
			mSecurityParameters.encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(mServerExtensions);
			mSecurityParameters.maxFragmentLength = ProcessMaxFragmentLengthExtension(mClientExtensions, mServerExtensions, 80);
			mSecurityParameters.truncatedHMac = TlsExtensionsUtilities.HasTruncatedHMacExtension(mServerExtensions);
			mAllowCertificateStatus = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(mServerExtensions, 5, 80);
			mExpectSessionTicket = !mResumedSession && TlsUtilities.HasExpectedEmptyExtensionData(mServerExtensions, 35, 80);
			TlsProtocol.WriteExtensions(message, mServerExtensions);
		}
		mSecurityParameters.prfAlgorithm = TlsProtocol.GetPrfAlgorithm(Context, mSecurityParameters.CipherSuite);
		mSecurityParameters.verifyDataLength = 12;
		ApplyMaxFragmentLengthExtension();
		message.WriteToRecordStream(this);
	}

	protected virtual void SendServerHelloDoneMessage()
	{
		byte[] message = new byte[4];
		TlsUtilities.WriteUint8(14, message, 0);
		TlsUtilities.WriteUint24(0, message, 1);
		WriteHandshakeMessage(message, 0, message.Length);
	}

	protected virtual void SendServerKeyExchangeMessage(byte[] serverKeyExchange)
	{
		HandshakeMessage handshakeMessage = new HandshakeMessage(12, serverKeyExchange.Length);
		handshakeMessage.Write(serverKeyExchange);
		handshakeMessage.WriteToRecordStream(this);
	}

	protected virtual bool ExpectCertificateVerifyMessage()
	{
		if (mClientCertificateType >= 0)
		{
			return TlsUtilities.HasSigningCapability((byte)mClientCertificateType);
		}
		return false;
	}
}
