using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.DocumentManagement;

[ValueConversion(typeof(int), typeof(string))]
public class RecentDocumentIndexToAccessTextConverter : IValueConverter
{
	private static RecentDocumentIndexToAccessTextConverter hNn;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is int && (int)value < 10)
		{
			return value.ToString();
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return DependencyProperty.UnsetValue;
	}

	public RecentDocumentIndexToAccessTextConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool NN0()
	{
		return hNn == null;
	}

	internal static RecentDocumentIndexToAccessTextConverter ONb()
	{
		return hNn;
	}
}
