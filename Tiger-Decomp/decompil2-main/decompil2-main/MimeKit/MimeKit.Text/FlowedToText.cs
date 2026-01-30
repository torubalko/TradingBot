using System;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public class FlowedToText : TextConverter
{
	public override TextFormat InputFormat => TextFormat.Flowed;

	public override TextFormat OutputFormat => TextFormat.Plain;

	public bool DeleteSpace { get; set; }

	private static string Unquote(string line, out int quoteDepth)
	{
		int i = 0;
		quoteDepth = 0;
		if (line.Length == 0)
		{
			return line;
		}
		for (; i < line.Length && line[i] == '>'; i++)
		{
			quoteDepth++;
		}
		if (i > 0 && i < line.Length && line[i] == ' ')
		{
			i++;
		}
		if (i <= 0)
		{
			return line;
		}
		return line.Substring(i);
	}

	public override void Convert(TextReader reader, TextWriter writer)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = -1;
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
		string line;
		while ((line = reader.ReadLine()) != null)
		{
			line = Unquote(line, out var quoteDepth);
			if (quoteDepth == 0 && line.Length > 0 && line[0] == ' ')
			{
				line = line.Substring(1);
			}
			if (num == -1)
			{
				num = quoteDepth;
			}
			else if (quoteDepth != num)
			{
				if (num > 0)
				{
					writer.Write(new string('>', num) + " ");
				}
				writer.WriteLine(stringBuilder);
				num = quoteDepth;
				stringBuilder.Length = 0;
			}
			stringBuilder.Append(line);
			if (line.Length == 0 || line[line.Length - 1] != ' ')
			{
				if (num > 0)
				{
					writer.Write(new string('>', num) + " ");
				}
				writer.WriteLine(stringBuilder);
				num = -1;
				stringBuilder.Length = 0;
			}
			else if (DeleteSpace)
			{
				stringBuilder.Length--;
			}
		}
		if (!string.IsNullOrEmpty(base.Footer))
		{
			writer.Write(base.Footer);
		}
	}
}
