using System.Text;
using ActiproSoftware.Products.Text;
using ActiproSoftware.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class AcronymSearchPatternProvider : SearchPatternProviderBase
{
	internal static AcronymSearchPatternProvider HVM;

	public override bool RequiresCaseSensitivity => true;

	internal AcronymSearchPatternProvider()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6036), SR.GetString(SRName.UISearchPatternProviderAcronym));
	}

	private static string nAv(string P_0)
	{
		P_0 = P_0.ToUpperInvariant();
		StringBuilder stringBuilder = new StringBuilder();
		if (char.IsLetter(P_0[0]))
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6054) + RegexHelper.Escape(char.ToLowerInvariant(P_0[0]).ToString()) + RegexHelper.Escape(char.ToUpperInvariant(P_0[0]).ToString()) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6066));
		}
		else if (char.IsWhiteSpace(P_0[0]))
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6074));
		}
		else
		{
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6108) + RegexHelper.Escape(P_0[0].ToString()) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120));
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
			stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6132) + text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6182));
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
				stringBuilder.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6222) + RegexHelper.Escape(P_0[i].ToString()) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6120));
			}
		}
		return stringBuilder.ToString();
	}

	public override string GetFindPattern(string pattern)
	{
		return nAv(pattern);
	}

	internal static bool uVZ()
	{
		return HVM == null;
	}

	internal static AcronymSearchPatternProvider OV9()
	{
		return HVM;
	}
}
