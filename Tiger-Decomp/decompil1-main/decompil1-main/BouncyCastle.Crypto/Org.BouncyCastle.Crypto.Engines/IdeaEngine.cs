using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class IdeaEngine : IBlockCipher
{
	private const int BLOCK_SIZE = 8;

	private int[] workingKey;

	private static readonly int MASK = 65535;

	private static readonly int BASE = 65537;

	public virtual string AlgorithmName => "IDEA";

	public virtual bool IsPartialBlockOkay => false;

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to IDEA init - " + Platform.GetTypeName(parameters));
		}
		workingKey = GenerateWorkingKey(forEncryption, ((KeyParameter)parameters).GetKey());
	}

	public virtual int GetBlockSize()
	{
		return 8;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (workingKey == null)
		{
			throw new InvalidOperationException("IDEA engine not initialised");
		}
		Check.DataLength(input, inOff, 8, "input buffer too short");
		Check.OutputLength(output, outOff, 8, "output buffer too short");
		IdeaFunc(workingKey, input, inOff, output, outOff);
		return 8;
	}

	public virtual void Reset()
	{
	}

	private int BytesToWord(byte[] input, int inOff)
	{
		return ((input[inOff] << 8) & 0xFF00) + (input[inOff + 1] & 0xFF);
	}

	private void WordToBytes(int word, byte[] outBytes, int outOff)
	{
		outBytes[outOff] = (byte)((uint)word >> 8);
		outBytes[outOff + 1] = (byte)word;
	}

	private int Mul(int x, int y)
	{
		if (x == 0)
		{
			x = BASE - y;
		}
		else if (y == 0)
		{
			x = BASE - x;
		}
		else
		{
			int num = x * y;
			y = num & MASK;
			x = num >>> 16;
			x = y - x + ((y < x) ? 1 : 0);
		}
		return x & MASK;
	}

	private void IdeaFunc(int[] workingKey, byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int keyOff = 0;
		int x0 = BytesToWord(input, inOff);
		int x1 = BytesToWord(input, inOff + 2);
		int x2 = BytesToWord(input, inOff + 4);
		int x3 = BytesToWord(input, inOff + 6);
		for (int round = 0; round < 8; round++)
		{
			x0 = Mul(x0, workingKey[keyOff++]);
			x1 += workingKey[keyOff++];
			x1 &= MASK;
			x2 += workingKey[keyOff++];
			x2 &= MASK;
			x3 = Mul(x3, workingKey[keyOff++]);
			int t0 = x1;
			int t1 = x2;
			x2 ^= x0;
			x1 ^= x3;
			x2 = Mul(x2, workingKey[keyOff++]);
			x1 += x2;
			x1 &= MASK;
			x1 = Mul(x1, workingKey[keyOff++]);
			x2 += x1;
			x2 &= MASK;
			x0 ^= x1;
			x3 ^= x2;
			x1 ^= t1;
			x2 ^= t0;
		}
		WordToBytes(Mul(x0, workingKey[keyOff++]), outBytes, outOff);
		WordToBytes(x2 + workingKey[keyOff++], outBytes, outOff + 2);
		WordToBytes(x1 + workingKey[keyOff++], outBytes, outOff + 4);
		WordToBytes(Mul(x3, workingKey[keyOff]), outBytes, outOff + 6);
	}

	private int[] ExpandKey(byte[] uKey)
	{
		int[] key = new int[52];
		if (uKey.Length < 16)
		{
			byte[] tmp = new byte[16];
			Array.Copy(uKey, 0, tmp, tmp.Length - uKey.Length, uKey.Length);
			uKey = tmp;
		}
		for (int i = 0; i < 8; i++)
		{
			key[i] = BytesToWord(uKey, i * 2);
		}
		for (int j = 8; j < 52; j++)
		{
			if ((j & 7) < 6)
			{
				key[j] = (((key[j - 7] & 0x7F) << 9) | (key[j - 6] >> 7)) & MASK;
			}
			else if ((j & 7) == 6)
			{
				key[j] = (((key[j - 7] & 0x7F) << 9) | (key[j - 14] >> 7)) & MASK;
			}
			else
			{
				key[j] = (((key[j - 15] & 0x7F) << 9) | (key[j - 14] >> 7)) & MASK;
			}
		}
		return key;
	}

	private int MulInv(int x)
	{
		if (x < 2)
		{
			return x;
		}
		int t0 = 1;
		int t1 = BASE / x;
		int y = BASE % x;
		while (y != 1)
		{
			int q = x / y;
			x %= y;
			t0 = (t0 + t1 * q) & MASK;
			if (x == 1)
			{
				return t0;
			}
			q = y / x;
			y %= x;
			t1 = (t1 + t0 * q) & MASK;
		}
		return (1 - t1) & MASK;
	}

	private int AddInv(int x)
	{
		return -x & MASK;
	}

	private int[] InvertKey(int[] inKey)
	{
		int p = 52;
		int[] key = new int[52];
		int inOff = 0;
		int t1 = MulInv(inKey[inOff++]);
		int t2 = AddInv(inKey[inOff++]);
		int t3 = AddInv(inKey[inOff++]);
		int t4 = MulInv(inKey[inOff++]);
		key[--p] = t4;
		key[--p] = t3;
		key[--p] = t2;
		key[--p] = t1;
		for (int round = 1; round < 8; round++)
		{
			t1 = inKey[inOff++];
			t2 = inKey[inOff++];
			key[--p] = t2;
			key[--p] = t1;
			t1 = MulInv(inKey[inOff++]);
			t2 = AddInv(inKey[inOff++]);
			t3 = AddInv(inKey[inOff++]);
			t4 = MulInv(inKey[inOff++]);
			key[--p] = t4;
			key[--p] = t2;
			key[--p] = t3;
			key[--p] = t1;
		}
		t1 = inKey[inOff++];
		t2 = inKey[inOff++];
		key[--p] = t2;
		key[--p] = t1;
		t1 = MulInv(inKey[inOff++]);
		t2 = AddInv(inKey[inOff++]);
		t3 = AddInv(inKey[inOff++]);
		t4 = MulInv(inKey[inOff]);
		key[--p] = t4;
		key[--p] = t3;
		key[--p] = t2;
		key[--p] = t1;
		return key;
	}

	private int[] GenerateWorkingKey(bool forEncryption, byte[] userKey)
	{
		if (forEncryption)
		{
			return ExpandKey(userKey);
		}
		return InvertKey(ExpandKey(userKey));
	}
}
