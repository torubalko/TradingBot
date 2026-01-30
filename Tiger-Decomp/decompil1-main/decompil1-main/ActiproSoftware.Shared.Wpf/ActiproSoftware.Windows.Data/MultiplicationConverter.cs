using System;
using System.Globalization;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class MultiplicationConverter : IMultiValueConverter, IValueConverter
{
	private static MultiplicationConverter gOq;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111472));
		}
		double num = 0.0;
		if (values.Length != 0)
		{
			bool flag = true;
			if (values[0] is double)
			{
				num = (double)values[0];
			}
			else if (values[0] is int)
			{
				num = (int)values[0];
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				for (int i = 1; i < values.Length; i++)
				{
					if (values[i] is double)
					{
						num *= (double)values[i];
						continue;
					}
					if (values[i] is int)
					{
						num *= (double)(int)values[i];
						continue;
					}
					num = 0.0;
					break;
				}
			}
		}
		if (parameter is double)
		{
			num *= (double)parameter;
		}
		else if (parameter is int)
		{
			num *= (double)(int)parameter;
		}
		return num;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double num = 0.0;
		if (value is double)
		{
			num = (double)value;
		}
		else if (value is int)
		{
			num = (int)value;
		}
		if (parameter is double)
		{
			num *= (double)parameter;
		}
		else if (parameter is int)
		{
			num *= (double)(int)parameter;
		}
		else
		{
			string text = parameter as string;
			if (!string.IsNullOrEmpty(text) && double.TryParse(text, NumberStyles.Float, culture, out var result))
			{
				num *= result;
			}
		}
		return num;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public MultiplicationConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool OOG()
	{
		return gOq == null;
	}

	internal static MultiplicationConverter WOn()
	{
		return gOq;
	}
}
