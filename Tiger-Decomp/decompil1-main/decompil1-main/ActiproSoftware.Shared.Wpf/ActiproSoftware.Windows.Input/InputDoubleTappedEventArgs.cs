using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputDoubleTappedEventArgs : EventArgs
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private InputDeviceKind u0M;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private InputEventArgs v0K;

	internal static InputDoubleTappedEventArgs PJ0;

	public InputDeviceKind DeviceKind
	{
		[CompilerGenerated]
		get
		{
			return u0M;
		}
		[CompilerGenerated]
		private set
		{
			u0M = value;
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
			return v0K;
		}
		[CompilerGenerated]
		private set
		{
			v0K = value;
		}
	}

	public InputDoubleTappedEventArgs(InputEventArgs e)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		WrappedEventArgs = e;
		m0L();
	}

	private void m0L()
	{
		InputDeviceKind value = InputDeviceKind.Mouse;
		if (WrappedEventArgs is MouseEventArgs e)
		{
			if (e.StylusDevice != null)
			{
				value = ((e.StylusDevice.TabletDevice == null || e.StylusDevice.TabletDevice.Type != TabletDeviceType.Touch) ? InputDeviceKind.Stylus : InputDeviceKind.Touch);
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

	public bool IsPositionOver(FrameworkElement element)
	{
		if (element == null)
		{
			return false;
		}
		Point position = GetPosition(element);
		return new Rect(0.0, 0.0, element.ActualWidth, element.ActualHeight).Contains(position);
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
		int num = 0;
		if (VJ1() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => stringBuilder.ToString(), 
		};
	}

	internal static bool AJb()
	{
		return PJ0 == null;
	}

	internal static InputDoubleTappedEventArgs VJ1()
	{
		return PJ0;
	}
}
