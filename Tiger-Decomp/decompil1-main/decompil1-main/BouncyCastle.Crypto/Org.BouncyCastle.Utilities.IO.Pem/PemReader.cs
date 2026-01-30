using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Utilities.IO.Pem;

public class PemReader
{
	private readonly TextReader reader;

	private readonly MemoryStream buffer;

	private readonly StreamWriter textBuffer;

	private readonly IList pushback = Platform.CreateArrayList();

	private int c;

	public TextReader Reader => reader;

	public PemReader(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		buffer = new MemoryStream();
		textBuffer = new StreamWriter(buffer);
		this.reader = reader;
	}

	public PemObject ReadPemObject()
	{
		do
		{
			if (!seekDash())
			{
				return null;
			}
			if (!consumeDash())
			{
				throw new IOException("no data after consuming leading dashes");
			}
			skipWhiteSpace();
		}
		while (!expect("BEGIN"));
		skipWhiteSpace();
		if (!bufferUntilStopChar('-', skipWhiteSpace: false))
		{
			throw new IOException("ran out of data before consuming type");
		}
		string type = bufferedString().Trim();
		if (!consumeDash())
		{
			throw new IOException("ran out of data consuming header");
		}
		skipWhiteSpace();
		IList headers = Platform.CreateArrayList();
		while (seekColon(64))
		{
			if (!bufferUntilStopChar(':', skipWhiteSpace: false))
			{
				throw new IOException("ran out of data reading header key value");
			}
			string key = bufferedString().Trim();
			c = Read();
			if (c != 58)
			{
				throw new IOException("expected colon");
			}
			if (!bufferUntilStopChar('\n', skipWhiteSpace: false))
			{
				throw new IOException("ran out of data before consuming header value");
			}
			skipWhiteSpace();
			string value = bufferedString().Trim();
			headers.Add(new PemHeader(key, value));
		}
		skipWhiteSpace();
		if (!bufferUntilStopChar('-', skipWhiteSpace: true))
		{
			throw new IOException("ran out of data before consuming payload");
		}
		string payload = bufferedString();
		if (!seekDash())
		{
			throw new IOException("did not find leading '-'");
		}
		if (!consumeDash())
		{
			throw new IOException("no data after consuming trailing dashes");
		}
		if (!expect("END " + type))
		{
			throw new IOException("END " + type + " was not found.");
		}
		if (!seekDash())
		{
			throw new IOException("did not find ending '-'");
		}
		consumeDash();
		return new PemObject(type, headers, Base64.Decode(payload));
	}

	private string bufferedString()
	{
		textBuffer.Flush();
		string result = Strings.FromUtf8ByteArray(buffer.ToArray());
		buffer.Position = 0L;
		buffer.SetLength(0L);
		return result;
	}

	private bool seekDash()
	{
		c = 0;
		while ((c = Read()) >= 0 && c != 45)
		{
		}
		PushBack(c);
		return c == 45;
	}

	private bool seekColon(int upTo)
	{
		c = 0;
		bool colonFound = false;
		IList read = Platform.CreateArrayList();
		while (upTo >= 0 && c >= 0)
		{
			c = Read();
			read.Add(c);
			if (c == 58)
			{
				colonFound = true;
				break;
			}
			upTo--;
		}
		while (read.Count > 0)
		{
			PushBack((int)read[read.Count - 1]);
			read.RemoveAt(read.Count - 1);
		}
		return colonFound;
	}

	private bool consumeDash()
	{
		c = 0;
		while ((c = Read()) >= 0 && c == 45)
		{
		}
		PushBack(c);
		return c != -1;
	}

	private void skipWhiteSpace()
	{
		while ((c = Read()) >= 0 && c <= 32)
		{
		}
		PushBack(c);
	}

	private bool expect(string value)
	{
		for (int t = 0; t < value.Length; t++)
		{
			c = Read();
			if (c != value[t])
			{
				return false;
			}
		}
		return true;
	}

	private bool bufferUntilStopChar(char stopChar, bool skipWhiteSpace)
	{
		while ((c = Read()) >= 0)
		{
			if (!skipWhiteSpace || c > 32)
			{
				if (c == stopChar)
				{
					PushBack(c);
					break;
				}
				textBuffer.Write((char)c);
				textBuffer.Flush();
			}
		}
		return c > -1;
	}

	private void PushBack(int value)
	{
		if (pushback.Count == 0)
		{
			pushback.Add(value);
		}
		else
		{
			pushback.Insert(0, value);
		}
	}

	private int Read()
	{
		if (pushback.Count > 0)
		{
			int result = (int)pushback[0];
			pushback.RemoveAt(0);
			return result;
		}
		return reader.Read();
	}
}
