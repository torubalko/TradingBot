using System;
using System.Collections.Generic;
using System.Windows;
using AFhqHf9jBdUU0oY6bWZl;
using ECOEgqlSad8NUJZ2Dr9n;
using I1BaHanG0KBZsFapGbF4;
using NsWD4W9miMxRbFU3fsu9;
using s8CVoTnYOlGDs7vDiB5f;
using TigerTrade.Chart.Clusters.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Settings;
using TigerTrade.Chart.Theme;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;
using TuAMtrl1Nd3XoZQQUXf0;
using U8g4nM9JuZySteT7noel;
using W7vgMFnvUmmoQloCDPpC;
using Wf1kTvnGy6XhfTKJgfkM;

namespace QGhVQP9Qx3B2p08QlRwD;

internal sealed class LsPDLk9QSmXoc3nqYBCZ
{
	private readonly vJGfm5nYMCEZFuST02my Tbe9Qe0Ibcj;

	private readonly ChartTheme dAp9Qsa1qKS;

	private readonly ChartSettings it69QXpKT8d;

	private readonly mR4Dhe9jvRbCaGB7gqgA Cvk9Qc5Mwhq;

	private IRawCluster jTU9Qjlnigo;

	private static LsPDLk9QSmXoc3nqYBCZ F6d8EPbj2XZLE01MwPBn;

	public LsPDLk9QSmXoc3nqYBCZ(vJGfm5nYMCEZFuST02my P_0)
	{
		W85j2Rbj9c7hfDZEo1HY();
		base._002Ector();
		Tbe9Qe0Ibcj = P_0;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				dAp9Qsa1qKS = (ChartTheme)lCtts4bjnxtFT7K9dQ21(P_0);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num = 0;
				}
				break;
			default:
				it69QXpKT8d = (ChartSettings)LDDPoWbjGwxX2nGtXBZG(P_0);
				Cvk9Qc5Mwhq = it69QXpKT8d.VisualSettings;
				return;
			}
		}
	}

	public void q5v9QLtuwcA(DxVisualQueue P_0, Rect P_1, ref List<bZ280mnnzG3Ijqb3fuSb> P_2)
	{
		ypqMIv9maFM0tRwF0xMh ypqMIv9maFM0tRwF0xMh = Tbe9Qe0Ibcj.DataProvider;
		int num;
		double step = default(double);
		if (WHUY3dbjYap5t2lQGs7H(Cvk9Qc5Mwhq) == ChartHistogramViewType.None)
		{
			num = 2;
		}
		else
		{
			step = ypqMIv9maFM0tRwF0xMh.Step;
			num = 26;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 == 0)
			{
				num = 12;
			}
		}
		XColor xColor = default(XColor);
		IRawClusterItem item = default(IRawClusterItem);
		long num9 = default(long);
		double num4 = default(double);
		double num8 = default(double);
		string text = default(string);
		ChartHistogramViewType chartHistogramViewType = default(ChartHistogramViewType);
		IRawClusterValueArea rawClusterValueArea = default(IRawClusterValueArea);
		long num11 = default(long);
		double num6 = default(double);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		double num7 = default(double);
		int num15 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		ijsjhhnGTadfwpOyDdrx symbol = default(ijsjhhnGTadfwpOyDdrx);
		int num10 = default(int);
		bool flag = default(bool);
		int num12 = default(int);
		long num13 = default(long);
		XBrush brush2 = default(XBrush);
		Rect rect2 = default(Rect);
		XBrush brush4 = default(XBrush);
		Rect rect8 = default(Rect);
		XBrush brush3 = default(XBrush);
		long num2 = default(long);
		XBrush xBrush4 = default(XBrush);
		double num16 = default(double);
		XFont font = default(XFont);
		Size size2 = default(Size);
		Rect rect5 = default(Rect);
		Rect rect3 = default(Rect);
		Rect rect = default(Rect);
		Size size = default(Size);
		while (true)
		{
			XBrush xBrush3;
			int num14;
			XBrush xBrush2;
			object obj2;
			object obj;
			XBrush xBrush;
			XBrush brush;
			Rect rect4;
			Size size3;
			switch (num)
			{
			case 45:
				xBrush3 = new XBrush(xColor.ChangeOpacity(-PtEebLbjL5B5XnVGjZ2h(item), num9, dAp9Qsa1qKS.ChartBackColor));
				goto IL_11fe;
			case 18:
				num4 = num8 / (double)item.Volume * (double)dhE2b9bjs0IK36hlIbGE(item);
				num = 10;
				continue;
			case 50:
				text = "";
				chartHistogramViewType = Cvk9Qc5Mwhq.HistogramViewType;
				num14 = 55;
				goto IL_0005;
			case 1:
				if (rawClusterValueArea != null && num11 == rawClusterValueArea.Vah)
				{
					num = 62;
					continue;
				}
				goto case 41;
			case 49:
				xBrush2 = dAp9Qsa1qKS.HistogramVolumeBrush;
				goto IL_1194;
			case 61:
				if (kk5GBtbjqBmQloQ5ulKw(Cvk9Qc5Mwhq))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 15;
			case 37:
				xBrush3 = dAp9Qsa1qKS.HistogramDeltaPlusBrush;
				goto IL_11fe;
			case 19:
				num8 = num6 / (double)maxValues.MaxVolume * (double)item.Volume;
				num = 18;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
				{
					num = 3;
				}
				continue;
			case 13:
			case 52:
			case 59:
				if (Cvk9Qc5Mwhq.HistogramCellViewType == ChartCellViewType.BorderedBars && num7 + (double)num15 > 3.0)
				{
					P_0.DrawRectangle(dAp9Qsa1qKS.HistogramCellBorderPen, new Rect(P_1.Left - 1.0, num3, num8, num5 - 1));
				}
				if (num11 != maxValues.Poc)
				{
					goto case 1;
				}
				if (!Gb4kWQbjQ6odh5HqMdci(Cvk9Qc5Mwhq))
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_859c6249cb0f4f11b2da29d1228ce418 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 4;
			case 14:
				text = symbol.FormatRawSize(item.Delta, num10, flag);
				goto case 13;
			case 56:
				return;
			case 44:
			{
				int num17 = (int)Tbe9Qe0Ibcj.ybUnYpBPWvT().A0PnvVYTtGb((double)num11 * step - step / 2.0);
				num5 = Math.Max(num17 - num12 + num15, 1);
				num3 = num12;
				num12 = num17;
				num = 58;
				continue;
			}
			case 58:
				item = jTU9Qjlnigo.GetItem(num11);
				if (item != null)
				{
					num8 = 0.0;
					num = 50;
					continue;
				}
				goto case 51;
			case 9:
				jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)2);
				goto IL_0fda;
			case 2:
				return;
			case 38:
				flag = Cvk9Qc5Mwhq.HistogramMinimizeValues;
				num11 = num13;
				goto IL_09b1;
			case 54:
				goto IL_04cf;
			case 36:
				P_0.DrawLine(new XPen(dAp9Qsa1qKS.HistogramMaximumBrush, 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Left + num6, num3 + num5 / 2));
				goto IL_111d;
			case 12:
				uHgo5pbjdnMDmaQUPwe4(P_0, new XPen(dAp9Qsa1qKS.HistogramMaximumBrush, 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Right, num3 + num5 / 2));
				P_2.Add(new bZ280mnnzG3Ijqb3fuSb((double)num11 * step, dAp9Qsa1qKS.HistogramMaximumColor));
				goto IL_111d;
			case 31:
				if (num7 > 7.0)
				{
					num = 21;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
					{
						num = 24;
					}
					continue;
				}
				goto case 51;
			case 53:
				num8 = num6 / (double)num9 * (double)Math.Abs(item.Delta);
				if (item.Delta <= 0)
				{
					num = 20;
					continue;
				}
				if (!Cvk9Qc5Mwhq.HistogramGradient)
				{
					num = 37;
					continue;
				}
				xColor = dAp9Qsa1qKS.HistogramDeltaPlusColor;
				xBrush3 = new XBrush(xColor.ChangeOpacity(item.Delta, num9, dAp9Qsa1qKS.ChartBackColor));
				goto IL_11fe;
			case 26:
				switch (Cvk9Qc5Mwhq.HistogramPeriod)
				{
				case ChartHistogramPeriodType.CurrentDay:
					jTU9Qjlnigo = (IRawCluster)SJEtl3bjoDM08IMSPTUu(ypqMIv9maFM0tRwF0xMh, (sOa57v9Jprw32ZFaJ5BM)0);
					goto IL_0fda;
				case ChartHistogramPeriodType.CurrentWeek:
					break;
				case ChartHistogramPeriodType.CurrentMonth:
					goto IL_04cf;
				case ChartHistogramPeriodType.LastWeek:
					goto IL_098a;
				case ChartHistogramPeriodType.Contract:
					jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)6);
					goto IL_0fda;
				case ChartHistogramPeriodType.LastMonth:
					goto IL_0dcf;
				default:
					goto IL_0fda;
				case ChartHistogramPeriodType.LastDay:
					goto IL_100b;
				}
				goto case 9;
			case 25:
				if (jP6EwUbjIwBney4fFbNG(Cvk9Qc5Mwhq))
				{
					num = 13;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
					{
						num = 31;
					}
					continue;
				}
				goto case 51;
			case 17:
				P_0.FillRectangle(brush2, rect2);
				P_0.FillRectangle(brush4, rect8);
				text = symbol.FormatRawSize(nT484ybjkQpJYHnLXJV3(item), num10, flag);
				num = 59;
				continue;
			case 46:
				if (Cvk9Qc5Mwhq.HistogramGradient)
				{
					xColor = dAp9Qsa1qKS.HistogramVolumeColor;
					num = 29;
				}
				else
				{
					num = 49;
				}
				continue;
			case 15:
				P_0.DrawLine(new XPen(dAp9Qsa1qKS.HistogramValueAreaBrush, 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Left + num6, num3 + num5 / 2));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num = 2;
				}
				continue;
			case 48:
				P_0.DrawLine(new XPen((XBrush)t1bW8SbjOY6hvNhISMOs(dAp9Qsa1qKS), 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Right, num3 + num5 / 2));
				P_2.Add(new bZ280mnnzG3Ijqb3fuSb((double)num11 * step, dAp9Qsa1qKS.HistogramValueAreaColor));
				goto case 57;
			case 47:
			{
				Rect rect7 = new Rect(P_1.Left, num3, num8, num5);
				P_0.FillRectangle(brush3, rect7);
				text = symbol.FormatRawSize(item.Volume, num10, flag);
				num = 13;
				continue;
			}
			case 40:
				if (num13 - num2 > 100000)
				{
					return;
				}
				maxValues = jTU9Qjlnigo.MaxValues;
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 42;
				}
				continue;
			case 35:
			{
				Rect rect6 = new Rect(P_1.Left, num3, num8, num5);
				XgX2SybjecWD2GEZmJv9(P_0, xBrush4, rect6);
				num14 = 14;
				goto IL_0005;
			}
			case 27:
				num15 = ((Cvk9Qc5Mwhq.HistogramCellViewType == ChartCellViewType.Bars || Cvk9Qc5Mwhq.HistogramCellViewType == ChartCellViewType.BorderedBars) ? (-1) : 0);
				num7 = spDoyTbjaciNbFHVRLJQ(EU6UNfbjvjgYcnVjOqAl(Tbe9Qe0Ibcj.ybUnYpBPWvT(), 0.0) - EU6UNfbjvjgYcnVjOqAl(Tbe9Qe0Ibcj.ybUnYpBPWvT(), JRJ1EsbjBe7PjUXfc4dB(Tbe9Qe0Ibcj.DataProvider)), 1.0);
				num16 = hRTvRubjirP4QXHBE2Qq(num7 + (double)num15 - 2.0, 18.0) * 96.0 / 72.0;
				num = 13;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
				{
					num = 22;
				}
				continue;
			case 22:
				num16 = Math.Min(num16, it69QXpKT8d.ChartFont.Size);
				font = new XFont(it69QXpKT8d.ChartFont.Name, num16);
				num13 = (long)(((NMHchMnvtxgoKNmDEII2)DBerpYbjlPiZddK3LuBL(Tbe9Qe0Ibcj)).O4PnBnYuFWH / step) + 1;
				num = 10;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num = 33;
				}
				continue;
			case 42:
				rawClusterValueArea = (gnrZ6pbj4QlU5Hk1tT8c(Cvk9Qc5Mwhq) ? jTU9Qjlnigo.GetValueArea(Cvk9Qc5Mwhq.HistogramValueAreaPercent) : null);
				num13 = Math.Min(jTU9Qjlnigo.High, num13 + 1);
				num = 21;
				continue;
			case 57:
				size2 = it69QXpKT8d.ChartFontBold.GetSize((string)G5BrtFbjRKvXCwV6o6DJ(--500511424 ^ 0x1DD110C2));
				num = 8;
				continue;
			case 4:
				rect5 = new Rect(P_1.Left, num3, num6, num5);
				if (Cvk9Qc5Mwhq.HistogramExtendPoc)
				{
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
					{
						num = 12;
					}
					continue;
				}
				goto case 36;
			case 10:
				if (!Cvk9Qc5Mwhq.HistogramGradient)
				{
					obj2 = fAEZ3pbjXa5ALfMoL0ZU(dAp9Qsa1qKS);
					goto IL_124b;
				}
				xColor = dAp9Qsa1qKS.HistogramBidColor;
				num = 34;
				continue;
			case 8:
				P_0.DrawString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x11D1040B ^ 0x11D52609), it69QXpKT8d.ChartFontBold, dAp9Qsa1qKS.HistogramValueAreaBrush, rect3.Right - size2.Width, rect3.Top - size2.Height - 4.0);
				num = 25;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d365c300683408da8d70007bc278f93 == 0)
				{
					num = 2;
				}
				continue;
			case 20:
				if (Cvk9Qc5Mwhq.HistogramGradient)
				{
					xColor = dAp9Qsa1qKS.HistogramDeltaMinusColor;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num = 45;
					}
					continue;
				}
				xBrush3 = dAp9Qsa1qKS.HistogramDeltaMinusBrush;
				goto IL_11fe;
			case 32:
				if (Cvk9Qc5Mwhq.HistogramGradient)
				{
					xColor = UgJgCdbjE8SKpoEtSRra(dAp9Qsa1qKS);
					num14 = 39;
					goto IL_0005;
				}
				goto case 11;
			case 6:
				symbol = ypqMIv9maFM0tRwF0xMh.Symbol;
				num10 = yoLOqhbjbJGJamwctSCp(Cvk9Qc5Mwhq);
				num = 38;
				continue;
			case 41:
				if (rawClusterValueArea != null && num11 == rawClusterValueArea.Val)
				{
					rect = new Rect(P_1.Left, num3, num6, num5);
					num = 61;
					continue;
				}
				goto case 25;
			case 21:
				num2 = qZADRobjD1h4kT1Ss95V(jTU9Qjlnigo.Low, num2 - 1);
				num12 = (int)Tbe9Qe0Ibcj.ybUnYpBPWvT().A0PnvVYTtGb((double)num13 * step + step / 2.0);
				num = 6;
				continue;
			case 16:
				goto IL_0dcf;
			case 11:
				obj = oIU7UKbjj6giHnirKE1x(dAp9Qsa1qKS);
				break;
			default:
				P_0.DrawLine(new XPen(dAp9Qsa1qKS.HistogramValueAreaBrush, 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Right, num3 + num5 / 2));
				P_2.Add(new bZ280mnnzG3Ijqb3fuSb((double)num11 * step, dAp9Qsa1qKS.HistogramValueAreaColor));
				num = 7;
				continue;
			case 51:
				num11--;
				goto IL_09b1;
			case 55:
				switch (chartHistogramViewType)
				{
				case ChartHistogramViewType.BidAsk:
					break;
				case ChartHistogramViewType.Volume:
					goto IL_05f4;
				case ChartHistogramViewType.Delta:
					goto IL_0671;
				case ChartHistogramViewType.Trades:
					goto IL_0cf5;
				default:
					goto IL_0eb2;
				}
				goto case 19;
			case 62:
				rect3 = new Rect(P_1.Left, num3, num6, num5);
				if (!Cvk9Qc5Mwhq.HistogramExtendValueArea)
				{
					P_0.DrawLine(new XPen((XBrush)t1bW8SbjOY6hvNhISMOs(dAp9Qsa1qKS), 3), new Point(P_1.Left, num3 + num5 / 2), new Point(P_1.Left + num6, num3 + num5 / 2));
					num = 57;
					continue;
				}
				num = 24;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
				{
					num = 48;
				}
				continue;
			case 24:
				if (num3 > 15)
				{
					P_0.DrawString(text, font, (XBrush)n5QNVKbjWCyPAG56Oo0W(dAp9Qsa1qKS), new Rect(P_1.Left + 2.0, num3, num6, num5));
					num = 51;
					continue;
				}
				goto case 51;
			case 63:
				rect2 = new Rect(P_1.Left, num3, num4, num5);
				num = 32;
				continue;
			case 3:
			case 7:
				size = ((XFont)eyuy0cbj6Ccph23jsmQl(it69QXpKT8d)).GetSize(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x80D98C7));
				num = 23;
				continue;
			case 33:
				num2 = (long)(Tbe9Qe0Ibcj.ybUnYpBPWvT().I4pnBGVUykx / step) - 1;
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num = 40;
				}
				continue;
			case 5:
			case 30:
			case 43:
				goto IL_0fda;
			case 28:
				goto IL_100b;
			case 23:
				yHLYyQbjMFv8eNy553B7(P_0, G5BrtFbjRKvXCwV6o6DJ(0x37B74BDF ^ 0x37B369D3), eyuy0cbj6Ccph23jsmQl(it69QXpKT8d), dAp9Qsa1qKS.HistogramValueAreaBrush, rect.Right - size.Width, rect.Top - size.Height - 4.0, XTextAlignment.Left);
				goto case 25;
			case 29:
				xBrush2 = new XBrush(xColor.ChangeOpacity(nT484ybjkQpJYHnLXJV3(item), maxValues.MaxVolume, dAp9Qsa1qKS.ChartBackColor));
				goto IL_1194;
			case 60:
				xBrush = new XBrush(xColor.ChangeOpacity(item.Trades, maxValues.MaxTrades, dAp9Qsa1qKS.ChartBackColor));
				goto IL_11d7;
			case 34:
				obj2 = new XBrush(xColor.ChangeOpacity(item.Bid, Math.Max(OWQns7bjcLukJio3mVZH(maxValues), maxValues.MaxAsk), dAp9Qsa1qKS.ChartBackColor));
				goto IL_124b;
			case 39:
				{
					obj = new XBrush(xColor.ChangeOpacity(item.Ask, Math.Max(OWQns7bjcLukJio3mVZH(maxValues), maxValues.MaxAsk), dAp9Qsa1qKS.ChartBackColor));
					break;
				}
				IL_0eb2:
				num = 52;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
				{
					num = 46;
				}
				continue;
				IL_0cf5:
				num8 = num6 / (double)XttcKKbj1eweZ6xISbVT(maxValues) * (double)item.Trades;
				if (Ao6YtUbj5h0Q9vIuJlgC(Cvk9Qc5Mwhq))
				{
					xColor = SRTLKBbjSOg6t6K2NfKy(dAp9Qsa1qKS);
					num = 60;
					continue;
				}
				xBrush = dAp9Qsa1qKS.HistogramTradesBrush;
				goto IL_11d7;
				IL_11d7:
				brush = xBrush;
				rect4 = new Rect(P_1.Left, num3, num8, num5);
				P_0.FillRectangle(brush, rect4);
				text = symbol.FormatTrades(N9c8hfbjxtP3TytXNAsR(item), num10, flag);
				goto case 13;
				IL_0671:
				num9 = Math.Max(maxValues.MaxDelta, -maxValues.MinDelta);
				num = 53;
				continue;
				IL_05f4:
				num8 = num6 / (double)p37jcabjN9w8HOO7IjrI(maxValues) * (double)item.Volume;
				num = 46;
				continue;
				IL_04cf:
				jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)4);
				num = 43;
				continue;
				IL_0fda:
				if (jTU9Qjlnigo == null)
				{
					return;
				}
				num6 = P_1.Width * 0.2;
				num = 27;
				continue;
				IL_124b:
				brush2 = (XBrush)obj2;
				num = 63;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 != 0)
				{
					num = 57;
				}
				continue;
				IL_09b1:
				if (num11 < num2)
				{
					num = 56;
					continue;
				}
				goto case 44;
				IL_1194:
				brush3 = xBrush2;
				num = 47;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7070f82fb97740909616ccb4e69409c5 == 0)
				{
					num = 36;
				}
				continue;
				IL_11fe:
				xBrush4 = xBrush3;
				num = 35;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num = 24;
				}
				continue;
				IL_0005:
				num = num14;
				continue;
				IL_111d:
				size3 = XLIy4TbjgM2Sn6QSobCA(it69QXpKT8d.ChartFontBold, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-377195341 ^ -377465525));
				yHLYyQbjMFv8eNy553B7(P_0, G5BrtFbjRKvXCwV6o6DJ(0x11D1040B ^ 0x11D525F3), eyuy0cbj6Ccph23jsmQl(it69QXpKT8d), dAp9Qsa1qKS.HistogramMaximumBrush, rect5.Right - size3.Width, rect5.Top - size3.Height - 4.0, XTextAlignment.Left);
				goto case 25;
				IL_100b:
				jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)1);
				num = 30;
				continue;
				IL_0dcf:
				jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)5);
				goto IL_0fda;
				IL_098a:
				jTU9Qjlnigo = ypqMIv9maFM0tRwF0xMh.zWfln9vXkDc((sOa57v9Jprw32ZFaJ5BM)3);
				num = 5;
				continue;
			}
			brush4 = (XBrush)obj;
			rect8 = new Rect(P_1.Left + num4, num3, num8 - num4, num5);
			num = 17;
		}
	}

	static LsPDLk9QSmXoc3nqYBCZ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void W85j2Rbj9c7hfDZEo1HY()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object lCtts4bjnxtFT7K9dQ21(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Theme;
	}

	internal static object LDDPoWbjGwxX2nGtXBZG(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).Settings;
	}

	internal static bool kuk6E4bjHLLMjrNkC4Sc()
	{
		return F6d8EPbj2XZLE01MwPBn == null;
	}

	internal static LsPDLk9QSmXoc3nqYBCZ lY8U2objfAXJwPtolPWa()
	{
		return F6d8EPbj2XZLE01MwPBn;
	}

	internal static ChartHistogramViewType WHUY3dbjYap5t2lQGs7H(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramViewType;
	}

	internal static object SJEtl3bjoDM08IMSPTUu(object P_0, sOa57v9Jprw32ZFaJ5BM P_1)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).zWfln9vXkDc(P_1);
	}

	internal static double EU6UNfbjvjgYcnVjOqAl(object P_0, double P_1)
	{
		return ((NMHchMnvtxgoKNmDEII2)P_0).A0PnvVYTtGb(P_1);
	}

	internal static double JRJ1EsbjBe7PjUXfc4dB(object P_0)
	{
		return ((ypqMIv9maFM0tRwF0xMh)P_0).Step;
	}

	internal static double spDoyTbjaciNbFHVRLJQ(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static double hRTvRubjirP4QXHBE2Qq(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object DBerpYbjlPiZddK3LuBL(object P_0)
	{
		return ((vJGfm5nYMCEZFuST02my)P_0).ybUnYpBPWvT();
	}

	internal static bool gnrZ6pbj4QlU5Hk1tT8c(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramShowValueArea;
	}

	internal static long qZADRobjD1h4kT1Ss95V(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static int yoLOqhbjbJGJamwctSCp(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramRoundValues;
	}

	internal static long p37jcabjN9w8HOO7IjrI(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long nT484ybjkQpJYHnLXJV3(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static int XttcKKbj1eweZ6xISbVT(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxTrades;
	}

	internal static bool Ao6YtUbj5h0Q9vIuJlgC(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramGradient;
	}

	internal static XColor SRTLKBbjSOg6t6K2NfKy(object P_0)
	{
		return ((ChartTheme)P_0).HistogramTradesColor;
	}

	internal static int N9c8hfbjxtP3TytXNAsR(object P_0)
	{
		return ((IRawClusterItem)P_0).Trades;
	}

	internal static long PtEebLbjL5B5XnVGjZ2h(object P_0)
	{
		return ((IRawClusterItem)P_0).Delta;
	}

	internal static void XgX2SybjecWD2GEZmJv9(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static long dhE2b9bjs0IK36hlIbGE(object P_0)
	{
		return ((IRawClusterItem)P_0).Bid;
	}

	internal static object fAEZ3pbjXa5ALfMoL0ZU(object P_0)
	{
		return ((ChartTheme)P_0).HistogramBidBrush;
	}

	internal static long OWQns7bjcLukJio3mVZH(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxBid;
	}

	internal static object oIU7UKbjj6giHnirKE1x(object P_0)
	{
		return ((ChartTheme)P_0).HistogramAskBrush;
	}

	internal static XColor UgJgCdbjE8SKpoEtSRra(object P_0)
	{
		return ((ChartTheme)P_0).HistogramAskColor;
	}

	internal static bool Gb4kWQbjQ6odh5HqMdci(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramShowPoc;
	}

	internal static void uHgo5pbjdnMDmaQUPwe4(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static Size XLIy4TbjgM2Sn6QSobCA(object P_0, object P_1)
	{
		return ((XFont)P_0).GetSize((string)P_1);
	}

	internal static object G5BrtFbjRKvXCwV6o6DJ(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object eyuy0cbj6Ccph23jsmQl(object P_0)
	{
		return ((ChartSettings)P_0).ChartFontBold;
	}

	internal static void yHLYyQbjMFv8eNy553B7(object P_0, object P_1, object P_2, object P_3, double P_4, double P_5, XTextAlignment P_6)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5, P_6);
	}

	internal static object t1bW8SbjOY6hvNhISMOs(object P_0)
	{
		return ((ChartTheme)P_0).HistogramValueAreaBrush;
	}

	internal static bool kk5GBtbjqBmQloQ5ulKw(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramExtendValueArea;
	}

	internal static bool jP6EwUbjIwBney4fFbNG(object P_0)
	{
		return ((mR4Dhe9jvRbCaGB7gqgA)P_0).HistogramShowValues;
	}

	internal static object n5QNVKbjWCyPAG56Oo0W(object P_0)
	{
		return ((ChartTheme)P_0).HistogramTextBrush;
	}
}
