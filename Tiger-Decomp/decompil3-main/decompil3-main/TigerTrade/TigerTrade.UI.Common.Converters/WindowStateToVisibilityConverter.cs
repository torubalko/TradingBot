using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal class WindowStateToVisibilityConverter : IValueConverter
{
	private static WindowStateToVisibilityConverter MjhGhRDLwW40PmrROlto;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		if (P_0 is WindowState windowState)
		{
			if ((uint)windowState <= 1u)
			{
				goto IL_0080;
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				goto IL_0080;
			}
			if (windowState == WindowState.Maximized)
			{
				return Visibility.Collapsed;
			}
		}
		return Visibility.Visible;
		IL_0080:
		return Visibility.Visible;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return WindowState.Normal;
	}

	public WindowStateToVisibilityConverter()
	{
		IcbSRbDLAmG6PlMTEnh6();
		base._002Ector();
	}

	static WindowStateToVisibilityConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool vmPXpPDL7jKpqmCyhmKf()
	{
		return MjhGhRDLwW40PmrROlto == null;
	}

	internal static WindowStateToVisibilityConverter cLZWX9DL8vKexDBs5eEY()
	{
		return MjhGhRDLwW40PmrROlto;
	}

	internal static void IcbSRbDLAmG6PlMTEnh6()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
