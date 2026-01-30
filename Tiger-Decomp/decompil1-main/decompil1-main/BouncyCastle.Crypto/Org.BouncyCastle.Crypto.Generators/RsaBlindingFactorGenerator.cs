using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Generators;

public class RsaBlindingFactorGenerator
{
	private RsaKeyParameters key;

	private SecureRandom random;

	public void Init(ICipherParameters param)
	{
		if (param is ParametersWithRandom)
		{
			ParametersWithRandom rParam = (ParametersWithRandom)param;
			key = (RsaKeyParameters)rParam.Parameters;
			random = rParam.Random;
		}
		else
		{
			key = (RsaKeyParameters)param;
			random = new SecureRandom();
		}
		if (key.IsPrivate)
		{
			throw new ArgumentException("generator requires RSA public key");
		}
	}

	public BigInteger GenerateBlindingFactor()
	{
		if (key == null)
		{
			throw new InvalidOperationException("generator not initialised");
		}
		BigInteger m = key.Modulus;
		int length = m.BitLength - 1;
		BigInteger factor;
		BigInteger gcd;
		do
		{
			factor = new BigInteger(length, random);
			gcd = factor.Gcd(m);
		}
		while (factor.SignValue == 0 || factor.Equals(BigInteger.One) || !gcd.Equals(BigInteger.One));
		return factor;
	}
}
