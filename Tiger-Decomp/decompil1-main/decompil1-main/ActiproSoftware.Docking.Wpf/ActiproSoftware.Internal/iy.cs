using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface iy : IDockTarget
{
	bool HasDockGuides { get; }

	bool RequiresReverseOrderInsertion { get; }

	bool SupportsAttach(DockHost P_0);

	bool SupportsInnerSideDock(DockHost P_0);

	bool SupportsOuterSideDock(DockHost P_0);
}
