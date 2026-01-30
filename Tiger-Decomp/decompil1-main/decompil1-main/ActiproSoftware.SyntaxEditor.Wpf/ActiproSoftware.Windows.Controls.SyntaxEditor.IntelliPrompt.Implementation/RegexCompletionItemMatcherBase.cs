using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class RegexCompletionItemMatcherBase : CompletionItemMatcherBase
{
	internal Regex MRa;

	internal string yRx;

	internal static RegexCompletionItemMatcherBase uga;

	public override IEnumerable<TextRange> GetHighlightedTextRanges(ICompletionSession session, ICompletionItem item, string text)
	{
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		if (item == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12126));
		}
		if (text == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192708));
		}
		string input = item.Text ?? string.Empty;
		if (text != yRx)
		{
			OnTextChanged(text);
		}
		Regex mRa = MRa;
		if (mRa == null)
		{
			return null;
		}
		Match match = mRa.Match(input);
		if (match.Groups.Count > 1)
		{
			List<TextRange> list = new List<TextRange>();
			for (int i = 1; i < match.Groups.Count; i++)
			{
				list.Add(TextRange.FromSpan(match.Groups[i].Index, match.Groups[i].Length));
			}
			return list;
		}
		return null;
	}

	protected abstract Regex GetRegex(string text);

	public override CompletionSelection Match(ICompletionSession session, IEnumerable items, string text, bool uniqueFullMatchOnly)
	{
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		if (items == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192720));
		}
		if (text == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192708));
		}
		if (text != yRx)
		{
			OnTextChanged(text);
		}
		Regex mRa = MRa;
		if (mRa == null)
		{
			return null;
		}
		bool flag = (session.MatchOptions & CompletionMatchOptions.TargetsDisplayText) == CompletionMatchOptions.TargetsDisplayText;
		bool flag2 = (session.MatchOptions & CompletionMatchOptions.RequiresExact) == CompletionMatchOptions.RequiresExact;
		ICompletionItem completionItem = null;
		bool flag3 = false;
		foreach (ICompletionItem item in items)
		{
			string input = (flag ? item.Text : (item.AutoCompletePreText ?? item.Text)) ?? string.Empty;
			if (!mRa.IsMatch(input))
			{
				continue;
			}
			if (flag3)
			{
				return new CompletionSelection(completionItem, CompletionSelectionState.Partial);
			}
			if (completionItem == null)
			{
				completionItem = item;
				flag3 = uniqueFullMatchOnly;
				if (!flag3)
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
		if (flag2)
		{
			string value = (flag ? completionItem.Text : (completionItem.AutoCompletePreText ?? completionItem.Text)) ?? string.Empty;
			if (!text.Equals(value, StringComparison.OrdinalIgnoreCase))
			{
				state = CompletionSelectionState.Partial;
			}
		}
		return new CompletionSelection(completionItem, state);
	}

	protected virtual void OnTextChanged(string text)
	{
		yRx = text;
		MRa = GetRegex(text);
	}

	protected RegexCompletionItemMatcherBase()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool AgL()
	{
		return uga == null;
	}

	internal static RegexCompletionItemMatcherBase Qgg()
	{
		return uga;
	}
}
