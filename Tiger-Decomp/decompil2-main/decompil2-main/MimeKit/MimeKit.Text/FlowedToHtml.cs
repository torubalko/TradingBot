using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MimeKit.Text;

public class FlowedToHtml : TextConverter
{
	private class FlowedToHtmlTagContext : HtmlTagContext
	{
		private HtmlAttributeCollection attrs;

		private bool isEndTag;

		public override string TagName => base.TagId.ToHtmlTagName();

		public override HtmlAttributeCollection Attributes => attrs;

		public override bool IsEmptyElementTag => base.TagId == HtmlTagId.Br;

		public override bool IsEndTag => isEndTag;

		public FlowedToHtmlTagContext(HtmlTagId tag, HtmlAttribute attr)
			: base(tag)
		{
			attrs = new HtmlAttributeCollection(new HtmlAttribute[1] { attr });
		}

		public FlowedToHtmlTagContext(HtmlTagId tag)
			: base(tag)
		{
			attrs = HtmlAttributeCollection.Empty;
		}

		public void SetIsEndTag(bool value)
		{
			isEndTag = value;
		}
	}

	private readonly UrlScanner scanner;

	public override TextFormat InputFormat => TextFormat.Flowed;

	public override TextFormat OutputFormat => TextFormat.Html;

	public bool DeleteSpace { get; set; }

	public HeaderFooterFormat FooterFormat { get; set; }

	public HeaderFooterFormat HeaderFormat { get; set; }

	public HtmlTagCallback HtmlTagCallback { get; set; }

	public bool OutputHtmlFragment { get; set; }

	public FlowedToHtml()
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

	private static bool SuppressContent(IList<FlowedToHtmlTagContext> stack)
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
				FlowedToHtmlTagContext flowedToHtmlTagContext = new FlowedToHtmlTagContext(HtmlTagId.A, new HtmlAttribute(HtmlAttributeId.Href, value));
				htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
				if (!flowedToHtmlTagContext.SuppressInnerContent)
				{
					htmlWriter.WriteText(array, match.StartIndex, count);
				}
				if (!flowedToHtmlTagContext.DeleteEndTag)
				{
					flowedToHtmlTagContext.SetIsEndTag(value: true);
					if (flowedToHtmlTagContext.InvokeCallbackForEndTag)
					{
						htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
					}
					else
					{
						flowedToHtmlTagContext.WriteTag(htmlWriter);
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

	private void WriteParagraph(HtmlWriter htmlWriter, IList<FlowedToHtmlTagContext> stack, ref int currentQuoteDepth, StringBuilder para, int quoteDepth)
	{
		HtmlTagCallback htmlTagCallback = HtmlTagCallback ?? new HtmlTagCallback(DefaultHtmlTagCallback);
		FlowedToHtmlTagContext flowedToHtmlTagContext;
		while (currentQuoteDepth < quoteDepth)
		{
			flowedToHtmlTagContext = new FlowedToHtmlTagContext(HtmlTagId.BlockQuote);
			htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
			currentQuoteDepth++;
			stack.Add(flowedToHtmlTagContext);
		}
		while (quoteDepth < currentQuoteDepth)
		{
			flowedToHtmlTagContext = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);
			if (!SuppressContent(stack) && !flowedToHtmlTagContext.DeleteEndTag)
			{
				flowedToHtmlTagContext.SetIsEndTag(value: true);
				if (flowedToHtmlTagContext.InvokeCallbackForEndTag)
				{
					htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
				}
				else
				{
					flowedToHtmlTagContext.WriteTag(htmlWriter);
				}
			}
			if (flowedToHtmlTagContext.TagId == HtmlTagId.BlockQuote)
			{
				currentQuoteDepth--;
			}
		}
		if (SuppressContent(stack))
		{
			return;
		}
		flowedToHtmlTagContext = new FlowedToHtmlTagContext((para.Length == 0) ? HtmlTagId.Br : HtmlTagId.P);
		htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
		if (para.Length > 0)
		{
			if (!flowedToHtmlTagContext.SuppressInnerContent)
			{
				WriteText(htmlWriter, para.ToString());
			}
			if (!flowedToHtmlTagContext.DeleteEndTag)
			{
				flowedToHtmlTagContext.SetIsEndTag(value: true);
				if (flowedToHtmlTagContext.InvokeCallbackForEndTag)
				{
					htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
				}
				else
				{
					flowedToHtmlTagContext.WriteTag(htmlWriter);
				}
			}
		}
		if (!flowedToHtmlTagContext.DeleteTag)
		{
			htmlWriter.WriteMarkupText(Environment.NewLine);
		}
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
			List<FlowedToHtmlTagContext> list = new List<FlowedToHtmlTagContext>();
			StringBuilder stringBuilder = new StringBuilder();
			int currentQuoteDepth = 0;
			int num = -1;
			string line;
			while ((line = reader.ReadLine()) != null)
			{
				line = Unquote(line, out var quoteDepth);
				if (line.Length > 0 && line[0] == ' ')
				{
					line = line.Substring(1);
				}
				if (stringBuilder.Length == 0)
				{
					num = quoteDepth;
				}
				else if (quoteDepth != num)
				{
					WriteParagraph(htmlWriter, list, ref currentQuoteDepth, stringBuilder, num);
					num = quoteDepth;
					stringBuilder.Length = 0;
				}
				stringBuilder.Append(line);
				if (line.Length == 0 || line[line.Length - 1] != ' ')
				{
					WriteParagraph(htmlWriter, list, ref currentQuoteDepth, stringBuilder, num);
					num = 0;
					stringBuilder.Length = 0;
				}
				else if (DeleteSpace)
				{
					stringBuilder.Length--;
				}
			}
			for (int num2 = list.Count; num2 > 0; num2--)
			{
				FlowedToHtmlTagContext flowedToHtmlTagContext = list[num2 - 1];
				flowedToHtmlTagContext.SetIsEndTag(value: true);
				if (flowedToHtmlTagContext.InvokeCallbackForEndTag)
				{
					htmlTagCallback(flowedToHtmlTagContext, htmlWriter);
				}
				else
				{
					flowedToHtmlTagContext.WriteTag(htmlWriter);
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
