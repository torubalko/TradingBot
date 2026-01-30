using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class MD4Digest : GeneralDigest
{
	private const int DigestLength = 16;

	private int H1;

	private int H2;

	private int H3;

	private int H4;

	private int[] X = new int[16];

	private int xOff;

	private const int S11 = 3;

	private const int S12 = 7;

	private const int S13 = 11;

	private const int S14 = 19;

	private const int S21 = 3;

	private const int S22 = 5;

	private const int S23 = 9;

	private const int S24 = 13;

	private const int S31 = 3;

	private const int S32 = 9;

	private const int S33 = 11;

	private const int S34 = 15;

	public override string AlgorithmName => "MD4";

	public MD4Digest()
	{
		Reset();
	}

	public MD4Digest(MD4Digest t)
		: base(t)
	{
		CopyIn(t);
	}

	private void CopyIn(MD4Digest t)
	{
		CopyIn((GeneralDigest)t);
		H1 = t.H1;
		H2 = t.H2;
		H3 = t.H3;
		H4 = t.H4;
		Array.Copy(t.X, 0, X, 0, t.X.Length);
		xOff = t.xOff;
	}

	public override int GetDigestSize()
	{
		return 16;
	}

	internal override void ProcessWord(byte[] input, int inOff)
	{
		X[xOff++] = (input[inOff] & 0xFF) | ((input[inOff + 1] & 0xFF) << 8) | ((input[inOff + 2] & 0xFF) << 16) | ((input[inOff + 3] & 0xFF) << 24);
		if (xOff == 16)
		{
			ProcessBlock();
		}
	}

	internal override void ProcessLength(long bitLength)
	{
		if (xOff > 14)
		{
			ProcessBlock();
		}
		X[14] = (int)(bitLength & 0xFFFFFFFFu);
		X[15] = (int)(bitLength >>> 32);
	}

	private void UnpackWord(int word, byte[] outBytes, int outOff)
	{
		outBytes[outOff] = (byte)word;
		outBytes[outOff + 1] = (byte)((uint)word >> 8);
		outBytes[outOff + 2] = (byte)((uint)word >> 16);
		outBytes[outOff + 3] = (byte)((uint)word >> 24);
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		Finish();
		UnpackWord(H1, output, outOff);
		UnpackWord(H2, output, outOff + 4);
		UnpackWord(H3, output, outOff + 8);
		UnpackWord(H4, output, outOff + 12);
		Reset();
		return 16;
	}

	public override void Reset()
	{
		base.Reset();
		H1 = 1732584193;
		H2 = -271733879;
		H3 = -1732584194;
		H4 = 271733878;
		xOff = 0;
		for (int i = 0; i != X.Length; i++)
		{
			X[i] = 0;
		}
	}

	private int RotateLeft(int x, int n)
	{
		return (x << n) | (x >>> 32 - n);
	}

	private int F(int u, int v, int w)
	{
		return (u & v) | (~u & w);
	}

	private int G(int u, int v, int w)
	{
		return (u & v) | (u & w) | (v & w);
	}

	private int H(int u, int v, int w)
	{
		return u ^ v ^ w;
	}

	internal override void ProcessBlock()
	{
		int a = H1;
		int b = H2;
		int c = H3;
		int d = H4;
		a = RotateLeft(a + F(b, c, d) + X[0], 3);
		d = RotateLeft(d + F(a, b, c) + X[1], 7);
		c = RotateLeft(c + F(d, a, b) + X[2], 11);
		b = RotateLeft(b + F(c, d, a) + X[3], 19);
		a = RotateLeft(a + F(b, c, d) + X[4], 3);
		d = RotateLeft(d + F(a, b, c) + X[5], 7);
		c = RotateLeft(c + F(d, a, b) + X[6], 11);
		b = RotateLeft(b + F(c, d, a) + X[7], 19);
		a = RotateLeft(a + F(b, c, d) + X[8], 3);
		d = RotateLeft(d + F(a, b, c) + X[9], 7);
		c = RotateLeft(c + F(d, a, b) + X[10], 11);
		b = RotateLeft(b + F(c, d, a) + X[11], 19);
		a = RotateLeft(a + F(b, c, d) + X[12], 3);
		d = RotateLeft(d + F(a, b, c) + X[13], 7);
		c = RotateLeft(c + F(d, a, b) + X[14], 11);
		b = RotateLeft(b + F(c, d, a) + X[15], 19);
		a = RotateLeft(a + G(b, c, d) + X[0] + 1518500249, 3);
		d = RotateLeft(d + G(a, b, c) + X[4] + 1518500249, 5);
		c = RotateLeft(c + G(d, a, b) + X[8] + 1518500249, 9);
		b = RotateLeft(b + G(c, d, a) + X[12] + 1518500249, 13);
		a = RotateLeft(a + G(b, c, d) + X[1] + 1518500249, 3);
		d = RotateLeft(d + G(a, b, c) + X[5] + 1518500249, 5);
		c = RotateLeft(c + G(d, a, b) + X[9] + 1518500249, 9);
		b = RotateLeft(b + G(c, d, a) + X[13] + 1518500249, 13);
		a = RotateLeft(a + G(b, c, d) + X[2] + 1518500249, 3);
		d = RotateLeft(d + G(a, b, c) + X[6] + 1518500249, 5);
		c = RotateLeft(c + G(d, a, b) + X[10] + 1518500249, 9);
		b = RotateLeft(b + G(c, d, a) + X[14] + 1518500249, 13);
		a = RotateLeft(a + G(b, c, d) + X[3] + 1518500249, 3);
		d = RotateLeft(d + G(a, b, c) + X[7] + 1518500249, 5);
		c = RotateLeft(c + G(d, a, b) + X[11] + 1518500249, 9);
		b = RotateLeft(b + G(c, d, a) + X[15] + 1518500249, 13);
		a = RotateLeft(a + H(b, c, d) + X[0] + 1859775393, 3);
		d = RotateLeft(d + H(a, b, c) + X[8] + 1859775393, 9);
		c = RotateLeft(c + H(d, a, b) + X[4] + 1859775393, 11);
		b = RotateLeft(b + H(c, d, a) + X[12] + 1859775393, 15);
		a = RotateLeft(a + H(b, c, d) + X[2] + 1859775393, 3);
		d = RotateLeft(d + H(a, b, c) + X[10] + 1859775393, 9);
		c = RotateLeft(c + H(d, a, b) + X[6] + 1859775393, 11);
		b = RotateLeft(b + H(c, d, a) + X[14] + 1859775393, 15);
		a = RotateLeft(a + H(b, c, d) + X[1] + 1859775393, 3);
		d = RotateLeft(d + H(a, b, c) + X[9] + 1859775393, 9);
		c = RotateLeft(c + H(d, a, b) + X[5] + 1859775393, 11);
		b = RotateLeft(b + H(c, d, a) + X[13] + 1859775393, 15);
		a = RotateLeft(a + H(b, c, d) + X[3] + 1859775393, 3);
		d = RotateLeft(d + H(a, b, c) + X[11] + 1859775393, 9);
		c = RotateLeft(c + H(d, a, b) + X[7] + 1859775393, 11);
		b = RotateLeft(b + H(c, d, a) + X[15] + 1859775393, 15);
		H1 += a;
		H2 += b;
		H3 += c;
		H4 += d;
		xOff = 0;
		for (int i = 0; i != X.Length; i++)
		{
			X[i] = 0;
		}
	}

	public override IMemoable Copy()
	{
		return new MD4Digest(this);
	}

	public override void Reset(IMemoable other)
	{
		MD4Digest d = (MD4Digest)other;
		CopyIn(d);
	}
}
