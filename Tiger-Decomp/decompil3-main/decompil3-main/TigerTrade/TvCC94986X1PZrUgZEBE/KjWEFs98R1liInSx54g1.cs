using System;
using bQeLQJ9JVIVGlOu9BJva;
using ECOEgqlSad8NUJZ2Dr9n;
using Io0TBCnnT6SonDXm9K0y;
using TigerTrade.Chart.Data;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TvCC94986X1PZrUgZEBE;

internal sealed class KjWEFs98R1liInSx54g1 : IChartTick
{
	private readonly KHxL9R9JZMZ1sv2HFY9P kt198MCAbkw;

	private readonly decimal L7A98OpZxwx;

	private readonly decimal K4998qTNX7v;

	private readonly int lWw98IgCInX;

	internal static KjWEFs98R1liInSx54g1 wCmgqsbroP1iupumox7o;

	public DateTime Time => A9qRu2briJ6E7qCoq2xr(kt198MCAbkw);

	public decimal Price => (decimal)MI4nfsnnUf3PYtFXkT2T.zaMnnyYmoGU(kt198MCAbkw.Price, lWw98IgCInX) * L7A98OpZxwx;

	public decimal Size => r4qB4HbrDG33jqNjWHyW(HB06sFbr4TicMupxHPgJ(Renh1kbrlc2GohWhXHB4(kt198MCAbkw)), K4998qTNX7v);

	public long OpenInterest => kt198MCAbkw.OpenInterest;

	public bool IsBuy => TNnclWbrb72DOZSGEx1f(kt198MCAbkw) == Side.Buy;

	public KjWEFs98R1liInSx54g1(KHxL9R9JZMZ1sv2HFY9P P_0, decimal P_1, decimal P_2, int P_3)
	{
		IY2HiVbraDZsMxFF76Tq();
		base._002Ector();
		kt198MCAbkw = P_0;
		L7A98OpZxwx = P_1;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				lWw98IgCInX = P_3;
				return;
			case 1:
				K4998qTNX7v = P_2;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static KjWEFs98R1liInSx54g1()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void IY2HiVbraDZsMxFF76Tq()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool CUBAlFbrvO45Efj00QjI()
	{
		return wCmgqsbroP1iupumox7o == null;
	}

	internal static KjWEFs98R1liInSx54g1 XZiZHObrBdmqXQZ3kyh4()
	{
		return wCmgqsbroP1iupumox7o;
	}

	internal static DateTime A9qRu2briJ6E7qCoq2xr(object P_0)
	{
		return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Time;
	}

	internal static long Renh1kbrlc2GohWhXHB4(object P_0)
	{
		return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Size;
	}

	internal static decimal HB06sFbr4TicMupxHPgJ(long P_0)
	{
		return P_0;
	}

	internal static decimal r4qB4HbrDG33jqNjWHyW(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static Side TNnclWbrb72DOZSGEx1f(object P_0)
	{
		return ((KHxL9R9JZMZ1sv2HFY9P)P_0).Side;
	}
}
