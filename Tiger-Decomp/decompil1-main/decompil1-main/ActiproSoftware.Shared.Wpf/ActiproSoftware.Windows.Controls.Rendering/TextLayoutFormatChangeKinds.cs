using System;

namespace ActiproSoftware.Windows.Controls.Rendering;

[Flags]
internal enum TextLayoutFormatChangeKinds
{
	None = 0,
	FontFamily = 1,
	FontSize = 2,
	FontStyle = 4,
	FontWeight = 8,
	Foreground = 0x10,
	Strikethrough = 0x20,
	Underline = 0x40,
	Spacer = 0x80
}
