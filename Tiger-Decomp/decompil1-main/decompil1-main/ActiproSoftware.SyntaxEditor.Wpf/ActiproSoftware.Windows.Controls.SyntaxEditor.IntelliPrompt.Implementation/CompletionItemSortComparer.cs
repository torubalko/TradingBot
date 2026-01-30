using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CompletionItemSortComparer : IComparer<ICompletionItem>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ICompletionSession s1Q;

	internal static CompletionItemSortComparer OLD;

	public ICompletionSession Session
	{
		[CompilerGenerated]
		get
		{
			return s1Q;
		}
		[CompilerGenerated]
		private set
		{
			s1Q = value;
		}
	}

	public CompletionItemSortComparer(ICompletionSession session)
	{
		grA.DaB7cz();
		base._002Ector();
		if (session == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8536));
		}
		Session = session;
	}

	public virtual int Compare(ICompletionItem x, ICompletionItem y)
	{
		bool flag = (Session.MatchOptions & CompletionMatchOptions.TargetsDisplayText) == CompletionMatchOptions.TargetsDisplayText;
		string strA = ((x == null) ? null : (flag ? (x.Text ?? x.AutoCompletePreText) : (x.AutoCompletePreText ?? x.Text)));
		string strB = ((y == null) ? null : (flag ? (y.Text ?? y.AutoCompletePreText) : (y.AutoCompletePreText ?? y.Text)));
		return string.Compare(strA, strB, StringComparison.CurrentCultureIgnoreCase);
	}

	internal static bool TLB()
	{
		return OLD == null;
	}

	internal static CompletionItemSortComparer XL0()
	{
		return OLD;
	}
}
