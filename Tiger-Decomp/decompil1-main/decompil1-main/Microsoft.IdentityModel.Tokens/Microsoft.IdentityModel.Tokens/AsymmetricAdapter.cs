using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal class AsymmetricAdapter : IDisposable
{
	private bool _useRSAOeapPadding;

	private bool _disposeCryptoOperators;

	private bool _disposed;

	private DecryptDelegate DecryptFunction = DecryptFunctionNotFound;

	private EncryptDelegate EncryptFunction = EncryptFunctionNotFound;

	private SignDelegate SignatureFunction = SignatureFunctionNotFound;

	private VerifyDelegate VerifyFunction = VerifyFunctionNotFound;

	private ECDsa ECDsa { get; set; }

	private HashAlgorithm HashAlgorithm { get; set; }

	private RSA RSA { get; set; }

	private HashAlgorithmName HashAlgorithmName { get; set; }

	private RSAEncryptionPadding RSAEncryptionPadding { get; set; }

	private RSASignaturePadding RSASignaturePadding { get; set; }

	private RSACryptoServiceProviderProxy RsaCryptoServiceProviderProxy { get; set; }

	internal AsymmetricAdapter(SecurityKey key, string algorithm, bool requirePrivateKey)
		: this(key, algorithm, null, requirePrivateKey)
	{
	}

	internal AsymmetricAdapter(SecurityKey key, string algorithm, HashAlgorithm hashAlgorithm, bool requirePrivateKey)
	{
		HashAlgorithm = hashAlgorithm;
		if (key is RsaSecurityKey rsaSecurityKey)
		{
			InitializeUsingRsaSecurityKey(rsaSecurityKey, algorithm);
		}
		else if (key is X509SecurityKey x509SecurityKey)
		{
			InitializeUsingX509SecurityKey(x509SecurityKey, algorithm, requirePrivateKey);
		}
		else if (key is JsonWebKey webKey)
		{
			if (!JsonWebKeyConverter.TryConvertToSecurityKey(webKey, out var key2))
			{
				return;
			}
			if (key2 is RsaSecurityKey rsaSecurityKey2)
			{
				InitializeUsingRsaSecurityKey(rsaSecurityKey2, algorithm);
				return;
			}
			if (key2 is X509SecurityKey x509SecurityKey2)
			{
				InitializeUsingX509SecurityKey(x509SecurityKey2, algorithm, requirePrivateKey);
				return;
			}
			if (!(key2 is ECDsaSecurityKey ecdsaSecurityKey))
			{
				throw LogHelper.LogExceptionMessage(new NotSupportedException(LogHelper.FormatInvariant("IDX10684: Unable to convert the JsonWebKey to an AsymmetricSecurityKey. Algorithm: '{0}', Key: '{1}'.", LogHelper.MarkAsNonPII(algorithm), key)));
			}
			InitializeUsingEcdsaSecurityKey(ecdsaSecurityKey);
		}
		else
		{
			if (!(key is ECDsaSecurityKey ecdsaSecurityKey2))
			{
				throw LogHelper.LogExceptionMessage(new NotSupportedException(LogHelper.FormatInvariant("IDX10684: Unable to convert the JsonWebKey to an AsymmetricSecurityKey. Algorithm: '{0}', Key: '{1}'.", LogHelper.MarkAsNonPII(algorithm), key)));
			}
			InitializeUsingEcdsaSecurityKey(ecdsaSecurityKey2);
		}
	}

	internal byte[] Decrypt(byte[] data)
	{
		return DecryptFunction(data);
	}

	internal static byte[] DecryptFunctionNotFound(byte[] _)
	{
		throw LogHelper.LogExceptionMessage(new NotSupportedException("IDX10711: Unable to Decrypt, Internal DecryptionFunction is not available."));
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (_disposed)
		{
			return;
		}
		_disposed = true;
		if (disposing && _disposeCryptoOperators)
		{
			if (ECDsa != null)
			{
				ECDsa.Dispose();
			}
			if (RsaCryptoServiceProviderProxy != null)
			{
				RsaCryptoServiceProviderProxy.Dispose();
			}
			if (RSA != null)
			{
				RSA.Dispose();
			}
		}
	}

	internal byte[] Encrypt(byte[] data)
	{
		return EncryptFunction(data);
	}

	internal static byte[] EncryptFunctionNotFound(byte[] _)
	{
		throw LogHelper.LogExceptionMessage(new NotSupportedException("IDX10712: Unable to Encrypt, Internal EncryptionFunction is not available."));
	}

	private void InitializeUsingEcdsaSecurityKey(ECDsaSecurityKey ecdsaSecurityKey)
	{
		ECDsa = ecdsaSecurityKey.ECDsa;
		SignatureFunction = SignWithECDsa;
		VerifyFunction = VerifyWithECDsa;
	}

	private void InitializeUsingRsa(RSA rsa, string algorithm)
	{
		if (rsa is RSACryptoServiceProvider rsa2)
		{
			_useRSAOeapPadding = algorithm.Equals("RSA-OAEP", StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", StringComparison.Ordinal);
			RsaCryptoServiceProviderProxy = new RSACryptoServiceProviderProxy(rsa2);
			DecryptFunction = DecryptWithRsaCryptoServiceProviderProxy;
			EncryptFunction = EncryptWithRsaCryptoServiceProviderProxy;
			SignatureFunction = SignWithRsaCryptoServiceProviderProxy;
			VerifyFunction = VerifyWithRsaCryptoServiceProviderProxy;
			_disposeCryptoOperators = true;
			return;
		}
		if (algorithm.Equals("PS256", StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2007/05/xmldsig-more#sha256-rsa-MGF1", StringComparison.Ordinal) || algorithm.Equals("PS384", StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2007/05/xmldsig-more#sha384-rsa-MGF1", StringComparison.Ordinal) || algorithm.Equals("PS512", StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2007/05/xmldsig-more#sha512-rsa-MGF1", StringComparison.Ordinal))
		{
			RSASignaturePadding = RSASignaturePadding.Pss;
		}
		else
		{
			RSASignaturePadding = RSASignaturePadding.Pkcs1;
		}
		RSAEncryptionPadding = ((algorithm.Equals("RSA-OAEP", StringComparison.Ordinal) || algorithm.Equals("http://www.w3.org/2001/04/xmlenc#rsa-oaep", StringComparison.Ordinal)) ? RSAEncryptionPadding.OaepSHA1 : RSAEncryptionPadding.Pkcs1);
		RSA = rsa;
		DecryptFunction = DecryptWithRsa;
		EncryptFunction = EncryptWithRsa;
		SignatureFunction = SignWithRsa;
		VerifyFunction = VerifyWithRsa;
	}

	private void InitializeUsingRsaSecurityKey(RsaSecurityKey rsaSecurityKey, string algorithm)
	{
		if (rsaSecurityKey.Rsa != null)
		{
			InitializeUsingRsa(rsaSecurityKey.Rsa, algorithm);
			return;
		}
		RSA rsa = RSA.Create(rsaSecurityKey.Parameters);
		InitializeUsingRsa(rsa, algorithm);
		_disposeCryptoOperators = true;
	}

	private void InitializeUsingX509SecurityKey(X509SecurityKey x509SecurityKey, string algorithm, bool requirePrivateKey)
	{
		if (requirePrivateKey)
		{
			InitializeUsingRsa(x509SecurityKey.PrivateKey as RSA, algorithm);
		}
		else
		{
			InitializeUsingRsa(x509SecurityKey.PublicKey as RSA, algorithm);
		}
	}

	internal byte[] Sign(byte[] bytes)
	{
		return SignatureFunction(bytes);
	}

	private static byte[] SignatureFunctionNotFound(byte[] _)
	{
		throw LogHelper.LogExceptionMessage(new CryptographicException("IDX10685: Unable to Sign, Internal SignFunction is not available."));
	}

	private byte[] SignWithECDsa(byte[] bytes)
	{
		return ECDsa.SignHash(HashAlgorithm.ComputeHash(bytes));
	}

	internal bool Verify(byte[] bytes, byte[] signature)
	{
		return VerifyFunction(bytes, signature);
	}

	private static bool VerifyFunctionNotFound(byte[] bytes, byte[] signature)
	{
		throw LogHelper.LogExceptionMessage(new NotSupportedException("IDX10686: Unable to Verify, Internal VerifyFunction is not available."));
	}

	private bool VerifyWithECDsa(byte[] bytes, byte[] signature)
	{
		return ECDsa.VerifyHash(HashAlgorithm.ComputeHash(bytes), signature);
	}

	internal AsymmetricAdapter(SecurityKey key, string algorithm, HashAlgorithm hashAlgorithm, HashAlgorithmName hashAlgorithmName, bool requirePrivateKey)
		: this(key, algorithm, hashAlgorithm, requirePrivateKey)
	{
		HashAlgorithmName = hashAlgorithmName;
	}

	private byte[] DecryptWithRsa(byte[] bytes)
	{
		return RSA.Decrypt(bytes, RSAEncryptionPadding);
	}

	private byte[] EncryptWithRsa(byte[] bytes)
	{
		return RSA.Encrypt(bytes, RSAEncryptionPadding);
	}

	private byte[] SignWithRsa(byte[] bytes)
	{
		return RSA.SignHash(HashAlgorithm.ComputeHash(bytes), HashAlgorithmName, RSASignaturePadding);
	}

	private bool VerifyWithRsa(byte[] bytes, byte[] signature)
	{
		return RSA.VerifyHash(HashAlgorithm.ComputeHash(bytes), signature, HashAlgorithmName, RSASignaturePadding);
	}

	internal byte[] DecryptWithRsaCryptoServiceProviderProxy(byte[] bytes)
	{
		return RsaCryptoServiceProviderProxy.Decrypt(bytes, _useRSAOeapPadding);
	}

	internal byte[] EncryptWithRsaCryptoServiceProviderProxy(byte[] bytes)
	{
		return RsaCryptoServiceProviderProxy.Encrypt(bytes, _useRSAOeapPadding);
	}

	internal byte[] SignWithRsaCryptoServiceProviderProxy(byte[] bytes)
	{
		return RsaCryptoServiceProviderProxy.SignData(bytes, HashAlgorithm);
	}

	private bool VerifyWithRsaCryptoServiceProviderProxy(byte[] bytes, byte[] signature)
	{
		return RsaCryptoServiceProviderProxy.VerifyData(bytes, HashAlgorithm, signature);
	}
}
