using System;

namespace MimeKit.Utils;

[Flags]
internal enum CharType : ushort
{
	None = 0,
	IsAscii = 1,
	IsAtom = 2,
	IsAttrChar = 4,
	IsBlank = 8,
	IsControl = 0x10,
	IsDomainSafe = 0x20,
	IsEncodedPhraseSafe = 0x40,
	IsEncodedWordSafe = 0x80,
	IsQuotedPrintableSafe = 0x100,
	IsSpace = 0x200,
	IsSpecial = 0x400,
	IsTokenSpecial = 0x800,
	IsWhitespace = 0x1000,
	IsXDigit = 0x2000,
	IsPhraseAtom = 0x4000,
	IsAsciiAtom = 3
}
