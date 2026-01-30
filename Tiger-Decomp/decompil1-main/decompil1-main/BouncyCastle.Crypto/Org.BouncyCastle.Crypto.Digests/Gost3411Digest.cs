using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Digests;

public class Gost3411Digest : IDigest, IMemoable
{
	private const int DIGEST_LENGTH = 32;

	private byte[] H = new byte[32];

	private byte[] L = new byte[32];

	private byte[] M = new byte[32];

	private byte[] Sum = new byte[32];

	private byte[][] C = MakeC();

	private byte[] xBuf = new byte[32];

	private int xBufOff;

	private ulong byteCount;

	private readonly IBlockCipher cipher = new Gost28147Engine();

	private byte[] sBox;

	private byte[] K = new byte[32];

	private byte[] a = new byte[8];

	internal short[] wS = new short[16];

	internal short[] w_S = new short[16];

	internal byte[] S = new byte[32];

	internal byte[] U = new byte[32];

	internal byte[] V = new byte[32];

	internal byte[] W = new byte[32];

	private static readonly byte[] C2 = new byte[32]
	{
		0, 255, 0, 255, 0, 255, 0, 255, 255, 0,
		255, 0, 255, 0, 255, 0, 0, 255, 255, 0,
		255, 0, 0, 255, 255, 0, 0, 0, 255, 255,
		0, 255
	};

	public string AlgorithmName => "Gost3411";

	private static byte[][] MakeC()
	{
		byte[][] c = new byte[4][];
		for (int i = 0; i < 4; i++)
		{
			c[i] = new byte[32];
		}
		return c;
	}

	public Gost3411Digest()
	{
		sBox = Gost28147Engine.GetSBox("D-A");
		cipher.Init(forEncryption: true, new ParametersWithSBox(null, sBox));
		Reset();
	}

	public Gost3411Digest(byte[] sBoxParam)
	{
		sBox = Arrays.Clone(sBoxParam);
		cipher.Init(forEncryption: true, new ParametersWithSBox(null, sBox));
		Reset();
	}

	public Gost3411Digest(Gost3411Digest t)
	{
		Reset(t);
	}

	public int GetDigestSize()
	{
		return 32;
	}

	public void Update(byte input)
	{
		xBuf[xBufOff++] = input;
		if (xBufOff == xBuf.Length)
		{
			sumByteArray(xBuf);
			processBlock(xBuf, 0);
			xBufOff = 0;
		}
		byteCount++;
	}

	public void BlockUpdate(byte[] input, int inOff, int length)
	{
		while (xBufOff != 0 && length > 0)
		{
			Update(input[inOff]);
			inOff++;
			length--;
		}
		while (length > xBuf.Length)
		{
			Array.Copy(input, inOff, xBuf, 0, xBuf.Length);
			sumByteArray(xBuf);
			processBlock(xBuf, 0);
			inOff += xBuf.Length;
			length -= xBuf.Length;
			byteCount += (uint)xBuf.Length;
		}
		while (length > 0)
		{
			Update(input[inOff]);
			inOff++;
			length--;
		}
	}

	private byte[] P(byte[] input)
	{
		int fourK = 0;
		for (int k = 0; k < 8; k++)
		{
			K[fourK++] = input[k];
			K[fourK++] = input[8 + k];
			K[fourK++] = input[16 + k];
			K[fourK++] = input[24 + k];
		}
		return K;
	}

	private byte[] A(byte[] input)
	{
		for (int j = 0; j < 8; j++)
		{
			a[j] = (byte)(input[j] ^ input[j + 8]);
		}
		Array.Copy(input, 8, input, 0, 24);
		Array.Copy(a, 0, input, 24, 8);
		return input;
	}

	private void E(byte[] key, byte[] s, int sOff, byte[] input, int inOff)
	{
		cipher.Init(forEncryption: true, new KeyParameter(key));
		cipher.ProcessBlock(input, inOff, s, sOff);
	}

	private void fw(byte[] input)
	{
		cpyBytesToShort(input, wS);
		w_S[15] = (short)(wS[0] ^ wS[1] ^ wS[2] ^ wS[3] ^ wS[12] ^ wS[15]);
		Array.Copy(wS, 1, w_S, 0, 15);
		cpyShortToBytes(w_S, input);
	}

	private void processBlock(byte[] input, int inOff)
	{
		Array.Copy(input, inOff, M, 0, 32);
		H.CopyTo(U, 0);
		M.CopyTo(V, 0);
		for (int j = 0; j < 32; j++)
		{
			W[j] = (byte)(U[j] ^ V[j]);
		}
		E(P(W), S, 0, H, 0);
		for (int i = 1; i < 4; i++)
		{
			byte[] tmpA = A(U);
			for (int k = 0; k < 32; k++)
			{
				U[k] = (byte)(tmpA[k] ^ C[i][k]);
			}
			V = A(A(V));
			for (int l = 0; l < 32; l++)
			{
				W[l] = (byte)(U[l] ^ V[l]);
			}
			E(P(W), S, i * 8, H, i * 8);
		}
		for (int n = 0; n < 12; n++)
		{
			fw(S);
		}
		for (int m = 0; m < 32; m++)
		{
			S[m] ^= M[m];
		}
		fw(S);
		for (int num = 0; num < 32; num++)
		{
			S[num] = (byte)(H[num] ^ S[num]);
		}
		for (int num2 = 0; num2 < 61; num2++)
		{
			fw(S);
		}
		Array.Copy(S, 0, H, 0, H.Length);
	}

	private void finish()
	{
		Pack.UInt64_To_LE(byteCount * 8, L);
		while (xBufOff != 0)
		{
			Update(0);
		}
		processBlock(L, 0);
		processBlock(Sum, 0);
	}

	public int DoFinal(byte[] output, int outOff)
	{
		finish();
		H.CopyTo(output, outOff);
		Reset();
		return 32;
	}

	public void Reset()
	{
		byteCount = 0uL;
		xBufOff = 0;
		Array.Clear(H, 0, H.Length);
		Array.Clear(L, 0, L.Length);
		Array.Clear(M, 0, M.Length);
		Array.Clear(C[1], 0, C[1].Length);
		Array.Clear(C[3], 0, C[3].Length);
		Array.Clear(Sum, 0, Sum.Length);
		Array.Clear(xBuf, 0, xBuf.Length);
		C2.CopyTo(C[2], 0);
	}

	private void sumByteArray(byte[] input)
	{
		int carry = 0;
		for (int i = 0; i != Sum.Length; i++)
		{
			int sum = (Sum[i] & 0xFF) + (input[i] & 0xFF) + carry;
			Sum[i] = (byte)sum;
			carry = sum >> 8;
		}
	}

	private static void cpyBytesToShort(byte[] S, short[] wS)
	{
		for (int i = 0; i < S.Length / 2; i++)
		{
			wS[i] = (short)(((S[i * 2 + 1] << 8) & 0xFF00) | (S[i * 2] & 0xFF));
		}
	}

	private static void cpyShortToBytes(short[] wS, byte[] S)
	{
		for (int i = 0; i < S.Length / 2; i++)
		{
			S[i * 2 + 1] = (byte)(wS[i] >> 8);
			S[i * 2] = (byte)wS[i];
		}
	}

	public int GetByteLength()
	{
		return 32;
	}

	public IMemoable Copy()
	{
		return new Gost3411Digest(this);
	}

	public void Reset(IMemoable other)
	{
		Gost3411Digest t = (Gost3411Digest)other;
		sBox = t.sBox;
		cipher.Init(forEncryption: true, new ParametersWithSBox(null, sBox));
		Reset();
		Array.Copy(t.H, 0, H, 0, t.H.Length);
		Array.Copy(t.L, 0, L, 0, t.L.Length);
		Array.Copy(t.M, 0, M, 0, t.M.Length);
		Array.Copy(t.Sum, 0, Sum, 0, t.Sum.Length);
		Array.Copy(t.C[1], 0, C[1], 0, t.C[1].Length);
		Array.Copy(t.C[2], 0, C[2], 0, t.C[2].Length);
		Array.Copy(t.C[3], 0, C[3], 0, t.C[3].Length);
		Array.Copy(t.xBuf, 0, xBuf, 0, t.xBuf.Length);
		xBufOff = t.xBufOff;
		byteCount = t.byteCount;
	}
}
