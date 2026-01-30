using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC;

public class BcTlsDHDomain : TlsDHDomain
{
	protected readonly BcTlsCrypto crypto;

	protected readonly TlsDHConfig dhConfig;

	protected readonly DHParameters dhParameters;

	private static byte[] EncodeValue(DHParameters dh, bool padded, BigInteger x)
	{
		if (!padded)
		{
			return BigIntegers.AsUnsignedByteArray(x);
		}
		return BigIntegers.AsUnsignedByteArray(GetValueLength(dh), x);
	}

	private static int GetValueLength(DHParameters dh)
	{
		return (dh.P.BitLength + 7) / 8;
	}

	public static BcTlsSecret CalculateDHAgreement(BcTlsCrypto crypto, DHPrivateKeyParameters privateKey, DHPublicKeyParameters publicKey, bool padded)
	{
		DHBasicAgreement dHBasicAgreement = new DHBasicAgreement();
		dHBasicAgreement.Init(privateKey);
		BigInteger agreementValue = dHBasicAgreement.CalculateAgreement(publicKey);
		byte[] secret = EncodeValue(privateKey.Parameters, padded, agreementValue);
		return crypto.AdoptLocalSecret(secret);
	}

	public static DHParameters GetParameters(TlsDHConfig dhConfig)
	{
		DHGroup dhGroup = TlsDHUtilities.GetDHGroup(dhConfig);
		if (dhGroup == null)
		{
			throw new ArgumentException("No DH configuration provided");
		}
		return new DHParameters(dhGroup.P, dhGroup.G, dhGroup.Q, dhGroup.L);
	}

	public BcTlsDHDomain(BcTlsCrypto crypto, TlsDHConfig dhConfig)
	{
		this.crypto = crypto;
		this.dhConfig = dhConfig;
		dhParameters = GetParameters(dhConfig);
	}

	public virtual BcTlsSecret CalculateDHAgreement(DHPrivateKeyParameters privateKey, DHPublicKeyParameters publicKey)
	{
		return CalculateDHAgreement(crypto, privateKey, publicKey, dhConfig.IsPadded);
	}

	public virtual TlsAgreement CreateDH()
	{
		return new BcTlsDH(this);
	}

	public virtual BigInteger DecodeParameter(byte[] encoding)
	{
		if (dhConfig.IsPadded && GetValueLength(dhParameters) != encoding.Length)
		{
			throw new TlsFatalAlert(47);
		}
		return new BigInteger(1, encoding);
	}

	public virtual DHPublicKeyParameters DecodePublicKey(byte[] encoding)
	{
		try
		{
			return new DHPublicKeyParameters(DecodeParameter(encoding), dhParameters);
		}
		catch (Exception alertCause)
		{
			throw new TlsFatalAlert(40, alertCause);
		}
	}

	public virtual byte[] EncodeParameter(BigInteger x)
	{
		return EncodeValue(dhParameters, dhConfig.IsPadded, x);
	}

	public virtual byte[] EncodePublicKey(DHPublicKeyParameters publicKey)
	{
		return EncodeValue(dhParameters, padded: true, publicKey.Y);
	}

	public virtual AsymmetricCipherKeyPair GenerateKeyPair()
	{
		DHBasicKeyPairGenerator dHBasicKeyPairGenerator = new DHBasicKeyPairGenerator();
		dHBasicKeyPairGenerator.Init(new DHKeyGenerationParameters(crypto.SecureRandom, dhParameters));
		return dHBasicKeyPairGenerator.GenerateKeyPair();
	}
}
