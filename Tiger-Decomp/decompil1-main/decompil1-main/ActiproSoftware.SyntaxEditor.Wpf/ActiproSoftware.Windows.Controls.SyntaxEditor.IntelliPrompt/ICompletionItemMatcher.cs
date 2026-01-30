using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionItemMatcher : IKeyedObject
{
	IEnumerable<TextRange> GetHighlightedTextRanges(ICompletionSession session, ICompletionItem item, string text);

	CompletionSelection Match(ICompletionSession session, IEnumerable items, string text, bool uniqueFullMatchOnly);
}
