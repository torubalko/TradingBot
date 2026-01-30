using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP256R1Field
{
	internal static readonly uint[] P = new uint[8] { 4294967295u, 4294967295u, 4294967295u, 0u, 0u, 0u, 1u, 4294967295u };

	private static readonly uint[] PExt = new uint[16]
	{
		1u, 0u, 0u, 4294967294u, 4294967295u, 4294967295u, 4294967294u, 1u, 4294967294u, 1u,
		4294967294u, 1u, 1u, 4294967294u, 2u, 4294967294u
	};

	private const uint P7 = uint.MaxValue;

	private const uint PExt15 = 4294967294u;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat256.Add(x, y, z) != 0 || (z[7] == uint.MaxValue && Nat256.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Add(16, xx, yy, zz) != 0 || (zz[15] >= 4294967294u && Nat.Gte(16, zz, PExt)))
		{
			Nat.SubFrom(16, PExt, zz);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(8, x, z) != 0 || (z[7] == uint.MaxValue && Nat256.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(256, x);
		if (z[7] == uint.MaxValue && Nat256.Gte(z, P))
		{
			Nat256.SubFrom(P, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(8, x, 0u, z);
			return;
		}
		uint c = Nat256.Add(x, P, z);
		Nat.ShiftDownBit(8, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 8; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat256.CreateExt();
		Nat256.Mul(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
		if (Nat256.MulAddTo(x, y, zz) != 0 || (zz[15] >= 4294967294u && Nat.Gte(16, zz, PExt)))
		{
			Nat.SubFrom(16, PExt, zz);
		}
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat256.Sub(P, P, z);
		}
		else
		{
			Nat256.Sub(P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[32];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 8);
		}
		while (Nat.LessThan(8, z, P) == 0);
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
		long xx8 = xx[8];
		long xx9 = xx[9];
		long xx10 = xx[10];
		long xx11 = xx[11];
		long xx12 = xx[12];
		long xx13 = xx[13];
		long xx14 = xx[14];
		long xx15 = xx[15];
		xx8 -= 6;
		long t0 = xx8 + xx9;
		long t1 = xx9 + xx10;
		long t2 = xx10 + xx11 - xx15;
		long t3 = xx11 + xx12;
		long t4 = xx12 + xx13;
		long t5 = xx13 + xx14;
		long t6 = xx14 + xx15;
		long t7 = t5 - t0;
		long cc = 0L;
		cc += xx[0] - t3 - t7;
		z[0] = (uint)cc;
		cc >>= 32;
		cc += xx[1] + t1 - t4 - t6;
		z[1] = (uint)cc;
		cc >>= 32;
		cc += xx[2] + t2 - t5;
		z[2] = (uint)cc;
		cc >>= 32;
		cc += xx[3] + (t3 << 1) + t7 - t6;
		z[3] = (uint)cc;
		cc >>= 32;
		cc += xx[4] + (t4 << 1) + xx14 - t1;
		z[4] = (uint)cc;
		cc >>= 32;
		cc += xx[5] + (t5 << 1) - t2;
		z[5] = (uint)cc;
		cc >>= 32;
		cc += xx[6] + (t6 << 1) + t7;
		z[6] = (uint)cc;
		cc >>= 32;
		cc += xx[7] + (xx15 << 1) + xx8 - t2 - t4;
		z[7] = (uint)cc;
		cc >>= 32;
		cc += 6;
		Reduce32((uint)cc, z);
	}

	public static void Reduce32(uint x, uint[] z)
	{
		long cc = 0L;
		if (x != 0)
		{
			long xx08 = x;
			cc += z[0] + xx08;
			z[0] = (uint)cc;
			cc >>= 32;
			if (cc != 0L)
			{
				cc += z[1];
				z[1] = (uint)cc;
				cc >>= 32;
				cc += z[2];
				z[2] = (uint)cc;
				cc >>= 32;
			}
			cc += z[3] - xx08;
			z[3] = (uint)cc;
			cc >>= 32;
			if (cc != 0L)
			{
				cc += z[4];
				z[4] = (uint)cc;
				cc >>= 32;
				cc += z[5];
				z[5] = (uint)cc;
				cc >>= 32;
			}
			cc += z[6] - xx08;
			z[6] = (uint)cc;
			cc >>= 32;
			cc += z[7] + xx08;
			z[7] = (uint)cc;
			cc >>= 32;
		}
		if (cc != 0L || (z[7] == uint.MaxValue && Nat256.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat256.CreateExt();
		Nat256.Square(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat256.CreateExt();
		Nat256.Square(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			Nat256.Square(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat256.Sub(x, y, z) != 0)
		{
			SubPInvFrom(z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(16, xx, yy, zz) != 0)
		{
			Nat.AddTo(16, PExt, zz);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(8, x, 0u, z) != 0 || (z[7] == uint.MaxValue && Nat256.Gte(z, P)))
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
		c += (long)z[3] - 1L;
		z[3] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[4];
			z[4] = (uint)c;
			c >>= 32;
			c += z[5];
			z[5] = (uint)c;
			c >>= 32;
		}
		c += (long)z[6] - 1L;
		z[6] = (uint)c;
		c >>= 32;
		c += (long)z[7] + 1L;
		z[7] = (uint)c;
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
		c += (long)z[3] + 1L;
		z[3] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[4];
			z[4] = (uint)c;
			c >>= 32;
			c += z[5];
			z[5] = (uint)c;
			c >>= 32;
		}
		c += (long)z[6] + 1L;
		z[6] = (uint)c;
		c >>= 32;
		c += (long)z[7] - 1L;
		z[7] = (uint)c;
	}
}
