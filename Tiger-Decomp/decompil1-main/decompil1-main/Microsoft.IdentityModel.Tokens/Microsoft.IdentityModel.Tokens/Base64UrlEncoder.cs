using System;
using System.Text;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

public static class Base64UrlEncoder
{
	private const char base64PadCharacter = '=';

	private const char base64Character62 = '+';

	private const char base64Character63 = '/';

	private const char base64UrlCharacter62 = '-';

	private const char base64UrlCharacter63 = '_';

	internal static readonly char[] s_base64Table = new char[64]
	{
		'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
		'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
		'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd',
		'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
		'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
		'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7',
		'8', '9', '-', '_'
	};

	public static string Encode(string arg)
	{
		if (arg == null)
		{
			throw LogHelper.LogArgumentNullException("arg");
		}
		return Encode(Encoding.UTF8.GetBytes(arg));
	}

	public static string Encode(byte[] inArray, int offset, int length)
	{
		if (inArray == null)
		{
			throw LogHelper.LogArgumentNullException("inArray");
		}
		if (length == 0)
		{
			return string.Empty;
		}
		if (length < 0)
		{
			throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException(LogHelper.FormatInvariant("IDX10106: The parameter {0} had an invalid value: '{1}'.", LogHelper.MarkAsNonPII("length"), LogHelper.MarkAsNonPII(length))));
		}
		if (offset < 0 || inArray.Length < offset)
		{
			throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException(LogHelper.FormatInvariant("IDX10106: The parameter {0} had an invalid value: '{1}'.", LogHelper.MarkAsNonPII("offset"), LogHelper.MarkAsNonPII(offset))));
		}
		if (inArray.Length < offset + length)
		{
			throw LogHelper.LogExceptionMessage(new ArgumentOutOfRangeException(LogHelper.FormatInvariant("IDX10106: The parameter {0} had an invalid value: '{1}'.", LogHelper.MarkAsNonPII("length"), LogHelper.MarkAsNonPII(length))));
		}
		int num = length % 3;
		int num2 = offset + (length - num);
		char[] array = new char[(length + 2) / 3 * 4];
		char[] array2 = s_base64Table;
		int num3 = 0;
		int i;
		for (i = offset; i < num2; i += 3)
		{
			byte b = inArray[i];
			byte b2 = inArray[i + 1];
			byte b3 = inArray[i + 2];
			array[num3] = array2[b >> 2];
			array[num3 + 1] = array2[((b & 3) << 4) | (b2 >> 4)];
			array[num3 + 2] = array2[((b2 & 0xF) << 2) | (b3 >> 6)];
			array[num3 + 3] = array2[b3 & 0x3F];
			num3 += 4;
		}
		i = num2;
		switch (num)
		{
		case 2:
		{
			byte b5 = inArray[i];
			byte b6 = inArray[i + 1];
			array[num3] = array2[b5 >> 2];
			array[num3 + 1] = array2[((b5 & 3) << 4) | (b6 >> 4)];
			array[num3 + 2] = array2[(b6 & 0xF) << 2];
			num3 += 3;
			break;
		}
		case 1:
		{
			byte b4 = inArray[i];
			array[num3] = array2[b4 >> 2];
			array[num3 + 1] = array2[(b4 & 3) << 4];
			num3 += 2;
			break;
		}
		}
		return new string(array, 0, num3);
	}

	public static string Encode(byte[] inArray)
	{
		if (inArray == null)
		{
			throw LogHelper.LogArgumentNullException("inArray");
		}
		return Encode(inArray, 0, inArray.Length);
	}

	internal static string EncodeString(string str)
	{
		if (str == null)
		{
			throw LogHelper.LogArgumentNullException("str");
		}
		return Encode(Encoding.UTF8.GetBytes(str));
	}

	public static byte[] DecodeBytes(string str)
	{
		if (str == null)
		{
			throw LogHelper.LogExceptionMessage(new ArgumentNullException("str"));
		}
		return UnsafeDecode(str);
	}

	private unsafe static byte[] UnsafeDecode(string str)
	{
		int num = str.Length % 4;
		if (num == 1)
		{
			throw LogHelper.LogExceptionMessage(new FormatException(LogHelper.FormatInvariant("IDX10400: Unable to decode: '{0}' as Base64url encoded string.", str)));
		}
		bool flag = false;
		int num2 = str.Length + (4 - num) % 4;
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] == '-' || str[i] == '_')
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			string text = new string('\0', num2);
			fixed (char* ptr = text)
			{
				int j;
				for (j = 0; j < str.Length; j++)
				{
					if (str[j] == '-')
					{
						ptr[j] = '+';
					}
					else if (str[j] == '_')
					{
						ptr[j] = '/';
					}
					else
					{
						ptr[j] = str[j];
					}
				}
				for (; j < num2; j++)
				{
					ptr[j] = '=';
				}
			}
			return Convert.FromBase64String(text);
		}
		if (num2 == str.Length)
		{
			return Convert.FromBase64String(str);
		}
		string text2 = new string('\0', num2);
		fixed (char* source = str)
		{
			fixed (char* ptr2 = text2)
			{
				Buffer.MemoryCopy(source, ptr2, str.Length * 2, str.Length * 2);
				ptr2[str.Length] = '=';
				if (str.Length + 2 == num2)
				{
					ptr2[str.Length + 1] = '=';
				}
			}
		}
		return Convert.FromBase64String(text2);
	}

	public static string Decode(string arg)
	{
		return Encoding.UTF8.GetString(DecodeBytes(arg));
	}
}
