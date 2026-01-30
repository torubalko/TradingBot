using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace MimeKit.Tnef;

public class TnefReader : IDisposable
{
	internal const int TnefSignature = 574529400;

	private const int ReadAheadSize = 128;

	private const int BlockSize = 4096;

	private const int PadSize = 0;

	private readonly byte[] input = new byte[4224];

	private const int inputStart = 128;

	private int inputIndex = 128;

	private int inputEnd = 128;

	private long position;

	private int checksum;

	private int codepage;

	private int version;

	private bool closed;

	private bool eos;

	public short AttachmentKey { get; private set; }

	public TnefAttributeLevel AttributeLevel { get; private set; }

	public int AttributeRawValueLength { get; private set; }

	public int AttributeRawValueStreamOffset { get; private set; }

	public TnefAttributeTag AttributeTag { get; private set; }

	internal TnefAttributeType AttributeType => (TnefAttributeType)(AttributeTag & (TnefAttributeTag)983040);

	public TnefComplianceMode ComplianceMode { get; private set; }

	public TnefComplianceStatus ComplianceStatus { get; internal set; }

	internal Stream InputStream { get; private set; }

	public int MessageCodepage
	{
		get
		{
			return codepage;
		}
		private set
		{
			if (value == codepage)
			{
				return;
			}
			try
			{
				Encoding encoding = Encoding.GetEncoding(value);
				codepage = encoding.CodePage;
			}
			catch (Exception innerException)
			{
				ComplianceStatus |= TnefComplianceStatus.InvalidMessageCodepage;
				if (ComplianceMode == TnefComplianceMode.Strict)
				{
					throw new TnefException(TnefComplianceStatus.InvalidMessageCodepage, string.Format(CultureInfo.InvariantCulture, "Invalid message codepage: {0}", value), innerException);
				}
				codepage = 1252;
			}
		}
	}

	public TnefPropertyReader TnefPropertyReader { get; private set; }

	public int StreamOffset => (int)(position - (inputEnd - inputIndex));

	public int TnefVersion
	{
		get
		{
			return version;
		}
		private set
		{
			if (value != 65536)
			{
				ComplianceStatus |= TnefComplianceStatus.InvalidTnefVersion;
				if (ComplianceMode == TnefComplianceMode.Strict)
				{
					throw new TnefException(TnefComplianceStatus.InvalidTnefVersion, string.Format(CultureInfo.InvariantCulture, "Invalid TNEF version: {0}", value));
				}
			}
			version = value;
		}
	}

	public TnefReader(Stream inputStream, int defaultMessageCodepage, TnefComplianceMode complianceMode)
	{
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (defaultMessageCodepage < 0)
		{
			throw new ArgumentOutOfRangeException("defaultMessageCodepage");
		}
		if (defaultMessageCodepage != 0)
		{
			Encoding encoding = Encoding.GetEncoding(defaultMessageCodepage);
			codepage = encoding.CodePage;
		}
		else
		{
			codepage = 1252;
		}
		TnefPropertyReader = new TnefPropertyReader(this);
		ComplianceMode = complianceMode;
		InputStream = inputStream;
		DecodeHeader();
	}

	public TnefReader(Stream inputStream)
		: this(inputStream, 0, TnefComplianceMode.Loose)
	{
	}

	~TnefReader()
	{
		Dispose(disposing: false);
	}

	private void CheckDisposed()
	{
		if (closed)
		{
			throw new ObjectDisposedException("TnefReader");
		}
	}

	internal int ReadAhead(int atleast)
	{
		CheckDisposed();
		int num = inputEnd - inputIndex;
		if (num >= atleast || eos)
		{
			return num;
		}
		int num2 = inputIndex;
		int num3 = 128;
		int num4 = inputEnd;
		if (num2 >= num3)
		{
			num3 -= Math.Min(128, num);
			Buffer.BlockCopy(input, num2, input, num3, num);
			num2 = num3;
			num3 += num;
		}
		else if (num2 > 0)
		{
			int num5 = Math.Min(num2, num4 - num3);
			Buffer.BlockCopy(input, num2, input, num2 - num5, num);
			num2 -= num5;
			num3 = num2 + num;
		}
		else
		{
			num3 = num4;
		}
		inputIndex = num2;
		inputEnd = num3;
		num4 = input.Length;
		int num6;
		if ((num6 = InputStream.Read(input, num3, num4 - num3)) > 0)
		{
			inputEnd += num6;
			position += num6;
		}
		else
		{
			eos = true;
		}
		return inputEnd - inputIndex;
	}

	internal void SetComplianceError(TnefComplianceStatus error, Exception innerException = null)
	{
		ComplianceStatus |= error;
		if (ComplianceMode != TnefComplianceMode.Strict)
		{
			return;
		}
		string message = null;
		switch (error)
		{
		case TnefComplianceStatus.AttributeOverflow:
			message = "Too many attributes.";
			break;
		case TnefComplianceStatus.InvalidAttribute:
			message = "Invalid attribute.";
			break;
		case TnefComplianceStatus.InvalidAttributeChecksum:
			message = "Invalid attribute checksum.";
			break;
		case TnefComplianceStatus.InvalidAttributeLength:
			message = "Invalid attribute length.";
			break;
		case TnefComplianceStatus.InvalidAttributeLevel:
			message = "Invalid attribute level.";
			break;
		case TnefComplianceStatus.InvalidAttributeValue:
			message = "Invalid attribute value.";
			break;
		case TnefComplianceStatus.InvalidDate:
			message = "Invalid date.";
			break;
		case TnefComplianceStatus.InvalidMessageClass:
			message = "Invalid message class.";
			break;
		case TnefComplianceStatus.InvalidMessageCodepage:
			message = "Invalid message codepage.";
			break;
		case TnefComplianceStatus.InvalidPropertyLength:
			message = "Invalid property length.";
			break;
		case TnefComplianceStatus.InvalidRowCount:
			message = "Invalid row count.";
			break;
		case TnefComplianceStatus.InvalidTnefSignature:
			message = "Invalid TNEF signature.";
			break;
		case TnefComplianceStatus.InvalidTnefVersion:
			message = "Invalid TNEF version.";
			break;
		case TnefComplianceStatus.NestingTooDeep:
			message = "Nesting too deep.";
			break;
		case TnefComplianceStatus.StreamTruncated:
			message = "Truncated TNEF stream.";
			break;
		case TnefComplianceStatus.UnsupportedPropertyType:
			message = "Unsupported property type.";
			break;
		case TnefComplianceStatus.Compliant:
			return;
		}
		if (innerException != null)
		{
			throw new TnefException(error, message, innerException);
		}
		throw new TnefException(error, message);
	}

	private void DecodeHeader()
	{
		try
		{
			int num = ReadInt32();
			if (num != 574529400)
			{
				SetComplianceError(TnefComplianceStatus.InvalidTnefSignature);
			}
			AttachmentKey = ReadInt16();
		}
		catch (EndOfStreamException)
		{
			SetComplianceError(TnefComplianceStatus.StreamTruncated);
		}
	}

	private void CheckAttributeLevel()
	{
		TnefAttributeLevel attributeLevel = AttributeLevel;
		if ((uint)(attributeLevel - 1) > 1u)
		{
			SetComplianceError(TnefComplianceStatus.InvalidAttributeLevel);
		}
	}

	private void CheckAttributeTag()
	{
		switch (AttributeTag)
		{
		case TnefAttributeTag.AttachRenderData:
			TnefPropertyReader.AttachMethod = TnefAttachMethod.ByValue;
			break;
		case TnefAttributeTag.OemCodepage:
			MessageCodepage = PeekInt32();
			break;
		case TnefAttributeTag.TnefVersion:
			TnefVersion = PeekInt32();
			break;
		default:
			SetComplianceError(TnefComplianceStatus.InvalidAttribute);
			break;
		case TnefAttributeTag.Null:
		case TnefAttributeTag.From:
		case TnefAttributeTag.Subject:
		case TnefAttributeTag.MessageId:
		case TnefAttributeTag.ParentId:
		case TnefAttributeTag.ConversationId:
		case TnefAttributeTag.AttachTitle:
		case TnefAttributeTag.Body:
		case TnefAttributeTag.DateStart:
		case TnefAttributeTag.DateEnd:
		case TnefAttributeTag.DateSent:
		case TnefAttributeTag.DateReceived:
		case TnefAttributeTag.AttachCreateDate:
		case TnefAttributeTag.AttachModifyDate:
		case TnefAttributeTag.DateModified:
		case TnefAttributeTag.RequestResponse:
		case TnefAttributeTag.Priority:
		case TnefAttributeTag.AidOwner:
		case TnefAttributeTag.Owner:
		case TnefAttributeTag.SentFor:
		case TnefAttributeTag.Delegate:
		case TnefAttributeTag.MessageStatus:
		case TnefAttributeTag.AttachData:
		case TnefAttributeTag.AttachMetaFile:
		case TnefAttributeTag.AttachTransportFilename:
		case TnefAttributeTag.MapiProperties:
		case TnefAttributeTag.RecipientTable:
		case TnefAttributeTag.Attachment:
		case TnefAttributeTag.OriginalMessageClass:
		case TnefAttributeTag.MessageClass:
			break;
		}
	}

	internal byte ReadByte()
	{
		if (ReadAhead(1) < 1)
		{
			throw new EndOfStreamException();
		}
		UpdateChecksum(input, inputIndex, 1);
		return input[inputIndex++];
	}

	internal short ReadInt16()
	{
		if (ReadAhead(2) < 2)
		{
			throw new EndOfStreamException();
		}
		UpdateChecksum(input, inputIndex, 2);
		return (short)(input[inputIndex++] | (input[inputIndex++] << 8));
	}

	internal int ReadInt32()
	{
		if (ReadAhead(4) < 4)
		{
			throw new EndOfStreamException();
		}
		UpdateChecksum(input, inputIndex, 4);
		return input[inputIndex++] | (input[inputIndex++] << 8) | (input[inputIndex++] << 16) | (input[inputIndex++] << 24);
	}

	internal int PeekInt32()
	{
		if (ReadAhead(4) < 4)
		{
			throw new EndOfStreamException();
		}
		return input[inputIndex] | (input[inputIndex + 1] << 8) | (input[inputIndex + 2] << 16) | (input[inputIndex + 3] << 24);
	}

	internal long ReadInt64()
	{
		if (ReadAhead(8) < 8)
		{
			throw new EndOfStreamException();
		}
		UpdateChecksum(input, inputIndex, 8);
		return (long)(input[inputIndex++] | ((ulong)input[inputIndex++] << 8) | ((ulong)input[inputIndex++] << 16) | ((ulong)input[inputIndex++] << 24) | ((ulong)input[inputIndex++] << 32) | ((ulong)input[inputIndex++] << 40) | ((ulong)input[inputIndex++] << 48) | ((ulong)input[inputIndex++] << 56));
	}

	private unsafe static float Int32BitsToSingle(int value)
	{
		return *(float*)(&value);
	}

	internal float ReadSingle()
	{
		int value = ReadInt32();
		return Int32BitsToSingle(value);
	}

	private unsafe static double Int64BitsToDouble(long value)
	{
		return *(double*)(&value);
	}

	internal double ReadDouble()
	{
		long value = ReadInt64();
		return Int64BitsToDouble(value);
	}

	internal bool Seek(int offset)
	{
		CheckDisposed();
		int num = offset - StreamOffset;
		if (num <= 0)
		{
			return true;
		}
		while (true)
		{
			int num2 = Math.Min(inputEnd - inputIndex, num);
			UpdateChecksum(input, inputIndex, num2);
			inputIndex += num2;
			num -= num2;
			if (num == 0)
			{
				break;
			}
			if (ReadAhead(num) == 0)
			{
				SetComplianceError(TnefComplianceStatus.StreamTruncated);
				return false;
			}
		}
		return true;
	}

	private bool SkipAttributeRawValue()
	{
		int offset = AttributeRawValueStreamOffset + AttributeRawValueLength;
		if (!Seek(offset))
		{
			return false;
		}
		int num = checksum;
		int num2;
		try
		{
			num2 = (ushort)ReadInt16();
		}
		catch (EndOfStreamException)
		{
			SetComplianceError(TnefComplianceStatus.StreamTruncated);
			return false;
		}
		if (num2 != num)
		{
			SetComplianceError(TnefComplianceStatus.InvalidAttributeChecksum);
		}
		return true;
	}

	public bool ReadNextAttribute()
	{
		CheckDisposed();
		if (AttributeRawValueStreamOffset != 0 && !SkipAttributeRawValue())
		{
			return false;
		}
		try
		{
			AttributeLevel = (TnefAttributeLevel)ReadByte();
		}
		catch (EndOfStreamException)
		{
			return false;
		}
		CheckAttributeLevel();
		try
		{
			AttributeTag = (TnefAttributeTag)ReadInt32();
			AttributeRawValueLength = ReadInt32();
			AttributeRawValueStreamOffset = StreamOffset;
			checksum = 0;
		}
		catch (EndOfStreamException)
		{
			SetComplianceError(TnefComplianceStatus.StreamTruncated);
			return false;
		}
		CheckAttributeTag();
		if (AttributeRawValueLength < 0)
		{
			SetComplianceError(TnefComplianceStatus.InvalidAttributeLength);
			return false;
		}
		try
		{
			TnefPropertyReader.Load();
		}
		catch (EndOfStreamException)
		{
			SetComplianceError(TnefComplianceStatus.StreamTruncated);
			return false;
		}
		return true;
	}

	private void UpdateChecksum(byte[] buffer, int offset, int count)
	{
		for (int i = offset; i < offset + count; i++)
		{
			checksum = (checksum + buffer[i]) & 0xFFFF;
		}
	}

	public int ReadAttributeRawValue(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset >= buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		CheckDisposed();
		int num = AttributeRawValueStreamOffset + AttributeRawValueLength;
		int num2 = num - StreamOffset;
		if (num2 == 0)
		{
			return 0;
		}
		int num3 = inputEnd - inputIndex;
		int num4 = Math.Min(num2, count);
		if (num4 > num3 && num3 < 128)
		{
			if ((num4 = Math.Min(ReadAhead(num4), num4)) == 0)
			{
				SetComplianceError(TnefComplianceStatus.StreamTruncated);
				return 0;
			}
		}
		else
		{
			num4 = Math.Min(num3, num4);
		}
		Buffer.BlockCopy(input, inputIndex, buffer, offset, num4);
		UpdateChecksum(buffer, offset, num4);
		inputIndex += num4;
		return num4;
	}

	public void ResetComplianceStatus()
	{
		ComplianceStatus = TnefComplianceStatus.Compliant;
	}

	public void Close()
	{
		Dispose();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !closed)
		{
			InputStream.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
		closed = true;
	}
}
