using System;
using System.Collections.Generic;
using System.IO;

namespace MimeKit.Text;

public class HtmlTagToken : HtmlToken
{
	public HtmlAttributeCollection Attributes { get; private set; }

	public HtmlTagId Id { get; private set; }

	public bool IsEmptyElement { get; internal set; }

	public bool IsEndTag { get; private set; }

	public string Name { get; private set; }

	public HtmlTagToken(string name, IEnumerable<HtmlAttribute> attributes, bool isEmptyElement)
		: base(HtmlTokenKind.Tag)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Attributes = new HtmlAttributeCollection(attributes);
		IsEmptyElement = isEmptyElement;
		Id = name.ToHtmlTagId();
		Name = name;
	}

	public HtmlTagToken(string name, bool isEndTag)
		: base(HtmlTokenKind.Tag)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		Attributes = new HtmlAttributeCollection();
		Id = name.ToHtmlTagId();
		IsEndTag = isEndTag;
		Name = name;
	}

	public override void WriteTo(TextWriter output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		output.Write('<');
		if (IsEndTag)
		{
			output.Write('/');
		}
		output.Write(Name);
		for (int i = 0; i < Attributes.Count; i++)
		{
			output.Write(' ');
			output.Write(Attributes[i].Name);
			if (Attributes[i].Value != null)
			{
				output.Write('=');
				HtmlUtils.HtmlAttributeEncode(output, Attributes[i].Value);
			}
		}
		if (IsEmptyElement)
		{
			output.Write('/');
		}
		output.Write('>');
	}
}
