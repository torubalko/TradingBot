using System.Collections.Generic;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetFolder
{
	IList<ICodeSnippetFolder> Folders { get; }

	IList<ICodeSnippetMetadata> Items { get; }

	string Name { get; }

	object Tag { get; set; }

	ICodeSnippetMetadata FindItemByShortcut(string shortcut, bool isCaseSensitive);
}
