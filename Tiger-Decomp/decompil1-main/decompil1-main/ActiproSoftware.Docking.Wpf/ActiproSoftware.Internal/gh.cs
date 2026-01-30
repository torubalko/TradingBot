using System.Runtime.CompilerServices;
using System.Windows;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Internal;

internal interface gh
{
	DockHost DockHost { get; }

	Point Location { get; set; }

	void Kmi();

	void Vmu(bool P_0, bool P_1, bool P_2);

	[SpecialName]
	Window NmX();

	[SpecialName]
	FloatingWindowControl Qmq();
}
