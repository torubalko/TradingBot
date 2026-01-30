using System;

namespace MimeKit.Text;

[AttributeUsage(AttributeTargets.Field)]
internal class HtmlAttributeNameAttribute : Attribute
{
	public string Name { get; protected set; }

	public HtmlAttributeNameAttribute(string name)
	{
		Name = name;
	}
}
