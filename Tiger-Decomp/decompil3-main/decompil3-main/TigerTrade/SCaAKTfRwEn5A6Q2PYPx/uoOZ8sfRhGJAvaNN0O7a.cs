using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using a77POVf3kMXUccGGIZHI;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using aRmyWPfwcr2UVcDGLIsf;
using bl7Or1fDrLHNeTtGhT82;
using c71M56fFrIRknXFy5cnV;
using Cok5gZfeOOYNUntqe0FS;
using ECOEgqlSad8NUJZ2Dr9n;
using EiV63dfMd1Jg25hKFUrs;
using LaJLKJf6QgxXtecRtEuE;
using LkgWJcfsLbF5GV6NcGQ4;
using m5KHHSfSCCCvZdkMl316;
using nDRVH5fO2N3bDxUGOOrY;
using NsWD4W9miMxRbFU3fsu9;
using nThyYY91yCRdCCPfZC5P;
using q6Lcl3fBRQ8ycXy3QOHi;
using sRAUFLf7jllYKTONukDI;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TigerTrade.Market.Settings;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using u42gcKfgzsMRGivVmHf8;
using USRHnUfw24BLQEfEWDPm;
using Wf1kTvnGy6XhfTKJgfkM;
using XUi8EWf1E6l7gdu7kUS9;

namespace SCaAKTfRwEn5A6Q2PYPx;

internal sealed class uoOZ8sfRhGJAvaNN0O7a : faw8pRfgu9tAi5EEEjfU
{
	private readonly List<Axw0YTf3N4379fghDfMt> n0ofRJXcYug;

	private readonly List<Point> J1yfRFMH3R6;

	[CompilerGenerated]
	private readonly smTKLVfeMIY6X8kUtDCi JhbfR3rq6VZ;

	[CompilerGenerated]
	private readonly wFFFvWfsxErbxn4XFmrR wvKfRptpGNC;

	internal static uoOZ8sfRhGJAvaNN0O7a KZ620fbGLuphqWi1xpO3;

	public wFFFvWfsxErbxn4XFmrR MarketView
	{
		[CompilerGenerated]
		get
		{
			return wvKfRptpGNC;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public smTKLVfeMIY6X8kUtDCi bnBfR8naMTX()
	{
		return JhbfR3rq6VZ;
	}

	public uoOZ8sfRhGJAvaNN0O7a(wFFFvWfsxErbxn4XFmrR P_0, smTKLVfeMIY6X8kUtDCi P_1)
	{
		lhjv4gbGXNMrW8PNbLkX();
		n0ofRJXcYug = new List<Axw0YTf3N4379fghDfMt>();
		J1yfRFMH3R6 = new List<Point>();
		base._002Ector();
		wvKfRptpGNC = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 == 0)
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
			JhbfR3rq6VZ = P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
			{
				num = 1;
			}
		}
	}

	public bool CheckUpdate()
	{
		if (uGUclWbGcmLY6xtNyhJ1(MarketView.Settings) || X0gDX1bGjwUeGBUA615g(MarketView.VisualSettings))
		{
			return MarketView.Market.HuZf1Cg8WFp().x4df3laBDHb();
		}
		return false;
	}

	public double iYwfR7c9dGi(double P_0)
	{
		if (OmSmT1bGETNWP1igbA7a(P_0) >= 1000000000.0)
		{
			return 4.0;
		}
		if (Math.Abs(P_0) >= 10000000.0)
		{
			return 3.0;
		}
		int num;
		if (!(Math.Abs(P_0) >= 1000000.0))
		{
			if (Math.Abs(P_0) >= 10000.0)
			{
				return 1.0;
			}
			OmSmT1bGETNWP1igbA7a(P_0);
			_ = 1000.0;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
			{
				num = 1;
			}
		}
		return num switch
		{
			1 => 2.0, 
			_ => 0.0, 
		};
	}

	public void Khal96VceVj(DxVisualQueue P_0)
	{
		int num = 1;
		int num2 = num;
		Rect clip = default(Rect);
		XrTs9ufSVt0hx8rJDd6l xrTs9ufSVt0hx8rJDd6l = default(XrTs9ufSVt0hx8rJDd6l);
		ijsjhhnGTadfwpOyDdrx ijsjhhnGTadfwpOyDdrx = default(ijsjhhnGTadfwpOyDdrx);
		List<Sl9ykSfFCMU49HP0CuHU> list = default(List<Sl9ykSfFCMU49HP0CuHU>);
		Axw0YTf3N4379fghDfMt axw0YTf3N4379fghDfMt2 = default(Axw0YTf3N4379fghDfMt);
		XBrush xBrush = default(XBrush);
		Point point = default(Point);
		double num16 = default(double);
		XPen pen = default(XPen);
		int num8 = default(int);
		double num27 = default(double);
		bool flag5 = default(bool);
		long num24 = default(long);
		bool flag4 = default(bool);
		int num9 = default(int);
		kySlNFfMQBimj7edN21j kySlNFfMQBimj7edN21j = default(kySlNFfMQBimj7edN21j);
		int num15 = default(int);
		Sl9ykSfFCMU49HP0CuHU sl9ykSfFCMU49HP0CuHU = default(Sl9ykSfFCMU49HP0CuHU);
		int num18 = default(int);
		bool flag3 = default(bool);
		int num19 = default(int);
		long num22 = default(long);
		long num23 = default(long);
		List<S0uWdcfwXXaHuYPfnsUO> list2 = default(List<S0uWdcfwXXaHuYPfnsUO>);
		bool flag2 = default(bool);
		bool flag = default(bool);
		XFont xFont = default(XFont);
		int num14 = default(int);
		double num11 = default(double);
		double num12 = default(double);
		double num13 = default(double);
		double num5 = default(double);
		List<kySlNFfMQBimj7edN21j> list3 = default(List<kySlNFfMQBimj7edN21j>);
		double num6 = default(double);
		long num10 = default(long);
		double num25 = default(double);
		Axw0YTf3N4379fghDfMt axw0YTf3N4379fghDfMt = default(Axw0YTf3N4379fghDfMt);
		long num20 = default(long);
		double num7 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				clip = new Rect(bnBfR8naMTX().X, bnBfR8naMTX().Y, bnBfR8naMTX().Width, mUwWDobGQE2mLWEHYwua(bnBfR8naMTX()));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			P_0.SetClip(clip);
			try
			{
				int num3;
				if (!uGUclWbGcmLY6xtNyhJ1(MarketView.Settings))
				{
					num3 = 2;
					goto IL_0049;
				}
				goto IL_0e51;
				IL_0e51:
				xrTs9ufSVt0hx8rJDd6l = (XrTs9ufSVt0hx8rJDd6l)RTohwObGdJK1LlyXVfVq(MarketView);
				ijsjhhnGTadfwpOyDdrx = MarketView.Symbol;
				list = xrTs9ufSVt0hx8rJDd6l.HuZf1Cg8WFp().Vvyf3iGvqcN();
				if (ohTrvFbGgrrdjsmBS4nK(list) <= 0)
				{
					return;
				}
				if (list.Count < n0ofRJXcYug.Count)
				{
					num3 = 46;
					goto IL_0049;
				}
				goto IL_0382;
				IL_0049:
				while (true)
				{
					int num26;
					long num17;
					switch (num3)
					{
					case 40:
					{
						double num21 = axw0YTf3N4379fghDfMt2.Rect.Height / 2.0;
						KkHc7AbY2F9ATSLVxeYR(P_0, xBrush, point, num16, num21);
						P_0.DrawEllipse(pen, point, num16, num21);
						num3 = 49;
						continue;
					}
					case 35:
						if (Bb5PiNbY0nT7birWvcEs(fgaQdCbG6YRjXfkRihF4()) == FOWNtn91Tu8fC29CNc7t.Ellipse)
						{
							point = new Point(axw0YTf3N4379fghDfMt2.Rect.Left + axw0YTf3N4379fghDfMt2.Rect.Width / 2.0, axw0YTf3N4379fghDfMt2.Rect.Top + axw0YTf3N4379fghDfMt2.Rect.Height / 2.0);
							num16 = axw0YTf3N4379fghDfMt2.Rect.Width / 2.0;
							num3 = 40;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 != 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 11;
					case 9:
						num8--;
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 == 0)
						{
							num3 = 62;
						}
						continue;
					case 4:
						num27 = (flag5 ? (num6 - 1.0) : 2.0);
						num3 = 48;
						continue;
					case 56:
						num24 = ijsjhhnGTadfwpOyDdrx.gN7nY27Lkwh(MarketView.VisualSettings.GraphTradesHideFilter, flag4);
						num9 = MarketView.VisualSettings.GraphRoundValues;
						num3 = 14;
						continue;
					case 55:
						xBrush = (XBrush)eiYbAZbGpvICsT8c2EFt(MarketView.Theme);
						pen = MarketView.Theme.a3DfWT7QR5v;
						goto case 25;
					case 19:
						axw0YTf3N4379fghDfMt.byOf3QA47De(num6);
						num3 = 18;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
						{
							num3 = 12;
						}
						continue;
					case 61:
						if (axw0YTf3N4379fghDfMt2.Side == Side.Buy)
						{
							xBrush = kySlNFfMQBimj7edN21j.wN2fMO7TLXF;
							pen = kySlNFfMQBimj7edN21j.lgXfMUssAnw;
							num3 = 25;
							continue;
						}
						goto case 47;
					default:
						axw0YTf3N4379fghDfMt.WDbf3qpkRR1(num15);
						if (iG1BvdbGhRaH1Hsn90ct(sl9ykSfFCMU49HP0CuHU) > 0)
						{
							num3 = 16;
							continue;
						}
						goto case 37;
					case 12:
						if (num18 >= list.Count)
						{
							if (X0gDX1bGjwUeGBUA615g(kUFLOObGWd1dhQwkmerp(MarketView)))
							{
								num3 = 58;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44d9df62f7524f8eb2abdc23baf0c87b != 0)
								{
									num3 = 33;
								}
								continue;
							}
							goto IL_0465;
						}
						goto case 45;
					case 7:
						zm3EFWbGKgXQMA0ragUZ(axw0YTf3N4379fghDfMt, flag3);
						num3 = 19;
						continue;
					case 41:
						num19--;
						goto case 6;
					case 51:
						if (n0ofRJXcYug.Count > num18)
						{
							num3 = 29;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 21;
					case 37:
						if (!((MarketSettings)jUCYQcbGM0cV58TewsNX(MarketView)).VisualSettings.GraphCompactMode)
						{
							num3 = 54;
							continue;
						}
						goto case 3;
					case 44:
						break;
					case 22:
						flag5 = num22 >= num23;
						num3 = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num3 = 36;
						}
						continue;
					case 29:
						n0ofRJXcYug[num18].Visible = false;
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 != 0)
						{
							num3 = 21;
						}
						continue;
					case 1:
						flag3 = true;
						goto IL_0b95;
					case 39:
						num15 = -1;
						num19 = list2.Count - 1;
						num3 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
						{
							num3 = 6;
						}
						continue;
					case 33:
						P_0.FillEllipse(xBrush, axw0YTf3N4379fghDfMt2.Center, axw0YTf3N4379fghDfMt2.vZ0f3ES07kk(), axw0YTf3N4379fghDfMt2.vZ0f3ES07kk());
						P_0.DrawEllipse(pen, axw0YTf3N4379fghDfMt2.Center, axw0YTf3N4379fghDfMt2.vZ0f3ES07kk(), axw0YTf3N4379fghDfMt2.vZ0f3ES07kk());
						goto case 49;
					case 47:
						xBrush = (XBrush)GwtgRJbGFFNH18YKq5km(kySlNFfMQBimj7edN21j);
						num3 = 13;
						continue;
					case 14:
						flag2 = ((SH4fZjfBgpnJAYxtUbu4)kUFLOObGWd1dhQwkmerp(MarketView)).GraphMinimizeValues;
						num3 = 10;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
						{
							num3 = 1;
						}
						continue;
					case 49:
						if (eJfqUwbYf0g1WpCN5Pf1(axw0YTf3N4379fghDfMt2))
						{
							P_0.DrawString(flag ? ijsjhhnGTadfwpOyDdrx.FormatRawSize(axw0YTf3N4379fghDfMt2.Size, num9, flag2) : ijsjhhnGTadfwpOyDdrx.FormatRawQuoteSize(axw0YTf3N4379fghDfMt2.Size, num9, flag2), xFont, MarketView.Theme.cYJfOxYsuth, axw0YTf3N4379fghDfMt2.Rect, XTextAlignment.Center);
							num3 = 9;
							continue;
						}
						goto case 9;
					case 26:
						num14 = axw0YTf3N4379fghDfMt2.zZyf3OPF0MQ();
						if (num14 >= 0)
						{
							num3 = 42;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 != 0)
							{
								num3 = 35;
							}
							continue;
						}
						goto IL_09db;
					case 10:
						num11 = xrTs9ufSVt0hx8rJDd6l.AKnfxPJ5PuD();
						num12 = Iry2aLbGtlRtC9j94fPX(xrTs9ufSVt0hx8rJDd6l) / 2.0;
						num13 = (double)MarketView.VisualSettings.GraphTicksLineWidth / 2.0;
						num3 = 53;
						continue;
					case 62:
						if (num8 < 0)
						{
							return;
						}
						goto case 59;
					case 31:
						num22 = (flag4 ? oD0htObGZTmcqMeJkDtw(sl9ykSfFCMU49HP0CuHU) : sl9ykSfFCMU49HP0CuHU.QuoteSize);
						num3 = 22;
						continue;
					case 32:
						if (flag5)
						{
							num3 = 52;
							continue;
						}
						goto IL_0b95;
					case 54:
						num5 -= num27 + num13;
						num3 = 3;
						continue;
					case 53:
						num18 = 0;
						num26 = 12;
						goto IL_0045;
					case 20:
						num17 = msbgWibGTH6RDsinTBVn(sl9ykSfFCMU49HP0CuHU) / myptwSbGy3cTAnb9vscv(((cXwoI5f1jl9EMXW8XL7D)RTohwObGdJK1LlyXVfVq(MarketView)).DataProvider);
						goto IL_0f86;
					case 17:
						list3 = MarketView.Theme.GraphSizeFiltersColors;
						num3 = 38;
						continue;
					case 13:
						pen = (XPen)zYytjKbG3nX5d4uyAN5H(kySlNFfMQBimj7edN21j);
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num3 = 27;
						}
						continue;
					case 11:
					{
						P_0.FillRectangle(xBrush, axw0YTf3N4379fghDfMt2.Rect);
						Rect rect = new Rect(axw0YTf3N4379fghDfMt2.Rect.X, L38PSRbYH1iiCn8iYBoC(axw0YTf3N4379fghDfMt2).Y, axw0YTf3N4379fghDfMt2.Rect.Width - 1.0, axw0YTf3N4379fghDfMt2.Rect.Height - 1.0);
						P_0.DrawRectangle(pen, rect);
						goto case 49;
					}
					case 59:
						axw0YTf3N4379fghDfMt2 = n0ofRJXcYug[num8];
						if (axw0YTf3N4379fghDfMt2.Visible)
						{
							num3 = 26;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 9;
					case 50:
						J1yfRFMH3R6.RemoveRange(num18, bA2JEVbGUEJVKemdtkrt(J1yfRFMH3R6) - num18);
						num3 = 57;
						continue;
					case 45:
						sl9ykSfFCMU49HP0CuHU = list[num18];
						num3 = 23;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 == 0)
						{
							num3 = 23;
						}
						continue;
					case 15:
						num6 += 2.0;
						num6 += iYwfR7c9dGi(num10);
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
						{
							num3 = 1;
						}
						continue;
					case 30:
						flag4 = MarketView.Settings.VisualSettings.GraphTradesParamsType == iiqB6if7c4rlwZXmgdxd.x4Lf7ER4uAX;
						flag = ((CR1isWfDCD1A4fwfUJUf)p3KNImbGOE0joJmc44hJ(jUCYQcbGM0cV58TewsNX(MarketView))).MarketDepthViewType == bRGA9Ifw05O8oh1kygRX.PMVfwH2OsOJ;
						num23 = shP9RkbGI7W0GPFearXc(ijsjhhnGTadfwpOyDdrx, JZYSJUbGqHZoq4jroXvH(MarketView.VisualSettings), flag4);
						num3 = 9;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
						{
							num3 = 56;
						}
						continue;
					case 24:
						J1yfRFMH3R6[num18] = new Point(num5, num25);
						if (TcQ68KbGCSeFfmWO9l4N(n0ofRJXcYug) == num18)
						{
							axw0YTf3N4379fghDfMt = new Axw0YTf3N4379fghDfMt();
							n0ofRJXcYug.Add(axw0YTf3N4379fghDfMt);
						}
						axw0YTf3N4379fghDfMt = n0ofRJXcYug[num18];
						ornTfibGrwMHBHZwWFlR(axw0YTf3N4379fghDfMt, num10);
						axw0YTf3N4379fghDfMt.Side = sl9ykSfFCMU49HP0CuHU.Side;
						num26 = 7;
						goto IL_0045;
					case 34:
						num25 = xrTs9ufSVt0hx8rJDd6l.O4qfSpNNA8v(sl9ykSfFCMU49HP0CuHU.Price) + num12;
						if (bA2JEVbGUEJVKemdtkrt(J1yfRFMH3R6) == num18)
						{
							J1yfRFMH3R6.Add(default(Point));
							num3 = 24;
							continue;
						}
						goto case 24;
					case 21:
						if (bA2JEVbGUEJVKemdtkrt(J1yfRFMH3R6) > num18)
						{
							num3 = 50;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
							{
								num3 = 34;
							}
							continue;
						}
						goto case 3;
					case 28:
						axw0YTf3N4379fghDfMt.Rect = new Rect(num5 - num6, num25 - num6, num6 * 2.0, num6 * 2.0);
						num3 = 3;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
						{
							num3 = 43;
						}
						continue;
					case 38:
						num8 = n0ofRJXcYug.Count - 1;
						goto case 62;
					case 3:
					case 57:
						num18++;
						goto case 12;
					case 48:
						num5 -= num27;
						num3 = 2;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 == 0)
						{
							num3 = 34;
						}
						continue;
					case 43:
						axw0YTf3N4379fghDfMt.Visible = num22 >= num24;
						axw0YTf3N4379fghDfMt.uVUf3caV8oa(_0020: false);
						num3 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
						{
							num3 = 0;
						}
						continue;
					case 42:
						if (XXFUWcbGJ2YEaSQe3jXR(list3) > 0)
						{
							kySlNFfMQBimj7edN21j = list3[Math.Min(num14, XXFUWcbGJ2YEaSQe3jXR(list3) - 1)];
							num26 = 61;
							goto IL_0045;
						}
						goto IL_09db;
					case 18:
						hhsXUObGmMG5TtXN9SRb(axw0YTf3N4379fghDfMt, new Point(num5, num25));
						num3 = 28;
						continue;
					case 60:
						list2 = MarketView.Settings.VisualSettings.GraphSizeFilters;
						num3 = 39;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
						{
							num3 = 34;
						}
						continue;
					case 58:
						if (J1yfRFMH3R6.Count > 1)
						{
							P_0.DrawLines(new XPen(((brG9LqfO0TVwbKGahwYo)qRaemUbG8PynaHgCEaEc(MarketView)).XCyftfK4jZn, mtWdCcbGA8adPVsbwjSh(MarketView.VisualSettings)), (Point[])Qp3oMMbGPo2BvK2Uk1x2(J1yfRFMH3R6));
						}
						goto IL_0465;
					case 36:
						num20 = (flag4 ? sl9ykSfFCMU49HP0CuHU.Size : sl9ykSfFCMU49HP0CuHU.QuoteSize);
						num3 = 60;
						continue;
					case 23:
						if (!(num5 < num11))
						{
							num6 = 3.0;
							flag3 = false;
							if (!flag)
							{
								num3 = 20;
								continue;
							}
							num17 = oD0htObGZTmcqMeJkDtw(sl9ykSfFCMU49HP0CuHU);
							goto IL_0f86;
						}
						if (n0ofRJXcYug.Count > num18)
						{
							n0ofRJXcYug.RemoveAt(num18);
						}
						if (bA2JEVbGUEJVKemdtkrt(J1yfRFMH3R6) > num18)
						{
							J1yfRFMH3R6.RemoveAt(num18);
							num3 = 2;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
							{
								num3 = 51;
							}
							continue;
						}
						goto case 51;
					case 5:
						goto IL_0bfe;
					case 2:
						goto IL_0daa;
					case 46:
						n0ofRJXcYug.Clear();
						num3 = 5;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
						{
							num3 = 44;
						}
						continue;
					case 63:
						return;
					case 25:
					case 27:
						if (!wjDhJ3bGzlZu21swPttQ(axw0YTf3N4379fghDfMt2))
						{
							num3 = 33;
							continue;
						}
						goto case 35;
					case 6:
						if (num19 >= 0)
						{
							if (num20 >= ijsjhhnGTadfwpOyDdrx.gN7nY27Lkwh(list2[num19].Value, flag4))
							{
								num15 = num19;
								num3 = 32;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2264c03640a14c8f930261fd70e85d60 != 0)
								{
									num3 = 18;
								}
								continue;
							}
							goto case 41;
						}
						goto case 32;
					case 52:
					{
						Size size = xFont.GetSize((string)(flag ? IfhpuZbGVAF1Rig1tYDH(ijsjhhnGTadfwpOyDdrx, num10, num9, flag2) : ijsjhhnGTadfwpOyDdrx.FormatRawQuoteSize(num10, num9, flag2)));
						if (size.Width > size.Height)
						{
							num6 = size.Width / 2.0;
							goto case 15;
						}
						num6 = size.Height / 2.0;
						num3 = 15;
						continue;
					}
					case 16:
						num7 = NiLFbZbGwP2i3KSwGZqZ(xrTs9ufSVt0hx8rJDd6l, (sl9ykSfFCMU49HP0CuHU.Price > sl9ykSfFCMU49HP0CuHU.FFnfF7kMeyd()) ? sl9ykSfFCMU49HP0CuHU.Price : iG1BvdbGhRaH1Hsn90ct(sl9ykSfFCMU49HP0CuHU)) - 2.0;
						num3 = 8;
						continue;
					case 8:
						{
							double num4 = NiLFbZbGwP2i3KSwGZqZ(xrTs9ufSVt0hx8rJDd6l, (sl9ykSfFCMU49HP0CuHU.Price < iG1BvdbGhRaH1Hsn90ct(sl9ykSfFCMU49HP0CuHU)) ? OoADSAbG7VsuWiQF2U50(sl9ykSfFCMU49HP0CuHU) : sl9ykSfFCMU49HP0CuHU.FFnfF7kMeyd()) + xrTs9ufSVt0hx8rJDd6l.I8MfLNiJ00B() + 2.0;
							axw0YTf3N4379fghDfMt.Rect = new Rect(num5 - num6, num7, num6 * 2.0, num4 - num7);
							axw0YTf3N4379fghDfMt.uVUf3caV8oa(_0020: true);
							num3 = 37;
							continue;
						}
						IL_09db:
						if (axw0YTf3N4379fghDfMt2.Side != Side.Buy)
						{
							xBrush = MarketView.Theme.A3IfWuExkuD;
							pen = (XPen)cb2dbmbGuNakF3SR8GFE(qRaemUbG8PynaHgCEaEc(MarketView));
							goto case 25;
						}
						num3 = 55;
						continue;
						IL_0465:
						if (MarketView.Settings.GraphShowTicks)
						{
							num3 = 17;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2fa91f76013747d9b5f0073a2a323201 != 0)
							{
								num3 = 8;
							}
							continue;
						}
						return;
						IL_0b95:
						num6 += (double)MarketView.VisualSettings.GraphTicksLineWidth / 2.0;
						num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
						{
							num3 = 4;
						}
						continue;
						IL_0f86:
						num10 = num17;
						num3 = 31;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
						{
							num3 = 14;
						}
						continue;
						IL_0045:
						num3 = num26;
						continue;
					}
					break;
					IL_0daa:
					if (!MarketView.VisualSettings.GraphShowTicksLine)
					{
						num3 = 63;
						continue;
					}
					goto IL_0e51;
				}
				goto IL_0382;
				IL_0bfe:
				num5 = xrTs9ufSVt0hx8rJDd6l.LXJfxF1ydT3() - 5.0;
				xFont = (((MhMDPU9v8rkigy1ao0Th)fgaQdCbG6YRjXfkRihF4()).MarketTradesGraphIsBold ? ((MarketSettings)jUCYQcbGM0cV58TewsNX(MarketView)).BaseBoldFont : MarketView.Settings.BaseFont);
				num3 = 30;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 != 0)
				{
					num3 = 9;
				}
				goto IL_0049;
				IL_0382:
				if (list.Count < J1yfRFMH3R6.Count)
				{
					kOPPu3bGRA7j5D3TbcNk(J1yfRFMH3R6);
					num3 = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
					{
						num3 = 3;
					}
					goto IL_0049;
				}
				goto IL_0bfe;
			}
			catch (Exception e)
			{
				LogManager.WriteError(e);
				return;
			}
			finally
			{
				o9YEQAbY9owyVTocscq9(P_0);
			}
		}
	}

	static uoOZ8sfRhGJAvaNN0O7a()
	{
		aiTQjMbYnF6kNsLp8Eb3();
	}

	internal static void lhjv4gbGXNMrW8PNbLkX()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool N3FlCsbGexXAcotfiIkn()
	{
		return KZ620fbGLuphqWi1xpO3 == null;
	}

	internal static uoOZ8sfRhGJAvaNN0O7a etcGWRbGsZGuIINhI8ry()
	{
		return KZ620fbGLuphqWi1xpO3;
	}

	internal static bool uGUclWbGcmLY6xtNyhJ1(object P_0)
	{
		return ((MarketSettings)P_0).GraphShowTicks;
	}

	internal static bool X0gDX1bGjwUeGBUA615g(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).GraphShowTicksLine;
	}

	internal static double OmSmT1bGETNWP1igbA7a(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double mUwWDobGQE2mLWEHYwua(object P_0)
	{
		return ((XE24ZNf6Ekk5SJSRxcIv)P_0).Height;
	}

	internal static object RTohwObGdJK1LlyXVfVq(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Market;
	}

	internal static int ohTrvFbGgrrdjsmBS4nK(object P_0)
	{
		return ((List<Sl9ykSfFCMU49HP0CuHU>)P_0).Count;
	}

	internal static void kOPPu3bGRA7j5D3TbcNk(object P_0)
	{
		((List<Point>)P_0).Clear();
	}

	internal static object fgaQdCbG6YRjXfkRihF4()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static object jUCYQcbGM0cV58TewsNX(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Settings;
	}

	internal static object p3KNImbGOE0joJmc44hJ(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static double JZYSJUbGqHZoq4jroXvH(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).GraphValuesFilter;
	}

	internal static long shP9RkbGI7W0GPFearXc(object P_0, double P_1, bool P_2)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).gN7nY27Lkwh(P_1, P_2);
	}

	internal static object kUFLOObGWd1dhQwkmerp(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).VisualSettings;
	}

	internal static double Iry2aLbGtlRtC9j94fPX(object P_0)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).I8MfLNiJ00B();
	}

	internal static int bA2JEVbGUEJVKemdtkrt(object P_0)
	{
		return ((List<Point>)P_0).Count;
	}

	internal static long msbgWibGTH6RDsinTBVn(object P_0)
	{
		return ((Sl9ykSfFCMU49HP0CuHU)P_0).QuoteSize;
	}

	internal static int myptwSbGy3cTAnb9vscv(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).UJElnHayjot;
	}

	internal static long oD0htObGZTmcqMeJkDtw(object P_0)
	{
		return ((Sl9ykSfFCMU49HP0CuHU)P_0).Size;
	}

	internal static object IfhpuZbGVAF1Rig1tYDH(object P_0, long P_1, int P_2, bool P_3)
	{
		return ((ijsjhhnGTadfwpOyDdrx)P_0).FormatRawSize(P_1, P_2, P_3);
	}

	internal static int TcQ68KbGCSeFfmWO9l4N(object P_0)
	{
		return ((List<Axw0YTf3N4379fghDfMt>)P_0).Count;
	}

	internal static void ornTfibGrwMHBHZwWFlR(object P_0, long P_1)
	{
		((Axw0YTf3N4379fghDfMt)P_0).Size = P_1;
	}

	internal static void zm3EFWbGKgXQMA0ragUZ(object P_0, bool P_1)
	{
		((Axw0YTf3N4379fghDfMt)P_0).ETBf3eREng8(P_1);
	}

	internal static void hhsXUObGmMG5TtXN9SRb(object P_0, Point P_1)
	{
		((Axw0YTf3N4379fghDfMt)P_0).Center = P_1;
	}

	internal static long iG1BvdbGhRaH1Hsn90ct(object P_0)
	{
		return ((Sl9ykSfFCMU49HP0CuHU)P_0).FFnfF7kMeyd();
	}

	internal static double NiLFbZbGwP2i3KSwGZqZ(object P_0, long P_1)
	{
		return ((XrTs9ufSVt0hx8rJDd6l)P_0).O4qfSpNNA8v(P_1);
	}

	internal static long OoADSAbG7VsuWiQF2U50(object P_0)
	{
		return ((Sl9ykSfFCMU49HP0CuHU)P_0).Price;
	}

	internal static object qRaemUbG8PynaHgCEaEc(object P_0)
	{
		return ((wFFFvWfsxErbxn4XFmrR)P_0).Theme;
	}

	internal static int mtWdCcbGA8adPVsbwjSh(object P_0)
	{
		return ((SH4fZjfBgpnJAYxtUbu4)P_0).GraphTicksLineWidth;
	}

	internal static object Qp3oMMbGPo2BvK2Uk1x2(object P_0)
	{
		return ((List<Point>)P_0).ToArray();
	}

	internal static int XXFUWcbGJ2YEaSQe3jXR(object P_0)
	{
		return ((List<kySlNFfMQBimj7edN21j>)P_0).Count;
	}

	internal static object GwtgRJbGFFNH18YKq5km(object P_0)
	{
		return ((kySlNFfMQBimj7edN21j)P_0).lvlfMCf9gX7;
	}

	internal static object zYytjKbG3nX5d4uyAN5H(object P_0)
	{
		return ((kySlNFfMQBimj7edN21j)P_0).bCQfMwri0VD;
	}

	internal static object eiYbAZbGpvICsT8c2EFt(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).W2TfWrBMMI8;
	}

	internal static object cb2dbmbGuNakF3SR8GFE(object P_0)
	{
		return ((brG9LqfO0TVwbKGahwYo)P_0).lr7fWPjZqqZ;
	}

	internal static bool wjDhJ3bGzlZu21swPttQ(object P_0)
	{
		return ((Axw0YTf3N4379fghDfMt)P_0).Yb9f3XDCPZM();
	}

	internal static FOWNtn91Tu8fC29CNc7t Bb5PiNbY0nT7birWvcEs(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).AggTradesShape;
	}

	internal static void KkHc7AbY2F9ATSLVxeYR(object P_0, object P_1, Point P_2, double P_3, double P_4)
	{
		((DxVisualQueue)P_0).FillEllipse((XBrush)P_1, P_2, P_3, P_4);
	}

	internal static Rect L38PSRbYH1iiCn8iYBoC(object P_0)
	{
		return ((Axw0YTf3N4379fghDfMt)P_0).Rect;
	}

	internal static bool eJfqUwbYf0g1WpCN5Pf1(object P_0)
	{
		return ((Axw0YTf3N4379fghDfMt)P_0).YTMf3L54qaB();
	}

	internal static void o9YEQAbY9owyVTocscq9(object P_0)
	{
		((DxVisualQueue)P_0).ResetClip();
	}

	internal static void aiTQjMbYnF6kNsLp8Eb3()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
