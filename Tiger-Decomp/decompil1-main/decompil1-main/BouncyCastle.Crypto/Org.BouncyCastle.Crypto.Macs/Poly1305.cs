using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;

namespace Org.BouncyCastle.Crypto.Macs;

public class Poly1305 : IMac
{
	private const int BlockSize = 16;

	private readonly IBlockCipher cipher;

	private readonly byte[] singleByte = new byte[1];

	private uint r0;

	private uint r1;

	private uint r2;

	private uint r3;

	private uint r4;

	private uint s1;

	private uint s2;

	private uint s3;

	private uint s4;

	private uint k0;

	private uint k1;

	private uint k2;

	private uint k3;

	private byte[] currentBlock = new byte[16];

	private int currentBlockOffset;

	private uint h0;

	private uint h1;

	private uint h2;

	private uint h3;

	private uint h4;

	public string AlgorithmName
	{
		get
		{
			if (cipher != null)
			{
				return "Poly1305-" + cipher.AlgorithmName;
			}
			return "Poly1305";
		}
	}

	public Poly1305()
	{
		cipher = null;
	}

	public Poly1305(IBlockCipher cipher)
	{
		if (cipher.GetBlockSize() != 16)
		{
			throw new ArgumentException("Poly1305 requires a 128 bit block cipher.");
		}
		this.cipher = cipher;
	}

	public void Init(ICipherParameters parameters)
	{
		byte[] nonce = null;
		if (cipher != null)
		{
			if (!(parameters is ParametersWithIV))
			{
				throw new ArgumentException("Poly1305 requires an IV when used with a block cipher.", "parameters");
			}
			ParametersWithIV obj = (ParametersWithIV)parameters;
			nonce = obj.GetIV();
			parameters = obj.Parameters;
		}
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("Poly1305 requires a key.");
		}
		KeyParameter keyParams = (KeyParameter)parameters;
		SetKey(keyParams.GetKey(), nonce);
		Reset();
	}

	private void SetKey(byte[] key, byte[] nonce)
	{
		if (key.Length != 32)
		{
			throw new ArgumentException("Poly1305 key must be 256 bits.");
		}
		if (cipher != null && (nonce == null || nonce.Length != 16))
		{
			throw new ArgumentException("Poly1305 requires a 128 bit IV.");
		}
		uint t0 = Pack.LE_To_UInt32(key, 0);
		uint t1 = Pack.LE_To_UInt32(key, 4);
		uint t2 = Pack.LE_To_UInt32(key, 8);
		uint t3 = Pack.LE_To_UInt32(key, 12);
		r0 = t0 & 0x3FFFFFF;
		r1 = ((t0 >> 26) | (t1 << 6)) & 0x3FFFF03;
		r2 = ((t1 >> 20) | (t2 << 12)) & 0x3FFC0FF;
		r3 = ((t2 >> 14) | (t3 << 18)) & 0x3F03FFF;
		r4 = (t3 >> 8) & 0xFFFFF;
		s1 = r1 * 5;
		s2 = r2 * 5;
		s3 = r3 * 5;
		s4 = r4 * 5;
		byte[] kBytes;
		int kOff;
		if (cipher == null)
		{
			kBytes = key;
			kOff = 16;
		}
		else
		{
			kBytes = new byte[16];
			kOff = 0;
			cipher.Init(forEncryption: true, new KeyParameter(key, 16, 16));
			cipher.ProcessBlock(nonce, 0, kBytes, 0);
		}
		k0 = Pack.LE_To_UInt32(kBytes, kOff);
		k1 = Pack.LE_To_UInt32(kBytes, kOff + 4);
		k2 = Pack.LE_To_UInt32(kBytes, kOff + 8);
		k3 = Pack.LE_To_UInt32(kBytes, kOff + 12);
	}

	public int GetMacSize()
	{
		return 16;
	}

	public void Update(byte input)
	{
		singleByte[0] = input;
		BlockUpdate(singleByte, 0, 1);
	}

	public void BlockUpdate(byte[] input, int inOff, int len)
	{
		int copied = 0;
		while (len > copied)
		{
			if (currentBlockOffset == 16)
			{
				ProcessBlock();
				currentBlockOffset = 0;
			}
			int toCopy = System.Math.Min(len - copied, 16 - currentBlockOffset);
			Array.Copy(input, copied + inOff, currentBlock, currentBlockOffset, toCopy);
			copied += toCopy;
			currentBlockOffset += toCopy;
		}
	}

	private void ProcessBlock()
	{
		if (currentBlockOffset < 16)
		{
			currentBlock[currentBlockOffset] = 1;
			for (int i = currentBlockOffset + 1; i < 16; i++)
			{
				currentBlock[i] = 0;
			}
		}
		ulong t0 = Pack.LE_To_UInt32(currentBlock, 0);
		ulong t1 = Pack.LE_To_UInt32(currentBlock, 4);
		ulong t2 = Pack.LE_To_UInt32(currentBlock, 8);
		ulong t3 = Pack.LE_To_UInt32(currentBlock, 12);
		h0 += (uint)(int)(t0 & 0x3FFFFFF);
		h1 += (uint)(int)((((t1 << 32) | t0) >> 26) & 0x3FFFFFF);
		h2 += (uint)(int)((((t2 << 32) | t1) >> 20) & 0x3FFFFFF);
		h3 += (uint)(int)((((t3 << 32) | t2) >> 14) & 0x3FFFFFF);
		h4 += (uint)(int)(t3 >> 8);
		if (currentBlockOffset == 16)
		{
			h4 += 16777216u;
		}
		ulong tp0 = mul32x32_64(h0, r0) + mul32x32_64(h1, s4) + mul32x32_64(h2, s3) + mul32x32_64(h3, s2) + mul32x32_64(h4, s1);
		ulong tp1 = mul32x32_64(h0, r1) + mul32x32_64(h1, r0) + mul32x32_64(h2, s4) + mul32x32_64(h3, s3) + mul32x32_64(h4, s2);
		ulong tp2 = mul32x32_64(h0, r2) + mul32x32_64(h1, r1) + mul32x32_64(h2, r0) + mul32x32_64(h3, s4) + mul32x32_64(h4, s3);
		ulong tp3 = mul32x32_64(h0, r3) + mul32x32_64(h1, r2) + mul32x32_64(h2, r1) + mul32x32_64(h3, r0) + mul32x32_64(h4, s4);
		ulong tp4 = mul32x32_64(h0, r4) + mul32x32_64(h1, r3) + mul32x32_64(h2, r2) + mul32x32_64(h3, r1) + mul32x32_64(h4, r0);
		h0 = (uint)((int)tp0 & 0x3FFFFFF);
		tp1 += tp0 >> 26;
		h1 = (uint)((int)tp1 & 0x3FFFFFF);
		tp2 += tp1 >> 26;
		h2 = (uint)((int)tp2 & 0x3FFFFFF);
		tp3 += tp2 >> 26;
		h3 = (uint)((int)tp3 & 0x3FFFFFF);
		tp4 += tp3 >> 26;
		h4 = (uint)((int)tp4 & 0x3FFFFFF);
		h0 += (uint)((int)(tp4 >> 26) * 5);
		h1 += h0 >> 26;
		h0 &= 67108863u;
	}

	public int DoFinal(byte[] output, int outOff)
	{
		Check.DataLength(output, outOff, 16, "Output buffer is too short.");
		if (currentBlockOffset > 0)
		{
			ProcessBlock();
		}
		h1 += h0 >> 26;
		h0 &= 67108863u;
		h2 += h1 >> 26;
		h1 &= 67108863u;
		h3 += h2 >> 26;
		h2 &= 67108863u;
		h4 += h3 >> 26;
		h3 &= 67108863u;
		h0 += (h4 >> 26) * 5;
		h4 &= 67108863u;
		h1 += h0 >> 26;
		h0 &= 67108863u;
		uint g0 = h0 + 5;
		uint b = g0 >> 26;
		g0 &= 0x3FFFFFF;
		uint g1 = h1 + b;
		b = g1 >> 26;
		g1 &= 0x3FFFFFF;
		uint g2 = h2 + b;
		b = g2 >> 26;
		g2 &= 0x3FFFFFF;
		uint g3 = h3 + b;
		b = g3 >> 26;
		g3 &= 0x3FFFFFF;
		uint g4 = h4 + b - 67108864;
		b = (g4 >> 31) - 1;
		uint nb = ~b;
		h0 = (h0 & nb) | (g0 & b);
		h1 = (h1 & nb) | (g1 & b);
		h2 = (h2 & nb) | (g2 & b);
		h3 = (h3 & nb) | (g3 & b);
		h4 = (h4 & nb) | (g4 & b);
		ulong f0 = (ulong)(h0 | (h1 << 26)) + (ulong)k0;
		ulong f1 = (ulong)((h1 >> 6) | (h2 << 20)) + (ulong)k1;
		ulong f2 = (ulong)((h2 >> 12) | (h3 << 14)) + (ulong)k2;
		long num = (long)((h3 >> 18) | (h4 << 8)) + (long)k3;
		Pack.UInt32_To_LE((uint)f0, output, outOff);
		f1 += f0 >> 32;
		Pack.UInt32_To_LE((uint)f1, output, outOff + 4);
		f2 += f1 >> 32;
		Pack.UInt32_To_LE((uint)f2, output, outOff + 8);
		Pack.UInt32_To_LE((uint)((ulong)num + (f2 >> 32)), output, outOff + 12);
		Reset();
		return 16;
	}

	public void Reset()
	{
		currentBlockOffset = 0;
		h0 = (h1 = (h2 = (h3 = (h4 = 0u))));
	}

	private static ulong mul32x32_64(uint i1, uint i2)
	{
		return (ulong)i1 * (ulong)i2;
	}
}
