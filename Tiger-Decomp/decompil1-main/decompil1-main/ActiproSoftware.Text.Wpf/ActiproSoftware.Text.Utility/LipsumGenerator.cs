using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Utility;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Lipsum")]
public class LipsumGenerator
{
	private IList<string> HVX;

	private IList<string> oVN;

	private static LipsumGenerator rWq;

	public LipsumGenerator()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(OVE(), UV3());
	}

	public LipsumGenerator(string startingWords, string words)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (string.IsNullOrEmpty(words))
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1828));
		}
		HVX = QVK(startingWords);
		oVN = QVK(words);
		if (oVN.Count == 0)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1842), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1828));
		}
	}

	private void kVo(StringBuilder P_0, int P_1, Random P_2)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		if (!kWc())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num4 = default(int);
		num3 = num4;
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num3)
			{
			case 1:
				num2++;
				break;
			}
			if (num2 >= P_1)
			{
				return;
			}
			string text = null;
			if (num2 == P_1 - 1)
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1898);
			}
			else if (num > 3 && num2 < P_1 - 3 && P_2.NextDouble() < 0.25)
			{
				num = -1;
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1904);
			}
			string text2 = oVN[P_2.Next(oVN.Count)];
			zV4(P_0, text2, text);
			num++;
			num3 = 1;
		}
		while (kWc());
		goto IL_0005;
	}

	private int VVD(StringBuilder P_0, int P_1)
	{
		int num = Math.Min(HVX.Count, P_1);
		bool flag = num == P_1 || P_1 - num >= 3;
		for (int i = 0; i < num; i++)
		{
			string text = null;
			if (i == num - 1 && flag)
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1898);
			}
			else if (i == 4 && num > 6 && KVk(HVX))
			{
				text = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1904);
			}
			zV4(P_0, HVX[i], text);
		}
		return num;
	}

	private void nV1(StringBuilder P_0, int P_1)
	{
		int num = 1;
		Random random = default(Random);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					goto IL_0081;
				}
				while (P_1 > 0)
				{
					int num3 = Math.Min(P_1, random.Next(6, 25));
					if (P_1 - num3 > 0 && P_1 - num3 < 4)
					{
						num3 = P_1;
					}
					kVo(P_0, num3, random);
					P_1 -= num3;
				}
				return;
				IL_0081:
				random = new Random();
				num2 = 0;
			}
			while (kWc());
		}
	}

	private static void zV4(StringBuilder P_0, string P_1, string P_2)
	{
		bool flag = P_0.Length == 0 || WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1910).IndexOfAny(new char[1] { P_0[P_0.Length - 1] }) != -1;
		if (P_0.Length > 0)
		{
			P_0.Append(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
		}
		if (!flag)
		{
			P_0.Append(P_1);
			int num = 0;
			if (CWf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			P_0.Append(P_1.Substring(0, 1).ToUpperInvariant());
			P_0.Append(P_1.Substring(1));
		}
		if (!string.IsNullOrEmpty(P_2))
		{
			P_0.Append(P_2);
		}
	}

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	private static IList<string> QVK(string P_0)
	{
		if (!string.IsNullOrEmpty(P_0))
		{
			P_0 = Regex.Replace(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1926), WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1920));
			string[] source = Regex.Split(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1946));
			return (from w in source
				where !string.IsNullOrEmpty(w)
				select w.ToLowerInvariant()).ToArray();
		}
		return new string[0];
	}

	private static bool KVk(IList<string> P_0)
	{
		return P_0 != null && P_0.Count == 8 && P_0[0] == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1954) && P_0[P_0.Count - 1] == WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1968);
	}

	[SpecialName]
	private static string OVE()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1980);
	}

	[SpecialName]
	private static string UV3()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(2094);
	}

	public string GenerateParagraph(bool useStartingWords, int wordCount)
	{
		if (wordCount <= 0)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5172));
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (useStartingWords)
		{
			wordCount -= VVD(stringBuilder, wordCount);
			int num = 0;
			if (CWf() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		nV1(stringBuilder, wordCount);
		return stringBuilder.ToString();
	}

	internal static bool kWc()
	{
		return rWq == null;
	}

	internal static LipsumGenerator CWf()
	{
		return rWq;
	}
}
