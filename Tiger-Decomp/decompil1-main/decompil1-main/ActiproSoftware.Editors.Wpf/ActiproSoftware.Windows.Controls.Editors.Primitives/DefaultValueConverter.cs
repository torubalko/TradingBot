using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[ValueConversion(typeof(object), typeof(object))]
public class DefaultValueConverter : IValueConverter
{
	internal static DefaultValueConverter NjF;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value == null && targetType != null && targetType.IsValueType)
		{
			if (targetType == typeof(double))
			{
				return 0.0;
			}
			if (targetType == typeof(int))
			{
				return 0;
			}
			if (targetType == typeof(bool))
			{
				return false;
			}
			if (targetType == typeof(byte))
			{
				return (byte)0;
			}
			if (targetType == typeof(sbyte))
			{
				return (sbyte)0;
			}
			if (targetType == typeof(short))
			{
				return (short)0;
			}
			if (targetType == typeof(ushort))
			{
				return (ushort)0;
			}
			if (targetType == typeof(uint))
			{
				return 0u;
			}
			if (targetType == typeof(long))
			{
				return 0L;
			}
			if (targetType == typeof(ulong))
			{
				return 0uL;
			}
			if (targetType == typeof(float))
			{
				return 0f;
			}
			if (targetType == typeof(decimal))
			{
				return 0m;
			}
			if (targetType == typeof(char))
			{
				return '\0';
			}
			if (targetType == typeof(DateTime))
			{
				return DateTime.Now;
			}
			if (targetType == typeof(Color))
			{
				return Colors.Red;
			}
			if (targetType == typeof(CornerRadius))
			{
				return default(CornerRadius);
			}
			if (targetType == typeof(Int32Rect))
			{
				return default(Int32Rect);
			}
			if (targetType == typeof(Point))
			{
				return default(Point);
			}
			if (targetType == typeof(Rect))
			{
				return default(Rect);
			}
			if (targetType == typeof(Size))
			{
				return default(Size);
			}
			if (targetType == typeof(Thickness))
			{
				return default(Thickness);
			}
			if (targetType == typeof(TimeSpan))
			{
				return default(TimeSpan);
			}
			if (targetType == typeof(Vector))
			{
				return default(Vector);
			}
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	public DefaultValueConverter()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool DjB()
	{
		return NjF == null;
	}

	internal static DefaultValueConverter PjW()
	{
		return NjF;
	}
}
