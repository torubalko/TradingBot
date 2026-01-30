using System;

namespace MimeKit.Cryptography;

public interface IDigitalSignature
{
	IDigitalCertificate SignerCertificate { get; }

	PublicKeyAlgorithm PublicKeyAlgorithm { get; }

	DigestAlgorithm DigestAlgorithm { get; }

	DateTime CreationDate { get; }

	bool Verify();

	bool Verify(bool verifySignatureOnly);
}
