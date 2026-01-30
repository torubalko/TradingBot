using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.Sec;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.EC;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.OpenSsl;

public class PemReader : Org.BouncyCastle.Utilities.IO.Pem.PemReader
{
	private readonly IPasswordFinder pFinder;

	static PemReader()
	{
	}

	public PemReader(TextReader reader)
		: this(reader, null)
	{
	}

	public PemReader(TextReader reader, IPasswordFinder pFinder)
		: base(reader)
	{
		this.pFinder = pFinder;
	}

	public object ReadObject()
	{
		PemObject obj = ReadPemObject();
		if (obj == null)
		{
			return null;
		}
		if (Platform.EndsWith(obj.Type, "PRIVATE KEY"))
		{
			return ReadPrivateKey(obj);
		}
		switch (obj.Type)
		{
		case "PUBLIC KEY":
			return ReadPublicKey(obj);
		case "RSA PUBLIC KEY":
			return ReadRsaPublicKey(obj);
		case "CERTIFICATE REQUEST":
		case "NEW CERTIFICATE REQUEST":
			return ReadCertificateRequest(obj);
		case "CERTIFICATE":
		case "X509 CERTIFICATE":
			return ReadCertificate(obj);
		case "PKCS7":
		case "CMS":
			return ReadPkcs7(obj);
		case "X509 CRL":
			return ReadCrl(obj);
		case "ATTRIBUTE CERTIFICATE":
			return ReadAttributeCertificate(obj);
		default:
			throw new IOException("unrecognised object: " + obj.Type);
		}
	}

	private AsymmetricKeyParameter ReadRsaPublicKey(PemObject pemObject)
	{
		RsaPublicKeyStructure rsaPubStructure = RsaPublicKeyStructure.GetInstance(Asn1Object.FromByteArray(pemObject.Content));
		return new RsaKeyParameters(isPrivate: false, rsaPubStructure.Modulus, rsaPubStructure.PublicExponent);
	}

	private AsymmetricKeyParameter ReadPublicKey(PemObject pemObject)
	{
		return PublicKeyFactory.CreateKey(pemObject.Content);
	}

	private X509Certificate ReadCertificate(PemObject pemObject)
	{
		try
		{
			return new X509CertificateParser().ReadCertificate(pemObject.Content);
		}
		catch (Exception ex)
		{
			throw new PemException("problem parsing cert: " + ex.ToString());
		}
	}

	private X509Crl ReadCrl(PemObject pemObject)
	{
		try
		{
			return new X509CrlParser().ReadCrl(pemObject.Content);
		}
		catch (Exception ex)
		{
			throw new PemException("problem parsing cert: " + ex.ToString());
		}
	}

	private Pkcs10CertificationRequest ReadCertificateRequest(PemObject pemObject)
	{
		try
		{
			return new Pkcs10CertificationRequest(pemObject.Content);
		}
		catch (Exception ex)
		{
			throw new PemException("problem parsing cert: " + ex.ToString());
		}
	}

	private IX509AttributeCertificate ReadAttributeCertificate(PemObject pemObject)
	{
		return new X509V2AttributeCertificate(pemObject.Content);
	}

	private Org.BouncyCastle.Asn1.Cms.ContentInfo ReadPkcs7(PemObject pemObject)
	{
		try
		{
			return Org.BouncyCastle.Asn1.Cms.ContentInfo.GetInstance(Asn1Object.FromByteArray(pemObject.Content));
		}
		catch (Exception ex)
		{
			throw new PemException("problem parsing PKCS7 object: " + ex.ToString());
		}
	}

	private object ReadPrivateKey(PemObject pemObject)
	{
		string type = pemObject.Type.Substring(0, pemObject.Type.Length - "PRIVATE KEY".Length).Trim();
		byte[] keyBytes = pemObject.Content;
		IDictionary fields = Platform.CreateHashtable();
		foreach (PemHeader header in pemObject.Headers)
		{
			fields[header.Name] = header.Value;
		}
		if ((string)fields["Proc-Type"] == "4,ENCRYPTED")
		{
			if (pFinder == null)
			{
				throw new PasswordException("No password finder specified, but a password is required");
			}
			char[] password = pFinder.GetPassword();
			if (password == null)
			{
				throw new PasswordException("Password is null, but a password is required");
			}
			string[] array = ((string)fields["DEK-Info"]).Split(',');
			string dekAlgName = array[0].Trim();
			byte[] iv = Hex.Decode(array[1].Trim());
			keyBytes = PemUtilities.Crypt(encrypt: false, keyBytes, password, dekAlgName, iv);
		}
		try
		{
			Asn1Sequence seq = Asn1Sequence.GetInstance(keyBytes);
			AsymmetricKeyParameter pubSpec;
			AsymmetricKeyParameter privSpec;
			switch (type)
			{
			default:
				if (type.Length != 0)
				{
					goto case null;
				}
				return PrivateKeyFactory.CreateKey(PrivateKeyInfo.GetInstance(seq));
			case "RSA":
			{
				if (seq.Count != 9)
				{
					throw new PemException("malformed sequence in RSA private key");
				}
				RsaPrivateKeyStructure rsa = RsaPrivateKeyStructure.GetInstance(seq);
				pubSpec = new RsaKeyParameters(isPrivate: false, rsa.Modulus, rsa.PublicExponent);
				privSpec = new RsaPrivateCrtKeyParameters(rsa.Modulus, rsa.PublicExponent, rsa.PrivateExponent, rsa.Prime1, rsa.Prime2, rsa.Exponent1, rsa.Exponent2, rsa.Coefficient);
				break;
			}
			case "DSA":
			{
				if (seq.Count != 6)
				{
					throw new PemException("malformed sequence in DSA private key");
				}
				DerInteger p = (DerInteger)seq[1];
				DerInteger q = (DerInteger)seq[2];
				DerInteger g = (DerInteger)seq[3];
				DerInteger obj = (DerInteger)seq[4];
				DerInteger obj2 = (DerInteger)seq[5];
				DsaParameters parameters = new DsaParameters(p.Value, q.Value, g.Value);
				privSpec = new DsaPrivateKeyParameters(obj2.Value, parameters);
				pubSpec = new DsaPublicKeyParameters(obj.Value, parameters);
				break;
			}
			case "EC":
			{
				ECPrivateKeyStructure pKey = ECPrivateKeyStructure.GetInstance(seq);
				AlgorithmIdentifier algId = new AlgorithmIdentifier(X9ObjectIdentifiers.IdECPublicKey, pKey.GetParameters());
				privSpec = PrivateKeyFactory.CreateKey(new PrivateKeyInfo(algId, pKey.ToAsn1Object()));
				DerBitString pubKey = pKey.GetPublicKey();
				pubSpec = ((pubKey == null) ? ECKeyPairGenerator.GetCorrespondingPublicKey((ECPrivateKeyParameters)privSpec) : PublicKeyFactory.CreateKey(new SubjectPublicKeyInfo(algId, pubKey.GetBytes())));
				break;
			}
			case "ENCRYPTED":
				return PrivateKeyFactory.DecryptKey(pFinder.GetPassword() ?? throw new PasswordException("Password is null, but a password is required"), EncryptedPrivateKeyInfo.GetInstance(seq));
			case null:
				throw new ArgumentException("Unknown key type: " + type, "type");
			}
			return new AsymmetricCipherKeyPair(pubSpec, privSpec);
		}
		catch (IOException ex)
		{
			throw ex;
		}
		catch (Exception ex2)
		{
			throw new PemException("problem creating " + type + " private key: " + ex2.ToString());
		}
	}

	private static X9ECParameters GetCurveParameters(string name)
	{
		X9ECParameters ecP = CustomNamedCurves.GetByName(name);
		if (ecP == null)
		{
			ecP = ECNamedCurveTable.GetByName(name);
		}
		if (ecP == null)
		{
			throw new Exception("unknown curve name: " + name);
		}
		return ecP;
	}
}
