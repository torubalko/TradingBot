using System;
using System.Globalization;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ValueConversion(typeof(DateTime), typeof(string))]
public class DateToDecadeStringConverter : IValueConverter
{
	private static DateToDecadeStringConverter jaY;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null)
		{
			return null;
		}
		if (!(value is DateTime))
		{
			throw new ArgumentException(QdM.AR8(23984), QdM.AR8(23908));
		}
		bool flag = false;
		if (parameter is bool)
		{
			flag = (bool)parameter;
		}
		else
		{
			string value2 = parameter as string;
			if (!string.IsNullOrEmpty(value2) && bool.TryParse(value2, out var result))
			{
				flag = result;
			}
		}
		return ldZ.qbZ((DateTime)value, flag);
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public DateToDecadeStringConverter()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool rax()
	{
		return jaY == null;
	}

	internal static DateToDecadeStringConverter caz()
	{
		return jaY;
	}
}
