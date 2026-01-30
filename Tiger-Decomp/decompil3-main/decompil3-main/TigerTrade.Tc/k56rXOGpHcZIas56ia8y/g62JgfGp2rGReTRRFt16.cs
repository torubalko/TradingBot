using System.Runtime.CompilerServices;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using lFFs11G39ohaRVknaFPC;
using LPq3llG3QX4HMCBL7b1Q;
using tpDLBrGJAci5JWh2s4im;
using x97CE55GhEYKgt7TSVZT;

namespace k56rXOGpHcZIas56ia8y;

public sealed class g62JgfGp2rGReTRRFt16 : anI4lfGJ8TTwhTlujQ36
{
	[CompilerGenerated]
	private long? L72Gpl6pOmy;

	[CompilerGenerated]
	private long? gSvGp4eo31K;

	[CompilerGenerated]
	private long? vc8GpDSJCFN;

	private static g62JgfGp2rGReTRRFt16 arvdrx5A2fXTsrguxDS5;

	public long? BidPrice
	{
		[CompilerGenerated]
		get
		{
			return L72Gpl6pOmy;
		}
		[CompilerGenerated]
		private set
		{
			L72Gpl6pOmy = l72Gpl6pOmy;
		}
	}

	public long? AskPrice
	{
		[CompilerGenerated]
		get
		{
			return gSvGp4eo31K;
		}
		[CompilerGenerated]
		private set
		{
			gSvGp4eo31K = num;
		}
	}

	public long? LastPrice
	{
		[CompilerGenerated]
		get
		{
			return vc8GpDSJCFN;
		}
		[CompilerGenerated]
		private set
		{
			vc8GpDSJCFN = num;
		}
	}

	public void fuUGpf2fvak(SecurityEvent P_0)
	{
		AskPrice = ((P_0.AskPrice > 0) ? P_0.AskPrice : AskPrice);
		BidPrice = ((P_0.BidPrice > 0) ? P_0.BidPrice : BidPrice);
		LastPrice = ((P_0.LastPrice > 0) ? P_0.LastPrice : LastPrice);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public void TYKGp9ASNfS(MarketDepthFullEvent P_0)
	{
		AskPrice = P_0.BestAskPrice;
		BidPrice = P_0.BestBidPrice;
	}

	public void GeFGpnx3wDN(TickEvent P_0)
	{
		LastPrice = P_0.Price;
	}

	public bool KJ8GpGGsKiV()
	{
		if (LastPrice.HasValue)
		{
			long? num = BidPrice;
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return num.HasValue;
				}
				if (!num.HasValue)
				{
					break;
				}
				num = AskPrice;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 == 0)
				{
					num2 = 1;
				}
			}
		}
		return false;
	}

	public override bool dqLlndlurqO()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				BidPrice = null;
				LastPrice = null;
				return true;
			case 1:
				AskPrice = null;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public g62JgfGp2rGReTRRFt16()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static g62JgfGp2rGReTRRFt16()
	{
		WefLZ75A9p4lle7gIju6();
		UMIJbK5An07vNFGGBEHb();
	}

	internal static bool ul9Xhp5AH1NPxnl6kWaT()
	{
		return arvdrx5A2fXTsrguxDS5 == null;
	}

	internal static g62JgfGp2rGReTRRFt16 mEADi85Afr1E5AkBM4KC()
	{
		return arvdrx5A2fXTsrguxDS5;
	}

	internal static void WefLZ75A9p4lle7gIju6()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void UMIJbK5An07vNFGGBEHb()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
