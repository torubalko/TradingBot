using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MimeKit.Text;

public class HtmlTextPreviewer : TextPreviewer
{
	private sealed class HtmlTagContext
	{
		public HtmlTagId TagId { get; }

		public int ListIndex { get; set; }

		public bool SuppressInnerContent { get; set; }

		public HtmlTagContext(HtmlTagId id)
		{
			TagId = id;
		}
	}

	public override TextFormat InputFormat => TextFormat.Html;

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

	private static bool Append(char[] preview, ref int previewLength, string value, ref bool lwsp)
	{
		int i;
		for (i = 0; i < value.Length; i++)
		{
			if (previewLength >= preview.Length)
			{
				break;
			}
			if (IsWhiteSpace(value[i]))
			{
				if (!lwsp)
				{
					preview[previewLength++] = ' ';
					lwsp = true;
				}
			}
			else
			{
				preview[previewLength++] = value[i];
				lwsp = false;
			}
		}
		if (i < value.Length)
		{
			if (lwsp)
			{
				previewLength--;
			}
			preview[previewLength - 1] = '…';
			lwsp = false;
			return true;
		}
		return false;
	}

	private static void Pop(IList<HtmlTagContext> stack, HtmlTagId id)
	{
		for (int num = stack.Count; num > 0; num--)
		{
			if (stack[num - 1].TagId == id)
			{
				stack.RemoveAt(num - 1);
				break;
			}
		}
	}

	private static bool ShouldSuppressInnerContent(HtmlTagId id)
	{
		switch (id)
		{
		case HtmlTagId.OL:
		case HtmlTagId.Script:
		case HtmlTagId.Style:
		case HtmlTagId.Table:
		case HtmlTagId.TBody:
		case HtmlTagId.THead:
		case HtmlTagId.TR:
		case HtmlTagId.UL:
			return true;
		default:
			return false;
		}
	}

	private static bool SuppressContent(IList<HtmlTagContext> stack)
	{
		int num = stack.Count - 1;
		if (num >= 0)
		{
			return stack[num].SuppressInnerContent;
		}
		return false;
	}

	private HtmlTagContext GetListItemContext(IList<HtmlTagContext> stack)
	{
		for (int num = stack.Count; num > 0; num--)
		{
			HtmlTagContext htmlTagContext = stack[num - 1];
			if (htmlTagContext.TagId == HtmlTagId.OL || htmlTagContext.TagId == HtmlTagId.UL)
			{
				return htmlTagContext;
			}
		}
		return null;
	}

	public override string GetPreviewText(TextReader reader)
	{
		if (reader == null)
		{
			throw new ArgumentNullException("reader");
		}
		HtmlTokenizer htmlTokenizer = new HtmlTokenizer(reader)
		{
			IgnoreTruncatedTags = true
		};
		char[] array = new char[base.MaximumPreviewLength];
		List<HtmlTagContext> list = new List<HtmlTagContext>();
		string text = string.Empty;
		int previewLength = 0;
		bool flag = false;
		bool flag2 = false;
		bool lwsp = true;
		HtmlToken token;
		while (!flag2 && htmlTokenizer.ReadNextToken(out token))
		{
			switch (token.Kind)
			{
			case HtmlTokenKind.Tag:
			{
				HtmlTagToken htmlTagToken = (HtmlTagToken)token;
				if (!htmlTagToken.IsEndTag)
				{
					if (flag)
					{
						switch (htmlTagToken.Id)
						{
						case HtmlTagId.Image:
						{
							HtmlAttribute htmlAttribute;
							if ((htmlAttribute = htmlTagToken.Attributes.FirstOrDefault((HtmlAttribute x) => x.Id == HtmlAttributeId.Alt)) != null)
							{
								flag2 = Append(array, ref previewLength, text + htmlAttribute.Value, ref lwsp);
								text = string.Empty;
							}
							break;
						}
						case HtmlTagId.LI:
						{
							HtmlTagContext listItemContext;
							if ((listItemContext = GetListItemContext(list)) != null)
							{
								if (listItemContext.TagId == HtmlTagId.OL)
								{
									flag2 = Append(array, ref previewLength, $" {++listItemContext.ListIndex}. ", ref lwsp);
									text = string.Empty;
								}
								else
								{
									text = " ";
								}
							}
							break;
						}
						case HtmlTagId.Br:
						case HtmlTagId.P:
							text = " ";
							break;
						}
						if (!htmlTagToken.IsEmptyElement)
						{
							HtmlTagContext listItemContext = new HtmlTagContext(htmlTagToken.Id)
							{
								SuppressInnerContent = ShouldSuppressInnerContent(htmlTagToken.Id)
							};
							list.Add(listItemContext);
						}
					}
					else if (htmlTagToken.Id == HtmlTagId.Body && !htmlTagToken.IsEmptyElement)
					{
						flag = true;
					}
				}
				else if (htmlTagToken.Id == HtmlTagId.Body)
				{
					list.Clear();
					flag = false;
				}
				else
				{
					Pop(list, htmlTagToken.Id);
				}
				break;
			}
			case HtmlTokenKind.Data:
				if (flag && !SuppressContent(list))
				{
					HtmlDataToken htmlDataToken = (HtmlDataToken)token;
					flag2 = Append(array, ref previewLength, text + htmlDataToken.Data, ref lwsp);
					text = string.Empty;
				}
				break;
			}
		}
		if (lwsp && previewLength > 0)
		{
			previewLength--;
		}
		return new string(array, 0, previewLength);
	}
}
