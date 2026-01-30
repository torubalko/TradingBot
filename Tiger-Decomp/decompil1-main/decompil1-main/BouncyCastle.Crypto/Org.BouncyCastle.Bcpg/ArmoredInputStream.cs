using System;
using System.Collections;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Bcpg;

public class ArmoredInputStream : BaseInputStream
{
	private static readonly byte[] decodingTable;

	private bool detectMissingChecksum;

	private Stream input;

	private bool start = true;

	private int[] outBuf = new int[3];

	private int bufPtr = 3;

	private Crc24 crc = new Crc24();

	private bool crcFound;

	private bool hasHeaders = true;

	private string header;

	private bool newLineFound;

	private bool clearText;

	private bool restart;

	private IList headerList = Platform.CreateArrayList();

	private int lastC;

	private bool isEndOfStream;

	static ArmoredInputStream()
	{
		decodingTable = new byte[128];
		Arrays.Fill(decodingTable, byte.MaxValue);
		for (int i = 65; i <= 90; i++)
		{
			decodingTable[i] = (byte)(i - 65);
		}
		for (int j = 97; j <= 122; j++)
		{
			decodingTable[j] = (byte)(j - 97 + 26);
		}
		for (int k = 48; k <= 57; k++)
		{
			decodingTable[k] = (byte)(k - 48 + 52);
		}
		decodingTable[43] = 62;
		decodingTable[47] = 63;
	}

	private static int Decode(int in0, int in1, int in2, int in3, int[] result)
	{
		if (in3 < 0)
		{
			throw new EndOfStreamException("unexpected end of file in armored stream.");
		}
		int b1;
		int b2;
		if (in2 == 61)
		{
			b1 = decodingTable[in0];
			b2 = decodingTable[in1];
			if ((b1 | b2) >= 128)
			{
				throw new IOException("invalid armor");
			}
			result[2] = ((b1 << 2) | (b2 >> 4)) & 0xFF;
			return 2;
		}
		int b3;
		if (in3 == 61)
		{
			b1 = decodingTable[in0];
			b2 = decodingTable[in1];
			b3 = decodingTable[in2];
			if ((b1 | b2 | b3) >= 128)
			{
				throw new IOException("invalid armor");
			}
			result[1] = ((b1 << 2) | (b2 >> 4)) & 0xFF;
			result[2] = ((b2 << 4) | (b3 >> 2)) & 0xFF;
			return 1;
		}
		b1 = decodingTable[in0];
		b2 = decodingTable[in1];
		b3 = decodingTable[in2];
		int b4 = decodingTable[in3];
		if ((b1 | b2 | b3 | b4) >= 128)
		{
			throw new IOException("invalid armor");
		}
		result[0] = ((b1 << 2) | (b2 >> 4)) & 0xFF;
		result[1] = ((b2 << 4) | (b3 >> 2)) & 0xFF;
		result[2] = ((b3 << 6) | b4) & 0xFF;
		return 0;
	}

	public ArmoredInputStream(Stream input)
		: this(input, hasHeaders: true)
	{
	}

	public ArmoredInputStream(Stream input, bool hasHeaders)
	{
		this.input = input;
		this.hasHeaders = hasHeaders;
		if (hasHeaders)
		{
			ParseHeaders();
		}
		start = false;
	}

	private bool ParseHeaders()
	{
		header = null;
		int last = 0;
		bool headerFound = false;
		headerList = Platform.CreateArrayList();
		if (restart)
		{
			headerFound = true;
		}
		else
		{
			int c;
			while ((c = input.ReadByte()) >= 0)
			{
				if (c == 45 && (last == 0 || last == 10 || last == 13))
				{
					headerFound = true;
					break;
				}
				last = c;
			}
		}
		if (headerFound)
		{
			StringBuilder buf = new StringBuilder("-");
			bool eolReached = false;
			bool crLf = false;
			if (restart)
			{
				buf.Append('-');
			}
			int c;
			while ((c = input.ReadByte()) >= 0)
			{
				if (last == 13 && c == 10)
				{
					crLf = true;
				}
				if ((eolReached && last != 13 && c == 10) || (eolReached && c == 13))
				{
					break;
				}
				if (c == 13 || (last != 13 && c == 10))
				{
					string line = buf.ToString();
					if (line.Trim().Length < 1)
					{
						break;
					}
					if (headerList.Count > 0 && line.IndexOf(':') < 0)
					{
						throw new IOException("invalid armor header");
					}
					headerList.Add(line);
					buf.Length = 0;
				}
				if (c != 10 && c != 13)
				{
					buf.Append((char)c);
					eolReached = false;
				}
				else if (c == 13 || (last != 13 && c == 10))
				{
					eolReached = true;
				}
				last = c;
			}
			if (crLf)
			{
				input.ReadByte();
			}
		}
		if (headerList.Count > 0)
		{
			header = (string)headerList[0];
		}
		clearText = "-----BEGIN PGP SIGNED MESSAGE-----".Equals(header);
		newLineFound = true;
		return headerFound;
	}

	public bool IsClearText()
	{
		return clearText;
	}

	public bool IsEndOfStream()
	{
		return isEndOfStream;
	}

	public string GetArmorHeaderLine()
	{
		return header;
	}

	public string[] GetArmorHeaders()
	{
		if (headerList.Count <= 1)
		{
			return null;
		}
		string[] hdrs = new string[headerList.Count - 1];
		for (int i = 0; i != hdrs.Length; i++)
		{
			hdrs[i] = (string)headerList[i + 1];
		}
		return hdrs;
	}

	private int ReadIgnoreSpace()
	{
		int c;
		do
		{
			c = input.ReadByte();
		}
		while (c == 32 || c == 9 || c == 12 || c == 11);
		if (c >= 128)
		{
			throw new IOException("invalid armor");
		}
		return c;
	}

	public override int ReadByte()
	{
		if (start)
		{
			if (hasHeaders)
			{
				ParseHeaders();
			}
			crc.Reset();
			start = false;
		}
		int c;
		if (clearText)
		{
			c = input.ReadByte();
			if (c == 13 || (c == 10 && lastC != 13))
			{
				newLineFound = true;
			}
			else if (newLineFound && c == 45)
			{
				c = input.ReadByte();
				if (c == 45)
				{
					clearText = false;
					start = true;
					restart = true;
				}
				else
				{
					c = input.ReadByte();
				}
				newLineFound = false;
			}
			else if (c != 10 && lastC != 13)
			{
				newLineFound = false;
			}
			lastC = c;
			if (c < 0)
			{
				isEndOfStream = true;
			}
			return c;
		}
		if (bufPtr > 2 || crcFound)
		{
			c = ReadIgnoreSpace();
			if (c == 13 || c == 10)
			{
				c = ReadIgnoreSpace();
				while (c == 10 || c == 13)
				{
					c = ReadIgnoreSpace();
				}
				if (c < 0)
				{
					isEndOfStream = true;
					return -1;
				}
				if (c == 61)
				{
					bufPtr = Decode(ReadIgnoreSpace(), ReadIgnoreSpace(), ReadIgnoreSpace(), ReadIgnoreSpace(), outBuf);
					if (bufPtr == 0)
					{
						int num = ((outBuf[0] & 0xFF) << 16) | ((outBuf[1] & 0xFF) << 8) | (outBuf[2] & 0xFF);
						crcFound = true;
						if (num != crc.Value)
						{
							throw new IOException("crc check failed in armored message.");
						}
						return ReadByte();
					}
					if (detectMissingChecksum)
					{
						throw new IOException("no crc found in armored message");
					}
				}
				else
				{
					if (c == 45)
					{
						while ((c = input.ReadByte()) >= 0 && c != 10 && c != 13)
						{
						}
						if (!crcFound && detectMissingChecksum)
						{
							throw new IOException("crc check not found");
						}
						crcFound = false;
						start = true;
						bufPtr = 3;
						if (c < 0)
						{
							isEndOfStream = true;
						}
						return -1;
					}
					bufPtr = Decode(c, ReadIgnoreSpace(), ReadIgnoreSpace(), ReadIgnoreSpace(), outBuf);
				}
			}
			else
			{
				if (c < 0)
				{
					isEndOfStream = true;
					return -1;
				}
				bufPtr = Decode(c, ReadIgnoreSpace(), ReadIgnoreSpace(), ReadIgnoreSpace(), outBuf);
			}
		}
		c = outBuf[bufPtr++];
		crc.Update(c);
		return c;
	}

	public override int Read(byte[] b, int off, int len)
	{
		CheckIndexSize(b.Length, off, len);
		int pos = 0;
		while (pos < len)
		{
			int c = ReadByte();
			if (c < 0)
			{
				break;
			}
			b[off + pos++] = (byte)c;
		}
		return pos;
	}

	private void CheckIndexSize(int size, int off, int len)
	{
		if (off < 0 || len < 0)
		{
			throw new IndexOutOfRangeException("Offset and length cannot be negative.");
		}
		if (off > size - len)
		{
			throw new IndexOutOfRangeException("Invalid offset and length.");
		}
	}

	public override void Close()
	{
		Platform.Dispose(input);
		base.Close();
	}

	public virtual void SetDetectMissingCrc(bool detectMissing)
	{
		detectMissingChecksum = detectMissing;
	}
}
