using System;
using ECOEgqlSad8NUJZ2Dr9n;
using NsWD4W9miMxRbFU3fsu9;
using NVdCPKfwZ2du9XXR24lV;
using ROhuQx9FcGTLTqPCaJ0j;
using sRAUFLf7jllYKTONukDI;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;

namespace scqDIK3IgvatbTpcZJG;

internal class pPoPrc3qBX4fc5gckU0
{
	private readonly TradingSettings QLd3TWNEaw;

	private ypqMIv9maFM0tRwF0xMh xkq3ykUcoY;

	private bool B1K3ZOv3ss;

	private static pPoPrc3qBX4fc5gckU0 aDv1fX4eW30JH1BuMwXW;

	public pPoPrc3qBX4fc5gckU0(TradingSettings P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		QLd3TWNEaw = P_0;
	}

	public void I6b3WPupQc(ypqMIv9maFM0tRwF0xMh P_0)
	{
		xkq3ykUcoY = P_0;
		B1K3ZOv3ss = false;
	}

	public void uPr3tlxi8L()
	{
		int num = 4;
		int num2 = num;
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!QLd3TWNEaw.MarketSettings.DomOneClickSetup)
				{
					return;
				}
				num3 = (long)Math.Ceiling((QLd3TWNEaw.MarketSettings.DomTradesParamsType == iiqB6if7c4rlwZXmgdxd.x4Lf7ER4uAX) ? xkq3ykUcoY.Symbol.CalculateVolumeToFilter(oZS6GF4eZkQTsHpb8tcZ(xkq3ykUcoY.OpZl98KAYgk())) : xkq3ykUcoY.Symbol.CalculateVolumeInQuoteToFilter(xuNdge4eym0wHaWY1fH7(Uftkr34eTGiHNALdA76k(xkq3ykUcoY))));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				int num4 = 0;
				foreach (kF0q2dfwytrWKiPAUIu7 domFilter in QLd3TWNEaw.MarketSettings.DomFilters)
				{
					domFilter.MinValueRatio = (num4 += 1);
					domFilter.MinValue = num3 * num4;
					domFilter.MaxValue = null;
					domFilter.Enabled = true;
					int num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					}
				}
				goto default;
			}
			default:
				QLd3TWNEaw.MarketSettings.DomQuoteMaxSize = num3;
				return;
			case 2:
				return;
			case 4:
				if (!B1K3ZOv3ss)
				{
					return;
				}
				num2 = 3;
				break;
			}
		}
	}

	public void wvD3UvmYYY()
	{
		if (B1K3ZOv3ss)
		{
			return;
		}
		int num;
		if (xkq3ykUcoY != null)
		{
			if (xkq3ykUcoY.OpZl98KAYgk().MaxSize > 0)
			{
				B1K3ZOv3ss = true;
				uPr3tlxi8L();
				return;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	static pPoPrc3qBX4fc5gckU0()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool GCvF3B4etutSLv1tsMOK()
	{
		return aDv1fX4eW30JH1BuMwXW == null;
	}

	internal static pPoPrc3qBX4fc5gckU0 XMxAqY4eUc3O4vCUKVhu()
	{
		return aDv1fX4eW30JH1BuMwXW;
	}

	internal static object Uftkr34eTGiHNALdA76k(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).OpZl98KAYgk();
	}

	internal static long xuNdge4eym0wHaWY1fH7(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).MaxSizeInQuote;
	}

	internal static long oZS6GF4eZkQTsHpb8tcZ(object P_0)
	{
		return ((daEwNq9FXerRxid1xGMa)P_0).MaxSize;
	}
}
