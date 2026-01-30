using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

public sealed class NonUIElementConverter : IValueConverter
{
	internal static NonUIElementConverter cnv;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is UIElement))
		{
			return value;
		}
		return null;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public NonUIElementConverter()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool PnN()
	{
		return cnv == null;
	}

	internal static NonUIElementConverter bnS()
	{
		return cnv;
	}
}
