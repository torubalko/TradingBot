using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Time;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Portfolio
{
	private string _portfolioID;

	internal static Portfolio MwmkCJ5urP9M1Kj3vBRI;

	public ConnectionInfo Connection { get; }

	public string ConnectionID { get; }

	internal string UniqueID { get; }

	public string Name { get; set; }

	public string Currency { get; set; }

	public string Register { get; set; }

	public int? Leverage { get; set; }

	public double Balance { get; set; }

	public double UsedMargin { get; set; }

	public double FreeMargin { get; set; }

	public double? UnrealizedPnl { get; set; }

	public double? RealizedPnl { get; set; }

	public double? Comission { get; set; }

	public int Precision { get; set; }

	public double? BalanceUsd { get; set; }

	public DateTime? Time { get; set; }

	public bool SkipPosition { get; set; }

	public string PortfolioID
	{
		get
		{
			return _portfolioID;
		}
		set
		{
			_portfolioID = value;
		}
	}

	public Portfolio(ConnectionInfo connection, string uniqueID)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		_portfolioID = "";
		base._002Ector();
		Connection = connection;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				_portfolioID = (string)oJKU6E5uh5NV8wHuClJb(ConnectionID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1153206687 ^ -1153199233), UniqueID);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
				{
					num = 2;
				}
				continue;
			case 2:
				return;
			}
			ConnectionID = connection.ConnectionID;
			UniqueID = uniqueID;
			Precision = 2;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
			{
				num = 1;
			}
		}
	}

	public string Print()
	{
		return (string)GApErq5uw1KYdRg19FoG(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73942A4C), Currency, Balance, Time.UnixMs());
	}

	public override string ToString()
	{
		return Name;
	}

	static Portfolio()
	{
		OJVEnK5u7EAptiRCIeFr();
		mp9DD15u8kHArnSOSH7E();
	}

	internal static bool JWtwkI5uKymSxmD8GrOC()
	{
		return MwmkCJ5urP9M1Kj3vBRI == null;
	}

	internal static Portfolio ldkduD5um42lQr0YuBUW()
	{
		return MwmkCJ5urP9M1Kj3vBRI;
	}

	internal static object oJKU6E5uh5NV8wHuClJb(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object GApErq5uw1KYdRg19FoG(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static void OJVEnK5u7EAptiRCIeFr()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void mp9DD15u8kHArnSOSH7E()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
