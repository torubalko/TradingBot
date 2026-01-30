using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RC564Engine : IBlockCipher
{
	private static readonly int wordSize = 64;

	private static readonly int bytesPerWord = wordSize / 8;

	private int _noRounds;

	private long[] _S;

	private static readonly long P64 = -5196783011329398165L;

	private static readonly long Q64 = -7046029254386353131L;

	private bool forEncryption;

	public virtual string AlgorithmName => "RC5-64";

	public virtual bool IsPartialBlockOkay => false;

	public RC564Engine()
	{
		_noRounds = 12;
	}

	public virtual int GetBlockSize()
	{
		return 2 * bytesPerWord;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!typeof(RC5Parameters).IsInstanceOfType(parameters))
		{
			throw new ArgumentException("invalid parameter passed to RC564 init - " + Platform.GetTypeName(parameters));
		}
		RC5Parameters p = (RC5Parameters)parameters;
		this.forEncryption = forEncryption;
		_noRounds = p.Rounds;
		SetKey(p.GetKey());
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
		long[] L = new long[(key.Length + (bytesPerWord - 1)) / bytesPerWord];
		for (int i = 0; i != key.Length; i++)
		{
			L[i / bytesPerWord] += (long)(key[i] & 0xFF) << 8 * (i % bytesPerWord);
		}
		_S = new long[2 * (_noRounds + 1)];
		_S[0] = P64;
		for (int j = 1; j < _S.Length; j++)
		{
			_S[j] = _S[j - 1] + Q64;
		}
		int iter = ((L.Length <= _S.Length) ? (3 * _S.Length) : (3 * L.Length));
		long A = 0L;
		long B = 0L;
		int ii = 0;
		int jj = 0;
		for (int k = 0; k < iter; k++)
		{
			A = (_S[ii] = RotateLeft(_S[ii] + A + B, 3L));
			B = (L[jj] = RotateLeft(L[jj] + A + B, A + B));
			ii = (ii + 1) % _S.Length;
			jj = (jj + 1) % L.Length;
		}
	}

	private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		long A = BytesToWord(input, inOff) + _S[0];
		long B = BytesToWord(input, inOff + bytesPerWord) + _S[1];
		for (int i = 1; i <= _noRounds; i++)
		{
			A = RotateLeft(A ^ B, B) + _S[2 * i];
			B = RotateLeft(B ^ A, A) + _S[2 * i + 1];
		}
		WordToBytes(A, outBytes, outOff);
		WordToBytes(B, outBytes, outOff + bytesPerWord);
		return 2 * bytesPerWord;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		long A = BytesToWord(input, inOff);
		long B = BytesToWord(input, inOff + bytesPerWord);
		for (int i = _noRounds; i >= 1; i--)
		{
			B = RotateRight(B - _S[2 * i + 1], A) ^ A;
			A = RotateRight(A - _S[2 * i], B) ^ B;
		}
		WordToBytes(A - _S[0], outBytes, outOff);
		WordToBytes(B - _S[1], outBytes, outOff + bytesPerWord);
		return 2 * bytesPerWord;
	}

	private long RotateLeft(long x, long y)
	{
		return (x << (int)(y & (wordSize - 1))) | (x >>> (int)(wordSize - (y & (wordSize - 1))));
	}

	private long RotateRight(long x, long y)
	{
		return (x >>> (int)(y & (wordSize - 1))) | (x << (int)(wordSize - (y & (wordSize - 1))));
	}

	private long BytesToWord(byte[] src, int srcOff)
	{
		long word = 0L;
		for (int i = bytesPerWord - 1; i >= 0; i--)
		{
			word = (word << 8) + (src[i + srcOff] & 0xFF);
		}
		return word;
	}

	private void WordToBytes(long word, byte[] dst, int dstOff)
	{
		for (int i = 0; i < bytesPerWord; i++)
		{
			dst[i + dstOff] = (byte)word;
			word >>>= 8;
		}
	}
}
