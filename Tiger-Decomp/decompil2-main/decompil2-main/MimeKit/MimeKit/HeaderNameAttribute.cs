using System;

namespace MimeKit;

[AttributeUsage(AttributeTargets.Field)]
internal class HeaderNameAttribute : Attribute
{
	public string HeaderName { get; protected set; }

	public HeaderNameAttribute(string name)
	{
		HeaderName = name;
	}
}
