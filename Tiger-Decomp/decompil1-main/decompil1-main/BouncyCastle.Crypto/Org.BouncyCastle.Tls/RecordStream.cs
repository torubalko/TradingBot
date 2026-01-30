using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

internal sealed class RecordStream
{
	private sealed class Record
	{
		private readonly byte[] m_header = new byte[5];

		internal volatile byte[] m_buf;

		internal volatile int m_pos;

		internal Record()
		{
			m_buf = m_header;
			m_pos = 0;
		}

		internal void FillTo(Stream input, int length)
		{
			while (m_pos < length)
			{
				int numRead = input.Read(m_buf, m_pos, length - m_pos);
				if (numRead >= 1)
				{
					m_pos += numRead;
					continue;
				}
				break;
			}
		}

		internal void ReadFragment(Stream input, int fragmentLength)
		{
			int recordLength = 5 + fragmentLength;
			Resize(recordLength);
			FillTo(input, recordLength);
			if (m_pos < recordLength)
			{
				throw new EndOfStreamException();
			}
		}

		internal bool ReadHeader(Stream input)
		{
			FillTo(input, 5);
			if (m_pos == 0)
			{
				return false;
			}
			if (m_pos < 5)
			{
				throw new EndOfStreamException();
			}
			return true;
		}

		internal void Reset()
		{
			m_buf = m_header;
			m_pos = 0;
		}

		private void Resize(int length)
		{
			if (m_buf.Length < length)
			{
				byte[] tmp = new byte[length];
				Array.Copy(m_buf, 0, tmp, 0, m_pos);
				m_buf = tmp;
			}
		}
	}

	private sealed class SequenceNumber
	{
		private long m_value;

		private bool m_exhausted;

		internal long CurrentValue
		{
			get
			{
				lock (this)
				{
					return m_value;
				}
			}
		}

		internal long NextValue(short alertDescription)
		{
			lock (this)
			{
				if (m_exhausted)
				{
					throw new TlsFatalAlert(alertDescription, "Sequence numbers exhausted");
				}
				long value = m_value;
				if (++m_value == 0L)
				{
					m_exhausted = true;
				}
				return value;
			}
		}

		internal void Reset()
		{
			lock (this)
			{
				m_value = 0L;
				m_exhausted = false;
			}
		}
	}

	private const int DefaultPlaintextLimit = 16384;

	private readonly Record m_inputRecord = new Record();

	private readonly SequenceNumber m_readSeqNo = new SequenceNumber();

	private readonly SequenceNumber m_writeSeqNo = new SequenceNumber();

	private readonly TlsProtocol m_handler;

	private readonly Stream m_input;

	private readonly Stream m_output;

	private TlsCipher m_pendingCipher;

	private TlsCipher m_readCipher = TlsNullNullCipher.Instance;

	private TlsCipher m_readCipherDeferred;

	private TlsCipher m_writeCipher = TlsNullNullCipher.Instance;

	private ProtocolVersion m_writeVersion;

	private int m_plaintextLimit = 16384;

	private int m_ciphertextLimit = 16384;

	private bool m_ignoreChangeCipherSpec;

	internal int PlaintextLimit => m_plaintextLimit;

	internal RecordStream(TlsProtocol handler, Stream input, Stream output)
	{
		m_handler = handler;
		m_input = input;
		m_output = output;
	}

	internal void SetPlaintextLimit(int plaintextLimit)
	{
		m_plaintextLimit = plaintextLimit;
		m_ciphertextLimit = m_readCipher.GetCiphertextDecodeLimit(plaintextLimit);
	}

	internal void SetWriteVersion(ProtocolVersion writeVersion)
	{
		m_writeVersion = writeVersion;
	}

	internal void SetIgnoreChangeCipherSpec(bool ignoreChangeCipherSpec)
	{
		m_ignoreChangeCipherSpec = ignoreChangeCipherSpec;
	}

	internal void SetPendingCipher(TlsCipher tlsCipher)
	{
		m_pendingCipher = tlsCipher;
	}

	internal void NotifyChangeCipherSpecReceived()
	{
		if (m_pendingCipher == null)
		{
			throw new TlsFatalAlert(10, "No pending cipher");
		}
		EnablePendingCipherRead(deferred: false);
	}

	internal void EnablePendingCipherRead(bool deferred)
	{
		if (m_pendingCipher == null)
		{
			throw new TlsFatalAlert(80);
		}
		if (m_readCipherDeferred != null)
		{
			throw new TlsFatalAlert(80);
		}
		if (deferred)
		{
			m_readCipherDeferred = m_pendingCipher;
			return;
		}
		m_readCipher = m_pendingCipher;
		m_ciphertextLimit = m_readCipher.GetCiphertextDecodeLimit(m_plaintextLimit);
		m_readSeqNo.Reset();
	}

	internal void EnablePendingCipherWrite()
	{
		if (m_pendingCipher == null)
		{
			throw new TlsFatalAlert(80);
		}
		m_writeCipher = m_pendingCipher;
		m_writeSeqNo.Reset();
	}

	internal void FinaliseHandshake()
	{
		if (m_readCipher != m_pendingCipher || m_writeCipher != m_pendingCipher)
		{
			throw new TlsFatalAlert(40);
		}
		m_pendingCipher = null;
	}

	internal bool NeedsKeyUpdate()
	{
		return m_writeSeqNo.CurrentValue >= 1048576;
	}

	internal void NotifyKeyUpdateReceived()
	{
		m_readCipher.RekeyDecoder();
		m_readSeqNo.Reset();
	}

	internal void NotifyKeyUpdateSent()
	{
		m_writeCipher.RekeyEncoder();
		m_writeSeqNo.Reset();
	}

	internal RecordPreview PreviewRecordHeader(byte[] recordHeader)
	{
		short recordType = CheckRecordType(recordHeader, 0);
		int length = TlsUtilities.ReadUint16(recordHeader, 3);
		CheckLength(length, m_ciphertextLimit, 22);
		int recordSize = 5 + length;
		int applicationDataLimit = 0;
		if (23 == recordType && m_handler.IsApplicationDataReady)
		{
			applicationDataLimit = System.Math.Max(0, System.Math.Min(m_plaintextLimit, m_readCipher.GetPlaintextLimit(length)));
		}
		return new RecordPreview(recordSize, applicationDataLimit);
	}

	internal RecordPreview PreviewOutputRecord(int contentLength)
	{
		int contentLimit = System.Math.Max(0, System.Math.Min(m_plaintextLimit, contentLength));
		return new RecordPreview(PreviewOutputRecordSize(contentLimit), contentLimit);
	}

	internal int PreviewOutputRecordSize(int contentLength)
	{
		return 5 + m_writeCipher.GetCiphertextEncodeLimit(contentLength, m_plaintextLimit);
	}

	internal bool ReadFullRecord(byte[] input, int inputOff, int inputLen)
	{
		if (inputLen < 5)
		{
			return false;
		}
		int length = TlsUtilities.ReadUint16(input, inputOff + 3);
		if (inputLen != 5 + length)
		{
			return false;
		}
		short recordType = CheckRecordType(input, inputOff);
		ProtocolVersion recordVersion = TlsUtilities.ReadVersion(input, inputOff + 1);
		CheckLength(length, m_ciphertextLimit, 22);
		if (m_ignoreChangeCipherSpec && 20 == recordType)
		{
			CheckChangeCipherSpec(input, inputOff + 5, length);
			return true;
		}
		TlsDecodeResult decoded = DecodeAndVerify(recordType, recordVersion, input, inputOff + 5, length);
		m_handler.ProcessRecord(decoded.contentType, decoded.buf, decoded.off, decoded.len);
		return true;
	}

	internal bool ReadRecord()
	{
		if (!m_inputRecord.ReadHeader(m_input))
		{
			return false;
		}
		short recordType = CheckRecordType(m_inputRecord.m_buf, 0);
		ProtocolVersion recordVersion = TlsUtilities.ReadVersion(m_inputRecord.m_buf, 1);
		int length = TlsUtilities.ReadUint16(m_inputRecord.m_buf, 3);
		CheckLength(length, m_ciphertextLimit, 22);
		m_inputRecord.ReadFragment(m_input, length);
		TlsDecodeResult decoded;
		try
		{
			if (m_ignoreChangeCipherSpec && 20 == recordType)
			{
				CheckChangeCipherSpec(m_inputRecord.m_buf, 5, length);
				return true;
			}
			decoded = DecodeAndVerify(recordType, recordVersion, m_inputRecord.m_buf, 5, length);
		}
		finally
		{
			m_inputRecord.Reset();
		}
		m_handler.ProcessRecord(decoded.contentType, decoded.buf, decoded.off, decoded.len);
		return true;
	}

	internal TlsDecodeResult DecodeAndVerify(short recordType, ProtocolVersion recordVersion, byte[] ciphertext, int off, int len)
	{
		long seqNo = m_readSeqNo.NextValue(10);
		TlsDecodeResult decoded = m_readCipher.DecodeCiphertext(seqNo, recordType, recordVersion, ciphertext, off, len);
		CheckLength(decoded.len, m_plaintextLimit, 22);
		if (decoded.len < 1 && decoded.contentType != 23)
		{
			throw new TlsFatalAlert(47);
		}
		return decoded;
	}

	internal void WriteRecord(short contentType, byte[] plaintext, int plaintextOffset, int plaintextLength)
	{
		if (m_writeVersion != null)
		{
			CheckLength(plaintextLength, m_plaintextLimit, 80);
			if (plaintextLength < 1 && contentType != 23)
			{
				throw new TlsFatalAlert(80);
			}
			long seqNo = m_writeSeqNo.NextValue(80);
			ProtocolVersion recordVersion = m_writeVersion;
			TlsEncodeResult encoded = m_writeCipher.EncodePlaintext(seqNo, contentType, recordVersion, 5, plaintext, plaintextOffset, plaintextLength);
			int i = encoded.len - 5;
			TlsUtilities.CheckUint16(i);
			TlsUtilities.WriteUint8(encoded.recordType, encoded.buf, encoded.off);
			TlsUtilities.WriteVersion(recordVersion, encoded.buf, encoded.off + 1);
			TlsUtilities.WriteUint16(i, encoded.buf, encoded.off + 3);
			m_output.Write(encoded.buf, encoded.off, encoded.len);
			m_output.Flush();
		}
	}

	internal void Close()
	{
		m_inputRecord.Reset();
		IOException io = null;
		try
		{
			Platform.Dispose(m_input);
		}
		catch (IOException ex)
		{
			io = ex;
		}
		try
		{
			Platform.Dispose(m_output);
		}
		catch (IOException ex2)
		{
			if (io == null)
			{
				io = ex2;
			}
		}
		if (io != null)
		{
			throw io;
		}
	}

	private void CheckChangeCipherSpec(byte[] buf, int off, int len)
	{
		if (1 != len || 1 != buf[off])
		{
			throw new TlsFatalAlert(10, "Malformed " + ContentType.GetText(20));
		}
	}

	private short CheckRecordType(byte[] buf, int off)
	{
		short recordType = TlsUtilities.ReadUint8(buf, off);
		if (m_readCipherDeferred != null && recordType == 23)
		{
			m_readCipher = m_readCipherDeferred;
			m_readCipherDeferred = null;
			m_ciphertextLimit = m_readCipher.GetCiphertextDecodeLimit(m_plaintextLimit);
			m_readSeqNo.Reset();
		}
		else if (m_readCipher.UsesOpaqueRecordType)
		{
			if (23 != recordType && (!m_ignoreChangeCipherSpec || 20 != recordType))
			{
				throw new TlsFatalAlert(10, "Opaque " + ContentType.GetText(recordType));
			}
		}
		else
		{
			switch (recordType)
			{
			case 23:
				if (!m_handler.IsApplicationDataReady)
				{
					throw new TlsFatalAlert(10, "Not ready for " + ContentType.GetText(23));
				}
				break;
			default:
				throw new TlsFatalAlert(10, "Unsupported " + ContentType.GetText(recordType));
			case 20:
			case 21:
			case 22:
				break;
			}
		}
		return recordType;
	}

	private static void CheckLength(int length, int limit, short alertDescription)
	{
		if (length > limit)
		{
			throw new TlsFatalAlert(alertDescription);
		}
	}
}
