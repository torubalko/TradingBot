using System;
using System.Globalization;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ValueConversion(typeof(int), typeof(double))]
public class ColorComponentToPercentConverter : IValueConverter
{
	private static ColorComponentToPercentConverter ran;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is int))
		{
			throw new ArgumentException(QdM.AR8(23848), QdM.AR8(23908));
		}
		double num = Math.Round(Math.Max(0.0, Math.Min(100.0, (double)(int)value / 255.0 * 100.0)), MidpointRounding.AwayFromZero);
		return num;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double))
		{
			throw new ArgumentException(QdM.AR8(23922), QdM.AR8(23908));
		}
		int num = Math.Max(0, Math.Min(255, (int)Math.Round((double)value * 255.0 / 100.0, MidpointRounding.AwayFromZero)));
		return num;
	}

	public ColorComponentToPercentConverter()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool gag()
	{
		return ran == null;
	}

	internal static ColorComponentToPercentConverter aas()
	{
		return ran;
	}
}
