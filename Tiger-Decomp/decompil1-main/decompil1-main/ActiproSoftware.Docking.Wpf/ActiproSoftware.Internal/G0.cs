using System.Collections.Generic;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface G0
{
	DockHost DockHost { get; }

	bool IsActive { get; set; }

	DockingWindow SelectedWindow { get; set; }

	IEnumerable<DockingWindow> Windows { get; }

	bool RemoveWindow(DockingWindow P_0);
}
