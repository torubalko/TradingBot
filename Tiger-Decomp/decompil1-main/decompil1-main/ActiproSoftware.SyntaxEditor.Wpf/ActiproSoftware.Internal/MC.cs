using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Internal;

internal class MC : RegexCompletionItemMatcherBase
{
	internal static MC KgA;

	public override string Key => Q7Z.tqM(192744);

	public override IEnumerable<TextRange> GetHighlightedTextRanges(ICompletionSession P_0, ICompletionItem P_1, string P_2)
	{
		if (P_0 == null || (P_0.MatchOptions & CompletionMatchOptions.UseShorthand) != CompletionMatchOptions.UseShorthand)
		{
			return null;
		}
		return base.GetHighlightedTextRanges(P_0, P_1, P_2);
	}

	protected override Regex GetRegex(string P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192708));
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(Q7Z.tqM(192734));
		for (int i = 0; i < P_0.Length; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(Q7Z.tqM(192734));
			}
			stringBuilder.Append(Q7Z.tqM(14044) + Regex.Escape(P_0[i].ToString()) + Q7Z.tqM(14000));
		}
		Regex regex = new Regex(stringBuilder.ToString(), RegexOptions.IgnoreCase | RegexOptions.Singleline);
		int num = 0;
		if (hgW() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => regex, 
		};
	}

	public override CompletionSelection Match(ICompletionSession P_0, IEnumerable P_1, string P_2, bool P_3)
	{
		if (P_0 != null && (P_0.MatchOptions & CompletionMatchOptions.UseShorthand) == CompletionMatchOptions.UseShorthand)
		{
			return base.Match(P_0, P_1, P_2, P_3);
		}
		return null;
	}

	public MC()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool Cgl()
	{
		return KgA == null;
	}

	internal static MC hgW()
	{
		return KgA;
	}
}
