using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders;

public class HexEncoder : IEncoder
{
	protected readonly byte[] encodingTable = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 56, 57,
		97, 98, 99, 100, 101, 102
	};

	protected readonly byte[] decodingTable = new byte[128];

	protected void InitialiseDecodingTable()
	{
		Arrays.Fill(decodingTable, byte.MaxValue);
		for (int i = 0; i < encodingTable.Length; i++)
		{
			decodingTable[encodingTable[i]] = (byte)i;
		}
		decodingTable[65] = decodingTable[97];
		decodingTable[66] = decodingTable[98];
		decodingTable[67] = decodingTable[99];
		decodingTable[68] = decodingTable[100];
		decodingTable[69] = decodingTable[101];
		decodingTable[70] = decodingTable[102];
	}

	public HexEncoder()
	{
		InitialiseDecodingTable();
	}

	public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
	{
		int inPos = inOff;
		int inEnd = inOff + inLen;
		int outPos = outOff;
		while (inPos < inEnd)
		{
			uint b = inBuf[inPos++];
			outBuf[outPos++] = encodingTable[b >> 4];
			outBuf[outPos++] = encodingTable[b & 0xF];
		}
		return outPos - outOff;
	}

	public int Encode(byte[] buf, int off, int len, Stream outStream)
	{
		if (len < 0)
		{
			return 0;
		}
		byte[] tmp = new byte[72];
		int remaining = len;
		while (remaining > 0)
		{
			int inLen = System.Math.Min(36, remaining);
			int outLen = Encode(buf, off, inLen, tmp, 0);
			outStream.Write(tmp, 0, outLen);
			off += inLen;
			remaining -= inLen;
		}
		return len * 2;
	}

	private static bool Ignore(char c)
	{
		if (c != '\n' && c != '\r' && c != '\t')
		{
			return c == ' ';
		}
		return true;
	}

	public int Decode(byte[] data, int off, int length, Stream outStream)
	{
		int outLen = 0;
		byte[] buf = new byte[36];
		int bufOff = 0;
		int end = off + length;
		while (end > off && Ignore((char)data[end - 1]))
		{
			end--;
		}
		int i = off;
		while (i < end)
		{
			for (; i < end && Ignore((char)data[i]); i++)
			{
			}
			byte b1 = decodingTable[data[i++]];
			for (; i < end && Ignore((char)data[i]); i++)
			{
			}
			byte b2 = decodingTable[data[i++]];
			if ((b1 | b2) >= 128)
			{
				throw new IOException("invalid characters encountered in Hex data");
			}
			buf[bufOff++] = (byte)((b1 << 4) | b2);
			if (bufOff == buf.Length)
			{
				outStream.Write(buf, 0, bufOff);
				bufOff = 0;
			}
			outLen++;
		}
		if (bufOff > 0)
		{
			outStream.Write(buf, 0, bufOff);
		}
		return outLen;
	}

	public int DecodeString(string data, Stream outStream)
	{
		int length = 0;
		byte[] buf = new byte[36];
		int bufOff = 0;
		int end = data.Length;
		while (end > 0 && Ignore(data[end - 1]))
		{
			end--;
		}
		int i = 0;
		while (i < end)
		{
			for (; i < end && Ignore(data[i]); i++)
			{
			}
			byte b1 = decodingTable[(uint)data[i++]];
			for (; i < end && Ignore(data[i]); i++)
			{
			}
			byte b2 = decodingTable[(uint)data[i++]];
			if ((b1 | b2) >= 128)
			{
				throw new IOException("invalid characters encountered in Hex data");
			}
			buf[bufOff++] = (byte)((b1 << 4) | b2);
			if (bufOff == buf.Length)
			{
				outStream.Write(buf, 0, bufOff);
				bufOff = 0;
			}
			length++;
		}
		if (bufOff > 0)
		{
			outStream.Write(buf, 0, bufOff);
		}
		return length;
	}

	internal byte[] DecodeStrict(string str, int off, int len)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (off < 0 || len < 0 || off > str.Length - len)
		{
			throw new IndexOutOfRangeException("invalid offset and/or length specified");
		}
		if ((len & 1) != 0)
		{
			throw new ArgumentException("a hexadecimal encoding must have an even number of characters", "len");
		}
		int resultLen = len >> 1;
		byte[] result = new byte[resultLen];
		int strPos = off;
		for (int i = 0; i < resultLen; i++)
		{
			byte b1 = decodingTable[(uint)str[strPos++]];
			byte b2 = decodingTable[(uint)str[strPos++]];
			if ((b1 | b2) >= 128)
			{
				throw new IOException("invalid characters encountered in Hex data");
			}
			result[i] = (byte)((b1 << 4) | b2);
		}
		return result;
	}
}
