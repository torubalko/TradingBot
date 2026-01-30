using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Text.RegularExpressions;

public static class RegexHelper
{
	private static RegexHelper wbZ;

	public static string Escape(string pattern)
	{
		return Escape(pattern, isReplacePattern: false);
	}

	public static string Escape(string pattern, bool isReplacePattern)
	{
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		int num = default(int);
		string result = default(string);
		if (!string.IsNullOrEmpty(pattern))
		{
			if (!isReplacePattern)
			{
				stringBuilder = new StringBuilder();
				text = pattern;
				num = 0;
				goto IL_0055;
			}
			result = pattern.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6126), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7114)).Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7122), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7128));
			goto IL_0169;
		}
		result = pattern;
		int num2 = 0;
		if (Fb8() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		goto IL_0009;
		IL_0009:
		switch (num2)
		{
		case 1:
			break;
		default:
			goto IL_0169;
		}
		bool flag = default(bool);
		char c = default(char);
		if (!flag)
		{
			stringBuilder.Append(c);
		}
		else
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6126) + c);
		}
		num++;
		goto IL_0055;
		IL_0169:
		return result;
		IL_0055:
		if (num < text.Length)
		{
			c = text[num];
			flag = IsPatternSpecialChar(c);
			num2 = 1;
			if (!sb9())
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		result = stringBuilder.ToString();
		goto IL_0169;
	}

	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public static bool IsPatternSpecialChar(char ch)
	{
		char c = ch;
		char c2 = c;
		switch (c2)
		{
		case '\0':
		case '\u0001':
		case '\u0002':
		case '\u0003':
		case '\u0004':
		case '\u0005':
		case '\u0006':
		case '\a':
		case '\b':
		case '\t':
		case '\n':
		case '\v':
		case '\f':
		case '\r':
		case '\u000e':
		case '\u000f':
		case '\u0010':
		case '\u0011':
		case '\u0012':
		case '\u0013':
		case '\u0014':
		case '\u0015':
		case '\u0016':
		case '\u0017':
		case '\u0018':
		case '\u0019':
		case '\u001a':
		case '\u001b':
		case '\u001c':
		case '\u001d':
		case '\u001e':
		case '\u001f':
		case ' ':
		case '!':
		case '#':
		case '%':
		case '&':
		case '\'':
		case ',':
		case '-':
		case '/':
		case '0':
		case '1':
		case '2':
		case '3':
		case '4':
		case '5':
		case '6':
		case '7':
		case '8':
		case '9':
		case ':':
		case ';':
		case '<':
		case '=':
		case '>':
			return false;
		case '"':
		case '$':
		case '(':
		case ')':
		case '*':
		case '+':
		case '.':
		case '?':
		case '[':
		case '\\':
		case ']':
		case '^':
			break;
		default:
		{
			int num = 0;
			if (!sb9())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (c2 == '{' || c2 == '|')
			{
				break;
			}
			goto case '\0';
		}
		}
		return true;
	}

	public static void Validate(string pattern, bool allowCapturing)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7136));
		}
		new RegexParser().ParsePattern(pattern, allowCapturing, requestIsReplacementPattern: false, CaseSensitivity.Insensitive);
	}

	public static void Validate(string pattern, bool allowCapturing, HashSet<string> macroKeys)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(7136));
		}
		new RegexParser().ParsePattern(pattern, allowCapturing, requestIsReplacementPattern: false, CaseSensitivity.Insensitive)?.ValidateMacros(macroKeys);
	}

	internal static bool sb9()
	{
		return wbZ == null;
	}

	internal static RegexHelper Fb8()
	{
		return wbZ;
	}
}
