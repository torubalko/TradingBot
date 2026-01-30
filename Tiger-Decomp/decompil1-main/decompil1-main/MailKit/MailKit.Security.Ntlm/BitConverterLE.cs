using System;

namespace MailKit.Security.Ntlm;

internal sealed class BitConverterLE
{
	private BitConverterLE()
	{
	}

	private unsafe static byte[] GetULongBytes(byte* bytes)
	{
		if (!BitConverter.IsLittleEndian)
		{
			return new byte[8]
			{
				bytes[7],
				bytes[6],
				bytes[5],
				bytes[4],
				bytes[3],
				bytes[2],
				bytes[1],
				*bytes
			};
		}
		return new byte[8]
		{
			*bytes,
			bytes[1],
			bytes[2],
			bytes[3],
			bytes[4],
			bytes[5],
			bytes[6],
			bytes[7]
		};
	}

	internal unsafe static byte[] GetBytes(long value)
	{
		return GetULongBytes((byte*)(&value));
	}

	private unsafe static void UShortFromBytes(byte* dst, byte[] src, int startIndex)
	{
		if (BitConverter.IsLittleEndian)
		{
			*dst = src[startIndex];
			dst[1] = src[startIndex + 1];
		}
		else
		{
			*dst = src[startIndex + 1];
			dst[1] = src[startIndex];
		}
	}

	private unsafe static void UIntFromBytes(byte* dst, byte[] src, int startIndex)
	{
		if (BitConverter.IsLittleEndian)
		{
			*dst = src[startIndex];
			dst[1] = src[startIndex + 1];
			dst[2] = src[startIndex + 2];
			dst[3] = src[startIndex + 3];
		}
		else
		{
			*dst = src[startIndex + 3];
			dst[1] = src[startIndex + 2];
			dst[2] = src[startIndex + 1];
			dst[3] = src[startIndex];
		}
	}

	internal unsafe static short ToInt16(byte[] value, int startIndex)
	{
		short result = default(short);
		UShortFromBytes((byte*)(&result), value, startIndex);
		return result;
	}

	internal unsafe static int ToInt32(byte[] value, int startIndex)
	{
		int result = default(int);
		UIntFromBytes((byte*)(&result), value, startIndex);
		return result;
	}

	internal unsafe static ushort ToUInt16(byte[] value, int startIndex)
	{
		ushort result = default(ushort);
		UShortFromBytes((byte*)(&result), value, startIndex);
		return result;
	}

	internal unsafe static uint ToUInt32(byte[] value, int startIndex)
	{
		uint result = default(uint);
		UIntFromBytes((byte*)(&result), value, startIndex);
		return result;
	}
}
