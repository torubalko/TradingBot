using System;
using System.IO;

namespace MimeKit.Text;

public class PlainTextPreviewer : TextPreviewer
{
	public override TextFormat InputFormat => TextFormat.Plain;

	private static bool IsWhiteSpace(char c)
	{
		if (!char.IsWhiteSpace(c))
		{
			if (c >= '\u200b')
			{
				return c <= '\u200d';
			}
			return false;
		}
		return true;
	}

	public override string GetPreviewText(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		if (text.Length == 0)
		{
			return string.Empty;
		}
		char[] array = new char[Math.Min(base.MaximumPreviewLength, text.Length)];
		int num = 0;
		bool flag = true;
		int i;
		for (i = 0; i < text.Length; i++)
		{
			if (num >= array.Length)
			{
				break;
			}
			if (IsWhiteSpace(text[i]))
			{
				if (!flag)
				{
					array[num++] = ' ';
					flag = true;
				}
			}
			else
			{
				array[num++] = text[i];
				flag = false;
			}
		}
		if (flag && num > 0)
		{
			num--;
		}
		if (i < text.Length)
		{
			array[num - 1] = '…';
		}
		return new string(array, 0, num);
	}

	public override string GetPreviewText(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		char[] array = new char[base.MaximumPreviewLength];
		char[] array2 = new char[4096];
		int num = 0;
		bool flag = true;
		int num2;
		while ((num2 = reader.ReadBlock(array2, 0, array2.Length)) > 0)
		{
			int i;
			for (i = 0; i < num2; i++)
			{
				if (num >= array.Length)
				{
					break;
				}
				if (char.IsWhiteSpace(array2[i]))
				{
					if (!flag)
					{
						array[num++] = ' ';
						flag = true;
					}
				}
				else
				{
					array[num++] = array2[i];
					flag = false;
				}
			}
			if (i < num2)
			{
				array[num - 1] = '…';
				flag = false;
				break;
			}
		}
		if (flag && num > 0)
		{
			num--;
		}
		return new string(array, 0, num);
	}
}
