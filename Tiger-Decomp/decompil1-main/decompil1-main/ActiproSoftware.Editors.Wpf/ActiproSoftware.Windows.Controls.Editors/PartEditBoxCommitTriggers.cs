using System;

namespace ActiproSoftware.Windows.Controls.Editors;

[Flags]
public enum PartEditBoxCommitTriggers
{
	None = 0,
	EnterKeyDown = 1,
	SpinnerChange = 2,
	ActivePartChange = 4,
	StringValueChange = 8,
	All = 0xF,
	Default = 3
}
