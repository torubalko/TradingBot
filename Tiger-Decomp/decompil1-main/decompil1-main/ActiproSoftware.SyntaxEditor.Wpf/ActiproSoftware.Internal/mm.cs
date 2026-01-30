using System;
using System.Collections;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Internal;

internal class mm : CompletionItemMatcherBase
{
	private static mm wgH;

	public override string Key => Q7Z.tqM(192790);

	public override CompletionSelection Match(ICompletionSession P_0, IEnumerable P_1, string P_2, bool P_3)
	{
		if (P_3)
		{
			return null;
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192720));
		}
		if (P_2 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192708));
		}
		bool flag = (P_0.MatchOptions & CompletionMatchOptions.TargetsDisplayText) == CompletionMatchOptions.TargetsDisplayText;
		int length = P_2.Length;
		ICompletionItem completionItem = null;
		while (length > 1)
		{
			P_2 = P_2.Substring(0, P_2.Length - 1);
			length = P_2.Length;
			foreach (ICompletionItem item in P_1)
			{
				string strB = (flag ? item.Text : (item.AutoCompletePreText ?? item.Text)) ?? string.Empty;
				if (string.Compare(P_2, 0, strB, 0, length, StringComparison.OrdinalIgnoreCase) == 0)
				{
					completionItem = item;
					break;
				}
			}
			if (completionItem != null)
			{
				break;
			}
		}
		return (completionItem != null) ? new CompletionSelection(completionItem, CompletionSelectionState.Partial) : null;
	}

	public mm()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool Igj()
	{
		return wgH == null;
	}

	internal static mm xgM()
	{
		return wgH;
	}
}
