using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Security;

public sealed class DotNetUtilities
{
	private DotNetUtilities()
	{
	}

	public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(X509CertificateStructure x509Struct)
	{
		return new System.Security.Cryptography.X509Certificates.X509Certificate(x509Struct.GetDerEncoded());
	}

	public static System.Security.Cryptography.X509Certificates.X509Certificate ToX509Certificate(Org.BouncyCastle.X509.X509Certificate x509Cert)
	{
		return new System.Security.Cryptography.X509Certificates.X509Certificate(x509Cert.GetEncoded());
	}

	public static Org.BouncyCastle.X509.X509Certificate FromX509Certificate(System.Security.Cryptography.X509Certificates.X509Certificate x509Cert)
	{
		return new X509CertificateParser().ReadCertificate(x509Cert.GetRawCertData());
	}

	public static AsymmetricCipherKeyPair GetDsaKeyPair(DSA dsa)
	{
		return GetDsaKeyPair(dsa.ExportParameters(includePrivateParameters: true));
	}

	public static AsymmetricCipherKeyPair GetDsaKeyPair(DSAParameters dp)
	{
		DsaValidationParameters validationParameters = ((dp.Seed != null) ? new DsaValidationParameters(dp.Seed, dp.Counter) : null);
		DsaParameters parameters = new DsaParameters(new BigInteger(1, dp.P), new BigInteger(1, dp.Q), new BigInteger(1, dp.G), validationParameters);
		DsaPublicKeyParameters publicParameter = new DsaPublicKeyParameters(new BigInteger(1, dp.Y), parameters);
		DsaPrivateKeyParameters privKey = new DsaPrivateKeyParameters(new BigInteger(1, dp.X), parameters);
		return new AsymmetricCipherKeyPair(publicParameter, privKey);
	}

	public static DsaPublicKeyParameters GetDsaPublicKey(DSA dsa)
	{
		return GetDsaPublicKey(dsa.ExportParameters(includePrivateParameters: false));
	}

	public static DsaPublicKeyParameters GetDsaPublicKey(DSAParameters dp)
	{
		DsaValidationParameters validationParameters = ((dp.Seed != null) ? new DsaValidationParameters(dp.Seed, dp.Counter) : null);
		DsaParameters parameters = new DsaParameters(new BigInteger(1, dp.P), new BigInteger(1, dp.Q), new BigInteger(1, dp.G), validationParameters);
		return new DsaPublicKeyParameters(new BigInteger(1, dp.Y), parameters);
	}

	public static AsymmetricCipherKeyPair GetRsaKeyPair(RSA rsa)
	{
		return GetRsaKeyPair(rsa.ExportParameters(includePrivateParameters: true));
	}

	public static AsymmetricCipherKeyPair GetRsaKeyPair(RSAParameters rp)
	{
		BigInteger modulus = new BigInteger(1, rp.Modulus);
		BigInteger pubExp = new BigInteger(1, rp.Exponent);
		RsaKeyParameters publicParameter = new RsaKeyParameters(isPrivate: false, modulus, pubExp);
		RsaPrivateCrtKeyParameters privKey = new RsaPrivateCrtKeyParameters(modulus, pubExp, new BigInteger(1, rp.D), new BigInteger(1, rp.P), new BigInteger(1, rp.Q), new BigInteger(1, rp.DP), new BigInteger(1, rp.DQ), new BigInteger(1, rp.InverseQ));
		return new AsymmetricCipherKeyPair(publicParameter, privKey);
	}

	public static RsaKeyParameters GetRsaPublicKey(RSA rsa)
	{
		return GetRsaPublicKey(rsa.ExportParameters(includePrivateParameters: false));
	}

	public static RsaKeyParameters GetRsaPublicKey(RSAParameters rp)
	{
		return new RsaKeyParameters(isPrivate: false, new BigInteger(1, rp.Modulus), new BigInteger(1, rp.Exponent));
	}

	public static AsymmetricCipherKeyPair GetKeyPair(AsymmetricAlgorithm privateKey)
	{
		if (privateKey is DSA)
		{
			return GetDsaKeyPair((DSA)privateKey);
		}
		if (privateKey is RSA)
		{
			return GetRsaKeyPair((RSA)privateKey);
		}
		throw new ArgumentException("Unsupported algorithm specified", "privateKey");
	}

	public static RSA ToRSA(RsaKeyParameters rsaKey)
	{
		return CreateRSAProvider(ToRSAParameters(rsaKey));
	}

	public static RSA ToRSA(RsaKeyParameters rsaKey, CspParameters csp)
	{
		return CreateRSAProvider(ToRSAParameters(rsaKey), csp);
	}

	public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey)
	{
		return CreateRSAProvider(ToRSAParameters(privKey));
	}

	public static RSA ToRSA(RsaPrivateCrtKeyParameters privKey, CspParameters csp)
	{
		return CreateRSAProvider(ToRSAParameters(privKey), csp);
	}

	public static RSA ToRSA(RsaPrivateKeyStructure privKey)
	{
		return CreateRSAProvider(ToRSAParameters(privKey));
	}

	public static RSA ToRSA(RsaPrivateKeyStructure privKey, CspParameters csp)
	{
		return CreateRSAProvider(ToRSAParameters(privKey), csp);
	}

	public static RSAParameters ToRSAParameters(RsaKeyParameters rsaKey)
	{
		RSAParameters rp = new RSAParameters
		{
			Modulus = rsaKey.Modulus.ToByteArrayUnsigned()
		};
		if (rsaKey.IsPrivate)
		{
			rp.D = ConvertRSAParametersField(rsaKey.Exponent, rp.Modulus.Length);
		}
		else
		{
			rp.Exponent = rsaKey.Exponent.ToByteArrayUnsigned();
		}
		return rp;
	}

	public static RSAParameters ToRSAParameters(RsaPrivateCrtKeyParameters privKey)
	{
		RSAParameters rp = default(RSAParameters);
		rp.Modulus = privKey.Modulus.ToByteArrayUnsigned();
		rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned();
		rp.P = privKey.P.ToByteArrayUnsigned();
		rp.Q = privKey.Q.ToByteArrayUnsigned();
		rp.D = ConvertRSAParametersField(privKey.Exponent, rp.Modulus.Length);
		rp.DP = ConvertRSAParametersField(privKey.DP, rp.P.Length);
		rp.DQ = ConvertRSAParametersField(privKey.DQ, rp.Q.Length);
		rp.InverseQ = ConvertRSAParametersField(privKey.QInv, rp.Q.Length);
		return rp;
	}

	public static RSAParameters ToRSAParameters(RsaPrivateKeyStructure privKey)
	{
		RSAParameters rp = default(RSAParameters);
		rp.Modulus = privKey.Modulus.ToByteArrayUnsigned();
		rp.Exponent = privKey.PublicExponent.ToByteArrayUnsigned();
		rp.P = privKey.Prime1.ToByteArrayUnsigned();
		rp.Q = privKey.Prime2.ToByteArrayUnsigned();
		rp.D = ConvertRSAParametersField(privKey.PrivateExponent, rp.Modulus.Length);
		rp.DP = ConvertRSAParametersField(privKey.Exponent1, rp.P.Length);
		rp.DQ = ConvertRSAParametersField(privKey.Exponent2, rp.Q.Length);
		rp.InverseQ = ConvertRSAParametersField(privKey.Coefficient, rp.Q.Length);
		return rp;
	}

	private static byte[] ConvertRSAParametersField(BigInteger n, int size)
	{
		byte[] bs = n.ToByteArrayUnsigned();
		if (bs.Length == size)
		{
			return bs;
		}
		if (bs.Length > size)
		{
			throw new ArgumentException("Specified size too small", "size");
		}
		byte[] padded = new byte[size];
		Array.Copy(bs, 0, padded, size - bs.Length, bs.Length);
		return padded;
	}

	private static RSA CreateRSAProvider(RSAParameters rp)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(new CspParameters
		{
			KeyContainerName = $"BouncyCastle-{Guid.NewGuid()}"
		});
		rSACryptoServiceProvider.ImportParameters(rp);
		return rSACryptoServiceProvider;
	}

	private static RSA CreateRSAProvider(RSAParameters rp, CspParameters csp)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(csp);
		rSACryptoServiceProvider.ImportParameters(rp);
		return rSACryptoServiceProvider;
	}
}
