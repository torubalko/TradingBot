using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class ReadOnlyDockingWindowCollection : ReadOnlyDockingWindowBaseCollection<DockingWindow>
{
	public ReadOnlyDockingWindowCollection(ObservableCollection<DockingWindow> list)
	{
		IVH.CecNqz();
		base._002Ector(list);
	}
}
