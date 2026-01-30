using System.Windows;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface IEditorViewMargin : ITextViewMargin, IOrderable, IKeyedObject
{
	EditorViewMarginPlacement Placement { get; }

	Visibility Visibility { get; }
}
