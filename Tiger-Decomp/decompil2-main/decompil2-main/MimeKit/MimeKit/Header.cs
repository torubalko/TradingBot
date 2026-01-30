using System;
using System.Collections.Generic;
using System.Text;
using MimeKit.Cryptography;
using MimeKit.Utils;

namespace MimeKit;

public class Header
{
	private delegate void ReceivedTokenSkipValueFunc(byte[] text, ref int index);

	private struct ReceivedToken
	{
		public readonly ReceivedTokenSkipValueFunc Skip;

		public readonly string Atom;

		public ReceivedToken(string atom, ReceivedTokenSkipValueFunc skip)
		{
			Atom = atom;
			Skip = skip;
		}
	}

	private class ReceivedTokenValue
	{
		public readonly int StartIndex;

		public readonly int Length;

		public ReceivedTokenValue(int startIndex, int length)
		{
			StartIndex = startIndex;
			Length = length;
		}
	}

	private class BrokenWord
	{
		public readonly char[] Text;

		public readonly int StartIndex;

		public readonly int Length;

		public BrokenWord(char[] text, int startIndex, int length)
		{
			StartIndex = startIndex;
			Length = length;
			Text = text;
		}
	}

	internal static readonly byte[] Colon = new byte[1] { 58 };

	internal readonly ParserOptions Options;

	private readonly byte[] rawField;

	private bool explicitRawValue;

	private string textValue;

	private byte[] rawValue;

	private static readonly byte[] ReceivedAddrSpecSentinels = new byte[2] { 62, 59 };

	private static readonly byte[] ReceivedMessageIdSentinels = new byte[1] { 62 };

	private static readonly ReceivedToken[] ReceivedTokens = new ReceivedToken[6]
	{
		new ReceivedToken("from", ReceivedTokenSkipDomain),
		new ReceivedToken("by", ReceivedTokenSkipDomain),
		new ReceivedToken("via", ReceivedTokenSkipDomain),
		new ReceivedToken("with", ReceivedTokenSkipAtom),
		new ReceivedToken("id", ReceivedTokenSkipMessageId),
		new ReceivedToken("for", ReceivedTokenSkipAddress)
	};

	public long? Offset { get; internal set; }

	public string Field { get; private set; }

	public HeaderId Id { get; private set; }

	internal bool IsInvalid { get; private set; }

	public byte[] RawField => rawField;

	public byte[] RawValue => rawValue;

	public string Value
	{
		get
		{
			if (textValue == null)
			{
				textValue = Unfold(Rfc2047.DecodeText(Options, rawValue));
			}
			return textValue;
		}
		set
		{
			SetValue(FormatOptions.Default, Encoding.UTF8, value);
		}
	}

	internal event EventHandler Changed;

	public Header(Encoding encoding, HeaderId id, string value)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Options = ParserOptions.Default.Clone();
		Field = id.ToHeaderName();
		Id = id;
		rawField = Encoding.ASCII.GetBytes(Field);
		SetValue(encoding, value);
	}

	public Header(string charset, HeaderId id, string value)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (id == HeaderId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Encoding encoding = CharsetUtils.GetEncoding(charset);
		Options = ParserOptions.Default.Clone();
		Field = id.ToHeaderName();
		Id = id;
		rawField = Encoding.ASCII.GetBytes(Field);
		SetValue(encoding, value);
	}

	public Header(HeaderId id, string value)
		: this(Encoding.UTF8, id, value)
	{
	}

	public Header(Encoding encoding, string field, string value)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		if (field.Length == 0)
		{
			throw new ArgumentException("Header field names are not allowed to be empty.", "field");
		}
		for (int i = 0; i < field.Length; i++)
		{
			if (field[i] >= '\u007f' || !IsAsciiAtom((byte)field[i]))
			{
				throw new ArgumentException("Illegal characters in header field name.", "field");
			}
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Options = ParserOptions.Default.Clone();
		Id = field.ToHeaderId();
		Field = field;
		rawField = Encoding.ASCII.GetBytes(field);
		SetValue(encoding, value);
	}

	public Header(string charset, string field, string value)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (field == null)
		{
			throw new ArgumentNullException("field");
		}
		if (field.Length == 0)
		{
			throw new ArgumentException("Header field names are not allowed to be empty.", "field");
		}
		for (int i = 0; i < field.Length; i++)
		{
			if (field[i] >= '\u007f' || !IsAsciiAtom((byte)field[i]))
			{
				throw new ArgumentException("Illegal characters in header field name.", "field");
			}
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		Encoding encoding = CharsetUtils.GetEncoding(charset);
		Options = ParserOptions.Default.Clone();
		Id = field.ToHeaderId();
		Field = field;
		rawField = Encoding.ASCII.GetBytes(field);
		SetValue(encoding, value);
	}

	public Header(string field, string value)
		: this(Encoding.UTF8, field, value)
	{
	}

	protected Header(ParserOptions options, HeaderId id, string name, byte[] field, byte[] value)
	{
		Options = options;
		rawField = field;
		rawValue = value;
		Field = name;
		Id = id;
	}

	protected internal Header(ParserOptions options, byte[] field, byte[] value, bool invalid)
	{
		char[] array = new char[field.Length];
		int i;
		for (i = 0; i < field.Length && (invalid || !field[i].IsBlank()); i++)
		{
			array[i] = (char)field[i];
		}
		Options = options;
		rawField = field;
		rawValue = value;
		Field = new string(array, 0, i);
		Id = Field.ToHeaderId();
		IsInvalid = invalid;
	}

	protected internal Header(ParserOptions options, HeaderId id, string field, byte[] value)
	{
		Options = options;
		rawField = Encoding.ASCII.GetBytes(field);
		rawValue = value;
		Field = field;
		Id = id;
	}

	public Header Clone()
	{
		Header header = new Header(Options, Id, Field, rawField, rawValue)
		{
			explicitRawValue = explicitRawValue,
			IsInvalid = IsInvalid
		};
		header.textValue = textValue;
		return header;
	}

	public string GetValue(Encoding encoding)
	{
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		ParserOptions parserOptions = Options.Clone();
		parserOptions.CharsetEncoding = encoding;
		return Unfold(Rfc2047.DecodeText(parserOptions, rawValue));
	}

	public string GetValue(string charset)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		Encoding encoding = CharsetUtils.GetEncoding(charset);
		return GetValue(encoding);
	}

	private static byte[] EncodeAddressHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		StringBuilder stringBuilder = new StringBuilder(" ");
		int lineLength = field.Length + 2;
		if (!InternetAddressList.TryParse(options, value, out var addresses))
		{
			return (byte[])format.NewLineBytes.Clone();
		}
		addresses.Encode(format, stringBuilder, firstToken: true, ref lineLength);
		stringBuilder.Append(format.NewLine);
		if (format.International)
		{
			return Encoding.UTF8.GetBytes(stringBuilder.ToString());
		}
		return Encoding.ASCII.GetBytes(stringBuilder.ToString());
	}

	private static byte[] EncodeMessageIdHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		return encoding.GetBytes(" " + value + format.NewLine);
	}

	private static void ReceivedTokenSkipAtom(byte[] text, ref int index)
	{
		if (ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, text.Length, throwOnError: false) && index < text.Length)
		{
			ParseUtils.SkipAtom(text, ref index, text.Length);
		}
	}

	private static void ReceivedTokenSkipDomain(byte[] text, ref int index)
	{
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, text.Length, throwOnError: false))
		{
			return;
		}
		if (text[index] == 91)
		{
			while (index < text.Length && text[index] != 93)
			{
				index++;
			}
			if (index < text.Length)
			{
				index++;
			}
		}
		else
		{
			while (ParseUtils.SkipAtom(text, ref index, text.Length) && index < text.Length && text[index] == 46)
			{
				index++;
			}
		}
	}

	private static void ReceivedTokenSkipAddress(byte[] text, ref int index)
	{
		if (ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, text.Length, throwOnError: false) && index < text.Length)
		{
			if (text[index] == 60)
			{
				index++;
			}
			InternetAddress.TryParseAddrspec(text, ref index, text.Length, ReceivedAddrSpecSentinels, RfcComplianceMode.Strict, throwOnError: false, out var _, out var _);
			if (index < text.Length && text[index] == 62)
			{
				index++;
			}
		}
	}

	private static void ReceivedTokenSkipMessageId(byte[] text, ref int index)
	{
		if (!ParseUtils.SkipCommentsAndWhiteSpace(text, ref index, text.Length, throwOnError: false) || index >= text.Length)
		{
			return;
		}
		if (text[index] == 60)
		{
			index++;
			InternetAddress.TryParseAddrspec(text, ref index, text.Length, ReceivedMessageIdSentinels, RfcComplianceMode.Strict, throwOnError: false, out var _, out var _);
			if (index < text.Length && text[index] == 62)
			{
				index++;
			}
		}
		else
		{
			ParseUtils.SkipAtom(text, ref index, text.Length);
		}
	}

	private static byte[] EncodeReceivedHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		List<ReceivedTokenValue> list = new List<ReceivedTokenValue>();
		byte[] bytes = encoding.GetBytes(value);
		StringBuilder stringBuilder = new StringBuilder();
		int num = field.Length + 1;
		bool flag = false;
		int i = 0;
		int num2 = 0;
		while (i < bytes.Length)
		{
			ReceivedTokenValue receivedTokenValue = null;
			int num3 = i;
			if (!ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref i, bytes.Length, throwOnError: false) || i >= bytes.Length)
			{
				list.Add(new ReceivedTokenValue(num3, i - num3));
				break;
			}
			for (; i < bytes.Length && !bytes[i].IsWhitespace(); i++)
			{
			}
			string text = encoding.GetString(bytes, num3, i - num3);
			for (int j = 0; j < ReceivedTokens.Length; j++)
			{
				if (text == ReceivedTokens[j].Atom)
				{
					ReceivedTokens[j].Skip(bytes, ref i);
					if (ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref i, bytes.Length, throwOnError: false) && i < bytes.Length && bytes[i] == 59)
					{
						flag = true;
						i++;
					}
					receivedTokenValue = new ReceivedTokenValue(num3, i - num3);
					break;
				}
			}
			if (receivedTokenValue == null)
			{
				if (ParseUtils.SkipCommentsAndWhiteSpace(bytes, ref i, bytes.Length, throwOnError: false))
				{
					for (; i < bytes.Length && !bytes[i].IsWhitespace(); i++)
					{
					}
				}
				receivedTokenValue = new ReceivedTokenValue(num3, i - num3);
			}
			list.Add(receivedTokenValue);
			ParseUtils.SkipWhiteSpace(bytes, ref i, bytes.Length);
			if (flag && i < bytes.Length)
			{
				list.Add(new ReceivedTokenValue(i, bytes.Length - i));
				break;
			}
		}
		foreach (ReceivedTokenValue item in list)
		{
			string text2 = encoding.GetString(bytes, item.StartIndex, item.Length).TrimEnd();
			if (num2 > 0 && num + text2.Length + 1 > format.MaxLineLength)
			{
				stringBuilder.Append(format.NewLine);
				stringBuilder.Append('\t');
				num = 1;
				num2 = 0;
			}
			else
			{
				stringBuilder.Append(' ');
				num++;
			}
			num += text2.Length;
			stringBuilder.Append(text2);
			num2++;
		}
		stringBuilder.Append(format.NewLine);
		return encoding.GetBytes(stringBuilder.ToString());
	}

	private static byte[] EncodeAuthenticationResultsHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		if (!AuthenticationResults.TryParse(bytes, out var authres))
		{
			return EncodeUnstructuredHeader(options, format, encoding, field, value);
		}
		StringBuilder stringBuilder = new StringBuilder();
		int lineLength = field.Length + 1;
		authres.Encode(format, stringBuilder, lineLength);
		return encoding.GetBytes(stringBuilder.ToString());
	}

	private static void EncodeDkimLongValue(FormatOptions format, StringBuilder encoded, ref int lineLength, string value)
	{
		int num = 0;
		while (true)
		{
			int num2 = format.MaxLineLength - lineLength;
			int num3 = Math.Min(num + num2, value.Length);
			encoded.Append(value.Substring(num, num3 - num));
			lineLength += num3 - num;
			if (num3 != value.Length)
			{
				encoded.Append(format.NewLine);
				encoded.Append('\t');
				lineLength = 1;
				num = num3;
				continue;
			}
			break;
		}
	}

	private static void EncodeDkimHeaderList(FormatOptions format, StringBuilder encoded, ref int lineLength, string value, char delim)
	{
		string[] array = value.Split(delim);
		for (int i = 0; i < array.Length; i++)
		{
			if (i > 0)
			{
				encoded.Append(delim);
				lineLength++;
			}
			if (lineLength + array[i].Length + 1 > format.MaxLineLength)
			{
				encoded.Append(format.NewLine);
				encoded.Append('\t');
				lineLength = 1;
				if (array[i].Length + 1 > format.MaxLineLength)
				{
					EncodeDkimLongValue(format, encoded, ref lineLength, array[i]);
					continue;
				}
				lineLength += array[i].Length;
				encoded.Append(array[i]);
			}
			else
			{
				lineLength += array[i].Length;
				encoded.Append(array[i]);
			}
		}
	}

	private static byte[] EncodeDkimOrArcSignatureHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int lineLength = field.Length + 1;
		StringBuilder stringBuilder2 = new StringBuilder();
		int i = 0;
		while (i < value.Length)
		{
			for (; i < value.Length && IsWhiteSpace(value[i]); i++)
			{
			}
			int num = i;
			for (; i < value.Length && value[i] != '='; i++)
			{
				if (!IsWhiteSpace(value[i]))
				{
					stringBuilder2.Append(value[i]);
				}
			}
			string text = value.Substring(num, i - num);
			for (; i < value.Length && value[i] != ';'; i++)
			{
				if (!IsWhiteSpace(value[i]))
				{
					stringBuilder2.Append(value[i]);
				}
			}
			if (i < value.Length && value[i] == ';')
			{
				stringBuilder2.Append(';');
				i++;
			}
			if (lineLength + stringBuilder2.Length + 1 > format.MaxLineLength || text == "bh" || text == "b")
			{
				stringBuilder.Append(format.NewLine);
				stringBuilder.Append('\t');
				lineLength = 1;
			}
			else
			{
				stringBuilder.Append(' ');
				lineLength++;
			}
			if (stringBuilder2.Length > format.MaxLineLength)
			{
				if (!(text == "z"))
				{
					if (text == "h")
					{
						EncodeDkimHeaderList(format, stringBuilder, ref lineLength, stringBuilder2.ToString(), ':');
					}
					else
					{
						EncodeDkimLongValue(format, stringBuilder, ref lineLength, stringBuilder2.ToString());
					}
				}
				else
				{
					EncodeDkimHeaderList(format, stringBuilder, ref lineLength, stringBuilder2.ToString(), '|');
				}
			}
			else
			{
				stringBuilder.Append(stringBuilder2.ToString());
				lineLength += stringBuilder2.Length;
			}
			stringBuilder2.Length = 0;
		}
		stringBuilder.Append(format.NewLine);
		return encoding.GetBytes(stringBuilder.ToString());
	}

	private static byte[] EncodeReferencesHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = field.Length + 1;
		int num2 = 0;
		foreach (string item in MimeUtils.EnumerateReferences(value))
		{
			if (num2 > 0 && num + item.Length + 3 > format.MaxLineLength)
			{
				stringBuilder.Append(format.NewLine);
				stringBuilder.Append('\t');
				num = 1;
				num2 = 0;
			}
			else
			{
				stringBuilder.Append(' ');
				num++;
			}
			stringBuilder.Append('<').Append(item).Append('>');
			num += item.Length + 2;
			num2++;
		}
		stringBuilder.Append(format.NewLine);
		return encoding.GetBytes(stringBuilder.ToString());
	}

	private static bool IsWhiteSpace(char c)
	{
		if (c != ' ' && c != '\t' && c != '\r')
		{
			return c == '\n';
		}
		return true;
	}

	private static IEnumerable<string> TokenizeText(string text)
	{
		int index = 0;
		while (index < text.Length)
		{
			int num = index;
			for (; index < text.Length && !IsWhiteSpace(text[index]); index++)
			{
			}
			yield return text.Substring(num, index - num);
			if (index != text.Length)
			{
				num = index;
				for (; index < text.Length && IsWhiteSpace(text[index]); index++)
				{
				}
				yield return text.Substring(num, index - num);
				continue;
			}
			break;
		}
	}

	private static IEnumerable<BrokenWord> WordBreak(FormatOptions format, string word, int lineLength)
	{
		char[] chars = word.ToCharArray();
		int startIndex = 0;
		lineLength = Math.Max(lineLength, 1);
		while (startIndex < word.Length)
		{
			int length = Math.Min(format.MaxLineLength - lineLength, word.Length - startIndex);
			if (char.IsSurrogatePair(word, startIndex + length - 1))
			{
				length--;
			}
			yield return new BrokenWord(chars, startIndex, length);
			startIndex += length;
			lineLength = 1;
		}
	}

	internal static string Fold(FormatOptions format, string field, string value)
	{
		StringBuilder stringBuilder = new StringBuilder(value.Length);
		int num = field.Length + 2;
		int num2 = -1;
		stringBuilder.Append(' ');
		IEnumerable<string> enumerable = TokenizeText(value);
		foreach (string item in enumerable)
		{
			if (IsWhiteSpace(item[0]))
			{
				if (num + item.Length > format.MaxLineLength)
				{
					for (int i = 0; i < item.Length; i++)
					{
						if (num > format.MaxLineLength)
						{
							stringBuilder.Append(format.NewLine);
							num = 0;
						}
						stringBuilder.Append(item[i]);
						num++;
					}
				}
				else
				{
					num += item.Length;
					stringBuilder.Append(item);
				}
				num2 = stringBuilder.Length - 1;
				continue;
			}
			if (num2 != -1 && num + item.Length > format.MaxLineLength)
			{
				stringBuilder.Insert(num2, format.NewLine);
				num = 1;
				num2 = -1;
			}
			if (item.Length > format.MaxLineLength)
			{
				foreach (BrokenWord item2 in WordBreak(format, item, num))
				{
					if (num + item2.Length > format.MaxLineLength)
					{
						stringBuilder.Append(format.NewLine);
						stringBuilder.Append(' ');
						num = 1;
					}
					stringBuilder.Append(item2.Text, item2.StartIndex, item2.Length);
					num += item2.Length;
				}
			}
			else
			{
				num += item.Length;
				stringBuilder.Append(item);
			}
		}
		stringBuilder.Append(format.NewLine);
		return stringBuilder.ToString();
	}

	private static byte[] EncodeContentDisposition(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		ContentDisposition contentDisposition = ContentDisposition.Parse(options, value);
		string s = contentDisposition.Encode(format, encoding);
		return Encoding.UTF8.GetBytes(s);
	}

	private static byte[] EncodeContentType(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		ContentType contentType = ContentType.Parse(options, value);
		string s = contentType.Encode(format, encoding);
		return Encoding.UTF8.GetBytes(s);
	}

	private static byte[] EncodeUnstructuredHeader(ParserOptions options, FormatOptions format, Encoding encoding, string field, string value)
	{
		if (format.International)
		{
			string s = Fold(format, field, value);
			return Encoding.UTF8.GetBytes(s);
		}
		byte[] text = Rfc2047.EncodeText(format, encoding, value);
		return Rfc2047.FoldUnstructuredHeader(format, field, text);
	}

	protected virtual byte[] FormatRawValue(FormatOptions format, Encoding encoding, string value)
	{
		switch (Id)
		{
		case HeaderId.Bcc:
		case HeaderId.Cc:
		case HeaderId.DispositionNotificationTo:
		case HeaderId.From:
		case HeaderId.ReplyTo:
		case HeaderId.ResentBcc:
		case HeaderId.ResentCc:
		case HeaderId.ResentFrom:
		case HeaderId.ResentReplyTo:
		case HeaderId.ResentSender:
		case HeaderId.ResentTo:
		case HeaderId.Sender:
		case HeaderId.To:
			return EncodeAddressHeader(Options, format, encoding, Field, value);
		case HeaderId.Received:
			return EncodeReceivedHeader(Options, format, encoding, Field, value);
		case HeaderId.ContentId:
		case HeaderId.InReplyTo:
		case HeaderId.MessageId:
		case HeaderId.ResentMessageId:
			return EncodeMessageIdHeader(Options, format, encoding, Field, value);
		case HeaderId.References:
			return EncodeReferencesHeader(Options, format, encoding, Field, value);
		case HeaderId.ContentDisposition:
			return EncodeContentDisposition(Options, format, encoding, Field, value);
		case HeaderId.ContentType:
			return EncodeContentType(Options, format, encoding, Field, value);
		case HeaderId.ArcAuthenticationResults:
		case HeaderId.AuthenticationResults:
			return EncodeAuthenticationResultsHeader(Options, format, encoding, Field, value);
		case HeaderId.ArcMessageSignature:
		case HeaderId.ArcSeal:
		case HeaderId.DkimSignature:
			return EncodeDkimOrArcSignatureHeader(Options, format, encoding, Field, value);
		default:
			return EncodeUnstructuredHeader(Options, format, encoding, Field, value);
		}
	}

	internal byte[] GetRawValue(FormatOptions format)
	{
		if (format.International && !explicitRawValue)
		{
			if (textValue == null)
			{
				textValue = Unfold(Rfc2047.DecodeText(Options, rawValue));
			}
			return FormatRawValue(format, CharsetUtils.UTF8, textValue);
		}
		return rawValue;
	}

	public void SetValue(FormatOptions format, Encoding encoding, string value)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (encoding == null)
		{
			throw new ArgumentNullException("encoding");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		textValue = Unfold(value.Trim());
		rawValue = FormatRawValue(format, encoding, textValue);
		explicitRawValue = false;
		OnChanged();
	}

	public void SetValue(Encoding encoding, string value)
	{
		SetValue(FormatOptions.Default, encoding, value);
	}

	public void SetValue(FormatOptions format, string charset, string value)
	{
		if (format == null)
		{
			throw new ArgumentNullException("format");
		}
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		Encoding encoding = CharsetUtils.GetEncoding(charset);
		SetValue(format, encoding, value);
	}

	public void SetValue(string charset, string value)
	{
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		Encoding encoding = CharsetUtils.GetEncoding(charset);
		SetValue(FormatOptions.Default, encoding, value);
	}

	public void SetRawValue(byte[] value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (value.Length == 0 || value[value.Length - 1] != 10)
		{
			throw new ArgumentException("The raw value MUST end with a new-line character.", "value");
		}
		explicitRawValue = true;
		rawValue = value;
		textValue = null;
		OnChanged();
	}

	private void OnChanged()
	{
		if (this.Changed != null)
		{
			this.Changed(this, EventArgs.Empty);
		}
	}

	public override string ToString()
	{
		if (!IsInvalid)
		{
			return Field + ": " + Value;
		}
		return Field;
	}

	public unsafe static string Unfold(string text)
	{
		int i = 0;
		if (text == null)
		{
			return string.Empty;
		}
		for (; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		if (i == text.Length)
		{
			return string.Empty;
		}
		int num = i;
		int num2 = i;
		while (i < text.Length)
		{
			if (!char.IsWhiteSpace(text[i++]))
			{
				num2 = i;
			}
		}
		int num3 = num2 - num;
		char[] array = new char[num3];
		fixed (char* ptr = array)
		{
			char* ptr2 = ptr;
			for (i = num; i < num2; i++)
			{
				if (text[i] != '\r' && text[i] != '\n')
				{
					*(ptr2++) = text[i];
				}
			}
			num3 = (int)(ptr2 - ptr);
		}
		return new string(array, 0, num3);
	}

	private static bool IsAsciiAtom(byte c)
	{
		return c.IsAsciiAtom();
	}

	private static bool IsControl(byte c)
	{
		return c.IsCtrl();
	}

	private static bool IsBlank(byte c)
	{
		return c.IsBlank();
	}

	internal unsafe static bool TryParse(ParserOptions options, byte* input, int length, bool strict, out Header header)
	{
		byte* ptr = input + length;
		byte* ptr2 = input;
		byte* ptr3 = input;
		bool invalid = false;
		if (strict)
		{
			for (; ptr3 < ptr && IsAsciiAtom(*ptr3); ptr3++)
			{
			}
		}
		else
		{
			for (; ptr3 < ptr && *ptr3 != 58 && !IsControl(*ptr3); ptr3++)
			{
			}
		}
		for (; ptr3 < ptr && IsBlank(*ptr3); ptr3++)
		{
		}
		if (ptr3 == ptr || *ptr3 != 58)
		{
			if (strict)
			{
				header = null;
				return false;
			}
			invalid = true;
			ptr3 = ptr;
		}
		byte[] array = new byte[(int)(ptr3 - ptr2)];
		fixed (byte* ptr4 = array)
		{
			byte* ptr5 = ptr4;
			while (ptr2 < ptr3)
			{
				*(ptr5++) = *(ptr2++);
			}
		}
		byte[] array2;
		if (ptr3 < ptr)
		{
			ptr3++;
			int num = (int)(ptr - ptr3);
			if (strict && ptr[-1] != 10)
			{
				num += FormatOptions.Default.NewLine.Length;
			}
			array2 = new byte[num];
			fixed (byte* ptr6 = array2)
			{
				byte* ptr7 = ptr6;
				while (ptr3 < ptr)
				{
					*(ptr7++) = *(ptr3++);
				}
				if (strict && ptr[-1] != 10)
				{
					byte[] newLineBytes = FormatOptions.Default.NewLineBytes;
					for (int i = 0; i < newLineBytes.Length; i++)
					{
						*(ptr7++) = newLineBytes[i];
					}
				}
			}
		}
		else
		{
			array2 = new byte[0];
		}
		header = new Header(options, array, array2, invalid);
		return true;
	}

	public unsafe static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, int length, out Header header)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex, length);
		fixed (byte* ptr = buffer)
		{
			return TryParse(options.Clone(), ptr + startIndex, length, strict: true, out header);
		}
	}

	public static bool TryParse(byte[] buffer, int startIndex, int length, out Header header)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, length, out header);
	}

	public unsafe static bool TryParse(ParserOptions options, byte[] buffer, int startIndex, out Header header)
	{
		ParseUtils.ValidateArguments(options, buffer, startIndex);
		int length = buffer.Length - startIndex;
		fixed (byte* ptr = buffer)
		{
			return TryParse(options.Clone(), ptr + startIndex, length, strict: true, out header);
		}
	}

	public static bool TryParse(byte[] buffer, int startIndex, out Header header)
	{
		return TryParse(ParserOptions.Default, buffer, startIndex, out header);
	}

	public static bool TryParse(ParserOptions options, byte[] buffer, out Header header)
	{
		return TryParse(options, buffer, 0, out header);
	}

	public static bool TryParse(byte[] buffer, out Header header)
	{
		return TryParse(ParserOptions.Default, buffer, out header);
	}

	public unsafe static bool TryParse(ParserOptions options, string text, out Header header)
	{
		ParseUtils.ValidateArguments(options, text);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		fixed (byte* input = bytes)
		{
			return TryParse(options.Clone(), input, bytes.Length, strict: true, out header);
		}
	}

	public static bool TryParse(string text, out Header header)
	{
		return TryParse(ParserOptions.Default, text, out header);
	}
}
