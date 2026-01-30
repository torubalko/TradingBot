using System;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls;

internal class DtlsRecordLayer : DatagramTransport, DatagramReceiver, DatagramSender, TlsCloseable
{
	private const int RECORD_HEADER_LENGTH = 13;

	private const int MAX_FRAGMENT_LENGTH = 16384;

	private const long TCP_MSL = 120000L;

	private const long RETRANSMIT_TIMEOUT = 240000L;

	private readonly TlsContext m_context;

	private readonly TlsPeer m_peer;

	private readonly DatagramTransport m_transport;

	private readonly ByteQueue m_recordQueue = new ByteQueue();

	private readonly object m_writeLock = new object();

	private volatile bool m_closed;

	private volatile bool m_failed;

	private volatile ProtocolVersion m_readVersion;

	private volatile ProtocolVersion m_writeVersion;

	private volatile bool m_inConnection;

	private volatile bool m_inHandshake;

	private volatile int m_plaintextLimit;

	private DtlsEpoch m_currentEpoch;

	private DtlsEpoch m_pendingEpoch;

	private DtlsEpoch m_readEpoch;

	private DtlsEpoch m_writeEpoch;

	private DtlsHandshakeRetransmit m_retransmit;

	private DtlsEpoch m_retransmitEpoch;

	private Timeout m_retransmitTimeout;

	private TlsHeartbeat m_heartbeat;

	private bool m_heartBeatResponder;

	private HeartbeatMessage m_heartbeatInFlight;

	private Timeout m_heartbeatTimeout;

	private int m_heartbeatResendMillis = -1;

	private Timeout m_heartbeatResendTimeout;

	internal virtual bool IsClosed => m_closed;

	internal virtual int ReadEpoch => m_readEpoch.Epoch;

	internal virtual ProtocolVersion ReadVersion
	{
		get
		{
			return m_readVersion;
		}
		set
		{
			m_readVersion = value;
		}
	}

	internal static byte[] ReceiveClientHelloRecord(byte[] data, int dataOff, int dataLen)
	{
		if (dataLen < 13)
		{
			return null;
		}
		short contentType = TlsUtilities.ReadUint8(data, dataOff);
		if (22 != contentType)
		{
			return null;
		}
		ProtocolVersion version = TlsUtilities.ReadVersion(data, dataOff + 1);
		if (!ProtocolVersion.DTLSv10.IsEqualOrEarlierVersionOf(version))
		{
			return null;
		}
		if (TlsUtilities.ReadUint16(data, dataOff + 3) != 0)
		{
			return null;
		}
		int length = TlsUtilities.ReadUint16(data, dataOff + 11);
		if (dataLen < 13 + length)
		{
			return null;
		}
		if (length > 16384)
		{
			return null;
		}
		return TlsUtilities.CopyOfRangeExact(data, dataOff + 13, dataOff + 13 + length);
	}

	internal static void SendHelloVerifyRequestRecord(DatagramSender sender, long recordSeq, byte[] message)
	{
		TlsUtilities.CheckUint16(message.Length);
		byte[] record = new byte[13 + message.Length];
		TlsUtilities.WriteUint8((short)22, record, 0);
		TlsUtilities.WriteVersion(ProtocolVersion.DTLSv10, record, 1);
		TlsUtilities.WriteUint16(0, record, 3);
		TlsUtilities.WriteUint48(recordSeq, record, 5);
		TlsUtilities.WriteUint16(message.Length, record, 11);
		Array.Copy(message, 0, record, 13, message.Length);
		SendDatagram(sender, record, 0, record.Length);
	}

	private static void SendDatagram(DatagramSender sender, byte[] buf, int off, int len)
	{
		sender.Send(buf, off, len);
	}

	internal DtlsRecordLayer(TlsContext context, TlsPeer peer, DatagramTransport transport)
	{
		m_context = context;
		m_peer = peer;
		m_transport = transport;
		m_inHandshake = true;
		m_currentEpoch = new DtlsEpoch(0, TlsNullNullCipher.Instance);
		m_pendingEpoch = null;
		m_readEpoch = m_currentEpoch;
		m_writeEpoch = m_currentEpoch;
		SetPlaintextLimit(16384);
	}

	internal virtual void ResetAfterHelloVerifyRequestServer(long recordSeq)
	{
		m_inConnection = true;
		m_currentEpoch.SequenceNumber = recordSeq;
		m_currentEpoch.ReplayWindow.Reset(recordSeq);
	}

	internal virtual void SetPlaintextLimit(int plaintextLimit)
	{
		m_plaintextLimit = plaintextLimit;
	}

	internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
	{
		m_writeVersion = writeVersion;
	}

	internal virtual void InitPendingEpoch(TlsCipher pendingCipher)
	{
		if (m_pendingEpoch != null)
		{
			throw new InvalidOperationException();
		}
		m_pendingEpoch = new DtlsEpoch(m_writeEpoch.Epoch + 1, pendingCipher);
	}

	internal virtual void HandshakeSuccessful(DtlsHandshakeRetransmit retransmit)
	{
		if (m_readEpoch == m_currentEpoch || m_writeEpoch == m_currentEpoch)
		{
			throw new InvalidOperationException();
		}
		if (retransmit != null)
		{
			m_retransmit = retransmit;
			m_retransmitEpoch = m_currentEpoch;
			m_retransmitTimeout = new Timeout(240000L);
		}
		m_inHandshake = false;
		m_currentEpoch = m_pendingEpoch;
		m_pendingEpoch = null;
	}

	internal virtual void InitHeartbeat(TlsHeartbeat heartbeat, bool heartbeatResponder)
	{
		if (m_inHandshake)
		{
			throw new InvalidOperationException();
		}
		m_heartbeat = heartbeat;
		m_heartBeatResponder = heartbeatResponder;
		if (heartbeat != null)
		{
			ResetHeartbeat();
		}
	}

	internal virtual void ResetWriteEpoch()
	{
		if (m_retransmitEpoch != null)
		{
			m_writeEpoch = m_retransmitEpoch;
		}
		else
		{
			m_writeEpoch = m_currentEpoch;
		}
	}

	public virtual int GetReceiveLimit()
	{
		return System.Math.Min(m_plaintextLimit, m_readEpoch.Cipher.GetPlaintextLimit(m_transport.GetReceiveLimit() - 13));
	}

	public virtual int GetSendLimit()
	{
		return System.Math.Min(m_plaintextLimit, m_writeEpoch.Cipher.GetPlaintextLimit(m_transport.GetSendLimit() - 13));
	}

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
	{
		long currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		Timeout timeout = Timeout.ForWaitMillis(waitMillis, currentTimeMillis);
		byte[] record = null;
		while (waitMillis >= 0)
		{
			if (m_retransmitTimeout != null && m_retransmitTimeout.RemainingMillis(currentTimeMillis) < 1)
			{
				m_retransmit = null;
				m_retransmitEpoch = null;
				m_retransmitTimeout = null;
			}
			if (Timeout.HasExpired(m_heartbeatTimeout, currentTimeMillis))
			{
				if (m_heartbeatInFlight != null)
				{
					throw new TlsTimeoutException("Heartbeat timed out");
				}
				m_heartbeatInFlight = HeartbeatMessage.Create(m_context, 1, m_heartbeat.GeneratePayload());
				m_heartbeatTimeout = new Timeout(m_heartbeat.TimeoutMillis, currentTimeMillis);
				m_heartbeatResendMillis = 1000;
				m_heartbeatResendTimeout = new Timeout(m_heartbeatResendMillis, currentTimeMillis);
				SendHeartbeatMessage(m_heartbeatInFlight);
			}
			else if (Timeout.HasExpired(m_heartbeatResendTimeout, currentTimeMillis))
			{
				m_heartbeatResendMillis = DtlsReliableHandshake.BackOff(m_heartbeatResendMillis);
				m_heartbeatResendTimeout = new Timeout(m_heartbeatResendMillis, currentTimeMillis);
				SendHeartbeatMessage(m_heartbeatInFlight);
			}
			waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_heartbeatTimeout, currentTimeMillis);
			waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_heartbeatResendTimeout, currentTimeMillis);
			if (waitMillis < 0)
			{
				waitMillis = 1;
			}
			int receiveLimit = System.Math.Min(len, GetReceiveLimit()) + 13;
			if (record == null || record.Length < receiveLimit)
			{
				record = new byte[receiveLimit];
			}
			int received = ReceiveRecord(record, 0, receiveLimit, waitMillis);
			int processed = ProcessRecord(received, record, buf, off);
			if (processed >= 0)
			{
				return processed;
			}
			currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
			waitMillis = Timeout.GetWaitMillis(timeout, currentTimeMillis);
		}
		return -1;
	}

	public virtual void Send(byte[] buf, int off, int len)
	{
		short contentType = 23;
		if (m_inHandshake || m_writeEpoch == m_retransmitEpoch)
		{
			contentType = 22;
			if (TlsUtilities.ReadUint8(buf, off) == 20)
			{
				DtlsEpoch nextEpoch = null;
				if (m_inHandshake)
				{
					nextEpoch = m_pendingEpoch;
				}
				else if (m_writeEpoch == m_retransmitEpoch)
				{
					nextEpoch = m_currentEpoch;
				}
				if (nextEpoch == null)
				{
					throw new InvalidOperationException();
				}
				byte[] data = new byte[1] { 1 };
				SendRecord(20, data, 0, data.Length);
				m_writeEpoch = nextEpoch;
			}
		}
		SendRecord(contentType, buf, off, len);
	}

	public virtual void Close()
	{
		if (!m_closed)
		{
			if (m_inHandshake && m_inConnection)
			{
				Warn(90, "User canceled handshake");
			}
			CloseTransport();
		}
	}

	internal virtual void Fail(short alertDescription)
	{
		if (m_closed)
		{
			return;
		}
		if (m_inConnection)
		{
			try
			{
				RaiseAlert(2, alertDescription, null, null);
			}
			catch (Exception)
			{
			}
		}
		m_failed = true;
		CloseTransport();
	}

	internal virtual void Failed()
	{
		if (!m_closed)
		{
			m_failed = true;
			CloseTransport();
		}
	}

	internal virtual void Warn(short alertDescription, string message)
	{
		RaiseAlert(1, alertDescription, message, null);
	}

	private void CloseTransport()
	{
		if (m_closed)
		{
			return;
		}
		try
		{
			if (!m_failed)
			{
				Warn(0, null);
			}
			m_transport.Close();
		}
		catch (Exception)
		{
		}
		m_closed = true;
	}

	private void RaiseAlert(short alertLevel, short alertDescription, string message, Exception cause)
	{
		m_peer.NotifyAlertRaised(alertLevel, alertDescription, message, cause);
		SendRecord(21, new byte[2]
		{
			(byte)alertLevel,
			(byte)alertDescription
		}, 0, 2);
	}

	private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
	{
		try
		{
			return m_transport.Receive(buf, off, len, waitMillis);
		}
		catch (TlsTimeoutException)
		{
			return -1;
		}
		catch (SocketException ex2)
		{
			if (TlsUtilities.IsTimeout(ex2))
			{
				return -1;
			}
			throw ex2;
		}
	}

	private int ProcessRecord(int received, byte[] record, byte[] buf, int off)
	{
		if (received < 13)
		{
			return -1;
		}
		int length = TlsUtilities.ReadUint16(record, 11);
		if (received != length + 13)
		{
			return -1;
		}
		short recordType = TlsUtilities.ReadUint8(record, 0);
		if ((uint)(recordType - 20) > 4u)
		{
			return -1;
		}
		int epoch = TlsUtilities.ReadUint16(record, 3);
		DtlsEpoch recordEpoch = null;
		if (epoch == m_readEpoch.Epoch)
		{
			recordEpoch = m_readEpoch;
		}
		else if (recordType == 22 && m_retransmitEpoch != null && epoch == m_retransmitEpoch.Epoch)
		{
			recordEpoch = m_retransmitEpoch;
		}
		if (recordEpoch == null)
		{
			return -1;
		}
		long seq = TlsUtilities.ReadUint48(record, 5);
		if (recordEpoch.ReplayWindow.ShouldDiscard(seq))
		{
			return -1;
		}
		ProtocolVersion recordVersion = TlsUtilities.ReadVersion(record, 1);
		if (!recordVersion.IsDtls)
		{
			return -1;
		}
		if (m_readVersion != null && !m_readVersion.Equals(recordVersion) && (ReadEpoch != 0 || length <= 0 || 22 != recordType || 1 != TlsUtilities.ReadUint8(record, 13)))
		{
			return -1;
		}
		long macSeqNo = GetMacSequenceNumber(recordEpoch.Epoch, seq);
		TlsDecodeResult decoded = recordEpoch.Cipher.DecodeCiphertext(macSeqNo, recordType, recordVersion, record, 13, length);
		recordEpoch.ReplayWindow.ReportAuthenticated(seq);
		if (decoded.len > m_plaintextLimit)
		{
			return -1;
		}
		if (decoded.len < 1 && decoded.contentType != 23)
		{
			return -1;
		}
		if (m_readVersion == null)
		{
			if (ReadEpoch == 0 && length > 0 && 22 == recordType && 3 == TlsUtilities.ReadUint8(record, 13))
			{
				if (!ProtocolVersion.DTLSv12.IsEqualOrLaterVersionOf(recordVersion))
				{
					return -1;
				}
			}
			else
			{
				m_readVersion = recordVersion;
			}
		}
		switch (decoded.contentType)
		{
		case 21:
			if (decoded.len == 2)
			{
				short alertLevel = TlsUtilities.ReadUint8(decoded.buf, decoded.off);
				short alertDescription = TlsUtilities.ReadUint8(decoded.buf, decoded.off + 1);
				m_peer.NotifyAlertReceived(alertLevel, alertDescription);
				if (alertLevel == 2)
				{
					Failed();
					throw new TlsFatalAlert(alertDescription);
				}
				if (alertDescription == 0)
				{
					CloseTransport();
				}
			}
			return -1;
		case 23:
			if (m_inHandshake)
			{
				return -1;
			}
			break;
		case 20:
		{
			for (int i = 0; i < decoded.len; i++)
			{
				if (TlsUtilities.ReadUint8(decoded.buf, decoded.off + i) == 1 && m_pendingEpoch != null)
				{
					m_readEpoch = m_pendingEpoch;
				}
			}
			return -1;
		}
		case 22:
			if (!m_inHandshake)
			{
				if (m_retransmit != null)
				{
					m_retransmit.ReceivedHandshakeRecord(epoch, decoded.buf, decoded.off, decoded.len);
				}
				return -1;
			}
			break;
		case 24:
			if (m_heartbeatInFlight != null || m_heartBeatResponder)
			{
				try
				{
					HeartbeatMessage heartbeatMessage = HeartbeatMessage.Parse(new MemoryStream(decoded.buf, decoded.off, decoded.len, writable: false));
					if (heartbeatMessage != null)
					{
						switch (heartbeatMessage.Type)
						{
						case 1:
							if (m_heartBeatResponder)
							{
								HeartbeatMessage response = HeartbeatMessage.Create(m_context, 2, heartbeatMessage.Payload);
								SendHeartbeatMessage(response);
							}
							break;
						case 2:
							if (m_heartbeatInFlight != null && Arrays.AreEqual(heartbeatMessage.Payload, m_heartbeatInFlight.Payload))
							{
								ResetHeartbeat();
							}
							break;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			return -1;
		default:
			return -1;
		}
		if (!m_inHandshake && m_retransmit != null)
		{
			m_retransmit = null;
			m_retransmitEpoch = null;
			m_retransmitTimeout = null;
		}
		Array.Copy(decoded.buf, decoded.off, buf, off, decoded.len);
		return decoded.len;
	}

	private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
	{
		if (m_recordQueue.Available > 0)
		{
			int length = 0;
			if (m_recordQueue.Available >= 13)
			{
				byte[] lengthBytes = new byte[2];
				m_recordQueue.Read(lengthBytes, 0, 2, 11);
				length = TlsUtilities.ReadUint16(lengthBytes, 0);
			}
			int received = System.Math.Min(m_recordQueue.Available, 13 + length);
			m_recordQueue.RemoveData(buf, off, received, 0);
			return received;
		}
		int received2 = ReceiveDatagram(buf, off, len, waitMillis);
		if (received2 >= 13)
		{
			m_inConnection = true;
			int fragmentLength = TlsUtilities.ReadUint16(buf, off + 11);
			int recordLength = 13 + fragmentLength;
			if (received2 > recordLength)
			{
				m_recordQueue.AddData(buf, off + recordLength, received2 - recordLength);
				received2 = recordLength;
			}
		}
		return received2;
	}

	private void ResetHeartbeat()
	{
		m_heartbeatInFlight = null;
		m_heartbeatResendMillis = -1;
		m_heartbeatResendTimeout = null;
		m_heartbeatTimeout = new Timeout(m_heartbeat.IdleMillis);
	}

	private void SendHeartbeatMessage(HeartbeatMessage heartbeatMessage)
	{
		MemoryStream output = new MemoryStream();
		heartbeatMessage.Encode(output);
		byte[] buf = output.ToArray();
		SendRecord(24, buf, 0, buf.Length);
	}

	private void SendRecord(short contentType, byte[] buf, int off, int len)
	{
		if (m_writeVersion == null)
		{
			return;
		}
		if (len > m_plaintextLimit)
		{
			throw new TlsFatalAlert(80);
		}
		if (len < 1 && contentType != 23)
		{
			throw new TlsFatalAlert(80);
		}
		lock (m_writeLock)
		{
			int recordEpoch = m_writeEpoch.Epoch;
			long recordSequenceNumber = m_writeEpoch.AllocateSequenceNumber();
			long macSequenceNumber = GetMacSequenceNumber(recordEpoch, recordSequenceNumber);
			ProtocolVersion recordVersion = m_writeVersion;
			TlsEncodeResult encoded = m_writeEpoch.Cipher.EncodePlaintext(macSequenceNumber, contentType, recordVersion, 13, buf, off, len);
			int i = encoded.len - 13;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint8(encoded.recordType, encoded.buf, encoded.off);
			TlsUtilities.WriteVersion(recordVersion, encoded.buf, encoded.off + 1);
			TlsUtilities.WriteUint16(recordEpoch, encoded.buf, encoded.off + 3);
			TlsUtilities.WriteUint48(recordSequenceNumber, encoded.buf, encoded.off + 5);
			TlsUtilities.WriteUint16(i, encoded.buf, encoded.off + 11);
			SendDatagram(m_transport, encoded.buf, encoded.off, encoded.len);
		}
	}

	private static long GetMacSequenceNumber(int epoch, long sequence_number)
	{
		return ((epoch & 0xFFFFFFFFu) << 48) | sequence_number;
	}
}
