using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Input;
using ActiproSoftware.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Input;

public class InputPointerWheelEventArgs : InputPointerEventArgs
{
	internal static InputPointerWheelEventArgs nJZ;

	public int Delta => WrappedEventArgs.Delta;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public bool IsHorizontal => false;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public int ScrollCharacters => NativeMethods.MouseWheelScrollCharacters;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public int ScrollLines => SystemParameters.WheelScrollLines;

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	public int SingleUnitDelta => Math.Max(1, 120);

	public new MouseWheelEventArgs WrappedEventArgs => (MouseWheelEventArgs)base.WrappedEventArgs;

	public InputPointerWheelEventArgs(MouseWheelEventArgs e)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(e);
	}

	public override string ToString()
	{
		string text = base.ToString();
		return text + string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110690), new object[1] { Delta });
	}

	internal static bool XJr()
	{
		return nJZ == null;
	}

	internal static InputPointerWheelEventArgs PJI()
	{
		return nJZ;
	}
}
