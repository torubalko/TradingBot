using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Tls;

internal class DtlsReliableHandshake
{
	internal class Message
	{
		private readonly int m_message_seq;

		private readonly short m_msg_type;

		private readonly byte[] m_body;

		public int Seq => m_message_seq;

		public short Type => m_msg_type;

		public byte[] Body => m_body;

		internal Message(int message_seq, short msg_type, byte[] body)
		{
			m_message_seq = message_seq;
			m_msg_type = msg_type;
			m_body = body;
		}
	}

	internal class RecordLayerBuffer : MemoryStream
	{
		internal RecordLayerBuffer(int size)
			: base(size)
		{
		}

		internal void SendToRecordLayer(DtlsRecordLayer recordLayer)
		{
			byte[] buf = GetBuffer();
			int bufLen = (int)Length;
			recordLayer.Send(buf, 0, bufLen);
			Platform.Dispose(this);
		}
	}

	internal class Retransmit : DtlsHandshakeRetransmit
	{
		private readonly DtlsReliableHandshake m_outer;

		internal Retransmit(DtlsReliableHandshake outer)
		{
			m_outer = outer;
		}

		public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
		{
			m_outer.ProcessRecord(0, epoch, buf, off, len);
		}
	}

	private const int MAX_RECEIVE_AHEAD = 16;

	private const int MESSAGE_HEADER_LENGTH = 12;

	internal const int INITIAL_RESEND_MILLIS = 1000;

	private const int MAX_RESEND_MILLIS = 60000;

	private DtlsRecordLayer m_recordLayer;

	private Timeout m_handshakeTimeout;

	private TlsHandshakeHash m_handshakeHash;

	private IDictionary m_currentInboundFlight = Platform.CreateHashtable();

	private IDictionary m_previousInboundFlight;

	private IList m_outboundFlight = Platform.CreateArrayList();

	private int m_resendMillis = -1;

	private Timeout m_resendTimeout;

	private int m_next_send_seq;

	private int m_next_receive_seq;

	internal TlsHandshakeHash HandshakeHash => m_handshakeHash;

	internal static DtlsRequest ReadClientRequest(byte[] data, int dataOff, int dataLen, Stream dtlsOutput)
	{
		byte[] message = DtlsRecordLayer.ReceiveClientHelloRecord(data, dataOff, dataLen);
		if (message == null || message.Length < 12)
		{
			return null;
		}
		long recordSeq = TlsUtilities.ReadUint48(data, dataOff + 5);
		short msgType = TlsUtilities.ReadUint8(message, 0);
		if (1 != msgType)
		{
			return null;
		}
		int length = TlsUtilities.ReadUint24(message, 1);
		if (message.Length != 12 + length)
		{
			return null;
		}
		if (TlsUtilities.ReadUint24(message, 6) != 0)
		{
			return null;
		}
		int fragmentLength = TlsUtilities.ReadUint24(message, 9);
		if (length != fragmentLength)
		{
			return null;
		}
		ClientHello clientHello = ClientHello.Parse(new MemoryStream(message, 12, length, writable: false), dtlsOutput);
		return new DtlsRequest(recordSeq, message, clientHello);
	}

	internal static void SendHelloVerifyRequest(DatagramSender sender, long recordSeq, byte[] cookie)
	{
		TlsUtilities.CheckUint8(cookie.Length);
		int length = 3 + cookie.Length;
		byte[] message = new byte[12 + length];
		TlsUtilities.WriteUint8((short)3, message, 0);
		TlsUtilities.WriteUint24(length, message, 1);
		TlsUtilities.WriteUint24(length, message, 9);
		TlsUtilities.WriteVersion(ProtocolVersion.DTLSv10, message, 12);
		TlsUtilities.WriteOpaque8(cookie, message, 14);
		DtlsRecordLayer.SendHelloVerifyRequestRecord(sender, recordSeq, message);
	}

	internal DtlsReliableHandshake(TlsContext context, DtlsRecordLayer transport, int timeoutMillis, DtlsRequest request)
	{
		m_recordLayer = transport;
		m_handshakeHash = new DeferredHash(context);
		m_handshakeTimeout = Timeout.ForWaitMillis(timeoutMillis);
		if (request != null)
		{
			m_resendMillis = 1000;
			m_resendTimeout = new Timeout(m_resendMillis);
			long recordSeq = request.RecordSeq;
			int messageSeq = request.MessageSeq;
			byte[] message = request.Message;
			m_recordLayer.ResetAfterHelloVerifyRequestServer(recordSeq);
			DtlsReassembler reassembler = new DtlsReassembler(1, message.Length - 12);
			m_currentInboundFlight[messageSeq] = reassembler;
			m_next_send_seq = 1;
			m_next_receive_seq = messageSeq + 1;
			m_handshakeHash.Update(message, 0, message.Length);
		}
	}

	internal void ResetAfterHelloVerifyRequestClient()
	{
		m_currentInboundFlight = Platform.CreateHashtable();
		m_previousInboundFlight = null;
		m_outboundFlight = Platform.CreateArrayList();
		m_resendMillis = -1;
		m_resendTimeout = null;
		m_next_receive_seq = 1;
		m_handshakeHash.Reset();
	}

	internal TlsHandshakeHash PrepareToFinish()
	{
		TlsHandshakeHash handshakeHash = m_handshakeHash;
		m_handshakeHash = m_handshakeHash.StopTracking();
		return handshakeHash;
	}

	internal void SendMessage(short msg_type, byte[] body)
	{
		TlsUtilities.CheckUint24(body.Length);
		if (m_resendTimeout != null)
		{
			CheckInboundFlight();
			m_resendMillis = -1;
			m_resendTimeout = null;
			m_outboundFlight.Clear();
		}
		Message message = new Message(m_next_send_seq++, msg_type, body);
		m_outboundFlight.Add(message);
		WriteMessage(message);
		UpdateHandshakeMessagesDigest(message);
	}

	internal byte[] ReceiveMessageBody(short msg_type)
	{
		Message message = ReceiveMessage();
		if (message.Type != msg_type)
		{
			throw new TlsFatalAlert(10);
		}
		return message.Body;
	}

	internal Message ReceiveMessage()
	{
		long currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		if (m_resendTimeout == null)
		{
			m_resendMillis = 1000;
			m_resendTimeout = new Timeout(m_resendMillis, currentTimeMillis);
			PrepareInboundFlight(Platform.CreateHashtable());
		}
		byte[] buf = null;
		while (true)
		{
			if (m_recordLayer.IsClosed)
			{
				throw new TlsFatalAlert(90);
			}
			Message pending = GetPendingMessage();
			if (pending != null)
			{
				return pending;
			}
			if (Timeout.HasExpired(m_handshakeTimeout, currentTimeMillis))
			{
				break;
			}
			int waitMillis = Timeout.GetWaitMillis(m_handshakeTimeout, currentTimeMillis);
			waitMillis = Timeout.ConstrainWaitMillis(waitMillis, m_resendTimeout, currentTimeMillis);
			if (waitMillis < 1)
			{
				waitMillis = 1;
			}
			int receiveLimit = m_recordLayer.GetReceiveLimit();
			if (buf == null || buf.Length < receiveLimit)
			{
				buf = new byte[receiveLimit];
			}
			int received = m_recordLayer.Receive(buf, 0, receiveLimit, waitMillis);
			if (received < 0)
			{
				ResendOutboundFlight();
			}
			else
			{
				ProcessRecord(16, m_recordLayer.ReadEpoch, buf, 0, received);
			}
			currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		}
		throw new TlsTimeoutException("Handshake timed out");
	}

	internal void Finish()
	{
		DtlsHandshakeRetransmit retransmit = null;
		if (m_resendTimeout != null)
		{
			CheckInboundFlight();
		}
		else
		{
			PrepareInboundFlight(null);
			if (m_previousInboundFlight != null)
			{
				retransmit = new Retransmit(this);
			}
		}
		m_recordLayer.HandshakeSuccessful(retransmit);
	}

	internal static int BackOff(int timeoutMillis)
	{
		return System.Math.Min(timeoutMillis * 2, 60000);
	}

	private void CheckInboundFlight()
	{
		foreach (int key in m_currentInboundFlight.Keys)
		{
			_ = key;
			_ = m_next_receive_seq;
		}
	}

	private Message GetPendingMessage()
	{
		DtlsReassembler next = (DtlsReassembler)m_currentInboundFlight[m_next_receive_seq];
		if (next != null)
		{
			byte[] body = next.GetBodyIfComplete();
			if (body != null)
			{
				m_previousInboundFlight = null;
				return UpdateHandshakeMessagesDigest(new Message(m_next_receive_seq++, next.MsgType, body));
			}
		}
		return null;
	}

	private void PrepareInboundFlight(IDictionary nextFlight)
	{
		ResetAll(m_currentInboundFlight);
		m_previousInboundFlight = m_currentInboundFlight;
		m_currentInboundFlight = nextFlight;
	}

	private void ProcessRecord(int windowSize, int epoch, byte[] buf, int off, int len)
	{
		bool checkPreviousFlight = false;
		while (len >= 12)
		{
			int fragment_length = TlsUtilities.ReadUint24(buf, off + 9);
			int message_length = fragment_length + 12;
			if (len < message_length)
			{
				break;
			}
			int length = TlsUtilities.ReadUint24(buf, off + 1);
			int fragment_offset = TlsUtilities.ReadUint24(buf, off + 6);
			if (fragment_offset + fragment_length > length)
			{
				break;
			}
			short msg_type = TlsUtilities.ReadUint8(buf, off);
			int expectedEpoch = ((msg_type == 20) ? 1 : 0);
			if (epoch != expectedEpoch)
			{
				break;
			}
			int message_seq = TlsUtilities.ReadUint16(buf, off + 4);
			if (message_seq < m_next_receive_seq + windowSize)
			{
				if (message_seq >= m_next_receive_seq)
				{
					DtlsReassembler reassembler = (DtlsReassembler)m_currentInboundFlight[message_seq];
					if (reassembler == null)
					{
						reassembler = new DtlsReassembler(msg_type, length);
						m_currentInboundFlight[message_seq] = reassembler;
					}
					reassembler.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
				}
				else if (m_previousInboundFlight != null)
				{
					DtlsReassembler reassembler2 = (DtlsReassembler)m_previousInboundFlight[message_seq];
					if (reassembler2 != null)
					{
						reassembler2.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
						checkPreviousFlight = true;
					}
				}
			}
			off += message_length;
			len -= message_length;
		}
		if (checkPreviousFlight && CheckAll(m_previousInboundFlight))
		{
			ResendOutboundFlight();
			ResetAll(m_previousInboundFlight);
		}
	}

	private void ResendOutboundFlight()
	{
		m_recordLayer.ResetWriteEpoch();
		foreach (Message message in m_outboundFlight)
		{
			WriteMessage(message);
		}
		m_resendMillis = BackOff(m_resendMillis);
		m_resendTimeout = new Timeout(m_resendMillis);
	}

	private Message UpdateHandshakeMessagesDigest(Message message)
	{
		short msg_type = message.Type;
		switch (msg_type)
		{
		default:
		{
			byte[] body = message.Body;
			byte[] buf = new byte[12];
			TlsUtilities.WriteUint8(msg_type, buf, 0);
			TlsUtilities.WriteUint24(body.Length, buf, 1);
			TlsUtilities.WriteUint16(message.Seq, buf, 4);
			TlsUtilities.WriteUint24(0, buf, 6);
			TlsUtilities.WriteUint24(body.Length, buf, 9);
			m_handshakeHash.Update(buf, 0, buf.Length);
			m_handshakeHash.Update(body, 0, body.Length);
			break;
		}
		case 0:
		case 3:
		case 24:
			break;
		}
		return message;
	}

	private void WriteMessage(Message message)
	{
		int fragmentLimit = m_recordLayer.GetSendLimit() - 12;
		if (fragmentLimit < 1)
		{
			throw new TlsFatalAlert(80);
		}
		int length = message.Body.Length;
		int fragment_offset = 0;
		do
		{
			int fragment_length = System.Math.Min(length - fragment_offset, fragmentLimit);
			WriteHandshakeFragment(message, fragment_offset, fragment_length);
			fragment_offset += fragment_length;
		}
		while (fragment_offset < length);
	}

	private void WriteHandshakeFragment(Message message, int fragment_offset, int fragment_length)
	{
		RecordLayerBuffer fragment = new RecordLayerBuffer(12 + fragment_length);
		TlsUtilities.WriteUint8(message.Type, fragment);
		TlsUtilities.WriteUint24(message.Body.Length, fragment);
		TlsUtilities.WriteUint16(message.Seq, fragment);
		TlsUtilities.WriteUint24(fragment_offset, fragment);
		TlsUtilities.WriteUint24(fragment_length, fragment);
		fragment.Write(message.Body, fragment_offset, fragment_length);
		fragment.SendToRecordLayer(m_recordLayer);
	}

	private static bool CheckAll(IDictionary inboundFlight)
	{
		foreach (DtlsReassembler value in inboundFlight.Values)
		{
			if (value.GetBodyIfComplete() == null)
			{
				return false;
			}
		}
		return true;
	}

	private static void ResetAll(IDictionary inboundFlight)
	{
		foreach (DtlsReassembler value in inboundFlight.Values)
		{
			value.Reset();
		}
	}
}
