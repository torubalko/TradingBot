using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public abstract class TlsProtocol : TlsCloseable
{
	protected const short CS_START = 0;

	protected const short CS_CLIENT_HELLO = 1;

	protected const short CS_SERVER_HELLO_RETRY_REQUEST = 2;

	protected const short CS_CLIENT_HELLO_RETRY = 3;

	protected const short CS_SERVER_HELLO = 4;

	protected const short CS_SERVER_ENCRYPTED_EXTENSIONS = 5;

	protected const short CS_SERVER_SUPPLEMENTAL_DATA = 6;

	protected const short CS_SERVER_CERTIFICATE = 7;

	protected const short CS_SERVER_CERTIFICATE_STATUS = 8;

	protected const short CS_SERVER_CERTIFICATE_VERIFY = 9;

	protected const short CS_SERVER_KEY_EXCHANGE = 10;

	protected const short CS_SERVER_CERTIFICATE_REQUEST = 11;

	protected const short CS_SERVER_HELLO_DONE = 12;

	protected const short CS_CLIENT_END_OF_EARLY_DATA = 13;

	protected const short CS_CLIENT_SUPPLEMENTAL_DATA = 14;

	protected const short CS_CLIENT_CERTIFICATE = 15;

	protected const short CS_CLIENT_KEY_EXCHANGE = 16;

	protected const short CS_CLIENT_CERTIFICATE_VERIFY = 17;

	protected const short CS_CLIENT_FINISHED = 18;

	protected const short CS_SERVER_SESSION_TICKET = 19;

	protected const short CS_SERVER_FINISHED = 20;

	protected const short CS_END = 21;

	protected const short ADS_MODE_1_Nsub1 = 0;

	protected const short ADS_MODE_0_N = 1;

	protected const short ADS_MODE_0_N_FIRSTONLY = 2;

	private readonly ByteQueue m_applicationDataQueue = new ByteQueue(0);

	private readonly ByteQueue m_alertQueue = new ByteQueue(2);

	private readonly ByteQueue m_handshakeQueue = new ByteQueue(0);

	internal readonly RecordStream m_recordStream;

	internal readonly object m_recordWriteLock = new object();

	private int m_maxHandshakeMessageSize = -1;

	internal TlsHandshakeHash m_handshakeHash;

	private TlsStream m_tlsStream;

	private volatile bool m_closed;

	private volatile bool m_failedWithError;

	private volatile bool m_appDataReady;

	private volatile bool m_appDataSplitEnabled = true;

	private volatile bool m_keyUpdateEnabled;

	private volatile bool m_keyUpdatePendingSend;

	private volatile bool m_resumableHandshake;

	private volatile int m_appDataSplitMode;

	protected TlsSession m_tlsSession;

	protected SessionParameters m_sessionParameters;

	protected TlsSecret m_sessionMasterSecret;

	protected byte[] m_retryCookie;

	protected int m_retryGroup = -1;

	protected IDictionary m_clientExtensions;

	protected IDictionary m_serverExtensions;

	protected short m_connectionState;

	protected bool m_resumedSession;

	protected bool m_selectedPsk13;

	protected bool m_receivedChangeCipherSpec;

	protected bool m_expectSessionTicket;

	protected readonly bool m_blocking;

	protected readonly ByteQueueInputStream m_inputBuffers;

	protected readonly ByteQueueOutputStream m_outputBuffer;

	protected abstract TlsContext Context { get; }

	internal abstract AbstractTlsContext ContextAdmin { get; }

	protected abstract TlsPeer Peer { get; }

	public virtual int ApplicationDataAvailable => m_applicationDataQueue.Available;

	public virtual int AppDataSplitMode
	{
		get
		{
			return m_appDataSplitMode;
		}
		set
		{
			if (value < 0 || value > 2)
			{
				throw new InvalidOperationException("Illegal appDataSplitMode mode: " + value);
			}
			m_appDataSplitMode = value;
		}
	}

	public virtual bool IsResumableHandshake
	{
		get
		{
			return m_resumableHandshake;
		}
		set
		{
			m_resumableHandshake = value;
		}
	}

	public virtual Stream Stream
	{
		get
		{
			if (!m_blocking)
			{
				throw new InvalidOperationException("Cannot use Stream in non-blocking mode! Use OfferInput()/OfferOutput() instead.");
			}
			return m_tlsStream;
		}
	}

	public virtual int ApplicationDataLimit => m_recordStream.PlaintextLimit;

	internal bool IsApplicationDataReady => m_appDataReady;

	public virtual bool IsClosed => m_closed;

	public virtual bool IsConnected
	{
		get
		{
			if (m_closed)
			{
				return false;
			}
			return ContextAdmin?.IsConnected ?? false;
		}
	}

	public virtual bool IsHandshaking
	{
		get
		{
			if (m_closed)
			{
				return false;
			}
			return ContextAdmin?.IsHandshaking ?? false;
		}
	}

	protected bool IsLegacyConnectionState()
	{
		switch (m_connectionState)
		{
		case 0:
		case 1:
		case 4:
		case 6:
		case 7:
		case 8:
		case 10:
		case 11:
		case 12:
		case 14:
		case 15:
		case 16:
		case 17:
		case 18:
		case 19:
		case 20:
		case 21:
			return true;
		default:
			return false;
		}
	}

	protected bool IsTlsV13ConnectionState()
	{
		switch (m_connectionState)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 7:
		case 9:
		case 11:
		case 13:
		case 15:
		case 17:
		case 18:
		case 20:
		case 21:
			return true;
		default:
			return false;
		}
	}

	protected TlsProtocol()
	{
		m_blocking = false;
		m_inputBuffers = new ByteQueueInputStream();
		m_outputBuffer = new ByteQueueOutputStream();
		m_recordStream = new RecordStream(this, m_inputBuffers, m_outputBuffer);
	}

	public TlsProtocol(Stream stream)
		: this(stream, stream)
	{
	}

	public TlsProtocol(Stream input, Stream output)
	{
		m_blocking = true;
		m_inputBuffers = null;
		m_outputBuffer = null;
		m_recordStream = new RecordStream(this, input, output);
	}

	public virtual void ResumeHandshake()
	{
		if (!m_blocking)
		{
			throw new InvalidOperationException("Cannot use ResumeHandshake() in non-blocking mode!");
		}
		if (!IsHandshaking)
		{
			throw new InvalidOperationException("No handshake in progress");
		}
		BlockForHandshake();
	}

	protected virtual void CloseConnection()
	{
		m_recordStream.Close();
	}

	protected virtual void HandleAlertMessage(short alertLevel, short alertDescription)
	{
		Peer.NotifyAlertReceived(alertLevel, alertDescription);
		if (alertLevel == 1)
		{
			HandleAlertWarningMessage(alertDescription);
			return;
		}
		HandleFailure();
		throw new TlsFatalAlertReceived(alertDescription);
	}

	protected virtual void HandleAlertWarningMessage(short alertDescription)
	{
		switch (alertDescription)
		{
		case 0:
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			HandleClose(user_canceled: false);
			break;
		case 41:
			throw new TlsFatalAlert(10);
		case 100:
			throw new TlsFatalAlert(40);
		}
	}

	protected virtual void HandleChangeCipherSpecMessage()
	{
	}

	protected virtual void HandleClose(bool user_canceled)
	{
		if (m_closed)
		{
			return;
		}
		m_closed = true;
		if (!m_appDataReady)
		{
			CleanupHandshake();
			if (user_canceled)
			{
				RaiseAlertWarning(90, "User canceled handshake");
			}
		}
		RaiseAlertWarning(0, "Connection closed");
		CloseConnection();
	}

	protected virtual void HandleException(short alertDescription, string message, Exception e)
	{
		if (!m_closed)
		{
			RaiseAlertFatal(alertDescription, message, e);
			HandleFailure();
		}
	}

	protected virtual void HandleFailure()
	{
		m_closed = true;
		m_failedWithError = true;
		InvalidateSession();
		if (!m_appDataReady)
		{
			CleanupHandshake();
		}
		CloseConnection();
	}

	protected abstract void HandleHandshakeMessage(short type, HandshakeMessageInput buf);

	protected virtual void ApplyMaxFragmentLengthExtension(short maxFragmentLength)
	{
		if (maxFragmentLength >= 0)
		{
			if (!MaxFragmentLength.IsValid(maxFragmentLength))
			{
				throw new TlsFatalAlert(80);
			}
			int plainTextLimit = 1 << 8 + maxFragmentLength;
			m_recordStream.SetPlaintextLimit(plainTextLimit);
		}
	}

	protected virtual void CheckReceivedChangeCipherSpec(bool expected)
	{
		if (expected != m_receivedChangeCipherSpec)
		{
			throw new TlsFatalAlert(10);
		}
	}

	protected virtual void BlockForHandshake()
	{
		while (m_connectionState != 21)
		{
			if (IsClosed)
			{
				throw new TlsFatalAlert(80);
			}
			SafeReadRecord();
		}
	}

	protected virtual void BeginHandshake()
	{
		AbstractTlsContext context = ContextAdmin;
		TlsPeer peer = Peer;
		m_maxHandshakeMessageSize = System.Math.Max(1024, peer.GetMaxHandshakeMessageSize());
		m_handshakeHash = new DeferredHash(context);
		m_connectionState = 0;
		m_resumedSession = false;
		m_selectedPsk13 = false;
		context.HandshakeBeginning(peer);
		context.SecurityParameters.m_extendedPadding = peer.ShouldUseExtendedPadding();
	}

	protected virtual void CleanupHandshake()
	{
		Context?.SecurityParameters?.Clear();
		m_tlsSession = null;
		m_sessionParameters = null;
		m_sessionMasterSecret = null;
		m_retryCookie = null;
		m_retryGroup = -1;
		m_clientExtensions = null;
		m_serverExtensions = null;
		m_resumedSession = false;
		m_selectedPsk13 = false;
		m_receivedChangeCipherSpec = false;
		m_expectSessionTicket = false;
	}

	protected virtual void CompleteHandshake()
	{
		try
		{
			AbstractTlsContext context = ContextAdmin;
			SecurityParameters securityParameters = context.SecurityParameters;
			if (!context.IsHandshaking || securityParameters.LocalVerifyData == null || securityParameters.PeerVerifyData == null)
			{
				throw new TlsFatalAlert(80);
			}
			m_recordStream.FinaliseHandshake();
			m_connectionState = 21;
			m_handshakeHash = new DeferredHash(context);
			m_alertQueue.Shrink();
			m_handshakeQueue.Shrink();
			ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			m_appDataSplitEnabled = !TlsUtilities.IsTlsV11(negotiatedVersion);
			m_appDataReady = true;
			m_keyUpdateEnabled = TlsUtilities.IsTlsV13(negotiatedVersion);
			if (m_blocking)
			{
				m_tlsStream = new TlsStream(this);
			}
			if (m_sessionParameters == null)
			{
				m_sessionMasterSecret = securityParameters.MasterSecret;
				m_sessionParameters = new SessionParameters.Builder().SetCipherSuite(securityParameters.CipherSuite).SetExtendedMasterSecret(securityParameters.IsExtendedMasterSecret).SetLocalCertificate(securityParameters.LocalCertificate)
					.SetMasterSecret(context.Crypto.AdoptSecret(m_sessionMasterSecret))
					.SetNegotiatedVersion(securityParameters.NegotiatedVersion)
					.SetPeerCertificate(securityParameters.PeerCertificate)
					.SetPskIdentity(securityParameters.PskIdentity)
					.SetSrpIdentity(securityParameters.SrpIdentity)
					.SetServerExtensions(m_serverExtensions)
					.Build();
				m_tlsSession = TlsUtilities.ImportSession(securityParameters.SessionID, m_sessionParameters);
			}
			else
			{
				securityParameters.m_localCertificate = m_sessionParameters.LocalCertificate;
				securityParameters.m_peerCertificate = m_sessionParameters.PeerCertificate;
				securityParameters.m_pskIdentity = m_sessionParameters.PskIdentity;
				securityParameters.m_srpIdentity = m_sessionParameters.SrpIdentity;
			}
			context.HandshakeComplete(Peer, m_tlsSession);
		}
		finally
		{
			CleanupHandshake();
		}
	}

	internal void ProcessRecord(short protocol, byte[] buf, int off, int len)
	{
		switch (protocol)
		{
		case 21:
			m_alertQueue.AddData(buf, off, len);
			ProcessAlertQueue();
			break;
		case 23:
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(10);
			}
			m_applicationDataQueue.AddData(buf, off, len);
			ProcessApplicationDataQueue();
			break;
		case 20:
			ProcessChangeCipherSpec(buf, off, len);
			break;
		case 22:
		{
			if (m_handshakeQueue.Available > 0)
			{
				m_handshakeQueue.AddData(buf, off, len);
				ProcessHandshakeQueue(m_handshakeQueue);
				break;
			}
			ByteQueue tmpQueue = new ByteQueue(buf, off, len);
			ProcessHandshakeQueue(tmpQueue);
			int remaining = tmpQueue.Available;
			if (remaining > 0)
			{
				m_handshakeQueue.AddData(buf, off + len - remaining, remaining);
			}
			break;
		}
		default:
			throw new TlsFatalAlert(10);
		}
	}

	private void ProcessHandshakeQueue(ByteQueue queue)
	{
		while (queue.Available >= 4)
		{
			int num = queue.ReadInt32();
			short type = (short)(num >>> 24);
			if (!HandshakeType.IsRecognized(type))
			{
				throw new TlsFatalAlert(10, "Handshake message of unrecognized type: " + type);
			}
			int length = num & 0xFFFFFF;
			if (length > m_maxHandshakeMessageSize)
			{
				throw new TlsFatalAlert(80, "Handshake message length exceeds the maximum: " + HandshakeType.GetText(type) + ", " + length + " > " + m_maxHandshakeMessageSize);
			}
			int totalLength = 4 + length;
			if (queue.Available < totalLength)
			{
				break;
			}
			if (type != 0)
			{
				ProtocolVersion negotiatedVersion = Context.ServerVersion;
				if (negotiatedVersion == null || !TlsUtilities.IsTlsV13(negotiatedVersion))
				{
					CheckReceivedChangeCipherSpec(20 == type);
				}
			}
			HandshakeMessageInput buf = queue.ReadHandshakeMessage(totalLength);
			switch (type)
			{
			case 4:
			{
				ProtocolVersion negotiatedVersion2 = Context.ServerVersion;
				if (negotiatedVersion2 != null && !TlsUtilities.IsTlsV13(negotiatedVersion2))
				{
					buf.UpdateHash(m_handshakeHash);
				}
				break;
			}
			default:
				buf.UpdateHash(m_handshakeHash);
				break;
			case 0:
			case 1:
			case 2:
			case 15:
			case 20:
			case 24:
				break;
			}
			buf.Seek(4L, SeekOrigin.Current);
			HandleHandshakeMessage(type, buf);
		}
	}

	private void ProcessApplicationDataQueue()
	{
	}

	private void ProcessAlertQueue()
	{
		while (m_alertQueue.Available >= 2)
		{
			byte[] array = m_alertQueue.RemoveData(2, 0);
			short alertLevel = array[0];
			short alertDescription = array[1];
			HandleAlertMessage(alertLevel, alertDescription);
		}
	}

	private void ProcessChangeCipherSpec(byte[] buf, int off, int len)
	{
		ProtocolVersion negotiatedVersion = Context.ServerVersion;
		if (negotiatedVersion == null || TlsUtilities.IsTlsV13(negotiatedVersion))
		{
			throw new TlsFatalAlert(10);
		}
		for (int i = 0; i < len; i++)
		{
			if (TlsUtilities.ReadUint8(buf, off + i) != 1)
			{
				throw new TlsFatalAlert(50);
			}
			if (m_receivedChangeCipherSpec || m_alertQueue.Available > 0 || m_handshakeQueue.Available > 0)
			{
				throw new TlsFatalAlert(10);
			}
			m_recordStream.NotifyChangeCipherSpecReceived();
			m_receivedChangeCipherSpec = true;
			HandleChangeCipherSpecMessage();
		}
	}

	public virtual int ReadApplicationData(byte[] buf, int off, int len)
	{
		if (len < 1)
		{
			return 0;
		}
		while (m_applicationDataQueue.Available == 0)
		{
			if (m_closed)
			{
				if (m_failedWithError)
				{
					throw new IOException("Cannot read application data on failed TLS connection");
				}
				return -1;
			}
			if (!m_appDataReady)
			{
				throw new InvalidOperationException("Cannot read application data until initial handshake completed.");
			}
			SafeReadRecord();
		}
		len = System.Math.Min(len, m_applicationDataQueue.Available);
		m_applicationDataQueue.RemoveData(buf, off, len, 0);
		return len;
	}

	protected virtual RecordPreview SafePreviewRecordHeader(byte[] recordHeader)
	{
		try
		{
			return m_recordStream.PreviewRecordHeader(recordHeader);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to read record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to read record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to read record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	protected virtual void SafeReadRecord()
	{
		try
		{
			if (m_recordStream.ReadRecord())
			{
				return;
			}
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			if (!Peer.RequiresCloseNotify())
			{
				HandleClose(user_canceled: false);
				return;
			}
		}
		catch (TlsFatalAlertReceived tlsFatalAlertReceived)
		{
			throw tlsFatalAlertReceived;
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to read record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to read record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to read record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
		HandleFailure();
		throw new TlsNoCloseNotifyException();
	}

	protected virtual bool SafeReadFullRecord(byte[] input, int inputOff, int inputLen)
	{
		try
		{
			return m_recordStream.ReadFullRecord(input, inputOff, inputLen);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to process record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to process record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to process record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	protected virtual void SafeWriteRecord(short type, byte[] buf, int offset, int len)
	{
		try
		{
			m_recordStream.WriteRecord(type, buf, offset, len);
		}
		catch (TlsFatalAlert tlsFatalAlert)
		{
			HandleException(tlsFatalAlert.AlertDescription, "Failed to write record", tlsFatalAlert);
			throw tlsFatalAlert;
		}
		catch (IOException ex)
		{
			HandleException(80, "Failed to write record", ex);
			throw ex;
		}
		catch (Exception ex2)
		{
			HandleException(80, "Failed to write record", ex2);
			throw new TlsFatalAlert(80, ex2);
		}
	}

	public virtual void WriteApplicationData(byte[] buf, int off, int len)
	{
		if (!m_appDataReady)
		{
			throw new InvalidOperationException("Cannot write application data until initial handshake completed.");
		}
		lock (m_recordWriteLock)
		{
			while (len > 0)
			{
				if (m_closed)
				{
					throw new IOException("Cannot write application data on closed/failed TLS connection");
				}
				if (m_appDataSplitEnabled)
				{
					switch (m_appDataSplitMode)
					{
					case 2:
						m_appDataSplitEnabled = false;
						SafeWriteRecord(23, TlsUtilities.EmptyBytes, 0, 0);
						break;
					case 1:
						SafeWriteRecord(23, TlsUtilities.EmptyBytes, 0, 0);
						break;
					default:
						if (len > 1)
						{
							SafeWriteRecord(23, buf, off, 1);
							off++;
							len--;
						}
						break;
					}
				}
				else if (m_keyUpdateEnabled)
				{
					if (m_keyUpdatePendingSend)
					{
						Send13KeyUpdate(updateRequested: false);
					}
					else if (m_recordStream.NeedsKeyUpdate())
					{
						Send13KeyUpdate(updateRequested: true);
					}
				}
				int toWrite = System.Math.Min(len, m_recordStream.PlaintextLimit);
				SafeWriteRecord(23, buf, off, toWrite);
				off += toWrite;
				len -= toWrite;
			}
		}
	}

	internal void WriteHandshakeMessage(byte[] buf, int off, int len)
	{
		if (len < 4)
		{
			throw new TlsFatalAlert(80);
		}
		switch (TlsUtilities.ReadUint8(buf, off))
		{
		case 4:
		{
			ProtocolVersion negotiatedVersion = Context.ServerVersion;
			if (negotiatedVersion != null && !TlsUtilities.IsTlsV13(negotiatedVersion))
			{
				m_handshakeHash.Update(buf, off, len);
			}
			break;
		}
		default:
			m_handshakeHash.Update(buf, off, len);
			break;
		case 0:
		case 1:
		case 24:
			break;
		}
		int total = 0;
		do
		{
			int toWrite = System.Math.Min(len - total, m_recordStream.PlaintextLimit);
			SafeWriteRecord(22, buf, off + total, toWrite);
			total += toWrite;
		}
		while (total < len);
	}

	public virtual void CloseInput()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use CloseInput() in blocking mode!");
		}
		if (!m_closed)
		{
			if (m_inputBuffers.Available > 0)
			{
				throw new EndOfStreamException();
			}
			if (!m_appDataReady)
			{
				throw new TlsFatalAlert(40);
			}
			if (Peer.RequiresCloseNotify())
			{
				HandleFailure();
				throw new TlsNoCloseNotifyException();
			}
			HandleClose(user_canceled: false);
		}
	}

	public virtual RecordPreview PreviewInputRecord(byte[] recordHeader)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use PreviewInputRecord() in blocking mode!");
		}
		if (m_inputBuffers.Available != 0)
		{
			throw new InvalidOperationException("Can only use PreviewInputRecord() for record-aligned input.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot accept any more input");
		}
		return SafePreviewRecordHeader(recordHeader);
	}

	public virtual RecordPreview PreviewOutputRecord(int applicationDataSize)
	{
		if (!m_appDataReady)
		{
			throw new InvalidOperationException("Cannot use PreviewOutputRecord() until initial handshake completed.");
		}
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use PreviewOutputRecord() in blocking mode!");
		}
		if (m_outputBuffer.Buffer.Available != 0)
		{
			throw new InvalidOperationException("Can only use PreviewOutputRecord() for record-aligned output.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot produce any more output");
		}
		if (applicationDataSize < 1)
		{
			return new RecordPreview(0, 0);
		}
		if (m_appDataSplitEnabled)
		{
			int appDataSplitMode = m_appDataSplitMode;
			if (appDataSplitMode != 0 && (uint)(appDataSplitMode - 1) <= 1u)
			{
				RecordPreview a = m_recordStream.PreviewOutputRecord(0);
				RecordPreview b = m_recordStream.PreviewOutputRecord(applicationDataSize);
				return RecordPreview.CombineAppData(a, b);
			}
			RecordPreview a2 = m_recordStream.PreviewOutputRecord(1);
			if (applicationDataSize > 1)
			{
				RecordPreview b2 = m_recordStream.PreviewOutputRecord(applicationDataSize - 1);
				a2 = RecordPreview.CombineAppData(a2, b2);
			}
			return a2;
		}
		RecordPreview a3 = m_recordStream.PreviewOutputRecord(applicationDataSize);
		if (m_keyUpdateEnabled && (m_keyUpdatePendingSend || m_recordStream.NeedsKeyUpdate()))
		{
			int keyUpdateLength = HandshakeMessageOutput.GetLength(1);
			int recordSize = m_recordStream.PreviewOutputRecordSize(keyUpdateLength);
			a3 = RecordPreview.ExtendRecordSize(a3, recordSize);
		}
		return a3;
	}

	public virtual void OfferInput(byte[] input)
	{
		OfferInput(input, 0, input.Length);
	}

	public virtual void OfferInput(byte[] input, int inputOff, int inputLen)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use OfferInput() in blocking mode! Use Stream instead.");
		}
		if (m_closed)
		{
			throw new IOException("Connection is closed, cannot accept any more input");
		}
		if (m_inputBuffers.Available == 0 && SafeReadFullRecord(input, inputOff, inputLen))
		{
			if (m_closed && !m_appDataReady)
			{
				throw new TlsFatalAlert(80);
			}
			return;
		}
		m_inputBuffers.AddBytes(input, inputOff, inputLen);
		while (m_inputBuffers.Available >= 5)
		{
			byte[] recordHeader = new byte[5];
			if (5 != m_inputBuffers.Peek(recordHeader))
			{
				throw new TlsFatalAlert(80);
			}
			RecordPreview preview = SafePreviewRecordHeader(recordHeader);
			if (m_inputBuffers.Available < preview.RecordSize)
			{
				break;
			}
			SafeReadRecord();
			if (m_closed)
			{
				if (!m_appDataReady)
				{
					throw new TlsFatalAlert(80);
				}
				break;
			}
		}
	}

	public virtual int GetAvailableInputBytes()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use GetAvailableInputBytes() in blocking mode!");
		}
		return ApplicationDataAvailable;
	}

	public virtual int ReadInput(byte[] buf, int off, int len)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use ReadInput() in blocking mode! Use Stream instead.");
		}
		len = System.Math.Min(len, ApplicationDataAvailable);
		if (len < 1)
		{
			return 0;
		}
		m_applicationDataQueue.RemoveData(buf, off, len, 0);
		return len;
	}

	public virtual int GetAvailableOutputBytes()
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use GetAvailableOutputBytes() in blocking mode! Use Stream instead.");
		}
		return m_outputBuffer.Buffer.Available;
	}

	public virtual int ReadOutput(byte[] buffer, int offset, int length)
	{
		if (m_blocking)
		{
			throw new InvalidOperationException("Cannot use ReadOutput() in blocking mode! Use 'Stream() instead.");
		}
		int bytesToRead = System.Math.Min(GetAvailableOutputBytes(), length);
		m_outputBuffer.Buffer.RemoveData(buffer, offset, bytesToRead, 0);
		return bytesToRead;
	}

	protected virtual bool EstablishSession(TlsSession sessionToResume)
	{
		m_tlsSession = null;
		m_sessionParameters = null;
		m_sessionMasterSecret = null;
		if (sessionToResume == null || !sessionToResume.IsResumable)
		{
			return false;
		}
		SessionParameters sessionParameters = sessionToResume.ExportSessionParameters();
		if (sessionParameters == null)
		{
			return false;
		}
		if (!sessionParameters.IsExtendedMasterSecret)
		{
			TlsPeer peer = Peer;
			if (!peer.AllowLegacyResumption() || peer.RequiresExtendedMasterSecret())
			{
				return false;
			}
		}
		TlsSecret sessionMasterSecret = TlsUtilities.GetSessionMasterSecret(Context.Crypto, sessionParameters.MasterSecret);
		if (sessionMasterSecret == null)
		{
			return false;
		}
		m_tlsSession = sessionToResume;
		m_sessionParameters = sessionParameters;
		m_sessionMasterSecret = sessionMasterSecret;
		return true;
	}

	protected virtual void InvalidateSession()
	{
		if (m_sessionMasterSecret != null)
		{
			m_sessionMasterSecret.Destroy();
			m_sessionMasterSecret = null;
		}
		if (m_sessionParameters != null)
		{
			m_sessionParameters.Clear();
			m_sessionParameters = null;
		}
		if (m_tlsSession != null)
		{
			m_tlsSession.Invalidate();
			m_tlsSession = null;
		}
	}

	protected virtual void ProcessFinishedMessage(MemoryStream buf)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		bool isServerContext = context.IsServer;
		byte[] verify_data = TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
		AssertEmpty(buf);
		byte[] expected_verify_data = TlsUtilities.CalculateVerifyData(context, m_handshakeHash, !isServerContext);
		if (!Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
		{
			throw new TlsFatalAlert(51);
		}
		securityParameters.m_peerVerifyData = expected_verify_data;
		if ((!m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.LocalVerifyData == null)
		{
			securityParameters.m_tlsUnique = expected_verify_data;
		}
	}

	protected virtual void Process13FinishedMessage(MemoryStream buf)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		bool isServerContext = context.IsServer;
		byte[] verify_data = TlsUtilities.ReadFully(securityParameters.VerifyDataLength, buf);
		AssertEmpty(buf);
		byte[] expected_verify_data = TlsUtilities.CalculateVerifyData(context, m_handshakeHash, !isServerContext);
		if (!Arrays.ConstantTimeAreEqual(expected_verify_data, verify_data))
		{
			throw new TlsFatalAlert(51);
		}
		securityParameters.m_peerVerifyData = expected_verify_data;
		securityParameters.m_tlsUnique = null;
	}

	protected virtual void RaiseAlertFatal(short alertDescription, string message, Exception cause)
	{
		Peer.NotifyAlertRaised(2, alertDescription, message, cause);
		byte[] alert = new byte[2]
		{
			2,
			(byte)alertDescription
		};
		try
		{
			m_recordStream.WriteRecord(21, alert, 0, 2);
		}
		catch (Exception)
		{
		}
	}

	protected virtual void RaiseAlertWarning(short alertDescription, string message)
	{
		Peer.NotifyAlertRaised(1, alertDescription, message, null);
		byte[] alert = new byte[2]
		{
			1,
			(byte)alertDescription
		};
		SafeWriteRecord(21, alert, 0, 2);
	}

	protected virtual void Receive13KeyUpdate(MemoryStream buf)
	{
		if (!m_appDataReady || !m_keyUpdateEnabled)
		{
			throw new TlsFatalAlert(10);
		}
		short requestUpdate = TlsUtilities.ReadUint8(buf);
		AssertEmpty(buf);
		if (!KeyUpdateRequest.IsValid(requestUpdate))
		{
			throw new TlsFatalAlert(47);
		}
		bool updateRequested = 1 == requestUpdate;
		TlsUtilities.Update13TrafficSecretPeer(Context);
		m_recordStream.NotifyKeyUpdateReceived();
		m_keyUpdatePendingSend |= updateRequested;
	}

	protected virtual void SendCertificateMessage(Certificate certificate, Stream endPointHash)
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		if (securityParameters.LocalCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		if (certificate == null)
		{
			certificate = Certificate.EmptyChain;
		}
		if (certificate.IsEmpty && !context.IsServer && securityParameters.NegotiatedVersion.IsSsl)
		{
			string message = "SSLv3 client didn't provide credentials";
			RaiseAlertWarning(41, message);
		}
		else
		{
			HandshakeMessageOutput message2 = new HandshakeMessageOutput(11);
			certificate.Encode(context, message2, endPointHash);
			message2.Send(this);
		}
		securityParameters.m_localCertificate = certificate;
	}

	protected virtual void Send13CertificateMessage(Certificate certificate)
	{
		if (certificate == null)
		{
			throw new TlsFatalAlert(80);
		}
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		if (securityParameters.LocalCertificate != null)
		{
			throw new TlsFatalAlert(80);
		}
		HandshakeMessageOutput message = new HandshakeMessageOutput(11);
		certificate.Encode(context, message, null);
		message.Send(this);
		securityParameters.m_localCertificate = certificate;
	}

	protected virtual void Send13CertificateVerifyMessage(DigitallySigned certificateVerify)
	{
		HandshakeMessageOutput message = new HandshakeMessageOutput(15);
		certificateVerify.Encode(message);
		message.Send(this);
	}

	protected virtual void SendChangeCipherSpec()
	{
		SendChangeCipherSpecMessage();
		m_recordStream.EnablePendingCipherWrite();
	}

	protected virtual void SendChangeCipherSpecMessage()
	{
		byte[] message = new byte[1] { 1 };
		SafeWriteRecord(20, message, 0, message.Length);
	}

	protected virtual void SendFinishedMessage()
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] verify_data = (securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(isServer: context.IsServer, context: context, handshakeHash: m_handshakeHash));
		if ((!m_resumedSession || securityParameters.IsExtendedMasterSecret) && securityParameters.PeerVerifyData == null)
		{
			securityParameters.m_tlsUnique = verify_data;
		}
		HandshakeMessageOutput.Send(this, 20, verify_data);
	}

	protected virtual void Send13FinishedMessage()
	{
		TlsContext context = Context;
		SecurityParameters securityParameters = context.SecurityParameters;
		byte[] verify_data = (securityParameters.m_localVerifyData = TlsUtilities.CalculateVerifyData(isServer: context.IsServer, context: context, handshakeHash: m_handshakeHash));
		securityParameters.m_tlsUnique = null;
		HandshakeMessageOutput.Send(this, 20, verify_data);
	}

	protected virtual void Send13KeyUpdate(bool updateRequested)
	{
		if (!m_appDataReady || !m_keyUpdateEnabled)
		{
			throw new TlsFatalAlert(80);
		}
		short requestUpdate = (short)(updateRequested ? 1 : 0);
		HandshakeMessageOutput.Send(this, 24, TlsUtilities.EncodeUint8(requestUpdate));
		TlsUtilities.Update13TrafficSecretLocal(Context);
		m_recordStream.NotifyKeyUpdateSent();
		m_keyUpdatePendingSend &= updateRequested;
	}

	protected virtual void SendSupplementalDataMessage(IList supplementalData)
	{
		HandshakeMessageOutput handshakeMessageOutput = new HandshakeMessageOutput(23);
		WriteSupplementalData(handshakeMessageOutput, supplementalData);
		handshakeMessageOutput.Send(this);
	}

	public virtual void Close()
	{
		HandleClose(user_canceled: true);
	}

	public virtual void Flush()
	{
	}

	protected virtual short ProcessMaxFragmentLengthExtension(IDictionary clientExtensions, IDictionary serverExtensions, short alertDescription)
	{
		short maxFragmentLength = TlsExtensionsUtilities.GetMaxFragmentLengthExtension(serverExtensions);
		if (maxFragmentLength >= 0 && (!MaxFragmentLength.IsValid(maxFragmentLength) || (!m_resumedSession && maxFragmentLength != TlsExtensionsUtilities.GetMaxFragmentLengthExtension(clientExtensions))))
		{
			throw new TlsFatalAlert(alertDescription);
		}
		return maxFragmentLength;
	}

	protected virtual void RefuseRenegotiation()
	{
		if (TlsUtilities.IsSsl(Context))
		{
			throw new TlsFatalAlert(40);
		}
		RaiseAlertWarning(100, "Renegotiation not supported");
	}

	internal static void AssertEmpty(MemoryStream buf)
	{
		if (buf.Position < buf.Length)
		{
			throw new TlsFatalAlert(50);
		}
	}

	internal static byte[] CreateRandomBlock(bool useGmtUnixTime, TlsContext context)
	{
		byte[] result = context.NonceGenerator.GenerateNonce(32);
		if (useGmtUnixTime)
		{
			TlsUtilities.WriteGmtUnixTime(result, 0);
		}
		return result;
	}

	internal static byte[] CreateRenegotiationInfo(byte[] renegotiated_connection)
	{
		return TlsUtilities.EncodeOpaque8(renegotiated_connection);
	}

	internal static void EstablishMasterSecret(TlsContext context, TlsKeyExchange keyExchange)
	{
		TlsSecret preMasterSecret = keyExchange.GeneratePreMasterSecret();
		if (preMasterSecret == null)
		{
			throw new TlsFatalAlert(80);
		}
		try
		{
			context.SecurityParameters.m_masterSecret = TlsUtilities.CalculateMasterSecret(context, preMasterSecret);
		}
		finally
		{
			preMasterSecret.Destroy();
		}
	}

	internal static IDictionary ReadExtensions(MemoryStream input)
	{
		if (input.Position >= input.Length)
		{
			return null;
		}
		byte[] extBytes = TlsUtilities.ReadOpaque16(input);
		AssertEmpty(input);
		return ReadExtensionsData(extBytes);
	}

	internal static IDictionary ReadExtensionsData(byte[] extBytes)
	{
		IDictionary extensions = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream buf = new MemoryStream(extBytes, writable: false);
			do
			{
				int extension_type = TlsUtilities.ReadUint16(buf);
				byte[] extension_data = TlsUtilities.ReadOpaque16(buf);
				int key = extension_type;
				if (extensions.Contains(key))
				{
					throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(extension_type));
				}
				extensions.Add(key, extension_data);
			}
			while (buf.Position < buf.Length);
		}
		return extensions;
	}

	internal static IDictionary ReadExtensionsData13(int handshakeType, byte[] extBytes)
	{
		IDictionary extensions = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream buf = new MemoryStream(extBytes, writable: false);
			do
			{
				int extension_type = TlsUtilities.ReadUint16(buf);
				if (!TlsUtilities.IsPermittedExtensionType13(handshakeType, extension_type))
				{
					throw new TlsFatalAlert(47, "Invalid extension: " + ExtensionType.GetText(extension_type));
				}
				byte[] extension_data = TlsUtilities.ReadOpaque16(buf);
				int key = extension_type;
				if (extensions.Contains(key))
				{
					throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(extension_type));
				}
				extensions.Add(key, extension_data);
			}
			while (buf.Position < buf.Length);
		}
		return extensions;
	}

	internal static IDictionary ReadExtensionsDataClientHello(byte[] extBytes)
	{
		IDictionary extensions = Platform.CreateHashtable();
		if (extBytes.Length != 0)
		{
			MemoryStream buf = new MemoryStream(extBytes, writable: false);
			bool pre_shared_key_found = false;
			int extension_type;
			do
			{
				extension_type = TlsUtilities.ReadUint16(buf);
				byte[] extension_data = TlsUtilities.ReadOpaque16(buf);
				int key = extension_type;
				if (extensions.Contains(key))
				{
					throw new TlsFatalAlert(47, "Repeated extension: " + ExtensionType.GetText(extension_type));
				}
				extensions.Add(key, extension_data);
				pre_shared_key_found = pre_shared_key_found || 41 == extension_type;
			}
			while (buf.Position < buf.Length);
			if (pre_shared_key_found && 41 != extension_type)
			{
				throw new TlsFatalAlert(47, "'pre_shared_key' MUST be last in ClientHello");
			}
		}
		return extensions;
	}

	internal static IList ReadSupplementalDataMessage(MemoryStream input)
	{
		byte[] buffer = TlsUtilities.ReadOpaque24(input, 1);
		AssertEmpty(input);
		MemoryStream buf = new MemoryStream(buffer, writable: false);
		IList supplementalData = Platform.CreateArrayList();
		while (buf.Position < buf.Length)
		{
			int supp_data_type = TlsUtilities.ReadUint16(buf);
			byte[] data = TlsUtilities.ReadOpaque16(buf);
			supplementalData.Add(new SupplementalDataEntry(supp_data_type, data));
		}
		return supplementalData;
	}

	internal static void WriteExtensions(Stream output, IDictionary extensions)
	{
		WriteExtensions(output, extensions, 0);
	}

	internal static void WriteExtensions(Stream output, IDictionary extensions, int bindersSize)
	{
		if (extensions != null && extensions.Count >= 1)
		{
			byte[] extBytes = WriteExtensionsData(extensions, bindersSize);
			int i = extBytes.Length + bindersSize;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint16(i, output);
			output.Write(extBytes, 0, extBytes.Length);
		}
	}

	internal static byte[] WriteExtensionsData(IDictionary extensions)
	{
		return WriteExtensionsData(extensions, 0);
	}

	internal static byte[] WriteExtensionsData(IDictionary extensions, int bindersSize)
	{
		MemoryStream buf = new MemoryStream();
		WriteExtensionsData(extensions, buf, bindersSize);
		return buf.ToArray();
	}

	internal static void WriteExtensionsData(IDictionary extensions, MemoryStream buf)
	{
		WriteExtensionsData(extensions, buf, 0);
	}

	internal static void WriteExtensionsData(IDictionary extensions, MemoryStream buf, int bindersSize)
	{
		WriteSelectedExtensions(buf, extensions, selectEmpty: true);
		WriteSelectedExtensions(buf, extensions, selectEmpty: false);
		WritePreSharedKeyExtension(buf, extensions, bindersSize);
	}

	internal static void WritePreSharedKeyExtension(MemoryStream buf, IDictionary extensions, int bindersSize)
	{
		byte[] extension_data = (byte[])extensions[41];
		if (extension_data != null)
		{
			TlsUtilities.CheckUint16(41);
			TlsUtilities.WriteUint16(41, buf);
			int i = extension_data.Length + bindersSize;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint16(i, buf);
			buf.Write(extension_data, 0, extension_data.Length);
		}
	}

	internal static void WriteSelectedExtensions(Stream output, IDictionary extensions, bool selectEmpty)
	{
		foreach (int key in extensions.Keys)
		{
			int extension_type = key;
			if (41 != extension_type)
			{
				byte[] extension_data = (byte[])extensions[key];
				if (selectEmpty == (extension_data.Length == 0))
				{
					TlsUtilities.CheckUint16(extension_type);
					TlsUtilities.WriteUint16(extension_type, output);
					TlsUtilities.WriteOpaque16(extension_data, output);
				}
			}
		}
	}

	internal static void WriteSupplementalData(Stream output, IList supplementalData)
	{
		MemoryStream buf = new MemoryStream();
		foreach (SupplementalDataEntry supplementalDatum in supplementalData)
		{
			int dataType = supplementalDatum.DataType;
			TlsUtilities.CheckUint16(dataType);
			TlsUtilities.WriteUint16(dataType, buf);
			TlsUtilities.WriteOpaque16(supplementalDatum.Data, buf);
		}
		TlsUtilities.WriteOpaque24(buf.ToArray(), output);
	}
}
