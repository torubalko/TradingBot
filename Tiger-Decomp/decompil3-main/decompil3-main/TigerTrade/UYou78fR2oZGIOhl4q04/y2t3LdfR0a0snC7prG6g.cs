using System;
using System.Runtime.CompilerServices;
using System.Windows;
using Cok5gZfeOOYNUntqe0FS;
using D0Dl1FfglhlruVPFTjak;
using ECOEgqlSad8NUJZ2Dr9n;
using KCwoyRfJW9MhNTEhT2A2;
using LkgWJcfsLbF5GV6NcGQ4;
using m5KHHSfSCCCvZdkMl316;
using nDRVH5fO2N3bDxUGOOrY;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using u42gcKfgzsMRGivVmHf8;
using XUi8EWf1E6l7gdu7kUS9;

namespace UYou78fR2oZGIOhl4q04;

internal sealed class y2t3LdfR0a0snC7prG6g : ukuHfqfgiWj29gahLmhg, faw8pRfgu9tAi5EEEjfU
{
	[CompilerGenerated]
	private readonly smTKLVfeMIY6X8kUtDCi TK2fRn57od5;

	[CompilerGenerated]
	private readonly wFFFvWfsxErbxn4XFmrR hdOfRGaEeIE;

	internal static y2t3LdfR0a0snC7prG6g bHn5XSb9vKi6hRw4fq8O;

	public new wFFFvWfsxErbxn4XFmrR MarketView
	{
		[CompilerGenerated]
		get
		{
			return hdOfRGaEeIE;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public smTKLVfeMIY6X8kUtDCi dlAfRHfwYet()
	{
		return TK2fRn57od5;
	}

	public y2t3LdfR0a0snC7prG6g(wFFFvWfsxErbxn4XFmrR P_0, smTKLVfeMIY6X8kUtDCi P_1, ukuHfqfgiWj29gahLmhg P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0, P_2);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		hdOfRGaEeIE = P_0;
		TK2fRn57od5 = P_1;
	}

	public bool CheckUpdate()
	{
		if (MarketView.Settings.GraphShowBidOfferBalance)
		{
			return MarketView.Market.Ci6f1KwuHct().LLHfJTG9gsr();
		}
		return false;
	}

	public void Khal96VceVj(DxVisualQueue P_0)
	{
		GrUfgj06O3b = Rect.Empty;
		double num = default(double);
		int num2;
		if (((MarketSettings)B8LrVpb9ifd7Veo12121(MarketView)).GraphShowBidOfferBalance)
		{
			num = hn2d00b94quW4SpNEeQ8(j96nAhb9l40BM9B64AGY(MarketView)) + 2.0;
			num2 = 14;
			goto IL_0009;
		}
		int num3 = 19;
		goto IL_0005;
		IL_0009:
		Rect rect = default(Rect);
		b5hjQAfJIa1IHHwyhZIx b5hjQAfJIa1IHHwyhZIx = default(b5hjQAfJIa1IHHwyhZIx);
		double num5 = default(double);
		double num6 = default(double);
		string text2 = default(string);
		Rect rect4 = default(Rect);
		long num9 = default(long);
		Rect rect2 = default(Rect);
		string text = default(string);
		long num7 = default(long);
		Rect rect3 = default(Rect);
		long num8 = default(long);
		double num12 = default(double);
		Rect rect6 = default(Rect);
		int num4 = default(int);
		while (true)
		{
			double num13;
			double num10;
			switch (num2)
			{
			case 12:
				GrUfgj06O3b = rect;
				num2 = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num2 = 1;
				}
				continue;
			case 21:
				if (b5hjQAfJIa1IHHwyhZIx.DadfJ7TmwhO() > 0)
				{
					int num11 = (int)((double)huPxlPb9xFPMoYZ3hBNC(b5hjQAfJIa1IHHwyhZIx) * num5);
					Rect rect5 = new Rect(((XrTs9ufSVt0hx8rJDd6l)j96nAhb9l40BM9B64AGY(MarketView)).LXJfxF1ydT3() - (double)num11, 0.0, num11, num6);
					qtwoIub9em43wqtygyDI(P_0, ((brG9LqfO0TVwbKGahwYo)UjJDJZb9L98CC70y6XZJ(MarketView)).C2lfU9hHQUk, rect5);
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_058c;
			case 2:
			{
				long num16 = lfNkQwb9kwHfxZUV2GfC(b5hjQAfJIa1IHHwyhZIx.wl5fJCqmY4n(), b5hjQAfJIa1IHHwyhZIx.DadfJ7TmwhO());
				num5 = ((num16 > 0) ? (lGSc90b91prC9GvruMRQ(j96nAhb9l40BM9B64AGY(MarketView)) / (double)num16) : 0.0);
				if (!(num5 > 0.0))
				{
					num3 = 22;
					break;
				}
				num13 = Math.Floor(num / 2.0);
				goto IL_067b;
			}
			case 20:
				WZodkCb9E5OHhenAys9d(P_0, text2, mcWgOub9c5ekLCUpcxOn(MarketView.Settings), t5GgTrb9j6Obfh91xX3A(MarketView.Theme), rect4, XTextAlignment.Right);
				num3 = 3;
				break;
			case 14:
				b5hjQAfJIa1IHHwyhZIx = (b5hjQAfJIa1IHHwyhZIx)smxfylb9DvyB0vqva9YL(j96nAhb9l40BM9B64AGY(MarketView));
				num2 = 15;
				continue;
			case 1:
				if (num9 <= 0)
				{
					num2 = 7;
					continue;
				}
				num10 = MarketView.Market.padfx7SrsRZ() / (double)num9;
				goto IL_0633;
			case 10:
				qtwoIub9em43wqtygyDI(P_0, ((brG9LqfO0TVwbKGahwYo)UjJDJZb9L98CC70y6XZJ(MarketView)).vLpftzf2vRT, rect2);
				text = hlWp3Qb9dxogQpabwyki(b5hjQAfJIa1IHHwyhZIx).ToString((string)HwM5vUb9sK7Aqj5X5bfe(0x769C7931 ^ 0x769C356D)) + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490739506) + text;
				goto IL_0273;
			case 4:
				num7 = kknIMdb9b7fudaWyEvvH(b5hjQAfJIa1IHHwyhZIx);
				num2 = 6;
				continue;
			default:
				text2 = (string)FKJcCAb9X5j0ExMileZA(b5hjQAfJIa1IHHwyhZIx.DadfJ7TmwhO().ToString((string)HwM5vUb9sK7Aqj5X5bfe(0x3E0426F0 ^ 0x3E046AAC)), HwM5vUb9sK7Aqj5X5bfe(-2123795572 ^ -2123725326), text2);
				goto IL_058c;
			case 5:
				text2 = MarketView.Symbol.FormatRawSize(num7);
				num2 = 21;
				continue;
			case 17:
				P_0.DrawString(text, (XFont)mcWgOub9c5ekLCUpcxOn(MarketView.Settings), MarketView.Theme.cYJfOxYsuth, rect3, XTextAlignment.Right);
				return;
			case 19:
				return;
			case 9:
				if (b5hjQAfJIa1IHHwyhZIx.cw4fJPrUan7() != 0L || b5hjQAfJIa1IHHwyhZIx.wNYfJ3bigEt() != 0L)
				{
					num8 = b8bCr7b9Nr9GpuRhLwqS(b5hjQAfJIa1IHHwyhZIx);
					num7 = b5hjQAfJIa1IHHwyhZIx.wNYfJ3bigEt();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
					{
						num2 = 11;
					}
					continue;
				}
				return;
			case 7:
				num10 = 0.0;
				goto IL_0633;
			case 3:
			{
				int num15 = (int)((double)num8 * num12);
				rect6 = new Rect(IM9ReSb9523s3tnRTb43(j96nAhb9l40BM9B64AGY(MarketView)) - (double)num15, rect.Bottom, num15, num6);
				P_0.FillRectangle((XBrush)WH0Ucgb9QBwc6Exkackv(MarketView.Theme), rect6);
				num2 = 8;
				continue;
			}
			case 18:
			{
				int num14 = (int)((double)hlWp3Qb9dxogQpabwyki(b5hjQAfJIa1IHHwyhZIx) * num5);
				rect2 = new Rect(MarketView.Market.LXJfxF1ydT3() - (double)num14, rect.Bottom, num14, num6);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
				{
					num2 = 10;
				}
				continue;
			}
			case 11:
				num9 = lfNkQwb9kwHfxZUV2GfC(num8, num7);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
				{
					num2 = 1;
				}
				continue;
			case 22:
				num13 = num;
				goto IL_067b;
			case 8:
				GrUfgj06O3b.Union(rect6);
				text = MarketView.Symbol.FormatRawSize(num8);
				if (hlWp3Qb9dxogQpabwyki(b5hjQAfJIa1IHHwyhZIx) > 0)
				{
					num2 = 18;
					continue;
				}
				goto IL_0273;
			case 15:
				num8 = b5hjQAfJIa1IHHwyhZIx.GwNfJyscUwi();
				num3 = 4;
				break;
			case 6:
				if (num8 == 0L && num7 == 0L)
				{
					num2 = 8;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 11;
			case 16:
				P_0.FillRectangle((XBrush)rrqIEVb9SyID1fP0iFy3(MarketView.Theme), rect);
				num2 = 12;
				continue;
			case 13:
				{
					rect = new Rect(IM9ReSb9523s3tnRTb43(MarketView.Market) - (double)num4, (num5 > 0.0) ? num6 : 0.0, num4, num6);
					num2 = 16;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				IL_0273:
				rect3 = new Rect(MarketView.Market.AKnfxPJ5PuD() + 5.0, rect.Bottom, lGSc90b91prC9GvruMRQ(j96nAhb9l40BM9B64AGY(MarketView)) - 10.0, num);
				num2 = 17;
				continue;
				IL_058c:
				rect4 = new Rect(MarketView.Market.AKnfxPJ5PuD() + 5.0, 0.0, MarketView.Market.padfx7SrsRZ() - 10.0, num);
				num2 = 20;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num2 = 10;
				}
				continue;
				IL_0633:
				num12 = num10;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
				{
					num2 = 2;
				}
				continue;
				IL_067b:
				num6 = num13;
				if (num7 <= 0 || num8 <= 0)
				{
					return;
				}
				num4 = (int)((double)num7 * num12);
				num2 = 13;
				continue;
			}
			break;
		}
		goto IL_0005;
		IL_0005:
		num2 = num3;
		goto IL_0009;
	}

	static y2t3LdfR0a0snC7prG6g()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool tRPb5Sb9BRX6vseJVR7h()
	{
		return bHn5XSb9vKi6hRw4fq8O == null;
	}

	internal static y2t3LdfR0a0snC7prG6g HAl7BQb9aEYACAdIaaGf()
	{
		return bHn5XSb9vKi6hRw4fq8O;
	}

	internal static object B8LrVpb9ifd7Veo12121(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Settings;
	}

	internal static object j96nAhb9l40BM9B64AGY(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Market;
	}

	internal static double hn2d00b94quW4SpNEeQ8(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).I8MfLNiJ00B();
	}

	internal static object smxfylb9DvyB0vqva9YL(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).Ci6f1KwuHct();
	}

	internal static long kknIMdb9b7fudaWyEvvH(object P_0)
	{
		return ((b5hjQAfJIa1IHHwyhZIx)P_0).GHhfJmlUcA2();
	}

	internal static long b8bCr7b9Nr9GpuRhLwqS(object P_0)
	{
		return ((b5hjQAfJIa1IHHwyhZIx)P_0).cw4fJPrUan7();
	}

	internal static long lfNkQwb9kwHfxZUV2GfC(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double lGSc90b91prC9GvruMRQ(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).padfx7SrsRZ();
	}

	internal static double IM9ReSb9523s3tnRTb43(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).LXJfxF1ydT3();
	}

	internal static object rrqIEVb9SyID1fP0iFy3(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).C2lfU9hHQUk;
	}

	internal static long huPxlPb9xFPMoYZ3hBNC(object P_0)
	{
		return ((b5hjQAfJIa1IHHwyhZIx)P_0).DadfJ7TmwhO();
	}

	internal static object UjJDJZb9L98CC70y6XZJ(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Theme;
	}

	internal static void qtwoIub9em43wqtygyDI(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static object HwM5vUb9sK7Aqj5X5bfe(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object FKJcCAb9X5j0ExMileZA(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object mcWgOub9c5ekLCUpcxOn(object P_0)
	{
		return ((MarketSettings)P_0).BaseBoldFont;
	}

	internal static object t5GgTrb9j6Obfh91xX3A(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).cYJfOxYsuth;
	}

	internal static void WZodkCb9E5OHhenAys9d(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object WH0Ucgb9QBwc6Exkackv(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).vLpftzf2vRT;
	}

	internal static long hlWp3Qb9dxogQpabwyki(object P_0)
	{
		return ((b5hjQAfJIa1IHHwyhZIx)P_0).wl5fJCqmY4n();
	}
}
