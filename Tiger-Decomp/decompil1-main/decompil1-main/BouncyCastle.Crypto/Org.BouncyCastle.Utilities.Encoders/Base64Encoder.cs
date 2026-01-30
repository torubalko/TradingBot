using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Encoders;

public class Base64Encoder : IEncoder
{
	protected readonly byte[] encodingTable = new byte[64]
	{
		65, 66, 67, 68, 69, 70, 71, 72, 73, 74,
		75, 76, 77, 78, 79, 80, 81, 82, 83, 84,
		85, 86, 87, 88, 89, 90, 97, 98, 99, 100,
		101, 102, 103, 104, 105, 106, 107, 108, 109, 110,
		111, 112, 113, 114, 115, 116, 117, 118, 119, 120,
		121, 122, 48, 49, 50, 51, 52, 53, 54, 55,
		56, 57, 43, 47
	};

	protected byte padding = 61;

	protected readonly byte[] decodingTable = new byte[128];

	protected void InitialiseDecodingTable()
	{
		Arrays.Fill(decodingTable, byte.MaxValue);
		for (int i = 0; i < encodingTable.Length; i++)
		{
			decodingTable[encodingTable[i]] = (byte)i;
		}
	}

	public Base64Encoder()
	{
		InitialiseDecodingTable();
	}

	public int Encode(byte[] inBuf, int inOff, int inLen, byte[] outBuf, int outOff)
	{
		int inPos = inOff;
		int inEnd = inOff + inLen - 2;
		int outPos = outOff;
		while (inPos < inEnd)
		{
			uint a1 = inBuf[inPos++];
			uint a2 = inBuf[inPos++];
			uint a3 = inBuf[inPos++];
			outBuf[outPos++] = encodingTable[(a1 >> 2) & 0x3F];
			outBuf[outPos++] = encodingTable[((a1 << 4) | (a2 >> 4)) & 0x3F];
			outBuf[outPos++] = encodingTable[((a2 << 2) | (a3 >> 6)) & 0x3F];
			outBuf[outPos++] = encodingTable[a3 & 0x3F];
		}
		switch (inLen - (inPos - inOff))
		{
		case 1:
		{
			uint a6 = inBuf[inPos++];
			outBuf[outPos++] = encodingTable[(a6 >> 2) & 0x3F];
			outBuf[outPos++] = encodingTable[(a6 << 4) & 0x3F];
			outBuf[outPos++] = padding;
			outBuf[outPos++] = padding;
			break;
		}
		case 2:
		{
			uint a4 = inBuf[inPos++];
			uint a5 = inBuf[inPos++];
			outBuf[outPos++] = encodingTable[(a4 >> 2) & 0x3F];
			outBuf[outPos++] = encodingTable[((a4 << 4) | (a5 >> 4)) & 0x3F];
			outBuf[outPos++] = encodingTable[(a5 << 2) & 0x3F];
			outBuf[outPos++] = padding;
			break;
		}
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
			int inLen = System.Math.Min(54, remaining);
			int outLen = Encode(buf, off, inLen, tmp, 0);
			outStream.Write(tmp, 0, outLen);
			off += inLen;
			remaining -= inLen;
		}
		return (len + 2) / 3 * 4;
	}

	private bool Ignore(char c)
	{
		if (c != '\n' && c != '\r' && c != '\t')
		{
			return c == ' ';
		}
		return true;
	}

	public int Decode(byte[] data, int off, int length, Stream outStream)
	{
		byte[] outBuffer = new byte[54];
		int bufOff = 0;
		int outLen = 0;
		int end = off + length;
		while (end > off && Ignore((char)data[end - 1]))
		{
			end--;
		}
		int i = off;
		int finish = end - 4;
		for (i = NextI(data, i, finish); i < finish; i = NextI(data, i, finish))
		{
			byte b1 = decodingTable[data[i++]];
			i = NextI(data, i, finish);
			byte b2 = decodingTable[data[i++]];
			i = NextI(data, i, finish);
			byte b3 = decodingTable[data[i++]];
			i = NextI(data, i, finish);
			byte b4 = decodingTable[data[i++]];
			if ((b1 | b2 | b3 | b4) >= 128)
			{
				throw new IOException("invalid characters encountered in base64 data");
			}
			outBuffer[bufOff++] = (byte)((b1 << 2) | (b2 >> 4));
			outBuffer[bufOff++] = (byte)((b2 << 4) | (b3 >> 2));
			outBuffer[bufOff++] = (byte)((b3 << 6) | b4);
			if (bufOff == outBuffer.Length)
			{
				outStream.Write(outBuffer, 0, bufOff);
				bufOff = 0;
			}
			outLen += 3;
		}
		if (bufOff > 0)
		{
			outStream.Write(outBuffer, 0, bufOff);
		}
		int e0 = NextI(data, i, end);
		int e1 = NextI(data, e0 + 1, end);
		int e2 = NextI(data, e1 + 1, end);
		int e3 = NextI(data, e2 + 1, end);
		return outLen + DecodeLastBlock(outStream, (char)data[e0], (char)data[e1], (char)data[e2], (char)data[e3]);
	}

	private int NextI(byte[] data, int i, int finish)
	{
		while (i < finish && Ignore((char)data[i]))
		{
			i++;
		}
		return i;
	}

	public int DecodeString(string data, Stream outStream)
	{
		int length = 0;
		int end = data.Length;
		while (end > 0 && Ignore(data[end - 1]))
		{
			end--;
		}
		int i = 0;
		int finish = end - 4;
		for (i = NextI(data, i, finish); i < finish; i = NextI(data, i, finish))
		{
			byte b1 = decodingTable[(uint)data[i++]];
			i = NextI(data, i, finish);
			byte b2 = decodingTable[(uint)data[i++]];
			i = NextI(data, i, finish);
			byte b3 = decodingTable[(uint)data[i++]];
			i = NextI(data, i, finish);
			byte b4 = decodingTable[(uint)data[i++]];
			if ((b1 | b2 | b3 | b4) >= 128)
			{
				throw new IOException("invalid characters encountered in base64 data");
			}
			outStream.WriteByte((byte)((b1 << 2) | (b2 >> 4)));
			outStream.WriteByte((byte)((b2 << 4) | (b3 >> 2)));
			outStream.WriteByte((byte)((b3 << 6) | b4));
			length += 3;
		}
		return length + DecodeLastBlock(outStream, data[end - 4], data[end - 3], data[end - 2], data[end - 1]);
	}

	private int DecodeLastBlock(Stream outStream, char c1, char c2, char c3, char c4)
	{
		if (c3 == padding)
		{
			if (c4 != padding)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			byte b1 = decodingTable[(uint)c1];
			byte b2 = decodingTable[(uint)c2];
			if ((b1 | b2) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			outStream.WriteByte((byte)((b1 << 2) | (b2 >> 4)));
			return 1;
		}
		if (c4 == padding)
		{
			byte b3 = decodingTable[(uint)c1];
			byte b4 = decodingTable[(uint)c2];
			byte b5 = decodingTable[(uint)c3];
			if ((b3 | b4 | b5) >= 128)
			{
				throw new IOException("invalid characters encountered at end of base64 data");
			}
			outStream.WriteByte((byte)((b3 << 2) | (b4 >> 4)));
			outStream.WriteByte((byte)((b4 << 4) | (b5 >> 2)));
			return 2;
		}
		byte b6 = decodingTable[(uint)c1];
		byte b7 = decodingTable[(uint)c2];
		byte b8 = decodingTable[(uint)c3];
		byte b9 = decodingTable[(uint)c4];
		if ((b6 | b7 | b8 | b9) >= 128)
		{
			throw new IOException("invalid characters encountered at end of base64 data");
		}
		outStream.WriteByte((byte)((b6 << 2) | (b7 >> 4)));
		outStream.WriteByte((byte)((b7 << 4) | (b8 >> 2)));
		outStream.WriteByte((byte)((b8 << 6) | b9));
		return 3;
	}

	private int NextI(string data, int i, int finish)
	{
		while (i < finish && Ignore(data[i]))
		{
			i++;
		}
		return i;
	}
}
