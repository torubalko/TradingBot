using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Connectors.Simulator.Player;
using TigerTrade.Tc.Data;
using TigerTrade.Tc.History;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Common;

public sealed class MarketDataWrapper
{
	internal static MarketDataWrapper vl7KV8x7g4muI8Nallff;

	public MarketDataType Type { get; }

	public object Data { get; }

	public bool NoCheck { get; }

	public ConnectionInfo Source { get; }

	public MarketDataWrapper(Security security, ConnectionInfo source)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		Type = MarketDataType.Security;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Source = source;
				return;
			case 1:
				Data = security;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public MarketDataWrapper(MarketDepth marketDepth, ConnectionInfo source)
	{
		woiTL1x7Msai0FMCbZa2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Source = source;
				return;
			}
			Type = MarketDataType.MarketDepth;
			Data = marketDepth;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ef27acefa2ec42e3b6a221f6d82bbbc0 == 0)
			{
				num = 1;
			}
		}
	}

	public MarketDataWrapper(Tick tick, ConnectionInfo source)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Source = source;
				return;
			case 1:
				Type = MarketDataType.Tick;
				Data = tick;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public MarketDataWrapper(TicksResponce responce, ConnectionInfo source)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Type = MarketDataType.Ticks;
				Data = responce;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
				{
					num = 0;
				}
				break;
			default:
				Source = source;
				return;
			}
		}
	}

	public MarketDataWrapper(BarsResponce responce, ConnectionInfo source)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		Type = MarketDataType.Bars;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Data = responce;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
				{
					num = 0;
				}
				break;
			default:
				Source = source;
				return;
			}
		}
	}

	public MarketDataWrapper(HistoryPlayerState state)
	{
		woiTL1x7Msai0FMCbZa2();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				NoCheck = true;
				return;
			case 1:
				Type = MarketDataType.PlayerState;
				Data = state;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_20e7e617d0f34403acbdcd4eaa1fe0e9 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public MarketDataWrapper(HistoryPlayerStats stats)
	{
		woiTL1x7Msai0FMCbZa2();
		base._002Ector();
		Type = MarketDataType.PlayerStats;
		Data = stats;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d != 0)
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
				NoCheck = true;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static MarketDataWrapper()
	{
		X2HMlwx7Of25QbUKjvdF();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool X1gnK3x7R5vyDY7C3lTM()
	{
		return vl7KV8x7g4muI8Nallff == null;
	}

	internal static MarketDataWrapper qVuXTDx76H9CXPifXQco()
	{
		return vl7KV8x7g4muI8Nallff;
	}

	internal static void woiTL1x7Msai0FMCbZa2()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static void X2HMlwx7Of25QbUKjvdF()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
