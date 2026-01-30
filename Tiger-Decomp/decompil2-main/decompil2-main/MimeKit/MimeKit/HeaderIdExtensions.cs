using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MimeKit.Utils;

namespace MimeKit;

public static class HeaderIdExtensions
{
	private static readonly Dictionary<string, HeaderId> dict;

	static HeaderIdExtensions()
	{
		HeaderId[] array = (HeaderId[])Enum.GetValues(typeof(HeaderId));
		dict = new Dictionary<string, HeaderId>(array.Length - 1, MimeUtils.OrdinalIgnoreCase);
		for (int i = 0; i < array.Length - 1; i++)
		{
			dict.Add(array[i].ToHeaderName(), array[i]);
		}
	}

	public static string ToHeaderName(this HeaderId value)
	{
		string text = value.ToString();
		FieldInfo field = typeof(HeaderId).GetField(text);
		object[] customAttributes = field.GetCustomAttributes(typeof(HeaderNameAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Length == 1)
		{
			return ((HeaderNameAttribute)customAttributes[0]).HeaderName;
		}
		StringBuilder stringBuilder = new StringBuilder(text);
		for (int i = 1; i < stringBuilder.Length; i++)
		{
			if (char.IsUpper(stringBuilder[i]))
			{
				stringBuilder.Insert(i++, '-');
			}
		}
		return stringBuilder.ToString();
	}

	internal static HeaderId ToHeaderId(this string name)
	{
		if (!dict.TryGetValue(name, out var value))
		{
			return HeaderId.Unknown;
		}
		return value;
	}
}
