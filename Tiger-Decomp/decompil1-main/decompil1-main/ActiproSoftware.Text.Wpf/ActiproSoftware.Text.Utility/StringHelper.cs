using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Text.Utility;

public static class StringHelper
{
	private static StringHelper KW3;

	private static string oBq(IList<string> P_0, LineTerminator P_1)
	{
		if (P_0.Count == 0)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int count = P_0.Count;
		string lineTerminatorText = GetLineTerminatorText(P_1);
		for (int i = 0; i < count - 1; i++)
		{
			stringBuilder.Append(P_0[i]);
			stringBuilder.Append(lineTerminatorText);
		}
		stringBuilder.Append(P_0[count - 1]);
		return stringBuilder.ToString();
	}

	internal static int[] GetLineFeedIndices(string text)
	{
		List<int> list = new List<int>();
		int num3 = default(int);
		for (int num = text.IndexOf('\n'); num != -1; num = text.IndexOf('\n', num + 1))
		{
			list.Add(num);
			int num2 = 0;
			if (!TWC())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return list.ToArray();
	}

	internal static LineTerminator GetLineTerminator(string text)
	{
		int num = text.IndexOfAny(new char[2] { '\r', '\n' });
		PlatformID platformID = default(PlatformID);
		int num2;
		LineTerminator result = default(LineTerminator);
		if (num == -1)
		{
			if (Environment.OSVersion == null)
			{
				goto IL_00d2;
			}
			PlatformID platform = Environment.OSVersion.Platform;
			platformID = platform;
			if (platformID != PlatformID.Unix)
			{
				num2 = 2;
				goto IL_0009;
			}
			result = LineTerminator.Newline;
		}
		else
		{
			if (text[num] == '\r')
			{
				if (num + 1 < text.Length)
				{
					num2 = 0;
					if (!TWC())
					{
						int num3 = default(int);
						num2 = num3;
					}
					goto IL_0009;
				}
				goto IL_013f;
			}
			result = LineTerminator.Newline;
		}
		goto IL_0164;
		IL_0009:
		switch (num2)
		{
		case 2:
			break;
		case 1:
			goto IL_0164;
		default:
			goto IL_0167;
		}
		if (platformID != PlatformID.MacOSX)
		{
			goto IL_00d2;
		}
		result = LineTerminator.CarriageReturn;
		goto IL_0164;
		IL_0164:
		return result;
		IL_0167:
		if (text[num + 1] != '\n')
		{
			goto IL_013f;
		}
		result = LineTerminator.CarriageReturnNewline;
		goto IL_0164;
		IL_00d2:
		result = LineTerminator.CarriageReturnNewline;
		goto IL_0164;
		IL_013f:
		result = LineTerminator.CarriageReturn;
		num2 = 1;
		if (RWw() == null)
		{
			num2 = 1;
		}
		goto IL_0009;
	}

	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Di")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rtl")]
	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "BiDi")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Bi")]
	public static bool ContainsRtlCharacters(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5340));
		}
		foreach (char c in text)
		{
			if (c >= '\u0590' && (c <= 'ۿ' || (c >= 'יִ' && c <= 'ﭏ')))
			{
				return true;
			}
		}
		return false;
	}

	public static IList<string> ConvertTextToLines(string text)
	{
		int num = text.IndexOfAny(new char[2] { '\r', '\n' });
		if (num != -1)
		{
			if (text[num] == '\r' && (num + 1 >= text.Length || text[num + 1] != '\n'))
			{
				return text.Replace('\r', '\n').Split('\n');
			}
			return text.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5352), string.Empty).Split('\n');
		}
		return new string[1] { text };
	}

	public static string CreateDescription(string key)
	{
		string text = string.Empty;
		bool flag = !string.IsNullOrEmpty(key);
		int num = 2;
		if (!TWC())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		int num3 = default(int);
		bool flag2 = default(bool);
		do
		{
			IL_0009_2:
			switch (num)
			{
			case 1:
				num3++;
				goto IL_0141;
			default:
				if (num3 != key.Length - 1 && char.IsLower(key[num3 + 1]))
				{
					text += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920);
				}
				else if (!flag2)
				{
					text += WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920);
				}
				goto IL_010b;
			case 2:
				{
					if (flag)
					{
						flag2 = false;
						num3 = 0;
						goto IL_0141;
					}
					goto IL_015d;
				}
				IL_010b:
				text += key[num3];
				flag2 = char.IsUpper(key[num3]);
				num = 1;
				if (TWC())
				{
					num = 1;
				}
				goto IL_0009_2;
				IL_0141:
				if (num3 < key.Length)
				{
					if (num3 > 0 && !text.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920), StringComparison.Ordinal) && char.IsUpper(key[num3]))
					{
						break;
					}
					goto IL_010b;
				}
				goto IL_015d;
				IL_015d:
				return text;
			}
			num = 0;
		}
		while (TWC());
		goto IL_0005;
	}

	public static int GetIndentAmount(string text, int tabSize)
	{
		int num = 0;
		if (!string.IsNullOrEmpty(text))
		{
			int num4 = default(int);
			for (int i = 0; i < text.Length; i++)
			{
				switch (text[i])
				{
				case '\t':
				{
					int num2 = tabSize - num % tabSize;
					num += num2;
					int num3 = 1;
					if (RWw() != null)
					{
						num3 = num4;
					}
					switch (num3)
					{
					}
					break;
				}
				default:
					return num;
				case ' ':
					num++;
					break;
				}
			}
		}
		return num;
	}

	public static string GetIndentText(bool convertTabsToSpaces, int tabSize, int indentAmount)
	{
		if (indentAmount > 0)
		{
			if (convertTabsToSpaces)
			{
				return new string(' ', indentAmount);
			}
			tabSize = Math.Max(1, tabSize);
			int num = indentAmount / tabSize;
			int num2 = indentAmount % tabSize;
			return ((num > 0) ? new string('\t', num) : string.Empty) + ((num2 > 0) ? new string(' ', num2) : string.Empty);
		}
		return string.Empty;
	}

	public static string GetLineTerminatorText(LineTerminator lineTerminator)
	{
		return lineTerminator switch
		{
			LineTerminator.CarriageReturnNewline => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5358), 
			LineTerminator.CarriageReturn => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5352), 
			LineTerminator.Newline => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5366), 
			_ => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5358), 
		};
	}

	public static TextPosition GetTextPositionDelta(string text)
	{
		int? num = null;
		int num2 = 0;
		char[] anyOf = new char[2] { '\r', '\n' };
		int length = text.Length;
		for (int num3 = text.IndexOfAny(anyOf); num3 != -1; num3 = text.IndexOfAny(anyOf, num3 + 1))
		{
			num2++;
			num = num3 + 1;
			if (text[num3] == '\r' && num3 + 1 < length && text[num3 + 1] == '\n')
			{
				num++;
				num3++;
			}
		}
		int character = (num.HasValue ? (length - num.Value) : length);
		return new TextPosition(num2, character);
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "BiDi")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Rtl")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Di")]
	[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Bi")]
	[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "ch")]
	public static bool IsRtlCharacter(char ch)
	{
		if (ch >= '\u0590' && (ch <= 'ۿ' || (ch >= 'יִ' && ch <= 'ﭏ')))
		{
			return true;
		}
		return false;
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	[SuppressMessage("Microsoft.Design", "CA1045:DoNotPassTypesByReference", MessageId = "0#")]
	public static bool TrimTrailingWhitespace(ref string text)
	{
		char[] trimChars = new char[2] { ' ', '\t' };
		IList<string> list = ConvertTextToLines(text);
		bool flag = false;
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Length > 0 && char.IsWhiteSpace(list[i][list[i].Length - 1]))
			{
				flag = true;
				list[i] = list[i].TrimEnd(trimChars);
			}
		}
		if (flag)
		{
			text = oBq(list, LineTerminator.Newline);
		}
		return flag;
	}

	internal static bool TWC()
	{
		return KW3 == null;
	}

	internal static StringHelper RWw()
	{
		return KW3;
	}
}
