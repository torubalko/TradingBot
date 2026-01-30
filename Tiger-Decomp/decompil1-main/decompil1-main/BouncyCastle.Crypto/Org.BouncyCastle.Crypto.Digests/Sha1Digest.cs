using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class Sha1Digest : GeneralDigest
{
	private const int DigestLength = 20;

	private uint H1;

	private uint H2;

	private uint H3;

	private uint H4;

	private uint H5;

	private uint[] X = new uint[80];

	private int xOff;

	private const uint Y1 = 1518500249u;

	private const uint Y2 = 1859775393u;

	private const uint Y3 = 2400959708u;

	private const uint Y4 = 3395469782u;

	public override string AlgorithmName => "SHA-1";

	public Sha1Digest()
	{
		Reset();
	}

	public Sha1Digest(Sha1Digest t)
		: base(t)
	{
		CopyIn(t);
	}

	private void CopyIn(Sha1Digest t)
	{
		CopyIn((GeneralDigest)t);
		H1 = t.H1;
		H2 = t.H2;
		H3 = t.H3;
		H4 = t.H4;
		H5 = t.H5;
		Array.Copy(t.X, 0, X, 0, t.X.Length);
		xOff = t.xOff;
	}

	public override int GetDigestSize()
	{
		return 20;
	}

	internal override void ProcessWord(byte[] input, int inOff)
	{
		X[xOff] = Pack.BE_To_UInt32(input, inOff);
		if (++xOff == 16)
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
		X[14] = (uint)((ulong)bitLength >> 32);
		X[15] = (uint)bitLength;
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		Finish();
		Pack.UInt32_To_BE(H1, output, outOff);
		Pack.UInt32_To_BE(H2, output, outOff + 4);
		Pack.UInt32_To_BE(H3, output, outOff + 8);
		Pack.UInt32_To_BE(H4, output, outOff + 12);
		Pack.UInt32_To_BE(H5, output, outOff + 16);
		Reset();
		return 20;
	}

	public override void Reset()
	{
		base.Reset();
		H1 = 1732584193u;
		H2 = 4023233417u;
		H3 = 2562383102u;
		H4 = 271733878u;
		H5 = 3285377520u;
		xOff = 0;
		Array.Clear(X, 0, X.Length);
	}

	private static uint F(uint u, uint v, uint w)
	{
		return (u & v) | (~u & w);
	}

	private static uint H(uint u, uint v, uint w)
	{
		return u ^ v ^ w;
	}

	private static uint G(uint u, uint v, uint w)
	{
		return (u & v) | (u & w) | (v & w);
	}

	internal override void ProcessBlock()
	{
		for (int i = 16; i < 80; i++)
		{
			uint t = X[i - 3] ^ X[i - 8] ^ X[i - 14] ^ X[i - 16];
			X[i] = (t << 1) | (t >> 31);
		}
		uint A = H1;
		uint B = H2;
		uint C = H3;
		uint D = H4;
		uint E = H5;
		int idx = 0;
		for (int j = 0; j < 4; j++)
		{
			E += ((A << 5) | (A >> 27)) + F(B, C, D) + X[idx++] + 1518500249;
			B = (B << 30) | (B >> 2);
			D += ((E << 5) | (E >> 27)) + F(A, B, C) + X[idx++] + 1518500249;
			A = (A << 30) | (A >> 2);
			C += ((D << 5) | (D >> 27)) + F(E, A, B) + X[idx++] + 1518500249;
			E = (E << 30) | (E >> 2);
			B += ((C << 5) | (C >> 27)) + F(D, E, A) + X[idx++] + 1518500249;
			D = (D << 30) | (D >> 2);
			A += ((B << 5) | (B >> 27)) + F(C, D, E) + X[idx++] + 1518500249;
			C = (C << 30) | (C >> 2);
		}
		for (int k = 0; k < 4; k++)
		{
			E += ((A << 5) | (A >> 27)) + H(B, C, D) + X[idx++] + 1859775393;
			B = (B << 30) | (B >> 2);
			D += ((E << 5) | (E >> 27)) + H(A, B, C) + X[idx++] + 1859775393;
			A = (A << 30) | (A >> 2);
			C += ((D << 5) | (D >> 27)) + H(E, A, B) + X[idx++] + 1859775393;
			E = (E << 30) | (E >> 2);
			B += ((C << 5) | (C >> 27)) + H(D, E, A) + X[idx++] + 1859775393;
			D = (D << 30) | (D >> 2);
			A += ((B << 5) | (B >> 27)) + H(C, D, E) + X[idx++] + 1859775393;
			C = (C << 30) | (C >> 2);
		}
		for (int l = 0; l < 4; l++)
		{
			E += (uint)((int)(((A << 5) | (A >> 27)) + G(B, C, D) + X[idx++]) + -1894007588);
			B = (B << 30) | (B >> 2);
			D += (uint)((int)(((E << 5) | (E >> 27)) + G(A, B, C) + X[idx++]) + -1894007588);
			A = (A << 30) | (A >> 2);
			C += (uint)((int)(((D << 5) | (D >> 27)) + G(E, A, B) + X[idx++]) + -1894007588);
			E = (E << 30) | (E >> 2);
			B += (uint)((int)(((C << 5) | (C >> 27)) + G(D, E, A) + X[idx++]) + -1894007588);
			D = (D << 30) | (D >> 2);
			A += (uint)((int)(((B << 5) | (B >> 27)) + G(C, D, E) + X[idx++]) + -1894007588);
			C = (C << 30) | (C >> 2);
		}
		for (int m = 0; m < 4; m++)
		{
			E += (uint)((int)(((A << 5) | (A >> 27)) + H(B, C, D) + X[idx++]) + -899497514);
			B = (B << 30) | (B >> 2);
			D += (uint)((int)(((E << 5) | (E >> 27)) + H(A, B, C) + X[idx++]) + -899497514);
			A = (A << 30) | (A >> 2);
			C += (uint)((int)(((D << 5) | (D >> 27)) + H(E, A, B) + X[idx++]) + -899497514);
			E = (E << 30) | (E >> 2);
			B += (uint)((int)(((C << 5) | (C >> 27)) + H(D, E, A) + X[idx++]) + -899497514);
			D = (D << 30) | (D >> 2);
			A += (uint)((int)(((B << 5) | (B >> 27)) + H(C, D, E) + X[idx++]) + -899497514);
			C = (C << 30) | (C >> 2);
		}
		H1 += A;
		H2 += B;
		H3 += C;
		H4 += D;
		H5 += E;
		xOff = 0;
		Array.Clear(X, 0, 16);
	}

	public override IMemoable Copy()
	{
		return new Sha1Digest(this);
	}

	public override void Reset(IMemoable other)
	{
		Sha1Digest d = (Sha1Digest)other;
		CopyIn(d);
	}
}
