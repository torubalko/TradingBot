using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecP192R1Field
{
	internal static readonly uint[] P = new uint[6] { 4294967295u, 4294967295u, 4294967294u, 4294967295u, 4294967295u, 4294967295u };

	private static readonly uint[] PExt = new uint[12]
	{
		1u, 0u, 2u, 0u, 1u, 0u, 4294967294u, 4294967295u, 4294967293u, 4294967295u,
		4294967295u, 4294967295u
	};

	private static readonly uint[] PExtInv = new uint[9] { 4294967295u, 4294967295u, 4294967293u, 4294967295u, 4294967294u, 4294967295u, 1u, 0u, 2u };

	private const uint P5 = uint.MaxValue;

	private const uint PExt11 = uint.MaxValue;

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		if (Nat192.Add(x, y, z) != 0 || (z[5] == uint.MaxValue && Nat192.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void AddExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if ((Nat.Add(12, xx, yy, zz) != 0 || (zz[11] == uint.MaxValue && Nat.Gte(12, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(12, zz, PExtInv.Length);
		}
	}

	public static void AddOne(uint[] x, uint[] z)
	{
		if (Nat.Inc(6, x, z) != 0 || (z[5] == uint.MaxValue && Nat192.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static uint[] FromBigInteger(BigInteger x)
	{
		uint[] z = Nat.FromBigInteger(192, x);
		if (z[5] == uint.MaxValue && Nat192.Gte(z, P))
		{
			Nat192.SubFrom(P, z);
		}
		return z;
	}

	public static void Half(uint[] x, uint[] z)
	{
		if ((x[0] & 1) == 0)
		{
			Nat.ShiftDownBit(6, x, 0u, z);
			return;
		}
		uint c = Nat192.Add(x, P, z);
		Nat.ShiftDownBit(6, z, c);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		Mod.CheckedModOddInverse(P, x, z);
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 6; i++)
		{
			d |= x[i];
		}
		d = (d >> 1) | (d & 1);
		return (int)(d - 1) >> 31;
	}

	public static void Multiply(uint[] x, uint[] y, uint[] z)
	{
		uint[] tt = Nat192.CreateExt();
		Nat192.Mul(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(uint[] x, uint[] y, uint[] zz)
	{
		if ((Nat192.MulAddTo(x, y, zz) != 0 || (zz[11] == uint.MaxValue && Nat.Gte(12, zz, PExt))) && Nat.AddTo(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.IncAt(12, zz, PExtInv.Length);
		}
	}

	public static void Negate(uint[] x, uint[] z)
	{
		if (IsZero(x) != 0)
		{
			Nat192.Sub(P, P, z);
		}
		else
		{
			Nat192.Sub(P, x, z);
		}
	}

	public static void Random(SecureRandom r, uint[] z)
	{
		byte[] bb = new byte[24];
		do
		{
			r.NextBytes(bb);
			Pack.LE_To_UInt32(bb, 0, z, 0, 6);
		}
		while (Nat.LessThan(6, z, P) == 0);
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
		ulong xx6 = xx[6];
		ulong xx7 = xx[7];
		ulong xx8 = xx[8];
		ulong xx9 = xx[9];
		ulong xx10 = xx[10];
		ulong xx11 = xx[11];
		ulong t0 = xx6 + xx10;
		ulong t1 = xx7 + xx11;
		ulong cc = 0uL;
		cc += xx[0] + t0;
		uint z2 = (uint)cc;
		cc >>= 32;
		cc += xx[1] + t1;
		z[1] = (uint)cc;
		cc >>= 32;
		t0 += xx8;
		t1 += xx9;
		cc += xx[2] + t0;
		ulong z3 = (uint)cc;
		cc >>= 32;
		cc += xx[3] + t1;
		z[3] = (uint)cc;
		cc >>= 32;
		t0 -= xx6;
		t1 -= xx7;
		cc += xx[4] + t0;
		z[4] = (uint)cc;
		cc >>= 32;
		cc += xx[5] + t1;
		z[5] = (uint)cc;
		cc >>= 32;
		z3 += cc;
		cc += z2;
		z[0] = (uint)cc;
		cc >>= 32;
		if (cc != 0L)
		{
			cc += z[1];
			z[1] = (uint)cc;
			z3 += cc >> 32;
		}
		z[2] = (uint)z3;
		cc = z3 >> 32;
		if ((cc != 0L && Nat.IncAt(6, z, 3) != 0) || (z[5] == uint.MaxValue && Nat192.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Reduce32(uint x, uint[] z)
	{
		ulong cc = 0uL;
		if (x != 0)
		{
			cc += (ulong)((long)z[0] + (long)x);
			z[0] = (uint)cc;
			cc >>= 32;
			if (cc != 0L)
			{
				cc += z[1];
				z[1] = (uint)cc;
				cc >>= 32;
			}
			cc += (ulong)((long)z[2] + (long)x);
			z[2] = (uint)cc;
			cc >>= 32;
		}
		if ((cc != 0L && Nat.IncAt(6, z, 3) != 0) || (z[5] == uint.MaxValue && Nat192.Gte(z, P)))
		{
			AddPInvTo(z);
		}
	}

	public static void Square(uint[] x, uint[] z)
	{
		uint[] tt = Nat192.CreateExt();
		Nat192.Square(x, tt);
		Reduce(tt, z);
	}

	public static void SquareN(uint[] x, int n, uint[] z)
	{
		uint[] tt = Nat192.CreateExt();
		Nat192.Square(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			Nat192.Square(z, tt);
			Reduce(tt, z);
		}
	}

	public static void Subtract(uint[] x, uint[] y, uint[] z)
	{
		if (Nat192.Sub(x, y, z) != 0)
		{
			SubPInvFrom(z);
		}
	}

	public static void SubtractExt(uint[] xx, uint[] yy, uint[] zz)
	{
		if (Nat.Sub(12, xx, yy, zz) != 0 && Nat.SubFrom(PExtInv.Length, PExtInv, zz) != 0)
		{
			Nat.DecAt(12, zz, PExtInv.Length);
		}
	}

	public static void Twice(uint[] x, uint[] z)
	{
		if (Nat.ShiftUpBit(6, x, 0u, z) != 0 || (z[5] == uint.MaxValue && Nat192.Gte(z, P)))
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
		}
		c += (long)z[2] + 1L;
		z[2] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			Nat.IncAt(6, z, 3);
		}
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
		}
		c += (long)z[2] - 1L;
		z[2] = (uint)c;
		c >>= 32;
		if (c != 0L)
		{
			Nat.DecAt(6, z, 3);
		}
	}
}
