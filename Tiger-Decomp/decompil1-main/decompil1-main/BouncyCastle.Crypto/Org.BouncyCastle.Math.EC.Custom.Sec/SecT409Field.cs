using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT409Field
{
	private const ulong M25 = 33554431uL;

	private const ulong M59 = 576460752303423487uL;

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
		z[2] = x[2] ^ y[2];
		z[3] = x[3] ^ y[3];
		z[4] = x[4] ^ y[4];
		z[5] = x[5] ^ y[5];
		z[6] = x[6] ^ y[6];
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
		for (int i = 0; i < 13; i++)
		{
			zz[i] = xx[i] ^ yy[i];
		}
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
		z[0] = x[0] ^ 1;
		z[1] = x[1];
		z[2] = x[2];
		z[3] = x[3];
		z[4] = x[4];
		z[5] = x[5];
		z[6] = x[6];
	}

	private static void AddTo(ulong[] x, ulong[] z)
	{
		z[0] ^= x[0];
		z[1] ^= x[1];
		z[2] ^= x[2];
		z[3] ^= x[3];
		z[4] ^= x[4];
		z[5] ^= x[5];
		z[6] ^= x[6];
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return Nat.FromBigInteger64(409, x);
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(13);
		Nat448.Copy64(x, z);
		for (int i = 1; i < 409; i += 2)
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
		if (Nat448.IsZero64(x))
		{
			throw new InvalidOperationException();
		}
		ulong[] t0 = Nat448.Create64();
		ulong[] t1 = Nat448.Create64();
		ulong[] t2 = Nat448.Create64();
		Square(x, t0);
		SquareN(t0, 1, t1);
		Multiply(t0, t1, t0);
		SquareN(t1, 1, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 3, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 6, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 12, t1);
		Multiply(t0, t1, t2);
		SquareN(t2, 24, t0);
		SquareN(t0, 24, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 48, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 96, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 192, t1);
		Multiply(t0, t1, t0);
		Multiply(t0, t2, z);
	}

	public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
		ulong[] tt = Nat448.CreateExt64();
		ImplMultiply(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] tt = Nat448.CreateExt64();
		ImplMultiply(x, y, tt);
		AddExt(zz, tt, zz);
	}

	public static void Reduce(ulong[] xx, ulong[] z)
	{
		ulong x00 = xx[0];
		ulong x1 = xx[1];
		ulong x2 = xx[2];
		ulong x3 = xx[3];
		ulong x4 = xx[4];
		ulong x5 = xx[5];
		ulong x6 = xx[6];
		ulong num = xx[7];
		ulong u = xx[12];
		x5 ^= u << 39;
		x6 ^= (u >> 25) ^ (u << 62);
		ulong num2 = num ^ (u >> 2);
		u = xx[11];
		x4 ^= u << 39;
		x5 ^= (u >> 25) ^ (u << 62);
		x6 ^= u >> 2;
		u = xx[10];
		x3 ^= u << 39;
		x4 ^= (u >> 25) ^ (u << 62);
		x5 ^= u >> 2;
		u = xx[9];
		x2 ^= u << 39;
		x3 ^= (u >> 25) ^ (u << 62);
		x4 ^= u >> 2;
		u = xx[8];
		x1 ^= u << 39;
		x2 ^= (u >> 25) ^ (u << 62);
		x3 ^= u >> 2;
		u = num2;
		x00 ^= u << 39;
		x1 ^= (u >> 25) ^ (u << 62);
		x2 ^= u >> 2;
		ulong t = x6 >> 25;
		z[0] = x00 ^ t;
		z[1] = x1 ^ (t << 23);
		z[2] = x2;
		z[3] = x3;
		z[4] = x4;
		z[5] = x5;
		z[6] = x6 & 0x1FFFFFF;
	}

	public static void Reduce39(ulong[] z, int zOff)
	{
		ulong z6 = z[zOff + 6];
		ulong t = z6 >> 25;
		z[zOff] ^= t;
		z[zOff + 1] ^= t << 23;
		z[zOff + 6] = z6 & 0x1FFFFFF;
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
		ulong num = Interleave.Unshuffle(x[0]);
		ulong u1 = Interleave.Unshuffle(x[1]);
		ulong e0 = (num & 0xFFFFFFFFu) | (u1 << 32);
		ulong c0 = (num >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		ulong num2 = Interleave.Unshuffle(x[2]);
		u1 = Interleave.Unshuffle(x[3]);
		ulong e1 = (num2 & 0xFFFFFFFFu) | (u1 << 32);
		ulong c1 = (num2 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		ulong num3 = Interleave.Unshuffle(x[4]);
		u1 = Interleave.Unshuffle(x[5]);
		ulong e2 = (num3 & 0xFFFFFFFFu) | (u1 << 32);
		ulong c2 = (num3 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		ulong num4 = Interleave.Unshuffle(x[6]);
		ulong e3 = num4 & 0xFFFFFFFFu;
		ulong c3 = num4 >> 32;
		z[0] = e0 ^ (c0 << 44);
		z[1] = e1 ^ (c1 << 44) ^ (c0 >> 20);
		z[2] = e2 ^ (c2 << 44) ^ (c1 >> 20);
		z[3] = e3 ^ (c3 << 44) ^ (c2 >> 20) ^ (c0 << 13);
		z[4] = (c3 >> 20) ^ (c1 << 13) ^ (c0 >> 51);
		z[5] = (c2 << 13) ^ (c1 >> 51);
		z[6] = (c3 << 13) ^ (c2 >> 51);
	}

	public static void Square(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(13);
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
		ulong[] tt = Nat.Create64(13);
		ImplSquare(x, tt);
		AddExt(zz, tt, zz);
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
		ulong[] tt = Nat.Create64(13);
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

	protected static void ImplCompactExt(ulong[] zz)
	{
		ulong z00 = zz[0];
		ulong z1 = zz[1];
		ulong z2 = zz[2];
		ulong z3 = zz[3];
		ulong z4 = zz[4];
		ulong z5 = zz[5];
		ulong z6 = zz[6];
		ulong z7 = zz[7];
		ulong z8 = zz[8];
		ulong z9 = zz[9];
		ulong z10 = zz[10];
		ulong z11 = zz[11];
		ulong z12 = zz[12];
		ulong z13 = zz[13];
		zz[0] = z00 ^ (z1 << 59);
		zz[1] = (z1 >> 5) ^ (z2 << 54);
		zz[2] = (z2 >> 10) ^ (z3 << 49);
		zz[3] = (z3 >> 15) ^ (z4 << 44);
		zz[4] = (z4 >> 20) ^ (z5 << 39);
		zz[5] = (z5 >> 25) ^ (z6 << 34);
		zz[6] = (z6 >> 30) ^ (z7 << 29);
		zz[7] = (z7 >> 35) ^ (z8 << 24);
		zz[8] = (z8 >> 40) ^ (z9 << 19);
		zz[9] = (z9 >> 45) ^ (z10 << 14);
		zz[10] = (z10 >> 50) ^ (z11 << 9);
		zz[11] = (z11 >> 55) ^ (z12 << 4) ^ (z13 << 63);
		zz[12] = z13 >> 1;
	}

	protected static void ImplExpand(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong x4 = x[2];
		ulong x5 = x[3];
		ulong x6 = x[4];
		ulong x7 = x[5];
		ulong x8 = x[6];
		z[0] = x2 & 0x7FFFFFFFFFFFFFFL;
		z[1] = ((x2 >> 59) ^ (x3 << 5)) & 0x7FFFFFFFFFFFFFFL;
		z[2] = ((x3 >> 54) ^ (x4 << 10)) & 0x7FFFFFFFFFFFFFFL;
		z[3] = ((x4 >> 49) ^ (x5 << 15)) & 0x7FFFFFFFFFFFFFFL;
		z[4] = ((x5 >> 44) ^ (x6 << 20)) & 0x7FFFFFFFFFFFFFFL;
		z[5] = ((x6 >> 39) ^ (x7 << 25)) & 0x7FFFFFFFFFFFFFFL;
		z[6] = (x7 >> 34) ^ (x8 << 30);
	}

	protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] a = new ulong[7];
		ulong[] b = new ulong[7];
		ImplExpand(x, a);
		ImplExpand(y, b);
		ulong[] u = new ulong[8];
		for (int i = 0; i < 7; i++)
		{
			ImplMulwAcc(u, a[i], b[i], zz, i << 1);
		}
		ulong v0 = zz[0];
		ulong v1 = zz[1];
		v0 ^= zz[2];
		zz[1] = v0 ^ v1;
		v1 ^= zz[3];
		v0 ^= zz[4];
		zz[2] = v0 ^ v1;
		v1 ^= zz[5];
		v0 ^= zz[6];
		zz[3] = v0 ^ v1;
		v1 ^= zz[7];
		v0 ^= zz[8];
		zz[4] = v0 ^ v1;
		v1 ^= zz[9];
		v0 ^= zz[10];
		zz[5] = v0 ^ v1;
		v1 ^= zz[11];
		v0 ^= zz[12];
		zz[6] = v0 ^ v1;
		v1 ^= zz[13];
		ulong w = v0 ^ v1;
		zz[7] = zz[0] ^ w;
		zz[8] = zz[1] ^ w;
		zz[9] = zz[2] ^ w;
		zz[10] = zz[3] ^ w;
		zz[11] = zz[4] ^ w;
		zz[12] = zz[5] ^ w;
		zz[13] = zz[6] ^ w;
		ImplMulwAcc(u, a[0] ^ a[1], b[0] ^ b[1], zz, 1);
		ImplMulwAcc(u, a[0] ^ a[2], b[0] ^ b[2], zz, 2);
		ImplMulwAcc(u, a[0] ^ a[3], b[0] ^ b[3], zz, 3);
		ImplMulwAcc(u, a[1] ^ a[2], b[1] ^ b[2], zz, 3);
		ImplMulwAcc(u, a[0] ^ a[4], b[0] ^ b[4], zz, 4);
		ImplMulwAcc(u, a[1] ^ a[3], b[1] ^ b[3], zz, 4);
		ImplMulwAcc(u, a[0] ^ a[5], b[0] ^ b[5], zz, 5);
		ImplMulwAcc(u, a[1] ^ a[4], b[1] ^ b[4], zz, 5);
		ImplMulwAcc(u, a[2] ^ a[3], b[2] ^ b[3], zz, 5);
		ImplMulwAcc(u, a[0] ^ a[6], b[0] ^ b[6], zz, 6);
		ImplMulwAcc(u, a[1] ^ a[5], b[1] ^ b[5], zz, 6);
		ImplMulwAcc(u, a[2] ^ a[4], b[2] ^ b[4], zz, 6);
		ImplMulwAcc(u, a[1] ^ a[6], b[1] ^ b[6], zz, 7);
		ImplMulwAcc(u, a[2] ^ a[5], b[2] ^ b[5], zz, 7);
		ImplMulwAcc(u, a[3] ^ a[4], b[3] ^ b[4], zz, 7);
		ImplMulwAcc(u, a[2] ^ a[6], b[2] ^ b[6], zz, 8);
		ImplMulwAcc(u, a[3] ^ a[5], b[3] ^ b[5], zz, 8);
		ImplMulwAcc(u, a[3] ^ a[6], b[3] ^ b[6], zz, 9);
		ImplMulwAcc(u, a[4] ^ a[5], b[4] ^ b[5], zz, 9);
		ImplMulwAcc(u, a[4] ^ a[6], b[4] ^ b[6], zz, 10);
		ImplMulwAcc(u, a[5] ^ a[6], b[5] ^ b[6], zz, 11);
		ImplCompactExt(zz);
	}

	protected static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
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
		ulong l = u[j & 7] ^ (u[(j >> 3) & 7] << 3);
		int k = 54;
		do
		{
			j = (uint)(x >> k);
			ulong g = u[j & 7] ^ (u[(j >> 3) & 7] << 3);
			l ^= g << k;
			h ^= g >> -k;
		}
		while ((k -= 6) > 0);
		z[zOff] ^= l & 0x7FFFFFFFFFFFFFFL;
		z[zOff + 1] ^= (l >> 59) ^ (h << 5);
	}

	protected static void ImplSquare(ulong[] x, ulong[] zz)
	{
		Interleave.Expand64To128(x, 0, 6, zz, 0);
		zz[12] = Interleave.Expand32to64((uint)x[6]);
	}
}
