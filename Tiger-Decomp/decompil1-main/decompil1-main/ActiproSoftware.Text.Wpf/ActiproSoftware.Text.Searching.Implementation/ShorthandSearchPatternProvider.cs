using System.Text;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class ShorthandSearchPatternProvider : SearchPatternProviderBase
{
	private static ShorthandSearchPatternProvider HVy;

	internal ShorthandSearchPatternProvider()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6416), SR.GetString(SRName.UISearchPatternProviderShorthand));
	}

	private static string oAz(string P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (char.IsLetter(P_0[0]))
		{
			stringBuilder.Append(RegexHelper.Escape(P_0[0].ToString()));
		}
		else if (char.IsWhiteSpace(P_0[0]))
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6438));
		}
		else
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6468) + RegexHelper.Escape(P_0[0].ToString()) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6476));
		}
		for (int i = 1; i < P_0.Length; i++)
		{
			string text = string.Empty;
			if (char.IsLetter(P_0[i]))
			{
				text = RegexHelper.Escape(P_0[i].ToString());
			}
			else if (!char.IsWhiteSpace(P_0[i]))
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6126) + RegexHelper.Escape(P_0[i].ToString());
			}
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6484) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6182));
			if (char.IsLetter(P_0[i]))
			{
				stringBuilder.Append(RegexHelper.Escape(P_0[i].ToString()));
			}
			else if (char.IsWhiteSpace(P_0[i]))
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6190));
			}
			else
			{
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6468) + RegexHelper.Escape(P_0[i].ToString()) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6476));
			}
		}
		return stringBuilder.ToString();
	}

	public override string GetFindPattern(string pattern)
	{
		return oAz(pattern);
	}

	internal static bool fVF()
	{
		return HVy == null;
	}

	internal static ShorthandSearchPatternProvider VVO()
	{
		return HVy;
	}
}
