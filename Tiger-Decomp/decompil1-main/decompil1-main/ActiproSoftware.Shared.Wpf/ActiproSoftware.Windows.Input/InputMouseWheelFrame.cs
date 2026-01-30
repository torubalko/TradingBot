using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputMouseWheelFrame : IInputMouseWheelFrame
{
	private readonly MouseWheelEventArgs m0P;

	internal static InputMouseWheelFrame yJv;

	public int Delta => m0P.Delta;

	public bool Handled
	{
		get
		{
			return m0P.Handled;
		}
		set
		{
			m0P.Handled = value;
		}
	}

	public MouseWheelEventArgs WrappedEventArgs => m0P;

	public InputMouseWheelFrame(MouseWheelEventArgs args)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		m0P = args;
	}

	internal static bool bJa()
	{
		return yJv == null;
	}

	internal static InputMouseWheelFrame BJy()
	{
		return yJv;
	}
}
