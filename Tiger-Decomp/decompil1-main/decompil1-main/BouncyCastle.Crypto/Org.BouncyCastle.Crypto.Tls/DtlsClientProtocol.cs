using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class DtlsClientProtocol : DtlsProtocol
{
	protected internal class ClientHandshakeState
	{
		internal TlsClient client;

		internal TlsClientContextImpl clientContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal byte[] selectedSessionID;

		internal bool resumedSession;

		internal bool secure_renegotiation;

		internal bool allowCertificateStatus;

		internal bool expectSessionTicket;

		internal TlsKeyExchange keyExchange;

		internal TlsAuthentication authentication;

		internal CertificateStatus certificateStatus;

		internal CertificateRequest certificateRequest;

		internal TlsCredentials clientCredentials;
	}

	public DtlsClientProtocol(SecureRandom secureRandom)
		: base(secureRandom)
	{
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
		SecurityParameters securityParameters = new SecurityParameters();
		securityParameters.entity = 1;
		ClientHandshakeState state = new ClientHandshakeState();
		state.client = client;
		state.clientContext = new TlsClientContextImpl(mSecureRandom, securityParameters);
		securityParameters.clientRandom = TlsProtocol.CreateRandomBlock(client.ShouldUseGmtUnixTime(), state.clientContext.NonceRandomGenerator);
		client.Init(state.clientContext);
		DtlsRecordLayer recordLayer = new DtlsRecordLayer(transport, state.clientContext, client, 22);
		client.NotifyCloseHandle(recordLayer);
		TlsSession sessionToResume = state.client.GetSessionToResume();
		if (sessionToResume != null && sessionToResume.IsResumable)
		{
			SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
			if (sessionParameters != null && sessionParameters.IsExtendedMasterSecret)
			{
				state.tlsSession = sessionToResume;
				state.sessionParameters = sessionParameters;
			}
		}
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

	internal virtual void AbortClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer, byte alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ClientHandshake(ClientHandshakeState state, DtlsRecordLayer recordLayer)
	{
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		DtlsReliableHandshake handshake = new DtlsReliableHandshake(state.clientContext, recordLayer, state.client.GetHandshakeTimeoutMillis());
		byte[] clientHelloBody = GenerateClientHello(state, state.client);
		recordLayer.SetWriteVersion(ProtocolVersion.DTLSv10);
		handshake.SendMessage(1, clientHelloBody);
		DtlsReliableHandshake.Message serverMessage = handshake.ReceiveMessage();
		while (serverMessage.Type == 3)
		{
			ProtocolVersion readVersion = recordLayer.ReadVersion;
			ProtocolVersion client_version = state.clientContext.ClientVersion;
			if (!readVersion.IsEqualOrEarlierVersionOf(client_version))
			{
				throw new TlsFatalAlert(47);
			}
			recordLayer.ReadVersion = null;
			byte[] cookie = ProcessHelloVerifyRequest(state, serverMessage.Body);
			byte[] patched = PatchClientHelloWithCookie(clientHelloBody, cookie);
			handshake.ResetHandshakeMessagesDigest();
			handshake.SendMessage(1, patched);
			serverMessage = handshake.ReceiveMessage();
		}
		if (serverMessage.Type == 2)
		{
			ProtocolVersion recordLayerVersion = recordLayer.ReadVersion;
			ReportServerVersion(state, recordLayerVersion);
			recordLayer.SetWriteVersion(recordLayerVersion);
			ProcessServerHello(state, serverMessage.Body);
			handshake.NotifyHelloComplete();
			DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.maxFragmentLength);
			if (state.resumedSession)
			{
				securityParameters.masterSecret = Arrays.Clone(state.sessionParameters.MasterSecret);
				recordLayer.InitPendingEpoch(state.client.GetCipher());
				byte[] resExpectedServerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, "server finished", TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				ProcessFinished(handshake.ReceiveMessageBody(20), resExpectedServerVerifyData);
				byte[] resClientVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, "client finished", TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				handshake.SendMessage(20, resClientVerifyData);
				handshake.Finish();
				state.clientContext.SetResumableSession(state.tlsSession);
				state.client.NotifyHandshakeComplete();
				return new DtlsTransport(recordLayer);
			}
			InvalidateSession(state);
			if (state.selectedSessionID.Length != 0)
			{
				state.tlsSession = new TlsSessionImpl(state.selectedSessionID, null);
			}
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
			state.keyExchange = state.client.GetKeyExchange();
			state.keyExchange.Init(state.clientContext);
			Certificate serverCertificate = null;
			if (serverMessage.Type == 11)
			{
				serverCertificate = ProcessServerCertificate(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
			else
			{
				state.keyExchange.SkipServerCredentials();
			}
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				state.allowCertificateStatus = false;
			}
			if (serverMessage.Type == 22)
			{
				ProcessCertificateStatus(state, serverMessage.Body);
				serverMessage = handshake.ReceiveMessage();
			}
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
				TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, state.certificateRequest.SupportedSignatureAlgorithms);
				serverMessage = handshake.ReceiveMessage();
			}
			if (serverMessage.Type == 14)
			{
				if (serverMessage.Body.Length != 0)
				{
					throw new TlsFatalAlert(50);
				}
				handshake.HandshakeHash.SealHashAlgorithms();
				IList clientSupplementalData = state.client.GetClientSupplementalData();
				if (clientSupplementalData != null)
				{
					byte[] supplementalDataBody = DtlsProtocol.GenerateSupplementalData(clientSupplementalData);
					handshake.SendMessage(23, supplementalDataBody);
				}
				if (state.certificateRequest != null)
				{
					state.clientCredentials = state.authentication.GetClientCredentials(state.certificateRequest);
					Certificate clientCertificate = null;
					if (state.clientCredentials != null)
					{
						clientCertificate = state.clientCredentials.Certificate;
					}
					if (clientCertificate == null)
					{
						clientCertificate = Certificate.EmptyChain;
					}
					byte[] certificateBody = DtlsProtocol.GenerateCertificate(clientCertificate);
					handshake.SendMessage(11, certificateBody);
				}
				if (state.clientCredentials != null)
				{
					state.keyExchange.ProcessClientCredentials(state.clientCredentials);
				}
				else
				{
					state.keyExchange.SkipClientCredentials();
				}
				byte[] clientKeyExchangeBody = GenerateClientKeyExchange(state);
				handshake.SendMessage(16, clientKeyExchangeBody);
				TlsHandshakeHash prepareFinishHash = handshake.PrepareToFinish();
				securityParameters.sessionHash = TlsProtocol.GetCurrentPrfHash(state.clientContext, prepareFinishHash, null);
				TlsProtocol.EstablishMasterSecret(state.clientContext, state.keyExchange);
				recordLayer.InitPendingEpoch(state.client.GetCipher());
				if (state.clientCredentials != null && state.clientCredentials is TlsSignerCredentials)
				{
					TlsSignerCredentials signerCredentials = (TlsSignerCredentials)state.clientCredentials;
					SignatureAndHashAlgorithm signatureAndHashAlgorithm = TlsUtilities.GetSignatureAndHashAlgorithm(state.clientContext, signerCredentials);
					byte[] hash = ((signatureAndHashAlgorithm != null) ? prepareFinishHash.GetFinalHash(signatureAndHashAlgorithm.Hash) : securityParameters.SessionHash);
					byte[] signature = signerCredentials.GenerateCertificateSignature(hash);
					DigitallySigned certificateVerify = new DigitallySigned(signatureAndHashAlgorithm, signature);
					byte[] certificateVerifyBody = GenerateCertificateVerify(state, certificateVerify);
					handshake.SendMessage(15, certificateVerifyBody);
				}
				byte[] clientVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, "client finished", TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				handshake.SendMessage(20, clientVerifyData);
				if (state.expectSessionTicket)
				{
					serverMessage = handshake.ReceiveMessage();
					if (serverMessage.Type != 4)
					{
						throw new TlsFatalAlert(10);
					}
					ProcessNewSessionTicket(state, serverMessage.Body);
				}
				byte[] expectedServerVerifyData = TlsUtilities.CalculateVerifyData(state.clientContext, "server finished", TlsProtocol.GetCurrentPrfHash(state.clientContext, handshake.HandshakeHash, null));
				ProcessFinished(handshake.ReceiveMessageBody(20), expectedServerVerifyData);
				handshake.Finish();
				if (state.tlsSession != null)
				{
					state.sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetCompressionAlgorithm(securityParameters.CompressionAlgorithm).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret)
						.SetMasterSecret(securityParameters.MasterSecret)
						.SetPeerCertificate(serverCertificate)
						.SetPskIdentity(securityParameters.PskIdentity)
						.SetSrpIdentity(securityParameters.SrpIdentity)
						.SetServerExtensions(state.serverExtensions)
						.Build();
					state.tlsSession = TlsUtilities.ImportSession(state.tlsSession.SessionID, state.sessionParameters);
					state.clientContext.SetResumableSession(state.tlsSession);
				}
				state.client.NotifyHandshakeComplete();
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

	protected virtual byte[] GenerateClientHello(ClientHandshakeState state, TlsClient client)
	{
		ProtocolVersion client_version = client.ClientVersion;
		if (!client_version.IsDtls)
		{
			throw new TlsFatalAlert(80);
		}
		TlsClientContextImpl clientContext = state.clientContext;
		clientContext.SetClientVersion(client_version);
		SecurityParameters securityParameters = clientContext.SecurityParameters;
		byte[] session_id = TlsUtilities.EmptyBytes;
		if (state.tlsSession != null)
		{
			session_id = state.tlsSession.SessionID;
			if (session_id == null || session_id.Length > 32)
			{
				session_id = TlsUtilities.EmptyBytes;
			}
		}
		bool isFallback = client.IsFallback;
		state.offeredCipherSuites = client.GetCipherSuites();
		if (session_id.Length != 0 && state.sessionParameters != null && (!state.sessionParameters.IsExtendedMasterSecret || !Arrays.Contains(state.offeredCipherSuites, state.sessionParameters.CipherSuite) || state.sessionParameters.CompressionAlgorithm != 0))
		{
			session_id = TlsUtilities.EmptyBytes;
		}
		state.clientExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(client.GetClientExtensions());
		TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.clientExtensions);
		MemoryStream buf = new MemoryStream();
		TlsUtilities.WriteVersion(client_version, buf);
		buf.Write(securityParameters.ClientRandom, 0, securityParameters.ClientRandom.Length);
		TlsUtilities.WriteOpaque8(session_id, buf);
		TlsUtilities.WriteOpaque8(TlsUtilities.EmptyBytes, buf);
		byte[] renegExtData = TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
		bool num = renegExtData == null;
		bool noRenegSCSV = !Arrays.Contains(state.offeredCipherSuites, 255);
		if (num && noRenegSCSV)
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 255);
		}
		if (isFallback && !Arrays.Contains(state.offeredCipherSuites, 22016))
		{
			state.offeredCipherSuites = Arrays.Append(state.offeredCipherSuites, 22016);
		}
		TlsUtilities.WriteUint16ArrayWithUint16Length(state.offeredCipherSuites, buf);
		TlsUtilities.WriteUint8ArrayWithUint8Length(new byte[1], buf);
		TlsProtocol.WriteExtensions(buf, state.clientExtensions);
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
		state.certificateRequest = CertificateRequest.Parse(state.clientContext, buf);
		TlsProtocol.AssertEmpty(buf);
		state.keyExchange.ValidateCertificateRequest(state.certificateRequest);
	}

	protected virtual void ProcessCertificateStatus(ClientHandshakeState state, byte[] body)
	{
		if (!state.allowCertificateStatus)
		{
			throw new TlsFatalAlert(10);
		}
		MemoryStream buf = new MemoryStream(body, writable: false);
		state.certificateStatus = CertificateStatus.Parse(buf);
		TlsProtocol.AssertEmpty(buf);
	}

	protected virtual byte[] ProcessHelloVerifyRequest(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		ProtocolVersion server_version = TlsUtilities.ReadVersion(memoryStream);
		byte[] cookie = TlsUtilities.ReadOpaque8(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		if (!server_version.IsEqualOrEarlierVersionOf(state.clientContext.ClientVersion))
		{
			throw new TlsFatalAlert(47);
		}
		if (!ProtocolVersion.DTLSv12.IsEqualOrEarlierVersionOf(server_version) && cookie.Length > 32)
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

	protected virtual Certificate ProcessServerCertificate(ClientHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		Certificate serverCertificate = Certificate.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		state.keyExchange.ProcessServerCertificate(serverCertificate);
		state.authentication = state.client.GetAuthentication();
		state.authentication.NotifyServerCertificate(serverCertificate);
		return serverCertificate;
	}

	protected virtual void ProcessServerHello(ClientHandshakeState state, byte[] body)
	{
		SecurityParameters securityParameters = state.clientContext.SecurityParameters;
		MemoryStream buf = new MemoryStream(body, writable: false);
		ProtocolVersion server_version = TlsUtilities.ReadVersion(buf);
		ReportServerVersion(state, server_version);
		securityParameters.serverRandom = TlsUtilities.ReadFully(32, buf);
		state.selectedSessionID = TlsUtilities.ReadOpaque8(buf);
		if (state.selectedSessionID.Length > 32)
		{
			throw new TlsFatalAlert(47);
		}
		state.client.NotifySessionID(state.selectedSessionID);
		state.resumedSession = state.selectedSessionID.Length != 0 && state.tlsSession != null && Arrays.AreEqual(state.selectedSessionID, state.tlsSession.SessionID);
		int selectedCipherSuite = TlsUtilities.ReadUint16(buf);
		if (!Arrays.Contains(state.offeredCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || CipherSuite.IsScsv(selectedCipherSuite) || !TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, state.clientContext.ServerVersion))
		{
			throw new TlsFatalAlert(47);
		}
		DtlsProtocol.ValidateSelectedCipherSuite(selectedCipherSuite, 47);
		state.client.NotifySelectedCipherSuite(selectedCipherSuite);
		byte selectedCompressionMethod = TlsUtilities.ReadUint8(buf);
		if (selectedCompressionMethod != 0)
		{
			throw new TlsFatalAlert(47);
		}
		state.client.NotifySelectedCompressionMethod(selectedCompressionMethod);
		state.serverExtensions = TlsProtocol.ReadExtensions(buf);
		securityParameters.extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.serverExtensions);
		if (!securityParameters.IsExtendedMasterSecret && (state.resumedSession || state.client.RequiresExtendedMasterSecret()))
		{
			throw new TlsFatalAlert(40);
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
			state.secure_renegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		state.client.NotifySecureRenegotiation(state.secure_renegotiation);
		IDictionary sessionClientExtensions = state.clientExtensions;
		IDictionary sessionServerExtensions = state.serverExtensions;
		if (state.resumedSession)
		{
			if (selectedCipherSuite != state.sessionParameters.CipherSuite || selectedCompressionMethod != state.sessionParameters.CompressionAlgorithm)
			{
				throw new TlsFatalAlert(47);
			}
			sessionClientExtensions = null;
			sessionServerExtensions = state.sessionParameters.ReadServerExtensions();
		}
		securityParameters.cipherSuite = selectedCipherSuite;
		securityParameters.compressionAlgorithm = selectedCompressionMethod;
		if (sessionServerExtensions != null && sessionServerExtensions.Count > 0)
		{
			bool serverSentEncryptThenMAC = TlsExtensionsUtilities.HasEncryptThenMacExtension(sessionServerExtensions);
			if (serverSentEncryptThenMAC && !TlsUtilities.IsBlockCipherSuite(securityParameters.CipherSuite))
			{
				throw new TlsFatalAlert(47);
			}
			securityParameters.encryptThenMac = serverSentEncryptThenMAC;
			securityParameters.maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, sessionClientExtensions, sessionServerExtensions, 47);
			securityParameters.truncatedHMac = TlsExtensionsUtilities.HasTruncatedHMacExtension(sessionServerExtensions);
			state.allowCertificateStatus = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 5, 47);
			state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(sessionServerExtensions, 35, 47);
		}
		if (sessionClientExtensions != null)
		{
			state.client.ProcessServerExtensions(sessionServerExtensions);
		}
		securityParameters.prfAlgorithm = TlsProtocol.GetPrfAlgorithm(state.clientContext, securityParameters.CipherSuite);
		securityParameters.verifyDataLength = 12;
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
		TlsClientContextImpl clientContext = state.clientContext;
		ProtocolVersion currentServerVersion = clientContext.ServerVersion;
		if (currentServerVersion == null)
		{
			clientContext.SetServerVersion(server_version);
			state.client.NotifyServerVersion(server_version);
		}
		else if (!currentServerVersion.Equals(server_version))
		{
			throw new TlsFatalAlert(47);
		}
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
		TlsUtilities.WriteUint8((byte)cookie.Length, patched, cookieLengthPos);
		Array.Copy(cookie, 0, patched, cookiePos, cookie.Length);
		Array.Copy(clientHelloBody, cookiePos, patched, cookiePos + cookie.Length, clientHelloBody.Length - cookiePos);
		return patched;
	}
}
