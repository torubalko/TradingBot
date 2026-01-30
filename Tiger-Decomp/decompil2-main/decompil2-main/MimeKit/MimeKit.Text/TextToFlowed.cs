using System;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public class TextToFlowed : TextConverter
{
	private const int MaxLineLength = 78;

	public override TextFormat InputFormat => TextFormat.Plain;

	public override TextFormat OutputFormat => TextFormat.Flowed;

	private static string Unquote(string line, out int quoteDepth)
	{
		int num = 0;
		quoteDepth = 0;
		if (line.Length == 0 || line[0] != '>')
		{
			return line;
		}
		do
		{
			quoteDepth++;
			num++;
			if (num < line.Length && line[num] == ' ')
			{
				num++;
			}
		}
		while (num < line.Length && line[num] == '>');
		return line.Substring(num);
	}

	private static bool StartsWith(string text, int startIndex, string value)
	{
		if (startIndex + value.Length > text.Length)
		{
			return false;
		}
		for (int i = 0; i < value.Length; i++)
		{
			if (text[startIndex + i] != value[i])
			{
				return false;
			}
		}
		return true;
	}

	private static string GetFlowedLine(StringBuilder flowed, string line, ref int index, int quoteDepth)
	{
		flowed.Length = 0;
		if (quoteDepth > 0)
		{
			flowed.Append('>', quoteDepth);
		}
		if (quoteDepth > 0 || (line.Length > index && line[index] == ' ') || StartsWith(line, index, "From "))
		{
			flowed.Append(' ');
		}
		if (flowed.Length + (line.Length - index) <= 78)
		{
			flowed.Append(line.Substring(index));
			index = line.Length;
			return flowed.ToString();
		}
		do
		{
			int num = line.IndexOf(' ', index);
			int num2 = ((num == -1) ? line.Length : num);
			int num3 = ((num != -1) ? 2 : 0);
			int num4 = num2 - index;
			if (flowed.Length + num4 + num3 <= 78)
			{
				flowed.Append(line, index, num4);
				index = num2;
				while (flowed.Length + 1 < 78 && index < line.Length && line[index] == ' ')
				{
					flowed.Append(line[index++]);
				}
				continue;
			}
			if (num4 > 78 - (quoteDepth + 1))
			{
				num4 = 78 - (flowed.Length + 1);
				flowed.Append(line, index, num4);
				index += num4;
			}
			break;
		}
		while (index < line.Length && flowed.Length + 1 < 78);
		if (index < line.Length)
		{
			flowed.Append(' ');
		}
		return flowed.ToString();
	}

	public override void Convert(TextReader reader, TextWriter writer)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		if (writer == null)
		{
			throw new ArgumentNullException("writer");
		}
		if (!string.IsNullOrEmpty(base.Header))
		{
			writer.Write(base.Header);
		}
		StringBuilder flowed = new StringBuilder(78);
		string text;
		while ((text = reader.ReadLine()) != null)
		{
			text = text.TrimEnd(' ');
			text = Unquote(text, out var quoteDepth);
			int index = 0;
			do
			{
				string flowedLine = GetFlowedLine(flowed, text, ref index, quoteDepth);
				writer.WriteLine(flowedLine);
			}
			while (index < text.Length);
		}
		if (!string.IsNullOrEmpty(base.Footer))
		{
			writer.Write(base.Footer);
		}
	}
}
