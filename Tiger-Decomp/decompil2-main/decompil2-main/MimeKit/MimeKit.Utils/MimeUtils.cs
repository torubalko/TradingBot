using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace MimeKit.Utils;

public static class MimeUtils
{
	private const string base36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	private static string DefaultHostName = null;

	public static readonly IEqualityComparer<string> OrdinalIgnoreCase = new OptimizedOrdinalIgnoreCaseComparer();

	internal static void GetRandomBytes(byte[] buffer)
	{
		using RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();
		randomNumberGenerator.GetBytes(buffer);
	}

	public static string GenerateMessageId(string domain)
	{
		if (domain == null)
		{
			throw new ArgumentNullException("domain");
		}
		if (domain.Length == 0)
		{
			throw new ArgumentException("The domain is invalid.", "domain");
		}
		ulong num = (ulong)DateTime.Now.Ticks;
		StringBuilder stringBuilder = new StringBuilder();
		byte[] array = new byte[8];
		GetRandomBytes(array);
		do
		{
			stringBuilder.Append("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[(int)(num % 36)]);
			num /= 36;
		}
		while (num != 0L);
		stringBuilder.Append('.');
		num = 0uL;
		for (int i = 0; i < 8; i++)
		{
			num = (num << 8) | array[i];
		}
		do
		{
			stringBuilder.Append("0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ"[(int)(num % 36)]);
			num /= 36;
		}
		while (num != 0L);
		stringBuilder.Append('@').Append(ParseUtils.IdnEncode(domain));
		return stringBuilder.ToString();
	}

	public static string GenerateMessageId()
	{
		if (DefaultHostName == null)
		{
			try
			{
				IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
				DefaultHostName = iPGlobalProperties.HostName;
			}
			catch
			{
				DefaultHostName = "localhost.localdomain";
			}
		}
		return GenerateMessageId(DefaultHostName);
	}

	public static IEnumerable<string> EnumerateReferences(byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(buffer, startIndex, length);
		int endIndex = startIndex + length;
		int index = startIndex;
		while (ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, endIndex, throwOnError: false) && index < endIndex)
		{
			if (buffer[index] == 60)
			{
				if (ParseUtils.TryParseMsgId(buffer, ref index, endIndex, requireAngleAddr: true, throwOnError: false, out var msgid))
				{
					yield return msgid;
				}
			}
			else if (!ParseUtils.SkipWord(buffer, ref index, endIndex, throwOnError: false))
			{
				index++;
			}
			if (index >= endIndex)
			{
				break;
			}
		}
	}

	public static IEnumerable<string> EnumerateReferences(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		return EnumerateReferences(bytes, 0, bytes.Length);
	}

	public static string ParseMessageId(byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(buffer, startIndex, length);
		int endIndex = startIndex + length;
		int index = startIndex;
		ParseUtils.TryParseMsgId(buffer, ref index, endIndex, requireAngleAddr: false, throwOnError: false, out var msgid);
		return msgid;
	}

	public static string ParseMessageId(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		return ParseMessageId(bytes, 0, bytes.Length);
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out Version version)
	{
		ParseUtils.ValidateArguments(buffer, startIndex, length);
		List<int> list = new List<int>();
		int num = startIndex + length;
		int index = startIndex;
		version = null;
		do
		{
			if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false) || index >= num)
			{
				return false;
			}
			if (!ParseUtils.TryParseInt32(buffer, ref index, num, out var value))
			{
				return false;
			}
			list.Add(value);
			if (!ParseUtils.SkipCommentsAndWhiteSpace(buffer, ref index, num, throwOnError: false))
			{
				return false;
			}
			if (index >= num)
			{
				break;
			}
			if (buffer[index++] != 46)
			{
				return false;
			}
		}
		while (index < num);
		switch (list.Count)
		{
		case 4:
			version = new Version(list[0], list[1], list[2], list[3]);
			break;
		case 3:
			version = new Version(list[0], list[1], list[2]);
			break;
		case 2:
			version = new Version(list[0], list[1]);
			break;
		default:
			return false;
		}
		return true;
	}

	public static bool TryParse(string text, out Version version)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		return TryParse(bytes, 0, bytes.Length, out version);
	}

	public static bool TryParse(string text, out ContentEncoding encoding)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		char[] array = new char[text.Length];
		int i = 0;
		int length = 0;
		for (; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		while (i < text.Length && text[i] != ';' && !char.IsWhiteSpace(text[i]))
		{
			array[length++] = char.ToLowerInvariant(text[i++]);
		}
		switch (new string(array, 0, length))
		{
		case "7bit":
			encoding = ContentEncoding.SevenBit;
			break;
		case "8bit":
			encoding = ContentEncoding.EightBit;
			break;
		case "binary":
			encoding = ContentEncoding.Binary;
			break;
		case "base64":
			encoding = ContentEncoding.Base64;
			break;
		case "quoted-printable":
			encoding = ContentEncoding.QuotedPrintable;
			break;
		case "x-uuencode":
			encoding = ContentEncoding.UUEncode;
			break;
		case "uuencode":
			encoding = ContentEncoding.UUEncode;
			break;
		case "x-uue":
			encoding = ContentEncoding.UUEncode;
			break;
		default:
			encoding = ContentEncoding.Default;
			break;
		}
		return encoding != ContentEncoding.Default;
	}

	public static StringBuilder AppendQuoted(StringBuilder builder, string text)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		builder.Append("\"");
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] == '\\' || text[i] == '"')
			{
				builder.Append('\\');
			}
			builder.Append(text[i]);
		}
		builder.Append("\"");
		return builder;
	}

	public static string Quote(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length + 2, text.Length * 2 + 2);
		AppendQuoted(stringBuilder, text);
		return stringBuilder.ToString();
	}

	public static string Unquote(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		int num = text.IndexOfAny(new char[5] { '\r', '\n', '\t', '\\', '"' });
		if (num == -1)
		{
			return text;
		}
		StringBuilder stringBuilder = new StringBuilder(text.Length);
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < text.Length; i++)
		{
			switch (text[i])
			{
			case '\n':
			case '\r':
				flag = false;
				break;
			case '\t':
				stringBuilder.Append(' ');
				flag = false;
				break;
			case '\\':
				if (flag)
				{
					stringBuilder.Append('\\');
				}
				flag = !flag;
				break;
			case '"':
				if (flag)
				{
					stringBuilder.Append('"');
					flag = false;
				}
				else
				{
					flag2 = !flag2;
				}
				break;
			default:
				stringBuilder.Append(text[i]);
				flag = false;
				break;
			}
		}
		return stringBuilder.ToString();
	}
}
