using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetMetadata
{
	CodeSnippetKind CodeKind { get; }

	string CodeLanguage { get; }

	string Description { get; }

	string Shortcut { get; }

	CodeSnippetTypes SnippetTypes { get; }

	string Title { get; }

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	ICodeSnippet GetCodeSnippet();
}
