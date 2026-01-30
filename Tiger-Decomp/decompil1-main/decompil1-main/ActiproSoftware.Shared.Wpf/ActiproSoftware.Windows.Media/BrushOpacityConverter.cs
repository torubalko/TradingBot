using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

[ValueConversion(typeof(Brush), typeof(Brush))]
public class BrushOpacityConverter : IValueConverter
{
	internal static BrushOpacityConverter gfP;

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Double.TryParse(System.String,System.Double@)")]
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is Brush { Opacity: var result } brush))
		{
			return null;
		}
		if (parameter != null)
		{
			if (parameter is double)
			{
				result = (double)parameter;
			}
			else if (parameter is string s && double.TryParse(s, out result))
			{
			}
		}
		double opacity = MathHelper.Range(result, 0.0, 1.0);
		Brush brush2 = brush.Clone();
		brush2.Opacity = opacity;
		return brush2;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public BrushOpacityConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool UfW()
	{
		return gfP == null;
	}

	internal static BrushOpacityConverter Ufz()
	{
		return gfP;
	}
}
