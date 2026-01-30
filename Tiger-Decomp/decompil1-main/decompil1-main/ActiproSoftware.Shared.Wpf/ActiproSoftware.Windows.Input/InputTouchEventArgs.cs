using System;
using System.Windows;
using System.Windows.Input;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputTouchEventArgs : EventArgs
{
	private readonly TouchEventArgs Mkw;

	internal static InputTouchEventArgs YJL;

	public bool Handled
	{
		get
		{
			return Mkw.Handled;
		}
		set
		{
			Mkw.Handled = value;
		}
	}

	public int Timestamp => Mkw.Timestamp;

	public IInputTouchDevice TouchDevice => new InputTouchDevice(Mkw.TouchDevice);

	public InputTouchEventArgs(TouchEventArgs args)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Mkw = args;
	}

	public IInputTouchPoint GetTouchPoint(IInputElement relativeTo)
	{
		return new InputTouchPoint(Mkw.GetTouchPoint(relativeTo));
	}

	internal static bool dJ4()
	{
		return YJL == null;
	}

	internal static InputTouchEventArgs BJs()
	{
		return YJL;
	}
}
