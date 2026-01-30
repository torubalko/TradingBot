using System;
using System.Collections.Generic;
using ABxgvYHyUBReVTOnCgrh;
using ECOEgqlSad8NUJZ2Dr9n;
using JqoLlqHyBgBYvLLyNweQ;
using SiIjO2HT3B67XBQMGhXK;
using TuAMtrl1Nd3XoZQQUXf0;

namespace BeZUmLHycXdIKSy1sjhT;

internal sealed class Ai3xtDHyXEfq3el8VjlP
{
	private long Bid;

	private long Ask;

	private long JUUHyESkRYU;

	private long gpPHyQtLr17;

	public DateTime Time;

	public DateTime OpenTime;

	public DateTime CloseTime;

	public long WT4Hydamaer;

	public long ocgHygQL53j;

	public long aMKHyRo2BUc;

	public long Close;

	public long KcWHy6OudXg;

	public long fcnHyMI3Ecm;

	public long lP0HyOXMq3O;

	public long CI4HyqWu69E;

	public long OpenPos;

	public long AmEHyIifxoV;

	public long CLXHyWqXcuh;

	public Dictionary<long, BJtE02HytsgECDGsyUU4> Items;

	private static Ai3xtDHyXEfq3el8VjlP d6FLbBDq8HN8QU7DQiZr;

	public Ai3xtDHyXEfq3el8VjlP(DateTime P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		Items = new Dictionary<long, BJtE02HytsgECDGsyUU4>();
		base._002Ector();
		Time = P_0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal void tEXHyj5d92E(YrSXmVHTFktGXlDx147H P_0, int P_1)
	{
		long num = ((P_1 > 1) ? ScaleValue(P_0.mPRHynleDCG, P_1) : P_0.mPRHynleDCG);
		if (Items.Count != 0)
		{
			ocgHygQL53j = Math.Max(ocgHygQL53j, num);
			aMKHyRo2BUc = HNG1FtDqJMNTg4meyePy(aMKHyRo2BUc, num);
			goto IL_011c;
		}
		int num2 = 10;
		goto IL_0009;
		IL_0009:
		BJtE02HytsgECDGsyUU4 bJtE02HytsgECDGsyUU = default(BJtE02HytsgECDGsyUU4);
		while (true)
		{
			switch (num2)
			{
			case 9:
				bJtE02HytsgECDGsyUU.Sd2HyCo9Wbh++;
				goto IL_0253;
			case 4:
				bJtE02HytsgECDGsyUU = Items[num];
				num2 = 5;
				continue;
			case 5:
				if (P_0.oZXHyonkMXM == BfOPPuHyv8PQM9MdOwif.Sell)
				{
					Bid += P_0.Size;
					JUUHyESkRYU++;
					num2 = 2;
					continue;
				}
				goto case 3;
			case 11:
				return;
			default:
				if (!Items.ContainsKey(num))
				{
					Items.Add(num, new BJtE02HytsgECDGsyUU4(num));
					num2 = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b17e829e94d54e7b87d666edd5b38bcd == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 4;
			case 3:
				if (P_0.oZXHyonkMXM == BfOPPuHyv8PQM9MdOwif.Buy)
				{
					int num3 = 7;
					num2 = num3;
					continue;
				}
				goto IL_0253;
			case 12:
				ocgHygQL53j = num;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				OpenTime = P_0.Time;
				WT4Hydamaer = num;
				num2 = 12;
				continue;
			case 7:
				Ask += P_0.Size;
				gpPHyQtLr17++;
				num2 = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
				{
					num2 = 6;
				}
				continue;
			case 2:
				bJtE02HytsgECDGsyUU.Bid += P_0.Size;
				bJtE02HytsgECDGsyUU.thSHyVbl7Ce++;
				goto IL_0253;
			case 8:
				Close = num;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
				{
					num2 = 0;
				}
				continue;
			case 1:
				break;
			case 6:
				{
					bJtE02HytsgECDGsyUU.Ask += P_0.Size;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
					{
						num2 = 9;
					}
					continue;
				}
				IL_0253:
				KcWHy6OudXg = Math.Max(KcWHy6OudXg, Ask - Bid);
				fcnHyMI3Ecm = Math.Min(fcnHyMI3Ecm, Ask - Bid);
				num2 = 11;
				continue;
			}
			break;
		}
		aMKHyRo2BUc = num;
		goto IL_011c;
		IL_011c:
		CloseTime = P_0.Time;
		num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
		{
			num2 = 8;
		}
		goto IL_0009;
	}

	private static long ScaleValue(long value, int scale)
	{
		return (value + value % scale) / scale;
	}

	static Ai3xtDHyXEfq3el8VjlP()
	{
		nE1YxfDqFFbN5c7y9d5w();
	}

	internal static bool dFJJMpDqAKXJdZF0negq()
	{
		return d6FLbBDq8HN8QU7DQiZr == null;
	}

	internal static Ai3xtDHyXEfq3el8VjlP WK5R9PDqPTGaZlP9oeUD()
	{
		return d6FLbBDq8HN8QU7DQiZr;
	}

	internal static long HNG1FtDqJMNTg4meyePy(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void nE1YxfDqFFbN5c7y9d5w()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
