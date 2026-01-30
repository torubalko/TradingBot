using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class X509CertificateRecord
{
	public int Id { get; internal set; }

	public int BasicConstraints => Certificate.GetBasicConstraints();

	public bool IsTrusted { get; set; }

	public bool IsAnchor => Certificate.IsSelfSigned();

	public X509KeyUsageFlags KeyUsage => Certificate.GetKeyUsageFlags();

	public DateTime NotBefore => Certificate.NotBefore.ToUniversalTime();

	public DateTime NotAfter => Certificate.NotAfter.ToUniversalTime();

	public string IssuerName => Certificate.IssuerDN.ToString();

	public string SerialNumber => Certificate.SerialNumber.ToString();

	public string SubjectName => Certificate.SubjectDN.ToString();

	public byte[] SubjectKeyIdentifier
	{
		get
		{
			Asn1OctetString asn1OctetString = Certificate.GetExtensionValue(X509Extensions.SubjectKeyIdentifier);
			if (asn1OctetString != null)
			{
				asn1OctetString = (Asn1OctetString)Asn1Object.FromByteArray(asn1OctetString.GetOctets());
			}
			return asn1OctetString?.GetOctets();
		}
	}

	public string SubjectEmail => Certificate.GetSubjectEmailAddress();

	public string Fingerprint => Certificate.GetFingerprint();

	public EncryptionAlgorithm[] Algorithms { get; set; }

	public DateTime AlgorithmsUpdated { get; set; }

	public X509Certificate Certificate { get; internal set; }

	public AsymmetricKeyParameter PrivateKey { get; set; }

	public X509CertificateRecord(X509Certificate certificate, AsymmetricKeyParameter key)
		: this(certificate)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!key.IsPrivate)
		{
			throw new ArgumentException("The key must be private.", "key");
		}
		PrivateKey = key;
	}

	public X509CertificateRecord(X509Certificate certificate)
		: this()
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Certificate = certificate;
	}

	public X509CertificateRecord()
	{
		AlgorithmsUpdated = DateTime.MinValue;
	}
}
