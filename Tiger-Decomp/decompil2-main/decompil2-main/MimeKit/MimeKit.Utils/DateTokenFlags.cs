using System;

namespace MimeKit.Utils;

[Flags]
internal enum DateTokenFlags : byte
{
	None = 0,
	NonNumeric = 1,
	NonWeekday = 2,
	NonMonth = 4,
	NonTime = 8,
	NonAlphaZone = 0x10,
	NonNumericZone = 0x20,
	HasColon = 0x40,
	HasSign = 0x80
}
