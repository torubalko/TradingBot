using System.Windows;
using System.Windows.Input;

namespace ActiproSoftware.Windows.Input;

public interface IInputTouchPoint
{
	TouchAction Action { get; }

	Point Position { get; }

	IInputTouchDevice TouchDevice { get; }
}
