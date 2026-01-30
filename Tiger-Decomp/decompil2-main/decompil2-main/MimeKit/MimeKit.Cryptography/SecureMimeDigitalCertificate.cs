using System;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class SecureMimeDigitalCertificate : IDigitalCertificate
{
	public X509Certificate Certificate { get; private set; }

	public PublicKeyAlgorithm PublicKeyAlgorithm { get; private set; }

	public DateTime CreationDate => Certificate.NotBefore.ToUniversalTime();

	public DateTime ExpirationDate => Certificate.NotAfter.ToUniversalTime();

	public string Fingerprint { get; private set; }

	public string Email => Certificate.GetSubjectEmailAddress();

	public string Name => Certificate.GetCommonName();

	public SecureMimeDigitalCertificate(X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Certificate = certificate;
		Fingerprint = certificate.GetFingerprint();
		PublicKeyAlgorithm = certificate.GetPublicKeyAlgorithm();
	}
}
