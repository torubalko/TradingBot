using System.Text;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class WildcardSearchPatternProvider : SearchPatternProviderBase
{
	private static WildcardSearchPatternProvider BVe;

	internal WildcardSearchPatternProvider()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6572), SR.GetString(SRName.UISearchPatternProviderWildcard));
	}

	private static string Wuq(string P_0)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < P_0.Length; i++)
		{
			char c = P_0[i];
			switch (c)
			{
			case '\t':
			case '\n':
			case ' ':
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6592));
				break;
			case '?':
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6604));
				break;
			case '#':
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6614));
				break;
			case '*':
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6626));
				break;
			case '[':
			{
				bool flag = ++i < P_0.Length && P_0[i] == '!';
				if (flag)
				{
					i++;
				}
				CharClass charClass = new CharClass();
				for (; i < P_0.Length; i++)
				{
					c = P_0[i];
					if (c == ']')
					{
						break;
					}
					charClass.Add(c);
				}
				if (flag)
				{
					charClass.IsNegated = !charClass.IsNegated;
				}
				stringBuilder.Append(charClass.ToString());
				break;
			}
			default:
				if (RegexHelper.IsPatternSpecialChar(c))
				{
					stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6126) + c);
				}
				else
				{
					stringBuilder.Append(c);
				}
				break;
			}
		}
		return stringBuilder.ToString();
	}

	public override string GetFindPattern(string pattern)
	{
		return Wuq(pattern);
	}

	internal static bool SVg()
	{
		return BVe == null;
	}

	internal static WildcardSearchPatternProvider vVp()
	{
		return BVe;
	}
}
