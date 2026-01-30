using System;
using System.Collections.Generic;

namespace MimeKit.Text;

internal class UrlScanner
{
	private delegate bool GetIndexDelegate(UrlMatch match, char[] input, int startIndex, int matchIndex, int endIndex);

	private const string AtomCharacters = "!#$%&'*+-/=?^_`{|}~";

	private const string UrlSafeCharacters = "$-_.+!*'(),{}|\\^~[]`#%\";/?:@&=";

	private readonly Dictionary<string, UrlPattern> patterns = new Dictionary<string, UrlPattern>(StringComparer.Ordinal);

	private readonly Trie trie = new Trie(ignoreCase: true);

	public void Add(UrlPattern pattern)
	{
		patterns.Add(pattern.Pattern, pattern);
		trie.Add(pattern.Pattern);
	}

	public bool Scan(char[] text, int startIndex, int count, out UrlMatch match)
	{
		int endIndex = startIndex + count;
		int matchIndex;
		if ((matchIndex = trie.Search(text, startIndex, count, out var pattern)) == -1)
		{
			match = null;
			return false;
		}
		if (!patterns.TryGetValue(pattern, out var value))
		{
			match = null;
			return false;
		}
		match = new UrlMatch(value.Pattern, value.Prefix);
		GetIndexDelegate getIndexDelegate;
		GetIndexDelegate getIndexDelegate2;
		switch (value.Type)
		{
		case UrlPatternType.Addrspec:
			getIndexDelegate = GetAddrspecStartIndex;
			getIndexDelegate2 = GetAddrspecEndIndex;
			break;
		case UrlPatternType.MailTo:
			getIndexDelegate = GetMailToStartIndex;
			getIndexDelegate2 = GetMailToEndIndex;
			break;
		case UrlPatternType.File:
			getIndexDelegate = GetFileStartIndex;
			getIndexDelegate2 = GetFileEndIndex;
			break;
		default:
			getIndexDelegate = GetWebStartIndex;
			getIndexDelegate2 = GetWebEndIndex;
			break;
		}
		if (!getIndexDelegate(match, text, startIndex, matchIndex, endIndex))
		{
			match = null;
			return false;
		}
		if (!getIndexDelegate2(match, text, startIndex, matchIndex, endIndex))
		{
			match = null;
			return false;
		}
		return true;
	}

	private static char GetClosingBrace(UrlMatch match, char[] text, int startIndex)
	{
		if (match.StartIndex == startIndex)
		{
			return '\0';
		}
		return text[match.StartIndex - 1] switch
		{
			'(' => ')', 
			'{' => '}', 
			'[' => ']', 
			'<' => '>', 
			'|' => '|', 
			_ => '\0', 
		};
	}

	private static bool IsDigit(char c)
	{
		if (c >= '0')
		{
			return c <= '9';
		}
		return false;
	}

	private static bool IsLetterOrDigit(char c)
	{
		if ((c < 'A' || c > 'Z') && (c < 'a' || c > 'z'))
		{
			return IsDigit(c);
		}
		return true;
	}

	private static bool IsUrlSafe(char c)
	{
		if (c < '\u0080' && !IsLetterOrDigit(c))
		{
			return "$-_.+!*'(),{}|\\^~[]`#%\";/?:@&=".IndexOf(c) != -1;
		}
		return true;
	}

	private static bool IsAtom(char c)
	{
		if (c < '\u0080' && !IsLetterOrDigit(c))
		{
			return "!#$%&'*+-/=?^_`{|}~".IndexOf(c) != -1;
		}
		return true;
	}

	private static bool IsDomain(char c)
	{
		if (c < '\u0080' && !IsLetterOrDigit(c))
		{
			return c == '-';
		}
		return true;
	}

	private static bool SkipAtom(char[] text, int endIndex, ref int index)
	{
		int num = index;
		while (index < endIndex && IsAtom(text[index]))
		{
			index++;
		}
		return index > num;
	}

	private static bool SkipAtomBackwards(char[] text, int startIndex, ref int index)
	{
		if (!IsAtom(text[index]))
		{
			return false;
		}
		while (index > startIndex && IsAtom(text[index - 1]))
		{
			index--;
		}
		return true;
	}

	private static bool SkipSubDomain(char[] text, int endIndex, ref int index)
	{
		if (!IsDomain(text[index]) || text[index] == '-')
		{
			return false;
		}
		index++;
		while (index < endIndex && IsDomain(text[index]))
		{
			index++;
		}
		return true;
	}

	private static bool SkipDomain(char[] text, int endIndex, ref int index)
	{
		if (!SkipSubDomain(text, endIndex, ref index))
		{
			return false;
		}
		while (index < endIndex && text[index] == '.')
		{
			int num = index++;
			if (index == endIndex || !SkipSubDomain(text, endIndex, ref index))
			{
				index = num;
				break;
			}
		}
		return true;
	}

	private static bool SkipQuoted(char[] text, int endIndex, ref int index)
	{
		bool flag = false;
		index++;
		while (index < endIndex)
		{
			if (text[index] == '\\')
			{
				flag = !flag;
			}
			else if (!flag)
			{
				if (text[index] == '"')
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
		if (index >= endIndex || text[index] != '"')
		{
			return false;
		}
		index++;
		return true;
	}

	private static bool SkipQuotedBackwards(char[] text, int startIndex, ref int index)
	{
		index--;
		while (index >= startIndex && (text[index] != '"' || (index != startIndex && text[index - 1] == '\\')))
		{
			index--;
		}
		if (index < startIndex || text[index] != '"')
		{
			return false;
		}
		return true;
	}

	private static bool SkipWord(char[] text, int endIndex, ref int index)
	{
		if (text[index] == '"')
		{
			return SkipQuoted(text, endIndex, ref index);
		}
		return SkipAtom(text, endIndex, ref index);
	}

	private static bool SkipWordBackwards(char[] text, int startIndex, ref int index)
	{
		if (text[index] == '"')
		{
			return SkipQuotedBackwards(text, startIndex, ref index);
		}
		return SkipAtomBackwards(text, startIndex, ref index);
	}

	private static bool SkipIPv4Literal(char[] text, int endIndex, ref int index)
	{
		int num = 0;
		while (index < endIndex && num < 4)
		{
			int num2 = index;
			int num3 = 0;
			while (index < endIndex && text[index] >= '0' && text[index] <= '9')
			{
				num3 = num3 * 10 + (text[index] - 48);
				index++;
			}
			if (index == num2 || index - num2 > 3 || num3 > 255)
			{
				return false;
			}
			num++;
			if (num < 4 && index < endIndex && text[index] == '.')
			{
				index++;
			}
		}
		return num == 4;
	}

	private static bool IsHexDigit(char c)
	{
		if ((c < 'A' || c > 'F') && (c < 'a' || c > 'f'))
		{
			if (c >= '0')
			{
				return c <= '9';
			}
			return false;
		}
		return true;
	}

	private static bool IsIPv6(char[] text, int startIndex)
	{
		int num = startIndex;
		if (text[num] != 'I' && text[num] != 'i')
		{
			return false;
		}
		num++;
		if (text[num] != 'P' && text[num] != 'p')
		{
			return false;
		}
		num++;
		if (text[num] != 'V' && text[num] != 'v')
		{
			return false;
		}
		num++;
		if (text[num] == '6')
		{
			return text[num + 1] == ':';
		}
		return false;
	}

	private static bool SkipIPv6Literal(char[] text, int endIndex, ref int index)
	{
		bool flag = false;
		int num = 0;
		while (index < endIndex)
		{
			int num2 = index;
			while (index < endIndex && IsHexDigit(text[index]))
			{
				index++;
			}
			if (index >= endIndex)
			{
				break;
			}
			if (index > num2 && num > 2 && text[index] == '.')
			{
				index = num2;
				if (!SkipIPv4Literal(text, endIndex, ref index))
				{
					return false;
				}
				if (!flag)
				{
					return num == 6;
				}
				return num < 6;
			}
			int num3 = index - num2;
			if (num3 > 4)
			{
				return false;
			}
			if (text[index] != ':')
			{
				break;
			}
			num2 = index;
			while (index < endIndex && text[index] == ':')
			{
				index++;
			}
			num3 = index - num2;
			if (num3 > 2)
			{
				return false;
			}
			if (num3 == 2)
			{
				if (flag)
				{
					return false;
				}
				flag = true;
				num += 2;
			}
			else
			{
				num++;
			}
		}
		if (num < 2)
		{
			return false;
		}
		if (!flag)
		{
			return num == 7;
		}
		return num < 7;
	}

	private static bool GetAddrspecStartIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		int index = matchIndex - 1;
		if (matchIndex == startIndex)
		{
			return false;
		}
		while (true)
		{
			if (!SkipWordBackwards(text, startIndex, ref index))
			{
				return false;
			}
			if (index == startIndex || text[index - 1] != '.')
			{
				break;
			}
			index -= 2;
			if (index <= startIndex)
			{
				return false;
			}
		}
		match.StartIndex = index;
		return true;
	}

	private static bool GetAddrspecEndIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		int index = matchIndex + 1;
		if (index == endIndex)
		{
			return false;
		}
		if (text[index] != '[')
		{
			if (!SkipDomain(text, endIndex, ref index))
			{
				return false;
			}
			match.EndIndex = index;
			return true;
		}
		index++;
		if (index + 8 >= endIndex)
		{
			return false;
		}
		if (IsIPv6(text, index))
		{
			index += "IPv6:".Length;
			if (!SkipIPv6Literal(text, endIndex, ref index))
			{
				return false;
			}
		}
		else if (!SkipIPv4Literal(text, endIndex, ref index))
		{
			return false;
		}
		if (index >= endIndex || text[index++] != ']')
		{
			return false;
		}
		match.EndIndex = index;
		return true;
	}

	private static bool GetFileStartIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		match.StartIndex = matchIndex;
		return true;
	}

	private static bool GetFileEndIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		char closingBrace = GetClosingBrace(match, text, startIndex);
		int i;
		for (i = matchIndex + match.Pattern.Length; i < endIndex && IsUrlSafe(text[i]) && text[i] != closingBrace; i++)
		{
		}
		match.EndIndex = i;
		return i > matchIndex + match.Pattern.Length;
	}

	private static bool GetMailToStartIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		match.StartIndex = matchIndex;
		return true;
	}

	private static bool SkipAddrspec(char[] text, int endIndex, ref int index)
	{
		if (!SkipWord(text, endIndex, ref index) || index >= endIndex)
		{
			return false;
		}
		while (text[index] == '.')
		{
			index++;
			if (index >= endIndex)
			{
				return false;
			}
			if (!SkipWord(text, endIndex, ref index))
			{
				return false;
			}
			if (index >= endIndex)
			{
				return false;
			}
		}
		if (index + 1 >= endIndex || text[index++] != '@')
		{
			return false;
		}
		if (text[index] != '[')
		{
			if (!SkipDomain(text, endIndex, ref index))
			{
				return false;
			}
		}
		else
		{
			index++;
			if (index + 8 >= endIndex)
			{
				return false;
			}
			if (IsIPv6(text, index))
			{
				index += "IPv6:".Length;
				if (!SkipIPv6Literal(text, endIndex, ref index))
				{
					return false;
				}
			}
			else if (!SkipIPv4Literal(text, endIndex, ref index))
			{
				return false;
			}
			if (index >= endIndex || text[index++] != ']')
			{
				return false;
			}
		}
		return true;
	}

	private static bool GetMailToEndIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		char closingBrace = GetClosingBrace(match, text, startIndex);
		int num = matchIndex + match.Pattern.Length;
		int i = num;
		if (num >= endIndex)
		{
			return false;
		}
		if (!SkipAddrspec(text, endIndex, ref i))
		{
			i = num;
		}
		if (i < endIndex && text[i] == '?')
		{
			for (i++; i < endIndex && IsUrlSafe(text[i]) && text[i] != closingBrace; i++)
			{
			}
		}
		match.EndIndex = i;
		return i > num;
	}

	private static bool GetWebStartIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		match.StartIndex = matchIndex;
		return true;
	}

	private static bool GetWebEndIndex(UrlMatch match, char[] text, int startIndex, int matchIndex, int endIndex)
	{
		char closingBrace = GetClosingBrace(match, text, startIndex);
		int i = matchIndex + match.Pattern.Length;
		if (i >= endIndex || !SkipDomain(text, endIndex, ref i))
		{
			return false;
		}
		if (i + 1 < endIndex && text[i] == ':' && IsDigit(text[i + 1]))
		{
			for (i += 2; i < endIndex && IsDigit(text[i]); i++)
			{
			}
		}
		if (i < endIndex && text[i] == '/')
		{
			for (i++; i < endIndex && IsUrlSafe(text[i]) && text[i] != closingBrace; i++)
			{
			}
		}
		match.EndIndex = i;
		return true;
	}
}
