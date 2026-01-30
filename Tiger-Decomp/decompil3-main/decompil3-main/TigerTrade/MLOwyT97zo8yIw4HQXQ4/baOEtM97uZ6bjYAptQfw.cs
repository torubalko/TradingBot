using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace MLOwyT97zo8yIw4HQXQ4;

internal sealed class baOEtM97uZ6bjYAptQfw : IChartClusterMaxValues
{
	private readonly IRawClusterMaxValues zYK9805TEac;

	private readonly decimal xkg982NqgBn;

	private readonly decimal UXA98HB5KF5;

	private static baOEtM97uZ6bjYAptQfw s4Uri8bVzFDGldIAT3tc;

	public decimal MaxBid => OKQQHRbC980d49gM0Clc(JgyVJHbCfri8DDs5Ysia(tB2qjRbCHYw3DGLuANtC(zYK9805TEac)), UXA98HB5KF5);

	public decimal MaxAsk => OKQQHRbC980d49gM0Clc(xFOHiFbCntJWkQo4cfYZ(zYK9805TEac), UXA98HB5KF5);

	public decimal MaxVolume => OKQQHRbC980d49gM0Clc(JgyVJHbCfri8DDs5Ysia(nSlfVybCGecDRDCAoabW(zYK9805TEac)), UXA98HB5KF5);

	public int MaxTrades => zYK9805TEac.MaxTrades;

	public decimal MaxDelta => (decimal)zYK9805TEac.MaxDelta * UXA98HB5KF5;

	public decimal MinDelta => JgyVJHbCfri8DDs5Ysia(zYK9805TEac.MinDelta) * UXA98HB5KF5;

	public long MaxOpenPos => WCUZyhbCYHuoS5VrrTFJ(zYK9805TEac);

	public long MinOpenPos => zYK9805TEac.MinOpenPos;

	public decimal Poc => (decimal)zYK9805TEac.Poc * xkg982NqgBn;

	public baOEtM97uZ6bjYAptQfw(IRawClusterMaxValues P_0, decimal P_1, decimal P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				zYK9805TEac = P_0;
				xkg982NqgBn = P_1;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c1a63437a5bc4d139ae2c4a2f19ec947 != 0)
				{
					num = 0;
				}
				break;
			default:
				UXA98HB5KF5 = P_2;
				return;
			}
		}
	}

	static baOEtM97uZ6bjYAptQfw()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static long tB2qjRbCHYw3DGLuANtC(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxBid;
	}

	internal static decimal JgyVJHbCfri8DDs5Ysia(long P_0)
	{
		return P_0;
	}

	internal static decimal OKQQHRbC980d49gM0Clc(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static bool RTFxd6bC0akECnBOyNfl()
	{
		return s4Uri8bVzFDGldIAT3tc == null;
	}

	internal static baOEtM97uZ6bjYAptQfw y7j0UYbC2ycm1ohZR5aP()
	{
		return s4Uri8bVzFDGldIAT3tc;
	}

	internal static long xFOHiFbCntJWkQo4cfYZ(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxAsk;
	}

	internal static long nSlfVybCGecDRDCAoabW(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}

	internal static long WCUZyhbCYHuoS5VrrTFJ(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxOpenPos;
	}
}
