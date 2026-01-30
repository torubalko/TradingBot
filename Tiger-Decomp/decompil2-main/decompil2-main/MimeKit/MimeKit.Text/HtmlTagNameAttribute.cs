using System;

namespace MimeKit.Text;

[AttributeUsage(AttributeTargets.Field)]
internal class HtmlTagNameAttribute : Attribute
{
	public string Name { get; protected set; }

	public HtmlTagNameAttribute(string name)
	{
		Name = name;
	}
}
