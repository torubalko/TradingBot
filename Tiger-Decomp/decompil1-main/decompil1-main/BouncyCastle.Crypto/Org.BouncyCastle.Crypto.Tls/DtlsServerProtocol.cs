using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls;

public class DtlsServerProtocol : DtlsProtocol
{
	protected internal class ServerHandshakeState
	{
		internal TlsServer server;

		internal TlsServerContextImpl serverContext;

		internal TlsSession tlsSession;

		internal SessionParameters sessionParameters;

		internal SessionParameters.Builder sessionParametersBuilder;

		internal int[] offeredCipherSuites;

		internal byte[] offeredCompressionMethods;

		internal IDictionary clientExtensions;

		internal IDictionary serverExtensions;

		internal bool resumedSession;

		internal bool secure_renegotiation;

		internal bool allowCertificateStatus;

		internal bool expectSessionTicket;

		internal TlsKeyExchange keyExchange;

		internal TlsCredentials serverCredentials;

		internal CertificateRequest certificateRequest;

		internal short clientCertificateType = -1;

		internal Certificate clientCertificate;
	}

	protected bool mVerifyRequests = true;

	public virtual bool VerifyRequests
	{
		get
		{
			return mVerifyRequests;
		}
		set
		{
			mVerifyRequests = value;
		}
	}

	public DtlsServerProtocol(SecureRandom secureRandom)
		: base(secureRandom)
	{
	}

	public virtual DtlsTransport Accept(TlsServer server, DatagramTransport transport)
	{
		if (server == null)
		{
			throw new ArgumentNullException("server");
		}
		if (transport == null)
		{
			throw new ArgumentNullException("transport");
		}
		SecurityParameters securityParameters = new SecurityParameters();
		securityParameters.entity = 0;
		ServerHandshakeState state = new ServerHandshakeState();
		state.server = server;
		state.serverContext = new TlsServerContextImpl(mSecureRandom, securityParameters);
		securityParameters.serverRandom = TlsProtocol.CreateRandomBlock(server.ShouldUseGmtUnixTime(), state.serverContext.NonceRandomGenerator);
		server.Init(state.serverContext);
		DtlsRecordLayer recordLayer = new DtlsRecordLayer(transport, state.serverContext, server, 22);
		server.NotifyCloseHandle(recordLayer);
		try
		{
			return ServerHandshake(state, recordLayer);
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

	internal virtual void AbortServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer, byte alertDescription)
	{
		recordLayer.Fail(alertDescription);
		InvalidateSession(state);
	}

	internal virtual DtlsTransport ServerHandshake(ServerHandshakeState state, DtlsRecordLayer recordLayer)
	{
		SecurityParameters securityParameters = state.serverContext.SecurityParameters;
		DtlsReliableHandshake handshake = new DtlsReliableHandshake(state.serverContext, recordLayer, state.server.GetHandshakeTimeoutMillis());
		DtlsReliableHandshake.Message clientMessage = handshake.ReceiveMessage();
		if (clientMessage.Type == 1)
		{
			ProcessClientHello(state, clientMessage.Body);
			byte[] serverHelloBody = GenerateServerHello(state);
			DtlsProtocol.ApplyMaxFragmentLengthExtension(recordLayer, securityParameters.maxFragmentLength);
			ProtocolVersion recordLayerVersion = (recordLayer.ReadVersion = state.serverContext.ServerVersion);
			recordLayer.SetWriteVersion(recordLayerVersion);
			handshake.SendMessage(2, serverHelloBody);
			handshake.NotifyHelloComplete();
			IList serverSupplementalData = state.server.GetServerSupplementalData();
			if (serverSupplementalData != null)
			{
				byte[] supplementalDataBody = DtlsProtocol.GenerateSupplementalData(serverSupplementalData);
				handshake.SendMessage(23, supplementalDataBody);
			}
			state.keyExchange = state.server.GetKeyExchange();
			state.keyExchange.Init(state.serverContext);
			state.serverCredentials = state.server.GetCredentials();
			Certificate serverCertificate = null;
			if (state.serverCredentials == null)
			{
				state.keyExchange.SkipServerCredentials();
			}
			else
			{
				state.keyExchange.ProcessServerCredentials(state.serverCredentials);
				serverCertificate = state.serverCredentials.Certificate;
				byte[] certificateBody = DtlsProtocol.GenerateCertificate(serverCertificate);
				handshake.SendMessage(11, certificateBody);
			}
			if (serverCertificate == null || serverCertificate.IsEmpty)
			{
				state.allowCertificateStatus = false;
			}
			if (state.allowCertificateStatus)
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
				if (state.certificateRequest != null)
				{
					if (TlsUtilities.IsTlsV12(state.serverContext) != (state.certificateRequest.SupportedSignatureAlgorithms != null))
					{
						throw new TlsFatalAlert(80);
					}
					state.keyExchange.ValidateCertificateRequest(state.certificateRequest);
					byte[] certificateRequestBody = GenerateCertificateRequest(state, state.certificateRequest);
					handshake.SendMessage(13, certificateRequestBody);
					TlsUtilities.TrackHashAlgorithms(handshake.HandshakeHash, state.certificateRequest.SupportedSignatureAlgorithms);
				}
			}
			handshake.SendMessage(14, TlsUtilities.EmptyBytes);
			handshake.HandshakeHash.SealHashAlgorithms();
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
				TlsHandshakeHash prepareFinishHash = handshake.PrepareToFinish();
				securityParameters.sessionHash = TlsProtocol.GetCurrentPrfHash(state.serverContext, prepareFinishHash, null);
				TlsProtocol.EstablishMasterSecret(state.serverContext, state.keyExchange);
				recordLayer.InitPendingEpoch(state.server.GetCipher());
				if (ExpectCertificateVerifyMessage(state))
				{
					byte[] certificateVerifyBody = handshake.ReceiveMessageBody(15);
					ProcessCertificateVerify(state, certificateVerifyBody, prepareFinishHash);
				}
				byte[] expectedClientVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, "client finished", TlsProtocol.GetCurrentPrfHash(state.serverContext, handshake.HandshakeHash, null));
				ProcessFinished(handshake.ReceiveMessageBody(20), expectedClientVerifyData);
				if (state.expectSessionTicket)
				{
					NewSessionTicket newSessionTicket = state.server.GetNewSessionTicket();
					byte[] newSessionTicketBody = GenerateNewSessionTicket(state, newSessionTicket);
					handshake.SendMessage(4, newSessionTicketBody);
				}
				byte[] serverVerifyData = TlsUtilities.CalculateVerifyData(state.serverContext, "server finished", TlsProtocol.GetCurrentPrfHash(state.serverContext, handshake.HandshakeHash, null));
				handshake.SendMessage(20, serverVerifyData);
				handshake.Finish();
				state.server.NotifyHandshakeComplete();
				return new DtlsTransport(recordLayer);
			}
			throw new TlsFatalAlert(10);
		}
		throw new TlsFatalAlert(10);
	}

	protected virtual void InvalidateSession(ServerHandshakeState state)
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

	protected virtual byte[] GenerateCertificateRequest(ServerHandshakeState state, CertificateRequest certificateRequest)
	{
		MemoryStream buf = new MemoryStream();
		certificateRequest.Encode(buf);
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

	protected virtual byte[] GenerateServerHello(ServerHandshakeState state)
	{
		SecurityParameters securityParameters = state.serverContext.SecurityParameters;
		MemoryStream buf = new MemoryStream();
		ProtocolVersion server_version = state.server.GetServerVersion();
		if (!server_version.IsEqualOrEarlierVersionOf(state.serverContext.ClientVersion))
		{
			throw new TlsFatalAlert(80);
		}
		state.serverContext.SetServerVersion(server_version);
		TlsUtilities.WriteVersion(state.serverContext.ServerVersion, buf);
		buf.Write(securityParameters.ServerRandom, 0, securityParameters.ServerRandom.Length);
		TlsUtilities.WriteOpaque8(TlsUtilities.EmptyBytes, buf);
		int selectedCipherSuite = state.server.GetSelectedCipherSuite();
		if (!Arrays.Contains(state.offeredCipherSuites, selectedCipherSuite) || selectedCipherSuite == 0 || CipherSuite.IsScsv(selectedCipherSuite) || !TlsUtilities.IsValidCipherSuiteForVersion(selectedCipherSuite, state.serverContext.ServerVersion))
		{
			throw new TlsFatalAlert(80);
		}
		DtlsProtocol.ValidateSelectedCipherSuite(selectedCipherSuite, 80);
		securityParameters.cipherSuite = selectedCipherSuite;
		byte selectedCompressionMethod = state.server.GetSelectedCompressionMethod();
		if (!Arrays.Contains(state.offeredCompressionMethods, selectedCompressionMethod))
		{
			throw new TlsFatalAlert(80);
		}
		securityParameters.compressionAlgorithm = selectedCompressionMethod;
		TlsUtilities.WriteUint16(selectedCipherSuite, buf);
		TlsUtilities.WriteUint8(selectedCompressionMethod, buf);
		state.serverExtensions = TlsExtensionsUtilities.EnsureExtensionsInitialised(state.server.GetServerExtensions());
		if (state.secure_renegotiation)
		{
			byte[] renegExtData = TlsUtilities.GetExtensionData(state.serverExtensions, 65281);
			if (renegExtData == null)
			{
				state.serverExtensions[65281] = TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes);
			}
		}
		if (securityParameters.IsExtendedMasterSecret)
		{
			TlsExtensionsUtilities.AddExtendedMasterSecretExtension(state.serverExtensions);
		}
		if (state.serverExtensions.Count > 0)
		{
			securityParameters.encryptThenMac = TlsExtensionsUtilities.HasEncryptThenMacExtension(state.serverExtensions);
			securityParameters.maxFragmentLength = DtlsProtocol.EvaluateMaxFragmentLengthExtension(state.resumedSession, state.clientExtensions, state.serverExtensions, 80);
			securityParameters.truncatedHMac = TlsExtensionsUtilities.HasTruncatedHMacExtension(state.serverExtensions);
			state.allowCertificateStatus = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 5, 80);
			state.expectSessionTicket = !state.resumedSession && TlsUtilities.HasExpectedEmptyExtensionData(state.serverExtensions, 35, 80);
			TlsProtocol.WriteExtensions(buf, state.serverExtensions);
		}
		securityParameters.prfAlgorithm = TlsProtocol.GetPrfAlgorithm(state.serverContext, securityParameters.CipherSuite);
		securityParameters.verifyDataLength = 12;
		return buf.ToArray();
	}

	protected virtual void NotifyClientCertificate(ServerHandshakeState state, Certificate clientCertificate)
	{
		if (state.certificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		if (state.clientCertificate != null)
		{
			throw new TlsFatalAlert(10);
		}
		state.clientCertificate = clientCertificate;
		if (clientCertificate.IsEmpty)
		{
			state.keyExchange.SkipClientCredentials();
		}
		else
		{
			state.clientCertificateType = TlsUtilities.GetClientCertificateType(clientCertificate, state.serverCredentials.Certificate);
			state.keyExchange.ProcessClientCertificate(clientCertificate);
		}
		state.server.NotifyClientCertificate(clientCertificate);
	}

	protected virtual void ProcessClientCertificate(ServerHandshakeState state, byte[] body)
	{
		MemoryStream memoryStream = new MemoryStream(body, writable: false);
		Certificate clientCertificate = Certificate.Parse(memoryStream);
		TlsProtocol.AssertEmpty(memoryStream);
		NotifyClientCertificate(state, clientCertificate);
	}

	protected virtual void ProcessCertificateVerify(ServerHandshakeState state, byte[] body, TlsHandshakeHash prepareFinishHash)
	{
		if (state.certificateRequest == null)
		{
			throw new InvalidOperationException();
		}
		MemoryStream buf = new MemoryStream(body, writable: false);
		TlsServerContextImpl context = state.serverContext;
		DigitallySigned clientCertificateVerify = DigitallySigned.Parse(context, buf);
		TlsProtocol.AssertEmpty(buf);
		try
		{
			SignatureAndHashAlgorithm signatureAlgorithm = clientCertificateVerify.Algorithm;
			byte[] hash;
			if (TlsUtilities.IsTlsV12(context))
			{
				TlsUtilities.VerifySupportedSignatureAlgorithm(state.certificateRequest.SupportedSignatureAlgorithms, signatureAlgorithm);
				hash = prepareFinishHash.GetFinalHash(signatureAlgorithm.Hash);
			}
			else
			{
				hash = context.SecurityParameters.SessionHash;
			}
			AsymmetricKeyParameter publicKey = PublicKeyFactory.CreateKey(state.clientCertificate.GetCertificateAt(0).SubjectPublicKeyInfo);
			TlsSigner tlsSigner = TlsUtilities.CreateTlsSigner((byte)state.clientCertificateType);
			tlsSigner.Init(context);
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

	protected virtual void ProcessClientHello(ServerHandshakeState state, byte[] body)
	{
		MemoryStream buf = new MemoryStream(body, writable: false);
		ProtocolVersion client_version = TlsUtilities.ReadVersion(buf);
		if (!client_version.IsDtls)
		{
			throw new TlsFatalAlert(47);
		}
		byte[] client_random = TlsUtilities.ReadFully(32, buf);
		if (TlsUtilities.ReadOpaque8(buf).Length > 32)
		{
			throw new TlsFatalAlert(47);
		}
		TlsUtilities.ReadOpaque8(buf);
		int cipher_suites_length = TlsUtilities.ReadUint16(buf);
		if (cipher_suites_length < 2 || (cipher_suites_length & 1) != 0)
		{
			throw new TlsFatalAlert(50);
		}
		state.offeredCipherSuites = TlsUtilities.ReadUint16Array(cipher_suites_length / 2, buf);
		int compression_methods_length = TlsUtilities.ReadUint8(buf);
		if (compression_methods_length < 1)
		{
			throw new TlsFatalAlert(47);
		}
		state.offeredCompressionMethods = TlsUtilities.ReadUint8Array(compression_methods_length, buf);
		state.clientExtensions = TlsProtocol.ReadExtensions(buf);
		TlsServerContextImpl serverContext = state.serverContext;
		SecurityParameters securityParameters = serverContext.SecurityParameters;
		securityParameters.extendedMasterSecret = TlsExtensionsUtilities.HasExtendedMasterSecretExtension(state.clientExtensions);
		if (!securityParameters.IsExtendedMasterSecret && state.server.RequiresExtendedMasterSecret())
		{
			throw new TlsFatalAlert(40);
		}
		serverContext.SetClientVersion(client_version);
		state.server.NotifyClientVersion(client_version);
		state.server.NotifyFallback(Arrays.Contains(state.offeredCipherSuites, 22016));
		securityParameters.clientRandom = client_random;
		state.server.NotifyOfferedCipherSuites(state.offeredCipherSuites);
		state.server.NotifyOfferedCompressionMethods(state.offeredCompressionMethods);
		if (Arrays.Contains(state.offeredCipherSuites, 255))
		{
			state.secure_renegotiation = true;
		}
		byte[] renegExtData = TlsUtilities.GetExtensionData(state.clientExtensions, 65281);
		if (renegExtData != null)
		{
			state.secure_renegotiation = true;
			if (!Arrays.ConstantTimeAreEqual(renegExtData, TlsProtocol.CreateRenegotiationInfo(TlsUtilities.EmptyBytes)))
			{
				throw new TlsFatalAlert(40);
			}
		}
		state.server.NotifySecureRenegotiation(state.secure_renegotiation);
		if (state.clientExtensions != null)
		{
			TlsExtensionsUtilities.GetPaddingExtension(state.clientExtensions);
			state.server.ProcessClientExtensions(state.clientExtensions);
		}
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
		if (state.clientCertificateType >= 0)
		{
			return TlsUtilities.HasSigningCapability((byte)state.clientCertificateType);
		}
		return false;
	}
}
