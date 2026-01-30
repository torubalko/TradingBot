using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputTappedEventArgs : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private InputDeviceKind rk9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private InputEventArgs ukh;

	internal static InputTappedEventArgs UJB;

	public InputDeviceKind DeviceKind
	{
		[CompilerGenerated]
		get
		{
			return rk9;
		}
		[CompilerGenerated]
		private set
		{
			rk9 = value;
		}
	}

	public bool Handled
	{
		get
		{
			return WrappedEventArgs.Handled;
		}
		set
		{
			WrappedEventArgs.Handled = value;
		}
	}

	public object OriginalSource => WrappedEventArgs.OriginalSource;

	public InputEventArgs WrappedEventArgs
	{
		[CompilerGenerated]
		get
		{
			return ukh;
		}
		[CompilerGenerated]
		private set
		{
			ukh = value;
		}
	}

	public InputTappedEventArgs(InputEventArgs e)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		WrappedEventArgs = e;
		gk3();
	}

	private void gk3()
	{
		InputDeviceKind value = InputDeviceKind.Mouse;
		if (WrappedEventArgs is MouseEventArgs e)
		{
			bool flag = e.StylusDevice != null;
			int num = 1;
			if (!kJA())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 1:
				if (flag)
				{
					if (e.StylusDevice.TabletDevice == null || e.StylusDevice.TabletDevice.Type != TabletDeviceType.Touch)
					{
						value = InputDeviceKind.Stylus;
						break;
					}
					goto default;
				}
				break;
			default:
				value = InputDeviceKind.Touch;
				break;
			}
		}
		else if (WrappedEventArgs is TouchEventArgs)
		{
			value = InputDeviceKind.Touch;
		}
		DeviceKind = value;
	}

	public Point GetPosition(UIElement relativeTo)
	{
		return WrappedEventArgs.GetPosition(relativeTo);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110538), DeviceKind);
		if (OriginalSource is UIElement relativeTo)
		{
			Point position = GetPosition(relativeTo);
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110550), position.X, position.Y);
		}
		stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110584), (OriginalSource != null) ? OriginalSource.GetType().Name : null);
		return stringBuilder.ToString();
	}

	internal static bool kJA()
	{
		return UJB == null;
	}

	internal static InputTappedEventArgs sJV()
	{
		return UJB;
	}
}
