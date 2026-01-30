using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class RipeMD320Digest : GeneralDigest
{
	private const int DigestLength = 40;

	private int H0;

	private int H1;

	private int H2;

	private int H3;

	private int H4;

	private int H5;

	private int H6;

	private int H7;

	private int H8;

	private int H9;

	private int[] X = new int[16];

	private int xOff;

	public override string AlgorithmName => "RIPEMD320";

	public override int GetDigestSize()
	{
		return 40;
	}

	public RipeMD320Digest()
	{
		Reset();
	}

	public RipeMD320Digest(RipeMD320Digest t)
		: base(t)
	{
		CopyIn(t);
	}

	private void CopyIn(RipeMD320Digest t)
	{
		CopyIn((GeneralDigest)t);
		H0 = t.H0;
		H1 = t.H1;
		H2 = t.H2;
		H3 = t.H3;
		H4 = t.H4;
		H5 = t.H5;
		H6 = t.H6;
		H7 = t.H7;
		H8 = t.H8;
		H9 = t.H9;
		Array.Copy(t.X, 0, X, 0, t.X.Length);
		xOff = t.xOff;
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
		UnpackWord(H0, output, outOff);
		UnpackWord(H1, output, outOff + 4);
		UnpackWord(H2, output, outOff + 8);
		UnpackWord(H3, output, outOff + 12);
		UnpackWord(H4, output, outOff + 16);
		UnpackWord(H5, output, outOff + 20);
		UnpackWord(H6, output, outOff + 24);
		UnpackWord(H7, output, outOff + 28);
		UnpackWord(H8, output, outOff + 32);
		UnpackWord(H9, output, outOff + 36);
		Reset();
		return 40;
	}

	public override void Reset()
	{
		base.Reset();
		H0 = 1732584193;
		H1 = -271733879;
		H2 = -1732584194;
		H3 = 271733878;
		H4 = -1009589776;
		H5 = 1985229328;
		H6 = -19088744;
		H7 = -1985229329;
		H8 = 19088743;
		H9 = 1009589775;
		xOff = 0;
		for (int i = 0; i != X.Length; i++)
		{
			X[i] = 0;
		}
	}

	private int RL(int x, int n)
	{
		return (x << n) | (x >>> 32 - n);
	}

	private int F1(int x, int y, int z)
	{
		return x ^ y ^ z;
	}

	private int F2(int x, int y, int z)
	{
		return (x & y) | (~x & z);
	}

	private int F3(int x, int y, int z)
	{
		return (x | ~y) ^ z;
	}

	private int F4(int x, int y, int z)
	{
		return (x & z) | (y & ~z);
	}

	private int F5(int x, int y, int z)
	{
		return x ^ (y | ~z);
	}

	internal override void ProcessBlock()
	{
		int a = H0;
		int b = H1;
		int c = H2;
		int d = H3;
		int e = H4;
		int aa = H5;
		int bb = H6;
		int cc = H7;
		int dd = H8;
		int ee = H9;
		a = RL(a + F1(b, c, d) + X[0], 11) + e;
		c = RL(c, 10);
		e = RL(e + F1(a, b, c) + X[1], 14) + d;
		b = RL(b, 10);
		d = RL(d + F1(e, a, b) + X[2], 15) + c;
		a = RL(a, 10);
		c = RL(c + F1(d, e, a) + X[3], 12) + b;
		e = RL(e, 10);
		b = RL(b + F1(c, d, e) + X[4], 5) + a;
		d = RL(d, 10);
		a = RL(a + F1(b, c, d) + X[5], 8) + e;
		c = RL(c, 10);
		e = RL(e + F1(a, b, c) + X[6], 7) + d;
		b = RL(b, 10);
		d = RL(d + F1(e, a, b) + X[7], 9) + c;
		a = RL(a, 10);
		c = RL(c + F1(d, e, a) + X[8], 11) + b;
		e = RL(e, 10);
		b = RL(b + F1(c, d, e) + X[9], 13) + a;
		d = RL(d, 10);
		a = RL(a + F1(b, c, d) + X[10], 14) + e;
		c = RL(c, 10);
		e = RL(e + F1(a, b, c) + X[11], 15) + d;
		b = RL(b, 10);
		d = RL(d + F1(e, a, b) + X[12], 6) + c;
		a = RL(a, 10);
		c = RL(c + F1(d, e, a) + X[13], 7) + b;
		e = RL(e, 10);
		b = RL(b + F1(c, d, e) + X[14], 9) + a;
		d = RL(d, 10);
		a = RL(a + F1(b, c, d) + X[15], 8) + e;
		c = RL(c, 10);
		aa = RL(aa + F5(bb, cc, dd) + X[5] + 1352829926, 8) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F5(aa, bb, cc) + X[14] + 1352829926, 9) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F5(ee, aa, bb) + X[7] + 1352829926, 9) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F5(dd, ee, aa) + X[0] + 1352829926, 11) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F5(cc, dd, ee) + X[9] + 1352829926, 13) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F5(bb, cc, dd) + X[2] + 1352829926, 15) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F5(aa, bb, cc) + X[11] + 1352829926, 15) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F5(ee, aa, bb) + X[4] + 1352829926, 5) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F5(dd, ee, aa) + X[13] + 1352829926, 7) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F5(cc, dd, ee) + X[6] + 1352829926, 7) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F5(bb, cc, dd) + X[15] + 1352829926, 8) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F5(aa, bb, cc) + X[8] + 1352829926, 11) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F5(ee, aa, bb) + X[1] + 1352829926, 14) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F5(dd, ee, aa) + X[10] + 1352829926, 14) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F5(cc, dd, ee) + X[3] + 1352829926, 12) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F5(bb, cc, dd) + X[12] + 1352829926, 6) + ee;
		cc = RL(cc, 10);
		int num = a;
		a = aa;
		aa = num;
		e = RL(e + F2(a, b, c) + X[7] + 1518500249, 7) + d;
		b = RL(b, 10);
		d = RL(d + F2(e, a, b) + X[4] + 1518500249, 6) + c;
		a = RL(a, 10);
		c = RL(c + F2(d, e, a) + X[13] + 1518500249, 8) + b;
		e = RL(e, 10);
		b = RL(b + F2(c, d, e) + X[1] + 1518500249, 13) + a;
		d = RL(d, 10);
		a = RL(a + F2(b, c, d) + X[10] + 1518500249, 11) + e;
		c = RL(c, 10);
		e = RL(e + F2(a, b, c) + X[6] + 1518500249, 9) + d;
		b = RL(b, 10);
		d = RL(d + F2(e, a, b) + X[15] + 1518500249, 7) + c;
		a = RL(a, 10);
		c = RL(c + F2(d, e, a) + X[3] + 1518500249, 15) + b;
		e = RL(e, 10);
		b = RL(b + F2(c, d, e) + X[12] + 1518500249, 7) + a;
		d = RL(d, 10);
		a = RL(a + F2(b, c, d) + X[0] + 1518500249, 12) + e;
		c = RL(c, 10);
		e = RL(e + F2(a, b, c) + X[9] + 1518500249, 15) + d;
		b = RL(b, 10);
		d = RL(d + F2(e, a, b) + X[5] + 1518500249, 9) + c;
		a = RL(a, 10);
		c = RL(c + F2(d, e, a) + X[2] + 1518500249, 11) + b;
		e = RL(e, 10);
		b = RL(b + F2(c, d, e) + X[14] + 1518500249, 7) + a;
		d = RL(d, 10);
		a = RL(a + F2(b, c, d) + X[11] + 1518500249, 13) + e;
		c = RL(c, 10);
		e = RL(e + F2(a, b, c) + X[8] + 1518500249, 12) + d;
		b = RL(b, 10);
		ee = RL(ee + F4(aa, bb, cc) + X[6] + 1548603684, 9) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F4(ee, aa, bb) + X[11] + 1548603684, 13) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F4(dd, ee, aa) + X[3] + 1548603684, 15) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F4(cc, dd, ee) + X[7] + 1548603684, 7) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F4(bb, cc, dd) + X[0] + 1548603684, 12) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F4(aa, bb, cc) + X[13] + 1548603684, 8) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F4(ee, aa, bb) + X[5] + 1548603684, 9) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F4(dd, ee, aa) + X[10] + 1548603684, 11) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F4(cc, dd, ee) + X[14] + 1548603684, 7) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F4(bb, cc, dd) + X[15] + 1548603684, 7) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F4(aa, bb, cc) + X[8] + 1548603684, 12) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F4(ee, aa, bb) + X[12] + 1548603684, 7) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F4(dd, ee, aa) + X[4] + 1548603684, 6) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F4(cc, dd, ee) + X[9] + 1548603684, 15) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F4(bb, cc, dd) + X[1] + 1548603684, 13) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F4(aa, bb, cc) + X[2] + 1548603684, 11) + dd;
		bb = RL(bb, 10);
		int num2 = b;
		b = bb;
		bb = num2;
		d = RL(d + F3(e, a, b) + X[3] + 1859775393, 11) + c;
		a = RL(a, 10);
		c = RL(c + F3(d, e, a) + X[10] + 1859775393, 13) + b;
		e = RL(e, 10);
		b = RL(b + F3(c, d, e) + X[14] + 1859775393, 6) + a;
		d = RL(d, 10);
		a = RL(a + F3(b, c, d) + X[4] + 1859775393, 7) + e;
		c = RL(c, 10);
		e = RL(e + F3(a, b, c) + X[9] + 1859775393, 14) + d;
		b = RL(b, 10);
		d = RL(d + F3(e, a, b) + X[15] + 1859775393, 9) + c;
		a = RL(a, 10);
		c = RL(c + F3(d, e, a) + X[8] + 1859775393, 13) + b;
		e = RL(e, 10);
		b = RL(b + F3(c, d, e) + X[1] + 1859775393, 15) + a;
		d = RL(d, 10);
		a = RL(a + F3(b, c, d) + X[2] + 1859775393, 14) + e;
		c = RL(c, 10);
		e = RL(e + F3(a, b, c) + X[7] + 1859775393, 8) + d;
		b = RL(b, 10);
		d = RL(d + F3(e, a, b) + X[0] + 1859775393, 13) + c;
		a = RL(a, 10);
		c = RL(c + F3(d, e, a) + X[6] + 1859775393, 6) + b;
		e = RL(e, 10);
		b = RL(b + F3(c, d, e) + X[13] + 1859775393, 5) + a;
		d = RL(d, 10);
		a = RL(a + F3(b, c, d) + X[11] + 1859775393, 12) + e;
		c = RL(c, 10);
		e = RL(e + F3(a, b, c) + X[5] + 1859775393, 7) + d;
		b = RL(b, 10);
		d = RL(d + F3(e, a, b) + X[12] + 1859775393, 5) + c;
		a = RL(a, 10);
		dd = RL(dd + F3(ee, aa, bb) + X[15] + 1836072691, 9) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F3(dd, ee, aa) + X[5] + 1836072691, 7) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F3(cc, dd, ee) + X[1] + 1836072691, 15) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F3(bb, cc, dd) + X[3] + 1836072691, 11) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F3(aa, bb, cc) + X[7] + 1836072691, 8) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F3(ee, aa, bb) + X[14] + 1836072691, 6) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F3(dd, ee, aa) + X[6] + 1836072691, 6) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F3(cc, dd, ee) + X[9] + 1836072691, 14) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F3(bb, cc, dd) + X[11] + 1836072691, 12) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F3(aa, bb, cc) + X[8] + 1836072691, 13) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F3(ee, aa, bb) + X[12] + 1836072691, 5) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F3(dd, ee, aa) + X[2] + 1836072691, 14) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F3(cc, dd, ee) + X[10] + 1836072691, 13) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F3(bb, cc, dd) + X[0] + 1836072691, 13) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F3(aa, bb, cc) + X[4] + 1836072691, 7) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F3(ee, aa, bb) + X[13] + 1836072691, 5) + cc;
		aa = RL(aa, 10);
		int num3 = c;
		c = cc;
		cc = num3;
		c = RL(c + F4(d, e, a) + X[1] + -1894007588, 11) + b;
		e = RL(e, 10);
		b = RL(b + F4(c, d, e) + X[9] + -1894007588, 12) + a;
		d = RL(d, 10);
		a = RL(a + F4(b, c, d) + X[11] + -1894007588, 14) + e;
		c = RL(c, 10);
		e = RL(e + F4(a, b, c) + X[10] + -1894007588, 15) + d;
		b = RL(b, 10);
		d = RL(d + F4(e, a, b) + X[0] + -1894007588, 14) + c;
		a = RL(a, 10);
		c = RL(c + F4(d, e, a) + X[8] + -1894007588, 15) + b;
		e = RL(e, 10);
		b = RL(b + F4(c, d, e) + X[12] + -1894007588, 9) + a;
		d = RL(d, 10);
		a = RL(a + F4(b, c, d) + X[4] + -1894007588, 8) + e;
		c = RL(c, 10);
		e = RL(e + F4(a, b, c) + X[13] + -1894007588, 9) + d;
		b = RL(b, 10);
		d = RL(d + F4(e, a, b) + X[3] + -1894007588, 14) + c;
		a = RL(a, 10);
		c = RL(c + F4(d, e, a) + X[7] + -1894007588, 5) + b;
		e = RL(e, 10);
		b = RL(b + F4(c, d, e) + X[15] + -1894007588, 6) + a;
		d = RL(d, 10);
		a = RL(a + F4(b, c, d) + X[14] + -1894007588, 8) + e;
		c = RL(c, 10);
		e = RL(e + F4(a, b, c) + X[5] + -1894007588, 6) + d;
		b = RL(b, 10);
		d = RL(d + F4(e, a, b) + X[6] + -1894007588, 5) + c;
		a = RL(a, 10);
		c = RL(c + F4(d, e, a) + X[2] + -1894007588, 12) + b;
		e = RL(e, 10);
		cc = RL(cc + F2(dd, ee, aa) + X[8] + 2053994217, 15) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F2(cc, dd, ee) + X[6] + 2053994217, 5) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F2(bb, cc, dd) + X[4] + 2053994217, 8) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F2(aa, bb, cc) + X[1] + 2053994217, 11) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F2(ee, aa, bb) + X[3] + 2053994217, 14) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F2(dd, ee, aa) + X[11] + 2053994217, 14) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F2(cc, dd, ee) + X[15] + 2053994217, 6) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F2(bb, cc, dd) + X[0] + 2053994217, 14) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F2(aa, bb, cc) + X[5] + 2053994217, 6) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F2(ee, aa, bb) + X[12] + 2053994217, 9) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F2(dd, ee, aa) + X[2] + 2053994217, 12) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F2(cc, dd, ee) + X[13] + 2053994217, 9) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F2(bb, cc, dd) + X[9] + 2053994217, 12) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F2(aa, bb, cc) + X[7] + 2053994217, 5) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F2(ee, aa, bb) + X[10] + 2053994217, 15) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F2(dd, ee, aa) + X[14] + 2053994217, 8) + bb;
		ee = RL(ee, 10);
		int num4 = d;
		d = dd;
		dd = num4;
		b = RL(b + F5(c, d, e) + X[4] + -1454113458, 9) + a;
		d = RL(d, 10);
		a = RL(a + F5(b, c, d) + X[0] + -1454113458, 15) + e;
		c = RL(c, 10);
		e = RL(e + F5(a, b, c) + X[5] + -1454113458, 5) + d;
		b = RL(b, 10);
		d = RL(d + F5(e, a, b) + X[9] + -1454113458, 11) + c;
		a = RL(a, 10);
		c = RL(c + F5(d, e, a) + X[7] + -1454113458, 6) + b;
		e = RL(e, 10);
		b = RL(b + F5(c, d, e) + X[12] + -1454113458, 8) + a;
		d = RL(d, 10);
		a = RL(a + F5(b, c, d) + X[2] + -1454113458, 13) + e;
		c = RL(c, 10);
		e = RL(e + F5(a, b, c) + X[10] + -1454113458, 12) + d;
		b = RL(b, 10);
		d = RL(d + F5(e, a, b) + X[14] + -1454113458, 5) + c;
		a = RL(a, 10);
		c = RL(c + F5(d, e, a) + X[1] + -1454113458, 12) + b;
		e = RL(e, 10);
		b = RL(b + F5(c, d, e) + X[3] + -1454113458, 13) + a;
		d = RL(d, 10);
		a = RL(a + F5(b, c, d) + X[8] + -1454113458, 14) + e;
		c = RL(c, 10);
		e = RL(e + F5(a, b, c) + X[11] + -1454113458, 11) + d;
		b = RL(b, 10);
		d = RL(d + F5(e, a, b) + X[6] + -1454113458, 8) + c;
		a = RL(a, 10);
		c = RL(c + F5(d, e, a) + X[15] + -1454113458, 5) + b;
		e = RL(e, 10);
		b = RL(b + F5(c, d, e) + X[13] + -1454113458, 6) + a;
		d = RL(d, 10);
		bb = RL(bb + F1(cc, dd, ee) + X[12], 8) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F1(bb, cc, dd) + X[15], 5) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F1(aa, bb, cc) + X[10], 12) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F1(ee, aa, bb) + X[4], 9) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F1(dd, ee, aa) + X[1], 12) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F1(cc, dd, ee) + X[5], 5) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F1(bb, cc, dd) + X[8], 14) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F1(aa, bb, cc) + X[7], 6) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F1(ee, aa, bb) + X[6], 8) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F1(dd, ee, aa) + X[2], 13) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F1(cc, dd, ee) + X[13], 6) + aa;
		dd = RL(dd, 10);
		aa = RL(aa + F1(bb, cc, dd) + X[14], 5) + ee;
		cc = RL(cc, 10);
		ee = RL(ee + F1(aa, bb, cc) + X[0], 15) + dd;
		bb = RL(bb, 10);
		dd = RL(dd + F1(ee, aa, bb) + X[3], 13) + cc;
		aa = RL(aa, 10);
		cc = RL(cc + F1(dd, ee, aa) + X[9], 11) + bb;
		ee = RL(ee, 10);
		bb = RL(bb + F1(cc, dd, ee) + X[11], 11) + aa;
		dd = RL(dd, 10);
		H0 += a;
		H1 += b;
		H2 += c;
		H3 += d;
		H4 += ee;
		H5 += aa;
		H6 += bb;
		H7 += cc;
		H8 += dd;
		H9 += e;
		xOff = 0;
		for (int i = 0; i != X.Length; i++)
		{
			X[i] = 0;
		}
	}

	public override IMemoable Copy()
	{
		return new RipeMD320Digest(this);
	}

	public override void Reset(IMemoable other)
	{
		RipeMD320Digest d = (RipeMD320Digest)other;
		CopyIn(d);
	}
}
