using System;

namespace MailKit.Net.Pop3;

[Flags]
public enum Pop3Capabilities : uint
{
	None = 0u,
	Apop = 1u,
	Expire = 2u,
	LoginDelay = 4u,
	Pipelining = 8u,
	ResponseCodes = 0x10u,
	Sasl = 0x20u,
	StartTLS = 0x40u,
	Top = 0x80u,
	UIDL = 0x100u,
	User = 0x200u,
	UTF8 = 0x400u,
	UTF8User = 0x800u,
	Lang = 0x1000u
}
