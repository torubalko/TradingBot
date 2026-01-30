using System;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

[DataContract(Name = "UserDeal", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Storage")]
public sealed class UserDeal : ICloneable
{
	internal static UserDeal TFsmAD53QgTVYbqg2pXI;

	[DataMember(Name = "DealID")]
	public string DealID { get; set; }

	[DataMember(Name = "SymbolID")]
	public string SymbolID { get; set; }

	[DataMember(Name = "SymbolName")]
	public string SymbolName { get; set; }

	[DataMember(Name = "AccountID")]
	public string AccountID { get; set; }

	[DataMember(Name = "AccountName")]
	public string AccountName { get; set; }

	[DataMember(Name = "OpenTime")]
	public DateTime OpenTime { get; set; }

	[DataMember(Name = "OpenPrice")]
	public double OpenPrice { get; set; }

	[DataMember(Name = "CloseTime")]
	public DateTime CloseTime { get; set; }

	[DataMember(Name = "ClosePrice")]
	public double ClosePrice { get; set; }

	[DataMember(Name = "Side")]
	public Side Side { get; set; }

	[DataMember(Name = "Contracts")]
	public double Quantity { get; set; }

	[DataMember(Name = "MaxContracts")]
	public double MaxQuantity { get; set; }

	[DataMember(Name = "TotalValue")]
	public double TotalValue { get; set; }

	[DataMember(Name = "Points")]
	public double Points { get; set; }

	[DataMember(Name = "Profit")]
	public double Profit { get; set; }

	[DataMember(Name = "Comission")]
	public double Comission { get; set; }

	[DataMember(Name = "Tags")]
	public string Tags { get; set; }

	[DataMember(Name = "Description")]
	public string Description { get; set; }

	[DataMember(Name = "LocalTime")]
	public DateTime LocalTime { get; set; }

	[DataMember(Name = "IsMt5TimeValid")]
	public bool IsMt5TimeValid { get; set; }

	public bool IsPlayer => AccountID.StartsWith((string)PPafhS53RWI08eLjtsEl(0x42D899B5 ^ 0x42D83F69));

	public bool IsSimulator => AccountID.StartsWith((string)PPafhS53RWI08eLjtsEl(0x446AB724 ^ 0x446A68B4));

	public bool IsLive
	{
		get
		{
			if (!IsPlayer)
			{
				return !IsSimulator;
			}
			return false;
		}
	}

	public UserDeal()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		DealID = Guid.NewGuid().ToString();
		IsMt5TimeValid = true;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public object Clone()
	{
		return MemberwiseClone();
	}

	static UserDeal()
	{
		sh4Ykd536dH7scyJJnl7();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool hsnSOB53dAXnqGjbL2oQ()
	{
		return TFsmAD53QgTVYbqg2pXI == null;
	}

	internal static UserDeal ny75W853gfFy3wh0Zn37()
	{
		return TFsmAD53QgTVYbqg2pXI;
	}

	internal static object PPafhS53RWI08eLjtsEl(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void sh4Ykd536dH7scyJJnl7()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
