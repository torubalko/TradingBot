using System;
using System.IO;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls;

internal class RecordStream
{
	private class HandshakeHashUpdateStream : BaseOutputStream
	{
		private readonly RecordStream mOuter;

		public HandshakeHashUpdateStream(RecordStream mOuter)
		{
			this.mOuter = mOuter;
		}

		public override void Write(byte[] buf, int off, int len)
		{
			mOuter.mHandshakeHash.BlockUpdate(buf, off, len);
		}
	}

	private class SequenceNumber
	{
		private long value;

		private bool exhausted;

		internal long NextValue(byte alertDescription)
		{
			if (exhausted)
			{
				throw new TlsFatalAlert(alertDescription);
			}
			long result = value;
			if (++value == 0L)
			{
				exhausted = true;
			}
			return result;
		}
	}

	private const int DEFAULT_PLAINTEXT_LIMIT = 16384;

	internal const int TLS_HEADER_SIZE = 5;

	internal const int TLS_HEADER_TYPE_OFFSET = 0;

	internal const int TLS_HEADER_VERSION_OFFSET = 1;

	internal const int TLS_HEADER_LENGTH_OFFSET = 3;

	private TlsProtocol mHandler;

	private Stream mInput;

	private Stream mOutput;

	private TlsCompression mPendingCompression;

	private TlsCompression mReadCompression;

	private TlsCompression mWriteCompression;

	private TlsCipher mPendingCipher;

	private TlsCipher mReadCipher;

	private TlsCipher mWriteCipher;

	private SequenceNumber mReadSeqNo = new SequenceNumber();

	private SequenceNumber mWriteSeqNo = new SequenceNumber();

	private MemoryStream mBuffer = new MemoryStream();

	private TlsHandshakeHash mHandshakeHash;

	private readonly BaseOutputStream mHandshakeHashUpdater;

	private ProtocolVersion mReadVersion;

	private ProtocolVersion mWriteVersion;

	private bool mRestrictReadVersion = true;

	private int mPlaintextLimit;

	private int mCompressedLimit;

	private int mCiphertextLimit;

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

	internal virtual TlsHandshakeHash HandshakeHash => mHandshakeHash;

	internal virtual Stream HandshakeHashUpdater => mHandshakeHashUpdater;

	internal RecordStream(TlsProtocol handler, Stream input, Stream output)
	{
		mHandler = handler;
		mInput = input;
		mOutput = output;
		mReadCompression = new TlsNullCompression();
		mWriteCompression = mReadCompression;
		mHandshakeHashUpdater = new HandshakeHashUpdateStream(this);
	}

	internal virtual void Init(TlsContext context)
	{
		mReadCipher = new TlsNullCipher(context);
		mWriteCipher = mReadCipher;
		mHandshakeHash = new DeferredHash();
		mHandshakeHash.Init(context);
		SetPlaintextLimit(16384);
	}

	internal virtual int GetPlaintextLimit()
	{
		return mPlaintextLimit;
	}

	internal virtual void SetPlaintextLimit(int plaintextLimit)
	{
		mPlaintextLimit = plaintextLimit;
		mCompressedLimit = mPlaintextLimit + 1024;
		mCiphertextLimit = mCompressedLimit + 1024;
	}

	internal virtual void SetWriteVersion(ProtocolVersion writeVersion)
	{
		mWriteVersion = writeVersion;
	}

	internal virtual void SetRestrictReadVersion(bool enabled)
	{
		mRestrictReadVersion = enabled;
	}

	internal virtual void SetPendingConnectionState(TlsCompression tlsCompression, TlsCipher tlsCipher)
	{
		mPendingCompression = tlsCompression;
		mPendingCipher = tlsCipher;
	}

	internal virtual void SentWriteCipherSpec()
	{
		if (mPendingCompression == null || mPendingCipher == null)
		{
			throw new TlsFatalAlert(40);
		}
		mWriteCompression = mPendingCompression;
		mWriteCipher = mPendingCipher;
		mWriteSeqNo = new SequenceNumber();
	}

	internal virtual void ReceivedReadCipherSpec()
	{
		if (mPendingCompression == null || mPendingCipher == null)
		{
			throw new TlsFatalAlert(40);
		}
		mReadCompression = mPendingCompression;
		mReadCipher = mPendingCipher;
		mReadSeqNo = new SequenceNumber();
	}

	internal virtual void FinaliseHandshake()
	{
		if (mReadCompression != mPendingCompression || mWriteCompression != mPendingCompression || mReadCipher != mPendingCipher || mWriteCipher != mPendingCipher)
		{
			throw new TlsFatalAlert(40);
		}
		mPendingCompression = null;
		mPendingCipher = null;
	}

	internal virtual void CheckRecordHeader(byte[] recordHeader)
	{
		CheckType(TlsUtilities.ReadUint8(recordHeader, 0), 10);
		if (!mRestrictReadVersion)
		{
			if ((TlsUtilities.ReadVersionRaw(recordHeader, 1) & 0xFFFFFF00u) != 768)
			{
				throw new TlsFatalAlert(47);
			}
		}
		else
		{
			ProtocolVersion version = TlsUtilities.ReadVersion(recordHeader, 1);
			if (mReadVersion != null && !version.Equals(mReadVersion))
			{
				throw new TlsFatalAlert(47);
			}
		}
		CheckLength(TlsUtilities.ReadUint16(recordHeader, 3), mCiphertextLimit, 22);
	}

	internal virtual bool ReadRecord()
	{
		byte[] recordHeader = TlsUtilities.ReadAllOrNothing(5, mInput);
		if (recordHeader == null)
		{
			return false;
		}
		byte type = TlsUtilities.ReadUint8(recordHeader, 0);
		CheckType(type, 10);
		if (!mRestrictReadVersion)
		{
			if ((TlsUtilities.ReadVersionRaw(recordHeader, 1) & 0xFFFFFF00u) != 768)
			{
				throw new TlsFatalAlert(47);
			}
		}
		else
		{
			ProtocolVersion version = TlsUtilities.ReadVersion(recordHeader, 1);
			if (mReadVersion == null)
			{
				mReadVersion = version;
			}
			else if (!version.Equals(mReadVersion))
			{
				throw new TlsFatalAlert(47);
			}
		}
		int length = TlsUtilities.ReadUint16(recordHeader, 3);
		CheckLength(length, mCiphertextLimit, 22);
		byte[] plaintext = DecodeAndVerify(type, mInput, length);
		mHandler.ProcessRecord(type, plaintext, 0, plaintext.Length);
		return true;
	}

	internal virtual byte[] DecodeAndVerify(byte type, Stream input, int len)
	{
		byte[] buf = TlsUtilities.ReadFully(len, input);
		long seqNo = mReadSeqNo.NextValue(10);
		byte[] decoded = mReadCipher.DecodeCiphertext(seqNo, type, buf, 0, buf.Length);
		CheckLength(decoded.Length, mCompressedLimit, 22);
		Stream cOut = mReadCompression.Decompress(mBuffer);
		if (cOut != mBuffer)
		{
			cOut.Write(decoded, 0, decoded.Length);
			cOut.Flush();
			decoded = GetBufferContents();
		}
		CheckLength(decoded.Length, mPlaintextLimit, 30);
		if (decoded.Length < 1 && type != 23)
		{
			throw new TlsFatalAlert(47);
		}
		return decoded;
	}

	internal virtual void WriteRecord(byte type, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
		if (mWriteVersion != null)
		{
			CheckType(type, 80);
			CheckLength(plaintextLength, mPlaintextLimit, 80);
			if (plaintextLength < 1 && type != 23)
			{
				throw new TlsFatalAlert(80);
			}
			Stream cOut = mWriteCompression.Compress(mBuffer);
			long seqNo = mWriteSeqNo.NextValue(80);
			byte[] ciphertext;
			if (cOut == mBuffer)
			{
				ciphertext = mWriteCipher.EncodePlaintext(seqNo, type, plaintext, plaintextOffset, plaintextLength);
			}
			else
			{
				cOut.Write(plaintext, plaintextOffset, plaintextLength);
				cOut.Flush();
				byte[] compressed = GetBufferContents();
				CheckLength(compressed.Length, plaintextLength + 1024, 80);
				ciphertext = mWriteCipher.EncodePlaintext(seqNo, type, compressed, 0, compressed.Length);
			}
			CheckLength(ciphertext.Length, mCiphertextLimit, 80);
			byte[] record = new byte[ciphertext.Length + 5];
			TlsUtilities.WriteUint8(type, record, 0);
			TlsUtilities.WriteVersion(mWriteVersion, record, 1);
			TlsUtilities.WriteUint16(ciphertext.Length, record, 3);
			Array.Copy(ciphertext, 0, record, 5, ciphertext.Length);
			mOutput.Write(record, 0, record.Length);
			mOutput.Flush();
		}
	}

	internal virtual void NotifyHelloComplete()
	{
		mHandshakeHash = mHandshakeHash.NotifyPrfDetermined();
	}

	internal virtual TlsHandshakeHash PrepareToFinish()
	{
		TlsHandshakeHash result = mHandshakeHash;
		mHandshakeHash = mHandshakeHash.StopTracking();
		return result;
	}

	internal virtual void SafeClose()
	{
		try
		{
			Platform.Dispose(mInput);
		}
		catch (IOException)
		{
		}
		try
		{
			Platform.Dispose(mOutput);
		}
		catch (IOException)
		{
		}
	}

	internal virtual void Flush()
	{
		mOutput.Flush();
	}

	private byte[] GetBufferContents()
	{
		byte[] result = mBuffer.ToArray();
		mBuffer.SetLength(0L);
		return result;
	}

	private static void CheckType(byte type, byte alertDescription)
	{
		if ((uint)(type - 20) > 3u)
		{
			throw new TlsFatalAlert(alertDescription);
		}
	}

	private static void CheckLength(int length, int limit, byte alertDescription)
	{
		if (length > limit)
		{
			throw new TlsFatalAlert(alertDescription);
		}
	}
}
