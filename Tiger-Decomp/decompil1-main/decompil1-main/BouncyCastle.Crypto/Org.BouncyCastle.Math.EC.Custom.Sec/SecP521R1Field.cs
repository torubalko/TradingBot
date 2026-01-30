using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP521R1Field
{
	internal static readonly uint[] P = new uint[17]
	{
		4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 511u
	};

	private const uint P16 = 511u;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		uint c = Nat.Add(16, x, y, z) + x[16] + y[16];
		if (c > 511 || (c == 511 && Nat.Eq(16, z, P)))
		{
			c += Nat.Inc(16, z);
			c &= 0x1FF;
		}
		z[16] = c;
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		uint c = Nat.Inc(16, x, z) + x[16];
		if (c > 511 || (c == 511 && Nat.Eq(16, z, P)))
		{
			c += Nat.Inc(16, z);
			c &= 0x1FF;
		}
		z[16] = c;
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(521, x);
		if (Nat.Eq(17, z, P))
		{
			Nat.Zero(17, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		uint x16 = x[16];
		uint c = Nat.ShiftDownBit(16, x, x16, z);
		z[16] = (x16 >> 1) | (c >> 23);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 17; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat.Create(33);
		ImplMultiply(x, y, tt);
		Reduce(tt, z);
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat.Sub(17, P, P, z);
		}
		else
		{
			Nat.Sub(17, P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[68];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 17);
			z[16] &= 511u;
		}
		while (Nat.LessThan(17, z, P) == 0);
	}

	public static void RandomMult(SecureRandom r, uint[] z)
	{
		do
		{
			Random(r, z);
		}
		while (IsZero(z) != 0);
	}

	public static void Reduce(uint[] xx, uint[] z)
	{
		uint xx32 = xx[32];
		uint c = Nat.ShiftDownBits(16, xx, 16, 9, xx32, z, 0) >> 23;
		c += xx32 >> 9;
		c += Nat.AddTo(16, xx, z);
		if (c > 511 || (c == 511 && Nat.Eq(16, z, P)))
		{
			c += Nat.Inc(16, z);
			c &= 0x1FF;
		}
		z[16] = c;
	}

	public static void Reduce23(uint[] z)
	{
		uint z16 = z[16];
		uint c = Nat.AddWordTo(16, z16 >> 9, z) + (z16 & 0x1FF);
		if (c > 511 || (c == 511 && Nat.Eq(16, z, P)))
		{
			c += Nat.Inc(16, z);
			c &= 0x1FF;
		}
		z[16] = c;
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat.Create(33);
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat.Create(33);
		ImplSquare(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			ImplSquare(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		int c = Nat.Sub(16, x, y, z) + (int)(x[16] - y[16]);
		if (c < 0)
		{
			c += Nat.Dec(16, z);
			c &= 0x1FF;
		}
		z[16] = (uint)c;
	}

	public static void Twice(uint[] x, uint[] z)
	{
		uint x16 = x[16];
		uint c = Nat.ShiftUpBit(16, x, x16 << 23, z) | (x16 << 1);
		z[16] = c & 0x1FF;
	}

	protected static void ImplMultiply(uint[] x, uint[] y, uint[] zz)
	{
		Nat512.Mul(x, y, zz);
		uint x16 = x[16];
		uint y16 = y[16];
		zz[32] = Nat.Mul31BothAdd(16, x16, y, y16, x, zz, 16) + x16 * y16;
	}

	protected static void ImplSquare(uint[] x, uint[] zz)
	{
		Nat512.Square(x, zz);
		uint x16 = x[16];
		zz[32] = Nat.MulWordAddTo(16, x16 << 1, x, 0, zz, 16) + x16 * x16;
	}
}
