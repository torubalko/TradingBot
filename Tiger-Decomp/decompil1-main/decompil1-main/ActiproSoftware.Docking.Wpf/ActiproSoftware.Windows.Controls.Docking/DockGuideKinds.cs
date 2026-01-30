using System;

namespace ActiproSoftware.Windows.Controls.Docking;

[Flags]
public enum DockGuideKinds
{
	None = 0,
	OuterLeft = 1,
	OuterTop = 2,
	OuterRight = 4,
	OuterBottom = 8,
	Outer = 0xF,
	InnerLeft = 0x10,
	InnerTop = 0x20,
	InnerRight = 0x40,
	InnerBottom = 0x80,
	Inner = 0xF0,
	Center = 0x100
}
