using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT131Field
{
	private const ulong M03 = 7uL;

	private const ulong M44 = 17592186044415uL;

	private static readonly ulong[] ROOT_Z = new ulong[3] { 2791191049453778211uL, 2791191049453778402uL, 6uL };

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
		z[2] = x[2] ^ y[2];
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
		zz[0] = xx[0] ^ yy[0];
		zz[1] = xx[1] ^ yy[1];
		zz[2] = xx[2] ^ yy[2];
		zz[3] = xx[3] ^ yy[3];
		zz[4] = xx[4] ^ yy[4];
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
		z[0] = x[0] ^ 1;
		z[1] = x[1];
		z[2] = x[2];
	}

	private static void AddTo(ulong[] x, ulong[] z)
	{
		z[0] ^= x[0];
		z[1] ^= x[1];
		z[2] ^= x[2];
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return Nat.FromBigInteger64(131, x);
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(5);
		Nat192.Copy64(x, z);
		for (int i = 1; i < 131; i += 2)
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
		if (Nat192.IsZero64(x))
		{
			throw new InvalidOperationException();
		}
		ulong[] t0 = Nat192.Create64();
		ulong[] t1 = Nat192.Create64();
		Square(x, t0);
		Multiply(t0, x, t0);
		SquareN(t0, 2, t1);
		Multiply(t1, t0, t1);
		SquareN(t1, 4, t0);
		Multiply(t0, t1, t0);
		SquareN(t0, 8, t1);
		Multiply(t1, t0, t1);
		SquareN(t1, 16, t0);
		Multiply(t0, t1, t0);
		SquareN(t0, 32, t1);
		Multiply(t1, t0, t1);
		Square(t1, t1);
		Multiply(t1, x, t1);
		SquareN(t1, 65, t0);
		Multiply(t0, t1, t0);
		Square(t0, z);
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
		ulong x4 = xx[4];
		x1 ^= (x4 << 61) ^ (x4 << 63);
		x2 ^= (x4 >> 3) ^ (x4 >> 1) ^ x4 ^ (x4 << 5);
		x3 ^= x4 >> 59;
		x0 ^= (x3 << 61) ^ (x3 << 63);
		x1 ^= (x3 >> 3) ^ (x3 >> 1) ^ x3 ^ (x3 << 5);
		x2 ^= x3 >> 59;
		ulong t = x2 >> 3;
		z[0] = x0 ^ t ^ (t << 2) ^ (t << 3) ^ (t << 8);
		z[1] = x1 ^ (t >> 56);
		z[2] = x2 & 7;
	}

	public static void Reduce61(ulong[] z, int zOff)
	{
		ulong z2 = z[zOff + 2];
		ulong t = z2 >> 3;
		z[zOff] ^= t ^ (t << 2) ^ (t << 3) ^ (t << 8);
		z[zOff + 1] ^= t >> 56;
		z[zOff + 2] = z2 & 7;
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
		ulong[] array = Nat192.Create64();
		ulong u0 = Interleave.Unshuffle(x[0]);
		ulong u1 = Interleave.Unshuffle(x[1]);
		ulong e0 = (u0 & 0xFFFFFFFFu) | (u1 << 32);
		array[0] = (u0 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		u0 = Interleave.Unshuffle(x[2]);
		ulong e1 = u0 & 0xFFFFFFFFu;
		array[1] = u0 >> 32;
		Multiply(array, ROOT_Z, z);
		z[0] ^= e0;
		z[1] ^= e1;
	}

	public static void Square(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(5);
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
		ulong[] tt = Nat.Create64(5);
		ImplSquare(x, tt);
		AddExt(zz, tt, zz);
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
		ulong[] tt = Nat.Create64(5);
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
		return (uint)((int)(x[0] ^ (x[1] >> 59) ^ (x[2] >> 1)) & 1);
	}

	protected static void ImplCompactExt(ulong[] zz)
	{
		ulong z0 = zz[0];
		ulong z1 = zz[1];
		ulong z2 = zz[2];
		ulong z3 = zz[3];
		ulong z4 = zz[4];
		ulong z5 = zz[5];
		zz[0] = z0 ^ (z1 << 44);
		zz[1] = (z1 >> 20) ^ (z2 << 24);
		zz[2] = (z2 >> 40) ^ (z3 << 4) ^ (z4 << 48);
		zz[3] = (z3 >> 60) ^ (z5 << 28) ^ (z4 >> 16);
		zz[4] = z5 >> 36;
		zz[5] = 0uL;
	}

	protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong f0 = x[0];
		ulong f1 = x[1];
		ulong f2 = x[2];
		f2 = ((f1 >> 24) ^ (f2 << 40)) & 0xFFFFFFFFFFFL;
		f1 = ((f0 >> 44) ^ (f1 << 20)) & 0xFFFFFFFFFFFL;
		f0 &= 0xFFFFFFFFFFFL;
		ulong g0 = y[0];
		ulong g1 = y[1];
		ulong g2 = y[2];
		g2 = ((g1 >> 24) ^ (g2 << 40)) & 0xFFFFFFFFFFFL;
		g1 = ((g0 >> 44) ^ (g1 << 20)) & 0xFFFFFFFFFFFL;
		g0 &= 0xFFFFFFFFFFFL;
		ulong[] H = new ulong[10];
		ImplMulw(zz, f0, g0, H, 0);
		ImplMulw(zz, f2, g2, H, 2);
		ulong t0 = f0 ^ f1 ^ f2;
		ulong t1 = g0 ^ g1 ^ g2;
		ImplMulw(zz, t0, t1, H, 4);
		ulong t2 = (f1 << 1) ^ (f2 << 2);
		ulong t3 = (g1 << 1) ^ (g2 << 2);
		ImplMulw(zz, f0 ^ t2, g0 ^ t3, H, 6);
		ImplMulw(zz, t0 ^ t2, t1 ^ t3, H, 8);
		ulong num = H[6] ^ H[8];
		ulong t5 = H[7] ^ H[9];
		ulong v0 = (num << 1) ^ H[6];
		ulong v1 = num ^ (t5 << 1) ^ H[7];
		ulong v2 = t5;
		ulong u0 = H[0];
		ulong u1 = H[1] ^ H[0] ^ H[4];
		ulong u2 = H[1] ^ H[5];
		ulong w0 = u0 ^ v0 ^ (H[2] << 4) ^ (H[2] << 1);
		ulong w1 = u1 ^ v1 ^ (H[3] << 4) ^ (H[3] << 1);
		ulong w2 = u2 ^ v2;
		w1 ^= w0 >> 44;
		w0 &= 0xFFFFFFFFFFFL;
		w2 ^= w1 >> 44;
		w1 &= 0xFFFFFFFFFFFL;
		w0 = (w0 >> 1) ^ ((w1 & 1) << 43);
		w1 = (w1 >> 1) ^ ((w2 & 1) << 43);
		w2 >>= 1;
		w0 ^= w0 << 1;
		w0 ^= w0 << 2;
		w0 ^= w0 << 4;
		w0 ^= w0 << 8;
		w0 ^= w0 << 16;
		w0 ^= w0 << 32;
		w0 &= 0xFFFFFFFFFFFL;
		w1 ^= w0 >> 43;
		w1 ^= w1 << 1;
		w1 ^= w1 << 2;
		w1 ^= w1 << 4;
		w1 ^= w1 << 8;
		w1 ^= w1 << 16;
		w1 ^= w1 << 32;
		w1 &= 0xFFFFFFFFFFFL;
		w2 ^= w1 >> 43;
		w2 ^= w2 << 1;
		w2 ^= w2 << 2;
		w2 ^= w2 << 4;
		w2 ^= w2 << 8;
		w2 ^= w2 << 16;
		w2 ^= w2 << 32;
		zz[0] = u0;
		zz[1] = u1 ^ w0 ^ H[2];
		zz[2] = u2 ^ w1 ^ w0 ^ H[3];
		zz[3] = w2 ^ w1;
		zz[4] = w2 ^ H[2];
		zz[5] = H[3];
		ImplCompactExt(zz);
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
		ulong l = u[j & 7] ^ (u[(j >> 3) & 7] << 3) ^ (u[(j >> 6) & 7] << 6) ^ (u[(j >> 9) & 7] << 9) ^ (u[(j >> 12) & 7] << 12);
		int k = 30;
		do
		{
			j = (uint)(x >> k);
			ulong g = u[j & 7] ^ (u[(j >> 3) & 7] << 3) ^ (u[(j >> 6) & 7] << 6) ^ (u[(j >> 9) & 7] << 9) ^ (u[(j >> 12) & 7] << 12);
			l ^= g << k;
			h ^= g >> -k;
		}
		while ((k -= 15) > 0);
		z[zOff] = l & 0xFFFFFFFFFFFL;
		z[zOff + 1] = (l >> 44) ^ (h << 20);
	}

	protected static void ImplSquare(ulong[] x, ulong[] zz)
	{
		Interleave.Expand64To128(x, 0, 2, zz, 0);
		zz[4] = Interleave.Expand8to16((uint)x[2]);
	}
}
