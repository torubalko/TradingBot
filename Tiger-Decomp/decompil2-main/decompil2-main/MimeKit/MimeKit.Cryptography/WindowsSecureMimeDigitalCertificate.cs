using System;
using System.Security.Cryptography.X509Certificates;

namespace MimeKit.Cryptography;

public class WindowsSecureMimeDigitalCertificate : IDigitalCertificate
{
	public X509Certificate2 Certificate { get; private set; }

	public PublicKeyAlgorithm PublicKeyAlgorithm { get; private set; }

	public DateTime CreationDate => Certificate.NotBefore.ToUniversalTime();

	public DateTime ExpirationDate => Certificate.NotAfter.ToUniversalTime();

	public string Fingerprint => Certificate.Thumbprint;

	public string Email => Certificate.GetNameInfo(X509NameType.EmailName, forIssuer: false);

	public string Name => Certificate.GetNameInfo(X509NameType.SimpleName, forIssuer: false);

	public WindowsSecureMimeDigitalCertificate(X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Certificate = certificate;
		PublicKeyAlgorithm = certificate.GetPublicKeyAlgorithm();
	}
}
