using System;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[Flags]
public enum CodeSnippetTypes
{
	None = 0,
	Expansion = 1,
	SurroundsWith = 2,
	Refactoring = 4
}
