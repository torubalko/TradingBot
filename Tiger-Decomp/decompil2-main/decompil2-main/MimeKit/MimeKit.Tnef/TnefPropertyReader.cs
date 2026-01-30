using System;
using System.IO;
using System.Text;

namespace MimeKit.Tnef;

public class TnefPropertyReader
{
	private static readonly Encoding DefaultEncoding = Encoding.GetEncoding(1252);

	private const long TicksPerMillisecond = 10000L;

	private const long TicksPerSecond = 10000000L;

	private const long TicksPerMinute = 600000000L;

	private const long TicksPerHour = 36000000000L;

	private const long TicksPerDay = 864000000000L;

	private const int MillisPerSecond = 1000;

	private const int MillisPerMinute = 60000;

	private const int MillisPerHour = 3600000;

	private const int MillisPerDay = 86400000;

	private const int DaysPerYear = 365;

	private const int DaysPer4Years = 1461;

	private const int DaysPer100Years = 36524;

	private const int DaysPer400Years = 146097;

	private const int DaysTo1899 = 693593;

	private const int DaysTo10000 = 3652059;

	private const long MaxMillis = 315537897600000L;

	private const long DoubleDateOffset = 599264352000000000L;

	private const long OADateMinAsTicks = 31241376000000000L;

	private const double OADateMinAsDouble = -657435.0;

	private const double OADateMaxAsDouble = 2958466.0;

	private TnefPropertyTag propertyTag;

	private readonly TnefReader reader;

	private TnefNameId propertyName;

	private int rawValueOffset;

	private int rawValueLength;

	private int propertyIndex;

	private int propertyCount;

	private Decoder decoder;

	private int valueIndex;

	private int valueCount;

	private int rowIndex;

	private int rowCount;

	internal TnefAttachMethod AttachMethod { get; set; }

	public bool IsEmbeddedMessage
	{
		get
		{
			if (propertyTag.Id == TnefPropertyId.AttachData)
			{
				return AttachMethod == TnefAttachMethod.EmbeddedMessage;
			}
			return false;
		}
	}

	public bool IsMultiValuedProperty => propertyTag.IsMultiValued;

	public bool IsNamedProperty => propertyTag.IsNamed;

	public bool IsObjectProperty => propertyTag.ValueTnefType == TnefPropertyType.Object;

	public int PropertyCount => propertyCount;

	public TnefNameId PropertyNameId => propertyName;

	public TnefPropertyTag PropertyTag => propertyTag;

	public int RawValueLength => rawValueLength;

	public int RawValueStreamOffset => rawValueOffset;

	public int RowCount => rowCount;

	public int ValueCount => valueCount;

	public Type ValueType
	{
		get
		{
			if (propertyCount > 0)
			{
				return GetPropertyValueType();
			}
			return GetAttributeValueType();
		}
	}

	internal TnefPropertyReader(TnefReader tnef)
	{
		propertyTag = TnefPropertyTag.Null;
		propertyName = default(TnefNameId);
		rawValueOffset = 0;
		rawValueLength = 0;
		propertyIndex = 0;
		propertyCount = 0;
		valueIndex = 0;
		valueCount = 0;
		rowIndex = 0;
		rowCount = 0;
		reader = tnef;
	}

	public TnefReader GetEmbeddedMessageReader()
	{
		if (!IsEmbeddedMessage)
		{
			throw new InvalidOperationException();
		}
		Stream rawValueReadStream = GetRawValueReadStream();
		byte[] buffer = new byte[16];
		rawValueReadStream.Read(buffer, 0, 16);
		return new TnefReader(rawValueReadStream, reader.MessageCodepage, reader.ComplianceMode);
	}

	public Stream GetRawValueReadStream()
	{
		if (valueIndex >= valueCount)
		{
			throw new InvalidOperationException();
		}
		int rawValueStreamOffset = RawValueStreamOffset;
		int num = RawValueLength;
		if (propertyCount > 0 && reader.StreamOffset == RawValueStreamOffset)
		{
			TnefPropertyType valueTnefType = propertyTag.ValueTnefType;
			if (valueTnefType == TnefPropertyType.Object || (uint)(valueTnefType - 30) <= 1u || valueTnefType == TnefPropertyType.Binary)
			{
				int num2 = ReadInt32();
				if (num2 >= 0 && num2 + 4 < num)
				{
					num = num2 + 4;
				}
			}
		}
		valueIndex++;
		int valueEndOffset = rawValueStreamOffset + RawValueLength;
		int dataEndOffset = rawValueStreamOffset + num;
		return new TnefReaderStream(reader, dataEndOffset, valueEndOffset);
	}

	private bool CheckRawValueLength()
	{
		int num = reader.AttributeRawValueStreamOffset + reader.AttributeRawValueLength;
		int num2 = RawValueStreamOffset + RawValueLength;
		if (num2 > num)
		{
			reader.SetComplianceError(TnefComplianceStatus.InvalidAttributeValue);
			return false;
		}
		return true;
	}

	private byte ReadByte()
	{
		return reader.ReadByte();
	}

	private byte[] ReadBytes(int count)
	{
		byte[] array = new byte[count];
		int num;
		for (int i = 0; i < count; i += num)
		{
			if ((num = reader.ReadAttributeRawValue(array, i, count - i)) <= 0)
			{
				break;
			}
		}
		return array;
	}

	private short ReadInt16()
	{
		return reader.ReadInt16();
	}

	private int ReadInt32()
	{
		return reader.ReadInt32();
	}

	private int PeekInt32()
	{
		return reader.PeekInt32();
	}

	private long ReadInt64()
	{
		return reader.ReadInt64();
	}

	private float ReadSingle()
	{
		return reader.ReadSingle();
	}

	private double ReadDouble()
	{
		return reader.ReadDouble();
	}

	private static long DoubleDateToTicks(double value)
	{
		if (!(value < 2958466.0) || !(value > -657435.0))
		{
			throw new ArgumentException("Invalid OLE Automation Date.", "value");
		}
		long num = (long)(value * 86400000.0 + ((value >= 0.0) ? 0.5 : (-0.5)));
		if (num < 0)
		{
			num -= num % 86400000 * 2;
		}
		num += 59926435200000L;
		if (num < 0 || num >= 315537897600000L)
		{
			throw new ArgumentException("Invalid OLE Automation Date.", "value");
		}
		return num * 10000;
	}

	private DateTime ReadAppTime()
	{
		double value = ReadDouble();
		return new DateTime(DoubleDateToTicks(value), DateTimeKind.Unspecified);
	}

	private DateTime ReadSysTime()
	{
		long fileTime = ReadInt64();
		return DateTime.FromFileTime(fileTime);
	}

	private static int GetPaddedLength(int length)
	{
		return (length + 3) & -4;
	}

	private byte[] ReadByteArray()
	{
		int num = ReadInt32();
		byte[] result = ReadBytes(num);
		if (num % 4 != 0)
		{
			int num2 = 4 - num % 4;
			reader.Seek(reader.StreamOffset + num2);
		}
		return result;
	}

	private string ReadUnicodeString()
	{
		byte[] array = ReadByteArray();
		int num = array.Length;
		num &= -2;
		while (num > 1 && array[num - 1] == 0 && array[num - 2] == 0)
		{
			num -= 2;
		}
		if (num < 2)
		{
			return string.Empty;
		}
		return Encoding.Unicode.GetString(array, 0, num);
	}

	private Encoding GetMessageEncoding()
	{
		int messageCodepage = reader.MessageCodepage;
		if (messageCodepage != 0 && messageCodepage != 1252)
		{
			try
			{
				return Encoding.GetEncoding(messageCodepage);
			}
			catch
			{
				return DefaultEncoding;
			}
		}
		return DefaultEncoding;
	}

	private string DecodeAnsiString(byte[] bytes)
	{
		int num = bytes.Length;
		while (num > 0 && bytes[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			return string.Empty;
		}
		try
		{
			return GetMessageEncoding().GetString(bytes, 0, num);
		}
		catch
		{
			return DefaultEncoding.GetString(bytes, 0, num);
		}
	}

	private string ReadString()
	{
		byte[] bytes = ReadByteArray();
		return DecodeAnsiString(bytes);
	}

	private byte[] ReadAttrBytes()
	{
		return ReadBytes(RawValueLength);
	}

	private string ReadAttrString()
	{
		byte[] bytes = ReadBytes(RawValueLength);
		return DecodeAnsiString(bytes);
	}

	private DateTime ReadAttrDateTime()
	{
		int year = ReadInt16();
		int month = ReadInt16();
		int day = ReadInt16();
		int hour = ReadInt16();
		int minute = ReadInt16();
		int second = ReadInt16();
		int num = ReadInt16();
		try
		{
			return new DateTime(year, month, day, hour, minute, second);
		}
		catch (ArgumentOutOfRangeException innerException)
		{
			reader.SetComplianceError(TnefComplianceStatus.InvalidDate, innerException);
			return default(DateTime);
		}
	}

	private void LoadPropertyName()
	{
		Guid propertySetGuid = new Guid(ReadBytes(16));
		switch ((TnefNameIdKind)ReadInt32())
		{
		case TnefNameIdKind.Name:
		{
			string name = ReadUnicodeString();
			propertyName = new TnefNameId(propertySetGuid, name);
			break;
		}
		case TnefNameIdKind.Id:
		{
			int id = ReadInt32();
			propertyName = new TnefNameId(propertySetGuid, id);
			break;
		}
		default:
			reader.SetComplianceError(TnefComplianceStatus.InvalidAttributeValue);
			propertyName = new TnefNameId(propertySetGuid, 0);
			break;
		}
	}

	public bool ReadNextProperty()
	{
		while (ReadNextValue())
		{
		}
		if (propertyIndex >= propertyCount)
		{
			return false;
		}
		try
		{
			TnefPropertyType type = (TnefPropertyType)ReadInt16();
			TnefPropertyId tnefPropertyId = (TnefPropertyId)ReadInt16();
			propertyTag = new TnefPropertyTag(tnefPropertyId, type);
			if (propertyTag.IsNamed)
			{
				LoadPropertyName();
			}
			LoadValueCount();
			propertyIndex++;
			if (!TryGetPropertyValueLength(out rawValueLength))
			{
				return false;
			}
			rawValueOffset = reader.StreamOffset;
			if (tnefPropertyId == TnefPropertyId.AttachMethod)
			{
				AttachMethod = (TnefAttachMethod)PeekInt32();
			}
		}
		catch (EndOfStreamException)
		{
			return false;
		}
		return CheckRawValueLength();
	}

	public bool ReadNextRow()
	{
		while (ReadNextProperty())
		{
		}
		if (rowIndex >= rowCount)
		{
			return false;
		}
		try
		{
			LoadPropertyCount();
			rowIndex++;
		}
		catch (EndOfStreamException)
		{
			reader.SetComplianceError(TnefComplianceStatus.StreamTruncated);
			return false;
		}
		return true;
	}

	public bool ReadNextValue()
	{
		if (valueIndex >= valueCount || propertyCount == 0)
		{
			return false;
		}
		int num = RawValueStreamOffset + RawValueLength;
		if (reader.StreamOffset < num && !reader.Seek(num))
		{
			return false;
		}
		try
		{
			if (!TryGetPropertyValueLength(out rawValueLength))
			{
				return false;
			}
			rawValueOffset = reader.StreamOffset;
			valueIndex++;
		}
		catch (EndOfStreamException)
		{
			return false;
		}
		return true;
	}

	public int ReadRawValue(byte[] buffer, int offset, int count)
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
		if (propertyCount > 0 && reader.StreamOffset == RawValueStreamOffset)
		{
			TnefPropertyType valueTnefType = propertyTag.ValueTnefType;
			if (valueTnefType == TnefPropertyType.Object || (uint)(valueTnefType - 30) <= 1u || valueTnefType == TnefPropertyType.Binary)
			{
				ReadInt32();
			}
		}
		int num = RawValueStreamOffset + RawValueLength;
		int val = num - reader.StreamOffset;
		int num2 = Math.Min(val, count);
		if (num2 <= 0)
		{
			return 0;
		}
		return reader.ReadAttributeRawValue(buffer, offset, num2);
	}

	public int ReadTextValue(char[] buffer, int offset, int count)
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
		if (reader.StreamOffset == RawValueStreamOffset && decoder == null)
		{
			throw new InvalidOperationException();
		}
		if (propertyCount > 0 && reader.StreamOffset == RawValueStreamOffset)
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Unicode:
				ReadInt32();
				decoder = Encoding.Unicode.GetDecoder();
				break;
			case TnefPropertyType.Object:
			case TnefPropertyType.String8:
			case TnefPropertyType.Binary:
				ReadInt32();
				decoder = GetMessageEncoding().GetDecoder();
				break;
			}
		}
		int num = RawValueStreamOffset + RawValueLength;
		int val = num - reader.StreamOffset;
		int num2 = Math.Min(val, count);
		if (num2 <= 0)
		{
			return 0;
		}
		byte[] array = new byte[num2];
		num2 = reader.ReadAttributeRawValue(array, 0, num2);
		bool flush = reader.StreamOffset >= num;
		return decoder.GetChars(array, 0, num2, buffer, offset, flush);
	}

	private bool TryGetPropertyValueLength(out int length)
	{
		switch (propertyTag.ValueTnefType)
		{
		case TnefPropertyType.Unspecified:
		case TnefPropertyType.Null:
			length = 0;
			break;
		case TnefPropertyType.I2:
		case TnefPropertyType.Long:
		case TnefPropertyType.R4:
		case TnefPropertyType.Error:
		case TnefPropertyType.Boolean:
			length = 4;
			break;
		case TnefPropertyType.Double:
		case TnefPropertyType.Currency:
		case TnefPropertyType.I8:
			length = 8;
			break;
		case TnefPropertyType.ClassId:
			length = 16;
			break;
		case TnefPropertyType.Object:
		case TnefPropertyType.String8:
		case TnefPropertyType.Unicode:
		case TnefPropertyType.Binary:
			length = 4 + GetPaddedLength(PeekInt32());
			break;
		case TnefPropertyType.AppTime:
		case TnefPropertyType.SysTime:
			length = 8;
			break;
		default:
			reader.SetComplianceError(TnefComplianceStatus.UnsupportedPropertyType);
			length = 0;
			return false;
		}
		return true;
	}

	private Type GetPropertyValueType()
	{
		return propertyTag.ValueTnefType switch
		{
			TnefPropertyType.I2 => typeof(short), 
			TnefPropertyType.Boolean => typeof(bool), 
			TnefPropertyType.Currency => typeof(long), 
			TnefPropertyType.I8 => typeof(long), 
			TnefPropertyType.Error => typeof(int), 
			TnefPropertyType.Long => typeof(int), 
			TnefPropertyType.Double => typeof(double), 
			TnefPropertyType.R4 => typeof(float), 
			TnefPropertyType.AppTime => typeof(DateTime), 
			TnefPropertyType.SysTime => typeof(DateTime), 
			TnefPropertyType.Unicode => typeof(string), 
			TnefPropertyType.String8 => typeof(string), 
			TnefPropertyType.Binary => typeof(byte[]), 
			TnefPropertyType.ClassId => typeof(Guid), 
			TnefPropertyType.Object => typeof(byte[]), 
			_ => typeof(object), 
		};
	}

	private Type GetAttributeValueType()
	{
		return reader.AttributeType switch
		{
			TnefAttributeType.Triples => typeof(byte[]), 
			TnefAttributeType.String => typeof(string), 
			TnefAttributeType.Text => typeof(string), 
			TnefAttributeType.Date => typeof(DateTime), 
			TnefAttributeType.Short => typeof(short), 
			TnefAttributeType.Long => typeof(int), 
			TnefAttributeType.Byte => typeof(byte[]), 
			TnefAttributeType.Word => typeof(short), 
			TnefAttributeType.DWord => typeof(int), 
			_ => typeof(object), 
		};
	}

	private object ReadPropertyValue()
	{
		object result;
		switch (propertyTag.ValueTnefType)
		{
		case TnefPropertyType.Null:
			result = null;
			break;
		case TnefPropertyType.I2:
			result = (short)(ReadInt32() & 0xFFFF);
			break;
		case TnefPropertyType.Boolean:
			result = (ReadInt32() & 0xFF) != 0;
			break;
		case TnefPropertyType.Currency:
		case TnefPropertyType.I8:
			result = ReadInt64();
			break;
		case TnefPropertyType.Long:
		case TnefPropertyType.Error:
			result = ReadInt32();
			break;
		case TnefPropertyType.Double:
			result = ReadDouble();
			break;
		case TnefPropertyType.R4:
			result = ReadSingle();
			break;
		case TnefPropertyType.AppTime:
			result = ReadAppTime();
			break;
		case TnefPropertyType.SysTime:
			result = ReadSysTime();
			break;
		case TnefPropertyType.Unicode:
			result = ReadUnicodeString();
			break;
		case TnefPropertyType.String8:
			result = ReadString();
			break;
		case TnefPropertyType.Binary:
			result = ReadByteArray();
			break;
		case TnefPropertyType.ClassId:
			result = new Guid(ReadBytes(16));
			break;
		case TnefPropertyType.Object:
			result = ReadByteArray();
			break;
		default:
			reader.SetComplianceError(TnefComplianceStatus.UnsupportedPropertyType);
			result = null;
			break;
		}
		valueIndex++;
		return result;
	}

	public object ReadValue()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		if (propertyCount > 0)
		{
			return ReadPropertyValue();
		}
		object result = null;
		switch (reader.AttributeType)
		{
		case TnefAttributeType.Triples:
			result = ReadAttrBytes();
			break;
		case TnefAttributeType.String:
			result = ReadAttrString();
			break;
		case TnefAttributeType.Text:
			result = ReadAttrString();
			break;
		case TnefAttributeType.Date:
			result = ReadAttrDateTime();
			break;
		case TnefAttributeType.Short:
			result = ReadInt16();
			break;
		case TnefAttributeType.Long:
			result = ReadInt32();
			break;
		case TnefAttributeType.Byte:
			result = ReadAttrBytes();
			break;
		case TnefAttributeType.Word:
			result = ReadInt16();
			break;
		case TnefAttributeType.DWord:
			result = ReadInt32();
			break;
		}
		valueIndex++;
		return result;
	}

	public bool ReadValueAsBoolean()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		bool result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16() != 0, 
				TnefAttributeType.Long => ReadInt32() != 0, 
				TnefAttributeType.Word => ReadInt16() != 0, 
				TnefAttributeType.DWord => ReadInt32() != 0, 
				TnefAttributeType.Byte => ReadByte() != 0, 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = (ReadInt32() & 0xFF) != 0;
				break;
			case TnefPropertyType.I2:
				result = (ReadInt32() & 0xFFFF) != 0;
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = ReadInt32() != 0;
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = ReadInt64() != 0;
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public byte[] ReadValueAsBytes()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		byte[] result;
		if (propertyCount > 0)
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Object:
			case TnefPropertyType.String8:
			case TnefPropertyType.Unicode:
			case TnefPropertyType.Binary:
				result = ReadByteArray();
				break;
			case TnefPropertyType.ClassId:
				result = ReadBytes(16);
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		else
		{
			switch (reader.AttributeType)
			{
			case TnefAttributeType.Triples:
			case TnefAttributeType.String:
			case TnefAttributeType.Text:
			case TnefAttributeType.Byte:
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
			result = ReadAttrBytes();
		}
		valueIndex++;
		return result;
	}

	public DateTime ReadValueAsDateTime()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		DateTime result;
		if (propertyCount > 0)
		{
			result = propertyTag.ValueTnefType switch
			{
				TnefPropertyType.AppTime => ReadAppTime(), 
				TnefPropertyType.SysTime => ReadSysTime(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			if (reader.AttributeType != TnefAttributeType.Date)
			{
				throw new InvalidOperationException();
			}
			result = ReadAttrDateTime();
		}
		valueIndex++;
		return result;
	}

	public double ReadValueAsDouble()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		double result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16(), 
				TnefAttributeType.Long => ReadInt32(), 
				TnefAttributeType.Word => ReadInt16(), 
				TnefAttributeType.DWord => ReadInt32(), 
				TnefAttributeType.Byte => ReadDouble(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = ReadInt32() & 0xFF;
				break;
			case TnefPropertyType.I2:
				result = ReadInt32() & 0xFFFF;
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = ReadInt32();
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = ReadInt64();
				break;
			case TnefPropertyType.Double:
				result = ReadDouble();
				break;
			case TnefPropertyType.R4:
				result = ReadSingle();
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public float ReadValueAsFloat()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		float result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16(), 
				TnefAttributeType.Long => ReadInt32(), 
				TnefAttributeType.Word => ReadInt16(), 
				TnefAttributeType.DWord => ReadInt32(), 
				TnefAttributeType.Byte => ReadSingle(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = ReadInt32() & 0xFF;
				break;
			case TnefPropertyType.I2:
				result = ReadInt32() & 0xFFFF;
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = ReadInt32();
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = ReadInt64();
				break;
			case TnefPropertyType.Double:
				result = (float)ReadDouble();
				break;
			case TnefPropertyType.R4:
				result = ReadSingle();
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public Guid ReadValueAsGuid()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		if (propertyCount > 0)
		{
			TnefPropertyType valueTnefType = propertyTag.ValueTnefType;
			if (valueTnefType == TnefPropertyType.ClassId)
			{
				Guid result = new Guid(ReadBytes(16));
				valueIndex++;
				return result;
			}
			throw new InvalidOperationException();
		}
		throw new InvalidOperationException();
	}

	public short ReadValueAsInt16()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		short result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16(), 
				TnefAttributeType.Long => (short)ReadInt32(), 
				TnefAttributeType.Word => ReadInt16(), 
				TnefAttributeType.DWord => (short)ReadInt32(), 
				TnefAttributeType.Byte => ReadInt16(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = (short)(ReadInt32() & 0xFF);
				break;
			case TnefPropertyType.I2:
				result = (short)(ReadInt32() & 0xFFFF);
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = (short)ReadInt32();
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = (short)ReadInt64();
				break;
			case TnefPropertyType.Double:
				result = (short)ReadDouble();
				break;
			case TnefPropertyType.R4:
				result = (short)ReadSingle();
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public int ReadValueAsInt32()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		int result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16(), 
				TnefAttributeType.Long => ReadInt32(), 
				TnefAttributeType.Word => ReadInt16(), 
				TnefAttributeType.DWord => ReadInt32(), 
				TnefAttributeType.Byte => ReadInt32(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = ReadInt32() & 0xFF;
				break;
			case TnefPropertyType.I2:
				result = ReadInt32() & 0xFFFF;
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = ReadInt32();
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = (int)ReadInt64();
				break;
			case TnefPropertyType.Double:
				result = (int)ReadDouble();
				break;
			case TnefPropertyType.R4:
				result = (int)ReadSingle();
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public long ReadValueAsInt64()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		long result;
		if (propertyCount <= 0)
		{
			result = reader.AttributeType switch
			{
				TnefAttributeType.Short => ReadInt16(), 
				TnefAttributeType.Long => ReadInt32(), 
				TnefAttributeType.Word => ReadInt16(), 
				TnefAttributeType.DWord => ReadInt32(), 
				TnefAttributeType.Byte => ReadInt64(), 
				_ => throw new InvalidOperationException(), 
			};
		}
		else
		{
			switch (propertyTag.ValueTnefType)
			{
			case TnefPropertyType.Boolean:
				result = ReadInt32() & 0xFF;
				break;
			case TnefPropertyType.I2:
				result = ReadInt32() & 0xFFFF;
				break;
			case TnefPropertyType.Long:
			case TnefPropertyType.Error:
				result = ReadInt32();
				break;
			case TnefPropertyType.Currency:
			case TnefPropertyType.I8:
				result = ReadInt64();
				break;
			case TnefPropertyType.Double:
				result = (long)ReadDouble();
				break;
			case TnefPropertyType.R4:
				result = (long)ReadSingle();
				break;
			default:
				throw new InvalidOperationException();
			}
		}
		valueIndex++;
		return result;
	}

	public string ReadValueAsString()
	{
		if (valueIndex >= valueCount || reader.StreamOffset > RawValueStreamOffset)
		{
			throw new InvalidOperationException();
		}
		string result = ((propertyCount > 0) ? (propertyTag.ValueTnefType switch
		{
			TnefPropertyType.Unicode => ReadUnicodeString(), 
			TnefPropertyType.String8 => ReadString(), 
			TnefPropertyType.Binary => ReadString(), 
			_ => throw new InvalidOperationException(), 
		}) : (reader.AttributeType switch
		{
			TnefAttributeType.String => ReadAttrString(), 
			TnefAttributeType.Text => ReadAttrString(), 
			TnefAttributeType.Byte => ReadAttrString(), 
			_ => throw new InvalidOperationException(), 
		}));
		valueIndex++;
		return result;
	}

	internal Uri ReadValueAsUri()
	{
		string uriString = ReadValueAsString();
		if (Uri.IsWellFormedUriString(uriString, UriKind.Absolute))
		{
			return new Uri(uriString, UriKind.Absolute);
		}
		if (Uri.IsWellFormedUriString(uriString, UriKind.Relative))
		{
			return new Uri(uriString, UriKind.Relative);
		}
		return null;
	}

	public override int GetHashCode()
	{
		return reader.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is TnefPropertyReader tnefPropertyReader)
		{
			return tnefPropertyReader.reader == reader;
		}
		return false;
	}

	private void LoadPropertyCount()
	{
		if ((propertyCount = ReadInt32()) < 0)
		{
			reader.SetComplianceError(TnefComplianceStatus.InvalidPropertyLength);
			propertyCount = 0;
		}
		propertyIndex = 0;
		valueCount = 0;
		valueIndex = 0;
		decoder = null;
	}

	private int ReadValueCount()
	{
		int result;
		if ((result = ReadInt32()) < 0)
		{
			reader.SetComplianceError(TnefComplianceStatus.InvalidAttributeValue);
			return 0;
		}
		return result;
	}

	private void LoadValueCount()
	{
		if (propertyTag.IsMultiValued)
		{
			valueCount = ReadValueCount();
		}
		else
		{
			TnefPropertyType valueTnefType = propertyTag.ValueTnefType;
			if (valueTnefType == TnefPropertyType.Object || (uint)(valueTnefType - 30) <= 1u || valueTnefType == TnefPropertyType.Binary)
			{
				valueCount = ReadValueCount();
			}
			else
			{
				valueCount = 1;
			}
		}
		valueIndex = 0;
		decoder = null;
	}

	private void LoadRowCount()
	{
		if ((rowCount = ReadInt32()) < 0)
		{
			reader.SetComplianceError(TnefComplianceStatus.InvalidRowCount);
			rowCount = 0;
		}
		propertyCount = 0;
		propertyIndex = 0;
		valueCount = 0;
		valueIndex = 0;
		decoder = null;
		rowIndex = 0;
	}

	internal void Load()
	{
		propertyTag = TnefPropertyTag.Null;
		rawValueOffset = 0;
		rawValueLength = 0;
		propertyCount = 0;
		propertyIndex = 0;
		valueCount = 0;
		valueIndex = 0;
		decoder = null;
		rowCount = 0;
		rowIndex = 0;
		switch (reader.AttributeTag)
		{
		case TnefAttributeTag.MapiProperties:
		case TnefAttributeTag.Attachment:
			LoadPropertyCount();
			return;
		case TnefAttributeTag.RecipientTable:
			LoadRowCount();
			return;
		}
		rawValueLength = reader.AttributeRawValueLength;
		rawValueOffset = reader.StreamOffset;
		valueCount = 1;
	}
}
