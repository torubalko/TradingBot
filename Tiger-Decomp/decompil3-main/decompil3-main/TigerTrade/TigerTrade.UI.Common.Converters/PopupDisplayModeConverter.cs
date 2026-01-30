using System;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class PopupDisplayModeConverter : IValueConverter
{
	internal static PopupDisplayModeConverter QGdRBUDsRFWbsAE2PJc2;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return ((Orientation)value == Orientation.Vertical) ? PopupButtonDisplayMode.ButtonOnly : PopupButtonDisplayMode.Merged;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return Binding.DoNothing;
	}

	public PopupDisplayModeConverter()
	{
		TQb9oCDsO0oApqShKBLf();
		base._002Ector();
	}

	static PopupDisplayModeConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool bG92CKDs668yVO2HuloT()
	{
		return QGdRBUDsRFWbsAE2PJc2 == null;
	}

	internal static PopupDisplayModeConverter EdO9R0DsMadYnHhWrs9f()
	{
		return QGdRBUDsRFWbsAE2PJc2;
	}

	internal static void TQb9oCDsO0oApqShKBLf()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
