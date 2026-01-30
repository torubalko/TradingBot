using System;

namespace MimeKit.Cryptography;

[Flags]
public enum X509CrlRecordFields
{
	Id = 1,
	IsDelta = 2,
	IssuerName = 4,
	ThisUpdate = 8,
	NextUpdate = 0x10,
	Crl = 0x20
}
