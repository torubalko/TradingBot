using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class NavigableSymbolContentProviderComparer : IComparer<INavigableSymbol>
{
	private Regex d3G;

	internal static NavigableSymbolContentProviderComparer GLK;

	private string c3x(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			if (d3G == null)
			{
				d3G = new Regex(Q7Z.tqM(192610), RegexOptions.Compiled);
			}
			return d3G.Replace(P_0, string.Empty).Trim();
		}
		return P_0;
	}

	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "1#")]
	[SuppressMessage("Microsoft.Naming", "CA1725:ParameterNamesShouldMatchBaseDeclaration", MessageId = "0#")]
	public int Compare(INavigableSymbol left, INavigableSymbol right)
	{
		if (left != null)
		{
			bool flag = default(bool);
			PlainTextContentProvider plainTextContentProvider2 = default(PlainTextContentProvider);
			int num2 = default(int);
			while (right != null)
			{
				string text = null;
				if (!(left.ContentProvider is HtmlContentProvider htmlContentProvider))
				{
					if (left.ContentProvider is PlainTextContentProvider plainTextContentProvider)
					{
						text = plainTextContentProvider.Text;
					}
				}
				else
				{
					text = c3x(htmlContentProvider.HtmlSnippet);
				}
				if (text != null)
				{
					string text2 = null;
					HtmlContentProvider htmlContentProvider2 = right.ContentProvider as HtmlContentProvider;
					int num = 0;
					if (QLr() != null)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 2:
							break;
						case 3:
							goto IL_00c1;
						default:
							goto IL_0114;
						case 1:
							if (flag)
							{
								text2 = plainTextContentProvider2.Text;
								num = 3;
								continue;
							}
							goto IL_00c1;
						}
						break;
						IL_0114:
						if (htmlContentProvider2 != null)
						{
							text2 = c3x(htmlContentProvider2.HtmlSnippet);
							goto IL_00c1;
						}
						plainTextContentProvider2 = right.ContentProvider as PlainTextContentProvider;
						flag = plainTextContentProvider2 != null;
						num = 1;
						if (!JLC())
						{
							num = num2;
						}
						continue;
						IL_00c1:
						if (text2 != null)
						{
							return string.Compare(text, text2, StringComparison.OrdinalIgnoreCase);
						}
						goto IL_004d;
					}
					continue;
				}
				goto IL_004d;
				IL_004d:
				return 0;
			}
			return -1;
		}
		return (right != null) ? 1 : 0;
	}

	public NavigableSymbolContentProviderComparer()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool JLC()
	{
		return GLK == null;
	}

	internal static NavigableSymbolContentProviderComparer QLr()
	{
		return GLK;
	}
}
