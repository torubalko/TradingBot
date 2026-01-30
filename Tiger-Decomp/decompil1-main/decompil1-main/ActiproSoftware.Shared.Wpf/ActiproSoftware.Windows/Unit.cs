using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows;

[Serializable]
[TypeConverter(typeof(UnitConverter))]
public struct Unit
{
	private readonly UnitType hL;

	private readonly double gd;

	public static readonly Unit Empty;

	internal static object TM9;

	public bool IsEmpty => hL == (UnitType)0;

	[SuppressMessage("Microsoft.Naming", "CA1721:PropertyNamesShouldNotMatchGetMethods")]
	public UnitType Type
	{
		get
		{
			if (!IsEmpty)
			{
				return hL;
			}
			return UnitType.Pixel;
		}
	}

	public double Value => gd;

	public Unit(double value)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		gd = value;
		hL = UnitType.Pixel;
	}

	public Unit(double value, UnitType type)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		gd = value;
		hL = type;
	}

	public Unit(string value)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this = new Unit(value, CultureInfo.CurrentCulture, UnitType.Pixel);
	}

	public Unit(string value, CultureInfo culture)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this = new Unit(value, culture, UnitType.Pixel);
	}

	internal Unit(string value, CultureInfo culture, UnitType defaultType)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		if (string.IsNullOrEmpty(value))
		{
			gd = 0.0;
			hL = (UnitType)0;
			return;
		}
		if (culture == null)
		{
			culture = CultureInfo.CurrentCulture;
		}
		string text = value.Trim();
		int length = text.Length;
		int num = -1;
		for (int i = 0; i < length; i++)
		{
			char c = text[i];
			if ((c < '0' || c > '9') && c != '-' && c != '.' && c != ',')
			{
				break;
			}
			num = i;
		}
		if (-1 == num)
		{
			throw new FormatException(string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(520), new object[1] { value }));
		}
		if (num < length - 1)
		{
			hL = @as(text.Substring(num + 1).Trim());
		}
		else
		{
			hL = defaultType;
		}
		string text2 = text.Substring(0, num + 1);
		try
		{
			TypeConverter typeConverter = new DoubleConverter();
			gd = (double)typeConverter.ConvertFromString(null, culture, text2);
		}
		catch
		{
			throw new FormatException(string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(768), new object[3]
			{
				value,
				text2,
				hL.ToString(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(928))
			}));
		}
	}

	private static string jE(UnitType P_0)
	{
		string result;
		switch (P_0)
		{
		case UnitType.Centimeter:
			result = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(956);
			break;
		case UnitType.Pixel:
			result = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(934);
			break;
		case UnitType.Point:
			result = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(964);
			break;
		case UnitType.Percentage:
			result = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(942);
			break;
		default:
			result = string.Empty;
			break;
		case UnitType.Inch:
		{
			result = WP6RZJql8gZrNhVA9v.L3hoFlcqP6(948);
			int num = 0;
			if (!xMc())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			break;
		}
		}
		return result;
	}

	private static UnitType @as(string P_0)
	{
		if (P_0 != null)
		{
			string text = P_0.ToUpperInvariant();
			if (text.Equals(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(942), StringComparison.Ordinal))
			{
				return UnitType.Percentage;
			}
			if (text.Equals(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(972), StringComparison.Ordinal))
			{
				return UnitType.Inch;
			}
			if (text.Equals(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(980), StringComparison.Ordinal))
			{
				return UnitType.Centimeter;
			}
			if (text.Equals(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(988), StringComparison.Ordinal))
			{
				return UnitType.Point;
			}
		}
		return UnitType.Pixel;
	}

	public static Unit Centimeter(double value)
	{
		return new Unit(value, UnitType.Centimeter);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Unit unit))
		{
			return false;
		}
		return unit.hL == hL && unit.gd == gd;
	}

	public override int GetHashCode()
	{
		return ((hL.GetHashCode() << 5) + hL.GetHashCode()) ^ gd.GetHashCode();
	}

	public double GetPixels(double width)
	{
		return Type switch
		{
			UnitType.Percentage => Value / 100.0 * width, 
			UnitType.Inch => Value * 96.0, 
			UnitType.Point => Value * 1.3333333333333333, 
			UnitType.Centimeter => Value * 37.79527559055118, 
			_ => Value, 
		};
	}

	public static Unit Inch(double value)
	{
		return new Unit(value, UnitType.Inch);
	}

	public static bool operator ==(Unit left, Unit right)
	{
		return left.hL == right.hL && left.gd == right.gd;
	}

	public static bool operator !=(Unit left, Unit right)
	{
		return !(left == right);
	}

	public static implicit operator Unit(double value)
	{
		return Pixel(value);
	}

	public static Unit Parse(string value)
	{
		return new Unit(value, CultureInfo.CurrentCulture);
	}

	public static Unit Parse(string value, CultureInfo culture)
	{
		return new Unit(value, culture);
	}

	public static Unit Percentage(double value)
	{
		return new Unit(value, UnitType.Percentage);
	}

	public static Unit Pixel(double value)
	{
		return new Unit(value);
	}

	public static Unit Point(double value)
	{
		return new Unit(value, UnitType.Point);
	}

	public override string ToString()
	{
		return ToString(CultureInfo.CurrentCulture);
	}

	public string ToString(IFormatProvider formatProvider)
	{
		if (!IsEmpty)
		{
			return gd.ToString(formatProvider) + jE(hL);
		}
		return string.Empty;
	}

	public static bool ValidateIsGreaterThan(object value, double min)
	{
		if (value is Unit unit)
		{
			return unit.Value > min && unit.Value <= double.MaxValue;
		}
		return false;
	}

	public static bool ValidateIsGreaterThanOrEqual(object value, double min)
	{
		if (!(value is Unit unit))
		{
			return false;
		}
		return unit.Value >= min && unit.Value <= double.MaxValue;
	}

	public static bool ValidateIsPositive(object value)
	{
		if (value is Unit unit)
		{
			return unit.Value >= 0.0;
		}
		return false;
	}

	static Unit()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		Empty = default(Unit);
	}

	internal static bool xMc()
	{
		return TM9 == null;
	}

	internal static object nMu()
	{
		return TM9;
	}
}
