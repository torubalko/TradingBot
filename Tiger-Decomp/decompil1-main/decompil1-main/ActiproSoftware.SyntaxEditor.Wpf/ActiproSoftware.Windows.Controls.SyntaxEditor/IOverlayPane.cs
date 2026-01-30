using System;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor;

public interface IOverlayPane : IKeyedObject
{
	ICommand CloseCommand { get; }

	double ControlKeyDownOpacity { get; }

	OverlayPaneInstanceKind InstanceKind { get; }

	UIElement VisualElement { get; }

	event EventHandler Closed;

	void Activate();

	void Close();
}
