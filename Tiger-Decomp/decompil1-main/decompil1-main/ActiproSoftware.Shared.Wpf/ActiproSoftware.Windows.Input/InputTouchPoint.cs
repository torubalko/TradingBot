using System.Windows;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

internal class InputTouchPoint : IInputTouchPoint
{
	private readonly TouchPoint Tku;

	private static InputTouchPoint mJP;

	public TouchAction Action => Tku.Action;

	public Point Position => Tku.Position;

	public IInputTouchDevice TouchDevice => new InputTouchDevice(Tku.TouchDevice);

	public InputTouchPoint(TouchPoint touchPoint)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Tku = touchPoint;
	}

	internal static bool xJW()
	{
		return mJP == null;
	}

	internal static InputTouchPoint uJz()
	{
		return mJP;
	}
}
