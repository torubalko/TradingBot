using System;

namespace MimeKit.Text;

public abstract class HtmlTagContext
{
	public abstract HtmlAttributeCollection Attributes { get; }

	public bool DeleteEndTag { get; set; }

	public bool DeleteTag { get; set; }

	public bool InvokeCallbackForEndTag { get; set; }

	public abstract bool IsEmptyElementTag { get; }

	public abstract bool IsEndTag { get; }

	public bool SuppressInnerContent { get; set; }

	public HtmlTagId TagId { get; private set; }

	public abstract string TagName { get; }

	protected HtmlTagContext(HtmlTagId tagId)
	{
		TagId = tagId;
	}

	public void WriteTag(HtmlWriter htmlWriter)
	{
		WriteTag(htmlWriter, writeAttributes: false);
	}

	public void WriteTag(HtmlWriter htmlWriter, bool writeAttributes)
	{
		if (htmlWriter == null)
		{
			throw new ArgumentNullException("htmlWriter");
		}
		if (IsEndTag)
		{
			htmlWriter.WriteEndTag(TagName);
			return;
		}
		if (IsEmptyElementTag)
		{
			htmlWriter.WriteEmptyElementTag(TagName);
		}
		else
		{
			htmlWriter.WriteStartTag(TagName);
		}
		if (writeAttributes)
		{
			for (int i = 0; i < Attributes.Count; i++)
			{
				htmlWriter.WriteAttribute(Attributes[i]);
			}
		}
	}
}
