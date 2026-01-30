namespace MimeKit.Utils;

internal static class ByteExtensions
{
	private const string AtomSafeCharacters = "!#$%&'*+-/=?^_`{|}~";

	private const string AttributeSpecials = "*'%";

	private const string CommentSpecials = "()\\\r";

	private const string DomainSpecials = "[]\\\r \t";

	private const string EncodedWordSpecials = "()<>@,;:\"/[]?.=_";

	private const string EncodedPhraseSpecials = "!*+-/=_";

	private const string Specials = "()<>[]:;@\\,.\"";

	internal const string TokenSpecials = "()<>@,;:\\\"/[]?=";

	private const string Whitespace = " \t\r\n";

	private static readonly CharType[] table;

	private static void RemoveFlags(string values, CharType bit)
	{
		for (int i = 0; i < values.Length; i++)
		{
			table[(byte)values[i]] &= (CharType)(ushort)(~(int)bit);
		}
	}

	private static void SetFlags(string values, CharType bit, CharType bitcopy, bool remove)
	{
		if (remove)
		{
			for (int i = 0; i < 128; i++)
			{
				table[i] |= bit;
			}
			for (int i = 0; i < values.Length; i++)
			{
				table[(uint)values[i]] &= (CharType)(ushort)(~(int)bit);
			}
			return;
		}
		for (int i = 0; i < values.Length; i++)
		{
			table[(uint)values[i]] |= bit;
		}
		if (bitcopy == CharType.None)
		{
			return;
		}
		for (int i = 0; i < 256; i++)
		{
			if ((table[i] & bitcopy) != CharType.None)
			{
				table[i] |= bit;
			}
		}
	}

	static ByteExtensions()
	{
		table = new CharType[256];
		for (int i = 0; i < 256; i++)
		{
			if (i < 127)
			{
				if (i < 32)
				{
					table[i] |= CharType.IsControl;
				}
				if (i > 32)
				{
					table[i] |= CharType.IsAttrChar;
				}
				if ((i >= 33 && i <= 60) || (i >= 62 && i <= 126) || i == 32)
				{
					table[i] |= CharType.IsEncodedWordSafe | CharType.IsQuotedPrintableSafe;
				}
				if ((i >= 48 && i <= 57) || (i >= 97 && i <= 122) || (i >= 65 && i <= 90))
				{
					table[i] |= CharType.IsAtom | CharType.IsEncodedPhraseSafe | CharType.IsPhraseAtom;
				}
				if ((i >= 48 && i <= 57) || (i >= 97 && i <= 102) || (i >= 65 && i <= 70))
				{
					table[i] |= CharType.IsXDigit;
				}
				table[i] |= CharType.IsAscii;
			}
			else
			{
				if (i == 127)
				{
					table[i] |= CharType.IsAscii;
				}
				else
				{
					table[i] |= CharType.IsAtom | CharType.IsPhraseAtom;
				}
				table[i] |= CharType.IsControl;
			}
		}
		table[9] |= CharType.IsBlank | CharType.IsQuotedPrintableSafe;
		table[32] |= CharType.IsBlank | CharType.IsSpace;
		SetFlags(" \t\r\n", CharType.IsWhitespace, CharType.None, remove: false);
		SetFlags("!#$%&'*+-/=?^_`{|}~", CharType.IsAtom | CharType.IsPhraseAtom, CharType.None, remove: false);
		SetFlags("()<>@,;:\\\"/[]?=", CharType.IsTokenSpecial, CharType.IsControl, remove: false);
		SetFlags("()<>[]:;@\\,.\"", CharType.IsSpecial, CharType.None, remove: false);
		SetFlags("[]\\\r \t", CharType.IsDomainSafe, CharType.None, remove: true);
		RemoveFlags("()<>[]:;@\\,.\"", CharType.IsAtom | CharType.IsPhraseAtom);
		RemoveFlags("()<>@,;:\"/[]?.=_", CharType.IsEncodedWordSafe);
		RemoveFlags("*'%()<>@,;:\\\"/[]?=", CharType.IsAttrChar);
		SetFlags("!*+-/=_", CharType.IsEncodedPhraseSafe, CharType.None, remove: false);
		table[91] |= CharType.IsPhraseAtom;
		table[93] |= CharType.IsPhraseAtom;
	}

	public static bool IsAsciiAtom(this byte c)
	{
		return (table[c] & CharType.IsAsciiAtom) == CharType.IsAsciiAtom;
	}

	public static bool IsPhraseAtom(this byte c)
	{
		return (table[c] & CharType.IsPhraseAtom) != 0;
	}

	public static bool IsAtom(this byte c)
	{
		return (table[c] & CharType.IsAtom) != 0;
	}

	public static bool IsAttr(this byte c)
	{
		return (table[c] & CharType.IsAttrChar) != 0;
	}

	public static bool IsBlank(this byte c)
	{
		return (table[c] & CharType.IsBlank) != 0;
	}

	public static bool IsCtrl(this byte c)
	{
		return (table[c] & CharType.IsControl) != 0;
	}

	public static bool IsDomain(this byte c)
	{
		return (table[c] & CharType.IsDomainSafe) != 0;
	}

	public static bool IsQpSafe(this byte c)
	{
		return (table[c] & CharType.IsQuotedPrintableSafe) != 0;
	}

	public static bool IsToken(this byte c)
	{
		return (table[c] & (CharType.IsControl | CharType.IsTokenSpecial | CharType.IsWhitespace)) == 0;
	}

	public static bool IsType(this byte c, CharType type)
	{
		return (table[c] & type) != 0;
	}

	public static bool IsWhitespace(this byte c)
	{
		return (table[c] & CharType.IsWhitespace) != 0;
	}

	public static bool IsXDigit(this byte c)
	{
		return (table[c] & CharType.IsXDigit) != 0;
	}

	public static byte ToXDigit(this byte c)
	{
		if (c >= 65)
		{
			if (c >= 97)
			{
				return (byte)(c - 87);
			}
			return (byte)(c - 55);
		}
		return (byte)(c - 48);
	}
}
