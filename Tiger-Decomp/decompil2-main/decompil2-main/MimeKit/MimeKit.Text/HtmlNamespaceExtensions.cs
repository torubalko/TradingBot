using System;

namespace MimeKit.Text;

internal static class HtmlNamespaceExtensions
{
	private static readonly int NamespacePrefixLength = "http://www.w3.org/".Length;

	private static readonly string[] NamespaceValues = new string[6] { "http://www.w3.org/1999/xhtml", "http://www.w3.org/1998/Math/MathML", "http://www.w3.org/2000/svg", "http://www.w3.org/1999/xlink", "http://www.w3.org/XML/1998/namespace", "http://www.w3.org/2000/xmlns/" };

	public static string ToNamespaceUrl(this HtmlNamespace value)
	{
		if (value < HtmlNamespace.Html || (int)value >= NamespaceValues.Length)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		return NamespaceValues[(int)value];
	}

	public static HtmlNamespace ToHtmlNamespace(this string ns)
	{
		if (ns == null)
		{
			throw new ArgumentNullException("ns");
		}
		if (!ns.StartsWith("http://www.w3.org/", StringComparison.OrdinalIgnoreCase))
		{
			return HtmlNamespace.Html;
		}
		for (int i = 0; i < NamespaceValues.Length; i++)
		{
			if (ns.Length == NamespaceValues[i].Length && string.Compare(ns, NamespacePrefixLength, NamespaceValues[i], NamespacePrefixLength, ns.Length - NamespacePrefixLength, StringComparison.OrdinalIgnoreCase) == 0)
			{
				return (HtmlNamespace)i;
			}
		}
		return HtmlNamespace.Html;
	}
}
