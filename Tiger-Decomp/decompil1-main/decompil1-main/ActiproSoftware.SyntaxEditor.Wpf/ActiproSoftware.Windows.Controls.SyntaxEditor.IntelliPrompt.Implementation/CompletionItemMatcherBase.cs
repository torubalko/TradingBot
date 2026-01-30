using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class CompletionItemMatcherBase : ICompletionItemMatcher, IKeyedObject
{
	private static CompletionItemMatcherBase saU;

	public abstract string Key { get; }

	public virtual IEnumerable<TextRange> GetHighlightedTextRanges(ICompletionSession session, ICompletionItem item, string text)
	{
		return null;
	}

	public abstract CompletionSelection Match(ICompletionSession session, IEnumerable items, string text, bool uniqueFullMatchOnly);

	protected CompletionItemMatcherBase()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool pae()
	{
		return saU == null;
	}

	internal static CompletionItemMatcherBase aaz()
	{
		return saU;
	}
}
