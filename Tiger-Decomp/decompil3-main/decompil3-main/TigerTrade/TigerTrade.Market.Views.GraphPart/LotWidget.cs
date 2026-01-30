using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using AQB6mgf3wjOUxVfiEwwS;
using Bs9FfLq8LSV7wJhpolq;
using Cok5gZfeOOYNUntqe0FS;
using ECOEgqlSad8NUJZ2Dr9n;
using F1U49sf6cAPweJWJV0Yg;
using LaJLKJf6QgxXtecRtEuE;
using LkgWJcfsLbF5GV6NcGQ4;
using m5KHHSfSCCCvZdkMl316;
using nDRVH5fO2N3bDxUGOOrY;
using pieN9WfFYEsJTSrYSp5q;
using sANMn1f60Cyb0T5WEfMC;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TigerTrade.UI.DocControls.Trading.Settings;
using TuAMtrl1Nd3XoZQQUXf0;
using u42gcKfgzsMRGivVmHf8;
using waDpctGJom9MvAveNXHq;
using XUi8EWf1E6l7gdu7kUS9;

namespace TigerTrade.Market.Views.GraphPart;

internal sealed class LotWidget : XE24ZNf6Ekk5SJSRxcIv, faw8pRfgu9tAi5EEEjfU
{
	private readonly Point fhJfdrgQfdX;

	private readonly Point pUMfdKvyiVk;

	private readonly Thickness DGCfdmlJTvW;

	private bool OkgfdhXuGwa;

	private bool sOCfdwyPXkm;

	private XFont prHfd7PetUy;

	private bool kCSfd8dufg0;

	private double vmYfdAOsHjG;

	private double fo4fdP20Vrm;

	private double GHQfdJhRRLS;

	private double eKcfdFsjgv0;

	private double hRhfd3fK2pI;

	private double MJ8fdpA8yAV;

	private double FFdfdu7yb35;

	private bool X5LfdzkLoPJ;

	private string cTRfg0fV7qO;

	private string AQZfg2w8typ;

	private int HGKfgHRnI5I;

	private Rect HkIfgfvK5Fy;

	private mMFDCqfRzaRLlovS6k5D IbFfg9vcdg4;

	private mMFDCqfRzaRLlovS6k5D JR1fgnn4aZ8;

	private mMFDCqfRzaRLlovS6k5D GFHfgGBRtJj;

	private mMFDCqfRzaRLlovS6k5D R51fgYLfHsv;

	private mMFDCqfRzaRLlovS6k5D LQefgorenue;

	private R3D7xnf6XASVgU8V4BJg[] QBgfgv3D7fV;

	[CompilerGenerated]
	private readonly smTKLVfeMIY6X8kUtDCi JNifgBYt9VA;

	[CompilerGenerated]
	private readonly wFFFvWfsxErbxn4XFmrR MYafganjRnQ;

	internal static LotWidget LYCXgHbHBYHFkOfYYwWx;

	public wFFFvWfsxErbxn4XFmrR MarketView
	{
		[CompilerGenerated]
		get
		{
			return MYafganjRnQ;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public smTKLVfeMIY6X8kUtDCi YtYfdqssgWw()
	{
		return JNifgBYt9VA;
	}

	[SpecialName]
	private XFont jhcfdtJTAJe()
	{
		return (XFont)HAhicsbHlRWibWnKk6yy(MarketView.Settings);
	}

	[SpecialName]
	private XBrush yKvfdTbkNwN()
	{
		return MarketView.Theme.T1dfVsGwWpr;
	}

	private string H5tfdLXUqXa(double P_0)
	{
		if (!h1JawdbH4q7K7WXnx8xq(MarketView.Market.Settings))
		{
			if (!((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).ExecuteInPercents)
			{
				return string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFA2BB4), P_0);
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => ((int)IhMKjVbHbOcDYcjSNG7Y(P_0)).ToString(NumberFormatInfo.CurrentInfo), 
			};
		}
		string text = McPEV4q7m2685kMvrQH.bR1qJgPHqX(j18iDj9nukSCmEyZs5lH.Settings.QuoteCurrencyOrderDecimals, _0020: false);
		return P_0.ToString(text, NumberFormatInfo.CurrentInfo);
	}

	private static double JBOfdewJhbd(EpdvD7f3hWq8UlJ32f6V P_0, bool P_1, bool P_2)
	{
		if (!P_2)
		{
			if (!P_1)
			{
				return t8u1adbHNbj58k9ICc3V(P_0);
			}
			return P_0.QuoteSize;
		}
		return P_0.PercentSize;
	}

	public LotWidget(wFFFvWfsxErbxn4XFmrR P_0, smTKLVfeMIY6X8kUtDCi P_1)
	{
		vX658XbHk10U3lWAQmPc();
		fhJfdrgQfdX = new Point(6.0, 6.0);
		pUMfdKvyiVk = new Point(4.0, 4.0);
		DGCfdmlJTvW = new Thickness(4.0, 6.0, 4.0, 6.0);
		OkgfdhXuGwa = true;
		HGKfgHRnI5I = -2;
		QBgfgv3D7fV = new R3D7xnf6XASVgU8V4BJg[5];
		base._002Ector();
		j8Gf6whb5mN(FX2hNmfFGUQfi0wdaZLW.Positions.LotWidget);
		MYafganjRnQ = P_0;
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 != 0)
		{
			num = 0;
		}
		bool executeInQuoteCurrency = default(bool);
		bool executeInPercents = default(bool);
		while (true)
		{
			switch (num)
			{
			case 11:
				hRhfd3fK2pI = JBOfdewJhbd(MarketView.Market.Settings.Preset3, executeInQuoteCurrency, executeInPercents);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num = 1;
				}
				break;
			case 3:
				return;
			case 4:
				FFdfdu7yb35 = JBOfdewJhbd((EpdvD7f3hWq8UlJ32f6V)JCpEMUbHRcCEuPkkevV4(G1AABbbHDCSbdcrFvuC5(MarketView.Market)), executeInQuoteCurrency, executeInPercents);
				num = 6;
				break;
			default:
			{
				GHQfdJhRRLS = PtHqIdbHxbUX5bCX8QAl(AXHOD7bHSuUT3VZhwbK9(MarketView.Market.Settings), executeInQuoteCurrency, executeInPercents);
				int num2 = 8;
				num = num2;
				break;
			}
			case 6:
			{
				mMFDCqfRzaRLlovS6k5D mMFDCqfRzaRLlovS6k5D5 = new mMFDCqfRzaRLlovS6k5D(P_0);
				mMFDCqfRzaRLlovS6k5D5.XOef6GXEQ2M(jhcfdtJTAJe());
				TGTEogbHL3t8jBtOkXqy(mMFDCqfRzaRLlovS6k5D5, H5tfdLXUqXa(FFdfdu7yb35));
				mMFDCqfRzaRLlovS6k5D5.CornerRadius = pUMfdKvyiVk;
				mMFDCqfRzaRLlovS6k5D5.IsChecked = MarketView.Market.Settings.Preset5IsSelected;
				mMFDCqfRzaRLlovS6k5D5.Padding = DGCfdmlJTvW;
				mMFDCqfRzaRLlovS6k5D5.Height = 21.0;
				mMFDCqfRzaRLlovS6k5D5.GMGf6AnwLRY(delegate
				{
					MarketView.Market.Settings.Preset5IsSelected = true;
				});
				LQefgorenue = mMFDCqfRzaRLlovS6k5D5;
				num = 10;
				break;
			}
			case 10:
				FVPf6d8fYXD(LQefgorenue);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 != 0)
				{
					num = 3;
				}
				break;
			case 8:
			{
				mMFDCqfRzaRLlovS6k5D mMFDCqfRzaRLlovS6k5D = new mMFDCqfRzaRLlovS6k5D(P_0);
				mMFDCqfRzaRLlovS6k5D.XOef6GXEQ2M(jhcfdtJTAJe());
				TGTEogbHL3t8jBtOkXqy(mMFDCqfRzaRLlovS6k5D, H5tfdLXUqXa(GHQfdJhRRLS));
				a5Z2o1bHeMP4fvPpY2TU(mMFDCqfRzaRLlovS6k5D, pUMfdKvyiVk);
				Y77LYlbHsK2iMGKj3m5I(mMFDCqfRzaRLlovS6k5D, ((MarketSettings)G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))).Preset1IsSelected);
				mMFDCqfRzaRLlovS6k5D.Padding = DGCfdmlJTvW;
				YfXlt8bHX2FUZblpwD6d(mMFDCqfRzaRLlovS6k5D, 21.0);
				mMFDCqfRzaRLlovS6k5D.GMGf6AnwLRY(delegate
				{
					i6kgh3bf9INnNkfJkD7m(G1AABbbHDCSbdcrFvuC5(MarketView.Market), true);
				});
				IbFfg9vcdg4 = mMFDCqfRzaRLlovS6k5D;
				FVPf6d8fYXD(IbFfg9vcdg4);
				eKcfdFsjgv0 = JBOfdewJhbd((EpdvD7f3hWq8UlJ32f6V)ETOdd0bHcvDyoXNcCQq9(MarketView.Market.Settings), executeInQuoteCurrency, executeInPercents);
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 9;
				}
				break;
			}
			case 2:
				JNifgBYt9VA = P_1;
				base.X = kQJPg4bH1pluqvCEH2tI(MarketView.Market) + 3.0;
				num = 7;
				break;
			case 7:
				base.Y = ((FrameworkElement)xDRVdGbH55RrWdp6ppq0(MarketView)).ActualHeight - (WCKf6yfqAyx() + 24.0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num = 5;
				}
				break;
			case 9:
			{
				mMFDCqfRzaRLlovS6k5D mMFDCqfRzaRLlovS6k5D4 = new mMFDCqfRzaRLlovS6k5D(P_0);
				mMFDCqfRzaRLlovS6k5D4.XOef6GXEQ2M(jhcfdtJTAJe());
				TGTEogbHL3t8jBtOkXqy(mMFDCqfRzaRLlovS6k5D4, H5tfdLXUqXa(eKcfdFsjgv0));
				mMFDCqfRzaRLlovS6k5D4.CornerRadius = pUMfdKvyiVk;
				mMFDCqfRzaRLlovS6k5D4.IsChecked = MtJVCVbHjgpBD1E0PJht(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings);
				mMFDCqfRzaRLlovS6k5D4.Padding = DGCfdmlJTvW;
				mMFDCqfRzaRLlovS6k5D4.Height = 21.0;
				UsR2TCbHEDVJrUbe6Bes(mMFDCqfRzaRLlovS6k5D4, (Action)delegate
				{
					MarketView.Market.Settings.Preset2IsSelected = true;
				});
				JR1fgnn4aZ8 = mMFDCqfRzaRLlovS6k5D4;
				FVPf6d8fYXD(JR1fgnn4aZ8);
				num = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 9;
				}
				break;
			}
			case 12:
			{
				mMFDCqfRzaRLlovS6k5D mMFDCqfRzaRLlovS6k5D3 = new mMFDCqfRzaRLlovS6k5D(P_0);
				sNveaUbHQGdAiAv6S9ei(mMFDCqfRzaRLlovS6k5D3, jhcfdtJTAJe());
				TGTEogbHL3t8jBtOkXqy(mMFDCqfRzaRLlovS6k5D3, H5tfdLXUqXa(MJ8fdpA8yAV));
				mMFDCqfRzaRLlovS6k5D3.CornerRadius = pUMfdKvyiVk;
				mMFDCqfRzaRLlovS6k5D3.IsChecked = lmyosJbHgtLQCuqyc2MR(G1AABbbHDCSbdcrFvuC5(MarketView.Market));
				mMFDCqfRzaRLlovS6k5D3.Padding = DGCfdmlJTvW;
				mMFDCqfRzaRLlovS6k5D3.Height = 21.0;
				mMFDCqfRzaRLlovS6k5D3.GMGf6AnwLRY(delegate
				{
					xKfEgxbfGky2oI2akvG5(G1AABbbHDCSbdcrFvuC5(MarketView.Market), true);
				});
				R51fgYLfHsv = mMFDCqfRzaRLlovS6k5D3;
				FVPf6d8fYXD(R51fgYLfHsv);
				num = 4;
				break;
			}
			case 1:
			{
				mMFDCqfRzaRLlovS6k5D mMFDCqfRzaRLlovS6k5D2 = new mMFDCqfRzaRLlovS6k5D(P_0);
				sNveaUbHQGdAiAv6S9ei(mMFDCqfRzaRLlovS6k5D2, jhcfdtJTAJe());
				TGTEogbHL3t8jBtOkXqy(mMFDCqfRzaRLlovS6k5D2, H5tfdLXUqXa(hRhfd3fK2pI));
				a5Z2o1bHeMP4fvPpY2TU(mMFDCqfRzaRLlovS6k5D2, pUMfdKvyiVk);
				mMFDCqfRzaRLlovS6k5D2.IsChecked = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.Preset3IsSelected;
				Mo6I1UbHd5d8k7ExRO7f(mMFDCqfRzaRLlovS6k5D2, DGCfdmlJTvW);
				YfXlt8bHX2FUZblpwD6d(mMFDCqfRzaRLlovS6k5D2, 21.0);
				mMFDCqfRzaRLlovS6k5D2.GMGf6AnwLRY(delegate
				{
					PXSfplbfnEgw6Ctciovb(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings, true);
				});
				GFHfgGBRtJj = mMFDCqfRzaRLlovS6k5D2;
				FVPf6d8fYXD(GFHfgGBRtJj);
				MJ8fdpA8yAV = JBOfdewJhbd(MarketView.Market.Settings.Preset4, executeInQuoteCurrency, executeInPercents);
				num = 12;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num = 11;
				}
				break;
			}
			case 5:
				kCSfd8dufg0 = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(P_0)).TradingSettings?.IsLotsInDOMShowed ?? false;
				executeInQuoteCurrency = ((MarketSettings)G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))).ExecuteInQuoteCurrency;
				executeInPercents = MarketView.Market.Settings.ExecuteInPercents;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public double tHOfdsBYYf2(out bool P_0)
	{
		int num = 4;
		int num2 = num;
		int presetID = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				P_0 = ((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).ExecuteInQuoteCurrency;
				num2 = 3;
				continue;
			case 2:
				switch (presetID)
				{
				default:
					return 0.0;
				case 3:
					if (!h1JawdbH4q7K7WXnx8xq(G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return XUBlaZbH6NqDUebP9GyO(MarketView.Market.Settings.Preset3);
				case 4:
					if (!((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.ExecuteInQuoteCurrency)
					{
						return MarketView.Market.Settings.Preset4.Size;
					}
					return ((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).Preset4.QuoteSize;
				case 2:
					if (!((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.ExecuteInQuoteCurrency)
					{
						return t8u1adbHNbj58k9ICc3V(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.Preset2);
					}
					return XUBlaZbH6NqDUebP9GyO(MarketView.Market.Settings.Preset2);
				case 5:
					if (!MarketView.Market.Settings.ExecuteInQuoteCurrency)
					{
						return t8u1adbHNbj58k9ICc3V(JCpEMUbHRcCEuPkkevV4(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings));
					}
					return MarketView.Market.Settings.Preset5.QuoteSize;
				case 1:
					break;
				}
				break;
			case 3:
				presetID = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.PresetID;
				num2 = 2;
				continue;
			default:
				return ((EpdvD7f3hWq8UlJ32f6V)QjBkGPbHMdmZFPSaEiEx(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings)).Size;
			case 1:
				break;
			}
			break;
		}
		if (!((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).ExecuteInQuoteCurrency)
		{
			return t8u1adbHNbj58k9ICc3V(MarketView.Market.Settings.Preset1);
		}
		return MarketView.Market.Settings.Preset1.QuoteSize;
	}

	public bool CheckUpdate()
	{
		return sOCfdwyPXkm;
	}

	public void q6xfdXiAZm6(bool P_0)
	{
		int num = 48;
		double num7 = default(double);
		double num8 = default(double);
		double num6 = default(double);
		double num4 = default(double);
		double num3 = default(double);
		bool executeInQuoteCurrency = default(bool);
		bool flag = default(bool);
		double num5 = default(double);
		bool? flag3 = default(bool?);
		bool flag2 = default(bool);
		double num9 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				bool num10;
				switch (num2)
				{
				case 7:
					OkgfdhXuGwa = false;
					return;
				case 8:
					JR1fgnn4aZ8.IsChecked = ((MarketSettings)G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))).Preset2IsSelected;
					num = 4;
					break;
				case 19:
					Y77LYlbHsK2iMGKj3m5I(LQefgorenue, MarketView.Market.Settings.Preset5IsSelected);
					X5LfdzkLoPJ = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.PresetAdjViaScrollMode;
					num2 = 3;
					continue;
				case 30:
					base.Y = num7 - 6.0;
					base.Height = WCKf6yfqAyx();
					num2 = 24;
					continue;
				case 15:
					PmvN54bHh0Vrui6Yxjne(GFHfgGBRtJj);
					num2 = 18;
					continue;
				case 36:
					GFHfgGBRtJj.IsChecked = MarketView.Market.Settings.Preset3IsSelected;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 != 0)
					{
						num2 = 1;
					}
					continue;
				case 51:
					fo4fdP20Vrm = fGOEkXbHyew4vr8XGS1K(MarketView.Market);
					GHQfdJhRRLS = num8;
					num2 = 52;
					continue;
				case 13:
					GFHfgGBRtJj.Height = eL2BBRbH7MFQLG3FDW97(GFHfgGBRtJj);
					R51fgYLfHsv.Height = eL2BBRbH7MFQLG3FDW97(R51fgYLfHsv);
					num2 = 21;
					continue;
				case 46:
				{
					Size size = jhcfdtJTAJe().GetSize((string)LSYwTYbHrIWxCVE8q6CE(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings));
					HkIfgfvK5Fy = new Rect(num6 + 1.0, num7 -= size.Height + 5.0, size.Width, size.Height);
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				case 9:
					if (QBgfgv3D7fV[4] == zQCjYCbHCYcXcvOvSFr3(LQefgorenue))
					{
						return;
					}
					goto IL_1071;
				case 35:
					if (!(P4kGVubHTu1yZFrZ8tAM(MarketView.Market) < n5of6t9ULd2()) && MarketView.Market.AKnfxPJ5PuD() == vmYfdAOsHjG && fGOEkXbHyew4vr8XGS1K(xDRVdGbH55RrWdp6ppq0(MarketView)) == fo4fdP20Vrm && jhcfdtJTAJe() == prHfd7PetUy && num8 == GHQfdJhRRLS)
					{
						num2 = 32;
						continue;
					}
					goto IL_1071;
				case 38:
					wI6f6U1bVuL(GFHfgGBRtJj.n5of6t9ULd2());
					goto IL_0131;
				case 11:
					wI6f6U1bVuL(HkIfgfvK5Fy.Width + 4.0);
					num2 = 17;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
					{
						num2 = 11;
					}
					continue;
				case 1:
					MJ8fdpA8yAV = num4;
					Y77LYlbHsK2iMGKj3m5I(R51fgYLfHsv, ((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).Preset4IsSelected);
					num = 16;
					break;
				case 2:
					WiLy5rbHmhRJrM0MkWG3(R51fgYLfHsv, num6, num7 -= R51fgYLfHsv.WCKf6yfqAyx() + 2.0);
					QBgfgv3D7fV[3] = R51fgYLfHsv.A9cf69hQ2ev();
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
					{
						num2 = 23;
					}
					continue;
				case 29:
					RKMf6ZDllHk(WCKf6yfqAyx() + IbFfg9vcdg4.WCKf6yfqAyx() + 2.0 + JR1fgnn4aZ8.WCKf6yfqAyx() + 2.0 + GFHfgGBRtJj.WCKf6yfqAyx() + 2.0 + R51fgYLfHsv.WCKf6yfqAyx() + 2.0 + eL2BBRbH7MFQLG3FDW97(LQefgorenue) + 2.0);
					if (IbFfg9vcdg4.n5of6t9ULd2() > n5of6t9ULd2())
					{
						wI6f6U1bVuL(P8rAbObH8cNkILYLfW8M(IbFfg9vcdg4));
					}
					if (JR1fgnn4aZ8.n5of6t9ULd2() > n5of6t9ULd2())
					{
						wI6f6U1bVuL(JR1fgnn4aZ8.n5of6t9ULd2());
					}
					if (GFHfgGBRtJj.n5of6t9ULd2() > n5of6t9ULd2())
					{
						num2 = 38;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_0131;
				case 23:
					GFHfgGBRtJj.Text = H5tfdLXUqXa(hRhfd3fK2pI);
					sNveaUbHQGdAiAv6S9ei(GFHfgGBRtJj, jhcfdtJTAJe());
					num = 15;
					break;
				default:
					if (!OkgfdhXuGwa)
					{
						return;
					}
					goto IL_0202;
				case 33:
					HGKfgHRnI5I = vZibTTbHUOaKHuMZQotV(j18iDj9nukSCmEyZs5lH.Settings);
					num2 = 34;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
					{
						num2 = 16;
					}
					continue;
				case 22:
					num7 += 4.0;
					wI6f6U1bVuL(0.0);
					num2 = 45;
					continue;
				case 43:
					IbFfg9vcdg4.Text = H5tfdLXUqXa(GHQfdJhRRLS);
					IbFfg9vcdg4.XOef6GXEQ2M(jhcfdtJTAJe());
					PmvN54bHh0Vrui6Yxjne(IbFfg9vcdg4);
					IbFfg9vcdg4.zSwf6HUsBr2(num6, num7 -= IbFfg9vcdg4.WCKf6yfqAyx() + 2.0);
					QBgfgv3D7fV[0] = IbFfg9vcdg4.A9cf69hQ2ev();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					HkIfgfvK5Fy.Width = n5of6t9ULd2();
					num2 = 26;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
					{
						num2 = 22;
					}
					continue;
				case 37:
					if (GFHfgGBRtJj.IsChecked == ljiBXpbHZNGTUtdVvAvv(MarketView.Market.Settings))
					{
						num2 = 40;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto IL_1071;
				case 40:
					AQZfg2w8typ = JLFqEJGJYiHaSdoROJXI.NpyGJkKFar8(cTRfg0fV7qO);
					num2 = 33;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
					{
						num2 = 24;
					}
					continue;
				case 44:
					num3 = PtHqIdbHxbUX5bCX8QAl(QjBkGPbHMdmZFPSaEiEx(G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))), executeInQuoteCurrency, flag);
					num4 = JBOfdewJhbd((EpdvD7f3hWq8UlJ32f6V)F6myGEbHqPfLUpUjQQ5m(MarketView.Market.Settings), executeInQuoteCurrency, flag);
					num2 = 25;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
					{
						num2 = 2;
					}
					continue;
				case 27:
					EsXUDhbHAsdqMBR46kj8(GFHfgGBRtJj, n5of6t9ULd2());
					R51fgYLfHsv.Width = n5of6t9ULd2();
					EsXUDhbHAsdqMBR46kj8(LQefgorenue, n5of6t9ULd2());
					IbFfg9vcdg4.Height = IbFfg9vcdg4.WCKf6yfqAyx();
					JR1fgnn4aZ8.Height = JR1fgnn4aZ8.WCKf6yfqAyx();
					num2 = 13;
					continue;
				case 14:
					IbFfg9vcdg4.Width = n5of6t9ULd2();
					EsXUDhbHAsdqMBR46kj8(JR1fgnn4aZ8, n5of6t9ULd2());
					num2 = 27;
					continue;
				case 25:
					num5 = JBOfdewJhbd(((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).Preset5, executeInQuoteCurrency, flag);
					flag3 = ((TradingSettings)z1yG01bHI79fuaRC9tHn(MarketView.Market))?.IsLotsInDOMShowed;
					flag2 = kCSfd8dufg0;
					num2 = 6;
					continue;
				case 6:
					if (flag3 == flag2 && !aM1FaCbHWKxoN5FDVRjt(MarketView.Market.Settings.CurrentPresetCurrency, cTRfg0fV7qO))
					{
						goto case 49;
					}
					goto IL_1071;
				case 42:
					TGTEogbHL3t8jBtOkXqy(LQefgorenue, H5tfdLXUqXa(FFdfdu7yb35));
					LQefgorenue.XOef6GXEQ2M(jhcfdtJTAJe());
					num2 = 20;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
					{
						num2 = 1;
					}
					continue;
				case 21:
					YfXlt8bHX2FUZblpwD6d(LQefgorenue, eL2BBRbH7MFQLG3FDW97(LQefgorenue));
					base.X = num6 - 2.0;
					num2 = 24;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
					{
						num2 = 30;
					}
					continue;
				case 3:
					num6 = MarketView.Market.AKnfxPJ5PuD() + 8.0;
					num7 = MarketView.Market.ActualHeight - 24.0;
					num = 42;
					break;
				case 32:
					if (num9 == eKcfdFsjgv0 && num3 == hRhfd3fK2pI)
					{
						num2 = 28;
						continue;
					}
					goto IL_1071;
				case 49:
					if (vZibTTbHUOaKHuMZQotV(hJq0vebHt9smRdhTifxe()) == HGKfgHRnI5I)
					{
						num2 = 35;
						continue;
					}
					goto IL_1071;
				case 17:
					RKMf6ZDllHk(HkIfgfvK5Fy.Height + 10.0);
					goto case 29;
				case 52:
					Y77LYlbHsK2iMGKj3m5I(IbFfg9vcdg4, XnNQZcbHKNYabRSjEQid(MarketView.Market.Settings));
					eKcfdFsjgv0 = num9;
					num2 = 8;
					continue;
				case 4:
					hRhfd3fK2pI = num3;
					num2 = 36;
					continue;
				case 28:
					if (num4 == MJ8fdpA8yAV && num5 == FFdfdu7yb35 && IbFfg9vcdg4.IsChecked == ((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).Preset1IsSelected && JR1fgnn4aZ8.IsChecked == MarketView.Market.Settings.Preset2IsSelected)
					{
						num2 = 37;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto IL_1071;
				case 5:
					if (!PXuwQVbHwchKkWuX9hyS(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.CurrentPresetCurrency))
					{
						num2 = 36;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
						{
							num2 = 46;
						}
						continue;
					}
					goto case 22;
				case 48:
					if (lrJfdZthgKK())
					{
						num2 = 47;
						continue;
					}
					goto default;
				case 18:
					WiLy5rbHmhRJrM0MkWG3(GFHfgGBRtJj, num6, num7 -= GFHfgGBRtJj.WCKf6yfqAyx() + 2.0);
					QBgfgv3D7fV[2] = GFHfgGBRtJj.A9cf69hQ2ev();
					num2 = 53;
					continue;
				case 45:
					RKMf6ZDllHk(0.0);
					num2 = 29;
					continue;
				case 34:
					prHfd7PetUy = jhcfdtJTAJe();
					vmYfdAOsHjG = kQJPg4bH1pluqvCEH2tI(xDRVdGbH55RrWdp6ppq0(MarketView));
					num2 = 51;
					continue;
				case 26:
					sOCfdwyPXkm = true;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 7;
					}
					continue;
				case 39:
					num9 = PtHqIdbHxbUX5bCX8QAl(MarketView.Market.Settings.Preset2, executeInQuoteCurrency, flag);
					num2 = 44;
					continue;
				case 31:
					QBgfgv3D7fV[4] = LQefgorenue.A9cf69hQ2ev();
					TGTEogbHL3t8jBtOkXqy(R51fgYLfHsv, H5tfdLXUqXa(MJ8fdpA8yAV));
					R51fgYLfHsv.XOef6GXEQ2M(jhcfdtJTAJe());
					R51fgYLfHsv.wmXf625PUN7();
					num2 = 2;
					continue;
				case 41:
					wI6f6U1bVuL(LQefgorenue.n5of6t9ULd2());
					num2 = 14;
					continue;
				case 20:
					LQefgorenue.wmXf625PUN7();
					WiLy5rbHmhRJrM0MkWG3(LQefgorenue, num6, num7 -= LQefgorenue.WCKf6yfqAyx() + 2.0);
					num = 31;
					break;
				case 50:
					if (R51fgYLfHsv.IsChecked == lmyosJbHgtLQCuqyc2MR(G1AABbbHDCSbdcrFvuC5(xDRVdGbH55RrWdp6ppq0(MarketView))))
					{
						num2 = 12;
						continue;
					}
					goto IL_1071;
				case 24:
					base.Width = n5of6t9ULd2() + 3.0;
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					if (fOoitBbHV9TCiEDENLmT(LQefgorenue) == ((MarketSettings)G1AABbbHDCSbdcrFvuC5(MarketView.Market)).Preset5IsSelected && X5LfdzkLoPJ == MarketView.Market.Settings.PresetAdjViaScrollMode && QBgfgv3D7fV[0] == IbFfg9vcdg4.A9cf69hQ2ev() && QBgfgv3D7fV[1] == JR1fgnn4aZ8.A9cf69hQ2ev() && QBgfgv3D7fV[2] == zQCjYCbHCYcXcvOvSFr3(GFHfgGBRtJj) && QBgfgv3D7fV[3] == R51fgYLfHsv.A9cf69hQ2ev())
					{
						num2 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_1071;
				case 54:
					JR1fgnn4aZ8.XOef6GXEQ2M(jhcfdtJTAJe());
					JR1fgnn4aZ8.wmXf625PUN7();
					WiLy5rbHmhRJrM0MkWG3(JR1fgnn4aZ8, num6, num7 -= JR1fgnn4aZ8.WCKf6yfqAyx() + 2.0);
					QBgfgv3D7fV[1] = zQCjYCbHCYcXcvOvSFr3(JR1fgnn4aZ8);
					num2 = 43;
					continue;
				case 53:
					TGTEogbHL3t8jBtOkXqy(JR1fgnn4aZ8, H5tfdLXUqXa(eKcfdFsjgv0));
					num2 = 54;
					continue;
				case 16:
					FFdfdu7yb35 = num5;
					num2 = 19;
					continue;
				case 47:
					{
						if (!P_0)
						{
							num2 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto IL_0202;
					}
					IL_0202:
					executeInQuoteCurrency = MarketView.Market.Settings.ExecuteInQuoteCurrency;
					flag = MRmdb6bHOFWnyJ3MWBZC(MarketView.Market.Settings);
					num8 = PtHqIdbHxbUX5bCX8QAl(AXHOD7bHSuUT3VZhwbK9(MarketView.Market.Settings), executeInQuoteCurrency, flag);
					num2 = 39;
					continue;
					IL_1071:
					num10 = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).TradingSettings?.IsLotsInDOMShowed ?? false;
					flag2 = num10;
					kCSfd8dufg0 = num10;
					base.IsVisible = flag2;
					if (!aM1FaCbHWKxoN5FDVRjt(cTRfg0fV7qO, LSYwTYbHrIWxCVE8q6CE(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings)))
					{
						goto case 33;
					}
					cTRfg0fV7qO = ((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings.CurrentPresetCurrency;
					num2 = 40;
					continue;
					IL_0131:
					if (R51fgYLfHsv.n5of6t9ULd2() > n5of6t9ULd2())
					{
						wI6f6U1bVuL(P8rAbObH8cNkILYLfW8M(R51fgYLfHsv));
					}
					if (LQefgorenue.n5of6t9ULd2() > n5of6t9ULd2())
					{
						num2 = 41;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f != 0)
						{
							num2 = 34;
						}
						continue;
					}
					goto case 14;
				}
				break;
			}
		}
	}

	[SpecialName]
	public bool lrJfdZthgKK()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				TradingSettings tradingSettings = MarketView.Market.TradingSettings;
				if (tradingSettings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (tradingSettings.IsLotsInDOMShowed)
				{
					object obj = z1yG01bHI79fuaRC9tHn(MarketView.Market);
					if (obj == null)
					{
						return true;
					}
					return !((TradingSettings)obj).IsExtendedLotsInDOMShowed;
				}
				break;
			}
			}
			break;
		}
		return false;
	}

	public void yURfdcvVHDg(Point P_0)
	{
		int num = 3;
		int num2 = num;
		Rect rect = default(Rect);
		List<XE24ZNf6Ekk5SJSRxcIv>.Enumerator enumerator = default(List<XE24ZNf6Ekk5SJSRxcIv>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				foreach (XE24ZNf6Ekk5SJSRxcIv item in base.Children)
				{
					item.IsMouseOver = dtkBn8bHJYOZVPwYK7ig(item).Contains(P_0);
					int num4 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					}
				}
				OkgfdhXuGwa = true;
				return;
			case 3:
				rect = base.Rect;
				num2 = 2;
				break;
			case 2:
				if (!rect.Contains(P_0))
				{
					enumerator = base.Children.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (enumerator.MoveNext())
						{
							XE24ZNf6Ekk5SJSRxcIv current = enumerator.Current;
							if (!tIoWP2bHPMBRsob16hih(current))
							{
								continue;
							}
							current.IsMouseOver = false;
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
							{
								num3 = 0;
							}
						}
						switch (num3)
						{
						case 1:
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 1;
			}
		}
	}

	public bool i35fdjUwJr9(Point P_0)
	{
		int num = 2;
		int num2 = num;
		Rect rect = default(Rect);
		List<XE24ZNf6Ekk5SJSRxcIv>.Enumerator enumerator2 = default(List<XE24ZNf6Ekk5SJSRxcIv>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!rect.Contains(P_0))
				{
					using (List<XE24ZNf6Ekk5SJSRxcIv>.Enumerator enumerator = base.Children.GetEnumerator())
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
								{
									num3 = 0;
								}
							}
							else
							{
								XE24ZNf6Ekk5SJSRxcIv current = enumerator.Current;
								if (!current.IsPressed)
								{
									continue;
								}
								current.IsPressed = false;
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
								{
									num3 = 0;
								}
							}
							switch (num3)
							{
							case 1:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					return false;
				}
				enumerator2 = base.Children.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				rect = base.Rect;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return true;
			}
			try
			{
				while (enumerator2.MoveNext())
				{
					XE24ZNf6Ekk5SJSRxcIv current2 = enumerator2.Current;
					rect = current2.Rect;
					current2.IsPressed = rect.Contains(P_0);
				}
				int num4 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
			finally
			{
				((IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
			}
			OkgfdhXuGwa = true;
			num2 = 3;
		}
	}

	public bool H7JfdEFFTyZ(Point P_0)
	{
		if (!base.Rect.Contains(P_0))
		{
			return false;
		}
		foreach (XE24ZNf6Ekk5SJSRxcIv item in base.Children)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					if (IRFFQLbHFpgBPdU7Df42(item))
					{
						item.IsPressed = false;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				case 1:
					item.UiUf68f7sq5()();
					break;
				}
				break;
			}
		}
		OkgfdhXuGwa = true;
		return true;
	}

	public bool teNfdQNBRPk(Point P_0)
	{
		if (!base.Rect.Contains(P_0))
		{
			return false;
		}
		YQnf6Jy97j6()();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => true, 
		};
	}

	public void Khal96VceVj(DxVisualQueue P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				sOCfdwyPXkm = false;
				num2 = 3;
				break;
			case 3:
				return;
			case 1:
			{
				Rect clip = new Rect(base.X, base.Y, A3nsp8bH3PlDEdqQAtLc(YtYfdqssgWw().Width - 8.0, base.Width + 3.0), base.Height + 1.0);
				P_0.SetClip(clip);
				try
				{
					XgQfddDgQ4H(P_0);
					P_0.DrawString(AQZfg2w8typ, ((MarketSettings)t05BeKbHpJKbQvEeLq0r(MarketView)).BaseBoldFont, yKvfdTbkNwN(), HkIfgfvK5Fy, XTextAlignment.Center);
					sjp1QMbHuKZCVW7smvTn(IbFfg9vcdg4, P_0);
					JR1fgnn4aZ8.wvHf6fPHCBS(P_0);
					int num3 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							R51fgYLfHsv.wvHf6fPHCBS(P_0);
							LQefgorenue.wvHf6fPHCBS(P_0);
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							GFHfgGBRtJj.wvHf6fPHCBS(P_0);
							num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				finally
				{
					mLPbNFbHzHg4jt7V0nqB(P_0);
				}
				sOCfdwyPXkm = false;
				return;
			}
			case 2:
				if (lrJfdZthgKK())
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private void XgQfddDgQ4H(DxVisualQueue P_0)
	{
		OI4aMbbf2uNpEl8C3FNk(P_0, SxO3U0bf09rJHGyCJaaZ(MarketView.Theme), base.Rect, fhJfdrgQfdX);
		yLaXgpbffevyL9ubs2cx(P_0, ((brG9LqfO0TVwbKGahwYo)Y22b2HbfHFc3P9bfOiZ3(MarketView)).KJOfVDuxZsI, base.Rect, fhJfdrgQfdX);
	}

	[CompilerGenerated]
	private void kWtfdgL6l9O()
	{
		i6kgh3bf9INnNkfJkD7m(G1AABbbHDCSbdcrFvuC5(MarketView.Market), true);
	}

	[CompilerGenerated]
	private void mrkfdRM3RiS()
	{
		MarketView.Market.Settings.Preset2IsSelected = true;
	}

	[CompilerGenerated]
	private void vGkfd6unQbY()
	{
		PXSfplbfnEgw6Ctciovb(((cXwoI5f1jl9EMXW8XL7D)xDRVdGbH55RrWdp6ppq0(MarketView)).Settings, true);
	}

	[CompilerGenerated]
	private void SFBfdMqAH7o()
	{
		xKfEgxbfGky2oI2akvG5(G1AABbbHDCSbdcrFvuC5(MarketView.Market), true);
	}

	[CompilerGenerated]
	private void qWRfdO2fYPZ()
	{
		MarketView.Market.Settings.Preset5IsSelected = true;
	}

	static LotWidget()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object HAhicsbHlRWibWnKk6yy(object P_0)
	{
		return ((MarketSettings)P_0).BaseFont;
	}

	internal static bool OLkkBkbHar9SVvSZb3hd()
	{
		return LYCXgHbHBYHFkOfYYwWx == null;
	}

	internal static LotWidget vbiIxxbHiQRcCFiHHwvg()
	{
		return LYCXgHbHBYHFkOfYYwWx;
	}

	internal static bool h1JawdbH4q7K7WXnx8xq(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInQuoteCurrency;
	}

	internal static object G1AABbbHDCSbdcrFvuC5(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).Settings;
	}

	internal static double IhMKjVbHbOcDYcjSNG7Y(double P_0)
	{
		return Math.Round(P_0);
	}

	internal static double t8u1adbHNbj58k9ICc3V(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).Size;
	}

	internal static void vX658XbHk10U3lWAQmPc()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static double kQJPg4bH1pluqvCEH2tI(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).AKnfxPJ5PuD();
	}

	internal static object xDRVdGbH55RrWdp6ppq0(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Market;
	}

	internal static object AXHOD7bHSuUT3VZhwbK9(object P_0)
	{
		return ((MarketSettings)P_0).Preset1;
	}

	internal static double PtHqIdbHxbUX5bCX8QAl(object P_0, bool P_1, bool P_2)
	{
		return JBOfdewJhbd((EpdvD7f3hWq8UlJ32f6V)P_0, P_1, P_2);
	}

	internal static void TGTEogbHL3t8jBtOkXqy(object P_0, object P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).Text = (string)P_1;
	}

	internal static void a5Z2o1bHeMP4fvPpY2TU(object P_0, Point P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).CornerRadius = P_1;
	}

	internal static void Y77LYlbHsK2iMGKj3m5I(object P_0, bool P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).IsChecked = P_1;
	}

	internal static void YfXlt8bHX2FUZblpwD6d(object P_0, double P_1)
	{
		((XE24ZNf6Ekk5SJSRxcIv)P_0).Height = P_1;
	}

	internal static object ETOdd0bHcvDyoXNcCQq9(object P_0)
	{
		return ((MarketSettings)P_0).Preset2;
	}

	internal static bool MtJVCVbHjgpBD1E0PJht(object P_0)
	{
		return ((MarketSettings)P_0).Preset2IsSelected;
	}

	internal static void UsR2TCbHEDVJrUbe6Bes(object P_0, object P_1)
	{
		((XE24ZNf6Ekk5SJSRxcIv)P_0).GMGf6AnwLRY((Action)P_1);
	}

	internal static void sNveaUbHQGdAiAv6S9ei(object P_0, object P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).XOef6GXEQ2M((XFont)P_1);
	}

	internal static void Mo6I1UbHd5d8k7ExRO7f(object P_0, Thickness P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).Padding = P_1;
	}

	internal static bool lmyosJbHgtLQCuqyc2MR(object P_0)
	{
		return ((MarketSettings)P_0).Preset4IsSelected;
	}

	internal static object JCpEMUbHRcCEuPkkevV4(object P_0)
	{
		return ((MarketSettings)P_0).Preset5;
	}

	internal static double XUBlaZbH6NqDUebP9GyO(object P_0)
	{
		return ((EpdvD7f3hWq8UlJ32f6V)P_0).QuoteSize;
	}

	internal static object QjBkGPbHMdmZFPSaEiEx(object P_0)
	{
		return ((MarketSettings)P_0).Preset3;
	}

	internal static bool MRmdb6bHOFWnyJ3MWBZC(object P_0)
	{
		return ((MarketSettings)P_0).ExecuteInPercents;
	}

	internal static object F6myGEbHqPfLUpUjQQ5m(object P_0)
	{
		return ((MarketSettings)P_0).Preset4;
	}

	internal static object z1yG01bHI79fuaRC9tHn(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).TradingSettings;
	}

	internal static bool aM1FaCbHWKxoN5FDVRjt(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object hJq0vebHt9smRdhTifxe()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static int vZibTTbHUOaKHuMZQotV(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).QuoteCurrencyOrderDecimals;
	}

	internal static double P4kGVubHTu1yZFrZ8tAM(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).padfx7SrsRZ();
	}

	internal static double fGOEkXbHyew4vr8XGS1K(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static bool ljiBXpbHZNGTUtdVvAvv(object P_0)
	{
		return ((MarketSettings)P_0).Preset3IsSelected;
	}

	internal static bool fOoitBbHV9TCiEDENLmT(object P_0)
	{
		return ((mMFDCqfRzaRLlovS6k5D)P_0).IsChecked;
	}

	internal static R3D7xnf6XASVgU8V4BJg zQCjYCbHCYcXcvOvSFr3(object P_0)
	{
		return ((mMFDCqfRzaRLlovS6k5D)P_0).A9cf69hQ2ev();
	}

	internal static object LSYwTYbHrIWxCVE8q6CE(object P_0)
	{
		return ((MarketSettings)P_0).CurrentPresetCurrency;
	}

	internal static bool XnNQZcbHKNYabRSjEQid(object P_0)
	{
		return ((MarketSettings)P_0).Preset1IsSelected;
	}

	internal static void WiLy5rbHmhRJrM0MkWG3(object P_0, double P_1, double P_2)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).zSwf6HUsBr2(P_1, P_2);
	}

	internal static void PmvN54bHh0Vrui6Yxjne(object P_0)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).wmXf625PUN7();
	}

	internal static bool PXuwQVbHwchKkWuX9hyS(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static double eL2BBRbH7MFQLG3FDW97(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).WCKf6yfqAyx();
	}

	internal static double P8rAbObH8cNkILYLfW8M(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).n5of6t9ULd2();
	}

	internal static void EsXUDhbHAsdqMBR46kj8(object P_0, double P_1)
	{
		((XE24ZNf6Ekk5SJSRxcIv)P_0).Width = P_1;
	}

	internal static bool tIoWP2bHPMBRsob16hih(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).IsMouseOver;
	}

	internal static Rect dtkBn8bHJYOZVPwYK7ig(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).Rect;
	}

	internal static bool IRFFQLbHFpgBPdU7Df42(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).IsPressed;
	}

	internal static double A3nsp8bH3PlDEdqQAtLc(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object t05BeKbHpJKbQvEeLq0r(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Settings;
	}

	internal static void sjp1QMbHuKZCVW7smvTn(object P_0, object P_1)
	{
		((mMFDCqfRzaRLlovS6k5D)P_0).wvHf6fPHCBS((DxVisualQueue)P_1);
	}

	internal static void mLPbNFbHzHg4jt7V0nqB(object P_0)
	{
		((DxVisualQueue)P_0).ResetClip();
	}

	internal static object SxO3U0bf09rJHGyCJaaZ(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).xGBfVBW066q;
	}

	internal static void OI4aMbbf2uNpEl8C3FNk(object P_0, object P_1, Rect P_2, Point P_3)
	{
		((DxVisualQueue)P_0).FillRoundedRectangle((XBrush)P_1, P_2, P_3);
	}

	internal static object Y22b2HbfHFc3P9bfOiZ3(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Theme;
	}

	internal static void yLaXgpbffevyL9ubs2cx(object P_0, object P_1, Rect P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawRoundedRectangle((XPen)P_1, P_2, P_3);
	}

	internal static void i6kgh3bf9INnNkfJkD7m(object P_0, bool value)
	{
		((MarketSettings)P_0).Preset1IsSelected = value;
	}

	internal static void PXSfplbfnEgw6Ctciovb(object P_0, bool value)
	{
		((MarketSettings)P_0).Preset3IsSelected = value;
	}

	internal static void xKfEgxbfGky2oI2akvG5(object P_0, bool value)
	{
		((MarketSettings)P_0).Preset4IsSelected = value;
	}
}
