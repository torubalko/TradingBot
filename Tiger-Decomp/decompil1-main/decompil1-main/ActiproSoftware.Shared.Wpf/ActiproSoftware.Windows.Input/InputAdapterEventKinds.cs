using System;

namespace ActiproSoftware.Windows.Input;

[Flags]
public enum InputAdapterEventKinds
{
	None = 0,
	PointerCaptureLost = 1,
	PointerEntered = 2,
	PointerExited = 4,
	PointerMoved = 8,
	PointerPressed = 0x10,
	PointerReleased = 0x20,
	PointerWheelChanged = 0x40,
	Tapped = 0x80,
	DoubleTapped = 0x100,
	KeyDown = 0x200,
	KeyUp = 0x400,
	All = 0x7FF
}
