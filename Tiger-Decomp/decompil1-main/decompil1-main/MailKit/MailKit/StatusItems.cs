using System;

namespace MailKit;

[Flags]
public enum StatusItems
{
	None = 0,
	Count = 1,
	Recent = 2,
	UidNext = 4,
	UidValidity = 8,
	Unread = 0x10,
	HighestModSeq = 0x20,
	AppendLimit = 0x40,
	Size = 0x80,
	MailboxId = 0x100
}
