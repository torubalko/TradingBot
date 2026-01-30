using System;
using System.Collections.Generic;

namespace MailKit;

internal static class UriExtensions
{
	public static IDictionary<string, string> ParsedQuery(this Uri uri)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		int i = 1;
		if (string.IsNullOrEmpty(uri.Query))
		{
			return dictionary;
		}
		while (i < uri.Query.Length)
		{
			int num = i;
			for (; i < uri.Query.Length && uri.Query[i] != '='; i++)
			{
			}
			string key = uri.Query.Substring(num, i - num);
			if (i >= uri.Query.Length)
			{
				dictionary.Add(key, string.Empty);
				break;
			}
			num = ++i;
			for (; i < uri.Query.Length && uri.Query[i] != '&'; i++)
			{
			}
			string stringToUnescape = uri.Query.Substring(num, i - num);
			dictionary.Add(key, Uri.UnescapeDataString(stringToUnescape));
			i++;
		}
		return dictionary;
	}
}
