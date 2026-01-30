using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(object), typeof(object))]
[SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "Op")]
public class NoOpConverter : IValueConverter
{
	private static readonly NoOpConverter Ekd;

	internal static NoOpConverter iO0;

	public static NoOpConverter Instance => Ekd;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	public NoOpConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static NoOpConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Ekd = new NoOpConverter();
	}

	internal static bool OOb()
	{
		return iO0 == null;
	}

	internal static NoOpConverter nO1()
	{
		return iO0;
	}
}
