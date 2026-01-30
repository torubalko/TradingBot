using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

[CLSCompliant(false)]
public abstract class X448Field
{
	public const int Size = 16;

	private const uint M28 = 268435455u;

	private static readonly uint[] P32 = new uint[14]
	{
		4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967295u, 4294967294u, 4294967295u, 4294967295u,
		4294967295u, 4294967295u, 4294967295u, 4294967295u
	};

	public static void Add(uint[] x, uint[] y, uint[] z)
	{
		for (int i = 0; i < 16; i++)
		{
			z[i] = x[i] + y[i];
		}
	}

	public static void AddOne(uint[] z)
	{
		z[0]++;
	}

	public static void AddOne(uint[] z, int zOff)
	{
		z[zOff]++;
	}

	public static int AreEqual(uint[] x, uint[] y)
	{
		uint d = 0u;
		for (int i = 0; i < 16; i++)
		{
			d |= x[i] ^ y[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return (int)(d - 1) >> 31;
	}

	public static bool AreEqualVar(uint[] x, uint[] y)
	{
		return AreEqual(x, y) != 0;
	}

	public static void Carry(uint[] z)
	{
		uint z2 = z[0];
		uint z3 = z[1];
		uint z4 = z[2];
		uint z5 = z[3];
		uint z6 = z[4];
		uint z7 = z[5];
		uint z8 = z[6];
		uint z9 = z[7];
		uint z10 = z[8];
		uint z11 = z[9];
		uint z12 = z[10];
		uint z13 = z[11];
		uint z14 = z[12];
		uint z15 = z[13];
		uint z16 = z[14];
		uint z17 = z[15];
		z3 += z2 >> 28;
		z2 &= 0xFFFFFFF;
		z7 += z6 >> 28;
		z6 &= 0xFFFFFFF;
		z11 += z10 >> 28;
		z10 &= 0xFFFFFFF;
		z15 += z14 >> 28;
		z14 &= 0xFFFFFFF;
		z4 += z3 >> 28;
		z3 &= 0xFFFFFFF;
		z8 += z7 >> 28;
		z7 &= 0xFFFFFFF;
		z12 += z11 >> 28;
		z11 &= 0xFFFFFFF;
		z16 += z15 >> 28;
		z15 &= 0xFFFFFFF;
		z5 += z4 >> 28;
		z4 &= 0xFFFFFFF;
		z9 += z8 >> 28;
		z8 &= 0xFFFFFFF;
		z13 += z12 >> 28;
		z12 &= 0xFFFFFFF;
		z17 += z16 >> 28;
		z16 &= 0xFFFFFFF;
		uint t = z17 >> 28;
		z17 &= 0xFFFFFFF;
		z2 += t;
		z10 += t;
		z6 += z5 >> 28;
		z5 &= 0xFFFFFFF;
		z10 += z9 >> 28;
		z9 &= 0xFFFFFFF;
		z14 += z13 >> 28;
		z13 &= 0xFFFFFFF;
		z3 += z2 >> 28;
		z2 &= 0xFFFFFFF;
		z7 += z6 >> 28;
		z6 &= 0xFFFFFFF;
		z11 += z10 >> 28;
		z10 &= 0xFFFFFFF;
		z15 += z14 >> 28;
		z14 &= 0xFFFFFFF;
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
		z[10] = z12;
		z[11] = z13;
		z[12] = z14;
		z[13] = z15;
		z[14] = z16;
		z[15] = z17;
	}

	public static void CMov(int cond, uint[] x, int xOff, uint[] z, int zOff)
	{
		for (int i = 0; i < 16; i++)
		{
			uint z_i = z[zOff + i];
			uint diff = z_i ^ x[xOff + i];
			z_i ^= diff & (uint)cond;
			z[zOff + i] = z_i;
		}
	}

	public static void CNegate(int negate, uint[] z)
	{
		uint[] t = Create();
		Sub(t, z, t);
		CMov(-negate, t, 0, z, 0);
	}

	public static void Copy(uint[] x, int xOff, uint[] z, int zOff)
	{
		for (int i = 0; i < 16; i++)
		{
			z[zOff + i] = x[xOff + i];
		}
	}

	public static uint[] Create()
	{
		return new uint[16];
	}

	public static uint[] CreateTable(int n)
	{
		return new uint[16 * n];
	}

	public static void CSwap(int swap, uint[] a, uint[] b)
	{
		uint mask = (uint)(-swap);
		for (int i = 0; i < 16; i++)
		{
			uint ai = a[i];
			uint bi = b[i];
			uint dummy = mask & (ai ^ bi);
			a[i] = ai ^ dummy;
			b[i] = bi ^ dummy;
		}
	}

	public static void Decode(uint[] x, int xOff, uint[] z)
	{
		Decode224(x, xOff, z, 0);
		Decode224(x, xOff + 7, z, 8);
	}

	public static void Decode(byte[] x, int xOff, uint[] z)
	{
		Decode56(x, xOff, z, 0);
		Decode56(x, xOff + 7, z, 2);
		Decode56(x, xOff + 14, z, 4);
		Decode56(x, xOff + 21, z, 6);
		Decode56(x, xOff + 28, z, 8);
		Decode56(x, xOff + 35, z, 10);
		Decode56(x, xOff + 42, z, 12);
		Decode56(x, xOff + 49, z, 14);
	}

	private static void Decode224(uint[] x, int xOff, uint[] z, int zOff)
	{
		uint x2 = x[xOff];
		uint x3 = x[xOff + 1];
		uint x4 = x[xOff + 2];
		uint x5 = x[xOff + 3];
		uint x6 = x[xOff + 4];
		uint x7 = x[xOff + 5];
		uint x8 = x[xOff + 6];
		z[zOff] = x2 & 0xFFFFFFF;
		z[zOff + 1] = ((x2 >> 28) | (x3 << 4)) & 0xFFFFFFF;
		z[zOff + 2] = ((x3 >> 24) | (x4 << 8)) & 0xFFFFFFF;
		z[zOff + 3] = ((x4 >> 20) | (x5 << 12)) & 0xFFFFFFF;
		z[zOff + 4] = ((x5 >> 16) | (x6 << 16)) & 0xFFFFFFF;
		z[zOff + 5] = ((x6 >> 12) | (x7 << 20)) & 0xFFFFFFF;
		z[zOff + 6] = ((x7 >> 8) | (x8 << 24)) & 0xFFFFFFF;
		z[zOff + 7] = x8 >> 4;
	}

	private static uint Decode24(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16));
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	private static void Decode56(byte[] bs, int off, uint[] z, int zOff)
	{
		uint lo = Decode32(bs, off);
		uint hi = Decode24(bs, off + 4);
		z[zOff] = lo & 0xFFFFFFF;
		z[zOff + 1] = (lo >> 28) | (hi << 4);
	}

	public static void Encode(uint[] x, uint[] z, int zOff)
	{
		Encode224(x, 0, z, zOff);
		Encode224(x, 8, z, zOff + 7);
	}

	public static void Encode(uint[] x, byte[] z, int zOff)
	{
		Encode56(x, 0, z, zOff);
		Encode56(x, 2, z, zOff + 7);
		Encode56(x, 4, z, zOff + 14);
		Encode56(x, 6, z, zOff + 21);
		Encode56(x, 8, z, zOff + 28);
		Encode56(x, 10, z, zOff + 35);
		Encode56(x, 12, z, zOff + 42);
		Encode56(x, 14, z, zOff + 49);
	}

	private static void Encode224(uint[] x, int xOff, uint[] z, int zOff)
	{
		uint x2 = x[xOff];
		uint x3 = x[xOff + 1];
		uint x4 = x[xOff + 2];
		uint x5 = x[xOff + 3];
		uint x6 = x[xOff + 4];
		uint x7 = x[xOff + 5];
		uint x8 = x[xOff + 6];
		uint x9 = x[xOff + 7];
		z[zOff] = x2 | (x3 << 28);
		z[zOff + 1] = (x3 >> 4) | (x4 << 24);
		z[zOff + 2] = (x4 >> 8) | (x5 << 20);
		z[zOff + 3] = (x5 >> 12) | (x6 << 16);
		z[zOff + 4] = (x6 >> 16) | (x7 << 12);
		z[zOff + 5] = (x7 >> 20) | (x8 << 8);
		z[zOff + 6] = (x8 >> 24) | (x9 << 4);
	}

	private static void Encode24(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
	}

	private static void Encode32(uint n, byte[] bs, int off)
	{
		bs[off] = (byte)n;
		bs[++off] = (byte)(n >> 8);
		bs[++off] = (byte)(n >> 16);
		bs[++off] = (byte)(n >> 24);
	}

	private static void Encode56(uint[] x, int xOff, byte[] bs, int off)
	{
		uint num = x[xOff];
		uint hi = x[xOff + 1];
		Encode32(num | (hi << 28), bs, off);
		Encode24(hi >> 4, bs, off + 4);
	}

	public static void Inv(uint[] x, uint[] z)
	{
		uint[] t = Create();
		uint[] u = new uint[14];
		Copy(x, 0, t, 0);
		Normalize(t);
		Encode(t, u, 0);
		Mod.ModOddInverse(P32, u, u);
		Decode(u, 0, z);
	}

	public static void InvVar(uint[] x, uint[] z)
	{
		uint[] t = Create();
		uint[] u = new uint[14];
		Copy(x, 0, t, 0);
		Normalize(t);
		Encode(t, u, 0);
		Mod.ModOddInverseVar(P32, u, u);
		Decode(u, 0, z);
	}

	public static int IsOne(uint[] x)
	{
		uint d = x[0] ^ 1;
		for (int i = 1; i < 16; i++)
		{
			d |= x[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return (int)(d - 1) >> 31;
	}

	public static bool IsOneVar(uint[] x)
	{
		return IsOne(x) != 0;
	}

	public static int IsZero(uint[] x)
	{
		uint d = 0u;
		for (int i = 0; i < 16; i++)
		{
			d |= x[i];
		}
		d |= d >> 16;
		d &= 0xFFFF;
		return (int)(d - 1) >> 31;
	}

	public static bool IsZeroVar(uint[] x)
	{
		return (long)IsZero(x) != 0;
	}

	public static void Mul(uint[] x, uint y, uint[] z)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint x6 = x[4];
		uint x7 = x[5];
		uint x8 = x[6];
		uint x9 = x[7];
		uint x10 = x[8];
		uint x11 = x[9];
		uint x12 = x[10];
		uint x13 = x[11];
		uint x14 = x[12];
		uint num = x[13];
		uint x15 = x[14];
		uint x16 = x[15];
		ulong c = (ulong)x3 * (ulong)y;
		uint z2 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		ulong d = (ulong)x7 * (ulong)y;
		uint z5 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong e = (ulong)x11 * (ulong)y;
		uint z9 = (uint)((int)e & 0xFFFFFFF);
		e >>= 28;
		ulong f = (ulong)num * (ulong)y;
		uint z13 = (uint)((int)f & 0xFFFFFFF);
		f >>= 28;
		c += (ulong)((long)x4 * (long)y);
		z[2] = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += (ulong)((long)x8 * (long)y);
		z[6] = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		e += (ulong)((long)x12 * (long)y);
		z[10] = (uint)((int)e & 0xFFFFFFF);
		e >>= 28;
		f += (ulong)((long)x15 * (long)y);
		z[14] = (uint)((int)f & 0xFFFFFFF);
		f >>= 28;
		c += (ulong)((long)x5 * (long)y);
		z[3] = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += (ulong)((long)x9 * (long)y);
		z[7] = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		e += (ulong)((long)x13 * (long)y);
		z[11] = (uint)((int)e & 0xFFFFFFF);
		e >>= 28;
		f += (ulong)((long)x16 * (long)y);
		z[15] = (uint)((int)f & 0xFFFFFFF);
		f >>= 28;
		d += f;
		c += (ulong)((long)x6 * (long)y);
		z[4] = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += (ulong)((long)x10 * (long)y);
		z[8] = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		e += (ulong)((long)x14 * (long)y);
		z[12] = (uint)((int)e & 0xFFFFFFF);
		e >>= 28;
		f += (ulong)((long)x2 * (long)y);
		z[0] = (uint)((int)f & 0xFFFFFFF);
		f >>= 28;
		z[1] = z2 + (uint)(int)f;
		z[5] = z5 + (uint)(int)c;
		z[9] = z9 + (uint)(int)d;
		z[13] = z13 + (uint)(int)e;
	}

	public static void Mul(uint[] x, uint[] y, uint[] z)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint x6 = x[4];
		uint x7 = x[5];
		uint x8 = x[6];
		uint x9 = x[7];
		uint u0 = x[8];
		uint u1 = x[9];
		uint u2 = x[10];
		uint u3 = x[11];
		uint u4 = x[12];
		uint u5 = x[13];
		uint u6 = x[14];
		uint u7 = x[15];
		uint y2 = y[0];
		uint y3 = y[1];
		uint y4 = y[2];
		uint y5 = y[3];
		uint y6 = y[4];
		uint y7 = y[5];
		uint y8 = y[6];
		uint y9 = y[7];
		uint v0 = y[8];
		uint v1 = y[9];
		uint v2 = y[10];
		uint v3 = y[11];
		uint v4 = y[12];
		uint v5 = y[13];
		uint v6 = y[14];
		uint v7 = y[15];
		uint s0 = x2 + u0;
		uint s1 = x3 + u1;
		uint s2 = x4 + u2;
		uint s3 = x5 + u3;
		uint s4 = x6 + u4;
		uint s5 = x7 + u5;
		uint s6 = x8 + u6;
		uint s7 = x9 + u7;
		uint t0 = y2 + v0;
		uint t1 = y3 + v1;
		uint t2 = y4 + v2;
		uint t3 = y5 + v3;
		uint t4 = y6 + v4;
		uint t5 = y7 + v5;
		uint t6 = y8 + v6;
		uint t7 = y9 + v7;
		ulong f0 = (ulong)x2 * (ulong)y2;
		ulong f8 = (ulong)((long)x9 * (long)y3 + (long)x8 * (long)y4 + (long)x7 * (long)y5 + (long)x6 * (long)y6 + (long)x5 * (long)y7 + (long)x4 * (long)y8 + (long)x3 * (long)y9);
		ulong g0 = (ulong)u0 * (ulong)v0;
		long num = (long)u7 * (long)v1 + (long)u6 * (long)v2 + (long)u5 * (long)v3 + (long)u4 * (long)v4 + (long)u3 * (long)v5 + (long)u2 * (long)v6 + (long)u1 * (long)v7;
		ulong h0 = (ulong)s0 * (ulong)t0;
		ulong h8 = (ulong)((long)s7 * (long)t1 + (long)s6 * (long)t2 + (long)s5 * (long)t3 + (long)s4 * (long)t4 + (long)s3 * (long)t5 + (long)s2 * (long)t6 + (long)s1 * (long)t7);
		ulong c = f0 + g0 + h8 - f8;
		uint z2 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		ulong d = (ulong)(num + (long)h0 - (long)f0) + h8;
		uint z8 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f9 = (ulong)((long)x3 * (long)y2 + (long)x2 * (long)y3);
		ulong f10 = (ulong)((long)x9 * (long)y4 + (long)x8 * (long)y5 + (long)x7 * (long)y6 + (long)x6 * (long)y7 + (long)x5 * (long)y8 + (long)x4 * (long)y9);
		ulong g1 = (ulong)((long)u1 * (long)v0 + (long)u0 * (long)v1);
		ulong g9 = (ulong)((long)u7 * (long)v2 + (long)u6 * (long)v3 + (long)u5 * (long)v4 + (long)u4 * (long)v5 + (long)u3 * (long)v6 + (long)u2 * (long)v7);
		ulong h9 = (ulong)((long)s1 * (long)t0 + (long)s0 * (long)t1);
		ulong h10 = (ulong)((long)s7 * (long)t2 + (long)s6 * (long)t3 + (long)s5 * (long)t4 + (long)s4 * (long)t5 + (long)s3 * (long)t6 + (long)s2 * (long)t7);
		c += f9 + g1 + h10 - f10;
		uint z9 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g9 + h9 - f9 + h10;
		uint z10 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f11 = (ulong)((long)x4 * (long)y2 + (long)x3 * (long)y3 + (long)x2 * (long)y4);
		ulong f12 = (ulong)((long)x9 * (long)y5 + (long)x8 * (long)y6 + (long)x7 * (long)y7 + (long)x6 * (long)y8 + (long)x5 * (long)y9);
		ulong g10 = (ulong)((long)u2 * (long)v0 + (long)u1 * (long)v1 + (long)u0 * (long)v2);
		ulong g11 = (ulong)((long)u7 * (long)v3 + (long)u6 * (long)v4 + (long)u5 * (long)v5 + (long)u4 * (long)v6 + (long)u3 * (long)v7);
		ulong h11 = (ulong)((long)s2 * (long)t0 + (long)s1 * (long)t1 + (long)s0 * (long)t2);
		ulong h12 = (ulong)((long)s7 * (long)t3 + (long)s6 * (long)t4 + (long)s5 * (long)t5 + (long)s4 * (long)t6 + (long)s3 * (long)t7);
		c += f11 + g10 + h12 - f12;
		uint z11 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g11 + h11 - f11 + h12;
		uint z12 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f13 = (ulong)((long)x5 * (long)y2 + (long)x4 * (long)y3 + (long)x3 * (long)y4 + (long)x2 * (long)y5);
		ulong f14 = (ulong)((long)x9 * (long)y6 + (long)x8 * (long)y7 + (long)x7 * (long)y8 + (long)x6 * (long)y9);
		ulong g12 = (ulong)((long)u3 * (long)v0 + (long)u2 * (long)v1 + (long)u1 * (long)v2 + (long)u0 * (long)v3);
		ulong g13 = (ulong)((long)u7 * (long)v4 + (long)u6 * (long)v5 + (long)u5 * (long)v6 + (long)u4 * (long)v7);
		ulong h13 = (ulong)((long)s3 * (long)t0 + (long)s2 * (long)t1 + (long)s1 * (long)t2 + (long)s0 * (long)t3);
		ulong h14 = (ulong)((long)s7 * (long)t4 + (long)s6 * (long)t5 + (long)s5 * (long)t6 + (long)s4 * (long)t7);
		c += f13 + g12 + h14 - f14;
		uint z13 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g13 + h13 - f13 + h14;
		uint z14 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f15 = (ulong)((long)x6 * (long)y2 + (long)x5 * (long)y3 + (long)x4 * (long)y4 + (long)x3 * (long)y5 + (long)x2 * (long)y6);
		ulong f16 = (ulong)((long)x9 * (long)y7 + (long)x8 * (long)y8 + (long)x7 * (long)y9);
		ulong g14 = (ulong)((long)u4 * (long)v0 + (long)u3 * (long)v1 + (long)u2 * (long)v2 + (long)u1 * (long)v3 + (long)u0 * (long)v4);
		ulong g15 = (ulong)((long)u7 * (long)v5 + (long)u6 * (long)v6 + (long)u5 * (long)v7);
		ulong h15 = (ulong)((long)s4 * (long)t0 + (long)s3 * (long)t1 + (long)s2 * (long)t2 + (long)s1 * (long)t3 + (long)s0 * (long)t4);
		ulong h16 = (ulong)((long)s7 * (long)t5 + (long)s6 * (long)t6 + (long)s5 * (long)t7);
		c += f15 + g14 + h16 - f16;
		uint z15 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g15 + h15 - f15 + h16;
		uint z16 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f17 = (ulong)((long)x7 * (long)y2 + (long)x6 * (long)y3 + (long)x5 * (long)y4 + (long)x4 * (long)y5 + (long)x3 * (long)y6 + (long)x2 * (long)y7);
		ulong f18 = (ulong)((long)x9 * (long)y8 + (long)x8 * (long)y9);
		ulong g16 = (ulong)((long)u5 * (long)v0 + (long)u4 * (long)v1 + (long)u3 * (long)v2 + (long)u2 * (long)v3 + (long)u1 * (long)v4 + (long)u0 * (long)v5);
		ulong g17 = (ulong)((long)u7 * (long)v6 + (long)u6 * (long)v7);
		ulong h17 = (ulong)((long)s5 * (long)t0 + (long)s4 * (long)t1 + (long)s3 * (long)t2 + (long)s2 * (long)t3 + (long)s1 * (long)t4 + (long)s0 * (long)t5);
		ulong h18 = (ulong)((long)s7 * (long)t6 + (long)s6 * (long)t7);
		c += f17 + g16 + h18 - f18;
		uint z17 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g17 + h17 - f17 + h18;
		uint z18 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f19 = (ulong)((long)x8 * (long)y2 + (long)x7 * (long)y3 + (long)x6 * (long)y4 + (long)x5 * (long)y5 + (long)x4 * (long)y6 + (long)x3 * (long)y7 + (long)x2 * (long)y8);
		ulong f20 = (ulong)x9 * (ulong)y9;
		ulong g18 = (ulong)((long)u6 * (long)v0 + (long)u5 * (long)v1 + (long)u4 * (long)v2 + (long)u3 * (long)v3 + (long)u2 * (long)v4 + (long)u1 * (long)v5 + (long)u0 * (long)v6);
		ulong g19 = (ulong)u7 * (ulong)v7;
		ulong h19 = (ulong)((long)s6 * (long)t0 + (long)s5 * (long)t1 + (long)s4 * (long)t2 + (long)s3 * (long)t3 + (long)s2 * (long)t4 + (long)s1 * (long)t5 + (long)s0 * (long)t6);
		ulong h20 = (ulong)s7 * (ulong)t7;
		c += f19 + g18 + h20 - f20;
		uint z19 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g19 + h19 - f19 + h20;
		uint z20 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f21 = (ulong)((long)x9 * (long)y2 + (long)x8 * (long)y3 + (long)x7 * (long)y4 + (long)x6 * (long)y5 + (long)x5 * (long)y6 + (long)x4 * (long)y7 + (long)x3 * (long)y8 + (long)x2 * (long)y9);
		ulong g20 = (ulong)((long)u7 * (long)v0 + (long)u6 * (long)v1 + (long)u5 * (long)v2 + (long)u4 * (long)v3 + (long)u3 * (long)v4 + (long)u2 * (long)v5 + (long)u1 * (long)v6 + (long)u0 * (long)v7);
		ulong h21 = (ulong)((long)s7 * (long)t0 + (long)s6 * (long)t1 + (long)s5 * (long)t2 + (long)s4 * (long)t3 + (long)s3 * (long)t4 + (long)s2 * (long)t5 + (long)s1 * (long)t6 + (long)s0 * (long)t7);
		c += f21 + g20;
		uint z21 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += h21 - f21;
		uint z22 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		c += d;
		c += z8;
		z8 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += z2;
		z2 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		z10 += (uint)(int)c;
		z9 += (uint)(int)d;
		z[0] = z2;
		z[1] = z9;
		z[2] = z11;
		z[3] = z13;
		z[4] = z15;
		z[5] = z17;
		z[6] = z19;
		z[7] = z21;
		z[8] = z8;
		z[9] = z10;
		z[10] = z12;
		z[11] = z14;
		z[12] = z16;
		z[13] = z18;
		z[14] = z20;
		z[15] = z22;
	}

	public static void Negate(uint[] x, uint[] z)
	{
		Sub(Create(), x, z);
	}

	public static void Normalize(uint[] z)
	{
		Reduce(z, 1);
		Reduce(z, -1);
	}

	public static void One(uint[] z)
	{
		z[0] = 1u;
		for (int i = 1; i < 16; i++)
		{
			z[i] = 0u;
		}
	}

	private static void PowPm3d4(uint[] x, uint[] z)
	{
		uint[] x2 = Create();
		Sqr(x, x2);
		Mul(x, x2, x2);
		uint[] x3 = Create();
		Sqr(x2, x3);
		Mul(x, x3, x3);
		uint[] x6 = Create();
		Sqr(x3, 3, x6);
		Mul(x3, x6, x6);
		uint[] x9 = Create();
		Sqr(x6, 3, x9);
		Mul(x3, x9, x9);
		uint[] x18 = Create();
		Sqr(x9, 9, x18);
		Mul(x9, x18, x18);
		uint[] x19 = Create();
		Sqr(x18, x19);
		Mul(x, x19, x19);
		uint[] x37 = Create();
		Sqr(x19, 18, x37);
		Mul(x18, x37, x37);
		uint[] x74 = Create();
		Sqr(x37, 37, x74);
		Mul(x37, x74, x74);
		uint[] x111 = Create();
		Sqr(x74, 37, x111);
		Mul(x37, x111, x111);
		uint[] x222 = Create();
		Sqr(x111, 111, x222);
		Mul(x111, x222, x222);
		uint[] x223 = Create();
		Sqr(x222, x223);
		Mul(x, x223, x223);
		uint[] t = Create();
		Sqr(x223, 223, t);
		Mul(t, x222, z);
	}

	private static void Reduce(uint[] z, int x)
	{
		uint num = z[15];
		uint z15 = num & 0xFFFFFFF;
		int t = (int)(num >> 28) + x;
		long cc = t;
		for (int i = 0; i < 8; i++)
		{
			cc += z[i];
			z[i] = (uint)((int)cc & 0xFFFFFFF);
			cc >>= 28;
		}
		cc += t;
		for (int j = 8; j < 15; j++)
		{
			cc += z[j];
			z[j] = (uint)((int)cc & 0xFFFFFFF);
			cc >>= 28;
		}
		z[15] = z15 + (uint)(int)cc;
	}

	public static void Sqr(uint[] x, uint[] z)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint x6 = x[4];
		uint x7 = x[5];
		uint x8 = x[6];
		uint x9 = x[7];
		uint u0 = x[8];
		uint u1 = x[9];
		uint u2 = x[10];
		uint u3 = x[11];
		uint u4 = x[12];
		uint u5 = x[13];
		uint u6 = x[14];
		uint u7 = x[15];
		uint x0_2 = x2 * 2;
		uint x1_2 = x3 * 2;
		uint x2_2 = x4 * 2;
		uint x3_2 = x5 * 2;
		uint x4_2 = x6 * 2;
		uint x5_2 = x7 * 2;
		uint x6_2 = x8 * 2;
		uint u0_2 = u0 * 2;
		uint u1_2 = u1 * 2;
		uint u2_2 = u2 * 2;
		uint u3_2 = u3 * 2;
		uint u4_2 = u4 * 2;
		uint u5_2 = u5 * 2;
		uint u6_2 = u6 * 2;
		uint s0 = x2 + u0;
		uint s1 = x3 + u1;
		uint s2 = x4 + u2;
		uint s3 = x5 + u3;
		uint s4 = x6 + u4;
		uint s5 = x7 + u5;
		uint s6 = x8 + u6;
		uint s7 = x9 + u7;
		uint s0_2 = s0 * 2;
		uint s1_2 = s1 * 2;
		uint s2_2 = s2 * 2;
		uint s3_2 = s3 * 2;
		uint s4_2 = s4 * 2;
		uint s5_2 = s5 * 2;
		uint s6_2 = s6 * 2;
		ulong f0 = (ulong)x2 * (ulong)x2;
		ulong f8 = (ulong)((long)x9 * (long)x1_2 + (long)x8 * (long)x2_2 + (long)x7 * (long)x3_2 + (long)x6 * (long)x6);
		ulong g0 = (ulong)u0 * (ulong)u0;
		long num = (long)u7 * (long)u1_2 + (long)u6 * (long)u2_2 + (long)u5 * (long)u3_2 + (long)u4 * (long)u4;
		ulong h0 = (ulong)s0 * (ulong)s0;
		ulong h8 = (ulong)((long)s7 * (long)s1_2 + (long)s6 * (long)s2_2 + (long)s5 * (long)s3_2 + (long)s4 * (long)s4);
		ulong c = f0 + g0 + h8 - f8;
		uint z2 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		ulong d = (ulong)(num + (long)h0 - (long)f0) + h8;
		uint z8 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f9 = (ulong)x3 * (ulong)x0_2;
		ulong f10 = (ulong)((long)x9 * (long)x2_2 + (long)x8 * (long)x3_2 + (long)x7 * (long)x4_2);
		ulong g1 = (ulong)u1 * (ulong)u0_2;
		ulong g9 = (ulong)((long)u7 * (long)u2_2 + (long)u6 * (long)u3_2 + (long)u5 * (long)u4_2);
		ulong h9 = (ulong)s1 * (ulong)s0_2;
		ulong h10 = (ulong)((long)s7 * (long)s2_2 + (long)s6 * (long)s3_2 + (long)s5 * (long)s4_2);
		c += f9 + g1 + h10 - f10;
		uint z9 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g9 + h9 - f9 + h10;
		uint z10 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f11 = (ulong)((long)x4 * (long)x0_2 + (long)x3 * (long)x3);
		ulong f12 = (ulong)((long)x9 * (long)x3_2 + (long)x8 * (long)x4_2 + (long)x7 * (long)x7);
		ulong g10 = (ulong)((long)u2 * (long)u0_2 + (long)u1 * (long)u1);
		ulong g11 = (ulong)((long)u7 * (long)u3_2 + (long)u6 * (long)u4_2 + (long)u5 * (long)u5);
		ulong h11 = (ulong)((long)s2 * (long)s0_2 + (long)s1 * (long)s1);
		ulong h12 = (ulong)((long)s7 * (long)s3_2 + (long)s6 * (long)s4_2 + (long)s5 * (long)s5);
		c += f11 + g10 + h12 - f12;
		uint z11 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g11 + h11 - f11 + h12;
		uint z12 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f13 = (ulong)((long)x5 * (long)x0_2 + (long)x4 * (long)x1_2);
		ulong f14 = (ulong)((long)x9 * (long)x4_2 + (long)x8 * (long)x5_2);
		ulong g12 = (ulong)((long)u3 * (long)u0_2 + (long)u2 * (long)u1_2);
		ulong g13 = (ulong)((long)u7 * (long)u4_2 + (long)u6 * (long)u5_2);
		ulong h13 = (ulong)((long)s3 * (long)s0_2 + (long)s2 * (long)s1_2);
		ulong h14 = (ulong)((long)s7 * (long)s4_2 + (long)s6 * (long)s5_2);
		c += f13 + g12 + h14 - f14;
		uint z13 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g13 + h13 - f13 + h14;
		uint z14 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f15 = (ulong)((long)x6 * (long)x0_2 + (long)x5 * (long)x1_2 + (long)x4 * (long)x4);
		ulong f16 = (ulong)((long)x9 * (long)x5_2 + (long)x8 * (long)x8);
		ulong g14 = (ulong)((long)u4 * (long)u0_2 + (long)u3 * (long)u1_2 + (long)u2 * (long)u2);
		ulong g15 = (ulong)((long)u7 * (long)u5_2 + (long)u6 * (long)u6);
		ulong h15 = (ulong)((long)s4 * (long)s0_2 + (long)s3 * (long)s1_2 + (long)s2 * (long)s2);
		ulong h16 = (ulong)((long)s7 * (long)s5_2 + (long)s6 * (long)s6);
		c += f15 + g14 + h16 - f16;
		uint z15 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g15 + h15 - f15 + h16;
		uint z16 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f17 = (ulong)((long)x7 * (long)x0_2 + (long)x6 * (long)x1_2 + (long)x5 * (long)x2_2);
		ulong f18 = (ulong)x9 * (ulong)x6_2;
		ulong g16 = (ulong)((long)u5 * (long)u0_2 + (long)u4 * (long)u1_2 + (long)u3 * (long)u2_2);
		ulong g17 = (ulong)u7 * (ulong)u6_2;
		ulong h17 = (ulong)((long)s5 * (long)s0_2 + (long)s4 * (long)s1_2 + (long)s3 * (long)s2_2);
		ulong h18 = (ulong)s7 * (ulong)s6_2;
		c += f17 + g16 + h18 - f18;
		uint z17 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g17 + h17 - f17 + h18;
		uint z18 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f19 = (ulong)((long)x8 * (long)x0_2 + (long)x7 * (long)x1_2 + (long)x6 * (long)x2_2 + (long)x5 * (long)x5);
		ulong f20 = (ulong)x9 * (ulong)x9;
		ulong g18 = (ulong)((long)u6 * (long)u0_2 + (long)u5 * (long)u1_2 + (long)u4 * (long)u2_2 + (long)u3 * (long)u3);
		ulong g19 = (ulong)u7 * (ulong)u7;
		ulong h19 = (ulong)((long)s6 * (long)s0_2 + (long)s5 * (long)s1_2 + (long)s4 * (long)s2_2 + (long)s3 * (long)s3);
		ulong h20 = (ulong)s7 * (ulong)s7;
		c += f19 + g18 + h20 - f20;
		uint z19 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += g19 + h19 - f19 + h20;
		uint z20 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		ulong f21 = (ulong)((long)x9 * (long)x0_2 + (long)x8 * (long)x1_2 + (long)x7 * (long)x2_2 + (long)x6 * (long)x3_2);
		ulong g20 = (ulong)((long)u7 * (long)u0_2 + (long)u6 * (long)u1_2 + (long)u5 * (long)u2_2 + (long)u4 * (long)u3_2);
		ulong h21 = (ulong)((long)s7 * (long)s0_2 + (long)s6 * (long)s1_2 + (long)s5 * (long)s2_2 + (long)s4 * (long)s3_2);
		c += f21 + g20;
		uint z21 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += h21 - f21;
		uint z22 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		c += d;
		c += z8;
		z8 = (uint)((int)c & 0xFFFFFFF);
		c >>= 28;
		d += z2;
		z2 = (uint)((int)d & 0xFFFFFFF);
		d >>= 28;
		z10 += (uint)(int)c;
		z9 += (uint)(int)d;
		z[0] = z2;
		z[1] = z9;
		z[2] = z11;
		z[3] = z13;
		z[4] = z15;
		z[5] = z17;
		z[6] = z19;
		z[7] = z21;
		z[8] = z8;
		z[9] = z10;
		z[10] = z12;
		z[11] = z14;
		z[12] = z16;
		z[13] = z18;
		z[14] = z20;
		z[15] = z22;
	}

	public static void Sqr(uint[] x, int n, uint[] z)
	{
		Sqr(x, z);
		while (--n > 0)
		{
			Sqr(z, z);
		}
	}

	public static bool SqrtRatioVar(uint[] u, uint[] v, uint[] z)
	{
		uint[] u3v = Create();
		uint[] u5v3 = Create();
		Sqr(u, u3v);
		Mul(u3v, v, u3v);
		Sqr(u3v, u5v3);
		Mul(u3v, u, u3v);
		Mul(u5v3, u, u5v3);
		Mul(u5v3, v, u5v3);
		uint[] x = Create();
		PowPm3d4(u5v3, x);
		Mul(x, u3v, x);
		uint[] t = Create();
		Sqr(x, t);
		Mul(t, v, t);
		Sub(u, t, t);
		Normalize(t);
		if (IsZeroVar(t))
		{
			Copy(x, 0, z, 0);
			return true;
		}
		return false;
	}

	public static void Sub(uint[] x, uint[] y, uint[] z)
	{
		uint num = x[0];
		uint x2 = x[1];
		uint x3 = x[2];
		uint x4 = x[3];
		uint x5 = x[4];
		uint x6 = x[5];
		uint x7 = x[6];
		uint x8 = x[7];
		uint x9 = x[8];
		uint x10 = x[9];
		uint x11 = x[10];
		uint x12 = x[11];
		uint x13 = x[12];
		uint x14 = x[13];
		uint x15 = x[14];
		uint x16 = x[15];
		uint y2 = y[0];
		uint y3 = y[1];
		uint y4 = y[2];
		uint y5 = y[3];
		uint y6 = y[4];
		uint y7 = y[5];
		uint y8 = y[6];
		uint y9 = y[7];
		uint y10 = y[8];
		uint y11 = y[9];
		uint y12 = y[10];
		uint y13 = y[11];
		uint y14 = y[12];
		uint y15 = y[13];
		uint y16 = y[14];
		uint y17 = y[15];
		uint z2 = num + 536870910 - y2;
		uint z3 = x2 + 536870910 - y3;
		uint z4 = x3 + 536870910 - y4;
		uint z5 = x4 + 536870910 - y5;
		uint z6 = x5 + 536870910 - y6;
		uint z7 = x6 + 536870910 - y7;
		uint z8 = x7 + 536870910 - y8;
		uint z9 = x8 + 536870910 - y9;
		uint z10 = x9 + 536870908 - y10;
		uint z11 = x10 + 536870910 - y11;
		uint z12 = x11 + 536870910 - y12;
		uint z13 = x12 + 536870910 - y13;
		uint z14 = x13 + 536870910 - y14;
		uint z15 = x14 + 536870910 - y15;
		uint z16 = x15 + 536870910 - y16;
		uint z17 = x16 + 536870910 - y17;
		z4 += z3 >> 28;
		z3 &= 0xFFFFFFF;
		z8 += z7 >> 28;
		z7 &= 0xFFFFFFF;
		z12 += z11 >> 28;
		z11 &= 0xFFFFFFF;
		z16 += z15 >> 28;
		z15 &= 0xFFFFFFF;
		z5 += z4 >> 28;
		z4 &= 0xFFFFFFF;
		z9 += z8 >> 28;
		z8 &= 0xFFFFFFF;
		z13 += z12 >> 28;
		z12 &= 0xFFFFFFF;
		z17 += z16 >> 28;
		z16 &= 0xFFFFFFF;
		uint t = z17 >> 28;
		z17 &= 0xFFFFFFF;
		z2 += t;
		z10 += t;
		z6 += z5 >> 28;
		z5 &= 0xFFFFFFF;
		z10 += z9 >> 28;
		z9 &= 0xFFFFFFF;
		z14 += z13 >> 28;
		z13 &= 0xFFFFFFF;
		z3 += z2 >> 28;
		z2 &= 0xFFFFFFF;
		z7 += z6 >> 28;
		z6 &= 0xFFFFFFF;
		z11 += z10 >> 28;
		z10 &= 0xFFFFFFF;
		z15 += z14 >> 28;
		z14 &= 0xFFFFFFF;
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
		z[10] = z12;
		z[11] = z13;
		z[12] = z14;
		z[13] = z15;
		z[14] = z16;
		z[15] = z17;
	}

	public static void SubOne(uint[] z)
	{
		uint[] one = Create();
		one[0] = 1u;
		Sub(z, one, z);
	}

	public static void Zero(uint[] z)
	{
		for (int i = 0; i < 16; i++)
		{
			z[i] = 0u;
		}
	}
}
