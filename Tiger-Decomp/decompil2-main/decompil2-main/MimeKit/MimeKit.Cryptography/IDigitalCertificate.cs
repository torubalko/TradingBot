using System;

namespace MimeKit.Cryptography;

public interface IDigitalCertificate
{
	PublicKeyAlgorithm PublicKeyAlgorithm { get; }

	DateTime CreationDate { get; }

	DateTime ExpirationDate { get; }

	string Fingerprint { get; }

	string Email { get; }

	string Name { get; }
}
