using System;

namespace Org.BouncyCastle.Crypto.Modes;

public class CtsBlockCipher : BufferedBlockCipher
{
	private readonly int blockSize;

	public CtsBlockCipher(IBlockCipher cipher)
	{
		if (cipher is OfbBlockCipher || cipher is CfbBlockCipher)
		{
			throw new ArgumentException("CtsBlockCipher can only accept ECB, or CBC ciphers");
		}
		base.cipher = cipher;
		blockSize = cipher.GetBlockSize();
		buf = new byte[blockSize * 2];
		bufOff = 0;
	}

	public override int GetUpdateOutputSize(int length)
	{
		int total = length + bufOff;
		int leftOver = total % buf.Length;
		if (leftOver == 0)
		{
			return total - buf.Length;
		}
		return total - leftOver;
	}

	public override int GetOutputSize(int length)
	{
		return length + bufOff;
	}

	public override int ProcessByte(byte input, byte[] output, int outOff)
	{
		int resultLen = 0;
		if (bufOff == buf.Length)
		{
			resultLen = cipher.ProcessBlock(buf, 0, output, outOff);
			Array.Copy(buf, blockSize, buf, 0, blockSize);
			bufOff = blockSize;
		}
		buf[bufOff++] = input;
		return resultLen;
	}

	public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		if (length < 0)
		{
			throw new ArgumentException("Can't have a negative input outLength!");
		}
		int blockSize = GetBlockSize();
		int outLength = GetUpdateOutputSize(length);
		if (outLength > 0 && outOff + outLength > output.Length)
		{
			throw new DataLengthException("output buffer too short");
		}
		int resultLen = 0;
		int gapLen = buf.Length - bufOff;
		if (length > gapLen)
		{
			Array.Copy(input, inOff, buf, bufOff, gapLen);
			resultLen += cipher.ProcessBlock(buf, 0, output, outOff);
			Array.Copy(buf, blockSize, buf, 0, blockSize);
			bufOff = blockSize;
			length -= gapLen;
			inOff += gapLen;
			while (length > blockSize)
			{
				Array.Copy(input, inOff, buf, bufOff, blockSize);
				resultLen += cipher.ProcessBlock(buf, 0, output, outOff + resultLen);
				Array.Copy(buf, blockSize, buf, 0, blockSize);
				length -= blockSize;
				inOff += blockSize;
			}
		}
		Array.Copy(input, inOff, buf, bufOff, length);
		bufOff += length;
		return resultLen;
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		if (bufOff + outOff > output.Length)
		{
			throw new DataLengthException("output buffer too small in doFinal");
		}
		int blockSize = cipher.GetBlockSize();
		int length = bufOff - blockSize;
		byte[] block = new byte[blockSize];
		if (forEncryption)
		{
			cipher.ProcessBlock(buf, 0, block, 0);
			if (bufOff < blockSize)
			{
				throw new DataLengthException("need at least one block of input for CTS");
			}
			for (int i = bufOff; i != buf.Length; i++)
			{
				buf[i] = block[i - blockSize];
			}
			for (int j = blockSize; j != bufOff; j++)
			{
				buf[j] ^= block[j - blockSize];
			}
			((cipher is CbcBlockCipher) ? ((CbcBlockCipher)cipher).GetUnderlyingCipher() : cipher).ProcessBlock(buf, blockSize, output, outOff);
			Array.Copy(block, 0, output, outOff + blockSize, length);
		}
		else
		{
			byte[] lastBlock = new byte[blockSize];
			((cipher is CbcBlockCipher) ? ((CbcBlockCipher)cipher).GetUnderlyingCipher() : cipher).ProcessBlock(buf, 0, block, 0);
			for (int k = blockSize; k != bufOff; k++)
			{
				lastBlock[k - blockSize] = (byte)(block[k - blockSize] ^ buf[k]);
			}
			Array.Copy(buf, blockSize, block, 0, length);
			cipher.ProcessBlock(block, 0, output, outOff);
			Array.Copy(lastBlock, 0, output, outOff + blockSize, length);
		}
		int result = bufOff;
		Reset();
		return result;
	}
}
