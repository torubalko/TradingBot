using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Engines;

public class RC6Engine : IBlockCipher
{
	private static readonly int wordSize = 32;

	private static readonly int bytesPerWord = wordSize / 8;

	private static readonly int _noRounds = 20;

	private int[] _S;

	private static readonly int P32 = -1209970333;

	private static readonly int Q32 = -1640531527;

	private static readonly int LGW = 5;

	private bool forEncryption;

	public virtual string AlgorithmName => "RC6";

	public virtual bool IsPartialBlockOkay => false;

	public virtual int GetBlockSize()
	{
		return 4 * bytesPerWord;
	}

	public virtual void Init(bool forEncryption, ICipherParameters parameters)
	{
		if (!(parameters is KeyParameter))
		{
			throw new ArgumentException("invalid parameter passed to RC6 init - " + Platform.GetTypeName(parameters));
		}
		this.forEncryption = forEncryption;
		KeyParameter p = (KeyParameter)parameters;
		SetKey(p.GetKey());
	}

	public virtual int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		int blockSize = GetBlockSize();
		if (_S == null)
		{
			throw new InvalidOperationException("RC6 engine not initialised");
		}
		Check.DataLength(input, inOff, blockSize, "input buffer too short");
		Check.OutputLength(output, outOff, blockSize, "output buffer too short");
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
		_ = (key.Length + (bytesPerWord - 1)) / bytesPerWord;
		int[] L = new int[(key.Length + bytesPerWord - 1) / bytesPerWord];
		for (int i = key.Length - 1; i >= 0; i--)
		{
			L[i / bytesPerWord] = (L[i / bytesPerWord] << 8) + (key[i] & 0xFF);
		}
		_S = new int[2 + 2 * _noRounds + 2];
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
		int A = BytesToWord(input, inOff);
		int B = BytesToWord(input, inOff + bytesPerWord);
		int C = BytesToWord(input, inOff + bytesPerWord * 2);
		int D = BytesToWord(input, inOff + bytesPerWord * 3);
		B += _S[0];
		D += _S[1];
		for (int i = 1; i <= _noRounds; i++)
		{
			int t = 0;
			int u = 0;
			t = B * (2 * B + 1);
			t = RotateLeft(t, 5);
			u = D * (2 * D + 1);
			u = RotateLeft(u, 5);
			A ^= t;
			A = RotateLeft(A, u);
			A += _S[2 * i];
			C ^= u;
			C = RotateLeft(C, t);
			C += _S[2 * i + 1];
			int num = A;
			A = B;
			B = C;
			C = D;
			D = num;
		}
		A += _S[2 * _noRounds + 2];
		C += _S[2 * _noRounds + 3];
		WordToBytes(A, outBytes, outOff);
		WordToBytes(B, outBytes, outOff + bytesPerWord);
		WordToBytes(C, outBytes, outOff + bytesPerWord * 2);
		WordToBytes(D, outBytes, outOff + bytesPerWord * 3);
		return 4 * bytesPerWord;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		int A = BytesToWord(input, inOff);
		int B = BytesToWord(input, inOff + bytesPerWord);
		int C = BytesToWord(input, inOff + bytesPerWord * 2);
		int D = BytesToWord(input, inOff + bytesPerWord * 3);
		C -= _S[2 * _noRounds + 3];
		A -= _S[2 * _noRounds + 2];
		for (int i = _noRounds; i >= 1; i--)
		{
			int t = 0;
			int u = 0;
			int num = D;
			D = C;
			C = B;
			B = A;
			A = num;
			t = B * (2 * B + 1);
			t = RotateLeft(t, LGW);
			u = D * (2 * D + 1);
			u = RotateLeft(u, LGW);
			C -= _S[2 * i + 1];
			C = RotateRight(C, t);
			C ^= u;
			A -= _S[2 * i];
			A = RotateRight(A, u);
			A ^= t;
		}
		D -= _S[1];
		B -= _S[0];
		WordToBytes(A, outBytes, outOff);
		WordToBytes(B, outBytes, outOff + bytesPerWord);
		WordToBytes(C, outBytes, outOff + bytesPerWord * 2);
		WordToBytes(D, outBytes, outOff + bytesPerWord * 3);
		return 4 * bytesPerWord;
	}

	private int RotateLeft(int x, int y)
	{
		return (x << (y & (wordSize - 1))) | (x >>> wordSize - (y & (wordSize - 1)));
	}

	private int RotateRight(int x, int y)
	{
		return (x >>> (y & (wordSize - 1))) | (x << wordSize - (y & (wordSize - 1)));
	}

	private int BytesToWord(byte[] src, int srcOff)
	{
		int word = 0;
		for (int i = bytesPerWord - 1; i >= 0; i--)
		{
			word = (word << 8) + (src[i + srcOff] & 0xFF);
		}
		return word;
	}

	private void WordToBytes(int word, byte[] dst, int dstOff)
	{
		for (int i = 0; i < bytesPerWord; i++)
		{
			dst[i + dstOff] = (byte)word;
			word >>>= 8;
		}
	}
}
