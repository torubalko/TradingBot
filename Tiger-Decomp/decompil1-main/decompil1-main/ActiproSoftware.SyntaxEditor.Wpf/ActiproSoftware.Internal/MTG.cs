using System.Windows;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Internal;

internal interface MTG : IOrderable, IKeyedObject
{
	UIElement VisualElement { get; }

	void Draw(TextViewDrawContext P_0);
}
