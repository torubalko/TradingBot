using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Input;

namespace ActiproSoftware.Windows.Input;

public interface IInputSource
{
	event EventHandler<InputMouseWheelEventArgs> PreviewMouseWheel;

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TouchDown")]
	event EventHandler<InputTouchEventArgs> PreviewTouchDown;

	event EventHandler<InputTouchEventArgs> PreviewTouchMove;

	event EventHandler<InputTouchEventArgs> PreviewTouchUp;

	event EventHandler<InputSourceEventArgs> TouchFrameReported;

	void CaptureMouse(IInputElement element);

	void NotifyPreviewMouseWheel(MouseWheelEventArgs args);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TouchDown")]
	void NotifyPreviewTouchDown(TouchEventArgs args);

	void NotifyPreviewTouchMove(TouchEventArgs args);

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TouchUp")]
	void NotifyPreviewTouchUp(TouchEventArgs args);

	void NotifyTouchFrameReported(TouchFrameEventArgs args);
}
