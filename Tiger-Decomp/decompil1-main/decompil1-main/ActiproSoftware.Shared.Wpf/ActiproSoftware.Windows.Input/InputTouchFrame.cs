using System.Windows;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

internal class InputTouchFrame : IInputTouchFrame
{
	private readonly TouchFrameEventArgs Dk4;

	internal static InputTouchFrame mJi;

	public int Timestamp => Dk4.Timestamp;

	public InputTouchFrame(TouchFrameEventArgs args)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Dk4 = args;
	}

	public IInputTouchPoint GetPrimaryTouchPoint(UIElement relativeTo)
	{
		return new InputTouchPoint(Dk4.GetPrimaryTouchPoint(relativeTo));
	}

	public void SuspendMousePromotionUntilTouchUp()
	{
		Dk4.SuspendMousePromotionUntilTouchUp();
	}

	internal static bool KJp()
	{
		return mJi == null;
	}

	internal static InputTouchFrame YJh()
	{
		return mJi;
	}
}
