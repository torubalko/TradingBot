using System.Windows;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

internal class InputTouchDevice : IInputTouchDevice
{
	private readonly TouchDevice nkm;

	internal static InputTouchDevice CJT;

	public UIElement DirectlyOver => nkm.DirectlyOver as UIElement;

	public InputTouchDevice(TouchDevice touchDevice)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		nkm = touchDevice;
	}

	internal static bool FJX()
	{
		return CJT == null;
	}

	internal static InputTouchDevice zJU()
	{
		return CJT;
	}
}
