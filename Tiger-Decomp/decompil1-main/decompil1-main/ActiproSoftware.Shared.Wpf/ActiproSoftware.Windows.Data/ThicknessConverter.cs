using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Extensions;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(double), typeof(Thickness))]
[ValueConversion(typeof(Thickness), typeof(Thickness))]
public class ThicknessConverter : IValueConverter
{
	private bool PkD;

	private double MkP;

	private static ThicknessConverter EOQ;

	public bool AllowNegative
	{
		get
		{
			return PkD;
		}
		set
		{
			PkD = value;
		}
	}

	public double Multiplier
	{
		get
		{
			return MkP;
		}
		set
		{
			MkP = value;
		}
	}

	private static Sides Uk8(object P_0)
	{
		if (!(P_0 is Sides result))
		{
			if (P_0 != null && P_0 is string value)
			{
				int num = 0;
				if (!MOC())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				try
				{
					return (Sides)Enum.Parse(typeof(Sides), value, ignoreCase: true);
				}
				catch (ArgumentException)
				{
				}
			}
			return Sides.All;
		}
		return result;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Sides sides = Uk8(parameter);
		Thickness thickness = default(Thickness);
		double num = default(double);
		int num2;
		bool flag = default(bool);
		if (value is double)
		{
			num = (double)value * MkP;
			num2 = 0;
			if (jOR() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			flag = value is int;
			num2 = 1;
			if (jOR() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		Thickness thickness2 = default(Thickness);
		while (true)
		{
			switch (num2)
			{
			case 2:
				thickness2 = new Thickness(thickness2.Left * MkP, thickness2.Top * MkP, thickness2.Right * MkP, thickness2.Bottom * MkP);
				goto IL_0147;
			case 1:
				if (flag)
				{
					double num3 = (double)(int)value * MkP;
					if (!PkD)
					{
						num3 = Math.Max(0.0, num3);
					}
					return thickness.SetSides(sides, num3);
				}
				if (!(value is Thickness))
				{
					return thickness;
				}
				thickness2 = (Thickness)value;
				if (PkD)
				{
					break;
				}
				thickness2 = new Thickness(Math.Max(0.0, thickness2.Left * MkP), Math.Max(0.0, thickness2.Top * MkP), Math.Max(0.0, thickness2.Right * MkP), Math.Max(0.0, thickness2.Bottom * MkP));
				goto IL_0147;
			default:
				{
					if (!PkD)
					{
						num = Math.Max(0.0, num);
					}
					return thickness.SetSides(sides, num);
				}
				IL_0147:
				return thickness.SetSides(sides, thickness2);
			}
			num2 = 2;
		}
		IL_0005:
		int num4 = default(int);
		num2 = num4;
		goto IL_0009;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (targetType != typeof(double))
		{
			throw new NotImplementedException();
		}
		if (!(value is Thickness))
		{
			return 0;
		}
		Sides sides = Uk8(parameter);
		Thickness thickness = (Thickness)value;
		double num = 0.0;
		if ((sides & Sides.Left) != Sides.None)
		{
			num = thickness.Left;
		}
		else if ((sides & Sides.Top) != Sides.None)
		{
			num = thickness.Top;
		}
		else if ((sides & Sides.Right) != Sides.None)
		{
			num = thickness.Right;
		}
		else if ((sides & Sides.Bottom) != Sides.None)
		{
			num = thickness.Bottom;
		}
		num /= MkP;
		if (!PkD)
		{
			num = Math.Max(0.0, num);
		}
		return num;
	}

	public ThicknessConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		PkD = true;
		MkP = 1.0;
		base._002Ector();
	}

	internal static bool MOC()
	{
		return EOQ == null;
	}

	internal static ThicknessConverter jOR()
	{
		return EOQ;
	}
}
