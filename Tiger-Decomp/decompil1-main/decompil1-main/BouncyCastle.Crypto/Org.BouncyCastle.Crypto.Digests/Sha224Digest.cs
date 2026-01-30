using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class Sha224Digest : GeneralDigest
{
	private const int DigestLength = 28;

	private uint H1;

	private uint H2;

	private uint H3;

	private uint H4;

	private uint H5;

	private uint H6;

	private uint H7;

	private uint H8;

	private uint[] X = new uint[64];

	private int xOff;

	internal static readonly uint[] K = new uint[64]
	{
		1116352408u, 1899447441u, 3049323471u, 3921009573u, 961987163u, 1508970993u, 2453635748u, 2870763221u, 3624381080u, 310598401u,
		607225278u, 1426881987u, 1925078388u, 2162078206u, 2614888103u, 3248222580u, 3835390401u, 4022224774u, 264347078u, 604807628u,
		770255983u, 1249150122u, 1555081692u, 1996064986u, 2554220882u, 2821834349u, 2952996808u, 3210313671u, 3336571891u, 3584528711u,
		113926993u, 338241895u, 666307205u, 773529912u, 1294757372u, 1396182291u, 1695183700u, 1986661051u, 2177026350u, 2456956037u,
		2730485921u, 2820302411u, 3259730800u, 3345764771u, 3516065817u, 3600352804u, 4094571909u, 275423344u, 430227734u, 506948616u,
		659060556u, 883997877u, 958139571u, 1322822218u, 1537002063u, 1747873779u, 1955562222u, 2024104815u, 2227730452u, 2361852424u,
		2428436474u, 2756734187u, 3204031479u, 3329325298u
	};

	public override string AlgorithmName => "SHA-224";

	public Sha224Digest()
	{
		Reset();
	}

	public Sha224Digest(Sha224Digest t)
		: base(t)
	{
		CopyIn(t);
	}

	private void CopyIn(Sha224Digest t)
	{
		CopyIn((GeneralDigest)t);
		H1 = t.H1;
		H2 = t.H2;
		H3 = t.H3;
		H4 = t.H4;
		H5 = t.H5;
		H6 = t.H6;
		H7 = t.H7;
		H8 = t.H8;
		Array.Copy(t.X, 0, X, 0, t.X.Length);
		xOff = t.xOff;
	}

	public override int GetDigestSize()
	{
		return 28;
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
		Pack.UInt32_To_BE(H6, output, outOff + 20);
		Pack.UInt32_To_BE(H7, output, outOff + 24);
		Reset();
		return 28;
	}

	public override void Reset()
	{
		base.Reset();
		H1 = 3238371032u;
		H2 = 914150663u;
		H3 = 812702999u;
		H4 = 4144912697u;
		H5 = 4290775857u;
		H6 = 1750603025u;
		H7 = 1694076839u;
		H8 = 3204075428u;
		xOff = 0;
		Array.Clear(X, 0, X.Length);
	}

	internal override void ProcessBlock()
	{
		for (int ti = 16; ti <= 63; ti++)
		{
			X[ti] = Theta1(X[ti - 2]) + X[ti - 7] + Theta0(X[ti - 15]) + X[ti - 16];
		}
		uint a = H1;
		uint b = H2;
		uint c = H3;
		uint d = H4;
		uint e = H5;
		uint f = H6;
		uint g = H7;
		uint h = H8;
		int t = 0;
		for (int i = 0; i < 8; i++)
		{
			h += Sum1(e) + Ch(e, f, g) + K[t] + X[t];
			d += h;
			h += Sum0(a) + Maj(a, b, c);
			t++;
			g += Sum1(d) + Ch(d, e, f) + K[t] + X[t];
			c += g;
			g += Sum0(h) + Maj(h, a, b);
			t++;
			f += Sum1(c) + Ch(c, d, e) + K[t] + X[t];
			b += f;
			f += Sum0(g) + Maj(g, h, a);
			t++;
			e += Sum1(b) + Ch(b, c, d) + K[t] + X[t];
			a += e;
			e += Sum0(f) + Maj(f, g, h);
			t++;
			d += Sum1(a) + Ch(a, b, c) + K[t] + X[t];
			h += d;
			d += Sum0(e) + Maj(e, f, g);
			t++;
			c += Sum1(h) + Ch(h, a, b) + K[t] + X[t];
			g += c;
			c += Sum0(d) + Maj(d, e, f);
			t++;
			b += Sum1(g) + Ch(g, h, a) + K[t] + X[t];
			f += b;
			b += Sum0(c) + Maj(c, d, e);
			t++;
			a += Sum1(f) + Ch(f, g, h) + K[t] + X[t];
			e += a;
			a += Sum0(b) + Maj(b, c, d);
			t++;
		}
		H1 += a;
		H2 += b;
		H3 += c;
		H4 += d;
		H5 += e;
		H6 += f;
		H7 += g;
		H8 += h;
		xOff = 0;
		Array.Clear(X, 0, 16);
	}

	private static uint Ch(uint x, uint y, uint z)
	{
		return (x & y) ^ (~x & z);
	}

	private static uint Maj(uint x, uint y, uint z)
	{
		return (x & y) ^ (x & z) ^ (y & z);
	}

	private static uint Sum0(uint x)
	{
		return ((x >> 2) | (x << 30)) ^ ((x >> 13) | (x << 19)) ^ ((x >> 22) | (x << 10));
	}

	private static uint Sum1(uint x)
	{
		return ((x >> 6) | (x << 26)) ^ ((x >> 11) | (x << 21)) ^ ((x >> 25) | (x << 7));
	}

	private static uint Theta0(uint x)
	{
		return ((x >> 7) | (x << 25)) ^ ((x >> 18) | (x << 14)) ^ (x >> 3);
	}

	private static uint Theta1(uint x)
	{
		return ((x >> 17) | (x << 15)) ^ ((x >> 19) | (x << 13)) ^ (x >> 10);
	}

	public override IMemoable Copy()
	{
		return new Sha224Digest(this);
	}

	public override void Reset(IMemoable other)
	{
		Sha224Digest d = (Sha224Digest)other;
		CopyIn(d);
	}
}
