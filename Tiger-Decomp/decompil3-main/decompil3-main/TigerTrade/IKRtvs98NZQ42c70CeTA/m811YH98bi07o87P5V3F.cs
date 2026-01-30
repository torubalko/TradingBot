using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace IKRtvs98NZQ42c70CeTA;

internal sealed class m811YH98bi07o87P5V3F : IChartClusterItem
{
	private readonly IRawClusterItem fFX98ktu33R;

	private readonly decimal Pbh9816TJdB;

	private readonly decimal eHi985PcKdO;

	private static m811YH98bi07o87P5V3F aQC9fqbCMZ2xrLGQWic7;

	public decimal Price => (decimal)fFX98ktu33R.Price * Pbh9816TJdB;

	public decimal Bid => dfl0oPbCIxf4qf6cxIDB(fFX98ktu33R.Bid) * eHi985PcKdO;

	public decimal Ask => NFeuksbCtx3A0AbBnWZ2(dfWu4FbCW6P8WJ4TKqd3(fFX98ktu33R), eHi985PcKdO);

	public int BidTrades => fFX98ktu33R.BidTrades;

	public int AskTrades => fFX98ktu33R.AskTrades;

	public long OpenPosBid => tB0AJUbCUrVp1yvajk2M(fFX98ktu33R);

	public long OpenPosAsk => zeCiySbCTkssuitPFrat(fFX98ktu33R);

	public decimal Volume => dfl0oPbCIxf4qf6cxIDB(iL1gCdbCyxKIjTkYAYym(fFX98ktu33R)) * eHi985PcKdO;

	public decimal Delta => (decimal)fFX98ktu33R.Delta * eHi985PcKdO;

	public int Trades => zXrT3VbCZAbKVPFgvtxJ(fFX98ktu33R);

	public long OpenPos => fFX98ktu33R.OpenPos;

	public m811YH98bi07o87P5V3F(IRawClusterItem P_0, decimal P_1, decimal P_2)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				eHi985PcKdO = P_2;
				return;
			}
			fFX98ktu33R = P_0;
			Pbh9816TJdB = P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
			{
				num = 0;
			}
		}
	}

	static m811YH98bi07o87P5V3F()
	{
		qF36XtbCVty2dr4emtip();
	}

	internal static bool WiAR2CbCOkGqqj82avSf()
	{
		return aQC9fqbCMZ2xrLGQWic7 == null;
	}

	internal static m811YH98bi07o87P5V3F b5B6aPbCqVmN7QNsVEcN()
	{
		return aQC9fqbCMZ2xrLGQWic7;
	}

	internal static decimal dfl0oPbCIxf4qf6cxIDB(long P_0)
	{
		return P_0;
	}

	internal static long dfWu4FbCW6P8WJ4TKqd3(object P_0)
	{
		return ((IRawClusterItem)P_0).Ask;
	}

	internal static decimal NFeuksbCtx3A0AbBnWZ2(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static long tB0AJUbCUrVp1yvajk2M(object P_0)
	{
		return ((IRawClusterItem)P_0).OpenPosBid;
	}

	internal static long zeCiySbCTkssuitPFrat(object P_0)
	{
		return ((IRawClusterItem)P_0).OpenPosAsk;
	}

	internal static long iL1gCdbCyxKIjTkYAYym(object P_0)
	{
		return ((IRawClusterItem)P_0).Volume;
	}

	internal static int zXrT3VbCZAbKVPFgvtxJ(object P_0)
	{
		return ((IRawClusterItem)P_0).Trades;
	}

	internal static void qF36XtbCVty2dr4emtip()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
