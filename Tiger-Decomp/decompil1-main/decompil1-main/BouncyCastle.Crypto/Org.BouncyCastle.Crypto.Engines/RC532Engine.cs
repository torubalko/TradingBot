using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RC532Engine : IBlockCipher
{
	private int _noRounds;

	private int[] _S;

	private static readonly int P32 = -1209970333;

	private static readonly int Q32 = -1640531527;

	private bool forEncryption;

	public virtual string AlgorithmName => "RC5-32";

	public virtual bool IsPartialBlockOkay => false;

	public RC532Engine()
	{
		_noRounds = 12;
	}

	public virtual int GetBlockSize()
	{
		return 8;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (typeof(RC5Parameters).IsInstanceOfType(parameters))
		{
			RC5Parameters p = (RC5Parameters)parameters;
			_noRounds = p.Rounds;
			SetKey(p.GetKey());
		}
		else
		{
			if (!typeof(KeyParameter).IsInstanceOfType(parameters))
			{
				throw new ArgumentException("invalid parameter passed to RC532 init - " + Platform.GetTypeName(parameters));
			}
			KeyParameter p2 = (KeyParameter)parameters;
			SetKey(p2.GetKey());
		}
		this.forEncryption = forEncryption;
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (!forEncryption)
		{
			return DecryptBlock(input, inOff, output, outOff);
		}
		return EncryptBlock(input, inOff, output, outOff);
	}

	public virtual void Reset()
	{
	}

	private void SetKey(byte[] key)
	{
		int[] L = new int[(key.Length + 3) / 4];
		for (int i = 0; i != key.Length; i++)
		{
			L[i / 4] += (key[i] & 0xFF) << 8 * (i % 4);
		}
		_S = new int[2 * (_noRounds + 1)];
		_S[0] = P32;
		for (int j = 1; j < _S.Length; j++)
		{
			_S[j] = _S[j - 1] + Q32;
		}
		int iter = ((L.Length <= _S.Length) ? (3 * _S.Length) : (3 * L.Length));
		int A = 0;
		int B = 0;
		int ii = 0;
		int jj = 0;
		for (int k = 0; k < iter; k++)
		{
			A = (_S[ii] = RotateLeft(_S[ii] + A + B, 3));
			B = (L[jj] = RotateLeft(L[jj] + A + B, A + B));
			ii = (ii + 1) % _S.Length;
			jj = (jj + 1) % L.Length;
		}
	}

	private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int A = BytesToWord(input, inOff) + _S[0];
		int B = BytesToWord(input, inOff + 4) + _S[1];
		for (int i = 1; i <= _noRounds; i++)
		{
			A = RotateLeft(A ^ B, B) + _S[2 * i];
			B = RotateLeft(B ^ A, A) + _S[2 * i + 1];
		}
		WordToBytes(A, outBytes, outOff);
		WordToBytes(B, outBytes, outOff + 4);
		return 8;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int A = BytesToWord(input, inOff);
		int B = BytesToWord(input, inOff + 4);
		for (int i = _noRounds; i >= 1; i--)
		{
			B = RotateRight(B - _S[2 * i + 1], A) ^ A;
			A = RotateRight(A - _S[2 * i], B) ^ B;
		}
		WordToBytes(A - _S[0], outBytes, outOff);
		WordToBytes(B - _S[1], outBytes, outOff + 4);
		return 8;
	}

	private int RotateLeft(int x, int y)
	{
		return (x << (y & 0x1F)) | (x >>> 32 - (y & 0x1F));
	}

	private int RotateRight(int x, int y)
	{
		return (x >>> (y & 0x1F)) | (x << 32 - (y & 0x1F));
	}

	private int BytesToWord(byte[] src, int srcOff)
	{
		return (src[srcOff] & 0xFF) | ((src[srcOff + 1] & 0xFF) << 8) | ((src[srcOff + 2] & 0xFF) << 16) | ((src[srcOff + 3] & 0xFF) << 24);
	}

	private void WordToBytes(int word, byte[] dst, int dstOff)
	{
		dst[dstOff] = (byte)word;
		dst[dstOff + 1] = (byte)(word >> 8);
		dst[dstOff + 2] = (byte)(word >> 16);
		dst[dstOff + 3] = (byte)(word >> 24);
	}
}
