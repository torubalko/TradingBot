using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public abstract class TextConverter
{
	internal static readonly List<UrlPattern> UrlPatterns;

	private Encoding outputEncoding = Encoding.UTF8;

	private Encoding inputEncoding = Encoding.UTF8;

	private int outputStreamBufferSize = 4096;

	private int inputStreamBufferSize = 4096;

	public bool DetectEncodingFromByteOrderMark { get; set; }

	public Encoding InputEncoding
	{
		get
		{
			return inputEncoding;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			inputEncoding = value;
		}
	}

	public abstract TextFormat InputFormat { get; }

	public Encoding OutputEncoding
	{
		get
		{
			return outputEncoding;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			outputEncoding = value;
		}
	}

	public abstract TextFormat OutputFormat { get; }

	public int InputStreamBufferSize
	{
		get
		{
			return inputStreamBufferSize;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			inputStreamBufferSize = value;
		}
	}

	public int OutputStreamBufferSize
	{
		get
		{
			return outputStreamBufferSize;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			outputStreamBufferSize = value;
		}
	}

	public string Footer { get; set; }

	public string Header { get; set; }

	static TextConverter()
	{
		UrlPatterns = new List<UrlPattern>(new UrlPattern[16]
		{
			new UrlPattern(UrlPatternType.Addrspec, "@", "mailto:"),
			new UrlPattern(UrlPatternType.MailTo, "mailto:", ""),
			new UrlPattern(UrlPatternType.Web, "www.", "http://"),
			new UrlPattern(UrlPatternType.Web, "ftp.", "ftp://"),
			new UrlPattern(UrlPatternType.File, "file://", ""),
			new UrlPattern(UrlPatternType.Web, "ftp://", ""),
			new UrlPattern(UrlPatternType.Web, "sftp://", ""),
			new UrlPattern(UrlPatternType.Web, "http://", ""),
			new UrlPattern(UrlPatternType.Web, "https://", ""),
			new UrlPattern(UrlPatternType.Web, "news://", ""),
			new UrlPattern(UrlPatternType.Web, "nntp://", ""),
			new UrlPattern(UrlPatternType.Web, "telnet://", ""),
			new UrlPattern(UrlPatternType.Web, "webcal://", ""),
			new UrlPattern(UrlPatternType.Web, "callto:", ""),
			new UrlPattern(UrlPatternType.Web, "h323:", ""),
			new UrlPattern(UrlPatternType.Web, "sip:", "")
		});
	}

	private TextReader CreateReader(Stream stream)
	{
		return new StreamReader(stream, InputEncoding, DetectEncodingFromByteOrderMark, InputStreamBufferSize, leaveOpen: true);
	}

	private TextWriter CreateWriter(Stream stream)
	{
		return new StreamWriter(stream, OutputEncoding, OutputStreamBufferSize, leaveOpen: true);
	}

	public virtual void Convert(Stream source, Stream destination)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		using TextWriter textWriter = CreateWriter(destination);
		using (TextReader reader = CreateReader(source))
		{
			Convert(reader, textWriter);
		}
		textWriter.Flush();
	}

	public virtual void Convert(Stream source, TextWriter writer)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		using TextReader reader = CreateReader(source);
		Convert(reader, writer);
	}

	public virtual void Convert(TextReader reader, Stream destination)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		if (destination == null)
		{
			throw new ArgumentNullException("destination");
		}
		using TextWriter textWriter = CreateWriter(destination);
		Convert(reader, textWriter);
		textWriter.Flush();
	}

	public abstract void Convert(TextReader reader, TextWriter writer);

	public virtual string Convert(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		using StringReader reader = new StringReader(text);
		StringBuilder stringBuilder = new StringBuilder();
		using (StringWriter writer = new StringWriter(stringBuilder))
		{
			Convert(reader, writer);
		}
		return stringBuilder.ToString();
	}
}
