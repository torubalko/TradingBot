using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputPointerEventArgs : EventArgs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private InputDeviceKind Vkv;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private InputEventArgs QkX;

	internal static InputPointerEventArgs dJo;

	public InputDeviceKind DeviceKind
	{
		[CompilerGenerated]
		get
		{
			return Vkv;
		}
		[CompilerGenerated]
		private set
		{
			Vkv = value;
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

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public ModifierKeys ModifierKeys => Keyboard.Modifiers;

	public object OriginalSource => WrappedEventArgs.OriginalSource;

	public InputEventArgs WrappedEventArgs
	{
		[CompilerGenerated]
		get
		{
			return QkX;
		}
		[CompilerGenerated]
		private set
		{
			QkX = value;
		}
	}

	public InputPointerEventArgs(InputEventArgs e)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		if (e == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107336));
		}
		WrappedEventArgs = e;
		D0z();
	}

	private void D0z()
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
		if (element != null)
		{
			Point position = GetPosition(element);
			return new Rect(0.0, 0.0, element.ActualWidth, element.ActualHeight).Contains(position);
		}
		return false;
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
		if (ModifierKeys != ModifierKeys.None)
		{
			stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110646), ModifierKeys);
		}
		stringBuilder.AppendFormat(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110584), (OriginalSource != null) ? OriginalSource.GetType().Name : null);
		return stringBuilder.ToString();
	}

	internal static bool tJ5()
	{
		return dJo == null;
	}

	internal static InputPointerEventArgs AJm()
	{
		return dJo;
	}
}
