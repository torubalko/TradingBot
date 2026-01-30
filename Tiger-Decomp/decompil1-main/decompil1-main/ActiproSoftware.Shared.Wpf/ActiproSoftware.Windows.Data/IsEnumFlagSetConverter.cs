using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(Enum), typeof(bool))]
[SuppressMessage("Microsoft.Naming", "CA1726:UsePreferredTerms", MessageId = "Flag")]
public class IsEnumFlagSetConverter : IValueConverter
{
	private static readonly IsEnumFlagSetConverter tkE;

	private static IsEnumFlagSetConverter fNz;

	public static IsEnumFlagSetConverter Instance => tkE;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is Enum obj))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111942));
		}
		Enum obj2 = parameter as Enum;
		if (obj2 == null)
		{
			string value2 = parameter as string;
			if (string.IsNullOrEmpty(value2))
			{
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112048));
			}
			obj2 = Enum.Parse(obj.GetType(), value2, ignoreCase: true) as Enum;
			int num = 0;
			if (!qOK())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		return (System.Convert.ToInt32(obj, CultureInfo.InvariantCulture) & System.Convert.ToInt32(obj2, CultureInfo.InvariantCulture)) != 0;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is bool))
		{
			int num = 0;
			if (!qOK())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112176));
			}
		}
		Enum obj = parameter as Enum;
		if (obj == null)
		{
			string value2 = parameter as string;
			if (string.IsNullOrEmpty(value2))
			{
				throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112048));
			}
			obj = Enum.Parse(targetType, value2, ignoreCase: true) as Enum;
		}
		if (!(bool)value)
		{
			return Enum.Parse(targetType, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(107242), ignoreCase: true) as Enum;
		}
		return obj;
	}

	public IsEnumFlagSetConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static IsEnumFlagSetConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		tkE = new IsEnumFlagSetConverter();
	}

	internal static bool qOK()
	{
		return fNz == null;
	}

	internal static IsEnumFlagSetConverter aOM()
	{
		return fNz;
	}
}
