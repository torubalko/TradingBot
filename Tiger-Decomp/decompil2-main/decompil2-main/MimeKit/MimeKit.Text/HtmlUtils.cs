using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public static class HtmlUtils
{
	internal static bool IsValidTokenName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return false;
		}
		for (int i = 0; i < name.Length; i++)
		{
			switch (name[i])
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
			case ' ':
			case '"':
			case '\'':
			case '/':
			case '<':
			case '=':
			case '>':
				return false;
			}
		}
		return true;
	}

	private static int IndexOfHtmlEncodeAttributeChar(ICharArray value, int startIndex, int endIndex, char quote)
	{
		for (int i = startIndex; i < endIndex; i++)
		{
			char c = value[i];
			switch (c)
			{
			case '&':
			case '<':
			case '>':
				return i;
			case '\t':
			case '\n':
			case '\f':
			case '\r':
				continue;
			}
			if (c == quote || c < ' ' || c >= '\u007f')
			{
				return i;
			}
		}
		return endIndex;
	}

	private static void HtmlAttributeEncode(TextWriter output, ICharArray value, int startIndex, int count, char quote = '"')
	{
		int num = startIndex + count;
		int num2 = IndexOfHtmlEncodeAttributeChar(value, startIndex, num, quote);
		output.Write(quote);
		if (num2 == num)
		{
			value.Write(output, startIndex, count);
			output.Write(quote);
			return;
		}
		if (num2 > startIndex)
		{
			value.Write(output, startIndex, num2 - startIndex);
		}
		while (num2 < num)
		{
			char c = value[num2++];
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
				output.Write(c);
				continue;
			case '\'':
				output.Write((c == quote) ? "&#39;" : "'");
				continue;
			case '"':
				output.Write((c == quote) ? "&quot;" : "\"");
				continue;
			case '&':
				output.Write("&amp;");
				continue;
			case '<':
				output.Write("&lt;");
				continue;
			case '>':
				output.Write("&gt;");
				continue;
			}
			if (c < ' ' || (c >= '\u007f' && c < '\u00a0'))
			{
				continue;
			}
			int num3;
			if (c > 'ÿ' && char.IsSurrogate(c))
			{
				if (num2 < num && char.IsSurrogatePair(c, value[num2]))
				{
					num3 = char.ConvertToUtf32(c, value[num2]);
					num2++;
				}
				else
				{
					num3 = c;
				}
			}
			else
			{
				if (c < '\u00a0')
				{
					output.Write(c);
					continue;
				}
				num3 = c;
			}
			output.Write(string.Format(CultureInfo.InvariantCulture, "&#{0};", num3));
		}
		output.Write(quote);
	}

	public static void HtmlAttributeEncode(TextWriter output, char[] value, int startIndex, int count, char quote = '"')
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex >= value.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > value.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		HtmlAttributeEncode(output, new CharArray(value), startIndex, count, quote);
	}

	public static string HtmlAttributeEncode(char[] value, int startIndex, int count, char quote = '"')
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex >= value.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > value.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		StringBuilder stringBuilder = new StringBuilder();
		using (StringWriter output = new StringWriter(stringBuilder))
		{
			HtmlAttributeEncode(output, new CharArray(value), startIndex, count, quote);
		}
		return stringBuilder.ToString();
	}

	public static void HtmlAttributeEncode(TextWriter output, string value, int startIndex, int count, char quote = '"')
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex >= value.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > value.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		HtmlAttributeEncode(output, new CharString(value), startIndex, count, quote);
	}

	public static void HtmlAttributeEncode(TextWriter output, string value, char quote = '"')
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		HtmlAttributeEncode(output, new CharString(value), 0, value.Length, quote);
	}

	public static string HtmlAttributeEncode(string value, int startIndex, int count, char quote = '"')
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (startIndex < 0 || startIndex >= value.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > value.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		StringBuilder stringBuilder = new StringBuilder();
		using (StringWriter output = new StringWriter(stringBuilder))
		{
			HtmlAttributeEncode(output, new CharString(value), startIndex, count, quote);
		}
		return stringBuilder.ToString();
	}

	public static string HtmlAttributeEncode(string value, char quote = '"')
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (quote != '"' && quote != '\'')
		{
			throw new ArgumentException("The quote character must either be '\"' or '''.", "quote");
		}
		StringBuilder stringBuilder = new StringBuilder();
		using (StringWriter output = new StringWriter(stringBuilder))
		{
			HtmlAttributeEncode(output, new CharString(value), 0, value.Length, quote);
		}
		return stringBuilder.ToString();
	}

	private static int IndexOfHtmlEncodeChar(ICharArray value, int startIndex, int endIndex)
	{
		for (int i = startIndex; i < endIndex; i++)
		{
			char c = value[i];
			switch (c)
			{
			case '"':
			case '&':
			case '\'':
			case '<':
			case '>':
				return i;
			case '\t':
			case '\n':
			case '\f':
			case '\r':
				continue;
			}
			if (c < ' ' || c >= '\u007f')
			{
				return i;
			}
		}
		return endIndex;
	}

	private static void HtmlEncode(TextWriter output, ICharArray data, int startIndex, int count)
	{
		int num = startIndex + count;
		int num2 = IndexOfHtmlEncodeChar(data, startIndex, num);
		if (num2 > startIndex)
		{
			data.Write(output, startIndex, num2 - startIndex);
		}
		while (num2 < num)
		{
			char c = data[num2++];
			switch (c)
			{
			case '\t':
			case '\n':
			case '\f':
			case '\r':
				output.Write(c);
				continue;
			case '\'':
				output.Write("&#39;");
				continue;
			case '"':
				output.Write("&quot;");
				continue;
			case '&':
				output.Write("&amp;");
				continue;
			case '<':
				output.Write("&lt;");
				continue;
			case '>':
				output.Write("&gt;");
				continue;
			}
			if (c < ' ' || (c >= '\u007f' && c < '\u00a0'))
			{
				continue;
			}
			int num3;
			if (c > 'ÿ' && char.IsSurrogate(c))
			{
				if (num2 < num && char.IsSurrogatePair(c, data[num2]))
				{
					num3 = char.ConvertToUtf32(c, data[num2]);
					num2++;
				}
				else
				{
					num3 = c;
				}
			}
			else
			{
				if (c < '\u00a0')
				{
					output.Write(c);
					continue;
				}
				num3 = c;
			}
			output.Write(string.Format(CultureInfo.InvariantCulture, "&#{0};", num3));
		}
	}

	public static void HtmlEncode(TextWriter output, char[] data, int startIndex, int count)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		HtmlEncode(output, new CharArray(data), startIndex, count);
	}

	public static string HtmlEncode(char[] data, int startIndex, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		StringBuilder stringBuilder = new StringBuilder();
		using (StringWriter output = new StringWriter(stringBuilder))
		{
			HtmlEncode(output, new CharArray(data), startIndex, count);
		}
		return stringBuilder.ToString();
	}

	public static void HtmlEncode(TextWriter output, string data, int startIndex, int count)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		HtmlEncode(output, new CharString(data), startIndex, count);
	}

	public static void HtmlEncode(TextWriter output, string data)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		HtmlEncode(output, new CharString(data), 0, data.Length);
	}

	public static string HtmlEncode(string data, int startIndex, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		using StringWriter stringWriter = new StringWriter();
		HtmlEncode(stringWriter, new CharString(data), startIndex, count);
		return stringWriter.ToString();
	}

	public static string HtmlEncode(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using StringWriter stringWriter = new StringWriter();
		HtmlEncode(stringWriter, new CharString(data), 0, data.Length);
		return stringWriter.ToString();
	}

	public static void HtmlDecode(TextWriter output, string data, int startIndex, int count)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		HtmlEntityDecoder htmlEntityDecoder = new HtmlEntityDecoder();
		int num = startIndex + count;
		int i = startIndex;
		while (i < num)
		{
			if (data[i] == '&')
			{
				for (; i < num && htmlEntityDecoder.Push(data[i]); i++)
				{
				}
				output.Write(htmlEntityDecoder.GetValue());
				htmlEntityDecoder.Reset();
			}
			else
			{
				output.Write(data[i++]);
			}
		}
	}

	public static void HtmlDecode(TextWriter output, string data)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		HtmlDecode(output, data, 0, data.Length);
	}

	public static string HtmlDecode(string data, int startIndex, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (startIndex < 0 || startIndex >= data.Length)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		if (count < 0 || count > data.Length - startIndex)
		{
			throw new ArgumentOutOfRangeException("count");
		}
		using StringWriter stringWriter = new StringWriter();
		HtmlDecode(stringWriter, data, startIndex, count);
		return stringWriter.ToString();
	}

	public static string HtmlDecode(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		using StringWriter stringWriter = new StringWriter();
		HtmlDecode(stringWriter, data, 0, data.Length);
		return stringWriter.ToString();
	}
}
