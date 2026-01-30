using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputSourceEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IInputTouchFrame pkS;

	internal static InputSourceEventArgs TJE;

	public IInputTouchFrame TouchFrame
	{
		[CompilerGenerated]
		get
		{
			return pkS;
		}
		[CompilerGenerated]
		private set
		{
			pkS = value;
		}
	}

	public InputSourceEventArgs(IInputTouchFrame touchFrame)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		TouchFrame = touchFrame;
	}

	internal static bool aJx()
	{
		return TJE == null;
	}

	internal static InputSourceEventArgs yJS()
	{
		return TJE;
	}
}
