using System;

namespace Org.BouncyCastle.Utilities.Encoders;

public class BufferedEncoder
{
	internal byte[] Buffer;

	internal int bufOff;

	internal ITranslator translator;

	public BufferedEncoder(ITranslator translator, int bufferSize)
	{
		this.translator = translator;
		if (bufferSize % translator.GetEncodedBlockSize() != 0)
		{
			throw new ArgumentException("buffer size not multiple of input block size");
		}
		Buffer = new byte[bufferSize];
	}

	public int ProcessByte(byte input, byte[] outBytes, int outOff)
	{
		int resultLen = 0;
		Buffer[bufOff++] = input;
		if (bufOff == Buffer.Length)
		{
			resultLen = translator.Encode(Buffer, 0, Buffer.Length, outBytes, outOff);
			bufOff = 0;
		}
		return resultLen;
	}

	public int ProcessBytes(byte[] input, int inOff, int len, byte[] outBytes, int outOff)
	{
		if (len < 0)
		{
			throw new ArgumentException("Can't have a negative input length!");
		}
		int resultLen = 0;
		int gapLen = Buffer.Length - bufOff;
		if (len > gapLen)
		{
			Array.Copy(input, inOff, Buffer, bufOff, gapLen);
			resultLen += translator.Encode(Buffer, 0, Buffer.Length, outBytes, outOff);
			bufOff = 0;
			len -= gapLen;
			inOff += gapLen;
			outOff += resultLen;
			int chunkSize = len - len % Buffer.Length;
			resultLen += translator.Encode(input, inOff, chunkSize, outBytes, outOff);
			len -= chunkSize;
			inOff += chunkSize;
		}
		if (len != 0)
		{
			Array.Copy(input, inOff, Buffer, bufOff, len);
			bufOff += len;
		}
		return resultLen;
	}
}
