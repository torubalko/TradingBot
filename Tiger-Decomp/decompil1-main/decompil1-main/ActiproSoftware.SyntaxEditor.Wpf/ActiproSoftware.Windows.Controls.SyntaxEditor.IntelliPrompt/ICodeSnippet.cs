using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface ICodeSnippet : ICodeSnippetMetadata
{
	string Author { get; }

	string CodeDelimiter { get; }

	string CodeText { get; }

	IList<ICodeSnippetDeclaration> Declarations { get; }

	[SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
	string HelpUrl { get; }

	IList<string> ImportedNamespaces { get; }

	IList<string> Keywords { get; }

	IList<ICodeSnippetAssemblyReference> References { get; }

	object Tag { get; set; }
}
