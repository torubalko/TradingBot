using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public static class X509Certificate2Extensions
{
	public static Org.BouncyCastle.X509.X509Certificate AsBouncyCastleCertificate(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		byte[] rawCertData = certificate.GetRawCertData();
		X509CertificateParser x509CertificateParser = new X509CertificateParser();
		return x509CertificateParser.ReadCertificate(rawCertData);
	}

	public static PublicKeyAlgorithm GetPublicKeyAlgorithm(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		string keyAlgorithm = certificate.GetKeyAlgorithm();
		Oid oid = new Oid(keyAlgorithm);
		return oid.FriendlyName switch
		{
			"DSA" => PublicKeyAlgorithm.Dsa, 
			"RSA" => PublicKeyAlgorithm.RsaGeneral, 
			"ECC" => PublicKeyAlgorithm.EllipticCurve, 
			"DH" => PublicKeyAlgorithm.DiffieHellman, 
			_ => PublicKeyAlgorithm.None, 
		};
	}

	private static EncryptionAlgorithm[] DecodeEncryptionAlgorithms(byte[] rawData)
	{
		using MemoryStream input = new MemoryStream(rawData, writable: false);
		using Asn1InputStream asn1InputStream = new Asn1InputStream(input);
		List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
		if (!(asn1InputStream.ReadObject() is Asn1Sequence asn1Sequence))
		{
			return null;
		}
		for (int i = 0; i < asn1Sequence.Count; i++)
		{
			AlgorithmIdentifier instance = AlgorithmIdentifier.GetInstance(asn1Sequence[i]);
			if (BouncyCastleSecureMimeContext.TryGetEncryptionAlgorithm(instance, out var algorithm))
			{
				list.Add(algorithm);
			}
		}
		return list.ToArray();
	}

	public static EncryptionAlgorithm[] GetEncryptionAlgorithms(this X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		X509ExtensionEnumerator enumerator = certificate.Extensions.GetEnumerator();
		while (enumerator.MoveNext())
		{
			System.Security.Cryptography.X509Certificates.X509Extension current = enumerator.Current;
			if (current.Oid.Value == "1.2.840.113549.1.9.15")
			{
				EncryptionAlgorithm[] array = DecodeEncryptionAlgorithms(current.RawData);
				if (array == null)
				{
					break;
				}
				return array;
			}
		}
		return new EncryptionAlgorithm[1] { EncryptionAlgorithm.TripleDes };
	}
}
