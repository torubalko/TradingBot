using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public static class BouncyCastleCertificateExtensions
{
	public static X509Certificate2 AsX509Certificate2(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return new X509Certificate2(certificate.GetEncoded());
	}

	internal static bool IsSelfSigned(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		return certificate.SubjectDN.Equivalent(certificate.IssuerDN);
	}

	public static string GetIssuerNameInfo(this Org.BouncyCastle.X509.X509Certificate certificate, DerObjectIdentifier identifier)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		IList valueList = certificate.IssuerDN.GetValueList(identifier);
		if (valueList.Count == 0)
		{
			return string.Empty;
		}
		return (string)valueList[0];
	}

	public static string GetSubjectNameInfo(this Org.BouncyCastle.X509.X509Certificate certificate, DerObjectIdentifier identifier)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		IList valueList = certificate.SubjectDN.GetValueList(identifier);
		if (valueList.Count == 0)
		{
			return string.Empty;
		}
		return (string)valueList[0];
	}

	public static string GetCommonName(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		return certificate.GetSubjectNameInfo(X509Name.CN);
	}

	public static string GetSubjectName(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		return certificate.GetSubjectNameInfo(X509Name.Name);
	}

	public static string GetSubjectEmailAddress(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		string subjectNameInfo = certificate.GetSubjectNameInfo(X509Name.EmailAddress);
		if (!string.IsNullOrEmpty(subjectNameInfo))
		{
			return subjectNameInfo;
		}
		Asn1OctetString extensionValue = certificate.GetExtensionValue(X509Extensions.SubjectAlternativeName);
		if (extensionValue == null)
		{
			return string.Empty;
		}
		Asn1Sequence instance = Asn1Sequence.GetInstance(Asn1Object.FromByteArray(extensionValue.GetOctets()));
		foreach (Asn1Encodable item in instance)
		{
			GeneralName instance2 = GeneralName.GetInstance(item);
			if (instance2.TagNo == 1)
			{
				return ((IAsn1String)instance2.Name).GetString();
			}
		}
		return null;
	}

	internal static string AsHex(this byte[] blob)
	{
		StringBuilder stringBuilder = new StringBuilder(blob.Length * 2);
		for (int i = 0; i < blob.Length; i++)
		{
			stringBuilder.Append(blob[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public static string GetFingerprint(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		byte[] encoded = certificate.GetEncoded();
		Sha1Digest sha1Digest = new Sha1Digest();
		sha1Digest.BlockUpdate(encoded, 0, encoded.Length);
		byte[] array = new byte[20];
		sha1Digest.DoFinal(array, 0);
		return array.AsHex();
	}

	public static PublicKeyAlgorithm GetPublicKeyAlgorithm(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		AsymmetricKeyParameter publicKey = certificate.GetPublicKey();
		if (publicKey is DsaKeyParameters)
		{
			return PublicKeyAlgorithm.Dsa;
		}
		if (publicKey is RsaKeyParameters)
		{
			return PublicKeyAlgorithm.RsaGeneral;
		}
		if (publicKey is ElGamalKeyParameters)
		{
			return PublicKeyAlgorithm.ElGamalGeneral;
		}
		if (publicKey is ECKeyParameters)
		{
			return PublicKeyAlgorithm.EllipticCurve;
		}
		if (publicKey is DHKeyParameters)
		{
			return PublicKeyAlgorithm.DiffieHellman;
		}
		return PublicKeyAlgorithm.None;
	}

	internal static X509KeyUsageFlags GetKeyUsageFlags(bool[] usage)
	{
		X509KeyUsageFlags x509KeyUsageFlags = X509KeyUsageFlags.None;
		if (usage == null || usage[0])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.DigitalSignature;
		}
		if (usage == null || usage[1])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.NonRepudiation;
		}
		if (usage == null || usage[2])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.KeyEncipherment;
		}
		if (usage == null || usage[3])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.DataEncipherment;
		}
		if (usage == null || usage[4])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.KeyAgreement;
		}
		if (usage == null || usage[5])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.KeyCertSign;
		}
		if (usage == null || usage[6])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.CrlSign;
		}
		if (usage == null || usage[7])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.EncipherOnly;
		}
		if (usage == null || usage[8])
		{
			x509KeyUsageFlags |= X509KeyUsageFlags.DecipherOnly;
		}
		return x509KeyUsageFlags;
	}

	public static X509KeyUsageFlags GetKeyUsageFlags(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		return GetKeyUsageFlags(certificate.GetKeyUsage());
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

	public static EncryptionAlgorithm[] GetEncryptionAlgorithms(this Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Asn1OctetString extensionValue = certificate.GetExtensionValue(SmimeAttributes.SmimeCapabilities);
		if (extensionValue != null)
		{
			return DecodeEncryptionAlgorithms(extensionValue.GetOctets());
		}
		return new EncryptionAlgorithm[1] { EncryptionAlgorithm.TripleDes };
	}

	internal static bool IsDelta(this X509Crl crl)
	{
		return crl.GetCriticalExtensionOids()?.Contains(X509Extensions.DeltaCrlIndicator.Id) ?? false;
	}
}
