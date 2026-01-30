using System;

namespace Org.BouncyCastle.Utilities.Encoders;

public class BufferedDecoder
{
	internal byte[] buffer;

	internal int bufOff;

	internal ITranslator translator;

	public BufferedDecoder(ITranslator translator, int bufferSize)
	{
		this.translator = translator;
		if (bufferSize % translator.GetEncodedBlockSize() != 0)
		{
			throw new ArgumentException("buffer size not multiple of input block size");
		}
		buffer = new byte[bufferSize];
	}

	public int ProcessByte(byte input, byte[] output, int outOff)
	{
		int resultLen = 0;
		buffer[bufOff++] = input;
		if (bufOff == buffer.Length)
		{
			resultLen = translator.Decode(buffer, 0, buffer.Length, output, outOff);
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
		int gapLen = buffer.Length - bufOff;
		if (len > gapLen)
		{
			Array.Copy(input, inOff, buffer, bufOff, gapLen);
			resultLen += translator.Decode(buffer, 0, buffer.Length, outBytes, outOff);
			bufOff = 0;
			len -= gapLen;
			inOff += gapLen;
			outOff += resultLen;
			int chunkSize = len - len % buffer.Length;
			resultLen += translator.Decode(input, inOff, chunkSize, outBytes, outOff);
			len -= chunkSize;
			inOff += chunkSize;
		}
		if (len != 0)
		{
			Array.Copy(input, inOff, buffer, bufOff, len);
			bufOff += len;
		}
		return resultLen;
	}
}
