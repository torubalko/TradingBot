using System;
using System.Collections.Generic;
using ECOEgqlSad8NUJZ2Dr9n;
using IKRtvs98NZQ42c70CeTA;
using MLOwyT97zo8yIw4HQXQ4;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace zubX8t98xURGVEUDeJDm;

internal sealed class VFodNS98SJDApVubB2u2 : IChartCluster
{
	private readonly IRawCluster Onj98LSIJl4;

	private readonly decimal I4k98eb5N2i;

	private readonly decimal vQZ98sIMLVv;

	private static VFodNS98SJDApVubB2u2 Mx59gHbCCGooH3GnpIDi;

	public DateTime Time => LY5WuebCmvo7LsMb45Xl(Onj98LSIJl4);

	public DateTime OpenTime => Onj98LSIJl4.Time;

	public DateTime CloseTime => Onj98LSIJl4.Time;

	public decimal Open => (decimal)Onj98LSIJl4.Open * I4k98eb5N2i;

	public decimal High => TcA0O9bCw6eLafGjs09j(NSYhmabChdk17nDXPrmk(Onj98LSIJl4)) * I4k98eb5N2i;

	public decimal Low => TcA0O9bCw6eLafGjs09j(Onj98LSIJl4.Low) * I4k98eb5N2i;

	public decimal Close => oQWY69bC8dw20WwaUspf(TcA0O9bCw6eLafGjs09j(rvwQeDbC7VHOGNnCLI0P(Onj98LSIJl4)), I4k98eb5N2i);

	public decimal Bid => TcA0O9bCw6eLafGjs09j(Onj98LSIJl4.Bid) * vQZ98sIMLVv;

	public decimal Ask => (decimal)HiNgepbCAPcK6JAXi7qi(Onj98LSIJl4) * vQZ98sIMLVv;

	public int BidTrades => Onj98LSIJl4.BidTrades;

	public int AskTrades => Onj98LSIJl4.AskTrades;

	public long OpenPos => Onj98LSIJl4.OpenPos;

	public long OpenPosHigh => DPImT5bCP0rkdA7FLSnk(Onj98LSIJl4);

	public long OpenPosLow => Onj98LSIJl4.OpenPosLow;

	public long OpenPosBidChg => Onj98LSIJl4.OpenPosBidChg;

	public long OpenPosAskChg => YZkte5bCJlujaxhMRORS(Onj98LSIJl4);

	public long OpenPosChg => Onj98LSIJl4.OpenPosChg;

	public decimal Volume => (decimal)z2TXLPbCFLSvIYMdKQeV(Onj98LSIJl4) * vQZ98sIMLVv;

	public decimal Delta => oQWY69bC8dw20WwaUspf(I8QW85bC3jtN7ORTUebH(Onj98LSIJl4), vQZ98sIMLVv);

	public int Trades => R44PigbCpwPxNAh9iQXn(Onj98LSIJl4);

	public decimal DeltaHigh => oQWY69bC8dw20WwaUspf(tOy8DjbCumFk830adgb4(Onj98LSIJl4), vQZ98sIMLVv);

	public decimal DeltaLow => oQWY69bC8dw20WwaUspf(Onj98LSIJl4.DeltaLow, vQZ98sIMLVv);

	public bool IsUp => FXTZptbCzuE2FftboQ6I(Onj98LSIJl4);

	public IChartClusterMaxValues MaxValues => new baOEtM97uZ6bjYAptQfw(Onj98LSIJl4.MaxValues, I4k98eb5N2i, vQZ98sIMLVv);

	public List<IChartClusterItem> Items
	{
		get
		{
			List<IChartClusterItem> list = new List<IChartClusterItem>();
			foreach (IRawClusterItem item in Onj98LSIJl4.Items)
			{
				list.Add(new m811YH98bi07o87P5V3F(item, I4k98eb5N2i, vQZ98sIMLVv));
			}
			return list;
		}
	}

	public IChartClusterItem GetItem(decimal P_0)
	{
		long price = h4OOKnbr25fu4LifxUx3(WMEheJbr0NSw0UEwgXlr(P_0, I4k98eb5N2i));
		IRawClusterItem item = Onj98LSIJl4.GetItem(price);
		if (item == null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => null, 
			};
		}
		return new m811YH98bi07o87P5V3F(item, I4k98eb5N2i, vQZ98sIMLVv);
	}

	public VFodNS98SJDApVubB2u2(IRawCluster P_0, decimal P_1, decimal P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		Onj98LSIJl4 = P_0;
		I4k98eb5N2i = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 == 0)
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
				vQZ98sIMLVv = P_2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static VFodNS98SJDApVubB2u2()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static DateTime LY5WuebCmvo7LsMb45Xl(object P_0)
	{
		return ((IRawCluster)P_0).Time;
	}

	internal static bool oPQ7WXbCrW5pRvZSv423()
	{
		return Mx59gHbCCGooH3GnpIDi == null;
	}

	internal static VFodNS98SJDApVubB2u2 DlElFTbCKT5hk6vxhNi1()
	{
		return Mx59gHbCCGooH3GnpIDi;
	}

	internal static long NSYhmabChdk17nDXPrmk(object P_0)
	{
		return ((IRawCluster)P_0).High;
	}

	internal static decimal TcA0O9bCw6eLafGjs09j(long P_0)
	{
		return P_0;
	}

	internal static long rvwQeDbC7VHOGNnCLI0P(object P_0)
	{
		return ((IRawCluster)P_0).Close;
	}

	internal static decimal oQWY69bC8dw20WwaUspf(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static long HiNgepbCAPcK6JAXi7qi(object P_0)
	{
		return ((IRawCluster)P_0).Ask;
	}

	internal static long DPImT5bCP0rkdA7FLSnk(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosHigh;
	}

	internal static long YZkte5bCJlujaxhMRORS(object P_0)
	{
		return ((IRawCluster)P_0).OpenPosAskChg;
	}

	internal static long z2TXLPbCFLSvIYMdKQeV(object P_0)
	{
		return ((IRawCluster)P_0).Volume;
	}

	internal static long I8QW85bC3jtN7ORTUebH(object P_0)
	{
		return ((IRawCluster)P_0).Delta;
	}

	internal static int R44PigbCpwPxNAh9iQXn(object P_0)
	{
		return ((IRawCluster)P_0).Trades;
	}

	internal static long tOy8DjbCumFk830adgb4(object P_0)
	{
		return ((IRawCluster)P_0).DeltaHigh;
	}

	internal static bool FXTZptbCzuE2FftboQ6I(object P_0)
	{
		return ((IRawCluster)P_0).IsUp;
	}

	internal static decimal WMEheJbr0NSw0UEwgXlr(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static long h4OOKnbr25fu4LifxUx3(decimal P_0)
	{
		return (long)P_0;
	}
}
