using System.Windows;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;

namespace ActiproSoftware.Internal;

internal interface zj : iy, IDockTarget, IOrientedElement
{
	Size TabPanelSize { get; }

	Side TabStripPlacement { get; }

	bool IsOverTabStrip(Point P_0);

	bool IsOverTitleBar(Point P_0);
}
