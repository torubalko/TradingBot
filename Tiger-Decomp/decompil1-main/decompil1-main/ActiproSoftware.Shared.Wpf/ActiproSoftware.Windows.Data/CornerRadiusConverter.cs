using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls;
using ActiproSoftware.Windows.Extensions;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Data;

[ValueConversion(typeof(double), typeof(CornerRadius))]
[ValueConversion(typeof(CornerRadius), typeof(CornerRadius))]
public class CornerRadiusConverter : IValueConverter
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Orientation? qkU;

	internal static CornerRadiusConverter sNI;

	public Orientation? InversionOrientation
	{
		[CompilerGenerated]
		get
		{
			return qkU;
		}
		[CompilerGenerated]
		set
		{
			qkU = value;
		}
	}

	private static Corners hkq(object P_0)
	{
		if (!(P_0 is Corners result))
		{
			if (P_0 != null && P_0 is string value)
			{
				try
				{
					return (Corners)Enum.Parse(typeof(Corners), value, ignoreCase: true);
				}
				catch (ArgumentException)
				{
				}
			}
			return Corners.All;
		}
		return result;
	}

	private CornerRadius hkW(CornerRadius P_0)
	{
		Orientation? inversionOrientation = InversionOrientation;
		Orientation? orientation = inversionOrientation;
		if (!orientation.HasValue)
		{
			goto IL_00f7;
		}
		Orientation valueOrDefault = orientation.GetValueOrDefault();
		CornerRadius result;
		if (valueOrDefault != Orientation.Horizontal)
		{
			if (valueOrDefault != Orientation.Vertical)
			{
				goto IL_00f7;
			}
			result = new CornerRadius(P_0.BottomLeft, P_0.BottomRight, P_0.TopRight, P_0.TopLeft);
			int num = 0;
			if (!nND())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		else
		{
			result = new CornerRadius(P_0.TopRight, P_0.TopLeft, P_0.BottomLeft, P_0.BottomRight);
		}
		goto IL_0064;
		IL_00f7:
		result = P_0;
		goto IL_0064;
		IL_0064:
		return result;
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Corners corners = hkq(parameter);
		CornerRadius cornerRadius = default(CornerRadius);
		if (value is double)
		{
			cornerRadius = cornerRadius.SetCorners(corners, (double)value);
		}
		else if (value is CornerRadius)
		{
			cornerRadius = cornerRadius.SetCorners(corners, (CornerRadius)value);
		}
		cornerRadius = hkW(cornerRadius);
		return cornerRadius;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (targetType != typeof(double))
		{
			throw new NotImplementedException();
		}
		Corners corners;
		CornerRadius cornerRadius;
		object result;
		if (value is CornerRadius)
		{
			corners = hkq(parameter);
			cornerRadius = (CornerRadius)value;
			cornerRadius = hkW(cornerRadius);
			if ((corners & Corners.TopLeft) != Corners.None)
			{
				result = cornerRadius.TopLeft;
			}
			else
			{
				if ((corners & Corners.TopRight) != Corners.None)
				{
					result = cornerRadius.TopRight;
					int num = 0;
					if (!nND())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 2:
						break;
					case 1:
						goto IL_00a9;
					default:
						goto IL_01ba;
					}
				}
				if ((corners & Corners.BottomLeft) == 0)
				{
					goto IL_00a9;
				}
				result = cornerRadius.BottomLeft;
			}
		}
		else
		{
			result = 0;
		}
		goto IL_01ba;
		IL_01ba:
		return result;
		IL_00a9:
		result = (((corners & Corners.BottomRight) != Corners.None) ? ((object)cornerRadius.BottomRight) : ((object)0));
		goto IL_01ba;
	}

	public CornerRadiusConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool nND()
	{
		return sNI == null;
	}

	internal static CornerRadiusConverter SN2()
	{
		return sNI;
	}
}
