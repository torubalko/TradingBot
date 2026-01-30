using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public sealed class BooleanToVisibilityConverter : IValueConverter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Visibility tkY;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool OkI;

	internal static BooleanToVisibilityConverter LNy;

	public Visibility FalseVisibility
	{
		[CompilerGenerated]
		get
		{
			return tkY;
		}
		[CompilerGenerated]
		set
		{
			tkY = value;
		}
	}

	public bool IsInverted
	{
		[CompilerGenerated]
		get
		{
			return OkI;
		}
		[CompilerGenerated]
		set
		{
			OkI = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool flag = false;
		if (value != null && (value is bool || value is bool?))
		{
			flag = (bool)value;
		}
		if (IsInverted)
		{
			return flag ? FalseVisibility : Visibility.Visible;
		}
		return (!flag) ? FalseVisibility : Visibility.Visible;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (IsInverted)
		{
			return value is Visibility && (Visibility)value != Visibility.Visible;
		}
		return value is Visibility && (Visibility)value == Visibility.Visible;
	}

	public BooleanToVisibilityConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		tkY = Visibility.Collapsed;
		base._002Ector();
	}

	internal static bool CNQ()
	{
		return LNy == null;
	}

	internal static BooleanToVisibilityConverter lNC()
	{
		return LNy;
	}
}
