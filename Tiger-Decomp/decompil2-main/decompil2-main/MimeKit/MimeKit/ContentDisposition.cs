using System;
using System.Globalization;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public class ContentDisposition
{
	public const string Attachment = "attachment";

	public const string FormData = "form-data";

	public const string Inline = "inline";

	private ParameterList parameters;

	private string disposition;

	public string Disposition
	{
		get
		{
			return disposition;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("The disposition is not allowed to be empty.", "value");
			}
			for (int i = 0; i < value.Length; i++)
			{
				if (value[i] >= '\u007f' || !IsAsciiAtom((byte)value[i]))
				{
					throw new ArgumentException("Illegal characters in disposition value.", "value");
				}
			}
			if (!(disposition == value))
			{
				disposition = value;
				OnChanged();
			}
		}
	}

	public bool IsAttachment
	{
		get
		{
			return disposition.Equals("attachment", StringComparison.OrdinalIgnoreCase);
		}
		set
		{
			disposition = (value ? "attachment" : "inline");
		}
	}

	public ParameterList Parameters
	{
		get
		{
			return parameters;
		}
		private set
		{
			if (parameters != null)
			{
				parameters.Changed -= OnParametersChanged;
			}
			value.Changed += OnParametersChanged;
			parameters = value;
		}
	}

	public string FileName
	{
		get
		{
			return Parameters["filename"];
		}
		set
		{
			if (value != null)
			{
				Parameters["filename"] = value;
			}
			else
			{
				Parameters.Remove("filename");
			}
		}
	}

	public DateTimeOffset? CreationDate
	{
		get
		{
			string text = Parameters["creation-date"];
			if (IsNullOrWhiteSpace(text))
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (!DateUtils.TryParse(bytes, 0, bytes.Length, out var date))
			{
				return null;
			}
			return date;
		}
		set
		{
			if (value.HasValue)
			{
				Parameters["creation-date"] = DateUtils.FormatDate(value.Value);
			}
			else
			{
				Parameters.Remove("creation-date");
			}
		}
	}

	public DateTimeOffset? ModificationDate
	{
		get
		{
			string text = Parameters["modification-date"];
			if (IsNullOrWhiteSpace(text))
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (!DateUtils.TryParse(bytes, 0, bytes.Length, out var date))
			{
				return null;
			}
			return date;
		}
		set
		{
			if (value.HasValue)
			{
				Parameters["modification-date"] = DateUtils.FormatDate(value.Value);
			}
			else
			{
				Parameters.Remove("modification-date");
			}
		}
	}

	public DateTimeOffset? ReadDate
	{
		get
		{
			string text = Parameters["read-date"];
			if (IsNullOrWhiteSpace(text))
			{
				return null;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			if (!DateUtils.TryParse(bytes, 0, bytes.Length, out var date))
			{
				return null;
			}
			return date;
		}
		set
		{
			if (value.HasValue)
			{
				Parameters["read-date"] = DateUtils.FormatDate(value.Value);
			}
			else
			{
				Parameters.Remove("read-date");
			}
		}
	}

	public long? Size
	{
		get
		{
			string text = Parameters["size"];
			if (IsNullOrWhiteSpace(text))
			{
				return null;
			}
			if (!long.TryParse(text, out var result))
			{
				return null;
			}
			return result;
		}
		set
		{
			if (value.HasValue)
			{
				Parameters["size"] = value.Value.ToString();
			}
			else
			{
				Parameters.Remove("size");
			}
		}
	}

	internal event EventHandler Changed;

	public ContentDisposition(string disposition)
	{
		Parameters = new ParameterList();
		Disposition = disposition;
	}

	public ContentDisposition()
		: this("attachment")
	{
	}

	private static bool IsAsciiAtom(byte c)
	{
		return c.IsAsciiAtom();
	}

	private static bool IsNullOrWhiteSpace(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return true;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (!char.IsWhiteSpace(value[i]))
			{
				return false;
			}
		}
		return true;
	}

	internal string Encode(FormatOptions options, Encoding charset)
	{
		int length = "Content-Disposition:".Length;
		StringBuilder stringBuilder = new StringBuilder(" ");
		stringBuilder.Append(disposition);
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
		StringBuilder stringBuilder = new StringBuilder("Content-Disposition: ");
		stringBuilder.Append(disposition);
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

	internal static bool TryParse(ParserOptions options, byte[] text, ref int index, int endIndex, bool throwOnError, out ContentDisposition disposition)
	{
		disposition = null;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
		if (index >= endIndex)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Expected atom token at position {0}", index), index, index);
			}
			return false;
		}
		int num = index;
		string text2;
		if (text[index] == 34)
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Unxpected qstring token at position {0}", num), num, index);
			}
			if (!ParseUtils.SkipQuoted(text, ref index, endIndex, throwOnError))
			{
				return false;
			}
			text2 = CharsetUtils.ConvertToUnicode(options, text, num, index - num);
			text2 = MimeUtils.Unquote(text2);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "attachment";
			}
		}
		else if (!ParseUtils.SkipAtom(text, ref index, endIndex))
		{
			if (throwOnError)
			{
				throw new ParseException(string.Format(CultureInfo.InvariantCulture, "Invalid atom token at position {0}", num), num, index);
			}
			if (index > num || text[index] != 59)
			{
				return false;
			}
			text2 = "attachment";
		}
		else
		{
			text2 = Encoding.ASCII.GetString(text, num, index - num);
		}
		disposition = new ContentDisposition();
		disposition.disposition = text2;
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, endIndex, throwOnError))
		{
			return false;
		}
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
		disposition.Parameters = paramList;
		return true;
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out ContentDisposition disposition)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		return TryParse(options, buffer, ref index, startIndex + length, throwOnError: false, out disposition);
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out ContentDisposition disposition)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out disposition);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out ContentDisposition disposition)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		return TryParse(options, buffer, ref index, buffer.Length, throwOnError: false, out disposition);
	}

	public static bool TryParse(byte[] buffer, int startIndex, out ContentDisposition disposition)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out disposition);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out ContentDisposition disposition)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		return TryParse(options, buffer, ref index, buffer.Length, throwOnError: false, out disposition);
	}

	public static bool TryParse(byte[] buffer, out ContentDisposition disposition)
	{
		return TryParse(ParserOptions.Default, buffer, out disposition);
	}

	public static bool TryParse(ParserOptions options, string text, out ContentDisposition disposition)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		return TryParse(ParserOptions.Default, bytes, ref index, bytes.Length, throwOnError: false, out disposition);
	}

	public static bool TryParse(string text, out ContentDisposition disposition)
	{
		return TryParse(ParserOptions.Default, text, out disposition);
	}

	public static ContentDisposition Parse(ParserOptions options, byte[] buffer, int startIndex, int length)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		int index = startIndex;
		TryParse(options, buffer, ref index, startIndex + length, throwOnError: true, out var result);
		return result;
	}

	public static ContentDisposition Parse(byte[] buffer, int startIndex, int length)
	{
		return Parse(ParserOptions.Default, buffer, startIndex, length);
	}

	public static ContentDisposition Parse(ParserOptions options, byte[] buffer, int startIndex)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int index = startIndex;
		TryParse(options, buffer, ref index, buffer.Length, throwOnError: true, out var result);
		return result;
	}

	public static ContentDisposition Parse(byte[] buffer, int startIndex)
	{
		return Parse(ParserOptions.Default, buffer, startIndex);
	}

	public static ContentDisposition Parse(ParserOptions options, byte[] buffer)
	{
		ParseUtils.ValidateArguments(options, buffer);
		int index = 0;
		TryParse(options, buffer, ref index, buffer.Length, throwOnError: true, out var result);
		return result;
	}

	public static ContentDisposition Parse(byte[] buffer)
	{
		return Parse(ParserOptions.Default, buffer);
	}

	public static ContentDisposition Parse(ParserOptions options, string text)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		int index = 0;
		TryParse(options, bytes, ref index, bytes.Length, throwOnError: true, out var result);
		return result;
	}

	public static ContentDisposition Parse(string text)
	{
		return Parse(ParserOptions.Default, text);
	}
}
