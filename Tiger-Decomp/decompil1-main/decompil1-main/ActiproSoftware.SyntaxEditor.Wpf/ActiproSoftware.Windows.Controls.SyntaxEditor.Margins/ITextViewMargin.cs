using System.Windows;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface ITextViewMargin : IOrderable, IKeyedObject
{
	FrameworkElement VisualElement { get; }

	void Draw(TextViewDrawContext context);
}
