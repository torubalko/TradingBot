using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Tls;

internal class DtlsReliableHandshake
{
	internal class Message
	{
		private readonly int mMessageSeq;

		private readonly byte mMsgType;

		private readonly byte[] mBody;

		public int Seq => mMessageSeq;

		public byte Type => mMsgType;

		public byte[] Body => mBody;

		internal Message(int message_seq, byte msg_type, byte[] body)
		{
			mMessageSeq = message_seq;
			mMsgType = msg_type;
			mBody = body;
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
		private readonly DtlsReliableHandshake mOuter;

		internal Retransmit(DtlsReliableHandshake outer)
		{
			mOuter = outer;
		}

		public void ReceivedHandshakeRecord(int epoch, byte[] buf, int off, int len)
		{
			mOuter.ProcessRecord(0, epoch, buf, off, len);
		}
	}

	private const int MaxReceiveAhead = 16;

	private const int MessageHeaderLength = 12;

	private const int InitialResendMillis = 1000;

	private const int MaxResendMillis = 60000;

	private readonly DtlsRecordLayer mRecordLayer;

	private readonly Timeout mHandshakeTimeout;

	private TlsHandshakeHash mHandshakeHash;

	private IDictionary mCurrentInboundFlight = Platform.CreateHashtable();

	private IDictionary mPreviousInboundFlight;

	private IList mOutboundFlight = Platform.CreateArrayList();

	private int mResendMillis = -1;

	private Timeout mResendTimeout;

	private int mMessageSeq;

	private int mNextReceiveSeq;

	internal TlsHandshakeHash HandshakeHash => mHandshakeHash;

	internal DtlsReliableHandshake(TlsContext context, DtlsRecordLayer transport, int timeoutMillis)
	{
		mRecordLayer = transport;
		mHandshakeTimeout = Timeout.ForWaitMillis(timeoutMillis);
		mHandshakeHash = new DeferredHash();
		mHandshakeHash.Init(context);
	}

	internal void NotifyHelloComplete()
	{
		mHandshakeHash = mHandshakeHash.NotifyPrfDetermined();
	}

	internal TlsHandshakeHash PrepareToFinish()
	{
		TlsHandshakeHash result = mHandshakeHash;
		mHandshakeHash = mHandshakeHash.StopTracking();
		return result;
	}

	internal void SendMessage(byte msg_type, byte[] body)
	{
		TlsUtilities.CheckUint24(body.Length);
		if (mResendTimeout != null)
		{
			CheckInboundFlight();
			mResendMillis = -1;
			mResendTimeout = null;
			mOutboundFlight.Clear();
		}
		Message message = new Message(mMessageSeq++, msg_type, body);
		mOutboundFlight.Add(message);
		WriteMessage(message);
		UpdateHandshakeMessagesDigest(message);
	}

	internal byte[] ReceiveMessageBody(byte msg_type)
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
		if (mResendTimeout == null)
		{
			mResendMillis = 1000;
			mResendTimeout = new Timeout(mResendMillis, currentTimeMillis);
			PrepareInboundFlight(Platform.CreateHashtable());
		}
		byte[] buf = null;
		while (true)
		{
			if (mRecordLayer.IsClosed)
			{
				throw new TlsFatalAlert(90);
			}
			Message pending = GetPendingMessage();
			if (pending != null)
			{
				return pending;
			}
			int handshakeMillis = Timeout.GetWaitMillis(mHandshakeTimeout, currentTimeMillis);
			if (handshakeMillis < 0)
			{
				break;
			}
			int waitMillis = System.Math.Max(1, Timeout.GetWaitMillis(mResendTimeout, currentTimeMillis));
			if (handshakeMillis > 0)
			{
				waitMillis = System.Math.Min(waitMillis, handshakeMillis);
			}
			int receiveLimit = mRecordLayer.GetReceiveLimit();
			if (buf == null || buf.Length < receiveLimit)
			{
				buf = new byte[receiveLimit];
			}
			int received = mRecordLayer.Receive(buf, 0, receiveLimit, waitMillis);
			if (received < 0)
			{
				ResendOutboundFlight();
			}
			else
			{
				ProcessRecord(16, mRecordLayer.ReadEpoch, buf, 0, received);
			}
			currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		}
		throw new TlsFatalAlert(40);
	}

	internal void Finish()
	{
		DtlsHandshakeRetransmit retransmit = null;
		if (mResendTimeout != null)
		{
			CheckInboundFlight();
		}
		else
		{
			PrepareInboundFlight(null);
			if (mPreviousInboundFlight != null)
			{
				retransmit = new Retransmit(this);
			}
		}
		mRecordLayer.HandshakeSuccessful(retransmit);
	}

	internal void ResetHandshakeMessagesDigest()
	{
		mHandshakeHash.Reset();
	}

	private int BackOff(int timeoutMillis)
	{
		return System.Math.Min(timeoutMillis * 2, 60000);
	}

	private void CheckInboundFlight()
	{
		foreach (int key in mCurrentInboundFlight.Keys)
		{
			_ = key;
			_ = mNextReceiveSeq;
		}
	}

	private Message GetPendingMessage()
	{
		DtlsReassembler next = (DtlsReassembler)mCurrentInboundFlight[mNextReceiveSeq];
		if (next != null)
		{
			byte[] body = next.GetBodyIfComplete();
			if (body != null)
			{
				mPreviousInboundFlight = null;
				return UpdateHandshakeMessagesDigest(new Message(mNextReceiveSeq++, next.MsgType, body));
			}
		}
		return null;
	}

	private void PrepareInboundFlight(IDictionary nextFlight)
	{
		ResetAll(mCurrentInboundFlight);
		mPreviousInboundFlight = mCurrentInboundFlight;
		mCurrentInboundFlight = nextFlight;
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
			byte msg_type = TlsUtilities.ReadUint8(buf, off);
			int expectedEpoch = ((msg_type == 20) ? 1 : 0);
			if (epoch != expectedEpoch)
			{
				break;
			}
			int message_seq = TlsUtilities.ReadUint16(buf, off + 4);
			if (message_seq < mNextReceiveSeq + windowSize)
			{
				if (message_seq >= mNextReceiveSeq)
				{
					DtlsReassembler reassembler = (DtlsReassembler)mCurrentInboundFlight[message_seq];
					if (reassembler == null)
					{
						reassembler = new DtlsReassembler(msg_type, length);
						mCurrentInboundFlight[message_seq] = reassembler;
					}
					reassembler.ContributeFragment(msg_type, length, buf, off + 12, fragment_offset, fragment_length);
				}
				else if (mPreviousInboundFlight != null)
				{
					DtlsReassembler reassembler2 = (DtlsReassembler)mPreviousInboundFlight[message_seq];
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
		if (checkPreviousFlight && CheckAll(mPreviousInboundFlight))
		{
			ResendOutboundFlight();
			ResetAll(mPreviousInboundFlight);
		}
	}

	private void ResendOutboundFlight()
	{
		mRecordLayer.ResetWriteEpoch();
		for (int i = 0; i < mOutboundFlight.Count; i++)
		{
			WriteMessage((Message)mOutboundFlight[i]);
		}
		mResendMillis = BackOff(mResendMillis);
		mResendTimeout = new Timeout(mResendMillis);
	}

	private Message UpdateHandshakeMessagesDigest(Message message)
	{
		if (message.Type != 0)
		{
			byte[] body = message.Body;
			byte[] buf = new byte[12];
			TlsUtilities.WriteUint8(message.Type, buf, 0);
			TlsUtilities.WriteUint24(body.Length, buf, 1);
			TlsUtilities.WriteUint16(message.Seq, buf, 4);
			TlsUtilities.WriteUint24(0, buf, 6);
			TlsUtilities.WriteUint24(body.Length, buf, 9);
			mHandshakeHash.BlockUpdate(buf, 0, buf.Length);
			mHandshakeHash.BlockUpdate(body, 0, body.Length);
		}
		return message;
	}

	private void WriteMessage(Message message)
	{
		int fragmentLimit = mRecordLayer.GetSendLimit() - 12;
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
		fragment.SendToRecordLayer(mRecordLayer);
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
