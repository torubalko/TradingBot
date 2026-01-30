using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IPrinterView : ITextView
{
	IPrinterViewMarginCollection Margins { get; }

	int PageCount { get; }

	int PageNumber { get; }
}
