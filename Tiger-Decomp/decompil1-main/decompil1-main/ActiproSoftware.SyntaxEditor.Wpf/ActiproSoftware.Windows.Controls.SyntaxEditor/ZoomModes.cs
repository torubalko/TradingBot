using System;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

[Flags]
public enum ZoomModes
{
	None = 0,
	Mouse = 1,
	Keyboard = 2,
	Touch = 4,
	All = 7
}
