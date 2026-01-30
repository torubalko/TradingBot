using System.Collections;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Generators;

public class NaccacheSternKeyPairGenerator : IAsymmetricCipherKeyPairGenerator
{
	private static readonly int[] smallPrimes = new int[101]
	{
		3, 5, 7, 11, 13, 17, 19, 23, 29, 31,
		37, 41, 43, 47, 53, 59, 61, 67, 71, 73,
		79, 83, 89, 97, 101, 103, 107, 109, 113, 127,
		131, 137, 139, 149, 151, 157, 163, 167, 173, 179,
		181, 191, 193, 197, 199, 211, 223, 227, 229, 233,
		239, 241, 251, 257, 263, 269, 271, 277, 281, 283,
		293, 307, 311, 313, 317, 331, 337, 347, 349, 353,
		359, 367, 373, 379, 383, 389, 397, 401, 409, 419,
		421, 431, 433, 439, 443, 449, 457, 461, 463, 467,
		479, 487, 491, 499, 503, 509, 521, 523, 541, 547,
		557
	};

	private NaccacheSternKeyGenerationParameters param;

	public void Init(KeyGenerationParameters parameters)
	{
		param = (NaccacheSternKeyGenerationParameters)parameters;
	}

	public AsymmetricCipherKeyPair GenerateKeyPair()
	{
		int strength = param.Strength;
		SecureRandom rand = param.Random;
		int certainty = param.Certainty;
		IList smallPrimes = findFirstPrimes(param.CountSmallPrimes);
		smallPrimes = permuteList(smallPrimes, rand);
		BigInteger u = BigInteger.One;
		BigInteger v = BigInteger.One;
		for (int i = 0; i < smallPrimes.Count / 2; i++)
		{
			u = u.Multiply((BigInteger)smallPrimes[i]);
		}
		for (int j = smallPrimes.Count / 2; j < smallPrimes.Count; j++)
		{
			v = v.Multiply((BigInteger)smallPrimes[j]);
		}
		BigInteger sigma = u.Multiply(v);
		int num = strength - sigma.BitLength - 48;
		BigInteger a = generatePrime(num / 2 + 1, certainty, rand);
		BigInteger b = generatePrime(num / 2 + 1, certainty, rand);
		long tries = 0L;
		BigInteger _2au = a.Multiply(u).ShiftLeft(1);
		BigInteger _2bv = b.Multiply(v).ShiftLeft(1);
		BigInteger _p;
		BigInteger p;
		BigInteger _q;
		BigInteger q;
		while (true)
		{
			tries++;
			_p = generatePrime(24, certainty, rand);
			p = _p.Multiply(_2au).Add(BigInteger.One);
			if (!p.IsProbablePrime(certainty, randomlySelected: true))
			{
				continue;
			}
			while (true)
			{
				_q = generatePrime(24, certainty, rand);
				if (!_p.Equals(_q))
				{
					q = _q.Multiply(_2bv).Add(BigInteger.One);
					if (q.IsProbablePrime(certainty, randomlySelected: true))
					{
						break;
					}
				}
			}
			if (sigma.Gcd(_p.Multiply(_q)).Equals(BigInteger.One) && p.Multiply(q).BitLength >= strength)
			{
				break;
			}
		}
		BigInteger n = p.Multiply(q);
		BigInteger phi_n = p.Subtract(BigInteger.One).Multiply(q.Subtract(BigInteger.One));
		tries = 0L;
		BigInteger g;
		bool divisible;
		do
		{
			IList gParts = Platform.CreateArrayList();
			for (int ind = 0; ind != smallPrimes.Count; ind++)
			{
				BigInteger i2 = (BigInteger)smallPrimes[ind];
				BigInteger e = phi_n.Divide(i2);
				do
				{
					tries++;
					g = generatePrime(strength, certainty, rand);
				}
				while (g.ModPow(e, n).Equals(BigInteger.One));
				gParts.Add(g);
			}
			g = BigInteger.One;
			for (int k = 0; k < smallPrimes.Count; k++)
			{
				BigInteger gPart = (BigInteger)gParts[k];
				BigInteger smallPrime = (BigInteger)smallPrimes[k];
				g = g.Multiply(gPart.ModPow(sigma.Divide(smallPrime), n)).Mod(n);
			}
			divisible = false;
			for (int l = 0; l < smallPrimes.Count; l++)
			{
				if (g.ModPow(phi_n.Divide((BigInteger)smallPrimes[l]), n).Equals(BigInteger.One))
				{
					divisible = true;
					break;
				}
			}
		}
		while (divisible || g.ModPow(phi_n.ShiftRight(2), n).Equals(BigInteger.One) || g.ModPow(phi_n.Divide(_p), n).Equals(BigInteger.One) || g.ModPow(phi_n.Divide(_q), n).Equals(BigInteger.One) || g.ModPow(phi_n.Divide(a), n).Equals(BigInteger.One) || g.ModPow(phi_n.Divide(b), n).Equals(BigInteger.One));
		return new AsymmetricCipherKeyPair(new NaccacheSternKeyParameters(privateKey: false, g, n, sigma.BitLength), new NaccacheSternPrivateKeyParameters(g, n, sigma.BitLength, smallPrimes, phi_n));
	}

	private static BigInteger generatePrime(int bitLength, int certainty, SecureRandom rand)
	{
		return new BigInteger(bitLength, certainty, rand);
	}

	private static IList permuteList(IList arr, SecureRandom rand)
	{
		IList retval = Platform.CreateArrayList(arr.Count);
		foreach (object element in arr)
		{
			int index = rand.Next(retval.Count + 1);
			retval.Insert(index, element);
		}
		return retval;
	}

	private static IList findFirstPrimes(int count)
	{
		IList primes = Platform.CreateArrayList(count);
		for (int i = 0; i != count; i++)
		{
			primes.Add(BigInteger.ValueOf(smallPrimes[i]));
		}
		return primes;
	}
}
