using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(object), typeof(string))]
public class StringFormatConverter : IMultiValueConverter, IValueConverter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool rkg;

	internal static StringFormatConverter hOv;

	public bool IsNullAllowed
	{
		[CompilerGenerated]
		get
		{
			return rkg;
		}
		[CompilerGenerated]
		set
		{
			rkg = value;
		}
	}

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(parameter is string format))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112408));
		}
		if (IsNullAllowed)
		{
			bool flag = true;
			if (values != null)
			{
				foreach (object obj in values)
				{
					if (obj != null)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				return null;
			}
		}
		return string.Format(CultureInfo.CurrentCulture, format, values);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(parameter is string format))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112408));
		}
		if (IsNullAllowed && value == null)
		{
			return null;
		}
		return string.Format(CultureInfo.CurrentCulture, format, new object[1] { value });
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public StringFormatConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool nOa()
	{
		return hOv == null;
	}

	internal static StringFormatConverter AOy()
	{
		return hOv;
	}
}
