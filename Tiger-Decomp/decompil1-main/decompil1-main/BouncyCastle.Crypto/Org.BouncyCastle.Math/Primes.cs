using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math;

public abstract class Primes
{
	public class MROutput
	{
		private readonly bool mProvablyComposite;

		private readonly BigInteger mFactor;

		public BigInteger Factor => mFactor;

		public bool IsProvablyComposite => mProvablyComposite;

		public bool IsNotPrimePower
		{
			get
			{
				if (mProvablyComposite)
				{
					return mFactor == null;
				}
				return false;
			}
		}

		internal static MROutput ProbablyPrime()
		{
			return new MROutput(provablyComposite: false, null);
		}

		internal static MROutput ProvablyCompositeWithFactor(BigInteger factor)
		{
			return new MROutput(provablyComposite: true, factor);
		}

		internal static MROutput ProvablyCompositeNotPrimePower()
		{
			return new MROutput(provablyComposite: true, null);
		}

		private MROutput(bool provablyComposite, BigInteger factor)
		{
			mProvablyComposite = provablyComposite;
			mFactor = factor;
		}
	}

	public class STOutput
	{
		private readonly BigInteger mPrime;

		private readonly byte[] mPrimeSeed;

		private readonly int mPrimeGenCounter;

		public BigInteger Prime => mPrime;

		public byte[] PrimeSeed => mPrimeSeed;

		public int PrimeGenCounter => mPrimeGenCounter;

		internal STOutput(BigInteger prime, byte[] primeSeed, int primeGenCounter)
		{
			mPrime = prime;
			mPrimeSeed = primeSeed;
			mPrimeGenCounter = primeGenCounter;
		}
	}

	public static readonly int SmallFactorLimit = 211;

	private static readonly BigInteger One = BigInteger.One;

	private static readonly BigInteger Two = BigInteger.Two;

	private static readonly BigInteger Three = BigInteger.Three;

	public static STOutput GenerateSTRandomPrime(IDigest hash, int length, byte[] inputSeed)
	{
		if (hash == null)
		{
			throw new ArgumentNullException("hash");
		}
		if (length < 2)
		{
			throw new ArgumentException("must be >= 2", "length");
		}
		if (inputSeed == null)
		{
			throw new ArgumentNullException("inputSeed");
		}
		if (inputSeed.Length == 0)
		{
			throw new ArgumentException("cannot be empty", "inputSeed");
		}
		return ImplSTRandomPrime(hash, length, Arrays.Clone(inputSeed));
	}

	public static MROutput EnhancedMRProbablePrimeTest(BigInteger candidate, SecureRandom random, int iterations)
	{
		CheckCandidate(candidate, "candidate");
		if (random == null)
		{
			throw new ArgumentNullException("random");
		}
		if (iterations < 1)
		{
			throw new ArgumentException("must be > 0", "iterations");
		}
		if (candidate.BitLength == 2)
		{
			return MROutput.ProbablyPrime();
		}
		if (!candidate.TestBit(0))
		{
			return MROutput.ProvablyCompositeWithFactor(Two);
		}
		BigInteger wSubOne = candidate.Subtract(One);
		BigInteger wSubTwo = candidate.Subtract(Two);
		int a = wSubOne.GetLowestSetBit();
		BigInteger m = wSubOne.ShiftRight(a);
		for (int i = 0; i < iterations; i++)
		{
			BigInteger b = BigIntegers.CreateRandomInRange(Two, wSubTwo, random);
			BigInteger g = b.Gcd(candidate);
			if (g.CompareTo(One) > 0)
			{
				return MROutput.ProvablyCompositeWithFactor(g);
			}
			BigInteger z = b.ModPow(m, candidate);
			if (z.Equals(One) || z.Equals(wSubOne))
			{
				continue;
			}
			bool primeToBase = false;
			BigInteger x = z;
			for (int j = 1; j < a; j++)
			{
				z = z.ModPow(Two, candidate);
				if (z.Equals(wSubOne))
				{
					primeToBase = true;
					break;
				}
				if (z.Equals(One))
				{
					break;
				}
				x = z;
			}
			if (primeToBase)
			{
				continue;
			}
			if (!z.Equals(One))
			{
				x = z;
				z = z.ModPow(Two, candidate);
				if (!z.Equals(One))
				{
					x = z;
				}
			}
			g = x.Subtract(One).Gcd(candidate);
			if (g.CompareTo(One) > 0)
			{
				return MROutput.ProvablyCompositeWithFactor(g);
			}
			return MROutput.ProvablyCompositeNotPrimePower();
		}
		return MROutput.ProbablyPrime();
	}

	public static bool HasAnySmallFactors(BigInteger candidate)
	{
		CheckCandidate(candidate, "candidate");
		return ImplHasAnySmallFactors(candidate);
	}

	public static bool IsMRProbablePrime(BigInteger candidate, SecureRandom random, int iterations)
	{
		CheckCandidate(candidate, "candidate");
		if (random == null)
		{
			throw new ArgumentException("cannot be null", "random");
		}
		if (iterations < 1)
		{
			throw new ArgumentException("must be > 0", "iterations");
		}
		if (candidate.BitLength == 2)
		{
			return true;
		}
		if (!candidate.TestBit(0))
		{
			return false;
		}
		BigInteger wSubOne = candidate.Subtract(One);
		BigInteger wSubTwo = candidate.Subtract(Two);
		int a = wSubOne.GetLowestSetBit();
		BigInteger m = wSubOne.ShiftRight(a);
		for (int i = 0; i < iterations; i++)
		{
			BigInteger b = BigIntegers.CreateRandomInRange(Two, wSubTwo, random);
			if (!ImplMRProbablePrimeToBase(candidate, wSubOne, m, a, b))
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsMRProbablePrimeToBase(BigInteger candidate, BigInteger baseValue)
	{
		CheckCandidate(candidate, "candidate");
		CheckCandidate(baseValue, "baseValue");
		if (baseValue.CompareTo(candidate.Subtract(One)) >= 0)
		{
			throw new ArgumentException("must be < ('candidate' - 1)", "baseValue");
		}
		if (candidate.BitLength == 2)
		{
			return true;
		}
		BigInteger wSubOne = candidate.Subtract(One);
		int a = wSubOne.GetLowestSetBit();
		BigInteger m = wSubOne.ShiftRight(a);
		return ImplMRProbablePrimeToBase(candidate, wSubOne, m, a, baseValue);
	}

	private static void CheckCandidate(BigInteger n, string name)
	{
		if (n == null || n.SignValue < 1 || n.BitLength < 2)
		{
			throw new ArgumentException("must be non-null and >= 2", name);
		}
	}

	private static bool ImplHasAnySmallFactors(BigInteger x)
	{
		int m = 223092870;
		int r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 2 == 0 || r % 3 == 0 || r % 5 == 0 || r % 7 == 0 || r % 11 == 0 || r % 13 == 0 || r % 17 == 0 || r % 19 == 0 || r % 23 == 0)
		{
			return true;
		}
		m = 58642669;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 29 == 0 || r % 31 == 0 || r % 37 == 0 || r % 41 == 0 || r % 43 == 0)
		{
			return true;
		}
		m = 600662303;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 47 == 0 || r % 53 == 0 || r % 59 == 0 || r % 61 == 0 || r % 67 == 0)
		{
			return true;
		}
		m = 33984931;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 71 == 0 || r % 73 == 0 || r % 79 == 0 || r % 83 == 0)
		{
			return true;
		}
		m = 89809099;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 89 == 0 || r % 97 == 0 || r % 101 == 0 || r % 103 == 0)
		{
			return true;
		}
		m = 167375713;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 107 == 0 || r % 109 == 0 || r % 113 == 0 || r % 127 == 0)
		{
			return true;
		}
		m = 371700317;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 131 == 0 || r % 137 == 0 || r % 139 == 0 || r % 149 == 0)
		{
			return true;
		}
		m = 645328247;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 151 == 0 || r % 157 == 0 || r % 163 == 0 || r % 167 == 0)
		{
			return true;
		}
		m = 1070560157;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 173 == 0 || r % 179 == 0 || r % 181 == 0 || r % 191 == 0)
		{
			return true;
		}
		m = 1596463769;
		r = x.Mod(BigInteger.ValueOf(m)).IntValue;
		if (r % 193 == 0 || r % 197 == 0 || r % 199 == 0 || r % 211 == 0)
		{
			return true;
		}
		return false;
	}

	private static bool ImplMRProbablePrimeToBase(BigInteger w, BigInteger wSubOne, BigInteger m, int a, BigInteger b)
	{
		BigInteger z = b.ModPow(m, w);
		if (z.Equals(One) || z.Equals(wSubOne))
		{
			return true;
		}
		bool result = false;
		for (int j = 1; j < a; j++)
		{
			z = z.ModPow(Two, w);
			if (z.Equals(wSubOne))
			{
				result = true;
				break;
			}
			if (z.Equals(One))
			{
				return false;
			}
		}
		return result;
	}

	private static STOutput ImplSTRandomPrime(IDigest d, int length, byte[] primeSeed)
	{
		int dLen = d.GetDigestSize();
		if (length < 33)
		{
			int primeGenCounter = 0;
			byte[] c0 = new byte[dLen];
			byte[] c1 = new byte[dLen];
			do
			{
				Hash(d, primeSeed, c0, 0);
				Inc(primeSeed, 1);
				Hash(d, primeSeed, c1, 0);
				Inc(primeSeed, 1);
				uint c2 = Extract32(c0) ^ Extract32(c1);
				c2 &= (uint)(-1 >>> 32 - length);
				c2 |= (uint)((1 << length - 1) | 1);
				primeGenCounter++;
				if (IsPrime32(c2))
				{
					return new STOutput(BigInteger.ValueOf(c2), primeSeed, primeGenCounter);
				}
			}
			while (primeGenCounter <= 4 * length);
			throw new InvalidOperationException("Too many iterations in Shawe-Taylor Random_Prime Routine");
		}
		STOutput sTOutput = ImplSTRandomPrime(d, (length + 3) / 2, primeSeed);
		BigInteger c3 = sTOutput.Prime;
		primeSeed = sTOutput.PrimeSeed;
		int primeGenCounter2 = sTOutput.PrimeGenCounter;
		int outlen = 8 * dLen;
		int iterations = (length - 1) / outlen;
		int oldCounter = primeGenCounter2;
		BigInteger bigInteger = HashGen(d, primeSeed, iterations + 1).Mod(One.ShiftLeft(length - 1)).SetBit(length - 1);
		BigInteger c0x2 = c3.ShiftLeft(1);
		BigInteger tx2 = bigInteger.Subtract(One).Divide(c0x2).Add(One)
			.ShiftLeft(1);
		int dt = 0;
		BigInteger c4 = tx2.Multiply(c3).Add(One);
		while (true)
		{
			if (c4.BitLength > length)
			{
				tx2 = One.ShiftLeft(length - 1).Subtract(One).Divide(c0x2)
					.Add(One)
					.ShiftLeft(1);
				c4 = tx2.Multiply(c3).Add(One);
			}
			primeGenCounter2++;
			if (!ImplHasAnySmallFactors(c4))
			{
				BigInteger bigInteger2 = HashGen(d, primeSeed, iterations + 1).Mod(c4.Subtract(Three)).Add(Two);
				tx2 = tx2.Add(BigInteger.ValueOf(dt));
				dt = 0;
				BigInteger z = bigInteger2.ModPow(tx2, c4);
				if (c4.Gcd(z.Subtract(One)).Equals(One) && z.ModPow(c3, c4).Equals(One))
				{
					return new STOutput(c4, primeSeed, primeGenCounter2);
				}
			}
			else
			{
				Inc(primeSeed, iterations + 1);
			}
			if (primeGenCounter2 >= 4 * length + oldCounter)
			{
				break;
			}
			dt += 2;
			c4 = c4.Add(c0x2);
		}
		throw new InvalidOperationException("Too many iterations in Shawe-Taylor Random_Prime Routine");
	}

	private static uint Extract32(byte[] bs)
	{
		uint result = 0u;
		int count = System.Math.Min(4, bs.Length);
		for (int i = 0; i < count; i++)
		{
			uint b = bs[bs.Length - (i + 1)];
			result |= b << 8 * i;
		}
		return result;
	}

	private static void Hash(IDigest d, byte[] input, byte[] output, int outPos)
	{
		d.BlockUpdate(input, 0, input.Length);
		d.DoFinal(output, outPos);
	}

	private static BigInteger HashGen(IDigest d, byte[] seed, int count)
	{
		int dLen = d.GetDigestSize();
		int pos = count * dLen;
		byte[] buf = new byte[pos];
		for (int i = 0; i < count; i++)
		{
			pos -= dLen;
			Hash(d, seed, buf, pos);
			Inc(seed, 1);
		}
		return new BigInteger(1, buf);
	}

	private static void Inc(byte[] seed, int c)
	{
		int pos = seed.Length;
		while (c > 0 && --pos >= 0)
		{
			c += seed[pos];
			seed[pos] = (byte)c;
			c >>= 8;
		}
	}

	private static bool IsPrime32(uint x)
	{
		switch (x)
		{
		case 0u:
		case 1u:
		case 4u:
		case 5u:
			return x == 5;
		case 2u:
		case 3u:
			return true;
		default:
		{
			if ((x & 1) == 0 || x % 3 == 0 || x % 5 == 0)
			{
				return false;
			}
			uint[] ds = new uint[8] { 1u, 7u, 11u, 13u, 17u, 19u, 23u, 29u };
			uint b = 0u;
			int pos = 1;
			while (true)
			{
				if (pos < ds.Length)
				{
					uint d = b + ds[pos];
					if (x % d == 0)
					{
						return x < 30;
					}
					pos++;
				}
				else
				{
					b += 30;
					if (b >> 16 != 0 || b * b >= x)
					{
						break;
					}
					pos = 0;
				}
			}
			return true;
		}
		}
	}
}
