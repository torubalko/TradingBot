using System;
using System.Threading;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Security;

public class SecureRandom : Random
{
	private static long counter = Times.NanoTime();

	private static readonly SecureRandom master = new SecureRandom(new CryptoApiRandomGenerator());

	protected readonly IRandomGenerator generator;

	private static readonly double DoubleScale = 1.0 / Convert.ToDouble(9007199254740992L);

	private static SecureRandom Master => master;

	private static long NextCounterValue()
	{
		return Interlocked.Increment(ref counter);
	}

	private static DigestRandomGenerator CreatePrng(string digestName, bool autoSeed)
	{
		IDigest digest = DigestUtilities.GetDigest(digestName);
		if (digest == null)
		{
			return null;
		}
		DigestRandomGenerator prng = new DigestRandomGenerator(digest);
		if (autoSeed)
		{
			prng.AddSeedMaterial(NextCounterValue());
			prng.AddSeedMaterial(GetNextBytes(Master, digest.GetDigestSize()));
		}
		return prng;
	}

	public static byte[] GetNextBytes(SecureRandom secureRandom, int length)
	{
		byte[] result = new byte[length];
		secureRandom.NextBytes(result);
		return result;
	}

	public static SecureRandom GetInstance(string algorithm)
	{
		return GetInstance(algorithm, autoSeed: true);
	}

	public static SecureRandom GetInstance(string algorithm, bool autoSeed)
	{
		string upper = Platform.ToUpperInvariant(algorithm);
		if (Platform.EndsWith(upper, "PRNG"))
		{
			DigestRandomGenerator prng = CreatePrng(upper.Substring(0, upper.Length - "PRNG".Length), autoSeed);
			if (prng != null)
			{
				return new SecureRandom(prng);
			}
		}
		throw new ArgumentException("Unrecognised PRNG algorithm: " + algorithm, "algorithm");
	}

	[Obsolete("Call GenerateSeed() on a SecureRandom instance instead")]
	public static byte[] GetSeed(int length)
	{
		return GetNextBytes(Master, length);
	}

	public SecureRandom()
		: this(CreatePrng("SHA256", autoSeed: true))
	{
	}

	[Obsolete("Use GetInstance/SetSeed instead")]
	public SecureRandom(byte[] seed)
		: this(CreatePrng("SHA1", autoSeed: false))
	{
		SetSeed(seed);
	}

	public SecureRandom(IRandomGenerator generator)
		: base(0)
	{
		this.generator = generator;
	}

	public virtual byte[] GenerateSeed(int length)
	{
		return GetNextBytes(Master, length);
	}

	public virtual void SetSeed(byte[] seed)
	{
		generator.AddSeedMaterial(seed);
	}

	public virtual void SetSeed(long seed)
	{
		generator.AddSeedMaterial(seed);
	}

	public override int Next()
	{
		return NextInt() & 0x7FFFFFFF;
	}

	public override int Next(int maxValue)
	{
		if (maxValue < 2)
		{
			if (maxValue < 0)
			{
				throw new ArgumentOutOfRangeException("maxValue", "cannot be negative");
			}
			return 0;
		}
		int bits;
		if ((maxValue & (maxValue - 1)) == 0)
		{
			bits = NextInt() & 0x7FFFFFFF;
			return (int)((long)bits * (long)maxValue >> 31);
		}
		int result;
		do
		{
			bits = NextInt() & 0x7FFFFFFF;
			result = bits % maxValue;
		}
		while (bits - result + (maxValue - 1) < 0);
		return result;
	}

	public override int Next(int minValue, int maxValue)
	{
		if (maxValue <= minValue)
		{
			if (maxValue == minValue)
			{
				return minValue;
			}
			throw new ArgumentException("maxValue cannot be less than minValue");
		}
		int diff = maxValue - minValue;
		if (diff > 0)
		{
			return minValue + Next(diff);
		}
		int i;
		do
		{
			i = NextInt();
		}
		while (i < minValue || i >= maxValue);
		return i;
	}

	public override void NextBytes(byte[] buf)
	{
		generator.NextBytes(buf);
	}

	public virtual void NextBytes(byte[] buf, int off, int len)
	{
		generator.NextBytes(buf, off, len);
	}

	public override double NextDouble()
	{
		return Convert.ToDouble((ulong)NextLong() >> 11) * DoubleScale;
	}

	public virtual int NextInt()
	{
		byte[] bytes = new byte[4];
		NextBytes(bytes);
		return (int)Pack.BE_To_UInt32(bytes, 0);
	}

	public virtual long NextLong()
	{
		byte[] bytes = new byte[8];
		NextBytes(bytes);
		return (long)Pack.BE_To_UInt64(bytes, 0);
	}
}
