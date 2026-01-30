using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public class DtlsServerProtocol : DtlsProtocol
{
	protected internal class ServerHandshakeState
	{
		internal TlsServer server;

		internal TlsServerContextImpl serverContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal TlsSecret sessionMasterSecret;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal bool offeredExtendedMasterSecret;

		internal bool resumedSession;

		internal bool expectSessionTicket;

		internal TlsKeyExchange keyExchange;

		internal TlsCredentials serverCredentials;

		internal CertificateRequest certificateRequest;

		internal TlsHeartbeat heartbeat;

		internal short heartbeatPolicy = 2;
	}

	protected bool m_verifyRequests = true;

	public virtual bool VerifyRequests
	{
		get
		{
			return m_verifyRequests;
		}
		set
		{
			m_verifyRequests = value;
		}
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport)
	{
		return Accept(server, transport, null);
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport, DtlsRequest request)
	{
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		if (transport == null)
		{
			throw new ArgumentNullException("transport");
		}
		ServerHandshakeState state = new ServerHandshakeState();
		state.server = server;
		state.serverContext = new TlsServerContextImpl(server.Crypto);
		server.Init(state.serverContext);
		state.serverContext.HandshakeBeginning(server);
		SecurityParameters securityParameters = state.serverContext.SecurityParameters;
		securityParameters.m_extendedPadding = server.ShouldUseExtendedPadding();
		DtlsRecordLayer recordLayer = new DtlsRecordLayer(state.serverContext, state.server, transport);
		server.NotifyCloseHandle(recordLayer);
		try
		{
			return ServerHandshake(state, recordLayer, request);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			AbortServerHandshake(state, recordLayer, tlsFatalAlert.AlertDescription);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			AbortServerHandshake(state, recordLayer, 80);
			throw ex;
		}
		catch (Exception alertCause)
		{
			AbortServerHandshake(state, recordLayer, 80);
			throw new TlsFatalAlert(80, alertCause);
		}
		finally
		{
			securityParameters.Clear();
		}
	}

	internal virtual void AbortServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, short alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, DtlsRequest request)
	{
		SecurityParameters securityParameters = state.serverContext.SecurityParameters;
		DtlsReliableHandshake handshake = new DtlsReliableHandshake(state.serverContext, recordLayer, state.server.GetHandshakeTimeoutMillis(), request);
		DtlsReliableHandshake.Message clientMessage = null;
		if (request == null)
		{
			clientMessage = handshake.ReceiveMessage();
			if (clientMessage.Type != 1)
			{
				throw new TlsFatalAlert(10);
			}
			ProcessClientHello(state, clientMessage.Body);
		}
		else
		{
			ProcessClientHello(state, request.ClientHello);
		}
		state.tlsSession = TlsUtilities.ImportSession(TlsUtilities.EmptyBytes, null);
		state.sessionParameters = null;
		state.sessionMasterSecret = null;
		securityParameters.m_sessionID = state.tlsSession.SessionID;
		state.server.NotifySession(state.tlsSession);
		byte[] serverHelloBody = GenerateServerHello(state, recordLayer);
		ProtocolVersion recordLayerVersion = (recordLayer.ReadVersion = state.serverContext.ServerVersion);
		recordLayer.SetWriteVersion(recordLayerVersion);
		handshake.SendMessage(2, serverHelloBody);
		handshake.HandshakeHash.NotifyPrfDetermined();
		IList serverSupplementalData = state.server.GetServerSupplementalData();
		if (serverSupplementalData != null)
		{
			byte[] supplementalDataBody = DtlsProtocol.GenerateSupplementalData(serverSupplementalData);
			handshake.SendMessage(23, supplementalDataBody);
		}
		state.keyExchange = TlsUtilities.InitKeyExchangeServer(state.serverContext, state.server);
		state.serverCredentials = TlsUtilities.EstablishServerCredentials(state.server);
		Certificate serverCertificate = null;
		MemoryStream endPointHash = new MemoryStream();
		if (state.serverCredentials == null)
		{
			state.keyExchange.SkipServerCredentials();
		}
		else
		{
			state.keyExchange.ProcessServerCredentials(state.serverCredentials);
			serverCertificate = state.serverCredentials.Certificate;
			DtlsProtocol.SendCertificateMessage(state.serverContext, handshake, serverCertificate, endPointHash);
		}
		securityParameters.m_tlsServerEndPoint = endPointHash.ToArray();
		if (serverCertificate == null || serverCertificate.IsEmpty)
		{
			securityParameters.m_statusRequestVersion = 0;
		}
		if (securityParameters.StatusRequestVersion > 0)
		{
			CertificateStatus certificateStatus = state.server.GetCertificateStatus();
			if (certificateStatus != null)
			{
				byte[] certificateStatusBody = GenerateCertificateStatus(state, certificateStatus);
				handshake.SendMessage(22, certificateStatusBody);
			}
		}
		byte[] serverKeyExchange = state.keyExchange.GenerateServerKeyExchange();
		if (serverKeyExchange != null)
		{
			handshake.SendMessage(12, serverKeyExchange);
		}
		if (state.serverCredentials != null)
		{
			state.certificateRequest = state.server.GetCertificateRequest();
			if (state.certificateRequest == null)
			{
				if (!state.keyExchange.RequiresCertificateVerify)
				{
					throw new TlsFatalAlert(80);
				}
			}
			else
			{
				if (TlsUtilities.IsTlsV12(state.serverContext) != (state.certificateRequest.SupportedSignatureAlgorithms != null))
				{
					throw new TlsFatalAlert(80);
				}
				state.certificateRequest = TlsUtilities.ValidateCertificateRequest(state.certificateRequest, state.keyExchange);
				TlsUtilities.EstablishServerSigAlgs(securityParameters, state.certificateRequest);
				TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, securityParameters.ServerSigAlgs);
				byte[] certificateRequestBody = GenerateCertificateRequest(state, state.certificateRequest);
				handshake.SendMessage(13, certificateRequestBody);
			}
		}
		handshake.SendMessage(14, TlsUtilities.EmptyBytes);
		bool forceBuffering = false;
		TlsUtilities.SealHandshakeHash(state.serverContext, handshake.HandshakeHash, forceBuffering);
		clientMessage = handshake.ReceiveMessage();
		if (clientMessage.Type == 23)
		{
			ProcessClientSupplementalData(state, clientMessage.Body);
			clientMessage = handshake.ReceiveMessage();
		}
		else
		{
			state.server.ProcessClientSupplementalData(null);
		}
		if (state.certificateRequest == null)
		{
			state.keyExchange.SkipClientCredentials();
		}
		else if (clientMessage.Type == 11)
		{
			ProcessClientCertificate(state, clientMessage.Body);
			clientMessage = handshake.ReceiveMessage();
		}
		else
		{
			if (TlsUtilities.IsTlsV12(state.serverContext))
			{
				throw new TlsFatalAlert(10);
			}
			NotifyClientCertificate(state, Certificate.EmptyChain);
		}
		if (clientMessage.Type == 16)
		{
			ProcessClientKeyExchange(state, clientMessage.Body);
			securityParameters.m_sessionHash = TlsUtilities.GetCurrentPrfHash(handshake.HandshakeHash);
			TlsProtocol.EstablishMasterSecret(state.serverContext, state.keyExchange);
			recordLayer.InitPendingEpoch(TlsUtilities.InitCipher(state.serverContext));
			TlsHandshakeHash certificateVerifyHash = handshake.PrepareToFinish();
			if (ExpectCertificateVerifyMessage(state))
			{
				byte[] certificateVerifyBody = handshake.ReceiveMessageBody(15);
				ProcessCertificateVerify(state, certificateVerifyBody, certificateVerifyHash);
			}
			securityParameters.m_peerVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, handshake.HandshakeHash, isServer: false);
			ProcessFinished(handshake.ReceiveMessageBody(20), securityParameters.PeerVerifyData);
			if (state.expectSessionTicket)
			{
				NewSessionTicket newSessionTicket = state.server.GetNewSessionTicket();
				byte[] newSessionTicketBody = GenerateNewSessionTicket(state, newSessionTicket);
				handshake.SendMessage(4, newSessionTicketBody);
			}
			securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, handshake.HandshakeHash, isServer: true);
			handshake.SendMessage(20, securityParameters.LocalVerifyData);
			handshake.Finish();
			state.sessionMasterSecret = securityParameters.MasterSecret;
			state.sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
				.SetMasterSecret(state.serverContext.Crypto.AdoptSecret(state.sessionMasterSecret))
				.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
				.SetPeerCertificate(securityParameters.PeerCertificate)
				.SetPskIdentity(securityParameters.PskIdentity)
				.SetSrpIdentity(securityParameters.SrpIdentity)
				.SetServerExtensions(state.serverExtensions)
				.Build();
			state.tlsSession = TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
			securityParameters.m_tlsUnique = securityParameters.PeerVerifyData;
			state.serverContext.HandshakeComplete(state.server, state.tlsSession);
			recordLayer.InitHeartbeat(state.heartbeat, 1 == state.heartbeatPolicy);
			return new DtlsTransport(recordLayer);
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual byte[] GenerateCertificateRequest(ServerHandshakeState state, CertificateRequest certificateRequest)
	{
		MemoryStream buf = new MemoryStream();
		certificateRequest.Encode(state.serverContext, buf);
		return buf.ToArray();
	}

	protected virtual byte[] GenerateCertificateStatus(ServerHandshakeState state, CertificateStatus certificateStatus)
	{
		MemoryStream buf = new MemoryStream();
		certificateStatus.Encode(buf);
		return buf.ToArray();
	}

	protected virtual byte[] GenerateNewSessionTicket(ServerHandshakeState state, NewSessionTicket newSessionTicket)
	{
		MemoryStream buf = new MemoryStream();
		newSessionTicket.Encode(buf);
		return buf.ToArray();
	}

	internal virtual byte[] GenerateServerHello(ServerHandshakeState state, DtlsRecordLayer recordLayer)
	{
		TlsServerContextImpl context = state.serverContext;
		SecurityParameters securityParameters = context.SecurityParameters;
		ProtocolVersion server_version = state.server.GetServerVersion();
		if (!ProtocolVersion.Contains(context.ClientSupportedVersions, server_version))
		{
			throw new TlsFatalAlert(80);
		}
		securityParameters.m_negotiatedVersion = server_version;
		TlsUtilities.NegotiatedVersionDtlsServer(context);
		bool useGmtUnixTime = ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(server_version) && state.server.ShouldUseGmtUnixTime();
		securityParameters.m_serverRandom = TlsProtocol.CreateRandomBlock(useGmtUnixTime, context);
		if (!server_version.Equals(ProtocolVersion.GetLatestDtls(state.server.GetProtocolVersions())))
		{
			TlsUtilities.WriteDowngradeMarker(server_version, securityParameters.ServerRandom);
		}
		int cipherSuite = DtlsProtocol.ValidateSelectedCipherSuite(state.server.GetSelectedCipherSuite(), 80);
		if (!TlsUtilities.IsValidCipherSuiteSelection(state.offeredCipherSuites, cipherSuite) || !TlsUtilities.IsValidVersionForCipherSuite(cipherSuite, securityParameters.NegotiatedVersion))
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.NegotiatedCipherSuite(securityParameters, cipherSuite);
		state.serverExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(state.server.GetServerExtensions());
		state.server.GetServerExtensionsForConnection(state.serverExtensions);
		ProtocolVersion legacy_version = server_version;
		if (server_version.IsLaterVersionOf(ProtocolVersion.DTLSv12))
		{
			legacy_version = ProtocolVersion.DTLSv12;
			TlsExtensionsUtilities.AddSupportedVersionsExtensionServer(state.serverExtensions, server_version);
		}
		if (securityParameters.IsSecureRenegotiation)
		{
			byte[] renegExtData = TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
			if (renegExtData == null)
			{
				state.serverExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
			}
		}
		if (TlsUtilities.IsTlsV13(server_version))
		{
			securityParameters.m_extendedMasterSecret = true;
		}
		else
		{
			securityParameters.m_extendedMasterSecret = state.offeredExtendedMasterSecret && state.server.ShouldUseExtendedMasterSecret();
			if (securityParameters.IsExtendedMasterSecret)
			{
				TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.serverExtensions);
			}
			else
			{
				if (state.server.RequiresExtendedMasterSecret())
				{
					throw new TlsFatalAlert(40);
				}
				if (state.resumedSession && !state.server.AllowLegacyResumption())
				{
					throw new TlsFatalAlert(80);
				}
			}
		}
		if (state.heartbeat != null || 1 == state.heartbeatPolicy)
		{
			TlsExtensionsUtilities.AddHeartbeatExtension(state.serverExtensions, new HeartbeatExtension(state.heartbeatPolicy));
		}
		securityParameters.m_applicationProtocol = TlsExtensionsUtilities.GetAlpnExtensionServer(state.serverExtensions);
		securityParameters.m_applicationProtocolSet = true;
		if (state.serverExtensions.Count > 0)
		{
			securityParameters.m_encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(state.serverExtensions);
			securityParameters.m_maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, state.clientExtensions, state.serverExtensions, 80);
			securityParameters.m_truncatedHmac = TlsExtensionsUtilities.HasTruncatedHmacExtension(state.serverExtensions);
			if (!state.resumedSession)
			{
				if (TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 17, 80))
				{
					securityParameters.m_statusRequestVersion = 2;
				}
				else if (TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 5, 80))
				{
					securityParameters.m_statusRequestVersion = 1;
				}
			}
			state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 35, 80);
		}
		DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.MaxFragmentLength);
		ServerHello serverHello = new ServerHello(legacy_version, securityParameters.ServerRandom, state.tlsSession.SessionID, securityParameters.CipherSuite, state.serverExtensions);
		MemoryStream buf = new MemoryStream();
		serverHello.Encode(state.serverContext, buf);
		return buf.ToArray();
	}

	protected virtual void InvalidateSession(ServerHandshakeState state)
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

	protected virtual void NotifyClientCertificate(ServerHandshakeState state, Certificate clientCertificate)
	{
		if (state.certificateRequest == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsUtilities.ProcessClientCertificate(state.serverContext, clientCertificate, state.keyExchange, state.server);
	}

	protected virtual void ProcessClientCertificate(ServerHandshakeState state, byte[] body)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		Certificate clientCertificate = Certificate.Parse(new Certificate.ParseOptions().SetMaxChainLength(state.server.GetMaxCertificateChainLength()), state.serverContext, buf, null);
		TlsProtocol.AssertEmpty(buf);
		NotifyClientCertificate(state, clientCertificate);
	}

	protected virtual void ProcessCertificateVerify(ServerHandshakeState state, byte[] body, TlsHandshakeHash handshakeHash)
	{
		if (state.certificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		MemoryStream buf = new MemoryStream(body, writable: false);
		TlsServerContextImpl serverContext = state.serverContext;
		DigitallySigned certificateVerify = DigitallySigned.Parse(serverContext, buf);
		TlsProtocol.AssertEmpty(buf);
		TlsUtilities.VerifyCertificateVerifyClient(serverContext, state.certificateRequest, certificateVerify, handshakeHash);
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, byte[] body)
	{
		ClientHello clientHello = ClientHello.Parse(new MemoryStream(body, writable: false), new NullOutputStream());
		ProcessClientHello(state, clientHello);
	}

	protected virtual void ProcessClientHello(ServerHandshakeState state, ClientHello clientHello)
	{
		ProtocolVersion legacy_version = clientHello.Version;
		state.offeredCipherSuites = clientHello.CipherSuites;
		state.clientExtensions = clientHello.Extensions;
		TlsServerContextImpl context = state.serverContext;
		SecurityParameters securityParameters = context.SecurityParameters;
		if (!legacy_version.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		context.SetRsaPreMasterSecretVersion(legacy_version);
		context.SetClientSupportedVersions(TlsExtensionsUtilities.GetSupportedVersionsExtensionClient(state.clientExtensions));
		ProtocolVersion client_version = legacy_version;
		if (context.ClientSupportedVersions == null)
		{
			if (client_version.IsLaterVersionOf(ProtocolVersion.DTLSv12))
			{
				client_version = ProtocolVersion.DTLSv12;
			}
			context.SetClientSupportedVersions(client_version.DownTo(ProtocolVersion.DTLSv10));
		}
		else
		{
			client_version = ProtocolVersion.GetLatestDtls(context.ClientSupportedVersions);
		}
		if (!ProtocolVersion.SERVER_EARLIEST_SUPPORTED_DTLS.IsEqualOrEarlierVersionOf(client_version))
		{
			throw new TlsFatalAlert(70);
		}
		context.SetClientVersion(client_version);
		state.server.NotifyClientVersion(context.ClientVersion);
		securityParameters.m_clientRandom = clientHello.Random;
		state.server.NotifyFallback(Arrays.Contains(state.offeredCipherSuites, 22016));
		state.server.NotifyOfferedCipherSuites(state.offeredCipherSuites);
		if (Arrays.Contains(state.offeredCipherSuites, 255))
		{
			securityParameters.m_secureRenegotiation = true;
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
		if (renegExtData != null)
		{
			securityParameters.m_secureRenegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		state.server.NotifySecureRenegotiation(securityParameters.IsSecureRenegotiation);
		state.offeredExtendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.clientExtensions);
		if (state.clientExtensions == null)
		{
			return;
		}
		TlsExtensionsUtilities.GetPaddingExtension(state.clientExtensions);
		securityParameters.m_clientServerNames = TlsExtensionsUtilities.GetServerNameExtensionClient(state.clientExtensions);
		if (TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(client_version))
		{
			TlsUtilities.EstablishClientSigAlgs(securityParameters, state.clientExtensions);
		}
		securityParameters.m_clientSupportedGroups = TlsExtensionsUtilities.GetSupportedGroupsExtension(state.clientExtensions);
		HeartbeatExtension heartbeatExtension = TlsExtensionsUtilities.GetHeartbeatExtension(state.clientExtensions);
		if (heartbeatExtension != null)
		{
			if (1 == heartbeatExtension.Mode)
			{
				state.heartbeat = state.server.GetHeartbeat();
			}
			state.heartbeatPolicy = state.server.GetHeartbeatPolicy();
		}
		state.server.ProcessClientExtensions(state.clientExtensions);
	}

	protected virtual void ProcessClientKeyExchange(ServerHandshakeState state, byte[] body)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		state.keyExchange.ProcessClientKeyExchange(buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual void ProcessClientSupplementalData(ServerHandshakeState state, byte[] body)
	{
		IList clientSupplementalData = TlsProtocol.ReadSupplementalDataMessage(new MemoryStream(body, writable: false));
		state.server.ProcessClientSupplementalData(clientSupplementalData);
	}

	protected virtual bool ExpectCertificateVerifyMessage(ServerHandshakeState state)
	{
		if (state.certificateRequest == null)
		{
			return false;
		}
		Certificate clientCertificate = state.serverContext.SecurityParameters.PeerCertificate;
		if (clientCertificate != null && !clientCertificate.IsEmpty)
		{
			if (state.keyExchange != null)
			{
				return state.keyExchange.RequiresCertificateVerify;
			}
			return true;
		}
		return false;
	}
}
