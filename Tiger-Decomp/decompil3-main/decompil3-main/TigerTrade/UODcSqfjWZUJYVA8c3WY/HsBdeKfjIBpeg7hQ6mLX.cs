using System;
using System.Windows;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using k2djPS9h3aXysXOe0uK1;
using LkgWJcfsLbF5GV6NcGQ4;
using m5KHHSfSCCCvZdkMl316;
using nDRVH5fO2N3bDxUGOOrY;
using NsWD4W9miMxRbFU3fsu9;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using umVEdnfXIjFXnbgukFHn;
using X38Ak5fjTXeLLeGJEvlZ;
using XUi8EWf1E6l7gdu7kUS9;

namespace UODcSqfjWZUJYVA8c3WY;

internal sealed class HsBdeKfjIBpeg7hQ6mLX : sHcWhbfjUODaD3OmcO7M
{
	public bool IsVisible;

	private static HsBdeKfjIBpeg7hQ6mLX gxHaOMDpR7WDPH8JWcIS;

	public HsBdeKfjIBpeg7hQ6mLX(wFFFvWfsxErbxn4XFmrR P_0, IS7h8SfXqbONIdCkb7Kr P_1)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector(P_0, P_1);
	}

	public override void Khal96VceVj(DxVisualQueue P_0, bool P_1)
	{
		int num = 36;
		double num7 = default(double);
		double num8 = default(double);
		double width = default(double);
		Rect rect = default(Rect);
		XBrush brush3 = default(XBrush);
		Rect rect3 = default(Rect);
		bool flag = default(bool);
		CoPfjK9hF3ASs5TbM8OK coPfjK9hF3ASs5TbM8OK = default(CoPfjK9hF3ASs5TbM8OK);
		XFont xFont = default(XFont);
		string text = default(string);
		Rect rect2 = default(Rect);
		double num5 = default(double);
		XBrush brush2 = default(XBrush);
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = default(ypqMIv9maFM0tRwF0xMh);
		XBrush brush = default(XBrush);
		double num6 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				object obj;
				object obj2;
				object obj3;
				double num3;
				switch (num2)
				{
				case 10:
					num7 = num8;
					width = rect.Width - num8 * 2.0;
					num2 = 33;
					continue;
				case 16:
					P_0.FillRectangle(brush3, rect3);
					P_0.DrawLine(base.MarketView.Theme.xGQfOQ3FZKP, new Point(rect3.Right, rect3.Top), new Point(rect3.Right, rect3.Bottom));
					if (flag && coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
					{
						num2 = 31;
						continue;
					}
					P_0.DrawString((string)AuqNC6DpP3b95XoWjQBi(-1848952786 ^ -1848922020), xFont, (XBrush)DbhPu3DpJImJDxqnGC7x(base.MarketView.Theme), rect3, XTextAlignment.Center);
					num2 = 19;
					continue;
				case 7:
					text = coPfjK9hF3ASs5TbM8OK.Nvk9wQQ3B5b(((MarketSettings)hTvn2cDppIg46bSOY5eK(base.MarketView)).TradeSettings.PositionSizeDisplayType, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44509943));
					num2 = 29;
					continue;
				case 13:
				case 32:
					if (!flag || !j18iDj9nukSCmEyZs5lH.Settings.MarketShowTotalOrders)
					{
						cHofjPYyXR1(Rect.Empty);
						FvKfj3J0SdR(Rect.Empty);
						return;
					}
					if (coPfjK9hF3ASs5TbM8OK.TotalAsks > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc == 0)
						{
							num2 = 1;
						}
						continue;
					}
					cHofjPYyXR1(Q3sjsHDu2VK5PJvJhJGO());
					goto IL_0926;
				case 4:
					coPfjK9hF3ASs5TbM8OK = base.MarketView.Market.DataProvider.d73l9JpDb23.Position;
					xFont = wwOfjCuseDX();
					C0rfEYX0tqd = lY2fjKdTHW4();
					if (C0rfEYX0tqd)
					{
						VPUfEiRZ4ZS = true;
					}
					base.MarketView.Market.QrafLjASmWS();
					rect2 = new Rect(jaNbOcDpIRaNeVxBQ8uU(base.MarketView.Market), 0.0, ((XrTs9ufSVt0hx8rJDd6l)ficieoDpW7p3EUblJJ0W(base.MarketView)).DomWidth - hip8eADptPtx7qT7pdpW(base.MarketView.Market) + 2.0, D84s4RDpUnIcCDYgvHSi(base.MarketView.Market) + 6.0);
					rect = new Rect(mifANADpTEtMHMx9GPyW(base.MarketView.Market), DIM9baDpy3yBbqY37MYU(base.MarketView) - num5, suw2TADpZ8oq6DxZHF1q(base.MarketView.Market) + base.MarketView.Market.DomWidth + 2.0, num5);
					num2 = 3;
					continue;
				case 22:
					P_0.DrawLine(base.MarketView.Theme.xGQfOQ3FZKP, new Point(UB6fEnsGZJb.Right, UB6fEnsGZJb.Top), new Point(UB6fEnsGZJb.Right, UB6fEnsGZJb.Bottom));
					if (flag && coPfjK9hF3ASs5TbM8OK.PositionSize != 0L)
					{
						num2 = 7;
						continue;
					}
					goto case 30;
				case 21:
					P_0.FillRectangle(brush2, UB6fEnsGZJb);
					num2 = 22;
					continue;
				case 31:
					Kt9E2tDpAh25b0bZ5EnZ(P_0, base.MarketView.Symbol.uhTnGh8ahcs(ait6qFDp75x2KhurEYmc(coPfjK9hF3ASs5TbM8OK), _0020: true), xFont, EJQ4HBDp8tSLA3ASKU4L(base.MarketView, coPfjK9hF3ASs5TbM8OK.PositionSize), rect3, XTextAlignment.Center);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
					{
						num2 = 12;
					}
					continue;
				case 35:
					if (DataManager.IsTradeAllowed((UserPosition)jJyHKXDpqFrtCP6c8J6E(ypqMIv9maFM0tRwF0xMh.d73l9JpDb23.Position)))
					{
						num = 6;
						break;
					}
					num4 = 0;
					goto IL_0a4c;
				case 14:
					if (PJgy4wDpuT3nDbeRMmcv(coPfjK9hF3ASs5TbM8OK) >= 0)
					{
						num = 15;
						break;
					}
					obj = ADoAaNDpzSYtN7ehbEXQ(base.MarketView.Theme);
					goto IL_0ad0;
				case 6:
					num4 = (DataManager.IsTradeAllowed(SymbolManager.Get(ypqMIv9maFM0tRwF0xMh.Symbol.Code)) ? 1 : 0);
					goto IL_0a4c;
				case 3:
					if (C0rfEYX0tqd)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto IL_08a8;
				case 24:
					obj2 = ((brG9LqfO0TVwbKGahwYo)QWvr16DpVrDe2u5oKwcL(base.MarketView)).Iw3fqi1AYJS;
					goto IL_0aa4;
				case 15:
					obj = base.MarketView.Theme.Iw3fqi1AYJS;
					goto IL_0ad0;
				case 33:
					rect3 = new Rect(rect.Left, rect.Top, num8, num5);
					if (!C0rfEYX0tqd)
					{
						goto case 12;
					}
					if (coPfjK9hF3ASs5TbM8OK.PositionSize <= 0)
					{
						num2 = 28;
						continue;
					}
					obj3 = iP4d8tDpwnvxDrxpKge2(QWvr16DpVrDe2u5oKwcL(base.MarketView));
					goto IL_0a78;
				default:
					num5 = f4MfjViufkk();
					num2 = 4;
					continue;
				case 1:
					cHofjPYyXR1(FdMfjtDRNtg(P_0, coPfjK9hF3ASs5TbM8OK.n1p9wC5SR3U(), coPfjK9hF3ASs5TbM8OK.TotalAsks, rect2.Top, coPfjK9hF3ASs5TbM8OK.TNi9w7nq0W8()));
					goto IL_0926;
				case 5:
					hslQqyDprgRnbqPNWDq1(P_0, a4kDwWDpCbHn0JSGVdpU(QWvr16DpVrDe2u5oKwcL(base.MarketView)), rect);
					K6Jtc0DpKHAKHjyB8fP7(P_0, base.MarketView.Theme.xGQfOQ3FZKP, new Point(rect.Left, rect.Top), new Point(rect.Right, rect.Top));
					goto IL_08a8;
				case 26:
					if (C0rfEYX0tqd)
					{
						num = 23;
						break;
					}
					goto case 8;
				case 20:
					num8 = Math.Round(rect.Width / 3.0);
					num = 10;
					break;
				case 8:
					num3 = rect.Bottom - D84s4RDpUnIcCDYgvHSi(base.MarketView.Market);
					goto IL_0af4;
				case 27:
					Kt9E2tDpAh25b0bZ5EnZ(P_0, base.MarketView.dI4fsUgnv5h(), xFont, base.MarketView.AX8fstiWLhA(coPfjK9hF3ASs5TbM8OK.PositionPnl), s6ffEGw2PUU, XTextAlignment.Center);
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					if (yGmGhrDpF2SfaIRif9oF(coPfjK9hF3ASs5TbM8OK) != 0L)
					{
						num = 27;
						break;
					}
					goto IL_08bf;
				case 28:
					obj3 = ((coPfjK9hF3ASs5TbM8OK.PositionSize < 0) ? ((brG9LqfO0TVwbKGahwYo)QWvr16DpVrDe2u5oKwcL(base.MarketView)).yr1fqxqmDc2 : bmPmInDphvvLU0oGDWO2(QWvr16DpVrDe2u5oKwcL(base.MarketView)));
					goto IL_0a78;
				case 29:
					Kt9E2tDpAh25b0bZ5EnZ(P_0, text, xFont, EJQ4HBDp8tSLA3ASKU4L(base.MarketView, coPfjK9hF3ASs5TbM8OK.PositionSize), UB6fEnsGZJb, XTextAlignment.Center);
					goto case 17;
				case 2:
					if (num7 < num8)
					{
						num2 = 20;
						continue;
					}
					goto case 33;
				case 34:
					P_0.FillRectangle(brush, s6ffEGw2PUU);
					if (flag)
					{
						num2 = 9;
						continue;
					}
					goto IL_08bf;
				case 36:
					ypqMIv9maFM0tRwF0xMh = (ypqMIv9maFM0tRwF0xMh)rVogeUDpOvs38TpBIhnl(base.MarketView.Market);
					num2 = 28;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
					{
						num2 = 35;
					}
					continue;
				case 11:
					FvKfj3J0SdR(FdMfjtDRNtg(P_0, wyfSk9DufWlK5E6ontln(coPfjK9hF3ASs5TbM8OK), L8HnIQDuHCxTZ6ScIRtX(coPfjK9hF3ASs5TbM8OK), num6, coPfjK9hF3ASs5TbM8OK.n2w9wmQBJPf()));
					num2 = 25;
					continue;
				case 25:
					return;
				case 30:
					P_0.DrawString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1878953018 ^ -1878918330), xFont, ((brG9LqfO0TVwbKGahwYo)QWvr16DpVrDe2u5oKwcL(base.MarketView)).cYJfOxYsuth, UB6fEnsGZJb, XTextAlignment.Center);
					num2 = 17;
					continue;
				case 18:
					if (C0rfEYX0tqd)
					{
						if (coPfjK9hF3ASs5TbM8OK.PositionPnl <= 0)
						{
							num2 = 14;
							continue;
						}
						obj = JLU8SUDu0nwieENA2mVv(QWvr16DpVrDe2u5oKwcL(base.MarketView));
						goto IL_0ad0;
					}
					num2 = 15;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
					{
						num2 = 32;
					}
					continue;
				case 17:
					s6ffEGw2PUU = new Rect(UB6fEnsGZJb.Right, UB6fEnsGZJb.Top, width, UB6fEnsGZJb.Height);
					num2 = 18;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
				case 19:
					UB6fEnsGZJb = new Rect(rect3.Right, rect3.Top, num7, num5);
					if (!C0rfEYX0tqd)
					{
						goto case 17;
					}
					if (coPfjK9hF3ASs5TbM8OK.PositionSize <= 0)
					{
						if (yGmGhrDpF2SfaIRif9oF(coPfjK9hF3ASs5TbM8OK) >= 0)
						{
							num2 = 24;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
							{
								num2 = 13;
							}
							continue;
						}
						obj2 = zrfiZODp3lxpQnoQlaPa(QWvr16DpVrDe2u5oKwcL(base.MarketView));
					}
					else
					{
						obj2 = ((brG9LqfO0TVwbKGahwYo)QWvr16DpVrDe2u5oKwcL(base.MarketView)).BK4fqchjNiB;
					}
					goto IL_0aa4;
				case 23:
					{
						num3 = rect.Top - base.MarketView.Market.I8MfLNiJ00B();
						goto IL_0af4;
					}
					IL_0a4c:
					flag = (byte)num4 != 0;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
					{
						num2 = 0;
					}
					continue;
					IL_0aa4:
					brush2 = (XBrush)obj2;
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 21;
					}
					continue;
					IL_08bf:
					P_0.DrawString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-673683647 ^ -673648691), xFont, base.MarketView.Theme.cYJfOxYsuth, s6ffEGw2PUU, XTextAlignment.Center);
					goto case 13;
					IL_08a8:
					num8 = IsvAEDDpmXFoYojdbOyD(base.MarketView.Market);
					num7 = Math.Round((rect.Width - num8) / 2.0);
					width = num7;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
					{
						num2 = 2;
					}
					continue;
					IL_0926:
					if (L8HnIQDuHCxTZ6ScIRtX(coPfjK9hF3ASs5TbM8OK) <= 0)
					{
						FvKfj3J0SdR(Rect.Empty);
						return;
					}
					num2 = 26;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
					{
						num2 = 16;
					}
					continue;
					IL_0af4:
					num6 = num3;
					num2 = 11;
					continue;
					IL_0a78:
					brush3 = (XBrush)obj3;
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
					{
						num2 = 16;
					}
					continue;
					IL_0ad0:
					brush = (XBrush)obj;
					num2 = 34;
					continue;
				}
				break;
			}
		}
	}

	private Rect FdMfjtDRNtg(DxVisualQueue P_0, double P_1, long P_2, double P_3, Side P_4)
	{
		int num = 2;
		int num2 = num;
		XBrush brush = default(XBrush);
		XFont xFont = default(XFont);
		string text = default(string);
		Rect rect = default(Rect);
		while (true)
		{
			switch (num2)
			{
			case 3:
				brush = egofjhU4Cme(P_4);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				xFont = mtofjrh5PRq();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				text = sGCfj8hTxVi(P_1, P_2);
				double num3 = pvjfj78ILQ8(xFont, text);
				rect = new Rect(base.MarketView.Market.nJ7fL9cL9PV() - num3, P_3, num3, base.MarketView.Market.I8MfLNiJ00B());
				num2 = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
				{
					num2 = 3;
				}
				break;
			}
			default:
				hslQqyDprgRnbqPNWDq1(P_0, base.MarketView.Theme.PKbfONj9WlI, rect);
				P_0.FillRectangle(brush, rect);
				P_0.DrawString(text, xFont, (XBrush)DbhPu3DpJImJDxqnGC7x(QWvr16DpVrDe2u5oKwcL(base.MarketView)), rect, XTextAlignment.Center);
				return rect;
			}
		}
	}

	static HsBdeKfjIBpeg7hQ6mLX()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool sSDQFoDp6UinJDyeryil()
	{
		return gxHaOMDpR7WDPH8JWcIS == null;
	}

	internal static HsBdeKfjIBpeg7hQ6mLX yfd34LDpMPyUYJMEvMRq()
	{
		return gxHaOMDpR7WDPH8JWcIS;
	}

	internal static object rVogeUDpOvs38TpBIhnl(object P_0)
	{
		return ((cXwoI5f1jl9EMXW8XL7D)P_0).DataProvider;
	}

	internal static object jJyHKXDpqFrtCP6c8J6E(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).XlV9wd4ELTW();
	}

	internal static double jaNbOcDpIRaNeVxBQ8uU(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).iDafL2mbSql();
	}

	internal static object ficieoDpW7p3EUblJJ0W(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Market;
	}

	internal static double hip8eADptPtx7qT7pdpW(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).QrafLjASmWS();
	}

	internal static double D84s4RDpUnIcCDYgvHSi(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).I8MfLNiJ00B();
	}

	internal static double mifANADpTEtMHMx9GPyW(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).AKnfxPJ5PuD();
	}

	internal static double DIM9baDpy3yBbqY37MYU(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).wD9fXGNmvlC();
	}

	internal static double suw2TADpZ8oq6DxZHF1q(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).padfx7SrsRZ();
	}

	internal static object QWvr16DpVrDe2u5oKwcL(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Theme;
	}

	internal static object a4kDwWDpCbHn0JSGVdpU(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).PKbfONj9WlI;
	}

	internal static void hslQqyDprgRnbqPNWDq1(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void K6Jtc0DpKHAKHjyB8fP7(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static double IsvAEDDpmXFoYojdbOyD(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).xRqfLLPDWBF();
	}

	internal static object bmPmInDphvvLU0oGDWO2(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).Iw3fqi1AYJS;
	}

	internal static object iP4d8tDpwnvxDrxpKge2(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).yUmfqNQLbAK;
	}

	internal static long ait6qFDp75x2KhurEYmc(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionPrice;
	}

	internal static object EJQ4HBDp8tSLA3ASKU4L(object P_0, double P_1)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).AX8fstiWLhA(P_1);
	}

	internal static void Kt9E2tDpAh25b0bZ5EnZ(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object AuqNC6DpP3b95XoWjQBi(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object DbhPu3DpJImJDxqnGC7x(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).cYJfOxYsuth;
	}

	internal static long yGmGhrDpF2SfaIRif9oF(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionSize;
	}

	internal static object zrfiZODp3lxpQnoQlaPa(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).lF2fqgcGFiy;
	}

	internal static object hTvn2cDppIg46bSOY5eK(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Settings;
	}

	internal static long PJgy4wDpuT3nDbeRMmcv(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).PositionPnl;
	}

	internal static object ADoAaNDpzSYtN7ehbEXQ(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).cp4fqT507QS;
	}

	internal static object JLU8SUDu0nwieENA2mVv(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).fyofqq7V7p2;
	}

	internal static Rect Q3sjsHDu2VK5PJvJhJGO()
	{
		return Rect.Empty;
	}

	internal static long L8HnIQDuHCxTZ6ScIRtX(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).TotalBids;
	}

	internal static double wyfSk9DufWlK5E6ontln(object P_0)
	{
		return ((CoPfjK9hF3ASs5TbM8OK)P_0).wi79wyoPAc5();
	}
}
