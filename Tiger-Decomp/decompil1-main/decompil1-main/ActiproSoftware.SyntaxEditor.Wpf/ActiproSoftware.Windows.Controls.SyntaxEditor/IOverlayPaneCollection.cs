using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IOverlayPaneCollection : IList<IOverlayPane>, ICollection<IOverlayPane>, IEnumerable<IOverlayPane>, IEnumerable, INotifyCollectionChanged
{
	IOverlayPane this[string key] { get; }

	bool Contains(string key);

	int IndexOf(string key);

	bool Remove(string key);
}
