using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

internal class DHKeyGeneratorHelper
{
	internal static readonly DHKeyGeneratorHelper Instance = new DHKeyGeneratorHelper();

	private DHKeyGeneratorHelper()
	{
	}

	internal BigInteger CalculatePrivate(DHParameters dhParams, SecureRandom random)
	{
		int limit = dhParams.L;
		if (limit != 0)
		{
			int minWeight = limit >> 2;
			BigInteger x;
			do
			{
				x = new BigInteger(limit, random).SetBit(limit - 1);
			}
			while (WNafUtilities.GetNafWeight(x) < minWeight);
			return x;
		}
		BigInteger min = BigInteger.Two;
		int m = dhParams.M;
		if (m != 0)
		{
			min = BigInteger.One.ShiftLeft(m - 1);
		}
		BigInteger q = dhParams.Q;
		if (q == null)
		{
			q = dhParams.P;
		}
		BigInteger max = q.Subtract(BigInteger.Two);
		int minWeight2 = max.BitLength >> 2;
		BigInteger x2;
		do
		{
			x2 = BigIntegers.CreateRandomInRange(min, max, random);
		}
		while (WNafUtilities.GetNafWeight(x2) < minWeight2);
		return x2;
	}

	internal BigInteger CalculatePublic(DHParameters dhParams, BigInteger x)
	{
		return dhParams.G.ModPow(x, dhParams.P);
	}
}
