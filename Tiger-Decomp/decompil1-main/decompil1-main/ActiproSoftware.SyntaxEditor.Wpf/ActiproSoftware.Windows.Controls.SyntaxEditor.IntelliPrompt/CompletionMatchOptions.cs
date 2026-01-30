using System;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[Flags]
public enum CompletionMatchOptions
{
	None = 0,
	IsCaseInsensitive = 1,
	TargetsDisplayText = 2,
	UseAcronyms = 4,
	UseShorthand = 8,
	RequiresExact = 0x10
}
