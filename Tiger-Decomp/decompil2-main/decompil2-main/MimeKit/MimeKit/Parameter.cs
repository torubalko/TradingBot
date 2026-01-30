using System;
using System.Text;
using MimeKit.Encodings;
using MimeKit.Utils;

namespace MimeKit;

public class Parameter
{
	private enum EncodeMethod
	{
		None,
		Quote,
		Rfc2047,
		Rfc2231
	}

	private ParameterEncodingMethod encodingMethod;

	private Encoding encoding;

	private bool alwaysQuote;

	private string text;

	public string Name { get; private set; }

	public Encoding Encoding
	{
		get
		{
			return encoding ?? CharsetUtils.UTF8;
		}
		set
		{
			if (encoding != value)
			{
				encoding = value;
				OnChanged();
			}
		}
	}

	public ParameterEncodingMethod EncodingMethod
	{
		get
		{
			return encodingMethod;
		}
		set
		{
			if (encodingMethod != value)
			{
				if ((uint)value > 2u)
				{
					throw new ArgumentOutOfRangeException("value");
				}
				encodingMethod = value;
				OnChanged();
			}
		}
	}

	public bool AlwaysQuote
	{
		get
		{
			return alwaysQuote;
		}
		set
		{
			if (!(alwaysQuote && value) && (alwaysQuote || value))
			{
				alwaysQuote = value;
				OnChanged();
			}
		}
	}

	public string Value
	{
		get
		{
			return text;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!(text == value))
			{
				text = value;
				OnChanged();
			}
		}
	}

	internal event EventHandler Changed;

	public Parameter(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("Parameter names are not allowed to be empty.", "name");
		}
		for (int i = 0; i < name.Length; i++)
		{
			if (name[i] > '\u007f' || !IsAttr((byte)name[i]))
			{
				throw new ArgumentException("Illegal characters in parameter name.", "name");
			}
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Value = value;
		Name = name;
	}

	public Parameter(Encoding encoding, string name, string value)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("Parameter names are not allowed to be empty.", "name");
		}
		for (int i = 0; i < name.Length; i++)
		{
			if (name[i] > '\u007f' || !IsAttr((byte)name[i]))
			{
				throw new ArgumentException("Illegal characters in parameter name.", "name");
			}
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Encoding = encoding;
		Value = value;
		Name = name;
	}

	public Parameter(string charset, string name, string value)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("Parameter names are not allowed to be empty.", "name");
		}
		for (int i = 0; i < name.Length; i++)
		{
			if (name[i] > '\u007f' || !IsAttr((byte)name[i]))
			{
				throw new ArgumentException("Illegal characters in parameter name.", "name");
			}
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Encoding = CharsetUtils.GetEncoding(charset);
		Value = value;
		Name = name;
	}

	private static bool IsAttr(byte c)
	{
		return c.IsAttr();
	}

	private static bool IsCtrl(char c)
	{
		return ((byte)c).IsCtrl();
	}

	private EncodeMethod GetEncodeMethod(FormatOptions options, string name, string value, out string quoted)
	{
		EncodeMethod encodeMethod = ((AlwaysQuote || options.AlwaysQuoteParameterValues) ? EncodeMethod.Quote : EncodeMethod.None);
		EncodeMethod result = encodingMethod switch
		{
			ParameterEncodingMethod.Rfc2231 => EncodeMethod.Rfc2231, 
			ParameterEncodingMethod.Rfc2047 => EncodeMethod.Rfc2047, 
			_ => (options.ParameterEncodingMethod != ParameterEncodingMethod.Rfc2231) ? EncodeMethod.Rfc2047 : EncodeMethod.Rfc2231, 
		};
		quoted = null;
		if (name.Length + 1 + value.Length >= options.MaxLineLength)
		{
			return result;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] < '\u0080')
			{
				byte c = (byte)value[i];
				if (c.IsCtrl())
				{
					return result;
				}
				if (!c.IsAttr())
				{
					encodeMethod = EncodeMethod.Quote;
				}
			}
			else
			{
				if (!options.International)
				{
					return result;
				}
				encodeMethod = EncodeMethod.Quote;
			}
		}
		if (encodeMethod == EncodeMethod.Quote)
		{
			quoted = MimeUtils.Quote(value);
			if (name.Length + 1 + quoted.Length >= options.MaxLineLength)
			{
				return result;
			}
		}
		return encodeMethod;
	}

	private static EncodeMethod GetEncodeMethod(FormatOptions options, char[] value, int startIndex, int length)
	{
		EncodeMethod result = EncodeMethod.None;
		for (int i = startIndex; i < startIndex + length; i++)
		{
			if (value[i] < '\u0080')
			{
				byte c = (byte)value[i];
				if (c.IsCtrl())
				{
					return EncodeMethod.Rfc2231;
				}
				if (!c.IsAttr())
				{
					result = EncodeMethod.Quote;
				}
			}
			else
			{
				if (!options.International)
				{
					return EncodeMethod.Rfc2231;
				}
				result = EncodeMethod.Quote;
			}
		}
		return result;
	}

	private static EncodeMethod GetEncodeMethod(byte[] value, int length)
	{
		EncodeMethod result = EncodeMethod.None;
		for (int i = 0; i < length; i++)
		{
			if (value[i] >= 127 || value[i].IsCtrl())
			{
				return EncodeMethod.Rfc2231;
			}
			if (!value[i].IsAttr())
			{
				result = EncodeMethod.Quote;
			}
		}
		return result;
	}

	private static Encoding GetBestEncoding(string value, Encoding defaultEncoding)
	{
		int num = 0;
		for (int i = 0; i < value.Length; i++)
		{
			if (value[i] < '\u007f')
			{
				if (IsCtrl(value[i]))
				{
					num = Math.Max(num, 1);
				}
			}
			else
			{
				num = ((value[i] >= 'Ā') ? 2 : Math.Max(num, 1));
			}
		}
		return num switch
		{
			0 => Encoding.ASCII, 
			1 => Encoding.GetEncoding(28591), 
			_ => defaultEncoding, 
		};
	}

	private static bool Rfc2231GetNextValue(FormatOptions options, string charset, Encoder encoder, HexEncoder hex, char[] chars, ref int index, ref byte[] bytes, ref byte[] encoded, int maxLength, out string value)
	{
		int num = chars.Length - index;
		if (num < maxLength)
		{
			switch (GetEncodeMethod(options, chars, index, num))
			{
			case EncodeMethod.Quote:
				value = MimeUtils.Quote(new string(chars, index, num));
				index += num;
				return false;
			case EncodeMethod.None:
				value = new string(chars, index, num);
				index += num;
				return false;
			}
		}
		num = Math.Min(maxLength, num);
		int num3;
		while (true)
		{
			int byteCount = encoder.GetByteCount(chars, index, num, flush: true);
			int num2;
			if (byteCount > maxLength && num > 1)
			{
				num = (((num2 = (int)Math.Round((double)byteCount / (double)num)) <= 1) ? (num - 1) : (num - Math.Max((byteCount - maxLength) / num2, 1)));
				continue;
			}
			if (bytes.Length < byteCount)
			{
				Array.Resize(ref bytes, byteCount);
			}
			byteCount = encoder.GetBytes(chars, index, num, bytes, 0, flush: true);
			if (index > 0 || charset == "us-ascii")
			{
				switch (GetEncodeMethod(bytes, byteCount))
				{
				case EncodeMethod.Quote:
					value = MimeUtils.Quote(Encoding.ASCII.GetString(bytes, 0, byteCount));
					index += num;
					return false;
				case EncodeMethod.None:
					value = Encoding.ASCII.GetString(bytes, 0, byteCount);
					index += num;
					return false;
				}
			}
			num3 = hex.EstimateOutputLength(byteCount);
			if (encoded.Length < num3)
			{
				Array.Resize(ref encoded, num3);
			}
			int num4 = ((index == 0) ? (charset.Length + 2) : 0);
			num3 = hex.Encode(bytes, 0, byteCount, encoded);
			if (num3 <= 3 || num4 + num3 <= maxLength)
			{
				break;
			}
			int num5 = 0;
			int num6 = num3 - 1;
			while (num6 >= 0 && num4 + num6 >= maxLength)
			{
				num5 = ((encoded[num6] != 37) ? (num5 + 1) : (num5 - 1));
				num6--;
			}
			num = (((num2 = (int)Math.Round((double)byteCount / (double)num)) <= 1) ? (num - 1) : (num - Math.Max(num5 / num2, 1)));
		}
		if (index == 0)
		{
			value = charset + "''" + Encoding.ASCII.GetString(encoded, 0, num3);
		}
		else
		{
			value = Encoding.ASCII.GetString(encoded, 0, num3);
		}
		index += num;
		return true;
	}

	private void EncodeRfc2231(FormatOptions options, StringBuilder builder, ref int lineLength, Encoding headerEncoding)
	{
		Encoding encoding = (options.International ? CharsetUtils.UTF8 : GetBestEncoding(Value, this.encoding ?? headerEncoding));
		int num = options.MaxLineLength - (Name.Length + 6);
		string mimeCharset = CharsetUtils.GetMimeCharset(encoding);
		Encoder encoder = encoding.GetEncoder();
		byte[] bytes = new byte[Math.Max(num, 6)];
		byte[] encoded = new byte[bytes.Length * 3 + 3];
		char[] array = Value.ToCharArray();
		HexEncoder hex = new HexEncoder();
		int index = 0;
		int num2 = 0;
		do
		{
			builder.Append(';');
			lineLength++;
			string value;
			bool flag = Rfc2231GetNextValue(options, mimeCharset, encoder, hex, array, ref index, ref bytes, ref encoded, num, out value);
			int num3 = Name.Length + (flag ? 1 : 0) + 1 + value.Length;
			if (num2 == 0 && index == array.Length)
			{
				if (lineLength + 1 + num3 >= options.MaxLineLength)
				{
					builder.Append(options.NewLine);
					builder.Append('\t');
					lineLength = 1;
				}
				else
				{
					builder.Append(' ');
					lineLength++;
				}
				builder.Append(Name);
				if (flag)
				{
					builder.Append('*');
				}
				builder.Append('=');
				builder.Append(value);
				lineLength += num3;
				break;
			}
			builder.Append(options.NewLine);
			builder.Append('\t');
			lineLength = 1;
			string text = num2.ToString();
			num3 += text.Length + 1;
			builder.Append(Name);
			builder.Append('*');
			builder.Append(text);
			if (flag)
			{
				builder.Append('*');
			}
			builder.Append('=');
			builder.Append(value);
			lineLength += num3;
			num2++;
		}
		while (index < array.Length);
	}

	private static int EstimateEncodedWordLength(string charset, int byteCount, int encodeCount)
	{
		int num = charset.Length + 7;
		if ((double)encodeCount < (double)byteCount * 0.17)
		{
			return num + (byteCount - encodeCount) + encodeCount * 3;
		}
		return num + (byteCount + 2) / 3 * 4;
	}

	private static bool ExceedsMaxWordLength(string charset, int byteCount, int encodeCount, int maxLength)
	{
		int num = EstimateEncodedWordLength(charset, byteCount, encodeCount);
		return num + 1 >= maxLength;
	}

	private static int Rfc2047EncodeNextChunk(StringBuilder str, string text, ref int index, Encoding encoding, string charset, Encoder encoder, int maxLength)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		char[] array = new char[2];
		int startIndex = index;
		while (index < text.Length)
		{
			char c = text[index++];
			int num4;
			int num5;
			if (c < '\u007f')
			{
				if (IsCtrl(c) || c == '"' || c == '\\')
				{
					num3++;
				}
				num++;
				num2++;
				num4 = 1;
				num5 = 1;
			}
			else if (c < 'Ā')
			{
				num3++;
				num++;
				num2++;
				num4 = 1;
				num5 = 1;
			}
			else
			{
				if (char.IsSurrogatePair(text, index - 1))
				{
					array[1] = text[index++];
					num4 = 2;
				}
				else
				{
					num4 = 1;
				}
				array[0] = c;
				try
				{
					num5 = encoder.GetByteCount(array, 0, num4, flush: true);
				}
				catch
				{
					num5 = 3;
				}
				num2 += num4;
				num3 += num5;
				num += num5;
			}
			if (ExceedsMaxWordLength(charset, num, num3, maxLength))
			{
				num2 -= num4;
				index -= num4;
				num -= num5;
				break;
			}
		}
		return Rfc2047.AppendEncodedWord(str, encoding, text, startIndex, num2, QEncodeMode.Text);
	}

	private void EncodeRfc2047(FormatOptions options, StringBuilder builder, ref int lineLength, Encoding headerEncoding)
	{
		Encoding encoding = (options.International ? CharsetUtils.UTF8 : GetBestEncoding(Value, this.encoding ?? headerEncoding));
		string mimeCharset = CharsetUtils.GetMimeCharset(encoding);
		Encoder encoder = encoding.GetEncoder();
		int index = 0;
		builder.Append(';');
		lineLength++;
		if (lineLength + Name.Length + mimeCharset.Length + 10 + Math.Min(Value.Length, 10) >= options.MaxLineLength)
		{
			builder.Append(options.NewLine);
			builder.Append('\t');
			lineLength = 1;
		}
		else
		{
			builder.Append(' ');
			lineLength++;
		}
		builder.AppendFormat("{0}=\"", Name);
		lineLength += Name.Length + 2;
		while (true)
		{
			int num = Rfc2047EncodeNextChunk(builder, Value, ref index, encoding, mimeCharset, encoder, options.MaxLineLength - lineLength - 1);
			lineLength += num;
			if (index >= Value.Length)
			{
				break;
			}
			builder.Append(options.NewLine);
			builder.Append('\t');
			lineLength = 1;
		}
		builder.Append('"');
		lineLength++;
	}

	internal void Encode(FormatOptions options, StringBuilder builder, ref int lineLength, Encoding headerEncoding)
	{
		string quoted;
		switch (GetEncodeMethod(options, Name, Value, out quoted))
		{
		case EncodeMethod.Rfc2231:
			EncodeRfc2231(options, builder, ref lineLength, headerEncoding);
			return;
		case EncodeMethod.Rfc2047:
			EncodeRfc2047(options, builder, ref lineLength, headerEncoding);
			return;
		case EncodeMethod.None:
			quoted = Value;
			break;
		}
		builder.Append(';');
		lineLength++;
		if (lineLength + 1 + Name.Length + 1 + quoted.Length >= options.MaxLineLength)
		{
			builder.Append(options.NewLine);
			builder.Append('\t');
			lineLength = 1;
		}
		else
		{
			builder.Append(' ');
			lineLength++;
		}
		lineLength += Name.Length + 1 + quoted.Length;
		builder.Append(Name);
		builder.Append('=');
		builder.Append(quoted);
	}

	public override string ToString()
	{
		return Name + "=" + MimeUtils.Quote(Value);
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}
}
