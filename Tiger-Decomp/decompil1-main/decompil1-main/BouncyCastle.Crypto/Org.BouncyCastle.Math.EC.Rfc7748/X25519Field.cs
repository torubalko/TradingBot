using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X25519Field
{
	public const int Size = 10;

	private const int M24 = 16777215;

	private const int M25 = 33554431;

	private const int M26 = 67108863;

	private static readonly uint[] P32 = new uint[8] { 4294967277u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 2147483647u };

	private static readonly int[] RootNegOne = new int[10] { 34513072, 59165138, 4688974, 3500415, 6194736, 33281959, 54535759, 32551604, 163342, 5703241 };

	public static void Add(int[] x, int[] y, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = x[i] + y[i];
		}
	}

	public static void AddOne(int[] z)
	{
		z[0]++;
	}

	public static void AddOne(int[] z, int zOff)
	{
		z[zOff]++;
	}

	public static void Apm(int[] x, int[] y, int[] zp, int[] zm)
	{
		for (int i = 0; i < 10; i++)
		{
			int xi = x[i];
			int yi = y[i];
			zp[i] = xi + yi;
			zm[i] = xi - yi;
		}
	}

	public static int AreEqual(int[] x, int[] y)
	{
		int d = 0;
		for (int i = 0; i < 10; i++)
		{
			d |= x[i] ^ y[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return d - 1 >> 31;
	}

	public static bool AreEqualVar(int[] x, int[] y)
	{
		return AreEqual(x, y) != 0;
	}

	public static void Carry(int[] z)
	{
		int z2 = z[0];
		int z3 = z[1];
		int z4 = z[2];
		int z5 = z[3];
		int z6 = z[4];
		int z7 = z[5];
		int z8 = z[6];
		int z9 = z[7];
		int z10 = z[8];
		int z11 = z[9];
		z4 += z3 >> 26;
		z3 &= 0x3FFFFFF;
		z6 += z5 >> 26;
		z5 &= 0x3FFFFFF;
		z9 += z8 >> 26;
		z8 &= 0x3FFFFFF;
		z11 += z10 >> 26;
		z10 &= 0x3FFFFFF;
		z5 += z4 >> 25;
		z4 &= 0x1FFFFFF;
		z7 += z6 >> 25;
		z6 &= 0x1FFFFFF;
		z10 += z9 >> 25;
		z9 &= 0x1FFFFFF;
		z2 += (z11 >> 25) * 38;
		z11 &= 0x1FFFFFF;
		z3 += z2 >> 26;
		z2 &= 0x3FFFFFF;
		z8 += z7 >> 26;
		z7 &= 0x3FFFFFF;
		z4 += z3 >> 26;
		z3 &= 0x3FFFFFF;
		z6 += z5 >> 26;
		z5 &= 0x3FFFFFF;
		z9 += z8 >> 26;
		z8 &= 0x3FFFFFF;
		z11 += z10 >> 26;
		z10 &= 0x3FFFFFF;
		z[0] = z2;
		z[1] = z3;
		z[2] = z4;
		z[3] = z5;
		z[4] = z6;
		z[5] = z7;
		z[6] = z8;
		z[7] = z9;
		z[8] = z10;
		z[9] = z11;
	}

	public static void CMov(int cond, int[] x, int xOff, int[] z, int zOff)
	{
		for (int i = 0; i < 10; i++)
		{
			int z_i = z[zOff + i];
			int diff = z_i ^ x[xOff + i];
			z_i ^= diff & cond;
			z[zOff + i] = z_i;
		}
	}

	public static void CNegate(int negate, int[] z)
	{
		int mask = -negate;
		for (int i = 0; i < 10; i++)
		{
			z[i] = (z[i] ^ mask) - mask;
		}
	}

	public static void Copy(int[] x, int xOff, int[] z, int zOff)
	{
		for (int i = 0; i < 10; i++)
		{
			z[zOff + i] = x[xOff + i];
		}
	}

	public static int[] Create()
	{
		return new int[10];
	}

	public static int[] CreateTable(int n)
	{
		return new int[10 * n];
	}

	public static void CSwap(int swap, int[] a, int[] b)
	{
		int mask = -swap;
		for (int i = 0; i < 10; i++)
		{
			int ai = a[i];
			int bi = b[i];
			int dummy = mask & (ai ^ bi);
			a[i] = ai ^ dummy;
			b[i] = bi ^ dummy;
		}
	}

	[CLSCompliant(false)]
	public static void Decode(uint[] x, int xOff, int[] z)
	{
		Decode128(x, xOff, z, 0);
		Decode128(x, xOff + 4, z, 5);
		z[9] &= 16777215;
	}

	public static void Decode(byte[] x, int xOff, int[] z)
	{
		Decode128(x, xOff, z, 0);
		Decode128(x, xOff + 16, z, 5);
		z[9] &= 16777215;
	}

	private static void Decode128(uint[] x, int xOff, int[] z, int zOff)
	{
		uint t0 = x[xOff];
		uint t1 = x[xOff + 1];
		uint t2 = x[xOff + 2];
		uint t3 = x[xOff + 3];
		z[zOff] = (int)(t0 & 0x3FFFFFF);
		z[zOff + 1] = (int)(((t1 << 6) | (t0 >> 26)) & 0x3FFFFFF);
		z[zOff + 2] = (int)(((t2 << 12) | (t1 >> 20)) & 0x1FFFFFF);
		z[zOff + 3] = (int)(((t3 << 19) | (t2 >> 13)) & 0x3FFFFFF);
		z[zOff + 4] = (int)(t3 >> 7);
	}

	private static void Decode128(byte[] bs, int off, int[] z, int zOff)
	{
		uint t0 = Decode32(bs, off);
		uint t1 = Decode32(bs, off + 4);
		uint t2 = Decode32(bs, off + 8);
		uint t3 = Decode32(bs, off + 12);
		z[zOff] = (int)(t0 & 0x3FFFFFF);
		z[zOff + 1] = (int)(((t1 << 6) | (t0 >> 26)) & 0x3FFFFFF);
		z[zOff + 2] = (int)(((t2 << 12) | (t1 >> 20)) & 0x1FFFFFF);
		z[zOff + 3] = (int)(((t3 << 19) | (t2 >> 13)) & 0x3FFFFFF);
		z[zOff + 4] = (int)(t3 >> 7);
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	[CLSCompliant(false)]
	public static void Encode(int[] x, uint[] z, int zOff)
	{
		Encode128(x, 0, z, zOff);
		Encode128(x, 5, z, zOff + 4);
	}

	public static void Encode(int[] x, byte[] z, int zOff)
	{
		Encode128(x, 0, z, zOff);
		Encode128(x, 5, z, zOff + 16);
	}

	private static void Encode128(int[] x, int xOff, uint[] z, int zOff)
	{
		uint x2 = (uint)x[xOff];
		uint x3 = (uint)x[xOff + 1];
		uint x4 = (uint)x[xOff + 2];
		uint x5 = (uint)x[xOff + 3];
		uint x6 = (uint)x[xOff + 4];
		z[zOff] = x2 | (x3 << 26);
		z[zOff + 1] = (x3 >> 6) | (x4 << 20);
		z[zOff + 2] = (x4 >> 12) | (x5 << 13);
		z[zOff + 3] = (x5 >> 19) | (x6 << 7);
	}

	private static void Encode128(int[] x, int xOff, byte[] bs, int off)
	{
		int num = x[xOff];
		uint x2 = (uint)x[xOff + 1];
		uint x3 = (uint)x[xOff + 2];
		uint x4 = (uint)x[xOff + 3];
		uint x5 = (uint)x[xOff + 4];
		Encode32((uint)num | (x2 << 26), bs, off);
		Encode32((x2 >> 6) | (x3 << 20), bs, off + 4);
		Encode32((x3 >> 12) | (x4 << 13), bs, off + 8);
		Encode32((x4 >> 19) | (x5 << 7), bs, off + 12);
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
		bs[++off] = (byte)(n >> 24);
	}

	public static void Inv(int[] x, int[] z)
	{
		int[] t = Create();
		uint[] u = new uint[8];
		Copy(x, 0, t, 0);
		Normalize(t);
		Encode(t, u, 0);
		Mod.ModOddInverse(P32, u, u);
		Decode(u, 0, z);
	}

	public static void InvVar(int[] x, int[] z)
	{
		int[] t = Create();
		uint[] u = new uint[8];
		Copy(x, 0, t, 0);
		Normalize(t);
		Encode(t, u, 0);
		Mod.ModOddInverseVar(P32, u, u);
		Decode(u, 0, z);
	}

	public static int IsOne(int[] x)
	{
		int d = x[0] ^ 1;
		for (int i = 1; i < 10; i++)
		{
			d |= x[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return d - 1 >> 31;
	}

	public static bool IsOneVar(int[] x)
	{
		return IsOne(x) != 0;
	}

	public static int IsZero(int[] x)
	{
		int d = 0;
		for (int i = 0; i < 10; i++)
		{
			d |= x[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return d - 1 >> 31;
	}

	public static bool IsZeroVar(int[] x)
	{
		return IsZero(x) != 0;
	}

	public static void Mul(int[] x, int y, int[] z)
	{
		int x2 = x[0];
		int x3 = x[1];
		int x4 = x[2];
		int x5 = x[3];
		int x6 = x[4];
		int x7 = x[5];
		int x8 = x[6];
		int x9 = x[7];
		int x10 = x[8];
		int x11 = x[9];
		long c0 = (long)x4 * (long)y;
		x4 = (int)c0 & 0x1FFFFFF;
		c0 >>= 25;
		long c1 = (long)x6 * (long)y;
		x6 = (int)c1 & 0x1FFFFFF;
		c1 >>= 25;
		long c2 = (long)x9 * (long)y;
		x9 = (int)c2 & 0x1FFFFFF;
		c2 >>= 25;
		long c3 = (long)x11 * (long)y;
		x11 = (int)c3 & 0x1FFFFFF;
		c3 >>= 25;
		c3 *= 38;
		c3 += (long)x2 * (long)y;
		z[0] = (int)c3 & 0x3FFFFFF;
		c3 >>= 26;
		c1 += (long)x7 * (long)y;
		z[5] = (int)c1 & 0x3FFFFFF;
		c1 >>= 26;
		c3 += (long)x3 * (long)y;
		z[1] = (int)c3 & 0x3FFFFFF;
		c3 >>= 26;
		c0 += (long)x5 * (long)y;
		z[3] = (int)c0 & 0x3FFFFFF;
		c0 >>= 26;
		c1 += (long)x8 * (long)y;
		z[6] = (int)c1 & 0x3FFFFFF;
		c1 >>= 26;
		c2 += (long)x10 * (long)y;
		z[8] = (int)c2 & 0x3FFFFFF;
		c2 >>= 26;
		z[2] = x4 + (int)c3;
		z[4] = x6 + (int)c0;
		z[7] = x9 + (int)c1;
		z[9] = x11 + (int)c2;
	}

	public static void Mul(int[] x, int[] y, int[] z)
	{
		int x2 = x[0];
		int y2 = y[0];
		int x3 = x[1];
		int y3 = y[1];
		int x4 = x[2];
		int y4 = y[2];
		int x5 = x[3];
		int y5 = y[3];
		int x6 = x[4];
		int y6 = y[4];
		int u0 = x[5];
		int v0 = y[5];
		int u1 = x[6];
		int v1 = y[6];
		int u2 = x[7];
		int v2 = y[7];
		int u3 = x[8];
		int v3 = y[8];
		int u4 = x[9];
		int v4 = y[9];
		long a0 = (long)x2 * (long)y2;
		long a1 = (long)x2 * (long)y3 + (long)x3 * (long)y2;
		long a2 = (long)x2 * (long)y4 + (long)x3 * (long)y3 + (long)x4 * (long)y2;
		long a3 = (long)x3 * (long)y4 + (long)x4 * (long)y3;
		a3 <<= 1;
		a3 += (long)x2 * (long)y5 + (long)x5 * (long)y2;
		long a4 = (long)x4 * (long)y4;
		a4 <<= 1;
		a4 += (long)x2 * (long)y6 + (long)x3 * (long)y5 + (long)x5 * (long)y3 + (long)x6 * (long)y2;
		long a5 = (long)x3 * (long)y6 + (long)x4 * (long)y5 + (long)x5 * (long)y4 + (long)x6 * (long)y3;
		a5 <<= 1;
		long a6 = (long)x4 * (long)y6 + (long)x6 * (long)y4;
		a6 <<= 1;
		a6 += (long)x5 * (long)y5;
		long a7 = (long)x5 * (long)y6 + (long)x6 * (long)y5;
		long a8 = (long)x6 * (long)y6;
		a8 <<= 1;
		long b0 = (long)u0 * (long)v0;
		long b1 = (long)u0 * (long)v1 + (long)u1 * (long)v0;
		long b2 = (long)u0 * (long)v2 + (long)u1 * (long)v1 + (long)u2 * (long)v0;
		long b3 = (long)u1 * (long)v2 + (long)u2 * (long)v1;
		b3 <<= 1;
		b3 += (long)u0 * (long)v3 + (long)u3 * (long)v0;
		long b4 = (long)u2 * (long)v2;
		b4 <<= 1;
		b4 += (long)u0 * (long)v4 + (long)u1 * (long)v3 + (long)u3 * (long)v1 + (long)u4 * (long)v0;
		long b5 = (long)u1 * (long)v4 + (long)u2 * (long)v3 + (long)u3 * (long)v2 + (long)u4 * (long)v1;
		long b6 = (long)u2 * (long)v4 + (long)u4 * (long)v2;
		b6 <<= 1;
		b6 += (long)u3 * (long)v3;
		long b7 = (long)u3 * (long)v4 + (long)u4 * (long)v3;
		long b8 = (long)u4 * (long)v4;
		a0 -= b5 * 76;
		a1 -= b6 * 38;
		a2 -= b7 * 38;
		a3 -= b8 * 76;
		a5 -= b0;
		a6 -= b1;
		a7 -= b2;
		a8 -= b3;
		x2 += u0;
		y2 += v0;
		x3 += u1;
		y3 += v1;
		x4 += u2;
		y4 += v2;
		x5 += u3;
		y5 += v3;
		x6 += u4;
		y6 += v4;
		long c0 = (long)x2 * (long)y2;
		long c1 = (long)x2 * (long)y3 + (long)x3 * (long)y2;
		long c2 = (long)x2 * (long)y4 + (long)x3 * (long)y3 + (long)x4 * (long)y2;
		long c3 = (long)x3 * (long)y4 + (long)x4 * (long)y3;
		c3 <<= 1;
		c3 += (long)x2 * (long)y5 + (long)x5 * (long)y2;
		long c4 = (long)x4 * (long)y4;
		c4 <<= 1;
		c4 += (long)x2 * (long)y6 + (long)x3 * (long)y5 + (long)x5 * (long)y3 + (long)x6 * (long)y2;
		long c5 = (long)x3 * (long)y6 + (long)x4 * (long)y5 + (long)x5 * (long)y4 + (long)x6 * (long)y3;
		c5 <<= 1;
		long c6 = (long)x4 * (long)y6 + (long)x6 * (long)y4;
		c6 <<= 1;
		c6 += (long)x5 * (long)y5;
		long c7 = (long)x5 * (long)y6 + (long)x6 * (long)y5;
		long c8 = (long)x6 * (long)y6;
		c8 <<= 1;
		long t = a8 + (c3 - a3);
		int z8 = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += c4 - a4 - b4;
		int z9 = (int)t & 0x1FFFFFF;
		t >>= 25;
		t = a0 + (t + c5 - a5) * 38;
		z[0] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a1 + (c6 - a6) * 38;
		z[1] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a2 + (c7 - a7) * 38;
		z[2] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += a3 + (c8 - a8) * 38;
		z[3] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a4 + b4 * 38;
		z[4] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += a5 + (c0 - a0);
		z[5] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a6 + (c1 - a1);
		z[6] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a7 + (c2 - a2);
		z[7] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += z8;
		z[8] = (int)t & 0x3FFFFFF;
		t >>= 26;
		z[9] = z9 + (int)t;
	}

	public static void Negate(int[] x, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = -x[i];
		}
	}

	public static void Normalize(int[] z)
	{
		int x = (z[9] >> 23) & 1;
		Reduce(z, x);
		Reduce(z, -x);
	}

	public static void One(int[] z)
	{
		z[0] = 1;
		for (int i = 1; i < 10; i++)
		{
			z[i] = 0;
		}
	}

	private static void PowPm5d8(int[] x, int[] rx2, int[] rz)
	{
		Sqr(x, rx2);
		Mul(x, rx2, rx2);
		int[] x3 = Create();
		Sqr(rx2, x3);
		Mul(x, x3, x3);
		int[] x5 = x3;
		Sqr(x3, 2, x5);
		Mul(rx2, x5, x5);
		int[] x10 = Create();
		Sqr(x5, 5, x10);
		Mul(x5, x10, x10);
		int[] x15 = Create();
		Sqr(x10, 5, x15);
		Mul(x5, x15, x15);
		int[] x25 = x5;
		Sqr(x15, 10, x25);
		Mul(x10, x25, x25);
		int[] x50 = x10;
		Sqr(x25, 25, x50);
		Mul(x25, x50, x50);
		int[] x75 = x15;
		Sqr(x50, 25, x75);
		Mul(x25, x75, x75);
		int[] x125 = x25;
		Sqr(x75, 50, x125);
		Mul(x50, x125, x125);
		int[] x250 = x50;
		Sqr(x125, 125, x250);
		Mul(x125, x250, x250);
		int[] t = x125;
		Sqr(x250, 2, t);
		Mul(t, x, rz);
	}

	private static void Reduce(int[] z, int x)
	{
		int num = z[9];
		int z9 = num & 0xFFFFFF;
		long cc = ((num >> 24) + x) * 19;
		cc += z[0];
		z[0] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		cc += z[1];
		z[1] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		cc += z[2];
		z[2] = (int)cc & 0x1FFFFFF;
		cc >>= 25;
		cc += z[3];
		z[3] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		cc += z[4];
		z[4] = (int)cc & 0x1FFFFFF;
		cc >>= 25;
		cc += z[5];
		z[5] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		cc += z[6];
		z[6] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		cc += z[7];
		z[7] = (int)cc & 0x1FFFFFF;
		cc >>= 25;
		cc += z[8];
		z[8] = (int)cc & 0x3FFFFFF;
		cc >>= 26;
		z[9] = z9 + (int)cc;
	}

	public static void Sqr(int[] x, int[] z)
	{
		int x2 = x[0];
		int x3 = x[1];
		int num = x[2];
		int x4 = x[3];
		int x5 = x[4];
		int u0 = x[5];
		int u1 = x[6];
		int u2 = x[7];
		int u3 = x[8];
		int u4 = x[9];
		int x1_2 = x3 * 2;
		int x2_2 = num * 2;
		int x3_2 = x4 * 2;
		int x4_2 = x5 * 2;
		long a0 = (long)x2 * (long)x2;
		long a1 = (long)x2 * (long)x1_2;
		long a2 = (long)x2 * (long)x2_2 + (long)x3 * (long)x3;
		long a3 = (long)x1_2 * (long)x2_2 + (long)x2 * (long)x3_2;
		long a4 = (long)num * (long)x2_2 + (long)x2 * (long)x4_2 + (long)x3 * (long)x3_2;
		long a5 = (long)x1_2 * (long)x4_2 + (long)x2_2 * (long)x3_2;
		long a6 = (long)x2_2 * (long)x4_2 + (long)x4 * (long)x4;
		long a7 = (long)x4 * (long)x4_2;
		long a8 = (long)x5 * (long)x4_2;
		int u1_2 = u1 * 2;
		int u2_2 = u2 * 2;
		int u3_2 = u3 * 2;
		int u4_2 = u4 * 2;
		long b0 = (long)u0 * (long)u0;
		long b1 = (long)u0 * (long)u1_2;
		long b2 = (long)u0 * (long)u2_2 + (long)u1 * (long)u1;
		long b3 = (long)u1_2 * (long)u2_2 + (long)u0 * (long)u3_2;
		long b4 = (long)u2 * (long)u2_2 + (long)u0 * (long)u4_2 + (long)u1 * (long)u3_2;
		long b5 = (long)u1_2 * (long)u4_2 + (long)u2_2 * (long)u3_2;
		long b6 = (long)u2_2 * (long)u4_2 + (long)u3 * (long)u3;
		long b7 = (long)u3 * (long)u4_2;
		long b8 = (long)u4 * (long)u4_2;
		a0 -= b5 * 38;
		a1 -= b6 * 38;
		a2 -= b7 * 38;
		a3 -= b8 * 38;
		a5 -= b0;
		a6 -= b1;
		a7 -= b2;
		a8 -= b3;
		x2 += u0;
		x3 += u1;
		int num2 = num + u2;
		x4 += u3;
		x5 += u4;
		x1_2 = x3 * 2;
		x2_2 = num2 * 2;
		x3_2 = x4 * 2;
		x4_2 = x5 * 2;
		long c0 = (long)x2 * (long)x2;
		long c1 = (long)x2 * (long)x1_2;
		long c2 = (long)x2 * (long)x2_2 + (long)x3 * (long)x3;
		long c3 = (long)x1_2 * (long)x2_2 + (long)x2 * (long)x3_2;
		long c4 = (long)num2 * (long)x2_2 + (long)x2 * (long)x4_2 + (long)x3 * (long)x3_2;
		long c5 = (long)x1_2 * (long)x4_2 + (long)x2_2 * (long)x3_2;
		long c6 = (long)x2_2 * (long)x4_2 + (long)x4 * (long)x4;
		long c7 = (long)x4 * (long)x4_2;
		long c8 = (long)x5 * (long)x4_2;
		long t = a8 + (c3 - a3);
		int z8 = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += c4 - a4 - b4;
		int z9 = (int)t & 0x1FFFFFF;
		t >>= 25;
		t = a0 + (t + c5 - a5) * 38;
		z[0] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a1 + (c6 - a6) * 38;
		z[1] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a2 + (c7 - a7) * 38;
		z[2] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += a3 + (c8 - a8) * 38;
		z[3] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a4 + b4 * 38;
		z[4] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += a5 + (c0 - a0);
		z[5] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a6 + (c1 - a1);
		z[6] = (int)t & 0x3FFFFFF;
		t >>= 26;
		t += a7 + (c2 - a2);
		z[7] = (int)t & 0x1FFFFFF;
		t >>= 25;
		t += z8;
		z[8] = (int)t & 0x3FFFFFF;
		t >>= 26;
		z[9] = z9 + (int)t;
	}

	public static void Sqr(int[] x, int n, int[] z)
	{
		Sqr(x, z);
		while (--n > 0)
		{
			Sqr(z, z);
		}
	}

	public static bool SqrtRatioVar(int[] u, int[] v, int[] z)
	{
		int[] uv3 = Create();
		int[] uv7 = Create();
		Mul(u, v, uv3);
		Sqr(v, uv7);
		Mul(uv3, uv7, uv3);
		Sqr(uv7, uv7);
		Mul(uv7, uv3, uv7);
		int[] t = Create();
		int[] x = Create();
		PowPm5d8(uv7, t, x);
		Mul(x, uv3, x);
		int[] vx2 = Create();
		Sqr(x, vx2);
		Mul(vx2, v, vx2);
		Sub(vx2, u, t);
		Normalize(t);
		if (IsZeroVar(t))
		{
			Copy(x, 0, z, 0);
			return true;
		}
		Add(vx2, u, t);
		Normalize(t);
		if (IsZeroVar(t))
		{
			Mul(x, RootNegOne, z);
			return true;
		}
		return false;
	}

	public static void Sub(int[] x, int[] y, int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = x[i] - y[i];
		}
	}

	public static void SubOne(int[] z)
	{
		z[0]--;
	}

	public static void Zero(int[] z)
	{
		for (int i = 0; i < 10; i++)
		{
			z[i] = 0;
		}
	}
}
