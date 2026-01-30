using System;
using System.Collections.Generic;
using System.Reflection;
using MimeKit.Utils;

namespace MimeKit.Text;

public static class HtmlTagIdExtensions
{
	private static readonly Dictionary<string, HtmlTagId> TagNameToId;

	static HtmlTagIdExtensions()
	{
		HtmlTagId[] array = (HtmlTagId[])Enum.GetValues(typeof(HtmlTagId));
		TagNameToId = new Dictionary<string, HtmlTagId>(array.Length - 1, MimeUtils.OrdinalIgnoreCase);
		for (int i = 0; i < array.Length - 1; i++)
		{
			TagNameToId.Add(array[i].ToHtmlTagName(), array[i]);
		}
	}

	public static string ToHtmlTagName(this HtmlTagId value)
	{
		if (value == HtmlTagId.Comment)
		{
			return "!";
		}
		string text = value.ToString();
		FieldInfo field = typeof(HtmlTagId).GetField(text);
		object[] customAttributes = field.GetCustomAttributes(typeof(HtmlTagNameAttribute), inherit: false);
		if (customAttributes != null && customAttributes.Length == 1)
		{
			return ((HtmlTagNameAttribute)customAttributes[0]).Name;
		}
		return text.ToLowerInvariant();
	}

	internal static HtmlTagId ToHtmlTagId(this string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return HtmlTagId.Unknown;
		}
		if (name[0] == '!')
		{
			return HtmlTagId.Comment;
		}
		if (!TagNameToId.TryGetValue(name, out var value))
		{
			return HtmlTagId.Unknown;
		}
		return value;
	}

	public static bool IsEmptyElement(this HtmlTagId id)
	{
		switch (id)
		{
		case HtmlTagId.Area:
		case HtmlTagId.Base:
		case HtmlTagId.Br:
		case HtmlTagId.Col:
		case HtmlTagId.Command:
		case HtmlTagId.Embed:
		case HtmlTagId.HR:
		case HtmlTagId.Image:
		case HtmlTagId.Input:
		case HtmlTagId.Keygen:
		case HtmlTagId.Link:
		case HtmlTagId.Meta:
		case HtmlTagId.Param:
		case HtmlTagId.Source:
		case HtmlTagId.Track:
		case HtmlTagId.Wbr:
			return true;
		default:
			return false;
		}
	}

	public static bool IsFormattingElement(this HtmlTagId id)
	{
		switch (id)
		{
		case HtmlTagId.A:
		case HtmlTagId.B:
		case HtmlTagId.Big:
		case HtmlTagId.Code:
		case HtmlTagId.EM:
		case HtmlTagId.Font:
		case HtmlTagId.I:
		case HtmlTagId.NoBR:
		case HtmlTagId.S:
		case HtmlTagId.Small:
		case HtmlTagId.Strike:
		case HtmlTagId.Strong:
		case HtmlTagId.TT:
		case HtmlTagId.U:
			return true;
		default:
			return false;
		}
	}
}
