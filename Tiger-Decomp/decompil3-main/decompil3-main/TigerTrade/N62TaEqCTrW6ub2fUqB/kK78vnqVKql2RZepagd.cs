using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.Docking;
using HWd9ES2bXNr0YZqBy5d0;
using TuAMtrl1Nd3XoZQQUXf0;
using uZqyk925mKGgabaJGJq6;

namespace N62TaEqCTrW6ub2fUqB;

public static class kK78vnqVKql2RZepagd
{
	internal static kK78vnqVKql2RZepagd jxq2sf4a3Ay3lWnkPl3d;

	public static void A0gqrlIxHt(this DockingWindow P_0)
	{
		P_0.SetValue(DockingWindow.UniqueIdProperty, Guid.NewGuid());
	}

	public static void leUqKEqCdl(this IEnumerable<DockingWindow> P_0)
	{
		foreach (DockingWindow item in P_0)
		{
			item.A0gqrlIxHt();
		}
	}

	public static bool QycqmpQJys(this DockingWindow P_0)
	{
		if (P_0 is DocumentWindow)
		{
			return qEYTeV2bsvVIVI3Hs7LY.CeA2b6Ju1mR(P_0.Name);
		}
		return false;
	}

	public static bool okpqhcsxVP(this DockingWindow P_0)
	{
		return qEYTeV2bsvVIVI3Hs7LY.HoC2bMwjGn8(P_0.UniqueId);
	}

	public static void i9Xqw7GQqw(this DockingWindow P_0)
	{
		if (P_0 is ToolWindow)
		{
			return;
		}
		string[] array = default(string[]);
		long ticks = default(long);
		int num;
		if (K1XOFN4azulIWn9Yl6yS(P_0.Name))
		{
			array = ((string)ctOgQU4i0k6FPLLTvMnM(P_0)).Split(new char[1] { '_' });
			ticks = suc98o4i2wooHyl2OAvw().Ticks;
			num = 2;
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
			{
				num = 1;
			}
		}
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				do
				{
					text = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB78B6F), array[0], ticks++);
				}
				while (qEYTeV2bsvVIVI3Hs7LY.CeA2b6Ju1mR(text));
				num = 3;
				break;
			case 3:
				P_0.Name = text;
				num = 4;
				break;
			case 1:
				return;
			case 4:
				if (ADiDME4iH18oNegiD7ZY(P_0) is z6kMSs25KYyGVf55FxBT z6kMSs25KYyGVf55FxBT)
				{
					z6kMSs25KYyGVf55FxBT.pvt257c0gLf();
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static kK78vnqVKql2RZepagd()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool dw880X4ap7DfHZklKPfb()
	{
		return jxq2sf4a3Ay3lWnkPl3d == null;
	}

	internal static kK78vnqVKql2RZepagd FM9Ifr4auBoLDUgMZPdq()
	{
		return jxq2sf4a3Ay3lWnkPl3d;
	}

	internal static bool K1XOFN4azulIWn9Yl6yS(object P_0)
	{
		return qEYTeV2bsvVIVI3Hs7LY.CeA2b6Ju1mR((string)P_0);
	}

	internal static object ctOgQU4i0k6FPLLTvMnM(object P_0)
	{
		return ((FrameworkElement)P_0).Name;
	}

	internal static DateTime suc98o4i2wooHyl2OAvw()
	{
		return DateTime.Now;
	}

	internal static object ADiDME4iH18oNegiD7ZY(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}
}
