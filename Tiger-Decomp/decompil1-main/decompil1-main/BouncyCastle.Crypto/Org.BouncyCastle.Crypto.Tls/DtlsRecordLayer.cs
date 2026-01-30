using System;
using System.Net.Sockets;
using Org.BouncyCastle.Utilities.Date;

namespace Org.BouncyCastle.Crypto.Tls;

internal class DtlsRecordLayer : DatagramTransport, TlsCloseable
{
	private const int RECORD_HEADER_LENGTH = 13;

	private const int MAX_FRAGMENT_LENGTH = 16384;

	private const long TCP_MSL = 120000L;

	private const long RETRANSMIT_TIMEOUT = 240000L;

	private readonly DatagramTransport mTransport;

	private readonly TlsContext mContext;

	private readonly TlsPeer mPeer;

	private readonly ByteQueue mRecordQueue = new ByteQueue();

	private volatile bool mClosed;

	private volatile bool mFailed;

	private volatile ProtocolVersion mReadVersion;

	private volatile ProtocolVersion mWriteVersion;

	private volatile bool mInHandshake;

	private volatile int mPlaintextLimit;

	private DtlsEpoch mCurrentEpoch;

	private DtlsEpoch mPendingEpoch;

	private DtlsEpoch mReadEpoch;

	private DtlsEpoch mWriteEpoch;

	private DtlsHandshakeRetransmit mRetransmit;

	private DtlsEpoch mRetransmitEpoch;

	private Timeout mRetransmitTimeout;

	internal bool IsClosed => mClosed;

	internal virtual int ReadEpoch => mReadEpoch.Epoch;

	internal virtual ProtocolVersion ReadVersion
	{
		get
		{
			return mReadVersion;
		}
		set
		{
			mReadVersion = value;
		}
	}

	private static void SendDatagram(DatagramTransport sender, byte[] buf, int off, int len)
	{
		sender.Send(buf, off, len);
	}

	internal DtlsRecordLayer(DatagramTransport transport, TlsContext context, TlsPeer peer, byte contentType)
	{
		mTransport = transport;
		mContext = context;
		mPeer = peer;
		mInHandshake = true;
		mCurrentEpoch = new DtlsEpoch(0, new TlsNullCipher(context));
		mPendingEpoch = null;
		mReadEpoch = mCurrentEpoch;
		mWriteEpoch = mCurrentEpoch;
		SetPlaintextLimit(16384);
	}

	internal virtual void SetPlaintextLimit(int plaintextLimit)
	{
		mPlaintextLimit = plaintextLimit;
	}

	internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
	{
		mWriteVersion = writeVersion;
	}

	internal virtual void InitPendingEpoch(TlsCipher pendingCipher)
	{
		if (mPendingEpoch != null)
		{
			throw new InvalidOperationException();
		}
		mPendingEpoch = new DtlsEpoch(mWriteEpoch.Epoch + 1, pendingCipher);
	}

	internal virtual void HandshakeSuccessful(DtlsHandshakeRetransmit retransmit)
	{
		if (mReadEpoch == mCurrentEpoch || mWriteEpoch == mCurrentEpoch)
		{
			throw new InvalidOperationException();
		}
		if (retransmit != null)
		{
			mRetransmit = retransmit;
			mRetransmitEpoch = mCurrentEpoch;
			mRetransmitTimeout = new Timeout(240000L);
		}
		mInHandshake = false;
		mCurrentEpoch = mPendingEpoch;
		mPendingEpoch = null;
	}

	internal virtual void ResetWriteEpoch()
	{
		if (mRetransmitEpoch != null)
		{
			mWriteEpoch = mRetransmitEpoch;
		}
		else
		{
			mWriteEpoch = mCurrentEpoch;
		}
	}

	public virtual int GetReceiveLimit()
	{
		return System.Math.Min(mPlaintextLimit, mReadEpoch.Cipher.GetPlaintextLimit(mTransport.GetReceiveLimit() - 13));
	}

	public virtual int GetSendLimit()
	{
		return System.Math.Min(mPlaintextLimit, mWriteEpoch.Cipher.GetPlaintextLimit(mTransport.GetSendLimit() - 13));
	}

	public virtual int Receive(byte[] buf, int off, int len, int waitMillis)
	{
		long currentTimeMillis = DateTimeUtilities.CurrentUnixMs();
		Timeout timeout = Timeout.ForWaitMillis(waitMillis, currentTimeMillis);
		byte[] record = null;
		while (waitMillis >= 0)
		{
			if (mRetransmitTimeout != null && mRetransmitTimeout.RemainingMillis(currentTimeMillis) < 1)
			{
				mRetransmit = null;
				mRetransmitEpoch = null;
				mRetransmitTimeout = null;
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
		byte contentType = 23;
		if (mInHandshake || mWriteEpoch == mRetransmitEpoch)
		{
			contentType = 22;
			if (TlsUtilities.ReadUint8(buf, off) == 20)
			{
				DtlsEpoch nextEpoch = null;
				if (mInHandshake)
				{
					nextEpoch = mPendingEpoch;
				}
				else if (mWriteEpoch == mRetransmitEpoch)
				{
					nextEpoch = mCurrentEpoch;
				}
				if (nextEpoch == null)
				{
					throw new InvalidOperationException();
				}
				byte[] data = new byte[1] { 1 };
				SendRecord(20, data, 0, data.Length);
				mWriteEpoch = nextEpoch;
			}
		}
		SendRecord(contentType, buf, off, len);
	}

	public virtual void Close()
	{
		if (!mClosed)
		{
			if (mInHandshake)
			{
				Warn(90, "User canceled handshake");
			}
			CloseTransport();
		}
	}

	internal virtual void Failed()
	{
		if (!mClosed)
		{
			mFailed = true;
			CloseTransport();
		}
	}

	internal virtual void Fail(byte alertDescription)
	{
		if (!mClosed)
		{
			try
			{
				RaiseAlert(2, alertDescription, null, null);
			}
			catch (Exception)
			{
			}
			mFailed = true;
			CloseTransport();
		}
	}

	internal virtual void Warn(byte alertDescription, string message)
	{
		RaiseAlert(1, alertDescription, message, null);
	}

	private void CloseTransport()
	{
		if (mClosed)
		{
			return;
		}
		try
		{
			if (!mFailed)
			{
				Warn(0, null);
			}
			mTransport.Close();
		}
		catch (Exception)
		{
		}
		mClosed = true;
	}

	private void RaiseAlert(byte alertLevel, byte alertDescription, string message, Exception cause)
	{
		mPeer.NotifyAlertRaised(alertLevel, alertDescription, message, cause);
		SendRecord(21, new byte[2] { alertLevel, alertDescription }, 0, 2);
	}

	private int ReceiveDatagram(byte[] buf, int off, int len, int waitMillis)
	{
		try
		{
			return mTransport.Receive(buf, off, len, waitMillis);
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
		byte type = TlsUtilities.ReadUint8(record, 0);
		if ((uint)(type - 20) > 4u)
		{
			return -1;
		}
		int epoch = TlsUtilities.ReadUint16(record, 3);
		DtlsEpoch recordEpoch = null;
		if (epoch == mReadEpoch.Epoch)
		{
			recordEpoch = mReadEpoch;
		}
		else if (type == 22 && mRetransmitEpoch != null && epoch == mRetransmitEpoch.Epoch)
		{
			recordEpoch = mRetransmitEpoch;
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
		ProtocolVersion version = TlsUtilities.ReadVersion(record, 1);
		if (!version.IsDtls)
		{
			return -1;
		}
		if (mReadVersion != null && !mReadVersion.Equals(version))
		{
			return -1;
		}
		byte[] plaintext = recordEpoch.Cipher.DecodeCiphertext(GetMacSequenceNumber(recordEpoch.Epoch, seq), type, record, 13, received - 13);
		recordEpoch.ReplayWindow.ReportAuthenticated(seq);
		if (plaintext.Length > mPlaintextLimit)
		{
			return -1;
		}
		if (mReadVersion == null)
		{
			mReadVersion = version;
		}
		switch (type)
		{
		case 21:
			if (plaintext.Length == 2)
			{
				byte alertLevel = plaintext[0];
				byte alertDescription = plaintext[1];
				mPeer.NotifyAlertReceived(alertLevel, alertDescription);
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
			if (mInHandshake)
			{
				return -1;
			}
			break;
		case 20:
		{
			for (int i = 0; i < plaintext.Length; i++)
			{
				if (TlsUtilities.ReadUint8(plaintext, i) == 1 && mPendingEpoch != null)
				{
					mReadEpoch = mPendingEpoch;
				}
			}
			return -1;
		}
		case 22:
			if (!mInHandshake)
			{
				if (mRetransmit != null)
				{
					mRetransmit.ReceivedHandshakeRecord(epoch, plaintext, 0, plaintext.Length);
				}
				return -1;
			}
			break;
		case 24:
			return -1;
		}
		if (!mInHandshake && mRetransmit != null)
		{
			mRetransmit = null;
			mRetransmitEpoch = null;
			mRetransmitTimeout = null;
		}
		Array.Copy(plaintext, 0, buf, off, plaintext.Length);
		return plaintext.Length;
	}

	private int ReceiveRecord(byte[] buf, int off, int len, int waitMillis)
	{
		if (mRecordQueue.Available > 0)
		{
			int length = 0;
			if (mRecordQueue.Available >= 13)
			{
				byte[] lengthBytes = new byte[2];
				mRecordQueue.Read(lengthBytes, 0, 2, 11);
				length = TlsUtilities.ReadUint16(lengthBytes, 0);
			}
			int received = System.Math.Min(mRecordQueue.Available, 13 + length);
			mRecordQueue.RemoveData(buf, off, received, 0);
			return received;
		}
		int received2 = ReceiveDatagram(buf, off, len, waitMillis);
		if (received2 >= 13)
		{
			int fragmentLength = TlsUtilities.ReadUint16(buf, off + 11);
			int recordLength = 13 + fragmentLength;
			if (received2 > recordLength)
			{
				mRecordQueue.AddData(buf, off + recordLength, received2 - recordLength);
				received2 = recordLength;
			}
		}
		return received2;
	}

	private void SendRecord(byte contentType, byte[] buf, int off, int len)
	{
		if (mWriteVersion != null)
		{
			if (len > mPlaintextLimit)
			{
				throw new TlsFatalAlert(80);
			}
			if (len < 1 && contentType != 23)
			{
				throw new TlsFatalAlert(80);
			}
			int recordEpoch = mWriteEpoch.Epoch;
			long recordSequenceNumber = mWriteEpoch.AllocateSequenceNumber();
			byte[] ciphertext = mWriteEpoch.Cipher.EncodePlaintext(GetMacSequenceNumber(recordEpoch, recordSequenceNumber), contentType, buf, off, len);
			byte[] record = new byte[ciphertext.Length + 13];
			TlsUtilities.WriteUint8(contentType, record, 0);
			TlsUtilities.WriteVersion(mWriteVersion, record, 1);
			TlsUtilities.WriteUint16(recordEpoch, record, 3);
			TlsUtilities.WriteUint48(recordSequenceNumber, record, 5);
			TlsUtilities.WriteUint16(ciphertext.Length, record, 11);
			Array.Copy(ciphertext, 0, record, 13, ciphertext.Length);
			SendDatagram(mTransport, record, 0, record.Length);
		}
	}

	private static long GetMacSequenceNumber(int epoch, long sequence_number)
	{
		return ((epoch & 0xFFFFFFFFu) << 48) | sequence_number;
	}
}
