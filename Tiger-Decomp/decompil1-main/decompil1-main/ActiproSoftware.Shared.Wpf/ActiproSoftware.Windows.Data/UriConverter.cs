using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(string), typeof(Uri))]
public class UriConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty UriPrefixProperty;

	internal static UriConverter COZ;

	[SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
	public string UriPrefix
	{
		get
		{
			return (string)GetValue(UriPrefixProperty);
		}
		set
		{
			SetValue(UriPrefixProperty, value);
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is string))
		{
			return null;
		}
		string uriString = (UriPrefix ?? string.Empty) + value.ToString();
		return new Uri(uriString, UriKind.RelativeOrAbsolute);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}

	public UriConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static UriConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		UriPrefixProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112744), typeof(string), typeof(UriConverter), new FrameworkPropertyMetadata(null));
	}

	internal static bool YOr()
	{
		return COZ == null;
	}

	internal static UriConverter rOI()
	{
		return COZ;
	}
}
