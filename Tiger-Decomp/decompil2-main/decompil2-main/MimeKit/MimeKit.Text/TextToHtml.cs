using System;
using System.Collections.Generic;
using System.IO;

namespace MimeKit.Text;

public class TextToHtml : TextConverter
{
	private class TextToHtmlTagContext : HtmlTagContext
	{
		private HtmlAttributeCollection attributes;

		private bool isEndTag;

		public override string TagName => base.TagId.ToHtmlTagName();

		public override HtmlAttributeCollection Attributes => attributes;

		public override bool IsEmptyElementTag => base.TagId == HtmlTagId.Br;

		public override bool IsEndTag => isEndTag;

		public TextToHtmlTagContext(HtmlTagId tag, HtmlAttribute attr)
			: base(tag)
		{
			attributes = new HtmlAttributeCollection(new HtmlAttribute[1] { attr });
		}

		public TextToHtmlTagContext(HtmlTagId tag)
			: base(tag)
		{
			attributes = HtmlAttributeCollection.Empty;
		}

		public void SetIsEndTag(bool value)
		{
			isEndTag = value;
		}
	}

	private readonly UrlScanner scanner;

	public override TextFormat InputFormat => TextFormat.Plain;

	public override TextFormat OutputFormat => TextFormat.Html;

	public HeaderFooterFormat FooterFormat { get; set; }

	public HeaderFooterFormat HeaderFormat { get; set; }

	public HtmlTagCallback HtmlTagCallback { get; set; }

	public bool OutputHtmlFragment { get; set; }

	public TextToHtml()
	{
		scanner = new UrlScanner();
		for (int i = 0; i < TextConverter.UrlPatterns.Count; i++)
		{
			scanner.Add(TextConverter.UrlPatterns[i]);
		}
	}

	private static void DefaultHtmlTagCallback(HtmlTagContext tagContext, HtmlWriter htmlWriter)
	{
		tagContext.WriteTag(htmlWriter, writeAttributes: true);
	}

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

	private static bool SuppressContent(IList<TextToHtmlTagContext> stack)
	{
		for (int num = stack.Count; num > 0; num--)
		{
			if (stack[num - 1].SuppressInnerContent)
			{
				return true;
			}
		}
		return false;
	}

	private void WriteText(HtmlWriter htmlWriter, string text)
	{
		HtmlTagCallback htmlTagCallback = HtmlTagCallback ?? new HtmlTagCallback(DefaultHtmlTagCallback);
		char[] array = text.ToCharArray();
		int num = array.Length;
		int num2 = 0;
		do
		{
			int count = num - num2;
			if (scanner.Scan(array, num2, count, out var match))
			{
				count = match.EndIndex - match.StartIndex;
				if (match.StartIndex > num2)
				{
					htmlWriter.WriteText(array, num2, match.StartIndex - num2);
				}
				string value = match.Prefix + new string(array, match.StartIndex, count);
				TextToHtmlTagContext textToHtmlTagContext = new TextToHtmlTagContext(HtmlTagId.A, new HtmlAttribute(HtmlAttributeId.Href, value));
				htmlTagCallback(textToHtmlTagContext, htmlWriter);
				if (!textToHtmlTagContext.SuppressInnerContent)
				{
					htmlWriter.WriteText(array, match.StartIndex, count);
				}
				if (!textToHtmlTagContext.DeleteEndTag)
				{
					textToHtmlTagContext.SetIsEndTag(value: true);
					if (textToHtmlTagContext.InvokeCallbackForEndTag)
					{
						htmlTagCallback(textToHtmlTagContext, htmlWriter);
					}
					else
					{
						textToHtmlTagContext.WriteTag(htmlWriter);
					}
				}
				num2 = match.EndIndex;
				continue;
			}
			htmlWriter.WriteText(array, num2, count);
			break;
		}
		while (num2 < num);
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
		if (!OutputHtmlFragment)
		{
			writer.Write("<html><body>");
		}
		if (!string.IsNullOrEmpty(base.Header))
		{
			if (HeaderFormat == HeaderFooterFormat.Text)
			{
				TextToHtml textToHtml = new TextToHtml
				{
					OutputHtmlFragment = true
				};
				using StringReader reader2 = new StringReader(base.Header);
				textToHtml.Convert(reader2, writer);
			}
			else
			{
				writer.Write(base.Header);
			}
		}
		using (HtmlWriter htmlWriter = new HtmlWriter(writer))
		{
			HtmlTagCallback htmlTagCallback = HtmlTagCallback ?? new HtmlTagCallback(DefaultHtmlTagCallback);
			List<TextToHtmlTagContext> list = new List<TextToHtmlTagContext>();
			int num = 0;
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				line = Unquote(line, out var quoteDepth);
				while (num < quoteDepth)
				{
					TextToHtmlTagContext textToHtmlTagContext = new TextToHtmlTagContext(HtmlTagId.BlockQuote);
					htmlTagCallback(textToHtmlTagContext, htmlWriter);
					num++;
					list.Add(textToHtmlTagContext);
				}
				while (quoteDepth < num)
				{
					TextToHtmlTagContext textToHtmlTagContext = list[list.Count - 1];
					list.RemoveAt(list.Count - 1);
					if (!SuppressContent(list) && !textToHtmlTagContext.DeleteEndTag)
					{
						textToHtmlTagContext.SetIsEndTag(value: true);
						if (textToHtmlTagContext.InvokeCallbackForEndTag)
						{
							htmlTagCallback(textToHtmlTagContext, htmlWriter);
						}
						else
						{
							textToHtmlTagContext.WriteTag(htmlWriter);
						}
					}
					if (textToHtmlTagContext.TagId == HtmlTagId.BlockQuote)
					{
						num--;
					}
				}
				if (!SuppressContent(list))
				{
					WriteText(htmlWriter, line);
					TextToHtmlTagContext textToHtmlTagContext = new TextToHtmlTagContext(HtmlTagId.Br);
					htmlTagCallback(textToHtmlTagContext, htmlWriter);
				}
			}
			for (int num2 = list.Count; num2 > 0; num2--)
			{
				TextToHtmlTagContext textToHtmlTagContext = list[num2 - 1];
				textToHtmlTagContext.SetIsEndTag(value: true);
				if (textToHtmlTagContext.InvokeCallbackForEndTag)
				{
					htmlTagCallback(textToHtmlTagContext, htmlWriter);
				}
				else
				{
					textToHtmlTagContext.WriteTag(htmlWriter);
				}
			}
			htmlWriter.Flush();
		}
		if (!string.IsNullOrEmpty(base.Footer))
		{
			if (FooterFormat == HeaderFooterFormat.Text)
			{
				TextToHtml textToHtml2 = new TextToHtml
				{
					OutputHtmlFragment = true
				};
				using StringReader reader3 = new StringReader(base.Footer);
				textToHtml2.Convert(reader3, writer);
			}
			else
			{
				writer.Write(base.Footer);
			}
		}
		if (!OutputHtmlFragment)
		{
			writer.Write("</body></html>");
		}
	}
}
