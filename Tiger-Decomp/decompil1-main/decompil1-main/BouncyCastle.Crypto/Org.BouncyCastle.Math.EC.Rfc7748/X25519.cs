using Org.BouncyCastle.Math.EC.Rfc8032;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Rfc7748;

public abstract class X25519
{
	private class F : X25519Field
	{
	}

	public const int PointSize = 32;

	public const int ScalarSize = 32;

	private const int C_A = 486662;

	private const int C_A24 = 121666;

	public static bool CalculateAgreement(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		ScalarMult(k, kOff, u, uOff, r, rOff);
		return !Arrays.AreAllZeroes(r, rOff, 32);
	}

	private static uint Decode32(byte[] bs, int off)
	{
		return (uint)(bs[off] | (bs[++off] << 8) | (bs[++off] << 16) | (bs[++off] << 24));
	}

	private static void DecodeScalar(byte[] k, int kOff, uint[] n)
	{
		for (int i = 0; i < 8; i++)
		{
			n[i] = Decode32(k, kOff + i * 4);
		}
		n[0] &= 4294967288u;
		n[7] &= 2147483647u;
		n[7] |= 1073741824u;
	}

	public static void GeneratePrivateKey(SecureRandom random, byte[] k)
	{
		random.NextBytes(k);
		k[0] &= 248;
		k[31] &= 127;
		k[31] |= 64;
	}

	public static void GeneratePublicKey(byte[] k, int kOff, byte[] r, int rOff)
	{
		ScalarMultBase(k, kOff, r, rOff);
	}

	private static void PointDouble(int[] x, int[] z)
	{
		int[] a = X25519Field.Create();
		int[] b = X25519Field.Create();
		X25519Field.Apm(x, z, a, b);
		X25519Field.Sqr(a, a);
		X25519Field.Sqr(b, b);
		X25519Field.Mul(a, b, x);
		X25519Field.Sub(a, b, a);
		X25519Field.Mul(a, 121666, z);
		X25519Field.Add(z, b, z);
		X25519Field.Mul(z, a, z);
	}

	public static void Precompute()
	{
		Ed25519.Precompute();
	}

	public static void ScalarMult(byte[] k, int kOff, byte[] u, int uOff, byte[] r, int rOff)
	{
		uint[] n = new uint[8];
		DecodeScalar(k, kOff, n);
		int[] x1 = X25519Field.Create();
		X25519Field.Decode(u, uOff, x1);
		int[] x2 = X25519Field.Create();
		X25519Field.Copy(x1, 0, x2, 0);
		int[] z2 = X25519Field.Create();
		z2[0] = 1;
		int[] x3 = X25519Field.Create();
		x3[0] = 1;
		int[] z3 = X25519Field.Create();
		int[] t1 = X25519Field.Create();
		int[] t2 = X25519Field.Create();
		int bit = 254;
		int swap = 1;
		do
		{
			X25519Field.Apm(x3, z3, t1, x3);
			X25519Field.Apm(x2, z2, z3, x2);
			X25519Field.Mul(t1, x2, t1);
			X25519Field.Mul(x3, z3, x3);
			X25519Field.Sqr(z3, z3);
			X25519Field.Sqr(x2, x2);
			X25519Field.Sub(z3, x2, t2);
			X25519Field.Mul(t2, 121666, z2);
			X25519Field.Add(z2, x2, z2);
			X25519Field.Mul(z2, t2, z2);
			X25519Field.Mul(x2, z3, x2);
			X25519Field.Apm(t1, x3, x3, z3);
			X25519Field.Sqr(x3, x3);
			X25519Field.Sqr(z3, z3);
			X25519Field.Mul(z3, x1, z3);
			bit--;
			int word = bit >> 5;
			int shift = bit & 0x1F;
			int kt = (int)((n[word] >> shift) & 1);
			swap ^= kt;
			X25519Field.CSwap(swap, x2, x3);
			X25519Field.CSwap(swap, z2, z3);
			swap = kt;
		}
		while (bit >= 3);
		for (int i = 0; i < 3; i++)
		{
			PointDouble(x2, z2);
		}
		X25519Field.Inv(z2, z2);
		X25519Field.Mul(x2, z2, x2);
		X25519Field.Normalize(x2);
		X25519Field.Encode(x2, r, rOff);
	}

	public static void ScalarMultBase(byte[] k, int kOff, byte[] r, int rOff)
	{
		int[] y = X25519Field.Create();
		int[] z = X25519Field.Create();
		Ed25519.ScalarMultBaseYZ(k, kOff, y, z);
		X25519Field.Apm(z, y, y, z);
		X25519Field.Inv(z, z);
		X25519Field.Mul(y, z, y);
		X25519Field.Normalize(y);
		X25519Field.Encode(y, r, rOff);
	}
}
