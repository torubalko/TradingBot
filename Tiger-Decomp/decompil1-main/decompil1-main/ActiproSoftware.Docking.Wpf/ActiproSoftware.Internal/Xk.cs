using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface Xk
{
	DockHost DockHost { get; }

	DockingWindowState State { get; }

	void RemoveBreadcrumb(bv P_0);
}
