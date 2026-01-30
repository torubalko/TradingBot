using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[ValueConversion(typeof(object), typeof(bool))]
public class IsNullOrTransparentBrushConverter : IValueConverter
{
	internal static IsNullOrTransparentBrushConverter E7F;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return true;
		}
		Color color = Colors.White;
		if (value is Color)
		{
			color = (Color)value;
		}
		else if (value is UIColor uIColor)
		{
			color = uIColor.ToColor();
		}
		else if (value is SolidColorBrush solidColorBrush)
		{
			color = solidColorBrush.Color;
		}
		if (color.A == 0)
		{
			return true;
		}
		return false;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public IsNullOrTransparentBrushConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool m7d()
	{
		return E7F == null;
	}

	internal static IsNullOrTransparentBrushConverter h7v()
	{
		return E7F;
	}
}
