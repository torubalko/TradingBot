using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class ConditionalConverter : IMultiValueConverter, IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object YkZ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object Jkn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object tka;

	internal static ConditionalConverter KNm;

	public object ConditionValue
	{
		[CompilerGenerated]
		get
		{
			return YkZ;
		}
		[CompilerGenerated]
		set
		{
			YkZ = value;
		}
	}

	public object FalseValue
	{
		[CompilerGenerated]
		get
		{
			return Jkn;
		}
		[CompilerGenerated]
		set
		{
			Jkn = value;
		}
	}

	public object TrueValue
	{
		[CompilerGenerated]
		get
		{
			return tka;
		}
		[CompilerGenerated]
		set
		{
			tka = value;
		}
	}

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || values.Length < 1 || values.Length > 3)
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111630));
		}
		object obj = ((values.Length > 1) ? values[1] : TrueValue);
		object obj2 = ((values.Length > 2) ? values[2] : FalseValue);
		return Hkr(values[0]) ? obj : obj2;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		return null;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return Hkr(value) ? TrueValue : FalseValue;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value == TrueValue;
	}

	private bool Hkr(object P_0)
	{
		if (P_0 == DependencyProperty.UnsetValue)
		{
			return false;
		}
		if (ConditionValue != null)
		{
			return ConditionValue.Equals(P_0);
		}
		if (P_0 == null || false.Equals(P_0))
		{
			return false;
		}
		if (P_0 is string value)
		{
			return !string.IsNullOrEmpty(value);
		}
		return true;
	}

	public ConditionalConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool LNZ()
	{
		return KNm == null;
	}

	internal static ConditionalConverter LNr()
	{
		return KNm;
	}
}
