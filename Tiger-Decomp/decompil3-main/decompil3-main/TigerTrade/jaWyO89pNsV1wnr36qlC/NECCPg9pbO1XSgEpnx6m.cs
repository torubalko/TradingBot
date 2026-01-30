using System.Runtime.CompilerServices;
using ABxgvYHyUBReVTOnCgrh;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace jaWyO89pNsV1wnr36qlC;

internal sealed class NECCPg9pbO1XSgEpnx6m : IRawClusterItem
{
	[CompilerGenerated]
	private long d8W9pEtSkHt;

	[CompilerGenerated]
	private long suF9pQpvtpr;

	[CompilerGenerated]
	private long OPw9pdCVZTy;

	[CompilerGenerated]
	private int RFt9pghSeuG;

	[CompilerGenerated]
	private int iPc9pRgiFMt;

	[CompilerGenerated]
	private long Wgb9p6y3UR2;

	[CompilerGenerated]
	private long Olv9pMa9sU8;

	[CompilerGenerated]
	private long dZ99pOhP8Sm;

	[CompilerGenerated]
	private long G5U9pqYwSRn;

	internal static NECCPg9pbO1XSgEpnx6m gKyfPHbmTvnPj7mbiFjn;

	public long Price
	{
		[CompilerGenerated]
		get
		{
			return d8W9pEtSkHt;
		}
		[CompilerGenerated]
		set
		{
			d8W9pEtSkHt = num;
		}
	}

	public long Bid
	{
		[CompilerGenerated]
		get
		{
			return suF9pQpvtpr;
		}
		[CompilerGenerated]
		set
		{
			suF9pQpvtpr = num;
		}
	}

	public long Ask
	{
		[CompilerGenerated]
		get
		{
			return OPw9pdCVZTy;
		}
		[CompilerGenerated]
		set
		{
			OPw9pdCVZTy = oPw9pdCVZTy;
		}
	}

	public int BidTrades
	{
		[CompilerGenerated]
		get
		{
			return RFt9pghSeuG;
		}
		[CompilerGenerated]
		set
		{
			RFt9pghSeuG = rFt9pghSeuG;
		}
	}

	public int AskTrades
	{
		[CompilerGenerated]
		get
		{
			return iPc9pRgiFMt;
		}
		[CompilerGenerated]
		set
		{
			iPc9pRgiFMt = num;
		}
	}

	public long OpenPosBid
	{
		[CompilerGenerated]
		get
		{
			return Wgb9p6y3UR2;
		}
		[CompilerGenerated]
		set
		{
			Wgb9p6y3UR2 = wgb9p6y3UR;
		}
	}

	public long OpenPosAsk
	{
		[CompilerGenerated]
		get
		{
			return Olv9pMa9sU8;
		}
		[CompilerGenerated]
		set
		{
			Olv9pMa9sU8 = olv9pMa9sU;
		}
	}

	public long Volume => Ask + Bid;

	public long Delta => Ask - Bid;

	public int Trades => AskTrades + BidTrades;

	public long OpenPos => OpenPosBid + OpenPosAsk;

	public long BidQuote
	{
		[CompilerGenerated]
		get
		{
			return dZ99pOhP8Sm;
		}
		[CompilerGenerated]
		set
		{
			dZ99pOhP8Sm = num;
		}
	}

	public long AskQuote
	{
		[CompilerGenerated]
		get
		{
			return G5U9pqYwSRn;
		}
		[CompilerGenerated]
		set
		{
			G5U9pqYwSRn = g5U9pqYwSRn;
		}
	}

	public long VolumeQuote => AskQuote + BidQuote;

	public long DeltaQuote => AskQuote - BidQuote;

	public NECCPg9pbO1XSgEpnx6m(long P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Price = P_0;
	}

	public NECCPg9pbO1XSgEpnx6m(BJtE02HytsgECDGsyUU4 P_0)
	{
		l7lkHobmVGAnGd1Inikg();
		base._002Ector();
		Price = P_0.kt5HyTQHYFD;
		Fbf9pkH35yC(P_0);
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

	public NECCPg9pbO1XSgEpnx6m(NECCPg9pbO1XSgEpnx6m P_0)
	{
		l7lkHobmVGAnGd1Inikg();
		base._002Ector();
		Price = P_0.Price;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Rib9p1Y650c(P_0);
	}

	public void Fbf9pkH35yC(BJtE02HytsgECDGsyUU4 P_0)
	{
		Bid += P_0.Bid;
		Ask += P_0.Ask;
		BidTrades += P_0.thSHyVbl7Ce;
		AskTrades += P_0.Sd2HyCo9Wbh;
		OpenPosBid += P_0.HLKHyrsbDms;
		OpenPosAsk += P_0.Pe6HyKSV4d0;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				BidQuote += P_0.b6XHyyvHEfX;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				AskQuote += P_0.Ks1HyZcxorY;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Rib9p1Y650c(NECCPg9pbO1XSgEpnx6m P_0)
	{
		Bid += HbobMabmCjXRgbEuZpBe(P_0);
		Ask += P_0.Ask;
		BidTrades += jjZkP5bmryoV2UY0HyEi(P_0);
		AskTrades += zZAwTWbmKGon1QvkVLPg(P_0);
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				OpenPosBid += P_0.OpenPosBid;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				OpenPosAsk += P_0.OpenPosAsk;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				BidQuote += ICx0X2bmmiFAC9U1ZI1w(P_0);
				AskQuote += nC0nQWbmhC3Yc0CiOiJ6(P_0);
				return;
			}
		}
	}

	static NECCPg9pbO1XSgEpnx6m()
	{
		rr5YEybmwivxWL0mbVQc();
	}

	internal static bool nRkVY3bmysx0WgkIkole()
	{
		return gKyfPHbmTvnPj7mbiFjn == null;
	}

	internal static NECCPg9pbO1XSgEpnx6m cwMbwTbmZuhmTk1xAG8B()
	{
		return gKyfPHbmTvnPj7mbiFjn;
	}

	internal static void l7lkHobmVGAnGd1Inikg()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static long HbobMabmCjXRgbEuZpBe(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).Bid;
	}

	internal static int jjZkP5bmryoV2UY0HyEi(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).BidTrades;
	}

	internal static int zZAwTWbmKGon1QvkVLPg(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).AskTrades;
	}

	internal static long ICx0X2bmmiFAC9U1ZI1w(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).BidQuote;
	}

	internal static long nC0nQWbmhC3Yc0CiOiJ6(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).AskQuote;
	}

	internal static void rr5YEybmwivxWL0mbVQc()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
