using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Documents;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IPrintSettings
{
	bool AreCollapsedOutliningNodesAllowed { get; set; }

	bool AreIndentationGuidesVisible { get; set; }

	bool AreSquiggleLinesVisible { get; set; }

	string DocumentTitle { get; set; }

	IHighlightingStyleRegistry HighlightingStyleRegistry { get; set; }

	bool IsDocumentTitleMarginVisible { get; set; }

	bool IsLineNumberMarginVisible { get; set; }

	bool IsPageNumberMarginVisible { get; set; }

	bool IsSyntaxHighlightingEnabled { get; set; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	bool IsWhitespaceVisible { get; set; }

	bool IsWordWrapGlyphMarginVisible { get; set; }

	Thickness PageMargin { get; set; }

	Size PageSize { get; set; }

	IPrinterViewMarginFactoryCollection ViewMarginFactories { get; }

	FixedDocument CreateFixedDocument(SyntaxEditor syntaxEditor);
}
