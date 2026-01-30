using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(object), typeof(bool))]
public class IsNullOrEmptyConverter : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool xks;

	internal static IsNullOrEmptyConverter NOY;

	public bool IsInverted
	{
		[CompilerGenerated]
		get
		{
			return xks;
		}
		[CompilerGenerated]
		set
		{
			xks = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool flag = ((!(value is string text)) ? (value == null) : (text.Length == 0));
		return IsInverted ? (!flag) : flag;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public IsNullOrEmptyConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool TOt()
	{
		return NOY == null;
	}

	internal static IsNullOrEmptyConverter HOf()
	{
		return NOY;
	}
}
