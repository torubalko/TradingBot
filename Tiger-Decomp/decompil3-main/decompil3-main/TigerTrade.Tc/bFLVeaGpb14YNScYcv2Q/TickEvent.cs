using System;
using System.Runtime.CompilerServices;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using tpDLBrGJAci5JWh2s4im;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace bFLVeaGpb14YNScYcv2Q;

public sealed class TickEvent : anI4lfGJ8TTwhTlujQ36
{
	[CompilerGenerated]
	private DateTime ApcGpkdJhYw;

	[CompilerGenerated]
	private long CSIGp183LpZ;

	[CompilerGenerated]
	private long teFGp5mquyn;

	[CompilerGenerated]
	private long X93GpSZHFUk;

	[CompilerGenerated]
	private long swMGpxNhnni;

	[CompilerGenerated]
	private long WNUGpLDkyDH;

	[CompilerGenerated]
	private long jwIGpeJwKci;

	[CompilerGenerated]
	private Side VIBGpsGSi8F;

	[CompilerGenerated]
	private long PDlGpX1bmwb;

	[CompilerGenerated]
	private long p5lGpcE1NSQ;

	[CompilerGenerated]
	private string JsmGpjKTgVY;

	[CompilerGenerated]
	private string tttGpEp6F46;

	[CompilerGenerated]
	private bool tMhGpQqpfMl;

	private static TickEvent W1Y3Yx5AGlfgFJXtCrtg;

	public DateTime Time
	{
		[CompilerGenerated]
		get
		{
			return ApcGpkdJhYw;
		}
		[CompilerGenerated]
		set
		{
			ApcGpkdJhYw = apcGpkdJhYw;
		}
	}

	public long Price
	{
		[CompilerGenerated]
		get
		{
			return CSIGp183LpZ;
		}
		[CompilerGenerated]
		set
		{
			CSIGp183LpZ = cSIGp183LpZ;
		}
	}

	public long Size
	{
		[CompilerGenerated]
		get
		{
			return teFGp5mquyn;
		}
		[CompilerGenerated]
		set
		{
			teFGp5mquyn = num;
		}
	}

	public long Bid
	{
		[CompilerGenerated]
		get
		{
			return X93GpSZHFUk;
		}
		[CompilerGenerated]
		set
		{
			X93GpSZHFUk = x93GpSZHFUk;
		}
	}

	public long BidSize
	{
		[CompilerGenerated]
		get
		{
			return swMGpxNhnni;
		}
		[CompilerGenerated]
		set
		{
			swMGpxNhnni = num;
		}
	}

	public long Ask
	{
		[CompilerGenerated]
		get
		{
			return WNUGpLDkyDH;
		}
		[CompilerGenerated]
		set
		{
			WNUGpLDkyDH = wNUGpLDkyDH;
		}
	}

	public long AskSize
	{
		[CompilerGenerated]
		get
		{
			return jwIGpeJwKci;
		}
		[CompilerGenerated]
		set
		{
			jwIGpeJwKci = num;
		}
	}

	public Side Side
	{
		[CompilerGenerated]
		get
		{
			return VIBGpsGSi8F;
		}
		[CompilerGenerated]
		set
		{
			VIBGpsGSi8F = vIBGpsGSi8F;
		}
	}

	public long OpenInterest
	{
		[CompilerGenerated]
		get
		{
			return PDlGpX1bmwb;
		}
		[CompilerGenerated]
		set
		{
			PDlGpX1bmwb = pDlGpX1bmwb;
		}
	}

	public long MarketCenter
	{
		[CompilerGenerated]
		get
		{
			return p5lGpcE1NSQ;
		}
		[CompilerGenerated]
		set
		{
			p5lGpcE1NSQ = num;
		}
	}

	public string Market
	{
		[CompilerGenerated]
		get
		{
			return JsmGpjKTgVY;
		}
		[CompilerGenerated]
		set
		{
			JsmGpjKTgVY = jsmGpjKTgVY;
		}
	}

	public string Conditions
	{
		[CompilerGenerated]
		get
		{
			return tttGpEp6F46;
		}
		[CompilerGenerated]
		set
		{
			tttGpEp6F46 = text;
		}
	}

	public bool NotQualified
	{
		[CompilerGenerated]
		get
		{
			return tMhGpQqpfMl;
		}
		[CompilerGenerated]
		set
		{
			tMhGpQqpfMl = flag;
		}
	}

	public long SizeQuote => Size * Price;

	public TickEvent kvAGpNSUxb2(Symbol P_0)
	{
		TickEvent tickEvent = IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY(P_0);
		tickEvent.Symbol = P_0;
		pcVcjp5AvTpXSUHCsxbe(tickEvent, Time);
		tickEvent.Price = Price;
		q84MPB5ABW12GDWZGBDp(tickEvent, Size);
		tickEvent.Bid = Bid;
		jVGSPM5AavqrDRc1fpd1(tickEvent, BidSize);
		Q1wraY5Ai4fWUT3a9wCR(tickEvent, Ask);
		tickEvent.AskSize = AskSize;
		tickEvent.Side = Side;
		Ctjln25AlOWq12AUkBvF(tickEvent, OpenInterest);
		ubRknO5A4674e4VVKatN(tickEvent, MarketCenter);
		tickEvent.Market = Market;
		N3H9qU5AD7pREHsYigfH(tickEvent, Conditions);
		tickEvent.NotQualified = NotQualified;
		return tickEvent;
	}

	public override bool dqLlndlurqO()
	{
		base.Symbol = null;
		Time = default(DateTime);
		Price = 0L;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Ask = 0L;
				AskSize = 0L;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				Size = 0L;
				Bid = 0L;
				num = 4;
				break;
			default:
				NotQualified = false;
				return true;
			case 2:
				Side = Side.Buy;
				OpenInterest = 0L;
				MarketCenter = 0L;
				num = 5;
				break;
			case 4:
				BidSize = 0L;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
				{
					num = 1;
				}
				break;
			case 5:
				Market = null;
				Conditions = null;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public TickEvent()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static TickEvent()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		RCmVX05Ablc8JncobyQw();
	}

	internal static bool fjtY8a5AYeAwUdYiC5UL()
	{
		return W1Y3Yx5AGlfgFJXtCrtg == null;
	}

	internal static TickEvent U0xKAD5Ao0gxc7vT57Xc()
	{
		return W1Y3Yx5AGlfgFJXtCrtg;
	}

	internal static void pcVcjp5AvTpXSUHCsxbe(object P_0, DateTime P_1)
	{
		((TickEvent)P_0).Time = P_1;
	}

	internal static void q84MPB5ABW12GDWZGBDp(object P_0, long P_1)
	{
		((TickEvent)P_0).Size = P_1;
	}

	internal static void jVGSPM5AavqrDRc1fpd1(object P_0, long P_1)
	{
		((TickEvent)P_0).BidSize = P_1;
	}

	internal static void Q1wraY5Ai4fWUT3a9wCR(object P_0, long P_1)
	{
		((TickEvent)P_0).Ask = P_1;
	}

	internal static void Ctjln25AlOWq12AUkBvF(object P_0, long P_1)
	{
		((TickEvent)P_0).OpenInterest = P_1;
	}

	internal static void ubRknO5A4674e4VVKatN(object P_0, long P_1)
	{
		((TickEvent)P_0).MarketCenter = P_1;
	}

	internal static void N3H9qU5AD7pREHsYigfH(object P_0, object P_1)
	{
		((TickEvent)P_0).Conditions = (string)P_1;
	}

	internal static void RCmVX05Ablc8JncobyQw()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
