using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using CA00IGfn6UyfKXYOM3Is;
using cFTRcUBbPZKPRWBDbjk;
using ECOEgqlSad8NUJZ2Dr9n;
using LxkBMPH3MZ8ObkVk5Atk;
using M7Qhok2zS37wTYN0rqJn;
using pduUFuHP7jFN8rkxyl0l;
using reuqbSHkyZtO3nPa1eKn;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Parts.Symbols;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.Manager;
using TigerTrade.UI.Controls.Notifications;
using TuAMtrl1Nd3XoZQQUXf0;
using wE4CpeH3AF16tgcTfoUP;
using wse3wd2zgF9O4VW2DUfZ;

namespace qAk2I7vAnP8GlHo9pVv;

internal sealed class jIh171v86jxWrLQ6orO : xRgq7gHkTVINiHGAKc0y
{
	[Serializable]
	[CompilerGenerated]
	private sealed class cf0oTFnDS5Pq5sJTkolB
	{
		public static readonly cf0oTFnDS5Pq5sJTkolB pMvnDLw0MUj;

		private static cf0oTFnDS5Pq5sJTkolB yBdceuN0WsT6vO747EDy;

		static cf0oTFnDS5Pq5sJTkolB()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
			sTb7OgN0T9HlWDEDtwFJ();
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			pMvnDLw0MUj = new cf0oTFnDS5Pq5sJTkolB();
		}

		public cf0oTFnDS5Pq5sJTkolB()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			base._002Ector();
		}

		internal void IVEnDxfYOMR(UserDeal deal)
		{
			p4gwA9H36qTSRys5LY33 p4gwA9H36qTSRys5LY = (p4gwA9H36qTSRys5LY33)EDUvyEN0Z4N25gQwhtSr(R8HNanN0ydHnt6X537Ol(deal));
			int num;
			if (p4gwA9H36qTSRys5LY != null)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_005b;
			IL_0009:
			double num2 = default(double);
			while (true)
			{
				switch (num)
				{
				case 5:
					break;
				default:
					num2 = p4gwA9H36qTSRys5LY.BrokerComission + omxlQ6N0Vhc8SHVMP9lL(p4gwA9H36qTSRys5LY);
					if (!(num2 > 0.0))
					{
						break;
					}
					if (p4gwA9H36qTSRys5LY.CommissionType != SymbolCommissionType.Fixed)
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
						{
							num = 3;
						}
						continue;
					}
					goto case 2;
				case 1:
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)HVyfc8N0KAwMlRdXk0MV(), Resources.RiskManagerTradingBlocked, NotificationType.Info));
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num = 3;
					}
					continue;
				case 4:
					return;
				case 2:
					deal.Comission = deal.Quantity * num2;
					num = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num = 5;
					}
					continue;
				case 3:
				case 6:
					deal.Comission = deal.TotalValue * (num2 / 100.0);
					break;
				}
				break;
			}
			goto IL_005b;
			IL_005b:
			h8uiRtfnRZ9JJpkepmSl.e4KfnMnruiQ(deal);
			Symbol symbol = (Symbol)zTYinMN0Cc7woP9YTpZK(deal.SymbolID);
			if (OlGVRBN0r7o0gSFM5WOG(deal.LocalTime.Date, TimeHelper.GetCurrDate(symbol.Exchange)))
			{
				return;
			}
			zyW7WyHPwnJEtIOWC1Wm.wTjHPJm2l1b(deal);
			if (zyW7WyHPwnJEtIOWC1Wm.SBCHPAwfl6D(deal.AccountName, deal.SymbolID))
			{
				return;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}

		internal static void sTb7OgN0T9HlWDEDtwFJ()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static bool t9DJ9TN0tqrrsMCHuwDA()
		{
			return yBdceuN0WsT6vO747EDy == null;
		}

		internal static cf0oTFnDS5Pq5sJTkolB qGKSAGN0U3lA7EGLwDCZ()
		{
			return yBdceuN0WsT6vO747EDy;
		}

		internal static object R8HNanN0ydHnt6X537Ol(object P_0)
		{
			return ((UserDeal)P_0).SymbolID;
		}

		internal static object EDUvyEN0Z4N25gQwhtSr(object P_0)
		{
			return vUDXImH38MJqxh3d1b5K.vTpH3FJLXYY((string)P_0);
		}

		internal static double omxlQ6N0Vhc8SHVMP9lL(object P_0)
		{
			return ((p4gwA9H36qTSRys5LY33)P_0).ExchangeComission;
		}

		internal static object zTYinMN0Cc7woP9YTpZK(object P_0)
		{
			return SymbolManager.Get((string)P_0);
		}

		internal static bool OlGVRBN0r7o0gSFM5WOG(DateTime P_0, DateTime P_1)
		{
			return P_0 != P_1;
		}

		internal static object HVyfc8N0KAwMlRdXk0MV()
		{
			return Resources.RiskManagerTitle;
		}
	}

	[CompilerGenerated]
	private readonly ObservableCollection<p7cFdGBDT4JXRGB8E8x> SL0Ba2T1Ec;

	private readonly Dictionary<string, p7cFdGBDT4JXRGB8E8x> qRYBiyhXEu;

	private p7cFdGBDT4JXRGB8E8x zOrBlYacCt;

	private bool cWAB4D5s6G;

	private static jIh171v86jxWrLQ6orO M6Mk3nlAomfXEsyyPkgc;

	public ObservableCollection<p7cFdGBDT4JXRGB8E8x> UserPositions
	{
		[CompilerGenerated]
		get
		{
			return SL0Ba2T1Ec;
		}
	}

	public p7cFdGBDT4JXRGB8E8x SelectedPosition
	{
		get
		{
			return zOrBlYacCt;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					JZYHkZsWiJ6((string)KWx56HlAah3hZdyjHl5a(0x130FEA25 ^ 0x130FCAE1));
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1AB79299 ^ 0x1AB7B5D9));
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BF8E63F));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					if (!object.Equals(objA, zOrBlYacCt))
					{
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					zOrBlYacCt = objA;
					num2 = 3;
					break;
				case 2:
					JZYHkZsWiJ6((string)KWx56HlAah3hZdyjHl5a(0x24B0B9E6 ^ 0x24B0990E));
					return;
				}
			}
		}
	}

	public bool CanEdit => SelectedPosition != null;

	public bool CanClear => SelectedPosition != null;

	public bool CanClose
	{
		get
		{
			if (SelectedPosition != null)
			{
				return pyTvpxQDVv(SelectedPosition);
			}
			return false;
		}
	}

	public bool OnlyOpenPositions
	{
		get
		{
			return cWAB4D5s6G;
		}
		set
		{
			if (flag == cWAB4D5s6G)
			{
				return;
			}
			cWAB4D5s6G = flag;
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					JZYHkZsWiJ6(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x735715F1 ^ 0x7357350D));
					SelectedPosition = null;
					MZhBHwHMPV();
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	static jIh171v86jxWrLQ6orO()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		DataManager.OnUserDeal += delegate(UserDeal deal)
		{
			p4gwA9H36qTSRys5LY33 p4gwA9H36qTSRys5LY = (p4gwA9H36qTSRys5LY33)cf0oTFnDS5Pq5sJTkolB.EDUvyEN0Z4N25gQwhtSr(cf0oTFnDS5Pq5sJTkolB.R8HNanN0ydHnt6X537Ol(deal));
			int num2;
			if (p4gwA9H36qTSRys5LY != null)
			{
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num2 = 0;
				}
				goto IL_0009;
			}
			goto IL_005b;
			IL_0009:
			double num3 = default(double);
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				default:
					num3 = p4gwA9H36qTSRys5LY.BrokerComission + cf0oTFnDS5Pq5sJTkolB.omxlQ6N0Vhc8SHVMP9lL(p4gwA9H36qTSRys5LY);
					if (!(num3 > 0.0))
					{
						break;
					}
					if (p4gwA9H36qTSRys5LY.CommissionType != SymbolCommissionType.Fixed)
					{
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 1:
					K6lE4P2zdkKlpKsuOtJY.Vyf2z6nK1t1(new FcjPXM2z5nD8Dwq2mFW6((string)cf0oTFnDS5Pq5sJTkolB.HVyfc8N0KAwMlRdXk0MV(), Resources.RiskManagerTradingBlocked, NotificationType.Info));
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					return;
				case 2:
					deal.Comission = deal.Quantity * num3;
					num2 = 3;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
				case 6:
					deal.Comission = deal.TotalValue * (num3 / 100.0);
					break;
				}
				break;
			}
			goto IL_005b;
			IL_005b:
			h8uiRtfnRZ9JJpkepmSl.e4KfnMnruiQ(deal);
			Symbol symbol = (Symbol)cf0oTFnDS5Pq5sJTkolB.zTYinMN0Cc7woP9YTpZK(deal.SymbolID);
			if (cf0oTFnDS5Pq5sJTkolB.OlGVRBN0r7o0gSFM5WOG(deal.LocalTime.Date, TimeHelper.GetCurrDate(symbol.Exchange)))
			{
				return;
			}
			zyW7WyHPwnJEtIOWC1Wm.wTjHPJm2l1b(deal);
			if (zyW7WyHPwnJEtIOWC1Wm.SBCHPAwfl6D(deal.AccountName, deal.SymbolID))
			{
				return;
			}
			num2 = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 != 0)
			{
				num2 = 0;
			}
			goto IL_0009;
		};
	}

	public jIh171v86jxWrLQ6orO()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		qRYBiyhXEu = new Dictionary<string, p7cFdGBDT4JXRGB8E8x>();
		base._002Ector();
		SL0Ba2T1Ec = new ObservableCollection<p7cFdGBDT4JXRGB8E8x>();
		h8uiRtfnRZ9JJpkepmSl.iWhfnmR8dlj(m4jvFqdDp2);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				h8uiRtfnRZ9JJpkepmSl.sVufny5rRK1(Yp7vPubNq7);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				g14bhOlAiQIdKOVWWqeK(new Action(MZhBHwHMPV));
				return;
			default:
				DataManager.OnUserPosition += MhevJDq7hI;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_aab13e7d663746898a6666b7303ea6c2 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	private void Yp7vPubNq7(UserDeal P_0)
	{
		int num = 2;
		int num2 = num;
		Symbol symbol = default(Symbol);
		p7cFdGBDT4JXRGB8E8x current = default(p7cFdGBDT4JXRGB8E8x);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			{
				if (symbol == null || f3vYhUlA479EIxRcd74Z(P_0).Date != TimeHelper.GetCurrDate(symbol.Exchange))
				{
					return;
				}
				using IEnumerator<p7cFdGBDT4JXRGB8E8x> enumerator = UserPositions.GetEnumerator();
				while (true)
				{
					int num3;
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						num3 = 2;
					}
					else
					{
						num3 = 3;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							if (current.Position.SymbolID != P_0.SymbolID)
							{
								break;
							}
							goto default;
						case 1:
							break;
						default:
							if (!RxxKaIlAbO5HZiM4lP2d(((UserPosition)CmR3dPlADNKNxbsho58O(current)).AccountID, P_0.AccountID))
							{
								current.TotalPoints += gkrO6wlANgwwZJl3lSNI(P_0);
								p7cFdGBDT4JXRGB8E8x p7cFdGBDT4JXRGB8E8x = current;
								gDL4DklA18A15YHUVxy9(p7cFdGBDT4JXRGB8E8x, p7cFdGBDT4JXRGB8E8x.TotalGrossPnl + olN1CjlAkmDhTTKbFMMF(P_0));
								p7cFdGBDT4JXRGB8E8x p7cFdGBDT4JXRGB8E8x2 = current;
								p7cFdGBDT4JXRGB8E8x2.Comission = Nai2f1lA5tkb4XZP1TU2(p7cFdGBDT4JXRGB8E8x2) + P_0.Comission;
								num3 = 1;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						case 3:
							return;
						}
						break;
					}
				}
			}
			case 2:
				symbol = SymbolManager.Get((string)MjI0aNlAlH0Q9BgSfF18(P_0));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void MhevJDq7hI(UserPosition P_0)
	{
		int num = 1;
		int num2 = num;
		p7cFdGBDT4JXRGB8E8x p7cFdGBDT4JXRGB8E8x = default(p7cFdGBDT4JXRGB8E8x);
		while (true)
		{
			switch (num2)
			{
			case 3:
				p7cFdGBDT4JXRGB8E8x.D6EBNTyRE4();
				num2 = 4;
				break;
			case 1:
			{
				if (qRYBiyhXEu.ContainsKey(P_0.PositionID))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
					{
						num2 = 0;
					}
					break;
				}
				p7cFdGBDT4JXRGB8E8x p7cFdGBDT4JXRGB8E8x2 = new p7cFdGBDT4JXRGB8E8x(P_0);
				qRYBiyhXEu.Add((string)BOS6AIlASa3e5KbHrkAX(P_0), p7cFdGBDT4JXRGB8E8x2);
				using (List<UserDeal>.Enumerator enumerator = h8uiRtfnRZ9JJpkepmSl.zJKfntsbo6Z(P_0.SymbolID, (string)shfG43lAxeeCxQILRaIP(P_0)).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						UserDeal current;
						while (true)
						{
							current = enumerator.Current;
							int num3 = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							case 1:
								continue;
							}
							break;
						}
						p7cFdGBDT4JXRGB8E8x2.TotalPoints += gkrO6wlANgwwZJl3lSNI(current);
						p7cFdGBDT4JXRGB8E8x2.TotalGrossPnl += current.Profit;
						p7cFdGBDT4JXRGB8E8x2.Comission += toWLt1lALfatZQCb5Xuh(current);
					}
				}
				p7cFdGBDT4JXRGB8E8x2.IsVisible = Filter(p7cFdGBDT4JXRGB8E8x2);
				UserPositions.Add(p7cFdGBDT4JXRGB8E8x2);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
				{
					num2 = 2;
				}
				break;
			}
			default:
				p7cFdGBDT4JXRGB8E8x = qRYBiyhXEu[P_0.PositionID];
				num2 = 3;
				break;
			case 2:
				return;
			case 4:
				p7cFdGBDT4JXRGB8E8x.IsVisible = Filter(p7cFdGBDT4JXRGB8E8x);
				return;
			}
		}
	}

	private void m4jvFqdDp2()
	{
		IEnumerator<p7cFdGBDT4JXRGB8E8x> enumerator = UserPositions.GetEnumerator();
		try
		{
			p7cFdGBDT4JXRGB8E8x current = default(p7cFdGBDT4JXRGB8E8x);
			double num2 = default(double);
			double num3 = default(double);
			while (true)
			{
				int num5;
				if (enumerator.MoveNext())
				{
					current = enumerator.Current;
					List<UserDeal> list = h8uiRtfnRZ9JJpkepmSl.zJKfntsbo6Z((string)inuVZflAeSIOY1TPOlu9(current.Position), current.Position.AccountID);
					double num = 0.0;
					num2 = 0.0;
					num3 = 0.0;
					using (List<UserDeal>.Enumerator enumerator2 = list.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							UserDeal current2;
							while (true)
							{
								current2 = enumerator2.Current;
								num += current2.Points;
								int num4 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 != 0)
								{
									num4 = 1;
								}
								switch (num4)
								{
								case 1:
									goto end_IL_00eb;
								}
								continue;
								end_IL_00eb:
								break;
							}
							num2 += current2.Profit;
							num3 += current2.Comission;
						}
					}
					current.TotalPoints = num;
					num5 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
					{
						num5 = 1;
					}
				}
				else
				{
					num5 = 2;
				}
				while (true)
				{
					switch (num5)
					{
					case 1:
						current.TotalGrossPnl = num2;
						gov4MMlAssMNyLblLs5o(current, num3);
						num5 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 != 0)
						{
							num5 = 0;
						}
						continue;
					case 2:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				zn6m5TlAXSx0RkYq4VrT(enumerator);
			}
		}
	}

	public void VZXv3VUQRJ()
	{
		foreach (p7cFdGBDT4JXRGB8E8x item in UserPositions)
		{
			item.D6EBNTyRE4();
		}
	}

	public bool pyTvpxQDVv(p7cFdGBDT4JXRGB8E8x P_0)
	{
		return P_0.Position.Size != 0;
	}

	public void ClosePosition(p7cFdGBDT4JXRGB8E8x viewModel)
	{
		UserPosition userPosition = viewModel.Position;
		if (userPosition.Size != 0L)
		{
			DataManager.ClientUpdateUserPosition(UserPositionData.ClosePosition(userPosition.ConnectionID, userPosition.PositionID));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void dsdvu829vB(UserPosition P_0)
	{
		if (PZMFiJlAcifK39LmwvJt(P_0) == 0L)
		{
			DataManager.ClientUpdateUserPosition(UserPositionData.HidePosition(SelectedPosition.Position.ConnectionID, SelectedPosition.Position.PositionID));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a9d70160736846b58381afc3c46699f2 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
	}

	public void J23vzEElHu()
	{
		if (SelectedPosition != null)
		{
			ClosePosition(SelectedPosition);
		}
	}

	public void CloseAllPositions()
	{
		IEnumerator<p7cFdGBDT4JXRGB8E8x> enumerator = UserPositions.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				p7cFdGBDT4JXRGB8E8x current = enumerator.Current;
				ClosePosition(current);
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				enumerator.Dispose();
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	public void EnterPosition(string symbolID, string accountID, double price, double size)
	{
		int num = 4;
		int num2 = num;
		Symbol symbol = default(Symbol);
		Account account = default(Account);
		while (true)
		{
			switch (num2)
			{
			default:
				symbol = symbol.GetSymbol();
				Fi7BlslAQl44CrZiLXSE(UserPositionData.NewPosition(account.ConnectionID, symbol.ID, account.AccountID, symbol.GetShortPrice(price), FF6HrYlAE37LfoEsNsiu(symbol, size)));
				return;
			case 1:
				if (!(price > 0.0) || size == 0.0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f40a817752724303a7406a720886b183 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				symbol = SymbolManager.Get(symbolID);
				num2 = 3;
				break;
			case 2:
				if (symbol == null || account == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				account = (Account)La42FdlAj2UlxLrPoWLh(accountID);
				num2 = 2;
				break;
			}
		}
	}

	public void TCOB0smr4L(p7cFdGBDT4JXRGB8E8x P_0, double P_1, double P_2)
	{
		int num = 1;
		int num2 = num;
		UserPosition userPosition = default(UserPosition);
		while (true)
		{
			switch (num2)
			{
			case 1:
				userPosition = P_0.Position;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (P_1 > 0.0 && P_2 != 0.0)
				{
					DataManager.ClientUpdateUserPosition((UserPositionData)wRPa9mlAgG88ghabOewo(hLk1uClAd5c2b3FpFVXY(userPosition), userPosition.PositionID, userPosition.Symbol.GetShortPrice(P_1), FF6HrYlAE37LfoEsNsiu(userPosition.Symbol, P_2)));
				}
				return;
			}
		}
	}

	public void aHmB2Ru1YK(p7cFdGBDT4JXRGB8E8x P_0)
	{
		DataManager.ClientUpdateUserPosition(UserPositionData.ClearPosition(((UserPosition)CmR3dPlADNKNxbsho58O(P_0)).ConnectionID, P_0.Position.PositionID));
	}

	public bool Filter(object obj)
	{
		int num;
		if (!(obj is p7cFdGBDT4JXRGB8E8x p7cFdGBDT4JXRGB8E8x))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
			{
				num = 0;
			}
		}
		else
		{
			if (!DataManager.FilterAccount(((UserPosition)CmR3dPlADNKNxbsho58O(p7cFdGBDT4JXRGB8E8x)).AccountID))
			{
				return false;
			}
			if (!p7cFdGBDT4JXRGB8E8x.Position.Hidden)
			{
				if (OnlyOpenPositions)
				{
					return (string)O9RuSvlARvYKjrsotOuj(p7cFdGBDT4JXRGB8E8x) != Resources.PositionSideFlat;
				}
				return true;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
			{
				num = 0;
			}
		}
		return num switch
		{
			1 => false, 
			_ => false, 
		};
	}

	private void MZhBHwHMPV()
	{
		foreach (p7cFdGBDT4JXRGB8E8x item in UserPositions)
		{
			qmZt40lA6MVKYnwP6fl1(item, Filter(item));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
	}

	internal static object KWx56HlAah3hZdyjHl5a(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool ueIhIAlAvcxh5t9o9i5Q()
	{
		return M6Mk3nlAomfXEsyyPkgc == null;
	}

	internal static jIh171v86jxWrLQ6orO DBwXy4lAB9ZdHeeVYqgp()
	{
		return M6Mk3nlAomfXEsyyPkgc;
	}

	internal static void g14bhOlAiQIdKOVWWqeK(object P_0)
	{
		DataManager.OnUpdateFilters += (Action)P_0;
	}

	internal static object MjI0aNlAlH0Q9BgSfF18(object P_0)
	{
		return ((UserDeal)P_0).SymbolID;
	}

	internal static DateTime f3vYhUlA479EIxRcd74Z(object P_0)
	{
		return ((UserDeal)P_0).LocalTime;
	}

	internal static object CmR3dPlADNKNxbsho58O(object P_0)
	{
		return ((p7cFdGBDT4JXRGB8E8x)P_0).Position;
	}

	internal static bool RxxKaIlAbO5HZiM4lP2d(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static double gkrO6wlANgwwZJl3lSNI(object P_0)
	{
		return ((UserDeal)P_0).Points;
	}

	internal static double olN1CjlAkmDhTTKbFMMF(object P_0)
	{
		return ((UserDeal)P_0).Profit;
	}

	internal static void gDL4DklA18A15YHUVxy9(object P_0, double P_1)
	{
		((p7cFdGBDT4JXRGB8E8x)P_0).TotalGrossPnl = P_1;
	}

	internal static double Nai2f1lA5tkb4XZP1TU2(object P_0)
	{
		return ((p7cFdGBDT4JXRGB8E8x)P_0).Comission;
	}

	internal static object BOS6AIlASa3e5KbHrkAX(object P_0)
	{
		return ((UserPosition)P_0).PositionID;
	}

	internal static object shfG43lAxeeCxQILRaIP(object P_0)
	{
		return ((UserPosition)P_0).AccountID;
	}

	internal static double toWLt1lALfatZQCb5Xuh(object P_0)
	{
		return ((UserDeal)P_0).Comission;
	}

	internal static object inuVZflAeSIOY1TPOlu9(object P_0)
	{
		return ((UserPosition)P_0).SymbolID;
	}

	internal static void gov4MMlAssMNyLblLs5o(object P_0, double P_1)
	{
		((p7cFdGBDT4JXRGB8E8x)P_0).Comission = P_1;
	}

	internal static void zn6m5TlAXSx0RkYq4VrT(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static long PZMFiJlAcifK39LmwvJt(object P_0)
	{
		return ((UserPosition)P_0).Size;
	}

	internal static object La42FdlAj2UlxLrPoWLh(object P_0)
	{
		return DataManager.GetAccount((string)P_0);
	}

	internal static long FF6HrYlAE37LfoEsNsiu(object P_0, double P_1)
	{
		return ((SymbolBase)P_0).GetShortSize(P_1);
	}

	internal static void Fi7BlslAQl44CrZiLXSE(object P_0)
	{
		DataManager.ClientUpdateUserPosition((UserPositionData)P_0);
	}

	internal static object hLk1uClAd5c2b3FpFVXY(object P_0)
	{
		return ((UserPosition)P_0).ConnectionID;
	}

	internal static object wRPa9mlAgG88ghabOewo(object P_0, object P_1, long P_2, long P_3)
	{
		return UserPositionData.EditPosition((string)P_0, (string)P_1, P_2, P_3);
	}

	internal static object O9RuSvlARvYKjrsotOuj(object P_0)
	{
		return ((p7cFdGBDT4JXRGB8E8x)P_0).Side;
	}

	internal static void qmZt40lA6MVKYnwP6fl1(object P_0, bool P_1)
	{
		((p7cFdGBDT4JXRGB8E8x)P_0).IsVisible = P_1;
	}
}
