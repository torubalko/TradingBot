using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class LinkBrushToVisibilityMultiConverter : IMultiValueConverter
{
	private static LinkBrushToVisibilityMultiConverter RvAPiFDsbjK0WPaecOWZ;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0.Length >= 2 && int.TryParse(P_0[0].ToString(), out var result) && result != 0)
		{
			return Visibility.Visible;
		}
		return Visibility.Collapsed;
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public LinkBrushToVisibilityMultiConverter()
	{
		WnurV1Ds16efMdXWgCT8();
		base._002Ector();
	}

	static LinkBrushToVisibilityMultiConverter()
	{
		QxupP9Ds5ItgqBOaVxlV();
	}

	internal static bool KwKvbpDsNjAJcJYnjbmq()
	{
		return RvAPiFDsbjK0WPaecOWZ == null;
	}

	internal static LinkBrushToVisibilityMultiConverter l746LiDskPslyHygsUQI()
	{
		return RvAPiFDsbjK0WPaecOWZ;
	}

	internal static void WnurV1Ds16efMdXWgCT8()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void QxupP9Ds5ItgqBOaVxlV()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
