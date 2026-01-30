using System;
using System.Globalization;
using System.Text;

namespace MimeKit.Utils;

internal static class ParseUtils
{
	private static readonly IdnMapping idn = new IdnMapping();

	private static readonly byte[] GreaterThanOrAt = new byte[2] { 62, 64 };

	public static void ValidateArguments(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (startIndex < 0 || startIndex > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (length < 0 || length > buffer.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("length");
		}
	}

	public static void ValidateArguments(ParserOptions options, byte[] buffer, int startIndex)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (startIndex < 0 || startIndex > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
	}

	public static void ValidateArguments(ParserOptions options, byte[] buffer)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
	}

	public static void ValidateArguments(ParserOptions options, string text)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
	}

	public static void ValidateArguments(byte[] buffer, int startIndex, int length)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (startIndex < 0 || startIndex > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (length < 0 || length > buffer.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("length");
		}
	}

	public static bool TryParseInt32(byte[] text, ref int index, int endIndex, out int value)
	{
		int num = index;
		value = 0;
		while (index < endIndex && text[index] >= 48 && text[index] <= 57)
		{
			int num2 = text[index] - 48;
			if (value > 214748364)
			{
				return false;
			}
			if (value == 214748364 && num2 > 7)
			{
				return false;
			}
			value = value * 10 + num2;
			index++;
		}
		return index > num;
	}

	public static bool SkipWhiteSpace(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsWhitespace())
		{
			index++;
		}
		return index > num;
	}

	public static bool SkipComment(byte[] text, ref int index, int endIndex)
	{
		bool flag = false;
		int num = 1;
		index++;
		while (index < endIndex && num > 0)
		{
			if (text[index] == 92)
			{
				flag = !flag;
			}
			else if (!flag)
			{
				if (text[index] == 40)
				{
					num++;
				}
				else if (text[index] == 41)
				{
					num--;
				}
				flag = false;
			}
			else
			{
				flag = false;
			}
			index++;
		}
		return num == 0;
	}

	public static bool SkipCommentsAndWhiteSpace(byte[] text, ref int index, int endIndex, bool throwOnError)
	{
		SkipWhiteSpace(text, ref index, endIndex);
		while (index < endIndex && text[index] == 40)
		{
			int num = index;
			if (!SkipComment(text, ref index, endIndex))
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete comment token at offset {0}", num), num, index);
				}
				return false;
			}
			SkipWhiteSpace(text, ref index, endIndex);
		}
		return true;
	}

	public static bool SkipQuoted(byte[] text, ref int index, int endIndex, bool throwOnError)
	{
		int num = index;
		bool flag = false;
		index++;
		while (index < endIndex)
		{
			if (text[index] == 92)
			{
				flag = !flag;
			}
			else if (!flag)
			{
				if (text[index] == 34)
				{
					break;
				}
			}
			else
			{
				flag = false;
			}
			index++;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete quoted-string token at offset {0}", num), num, index);
			}
			return false;
		}
		index++;
		return true;
	}

	public static bool SkipAtom(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsAtom())
		{
			index++;
		}
		return index > num;
	}

	public static bool SkipPhraseAtom(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsPhraseAtom())
		{
			index++;
		}
		return index > num;
	}

	public static bool SkipToken(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsToken())
		{
			index++;
		}
		return index > num;
	}

	public static bool SkipWord(byte[] text, ref int index, int endIndex, bool throwOnError)
	{
		if (text[index] == 34)
		{
			return SkipQuoted(text, ref index, endIndex, throwOnError);
		}
		if (text[index].IsAtom())
		{
			return SkipAtom(text, ref index, endIndex);
		}
		return false;
	}

	public static bool IsSentinel(byte c, byte[] sentinels)
	{
		for (int i = 0; i < sentinels.Length; i++)
		{
			if (c == sentinels[i])
			{
				return true;
			}
		}
		return false;
	}

	private static bool TryParseDotAtom(byte[] text, ref int index, int endIndex, byte[] sentinels, bool throwOnError, string tokenType, out string dotatom)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = index;
		dotatom = null;
		while (true)
		{
			if (!text[index].IsAtom())
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid {0} token at offset {1}", tokenType, num), num, index);
				}
				return false;
			}
			int num2 = index;
			while (index < endIndex && text[index].IsAtom())
			{
				index++;
			}
			try
			{
				stringBuilder.Append(CharsetUtils.UTF8.GetString(text, num2, index - num2));
			}
			catch (DecoderFallbackException innerException)
			{
				if (throwOnError)
				{
					throw new ParseException("Internationalized domains may only contain UTF-8 characters.", num2, num2, innerException);
				}
				return false;
			}
			int num3 = index;
			if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex || text[index] != 46)
			{
				index = num3;
				break;
			}
			index++;
			if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex || IsSentinel(text[index], sentinels))
			{
				break;
			}
			stringBuilder.Append('.');
		}
		dotatom = stringBuilder.ToString();
		return true;
	}

	private static bool TryParseDomainLiteral(byte[] text, ref int index, int endIndex, bool throwOnError, out string domain)
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		int num = index++;
		domain = null;
		SkipWhiteSpace(text, ref index, endIndex);
		while (true)
		{
			if (index < endIndex && text[index].IsDomain())
			{
				stringBuilder.Append((char)text[index]);
				index++;
				continue;
			}
			SkipWhiteSpace(text, ref index, endIndex);
			if (index >= endIndex)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete domain literal token at offset {0}", num), num, index);
				}
				return false;
			}
			if (text[index] == 93)
			{
				break;
			}
			if (!text[index].IsDomain())
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid domain literal token at offset {0}", num), num, index);
				}
				return false;
			}
		}
		stringBuilder.Append(']');
		index++;
		domain = stringBuilder.ToString();
		return true;
	}

	public static bool TryParseDomain(byte[] text, ref int index, int endIndex, byte[] sentinels, bool throwOnError, out string domain)
	{
		if (text[index] == 91)
		{
			return TryParseDomainLiteral(text, ref index, endIndex, throwOnError, out domain);
		}
		return TryParseDotAtom(text, ref index, endIndex, sentinels, throwOnError, "domain", out domain);
	}

	public static bool TryParseMsgId(byte[] text, ref int index, int endIndex, bool requireAngleAddr, bool throwOnError, out string msgid)
	{
		bool flag = false;
		msgid = null;
		if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex || (requireAngleAddr && text[index] != 60))
		{
			if (throwOnError)
			{
				throw new ParseException("No msg-id token found.", index, index);
			}
			return false;
		}
		int num = index;
		if (text[index] == 60)
		{
			flag = true;
			index++;
		}
		SkipWhiteSpace(text, ref index, endIndex);
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete msg-id token at offset {0}", num), num, index);
			}
			return false;
		}
		StringBuilder stringBuilder = new StringBuilder();
		while (true)
		{
			int num2 = index;
			if (text[index] == 34)
			{
				if (!SkipQuoted(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
			}
			else
			{
				while (index < endIndex && text[index] != 46 && text[index] != 64 && text[index] != 62 && !text[index].IsWhitespace())
				{
					index++;
				}
			}
			try
			{
				stringBuilder.Append(CharsetUtils.UTF8.GetString(text, num2, index - num2));
			}
			catch (DecoderFallbackException innerException)
			{
				if (throwOnError)
				{
					throw new ParseException("Internationalized local-part tokens may only contain UTF-8 characters.", num2, num2, innerException);
				}
				return false;
			}
			if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				if (!flag)
				{
					break;
				}
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete msg-id token at offset {0}", num), num, index);
				}
				return false;
			}
			if (text[index] == 64 || text[index] == 62)
			{
				break;
			}
			if (text[index] != 46)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid msg-id token at offset {0}", num), num, index);
				}
				return false;
			}
			stringBuilder.Append('.');
			index++;
			if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index >= endIndex)
			{
				if (throwOnError)
				{
					throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete msg-id at offset {0}", num), num, index);
				}
				return false;
			}
		}
		if (index < endIndex && text[index] == 64)
		{
			stringBuilder.Append('@');
			index++;
			if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			if (index < endIndex && text[index] != 62)
			{
				while (true)
				{
					if (!TryParseDomain(text, ref index, endIndex, GreaterThanOrAt, throwOnError, out var domain))
					{
						return false;
					}
					if (IsIdnEncoded(domain))
					{
						domain = IdnDecode(domain);
					}
					stringBuilder.Append(domain);
					if (index >= endIndex || text[index] != 64)
					{
						break;
					}
					stringBuilder.Append('@');
					index++;
				}
				if (!SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
				{
					return false;
				}
			}
		}
		if (flag && (index >= endIndex || text[index] != 62))
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Incomplete msg-id token at offset {0}", num), num, index);
			}
			return false;
		}
		if (index < endIndex && text[index] == 62)
		{
			index++;
		}
		msgid = stringBuilder.ToString();
		return true;
	}

	public static bool IsInternational(string value)
	{
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] > '\u007f')
			{
				return true;
			}
		}
		return false;
	}

	public static bool IsIdnEncoded(string value)
	{
		if (value.StartsWith("xn--", StringComparison.Ordinal))
		{
			return true;
		}
		return value.IndexOf(".xn--", StringComparison.Ordinal) != -1;
	}

	public static string IdnEncode(string unicode)
	{
		try
		{
			return idn.GetAscii(unicode);
		}
		catch
		{
			return unicode;
		}
	}

	public static string IdnDecode(string ascii)
	{
		try
		{
			return idn.GetUnicode(ascii);
		}
		catch
		{
			return ascii;
		}
	}
}
