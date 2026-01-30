using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICompletionFilterCollection : IKeyedObservableCollection<ICompletionFilter>, IObservableCollection<ICompletionFilter>, IList<ICompletionFilter>, ICollection<ICompletionFilter>, IEnumerable<ICompletionFilter>, IEnumerable
{
}
