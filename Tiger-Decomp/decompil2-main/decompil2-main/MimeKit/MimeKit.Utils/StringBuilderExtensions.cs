using System.Collections.Generic;
using System.Text;

namespace MimeKit.Utils;

internal static class StringBuilderExtensions
{
	public static StringBuilder LineWrap(this StringBuilder text, FormatOptions options)
	{
		if (text.Length == 0)
		{
			return text;
		}
		if (char.IsWhiteSpace(text[text.Length - 1]))
		{
			text.Insert(text.Length - 1, options.NewLine);
		}
		else
		{
			text.Append(options.NewLine);
			text.Append('\t');
		}
		return text;
	}

	public static void AppendTokens(this StringBuilder text, FormatOptions options, ref int lineLength, List<string> tokens)
	{
		string text2 = string.Empty;
		foreach (string token in tokens)
		{
			if (string.IsNullOrWhiteSpace(token))
			{
				text2 = token;
				continue;
			}
			if (lineLength + text2.Length + token.Length > options.MaxLineLength)
			{
				text.Append(options.NewLine);
				text2 = string.Empty;
				text.Append('\t');
				lineLength = 1;
			}
			else
			{
				lineLength += text2.Length;
				text.Append(text2);
				text2 = string.Empty;
			}
			lineLength += token.Length;
			text.Append(token);
		}
	}

	public static StringBuilder AppendFolded(this StringBuilder text, FormatOptions options, bool firstToken, string value, ref int lineLength)
	{
		int i = 0;
		while (i < value.Length)
		{
			int j = i;
			if (value[i] == '"')
			{
				j++;
				while (j < value.Length && value[j] != '"')
				{
					if (value[j] == '\\')
					{
						j++;
						if (j < value.Length)
						{
							j++;
						}
					}
					else
					{
						j++;
					}
				}
				if (j < value.Length)
				{
					j++;
				}
			}
			else
			{
				for (; j < value.Length && !char.IsWhiteSpace(value[j]); j++)
				{
				}
			}
			int num = j - i;
			if (!firstToken && lineLength > 1 && lineLength + num > options.MaxLineLength)
			{
				text.LineWrap(options);
				lineLength = 1;
			}
			text.Append(value, i, num);
			lineLength += num;
			firstToken = false;
			for (i = j; i < value.Length && char.IsWhiteSpace(value[i]); i++)
			{
			}
			if (i < value.Length && i > j)
			{
				text.Append(' ');
				lineLength++;
			}
		}
		return text;
	}
}
