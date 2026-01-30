using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X448
{
	private class F : X448Field
	{
	}

	public const int PointSize = 56;

	public const int ScalarSize = 56;

	private const uint C_A = 156326u;

	private const uint C_A24 = 39082u;

	public static bool CalculateAgreement(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		ScalarMult(k, kOff, u, uOff, r, rOff);
		return !Arrays.AreAllZeroes(r, rOff, 56);
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		for (int i = 0; i < 14; i++)
		{
			n[i] = Decode32(k, kOff + i * 4);
		}
		n[0] &= 4294967292u;
		n[13] |= 2147483648u;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
		random.NextBytes(k);
		k[0] &= 252;
		k[55] |= 128;
	}

	public static void GeneratePublicKey(byte[] k, int kOff, byte[] r, int rOff)
	{
		ScalarMultBase(k, kOff, r, rOff);
	}

	private static void PointDouble(uint[] x, uint[] z)
	{
		uint[] a = X448Field.Create();
		uint[] b = X448Field.Create();
		X448Field.Add(x, z, a);
		X448Field.Sub(x, z, b);
		X448Field.Sqr(a, a);
		X448Field.Sqr(b, b);
		X448Field.Mul(a, b, x);
		X448Field.Sub(a, b, a);
		X448Field.Mul(a, 39082u, z);
		X448Field.Add(z, b, z);
		X448Field.Mul(z, a, z);
	}

	public static void Precompute()
	{
		Ed448.Precompute();
	}

	public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		uint[] n = new uint[14];
		DecodeScalar(k, kOff, n);
		uint[] x1 = X448Field.Create();
		X448Field.Decode(u, uOff, x1);
		uint[] x2 = X448Field.Create();
		X448Field.Copy(x1, 0, x2, 0);
		uint[] z2 = X448Field.Create();
		z2[0] = 1u;
		uint[] x3 = X448Field.Create();
		x3[0] = 1u;
		uint[] z3 = X448Field.Create();
		uint[] t1 = X448Field.Create();
		uint[] t2 = X448Field.Create();
		int bit = 447;
		int swap = 1;
		do
		{
			X448Field.Add(x3, z3, t1);
			X448Field.Sub(x3, z3, x3);
			X448Field.Add(x2, z2, z3);
			X448Field.Sub(x2, z2, x2);
			X448Field.Mul(t1, x2, t1);
			X448Field.Mul(x3, z3, x3);
			X448Field.Sqr(z3, z3);
			X448Field.Sqr(x2, x2);
			X448Field.Sub(z3, x2, t2);
			X448Field.Mul(t2, 39082u, z2);
			X448Field.Add(z2, x2, z2);
			X448Field.Mul(z2, t2, z2);
			X448Field.Mul(x2, z3, x2);
			X448Field.Sub(t1, x3, z3);
			X448Field.Add(t1, x3, x3);
			X448Field.Sqr(x3, x3);
			X448Field.Sqr(z3, z3);
			X448Field.Mul(z3, x1, z3);
			bit--;
			int word = bit >> 5;
			int shift = bit & 0x1F;
			int kt = (int)((n[word] >> shift) & 1);
			swap ^= kt;
			X448Field.CSwap(swap, x2, x3);
			X448Field.CSwap(swap, z2, z3);
			swap = kt;
		}
		while (bit >= 2);
		for (int i = 0; i < 2; i++)
		{
			PointDouble(x2, z2);
		}
		X448Field.Inv(z2, z2);
		X448Field.Mul(x2, z2, x2);
		X448Field.Normalize(x2);
		X448Field.Encode(x2, r, rOff);
	}

	public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
	{
		uint[] x = X448Field.Create();
		uint[] y = X448Field.Create();
		Ed448.ScalarMultBaseXY(k, kOff, x, y);
		X448Field.Inv(x, x);
		X448Field.Mul(x, y, x);
		X448Field.Sqr(x, x);
		X448Field.Normalize(x);
		X448Field.Encode(x, r, rOff);
	}
}
