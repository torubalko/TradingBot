using System;
using System.Collections;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Common;
using WvFZ4RY0BtLmwaWPAUqv;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Order
{
	private static long _localOrderID;

	internal static Order N1SSA75uE7nQHc6rtjS2;

	internal long NumCookie { get; set; }

	internal string StrCookie { get; set; }

	public string ID { get; }

	public string OrderID { get; internal set; }

	public string TransID { get; internal set; }

	public Symbol Symbol { get; }

	public Account Account { get; }

	public OrderType Type { get; set; }

	public OrderState State { get; set; }

	public OrderValidity Validity { get; set; }

	public DateTime Time { get; set; }

	public long Price { get; set; }

	public long StopPrice { get; set; }

	public long TakePrice { get; set; }

	public long Quantity { get; set; }

	public double QuantityReal { get; set; }

	public long? DisplayQty { get; set; }

	public long Filled { get; set; }

	public long Remaining { get; set; }

	public double? AvgFillPrice { get; set; }

	public Side Side { get; set; }

	public string Comment { get; set; }

	public Hashtable Options { get; }

	public OrderModifyParams ModifyParams { get; set; }

	public RoundTrip RoundTrip { get; }

	public int RetryCounter { get; set; }

	public bool PosClose { get; set; }

	public bool SlTpClose { get; set; }

	internal bool Invisible { get; set; }

	public string PlaceInitiator { get; set; }

	public string ModifyInitiator { get; set; }

	public string CancelInitiator { get; set; }

	public bool IsSplicedFuturesSymbol { get; private set; }

	internal bool Error { get; set; }

	internal bool InCancel { get; set; }

	internal bool InModify { get; set; }

	internal bool SlTp { get; set; }

	internal bool Tp { get; set; }

	internal string TrustID { get; set; }

	internal bool TrustExclude { get; set; }

	internal int TakeSpread { get; set; }

	internal DateTime Timestamp { get; set; }

	internal long Timestamp2 { get; set; }

	internal ul2RZ6Y0vkIC8SNHSaDb Spread { get; set; }

	public ConnectionInfo Connection => (ConnectionInfo)tSBBlq5ugeO5AeJLsaBw(Account);

	public bool IsActive
	{
		get
		{
			if (State != OrderState.Wait)
			{
				return State == OrderState.Active;
			}
			return true;
		}
	}

	public bool IsInactive
	{
		get
		{
			if (State != OrderState.Canceled)
			{
				return State == OrderState.Completed;
			}
			return true;
		}
	}

	public Order(Symbol symbol, Account account)
	{
		gxaKGO5uRDSTY0m7TFLA();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				RoundTrip = new RoundTrip();
				Validity = OrderValidity.Day;
				Options = new Hashtable();
				IsSplicedFuturesSymbol = mkmpGd5uMhh2lbnvHt1n(symbol);
				return;
			case 2:
				Symbol = symbol.GetSymbol();
				Account = account;
				ID = Guid.NewGuid().ToString();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a != 0)
				{
					num = 1;
				}
				break;
			case 1:
				if (symbol.Exchange == (string)m9agXp5u6sghUBmsJVoC(-1848952786 ^ -1848908010))
				{
					num = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 != 0)
					{
						num = 3;
					}
					break;
				}
				goto default;
			case 3:
				ID = ID.Replace(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4297C3EB ^ 0x42972929), "");
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public Order(Symbol symbol, Account account, Hashtable options)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector(symbol, account);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		AddOptions(options);
	}

	private void AddOptions(Hashtable options)
	{
		if (options == null)
		{
			return;
		}
		IDictionaryEnumerator enumerator = options.GetEnumerator();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		try
		{
			while (enumerator.MoveNext())
			{
				DictionaryEntry dictionaryEntry = (DictionaryEntry)nNAcAN5uODDaxVKKDv1W(enumerator);
				Options.Add(dictionaryEntry.Key, dictionaryEntry.Value);
			}
			int num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 == 0)
			{
				num2 = 0;
			}
			switch (num2)
			{
			case 0:
				break;
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				int num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					disposable.Dispose();
					break;
				}
			}
		}
	}

	internal void SetOrderOffset(long price)
	{
		double? num = (double?)Options[F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461292091 ^ -1461288613)];
		bool flag = (bool)Options[m9agXp5u6sghUBmsJVoC(0x20B584D2 ^ 0x20B5767C)];
		int num2 = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
		{
			num2 = 0;
		}
		long num3 = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Price = price;
				if (num.HasValue)
				{
					num3 = (flag ? ((long)(Math.Round((double)price * num.Value / Symbol.Step / 100.0, MidpointRounding.AwayFromZero) * Symbol.Step)) : ((long)num.Value));
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
					{
						num2 = 2;
					}
				}
				break;
			case 2:
				return;
			default:
				Price += ((Side != Side.Sell) ? 1 : (-1)) * num3;
				return;
			}
		}
	}

	internal static string GetLocalID()
	{
		long num = ++_localOrderID;
		return num.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-5977659 ^ -6017943));
	}

	internal string Print()
	{
		return (string)tRjywY5uqQUogftbXcvC(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894947332), new object[8]
		{
			OrderID,
			TransID,
			NumCookie,
			StrCookie,
			Symbol?.Name,
			Account?.Name,
			Type,
			State
		}) + string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4220DA8 ^ 0x422FEDE), Time, Price, StopPrice, Quantity, Filled, Remaining, Side, YrU6Sx5uIKeUsq6Y65qD(RoundTrip));
	}

	internal string PrintPlace()
	{
		return (string)tRjywY5uqQUogftbXcvC(m9agXp5u6sghUBmsJVoC(0x7F55E538 ^ 0x7F55110C), new object[7]
		{
			Symbol?.Name,
			Account?.Name,
			Type,
			Side,
			Price,
			StopPrice,
			Quantity
		}) + string.Format((string)m9agXp5u6sghUBmsJVoC(-57768881 ^ -57773925), DisplayQty, PosClose, Validity, PlaceInitiator) + string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380569412), Symbol.Step, Symbol.SizeStep, Symbol.ContractValue);
	}

	internal string PrintModify()
	{
		return string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1047165041 ^ -1047170485), Symbol?.Name, Account?.Name, OrderID, Type, Side, Price, ModifyParams?.Price) + string.Format((string)m9agXp5u6sghUBmsJVoC(0x60620FC1 ^ 0x6062F991), StopPrice, ModifyParams?.StopPrice, Quantity, ModifyParams?.Quantity, DisplayQty) + string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841434907), Remaining, Validity, ModifyInitiator);
	}

	internal string PrintCancel()
	{
		return (string)JXc95A5uWHk2I8PC2vhJ(string.Format((string)m9agXp5u6sghUBmsJVoC(--855742383 ^ 0x330160A9), Symbol?.Name, Account?.Name, OrderID, Type, Side, Price, StopPrice, Quantity), string.Format(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB158FD4), DisplayQty, Remaining, Validity, CancelInitiator));
	}

	internal bool CanCancel()
	{
		if (!InCancel)
		{
			return IsActive;
		}
		return false;
	}

	internal bool CanModify()
	{
		if (!InModify)
		{
			return IsActive;
		}
		return false;
	}

	internal bool IsReduceOnly()
	{
		if (Options.ContainsKey(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894950134)))
		{
			return (bool)IvEpN55ut9Jm2EsAdT1K(Options, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xB15786A ^ 0xB15804C));
		}
		return false;
	}

	static Order()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool scWqkX5uQAeOocfqvtMt()
	{
		return N1SSA75uE7nQHc6rtjS2 == null;
	}

	internal static Order XnPS6L5ud6NSi2Zjva4W()
	{
		return N1SSA75uE7nQHc6rtjS2;
	}

	internal static object tSBBlq5ugeO5AeJLsaBw(object P_0)
	{
		return ((Account)P_0).Connection;
	}

	internal static void gxaKGO5uRDSTY0m7TFLA()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object m9agXp5u6sghUBmsJVoC(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool mkmpGd5uMhh2lbnvHt1n(object P_0)
	{
		return ((Symbol)P_0).IsSplicedFutures;
	}

	internal static object nNAcAN5uODDaxVKKDv1W(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object tRjywY5uqQUogftbXcvC(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static int YrU6Sx5uIKeUsq6Y65qD(object P_0)
	{
		return ((RoundTrip)P_0).Value;
	}

	internal static object JXc95A5uWHk2I8PC2vhJ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object IvEpN55ut9Jm2EsAdT1K(object P_0, object P_1)
	{
		return ((Hashtable)P_0)[P_1];
	}
}
