using System;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace MimeKit.Cryptography;

public static class AsymmetricAlgorithmExtensions
{
	private static void GetAsymmetricKeyParameters(DSA dsa, bool publicOnly, out AsymmetricKeyParameter pub, out AsymmetricKeyParameter key)
	{
		DSAParameters dSAParameters = dsa.ExportParameters(!publicOnly);
		DsaValidationParameters parameters = ((dSAParameters.Seed != null) ? new DsaValidationParameters(dSAParameters.Seed, dSAParameters.Counter) : null);
		DsaParameters parameters2 = new DsaParameters(new BigInteger(1, dSAParameters.P), new BigInteger(1, dSAParameters.Q), new BigInteger(1, dSAParameters.G), parameters);
		pub = new DsaPublicKeyParameters(new BigInteger(1, dSAParameters.Y), parameters2);
		key = (publicOnly ? null : new DsaPrivateKeyParameters(new BigInteger(1, dSAParameters.X), parameters2));
	}

	private static AsymmetricKeyParameter GetAsymmetricKeyParameter(DSACryptoServiceProvider dsa)
	{
		GetAsymmetricKeyParameters(dsa, dsa.PublicOnly, out var pub, out var key);
		if (!dsa.PublicOnly)
		{
			return key;
		}
		return pub;
	}

	private static AsymmetricCipherKeyPair GetAsymmetricCipherKeyPair(DSACryptoServiceProvider dsa)
	{
		if (dsa.PublicOnly)
		{
			throw new ArgumentException("DSA key is not a private key.", "key");
		}
		GetAsymmetricKeyParameters(dsa, dsa.PublicOnly, out var pub, out var key);
		return new AsymmetricCipherKeyPair(pub, key);
	}

	private static AsymmetricKeyParameter GetAsymmetricKeyParameter(DSA dsa)
	{
		GetAsymmetricKeyParameters(dsa, publicOnly: false, out var _, out var key);
		return key;
	}

	private static AsymmetricCipherKeyPair GetAsymmetricCipherKeyPair(DSA dsa)
	{
		GetAsymmetricKeyParameters(dsa, publicOnly: false, out var pub, out var key);
		return new AsymmetricCipherKeyPair(pub, key);
	}

	private static void GetAsymmetricKeyParameters(RSA rsa, bool publicOnly, out AsymmetricKeyParameter pub, out AsymmetricKeyParameter key)
	{
		RSAParameters rSAParameters = rsa.ExportParameters(!publicOnly);
		BigInteger modulus = new BigInteger(1, rSAParameters.Modulus);
		BigInteger bigInteger = new BigInteger(1, rSAParameters.Exponent);
		pub = new RsaKeyParameters(isPrivate: false, modulus, bigInteger);
		key = (publicOnly ? null : new RsaPrivateCrtKeyParameters(modulus, bigInteger, new BigInteger(1, rSAParameters.D), new BigInteger(1, rSAParameters.P), new BigInteger(1, rSAParameters.Q), new BigInteger(1, rSAParameters.DP), new BigInteger(1, rSAParameters.DQ), new BigInteger(1, rSAParameters.InverseQ)));
	}

	private static AsymmetricKeyParameter GetAsymmetricKeyParameter(RSACryptoServiceProvider rsa)
	{
		GetAsymmetricKeyParameters(rsa, rsa.PublicOnly, out var pub, out var key);
		if (!rsa.PublicOnly)
		{
			return key;
		}
		return pub;
	}

	private static AsymmetricCipherKeyPair GetAsymmetricCipherKeyPair(RSACryptoServiceProvider rsa)
	{
		if (rsa.PublicOnly)
		{
			throw new ArgumentException("RSA key is not a private key.", "key");
		}
		GetAsymmetricKeyParameters(rsa, rsa.PublicOnly, out var pub, out var key);
		return new AsymmetricCipherKeyPair(pub, key);
	}

	private static AsymmetricKeyParameter GetAsymmetricKeyParameter(RSA rsa)
	{
		GetAsymmetricKeyParameters(rsa, publicOnly: false, out var _, out var key);
		return key;
	}

	private static AsymmetricCipherKeyPair GetAsymmetricCipherKeyPair(RSA rsa)
	{
		GetAsymmetricKeyParameters(rsa, publicOnly: false, out var pub, out var key);
		return new AsymmetricCipherKeyPair(pub, key);
	}

	public static AsymmetricKeyParameter AsAsymmetricKeyParameter(this AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key is RSACryptoServiceProvider rsa)
		{
			return GetAsymmetricKeyParameter(rsa);
		}
		if (key is RSA rsa2)
		{
			return GetAsymmetricKeyParameter(rsa2);
		}
		if (key is DSACryptoServiceProvider dsa)
		{
			return GetAsymmetricKeyParameter(dsa);
		}
		if (key is DSA dsa2)
		{
			return GetAsymmetricKeyParameter(dsa2);
		}
		throw new NotSupportedException($"'{key.GetType().Name}' is currently not supported.");
	}

	public static AsymmetricCipherKeyPair AsAsymmetricCipherKeyPair(this AsymmetricAlgorithm key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key is RSACryptoServiceProvider rsa)
		{
			return GetAsymmetricCipherKeyPair(rsa);
		}
		if (key is RSA rsa2)
		{
			return GetAsymmetricCipherKeyPair(rsa2);
		}
		if (key is DSACryptoServiceProvider dsa)
		{
			return GetAsymmetricCipherKeyPair(dsa);
		}
		if (key is DSA dsa2)
		{
			return GetAsymmetricCipherKeyPair(dsa2);
		}
		throw new NotSupportedException($"'{key.GetType().Name}' is currently not supported.");
	}

	private static byte[] GetPaddedByteArray(BigInteger big, int length)
	{
		byte[] array = big.ToByteArrayUnsigned();
		if (array.Length >= length)
		{
			return array;
		}
		byte[] array2 = new byte[length];
		Buffer.BlockCopy(array, 0, array2, length - array.Length, array.Length);
		return array2;
	}

	private static DSAParameters GetDSAParameters(DsaKeyParameters key)
	{
		DSAParameters result = default(DSAParameters);
		if (key.Parameters.ValidationParameters != null)
		{
			result.Counter = key.Parameters.ValidationParameters.Counter;
			result.Seed = key.Parameters.ValidationParameters.GetSeed();
		}
		result.P = key.Parameters.P.ToByteArrayUnsigned();
		result.Q = key.Parameters.Q.ToByteArrayUnsigned();
		result.G = GetPaddedByteArray(key.Parameters.G, result.P.Length);
		return result;
	}

	private static AsymmetricAlgorithm GetAsymmetricAlgorithm(DsaPrivateKeyParameters key, DsaPublicKeyParameters pub)
	{
		DSAParameters dSAParameters = GetDSAParameters(key);
		dSAParameters.X = GetPaddedByteArray(key.X, dSAParameters.Q.Length);
		if (pub != null)
		{
			dSAParameters.Y = GetPaddedByteArray(pub.Y, dSAParameters.P.Length);
		}
		DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
		dSACryptoServiceProvider.ImportParameters(dSAParameters);
		return dSACryptoServiceProvider;
	}

	private static AsymmetricAlgorithm GetAsymmetricAlgorithm(DsaPublicKeyParameters key)
	{
		DSAParameters dSAParameters = GetDSAParameters(key);
		dSAParameters.Y = key.Y.ToByteArrayUnsigned();
		DSACryptoServiceProvider dSACryptoServiceProvider = new DSACryptoServiceProvider();
		dSACryptoServiceProvider.ImportParameters(dSAParameters);
		return dSACryptoServiceProvider;
	}

	private static AsymmetricAlgorithm GetAsymmetricAlgorithm(RsaPrivateCrtKeyParameters key)
	{
		RSAParameters parameters = default(RSAParameters);
		parameters.Exponent = key.PublicExponent.ToByteArrayUnsigned();
		parameters.Modulus = key.Modulus.ToByteArrayUnsigned();
		parameters.P = key.P.ToByteArrayUnsigned();
		parameters.Q = key.Q.ToByteArrayUnsigned();
		parameters.InverseQ = GetPaddedByteArray(key.QInv, parameters.Q.Length);
		parameters.D = GetPaddedByteArray(key.Exponent, parameters.Modulus.Length);
		parameters.DP = GetPaddedByteArray(key.DP, parameters.P.Length);
		parameters.DQ = GetPaddedByteArray(key.DQ, parameters.Q.Length);
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		return rSACryptoServiceProvider;
	}

	private static AsymmetricAlgorithm GetAsymmetricAlgorithm(RsaKeyParameters key)
	{
		RSAParameters parameters = new RSAParameters
		{
			Exponent = key.Exponent.ToByteArrayUnsigned(),
			Modulus = key.Modulus.ToByteArrayUnsigned()
		};
		RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.ImportParameters(parameters);
		return rSACryptoServiceProvider;
	}

	public static AsymmetricAlgorithm AsAsymmetricAlgorithm(this AsymmetricKeyParameter key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.IsPrivate)
		{
			if (key is RsaPrivateCrtKeyParameters key2)
			{
				return GetAsymmetricAlgorithm(key2);
			}
			if (key is DsaPrivateKeyParameters key3)
			{
				return GetAsymmetricAlgorithm(key3, null);
			}
		}
		else
		{
			if (key is RsaKeyParameters key4)
			{
				return GetAsymmetricAlgorithm(key4);
			}
			if (key is DsaPublicKeyParameters key5)
			{
				return GetAsymmetricAlgorithm(key5);
			}
		}
		throw new NotSupportedException($"{key.GetType().Name} is currently not supported.");
	}

	public static AsymmetricAlgorithm AsAsymmetricAlgorithm(this AsymmetricCipherKeyPair key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.Private is RsaPrivateCrtKeyParameters key2)
		{
			return GetAsymmetricAlgorithm(key2);
		}
		if (key.Private is DsaPrivateKeyParameters key3)
		{
			return GetAsymmetricAlgorithm(key3, (DsaPublicKeyParameters)key.Public);
		}
		throw new NotSupportedException($"{key.GetType().Name} is currently not supported.");
	}
}
