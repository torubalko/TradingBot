using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Text.Parsing;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Indicators;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;

namespace ActiproSoftware.Text;

public interface IEditorDocument : ICodeDocument, IParseTarget, ITextDocument
{
	IIndicatorManager IndicatorManager { get; }

	int LineNumberOrigin { get; set; }

	IOutliningManager OutliningManager { get; }

	OutliningMode OutliningMode { get; set; }

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	WhitespaceTrimModes WhitespaceTrimModes { get; set; }
}
