using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public class DtlsClientProtocol : DtlsProtocol
{
	protected internal class ClientHandshakeState
	{
		internal TlsClient client;

		internal TlsClientContextImpl clientContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal bool resumedSession;

		internal bool expectSessionTicket;

		internal IDictionary clientAgreements;

		internal TlsKeyExchange keyExchange;

		internal TlsAuthentication authentication;

		internal CertificateStatus certificateStatus;

		internal CertificateRequest certificateRequest;

		internal TlsCredentials clientCredentials;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy = 2;
	}

	public virtual DtlsTransport Connect(TlsClient client, DatagramTransport transport)
	{
		if (client == null)
		{
			throw new ArgumentNullException("client");
		}
		if (transport == null)
		{
			throw new ArgumentNullException("transport");
		}
		ClientHandshakeState state = new ClientHandshakeState();
		state.client = client;
		state.clientContext = new TlsClientContextImpl(client.Crypto);
		client.Init(state.clientContext);
		state.clientContext.HandshakeBeginning(client);
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		securityParameters.m_extendedPadding = client.ShouldUseExtendedPadding();
		TlsSession sessionToResume = state.client.GetSessionToResume();
		if (sessionToResume != null && sessionToResume.IsResumable)
		{
			SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters != null && (sessionParameters.IsExtendedMasterSecret || (!state.client.RequiresExtendedMasterSecret() && state.client.AllowLegacyResumption())))
			{
				TlsSecret masterSecret = sessionParameters.MasterSecret;
				lock (masterSecret)
				{
					if (masterSecret.IsAlive())
					{
						state.tlsSession = sessionToResume;
						state.sessionParameters = sessionParameters;
						state.sessionMasterSecret = state.clientContext.Crypto.AdoptSecret(masterSecret);
					}
				}
			}
		}
		DtlsRecordLayer recordLayer = new DtlsRecordLayer(state.clientContext, state.client, transport);
		client.NotifyCloseHandle(recordLayer);
		try
		{
			return ClientHandshake(state, recordLayer);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			AbortClientHandshake(state, recordLayer, tlsFatalAlert.AlertDescription);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			AbortClientHandshake(state, recordLayer, 80);
			throw ex;
		}
		catch (Exception alertCause)
		{
			AbortClientHandshake(state, recordLayer, 80);
			throw new TlsFatalAlert(80, alertCause);
		}
		finally
		{
			securityParameters.Clear();
		}
	}

	internal virtual void AbortClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer)
	{
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		DtlsReliableHandshake handshake = new DtlsReliableHandshake(state.clientContext, recordLayer, state.client.GetHandshakeTimeoutMillis(), null);
		byte[] clientHelloBody = GenerateClientHello(state);
		recordLayer.SetWriteVersion(ProtocolVersion.DTLSv10);
		handshake.SendMessage(1, clientHelloBody);
		DtlsReliableHandshake.Message serverMessage = handshake.ReceiveMessage();
		while (serverMessage.Type == 3)
		{
			byte[] cookie = ProcessHelloVerifyRequest(state, serverMessage.Body);
			byte[] patched = PatchClientHelloWithCookie(clientHelloBody, cookie);
			handshake.ResetAfterHelloVerifyRequestClient();
			handshake.SendMessage(1, patched);
			serverMessage = handshake.ReceiveMessage();
		}
		if (serverMessage.Type == 2)
		{
			ProtocolVersion recordLayerVersion = recordLayer.ReadVersion;
			ReportServerVersion(state, recordLayerVersion);
			recordLayer.SetWriteVersion(recordLayerVersion);
			ProcessServerHello(state, serverMessage.Body);
			handshake.HandshakeHash.NotifyPrfDetermined();
			DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
			if (state.resumedSession)
			{
				securityParameters.m_masterSecret = state.sessionMasterSecret;
				recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.clientContext));
				securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, isServer: true);
				ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, isServer: false);
				handshake.SendMessage(20, securityParameters.LocalVerifyData);
				handshake.Finish();
				if (securityParameters.IsExtendedMasterSecret)
				{
					securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
				}
				securityParameters.m_localCertificate = state.sessionParameters.LocalCertificate;
				securityParameters.m_peerCertificate = state.sessionParameters.PeerCertificate;
				securityParameters.m_pskIdentity = state.sessionParameters.PskIdentity;
				securityParameters.m_srpIdentity = state.sessionParameters.SrpIdentity;
				state.clientContext.HandshakeComplete(state.client, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new DtlsTransport(recordLayer);
			}
			InvalidateSession(state);
			state.tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
			serverMessage = handshake.ReceiveMessage();
			if (serverMessage.Type == 23)
			{
				ProcessServerSupplementalData(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.client.ProcessServerSupplementalData(null);
			}
			state.keyExchange = TlsUtilities.InitKeyExchangeClient(state.clientContext, state.client);
			if (serverMessage.Type == 11)
			{
				ProcessServerCertificate(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.authentication = null;
			}
			if (serverMessage.Type == 22)
			{
				if (securityParameters.StatusRequestVersion < 1)
				{
					throw new TlsFatalAlert(10);
				}
				ProcessCertificateStatus(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			TlsUtilities.ProcessServerCertificate(state.clientContext, state.certificateStatus, state.keyExchange, state.authentication, state.clientExtensions, state.serverExtensions);
			if (serverMessage.Type == 12)
			{
				ProcessServerKeyExchange(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.keyExchange.SkipServerKeyExchange();
			}
			if (serverMessage.Type == 13)
			{
				ProcessCertificateRequest(state, serverMessage.Body);
				TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
				TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, securityParameters.ServerSigAlgs);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type == 14)
			{
				if (serverMessage.Body.Length != 0)
				{
					throw new TlsFatalAlert(50);
				}
				IList clientSupplementalData = state.client.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					byte[] supplementalDataBody = DtlsProtocol.GenerateSupplementalData(clientSupplementalData);
					handshake.SendMessage(23, supplementalDataBody);
				}
				if (state.certificateRequest != null)
				{
					state.clientCredentials = TlsUtilities.EstablishClientCredentials(state.authentication, state.certificateRequest);
					Certificate clientCertificate = null;
					if (state.clientCredentials != null)
					{
						clientCertificate = state.clientCredentials.Certificate;
					}
					DtlsProtocol.SendCertificateMessage(state.clientContext, handshake, clientCertificate, null);
				}
				TlsCredentialedSigner credentialedSigner = null;
				TlsStreamSigner streamSigner = null;
				if (state.clientCredentials != null)
				{
					state.keyExchange.ProcessClientCredentials(state.clientCredentials);
					if (state.clientCredentials is TlsCredentialedSigner)
					{
						credentialedSigner = (TlsCredentialedSigner)state.clientCredentials;
						streamSigner = credentialedSigner.GetStreamSigner();
					}
				}
				else
				{
					state.keyExchange.SkipClientCredentials();
				}
				bool forceBuffering = streamSigner != null;
				TlsUtilities.SealHandshakeHash(state.clientContext, handshake.HandshakeHash, forceBuffering);
				byte[] clientKeyExchangeBody = GenerateClientKeyExchange(state);
				handshake.SendMessage(16, clientKeyExchangeBody);
				securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(handshake.HandshakeHash);
				TlsProtocol.EstablishMasterSecret(state.clientContext, state.keyExchange);
				recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.clientContext));
				if (credentialedSigner != null)
				{
					DigitallySigned certificateVerify = TlsUtilities.GenerateCertificateVerifyClient(state.clientContext, credentialedSigner, streamSigner, handshake.HandshakeHash);
					byte[] certificateVerifyBody = GenerateCertificateVerify(state, certificateVerify);
					handshake.SendMessage(15, certificateVerifyBody);
				}
				handshake.PrepareToFinish();
				securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, isServer: false);
				handshake.SendMessage(20, securityParameters.LocalVerifyData);
				if (state.expectSessionTicket)
				{
					serverMessage = handshake.ReceiveMessage();
					if (serverMessage.Type != 4)
					{
						throw new TlsFatalAlert(10);
					}
					securityParameters.m_sessionID = TlsUtilities.EmptyBytes;
					InvalidateSession(state);
					state.tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, null);
					ProcessNewSessionTicket(state, serverMessage.Body);
				}
				securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, handshake.HandshakeHash, isServer: true);
				ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
				handshake.Finish();
				state.sessionMasterSecret = securityParameters.MasterSecret;
				state.sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
					.SetMasterSecret(state.clientContext.Crypto.AdoptSecret(state.sessionMasterSecret))
					.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
					.SetPeerCertificate(securityParameters.PeerCertificate)
					.SetPskIdentity(securityParameters.PskIdentity)
					.SetSrpIdentity(securityParameters.SrpIdentity)
					.SetServerExtensions(state.serverExtensions)
					.Build();
				state.tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, state.sessionParameters);
				securityParameters.m_tlsUnique = securityParameters.LocalVerifyData;
				state.clientContext.HandshakeComplete(state.client, state.tlsSession);
				recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
				return new DtlsTransport(recordLayer);
			}
			throw new TlsFatalAlert(10);
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual byte[] GenerateCertificateVerify(ClientHandshakeState state, DigitallySigned certificateVerify)
	{
		MemoryStream buf = new MemoryStream();
		certificateVerify.Encode(buf);
		return buf.ToArray();
	}

	protected virtual byte[] GenerateClientHello(ClientHandshakeState state)
	{
		TlsClientContextImpl context = state.clientContext;
		SecurityParameters securityParameters = context.SecurityParameters;
		context.SetClientSupportedVersions(state.client.GetProtocolVersions());
		ProtocolVersion client_version = ProtocolVersion.GetLatestDtls(context.ClientSupportedVersions);
		if (!ProtocolVersion.IsSupportedDtlsVersionClient(client_version))
		{
			throw new TlsFatalAlert(80);
		}
		context.SetClientVersion(client_version);
		byte[] session_id = TlsUtilities.GetSessionID(state.tlsSession);
		bool num = state.client.IsFallback();
		state.offeredCipherSuites = state.client.GetCipherSuites();
		if (session_id.Length != 0 && state.sessionParameters != null && !Arrays.Contains(state.offeredCipherSuites, state.sessionParameters.CipherSuite))
		{
			session_id = TlsUtilities.EmptyBytes;
		}
		state.clientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(state.client.GetClientExtensions());
		ProtocolVersion legacy_version = client_version;
		if (client_version.IsLaterVersionOf(ProtocolVersion.DTLSv12))
		{
			legacy_version = ProtocolVersion.DTLSv12;
			TlsExtensionsUtilities.AddSupportedVersionsExtensionClient(state.clientExtensions, context.ClientSupportedVersions);
		}
		context.SetRsaPreMasterSecretVersion(legacy_version);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(client_version))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
		state.clientAgreements = TlsUtilities.AddKeyShareToClientHello(state.clientContext, state.client, state.clientExtensions);
		if (TlsUtilities.IsExtendedMasterSecretOptionalDtls(context.ClientSupportedVersions) && state.client.ShouldUseExtendedMasterSecret())
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.clientExtensions);
		}
		else if (!TlsUtilities.IsTlsV13(client_version) && state.client.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(80);
		}
		bool useGmtUnixTime = ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(client_version) && state.client.ShouldUseGmtUnixTime();
		securityParameters.m_clientRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, state.clientContext);
		bool num2 = TlsUtilities.GetExtensionData(state.clientExtensions, 65281) == null;
		bool noRenegScsv = !Arrays.Contains(state.offeredCipherSuites, 255);
		if (num2 && noRenegScsv)
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 255);
		}
		if (num && !Arrays.Contains(state.offeredCipherSuites, 22016))
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 22016);
		}
		state.heartbeat = state.client.GetHeartbeat();
		state.heartbeatPolicy = state.client.GetHeartbeatPolicy();
		if (state.heartbeat != null || 1 == state.heartbeatPolicy)
		{
			TlsExtensionsUtilities.AddHeartbeatExtension(state.clientExtensions, new HeartbeatExtension(state.heartbeatPolicy));
		}
		ClientHello clientHello = new ClientHello(legacy_version, securityParameters.ClientRandom, session_id, TlsUtilities.EmptyBytes, state.offeredCipherSuites, state.clientExtensions, 0);
		MemoryStream buf = new MemoryStream();
		clientHello.Encode(state.clientContext, buf);
		return buf.ToArray();
	}

	protected virtual byte[] GenerateClientKeyExchange(ClientHandshakeState state)
	{
		MemoryStream buf = new MemoryStream();
		state.keyExchange.GenerateClientKeyExchange(buf);
		return buf.ToArray();
	}

	protected virtual void InvalidateSession(ClientHandshakeState state)
	{
		if (state.sessionMasterSecret != null)
		{
			state.sessionMasterSecret.Destroy();
			state.sessionMasterSecret = null;
		}
		if (state.sessionParameters != null)
		{
			state.sessionParameters.Clear();
			state.sessionParameters = null;
		}
		if (state.tlsSession != null)
		{
			state.tlsSession.Invalidate();
			state.tlsSession = null;
		}
	}

	protected virtual void ProcessCertificateRequest(ClientHandshakeState state, byte[] body)
	{
		if (state.authentication == null)
		{
			throw new TlsFatalAlert(40);
		}
		MemoryStream buf = new MemoryStream(body, writable: false);
		CertificateRequest certificateRequest = CertificateRequest.Parse(state.clientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		state.certificateRequest = TlsUtilities.ValidateCertificateRequest(certificateRequest, state.keyExchange);
	}

	protected virtual void ProcessCertificateStatus(ClientHandshakeState state, byte[] body)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		state.certificateStatus = CertificateStatus.Parse(state.clientContext, buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual byte[] ProcessHelloVerifyRequest(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		ProtocolVersion server_version = TlsUtilities.ReadVersion(memoryStream);
		int maxCookieLength = (ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(server_version) ? 255 : 32);
		byte[] cookie = TlsUtilities.ReadOpaque8(memoryStream, 0, maxCookieLength);
		TlsProtocol.AssertEmpty(memoryStream);
		if (!server_version.IsEqualOrEarlierVersionOf(state.clientContext.ClientVersion))
		{
			throw new TlsFatalAlert(47);
		}
		return cookie;
	}

	protected virtual void ProcessNewSessionTicket(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		NewSessionTicket newSessionTicket = NewSessionTicket.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		state.client.NotifyNewSessionTicket(newSessionTicket);
	}

	protected virtual void ProcessServerCertificate(ClientHandshakeState state, byte[] body)
	{
		state.authentication = TlsUtilities.ReceiveServerCertificate(state.clientContext, state.client, new MemoryStream(body, writable: false));
	}

	protected virtual void ProcessServerHello(ClientHandshakeState state, byte[] body)
	{
		ServerHello serverHello = ServerHello.Parse(new MemoryStream(body, writable: false));
		ProtocolVersion server_version = serverHello.Version;
		state.serverExtensions = serverHello.Extensions;
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		ReportServerVersion(state, server_version);
		securityParameters.m_serverRandom = serverHello.Random;
		if (!state.clientContext.ClientVersion.Equals(server_version))
		{
			TlsUtilities.CheckDowngradeMarker(server_version, securityParameters.ServerRandom);
		}
		byte[] selectedSessionID = (securityParameters.m_sessionID = serverHello.SessionID);
		state.client.NotifySessionID(selectedSessionID);
		state.resumedSession = selectedSessionID.Length != 0 && state.tlsSession != null && Arrays.AreEqual(selectedSessionID, state.tlsSession.SessionID);
		int cipherSuite = DtlsProtocol.ValidateSelectedCipherSuite(serverHello.CipherSuite, 47);
		if (!TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, cipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
		{
			throw new TlsFatalAlert(47);
		}
		TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
		state.client.NotifySelectedCipherSuite(cipherSuite);
		if (TlsUtilities.IsTlsV13(server_version))
		{
			securityParameters.m_extendedMasterSecret = true;
		}
		else
		{
			bool acceptedExtendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.serverExtensions);
			if (acceptedExtendedMasterSecret)
			{
				if (!state.resumedSession && !state.client.ShouldUseExtendedMasterSecret())
				{
					throw new TlsFatalAlert(40);
				}
			}
			else if (state.client.RequiresExtendedMasterSecret() || (state.resumedSession && !state.client.AllowLegacyResumption()))
			{
				throw new TlsFatalAlert(40);
			}
			securityParameters.m_extendedMasterSecret = acceptedExtendedMasterSecret;
		}
		if (state.serverExtensions != null)
		{
			foreach (int extType in state.serverExtensions.Keys)
			{
				if (extType != 65281)
				{
					if (TlsUtilities.GetExtensionData(state.clientExtensions, extType) == null)
					{
						throw new TlsFatalAlert(110);
					}
					_ = state.resumedSession;
				}
			}
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
		if (renegExtData != null)
		{
			securityParameters.m_secureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		state.client.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
		securityParameters.m_applicationProtocolSet = true;
		HeartbeatExtension heartbeatExtension = TlsExtensionsUtilities.GetHeartbeatExtension(state.serverExtensions);
		if (heartbeatExtension == null)
		{
			state.heartbeat = null;
			state.heartbeatPolicy = 2;
		}
		else if (1 != heartbeatExtension.Mode)
		{
			state.heartbeat = null;
		}
		IDictionary sessionClientExtensions = state.clientExtensions;
		IDictionary sessionServerExtensions = state.serverExtensions;
		if (state.resumedSession)
		{
			if (securityParameters.CipherSuite != state.sessionParameters.CipherSuite || !server_version.Equals(state.sessionParameters.NegotiatedVersion))
			{
				throw new TlsFatalAlert(47);
			}
			sessionClientExtensions = null;
			sessionServerExtensions = state.sessionParameters.ReadServerExtensions();
		}
		if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
		{
			bool serverSentEncryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
			if (serverSentEncryptThenMac && !TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
			{
				throw new TlsFatalAlert(47);
			}
			securityParameters.m_encryptThenMac = serverSentEncryptThenMac;
			securityParameters.m_maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, sessionClientExtensions, sessionServerExtensions, 47);
			securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(sessionServerExtensions);
			if (!state.resumedSession)
			{
				if (TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 17, 47))
				{
					securityParameters.m_statusRequestVersion = 2;
				}
				else if (TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47))
				{
					securityParameters.m_statusRequestVersion = 1;
				}
			}
			state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47);
		}
		if (sessionClientExtensions != null)
		{
			state.client.ProcessServerExtensions(sessionServerExtensions);
		}
	}

	protected virtual void ProcessServerKeyExchange(ClientHandshakeState state, byte[] body)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		state.keyExchange.ProcessServerKeyExchange(buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual void ProcessServerSupplementalData(ClientHandshakeState state, byte[] body)
	{
		IList serverSupplementalData = TlsProtocol.ReadSupplementalDataMessage(new MemoryStream(body, writable: false));
		state.client.ProcessServerSupplementalData(serverSupplementalData);
	}

	protected virtual void ReportServerVersion(ClientHandshakeState state, ProtocolVersion server_version)
	{
		TlsClientContextImpl context = state.clientContext;
		SecurityParameters securityParameters = context.SecurityParameters;
		ProtocolVersion currentServerVersion = securityParameters.NegotiatedVersion;
		if (currentServerVersion != null)
		{
			if (!currentServerVersion.Equals(server_version))
			{
				throw new TlsFatalAlert(47);
			}
			return;
		}
		if (!ProtocolVersion.Contains(context.ClientSupportedVersions, server_version))
		{
			throw new TlsFatalAlert(70);
		}
		securityParameters.m_negotiatedVersion = server_version;
		TlsUtilities.NegotiatedVersionDtlsClient(state.clientContext, state.client);
	}

	protected static byte[] PatchClientHelloWithCookie(byte[] clientHelloBody, byte[] cookie)
	{
		int sessionIDPos = 34;
		int sessionIDLength = TlsUtilities.ReadUint8(clientHelloBody, sessionIDPos);
		int cookieLengthPos = sessionIDPos + 1 + sessionIDLength;
		int cookiePos = cookieLengthPos + 1;
		byte[] patched = new byte[clientHelloBody.Length + cookie.Length];
		Array.Copy(clientHelloBody, 0, patched, 0, cookieLengthPos);
		TlsUtilities.CheckUint8(cookie.Length);
		TlsUtilities.WriteUint8(cookie.Length, patched, cookieLengthPos);
		Array.Copy(cookie, 0, patched, cookiePos, cookie.Length);
		Array.Copy(clientHelloBody, cookiePos, patched, cookiePos + cookie.Length, clientHelloBody.Length - cookiePos);
		return patched;
	}
}
