using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ActiproSoftware.Products.Text;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class TextStatistics : ITextStatistics
{
	private int Yd8;

	private int ydT;

	private int nd2;

	private int Ydm;

	private int Vdc;

	private int Ydh;

	private int Hdd;

	private int ydL;

	private int gdq;

	internal static TextStatistics M20;

	public double AverageLettersPerWord => (double)ydT / (double)((gdq == 0) ? 1 : gdq);

	public double AverageSyllablesPerWord => (double)Vdc / (double)((gdq == 0) ? 1 : gdq);

	public double AverageWordsPerSentence => (double)gdq / (double)((Ydm == 0) ? 1 : Ydm);

	public int Characters => Yd8;

	public int Consonants => ydT - Ydh;

	public double FleschKincaidGradeLevel => Math.Max(0.0, 0.38999998569488525 * AverageWordsPerSentence + 11.800000190734863 * AverageSyllablesPerWord - 15.59000015258789);

	public double FleschReadingEaseScore => Math.Max(0.0, Math.Min(100.0, 206.8350067138672 - 1.0149999856948853 * AverageWordsPerSentence - 84.5999984741211 * AverageSyllablesPerWord));

	public int Letters => ydT;

	public int Lines => nd2;

	public int NonWhitespaceCharacters => Yd8 - Hdd;

	public int NonWhitespaceLines => nd2 - ydL;

	public int Sentences => Ydm;

	public int Syllables => Vdc;

	public int Vowels => Ydh;

	public int WhitespaceCharacters => Hdd;

	public int WhitespaceLines => ydL;

	public int Words => gdq;

	public TextStatistics(string text)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		ed9(text);
	}

	private void ed9(string P_0)
	{
		Yd8 = P_0.Length;
		Hdd = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1946), RegexOptions.IgnoreCase).Count;
		ydT = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9298), RegexOptions.IgnoreCase).Count;
		nd2 = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9318), RegexOptions.IgnoreCase).Count + 1;
		ydL = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9330), RegexOptions.Multiline).Count;
		Ydm = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9350), RegexOptions.IgnoreCase).Count;
		Ydh = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9372), RegexOptions.IgnoreCase).Count;
		MatchCollection matchCollection = Regex.Matches(P_0, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9404), RegexOptions.IgnoreCase);
		gdq = matchCollection.Count;
		Vdc = 0;
		foreach (Match item in matchCollection)
		{
			Vdc += vdA(item.Value);
		}
	}

	private static int vdA(string P_0)
	{
		bool flag = false;
		int length = P_0.Length;
		int num = 0;
		if (length <= 3)
		{
			return 1;
		}
		for (int i = 0; i < length; i++)
		{
			if (Ndu(P_0[i]))
			{
				if (!flag)
				{
					if (i == length - 1)
					{
						num++;
					}
					else if (P_0[i + 1] != '\'')
					{
						num++;
					}
				}
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
		if (P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9420), StringComparison.OrdinalIgnoreCase) && !P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9426), StringComparison.OrdinalIgnoreCase) && !Ndu(P_0[length - 2]))
		{
			num--;
		}
		if ((P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9434), StringComparison.OrdinalIgnoreCase) || P_0.EndsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9442), StringComparison.OrdinalIgnoreCase)) && !Ndu(P_0[length - 3]))
		{
			num--;
		}
		return num;
	}

	private static bool Ndu(char P_0)
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9450).IndexOf(P_0.ToString(), StringComparison.OrdinalIgnoreCase) != -1;
	}

	public static ITextStatistic CreateStatistic(string key, string description, object value)
	{
		return new TextStatistic
		{
			Key = key,
			Description = description,
			Value = value
		};
	}

	public virtual IList<ITextStatistic> GetRawStatistics()
	{
		List<ITextStatistic> list = new List<ITextStatistic>();
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9466), SR.GetString(SRName.UITextStatisticLines), Lines));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9480), SR.GetString(SRName.UITextStatisticNonWhitespaceLines), NonWhitespaceLines));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9520), SR.GetString(SRName.UITextStatisticSentences), Sentences));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9542), SR.GetString(SRName.UITextStatisticWords), Words));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9556), SR.GetString(SRName.UITextStatisticSyllables), Syllables));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9578), SR.GetString(SRName.UITextStatisticCharacters), Characters));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9602), SR.GetString(SRName.UITextStatisticNonWhitespaceCharacters), NonWhitespaceCharacters));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9652), SR.GetString(SRName.UITextStatisticLetters), Letters));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9670), SR.GetString(SRName.UITextStatisticConsonants), Consonants));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9694), SR.GetString(SRName.UITextStatisticVowels), Vowels));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9710), SR.GetString(SRName.UITextStatisticAverageWordsPerSentence), AverageWordsPerSentence));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9760), SR.GetString(SRName.UITextStatisticAverageSyllablesPerWord), AverageSyllablesPerWord));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9810), SR.GetString(SRName.UITextStatisticAverageLettersPerWord), AverageLettersPerWord));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9856), SR.GetString(SRName.UITextStatisticFleschReadingEaseScore), FleschReadingEaseScore));
		list.Add(CreateStatistic(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(9904), SR.GetString(SRName.UITextStatisticFleschKincaidGradeLevel), FleschKincaidGradeLevel));
		return list;
	}

	internal static bool A2N()
	{
		return M20 == null;
	}

	internal static TextStatistics v2r()
	{
		return M20;
	}
}
