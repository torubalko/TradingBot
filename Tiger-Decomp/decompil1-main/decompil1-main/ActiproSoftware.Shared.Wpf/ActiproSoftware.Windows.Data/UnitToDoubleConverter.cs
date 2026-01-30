using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

public class UnitToDoubleConverter : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private UnitType MkG;

	private static UnitToDoubleConverter AOo;

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public UnitType Type
	{
		[CompilerGenerated]
		get
		{
			return MkG;
		}
		[CompilerGenerated]
		set
		{
			MkG = value;
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is Unit unit))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112532));
		}
		return unit.Value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is double))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(112636));
		}
		return new Unit((double)value, Type);
	}

	public UnitToDoubleConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool mO5()
	{
		return AOo == null;
	}

	internal static UnitToDoubleConverter zOm()
	{
		return AOo;
	}
}
