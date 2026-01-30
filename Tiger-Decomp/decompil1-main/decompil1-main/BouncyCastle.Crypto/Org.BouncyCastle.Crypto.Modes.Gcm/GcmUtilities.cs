using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm;

internal abstract class GcmUtilities
{
	private const uint E1 = 3774873600u;

	private const ulong E1UL = 16212958658533785600uL;

	internal static byte[] OneAsBytes()
	{
		return new byte[16]
		{
			128, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0
		};
	}

	internal static uint[] OneAsUints()
	{
		return new uint[4] { 2147483648u, 0u, 0u, 0u };
	}

	internal static ulong[] OneAsUlongs()
	{
		return new ulong[2] { 9223372036854775808uL, 0uL };
	}

	internal static byte[] AsBytes(uint[] x)
	{
		return Pack.UInt32_To_BE(x);
	}

	internal static void AsBytes(uint[] x, byte[] z)
	{
		Pack.UInt32_To_BE(x, z, 0);
	}

	internal static byte[] AsBytes(ulong[] x)
	{
		byte[] z = new byte[16];
		Pack.UInt64_To_BE(x, z, 0);
		return z;
	}

	internal static void AsBytes(ulong[] x, byte[] z)
	{
		Pack.UInt64_To_BE(x, z, 0);
	}

	internal static uint[] AsUints(byte[] bs)
	{
		uint[] output = new uint[4];
		Pack.BE_To_UInt32(bs, 0, output);
		return output;
	}

	internal static void AsUints(byte[] bs, uint[] output)
	{
		Pack.BE_To_UInt32(bs, 0, output);
	}

	internal static ulong[] AsUlongs(byte[] x)
	{
		ulong[] z = new ulong[2];
		Pack.BE_To_UInt64(x, 0, z);
		return z;
	}

	internal static void AsUlongs(byte[] x, ulong[] z)
	{
		Pack.BE_To_UInt64(x, 0, z);
	}

	internal static void AsUlongs(byte[] x, ulong[] z, int zOff)
	{
		Pack.BE_To_UInt64(x, 0, z, zOff, 2);
	}

	internal static void Copy(uint[] x, uint[] z)
	{
		z[0] = x[0];
		z[1] = x[1];
		z[2] = x[2];
		z[3] = x[3];
	}

	internal static void Copy(ulong[] x, ulong[] z)
	{
		z[0] = x[0];
		z[1] = x[1];
	}

	internal static void Copy(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		z[zOff] = x[xOff];
		z[zOff + 1] = x[xOff + 1];
	}

	internal static void DivideP(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong m = (ulong)((long)x2 >> 63);
		x2 ^= m & 0xE100000000000000uL;
		z[0] = (x2 << 1) | (x3 >> 63);
		z[1] = (x3 << 1) | (0L - m);
	}

	internal static void DivideP(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		ulong x2 = x[xOff];
		ulong x3 = x[xOff + 1];
		ulong m = (ulong)((long)x2 >> 63);
		x2 ^= m & 0xE100000000000000uL;
		z[zOff] = (x2 << 1) | (x3 >> 63);
		z[zOff + 1] = (x3 << 1) | (0L - m);
	}

	internal static void Multiply(byte[] x, byte[] y)
	{
		ulong[] x2 = AsUlongs(x);
		ulong[] t2 = AsUlongs(y);
		Multiply(x2, t2);
		AsBytes(x2, x);
	}

	internal static void Multiply(uint[] x, uint[] y)
	{
		uint y2 = y[0];
		uint y3 = y[1];
		uint y4 = y[2];
		uint y5 = y[3];
		uint z0 = 0u;
		uint z1 = 0u;
		uint z2 = 0u;
		uint z3 = 0u;
		for (int i = 0; i < 4; i++)
		{
			int bits = (int)x[i];
			for (int j = 0; j < 32; j++)
			{
				uint m1 = (uint)(bits >> 31);
				bits <<= 1;
				z0 ^= y2 & m1;
				z1 ^= y3 & m1;
				z2 ^= y4 & m1;
				z3 ^= y5 & m1;
				uint m2 = (uint)((int)(y5 << 31) >> 8);
				y5 = (y5 >> 1) | (y4 << 31);
				y4 = (y4 >> 1) | (y3 << 31);
				y3 = (y3 >> 1) | (y2 << 31);
				y2 = (y2 >> 1) ^ (m2 & 0xE1000000u);
			}
		}
		x[0] = z0;
		x[1] = z1;
		x[2] = z2;
		x[3] = z3;
	}

	internal static void Multiply(ulong[] x, ulong[] y)
	{
		ulong num = x[0];
		ulong x2 = x[1];
		ulong y2 = y[0];
		ulong y3 = y[1];
		ulong x0r = Longs.Reverse(num);
		ulong x1r = Longs.Reverse(x2);
		ulong y0r = Longs.Reverse(y2);
		ulong y1r = Longs.Reverse(y3);
		ulong h0 = Longs.Reverse(ImplMul64(x0r, y0r));
		ulong h1 = ImplMul64(num, y2) << 1;
		ulong h2 = Longs.Reverse(ImplMul64(x1r, y1r));
		ulong h3 = ImplMul64(x2, y3) << 1;
		ulong h4 = Longs.Reverse(ImplMul64(x0r ^ x1r, y0r ^ y1r));
		ulong h5 = ImplMul64(num ^ x2, y2 ^ y3) << 1;
		ulong z0 = h0;
		ulong z1 = h1 ^ h0 ^ h2 ^ h4;
		ulong z2 = h2 ^ h1 ^ h3 ^ h5;
		ulong z3 = h3;
		z1 ^= z3 ^ (z3 >> 1) ^ (z3 >> 2) ^ (z3 >> 7);
		z2 ^= (z3 << 62) ^ (z3 << 57);
		z0 ^= z2 ^ (z2 >> 1) ^ (z2 >> 2) ^ (z2 >> 7);
		z1 ^= (z2 << 63) ^ (z2 << 62) ^ (z2 << 57);
		x[0] = z0;
		x[1] = z1;
	}

	internal static void MultiplyP(uint[] x)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint m = (uint)((int)(x5 << 31) >> 31);
		x[0] = (x2 >> 1) ^ (m & 0xE1000000u);
		x[1] = (x3 >> 1) | (x2 << 31);
		x[2] = (x4 >> 1) | (x3 << 31);
		x[3] = (x5 >> 1) | (x4 << 31);
	}

	internal static void MultiplyP(uint[] x, uint[] z)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint m = (uint)((int)(x5 << 31) >> 31);
		z[0] = (x2 >> 1) ^ (m & 0xE1000000u);
		z[1] = (x3 >> 1) | (x2 << 31);
		z[2] = (x4 >> 1) | (x3 << 31);
		z[3] = (x5 >> 1) | (x4 << 31);
	}

	internal static void MultiplyP(ulong[] x)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong m = (ulong)((long)(x3 << 63) >> 63);
		x[0] = (x2 >> 1) ^ (m & 0xE100000000000000uL);
		x[1] = (x3 >> 1) | (x2 << 63);
	}

	internal static void MultiplyP(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong m = (ulong)((long)(x3 << 63) >> 63);
		z[0] = (x2 >> 1) ^ (m & 0xE100000000000000uL);
		z[1] = (x3 >> 1) | (x2 << 63);
	}

	internal static void MultiplyP3(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong c = x3 << 61;
		z[0] = (x2 >> 3) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[1] = (x3 >> 3) | (x2 << 61);
	}

	internal static void MultiplyP3(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		ulong x2 = x[xOff];
		ulong x3 = x[xOff + 1];
		ulong c = x3 << 61;
		z[zOff] = (x2 >> 3) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[zOff + 1] = (x3 >> 3) | (x2 << 61);
	}

	internal static void MultiplyP4(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong c = x3 << 60;
		z[0] = (x2 >> 4) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[1] = (x3 >> 4) | (x2 << 60);
	}

	internal static void MultiplyP4(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		ulong x2 = x[xOff];
		ulong x3 = x[xOff + 1];
		ulong c = x3 << 60;
		z[zOff] = (x2 >> 4) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[zOff + 1] = (x3 >> 4) | (x2 << 60);
	}

	internal static void MultiplyP7(ulong[] x, ulong[] z)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong c = x3 << 57;
		z[0] = (x2 >> 7) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[1] = (x3 >> 7) | (x2 << 57);
	}

	internal static void MultiplyP7(ulong[] x, int xOff, ulong[] z, int zOff)
	{
		ulong x2 = x[xOff];
		ulong x3 = x[xOff + 1];
		ulong c = x3 << 57;
		z[zOff] = (x2 >> 7) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		z[zOff + 1] = (x3 >> 7) | (x2 << 57);
	}

	internal static void MultiplyP8(uint[] x)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint c = x5 << 24;
		x[0] = (x2 >> 8) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		x[1] = (x3 >> 8) | (x2 << 24);
		x[2] = (x4 >> 8) | (x3 << 24);
		x[3] = (x5 >> 8) | (x4 << 24);
	}

	internal static void MultiplyP8(uint[] x, uint[] y)
	{
		uint x2 = x[0];
		uint x3 = x[1];
		uint x4 = x[2];
		uint x5 = x[3];
		uint c = x5 << 24;
		y[0] = (x2 >> 8) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		y[1] = (x3 >> 8) | (x2 << 24);
		y[2] = (x4 >> 8) | (x3 << 24);
		y[3] = (x5 >> 8) | (x4 << 24);
	}

	internal static void MultiplyP8(ulong[] x)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong c = x3 << 56;
		x[0] = (x2 >> 8) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		x[1] = (x3 >> 8) | (x2 << 56);
	}

	internal static void MultiplyP8(ulong[] x, ulong[] y)
	{
		ulong x2 = x[0];
		ulong x3 = x[1];
		ulong c = x3 << 56;
		y[0] = (x2 >> 8) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		y[1] = (x3 >> 8) | (x2 << 56);
	}

	internal static void MultiplyP8(ulong[] x, int xOff, ulong[] y, int yOff)
	{
		ulong x2 = x[xOff];
		ulong x3 = x[xOff + 1];
		ulong c = x3 << 56;
		y[yOff] = (x2 >> 8) ^ c ^ (c >> 1) ^ (c >> 2) ^ (c >> 7);
		y[yOff + 1] = (x3 >> 8) | (x2 << 56);
	}

	internal static void Square(ulong[] x, ulong[] z)
	{
		ulong[] t = new ulong[4];
		Interleave.Expand64To128Rev(x[0], t, 0);
		Interleave.Expand64To128Rev(x[1], t, 2);
		ulong z2 = t[0];
		ulong z3 = t[1];
		ulong z4 = t[2];
		ulong z5 = t[3];
		z3 ^= z5 ^ (z5 >> 1) ^ (z5 >> 2) ^ (z5 >> 7);
		z4 ^= (z5 << 62) ^ (z5 << 57);
		z2 ^= z4 ^ (z4 >> 1) ^ (z4 >> 2) ^ (z4 >> 7);
		z3 ^= (z4 << 63) ^ (z4 << 62) ^ (z4 << 57);
		z[0] = z2;
		z[1] = z3;
	}

	internal static void Xor(byte[] x, byte[] y)
	{
		int i = 0;
		do
		{
			x[i] ^= y[i];
			i++;
			x[i] ^= y[i];
			i++;
			x[i] ^= y[i];
			i++;
			x[i] ^= y[i];
			i++;
		}
		while (i < 16);
	}

	internal static void Xor(byte[] x, byte[] y, int yOff)
	{
		int i = 0;
		do
		{
			x[i] ^= y[yOff + i];
			i++;
			x[i] ^= y[yOff + i];
			i++;
			x[i] ^= y[yOff + i];
			i++;
			x[i] ^= y[yOff + i];
			i++;
		}
		while (i < 16);
	}

	internal static void Xor(byte[] x, int xOff, byte[] y, int yOff, byte[] z, int zOff)
	{
		int i = 0;
		do
		{
			z[zOff + i] = (byte)(x[xOff + i] ^ y[yOff + i]);
			i++;
			z[zOff + i] = (byte)(x[xOff + i] ^ y[yOff + i]);
			i++;
			z[zOff + i] = (byte)(x[xOff + i] ^ y[yOff + i]);
			i++;
			z[zOff + i] = (byte)(x[xOff + i] ^ y[yOff + i]);
			i++;
		}
		while (i < 16);
	}

	internal static void Xor(byte[] x, byte[] y, int yOff, int yLen)
	{
		while (--yLen >= 0)
		{
			x[yLen] ^= y[yOff + yLen];
		}
	}

	internal static void Xor(byte[] x, int xOff, byte[] y, int yOff, int len)
	{
		while (--len >= 0)
		{
			x[xOff + len] ^= y[yOff + len];
		}
	}

	internal static void Xor(byte[] x, byte[] y, byte[] z)
	{
		int i = 0;
		do
		{
			z[i] = (byte)(x[i] ^ y[i]);
			i++;
			z[i] = (byte)(x[i] ^ y[i]);
			i++;
			z[i] = (byte)(x[i] ^ y[i]);
			i++;
			z[i] = (byte)(x[i] ^ y[i]);
			i++;
		}
		while (i < 16);
	}

	internal static void Xor(uint[] x, uint[] y)
	{
		x[0] ^= y[0];
		x[1] ^= y[1];
		x[2] ^= y[2];
		x[3] ^= y[3];
	}

	internal static void Xor(uint[] x, uint[] y, uint[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
		z[2] = x[2] ^ y[2];
		z[3] = x[3] ^ y[3];
	}

	internal static void Xor(ulong[] x, ulong[] y)
	{
		x[0] ^= y[0];
		x[1] ^= y[1];
	}

	internal static void Xor(ulong[] x, int xOff, ulong[] y, int yOff)
	{
		x[xOff] ^= y[yOff];
		x[xOff + 1] ^= y[yOff + 1];
	}

	internal static void Xor(ulong[] x, ulong[] y, ulong[] z)
	{
		z[0] = x[0] ^ y[0];
		z[1] = x[1] ^ y[1];
	}

	internal static void Xor(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
	{
		z[zOff] = x[xOff] ^ y[yOff];
		z[zOff + 1] = x[xOff + 1] ^ y[yOff + 1];
	}

	private static ulong ImplMul64(ulong x, ulong y)
	{
		ulong num = x & 0x1111111111111111L;
		ulong x2 = x & 0x2222222222222222L;
		ulong x3 = x & 0x4444444444444444L;
		ulong x4 = x & 0x8888888888888888uL;
		ulong y2 = y & 0x1111111111111111L;
		ulong y3 = y & 0x2222222222222222L;
		ulong y4 = y & 0x4444444444444444L;
		ulong y5 = y & 0x8888888888888888uL;
		ulong z0 = (num * y2) ^ (x2 * y5) ^ (x3 * y4) ^ (x4 * y3);
		ulong z1 = (num * y3) ^ (x2 * y2) ^ (x3 * y5) ^ (x4 * y4);
		ulong z2 = (num * y4) ^ (x2 * y3) ^ (x3 * y2) ^ (x4 * y5);
		ulong z3 = (num * y5) ^ (x2 * y4) ^ (x3 * y3) ^ (x4 * y2);
		z0 &= 0x1111111111111111L;
		z1 &= 0x2222222222222222L;
		z2 &= 0x4444444444444444L;
		z3 &= 0x8888888888888888uL;
		return z0 | z1 | z2 | z3;
	}
}
