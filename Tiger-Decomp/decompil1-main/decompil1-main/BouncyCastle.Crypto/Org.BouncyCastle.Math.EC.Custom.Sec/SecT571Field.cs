using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec;

internal class SecT571Field
{
	private const ulong M59 = 576460752303423487uL;

	private static readonly ulong[] ROOT_Z = new ulong[9] { 3161836309350906777uL, 10804290191530228771uL, 14625517132619890193uL, 7312758566309945096uL, 17890083061325672324uL, 8945041530681231562uL, 13695892802195391589uL, 6847946401097695794uL, 541669439031730457uL };

	public static void Add(ulong[] x, ulong[] y, ulong[] z)
	{
		for (int i = 0; i < 9; i++)
		{
			z[i] = x[i] ^ y[i];
		}
	}

	private static void Add(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
	{
		for (int i = 0; i < 9; i++)
		{
			z[zOff + i] = x[xOff + i] ^ y[yOff + i];
		}
	}

	public static void AddBothTo(ulong[] x, ulong[] y, ulong[] z)
	{
		for (int i = 0; i < 9; i++)
		{
			z[i] ^= x[i] ^ y[i];
		}
	}

	private static void AddBothTo(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
	{
		for (int i = 0; i < 9; i++)
		{
			z[zOff + i] ^= x[xOff + i] ^ y[yOff + i];
		}
	}

	public static void AddExt(ulong[] xx, ulong[] yy, ulong[] zz)
	{
		for (int i = 0; i < 18; i++)
		{
			zz[i] = xx[i] ^ yy[i];
		}
	}

	public static void AddOne(ulong[] x, ulong[] z)
	{
		z[0] = x[0] ^ 1;
		for (int i = 1; i < 9; i++)
		{
			z[i] = x[i];
		}
	}

	private static void AddTo(ulong[] x, ulong[] z)
	{
		for (int i = 0; i < 9; i++)
		{
			z[i] ^= x[i];
		}
	}

	public static ulong[] FromBigInteger(BigInteger x)
	{
		return Nat.FromBigInteger64(571, x);
	}

	public static void HalfTrace(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat576.CreateExt64();
		Nat576.Copy64(x, z);
		for (int i = 1; i < 571; i += 2)
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
		if (Nat576.IsZero64(x))
		{
			throw new InvalidOperationException();
		}
		ulong[] t0 = Nat576.Create64();
		ulong[] t1 = Nat576.Create64();
		ulong[] t2 = Nat576.Create64();
		Square(x, t2);
		Square(t2, t0);
		Square(t0, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 2, t1);
		Multiply(t0, t1, t0);
		Multiply(t0, t2, t0);
		SquareN(t0, 5, t1);
		Multiply(t0, t1, t0);
		SquareN(t1, 5, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 15, t1);
		Multiply(t0, t1, t2);
		SquareN(t2, 30, t0);
		SquareN(t0, 30, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 60, t1);
		Multiply(t0, t1, t0);
		SquareN(t1, 60, t1);
		Multiply(t0, t1, t0);
		SquareN(t0, 180, t1);
		Multiply(t0, t1, t0);
		SquareN(t1, 180, t1);
		Multiply(t0, t1, t0);
		Multiply(t0, t2, z);
	}

	public static void Multiply(ulong[] x, ulong[] y, ulong[] z)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplMultiply(x, y, tt);
		Reduce(tt, z);
	}

	public static void MultiplyAddToExt(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplMultiply(x, y, tt);
		AddExt(zz, tt, zz);
	}

	public static void MultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] z)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplMultiplyPrecomp(x, precomp, tt);
		Reduce(tt, z);
	}

	public static void MultiplyPrecompAddToExt(ulong[] x, ulong[] precomp, ulong[] zz)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplMultiplyPrecomp(x, precomp, tt);
		AddExt(zz, tt, zz);
	}

	public static ulong[] PrecompMultiplicand(ulong[] x)
	{
		int len = 144;
		ulong[] t = new ulong[len << 1];
		Array.Copy(x, 0, t, 9, 9);
		int tOff = 0;
		for (int i = 7; i > 0; i--)
		{
			tOff += 18;
			Nat.ShiftUpBit64(9, t, tOff >> 1, 0uL, t, tOff);
			Reduce5(t, tOff);
			Add(t, 9, t, tOff, t, tOff + 9);
		}
		Nat.ShiftUpBits64(len, t, 0, 4, 0uL, t, len);
		return t;
	}

	public static void Reduce(ulong[] xx, ulong[] z)
	{
		ulong xx9 = xx[9];
		ulong u = xx[17];
		ulong v = xx9;
		xx9 = v ^ (u >> 59) ^ (u >> 57) ^ (u >> 54) ^ (u >> 49);
		v = xx[8] ^ (u << 5) ^ (u << 7) ^ (u << 10) ^ (u << 15);
		for (int i = 16; i >= 10; i--)
		{
			u = xx[i];
			z[i - 8] = v ^ (u >> 59) ^ (u >> 57) ^ (u >> 54) ^ (u >> 49);
			v = xx[i - 9] ^ (u << 5) ^ (u << 7) ^ (u << 10) ^ (u << 15);
		}
		u = xx9;
		z[1] = v ^ (u >> 59) ^ (u >> 57) ^ (u >> 54) ^ (u >> 49);
		v = xx[0] ^ (u << 5) ^ (u << 7) ^ (u << 10) ^ (u << 15);
		ulong x08 = z[8];
		ulong t = x08 >> 59;
		z[0] = v ^ t ^ (t << 2) ^ (t << 5) ^ (t << 10);
		z[8] = x08 & 0x7FFFFFFFFFFFFFFL;
	}

	public static void Reduce5(ulong[] z, int zOff)
	{
		ulong z8 = z[zOff + 8];
		ulong t = z8 >> 59;
		z[zOff] ^= t ^ (t << 2) ^ (t << 5) ^ (t << 10);
		z[zOff + 8] = z8 & 0x7FFFFFFFFFFFFFFL;
	}

	public static void Sqrt(ulong[] x, ulong[] z)
	{
		ulong[] evn = Nat576.Create64();
		ulong[] odd = Nat576.Create64();
		int pos = 0;
		for (int i = 0; i < 4; i++)
		{
			ulong u0 = Interleave.Unshuffle(x[pos++]);
			ulong u1 = Interleave.Unshuffle(x[pos++]);
			evn[i] = (u0 & 0xFFFFFFFFu) | (u1 << 32);
			odd[i] = (u0 >> 32) | (u1 & 0xFFFFFFFF00000000uL);
		}
		ulong u2 = Interleave.Unshuffle(x[pos]);
		evn[4] = u2 & 0xFFFFFFFFu;
		odd[4] = u2 >> 32;
		Multiply(odd, ROOT_Z, z);
		Add(z, evn, z);
	}

	public static void Square(ulong[] x, ulong[] z)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplSquare(x, tt);
		Reduce(tt, z);
	}

	public static void SquareAddToExt(ulong[] x, ulong[] zz)
	{
		ulong[] tt = Nat576.CreateExt64();
		ImplSquare(x, tt);
		AddExt(zz, tt, zz);
	}

	public static void SquareN(ulong[] x, int n, ulong[] z)
	{
		ulong[] tt = Nat576.CreateExt64();
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
		return (uint)((int)(x[0] ^ (x[8] >> 49) ^ (x[8] >> 57)) & 1);
	}

	protected static void ImplMultiply(ulong[] x, ulong[] y, ulong[] zz)
	{
		ulong[] u = new ulong[16];
		for (int i = 0; i < 9; i++)
		{
			ImplMulwAcc(u, x[i], y[i], zz, i << 1);
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
		v0 ^= zz[14];
		zz[7] = v0 ^ v1;
		v1 ^= zz[15];
		v0 ^= zz[16];
		zz[8] = v0 ^ v1;
		v1 ^= zz[17];
		ulong w = v0 ^ v1;
		zz[9] = zz[0] ^ w;
		zz[10] = zz[1] ^ w;
		zz[11] = zz[2] ^ w;
		zz[12] = zz[3] ^ w;
		zz[13] = zz[4] ^ w;
		zz[14] = zz[5] ^ w;
		zz[15] = zz[6] ^ w;
		zz[16] = zz[7] ^ w;
		zz[17] = zz[8] ^ w;
		ImplMulwAcc(u, x[0] ^ x[1], y[0] ^ y[1], zz, 1);
		ImplMulwAcc(u, x[0] ^ x[2], y[0] ^ y[2], zz, 2);
		ImplMulwAcc(u, x[0] ^ x[3], y[0] ^ y[3], zz, 3);
		ImplMulwAcc(u, x[1] ^ x[2], y[1] ^ y[2], zz, 3);
		ImplMulwAcc(u, x[0] ^ x[4], y[0] ^ y[4], zz, 4);
		ImplMulwAcc(u, x[1] ^ x[3], y[1] ^ y[3], zz, 4);
		ImplMulwAcc(u, x[0] ^ x[5], y[0] ^ y[5], zz, 5);
		ImplMulwAcc(u, x[1] ^ x[4], y[1] ^ y[4], zz, 5);
		ImplMulwAcc(u, x[2] ^ x[3], y[2] ^ y[3], zz, 5);
		ImplMulwAcc(u, x[0] ^ x[6], y[0] ^ y[6], zz, 6);
		ImplMulwAcc(u, x[1] ^ x[5], y[1] ^ y[5], zz, 6);
		ImplMulwAcc(u, x[2] ^ x[4], y[2] ^ y[4], zz, 6);
		ImplMulwAcc(u, x[0] ^ x[7], y[0] ^ y[7], zz, 7);
		ImplMulwAcc(u, x[1] ^ x[6], y[1] ^ y[6], zz, 7);
		ImplMulwAcc(u, x[2] ^ x[5], y[2] ^ y[5], zz, 7);
		ImplMulwAcc(u, x[3] ^ x[4], y[3] ^ y[4], zz, 7);
		ImplMulwAcc(u, x[0] ^ x[8], y[0] ^ y[8], zz, 8);
		ImplMulwAcc(u, x[1] ^ x[7], y[1] ^ y[7], zz, 8);
		ImplMulwAcc(u, x[2] ^ x[6], y[2] ^ y[6], zz, 8);
		ImplMulwAcc(u, x[3] ^ x[5], y[3] ^ y[5], zz, 8);
		ImplMulwAcc(u, x[1] ^ x[8], y[1] ^ y[8], zz, 9);
		ImplMulwAcc(u, x[2] ^ x[7], y[2] ^ y[7], zz, 9);
		ImplMulwAcc(u, x[3] ^ x[6], y[3] ^ y[6], zz, 9);
		ImplMulwAcc(u, x[4] ^ x[5], y[4] ^ y[5], zz, 9);
		ImplMulwAcc(u, x[2] ^ x[8], y[2] ^ y[8], zz, 10);
		ImplMulwAcc(u, x[3] ^ x[7], y[3] ^ y[7], zz, 10);
		ImplMulwAcc(u, x[4] ^ x[6], y[4] ^ y[6], zz, 10);
		ImplMulwAcc(u, x[3] ^ x[8], y[3] ^ y[8], zz, 11);
		ImplMulwAcc(u, x[4] ^ x[7], y[4] ^ y[7], zz, 11);
		ImplMulwAcc(u, x[5] ^ x[6], y[5] ^ y[6], zz, 11);
		ImplMulwAcc(u, x[4] ^ x[8], y[4] ^ y[8], zz, 12);
		ImplMulwAcc(u, x[5] ^ x[7], y[5] ^ y[7], zz, 12);
		ImplMulwAcc(u, x[5] ^ x[8], y[5] ^ y[8], zz, 13);
		ImplMulwAcc(u, x[6] ^ x[7], y[6] ^ y[7], zz, 13);
		ImplMulwAcc(u, x[6] ^ x[8], y[6] ^ y[8], zz, 14);
		ImplMulwAcc(u, x[7] ^ x[8], y[7] ^ y[8], zz, 15);
	}

	protected static void ImplMultiplyPrecomp(ulong[] x, ulong[] precomp, ulong[] zz)
	{
		uint MASK = 15u;
		for (int k = 56; k >= 0; k -= 8)
		{
			for (int j = 1; j < 9; j += 2)
			{
				int num = (int)(x[j] >> k);
				uint u = (uint)num & MASK;
				uint v = (uint)(num >>> 4) & MASK;
				AddBothTo(precomp, (int)(9 * u), precomp, (int)(9 * (v + 16)), zz, j - 1);
			}
			Nat.ShiftUpBits64(16, zz, 0, 8, 0uL);
		}
		for (int k2 = 56; k2 >= 0; k2 -= 8)
		{
			for (int i = 0; i < 9; i += 2)
			{
				int num2 = (int)(x[i] >> k2);
				uint u2 = (uint)num2 & MASK;
				uint v2 = (uint)(num2 >>> 4) & MASK;
				AddBothTo(precomp, (int)(9 * u2), precomp, (int)(9 * (v2 + 16)), zz, i);
			}
			if (k2 > 0)
			{
				Nat.ShiftUpBits64(18, zz, 0, 8, 0uL);
			}
		}
	}

	protected static void ImplMulwAcc(ulong[] u, ulong x, ulong y, ulong[] z, int zOff)
	{
		u[1] = y;
		for (int i = 2; i < 16; i += 2)
		{
			u[i] = u[i >> 1] << 1;
			u[i + 1] = u[i] ^ y;
		}
		uint j = (uint)x;
		ulong h = 0uL;
		ulong l = u[j & 0xF] ^ (u[(j >> 4) & 0xF] << 4);
		int k = 56;
		do
		{
			j = (uint)(x >> k);
			ulong g = u[j & 0xF] ^ (u[(j >> 4) & 0xF] << 4);
			l ^= g << k;
			h ^= g >> -k;
		}
		while ((k -= 8) > 0);
		for (int p = 0; p < 7; p++)
		{
			x = (x & 0xFEFEFEFEFEFEFEFEuL) >> 1;
			h ^= x & (ulong)((long)(y << p) >> 63);
		}
		z[zOff] ^= l;
		z[zOff + 1] ^= h;
	}

	protected static void ImplSquare(ulong[] x, ulong[] zz)
	{
		Interleave.Expand64To128(x, 0, 9, zz, 0);
	}
}
