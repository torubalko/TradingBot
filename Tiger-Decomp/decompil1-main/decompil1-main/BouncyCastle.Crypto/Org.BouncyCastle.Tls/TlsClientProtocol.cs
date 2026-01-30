using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class TlsClientProtocol : TlsProtocol
{
	protected TlsClient m_tlsClient;

	internal TlsClientContextImpl m_tlsClientContext;

	protected IDictionary m_clientAgreements;

	internal OfferedPsks.BindersConfig m_clientBinders;

	protected ClientHello m_clientHello;

	protected TlsKeyExchange m_keyExchange;

	protected TlsAuthentication m_authentication;

	protected CertificateStatus m_certificateStatus;

	protected CertificateRequest m_certificateRequest;

	protected override TlsContext Context => m_tlsClientContext;

	internal override AbstractTlsContext ContextAdmin => m_tlsClientContext;

	protected override TlsPeer Peer => m_tlsClient;

	public TlsClientProtocol()
	{
	}

	public TlsClientProtocol(Stream stream)
		: base(stream)
	{
	}

	public TlsClientProtocol(Stream input, Stream output)
		: base(input, output)
	{
	}

	public virtual void Connect(TlsClient tlsClient)
	{
		if (tlsClient == null)
		{
			throw new ArgumentNullException("tlsClient");
		}
		if (m_tlsClient != null)
		{
			throw new InvalidOperationException("'Connect' can only be called once");
		}
		m_tlsClient = tlsClient;
		m_tlsClientContext = new TlsClientContextImpl(tlsClient.Crypto);
		tlsClient.Init(m_tlsClientContext);
		tlsClient.NotifyCloseHandle(this);
		BeginHandshake();
		if (m_blocking)
		{
			BlockForHandshake();
		}
	}

	protected override void BeginHandshake()
	{
		base.BeginHandshake();
		SendClientHello();
		m_connectionState = 1;
	}

	protected override void CleanupHandshake()
	{
		base.CleanupHandshake();
		m_clientAgreements = null;
		m_clientBinders = null;
		m_clientHello = null;
		m_keyExchange = null;
		m_authentication = null;
		m_certificateStatus = null;
		m_certificateRequest = null;
	}

	protected virtual void Handle13HandshakeMessage(short type, HandshakeMessageInput buf)
	{
		if (!IsTlsV13ConnectionState() || m_resumedSession)
		{
			throw new TlsFatalAlert(80);
		}
		switch (type)
		{
		case 11:
		{
			short connectionState = m_connectionState;
			if (connectionState == 5 || connectionState == 11)
			{
				if (m_connectionState != 11)
				{
					Skip13CertificateRequest();
				}
				Receive13ServerCertificate(buf);
				m_connectionState = 7;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 13:
		{
			short connectionState = m_connectionState;
			if (connectionState != 5)
			{
				_ = 21;
				throw new TlsFatalAlert(10);
			}
			Receive13CertificateRequest(buf, postHandshakeAuth: false);
			m_connectionState = 11;
			break;
		}
		case 15:
			if (m_connectionState == 7)
			{
				Receive13ServerCertificateVerify(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 9;
				break;
			}
			throw new TlsFatalAlert(10);
		case 8:
			if (m_connectionState == 4)
			{
				Receive13EncryptedExtensions(buf);
				m_connectionState = 5;
				break;
			}
			throw new TlsFatalAlert(10);
		case 20:
		{
			short connectionState = m_connectionState;
			if (connectionState == 5 || connectionState == 9 || connectionState == 11)
			{
				if (m_connectionState == 5)
				{
					Skip13CertificateRequest();
				}
				if (m_connectionState != 9)
				{
					Skip13ServerCertificate();
				}
				Receive13ServerFinished(buf);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 20;
				byte[] serverFinishedTranscriptHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
				m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: false);
				if (m_certificateRequest != null)
				{
					TlsCredentialedSigner clientCredentials = TlsUtilities.Establish13ClientCredentials(m_authentication, m_certificateRequest);
					Certificate clientCertificate = null;
					if (clientCredentials != null)
					{
						clientCertificate = clientCredentials.Certificate;
					}
					if (clientCertificate == null)
					{
						clientCertificate = Certificate.EmptyChainTls13;
					}
					Send13CertificateMessage(clientCertificate);
					m_connectionState = 15;
					if (clientCredentials != null)
					{
						DigitallySigned certificateVerify = TlsUtilities.Generate13CertificateVerify(m_tlsClientContext, clientCredentials, m_handshakeHash);
						Send13CertificateVerifyMessage(certificateVerify);
						m_connectionState = 17;
					}
				}
				Send13FinishedMessage();
				m_connectionState = 18;
				TlsUtilities.Establish13PhaseApplication(m_tlsClientContext, serverFinishedTranscriptHash, m_recordStream);
				m_recordStream.EnablePendingCipherWrite();
				m_recordStream.EnablePendingCipherRead(deferred: false);
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 24:
			Receive13KeyUpdate(buf);
			break;
		case 4:
			Receive13NewSessionTicket(buf);
			break;
		case 2:
			switch (m_connectionState)
			{
			case 1:
				throw new TlsFatalAlert(80);
			case 3:
			{
				ServerHello serverHello = ReceiveServerHelloMessage(buf);
				if (serverHello.IsHelloRetryRequest())
				{
					throw new TlsFatalAlert(10);
				}
				Process13ServerHello(serverHello, afterHelloRetryRequest: true);
				buf.UpdateHash(m_handshakeHash);
				m_connectionState = 4;
				Process13ServerHelloCoda(serverHello, afterHelloRetryRequest: true);
				break;
			}
			default:
				throw new TlsFatalAlert(10);
			}
			break;
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected override void HandleHandshakeMessage(short type, HandshakeMessageInput buf)
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		if (m_connectionState > 1 && TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
		{
			Handle13HandshakeMessage(type, buf);
			return;
		}
		if (!IsLegacyConnectionState())
		{
			throw new TlsFatalAlert(80);
		}
		if (m_resumedSession)
		{
			if (type != 20 || m_connectionState != 4)
			{
				throw new TlsFatalAlert(10);
			}
			ProcessFinishedMessage(buf);
			buf.UpdateHash(m_handshakeHash);
			m_connectionState = 20;
			SendChangeCipherSpec();
			SendFinishedMessage();
			m_connectionState = 18;
			CompleteHandshake();
			return;
		}
		switch (type)
		{
		case 11:
		{
			short connectionState = m_connectionState;
			if (connectionState == 4 || connectionState == 6)
			{
				if (m_connectionState != 6)
				{
					HandleSupplementalData(null);
				}
				m_authentication = TlsUtilities.ReceiveServerCertificate(m_tlsClientContext, m_tlsClient, buf);
				m_connectionState = 7;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 22:
			if (m_connectionState == 7)
			{
				if (securityParameters.StatusRequestVersion < 1)
				{
					throw new TlsFatalAlert(10);
				}
				m_certificateStatus = CertificateStatus.Parse(m_tlsClientContext, buf);
				TlsProtocol.AssertEmpty(buf);
				m_connectionState = 8;
				break;
			}
			throw new TlsFatalAlert(10);
		case 20:
		{
			short connectionState = m_connectionState;
			if ((uint)(connectionState - 18) <= 1u)
			{
				if (m_connectionState != 19 && m_expectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				ProcessFinishedMessage(buf);
				m_connectionState = 20;
				CompleteHandshake();
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 2:
			if (m_connectionState == 1)
			{
				ServerHello serverHello = ReceiveServerHelloMessage(buf);
				if (serverHello.IsHelloRetryRequest())
				{
					Process13HelloRetryRequest(serverHello);
					m_handshakeHash.NotifyPrfDetermined();
					TlsUtilities.AdjustTranscriptForRetry(m_handshakeHash);
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 2;
					Send13ClientHelloRetry();
					m_handshakeHash.SealHashAlgorithms();
					m_connectionState = 3;
				}
				else
				{
					ProcessServerHello(serverHello);
					m_handshakeHash.NotifyPrfDetermined();
					buf.UpdateHash(m_handshakeHash);
					m_connectionState = 4;
					if (TlsUtilities.IsTlsV13(securityParameters.NegotiatedVersion))
					{
						m_handshakeHash.SealHashAlgorithms();
						Process13ServerHelloCoda(serverHello, afterHelloRetryRequest: false);
					}
				}
				break;
			}
			throw new TlsFatalAlert(10);
		case 23:
			if (m_connectionState == 4)
			{
				HandleSupplementalData(TlsProtocol.ReadSupplementalDataMessage(buf));
				break;
			}
			throw new TlsFatalAlert(10);
		case 14:
			switch (m_connectionState)
			{
			case 4:
			case 6:
			case 7:
			case 8:
			case 10:
			case 11:
			{
				if (m_connectionState == 4)
				{
					HandleSupplementalData(null);
				}
				if (m_connectionState == 4 || m_connectionState == 6)
				{
					m_authentication = null;
				}
				if (m_connectionState != 10 && m_connectionState != 11)
				{
					HandleServerCertificate();
					m_keyExchange.SkipServerKeyExchange();
				}
				TlsProtocol.AssertEmpty(buf);
				m_connectionState = 12;
				IList clientSupplementalData = m_tlsClient.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					SendSupplementalDataMessage(clientSupplementalData);
					m_connectionState = 14;
				}
				TlsCredentialedSigner credentialedSigner = null;
				TlsStreamSigner streamSigner = null;
				if (m_certificateRequest == null)
				{
					m_keyExchange.SkipClientCredentials();
				}
				else
				{
					Certificate clientCertificate = null;
					TlsCredentials clientCredentials = TlsUtilities.EstablishClientCredentials(m_authentication, m_certificateRequest);
					if (clientCredentials == null)
					{
						m_keyExchange.SkipClientCredentials();
					}
					else
					{
						m_keyExchange.ProcessClientCredentials(clientCredentials);
						clientCertificate = clientCredentials.Certificate;
						if (clientCredentials is TlsCredentialedSigner)
						{
							credentialedSigner = (TlsCredentialedSigner)clientCredentials;
							streamSigner = credentialedSigner.GetStreamSigner();
						}
					}
					SendCertificateMessage(clientCertificate, null);
					m_connectionState = 15;
				}
				bool forceBuffering = streamSigner != null;
				TlsUtilities.SealHandshakeHash(m_tlsClientContext, m_handshakeHash, forceBuffering);
				SendClientKeyExchange();
				m_connectionState = 16;
				bool num = TlsUtilities.IsSsl(m_tlsClientContext);
				if (num)
				{
					TlsProtocol.EstablishMasterSecret(m_tlsClientContext, m_keyExchange);
				}
				securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
				if (!num)
				{
					TlsProtocol.EstablishMasterSecret(m_tlsClientContext, m_keyExchange);
				}
				m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsClientContext));
				if (credentialedSigner != null)
				{
					DigitallySigned certificateVerify = TlsUtilities.GenerateCertificateVerifyClient(m_tlsClientContext, credentialedSigner, streamSigner, m_handshakeHash);
					SendCertificateVerifyMessage(certificateVerify);
					m_connectionState = 17;
				}
				m_handshakeHash = m_handshakeHash.StopTracking();
				SendChangeCipherSpec();
				SendFinishedMessage();
				m_connectionState = 18;
				break;
			}
			default:
				throw new TlsFatalAlert(10);
			}
			break;
		case 12:
		{
			short connectionState = m_connectionState;
			if (connectionState == 4 || (uint)(connectionState - 6) <= 2u)
			{
				if (m_connectionState == 4)
				{
					HandleSupplementalData(null);
				}
				if (m_connectionState != 7 && m_connectionState != 8)
				{
					m_authentication = null;
				}
				HandleServerCertificate();
				m_keyExchange.ProcessServerKeyExchange(buf);
				TlsProtocol.AssertEmpty(buf);
				m_connectionState = 10;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 13:
		{
			short connectionState = m_connectionState;
			if ((uint)(connectionState - 7) <= 1u || connectionState == 10)
			{
				if (m_connectionState != 10)
				{
					HandleServerCertificate();
					m_keyExchange.SkipServerKeyExchange();
				}
				ReceiveCertificateRequest(buf);
				TlsUtilities.EstablishServerSigAlgs(securityParameters, m_certificateRequest);
				TlsUtilities.TrackHashAlgorithms(m_handshakeHash, securityParameters.ServerSigAlgs);
				m_connectionState = 11;
				break;
			}
			throw new TlsFatalAlert(10);
		}
		case 4:
			if (m_connectionState == 18)
			{
				if (!m_expectSessionTicket)
				{
					throw new TlsFatalAlert(10);
				}
				securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
				InvalidateSession();
				m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
				ReceiveNewSessionTicket(buf);
				m_connectionState = 19;
				break;
			}
			throw new TlsFatalAlert(10);
		case 0:
			TlsProtocol.AssertEmpty(buf);
			if (base.IsApplicationDataReady)
			{
				RefuseRenegotiation();
			}
			break;
		default:
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void HandleServerCertificate()
	{
		TlsUtilities.ProcessServerCertificate(m_tlsClientContext, m_certificateStatus, m_keyExchange, m_authentication, m_clientExtensions, m_serverExtensions);
	}

	protected virtual void HandleSupplementalData(IList serverSupplementalData)
	{
		m_tlsClient.ProcessServerSupplementalData(serverSupplementalData);
		m_connectionState = 6;
		m_keyExchange = TlsUtilities.InitKeyExchangeClient(m_tlsClientContext, m_tlsClient);
	}

	protected virtual void Process13HelloRetryRequest(ServerHello helloRetryRequest)
	{
		ProtocolVersion legacy_record_version = ProtocolVersion.TLSv12;
		m_recordStream.SetWriteVersion(legacy_record_version);
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion legacy_version = helloRetryRequest.Version;
		byte[] legacy_session_id_echo = helloRetryRequest.SessionID;
		int cipherSuite = helloRetryRequest.CipherSuite;
		if (!ProtocolVersion.TLSv12.Equals(legacy_version) || !Arrays.AreEqual(m_clientHello.SessionID, legacy_session_id_echo) || !TlsUtilities.IsValidCipherSuiteSelection(m_clientHello.CipherSuites, cipherSuite))
		{
			throw new TlsFatalAlert(47);
		}
		IDictionary extensions = helloRetryRequest.Extensions;
		if (extensions == null)
		{
			throw new TlsFatalAlert(47);
		}
		TlsUtilities.CheckExtensionData13(extensions, 6, 47);
		foreach (int extType in extensions.Keys)
		{
			if (44 != extType && TlsUtilities.GetExtensionData(m_clientExtensions, extType) == null)
			{
				throw new TlsFatalAlert(110);
			}
		}
		ProtocolVersion server_version = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
		if (server_version == null)
		{
			throw new TlsFatalAlert(109);
		}
		if (!ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(server_version) || !ProtocolVersion.Contains(m_tlsClientContext.ClientSupportedVersions, server_version) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, server_version))
		{
			throw new TlsFatalAlert(47);
		}
		if (m_clientBinders != null && !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 1))
		{
			m_clientBinders = null;
			m_tlsClient.NotifySelectedPsk(null);
		}
		int selected_group = TlsExtensionsUtilities.GetKeyShareHelloRetryRequest(extensions);
		if (!TlsUtilities.IsValidKeyShareSelection(server_version, securityParameters.ClientSupportedGroups, m_clientAgreements, selected_group))
		{
			throw new TlsFatalAlert(47);
		}
		byte[] cookie = TlsExtensionsUtilities.GetCookieExtension(extensions);
		securityParameters.m_negotiatedVersion = server_version;
		TlsUtilities.NegotiatedVersionTlsClient(m_tlsClientContext, m_tlsClient);
		m_resumedSession = false;
		securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
		m_tlsClient.NotifySessionID(TlsUtilities.EmptyBytes);
		TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
		m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
		m_clientAgreements = null;
		m_retryCookie = cookie;
		m_retryGroup = selected_group;
	}

	protected virtual void Process13ServerHello(ServerHello serverHello, bool afterHelloRetryRequest)
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion legacy_version = serverHello.Version;
		byte[] legacy_session_id_echo = serverHello.SessionID;
		int cipherSuite = serverHello.CipherSuite;
		if (!ProtocolVersion.TLSv12.Equals(legacy_version) || !Arrays.AreEqual(m_clientHello.SessionID, legacy_session_id_echo))
		{
			throw new TlsFatalAlert(47);
		}
		IDictionary extensions = serverHello.Extensions;
		if (extensions == null)
		{
			throw new TlsFatalAlert(47);
		}
		TlsUtilities.CheckExtensionData13(extensions, 2, 47);
		if (afterHelloRetryRequest)
		{
			ProtocolVersion server_version = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(extensions);
			if (server_version == null)
			{
				throw new TlsFatalAlert(109);
			}
			if (!securityParameters.NegotiatedVersion.Equals(server_version) || securityParameters.CipherSuite != cipherSuite)
			{
				throw new TlsFatalAlert(47);
			}
		}
		else
		{
			if (!TlsUtilities.IsValidCipherSuiteSelection(m_clientHello.CipherSuites, cipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
			{
				throw new TlsFatalAlert(47);
			}
			m_resumedSession = false;
			securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
			m_tlsClient.NotifySessionID(TlsUtilities.EmptyBytes);
			TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
			m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
		}
		m_clientHello = null;
		securityParameters.m_serverRandom = serverHello.Random;
		securityParameters.m_secureRenegotiation = false;
		securityParameters.m_extendedMasterSecret = true;
		securityParameters.m_statusRequestVersion = (m_clientExtensions.Contains(5) ? 1 : 0);
		TlsSecret pskEarlySecret = null;
		int selected_identity = TlsExtensionsUtilities.GetPreSharedKeyServerHello(extensions);
		TlsPsk selectedPsk = null;
		if (selected_identity >= 0)
		{
			if (m_clientBinders == null || selected_identity >= m_clientBinders.m_psks.Length)
			{
				throw new TlsFatalAlert(47);
			}
			selectedPsk = m_clientBinders.m_psks[selected_identity];
			if (selectedPsk.PrfAlgorithm != securityParameters.PrfAlgorithm)
			{
				throw new TlsFatalAlert(47);
			}
			pskEarlySecret = m_clientBinders.m_earlySecrets[selected_identity];
			m_selectedPsk13 = true;
		}
		m_tlsClient.NotifySelectedPsk(selectedPsk);
		TlsSecret sharedSecret = null;
		KeyShareEntry keyShareEntry = TlsExtensionsUtilities.GetKeyShareServerHello(extensions);
		if (keyShareEntry == null)
		{
			if (afterHelloRetryRequest || pskEarlySecret == null || !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 0))
			{
				throw new TlsFatalAlert(47);
			}
		}
		else
		{
			if (pskEarlySecret != null && !Arrays.Contains(m_clientBinders.m_pskKeyExchangeModes, 1))
			{
				throw new TlsFatalAlert(47);
			}
			TlsAgreement agreement = (TlsAgreement)m_clientAgreements[keyShareEntry.NamedGroup];
			if (agreement == null)
			{
				throw new TlsFatalAlert(47);
			}
			agreement.ReceivePeerValue(keyShareEntry.KeyExchange);
			sharedSecret = agreement.CalculateSecret();
		}
		m_clientAgreements = null;
		m_clientBinders = null;
		TlsUtilities.Establish13PhaseSecrets(m_tlsClientContext, pskEarlySecret, sharedSecret);
		InvalidateSession();
		m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
	}

	protected virtual void Process13ServerHelloCoda(ServerHello serverHello, bool afterHelloRetryRequest)
	{
		byte[] serverHelloTranscriptHash = TlsUtilities.GetCurrentPrfHash(m_handshakeHash);
		TlsUtilities.Establish13PhaseHandshake(m_tlsClientContext, serverHelloTranscriptHash, m_recordStream);
		if (!afterHelloRetryRequest)
		{
			m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: true);
			SendChangeCipherSpecMessage();
		}
		m_recordStream.EnablePendingCipherWrite();
		m_recordStream.EnablePendingCipherRead(deferred: false);
	}

	protected virtual void ProcessServerHello(ServerHello serverHello)
	{
		IDictionary serverHelloExtensions = serverHello.Extensions;
		ProtocolVersion legacy_version = serverHello.Version;
		ProtocolVersion supported_version = TlsExtensionsUtilities.GetSupportedVersionsExtensionServer(serverHelloExtensions);
		ProtocolVersion server_version;
		if (supported_version == null)
		{
			server_version = legacy_version;
		}
		else
		{
			if (!ProtocolVersion.TLSv12.Equals(legacy_version) || !ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(supported_version))
			{
				throw new TlsFatalAlert(47);
			}
			server_version = supported_version;
		}
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		if (!ProtocolVersion.Contains(m_tlsClientContext.ClientSupportedVersions, server_version))
		{
			throw new TlsFatalAlert(70);
		}
		ProtocolVersion legacy_record_version = (server_version.IsLaterVersionOf(ProtocolVersion.TLSv12) ? ProtocolVersion.TLSv12 : server_version);
		m_recordStream.SetWriteVersion(legacy_record_version);
		securityParameters.m_negotiatedVersion = server_version;
		TlsUtilities.NegotiatedVersionTlsClient(m_tlsClientContext, m_tlsClient);
		if (ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(server_version))
		{
			Process13ServerHello(serverHello, afterHelloRetryRequest: false);
			return;
		}
		int[] cipherSuites = m_clientHello.CipherSuites;
		m_clientHello = null;
		m_retryCookie = null;
		m_retryGroup = -1;
		securityParameters.m_serverRandom = serverHello.Random;
		if (!m_tlsClientContext.ClientVersion.Equals(server_version))
		{
			TlsUtilities.CheckDowngradeMarker(server_version, securityParameters.ServerRandom);
		}
		byte[] selectedSessionID = (securityParameters.m_sessionID = serverHello.SessionID);
		m_tlsClient.NotifySessionID(selectedSessionID);
		m_resumedSession = selectedSessionID.Length != 0 && m_tlsSession != null && Arrays.AreEqual(selectedSessionID, m_tlsSession.SessionID);
		int cipherSuite = serverHello.CipherSuite;
		if (!TlsUtilities.IsValidCipherSuiteSelection(cipherSuites, cipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
		{
			throw new TlsFatalAlert(47);
		}
		TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
		m_tlsClient.NotifySelectedCipherSuite(cipherSuite);
		m_serverExtensions = serverHelloExtensions;
		if (m_serverExtensions != null)
		{
			foreach (int extType in m_serverExtensions.Keys)
			{
				if (65281 != extType)
				{
					if (TlsUtilities.GetExtensionData(m_clientExtensions, extType) == null)
					{
						throw new TlsFatalAlert(110);
					}
					_ = m_resumedSession;
				}
			}
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(m_serverExtensions, 65281);
		if (renegExtData == null)
		{
			securityParameters.m_secureRenegotiation = false;
		}
		else
		{
			securityParameters.m_secureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		m_tlsClient.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
		bool acceptedExtendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(m_serverExtensions);
		if (acceptedExtendedMasterSecret)
		{
			if (server_version.IsSsl || (!m_resumedSession && !m_tlsClient.ShouldUseExtendedMasterSecret()))
			{
				throw new TlsFatalAlert(40);
			}
		}
		else if (m_tlsClient.RequiresExtendedMasterSecret() || (m_resumedSession && !m_tlsClient.AllowLegacyResumption()))
		{
			throw new TlsFatalAlert(40);
		}
		securityParameters.m_extendedMasterSecret = acceptedExtendedMasterSecret;
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(m_serverExtensions);
		securityParameters.m_applicationProtocolSet = true;
		IDictionary sessionClientExtensions = m_clientExtensions;
		IDictionary sessionServerExtensions = m_serverExtensions;
		if (m_resumedSession)
		{
			if (securityParameters.CipherSuite != m_sessionParameters.CipherSuite || !server_version.Equals(m_sessionParameters.NegotiatedVersion))
			{
				throw new TlsFatalAlert(47);
			}
			sessionClientExtensions = null;
			sessionServerExtensions = m_sessionParameters.ReadServerExtensions();
		}
		if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
		{
			bool serverSentEncryptThenMAC = TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
			if (serverSentEncryptThenMAC && !TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
			{
				throw new TlsFatalAlert(47);
			}
			securityParameters.m_encryptThenMac = serverSentEncryptThenMAC;
			securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
			securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(sessionServerExtensions);
			if (!m_resumedSession)
			{
				if (TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 17, 47))
				{
					securityParameters.m_statusRequestVersion = 2;
				}
				else if (TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47))
				{
					securityParameters.m_statusRequestVersion = 1;
				}
				m_expectSessionTicket = TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47);
			}
		}
		if (sessionClientExtensions != null)
		{
			m_tlsClient.ProcessServerExtensions(sessionServerExtensions);
		}
		ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
		if (m_resumedSession)
		{
			securityParameters.m_masterSecret = m_sessionMasterSecret;
			m_recordStream.SetPendingCipher(TlsUtilities.InitCipher(m_tlsClientContext));
		}
		else
		{
			InvalidateSession();
			m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
		}
	}

	protected virtual void Receive13CertificateRequest(MemoryStream buf, bool postHandshakeAuth)
	{
		if (postHandshakeAuth)
		{
			throw new TlsFatalAlert(80);
		}
		if (m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		CertificateRequest certificateRequest = CertificateRequest.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		if (!certificateRequest.HasCertificateRequestContext(TlsUtilities.EmptyBytes))
		{
			throw new TlsFatalAlert(47);
		}
		m_certificateRequest = certificateRequest;
		TlsUtilities.EstablishServerSigAlgs(m_tlsClientContext.SecurityParameters, certificateRequest);
	}

	protected virtual void Receive13EncryptedExtensions(MemoryStream buf)
	{
		byte[] extBytes = TlsUtilities.ReadOpaque16(buf);
		TlsProtocol.AssertEmpty(buf);
		m_serverExtensions = TlsProtocol.ReadExtensionsData13(8, extBytes);
		foreach (int extType in m_serverExtensions.Keys)
		{
			if (TlsUtilities.GetExtensionData(m_clientExtensions, extType) == null)
			{
				throw new TlsFatalAlert(110);
			}
		}
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(m_serverExtensions);
		securityParameters.m_applicationProtocolSet = true;
		IDictionary sessionClientExtensions = m_clientExtensions;
		IDictionary sessionServerExtensions = m_serverExtensions;
		if (m_resumedSession)
		{
			if (securityParameters.CipherSuite != m_sessionParameters.CipherSuite || !negotiatedVersion.Equals(m_sessionParameters.NegotiatedVersion))
			{
				throw new TlsFatalAlert(47);
			}
			sessionClientExtensions = null;
			sessionServerExtensions = m_sessionParameters.ReadServerExtensions();
		}
		securityParameters.m_maxFragmentLength = ProcessMaxFragmentLengthExtension(sessionClientExtensions, sessionServerExtensions, 47);
		securityParameters.m_encryptThenMac = false;
		securityParameters.m_truncatedHmac = false;
		securityParameters.m_statusRequestVersion = (m_clientExtensions.Contains(5) ? 1 : 0);
		m_expectSessionTicket = false;
		if (sessionClientExtensions != null)
		{
			m_tlsClient.ProcessServerExtensions(m_serverExtensions);
		}
		ApplyMaxFragmentLengthExtension(securityParameters.MaxFragmentLength);
	}

	protected virtual void Receive13NewSessionTicket(MemoryStream buf)
	{
		if (!base.IsApplicationDataReady)
		{
			throw new TlsFatalAlert(10);
		}
		TlsUtilities.ReadUint32(buf);
		TlsUtilities.ReadUint32(buf);
		TlsUtilities.ReadOpaque8(buf);
		TlsUtilities.ReadOpaque16(buf);
		TlsUtilities.ReadOpaque16(buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual void Receive13ServerCertificate(MemoryStream buf)
	{
		if (m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		m_authentication = TlsUtilities.Receive13ServerCertificate(m_tlsClientContext, m_tlsClient, buf);
		HandleServerCertificate();
	}

	protected virtual void Receive13ServerCertificateVerify(MemoryStream buf)
	{
		Certificate serverCertificate = m_tlsClientContext.SecurityParameters.PeerCertificate;
		if (serverCertificate == null || serverCertificate.IsEmpty)
		{
			throw new TlsFatalAlert(80);
		}
		DigitallySigned certificateVerify = DigitallySigned.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		TlsUtilities.Verify13CertificateVerifyServer(m_tlsClientContext, certificateVerify, m_handshakeHash);
	}

	protected virtual void Receive13ServerFinished(MemoryStream buf)
	{
		Process13FinishedMessage(buf);
	}

	protected virtual void ReceiveCertificateRequest(MemoryStream buf)
	{
		if (m_authentication == null)
		{
			throw new TlsFatalAlert(40);
		}
		CertificateRequest certificateRequest = CertificateRequest.Parse(m_tlsClientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		m_certificateRequest = TlsUtilities.ValidateCertificateRequest(certificateRequest, m_keyExchange);
	}

	protected virtual void ReceiveNewSessionTicket(MemoryStream buf)
	{
		NewSessionTicket newSessionTicket = NewSessionTicket.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
		m_tlsClient.NotifyNewSessionTicket(newSessionTicket);
	}

	protected virtual ServerHello ReceiveServerHelloMessage(MemoryStream buf)
	{
		return ServerHello.Parse(buf);
	}

	protected virtual void Send13ClientHelloRetry()
	{
		IDictionary clientHelloExtensions = m_clientHello.Extensions;
		clientHelloExtensions.Remove(44);
		clientHelloExtensions.Remove(42);
		clientHelloExtensions.Remove(51);
		clientHelloExtensions.Remove(41);
		if (m_retryCookie != null)
		{
			TlsExtensionsUtilities.AddCookieExtension(clientHelloExtensions, m_retryCookie);
			m_retryCookie = null;
		}
		if (m_clientBinders != null)
		{
			m_clientBinders = TlsUtilities.AddPreSharedKeyToClientHelloRetry(m_tlsClientContext, m_clientBinders, clientHelloExtensions);
			if (m_clientBinders == null)
			{
				m_tlsClient.NotifySelectedPsk(null);
			}
		}
		if (m_retryGroup < 0)
		{
			throw new TlsFatalAlert(80);
		}
		m_clientAgreements = TlsUtilities.AddKeyShareToClientHelloRetry(m_tlsClientContext, clientHelloExtensions, m_retryGroup);
		m_recordStream.SetIgnoreChangeCipherSpec(ignoreChangeCipherSpec: true);
		SendChangeCipherSpecMessage();
		SendClientHelloMessage();
	}

	protected virtual void SendCertificateVerifyMessage(DigitallySigned certificateVerify)
	{
		HandshakeMessageOutput message = new HandshakeMessageOutput(15);
		certificateVerify.Encode(message);
		message.Send(this);
	}

	protected virtual void SendClientHello()
	{
		SecurityParameters securityParameters = m_tlsClientContext.SecurityParameters;
		ProtocolVersion[] supportedVersions = m_tlsClient.GetProtocolVersions();
		if (ProtocolVersion.Contains(supportedVersions, ProtocolVersion.SSLv3))
		{
			m_recordStream.SetWriteVersion(ProtocolVersion.SSLv3);
		}
		else
		{
			m_recordStream.SetWriteVersion(ProtocolVersion.TLSv10);
		}
		ProtocolVersion earliestVersion = ProtocolVersion.GetEarliestTls(supportedVersions);
		ProtocolVersion latestVersion = ProtocolVersion.GetLatestTls(supportedVersions);
		if (!ProtocolVersion.IsSupportedTlsVersionClient(latestVersion))
		{
			throw new TlsFatalAlert(80);
		}
		m_tlsClientContext.SetClientVersion(latestVersion);
		m_tlsClientContext.SetClientSupportedVersions(supportedVersions);
		bool offeringTlsV12Minus = ProtocolVersion.TLSv12.IsEqualOrLaterVersionOf(earliestVersion);
		bool offeringTlsV13Plus = ProtocolVersion.TLSv13.IsEqualOrEarlierVersionOf(latestVersion);
		EstablishSession(offeringTlsV12Minus ? m_tlsClient.GetSessionToResume() : null);
		m_tlsClient.NotifySessionToResume(m_tlsSession);
		byte[] legacy_session_id = TlsUtilities.GetSessionID(m_tlsSession);
		bool num = m_tlsClient.IsFallback();
		int[] offeredCipherSuites = m_tlsClient.GetCipherSuites();
		if (legacy_session_id.Length != 0 && m_sessionParameters != null && !Arrays.Contains(offeredCipherSuites, m_sessionParameters.CipherSuite))
		{
			legacy_session_id = TlsUtilities.EmptyBytes;
		}
		m_clientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(m_tlsClient.GetClientExtensions());
		ProtocolVersion legacy_version = latestVersion;
		if (offeringTlsV13Plus)
		{
			legacy_version = ProtocolVersion.TLSv12;
			TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(m_clientExtensions, supportedVersions);
			if (legacy_session_id.Length < 1)
			{
				legacy_session_id = m_tlsClientContext.NonceGenerator.GenerateNonce(32);
			}
		}
		m_tlsClientContext.SetRsaPreMasterSecretVersion(legacy_version);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(m_clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(latestVersion))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, m_clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(m_clientExtensions);
		m_clientBinders = TlsUtilities.AddPreSharedKeyToClientHello(m_tlsClientContext, m_tlsClient, m_clientExtensions, offeredCipherSuites);
		m_clientAgreements = TlsUtilities.AddKeyShareToClientHello(m_tlsClientContext, m_tlsClient, m_clientExtensions);
		if (TlsUtilities.IsExtendedMasterSecretOptionalTls(supportedVersions) && (m_tlsClient.ShouldUseExtendedMasterSecret() || (m_sessionParameters != null && m_sessionParameters.IsExtendedMasterSecret)))
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(m_clientExtensions);
		}
		else if (!offeringTlsV13Plus && m_tlsClient.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(80);
		}
		bool useGmtUnixTime = !offeringTlsV13Plus && m_tlsClient.ShouldUseGmtUnixTime();
		securityParameters.m_clientRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, m_tlsClientContext);
		bool num2 = TlsUtilities.GetExtensionData(m_clientExtensions, 65281) == null;
		bool noRenegScsv = !Arrays.Contains(offeredCipherSuites, 255);
		if (num2 && noRenegScsv)
		{
			offeredCipherSuites = Arrays.Append(offeredCipherSuites, 255);
		}
		if (num && !Arrays.Contains(offeredCipherSuites, 22016))
		{
			offeredCipherSuites = Arrays.Append(offeredCipherSuites, 22016);
		}
		int bindersSize = ((m_clientBinders != null) ? m_clientBinders.m_bindersSize : 0);
		m_clientHello = new ClientHello(legacy_version, securityParameters.ClientRandom, legacy_session_id, null, offeredCipherSuites, m_clientExtensions, bindersSize);
		SendClientHelloMessage();
	}

	protected virtual void SendClientHelloMessage()
	{
		HandshakeMessageOutput message = new HandshakeMessageOutput(1);
		m_clientHello.Encode(m_tlsClientContext, message);
		message.PrepareClientHello(m_handshakeHash, m_clientHello.BindersSize);
		if (m_clientBinders != null)
		{
			OfferedPsks.EncodeBinders(message, m_tlsClientContext.Crypto, m_handshakeHash, m_clientBinders);
		}
		message.SendClientHello(this, m_handshakeHash, m_clientHello.BindersSize);
	}

	protected virtual void SendClientKeyExchange()
	{
		HandshakeMessageOutput message = new HandshakeMessageOutput(16);
		m_keyExchange.GenerateClientKeyExchange(message);
		message.Send(this);
	}

	protected virtual void Skip13CertificateRequest()
	{
		m_certificateRequest = null;
	}

	protected virtual void Skip13ServerCertificate()
	{
		if (!m_selectedPsk13)
		{
			throw new TlsFatalAlert(10);
		}
		m_authentication = TlsUtilities.Skip13ServerCertificate(m_tlsClientContext);
	}
}
