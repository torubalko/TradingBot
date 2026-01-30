using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Navigation;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public interface IQuickInfoSession : IIntelliPromptSession, IServiceLocator
{
	object Content { get; }

	object Context { get; }

	double ControlKeyDownOpacity { get; }

	double MaxWidth { get; }

	event RequestNavigateEventHandler RequestNavigate;

	void Open(IEditorView view, PlacementMode placement, UIElement placementTarget, Rect placementRectangle);
}
