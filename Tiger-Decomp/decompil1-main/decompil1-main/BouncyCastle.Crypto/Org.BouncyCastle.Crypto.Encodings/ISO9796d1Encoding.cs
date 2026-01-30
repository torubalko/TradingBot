using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Encodings;

public class ISO9796d1Encoding : IAsymmetricBlockCipher
{
	private static readonly BigInteger Sixteen = BigInteger.ValueOf(16L);

	private static readonly BigInteger Six = BigInteger.ValueOf(6L);

	private static readonly byte[] shadows = new byte[16]
	{
		14, 3, 5, 8, 9, 4, 2, 15, 0, 13,
		11, 6, 7, 10, 12, 1
	};

	private static readonly byte[] inverse = new byte[16]
	{
		8, 15, 6, 1, 5, 2, 11, 12, 3, 4,
		13, 10, 14, 9, 0, 7
	};

	private readonly IAsymmetricBlockCipher engine;

	private bool forEncryption;

	private int bitSize;

	private int padBits;

	private BigInteger modulus;

	public string AlgorithmName => engine.AlgorithmName + "/ISO9796-1Padding";

	public ISO9796d1Encoding(IAsymmetricBlockCipher cipher)
	{
		engine = cipher;
	}

	public IAsymmetricBlockCipher GetUnderlyingCipher()
	{
		return engine;
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
		RsaKeyParameters kParam = ((!(parameters is ParametersWithRandom)) ? ((RsaKeyParameters)parameters) : ((RsaKeyParameters)((ParametersWithRandom)parameters).Parameters));
		engine.Init(forEncryption, parameters);
		modulus = kParam.Modulus;
		bitSize = modulus.BitLength;
		this.forEncryption = forEncryption;
	}

	public int GetInputBlockSize()
	{
		int baseBlockSize = engine.GetInputBlockSize();
		if (forEncryption)
		{
			return (baseBlockSize + 1) / 2;
		}
		return baseBlockSize;
	}

	public int GetOutputBlockSize()
	{
		int baseBlockSize = engine.GetOutputBlockSize();
		if (forEncryption)
		{
			return baseBlockSize;
		}
		return (baseBlockSize + 1) / 2;
	}

	public void SetPadBits(int padBits)
	{
		if (padBits > 7)
		{
			throw new ArgumentException("padBits > 7");
		}
		this.padBits = padBits;
	}

	public int GetPadBits()
	{
		return padBits;
	}

	public byte[] ProcessBlock(byte[] input, int inOff, int length)
	{
		if (forEncryption)
		{
			return EncodeBlock(input, inOff, length);
		}
		return DecodeBlock(input, inOff, length);
	}

	private byte[] EncodeBlock(byte[] input, int inOff, int inLen)
	{
		byte[] block = new byte[(bitSize + 7) / 8];
		int r = padBits + 1;
		int t = (bitSize + 13) / 16;
		for (int i = 0; i < t; i += inLen)
		{
			if (i > t - inLen)
			{
				Array.Copy(input, inOff + inLen - (t - i), block, block.Length - t, t - i);
			}
			else
			{
				Array.Copy(input, inOff, block, block.Length - (i + inLen), inLen);
			}
		}
		for (int j = block.Length - 2 * t; j != block.Length; j += 2)
		{
			byte val = block[block.Length - t + j / 2];
			block[j] = (byte)((shadows[(val & 0xFF) >>> 4] << 4) | shadows[val & 0xF]);
			block[j + 1] = val;
		}
		block[block.Length - 2 * inLen] ^= (byte)r;
		block[block.Length - 1] = (byte)((block[block.Length - 1] << 4) | 6);
		int maxBit = 8 - (bitSize - 1) % 8;
		int offSet = 0;
		if (maxBit != 8)
		{
			block[0] &= (byte)(255 >> maxBit);
			block[0] |= (byte)(128 >> maxBit);
		}
		else
		{
			block[0] = 0;
			block[1] |= 128;
			offSet = 1;
		}
		return engine.ProcessBlock(block, offSet, block.Length - offSet);
	}

	private byte[] DecodeBlock(byte[] input, int inOff, int inLen)
	{
		byte[] block = engine.ProcessBlock(input, inOff, inLen);
		int r = 1;
		int t = (bitSize + 13) / 16;
		BigInteger iS = new BigInteger(1, block);
		BigInteger iR;
		if (iS.Mod(Sixteen).Equals(Six))
		{
			iR = iS;
		}
		else
		{
			iR = modulus.Subtract(iS);
			if (!iR.Mod(Sixteen).Equals(Six))
			{
				throw new InvalidCipherTextException("resulting integer iS or (modulus - iS) is not congruent to 6 mod 16");
			}
		}
		block = iR.ToByteArrayUnsigned();
		if ((block[block.Length - 1] & 0xF) != 6)
		{
			throw new InvalidCipherTextException("invalid forcing byte in block");
		}
		block[block.Length - 1] = (byte)(((ushort)(block[block.Length - 1] & 0xFF) >> 4) | (inverse[(block[block.Length - 2] & 0xFF) >> 4] << 4));
		block[0] = (byte)((shadows[(block[1] & 0xFF) >>> 4] << 4) | shadows[block[1] & 0xF]);
		bool boundaryFound = false;
		int boundary = 0;
		for (int i = block.Length - 1; i >= block.Length - 2 * t; i -= 2)
		{
			int val = (shadows[(block[i] & 0xFF) >>> 4] << 4) | shadows[block[i] & 0xF];
			if (((block[i - 1] ^ val) & 0xFF) != 0)
			{
				if (boundaryFound)
				{
					throw new InvalidCipherTextException("invalid tsums in block");
				}
				boundaryFound = true;
				r = (block[i - 1] ^ val) & 0xFF;
				boundary = i - 1;
			}
		}
		block[boundary] = 0;
		byte[] nblock = new byte[(block.Length - boundary) / 2];
		for (int j = 0; j < nblock.Length; j++)
		{
			nblock[j] = block[2 * j + boundary + 1];
		}
		padBits = r - 1;
		return nblock;
	}
}
