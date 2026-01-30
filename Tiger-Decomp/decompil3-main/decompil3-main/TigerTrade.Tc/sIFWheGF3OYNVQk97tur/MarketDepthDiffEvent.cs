using System.Collections.Generic;
using System.Runtime.CompilerServices;
using amKgk7GJqUGhPrEY71aU;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using nI0iklG3L4EXgsHYE0T1;
using TigerTrade.Tc.Data;
using tpDLBrGJAci5JWh2s4im;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace sIFWheGF3OYNVQk97tur;

public class MarketDepthDiffEvent : anI4lfGJ8TTwhTlujQ36
{
	protected readonly Dictionary<long, long> WcsG30XNwUn;

	protected readonly Dictionary<long, long> iQsG32Ssypy;

	[CompilerGenerated]
	private int N3rG3HlkJsq;

	[CompilerGenerated]
	private syh8dIG3xetxRkGYZ5kB rRxG3fnxEyE;

	internal static MarketDepthDiffEvent jKccQA58T64pjYSkTMZf;

	public int LastPing
	{
		[CompilerGenerated]
		get
		{
			return N3rG3HlkJsq;
		}
		[CompilerGenerated]
		internal set
		{
			N3rG3HlkJsq = n3rG3HlkJsq;
		}
	}

	public syh8dIG3xetxRkGYZ5kB Version
	{
		[CompilerGenerated]
		get
		{
			return rRxG3fnxEyE;
		}
		[CompilerGenerated]
		internal set
		{
			rRxG3fnxEyE = syh8dIG3xetxRkGYZ5kB;
		}
	}

	public IReadOnlyDictionary<long, long> Bids => WcsG30XNwUn;

	public IReadOnlyDictionary<long, long> Asks => iQsG32Ssypy;

	public MarketDepthDiffEvent()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		WcsG30XNwUn = new Dictionary<long, long>();
		iQsG32Ssypy = new Dictionary<long, long>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal virtual void YlHloi6rCYj(long P_0, long P_1)
	{
		HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(WcsG30XNwUn, P_0, P_1);
	}

	internal virtual void AcdlolmAx8M(long P_0, long P_1)
	{
		HgPkxwGJOat6QIA5PDSs.Gi6GJWptHb5(iQsG32Ssypy, P_0, P_1);
	}

	internal MarketDepthDiffEvent eGrGFpMbqyA(Symbol P_0)
	{
		MarketDepthDiffEvent marketDepthDiffEvent = IlvHiXGF9pA6U4gUK5bq.NWmGFbytOIy(P_0);
		marketDepthDiffEvent.Symbol = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				E5AEti58V9SgUJQZco5o(marketDepthDiffEvent, Version);
				using (Dictionary<long, long>.Enumerator enumerator = iQsG32Ssypy.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<long, long> current = enumerator.Current;
						marketDepthDiffEvent.iQsG32Ssypy[current.Key] = current.Value;
					}
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					case 0:
						break;
					}
				}
				foreach (KeyValuePair<long, long> item in WcsG30XNwUn)
				{
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					marketDepthDiffEvent.WcsG30XNwUn[item.Key] = item.Value;
				}
				goto case 2;
			}
			case 2:
				return marketDepthDiffEvent;
			default:
				marketDepthDiffEvent.LastPing = LastPing;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool dqLlndlurqO()
	{
		iQsG32Ssypy.Clear();
		WcsG30XNwUn.Clear();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				LastPing = 0;
				Version = null;
				return true;
			case 1:
				base.Symbol = null;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static MarketDepthDiffEvent()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool WPDd8P58y4pV9HdF7jR3()
	{
		return jKccQA58T64pjYSkTMZf == null;
	}

	internal static MarketDepthDiffEvent OkoLI658ZPBfXu2TPHKi()
	{
		return jKccQA58T64pjYSkTMZf;
	}

	internal static void E5AEti58V9SgUJQZco5o(object P_0, object P_1)
	{
		((MarketDepthDiffEvent)P_0).Version = (syh8dIG3xetxRkGYZ5kB)P_1;
	}
}
