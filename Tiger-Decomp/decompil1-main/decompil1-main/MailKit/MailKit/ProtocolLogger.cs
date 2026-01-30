using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace MailKit;

public class ProtocolLogger : IProtocolLogger, IDisposable
{
	private static byte[] defaultClientPrefix = Encoding.ASCII.GetBytes("C: ");

	private static byte[] defaultServerPrefix = Encoding.ASCII.GetBytes("S: ");

	private static readonly byte[] Secret = Encoding.ASCII.GetBytes("********");

	private static readonly byte[] Space = new byte[1] { 32 };

	private const string DefaultTimestampFormat = "yyyy-MM-ddTHH:mm:ssZ";

	private byte[] clientPrefix = defaultClientPrefix;

	private byte[] serverPrefix = defaultServerPrefix;

	private readonly Stream stream;

	private readonly bool leaveOpen;

	private bool clientMidline;

	private bool serverMidline;

	public Stream Stream => stream;

	public static string DefaultClientPrefix
	{
		get
		{
			return Encoding.UTF8.GetString(defaultClientPrefix);
		}
		set
		{
			defaultClientPrefix = Encoding.UTF8.GetBytes(value);
		}
	}

	public static string DefaultServerPrefix
	{
		get
		{
			return Encoding.UTF8.GetString(defaultServerPrefix);
		}
		set
		{
			defaultServerPrefix = Encoding.UTF8.GetBytes(value);
		}
	}

	public string ClientPrefix
	{
		get
		{
			return Encoding.UTF8.GetString(clientPrefix);
		}
		set
		{
			clientPrefix = Encoding.UTF8.GetBytes(value);
		}
	}

	public string ServerPrefix
	{
		get
		{
			return Encoding.UTF8.GetString(serverPrefix);
		}
		set
		{
			serverPrefix = Encoding.UTF8.GetBytes(value);
		}
	}

	public bool RedactSecrets { get; set; }

	public bool LogTimestamps { get; set; }

	public string TimestampFormat { get; set; }

	public IAuthenticationSecretDetector AuthenticationSecretDetector { get; set; }

	private ProtocolLogger()
	{
		TimestampFormat = "yyyy-MM-ddTHH:mm:ssZ";
	}

	public ProtocolLogger(string fileName, bool append = true)
		: this()
	{
		stream = File.Open(fileName, append ? FileMode.Append : FileMode.Create, FileAccess.Write, FileShare.Read);
	}

	public ProtocolLogger(Stream stream, bool leaveOpen = false)
		: this()
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		this.leaveOpen = leaveOpen;
		this.stream = stream;
	}

	~ProtocolLogger()
	{
		Dispose(disposing: false);
	}

	private static void ValidateArguments(byte[] buffer, int offset, int count)
	{
		if (buffer == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (offset < 0 || offset > buffer.Length)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0 || count > buffer.Length - offset)
		{
			throw new ArgumentOutOfRangeException("count");
		}
	}

	private void Log(byte[] prefix, ref bool midline, byte[] buffer, int offset, int count, bool isClient)
	{
		int num = offset + count;
		int i = offset;
		while (i < num)
		{
			int num2 = i;
			for (; i < num && buffer[i] != 10; i++)
			{
			}
			if (!midline)
			{
				if (LogTimestamps)
				{
					byte[] bytes = Encoding.ASCII.GetBytes(DateTime.UtcNow.ToString(TimestampFormat, CultureInfo.InvariantCulture));
					stream.Write(bytes, 0, bytes.Length);
					stream.Write(Space, 0, Space.Length);
				}
				stream.Write(prefix, 0, prefix.Length);
			}
			if (i < num && buffer[i] == 10)
			{
				midline = false;
				i++;
			}
			else
			{
				midline = true;
			}
			if (isClient && RedactSecrets)
			{
				IList<AuthenticationSecret> list = AuthenticationSecretDetector.DetectSecrets(buffer, num2, i - num2);
				foreach (AuthenticationSecret item in list)
				{
					if (item.StartIndex > num2)
					{
						stream.Write(buffer, num2, item.StartIndex - num2);
					}
					num2 = item.StartIndex + item.Length;
					stream.Write(Secret, 0, Secret.Length);
				}
			}
			stream.Write(buffer, num2, i - num2);
		}
		stream.Flush();
	}

	public void LogConnect(Uri uri)
	{
		if (uri == null)
		{
			throw new ArgumentNullException("uri");
		}
		string s = ((!LogTimestamps) ? $"Connected to {uri}\r\n" : $"{DateTime.UtcNow.ToString(TimestampFormat, CultureInfo.InvariantCulture)} Connected to {uri}\r\n");
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		if (clientMidline || serverMidline)
		{
			stream.WriteByte(13);
			stream.WriteByte(10);
			clientMidline = false;
			serverMidline = false;
		}
		stream.Write(bytes, 0, bytes.Length);
		stream.Flush();
	}

	public void LogClient(byte[] buffer, int offset, int count)
	{
		ValidateArguments(buffer, offset, count);
		Log(clientPrefix, ref clientMidline, buffer, offset, count, isClient: true);
	}

	public void LogServer(byte[] buffer, int offset, int count)
	{
		ValidateArguments(buffer, offset, count);
		Log(serverPrefix, ref serverMidline, buffer, offset, count, isClient: false);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing && !leaveOpen)
		{
			stream.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
