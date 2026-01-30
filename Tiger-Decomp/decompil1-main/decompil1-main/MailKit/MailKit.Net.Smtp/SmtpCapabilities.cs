using System;

namespace MailKit.Net.Smtp;

[Flags]
public enum SmtpCapabilities : uint
{
	None = 0u,
	Size = 1u,
	Dsn = 2u,
	EnhancedStatusCodes = 4u,
	Authentication = 8u,
	EightBitMime = 0x10u,
	Pipelining = 0x20u,
	BinaryMime = 0x40u,
	Chunking = 0x80u,
	StartTLS = 0x100u,
	UTF8 = 0x200u,
	RequireTLS = 0x400u
}
