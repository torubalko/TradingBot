using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP128R1Field
{
	internal static readonly uint[] P = new uint[4] { 4294967295u, 4294967295u, 4294967295u, 4294967293u };

	private static readonly uint[] PExt = new uint[8] { 1u, 0u, 0u, 4u, 4294967294u, 4294967295u, 3u, 4294967292u };

	private static readonly uint[] PExtInv = new uint[8] { 4294967295u, 4294967295u, 4294967295u, 4294967291u, 1u, 0u, 4294967292u, 3u };

	private const uint P3 = 4294967293u;

	private const uint PExt7 = 4294967292u;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat128.Add(x, y, z) != 0 || (z[3] >= 4294967293u && Nat128.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat256.Add(xx, yy, zz) != 0 || (zz[7] >= 4294967292u && Nat256.Gte(zz, PExt)))
		{
			Nat.AddTo(PExtInv.Length, PExtInv, zz);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(4, x, z) != 0 || (z[3] >= 4294967293u && Nat128.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(128, x);
		if (z[3] >= 4294967293u && Nat128.Gte(z, P))
		{
			Nat128.SubFrom(P, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(4, x, 0u, z);
			return;
		}
		uint c = Nat128.Add(x, P, z);
		Nat.ShiftDownBit(4, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 4; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat128.CreateExt();
		Nat128.Mul(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
		if (Nat128.MulAddTo(x, y, zz) != 0 || (zz[7] >= 4294967292u && Nat256.Gte(zz, PExt)))
		{
			Nat.AddTo(PExtInv.Length, PExtInv, zz);
		}
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat128.Sub(P, P, z);
		}
		else
		{
			Nat128.Sub(P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[16];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 4);
		}
		while (Nat.LessThan(4, z, P) == 0);
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
		ulong x0 = xx[0];
		ulong x1 = xx[1];
		ulong x2 = xx[2];
		ulong x3 = xx[3];
		ulong x4 = xx[4];
		ulong x5 = xx[5];
		ulong x6 = xx[6];
		ulong x7 = xx[7];
		x3 += x7;
		x6 += x7 << 1;
		x2 += x6;
		x5 += x6 << 1;
		x1 += x5;
		x4 += x5 << 1;
		x0 += x4;
		x3 += x4 << 1;
		z[0] = (uint)x0;
		x1 += x0 >> 32;
		z[1] = (uint)x1;
		x2 += x1 >> 32;
		z[2] = (uint)x2;
		x3 += x2 >> 32;
		z[3] = (uint)x3;
		Reduce32((uint)(x3 >> 32), z);
	}

	public static void Reduce32(uint x, uint[] z)
	{
		while (x != 0)
		{
			ulong x4 = x;
			ulong c = z[0] + x4;
			z[0] = (uint)c;
			c >>= 32;
			if (c != 0L)
			{
				c += z[1];
				z[1] = (uint)c;
				c >>= 32;
				c += z[2];
				z[2] = (uint)c;
				c >>= 32;
			}
			c += z[3] + (x4 << 1);
			z[3] = (uint)c;
			c >>= 32;
			x = (uint)c;
		}
		if (z[3] >= 4294967293u && Nat128.Gte(z, P))
		{
			AddPInvTo(z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat128.CreateExt();
		Nat128.Square(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat128.CreateExt();
		Nat128.Square(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			Nat128.Square(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat128.Sub(x, y, z) != 0)
		{
			SubPInvFrom(z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(10, xx, yy, zz) != 0)
		{
			Nat.SubFrom(PExtInv.Length, PExtInv, zz);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(4, x, 0u, z) != 0 || (z[3] >= 4294967293u && Nat128.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	private static void AddPInvTo(uint[] z)
	{
		long c = (long)z[0] + 1L;
		z[0] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[1];
			z[1] = (uint)c;
			c >>= 32;
			c += z[2];
			z[2] = (uint)c;
			c >>= 32;
		}
		c += (long)z[3] + 2L;
		z[3] = (uint)c;
	}

	private static void SubPInvFrom(uint[] z)
	{
		long c = (long)z[0] - 1L;
		z[0] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[1];
			z[1] = (uint)c;
			c >>= 32;
			c += z[2];
			z[2] = (uint)c;
			c >>= 32;
		}
		c += (long)z[3] - 2L;
		z[3] = (uint)c;
	}
}
