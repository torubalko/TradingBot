using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

internal class DHParametersHelper
{
	private static readonly BigInteger Six = BigInteger.ValueOf(6L);

	private static readonly int[][] primeLists = BigInteger.primeLists;

	private static readonly int[] primeProducts = BigInteger.primeProducts;

	private static readonly BigInteger[] BigPrimeProducts = ConstructBigPrimeProducts(primeProducts);

	private static BigInteger[] ConstructBigPrimeProducts(int[] primeProducts)
	{
		BigInteger[] bpp = new BigInteger[primeProducts.Length];
		for (int i = 0; i < bpp.Length; i++)
		{
			bpp[i] = BigInteger.ValueOf(primeProducts[i]);
		}
		return bpp;
	}

	internal static BigInteger[] GenerateSafePrimes(int size, int certainty, SecureRandom random)
	{
		int qLength = size - 1;
		int minWeight = size >> 2;
		BigInteger q;
		BigInteger p;
		if (size <= 32)
		{
			do
			{
				q = new BigInteger(qLength, 2, random);
				p = q.ShiftLeft(1).Add(BigInteger.One);
			}
			while (!p.IsProbablePrime(certainty, randomlySelected: true) || (certainty > 2 && !q.IsProbablePrime(certainty, randomlySelected: true)));
		}
		else
		{
			while (true)
			{
				q = new BigInteger(qLength, 0, random);
				while (true)
				{
					for (int i = 0; i < primeLists.Length; i++)
					{
						int test = q.Remainder(BigPrimeProducts[i]).IntValue;
						if (i == 0)
						{
							int rem3 = test % 3;
							if (rem3 != 2)
							{
								int diff = 2 * rem3 + 2;
								q = q.Add(BigInteger.ValueOf(diff));
								test = (test + diff) % primeProducts[i];
							}
						}
						int[] primeList = primeLists[i];
						foreach (int prime in primeList)
						{
							int qRem = test % prime;
							if (qRem == 0 || qRem == prime >> 1)
							{
								goto IL_00cd;
							}
						}
					}
					break;
					IL_00cd:
					q = q.Add(Six);
				}
				if (q.BitLength == qLength && q.RabinMillerTest(2, random, randomlySelected: true))
				{
					p = q.ShiftLeft(1).Add(BigInteger.One);
					if (p.RabinMillerTest(certainty, random, randomlySelected: true) && (certainty <= 2 || q.RabinMillerTest(certainty - 2, random, randomlySelected: true)) && WNafUtilities.GetNafWeight(p) >= minWeight)
					{
						break;
					}
				}
			}
		}
		return new BigInteger[2] { p, q };
	}

	internal static BigInteger SelectGenerator(BigInteger p, BigInteger q, SecureRandom random)
	{
		BigInteger pMinusTwo = p.Subtract(BigInteger.Two);
		BigInteger g;
		do
		{
			g = BigIntegers.CreateRandomInRange(BigInteger.Two, pMinusTwo, random).ModPow(BigInteger.Two, p);
		}
		while (g.Equals(BigInteger.One));
		return g;
	}
}
