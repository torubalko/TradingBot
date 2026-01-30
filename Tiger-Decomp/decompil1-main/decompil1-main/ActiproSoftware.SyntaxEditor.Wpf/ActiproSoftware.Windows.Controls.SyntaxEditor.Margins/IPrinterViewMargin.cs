using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface IPrinterViewMargin : ITextViewMargin, IOrderable, IKeyedObject
{
	PrinterViewMarginPlacement Placement { get; }
}
