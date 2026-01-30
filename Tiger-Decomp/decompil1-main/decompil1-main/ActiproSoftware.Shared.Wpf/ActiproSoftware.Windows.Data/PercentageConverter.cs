using System;
using System.Globalization;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(double), typeof(double))]
public class PercentageConverter : IValueConverter
{
	internal static PercentageConverter tOk;

	public virtual object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double))
		{
			if (!(value is int))
			{
				if (!(value is float))
				{
					return value;
				}
				value = (double)(float)value;
			}
			else
			{
				value = (double)(int)value;
			}
		}
		int num4 = default(int);
		while (true)
		{
			double num = (double)value;
			double num2 = Math.Round(num * 100.0);
			bool flag = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(942).Equals(parameter);
			int num3 = 0;
			if (!DOF())
			{
				num3 = num4;
			}
			switch (num3)
			{
			case 1:
				continue;
			}
			if (!flag)
			{
				return num2;
			}
			return num2 + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(942);
		}
	}

	public virtual object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double))
		{
			if (value is int)
			{
				value = (double)(int)value;
			}
			else
			{
				if (!(value is float))
				{
					return value;
				}
				value = (double)(float)value;
			}
		}
		double num = (double)value;
		return num / 100.0;
	}

	public PercentageConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool DOF()
	{
		return tOk == null;
	}

	internal static PercentageConverter vOd()
	{
		return tOk;
	}
}
