using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ValueConversion(typeof(Side), typeof(Dock))]
public sealed class SideToDockConverter : IValueConverter
{
	private static SideToDockConverter HnP;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is Side))
		{
			throw new ArgumentException(vVK.ssH(21448));
		}
		return (Side)value switch
		{
			Side.Left => Dock.Left, 
			Side.Top => Dock.Top, 
			Side.Right => Dock.Right, 
			_ => Dock.Bottom, 
		};
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public SideToDockConverter()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool bne()
	{
		return HnP == null;
	}

	internal static SideToDockConverter enJ()
	{
		return HnP;
	}
}
