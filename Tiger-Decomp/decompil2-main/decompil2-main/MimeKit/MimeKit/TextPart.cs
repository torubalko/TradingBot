using System;
using System.IO;
using System.Text;
using MimeKit.IO;
using MimeKit.IO.Filters;
using MimeKit.Text;
using MimeKit.Utils;

namespace MimeKit;

public class TextPart : MimePart
{
	public TextFormat Format
	{
		get
		{
			if (base.ContentType.MediaType.Equals("text", StringComparison.OrdinalIgnoreCase))
			{
				if (base.ContentType.MediaSubtype.Equals("plain"))
				{
					if (base.ContentType.Parameters.TryGetValue("format", out string value))
					{
						value = value.Trim();
						if (value.Equals("flowed", StringComparison.OrdinalIgnoreCase))
						{
							return TextFormat.Flowed;
						}
					}
				}
				else
				{
					if (base.ContentType.MediaSubtype.Equals("html", StringComparison.OrdinalIgnoreCase))
					{
						return TextFormat.Html;
					}
					if (base.ContentType.MediaSubtype.Equals("rtf", StringComparison.OrdinalIgnoreCase))
					{
						return TextFormat.RichText;
					}
					if (base.ContentType.MediaSubtype.Equals("enriched", StringComparison.OrdinalIgnoreCase))
					{
						return TextFormat.Enriched;
					}
					if (base.ContentType.MediaSubtype.Equals("richtext", StringComparison.OrdinalIgnoreCase))
					{
						return TextFormat.Enriched;
					}
				}
			}
			else if (base.ContentType.IsMimeType("application", "rtf"))
			{
				return TextFormat.RichText;
			}
			return TextFormat.Plain;
		}
	}

	public bool IsEnriched
	{
		get
		{
			if (!base.ContentType.IsMimeType("text", "enriched"))
			{
				return base.ContentType.IsMimeType("text", "richtext");
			}
			return true;
		}
	}

	public bool IsFlowed
	{
		get
		{
			if (!IsPlain || !base.ContentType.Parameters.TryGetValue("format", out string value))
			{
				return false;
			}
			value = value.Trim();
			return value.Equals("flowed", StringComparison.OrdinalIgnoreCase);
		}
	}

	public bool IsHtml => base.ContentType.IsMimeType("text", "html");

	public bool IsPlain => base.ContentType.IsMimeType("text", "plain");

	public bool IsRichText
	{
		get
		{
			if (!base.ContentType.IsMimeType("text", "rtf"))
			{
				return base.ContentType.IsMimeType("application", "rtf");
			}
			return true;
		}
	}

	public string Text
	{
		get
		{
			Encoding encoding;
			return GetText(out encoding);
		}
		set
		{
			SetText(Encoding.UTF8, value);
		}
	}

	public TextPart(MimeEntityConstructorArgs args)
		: base(args)
	{
	}

	public TextPart(string subtype, params object[] args)
		: this(subtype)
	{
		if (args == null)
		{
			throw new ArgumentNullException("args");
		}
		Encoding encoding = null;
		string text = null;
		foreach (object obj in args)
		{
			if (obj == null || TryInit(obj))
			{
				continue;
			}
			if (obj is Encoding encoding2)
			{
				if (encoding != null)
				{
					throw new ArgumentException("An encoding should not be specified more than once.");
				}
				encoding = encoding2;
				continue;
			}
			if (obj is string text2)
			{
				if (text != null)
				{
					throw new ArgumentException("The text should not be specified more than once.");
				}
				text = text2;
				continue;
			}
			throw new ArgumentException("Unknown initialization parameter: " + obj.GetType());
		}
		if (text != null)
		{
			encoding = encoding ?? Encoding.UTF8;
			SetText(encoding, text);
		}
	}

	internal TextPart(ContentType contentType)
		: base(contentType)
	{
	}

	public TextPart(string subtype)
		: base("text", subtype)
	{
	}

	private static string GetMediaSubtype(TextFormat format)
	{
		switch (format)
		{
		case TextFormat.CompressedRichText:
		case TextFormat.RichText:
			return "rtf";
		case TextFormat.Enriched:
			return "enriched";
		case TextFormat.Plain:
		case TextFormat.Flowed:
			return "plain";
		case TextFormat.Html:
			return "html";
		default:
			throw new ArgumentOutOfRangeException("format");
		}
	}

	public TextPart(TextFormat format)
		: base("text", GetMediaSubtype(format))
	{
		if (format == TextFormat.Flowed)
		{
			base.ContentType.Format = "flowed";
		}
	}

	public TextPart()
		: base("text", "plain")
	{
	}

	public override void Accept(MimeVisitor visitor)
	{
		if (visitor == null)
		{
			throw new ArgumentNullException("visitor");
		}
		visitor.VisitTextPart(this);
	}

	internal bool IsFormat(TextFormat format)
	{
		return format switch
		{
			TextFormat.Plain => IsPlain, 
			TextFormat.Flowed => IsFlowed, 
			TextFormat.Html => IsHtml, 
			TextFormat.Enriched => IsEnriched, 
			TextFormat.RichText => IsRichText, 
			_ => false, 
		};
	}

	public string GetText(out Encoding encoding)
	{
		if (base.Content == null)
		{
			encoding = Encoding.ASCII;
			return string.Empty;
		}
		encoding = base.ContentType.CharsetEncoding;
		if (encoding == null)
		{
			try
			{
				using (Stream stream = base.Content.Open())
				{
					if (!CharsetUtils.TryGetBomEncoding(stream, out encoding))
					{
						encoding = CharsetUtils.UTF8;
					}
				}
				return GetText(encoding);
			}
			catch (DecoderFallbackException)
			{
				encoding = CharsetUtils.Latin1;
			}
		}
		return GetText(encoding);
	}

	public string GetText(Encoding encoding)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (base.Content == null)
		{
			return string.Empty;
		}
		using MemoryStream memoryStream = new MemoryStream();
		using (FilteredStream filteredStream = new FilteredStream(memoryStream))
		{
			filteredStream.Add(new CharsetFilter(encoding, CharsetUtils.UTF8));
			filteredStream.Add(FormatOptions.Default.CreateNewLineFilter());
			base.Content.DecodeTo(filteredStream);
			filteredStream.Flush();
		}
		byte[] buffer = memoryStream.GetBuffer();
		return CharsetUtils.UTF8.GetString(buffer, 0, (int)memoryStream.Length);
	}

	public string GetText(string charset)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		return GetText(CharsetUtils.GetEncoding(charset));
	}

	public void SetText(Encoding encoding, string text)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		MemoryStream stream = new MemoryStream(encoding.GetBytes(text));
		base.ContentType.CharsetEncoding = encoding;
		base.Content = new MimeContent(stream);
	}

	public void SetText(string charset, string text)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		SetText(CharsetUtils.GetEncoding(charset), text);
	}
}
