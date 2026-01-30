using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings;

public class PaddedBufferedBlockCipher : BufferedBlockCipher
{
	private readonly IBlockCipherPadding padding;

	public PaddedBufferedBlockCipher(IBlockCipher cipher, IBlockCipherPadding padding)
	{
		base.cipher = cipher;
		this.padding = padding;
		buf = new byte[cipher.GetBlockSize()];
		bufOff = 0;
	}

	public PaddedBufferedBlockCipher(IBlockCipher cipher)
		: this(cipher, new Pkcs7Padding())
	{
	}

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
		base.forEncryption = forEncryption;
		SecureRandom initRandom = null;
		if (parameters is ParametersWithRandom)
		{
			ParametersWithRandom obj = (ParametersWithRandom)parameters;
			initRandom = obj.Random;
			parameters = obj.Parameters;
		}
		Reset();
		padding.Init(initRandom);
		cipher.Init(forEncryption, parameters);
	}

	public override int GetOutputSize(int length)
	{
		int total = length + bufOff;
		int leftOver = total % buf.Length;
		if (leftOver == 0)
		{
			if (forEncryption)
			{
				return total + buf.Length;
			}
			return total;
		}
		return total - leftOver + buf.Length;
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

	public override int ProcessByte(byte input, byte[] output, int outOff)
	{
		int resultLen = 0;
		if (bufOff == buf.Length)
		{
			resultLen = cipher.ProcessBlock(buf, 0, output, outOff);
			bufOff = 0;
		}
		buf[bufOff++] = input;
		return resultLen;
	}

	public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		if (length < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
		int blockSize = GetBlockSize();
		int outLength = GetUpdateOutputSize(length);
		if (outLength > 0)
		{
			Check.OutputLength(output, outOff, outLength, "output buffer too short");
		}
		int resultLen = 0;
		int gapLen = buf.Length - bufOff;
		if (length > gapLen)
		{
			Array.Copy(input, inOff, buf, bufOff, gapLen);
			resultLen += cipher.ProcessBlock(buf, 0, output, outOff);
			bufOff = 0;
			length -= gapLen;
			inOff += gapLen;
			while (length > buf.Length)
			{
				resultLen += cipher.ProcessBlock(input, inOff, output, outOff + resultLen);
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
		int blockSize = cipher.GetBlockSize();
		int resultLen = 0;
		if (forEncryption)
		{
			if (bufOff == blockSize)
			{
				if (outOff + 2 * blockSize > output.Length)
				{
					Reset();
					throw new OutputLengthException("output buffer too short");
				}
				resultLen = cipher.ProcessBlock(buf, 0, output, outOff);
				bufOff = 0;
			}
			padding.AddPadding(buf, bufOff);
			resultLen += cipher.ProcessBlock(buf, 0, output, outOff + resultLen);
			Reset();
		}
		else
		{
			if (bufOff != blockSize)
			{
				Reset();
				throw new DataLengthException("last block incomplete in decryption");
			}
			resultLen = cipher.ProcessBlock(buf, 0, buf, 0);
			bufOff = 0;
			try
			{
				resultLen -= padding.PadCount(buf);
				Array.Copy(buf, 0, output, outOff, resultLen);
			}
			finally
			{
				Reset();
			}
		}
		return resultLen;
	}
}
