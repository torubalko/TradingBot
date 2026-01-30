using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface IEditorViewMarginCollection : IKeyedObservableCollection<IEditorViewMargin>, IObservableCollection<IEditorViewMargin>, IList<IEditorViewMargin>, ICollection<IEditorViewMargin>, IEnumerable<IEditorViewMargin>, IEnumerable
{
}
