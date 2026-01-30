using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IEditorViewOverlayPaneCollection : IOverlayPaneCollection, IList<IOverlayPane>, ICollection<IOverlayPane>, IEnumerable<IOverlayPane>, IEnumerable, INotifyCollectionChanged
{
	IOverlayPane AddSearch(bool isReplaceVisible);
}
