using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionItemMatcherCollection : IKeyedObservableCollection<ICompletionItemMatcher>, IObservableCollection<ICompletionItemMatcher>, IList<ICompletionItemMatcher>, ICollection<ICompletionItemMatcher>, IEnumerable<ICompletionItemMatcher>, IEnumerable
{
}
