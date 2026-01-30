using System;

namespace MailKit.Security.Ntlm;

[Flags]
internal enum NtlmFlags
{
	NegotiateUnicode = 1,
	NegotiateOem = 2,
	RequestTarget = 4,
	R10 = 8,
	NegotiateSign = 0x10,
	NegotiateSeal = 0x20,
	NegotiateDatagramStyle = 0x40,
	NegotiateLanManagerKey = 0x80,
	R9 = 0x100,
	NegotiateNtlm = 0x200,
	R8 = 0x400,
	NegotiateAnonymous = 0x800,
	NegotiateDomainSupplied = 0x1000,
	NegotiateWorkstationSupplied = 0x2000,
	NegotiateLocalCall = 0x4000,
	R7 = 0x4000,
	NegotiateAlwaysSign = 0x8000,
	TargetTypeDomain = 0x10000,
	TargetTypeServer = 0x20000,
	TargetTypeShare = 0x40000,
	R6 = 0x40000,
	NegotiateNtlm2Key = 0x80000,
	NegotiateIdentify = 0x100000,
	R5 = 0x200000,
	RequestNonNTSessionKey = 0x400000,
	NegotiateTargetInfo = 0x800000,
	R4 = 0x1000000,
	NegotiateVersion = 0x2000000,
	R3 = 0x4000000,
	R2 = 0x8000000,
	R1 = 0x10000000,
	Negotiate128 = 0x20000000,
	NegotiateKeyExchange = 0x40000000,
	Negotiate56 = int.MinValue
}
