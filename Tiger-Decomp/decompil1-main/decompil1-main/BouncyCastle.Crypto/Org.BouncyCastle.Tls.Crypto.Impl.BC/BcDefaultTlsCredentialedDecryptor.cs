using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcDefaultTlsCredentialedDecryptor : TlsCredentialedDecryptor, TlsCredentials
{
	protected readonly BcTlsCrypto m_crypto;

	protected readonly Certificate m_certificate;

	protected readonly AsymmetricKeyParameter m_privateKey;

	public virtual Certificate Certificate => m_certificate;

	public BcDefaultTlsCredentialedDecryptor(BcTlsCrypto crypto, Certificate certificate, AsymmetricKeyParameter privateKey)
	{
		if (crypto == null)
		{
			throw new ArgumentNullException("crypto");
		}
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		if (certificate.IsEmpty)
		{
			throw new ArgumentException("cannot be empty", "certificate");
		}
		if (privateKey == null)
		{
			throw new ArgumentNullException("privateKey");
		}
		if (!privateKey.IsPrivate)
		{
			throw new ArgumentException("must be private", "privateKey");
		}
		if (!(privateKey is RsaKeyParameters))
		{
			throw new ArgumentException("'privateKey' type not supported: " + Platform.GetTypeName(privateKey));
		}
		m_crypto = crypto;
		m_certificate = certificate;
		m_privateKey = privateKey;
	}

	public virtual TlsSecret Decrypt(TlsCryptoParameters cryptoParams, byte[] ciphertext)
	{
		return SafeDecryptPreMasterSecret(cryptoParams, (RsaKeyParameters)m_privateKey, ciphertext);
	}

	protected virtual TlsSecret SafeDecryptPreMasterSecret(TlsCryptoParameters cryptoParams, RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
	{
		SecureRandom secureRandom = m_crypto.SecureRandom;
		ProtocolVersion expectedVersion = cryptoParams.RsaPreMasterSecretVersion;
		bool versionNumberCheckDisabled = false;
		byte[] fallback = new byte[48];
		secureRandom.NextBytes(fallback);
		byte[] M = Arrays.Clone(fallback);
		try
		{
			Pkcs1Encoding pkcs1Encoding = new Pkcs1Encoding(new RsaBlindedEngine(), fallback);
			pkcs1Encoding.Init(forEncryption: false, new ParametersWithRandom(rsaServerPrivateKey, secureRandom));
			M = pkcs1Encoding.ProcessBlock(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
		}
		catch (Exception)
		{
		}
		if (!versionNumberCheckDisabled || TlsImplUtilities.IsTlsV11(expectedVersion))
		{
			int mask = (expectedVersion.MajorVersion ^ (M[0] & 0xFF)) | (expectedVersion.MinorVersion ^ (M[1] & 0xFF));
			mask = mask - 1 >> 31;
			for (int i = 0; i < 48; i++)
			{
				M[i] = (byte)((M[i] & mask) | (fallback[i] & ~mask));
			}
		}
		return m_crypto.CreateSecret(M);
	}
}
