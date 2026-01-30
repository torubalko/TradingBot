using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using aRWmuh2vhchcbeymfINj;
using ECOEgqlSad8NUJZ2Dr9n;
using gV1DZv2vuJ5qRQX2kKAO;
using j1BN742BOhpRMoKB7dJN;
using NEssfs2G0ClPwDWgYxdZ;
using TigerTrade.Config.Common;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.DocControls.Statistics.Controls;

internal sealed class EquityChart : UserControl, IComponentConnector
{
	private readonly DxVisualQueue visualQueue;

	private readonly List<CiyPMi2BMhk9879qqk2F> _chartPoints;

	private double _maxPoint;

	private double _minPoint;

	private int _mouseX;

	private int _mouseY;

	private bool _updated;

	internal DxHwndHost HwndHost;

	private bool _contentLoaded;

	private static EquityChart P8DK3M4OQpbJFwhP9KHf;

	public EquityChart()
	{
		timxMk4ORhRrR7rvKmol();
		visualQueue = new DxVisualQueue();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				InitializeComponent();
				_chartPoints = new List<CiyPMi2BMhk9879qqk2F>
				{
					new CiyPMi2BMhk9879qqk2F()
				};
				HwndHost.OnTimerTick += OnTimerTick;
				HwndHost.OnRenderVisual += OnRender;
				num = 2;
				break;
			case 2:
				vs1rsY4O65x9dM1PvC3p(HwndHost, 50);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void AddPoint(UserDeal deal, Symbol symbol)
	{
		CiyPMi2BMhk9879qqk2F ciyPMi2BMhk9879qqk2F = _chartPoints.LastOrDefault();
		int num;
		if (ciyPMi2BMhk9879qqk2F != null)
		{
			List<CiyPMi2BMhk9879qqk2F> chartPoints = _chartPoints;
			CiyPMi2BMhk9879qqk2F obj = new CiyPMi2BMhk9879qqk2F
			{
				X = ciyPMi2BMhk9879qqk2F.X + 1
			};
			IaM5pu4OOfs5tnkEG3o1(obj, M1SVWX4OMyeDIw4VNRpE(symbol, deal.OpenTime));
			obj.Points = c2ctrj4OqdH271KIVtbv(ciyPMi2BMhk9879qqk2F) + sdPpCP4OISgaelGGkuiV(deal);
			obj.GrossPnl = Math.Round(ciyPMi2BMhk9879qqk2F.GrossPnl + deal.Profit, symbol.PnlPrecision);
			obj.NetPnl = Math.Round(CYQYO64OWIaE57lQJeEg(ciyPMi2BMhk9879qqk2F) + SBVLWx4Otuaw7RLhrEKw(deal) - deal.Comission, symbol.PnlPrecision);
			MJKQs54OTMUyBKVjNxmw(obj, Math.Round(ciyPMi2BMhk9879qqk2F.Comission + deal.Comission, BDOSQ44OUldZXCZC1Ibi(symbol)));
			obj.Ii42BhFod0R(kXMG3E4OyTfTDZ6qMf57(symbol));
			rOnpVj4OZEZ9PZiLQXj9(obj, symbol.PnlPrecision);
			chartPoints.Add(obj);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
			{
				num = 1;
			}
		}
		else
		{
			List<CiyPMi2BMhk9879qqk2F> chartPoints2 = _chartPoints;
			CiyPMi2BMhk9879qqk2F obj2 = new CiyPMi2BMhk9879qqk2F
			{
				X = 1
			};
			Cx5LIq4OVXBpEeqlZwrQ(obj2, sdPpCP4OISgaelGGkuiV(deal));
			obj2.GrossPnl = Math.Round(deal.Profit, symbol.PnlPrecision);
			obj2.NetPnl = OomvFF4OriA8M0TPybT8(deal.Profit - DM8BwI4OCKXayaqt33Ea(deal), BDOSQ44OUldZXCZC1Ibi(symbol));
			obj2.Comission = Math.Round(DM8BwI4OCKXayaqt33Ea(deal), symbol.PnlPrecision);
			tynjva4OKnvVtr6whDAb(obj2, symbol.Precision);
			obj2.qRx2B8Unvlc(BDOSQ44OUldZXCZC1Ibi(symbol));
			chartPoints2.Add(obj2);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		}
		_updated = true;
	}

	public void AddPoints(IEnumerable<TE5Z4B2nzNQDjdIXnWaQ> deals)
	{
		foreach (TE5Z4B2nzNQDjdIXnWaQ deal in deals)
		{
			AddPoint(deal.i2b2G2QycaF, deal.Symbol);
		}
	}

	public void ClearPoints()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				_chartPoints.Clear();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_chartPoints.Add(new CiyPMi2BMhk9879qqk2F());
				_updated = true;
				return;
			}
		}
	}

	private void OnTimerTick()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				_updated = false;
				_maxPoint = 0.0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (!_updated)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_minPoint = 0.0;
				foreach (CiyPMi2BMhk9879qqk2F chartPoint in _chartPoints)
				{
					int num3 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							_maxPoint = Math.Max(_maxPoint, bxHjOX4OmoFht9kFEZFZ(chartPoint.GrossPnl, Math.Max(CYQYO64OWIaE57lQJeEg(chartPoint), chartPoint.Comission)));
							num3 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					_minPoint = bX0fG14OwVi1l9XOerxW(_minPoint, Math.Min(S1OyYX4OhNGrd3jRTjeI(chartPoint), Math.Min(chartPoint.NetPnl, chartPoint.Comission)));
				}
				c5Ik4V4O7dP1yyGCZhBa(HwndHost, false);
				return;
			}
		}
	}

	private void OnRender(bool full)
	{
		try
		{
			Reo1wt4O8VRYuhJnOypw(visualQueue, HwndHost.ClientRect);
			DrawChart(visualQueue);
			WJbac14OA8SLCErrYuHV(HwndHost, visualQueue, null);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		catch (Exception ex)
		{
			GrWOjo4OPn5WBGe9RlxA(ex);
		}
	}

	private void DrawChart(DxVisualQueue visual)
	{
		int num = 5;
		List<Tuple<string, Rect>> list = default(List<Tuple<string, Rect>>);
		Rect rect = default(Rect);
		bool flag2 = default(bool);
		bool flag = default(bool);
		XFont xFont = default(XFont);
		dedPnv2vpONa7N0cev25 dedPnv2vpONa7N0cev = default(dedPnv2vpONa7N0cev25);
		int num15 = default(int);
		int num7 = default(int);
		string text = default(string);
		Rect item = default(Rect);
		double num5 = default(double);
		double num6 = default(double);
		double num13 = default(double);
		LS5nLy2vmpKwDigwOIvd lS5nLy2vmpKwDigwOIvd = default(LS5nLy2vmpKwDigwOIvd);
		int num18 = default(int);
		double num4 = default(double);
		double num16 = default(double);
		Point[] array3 = default(Point[]);
		Point[] array4 = default(Point[]);
		int count = default(int);
		double width = default(double);
		double num10 = default(double);
		string text2 = default(string);
		XPen xPen = default(XPen);
		double height2 = default(double);
		int num17 = default(int);
		Point[] array = default(Point[]);
		double num11 = default(double);
		double num12 = default(double);
		int num19 = default(int);
		int num3 = default(int);
		Point[] array2 = default(Point[]);
		double num9 = default(double);
		double height = default(double);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 41:
				{
					foreach (Tuple<string, Rect> item3 in list)
					{
						Rect item2 = item3.Item2;
						int num14 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 != 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							case 3:
								break;
							case 2:
								item2.X -= rect.Width;
								num14 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
								{
									num14 = 0;
								}
								continue;
							default:
								if (flag2)
								{
									item2.Y -= rect.Height;
									num14 = 3;
									continue;
								}
								break;
							case 1:
								if (flag)
								{
									num14 = 2;
									if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 == 0)
									{
										num14 = 0;
									}
									continue;
								}
								goto default;
							}
							break;
						}
						visual.DrawString(item3.Item1, xFont, dedPnv2vpONa7N0cev.NoJ2BHWqv1U(), item2, XTextAlignment.Center);
					}
					return;
				}
				case 47:
					goto IL_0114;
				case 42:
					num15 += 25;
					num2 = 26;
					continue;
				case 23:
					num15 = 10;
					num2 = 14;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num2 = 11;
					}
					continue;
				case 25:
					num7++;
					goto IL_05d1;
				case 11:
				case 16:
				case 33:
				{
					Size size = xFont.GetSize(text);
					item = new Rect(new Point(num5 + 4.0, (double)_mouseY + num6), new Point(num5 + 8.0 + (double)(int)size.Width, (double)_mouseY + num6 + size.Height + 6.0));
					num2 = 37;
					continue;
				}
				case 43:
					num13 = Math.Max(xFont.GetWidth(y8n8Pg4q09Gxl3a37UOd(lS5nLy2vmpKwDigwOIvd).ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3E0426F0 ^ 0x3E04091C) + num18)), gVCgKi4q2YEwHnlogs1U(xFont, lS5nLy2vmpKwDigwOIvd.Max.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2074141628 ^ -2074135640) + num18))) + 15.0;
					num4 = Math.Max(1.0, base.ActualWidth - num13 - 20.0) / (double)OIrNB14qH2I4NmoCNuOD(_chartPoints.Count - 1, 1);
					num = 9;
					break;
				case 18:
					if (_maxPoint == 0.0)
					{
						return;
					}
					goto IL_0346;
				case 37:
					list.Add(new Tuple<string, Rect>(text, item));
					num6 += item.Height;
					num16 = bxHjOX4OmoFht9kFEZFZ(num16, item.Width + 8.0);
					num2 = 19;
					continue;
				case 35:
					visual.DrawLines(dedPnv2vpONa7N0cev.R5Z2BNxapPK(), array3);
					num2 = 34;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
					{
						num2 = 27;
					}
					continue;
				case 5:
					if (j18iDj9nukSCmEyZs5lH.Settings.AppTheme == AppTheme.MetroDark)
					{
						num2 = 4;
						continue;
					}
					obj = T0ldEI4OFR3fLEsyOuKx();
					goto IL_1142;
				case 15:
					flag = false;
					flag2 = false;
					if (rect.Right > GFYsc64qfqvsyJ323YU8(this) - 5.0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_07a1;
				case 24:
					visual.FillRectangle(dedPnv2vpONa7N0cev.adG2vzWR4h2(), new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight));
					if (_chartPoints.Count == 0)
					{
						return;
					}
					if (_minPoint == 0.0)
					{
						num2 = 18;
						continue;
					}
					goto IL_0346;
				case 3:
					array4 = new Point[count];
					array3 = new Point[count];
					num2 = 48;
					continue;
				case 45:
					num15 += 10 + (int)width;
					num = 25;
					break;
				case 38:
					nv5Dtq4qnrKQylZ9y8tv(visual, dedPnv2vpONa7N0cev.YUx2BoEeZgT(), new Point(0.0, (int)num10), new Point(base.ActualWidth - num13, (int)num10));
					num2 = 31;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
					{
						num2 = 30;
					}
					continue;
				case 46:
					goto IL_0658;
				case 21:
					flag = true;
					goto IL_07a1;
				case 10:
				case 17:
				case 27:
					if (!poSeBS4qasrkvk7yKTiG(text2) && xPen != null)
					{
						width = xFont.GetWidth(text2);
						visual.DrawLine(xPen, new Point(num15, 5.0 + height2 / 2.0), new Point(num15 + 20, 5.0 + height2 / 2.0));
						num2 = 42;
						continue;
					}
					goto case 25;
				case 2:
					visual.DrawLine(dedPnv2vpONa7N0cev.fIP2BnZbFLX(), new Point(base.ActualWidth - num13, 0.0), new Point(base.ActualWidth - num13, base.ActualHeight));
					count = _chartPoints.Count;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (num17 >= count)
					{
						visual.DrawLines((XPen)c1ok2n4qoXNPxCYHJ3L6(dedPnv2vpONa7N0cev), array4);
						num2 = 35;
						continue;
					}
					array[num17] = new Point(10.0 + num4 * (double)num17, num11 - num12 * (_chartPoints[num17].Points - _minPoint) + 30.0);
					array4[num17] = new Point(10.0 + num4 * (double)num17, num11 - num12 * (S1OyYX4OhNGrd3jRTjeI(_chartPoints[num17]) - _minPoint) + 30.0);
					num = 12;
					break;
				case 36:
					xPen = (XPen)xKRgA74qBVcjEmlvpnbL(dedPnv2vpONa7N0cev);
					goto case 10;
				case 4:
					obj = qKnvdn4OJXwGKvGeBtMw();
					goto IL_1142;
				case 39:
					lS5nLy2vmpKwDigwOIvd = new LS5nLy2vmpKwDigwOIvd(_minPoint, _maxPoint, num19);
					num18 = (int)Math.Max(0.0 - pMg5pE4O3yEuQm1yKblU(Math.Log10(lS5nLy2vmpKwDigwOIvd.q6B2vAKb6ES())), 0.0);
					xFont = new XFont((string)g3ZPdn4OuFdymquIA7Xg(Fsjm8p4OpDrXPdHU6VyC()), zgjgQE4OzflxZGKeQ5RN(j18iDj9nukSCmEyZs5lH.Settings));
					num2 = 30;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
					{
						num2 = 43;
					}
					continue;
				case 9:
					num12 = num11 / (_maxPoint - _minPoint);
					if (num19 > 1)
					{
						num2 = 44;
						continue;
					}
					goto case 2;
				case 40:
					goto IL_09b9;
				case 22:
					num19 = (int)(num11 / 40.0) + 1;
					num = 39;
					break;
				case 6:
					if (num3 >= count)
					{
						return;
					}
					num5 = 10.0 + num4 * (double)num3;
					nv5Dtq4qnrKQylZ9y8tv(visual, sCFhm14ql6w8bmMxC2YI(dedPnv2vpONa7N0cev), new Point(num5, 0.0), new Point(num5, oMPySk4q4NFDywyW3X9h(this)));
					list = new List<Tuple<string, Rect>>();
					num2 = 32;
					continue;
				case 12:
					array3[num17] = new Point(10.0 + num4 * (double)num17, num11 - num12 * (_chartPoints[num17].NetPnl - _minPoint) + 30.0);
					array2[num17] = new Point(10.0 + num4 * (double)num17, num11 - num12 * (P7f8sN4qYY4nSvepE6mb(_chartPoints[num17]) - _minPoint) + 30.0);
					num17++;
					num = 7;
					break;
				case 14:
					num7 = 1;
					goto IL_05d1;
				case 8:
					visual.DrawString(num9.ToString((string)TG7HJl4q916k4848auTJ(0x741B85CB ^ 0x741BAA27) + num18), xFont, dedPnv2vpONa7N0cev.NoJ2BHWqv1U(), new Rect(new Point(base.ActualWidth - num13 + 10.0, num10 - height / 2.0 - 1.0), new Point(GFYsc64qfqvsyJ323YU8(this) - 5.0, num10 + height / 2.0)));
					num2 = 38;
					continue;
				case 28:
					goto IL_0c4a;
				case 51:
					goto IL_0cde;
				case 32:
					num6 = 0.0;
					num16 = 0.0;
					num8 = 0;
					num = 49;
					break;
				case 19:
					num8++;
					num2 = 29;
					continue;
				case 1:
					rect.X -= rect.Width;
					num = 21;
					break;
				case 31:
					num9 += lS5nLy2vmpKwDigwOIvd.q6B2vAKb6ES();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
					{
						num2 = 30;
					}
					continue;
				case 48:
					array2 = new Point[count];
					num17 = 0;
					goto case 7;
				case 20:
					goto IL_0e76;
				case 34:
					visual.DrawLines(dedPnv2vpONa7N0cev.xBf2B574Blq(), array2);
					height2 = xFont.GetHeight();
					num2 = 23;
					continue;
				case 13:
					rect = new Rect(new Point(num5, (double)_mouseY + num6), new Point(num5 + num16, _mouseY));
					num2 = 15;
					continue;
				case 26:
					visual.DrawString(text2, xFont, (XBrush)nCOGqk4qiq4WKQCUm15G(dedPnv2vpONa7N0cev), num15, 5.0);
					num2 = 45;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
					{
						num2 = 38;
					}
					continue;
				case 44:
					num9 = y8n8Pg4q09Gxl3a37UOd(lS5nLy2vmpKwDigwOIvd);
					goto case 30;
				case 29:
				case 49:
					if (num8 < 7)
					{
						text = "";
						switch (num8)
						{
						case 2:
							goto IL_0658;
						case 4:
							goto IL_07c3;
						case 5:
							goto IL_09b9;
						case 3:
							goto IL_0c4a;
						case 6:
							goto IL_0e76;
						case 0:
							text = (string)SYsYqN4qDyjt2VrXcXeS(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1306877528 ^ -1306904514), num3);
							break;
						case 1:
							goto IL_1090;
						}
						goto case 11;
					}
					num2 = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
					{
						num2 = 3;
					}
					continue;
				case 52:
					goto IL_1090;
				default:
					array = new Point[count];
					num2 = 3;
					continue;
				case 30:
					if (num9 <= YLwSp04qGNV16NZFH35R(lS5nLy2vmpKwDigwOIvd))
					{
						num10 = num11 - num12 * (num9 - _minPoint) + 30.0;
						height = xFont.GetHeight();
						visual.DrawLine(dedPnv2vpONa7N0cev.fIP2BnZbFLX(), new Point(base.ActualWidth - num13, (int)num10), new Point(GFYsc64qfqvsyJ323YU8(this) - num13 + 5.0, (int)num10));
						num2 = 8;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
						{
							num2 = 2;
						}
					}
					continue;
				case 50:
					{
						if (_mouseX > 0)
						{
							num3 = (int)((double)(_mouseX - 10) / num4) + 1;
							if (num3 > 0)
							{
								num2 = 6;
								continue;
							}
						}
						return;
					}
					IL_046b:
					text2 = TigerTrade.Properties.Resources.EquityChartComission;
					num2 = 35;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
					{
						num2 = 36;
					}
					continue;
					IL_05d1:
					if (num7 >= 4)
					{
						num2 = 50;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 != 0)
						{
							num2 = 46;
						}
						continue;
					}
					text2 = null;
					xPen = null;
					switch (num7)
					{
					case 1:
						break;
					case 0:
						goto IL_0114;
					case 3:
						goto IL_046b;
					case 2:
						goto IL_0cde;
					default:
						goto IL_0fca;
					}
					text2 = TigerTrade.Properties.Resources.EquityChartGrossPnL;
					xPen = dedPnv2vpONa7N0cev.k012B4bKtQI();
					num2 = 10;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 6;
					}
					continue;
					IL_1090:
					text = string.Format(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225795185), TigerTrade.Properties.Resources.EquityChartDate, ucXhss4qb0753vlr4tqZ(_chartPoints[num3]));
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num2 = 11;
					}
					continue;
					IL_07a1:
					if (rect.Top > rect.Height + 5.0)
					{
						rect.Y -= rect.Height;
						flag2 = true;
					}
					TCHACm4qxCABs6BdjD9H(visual, dedPnv2vpONa7N0cev.adG2vzWR4h2(), rect);
					visual.DrawRectangle((XPen)sCFhm14ql6w8bmMxC2YI(dedPnv2vpONa7N0cev), rect);
					num = 41;
					break;
					IL_07c3:
					text = TigerTrade.Properties.Resources.EquityChartGrossPnL + (string)TG7HJl4q916k4848auTJ(0x315AB1E3 ^ 0x315A2831) + _chartPoints[num3].GrossPnl.ToString((string)TG7HJl4q916k4848auTJ(0x12620268 ^ 0x12622D84) + _chartPoints[num3].DYZ2B7i8E54());
					num2 = 16;
					continue;
					IL_0fca:
					num2 = 27;
					continue;
					IL_0cde:
					text2 = TigerTrade.Properties.Resources.EquityChartNetPnL;
					xPen = dedPnv2vpONa7N0cev.R5Z2BNxapPK();
					goto case 10;
					IL_0e76:
					text = (string)F8Mv2n4q5ZLObZPXD3yY(bA5orH4qS9WhLgaJc5lk(), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44514213), _chartPoints[num3].Comission.ToString((string)xjpMH34q17e0vn4SqrRY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-839659358 ^ -839647410), _chartPoints[num3].DYZ2B7i8E54().ToString())));
					goto case 11;
					IL_1142:
					dedPnv2vpONa7N0cev = (dedPnv2vpONa7N0cev25)obj;
					num2 = 23;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b != 0)
					{
						num2 = 24;
					}
					continue;
					IL_0c4a:
					text = (string)ViDYmg4qvSkCpJfpsb9H() + stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962490335) + _chartPoints[num3].Points.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741BAA27) + TJDh134qkCbP60kwUqHD(_chartPoints[num3]));
					num2 = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num2 = 33;
					}
					continue;
					IL_09b9:
					text = (string)F8Mv2n4q5ZLObZPXD3yY(TigerTrade.Properties.Resources.EquityChartNetPnL, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-90307782 ^ -90268952), _chartPoints[num3].NetPnl.ToString((string)xjpMH34q17e0vn4SqrRY(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x32DEA4F1 ^ 0x32DE8B1D), _chartPoints[num3].DYZ2B7i8E54().ToString())));
					goto case 11;
					IL_0346:
					num11 = Math.Max(1.0, base.ActualHeight - 60.0);
					num2 = 12;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
					{
						num2 = 22;
					}
					continue;
					IL_0114:
					text2 = (string)ViDYmg4qvSkCpJfpsb9H();
					xPen = dedPnv2vpONa7N0cev.hLd2BaLsegM();
					num2 = 17;
					continue;
					IL_0658:
					text = (string)VWM2Qp4qNaA5Gc4oBhXT(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4662F6AF ^ 0x46626F15), TigerTrade.Properties.Resources.EquityChartTime, ucXhss4qb0753vlr4tqZ(_chartPoints[num3]));
					goto case 11;
				}
				break;
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		base.OnMouseMove(e);
		Point point = fKEEIw4qLvsaUGd1VHPF(e, this);
		_mouseX = (int)point.X;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			_mouseY = (int)point.Y;
			HwndHost.InvalidateVisual();
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void OnMouseLeave(MouseEventArgs e)
	{
		base.OnMouseLeave(e);
		_mouseX = 0;
		_mouseY = 0;
		c5Ik4V4O7dP1yyGCZhBa(HwndHost, false);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void Dispose()
	{
		HwndHost.OnTimerTick -= OnTimerTick;
		HwndHost.OnRenderVisual -= OnRender;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		HwndHost.Dispose();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (_contentLoaded)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
					{
						num2 = 0;
					}
					break;
				}
				_contentLoaded = true;
				Uri uri = new Uri((string)TG7HJl4q916k4848auTJ(-991861155 ^ -991821945), UriKind.Relative);
				EiJrCu4qeagrqhgpdNen(this, uri);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		if (connectionId != 1)
		{
			_contentLoaded = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			HwndHost = (DxHwndHost)target;
		}
	}

	static EquityChart()
	{
		SPrIUQ4qsoNTpqNItBY4();
	}

	internal static void timxMk4ORhRrR7rvKmol()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void vs1rsY4O65x9dM1PvC3p(object P_0, int P_1)
	{
		((DxHwndHost)P_0).StartTimer(P_1);
	}

	internal static bool tiRwZC4Od5jU8QYlafWL()
	{
		return P8DK3M4OQpbJFwhP9KHf == null;
	}

	internal static EquityChart dV3EN64Ogt6XxDR70okp()
	{
		return P8DK3M4OQpbJFwhP9KHf;
	}

	internal static DateTime M1SVWX4OMyeDIw4VNRpE(object P_0, DateTime P_1)
	{
		return ((Symbol)P_0).ConvertTimeToLocal(P_1);
	}

	internal static void IaM5pu4OOfs5tnkEG3o1(object P_0, DateTime P_1)
	{
		((CiyPMi2BMhk9879qqk2F)P_0).Time = P_1;
	}

	internal static double c2ctrj4OqdH271KIVtbv(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).Points;
	}

	internal static double sdPpCP4OISgaelGGkuiV(object P_0)
	{
		return ((UserDeal)P_0).Points;
	}

	internal static double CYQYO64OWIaE57lQJeEg(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).NetPnl;
	}

	internal static double SBVLWx4Otuaw7RLhrEKw(object P_0)
	{
		return ((UserDeal)P_0).Profit;
	}

	internal static int BDOSQ44OUldZXCZC1Ibi(object P_0)
	{
		return ((Symbol)P_0).PnlPrecision;
	}

	internal static void MJKQs54OTMUyBKVjNxmw(object P_0, double P_1)
	{
		((CiyPMi2BMhk9879qqk2F)P_0).Comission = P_1;
	}

	internal static int kXMG3E4OyTfTDZ6qMf57(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}

	internal static void rOnpVj4OZEZ9PZiLQXj9(object P_0, int P_1)
	{
		((CiyPMi2BMhk9879qqk2F)P_0).qRx2B8Unvlc(P_1);
	}

	internal static void Cx5LIq4OVXBpEeqlZwrQ(object P_0, double P_1)
	{
		((CiyPMi2BMhk9879qqk2F)P_0).Points = P_1;
	}

	internal static double DM8BwI4OCKXayaqt33Ea(object P_0)
	{
		return ((UserDeal)P_0).Comission;
	}

	internal static double OomvFF4OriA8M0TPybT8(double P_0, int P_1)
	{
		return Math.Round(P_0, P_1);
	}

	internal static void tynjva4OKnvVtr6whDAb(object P_0, int P_1)
	{
		((CiyPMi2BMhk9879qqk2F)P_0).Ii42BhFod0R(P_1);
	}

	internal static double bxHjOX4OmoFht9kFEZFZ(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double S1OyYX4OhNGrd3jRTjeI(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).GrossPnl;
	}

	internal static double bX0fG14OwVi1l9XOerxW(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void c5Ik4V4O7dP1yyGCZhBa(object P_0, bool P_1)
	{
		((DxHwndHost)P_0).InvalidateVisual(P_1);
	}

	internal static void Reo1wt4O8VRYuhJnOypw(object P_0, Rect P_1)
	{
		((DxVisualQueue)P_0).Set(P_1);
	}

	internal static void WJbac14OA8SLCErrYuHV(object P_0, object P_1, object P_2)
	{
		((DxHwndHost)P_0).Render((DxVisualQueue)P_1, (DxVisualQueue)P_2);
	}

	internal static void GrWOjo4OPn5WBGe9RlxA(object P_0)
	{
		LogManager.WriteError((Exception)P_0);
	}

	internal static object qKnvdn4OJXwGKvGeBtMw()
	{
		return dedPnv2vpONa7N0cev25.DarkTheme;
	}

	internal static object T0ldEI4OFR3fLEsyOuKx()
	{
		return dedPnv2vpONa7N0cev25.LightTheme;
	}

	internal static double pMg5pE4O3yEuQm1yKblU(double P_0)
	{
		return Math.Floor(P_0);
	}

	internal static object Fsjm8p4OpDrXPdHU6VyC()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object g3ZPdn4OuFdymquIA7Xg(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).FontName;
	}

	internal static int zgjgQE4OzflxZGKeQ5RN(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).FontSize;
	}

	internal static double y8n8Pg4q09Gxl3a37UOd(object P_0)
	{
		return ((LS5nLy2vmpKwDigwOIvd)P_0).Min;
	}

	internal static double gVCgKi4q2YEwHnlogs1U(object P_0, object P_1)
	{
		return ((XFont)P_0).GetWidth((string)P_1);
	}

	internal static int OIrNB14qH2I4NmoCNuOD(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double GFYsc64qfqvsyJ323YU8(object P_0)
	{
		return ((FrameworkElement)P_0).ActualWidth;
	}

	internal static object TG7HJl4q916k4848auTJ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void nv5Dtq4qnrKQylZ9y8tv(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static double YLwSp04qGNV16NZFH35R(object P_0)
	{
		return ((LS5nLy2vmpKwDigwOIvd)P_0).Max;
	}

	internal static double P7f8sN4qYY4nSvepE6mb(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).Comission;
	}

	internal static object c1ok2n4qoXNPxCYHJ3L6(object P_0)
	{
		return ((dedPnv2vpONa7N0cev25)P_0).k012B4bKtQI();
	}

	internal static object ViDYmg4qvSkCpJfpsb9H()
	{
		return TigerTrade.Properties.Resources.EquityChartPoints;
	}

	internal static object xKRgA74qBVcjEmlvpnbL(object P_0)
	{
		return ((dedPnv2vpONa7N0cev25)P_0).xBf2B574Blq();
	}

	internal static bool poSeBS4qasrkvk7yKTiG(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object nCOGqk4qiq4WKQCUm15G(object P_0)
	{
		return ((dedPnv2vpONa7N0cev25)P_0).NoJ2BHWqv1U();
	}

	internal static object sCFhm14ql6w8bmMxC2YI(object P_0)
	{
		return ((dedPnv2vpONa7N0cev25)P_0).fIP2BnZbFLX();
	}

	internal static double oMPySk4q4NFDywyW3X9h(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static object SYsYqN4qDyjt2VrXcXeS(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static DateTime ucXhss4qb0753vlr4tqZ(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).Time;
	}

	internal static object VWM2Qp4qNaA5Gc4oBhXT(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static int TJDh134qkCbP60kwUqHD(object P_0)
	{
		return ((CiyPMi2BMhk9879qqk2F)P_0).e0f2BmQh54D();
	}

	internal static object xjpMH34q17e0vn4SqrRY(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object F8Mv2n4q5ZLObZPXD3yY(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object bA5orH4qS9WhLgaJc5lk()
	{
		return TigerTrade.Properties.Resources.EquityChartComission;
	}

	internal static void TCHACm4qxCABs6BdjD9H(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static Point fKEEIw4qLvsaUGd1VHPF(object P_0, object P_1)
	{
		return ((MouseEventArgs)P_0).GetPosition((IInputElement)P_1);
	}

	internal static void EiJrCu4qeagrqhgpdNen(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void SPrIUQ4qsoNTpqNItBY4()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
