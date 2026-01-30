using System;
using System.Runtime.CompilerServices;
using ECOEgqlSad8NUJZ2Dr9n;
using jaWyO89pNsV1wnr36qlC;
using TigerTrade.Chart.Data;
using TuAMtrl1Nd3XoZQQUXf0;

namespace bGbKcM9ATU5Unk2KEfOW;

internal sealed class afH9fo9AUdcyVd3GvuCB : IRawClusterMaxValues
{
	[CompilerGenerated]
	private long ffD9A3HbXMu;

	[CompilerGenerated]
	private long jvd9App7whT;

	[CompilerGenerated]
	private long USd9AuGZ6Hh;

	[CompilerGenerated]
	private int P589AzZPkKe;

	[CompilerGenerated]
	private long BKL9P0HbFMM;

	[CompilerGenerated]
	private long XZe9P2aES8G;

	[CompilerGenerated]
	private long pb39PH1h1YS;

	[CompilerGenerated]
	private long Fyd9PfVmOsy;

	[CompilerGenerated]
	private long QH09P94ubf7;

	[CompilerGenerated]
	private long u0b9PnKo7hq;

	[CompilerGenerated]
	private long Ju39PGijKwA;

	[CompilerGenerated]
	private long pct9PYAP5kg;

	[CompilerGenerated]
	private long pqN9Po01kEs;

	[CompilerGenerated]
	private long gxL9PvrZMJi;

	internal static afH9fo9AUdcyVd3GvuCB PUMOuEbKnjx6Edf9JvxV;

	public long MaxBid
	{
		[CompilerGenerated]
		get
		{
			return ffD9A3HbXMu;
		}
		[CompilerGenerated]
		private set
		{
			ffD9A3HbXMu = num;
		}
	}

	public long MaxAsk
	{
		[CompilerGenerated]
		get
		{
			return jvd9App7whT;
		}
		[CompilerGenerated]
		private set
		{
			jvd9App7whT = num;
		}
	}

	public long MaxVolume
	{
		[CompilerGenerated]
		get
		{
			return USd9AuGZ6Hh;
		}
		[CompilerGenerated]
		private set
		{
			USd9AuGZ6Hh = uSd9AuGZ6Hh;
		}
	}

	public int MaxTrades
	{
		[CompilerGenerated]
		get
		{
			return P589AzZPkKe;
		}
		[CompilerGenerated]
		private set
		{
			P589AzZPkKe = p589AzZPkKe;
		}
	}

	public long MaxDelta
	{
		[CompilerGenerated]
		get
		{
			return BKL9P0HbFMM;
		}
		[CompilerGenerated]
		private set
		{
			BKL9P0HbFMM = bKL9P0HbFMM;
		}
	}

	public long MinDelta
	{
		[CompilerGenerated]
		get
		{
			return XZe9P2aES8G;
		}
		[CompilerGenerated]
		private set
		{
			XZe9P2aES8G = xZe9P2aES8G;
		}
	}

	public long MaxOpenPos
	{
		[CompilerGenerated]
		get
		{
			return pb39PH1h1YS;
		}
		[CompilerGenerated]
		private set
		{
			pb39PH1h1YS = num;
		}
	}

	public long MinOpenPos
	{
		[CompilerGenerated]
		get
		{
			return Fyd9PfVmOsy;
		}
		[CompilerGenerated]
		private set
		{
			Fyd9PfVmOsy = fyd9PfVmOsy;
		}
	}

	public long Poc
	{
		[CompilerGenerated]
		get
		{
			return QH09P94ubf7;
		}
		[CompilerGenerated]
		private set
		{
			QH09P94ubf7 = qH09P94ubf;
		}
	}

	public long MaxBidQuote
	{
		[CompilerGenerated]
		get
		{
			return u0b9PnKo7hq;
		}
		[CompilerGenerated]
		private set
		{
			u0b9PnKo7hq = num;
		}
	}

	public long MaxAskQuote
	{
		[CompilerGenerated]
		get
		{
			return Ju39PGijKwA;
		}
		[CompilerGenerated]
		private set
		{
			Ju39PGijKwA = ju39PGijKwA;
		}
	}

	public long MaxVolumeQuote
	{
		[CompilerGenerated]
		get
		{
			return pct9PYAP5kg;
		}
		[CompilerGenerated]
		private set
		{
			pct9PYAP5kg = num;
		}
	}

	public long MaxDeltaQuote
	{
		[CompilerGenerated]
		get
		{
			return pqN9Po01kEs;
		}
		[CompilerGenerated]
		private set
		{
			pqN9Po01kEs = num;
		}
	}

	public long MinDeltaQuote
	{
		[CompilerGenerated]
		get
		{
			return gxL9PvrZMJi;
		}
		[CompilerGenerated]
		private set
		{
			gxL9PvrZMJi = num;
		}
	}

	public void VC09Ay0RAsN(NECCPg9pbO1XSgEpnx6m P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 6:
				Poc = P_0.Price;
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				if (P_0.Trades > MaxTrades)
				{
					MaxTrades = gnQv4RbKBD8BM2jDM8fL(P_0);
					num2 = 5;
					break;
				}
				goto case 5;
			case 7:
				MaxOpenPos = Math.Max(MaxOpenPos, joRN5pbKabniuqj2xgwx(P_0));
				MinOpenPos = v0r7xybKiPDCF0q9HWwC(MinOpenPos, P_0.OpenPos);
				MaxDeltaQuote = Math.Max(MaxDeltaQuote, MNd8YTbKlTt0do5gPaWF(P_0));
				MinDeltaQuote = Math.Min(MinDeltaQuote, MNd8YTbKlTt0do5gPaWF(P_0));
				return;
			case 0:
				return;
			case 2:
				if (P_0.Volume > MaxVolume)
				{
					MaxVolume = P_0.Volume;
					MaxVolumeQuote = P_0.VolumeQuote;
					num2 = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 3:
				MaxBid = lVTgLLbKvpK9NgYjuu0M(P_0);
				num2 = 4;
				break;
			case 5:
				MaxDelta = Math.Max(MaxDelta, P_0.Delta);
				MinDelta = Math.Min(MinDelta, P_0.Delta);
				num2 = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				if (P_0 != null)
				{
					if (P_0.Ask > MaxAsk)
					{
						MaxAsk = Wn7IOobKoCdtMBu5w1YR(P_0);
						MaxAskQuote = P_0.AskQuote;
					}
					if (P_0.Bid > MaxBid)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				MaxBidQuote = P_0.BidQuote;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public afH9fo9AUdcyVd3GvuCB()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static afH9fo9AUdcyVd3GvuCB()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool HA1epybKGEbvf3MrsHrq()
	{
		return PUMOuEbKnjx6Edf9JvxV == null;
	}

	internal static afH9fo9AUdcyVd3GvuCB HOospjbKYbCNk4uBOJBi()
	{
		return PUMOuEbKnjx6Edf9JvxV;
	}

	internal static long Wn7IOobKoCdtMBu5w1YR(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).Ask;
	}

	internal static long lVTgLLbKvpK9NgYjuu0M(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).Bid;
	}

	internal static int gnQv4RbKBD8BM2jDM8fL(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).Trades;
	}

	internal static long joRN5pbKabniuqj2xgwx(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).OpenPos;
	}

	internal static long v0r7xybKiPDCF0q9HWwC(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static long MNd8YTbKlTt0do5gPaWF(object P_0)
	{
		return ((NECCPg9pbO1XSgEpnx6m)P_0).DeltaQuote;
	}
}
