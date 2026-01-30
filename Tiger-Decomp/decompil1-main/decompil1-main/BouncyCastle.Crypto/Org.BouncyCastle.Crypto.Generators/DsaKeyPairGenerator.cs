using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class DsaKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly BigInteger One = BigInteger.One;

	private DsaKeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
		if (parameters == null)
		{
			throw new ArgumentNullException("parameters");
		}
		param = (DsaKeyGenerationParameters)parameters;
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		DsaParameters dsaParams = param.Parameters;
		BigInteger x = GeneratePrivateKey(dsaParams.Q, param.Random);
		return new AsymmetricCipherKeyPair(new DsaPublicKeyParameters(CalculatePublicKey(dsaParams.P, dsaParams.G, x), dsaParams), new DsaPrivateKeyParameters(x, dsaParams));
	}

	private static BigInteger GeneratePrivateKey(BigInteger q, SecureRandom random)
	{
		int minWeight = q.BitLength >> 2;
		BigInteger x;
		do
		{
			x = BigIntegers.CreateRandomInRange(One, q.Subtract(One), random);
		}
		while (WNafUtilities.GetNafWeight(x) < minWeight);
		return x;
	}

	private static BigInteger CalculatePublicKey(BigInteger p, BigInteger g, BigInteger x)
	{
		return g.ModPow(x, p);
	}
}
