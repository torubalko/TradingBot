using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippetAssemblyReference
{
	string Assembly { get; }

	[SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
	string Url { get; }
}
