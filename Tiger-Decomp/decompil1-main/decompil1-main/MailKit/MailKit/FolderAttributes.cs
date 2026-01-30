using System;

namespace MailKit;

[Flags]
public enum FolderAttributes
{
	None = 0,
	NoInferiors = 1,
	NoSelect = 2,
	Marked = 4,
	Unmarked = 8,
	NonExistent = 0x10,
	Subscribed = 0x20,
	Remote = 0x40,
	HasChildren = 0x80,
	HasNoChildren = 0x100,
	All = 0x200,
	Archive = 0x400,
	Drafts = 0x800,
	Flagged = 0x1000,
	Important = 0x2000,
	Inbox = 0x4000,
	Junk = 0x8000,
	Sent = 0x10000,
	Trash = 0x20000
}
