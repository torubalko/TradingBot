using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Internal;

internal class on : RegexCompletionItemMatcherBase
{
	internal static on UaG;

	public override string Key => Q7Z.tqM(14050);

	public override IEnumerable<TextRange> GetHighlightedTextRanges(ICompletionSession P_0, ICompletionItem P_1, string P_2)
	{
		if (P_0 == null || (P_0.MatchOptions & CompletionMatchOptions.UseAcronyms) != CompletionMatchOptions.UseAcronyms)
		{
			return null;
		}
		return base.GetHighlightedTextRanges(P_0, P_1, P_2);
	}

	protected override Regex GetRegex(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		P_0 = P_0.ToUpperInvariant();
		StringBuilder stringBuilder = new StringBuilder();
		if (char.IsLetter(P_0[0]))
		{
			stringBuilder.Append(Q7Z.tqM(13974) + Regex.Escape(char.ToLowerInvariant(P_0[0]).ToString()) + Regex.Escape(char.ToUpperInvariant(P_0[0]).ToString()) + Q7Z.tqM(13984));
		}
		else
		{
			stringBuilder.Append(Q7Z.tqM(13992) + Regex.Escape(P_0[0].ToString()) + Q7Z.tqM(14000));
		}
		for (int i = 1; i < P_0.Length; i++)
		{
			stringBuilder.Append(Q7Z.tqM(14006));
			stringBuilder.Append(Q7Z.tqM(14044) + Regex.Escape(P_0[i].ToString()) + Q7Z.tqM(14000));
		}
		return new Regex(stringBuilder.ToString(), RegexOptions.Singleline);
	}

	public override CompletionSelection Match(ICompletionSession P_0, IEnumerable P_1, string P_2, bool P_3)
	{
		if (P_0 == null || (P_0.MatchOptions & CompletionMatchOptions.UseAcronyms) != CompletionMatchOptions.UseAcronyms)
		{
			return null;
		}
		return base.Match(P_0, P_1, P_2, P_3);
	}

	public on()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool laN()
	{
		return UaG == null;
	}

	internal static on JaH()
	{
		return UaG;
	}
}
