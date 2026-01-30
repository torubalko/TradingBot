using System;
using System.Collections.Generic;
using System.IO;

namespace MimeKit.Text;

public class HtmlToHtml : TextConverter
{
	private class HtmlToHtmlTagContext : HtmlTagContext
	{
		private readonly HtmlTagToken tag;

		public override string TagName => tag.Name;

		public override HtmlAttributeCollection Attributes => tag.Attributes;

		public override bool IsEmptyElementTag
		{
			get
			{
				if (!tag.IsEmptyElement)
				{
					return tag.Id.IsEmptyElement();
				}
				return true;
			}
		}

		public override bool IsEndTag => tag.IsEndTag;

		public HtmlToHtmlTagContext(HtmlTagToken htmlTag)
			: base(htmlTag.Id)
		{
			tag = htmlTag;
		}
	}

	public override TextFormat InputFormat => TextFormat.Html;

	public override TextFormat OutputFormat => TextFormat.Html;

	public bool FilterComments { get; set; }

	public bool FilterHtml { get; set; }

	public HeaderFooterFormat FooterFormat { get; set; }

	public HeaderFooterFormat HeaderFormat { get; set; }

	public HtmlTagCallback HtmlTagCallback { get; set; }

	private static void DefaultHtmlTagCallback(HtmlTagContext tagContext, HtmlWriter htmlWriter)
	{
		tagContext.WriteTag(htmlWriter, writeAttributes: true);
	}

	private static bool SuppressContent(IList<HtmlToHtmlTagContext> stack)
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

	private static HtmlToHtmlTagContext Pop(IList<HtmlToHtmlTagContext> stack, string name)
	{
		for (int num = stack.Count; num > 0; num--)
		{
			if (stack[num - 1].TagName.Equals(name, StringComparison.OrdinalIgnoreCase))
			{
				HtmlToHtmlTagContext result = stack[num - 1];
				stack.RemoveAt(num - 1);
				return result;
			}
		}
		return null;
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
			List<HtmlToHtmlTagContext> list = new List<HtmlToHtmlTagContext>();
			HtmlTokenizer htmlTokenizer = new HtmlTokenizer(reader);
			HtmlToken token;
			while (htmlTokenizer.ReadNextToken(out token))
			{
				switch (token.Kind)
				{
				default:
					if (!SuppressContent(list))
					{
						htmlWriter.WriteToken(token);
					}
					break;
				case HtmlTokenKind.Comment:
					if (!FilterComments && !SuppressContent(list))
					{
						htmlWriter.WriteToken(token);
					}
					break;
				case HtmlTokenKind.Tag:
				{
					HtmlTagToken htmlTagToken = (HtmlTagToken)token;
					HtmlToHtmlTagContext htmlToHtmlTagContext;
					if (!htmlTagToken.IsEndTag)
					{
						if (!htmlTagToken.IsEmptyElement)
						{
							htmlToHtmlTagContext = new HtmlToHtmlTagContext(htmlTagToken);
							if (FilterHtml && htmlToHtmlTagContext.TagId == HtmlTagId.Script)
							{
								htmlToHtmlTagContext.SuppressInnerContent = true;
								htmlToHtmlTagContext.DeleteEndTag = true;
								htmlToHtmlTagContext.DeleteTag = true;
							}
							else if (!SuppressContent(list))
							{
								htmlTagCallback(htmlToHtmlTagContext, htmlWriter);
							}
							list.Add(htmlToHtmlTagContext);
						}
						else if (!SuppressContent(list))
						{
							htmlToHtmlTagContext = new HtmlToHtmlTagContext(htmlTagToken);
							if (!FilterHtml || htmlToHtmlTagContext.TagId != HtmlTagId.Script)
							{
								htmlTagCallback(htmlToHtmlTagContext, htmlWriter);
							}
						}
					}
					else if ((htmlToHtmlTagContext = Pop(list, htmlTagToken.Name)) != null)
					{
						if (!SuppressContent(list))
						{
							if (htmlToHtmlTagContext.InvokeCallbackForEndTag)
							{
								htmlToHtmlTagContext = new HtmlToHtmlTagContext(htmlTagToken)
								{
									InvokeCallbackForEndTag = htmlToHtmlTagContext.InvokeCallbackForEndTag,
									SuppressInnerContent = htmlToHtmlTagContext.SuppressInnerContent,
									DeleteEndTag = htmlToHtmlTagContext.DeleteEndTag,
									DeleteTag = htmlToHtmlTagContext.DeleteTag
								};
								htmlTagCallback(htmlToHtmlTagContext, htmlWriter);
							}
							else if (!htmlToHtmlTagContext.DeleteEndTag)
							{
								htmlWriter.WriteEndTag(htmlTagToken.Name);
							}
						}
					}
					else if (!SuppressContent(list))
					{
						htmlToHtmlTagContext = new HtmlToHtmlTagContext(htmlTagToken);
						htmlTagCallback(htmlToHtmlTagContext, htmlWriter);
					}
					break;
				}
				}
			}
			htmlWriter.Flush();
		}
		if (string.IsNullOrEmpty(base.Footer))
		{
			return;
		}
		if (FooterFormat == HeaderFooterFormat.Text)
		{
			TextToHtml textToHtml2 = new TextToHtml
			{
				OutputHtmlFragment = true
			};
			using StringReader reader3 = new StringReader(base.Footer);
			textToHtml2.Convert(reader3, writer);
			return;
		}
		writer.Write(base.Footer);
	}
}
