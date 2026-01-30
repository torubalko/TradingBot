using System;

namespace MimeKit.Cryptography;

[Flags]
public enum X509CertificateRecordFields
{
	Id = 1,
	Trusted = 2,
	Algorithms = 8,
	AlgorithmsUpdated = 0x10,
	Certificate = 0x20,
	PrivateKey = 0x40
}
