using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Markup;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ContentProperty("Converter")]
public class InverseConverter : IValueConverter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IValueConverter QkR;

	private static InverseConverter aNh;

	public IValueConverter Converter
	{
		[CompilerGenerated]
		get
		{
			return QkR;
		}
		[CompilerGenerated]
		set
		{
			QkR = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (Converter == null)
		{
			return value;
		}
		return Converter.ConvertBack(value, targetType, parameter, culture);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (Converter == null)
		{
			return value;
		}
		return Converter.Convert(value, targetType, parameter, culture);
	}

	public InverseConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool kNP()
	{
		return aNh == null;
	}

	internal static InverseConverter PNW()
	{
		return aNh;
	}
}
