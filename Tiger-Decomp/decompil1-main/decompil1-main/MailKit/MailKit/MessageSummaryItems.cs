using System;

namespace MailKit;

[Flags]
public enum MessageSummaryItems
{
	None = 0,
	Annotations = 1,
	Body = 2,
	BodyStructure = 4,
	Envelope = 8,
	Flags = 0x10,
	InternalDate = 0x20,
	Size = 0x40,
	ModSeq = 0x80,
	References = 0x100,
	UniqueId = 0x200,
	EmailId = 0x400,
	[Obsolete("Use EmailId instead.")]
	Id = 0x400,
	ThreadId = 0x800,
	GMailMessageId = 0x1000,
	GMailThreadId = 0x2000,
	GMailLabels = 0x4000,
	Headers = 0x8000,
	PreviewText = 0x10000,
	SaveDate = 0x20000,
	All = 0x78,
	Fast = 0x70,
	Full = 0x7A
}
