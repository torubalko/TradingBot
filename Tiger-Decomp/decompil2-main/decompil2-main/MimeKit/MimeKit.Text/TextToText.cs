using System;
using System.IO;

namespace MimeKit.Text;

public class TextToText : TextConverter
{
	public override TextFormat InputFormat => TextFormat.Plain;

	public override TextFormat OutputFormat => TextFormat.Plain;

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
		char[] array = new char[4096];
		int count;
		while ((count = reader.Read(array, 0, array.Length)) > 0)
		{
			writer.Write(array, 0, count);
		}
		if (!string.IsNullOrEmpty(base.Footer))
		{
			writer.Write(base.Footer);
		}
	}
}
