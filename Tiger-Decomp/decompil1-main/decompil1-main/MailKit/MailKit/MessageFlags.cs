using System;

namespace MailKit;

[Flags]
public enum MessageFlags
{
	None = 0,
	Seen = 1,
	Answered = 2,
	Flagged = 4,
	Deleted = 8,
	Draft = 0x10,
	Recent = 0x20,
	UserDefined = 0x40
}
