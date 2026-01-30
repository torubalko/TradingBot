using System.Windows;

namespace ActiproSoftware.Windows.Input;

public interface IInputTouchFrame
{
	int Timestamp { get; }

	IInputTouchPoint GetPrimaryTouchPoint(UIElement relativeTo);

	void SuspendMousePromotionUntilTouchUp();
}
