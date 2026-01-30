using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(double), typeof(TextFormattingMode))]
public class ZoomLevelToTextFormattingModeConverter : IValueConverter
{
	private static ZoomLevelToTextFormattingModeConverter cOE;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double num) || !(num > 1.04))
		{
			return TextFormattingMode.Display;
		}
		int num2 = 0;
		if (!mOx())
		{
			int num3 = default(int);
			num2 = num3;
		}
		return num2 switch
		{
			_ => TextFormattingMode.Ideal, 
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ZoomLevelToTextFormattingModeConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool mOx()
	{
		return cOE == null;
	}

	internal static ZoomLevelToTextFormattingModeConverter KOS()
	{
		return cOE;
	}
}
