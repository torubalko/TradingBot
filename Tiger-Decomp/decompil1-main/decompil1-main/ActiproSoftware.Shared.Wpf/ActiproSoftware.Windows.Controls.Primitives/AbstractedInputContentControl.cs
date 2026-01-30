using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class AbstractedInputContentControl : ContentControl
{
	private IInputSource PIN;

	internal static AbstractedInputContentControl e05;

	internal IInputSource InputSource
	{
		get
		{
			return PIN;
		}
		set
		{
			if (PIN != null)
			{
				NId(PIN);
			}
			PIN = value;
			if (PIN != null)
			{
				qIL(PIN);
			}
		}
	}

	public AbstractedInputContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		InputSource = new InputSource();
		base.Loaded += bIR;
		base.Unloaded += rIE;
	}

	protected virtual void OnInputPreviewMouseWheel(object sender, InputMouseWheelEventArgs args)
	{
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TouchDown")]
	protected virtual void OnInputPreviewTouchDown(object sender, InputTouchEventArgs args)
	{
	}

	protected virtual void OnInputPreviewTouchMove(object sender, InputTouchEventArgs args)
	{
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "TouchUp")]
	protected virtual void OnInputPreviewTouchUp(object sender, InputTouchEventArgs args)
	{
	}

	private void bIR(object P_0, RoutedEventArgs P_1)
	{
		Touch.FrameReported += iIs;
	}

	private void rIE(object P_0, RoutedEventArgs P_1)
	{
		Touch.FrameReported -= iIs;
	}

	private void iIs(object P_0, TouchFrameEventArgs P_1)
	{
		InputSource.NotifyTouchFrameReported(P_1);
	}

	private void qIL(IInputSource P_0)
	{
		P_0.TouchFrameReported += OnInputTouchFrameReported;
		P_0.PreviewMouseWheel += OnInputPreviewMouseWheel;
		P_0.PreviewTouchDown += OnInputPreviewTouchDown;
		P_0.PreviewTouchMove += OnInputPreviewTouchMove;
		P_0.PreviewTouchUp += OnInputPreviewTouchUp;
	}

	private void NId(IInputSource P_0)
	{
		if (P_0 != null)
		{
			P_0.TouchFrameReported -= OnInputTouchFrameReported;
			P_0.PreviewMouseWheel -= OnInputPreviewMouseWheel;
			P_0.PreviewTouchDown -= OnInputPreviewTouchDown;
			P_0.PreviewTouchMove -= OnInputPreviewTouchMove;
			P_0.PreviewTouchUp -= OnInputPreviewTouchUp;
		}
	}

	protected void CaptureMouse(IInputElement element)
	{
		PIN.CaptureMouse(element);
	}

	protected override void OnPreviewMouseWheel(MouseWheelEventArgs e)
	{
		InputSource.NotifyPreviewMouseWheel(e);
	}

	protected override void OnPreviewTouchDown(TouchEventArgs e)
	{
		InputSource.NotifyPreviewTouchDown(e);
	}

	protected override void OnPreviewTouchMove(TouchEventArgs e)
	{
		InputSource.NotifyPreviewTouchMove(e);
	}

	protected override void OnPreviewTouchUp(TouchEventArgs e)
	{
		InputSource.NotifyPreviewTouchUp(e);
	}

	protected virtual void OnInputTouchFrameReported(object sender, InputSourceEventArgs args)
	{
	}

	internal static bool P0m()
	{
		return e05 == null;
	}

	internal static AbstractedInputContentControl I0Z()
	{
		return e05;
	}
}
