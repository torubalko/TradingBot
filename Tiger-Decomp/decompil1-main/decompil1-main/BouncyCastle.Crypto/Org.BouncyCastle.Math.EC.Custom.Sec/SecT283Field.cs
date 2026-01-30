using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT283Field
{
	private const ulong M27 = 134217727uL;

	private const ulong M57 = 144115188075855871uL;

	private static readonly ulong[] ROOT_Z = new ulong[5] { 878416384462358536uL, 3513665537849438403uL, 9369774767598502668uL, 585610922974906400uL, 34087042uL };

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
		z[2] = x[2] ^ y[2];
		z[3] = x[3] ^ y[3];
		z[4] = x[4] ^ y[4];
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
		zz[0] = xx[0] ^ yy[0];
		zz[1] = xx[1] ^ yy[1];
		zz[2] = xx[2] ^ yy[2];
		zz[3] = xx[3] ^ yy[3];
		zz[4] = xx[4] ^ yy[4];
		zz[5] = xx[5] ^ yy[5];
		zz[6] = xx[6] ^ yy[6];
		zz[7] = xx[7] ^ yy[7];
		zz[8] = xx[8] ^ yy[8];
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
		z[0] = x[0] ^ 1;
		z[1] = x[1];
		z[2] = x[2];
		z[3] = x[3];
		z[4] = x[4];
	}

	private static void AddTo(ulong[] x, ulong[] z)
	{
		z[0] ^= x[0];
		z[1] ^= x[1];
		z[2] ^= x[2];
		z[3] ^= x[3];
		z[4] ^= x[4];
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return Nat.FromBigInteger64(283, x);
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(9);
		Nat320.Copy64(x, z);
		for (int i = 1; i < 283; i += 2)
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
		if (Nat320.IsZero64(x))
		{
			throw new InvalidOperationException();
		}
		ulong[] t0 = Nat320.Create64();
		ulong[] t1 = Nat320.Create64();
		Square(x, t0);
		Multiply(t0, x, t0);
		SquareN(t0, 2, t1);
		Multiply(t1, t0, t1);
		SquareN(t1, 4, t0);
		Multiply(t0, t1, t0);
		SquareN(t0, 8, t1);
		Multiply(t1, t0, t1);
		Square(t1, t1);
		Multiply(t1, x, t1);
		SquareN(t1, 17, t0);
		Multiply(t0, t1, t0);
		Square(t0, t0);
		Multiply(t0, x, t0);
		SquareN(t0, 35, t1);
		Multiply(t1, t0, t1);
		SquareN(t1, 70, t0);
		Multiply(t0, t1, t0);
		Square(t0, t0);
		Multiply(t0, x, t0);
		SquareN(t0, 141, t1);
		Multiply(t1, t0, t1);
		Square(t1, z);
	}

	public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
		ulong[] tt = Nat320.CreateExt64();
		ImplMultiply(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] tt = Nat320.CreateExt64();
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
		ulong x5 = xx[5];
		ulong x6 = xx[6];
		ulong x7 = xx[7];
		ulong x8 = xx[8];
		x3 ^= (x8 << 37) ^ (x8 << 42) ^ (x8 << 44) ^ (x8 << 49);
		x4 ^= (x8 >> 27) ^ (x8 >> 22) ^ (x8 >> 20) ^ (x8 >> 15);
		x2 ^= (x7 << 37) ^ (x7 << 42) ^ (x7 << 44) ^ (x7 << 49);
		x3 ^= (x7 >> 27) ^ (x7 >> 22) ^ (x7 >> 20) ^ (x7 >> 15);
		x1 ^= (x6 << 37) ^ (x6 << 42) ^ (x6 << 44) ^ (x6 << 49);
		x2 ^= (x6 >> 27) ^ (x6 >> 22) ^ (x6 >> 20) ^ (x6 >> 15);
		x0 ^= (x5 << 37) ^ (x5 << 42) ^ (x5 << 44) ^ (x5 << 49);
		x1 ^= (x5 >> 27) ^ (x5 >> 22) ^ (x5 >> 20) ^ (x5 >> 15);
		ulong t = x4 >> 27;
		z[0] = x0 ^ t ^ (t << 5) ^ (t << 7) ^ (t << 12);
		z[1] = x1;
		z[2] = x2;
		z[3] = x3;
		z[4] = x4 & 0x7FFFFFF;
	}

	public static void Reduce37(ulong[] z, int zOff)
	{
		ulong z4 = z[zOff + 4];
		ulong t = z4 >> 27;
		z[zOff] ^= t ^ (t << 5) ^ (t << 7) ^ (t << 12);
		z[zOff + 4] = z4 & 0x7FFFFFF;
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
		ulong[] array = Nat320.Create64();
		ulong u0 = Interleave.Unshuffle(x[0]);
		ulong u1 = Interleave.Unshuffle(x[1]);
		ulong e0 = (u0 & 0xFFFFFFFFu) | (u1 << 32);
		array[0] = (u0 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		u0 = Interleave.Unshuffle(x[2]);
		u1 = Interleave.Unshuffle(x[3]);
		ulong e1 = (u0 & 0xFFFFFFFFu) | (u1 << 32);
		array[1] = (u0 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		u0 = Interleave.Unshuffle(x[4]);
		ulong e2 = u0 & 0xFFFFFFFFu;
		array[2] = u0 >> 32;
		Multiply(array, ROOT_Z, z);
		z[0] ^= e0;
		z[1] ^= e1;
		z[2] ^= e2;
	}

	public static void Square(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat.Create64(9);
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
		ulong[] tt = Nat.Create64(9);
		ImplSquare(x, tt);
		AddExt(zz, tt, zz);
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
		ulong[] tt = Nat.Create64(9);
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
		return (uint)((int)(x[0] ^ (x[4] >> 15)) & 1);
	}

	protected static void ImplCompactExt(ulong[] zz)
	{
		ulong z0 = zz[0];
		ulong z1 = zz[1];
		ulong z2 = zz[2];
		ulong z3 = zz[3];
		ulong z4 = zz[4];
		ulong z5 = zz[5];
		ulong z6 = zz[6];
		ulong z7 = zz[7];
		ulong z8 = zz[8];
		ulong z9 = zz[9];
		zz[0] = z0 ^ (z1 << 57);
		zz[1] = (z1 >> 7) ^ (z2 << 50);
		zz[2] = (z2 >> 14) ^ (z3 << 43);
		zz[3] = (z3 >> 21) ^ (z4 << 36);
		zz[4] = (z4 >> 28) ^ (z5 << 29);
		zz[5] = (z5 >> 35) ^ (z6 << 22);
		zz[6] = (z6 >> 42) ^ (z7 << 15);
		zz[7] = (z7 >> 49) ^ (z8 << 8);
		zz[8] = (z8 >> 56) ^ (z9 << 1);
		zz[9] = z9 >> 63;
	}

	protected static void ImplExpand(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong x4 = x[2];
		ulong x5 = x[3];
		ulong x6 = x[4];
		z[0] = x2 & 0x1FFFFFFFFFFFFFFL;
		z[1] = ((x2 >> 57) ^ (x3 << 7)) & 0x1FFFFFFFFFFFFFFL;
		z[2] = ((x3 >> 50) ^ (x4 << 14)) & 0x1FFFFFFFFFFFFFFL;
		z[3] = ((x4 >> 43) ^ (x5 << 21)) & 0x1FFFFFFFFFFFFFFL;
		z[4] = (x5 >> 36) ^ (x6 << 28);
	}

	protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] a = new ulong[5];
		ulong[] b = new ulong[5];
		ImplExpand(x, a);
		ImplExpand(y, b);
		ulong[] p = new ulong[26];
		ImplMulw(zz, a[0], b[0], p, 0);
		ImplMulw(zz, a[1], b[1], p, 2);
		ImplMulw(zz, a[2], b[2], p, 4);
		ImplMulw(zz, a[3], b[3], p, 6);
		ImplMulw(zz, a[4], b[4], p, 8);
		ulong u0 = a[0] ^ a[1];
		ulong v0 = b[0] ^ b[1];
		ulong u1 = a[0] ^ a[2];
		ulong v1 = b[0] ^ b[2];
		ulong u2 = a[2] ^ a[4];
		ulong v2 = b[2] ^ b[4];
		ulong u3 = a[3] ^ a[4];
		ulong v3 = b[3] ^ b[4];
		ImplMulw(zz, u1 ^ a[3], v1 ^ b[3], p, 18);
		ImplMulw(zz, u2 ^ a[1], v2 ^ b[1], p, 20);
		ulong A4 = u0 ^ u3;
		ulong B4 = v0 ^ v3;
		ulong A5 = A4 ^ a[2];
		ulong B5 = B4 ^ b[2];
		ImplMulw(zz, A4, B4, p, 22);
		ImplMulw(zz, A5, B5, p, 24);
		ImplMulw(zz, u0, v0, p, 10);
		ImplMulw(zz, u1, v1, p, 12);
		ImplMulw(zz, u2, v2, p, 14);
		ImplMulw(zz, u3, v3, p, 16);
		zz[0] = p[0];
		zz[9] = p[9];
		ulong num = p[0] ^ p[1];
		ulong num2 = num ^ p[2];
		ulong t3 = (zz[1] = num2 ^ p[10]);
		ulong t4 = p[3] ^ p[4];
		ulong t5 = p[11] ^ p[12];
		ulong t6 = t4 ^ t5;
		ulong t7 = (zz[2] = num2 ^ t6);
		ulong num3 = num ^ t4;
		ulong t9 = p[5] ^ p[6];
		ulong num4 = num3 ^ t9 ^ p[8];
		ulong t12 = p[13] ^ p[14];
		ulong num5 = num4 ^ t12;
		ulong t15 = p[18] ^ p[22] ^ p[24];
		ulong t16 = num5 ^ t15;
		zz[3] = t16;
		ulong num6 = p[7] ^ p[8] ^ p[9];
		ulong t19 = (zz[8] = num6 ^ p[17]);
		ulong num7 = num6 ^ t9;
		ulong t21 = p[15] ^ p[16];
		ulong t23 = (zz[7] = num7 ^ t21) ^ t3;
		ulong num8 = p[19] ^ p[20];
		ulong t25 = p[25] ^ p[24];
		ulong t26 = p[18] ^ p[23];
		ulong num9 = num8 ^ t25;
		ulong t29 = num9 ^ t26 ^ t23;
		zz[4] = t29;
		ulong t30 = t7 ^ t19;
		ulong num10 = num9 ^ t30;
		ulong t32 = p[21] ^ p[22];
		ulong t33 = num10 ^ t32;
		zz[5] = t33;
		ulong t39 = num4 ^ p[0] ^ p[9] ^ t12 ^ p[21] ^ p[23] ^ p[25];
		zz[6] = t39;
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
		Interleave.Expand64To128(x, 0, 4, zz, 0);
		zz[8] = Interleave.Expand32to64((uint)x[4]);
	}
}
