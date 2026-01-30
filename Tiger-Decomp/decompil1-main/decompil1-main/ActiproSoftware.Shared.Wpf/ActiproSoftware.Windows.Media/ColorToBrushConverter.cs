using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[ValueConversion(typeof(Color), typeof(Brush))]
public class ColorToBrushConverter : IValueConverter
{
	internal static ColorToBrushConverter D7H;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is Color)
		{
			SolidColorBrush solidColorBrush = new SolidColorBrush();
			solidColorBrush.Color = (Color)value;
			if (solidColorBrush.CanFreeze)
			{
				solidColorBrush.Freeze();
			}
			return solidColorBrush;
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ColorToBrushConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool c7J()
	{
		return D7H == null;
	}

	internal static ColorToBrushConverter y73()
	{
		return D7H;
	}
}
