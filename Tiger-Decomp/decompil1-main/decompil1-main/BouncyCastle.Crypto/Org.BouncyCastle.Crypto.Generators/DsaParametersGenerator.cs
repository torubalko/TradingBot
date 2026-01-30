using System;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Crypto.Generators;

public class DsaParametersGenerator
{
	private IDigest digest;

	private int L;

	private int N;

	private int certainty;

	private SecureRandom random;

	private bool use186_3;

	private int usageIndex;

	public DsaParametersGenerator()
		: this(new Sha1Digest())
	{
	}

	public DsaParametersGenerator(IDigest digest)
	{
		this.digest = digest;
	}

	public virtual void Init(int size, int certainty, SecureRandom random)
	{
		if (!IsValidDsaStrength(size))
		{
			throw new ArgumentException("size must be from 512 - 1024 and a multiple of 64", "size");
		}
		use186_3 = false;
		L = size;
		N = GetDefaultN(size);
		this.certainty = certainty;
		this.random = random;
	}

	public virtual void Init(DsaParameterGenerationParameters parameters)
	{
		use186_3 = true;
		L = parameters.L;
		N = parameters.N;
		certainty = parameters.Certainty;
		random = parameters.Random;
		usageIndex = parameters.UsageIndex;
		if (L < 1024 || L > 3072 || L % 1024 != 0)
		{
			throw new ArgumentException("Values must be between 1024 and 3072 and a multiple of 1024", "L");
		}
		if (L == 1024 && N != 160)
		{
			throw new ArgumentException("N must be 160 for L = 1024");
		}
		if (L == 2048 && N != 224 && N != 256)
		{
			throw new ArgumentException("N must be 224 or 256 for L = 2048");
		}
		if (L == 3072 && N != 256)
		{
			throw new ArgumentException("N must be 256 for L = 3072");
		}
		if (digest.GetDigestSize() * 8 < N)
		{
			throw new InvalidOperationException("Digest output size too small for value of N");
		}
	}

	public virtual DsaParameters GenerateParameters()
	{
		if (!use186_3)
		{
			return GenerateParameters_FIPS186_2();
		}
		return GenerateParameters_FIPS186_3();
	}

	protected virtual DsaParameters GenerateParameters_FIPS186_2()
	{
		byte[] seed = new byte[20];
		byte[] part1 = new byte[20];
		byte[] part2 = new byte[20];
		byte[] u = new byte[20];
		int n = (L - 1) / 160;
		byte[] w = new byte[L / 8];
		if (!(digest is Sha1Digest))
		{
			throw new InvalidOperationException("can only use SHA-1 for generating FIPS 186-2 parameters");
		}
		while (true)
		{
			random.NextBytes(seed);
			Hash(digest, seed, part1);
			Array.Copy(seed, 0, part2, 0, seed.Length);
			Inc(part2);
			Hash(digest, part2, part2);
			for (int i = 0; i != u.Length; i++)
			{
				u[i] = (byte)(part1[i] ^ part2[i]);
			}
			u[0] |= 128;
			u[19] |= 1;
			BigInteger q = new BigInteger(1, u);
			if (!q.IsProbablePrime(certainty))
			{
				continue;
			}
			byte[] offset = Arrays.Clone(seed);
			Inc(offset);
			for (int counter = 0; counter < 4096; counter++)
			{
				for (int k = 0; k < n; k++)
				{
					Inc(offset);
					Hash(digest, offset, part1);
					Array.Copy(part1, 0, w, w.Length - (k + 1) * part1.Length, part1.Length);
				}
				Inc(offset);
				Hash(digest, offset, part1);
				Array.Copy(part1, part1.Length - (w.Length - n * part1.Length), w, 0, w.Length - n * part1.Length);
				w[0] |= 128;
				BigInteger bigInteger = new BigInteger(1, w);
				BigInteger c = bigInteger.Mod(q.ShiftLeft(1));
				BigInteger p = bigInteger.Subtract(c.Subtract(BigInteger.One));
				if (p.BitLength == L && p.IsProbablePrime(certainty))
				{
					BigInteger g = CalculateGenerator_FIPS186_2(p, q, random);
					return new DsaParameters(p, q, g, new DsaValidationParameters(seed, counter));
				}
			}
		}
	}

	protected virtual BigInteger CalculateGenerator_FIPS186_2(BigInteger p, BigInteger q, SecureRandom r)
	{
		BigInteger e = p.Subtract(BigInteger.One).Divide(q);
		BigInteger pSub2 = p.Subtract(BigInteger.Two);
		BigInteger g;
		do
		{
			g = BigIntegers.CreateRandomInRange(BigInteger.Two, pSub2, r).ModPow(e, p);
		}
		while (g.BitLength <= 1);
		return g;
	}

	protected virtual DsaParameters GenerateParameters_FIPS186_3()
	{
		IDigest d = digest;
		int outlen = d.GetDigestSize() * 8;
		byte[] seed = new byte[N / 8];
		int n = (L - 1) / outlen;
		int b = (L - 1) % outlen;
		byte[] output = new byte[d.GetDigestSize()];
		while (true)
		{
			random.NextBytes(seed);
			Hash(d, seed, output);
			BigInteger q = new BigInteger(1, output).Mod(BigInteger.One.ShiftLeft(N - 1)).SetBit(0).SetBit(N - 1);
			if (!q.IsProbablePrime(certainty))
			{
				continue;
			}
			byte[] offset = Arrays.Clone(seed);
			int counterLimit = 4 * L;
			for (int counter = 0; counter < counterLimit; counter++)
			{
				BigInteger W = BigInteger.Zero;
				int j = 0;
				int exp = 0;
				while (j <= n)
				{
					Inc(offset);
					Hash(d, offset, output);
					BigInteger Vj = new BigInteger(1, output);
					if (j == n)
					{
						Vj = Vj.Mod(BigInteger.One.ShiftLeft(b));
					}
					W = W.Add(Vj.ShiftLeft(exp));
					j++;
					exp += outlen;
				}
				BigInteger bigInteger = W.Add(BigInteger.One.ShiftLeft(L - 1));
				BigInteger c = bigInteger.Mod(q.ShiftLeft(1));
				BigInteger p = bigInteger.Subtract(c.Subtract(BigInteger.One));
				if (p.BitLength != L || !p.IsProbablePrime(certainty))
				{
					continue;
				}
				if (usageIndex >= 0)
				{
					BigInteger g = CalculateGenerator_FIPS186_3_Verifiable(d, p, q, seed, usageIndex);
					if (g != null)
					{
						return new DsaParameters(p, q, g, new DsaValidationParameters(seed, counter, usageIndex));
					}
				}
				BigInteger g2 = CalculateGenerator_FIPS186_3_Unverifiable(p, q, random);
				return new DsaParameters(p, q, g2, new DsaValidationParameters(seed, counter));
			}
		}
	}

	protected virtual BigInteger CalculateGenerator_FIPS186_3_Unverifiable(BigInteger p, BigInteger q, SecureRandom r)
	{
		return CalculateGenerator_FIPS186_2(p, q, r);
	}

	protected virtual BigInteger CalculateGenerator_FIPS186_3_Verifiable(IDigest d, BigInteger p, BigInteger q, byte[] seed, int index)
	{
		BigInteger e = p.Subtract(BigInteger.One).Divide(q);
		byte[] ggen = Hex.DecodeStrict("6767656E");
		byte[] U = new byte[seed.Length + ggen.Length + 1 + 2];
		Array.Copy(seed, 0, U, 0, seed.Length);
		Array.Copy(ggen, 0, U, seed.Length, ggen.Length);
		U[U.Length - 3] = (byte)index;
		byte[] w = new byte[d.GetDigestSize()];
		for (int count = 1; count < 65536; count++)
		{
			Inc(U);
			Hash(d, U, w);
			BigInteger g = new BigInteger(1, w).ModPow(e, p);
			if (g.CompareTo(BigInteger.Two) >= 0)
			{
				return g;
			}
		}
		return null;
	}

	private static bool IsValidDsaStrength(int strength)
	{
		if (strength >= 512 && strength <= 1024)
		{
			return strength % 64 == 0;
		}
		return false;
	}

	protected static void Hash(IDigest d, byte[] input, byte[] output)
	{
		d.BlockUpdate(input, 0, input.Length);
		d.DoFinal(output, 0);
	}

	private static int GetDefaultN(int L)
	{
		if (L <= 1024)
		{
			return 160;
		}
		return 256;
	}

	protected static void Inc(byte[] buf)
	{
		int i = buf.Length - 1;
		while (i >= 0 && ++buf[i] == 0)
		{
			i--;
		}
	}
}
