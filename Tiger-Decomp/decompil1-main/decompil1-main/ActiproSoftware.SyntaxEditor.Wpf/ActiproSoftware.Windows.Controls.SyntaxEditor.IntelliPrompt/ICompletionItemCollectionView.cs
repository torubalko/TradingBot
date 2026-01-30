using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]
public interface ICompletionItemCollectionView : ICollectionView, IEnumerable, INotifyCollectionChanged
{
	int Count { get; }

	ICompletionItem this[int index] { get; }

	bool Contains(ICompletionItem item);

	int IndexOf(ICompletionItem item);
}
