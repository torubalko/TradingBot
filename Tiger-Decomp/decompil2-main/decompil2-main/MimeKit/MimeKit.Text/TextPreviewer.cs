using System;
using System.IO;
using System.Text;
using MimeKit.Utils;

namespace MimeKit.Text;

public abstract class TextPreviewer
{
	private int maximumPreviewLength;

	public abstract TextFormat InputFormat { get; }

	public int MaximumPreviewLength
	{
		get
		{
			return maximumPreviewLength;
		}
		set
		{
			if (value < 1 || value > 1024)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			maximumPreviewLength = value;
		}
	}

	protected TextPreviewer()
	{
		maximumPreviewLength = 230;
	}

	private static TextPreviewer Create(TextFormat format)
	{
		if (format == TextFormat.Html)
		{
			return new HtmlTextPreviewer();
		}
		return new PlainTextPreviewer();
	}

	public static string GetPreviewText(TextPart body)
	{
		if (body == null)
		{
			throw new ArgumentNullException("body");
		}
		if (body.Content == null)
		{
			return string.Empty;
		}
		Encoding encoding = body.ContentType.CharsetEncoding;
		byte[] array = new byte[16384];
		int num = 0;
		using (Stream stream = body.Content.Open())
		{
			int num2;
			while ((num2 = stream.Read(array, num, array.Length - num)) > 0)
			{
				num += num2;
				if (num >= array.Length)
				{
					break;
				}
			}
		}
		if (encoding == null && !CharsetUtils.TryGetBomEncoding(array, num, out encoding))
		{
			encoding = CharsetUtils.UTF8;
		}
		using MemoryStream memoryStream = new MemoryStream(array, 0, num, writable: false);
		TextPreviewer textPreviewer = Create(body.Format);
		try
		{
			return textPreviewer.GetPreviewText(memoryStream, encoding);
		}
		catch (DecoderFallbackException)
		{
			memoryStream.Position = 0L;
			return textPreviewer.GetPreviewText(memoryStream, CharsetUtils.Latin1);
		}
	}

	public virtual string GetPreviewText(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		using StringReader reader = new StringReader(text);
		return GetPreviewText(reader);
	}

	public virtual string GetPreviewText(Stream stream, string charset)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		Encoding encoding;
		try
		{
			encoding = CharsetUtils.GetEncoding(charset);
		}
		catch (NotSupportedException)
		{
			encoding = CharsetUtils.UTF8;
		}
		return GetPreviewText(stream, encoding);
	}

	public virtual string GetPreviewText(Stream stream, Encoding encoding)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		using StreamReader reader = new StreamReader(stream, encoding, detectEncodingFromByteOrderMarks: false, 4096, leaveOpen: true);
		return GetPreviewText(reader);
	}

	public abstract string GetPreviewText(TextReader reader);
}
