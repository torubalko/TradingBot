using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal class P4 : ICompletionFilter, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string cFX;

	private static P4 dLJ;

	public string GroupName
	{
		[CompilerGenerated]
		get
		{
			return cFX;
		}
		[CompilerGenerated]
		set
		{
			cFX = text;
		}
	}

	public bool IsActive
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public string Key => Q7Z.tqM(191666);

	public P4()
	{
		grA.DaB7cz();
		base._002Ector();
		IsActive = true;
	}

	public CompletionFilterResult Filter(ICompletionSession P_0, ICompletionItem P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return CompletionFilterResult.Included;
		}
		string typedText = P_0.TypedText;
		if (string.IsNullOrEmpty(typedText))
		{
			return CompletionFilterResult.Included;
		}
		ICompletionItemMatcherCollection itemMatchers = P_0.ItemMatchers;
		if (itemMatchers == null)
		{
			return CompletionFilterResult.Included;
		}
		foreach (ICompletionItemMatcher item in itemMatchers)
		{
			if (item.Match(P_0, new ICompletionItem[1] { P_1 }, typedText, uniqueFullMatchOnly: true) != null)
			{
				return CompletionFilterResult.Included;
			}
		}
		return CompletionFilterResult.Excluded;
	}

	internal static bool nLR()
	{
		return dLJ == null;
	}

	internal static P4 iLO()
	{
		return dLJ;
	}
}
