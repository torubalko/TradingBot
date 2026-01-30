using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface wH : lX
{
	bool ContainsDockingWindows { get; }

	bool ContainsWorkspace { get; }

	Size DockedSize { get; set; }

	DockHost DockHost { get; set; }

	Size MaxSize { get; }

	Size MinSize { get; }

	int GetVisibleToolWindowContainerCount();
}
