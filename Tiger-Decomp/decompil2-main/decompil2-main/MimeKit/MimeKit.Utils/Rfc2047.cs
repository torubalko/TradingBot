using System;
using System.Collections.Generic;
using System.Text;
using MimeKit.Encodings;

namespace MimeKit.Utils;

public static class Rfc2047
{
	private class Token
	{
		public ContentEncoding Encoding;

		public string CharsetName;

		public string CultureName;

		public int CodePage;

		public int StartIndex;

		public int Length;

		public bool Is8bit;

		public string CharsetCulture
		{
			get
			{
				if (!string.IsNullOrEmpty(CultureName))
				{
					return CharsetName + "*" + CultureName;
				}
				return CharsetName;
			}
		}

		public Token(string charset, string culture, ContentEncoding encoding, int startIndex, int length)
		{
			CodePage = CharsetUtils.GetCodePage(charset);
			CharsetName = charset;
			CultureName = culture;
			Encoding = encoding;
			StartIndex = startIndex;
			Length = length;
		}

		public Token(int startIndex, int length)
		{
			Encoding = ContentEncoding.Default;
			StartIndex = startIndex;
			Length = length;
		}
	}

	private enum WordType
	{
		Atom,
		QuotedString,
		EncodedWord
	}

	private enum WordEncoding
	{
		Ascii,
		Latin1,
		UserSpecified
	}

	private class Word
	{
		public WordType Type;

		public int StartIndex;

		public int CharCount;

		public WordEncoding Encoding;

		public int ByteCount;

		public int EncodeCount;

		public int QuotedPairs;

		public Word()
		{
			Type = WordType.Atom;
		}

		public void CopyTo(Word word)
		{
			word.EncodeCount = EncodeCount;
			word.QuotedPairs = QuotedPairs;
			word.StartIndex = StartIndex;
			word.CharCount = CharCount;
			word.ByteCount = ByteCount;
			word.Encoding = Encoding;
			word.Type = Type;
		}
	}

	private static bool IsAscii(byte c)
	{
		return c < 128;
	}

	private static bool IsAsciiAtom(byte c)
	{
		return c.IsAsciiAtom();
	}

	private static bool IsAtom(byte c)
	{
		return c.IsAtom();
	}

	private static bool IsBbQq(byte c)
	{
		if (c != 66 && c != 98 && c != 81)
		{
			return c == 113;
		}
		return true;
	}

	private static bool IsLwsp(byte c)
	{
		return c.IsWhitespace();
	}

	private unsafe static bool TryGetEncodedWordToken(byte* input, byte* word, int length, out Token token)
	{
		token = null;
		if (length < 7)
		{
			return false;
		}
		byte* ptr = word + length - 2;
		byte* ptr2 = word;
		if (*(ptr2++) != 61 || *(ptr2++) != 63 || *(ptr++) != 63 || *(ptr++) != 61)
		{
			return false;
		}
		ptr -= 2;
		if (*ptr2 == 63 || *ptr2 == 42)
		{
			return false;
		}
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (; *ptr2 != 63 && *ptr2 != 42; ptr2++)
		{
			if (!IsAsciiAtom(*ptr2))
			{
				return false;
			}
			stringBuilder.Append((char)(*ptr2));
		}
		if (*ptr2 == 42)
		{
			for (ptr2++; *ptr2 != 63; ptr2++)
			{
				if (!IsAsciiAtom(*ptr2))
				{
					return false;
				}
				stringBuilder2.Append((char)(*ptr2));
			}
		}
		ptr2++;
		ContentEncoding encoding;
		if (*ptr2 == 66 || *ptr2 == 98)
		{
			encoding = ContentEncoding.Base64;
		}
		else
		{
			if (*ptr2 != 81 && *ptr2 != 113)
			{
				return false;
			}
			encoding = ContentEncoding.QuotedPrintable;
		}
		ptr2++;
		if (*ptr2 != 63 || ptr2 == ptr)
		{
			return false;
		}
		ptr2++;
		int startIndex = (int)(ptr2 - input);
		int length2 = (int)(ptr - ptr2);
		token = new Token(stringBuilder.ToString(), stringBuilder2.ToString(), encoding, startIndex, length2);
		return true;
	}

	private unsafe static IList<Token> TokenizePhrase(ParserOptions options, byte* inbuf, int startIndex, int length)
	{
		byte* ptr = inbuf + startIndex;
		byte* ptr2 = ptr + length;
		List<Token> list = new List<Token>();
		bool flag = false;
		Token token = null;
		Token token2 = null;
		while (ptr < ptr2)
		{
			byte* ptr3 = ptr;
			for (; ptr < ptr2 && IsLwsp(*ptr); ptr++)
			{
			}
			token2 = ((ptr <= ptr3) ? null : new Token((int)(ptr3 - inbuf), (int)(ptr - ptr3)));
			byte* ptr4 = ptr;
			bool flag2 = true;
			if (ptr < ptr2 && IsAsciiAtom(*ptr))
			{
				if (options.Rfc2047ComplianceMode == RfcComplianceMode.Loose)
				{
					bool flag3 = false;
					if (ptr + 2 < ptr2 && *ptr == 61 && ptr[1] == 63)
					{
						for (ptr += 2; ptr < ptr2 && *ptr != 63; ptr++)
						{
							flag2 = flag2 && IsAscii(*ptr);
						}
						if (ptr + 3 >= ptr2 || *ptr != 63 || !IsBbQq(ptr[1]) || ptr[2] != 63)
						{
							flag2 = true;
						}
						else
						{
							for (ptr += 3; ptr + 2 < ptr2 && (*ptr != 63 || ptr[1] != 61); ptr++)
							{
								flag2 = flag2 && IsAscii(*ptr);
							}
							if (ptr + 2 > ptr2 || *ptr != 63 || ptr[1] != 61)
							{
								ptr = ptr4 + 2;
								flag2 = true;
							}
							else
							{
								flag3 = true;
								ptr += 2;
							}
						}
					}
					if (!flag3)
					{
						for (; ptr < ptr2 && IsAtom(*ptr) && (ptr + 2 >= ptr2 || *ptr != 61 || ptr[1] != 63); ptr++)
						{
							flag2 = flag2 && IsAscii(*ptr);
						}
					}
				}
				else
				{
					for (; ptr < ptr2 && IsAsciiAtom(*ptr); ptr++)
					{
					}
				}
				int length2 = (int)(ptr - ptr4);
				if (TryGetEncodedWordToken(inbuf, ptr4, length2, out token))
				{
					if (!flag && token2 != null)
					{
						list.Add(token2);
					}
					list.Add(token);
					flag = true;
					continue;
				}
				if (token2 != null)
				{
					list.Add(token2);
				}
				token = new Token((int)(ptr4 - inbuf), length2);
				token.Is8bit = !flag2;
				list.Add(token);
				flag = false;
			}
			else
			{
				if (token2 != null)
				{
					list.Add(token2);
				}
				flag2 = true;
				for (; ptr < ptr2 && !IsLwsp(*ptr) && !IsAsciiAtom(*ptr); ptr++)
				{
					flag2 = flag2 && IsAscii(*ptr);
				}
				token = new Token((int)(ptr4 - inbuf), (int)(ptr - ptr4));
				token.Is8bit = !flag2;
				list.Add(token);
				flag = false;
			}
		}
		return list;
	}

	private unsafe static IList<Token> TokenizeText(ParserOptions options, byte* inbuf, int startIndex, int length)
	{
		byte* ptr = inbuf + startIndex;
		byte* ptr2 = ptr + length;
		List<Token> list = new List<Token>();
		bool flag = false;
		Token token = null;
		Token token2 = null;
		while (ptr < ptr2)
		{
			byte* ptr3 = ptr;
			for (; ptr < ptr2 && IsLwsp(*ptr); ptr++)
			{
			}
			token2 = ((ptr <= ptr3) ? null : new Token((int)(ptr3 - inbuf), (int)(ptr - ptr3)));
			if (ptr < ptr2)
			{
				byte* ptr4 = ptr;
				bool flag2 = true;
				if (options.Rfc2047ComplianceMode == RfcComplianceMode.Loose)
				{
					bool flag3 = false;
					if (ptr + 2 < ptr2 && *ptr == 61 && ptr[1] == 63)
					{
						for (ptr += 2; ptr < ptr2 && *ptr != 63; ptr++)
						{
							flag2 = flag2 && IsAscii(*ptr);
						}
						if (ptr + 3 >= ptr2 || *ptr != 63 || !IsBbQq(ptr[1]) || ptr[2] != 63)
						{
							flag2 = true;
						}
						else
						{
							for (ptr += 3; ptr + 2 < ptr2 && (*ptr != 63 || ptr[1] != 61); ptr++)
							{
								flag2 = flag2 && IsAscii(*ptr);
							}
							if (ptr + 2 > ptr2 || *ptr != 63 || ptr[1] != 61)
							{
								ptr = ptr4 + 2;
								flag2 = true;
							}
							else
							{
								flag3 = true;
								ptr += 2;
							}
						}
					}
					if (!flag3)
					{
						for (; ptr < ptr2 && !IsLwsp(*ptr) && (ptr + 2 >= ptr2 || *ptr != 61 || ptr[1] != 63); ptr++)
						{
							flag2 = flag2 && IsAscii(*ptr);
						}
					}
				}
				else
				{
					for (; ptr < ptr2 && !IsLwsp(*ptr); ptr++)
					{
						flag2 = flag2 && IsAscii(*ptr);
					}
				}
				int length2 = (int)(ptr - ptr4);
				if (TryGetEncodedWordToken(inbuf, ptr4, length2, out token))
				{
					if (!flag && token2 != null)
					{
						list.Add(token2);
					}
					list.Add(token);
					flag = true;
					continue;
				}
				if (token2 != null)
				{
					list.Add(token2);
				}
				token = new Token((int)(ptr4 - inbuf), length2);
				token.Is8bit = !flag2;
				list.Add(token);
				flag = false;
				continue;
			}
			if (token2 != null)
			{
				list.Add(token2);
			}
			break;
		}
		return list;
	}

	private unsafe static int DecodeToken(Token token, IMimeDecoder decoder, byte* input, byte* output)
	{
		byte* input2 = input + token.StartIndex;
		return decoder.Decode(input2, token.Length, output);
	}

	private unsafe static string DecodeTokens(ParserOptions options, IList<Token> tokens, byte[] input, byte* inbuf, int length)
	{
		StringBuilder stringBuilder = new StringBuilder(length);
		QuotedPrintableDecoder quotedPrintableDecoder = new QuotedPrintableDecoder(rfc2047: true);
		Base64Decoder base64Decoder = new Base64Decoder();
		byte[] array = new byte[length];
		fixed (byte* ptr = array)
		{
			for (int i = 0; i < tokens.Count; i++)
			{
				Token token = tokens[i];
				int charCount;
				if (token.Encoding != ContentEncoding.Default)
				{
					ContentEncoding encoding = token.Encoding;
					int codePage = token.CodePage;
					int j;
					for (j = i + 1; j < tokens.Count && tokens[j].Encoding == encoding && tokens[j].CodePage == codePage; j++)
					{
					}
					IMimeDecoder mimeDecoder = ((encoding != ContentEncoding.Base64) ? ((IMimeDecoder)quotedPrintableDecoder) : ((IMimeDecoder)base64Decoder));
					byte* ptr2 = ptr;
					int num = 0;
					do
					{
						charCount = DecodeToken(tokens[i], mimeDecoder, inbuf, ptr2);
						ptr2 += charCount;
						num += charCount;
						i++;
					}
					while (i < j);
					mimeDecoder.Reset();
					i--;
					char[] value = CharsetUtils.ConvertToUnicode(options, codePage, array, 0, num, out charCount);
					stringBuilder.Append(value, 0, charCount);
				}
				else if (token.Is8bit)
				{
					char[] value2 = CharsetUtils.ConvertToUnicode(options, input, token.StartIndex, token.Length, out charCount);
					stringBuilder.Append(value2, 0, charCount);
				}
				else
				{
					byte* ptr3 = inbuf + token.StartIndex;
					byte* ptr4 = ptr3 + token.Length;
					while (ptr3 < ptr4)
					{
						stringBuilder.Append((char)(*(ptr3++)));
					}
				}
			}
		}
		return stringBuilder.ToString();
	}

	internal unsafe static string DecodePhrase(ParserOptions options, byte[] phrase, int startIndex, int count, out int codepage)
	{
		codepage = Encoding.UTF8.CodePage;
		if (count == 0)
		{
			return string.Empty;
		}
		fixed (byte* inbuf = phrase)
		{
			IList<Token> list = TokenizePhrase(options, inbuf, startIndex, count);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (Token item in list)
			{
				if (item.CodePage != 0)
				{
					if (!dictionary.ContainsKey(item.CodePage))
					{
						dictionary.Add(item.CodePage, 1);
					}
					else
					{
						dictionary[item.CodePage]++;
					}
				}
			}
			int num = 0;
			foreach (KeyValuePair<int, int> item2 in dictionary)
			{
				if (item2.Value > num)
				{
					codepage = item2.Key;
					num = item2.Value;
				}
			}
			return DecodeTokens(options, list, phrase, inbuf, count);
		}
	}

	public unsafe static string DecodePhrase(ParserOptions options, byte[] phrase, int startIndex, int count)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (phrase == null)
		{
			throw new ArgumentNullException("phrase");
		}
		if (startIndex < 0 || startIndex > phrase.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || startIndex + count > phrase.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return string.Empty;
		}
		fixed (byte* inbuf = phrase)
		{
			IList<Token> tokens = TokenizePhrase(options, inbuf, startIndex, count);
			return DecodeTokens(options, tokens, phrase, inbuf, count);
		}
	}

	public static string DecodePhrase(byte[] phrase, int startIndex, int count)
	{
		return DecodePhrase(ParserOptions.Default, phrase, startIndex, count);
	}

	public static string DecodePhrase(ParserOptions options, byte[] phrase)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (phrase == null)
		{
			throw new ArgumentNullException("phrase");
		}
		return DecodePhrase(options, phrase, 0, phrase.Length);
	}

	public static string DecodePhrase(byte[] phrase)
	{
		if (phrase == null)
		{
			throw new ArgumentNullException("phrase");
		}
		return DecodePhrase(phrase, 0, phrase.Length);
	}

	internal unsafe static string DecodeText(ParserOptions options, byte[] text, int startIndex, int count, out int codepage)
	{
		codepage = Encoding.UTF8.CodePage;
		if (count == 0)
		{
			return string.Empty;
		}
		fixed (byte* inbuf = text)
		{
			IList<Token> list = TokenizeText(options, inbuf, startIndex, count);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			foreach (Token item in list)
			{
				if (item.CodePage != 0)
				{
					if (!dictionary.ContainsKey(item.CodePage))
					{
						dictionary.Add(item.CodePage, 1);
					}
					else
					{
						dictionary[item.CodePage]++;
					}
				}
			}
			int num = 0;
			foreach (KeyValuePair<int, int> item2 in dictionary)
			{
				if (item2.Value > num)
				{
					codepage = item2.Key;
					num = item2.Value;
				}
			}
			return DecodeTokens(options, list, text, inbuf, count);
		}
	}

	public unsafe static string DecodeText(ParserOptions options, byte[] text, int startIndex, int count)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (startIndex < 0 || startIndex > text.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || startIndex + count > text.Length)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (count == 0)
		{
			return string.Empty;
		}
		fixed (byte* inbuf = text)
		{
			IList<Token> tokens = TokenizeText(options, inbuf, startIndex, count);
			return DecodeTokens(options, tokens, text, inbuf, count);
		}
	}

	public static string DecodeText(byte[] text, int startIndex, int count)
	{
		return DecodeText(ParserOptions.Default, text, startIndex, count);
	}

	public static string DecodeText(ParserOptions options, byte[] text)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return DecodeText(options, text, 0, text.Length);
	}

	public static string DecodeText(byte[] text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return DecodeText(text, 0, text.Length);
	}

	private static byte[] FoldTokens(FormatOptions options, IList<Token> tokens, string field, byte[] input)
	{
		StringBuilder stringBuilder = new StringBuilder(input.Length + input.Length / options.MaxLineLength * 2 + 2);
		int num = field.Length + 2;
		bool flag = true;
		int num2 = 0;
		int num3 = 0;
		stringBuilder.Append(' ');
		for (int i = 0; i < tokens.Count; i++)
		{
			Token token = tokens[i];
			if (input[token.StartIndex].IsWhitespace())
			{
				for (int j = token.StartIndex; j < token.StartIndex + token.Length; j++)
				{
					if (input[j] != 13)
					{
						num2 = stringBuilder.Length;
						if (input[j] == 9)
						{
							num3 = stringBuilder.Length;
						}
						if (input[j] == 10)
						{
							stringBuilder.Append(options.NewLine);
							num2 = (num3 = 0);
							num = 0;
						}
						else
						{
							stringBuilder.Append((char)input[j]);
							num++;
						}
					}
				}
				if (num == 0 && i + 1 < tokens.Count)
				{
					stringBuilder.Append(' ');
					num = 1;
				}
				flag = false;
			}
			else if (token.Encoding != ContentEncoding.Default)
			{
				string charsetCulture = token.CharsetCulture;
				if (num + token.Length + charsetCulture.Length + 7 > options.MaxLineLength)
				{
					if (num3 != 0)
					{
						stringBuilder.Insert(num3, options.NewLine);
						num = num2 - num3 + 1;
					}
					else if (num2 != 0)
					{
						stringBuilder.Insert(num2, options.NewLine);
						num = 1;
					}
					else if (num > 1 && !flag)
					{
						stringBuilder.Append(options.NewLine);
						stringBuilder.Append(' ');
						num = 1;
					}
				}
				stringBuilder.AppendFormat("=?{0}?{1}?", charsetCulture, (token.Encoding == ContentEncoding.Base64) ? 'b' : 'q');
				for (int k = token.StartIndex; k < token.StartIndex + token.Length; k++)
				{
					stringBuilder.Append((char)input[k]);
				}
				stringBuilder.Append("?=");
				num += token.Length + charsetCulture.Length + 7;
				flag = false;
				num2 = 0;
				num3 = 0;
			}
			else if (num + token.Length > options.MaxLineLength)
			{
				if (num3 != 0)
				{
					stringBuilder.Insert(num3, options.NewLine);
					num = num2 - num3 + 1;
				}
				else if (num2 != 0)
				{
					stringBuilder.Insert(num2, options.NewLine);
					num = 1;
				}
				else if (num > 1 && !flag)
				{
					stringBuilder.Append(options.NewLine);
					stringBuilder.Append(' ');
					num = 1;
				}
				if (token.Length >= options.MaxLineLength)
				{
					for (int l = token.StartIndex; l < token.StartIndex + token.Length; l++)
					{
						if (num >= options.MaxLineLength)
						{
							stringBuilder.Append(options.NewLine);
							stringBuilder.Append(' ');
							num = 1;
						}
						stringBuilder.Append((char)input[l]);
						num++;
					}
				}
				else
				{
					for (int m = token.StartIndex; m < token.StartIndex + token.Length; m++)
					{
						stringBuilder.Append((char)input[m]);
					}
					num += token.Length;
				}
				flag = false;
				num2 = 0;
				num3 = 0;
			}
			else
			{
				for (int n = token.StartIndex; n < token.StartIndex + token.Length; n++)
				{
					stringBuilder.Append((char)input[n]);
				}
				num += token.Length;
				flag = false;
				num2 = 0;
				num3 = 0;
			}
		}
		if (stringBuilder[stringBuilder.Length - 1] != '\n')
		{
			stringBuilder.Append(options.NewLine);
		}
		return Encoding.ASCII.GetBytes(stringBuilder.ToString());
	}

	internal unsafe static byte[] FoldUnstructuredHeader(FormatOptions options, string field, byte[] text)
	{
		fixed (byte* inbuf = text)
		{
			IList<Token> tokens = TokenizeText(ParserOptions.Default, inbuf, 0, text.Length);
			return FoldTokens(options, tokens, field, text);
		}
	}

	private static byte[] CharsetConvert(Encoding charset, char[] word, int length, out int converted)
	{
		Encoder encoder = charset.GetEncoder();
		int byteCount = encoder.GetByteCount(word, 0, length, flush: true);
		byte[] array = new byte[byteCount];
		converted = encoder.GetBytes(word, 0, length, array, 0, flush: true);
		return array;
	}

	private static ContentEncoding GetBestContentEncoding(byte[] text, int startIndex, int length)
	{
		int num = 0;
		for (int i = startIndex; i < startIndex + length; i++)
		{
			if (text[i] > 127)
			{
				num++;
			}
		}
		if ((double)num < (double)length * 0.17)
		{
			return ContentEncoding.QuotedPrintable;
		}
		return ContentEncoding.Base64;
	}

	private static bool CharsetRequiresBase64(Encoding encoding)
	{
		if (encoding.CodePage != 50220)
		{
			return encoding.CodePage == 50222;
		}
		return true;
	}

	internal static int AppendEncodedWord(StringBuilder str, Encoding charset, string text, int startIndex, int length, QEncodeMode mode)
	{
		int length2 = str.Length;
		char[] array = new char[length];
		text.CopyTo(startIndex, array, 0, length);
		byte[] array2;
		int converted;
		try
		{
			array2 = CharsetConvert(charset, array, length, out converted);
		}
		catch
		{
			charset = Encoding.UTF8;
			array2 = CharsetConvert(charset, array, length, out converted);
		}
		IMimeEncoder mimeEncoder;
		char c;
		if (CharsetRequiresBase64(charset) || GetBestContentEncoding(array2, 0, converted) == ContentEncoding.Base64)
		{
			mimeEncoder = new Base64Encoder(rfc2047: true);
			c = 'b';
		}
		else
		{
			mimeEncoder = new QEncoder(mode);
			c = 'q';
		}
		byte[] array3 = new byte[mimeEncoder.EstimateOutputLength(converted)];
		converted = mimeEncoder.Flush(array2, 0, converted, array3);
		str.AppendFormat("=?{0}?{1}?", CharsetUtils.GetMimeCharset(charset), c);
		for (int i = 0; i < converted; i++)
		{
			str.Append((char)array3[i]);
		}
		str.Append("?=");
		return str.Length - length2;
	}

	private static void AppendQuoted(StringBuilder str, string text, int startIndex, int length)
	{
		int num = startIndex + length;
		str.Append('"');
		for (int i = startIndex; i < num; i++)
		{
			char c = text[i];
			if (c == '"' || c == '\\')
			{
				str.Append('\\');
			}
			str.Append(c);
		}
		str.Append('"');
	}

	private static bool IsAtom(char c)
	{
		return ((byte)c).IsAtom();
	}

	private static bool IsBlank(char c)
	{
		if (c != ' ')
		{
			return c == '\t';
		}
		return true;
	}

	private static bool IsCtrl(char c)
	{
		return ((byte)c).IsCtrl();
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

	private static int EstimateEncodedWordLength(Encoding charset, int byteCount, int encodeCount)
	{
		return EstimateEncodedWordLength(CharsetUtils.GetMimeCharset(charset), byteCount, encodeCount);
	}

	private static bool ExceedsMaxLineLength(FormatOptions options, Encoding charset, Word word)
	{
		return word.Type switch
		{
			WordType.EncodedWord => word.Encoding switch
			{
				WordEncoding.Latin1 => EstimateEncodedWordLength("iso-8859-1", word.ByteCount, word.EncodeCount), 
				WordEncoding.Ascii => EstimateEncodedWordLength("us-ascii", word.ByteCount, word.EncodeCount), 
				_ => EstimateEncodedWordLength(charset, word.ByteCount, word.EncodeCount), 
			}, 
			WordType.QuotedString => word.ByteCount + word.QuotedPairs + 2, 
			_ => word.ByteCount, 
		} + 1 >= options.MaxLineLength;
	}

	private static IList<Word> GetRfc822Words(FormatOptions options, Encoding charset, string text, bool phrase)
	{
		Encoder encoder = charset.GetEncoder();
		List<Word> list = new List<Word>();
		char[] array = new char[2];
		Word word = new Word();
		Word word2 = new Word();
		int num = 0;
		while (num < text.Length)
		{
			char c = text[num++];
			if (c < 'Ā' && IsBlank(c))
			{
				if (word2.ByteCount > 0)
				{
					list.Add(word2);
					word2 = new Word();
				}
				word2.StartIndex = num;
				continue;
			}
			word2.CopyTo(word);
			int num2;
			if (c < '\u007f')
			{
				if (IsCtrl(c))
				{
					word2.Encoding = (WordEncoding)Math.Max((int)word2.Encoding, 1);
					word2.Type = WordType.EncodedWord;
					word2.EncodeCount++;
				}
				else if (phrase && !IsAtom(c) && word2.Type == WordType.Atom)
				{
					word2.Type = WordType.QuotedString;
				}
				if (c == '"' || c == '\\')
				{
					word2.QuotedPairs++;
				}
				word2.ByteCount++;
				word2.CharCount++;
				num2 = 1;
			}
			else if (c < 'Ā')
			{
				word2.Encoding = (WordEncoding)Math.Max((int)word2.Encoding, 1);
				word2.Type = WordType.EncodedWord;
				word2.EncodeCount++;
				word2.ByteCount++;
				word2.CharCount++;
				num2 = 1;
			}
			else
			{
				if (char.IsSurrogatePair(text, num - 1))
				{
					array[1] = text[num++];
					num2 = 2;
				}
				else
				{
					num2 = 1;
				}
				array[0] = c;
				int num3;
				try
				{
					num3 = encoder.GetByteCount(array, 0, num2, flush: true);
				}
				catch
				{
					num3 = 3 * num2;
				}
				word2.Encoding = WordEncoding.UserSpecified;
				word2.Type = WordType.EncodedWord;
				word2.CharCount += num2;
				word2.EncodeCount += num3;
				word2.ByteCount += num3;
			}
			if (ExceedsMaxLineLength(options, charset, word2))
			{
				word.CopyTo(word2);
				num -= num2;
				if (word2.Type == WordType.Atom)
				{
					word2.Type = WordType.EncodedWord;
					int num3 = "us-ascii".Length + 7;
					word2.CharCount -= num3;
					word2.ByteCount -= num3;
					num -= num3;
				}
				list.Add(word2);
				word.Type = word2.Type;
				word2 = new Word();
				word2.Type = word.Type;
				word2.StartIndex = num;
			}
		}
		if (word2.ByteCount > 0)
		{
			list.Add(word2);
		}
		return list;
	}

	private static bool ShouldMergeWords(FormatOptions options, Encoding charset, IList<Word> words, Word word, int i)
	{
		Word word2 = words[i];
		int num = word2.StartIndex - (word.StartIndex + word.CharCount);
		int num2 = word.ByteCount + num + word2.ByteCount;
		int encodeCount = word.EncodeCount + word2.EncodeCount;
		int num3 = word.QuotedPairs + word2.QuotedPairs;
		switch (word.Type)
		{
		case WordType.Atom:
			if (word2.Type == WordType.EncodedWord)
			{
				return false;
			}
			return num2 + 1 < options.MaxLineLength;
		case WordType.QuotedString:
			if (word2.Type == WordType.EncodedWord)
			{
				return false;
			}
			return num2 + num3 + 3 < options.MaxLineLength;
		case WordType.EncodedWord:
			if (word2.Type == WordType.Atom)
			{
				bool flag = false;
				int num4 = 0;
				for (int j = i + 1; j < words.Count; j++)
				{
					if (num4 >= 3)
					{
						break;
					}
					if (words[j].Type != WordType.Atom)
					{
						flag = true;
						break;
					}
					num4++;
				}
				if (!flag)
				{
					return false;
				}
			}
			if (word2.Type == WordType.QuotedString)
			{
				return false;
			}
			return (WordEncoding)Math.Max((int)word.Encoding, (int)word2.Encoding) switch
			{
				WordEncoding.Latin1 => EstimateEncodedWordLength("iso-8859-1", num2, encodeCount), 
				WordEncoding.Ascii => EstimateEncodedWordLength("us-ascii", num2, encodeCount), 
				_ => EstimateEncodedWordLength(charset, num2, encodeCount), 
			} + 1 < options.MaxLineLength;
		default:
			return false;
		}
	}

	private static IList<Word> Merge(FormatOptions options, Encoding charset, IList<Word> words)
	{
		if (words.Count < 2)
		{
			return words;
		}
		List<Word> list = new List<Word>();
		Word word = words[0];
		list.Add(word);
		for (int i = 1; i < words.Count; i++)
		{
			Word word2 = words[i];
			if (word.Type != WordType.Atom && word.Type == word2.Type)
			{
				WordEncoding wordEncoding = (WordEncoding)Math.Max((int)word.Encoding, (int)word2.Encoding);
				int num = word2.StartIndex - (word.StartIndex + word.CharCount);
				int num2 = word.ByteCount + num + word2.ByteCount;
				int encodeCount = word.EncodeCount + word2.EncodeCount;
				int num3 = word.QuotedPairs + word2.QuotedPairs;
				int num4 = ((word.Type != WordType.EncodedWord) ? (num2 + num3 + 2) : (wordEncoding switch
				{
					WordEncoding.Latin1 => EstimateEncodedWordLength("iso-8859-1", num2, encodeCount), 
					WordEncoding.Ascii => EstimateEncodedWordLength("us-ascii", num2, encodeCount), 
					_ => EstimateEncodedWordLength(charset, num2, encodeCount), 
				}));
				if (num4 + 1 < options.MaxLineLength)
				{
					word.CharCount = word2.StartIndex + word2.CharCount - word.StartIndex;
					word.ByteCount = num2;
					word.EncodeCount = encodeCount;
					word.QuotedPairs = num3;
					word.Encoding = wordEncoding;
					continue;
				}
			}
			list.Add(word2);
			word = word2;
		}
		words = list;
		list = new List<Word>();
		word = words[0];
		list.Add(word);
		for (int j = 1; j < words.Count; j++)
		{
			Word word2 = words[j];
			if (ShouldMergeWords(options, charset, words, word, j))
			{
				int num = word2.StartIndex - (word.StartIndex + word.CharCount);
				word.Type = (WordType)Math.Max((int)word.Type, (int)word2.Type);
				word.CharCount = word2.StartIndex + word2.CharCount - word.StartIndex;
				word.ByteCount = word.ByteCount + num + word2.ByteCount;
				word.Encoding = (WordEncoding)Math.Max((int)word.Encoding, (int)word2.Encoding);
				word.EncodeCount += word2.EncodeCount;
				word.QuotedPairs += word2.QuotedPairs;
			}
			else
			{
				list.Add(word2);
				word = word2;
			}
		}
		return list;
	}

	private static byte[] Encode(FormatOptions options, Encoding charset, string text, bool phrase)
	{
		QEncodeMode mode = ((!phrase) ? QEncodeMode.Text : QEncodeMode.Phrase);
		IList<Word> list = Merge(options, charset, GetRfc822Words(options, charset, text, phrase));
		StringBuilder stringBuilder = new StringBuilder();
		Word word = null;
		if (!options.AllowMixedHeaderCharsets)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Type == WordType.EncodedWord)
				{
					list[i].Encoding = WordEncoding.UserSpecified;
				}
			}
		}
		foreach (Word item in list)
		{
			if (word != null && (word.Type != WordType.EncodedWord || item.Type != WordType.EncodedWord))
			{
				int num = word.StartIndex + word.CharCount;
				int count = item.StartIndex - num;
				stringBuilder.Append(text, num, count);
			}
			switch (item.Type)
			{
			case WordType.Atom:
				stringBuilder.Append(text, item.StartIndex, item.CharCount);
				break;
			case WordType.QuotedString:
				AppendQuoted(stringBuilder, text, item.StartIndex, item.CharCount);
				break;
			case WordType.EncodedWord:
			{
				int num;
				int count;
				if (word != null && word.Type == WordType.EncodedWord)
				{
					num = word.StartIndex + word.CharCount;
					count = item.StartIndex + item.CharCount - num;
					stringBuilder.Append(phrase ? '\t' : ' ');
				}
				else
				{
					num = item.StartIndex;
					count = item.CharCount;
				}
				switch (item.Encoding)
				{
				case WordEncoding.Ascii:
					AppendEncodedWord(stringBuilder, Encoding.ASCII, text, num, count, mode);
					break;
				case WordEncoding.Latin1:
					AppendEncodedWord(stringBuilder, CharsetUtils.Latin1, text, num, count, mode);
					break;
				default:
					AppendEncodedWord(stringBuilder, charset, text, num, count, mode);
					break;
				}
				break;
			}
			}
			word = item;
		}
		byte[] array = new byte[stringBuilder.Length];
		for (int j = 0; j < stringBuilder.Length; j++)
		{
			array[j] = (byte)stringBuilder[j];
		}
		return array;
	}

	public static byte[] EncodePhrase(FormatOptions options, Encoding charset, string phrase)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (phrase == null)
		{
			throw new ArgumentNullException("phrase");
		}
		return Encode(options, charset, phrase, phrase: true);
	}

	public static byte[] EncodePhrase(Encoding charset, string phrase)
	{
		return EncodePhrase(FormatOptions.Default, charset, phrase);
	}

	public static byte[] EncodeText(FormatOptions options, Encoding charset, string text)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (charset == null)
		{
			throw new ArgumentNullException("charset");
		}
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		return Encode(options, charset, text, phrase: false);
	}

	public static byte[] EncodeText(Encoding charset, string text)
	{
		return EncodeText(FormatOptions.Default, charset, text);
	}
}
