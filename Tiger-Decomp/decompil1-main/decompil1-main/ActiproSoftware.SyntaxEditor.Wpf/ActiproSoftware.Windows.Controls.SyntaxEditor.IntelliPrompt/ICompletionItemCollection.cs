using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionItemCollection : IList<ICompletionItem>, ICollection<ICompletionItem>, IEnumerable<ICompletionItem>, IEnumerable, INotifyCollectionChanged
{
	void AddRange(IEnumerable<ICompletionItem> items);

	IDisposable CreateBatch();
}
