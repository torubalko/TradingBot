using System.Windows;

namespace ActiproSoftware.Windows.Input;

public interface IInputTouchDevice
{
	UIElement DirectlyOver { get; }
}
