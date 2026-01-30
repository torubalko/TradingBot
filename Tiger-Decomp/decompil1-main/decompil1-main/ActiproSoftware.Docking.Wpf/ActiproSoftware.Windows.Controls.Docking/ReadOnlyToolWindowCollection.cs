using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking;

public class ReadOnlyToolWindowCollection : ReadOnlyDockingWindowBaseCollection<ToolWindow>
{
	public ReadOnlyToolWindowCollection(ObservableCollection<ToolWindow> list)
	{
		IVH.CecNqz();
		base._002Ector(list);
	}
}
