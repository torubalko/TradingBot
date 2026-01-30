using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Utilities;

public abstract class BigIntegers
{
	public static readonly BigInteger Zero = BigInteger.Zero;

	public static readonly BigInteger One = BigInteger.One;

	private const int MaxIterations = 1000;

	public static byte[] AsUnsignedByteArray(BigInteger n)
	{
		return n.ToByteArrayUnsigned();
	}

	public static byte[] AsUnsignedByteArray(int length, BigInteger n)
	{
		byte[] bytes = n.ToByteArrayUnsigned();
		if (bytes.Length > length)
		{
			throw new ArgumentException("standard length exceeded", "n");
		}
		if (bytes.Length == length)
		{
			return bytes;
		}
		byte[] tmp = new byte[length];
		Array.Copy(bytes, 0, tmp, tmp.Length - bytes.Length, bytes.Length);
		return tmp;
	}

	public static void AsUnsignedByteArray(BigInteger value, byte[] buf, int off, int len)
	{
		byte[] bytes = value.ToByteArrayUnsigned();
		if (bytes.Length == len)
		{
			Array.Copy(bytes, 0, buf, off, len);
			return;
		}
		int start = ((bytes[0] == 0) ? 1 : 0);
		int count = bytes.Length - start;
		if (count > len)
		{
			throw new ArgumentException("standard length exceeded for value");
		}
		int padLen = len - count;
		Arrays.Fill(buf, off, off + padLen, 0);
		Array.Copy(bytes, start, buf, off + padLen, count);
	}

	public static BigInteger CreateRandomBigInteger(int bitLength, SecureRandom secureRandom)
	{
		return new BigInteger(bitLength, secureRandom);
	}

	public static BigInteger CreateRandomInRange(BigInteger min, BigInteger max, SecureRandom random)
	{
		int cmp = min.CompareTo(max);
		if (cmp >= 0)
		{
			if (cmp > 0)
			{
				throw new ArgumentException("'min' may not be greater than 'max'");
			}
			return min;
		}
		if (min.BitLength > max.BitLength / 2)
		{
			return CreateRandomInRange(BigInteger.Zero, max.Subtract(min), random).Add(min);
		}
		for (int i = 0; i < 1000; i++)
		{
			BigInteger x = new BigInteger(max.BitLength, random);
			if (x.CompareTo(min) >= 0 && x.CompareTo(max) <= 0)
			{
				return x;
			}
		}
		return new BigInteger(max.Subtract(min).BitLength - 1, random).Add(min);
	}

	public static BigInteger ModOddInverse(BigInteger M, BigInteger X)
	{
		if (!M.TestBit(0))
		{
			throw new ArgumentException("must be odd", "M");
		}
		if (M.SignValue != 1)
		{
			throw new ArithmeticException("BigInteger: modulus not positive");
		}
		if (X.SignValue < 0 || X.CompareTo(M) >= 0)
		{
			X = X.Mod(M);
		}
		int bitLength = M.BitLength;
		uint[] m = Nat.FromBigInteger(bitLength, M);
		uint[] x = Nat.FromBigInteger(bitLength, X);
		int len = m.Length;
		uint[] z = Nat.Create(len);
		if (Mod.ModOddInverse(m, x, z) == 0)
		{
			throw new ArithmeticException("BigInteger not invertible");
		}
		return Nat.ToBigInteger(len, z);
	}

	public static BigInteger ModOddInverseVar(BigInteger M, BigInteger X)
	{
		if (!M.TestBit(0))
		{
			throw new ArgumentException("must be odd", "M");
		}
		if (M.SignValue != 1)
		{
			throw new ArithmeticException("BigInteger: modulus not positive");
		}
		if (M.Equals(One))
		{
			return Zero;
		}
		if (X.SignValue < 0 || X.CompareTo(M) >= 0)
		{
			X = X.Mod(M);
		}
		if (X.Equals(One))
		{
			return One;
		}
		int bitLength = M.BitLength;
		uint[] m = Nat.FromBigInteger(bitLength, M);
		uint[] x = Nat.FromBigInteger(bitLength, X);
		int len = m.Length;
		uint[] z = Nat.Create(len);
		if (!Mod.ModOddInverseVar(m, x, z))
		{
			throw new ArithmeticException("BigInteger not invertible");
		}
		return Nat.ToBigInteger(len, z);
	}

	public static int GetUnsignedByteLength(BigInteger n)
	{
		return (n.BitLength + 7) / 8;
	}
}
