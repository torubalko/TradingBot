using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP384R1Field
{
	internal static readonly uint[] P = new uint[12]
	{
		4294967295u, 0u, 0u, 4294967295u, 4294967294u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u
	};

	private static readonly uint[] PExt = new uint[24]
	{
		1u, 4294967294u, 0u, 2u, 0u, 4294967294u, 0u, 2u, 1u, 0u,
		0u, 0u, 4294967294u, 1u, 0u, 4294967294u, 4294967293u, 4294967295u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 4294967295u
	};

	private static readonly uint[] PExtInv = new uint[17]
	{
		4294967295u, 1u, 4294967295u, 4294967293u, 4294967295u, 1u, 4294967295u, 4294967293u, 4294967294u, 4294967295u,
		4294967295u, 4294967295u, 1u, 4294967294u, 4294967295u, 1u, 2u
	};

	private const uint P11 = uint.MaxValue;

	private const uint PExt23 = uint.MaxValue;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat.Add(12, x, y, z) != 0 || (z[11] == uint.MaxValue && Nat.Gte(12, z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if ((Nat.Add(24, xx, yy, zz) != 0 || (zz[23] == uint.MaxValue && Nat.Gte(24, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(24, zz, PExtInv.Length);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(12, x, z) != 0 || (z[11] == uint.MaxValue && Nat.Gte(12, z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(384, x);
		if (z[11] == uint.MaxValue && Nat.Gte(12, z, P))
		{
			Nat.SubFrom(12, P, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(12, x, 0u, z);
			return;
		}
		uint c = Nat.Add(12, x, P, z);
		Nat.ShiftDownBit(12, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 12; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat.Create(24);
		Nat384.Mul(x, y, tt);
		Reduce(tt, z);
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat.Sub(12, P, P, z);
		}
		else
		{
			Nat.Sub(12, P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[48];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 12);
		}
		while (Nat.LessThan(12, z, P) == 0);
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
		long xx16 = xx[16];
		long xx17 = xx[17];
		long xx18 = xx[18];
		long xx19 = xx[19];
		long xx20 = xx[20];
		long xx21 = xx[21];
		long xx22 = xx[22];
		long xx23 = xx[23];
		long t0 = xx[12] + xx20 - 1;
		long t1 = xx[13] + xx22;
		long t2 = xx[14] + xx22 + xx23;
		long t3 = xx[15] + xx23;
		long t4 = xx17 + xx21;
		long t5 = xx21 - xx23;
		long t6 = xx22 - xx23;
		long t7 = t0 + t5;
		long cc = 0L;
		cc += xx[0] + t7;
		z[0] = (uint)cc;
		cc >>= 32;
		cc += xx[1] + xx23 - t0 + t1;
		z[1] = (uint)cc;
		cc >>= 32;
		cc += xx[2] - xx21 - t1 + t2;
		z[2] = (uint)cc;
		cc >>= 32;
		cc += xx[3] - t2 + t3 + t7;
		z[3] = (uint)cc;
		cc >>= 32;
		cc += xx[4] + xx16 + xx21 + t1 - t3 + t7;
		z[4] = (uint)cc;
		cc >>= 32;
		cc += xx[5] - xx16 + t1 + t2 + t4;
		z[5] = (uint)cc;
		cc >>= 32;
		cc += xx[6] + xx18 - xx17 + t2 + t3;
		z[6] = (uint)cc;
		cc >>= 32;
		cc += xx[7] + xx16 + xx19 - xx18 + t3;
		z[7] = (uint)cc;
		cc >>= 32;
		cc += xx[8] + xx16 + xx17 + xx20 - xx19;
		z[8] = (uint)cc;
		cc >>= 32;
		cc += xx[9] + xx18 - xx20 + t4;
		z[9] = (uint)cc;
		cc >>= 32;
		cc += xx[10] + xx18 + xx19 - t5 + t6;
		z[10] = (uint)cc;
		cc >>= 32;
		cc += xx[11] + xx19 + xx20 - t6;
		z[11] = (uint)cc;
		cc >>= 32;
		cc++;
		Reduce32((uint)cc, z);
	}

	public static void Reduce32(uint x, uint[] z)
	{
		long cc = 0L;
		if (x != 0)
		{
			long xx12 = x;
			cc += z[0] + xx12;
			z[0] = (uint)cc;
			cc >>= 32;
			cc += z[1] - xx12;
			z[1] = (uint)cc;
			cc >>= 32;
			if (cc != 0L)
			{
				cc += z[2];
				z[2] = (uint)cc;
				cc >>= 32;
			}
			cc += z[3] + xx12;
			z[3] = (uint)cc;
			cc >>= 32;
			cc += z[4] + xx12;
			z[4] = (uint)cc;
			cc >>= 32;
		}
		if ((cc != 0L && Nat.IncAt(12, z, 5) != 0) || (z[11] == uint.MaxValue && Nat.Gte(12, z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat.Create(24);
		Nat384.Square(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat.Create(24);
		Nat384.Square(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			Nat384.Square(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat.Sub(12, x, y, z) != 0)
		{
			SubPInvFrom(z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(24, xx, yy, zz) != 0 && Nat.SubFrom(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.DecAt(24, zz, PExtInv.Length);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(12, x, 0u, z) != 0 || (z[11] == uint.MaxValue && Nat.Gte(12, z, P)))
		{
			AddPInvTo(z);
		}
	}

	private static void AddPInvTo(uint[] z)
	{
		long c = (long)z[0] + 1L;
		z[0] = (uint)c;
		c >>= 32;
		c += (long)z[1] - 1L;
		z[1] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[2];
			z[2] = (uint)c;
			c >>= 32;
		}
		c += (long)z[3] + 1L;
		z[3] = (uint)c;
		c >>= 32;
		c += (long)z[4] + 1L;
		z[4] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			Nat.IncAt(12, z, 5);
		}
	}

	private static void SubPInvFrom(uint[] z)
	{
		long c = (long)z[0] - 1L;
		z[0] = (uint)c;
		c >>= 32;
		c += (long)z[1] + 1L;
		z[1] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			c += z[2];
			z[2] = (uint)c;
			c >>= 32;
		}
		c += (long)z[3] - 1L;
		z[3] = (uint)c;
		c >>= 32;
		c += (long)z[4] - 1L;
		z[4] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			Nat.DecAt(12, z, 5);
		}
	}
}
