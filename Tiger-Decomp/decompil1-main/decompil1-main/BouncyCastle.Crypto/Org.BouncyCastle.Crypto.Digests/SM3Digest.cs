using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class SM3Digest : GeneralDigest
{
	private const int DIGEST_LENGTH = 32;

	private const int BLOCK_SIZE = 16;

	private uint[] V = new uint[8];

	private uint[] inwords = new uint[16];

	private int xOff;

	private uint[] W = new uint[68];

	private static readonly uint[] T;

	public override string AlgorithmName => "SM3";

	static SM3Digest()
	{
		T = new uint[64];
		for (int i = 0; i < 16; i++)
		{
			uint t = 2043430169u;
			T[i] = (t << i) | (t >> 32 - i);
		}
		for (int j = 16; j < 64; j++)
		{
			int n = j % 32;
			uint t2 = 2055708042u;
			T[j] = (t2 << n) | (t2 >> 32 - n);
		}
	}

	public SM3Digest()
	{
		Reset();
	}

	public SM3Digest(SM3Digest t)
		: base(t)
	{
		CopyIn(t);
	}

	private void CopyIn(SM3Digest t)
	{
		Array.Copy(t.V, 0, V, 0, V.Length);
		Array.Copy(t.inwords, 0, inwords, 0, inwords.Length);
		xOff = t.xOff;
	}

	public override int GetDigestSize()
	{
		return 32;
	}

	public override IMemoable Copy()
	{
		return new SM3Digest(this);
	}

	public override void Reset(IMemoable other)
	{
		SM3Digest d = (SM3Digest)other;
		CopyIn((GeneralDigest)d);
		CopyIn(d);
	}

	public override void Reset()
	{
		base.Reset();
		V[0] = 1937774191u;
		V[1] = 1226093241u;
		V[2] = 388252375u;
		V[3] = 3666478592u;
		V[4] = 2842636476u;
		V[5] = 372324522u;
		V[6] = 3817729613u;
		V[7] = 2969243214u;
		xOff = 0;
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		Finish();
		Pack.UInt32_To_BE(V, output, outOff);
		Reset();
		return 32;
	}

	internal override void ProcessWord(byte[] input, int inOff)
	{
		uint n = Pack.BE_To_UInt32(input, inOff);
		inwords[xOff] = n;
		xOff++;
		if (xOff >= 16)
		{
			ProcessBlock();
		}
	}

	internal override void ProcessLength(long bitLength)
	{
		if (xOff > 14)
		{
			inwords[xOff] = 0u;
			xOff++;
			ProcessBlock();
		}
		while (xOff < 14)
		{
			inwords[xOff] = 0u;
			xOff++;
		}
		inwords[xOff++] = (uint)(bitLength >> 32);
		inwords[xOff++] = (uint)bitLength;
	}

	private uint P0(uint x)
	{
		uint r9 = (x << 9) | (x >> 23);
		uint r17 = (x << 17) | (x >> 15);
		return x ^ r9 ^ r17;
	}

	private uint P1(uint x)
	{
		uint r15 = (x << 15) | (x >> 17);
		uint r23 = (x << 23) | (x >> 9);
		return x ^ r15 ^ r23;
	}

	private uint FF0(uint x, uint y, uint z)
	{
		return x ^ y ^ z;
	}

	private uint FF1(uint x, uint y, uint z)
	{
		return (x & y) | (x & z) | (y & z);
	}

	private uint GG0(uint x, uint y, uint z)
	{
		return x ^ y ^ z;
	}

	private uint GG1(uint x, uint y, uint z)
	{
		return (x & y) | (~x & z);
	}

	internal override void ProcessBlock()
	{
		for (int j = 0; j < 16; j++)
		{
			W[j] = inwords[j];
		}
		for (int i = 16; i < 68; i++)
		{
			uint wj3 = W[i - 3];
			uint r15 = (wj3 << 15) | (wj3 >> 17);
			uint wj13 = W[i - 13];
			uint r16 = (wj13 << 7) | (wj13 >> 25);
			W[i] = P1(W[i - 16] ^ W[i - 9] ^ r15) ^ r16 ^ W[i - 6];
		}
		uint A = V[0];
		uint B = V[1];
		uint C = V[2];
		uint D = V[3];
		uint E = V[4];
		uint F = V[5];
		uint G = V[6];
		uint H = V[7];
		for (int k = 0; k < 16; k++)
		{
			uint a12 = (A << 12) | (A >> 20);
			uint s1_ = a12 + E + T[k];
			uint SS1 = (s1_ << 7) | (s1_ >> 25);
			uint SS2 = SS1 ^ a12;
			uint Wj = W[k];
			uint W1j = Wj ^ W[k + 4];
			uint num = FF0(A, B, C) + D + SS2 + W1j;
			uint TT2 = GG0(E, F, G) + H + SS1 + Wj;
			D = C;
			C = (B << 9) | (B >> 23);
			B = A;
			A = num;
			H = G;
			G = (F << 19) | (F >> 13);
			F = E;
			E = P0(TT2);
		}
		for (int l = 16; l < 64; l++)
		{
			uint a13 = (A << 12) | (A >> 20);
			uint s1_2 = a13 + E + T[l];
			uint SS3 = (s1_2 << 7) | (s1_2 >> 25);
			uint SS4 = SS3 ^ a13;
			uint Wj2 = W[l];
			uint W1j2 = Wj2 ^ W[l + 4];
			uint num2 = FF1(A, B, C) + D + SS4 + W1j2;
			uint TT3 = GG1(E, F, G) + H + SS3 + Wj2;
			D = C;
			C = (B << 9) | (B >> 23);
			B = A;
			A = num2;
			H = G;
			G = (F << 19) | (F >> 13);
			F = E;
			E = P0(TT3);
		}
		V[0] ^= A;
		V[1] ^= B;
		V[2] ^= C;
		V[3] ^= D;
		V[4] ^= E;
		V[5] ^= F;
		V[6] ^= G;
		V[7] ^= H;
		xOff = 0;
	}
}
