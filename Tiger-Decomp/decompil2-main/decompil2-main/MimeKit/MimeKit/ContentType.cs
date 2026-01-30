using System;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class ContentType
{
	private ParameterList parameters;

	private string type;

	private string subtype;

	public string MediaType
	{
		get
		{
			return type;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(type == value))
			{
				type = value;
				OnChanged();
			}
		}
	}

	public string MediaSubtype
	{
		get
		{
			return subtype;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(subtype == value))
			{
				subtype = value;
				OnChanged();
			}
		}
	}

	public ParameterList Parameters
	{
		get
		{
			return parameters;
		}
		internal set
		{
			if (parameters != null)
			{
				parameters.Changed -= OnParametersChanged;
			}
			value.Changed += OnParametersChanged;
			parameters = value;
		}
	}

	public string Boundary
	{
		get
		{
			return Parameters["boundary"];
		}
		set
		{
			if (value != null)
			{
				Parameters["boundary"] = value;
			}
			else
			{
				Parameters.Remove("boundary");
			}
		}
	}

	public string Charset
	{
		get
		{
			return Parameters["charset"];
		}
		set
		{
			if (value != null)
			{
				Parameters["charset"] = value;
			}
			else
			{
				Parameters.Remove("charset");
			}
		}
	}

	public Encoding CharsetEncoding
	{
		get
		{
			string charset = Charset;
			if (charset == null)
			{
				return null;
			}
			try
			{
				return CharsetUtils.GetEncoding(charset);
			}
			catch
			{
				return null;
			}
		}
		set
		{
			Charset = ((value != null) ? CharsetUtils.GetMimeCharset(value) : null);
		}
	}

	public string Format
	{
		get
		{
			return Parameters["format"];
		}
		set
		{
			if (value != null)
			{
				Parameters["format"] = value;
			}
			else
			{
				Parameters.Remove("format");
			}
		}
	}

	public string MimeType => $"{MediaType}/{MediaSubtype}";

	public string Name
	{
		get
		{
			return Parameters["name"];
		}
		set
		{
			if (value != null)
			{
				Parameters["name"] = value;
			}
			else
			{
				Parameters.Remove("name");
			}
		}
	}

	internal event EventHandler Changed;

	public ContentType(string mediaType, string mediaSubtype)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		if (mediaSubtype == null)
		{
			throw new ArgumentNullException("mediaSubtype");
		}
		Parameters = new ParameterList();
		subtype = mediaSubtype;
		type = mediaType;
	}

	public bool IsMimeType(string mediaType, string mediaSubtype)
	{
		if (mediaType == null)
		{
			throw new ArgumentNullException("mediaType");
		}
		if (mediaSubtype == null)
		{
			throw new ArgumentNullException("mediaSubtype");
		}
		if (mediaType == "*" || mediaType.Equals(type, StringComparison.OrdinalIgnoreCase))
		{
			if (!(mediaSubtype == "*"))
			{
				return mediaSubtype.Equals(subtype, StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
		return false;
	}

	internal string Encode(FormatOptions options, Encoding charset)
	{
		int length = "Content-Type:".Length;
		StringBuilder stringBuilder = new StringBuilder(" ");
		stringBuilder.Append(MediaType);
		stringBuilder.Append('/');
		stringBuilder.Append(MediaSubtype);
		length += stringBuilder.Length;
		Parameters.Encode(options, stringBuilder, ref length, charset);
		stringBuilder.Append(options.NewLine);
		return stringBuilder.ToString();
	}

	public string ToString(FormatOptions options, Encoding charset, bool encode)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		StringBuilder stringBuilder = new StringBuilder("Content-Type: ");
		stringBuilder.Append(MediaType);
		stringBuilder.Append('/');
		stringBuilder.Append(MediaSubtype);
		if (encode)
		{
			int lineLength = stringBuilder.Length;
			Parameters.Encode(options, stringBuilder, ref lineLength, charset);
		}
		else
		{
			stringBuilder.Append(Parameters.ToString());
		}
		return stringBuilder.ToString();
	}

	public string ToString(Encoding charset, bool encode)
	{
		return ToString(FormatOptions.Default, charset, encode);
	}

	public string ToString(bool encode)
	{
		return ToString(FormatOptions.Default, Encoding.UTF8, encode);
	}

	public override string ToString()
	{
		return ToString(encode: false);
	}

	private void OnParametersChanged(object sender, EventArgs e)
	{
		OnChanged();
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	private static bool SkipType(byte[] text, ref int index, int endIndex)
	{
		int num = index;
		while (index < endIndex && text[index].IsAsciiAtom() && text[index] != 47)
		{
			index++;
		}
		return index > num;
	}

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out ContentType contentType)
	{
		contentType = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		int num = index;
		if (!SkipType(text, ref index, endIndex))
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid type token at position {0}", num), num, index);
			}
			return false;
		}
		string mediaType = Encoding.ASCII.GetString(text, num, index - num);
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex || text[index] != 47)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Expected '/' at position {0}", index), index, index);
			}
			return false;
		}
		index++;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		num = index;
		if (!ParseUtils.SkipToken(text, ref index, endIndex))
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid atom token at position {0}", num), num, index);
			}
			return false;
		}
		string mediaSubtype = Encoding.ASCII.GetString(text, num, index - num);
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		contentType = new ContentType(mediaType, mediaSubtype);
		if (index >= endIndex)
		{
			return true;
		}
		if (text[index] != 59)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Expected ';' at position {0}", index), index, index);
			}
			return false;
		}
		index++;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			return true;
		}
		if (!ParameterList.TryParse(options, text, ref index, endIndex, throwOnError, out var paramList))
		{
			return false;
		}
		contentType.Parameters = paramList;
		return true;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out ContentType type)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		return TryParse(options, buffer, ref index, startIndex + length, throwOnError: false, out type);
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out ContentType type)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out type);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out ContentType type)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		return TryParse(options, buffer, ref index, buffer.Length, throwOnError: false, out type);
	}

	public static bool TryParse(byte[] buffer, int startIndex, out ContentType type)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out type);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out ContentType type)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		return TryParse(options, buffer, ref index, buffer.Length, throwOnError: false, out type);
	}

	public static bool TryParse(byte[] buffer, out ContentType type)
	{
		return TryParse(ParserOptions.Default, buffer, out type);
	}

	public static bool TryParse(ParserOptions options, string text, out ContentType type)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		return TryParse(options, bytes, ref index, bytes.Length, throwOnError: false, out type);
	}

	public static bool TryParse(string text, out ContentType type)
	{
		return TryParse(ParserOptions.Default, text, out type);
	}

	public static ContentType Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		TryParse(options, buffer, ref index, startIndex + length, throwOnError: true, out var contentType);
		return contentType;
	}

	public static ContentType Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public static ContentType Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		TryParse(options, buffer, ref index, buffer.Length, throwOnError: true, out var contentType);
		return contentType;
	}

	public static ContentType Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public static ContentType Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		TryParse(options, buffer, ref index, buffer.Length, throwOnError: true, out var contentType);
		return contentType;
	}

	public static ContentType Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public static ContentType Parse(ParserOptions options, string text)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		TryParse(options, bytes, ref index, bytes.Length, throwOnError: true, out var contentType);
		return contentType;
	}

	public static ContentType Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}
}
