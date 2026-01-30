using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class CmsSigner
{
	internal X509Certificate2 WindowsCertificate { get; set; }

	public Org.BouncyCastle.X509.X509Certificate Certificate { get; private set; }

	public X509CertificateChain CertificateChain { get; private set; }

	public DigestAlgorithm DigestAlgorithm { get; set; }

	public AsymmetricKeyParameter PrivateKey { get; private set; }

	[Obsolete("Use RsaSignaturePadding instead.")]
	public RsaSignaturePaddingScheme RsaSignaturePaddingScheme
	{
		get
		{
			return RsaSignaturePadding?.Scheme ?? RsaSignaturePaddingScheme.Pkcs1;
		}
		set
		{
			switch (value)
			{
			case RsaSignaturePaddingScheme.Pkcs1:
				RsaSignaturePadding = RsaSignaturePadding.Pkcs1;
				break;
			case RsaSignaturePaddingScheme.Pss:
				RsaSignaturePadding = RsaSignaturePadding.Pss;
				break;
			default:
				throw new ArgumentOutOfRangeException("value");
			}
		}
	}

	public RsaSignaturePadding RsaSignaturePadding { get; set; }

	public SubjectIdentifierType SignerIdentifierType { get; private set; }

	public AttributeTable SignedAttributes { get; set; }

	public AttributeTable UnsignedAttributes { get; set; }

	private CmsSigner()
	{
		UnsignedAttributes = new AttributeTable(new Dictionary<DerObjectIdentifier, Asn1Encodable>());
		SignedAttributes = new AttributeTable(new Dictionary<DerObjectIdentifier, Asn1Encodable>());
		DigestAlgorithm = DigestAlgorithm.Sha256;
	}

	private static bool CanSign(Org.BouncyCastle.X509.X509Certificate certificate)
	{
		X509KeyUsageFlags keyUsageFlags = certificate.GetKeyUsageFlags();
		if (keyUsageFlags != X509KeyUsageFlags.None && (keyUsageFlags & (X509KeyUsageFlags.NonRepudiation | X509KeyUsageFlags.DigitalSignature)) == 0)
		{
			return false;
		}
		return true;
	}

	private static void CheckCertificateCanBeUsedForSigning(Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (!CanSign(certificate))
		{
			throw new ArgumentException("The certificate cannot be used for signing.", "certificate");
		}
	}

	public CmsSigner(IEnumerable<Org.BouncyCastle.X509.X509Certificate> chain, AsymmetricKeyParameter key, SubjectIdentifierType signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
		: this()
	{
		if (chain == null)
		{
			throw new ArgumentNullException("chain");
		}
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		CertificateChain = new X509CertificateChain(chain);
		if (CertificateChain.Count == 0)
		{
			throw new ArgumentException("The certificate chain was empty.", "chain");
		}
		CheckCertificateCanBeUsedForSigning(CertificateChain[0]);
		if (!key.IsPrivate)
		{
			throw new ArgumentException("The key must be a private key.", "key");
		}
		if (signerIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			SignerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			SignerIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		Certificate = CertificateChain[0];
		PrivateKey = key;
	}

	public CmsSigner(Org.BouncyCastle.X509.X509Certificate certificate, AsymmetricKeyParameter key, SubjectIdentifierType signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
		: this()
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		CheckCertificateCanBeUsedForSigning(certificate);
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (!key.IsPrivate)
		{
			throw new ArgumentException("The key must be a private key.", "key");
		}
		if (signerIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			SignerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			SignerIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		CertificateChain = new X509CertificateChain();
		CertificateChain.Add(certificate);
		Certificate = certificate;
		PrivateKey = key;
	}

	private void LoadPkcs12(Stream stream, string password, SubjectIdentifierType signerIdentifierType)
	{
		Pkcs12Store pkcs12Store = new Pkcs12Store(stream, password.ToCharArray());
		bool flag = false;
		foreach (string alias in pkcs12Store.Aliases)
		{
			if (!pkcs12Store.IsKeyEntry(alias))
			{
				continue;
			}
			X509CertificateEntry[] certificateChain = pkcs12Store.GetCertificateChain(alias);
			AsymmetricKeyEntry key = pkcs12Store.GetKey(alias);
			if (!key.Key.IsPrivate)
			{
				continue;
			}
			flag = true;
			if (certificateChain.Length != 0 && CanSign(certificateChain[0].Certificate))
			{
				if (signerIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
				{
					SignerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
				}
				else
				{
					SignerIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
				}
				CertificateChain = new X509CertificateChain();
				Certificate = certificateChain[0].Certificate;
				PrivateKey = key.Key;
				X509CertificateEntry[] array = certificateChain;
				foreach (X509CertificateEntry x509CertificateEntry in array)
				{
					CertificateChain.Add(x509CertificateEntry.Certificate);
				}
				return;
			}
		}
		if (!flag)
		{
			throw new ArgumentException("The stream did not contain a private key.", "stream");
		}
		throw new ArgumentException("The stream did not contain a certificate that could be used to create digital signatures.", "stream");
	}

	public CmsSigner(Stream stream, string password, SubjectIdentifierType signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
		: this()
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		LoadPkcs12(stream, password, signerIdentifierType);
	}

	public CmsSigner(string fileName, string password, SubjectIdentifierType signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
		: this()
	{
		if (fileName == null)
		{
			throw new ArgumentNullException("fileName");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		using FileStream stream = File.OpenRead(fileName);
		LoadPkcs12(stream, password, signerIdentifierType);
	}

	public CmsSigner(X509Certificate2 certificate, SubjectIdentifierType signerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber)
		: this()
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (!certificate.HasPrivateKey)
		{
			throw new ArgumentException("The certificate does not contain a private key.", "certificate");
		}
		Org.BouncyCastle.X509.X509Certificate certificate2 = certificate.AsBouncyCastleCertificate();
		AsymmetricKeyParameter privateKey = certificate.PrivateKey.AsAsymmetricKeyParameter();
		CheckCertificateCanBeUsedForSigning(certificate2);
		if (signerIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier)
		{
			SignerIdentifierType = SubjectIdentifierType.IssuerAndSerialNumber;
		}
		else
		{
			SignerIdentifierType = SubjectIdentifierType.SubjectKeyIdentifier;
		}
		CertificateChain = new X509CertificateChain();
		WindowsCertificate = certificate;
		CertificateChain.Add(certificate2);
		Certificate = certificate2;
		PrivateKey = privateKey;
	}
}
