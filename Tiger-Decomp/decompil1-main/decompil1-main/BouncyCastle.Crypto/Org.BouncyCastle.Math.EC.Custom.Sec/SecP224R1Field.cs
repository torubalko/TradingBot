using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP224R1Field
{
	internal static readonly uint[] P = new uint[7] { 1u, 0u, 0u, 4294967295u, 4294967295u, 4294967295u, 4294967295u };

	private static readonly uint[] PExt = new uint[14]
	{
		1u, 0u, 0u, 4294967294u, 4294967295u, 4294967295u, 0u, 2u, 0u, 0u,
		4294967294u, 4294967295u, 4294967295u, 4294967295u
	};

	private static readonly uint[] PExtInv = new uint[11]
	{
		4294967295u, 4294967295u, 4294967295u, 1u, 0u, 0u, 4294967295u, 4294967293u, 4294967295u, 4294967295u,
		1u
	};

	private const uint P6 = uint.MaxValue;

	private const uint PExt13 = uint.MaxValue;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat224.Add(x, y, z) != 0 || (z[6] == uint.MaxValue && Nat224.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if ((Nat.Add(14, xx, yy, zz) != 0 || (zz[13] == uint.MaxValue && Nat.Gte(14, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(14, zz, PExtInv.Length);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(7, x, z) != 0 || (z[6] == uint.MaxValue && Nat224.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(224, x);
		if (z[6] == uint.MaxValue && Nat224.Gte(z, P))
		{
			Nat224.SubFrom(P, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(7, x, 0u, z);
			return;
		}
		uint c = Nat224.Add(x, P, z);
		Nat.ShiftDownBit(7, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 7; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat224.CreateExt();
		Nat224.Mul(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
		if ((Nat224.MulAddTo(x, y, zz) != 0 || (zz[13] == uint.MaxValue && Nat.Gte(14, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(14, zz, PExtInv.Length);
		}
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat224.Sub(P, P, z);
		}
		else
		{
			Nat224.Sub(P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[28];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 7);
		}
		while (Nat.LessThan(7, z, P) == 0);
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
		long xx10 = xx[10];
		long xx11 = xx[11];
		long xx12 = xx[12];
		long xx13 = xx[13];
		long t0 = xx[7] + xx11 - 1;
		long t1 = xx[8] + xx12;
		long t2 = xx[9] + xx13;
		long cc = 0L;
		cc += xx[0] - t0;
		long z2 = (uint)cc;
		cc >>= 32;
		cc += xx[1] - t1;
		z[1] = (uint)cc;
		cc >>= 32;
		cc += xx[2] - t2;
		z[2] = (uint)cc;
		cc >>= 32;
		cc += xx[3] + t0 - xx10;
		long z3 = (uint)cc;
		cc >>= 32;
		cc += xx[4] + t1 - xx11;
		z[4] = (uint)cc;
		cc >>= 32;
		cc += xx[5] + t2 - xx12;
		z[5] = (uint)cc;
		cc >>= 32;
		cc += xx[6] + xx10 - xx13;
		z[6] = (uint)cc;
		cc >>= 32;
		cc++;
		z3 += cc;
		z2 -= cc;
		z[0] = (uint)z2;
		cc = z2 >> 32;
		if (cc != 0L)
		{
			cc += z[1];
			z[1] = (uint)cc;
			cc >>= 32;
			cc += z[2];
			z[2] = (uint)cc;
			z3 += cc >> 32;
		}
		z[3] = (uint)z3;
		cc = z3 >> 32;
		if ((cc != 0L && Nat.IncAt(7, z, 4) != 0) || (z[6] == uint.MaxValue && Nat224.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Reduce32(uint x, uint[] z)
	{
		long cc = 0L;
		if (x != 0)
		{
			long xx07 = x;
			cc += z[0] - xx07;
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
			cc += z[3] + xx07;
			z[3] = (uint)cc;
			cc >>= 32;
		}
		if ((cc != 0L && Nat.IncAt(7, z, 4) != 0) || (z[6] == uint.MaxValue && Nat224.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat224.CreateExt();
		Nat224.Square(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat224.CreateExt();
		Nat224.Square(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			Nat224.Square(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat224.Sub(x, y, z) != 0)
		{
			SubPInvFrom(z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(14, xx, yy, zz) != 0 && Nat.SubFrom(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.DecAt(14, zz, PExtInv.Length);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(7, x, 0u, z) != 0 || (z[6] == uint.MaxValue && Nat224.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	private static void AddPInvTo(uint[] z)
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
			Nat.IncAt(7, z, 4);
		}
	}

	private static void SubPInvFrom(uint[] z)
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
			Nat.DecAt(7, z, 4);
		}
	}
}
