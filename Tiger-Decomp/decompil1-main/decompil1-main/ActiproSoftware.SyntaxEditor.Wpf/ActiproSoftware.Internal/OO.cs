using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

namespace ActiproSoftware.Internal;

internal class OO : RegexCompletionItemMatcherBase
{
	private Regex GRf;

	private static OO Vg5;

	public override string Key => Q7Z.tqM(192766);

	private static Regex KRK(string P_0, bool P_1)
	{
		string pattern = Q7Z.tqM(13992) + Regex.Escape(P_0) + Q7Z.tqM(14000);
		return new Regex(pattern, (RegexOptions)((P_1 ? 1 : 0) | 0x10));
	}

	protected override Regex GetRegex(string P_0)
	{
		return KRK(P_0, _0020: true);
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public override CompletionSelection Match(ICompletionSession P_0, IEnumerable P_1, string P_2, bool P_3)
	{
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
		CompletionMatchOptions matchOptions = P_0.MatchOptions;
		bool flag = (matchOptions & CompletionMatchOptions.IsCaseInsensitive) == 0;
		bool flag2 = (matchOptions & CompletionMatchOptions.TargetsDisplayText) == CompletionMatchOptions.TargetsDisplayText;
		bool flag3 = (matchOptions & CompletionMatchOptions.RequiresExact) == CompletionMatchOptions.RequiresExact;
		ICompletionItem completionItem = null;
		bool flag4 = false;
		if (P_2 != yRx)
		{
			OnTextChanged(P_2);
		}
		Regex mRa = MRa;
		Regex gRf = GRf;
		if (mRa == null || gRf == null)
		{
			return null;
		}
		foreach (ICompletionItem item in P_1)
		{
			string text = (flag2 ? item.Text : (item.AutoCompletePreText ?? item.Text)) ?? string.Empty;
			if (!mRa.IsMatch(text))
			{
				continue;
			}
			if (flag4)
			{
				return new CompletionSelection(completionItem, CompletionSelectionState.Partial);
			}
			if (completionItem == null)
			{
				completionItem = item;
				flag4 = P_3 && !flag3;
			}
			if (!flag && !flag4)
			{
				break;
			}
			if (gRf.IsMatch(text))
			{
				completionItem = item;
				if (flag3 && P_2.Equals(text, StringComparison.Ordinal))
				{
					return new CompletionSelection(completionItem, CompletionSelectionState.Full);
				}
				if (!flag4)
				{
					break;
				}
			}
		}
		if (completionItem == null)
		{
			return null;
		}
		CompletionSelectionState state = CompletionSelectionState.Full;
		if (flag3)
		{
			string value = (flag2 ? completionItem.Text : (completionItem.AutoCompletePreText ?? completionItem.Text)) ?? string.Empty;
			if (!P_2.Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				state = CompletionSelectionState.Partial;
			}
		}
		return new CompletionSelection(completionItem, state);
	}

	protected override void OnTextChanged(string P_0)
	{
		base.OnTextChanged(P_0);
		GRf = KRK(P_0, _0020: false);
	}

	public OO()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool zgG()
	{
		return Vg5 == null;
	}

	internal static OO vgN()
	{
		return Vg5;
	}
}
