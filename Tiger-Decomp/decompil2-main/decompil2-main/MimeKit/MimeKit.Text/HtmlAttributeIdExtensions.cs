using System;
using System.Collections.Generic;
using System.Reflection;
using MimeKit.Utils;

namespace MimeKit.Text;

public static class HtmlAttributeIdExtensions
{
	private static readonly Dictionary<string, HtmlAttributeId> AttributeNameToId;

	static HtmlAttributeIdExtensions()
	{
		HtmlAttributeId[] array = (HtmlAttributeId[])Enum.GetValues(typeof(HtmlAttributeId));
		AttributeNameToId = new Dictionary<string, HtmlAttributeId>(array.Length - 1, MimeUtils.OrdinalIgnoreCase);
		for (int i = 1; i < array.Length; i++)
		{
			AttributeNameToId.Add(array[i].ToAttributeName(), array[i]);
		}
	}

	public static string ToAttributeName(this HtmlAttributeId value)
	{
		string text = value.ToString();
		FieldInfo field = typeof(HtmlAttributeId).GetField(text);
		object[] customAttributes = field.GetCustomAttributes(typeof(HtmlAttributeNameAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Length == 1)
		{
			return ((HtmlAttributeNameAttribute)customAttributes[0]).Name;
		}
		return text.ToLowerInvariant();
	}

	internal static HtmlAttributeId ToHtmlAttributeId(this string name)
	{
		if (!AttributeNameToId.TryGetValue(name, out var value))
		{
			return HtmlAttributeId.Unknown;
		}
		return value;
	}
}
