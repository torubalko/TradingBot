using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class ParallaxConverter : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double akK;

	private static ParallaxConverter xOe;

	public double Factor
	{
		[CompilerGenerated]
		get
		{
			return akK;
		}
		[CompilerGenerated]
		set
		{
			akK = value;
		}
	}

	public ParallaxConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		Factor = -0.1;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is double)
		{
			return (double)value * Factor;
		}
		return 0.0;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double num))
		{
			return 0.0;
		}
		return num / ((Factor != 0.0) ? Factor : 1.0);
	}

	internal static bool CO6()
	{
		return xOe == null;
	}

	internal static ParallaxConverter zOw()
	{
		return xOe;
	}
}
