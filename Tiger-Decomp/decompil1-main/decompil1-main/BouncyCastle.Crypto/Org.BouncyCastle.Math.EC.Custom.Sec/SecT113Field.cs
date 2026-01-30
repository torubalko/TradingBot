using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT113Field
{
	private const ulong M49 = 562949953421311uL;

	private const ulong M57 = 144115188075855871uL;

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
		zz[0] = xx[0] ^ yy[0];
		zz[1] = xx[1] ^ yy[1];
		zz[2] = xx[2] ^ yy[2];
		zz[3] = xx[3] ^ yy[3];
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
		z[0] = x[0] ^ 1;
		z[1] = x[1];
	}

	private static void AddTo(ulong[] x, ulong[] z)
	{
		z[0] ^= x[0];
		z[1] ^= x[1];
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return Nat.FromBigInteger64(113, x);
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat128.CreateExt64();
		Nat128.Copy64(x, z);
		for (int i = 1; i < 113; i += 2)
		{
			ImplSquare(z, tt);
			Reduce(tt, z);
			ImplSquare(z, tt);
			Reduce(tt, z);
			AddTo(x, z);
		}
	}

	public static void Invert(ulong[] x, ulong[] z)
	{
		if (Nat128.IsZero64(x))
		{
			throw new InvalidOperationException();
		}
		ulong[] t0 = Nat128.Create64();
		ulong[] t1 = Nat128.Create64();
		Square(x, t0);
		Multiply(t0, x, t0);
		Square(t0, t0);
		Multiply(t0, x, t0);
		SquareN(t0, 3, t1);
		Multiply(t1, t0, t1);
		Square(t1, t1);
		Multiply(t1, x, t1);
		SquareN(t1, 7, t0);
		Multiply(t0, t1, t0);
		SquareN(t0, 14, t1);
		Multiply(t1, t0, t1);
		SquareN(t1, 28, t0);
		Multiply(t0, t1, t0);
		SquareN(t0, 56, t1);
		Multiply(t1, t0, t1);
		Square(t1, z);
	}

	public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
		ulong[] tt = new ulong[8];
		ImplMultiply(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] tt = new ulong[8];
		ImplMultiply(x, y, tt);
		AddExt(zz, tt, zz);
	}

	public static void Reduce(ulong[] xx, ulong[] z)
	{
		ulong x0 = xx[0];
		ulong x1 = xx[1];
		ulong x2 = xx[2];
		ulong x3 = xx[3];
		x1 ^= (x3 << 15) ^ (x3 << 24);
		x2 ^= (x3 >> 49) ^ (x3 >> 40);
		x0 ^= (x2 << 15) ^ (x2 << 24);
		x1 ^= (x2 >> 49) ^ (x2 >> 40);
		ulong t = x1 >> 49;
		z[0] = x0 ^ t ^ (t << 9);
		z[1] = x1 & 0x1FFFFFFFFFFFFL;
	}

	public static void Reduce15(ulong[] z, int zOff)
	{
		ulong z2 = z[zOff + 1];
		ulong t = z2 >> 49;
		z[zOff] ^= t ^ (t << 9);
		z[zOff + 1] = z2 & 0x1FFFFFFFFFFFFL;
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
		ulong num = Interleave.Unshuffle(x[0]);
		ulong u1 = Interleave.Unshuffle(x[1]);
		ulong e0 = (num & 0xFFFFFFFFu) | (u1 << 32);
		ulong c0 = (num >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		z[0] = e0 ^ (c0 << 57) ^ (c0 << 5);
		z[1] = (c0 >> 7) ^ (c0 >> 59);
	}

	public static void Square(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat128.CreateExt64();
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
		ulong[] tt = Nat128.CreateExt64();
		ImplSquare(x, tt);
		AddExt(zz, tt, zz);
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
		ulong[] tt = Nat128.CreateExt64();
		ImplSquare(x, tt);
		Reduce(tt, z);
		while (--n > 0)
		{
			ImplSquare(z, tt);
			Reduce(tt, z);
		}
	}

	public static uint Trace(ulong[] x)
	{
		return (uint)((int)x[0] & 1);
	}

	protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong f0 = x[0];
		ulong f1 = x[1];
		f1 = ((f0 >> 57) ^ (f1 << 7)) & 0x1FFFFFFFFFFFFFFL;
		f0 &= 0x1FFFFFFFFFFFFFFL;
		ulong g0 = y[0];
		ulong g1 = y[1];
		g1 = ((g0 >> 57) ^ (g1 << 7)) & 0x1FFFFFFFFFFFFFFL;
		g0 &= 0x1FFFFFFFFFFFFFFL;
		ulong[] H = new ulong[6];
		ImplMulw(zz, f0, g0, H, 0);
		ImplMulw(zz, f1, g1, H, 2);
		ImplMulw(zz, f0 ^ f1, g0 ^ g1, H, 4);
		ulong r = H[1] ^ H[2];
		ulong z0 = H[0];
		ulong z3 = H[3];
		ulong z4 = H[4] ^ z0 ^ r;
		ulong z5 = H[5] ^ z3 ^ r;
		zz[0] = z0 ^ (z4 << 57);
		zz[1] = (z4 >> 7) ^ (z5 << 50);
		zz[2] = (z5 >> 14) ^ (z3 << 43);
		zz[3] = z3 >> 21;
	}

	protected static void ImplMulw(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
	{
		u[1] = y;
		u[2] = u[1] << 1;
		u[3] = u[2] ^ y;
		u[4] = u[2] << 1;
		u[5] = u[4] ^ y;
		u[6] = u[3] << 1;
		u[7] = u[6] ^ y;
		uint j = (uint)x;
		ulong h = 0uL;
		ulong l = u[j & 7];
		int k = 48;
		do
		{
			j = (uint)(x >> k);
			ulong g = u[j & 7] ^ (u[(j >> 3) & 7] << 3) ^ (u[(j >> 6) & 7] << 6);
			l ^= g << k;
			h ^= g >> -k;
		}
		while ((k -= 9) > 0);
		h ^= (x & 0x100804020100800L & (ulong)((long)(y << 7) >> 63)) >> 8;
		z[zOff] = l & 0x1FFFFFFFFFFFFFFL;
		z[zOff + 1] = (l >> 57) ^ (h << 7);
	}

	protected static void ImplSquare(ulong[] x, ulong[] zz)
	{
		Interleave.Expand64To128(x, 0, 2, zz, 0);
	}
}
