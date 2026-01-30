using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Modes;

public class OpenPgpCfbBlockCipher : IBlockCipher
{
	private byte[] IV;

	private byte[] FR;

	private byte[] FRE;

	private readonly IBlockCipher cipher;

	private readonly int blockSize;

	private int count;

	private bool forEncryption;

	public string AlgorithmName => cipher.AlgorithmName + "/OpenPGPCFB";

	public bool IsPartialBlockOkay => true;

	public OpenPgpCfbBlockCipher(IBlockCipher cipher)
	{
		this.cipher = cipher;
		blockSize = cipher.GetBlockSize();
		IV = new byte[blockSize];
		FR = new byte[blockSize];
		FRE = new byte[blockSize];
	}

	public IBlockCipher GetUnderlyingCipher()
	{
		return cipher;
	}

	public int GetBlockSize()
	{
		return cipher.GetBlockSize();
	}

	public int ProcessBlock(byte[] input, int inOff, byte[] output, int outOff)
	{
		if (!forEncryption)
		{
			return DecryptBlock(input, inOff, output, outOff);
		}
		return EncryptBlock(input, inOff, output, outOff);
	}

	public void Reset()
	{
		count = 0;
		Array.Copy(IV, 0, FR, 0, FR.Length);
		cipher.Reset();
	}

	public void Init(bool forEncryption, ICipherParameters parameters)
	{
		this.forEncryption = forEncryption;
		if (parameters is ParametersWithIV)
		{
			ParametersWithIV ivParam = (ParametersWithIV)parameters;
			byte[] iv = ivParam.GetIV();
			if (iv.Length < IV.Length)
			{
				Array.Copy(iv, 0, IV, IV.Length - iv.Length, iv.Length);
				for (int i = 0; i < IV.Length - iv.Length; i++)
				{
					IV[i] = 0;
				}
			}
			else
			{
				Array.Copy(iv, 0, IV, 0, IV.Length);
			}
			parameters = ivParam.Parameters;
		}
		Reset();
		cipher.Init(forEncryption: true, parameters);
	}

	private byte EncryptByte(byte data, int blockOff)
	{
		return (byte)(FRE[blockOff] ^ data);
	}

	private int EncryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		if (inOff + blockSize > input.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		if (outOff + blockSize > outBytes.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		if (count > blockSize)
		{
			FR[blockSize - 2] = (outBytes[outOff] = EncryptByte(input[inOff], blockSize - 2));
			FR[blockSize - 1] = (outBytes[outOff + 1] = EncryptByte(input[inOff + 1], blockSize - 1));
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int n = 2; n < blockSize; n++)
			{
				FR[n - 2] = (outBytes[outOff + n] = EncryptByte(input[inOff + n], n - 2));
			}
		}
		else if (count == 0)
		{
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int i = 0; i < blockSize; i++)
			{
				FR[i] = (outBytes[outOff + i] = EncryptByte(input[inOff + i], i));
			}
			count += blockSize;
		}
		else if (count == blockSize)
		{
			cipher.ProcessBlock(FR, 0, FRE, 0);
			outBytes[outOff] = EncryptByte(input[inOff], 0);
			outBytes[outOff + 1] = EncryptByte(input[inOff + 1], 1);
			Array.Copy(FR, 2, FR, 0, blockSize - 2);
			Array.Copy(outBytes, outOff, FR, blockSize - 2, 2);
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int j = 2; j < blockSize; j++)
			{
				FR[j - 2] = (outBytes[outOff + j] = EncryptByte(input[inOff + j], j - 2));
			}
			count += blockSize;
		}
		return blockSize;
	}

	private int DecryptBlock(byte[] input, int inOff, byte[] outBytes, int outOff)
	{
		if (inOff + blockSize > input.Length)
		{
			throw new DataLengthException("input buffer too short");
		}
		if (outOff + blockSize > outBytes.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		if (count > blockSize)
		{
			byte inVal = input[inOff];
			FR[blockSize - 2] = inVal;
			outBytes[outOff] = EncryptByte(inVal, blockSize - 2);
			inVal = input[inOff + 1];
			FR[blockSize - 1] = inVal;
			outBytes[outOff + 1] = EncryptByte(inVal, blockSize - 1);
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int n = 2; n < blockSize; n++)
			{
				inVal = input[inOff + n];
				FR[n - 2] = inVal;
				outBytes[outOff + n] = EncryptByte(inVal, n - 2);
			}
		}
		else if (count == 0)
		{
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int i = 0; i < blockSize; i++)
			{
				FR[i] = input[inOff + i];
				outBytes[i] = EncryptByte(input[inOff + i], i);
			}
			count += blockSize;
		}
		else if (count == blockSize)
		{
			cipher.ProcessBlock(FR, 0, FRE, 0);
			byte inVal2 = input[inOff];
			byte inVal3 = input[inOff + 1];
			outBytes[outOff] = EncryptByte(inVal2, 0);
			outBytes[outOff + 1] = EncryptByte(inVal3, 1);
			Array.Copy(FR, 2, FR, 0, blockSize - 2);
			FR[blockSize - 2] = inVal2;
			FR[blockSize - 1] = inVal3;
			cipher.ProcessBlock(FR, 0, FRE, 0);
			for (int j = 2; j < blockSize; j++)
			{
				byte inVal4 = input[inOff + j];
				FR[j - 2] = inVal4;
				outBytes[outOff + j] = EncryptByte(inVal4, j - 2);
			}
			count += blockSize;
		}
		return blockSize;
	}
}
