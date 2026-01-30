using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto;

public class BufferedBlockCipher : BufferedCipherBase
{
	internal byte[] buf;

	internal int bufOff;

	internal bool forEncryption;

	internal IBlockCipher cipher;

	public override string AlgorithmName => cipher.AlgorithmName;

	protected BufferedBlockCipher()
	{
	}

	public BufferedBlockCipher(IBlockCipher cipher)
	{
		if (cipher == null)
		{
			throw new ArgumentNullException("cipher");
		}
		this.cipher = cipher;
		buf = new byte[cipher.GetBlockSize()];
		bufOff = 0;
	}

	public override void Init(bool forEncryption, ICipherParameters parameters)
	{
		this.forEncryption = forEncryption;
		if (parameters is ParametersWithRandom pwr)
		{
			parameters = pwr.Parameters;
		}
		Reset();
		cipher.Init(forEncryption, parameters);
	}

	public override int GetBlockSize()
	{
		return cipher.GetBlockSize();
	}

	public override int GetUpdateOutputSize(int length)
	{
		int num = length + bufOff;
		int leftOver = num % buf.Length;
		return num - leftOver;
	}

	public override int GetOutputSize(int length)
	{
		return length + bufOff;
	}

	public override int ProcessByte(byte input, byte[] output, int outOff)
	{
		buf[bufOff++] = input;
		if (bufOff == buf.Length)
		{
			if (outOff + buf.Length > output.Length)
			{
				throw new DataLengthException("output buffer too short");
			}
			bufOff = 0;
			return cipher.ProcessBlock(buf, 0, output, outOff);
		}
		return 0;
	}

	public override byte[] ProcessByte(byte input)
	{
		int outLength = GetUpdateOutputSize(1);
		byte[] outBytes = ((outLength > 0) ? new byte[outLength] : null);
		int pos = ProcessByte(input, outBytes, 0);
		if (outLength > 0 && pos < outLength)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override byte[] ProcessBytes(byte[] input, int inOff, int length)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (length < 1)
		{
			return null;
		}
		int outLength = GetUpdateOutputSize(length);
		byte[] outBytes = ((outLength > 0) ? new byte[outLength] : null);
		int pos = ProcessBytes(input, inOff, length, outBytes, 0);
		if (outLength > 0 && pos < outLength)
		{
			byte[] tmp = new byte[pos];
			Array.Copy(outBytes, 0, tmp, 0, pos);
			outBytes = tmp;
		}
		return outBytes;
	}

	public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		if (length < 1)
		{
			if (length < 0)
			{
				throw new ArgumentException("Can't have a negative input length!");
			}
			return 0;
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
		if (bufOff == buf.Length)
		{
			resultLen += cipher.ProcessBlock(buf, 0, output, outOff + resultLen);
			bufOff = 0;
		}
		return resultLen;
	}

	public override byte[] DoFinal()
	{
		byte[] outBytes = BufferedCipherBase.EmptyBuffer;
		int length = GetOutputSize(0);
		if (length > 0)
		{
			outBytes = new byte[length];
			int pos = DoFinal(outBytes, 0);
			if (pos < outBytes.Length)
			{
				byte[] tmp = new byte[pos];
				Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
		}
		else
		{
			Reset();
		}
		return outBytes;
	}

	public override byte[] DoFinal(byte[] input, int inOff, int inLen)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		int length = GetOutputSize(inLen);
		byte[] outBytes = BufferedCipherBase.EmptyBuffer;
		if (length > 0)
		{
			outBytes = new byte[length];
			int pos = ((inLen > 0) ? ProcessBytes(input, inOff, inLen, outBytes, 0) : 0);
			pos += DoFinal(outBytes, pos);
			if (pos < outBytes.Length)
			{
				byte[] tmp = new byte[pos];
				Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
		}
		else
		{
			Reset();
		}
		return outBytes;
	}

	public override int DoFinal(byte[] output, int outOff)
	{
		try
		{
			if (bufOff != 0)
			{
				Check.DataLength(!cipher.IsPartialBlockOkay, "data not block size aligned");
				Check.OutputLength(output, outOff, bufOff, "output buffer too short for DoFinal()");
				cipher.ProcessBlock(buf, 0, buf, 0);
				Array.Copy(buf, 0, output, outOff, bufOff);
			}
			return bufOff;
		}
		finally
		{
			Reset();
		}
	}

	public override void Reset()
	{
		Array.Clear(buf, 0, buf.Length);
		bufOff = 0;
		cipher.Reset();
	}
}
