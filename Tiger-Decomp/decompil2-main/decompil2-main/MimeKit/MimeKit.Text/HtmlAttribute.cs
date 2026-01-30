using System;

namespace MimeKit.Text;

public class HtmlAttribute
{
	public HtmlAttributeId Id { get; private set; }

	public string Name { get; private set; }

	public string Value { get; internal set; }

	public HtmlAttribute(HtmlAttributeId id, string value)
	{
		if (id == HtmlAttributeId.Unknown)
		{
			throw new ArgumentOutOfRangeException("id");
		}
		Name = id.ToAttributeName();
		Value = value;
		Id = id;
	}

	public HtmlAttribute(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("The attribute name cannot be empty.", "name");
		}
		if (!HtmlUtils.IsValidTokenName(name))
		{
			throw new ArgumentException("Invalid attribute name.", "name");
		}
		Id = name.ToHtmlAttributeId();
		Value = value;
		Name = name;
	}

	internal HtmlAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (name.Length == 0)
		{
			throw new ArgumentException("The attribute name cannot be empty.", "name");
		}
		Id = name.ToHtmlAttributeId();
		Name = name;
	}
}
