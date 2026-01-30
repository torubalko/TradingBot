using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Media;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.ColorSelection;

[ValueConversion(typeof(Color), typeof(string))]
public class ColorToStringConverter : IValueConverter
{
	internal static ColorToStringConverter abs;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Color color = (Color)value;
		bool flag = color.A < byte.MaxValue;
		if (parameter != null && bool.TryParse(parameter.ToString(), out var result))
		{
			flag = result;
		}
		return UIColor.FromArgb(flag ? color.A : byte.MaxValue, color.R, color.G, color.B).ToWebColor(flag);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		try
		{
			UIColor uIColor = UIColor.FromWebColor((string)value);
			if (parameter != null && bool.TryParse(parameter.ToString(), out var result) && !result)
			{
				uIColor.A = byte.MaxValue;
			}
			return uIColor.ToColor();
		}
		catch
		{
			return DependencyProperty.UnsetValue;
		}
	}

	public ColorToStringConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Wbi()
	{
		return abs == null;
	}

	internal static ColorToStringConverter sbp()
	{
		return abs;
	}
}
