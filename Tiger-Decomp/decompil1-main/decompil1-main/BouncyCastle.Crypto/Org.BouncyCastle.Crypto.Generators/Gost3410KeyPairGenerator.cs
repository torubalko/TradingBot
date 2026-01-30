using Org.BouncyCastle.Asn1.CryptoPro;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class Gost3410KeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private Gost3410KeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
		if (parameters is Gost3410KeyGenerationParameters)
		{
			param = (Gost3410KeyGenerationParameters)parameters;
			return;
		}
		Gost3410KeyGenerationParameters kgp = new Gost3410KeyGenerationParameters(parameters.Random, CryptoProObjectIdentifiers.GostR3410x94CryptoProA);
		_ = parameters.Strength;
		_ = kgp.Parameters.P.BitLength - 1;
		param = kgp;
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		SecureRandom random = param.Random;
		Gost3410Parameters gost3410Params = param.Parameters;
		BigInteger q = gost3410Params.Q;
		int minWeight = 64;
		BigInteger x;
		do
		{
			x = new BigInteger(256, random);
		}
		while (x.SignValue < 1 || x.CompareTo(q) >= 0 || WNafUtilities.GetNafWeight(x) < minWeight);
		BigInteger p = gost3410Params.P;
		BigInteger y = gost3410Params.A.ModPow(x, p);
		if (param.PublicKeyParamSet != null)
		{
			return new AsymmetricCipherKeyPair(new Gost3410PublicKeyParameters(y, param.PublicKeyParamSet), new Gost3410PrivateKeyParameters(x, param.PublicKeyParamSet));
		}
		return new AsymmetricCipherKeyPair(new Gost3410PublicKeyParameters(y, gost3410Params), new Gost3410PrivateKeyParameters(x, gost3410Params));
	}
}
