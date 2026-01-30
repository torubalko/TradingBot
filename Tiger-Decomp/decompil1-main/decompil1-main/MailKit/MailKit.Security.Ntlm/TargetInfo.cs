using System;
using System.Text;

namespace MailKit.Security.Ntlm;

internal class TargetInfo
{
	public int? Flags { get; set; }

	public byte[] ChannelBinding { get; set; }

	public string DomainName { get; set; }

	public string ServerName { get; set; }

	public string DnsDomainName { get; set; }

	public string DnsServerName { get; set; }

	public string DnsTreeName { get; set; }

	public string TargetName { get; set; }

	public long Timestamp { get; set; }

	public TargetInfo(byte[] buffer, int startIndex, int length, bool unicode)
	{
		Decode(buffer, startIndex, length, unicode);
	}

	public TargetInfo()
	{
	}

	private static byte[] DecodeByteArray(byte[] buffer, ref int index)
	{
		short num = BitConverterLE.ToInt16(buffer, index);
		byte[] array = new byte[num];
		Buffer.BlockCopy(buffer, index + 2, array, 0, num);
		index += 2 + num;
		return array;
	}

	private static string DecodeString(byte[] buffer, ref int index, bool unicode)
	{
		Encoding encoding = (unicode ? Encoding.Unicode : Encoding.UTF8);
		short num = BitConverterLE.ToInt16(buffer, index);
		string result = encoding.GetString(buffer, index + 2, num);
		index += 2 + num;
		return result;
	}

	private static int DecodeFlags(byte[] buffer, ref int index)
	{
		short num = BitConverterLE.ToInt16(buffer, index);
		index += 2;
		int result = num switch
		{
			4 => BitConverterLE.ToInt32(buffer, index), 
			2 => BitConverterLE.ToInt16(buffer, index), 
			_ => 0, 
		};
		index += num;
		return result;
	}

	private static long DecodeTimestamp(byte[] buffer, ref int index)
	{
		short num = BitConverterLE.ToInt16(buffer, index);
		index += 2;
		switch (num)
		{
		case 8:
		{
			long result = BitConverterLE.ToUInt32(buffer, index);
			index += 4;
			long num2 = BitConverterLE.ToUInt32(buffer, index);
			index += 4;
			return (num2 << 32) | result;
		}
		case 4:
		{
			long result = BitConverterLE.ToUInt32(buffer, index);
			index += 4;
			return result;
		}
		case 2:
		{
			long result = BitConverterLE.ToUInt16(buffer, index);
			index += 2;
			return result;
		}
		default:
			index += num;
			return 0L;
		}
	}

	private void Decode(byte[] buffer, int startIndex, int length, bool unicode)
	{
		int index = startIndex;
		do
		{
			short num = BitConverterLE.ToInt16(buffer, index);
			index += 2;
			switch (num)
			{
			case 0:
				index = startIndex + length;
				break;
			case 1:
				ServerName = DecodeString(buffer, ref index, unicode);
				break;
			case 2:
				DomainName = DecodeString(buffer, ref index, unicode);
				break;
			case 3:
				DnsServerName = DecodeString(buffer, ref index, unicode);
				break;
			case 4:
				DnsDomainName = DecodeString(buffer, ref index, unicode);
				break;
			case 5:
				DnsTreeName = DecodeString(buffer, ref index, unicode);
				break;
			case 6:
				Flags = DecodeFlags(buffer, ref index);
				break;
			case 7:
				Timestamp = DecodeTimestamp(buffer, ref index);
				break;
			case 9:
				TargetName = DecodeString(buffer, ref index, unicode);
				break;
			case 10:
				ChannelBinding = DecodeByteArray(buffer, ref index);
				break;
			default:
				index += 2 + BitConverterLE.ToInt16(buffer, index);
				break;
			}
		}
		while (index < startIndex + length);
	}

	private int CalculateSize(bool unicode)
	{
		Encoding encoding = (unicode ? Encoding.Unicode : Encoding.UTF8);
		int num = 4;
		if (!string.IsNullOrEmpty(DomainName))
		{
			num += 4 + encoding.GetByteCount(DomainName);
		}
		if (!string.IsNullOrEmpty(ServerName))
		{
			num += 4 + encoding.GetByteCount(ServerName);
		}
		if (!string.IsNullOrEmpty(DnsDomainName))
		{
			num += 4 + encoding.GetByteCount(DnsDomainName);
		}
		if (!string.IsNullOrEmpty(DnsServerName))
		{
			num += 4 + encoding.GetByteCount(DnsServerName);
		}
		if (!string.IsNullOrEmpty(DnsTreeName))
		{
			num += 4 + encoding.GetByteCount(DnsTreeName);
		}
		if (Flags.HasValue)
		{
			num += 8;
		}
		if (Timestamp != 0L)
		{
			num += 12;
		}
		if (!string.IsNullOrEmpty(TargetName))
		{
			num += 4 + encoding.GetByteCount(TargetName);
		}
		if (ChannelBinding != null && ChannelBinding.Length != 0)
		{
			num += 4 + ChannelBinding.Length;
		}
		return num;
	}

	private static void EncodeTypeAndLength(byte[] buf, ref int index, short type, short length)
	{
		buf[index++] = (byte)type;
		buf[index++] = (byte)(type >> 8);
		buf[index++] = (byte)length;
		buf[index++] = (byte)(length >> 8);
	}

	private static void EncodeByteArray(byte[] buf, ref int index, short type, byte[] value)
	{
		EncodeTypeAndLength(buf, ref index, type, (short)value.Length);
		Buffer.BlockCopy(value, 0, buf, index, value.Length);
		index += value.Length;
	}

	private static void EncodeString(byte[] buf, ref int index, short type, string value, bool unicode)
	{
		Encoding encoding = (unicode ? Encoding.Unicode : Encoding.UTF8);
		int byteCount = encoding.GetByteCount(value);
		EncodeTypeAndLength(buf, ref index, type, (short)byteCount);
		encoding.GetBytes(value, 0, value.Length, buf, index);
		index += byteCount;
	}

	private static void EncodeInt32(byte[] buf, ref int index, int value)
	{
		buf[index++] = (byte)value;
		buf[index++] = (byte)(value >> 8);
		buf[index++] = (byte)(value >> 16);
		buf[index++] = (byte)(value >> 24);
	}

	private static void EncodeTimestamp(byte[] buf, ref int index, short type, long value)
	{
		EncodeTypeAndLength(buf, ref index, type, 8);
		EncodeInt32(buf, ref index, (int)(value & 0xFFFFFFFFu));
		EncodeInt32(buf, ref index, (int)(value >> 32));
	}

	private static void EncodeFlags(byte[] buf, ref int index, short type, int value)
	{
		EncodeTypeAndLength(buf, ref index, type, 4);
		EncodeInt32(buf, ref index, value);
	}

	public byte[] Encode(bool unicode)
	{
		byte[] array = new byte[CalculateSize(unicode)];
		int index = 0;
		if (!string.IsNullOrEmpty(DomainName))
		{
			EncodeString(array, ref index, 2, DomainName, unicode);
		}
		if (!string.IsNullOrEmpty(ServerName))
		{
			EncodeString(array, ref index, 1, ServerName, unicode);
		}
		if (!string.IsNullOrEmpty(DnsDomainName))
		{
			EncodeString(array, ref index, 4, DnsDomainName, unicode);
		}
		if (!string.IsNullOrEmpty(DnsServerName))
		{
			EncodeString(array, ref index, 3, DnsServerName, unicode);
		}
		if (!string.IsNullOrEmpty(DnsTreeName))
		{
			EncodeString(array, ref index, 5, DnsTreeName, unicode);
		}
		if (Flags.HasValue)
		{
			EncodeFlags(array, ref index, 6, Flags.Value);
		}
		if (Timestamp != 0L)
		{
			EncodeTimestamp(array, ref index, 7, Timestamp);
		}
		if (!string.IsNullOrEmpty(TargetName))
		{
			EncodeString(array, ref index, 9, TargetName, unicode);
		}
		if (ChannelBinding != null && ChannelBinding.Length != 0)
		{
			EncodeByteArray(array, ref index, 10, ChannelBinding);
		}
		return array;
	}
}
