using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public class ColorInterpolationConverter : IMultiValueConverter
{
	internal static ColorInterpolationConverter u7K;

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Double.TryParse(System.String,System.Double@)")]
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || values.Length != 2 || !(values[0] is Color) || !(values[1] is Color))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106314));
		}
		double result = 0.5;
		if (parameter != null)
		{
			if (parameter is double)
			{
				result = (double)parameter;
			}
			if (parameter is string s && !double.TryParse(s, out result))
			{
			}
		}
		result = Math.Max(0.0, Math.Min(1.0, result));
		Color color = (Color)values[0];
		Color color2 = (Color)values[1];
		return UIColor.FromMix(color, color2, result).ToColor();
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ColorInterpolationConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool a7M()
	{
		return u7K == null;
	}

	internal static ColorInterpolationConverter E7Y()
	{
		return u7K;
	}
}
