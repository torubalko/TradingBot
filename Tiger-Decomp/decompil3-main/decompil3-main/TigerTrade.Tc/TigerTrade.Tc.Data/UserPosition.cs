using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using EyD6NKGhRYBSlyBqPfrJ;
using IqjG5RGpM8HpdaZSkjjx;
using jSIOgkGu0P3Y4vrBGi9s;
using JWHT9dacY6lGeDQXkL4K;
using K1GcsD5GTtMSlaiJI0Xh;
using LgG2iaajiPaPidMEDVBM;
using mLJY4pY2D5OUPvF9bslY;
using NIkKPXGuH9wBj6WnkSjx;
using OmxnJ7Gu9rHTQUtTbB9M;
using RRGeI95GVMJEHGH0bnkl;
using rU0ObGGuLGgrPU67U4H0;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

[DataContract(Name = "UserPosition", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Storage")]
public sealed class UserPosition : ICloneable
{
	private ExitStrategy _strategy;

	private List<uioCmvGp6sXANp11eX6R> _executions;

	private ApidlOGpzEFH7ruf5jBr? _priceStrategy;

	private n94DQwGu2NVuNQEJYC0O _positionPriceStrategy;

	internal static UserPosition xpQ1Yy53MduWDmlr6vib;

	public Symbol Symbol { get; internal set; }

	[DataMember(Name = "ConnectionID")]
	public string ConnectionID { get; set; }

	[DataMember(Name = "ConnectionName")]
	public string ConnectionName { get; set; }

	[DataMember(Name = "SymbolID")]
	public string SymbolID { get; set; }

	[DataMember(Name = "SymbolName")]
	public string SymbolName { get; set; }

	[DataMember(Name = "AccountID")]
	public string AccountID { get; set; }

	[DataMember(Name = "AccountName")]
	public string AccountName { get; set; }

	[DataMember(Name = "Price")]
	public long Price { get; set; }

	[DataMember(Name = "PriceSumBig")]
	public BigInteger PriceSum { get; set; }

	[DataMember(Name = "PriceSum")]
	public long PriceSumLong
	{
		get
		{
			return 0L;
		}
		set
		{
			if (value != 0L)
			{
				PriceSum = value;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "Size")]
	public long Size { get; set; }

	[DataMember(Name = "RealSize")]
	public decimal? RealSize { get; set; }

	[DataMember(Name = "SizeStep")]
	public double? SizeStep { get; set; }

	[DataMember(Name = "TotalValueBig")]
	public BigInteger TotalValue { get; set; }

	[DataMember(Name = "TotalValue")]
	public long TotalValueLong
	{
		get
		{
			return 0L;
		}
		set
		{
			if (value != 0L)
			{
				TotalValue = PKQTfF53I4dQvRLJYZ28(value);
			}
		}
	}

	[DataMember(Name = "Contracts")]
	public long TotalQuantity { get; set; }

	[DataMember(Name = "MaxContracts")]
	public long MaxQuantity { get; set; }

	[DataMember(Name = "Comission")]
	public double Comission { get; set; }

	[DataMember(Name = "StartTime")]
	public DateTime StartTime { get; set; }

	[DataMember(Name = "OpenTime")]
	public DateTime OpenTime { get; set; }

	[DataMember(Name = "OpenPrice")]
	public long OpenPrice { get; set; }

	[DataMember(Name = "LastTradeTime")]
	public DateTime LastTradeTime { get; set; }

	[DataMember(Name = "IsMt5TimeValid")]
	public bool IsMt5TimeValid { get; set; }

	[DataMember(Name = "LastTradeIDs")]
	public HashSet<string> LastTradeIDs { get; set; }

	[DataMember(Name = "LastTradeCombinedIDs")]
	public HashSet<string> LastTradeCombinedIDs { get; set; }

	[DataMember(Name = "Hidden")]
	public bool Hidden { get; set; }

	[DataMember(Name = "Strategy")]
	public ExitStrategy Strategy
	{
		get
		{
			return _strategy ?? (_strategy = new ExitStrategy());
		}
		set
		{
			_strategy = value;
		}
	}

	[DataMember(Name = "LastSizeTriggeredStrategy")]
	public long LastSizeTriggeredStrategy { get; set; }

	[DataMember(Name = "Executions")]
	public List<uioCmvGp6sXANp11eX6R> Executions
	{
		get
		{
			return _executions ?? (_executions = new List<uioCmvGp6sXANp11eX6R>());
		}
		set
		{
			_executions = new List<uioCmvGp6sXANp11eX6R>(value);
		}
	}

	[DataMember(Name = "PriceStrategy")]
	public ApidlOGpzEFH7ruf5jBr? PriceStrategy
	{
		get
		{
			return _priceStrategy;
		}
		set
		{
			if (_priceStrategy != value || _positionPriceStrategy == null)
			{
				_priceStrategy = value;
				if (_priceStrategy.HasValue)
				{
					_positionPriceStrategy = RIcas2Guf5AxQ4VFxo19.LATGunEyVj5(_priceStrategy.Value);
				}
			}
		}
	}

	[DataMember(Name = "PnlBig")]
	public BigInteger Pnl { get; set; }

	[DataMember(Name = "Pnl")]
	public long PnlLong
	{
		get
		{
			return 0L;
		}
		set
		{
			if (value != 0L)
			{
				Pnl = value;
			}
		}
	}

	public string PositionID => (string)OEWYWi53WJNxZvR5E5yp(SymbolID, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-520155535 ^ -520098735), AccountID);

	public long LastPrice { get; private set; }

	public long Bid { get; private set; }

	public long Ask { get; private set; }

	public long PositionPnl { get; private set; }

	private double? PositionRealPnl { get; set; }

	public double? PositionRealSizeInQuoteByCurrentPrice { get; set; }

	public double? PositionRealSizeInQuoteByEntryPrice { get; set; }

	public TimeSpan PositionTime { get; private set; }

	internal DateTime NewTradeTime { get; private set; }

	internal bool SecurityIsSubscribed { get; set; }

	internal string TradeClientId { get; set; }

	public UserPosition()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	public UserPosition(ConnectionInfo info, Symbol symbol, Account account)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		ConnectionID = info.ConnectionID;
		int num = 3;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				AccountName = account.Name;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				if (YtFfukajaSr17E52hP4h.d59ajl8LAnH((string)d0siEs53UvSp529yPjQw(symbol)))
				{
					Hidden = true;
				}
				return;
			case 3:
				ConnectionName = info.ConnectionName;
				TradeClientId = (string)Tl4JuY53twPXDUlPMSs0(info);
				Symbol = symbol;
				SymbolID = symbol.ID;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
				{
					num = 4;
				}
				break;
			case 4:
				SymbolName = symbol.Name;
				AccountID = account.AccountID;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				if (!account.HedgeMode)
				{
					return;
				}
				num = 2;
				break;
			}
		}
	}

	internal void AddExecution(Execution execution, out UserDeal deal, out bool updated)
	{
		int num = 4;
		long price = default(long);
		long size = default(long);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 20:
					return;
				default:
					if (LastTradeIDs.Contains(execution.CombinedID))
					{
						num2 = 6;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_320dc241f2414298b90e22a730a02f87 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					if (LastTradeCombinedIDs.Contains(execution.CombinedID))
					{
						return;
					}
					goto case 15;
				case 17:
					LastTradeCombinedIDs.Add(execution.CombinedID);
					goto IL_029f;
				case 7:
					price = Price;
					if (size != 0L)
					{
						goto IL_01a6;
					}
					goto case 14;
				case 6:
					return;
				case 8:
					PositionRealPnl = null;
					PositionTime = TimeSpan.FromMilliseconds(0.0);
					return;
				case 10:
					if (LastTradeCombinedIDs.Contains(execution.CombinedID))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					if (!wLodGY53VJ64TbZ6WAlE(R334q953ZsCOI6B8qnHr(execution)))
					{
						num = 9;
						break;
					}
					goto IL_029f;
				case 4:
					deal = null;
					num2 = 3;
					continue;
				case 11:
					if (size == 0L && Size != 0L)
					{
						num2 = 12;
						continue;
					}
					if (Math.Sign(Size) != axNP2r53wqjNRNLLk684(size))
					{
						num2 = 18;
						continue;
					}
					goto IL_0085;
				case 3:
					updated = false;
					if (!o2fJY853TIbSgPm7Nj9f(execution))
					{
						if (!IyVpIQ53yaOkcYJHjxuc(execution))
						{
							num2 = 19;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
							{
								num2 = 17;
							}
							continue;
						}
						goto IL_029f;
					}
					num2 = 20;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
					{
						num2 = 19;
					}
					continue;
				case 2:
					LastTradeIDs.Add((string)B7kyXD53mQxfcGEGNpJF(execution));
					num2 = 17;
					continue;
				case 13:
					if (((Symbol)ENX6Xx53KwtvFRav8Lcc(execution)).Type == SymbolType.Crypto)
					{
						return;
					}
					num2 = 10;
					continue;
				case 12:
				case 18:
					Strategy.Clear();
					goto IL_0085;
				case 15:
					LastTradeTime = dateTime;
					num = 2;
					break;
				case 1:
					Hidden = false;
					num2 = 11;
					continue;
				case 5:
					if (LastTradeCombinedIDs == null)
					{
						LastTradeCombinedIDs = new HashSet<string>();
					}
					if (!(dateTime == LastTradeTime))
					{
						LastTradeIDs.Clear();
						LastTradeCombinedIDs.Clear();
						num2 = 15;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					if (LastTradeIDs.Contains(execution.ExecutionID))
					{
						num2 = 13;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto default;
				case 16:
					if (RBrNw253rYsUGwaPbuhb(dateTime, LastTradeTime))
					{
						return;
					}
					if (LastTradeIDs == null)
					{
						LastTradeIDs = new HashSet<string>();
						num2 = 5;
						continue;
					}
					goto case 5;
				case 14:
					SetPositionPriceStrategy(v1Orcf53hWl3BtXOiQRx());
					goto IL_01a6;
				case 9:
					{
						dateTime = new DateTime(hcTrRj53CJxFOyiGdlSZ(execution).Year, execution.Time.Month, execution.Time.Day, execution.Time.Hour, hcTrRj53CJxFOyiGdlSZ(execution).Minute, 0);
						num2 = 16;
						continue;
					}
					IL_01a6:
					AddExecutionInternal(execution, ref deal);
					if (Size == 0L)
					{
						Strategy.Clear(isClosePosition: true);
						PositionPnl = 0L;
						num2 = 8;
						continue;
					}
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
					{
						num2 = 1;
					}
					continue;
					IL_029f:
					NewTradeTime = TimeHelper.LocalTime;
					updated = true;
					size = Size;
					num2 = 7;
					continue;
					IL_0085:
					UpdateDynamicSlTp(size, price);
					return;
				}
				break;
			}
		}
	}

	private void UpdateDynamicSlTp(long lastSize, long lastPrice)
	{
		int num = 1;
		long num6 = default(long);
		ExitStrategyTarget strategySingleTarget = default(ExitStrategyTarget);
		long num8 = default(long);
		long num3 = default(long);
		long num9 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num4;
				long num7;
				long num5;
				switch (num2)
				{
				default:
					return;
				case 12:
					if (Price == lastPrice)
					{
						return;
					}
					goto IL_019a;
				case 11:
					return;
				case 18:
					return;
				case 3:
					num4 = 0L;
					goto IL_044a;
				case 6:
					if (Size < 0)
					{
						return;
					}
					goto IL_0274;
				case 13:
					num6 = ((strategySingleTarget.TakeProfitPrice != 0L) ? (strategySingleTarget.TakeProfitPrice - lastPrice) : 0);
					num2 = 17;
					continue;
				case 15:
					if (lastSize < 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 5:
					num7 = Price - num6;
					goto IL_048c;
				case 17:
					if (strategySingleTarget.StopLossPrice == 0L)
					{
						num2 = 19;
						continue;
					}
					num5 = lastPrice - qt7Y3l5378fsTeZHja1O(strategySingleTarget);
					goto IL_043a;
				case 1:
					if (!Acj0FgGhg83F5A0lfPa4.L6UGhmD0FK9())
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if (Size == lastSize)
					{
						num2 = 12;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto IL_019a;
				case 9:
					return;
				case 14:
					if (strategySingleTarget != null)
					{
						num6 = 0L;
						num2 = 16;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_af030adc5d834c7fa654aaa946f39572 == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 10:
					if (num8 < Ask)
					{
						num2 = 4;
						continue;
					}
					if (Size > 0)
					{
						return;
					}
					goto case 4;
				case 2:
					if (strategySingleTarget.TakeProfitPrice == 0L)
					{
						num2 = 3;
						continue;
					}
					num4 = lastPrice - strategySingleTarget.TakeProfitPrice;
					goto IL_044a;
				case 0:
					return;
				case 7:
					if (num3 != 0L)
					{
						num8 = ((Size > 0) ? (Price - num3) : (Price + num3));
						num = 10;
						break;
					}
					goto IL_0223;
				case 8:
					if (lastSize > 0)
					{
						num2 = 13;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 15;
				case 4:
					if (num8 <= Bid && Size < 0)
					{
						return;
					}
					LogManager.WriteInfo((string)PiEuWX538VWPLp6ubpk3(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x5CD4F15 ^ 0x5CDA02D), new object[5]
					{
						ConnectionName,
						qt7Y3l5378fsTeZHja1O(strategySingleTarget),
						num8,
						SymbolName,
						AccountName
					}));
					yTbs1r53AQ5BG9EC6nAR(strategySingleTarget, num8);
					goto IL_0223;
				case 19:
					num5 = 0L;
					goto IL_043a;
				case 16:
					{
						num3 = 0L;
						num2 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					IL_0223:
					if (num6 == 0L)
					{
						num2 = 18;
						continue;
					}
					if (Size <= 0)
					{
						num2 = 5;
						continue;
					}
					num7 = Price + num6;
					goto IL_048c;
					IL_019a:
					strategySingleTarget = Strategy.GetStrategySingleTarget(create: false);
					num2 = 14;
					continue;
					IL_043a:
					num3 = num5;
					goto case 7;
					IL_044a:
					num6 = num4;
					num3 = ((strategySingleTarget.StopLossPrice != 0L) ? (strategySingleTarget.StopLossPrice - lastPrice) : 0);
					num = 7;
					break;
					IL_048c:
					num9 = num7;
					if (num9 <= Bid && Size > 0)
					{
						return;
					}
					if (num9 >= Ask)
					{
						num2 = 5;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto IL_0274;
					IL_0274:
					LogManager.WriteInfo((string)PiEuWX538VWPLp6ubpk3(HbnyT353PRRpbqLjBn1R(-90307782 ^ -90247972), new object[5]
					{
						ConnectionName,
						Y9VUTD53JYJ73sbTvSnp(strategySingleTarget),
						num9,
						SymbolName,
						AccountName
					}));
					pSbv0Z53Fjv58tErHQLi(strategySingleTarget, num9);
					num2 = 11;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	private void AddExecutionInternal(Execution execution, ref UserDeal deal)
	{
		long num = ((execution.Side == Side.Buy) ? execution.Quantity : (-sLKBGL533wdFMtMbdMBc(execution)));
		int num2 = 35;
		decimal num4 = default(decimal);
		double? num6 = default(double?);
		decimal? num3 = default(decimal?);
		uint num7 = default(uint);
		string text = default(string);
		decimal? num8 = default(decimal?);
		uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R2 = default(uioCmvGp6sXANp11eX6R);
		double num9 = default(double);
		double? num10 = default(double?);
		double num11 = default(double);
		while (true)
		{
			decimal? num5;
			int num12;
			decimal? obj;
			double? num13;
			uioCmvGp6sXANp11eX6R uioCmvGp6sXANp11eX6R;
			switch (num2)
			{
			case 29:
				num4 = (decimal)num6.Value;
				if (num3.HasValue)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 1:
			case 2:
			case 7:
			case 14:
			case 19:
				num6 = execution.Comission;
				num2 = 30;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
				{
					num2 = 12;
				}
				continue;
			case 37:
				return;
			case 23:
				if (num7 <= 2204885439u)
				{
					if (num7 <= 1945420267)
					{
						if (num7 == 1041130325)
						{
							if (text == (string)HbnyT353PRRpbqLjBn1R(0x78D396D8 ^ 0x78D349E0))
							{
								goto default;
							}
						}
						else if (num7 == 1945420267)
						{
							goto case 6;
						}
					}
					else
					{
						if (num7 == 1976993578)
						{
							goto case 9;
						}
						if (num7 == 2132487982)
						{
							goto case 34;
						}
						if (num7 == 2204885439u)
						{
							goto case 25;
						}
					}
					goto case 1;
				}
				goto case 18;
			case 10:
				if (xSgGGP53uiMjA3t3Ub2c(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x3544E813 ^ 0x35444B21)))
				{
					goto default;
				}
				goto case 1;
			case 24:
				if (num6.HasValue)
				{
					num5 = (decimal)(0.0 - num6.GetValueOrDefault());
					goto IL_0883;
				}
				num3 = null;
				num2 = 32;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
				{
					num2 = 2;
				}
				continue;
			case 15:
				if (num8.HasValue)
				{
					num12 = 13;
					goto IL_0005;
				}
				goto IL_010a;
			case 16:
				if (g2Wpbv5p02mRkdq0eEnA(execution) == Side.Buy)
				{
					num2 = 15;
					continue;
				}
				goto IL_010a;
			case 32:
				num5 = num3;
				goto IL_0883;
			case 4:
				obj = null;
				goto IL_08b2;
			case 35:
				if (execution.Side != Side.Buy)
				{
					num6 = execution.RealQuantity;
					num2 = 24;
					continue;
				}
				num6 = execution.RealQuantity;
				if (num6.HasValue)
				{
					num2 = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
					{
						num2 = 27;
					}
					continue;
				}
				num3 = null;
				num5 = num3;
				goto IL_0883;
			case 26:
				if (num7 == 3677625335u)
				{
					if (text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6F7F734B ^ 0x6F7F9A57))
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				}
				num2 = 28;
				continue;
			case 17:
				if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325244069)))
				{
					goto case 1;
				}
				goto default;
			default:
			{
				double comission = Comission;
				num6 = execution.QuoteComission;
				Comission = comission + num6.GetValueOrDefault();
				if (execution.ComissionCurrency == (qIRyR9Y24XhFakDdJT1k)1)
				{
					num2 = 20;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
					{
						num2 = 19;
					}
					continue;
				}
				goto case 22;
			}
			case 34:
				if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1311293279 ^ -1311267727)))
				{
					goto case 1;
				}
				goto default;
			case 9:
				if (!xSgGGP53uiMjA3t3Ub2c(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-5977659 ^ -6001949)))
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			case 18:
				if (num7 <= 3516542306u)
				{
					num2 = 27;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
					{
						num2 = 33;
					}
					continue;
				}
				if (num7 != 3573002156u)
				{
					num12 = 26;
					goto IL_0005;
				}
				goto case 10;
			case 25:
				if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-520155535 ^ -520098575)))
				{
					num12 = 14;
					goto IL_0005;
				}
				goto default;
			case 31:
				if (xSgGGP53uiMjA3t3Ub2c(text, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7B455D)))
				{
					goto default;
				}
				goto case 1;
			case 21:
				if (execution.Time < StartTime || StartTime == default(DateTime))
				{
					uioCmvGp6sXANp11eX6R2.StartTime = execution.Time;
				}
				goto IL_03e7;
			case 11:
				num9 = 0.0;
				text = (string)d0siEs53UvSp529yPjQw(Symbol);
				num7 = fWBs7S53peICXXDpcO4r(text);
				num2 = 23;
				continue;
			case 5:
				num13 = num10;
				break;
			case 8:
				if (!num6.HasValue)
				{
					num10 = null;
					num2 = 5;
					continue;
				}
				num13 = num6.GetValueOrDefault() / num11;
				break;
			case 13:
				num = Symbol.GetMinShortSize(num8.Value);
				goto IL_010a;
			case 28:
				if (num7 != 3777067153u || !(text == (string)HbnyT353PRRpbqLjBn1R(0x7D553BE0 ^ 0x7D55E4C6)))
				{
					goto case 1;
				}
				goto default;
			case 30:
				num11 = execution.Quantity;
				num2 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
				{
					num2 = 8;
				}
				continue;
			case 36:
				num9 = num10.GetValueOrDefault();
				num2 = 22;
				continue;
			case 22:
				if (A48BdF53zP6RAiGCg0YB(Symbol) == SymbolType.Crypto)
				{
					num2 = 16;
					continue;
				}
				goto IL_010a;
			case 33:
				if (num7 != 2618539384u)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
					{
						num2 = 12;
					}
					continue;
				}
				goto case 17;
			case 20:
				num3 = num8;
				num6 = execution.Comission;
				num2 = 29;
				continue;
			case 6:
				if (!(text == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x86EFEF6 ^ 0x86E5DB4)))
				{
					goto case 1;
				}
				goto default;
			case 12:
				if (num7 != 3516542306u)
				{
					goto case 1;
				}
				goto case 31;
			case 27:
				num5 = (decimal)num6.GetValueOrDefault();
				goto IL_0883;
			case 3:
				{
					obj = num3.GetValueOrDefault() - num4;
					goto IL_08b2;
				}
				IL_010a:
				uioCmvGp6sXANp11eX6R = new uioCmvGp6sXANp11eX6R();
				qb7X4S5pHvX7Op6Yggdc(uioCmvGp6sXANp11eX6R, O5SFDL5p2suxy7S9FL7V(execution));
				KBo3WZ5pfBfiEJwPTfmg(uioCmvGp6sXANp11eX6R, TimeHelper.LocalTime);
				uioCmvGp6sXANp11eX6R.OpenTime = hcTrRj53CJxFOyiGdlSZ(execution);
				k3Ddeu5pnZiTlclmger5(uioCmvGp6sXANp11eX6R, b30VrH5p9e7WyW09HYdQ(execution));
				uioCmvGp6sXANp11eX6R.Quantity = num;
				uioCmvGp6sXANp11eX6R.SGpGph7S7WX = num8;
				uioCmvGp6sXANp11eX6R.Y58Gp8qAYyf = num9;
				uioCmvGp6sXANp11eX6R2 = uioCmvGp6sXANp11eX6R;
				if (execution.Connection.TradeClientID == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1878928986))
				{
					num12 = 21;
					goto IL_0005;
				}
				goto IL_03e7;
				IL_0883:
				num8 = num5;
				num2 = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 != 0)
				{
					num2 = 5;
				}
				continue;
				IL_08b2:
				num8 = obj;
				goto case 22;
				IL_03e7:
				Apply(uioCmvGp6sXANp11eX6R2, ref deal);
				num2 = 23;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
				{
					num2 = 37;
				}
				continue;
				IL_0005:
				num2 = num12;
				continue;
			}
			num10 = num13;
			num2 = 23;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
			{
				num2 = 36;
			}
		}
	}

	private void Apply(uioCmvGp6sXANp11eX6R execution, ref UserDeal deal)
	{
		int num = 71;
		long num8 = default(long);
		decimal? num7 = default(decimal?);
		double totalValue2 = default(double);
		double num9 = default(double);
		double points2 = default(double);
		long num10 = default(long);
		uint num3 = default(uint);
		string exchange = default(string);
		Side side = default(Side);
		long totalQuantity2 = default(long);
		long maxQuantity2 = default(long);
		double totalValue = default(double);
		double points = default(double);
		double profit = default(double);
		double comission = default(double);
		decimal? num4 = default(decimal?);
		double num13 = default(double);
		long num11 = default(long);
		long totalQuantity = default(long);
		double profit2 = default(double);
		double comission2 = default(double);
		Side side2 = default(Side);
		long maxQuantity = default(long);
		long num12 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num14;
				double num15;
				switch (num2)
				{
				case 61:
					execution = new uioCmvGp6sXANp11eX6R
					{
						dNwGpW7R045 = execution.dNwGpW7R045,
						OpenTime = execution.OpenTime,
						Price = execution.Price,
						Quantity = num8,
						SGpGph7S7WX = num7,
						Y58Gp8qAYyf = AZAb9c5pBee2VHBvHIx9(execution),
						StartTime = XONO5B5p4KlJSMnxxPrr(execution)
					};
					A9HUHU5pDaOUKHvaTewL(_positionPriceStrategy, this);
					_positionPriceStrategy.New(this, execution);
					StartTime = XONO5B5p4KlJSMnxxPrr(execution);
					OpenTime = execution.OpenTime;
					OpenPrice = execution.Price;
					return;
				case 2:
					totalValue2 = (double)TotalValue * Symbol.GetStepPrice() * num9;
					points2 = lMdJmP5pifHlxTVihI5c(Symbol, num10) * num9;
					num2 = 78;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num2 = 5;
					}
					continue;
				case 26:
					OpenTime = DateTime.MinValue;
					OpenPrice = 0L;
					num2 = 65;
					continue;
				case 62:
					return;
				case 79:
					if (num3 != 1976993578)
					{
						num2 = 60;
						continue;
					}
					goto case 18;
				case 43:
					if (num3 != 665101479)
					{
						if (num3 != 1041130325)
						{
							num2 = 11;
							continue;
						}
						goto case 57;
					}
					if (!(exchange == (string)HbnyT353PRRpbqLjBn1R(-2056710528 ^ -2056651144)))
					{
						num2 = 22;
						continue;
					}
					goto IL_13bf;
				case 18:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1801468030 ^ -1801493340)))
					{
						num2 = 16;
						continue;
					}
					goto case 32;
				case 1:
					if (num3 == 2618539384u)
					{
						goto case 55;
					}
					if (num3 != 3516542306u)
					{
						num2 = 5;
						continue;
					}
					goto case 34;
				case 47:
					if (!(exchange == (string)HbnyT353PRRpbqLjBn1R(0x769C7931 ^ 0x769C9DCB)))
					{
						num2 = 30;
						continue;
					}
					goto IL_13bf;
				case 38:
					if (!(Symbol.Currency == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1878953018 ^ -1878949064)))
					{
						goto IL_0519;
					}
					goto IL_13bf;
				case 15:
				case 16:
				case 23:
				case 24:
				case 35:
				case 37:
				case 42:
				case 67:
				case 75:
				case 81:
					CloseDeal(out deal, side, execution.OpenTime, execution.Price, totalQuantity2, maxQuantity2, totalValue, points, profit, comission);
					num2 = 21;
					continue;
				case 3:
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
					if (num3 > 2132487982)
					{
						if (num3 <= 3516542306u)
						{
							if (num3 != 2204885439u)
							{
								num2 = 77;
								continue;
							}
							if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6E2DFBED ^ 0x6E2D196D)))
							{
								num2 = 7;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
								{
									num2 = 35;
								}
								continue;
							}
							goto case 19;
						}
						if (num3 <= 3670628538u)
						{
							if (num3 == 3573002156u)
							{
								if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1606927328 ^ -1606901998))
								{
									goto case 32;
								}
							}
							else
							{
								if (num3 != 3670628538u)
								{
									num2 = 23;
									continue;
								}
								if (xSgGGP53uiMjA3t3Ub2c(exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F55E538 ^ 0x7F5501C2)))
								{
									goto case 12;
								}
							}
							goto case 15;
						}
						goto case 40;
					}
					num2 = 80;
					continue;
				case 6:
					if (!Symbol.IsOkxX)
					{
						num2 = 8;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto IL_13a5;
				default:
					num4 = RealSize;
					num = 59;
					break;
				case 71:
					if (_positionPriceStrategy == null)
					{
						num2 = 70;
						continue;
					}
					goto case 53;
				case 46:
					if (!xSgGGP53uiMjA3t3Ub2c(exchange, HbnyT353PRRpbqLjBn1R(-1380525184 ^ -1380568420)))
					{
						goto case 15;
					}
					goto case 32;
				case 31:
					if (Comission == 0.0)
					{
						num2 = 15;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c == 0)
						{
							num2 = 74;
						}
						continue;
					}
					goto IL_09e0;
				case 74:
					if (AZAb9c5pBee2VHBvHIx9(execution) != 0.0)
					{
						Comission += execution.Y58Gp8qAYyf * num13;
					}
					goto IL_09e0;
				case 9:
					return;
				case 14:
					num10 = (long)Pnl;
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					_positionPriceStrategy = RIcas2Guf5AxQ4VFxo19.LATGunEyVj5(PriceStrategy.GetValueOrDefault());
					num2 = 47;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
					{
						num2 = 53;
					}
					continue;
				case 21:
					_positionPriceStrategy.Remove(this, execution);
					num2 = 62;
					continue;
				case 55:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225780027)))
					{
						num2 = 72;
						continue;
					}
					goto IL_0519;
				case 53:
					num9 = (Symbol.IsDenomination ? Symbol.ContractValue : wKJqaR5poCmfFV4QA1EF(Symbol));
					num2 = 27;
					continue;
				case 36:
					if (num3 != 2132487982)
					{
						num2 = 13;
						continue;
					}
					if (xSgGGP53uiMjA3t3Ub2c(exchange, HbnyT353PRRpbqLjBn1R(-342738082 ^ -342696050)))
					{
						goto IL_0519;
					}
					goto case 5;
				case 34:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-671204305 ^ -671164257)))
					{
						num2 = 7;
						continue;
					}
					goto IL_0519;
				case 57:
					if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-60853733 ^ -60838621))
					{
						goto IL_0519;
					}
					goto case 5;
				case 73:
					if (Size < 0)
					{
						num2 = 48;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto IL_0291;
				case 32:
				case 45:
				case 50:
				case 51:
					comission = Comission;
					num2 = 15;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
					{
						num2 = 3;
					}
					continue;
				case 82:
					if (num3 != 207070566)
					{
						num2 = 43;
						continue;
					}
					if (!xSgGGP53uiMjA3t3Ub2c(exchange, HbnyT353PRRpbqLjBn1R(0x28B345BB ^ 0x28B3AFA7)))
					{
						goto case 5;
					}
					goto IL_13bf;
				case 39:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x11D1040B ^ 0x11D1ECF3)))
					{
						num = 67;
						break;
					}
					goto case 12;
				case 60:
					if (num3 != 2132487982)
					{
						goto case 15;
					}
					goto case 54;
				case 17:
					if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1763895751 ^ -1763854981))
					{
						num2 = 35;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4b62428db63649d1b023deac83179573 != 0)
						{
							num2 = 45;
						}
						continue;
					}
					goto case 15;
				case 4:
					if (num3 != 1945420267)
					{
						num2 = 79;
						continue;
					}
					goto case 17;
				case 29:
					if (Symbol.IsOKX)
					{
						goto IL_13a5;
					}
					num14 = Symbol.LotStep;
					goto IL_13b0;
				case 19:
					if ((string)HVut1D5pNdq01rXOVHSW(Symbol) == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD5484D))
					{
						num = 12;
						break;
					}
					goto case 32;
				case 68:
					if (_positionPriceStrategy is HIpyYGGux8yDt3ZakUAG)
					{
						side = ((Size <= 0) ? Side.Sell : Side.Buy);
						BigInteger bigInteger = TotalValue + KJfAWQ5pb0otuBUOGjJ3(PKQTfF53I4dQvRLJYZ28(execution.Price), Math.Abs(bGu1Oy5paPL5b9ZouRwi(execution)));
						totalQuantity2 = Math.Abs(bGu1Oy5paPL5b9ZouRwi(execution)) * 2;
						maxQuantity2 = Math.Abs(execution.Quantity);
						num11 = (Price - zjv1955pl3OT4ct0T5rw(execution)) * bGu1Oy5paPL5b9ZouRwi(execution);
						totalValue = (double)bigInteger * Symbol.GetStepPrice() * num9;
						num2 = 69;
						continue;
					}
					goto case 21;
				case 33:
					totalQuantity = TotalQuantity;
					num2 = 52;
					continue;
				case 44:
					if (exchange == (string)HbnyT353PRRpbqLjBn1R(-176525661 ^ -176501279))
					{
						goto IL_0519;
					}
					goto case 5;
				case 25:
					comission = Comission;
					num2 = 24;
					continue;
				case 27:
					num8 = Size + execution.Quantity;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 != 0)
					{
						num2 = 0;
					}
					continue;
				case 56:
					SizeStep = Symbol.SizeStep;
					if (Size != 0L)
					{
						num13 = Math.Abs(Size);
						num2 = 18;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto IL_086f;
				case 80:
					if (num3 > 1041130325)
					{
						goto case 4;
					}
					if (num3 == 207070566)
					{
						if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-624753169 ^ -624693261)))
						{
							goto case 15;
						}
						goto case 12;
					}
					if (num3 != 665101479)
					{
						num2 = 28;
						continue;
					}
					goto case 39;
				case 58:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1EFE0A28 ^ 0x1EFED50E)))
					{
						goto case 5;
					}
					goto IL_0519;
				case 76:
					StartTime = DateTime.MinValue;
					num2 = 26;
					continue;
				case 40:
					if (num3 != 3677625335u)
					{
						if (num3 == 3777067153u && xSgGGP53uiMjA3t3Ub2c(exchange, HbnyT353PRRpbqLjBn1R(-991861155 ^ -991839877)))
						{
							num = 32;
							break;
						}
						goto case 15;
					}
					goto case 46;
				case 77:
					if (num3 == 2618539384u)
					{
						if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380565144))
						{
							goto case 32;
						}
					}
					else if (num3 == 3516542306u && xSgGGP53uiMjA3t3Ub2c(exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-176525661 ^ -176518637)))
					{
						num2 = 28;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
						{
							num2 = 50;
						}
						continue;
					}
					goto case 15;
				case 78:
					profit2 = (double)num10 * Symbol.GetStepPrice() * num9;
					comission2 = 0.0;
					exchange = Symbol.Exchange;
					num3 = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(exchange);
					if (num3 > 2132487982)
					{
						if (num3 > 3516542306u)
						{
							goto case 64;
						}
						if (num3 != 2204885439u)
						{
							num2 = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 != 0)
							{
								num2 = 1;
							}
							continue;
						}
						if (exchange == (string)HbnyT353PRRpbqLjBn1R(0x741B85CB ^ 0x741B674B))
						{
							num2 = 17;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
							{
								num2 = 38;
							}
							continue;
						}
					}
					else
					{
						if (num3 <= 1041130325)
						{
							num2 = 82;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
							{
								num2 = 45;
							}
							continue;
						}
						if (num3 == 1945420267)
						{
							goto case 44;
						}
						if (num3 != 1976993578)
						{
							num2 = 36;
							continue;
						}
						if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2BD86B18 ^ 0x2BD8C83E))
						{
							goto IL_0519;
						}
					}
					goto case 5;
				case 28:
					if (num3 != 1041130325 || !(exchange == (string)HbnyT353PRRpbqLjBn1R(0x28B345BB ^ 0x28B39A83)))
					{
						goto case 15;
					}
					goto case 32;
				case 5:
				case 7:
				case 10:
				case 11:
				case 13:
				case 22:
				case 30:
				case 72:
				case 83:
					CloseDeal(out deal, side2, execution.OpenTime, execution.Price, totalQuantity, maxQuantity, totalValue2, points2, profit2, comission2);
					num2 = 22;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_78f2003ea86d4a38b55c210d3b84bb0e == 0)
					{
						num2 = 41;
					}
					continue;
				case 63:
					num12 = PceuLL5pv9AIVkG2B7q0(num8);
					num = 6;
					break;
				case 69:
					points = Symbol.GetRealPrice(num11) * num9;
					profit = (double)num11 * Symbol.GetStepPrice() * num9;
					comission = 0.0;
					num2 = 66;
					continue;
				case 65:
					_positionPriceStrategy.Clear(this);
					goto IL_086f;
				case 49:
					comission2 = Comission;
					goto case 5;
				case 54:
					if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x706541F3 ^ 0x7065A523)))
					{
						num2 = 75;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 32;
				case 48:
					if (Size < num8)
					{
						num2 = 68;
						continue;
					}
					goto IL_0291;
				case 66:
					exchange = Symbol.Exchange;
					num2 = 3;
					continue;
				case 20:
					if (exchange == (string)HbnyT353PRRpbqLjBn1R(-2108526692 ^ -2108502866))
					{
						goto IL_0519;
					}
					goto case 5;
				case 59:
				{
					decimal valueOrDefault = num4.GetValueOrDefault();
					decimal? num5 = execution.SGpGph7S7WX;
					decimal? num6;
					if (!num5.HasValue)
					{
						num4 = null;
						num6 = num4;
					}
					else
					{
						num6 = valueOrDefault + num5.GetValueOrDefault();
					}
					num7 = num6;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
					{
						num2 = 63;
					}
					continue;
				}
				case 41:
					RealSize = null;
					Comission = 0.0;
					num = 76;
					break;
				case 52:
					maxQuantity = MaxQuantity;
					if (_positionPriceStrategy is HIpyYGGux8yDt3ZakUAG)
					{
						totalQuantity = Math.Abs(bGu1Oy5paPL5b9ZouRwi(execution)) * 2;
						maxQuantity = Math.Abs(execution.Quantity);
						num2 = 14;
						continue;
					}
					goto case 14;
				case 64:
					if (num3 <= 3670628538u)
					{
						if (num3 == 3573002156u)
						{
							goto case 20;
						}
						if (num3 == 3670628538u)
						{
							goto case 47;
						}
					}
					else
					{
						if (num3 != 3677625335u)
						{
							if (num3 != 3777067153u)
							{
								num2 = 10;
								continue;
							}
							goto case 58;
						}
						if (xSgGGP53uiMjA3t3Ub2c(exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D313048 ^ 0x2D31D954)))
						{
							goto IL_0519;
						}
					}
					goto case 5;
				case 70:
					MwfGgk5pYGJ8jEIUggWb(uAHNdh5pGxo0NqWkEOiA(HbnyT353PRRpbqLjBn1R(0x50C1C840 ^ 0x50C138D8), Print(), (int?)PriceStrategy));
					num2 = 8;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
					{
						num2 = 8;
					}
					continue;
				case 12:
					{
						profit = GetMoneyPnl((Size != 0L) ? ((long)(PriceSum / Size)) : 0, execution.Price, Size);
						num = 25;
						break;
					}
					IL_13bf:
					profit2 = GetMoneyPnl((Size != 0L) ? ((long)(PriceSum / Size)) : 0, zjv1955pl3OT4ct0T5rw(execution), Size);
					num2 = 49;
					continue;
					IL_09e0:
					side2 = ((Size <= 0) ? Side.Sell : Side.Buy);
					_positionPriceStrategy.Close(this, execution);
					num2 = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
					{
						num2 = 33;
					}
					continue;
					IL_0291:
					n5P1Q65pkVTcRtHR9YRA(_positionPriceStrategy, this, execution);
					num2 = 9;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 == 0)
					{
						num2 = 4;
					}
					continue;
					IL_0519:
					comission2 = Comission;
					goto case 5;
					IL_086f:
					if (num8 == 0L)
					{
						return;
					}
					num2 = 61;
					continue;
					IL_13a5:
					num14 = wKJqaR5poCmfFV4QA1EF(Symbol);
					goto IL_13b0;
					IL_13b0:
					num15 = num14;
					if (num8 != 0L && (double)num12 * num9 < num15)
					{
						num8 = 0L;
					}
					if (Math.Sign(num8) != Math.Sign(Size))
					{
						num2 = 56;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 == 0)
						{
							num2 = 10;
						}
						continue;
					}
					if (Size <= 0)
					{
						goto case 73;
					}
					if (Size <= num8)
					{
						num2 = 73;
						continue;
					}
					goto case 68;
				}
				break;
			}
		}
	}

	private void CloseDeal(out UserDeal deal, Side side, DateTime closeTime, long closePrice, long totalQuantity, long maxQuantity, double totalValue, double points, double profit, double comission)
	{
		UserDeal obj = new UserDeal
		{
			SymbolID = SymbolID
		};
		d0DZDD5p1jo2qGorW6we(obj, SymbolName);
		HchkFx5p5pEceHZaJmEM(obj, AccountID);
		tjxE2I5pSWkONHl4DLvj(obj, AccountName);
		SOb79B5px8mSBrHt8jWF(obj, OpenTime);
		CUCGru5pLxGGKhbRcijQ(obj, Symbol.GetRealPrice(OpenPrice));
		hwMGXI5peVLH3sc3CWef(obj, closeTime);
		hTrqOU5psSBeNj4PZIAe(obj, lMdJmP5pifHlxTVihI5c(Symbol, closePrice));
		qrMFSC5pXOSpJtrNhcTI(obj, side);
		obj.Quantity = Symbol.GetRealSize(totalQuantity);
		gF7K4m5pjMC60SHrfVdU(obj, FKcbba5pcbWwrljIGrPe(Symbol, maxQuantity));
		obj.TotalValue = totalValue;
		leYEgS5pE3J2oB71N39a(obj, points);
		obj.Profit = profit;
		obj.Comission = comission;
		LHYJ6q5pQa023hdfhypP(obj, TimeHelper.GetCurrTime(Symbol.Exchange));
		deal = obj;
	}

	internal void Correct(UserPositionData position)
	{
		Price = position.Price;
		PriceSum = BigInteger.Multiply(position.Price, position.Size);
		Size = position.Size;
		RealSize = (decimal)Symbol.GetRealSize(Size);
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				OpenPrice = MB2RX65pgE4q1vNiD44K(position);
				if (vw95ep5pRBkL45MBynvH(OpenTime, DateTime.MinValue))
				{
					return;
				}
				StartTime = dAw6kJ5p6fkVUJuqTySo();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a != 0)
				{
					num = 0;
				}
				break;
			default:
				OpenTime = TimeHelper.GetCurrTime((string)d0siEs53UvSp529yPjQw(Symbol));
				return;
			case 3:
				TotalValue = KJfAWQ5pb0otuBUOGjJ3(PKQTfF53I4dQvRLJYZ28(position.Price), Math.Abs(position.Size));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
				{
					num = 2;
				}
				break;
			case 2:
				TotalQuantity = Math.Abs(EYT9Gg5pdhqn4K82iOuQ(position));
				MaxQuantity = Math.Abs(position.Size);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal void Correct(Position position)
	{
		n94DQwGu2NVuNQEJYC0O positionPriceStrategy = _positionPriceStrategy;
		if (positionPriceStrategy == null)
		{
			goto IL_0140;
		}
		positionPriceStrategy.Clear(this);
		int num = 7;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
		{
			num = 2;
		}
		goto IL_0009;
		IL_0140:
		PriceStrategy = ApidlOGpzEFH7ruf5jBr.UnifiedOpen;
		long shortPrice = Symbol.GetShortPrice(position.AvgPrice);
		long quantity = position.Quantity;
		Price = shortPrice;
		num = 2;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
		{
			num = 3;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			default:
				Size = quantity;
				num = 8;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
				{
					num = 6;
				}
				continue;
			case 5:
				if (Size == 0L)
				{
					Strategy.Clear();
					PositionPnl = 0L;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
					{
						num = 1;
					}
					continue;
				}
				goto case 4;
			case 2:
				Comission = 0.0;
				num = 6;
				continue;
			case 9:
				Pnl = PriceSum;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
				{
					num = 0;
				}
				continue;
			case 7:
				break;
			case 3:
				PriceSum = KJfAWQ5pb0otuBUOGjJ3(shortPrice, quantity);
				num = 9;
				continue;
			case 1:
				PositionRealPnl = null;
				PositionTime = TimeSpan.FromMilliseconds(0.0);
				num = 4;
				continue;
			case 8:
				RealSize = (decimal)Symbol.GetRealSize(quantity);
				TotalValue = BigInteger.Multiply(shortPrice, Math.Abs(quantity));
				TotalQuantity = Math.Abs(quantity);
				MaxQuantity = Math.Abs(quantity);
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 == 0)
				{
					num = 2;
				}
				continue;
			case 6:
				StartTime = TimeHelper.LocalTime;
				OpenTime = TimeHelper.GetCurrTime(Symbol.Exchange);
				OpenPrice = shortPrice;
				num = 5;
				continue;
			case 4:
				Hidden = false;
				return;
			}
			break;
		}
		goto IL_0140;
	}

	internal void Clear()
	{
		Price = 0L;
		PriceSum = 0;
		int num = 5;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				Comission = 0.0;
				StartTime = DateTime.MinValue;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
				{
					num = 4;
				}
				break;
			case 5:
				Size = 0L;
				num = 2;
				break;
			default:
				_positionPriceStrategy = null;
				return;
			case 2:
				RealSize = null;
				TotalValue = 0;
				TotalQuantity = 0L;
				MaxQuantity = 0L;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
				{
					num = 3;
				}
				break;
			case 4:
				OpenTime = DateTime.MinValue;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_04ffa74e86424225b1da01f05c8e1ee9 != 0)
				{
					num = 1;
				}
				break;
			case 1:
			{
				OpenPrice = 0L;
				Strategy.Clear();
				n94DQwGu2NVuNQEJYC0O positionPriceStrategy = _positionPriceStrategy;
				if (positionPriceStrategy == null)
				{
					goto default;
				}
				positionPriceStrategy.Clear(this);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	internal void ClearPlayer()
	{
		Clear();
	}

	internal void Hide()
	{
		Hidden = true;
	}

	public double GetPointsPnl()
	{
		return (double)PositionPnl * Symbol.Step;
	}

	public double GetMoneyPnl()
	{
		return PositionRealPnl ?? ((double)PositionPnl * wr2enT5pMxIastqJc7xR(Symbol) * Math.Abs(Symbol.GetRealSize(Size)));
	}

	public double GetPercentPnl()
	{
		if (Price == 0L)
		{
			return 0.0;
		}
		return (double)PositionPnl / (double)Price;
	}

	public double GetPointsPnl(long exitPrice)
	{
		return (double)((Size > 0) ? (exitPrice - Price) : (Price - exitPrice)) * QR2jic5pOC2mqUZj5sRC(Symbol);
	}

	public double GetMoneyPnl(long exitPrice)
	{
		return GetMoneyPnl(Price, exitPrice, Size);
	}

	public double GetMoneyPnl(long entryPrice, long exitPrice, long size)
	{
		if (!(Symbol.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-53782092 ^ -53756594)))
		{
			if (xSgGGP53uiMjA3t3Ub2c(Symbol.Exchange, HbnyT353PRRpbqLjBn1R(-165474503 ^ -165419739)))
			{
				return Symbol.GetRealSize(size) * (1.0 / Symbol.GetRealPrice(entryPrice) - 1.0 / Symbol.GetRealPrice(exitPrice));
			}
			if (Symbol.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-29702950 ^ -29743526) && (string)HVut1D5pNdq01rXOVHSW(Symbol) == (string)HbnyT353PRRpbqLjBn1R(0x1AB79299 ^ 0x1AB76267))
			{
				int num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 3:
					goto IL_00e1;
				case 1:
					return Symbol.GetRealSize(size) * (1.0 / lMdJmP5pifHlxTVihI5c(Symbol, entryPrice) - 1.0 / Symbol.GetRealPrice(exitPrice));
				case 4:
					goto IL_024c;
				case 2:
					goto IL_02c6;
				}
				goto IL_0046;
			}
			if (Symbol.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--737722733 ^ 0x2BF82995))
			{
				return FKcbba5pcbWwrljIGrPe(Symbol, size) * Symbol.PointValue * (1.0 / lMdJmP5pifHlxTVihI5c(Symbol, entryPrice) - 1.0 / Symbol.GetRealPrice(exitPrice));
			}
			return FKcbba5pcbWwrljIGrPe(Symbol, size) * ((double)(exitPrice - entryPrice) * wr2enT5pMxIastqJc7xR(Symbol));
		}
		goto IL_02c6;
		IL_024c:
		return FKcbba5pcbWwrljIGrPe(Symbol, size) * (1.0 / lMdJmP5pifHlxTVihI5c(Symbol, entryPrice) - 1.0 / Symbol.GetRealPrice(exitPrice));
		IL_00e1:
		return Symbol.GetRealSize(size) * 1E-06 * (lMdJmP5pifHlxTVihI5c(Symbol, exitPrice) - Symbol.GetRealPrice(entryPrice));
		IL_02c6:
		if (!Symbol.Code.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-377195341 ^ -377190981)))
		{
			if (Symbol.Code.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1583344314 ^ -1583291308)))
			{
				goto IL_0046;
			}
			if (Symbol.Code.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1325234765 ^ -1325239151)))
			{
				return FKcbba5pcbWwrljIGrPe(Symbol, size) * 0.0002 * (Symbol.GetRealPrice(exitPrice) - Symbol.GetRealPrice(entryPrice));
			}
			if (!Symbol.Code.StartsWith((string)HbnyT353PRRpbqLjBn1R(-1606927328 ^ -1606890222)))
			{
				return FKcbba5pcbWwrljIGrPe(Symbol, size) * (lMdJmP5pifHlxTVihI5c(Symbol, exitPrice) - Symbol.GetRealPrice(entryPrice));
			}
			goto IL_00e1;
		}
		goto IL_024c;
		IL_0046:
		return FKcbba5pcbWwrljIGrPe(Symbol, size) * 1E-06 * (Symbol.GetRealPrice(exitPrice) - Symbol.GetRealPrice(entryPrice));
	}

	private double GetSizeInQuoteAsset(long price)
	{
		string exchange = Symbol.Exchange;
		if (!(exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x2D313048 ^ 0x2D31DA54)))
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return FKcbba5pcbWwrljIGrPe(Symbol, Size) * (double)price * Symbol.GetStepPrice();
				default:
					if (xSgGGP53uiMjA3t3Ub2c(exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1841489831 ^ -1841431847)))
					{
						if ((string)HVut1D5pNdq01rXOVHSW(Symbol) == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1153206687 ^ -1153202529))
						{
							return getInverseSize(price);
						}
						goto case 1;
					}
					if (exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-53782092 ^ -53759668))
					{
						return FKcbba5pcbWwrljIGrPe(Symbol, Size) * Symbol.PointValue * (1.0 / Symbol.GetRealPrice(price));
					}
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}
		return getInverseSize(price);
	}

	private double getInverseSize(long price)
	{
		return Symbol.GetRealSize(Size) * (1.0 / Symbol.GetRealPrice(price));
	}

	public double GetPercentPnl(long exitPrice)
	{
		if (Price == 0L)
		{
			return 0.0;
		}
		return (double)(exitPrice - Price) / (double)Price * (double)axNP2r53wqjNRNLLk684(Size);
	}

	internal void Update(long bid, long ask, long last)
	{
		LastPrice = last;
		Bid = bid;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_137abeaac6b54c2d909c4f75bdf9527a == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 8:
			case 9:
				if (AUMPNg5pqLoD7SAJ5ch3(Symbol.Exchange))
				{
					num = 10;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
					{
						num = 7;
					}
					continue;
				}
				goto case 13;
			case 11:
				if (!(Symbol.Currency == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-371631841 ^ -371611167)))
				{
					num = 8;
					continue;
				}
				PositionRealPnl = GetMoneyPnl((Size > 0) ? bid : ask);
				goto case 13;
			default:
				if (Symbol.Exchange == (string)HbnyT353PRRpbqLjBn1R(0x11D1040B ^ 0x11D1E68B))
				{
					break;
				}
				if (!xSgGGP53uiMjA3t3Ub2c(Symbol.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-520155535 ^ -520100215)))
				{
					if (!(Symbol.Exchange == (string)HbnyT353PRRpbqLjBn1R(-1161619942 ^ -1161562982)))
					{
						goto case 8;
					}
					goto case 11;
				}
				num = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
				{
					num = 6;
				}
				continue;
			case 4:
				if (Size == 0L || bid <= 0 || ask <= 0)
				{
					PositionPnl = 0L;
					PositionRealPnl = null;
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 != 0)
					{
						num = 1;
					}
				}
				else
				{
					PositionRealSizeInQuoteByCurrentPrice = GetSizeInQuoteAsset((Size > 0) ? bid : ask);
					PositionPnl = ((Size > 0) ? (bid - Price) : (Price - ask));
					num = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
					{
						num = 7;
					}
				}
				continue;
			case 2:
			{
				double? num2 = GetSizeInQuoteAsset(Price);
				PositionRealSizeInQuoteByEntryPrice = ((Size == 0L || Price == 0L) ? ((double?)null) : num2);
				num = 4;
				continue;
			}
			case 13:
				if (xSgGGP53uiMjA3t3Ub2c(TradeClientId, HbnyT353PRRpbqLjBn1R(-490987856 ^ -490947376)))
				{
					PositionTime = TimeHelper.ConvertTimeFromLocal(TimeHelper.LocalTime, Symbol.Exchange, ignoreGlobalOption: true) - StartTime;
					num = 5;
					continue;
				}
				PositionTime = dAw6kJ5p6fkVUJuqTySo() - StartTime;
				return;
			case 14:
				SizeUpdate();
				num = 2;
				continue;
			case 1:
				PositionRealSizeInQuoteByCurrentPrice = null;
				PositionTime = TimeSpan.FromMilliseconds(0.0);
				return;
			case 10:
				PositionRealPnl = (double)PositionPnl * MpIsnH5pIxLg3MSIcayT(Symbol.GetRealSize(Size));
				goto case 13;
			case 5:
				return;
			case 12:
				if (!xSgGGP53uiMjA3t3Ub2c(Symbol.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-2108526692 ^ -2108521088)))
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 3:
				Ask = ask;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
				{
					num = 14;
				}
				continue;
			case 7:
				if (xSgGGP53uiMjA3t3Ub2c(d0siEs53UvSp529yPjQw(Symbol), F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-176525661 ^ -176518567)))
				{
					break;
				}
				goto case 12;
			case 6:
				break;
			}
			PositionRealPnl = GetMoneyPnl((Size > 0) ? bid : ask);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e != 0)
			{
				num = 13;
			}
		}
	}

	public void InitStrategy(ExitStrategy strategy)
	{
		Strategy.Init(strategy);
	}

	internal static string GetID(Symbol symbol, Account account)
	{
		return (string)OEWYWi53WJNxZvR5E5yp(symbol.ID, HbnyT353PRRpbqLjBn1R(0x68C7EAE6 ^ 0x68C708C6), uIGmDL5pWsUhUMilRMD2(account));
	}

	internal static string GetPriceStrategyName(ApidlOGpzEFH7ruf5jBr? priceStrategy)
	{
		if (!priceStrategy.HasValue)
		{
			if (!Acj0FgGhg83F5A0lfPa4.dBtGhqwS0s1())
			{
				return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x78D396D8 ^ 0x78D3679A);
			}
			return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--500511424 ^ 0x1DD5C3A4);
		}
		if (!(Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(33554747)).GetField(priceStrategy.ToString()).GetCustomAttributes(Type.GetTypeFromHandle(mbW0ZX5GZSjijNSIwCPB.torLy1vMGw1(16777444)), inherit: false)
			.FirstOrDefault() is DescriptionAttribute descriptionAttribute))
		{
			return ((int?)priceStrategy/*cast due to .constrained prefix*/).ToString();
		}
		return descriptionAttribute.Description;
	}

	internal string Print()
	{
		string priceStrategyName = GetPriceStrategyName(PriceStrategy);
		return string.Format((string)HbnyT353PRRpbqLjBn1R(-1416986301 ^ -1416990521), SymbolName, AccountName, Price, Size, Comission, priceStrategyName, Executions?.Count);
	}

	private void SizeUpdate()
	{
		int num = 1;
		double? sizeStep = default(double?);
		double num3 = default(double);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					sizeStep = SizeStep;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				case 4:
					return;
				case 3:
					RealSize = (decimal)num3;
					SizeStep = Symbol.SizeStep;
					return;
				}
				if (!sizeStep.HasValue)
				{
					SizeStep = Symbol.SizeStep;
					num2 = 4;
					continue;
				}
				sizeStep = SizeStep;
				if (!(Math.Abs(sizeStep.Value - Symbol.SizeStep) < double.Epsilon))
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
				{
					num2 = 2;
				}
			}
			double num4 = Size;
			sizeStep = SizeStep;
			num3 = num4 * sizeStep.Value;
			Size = Symbol.GetShortSize(num3);
			num = 3;
		}
	}

	public void SetPositionPriceStrategy(ApidlOGpzEFH7ruf5jBr strategy)
	{
		int num = 4;
		int num3 = default(int);
		uioCmvGp6sXANp11eX6R[] array = default(uioCmvGp6sXANp11eX6R[]);
		long size = default(long);
		long price = default(long);
		UserDeal deal = default(UserDeal);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = 0;
					goto IL_00e5;
				case 2:
				{
					uioCmvGp6sXANp11eX6R[] array2 = Executions.ToArray();
					PriceStrategy = strategy;
					A9HUHU5pDaOUKHvaTewL(_positionPriceStrategy, this);
					array = array2;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 4:
					break;
				case 5:
					if (size == 0L)
					{
						num2 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5557066a01244f8e812ce68a3370995c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_00d6;
				default:
					num3++;
					goto IL_00e5;
				case 3:
					{
						price = Price;
						deal = null;
						num2 = 5;
						continue;
					}
					IL_00e5:
					if (num3 < array.Length)
					{
						uioCmvGp6sXANp11eX6R execution = array[num3];
						Apply(execution, ref deal);
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_00d6;
					IL_00d6:
					UpdateDynamicSlTp(size, price);
					return;
				}
				break;
			}
			size = Size;
			num = 3;
		}
	}

	public object Clone()
	{
		UserPosition userPosition = new UserPosition();
		UIgppK5pt39QD4tct9TR(userPosition, ConnectionID);
		userPosition.ConnectionName = ConnectionName;
		userPosition.SymbolID = SymbolID;
		jpJfhv5pUAKGJp5EFk1V(userPosition, SymbolName);
		userPosition.AccountID = AccountID;
		Godysi5pTgNtQT67Ax7o(userPosition, AccountName);
		userPosition.Price = Price;
		userPosition.LastSizeTriggeredStrategy = LastSizeTriggeredStrategy;
		userPosition.PriceSumLong = PriceSumLong;
		oXBEJD5pyYi0vIoRNHlR(userPosition, PriceSum);
		userPosition.RealSize = RealSize;
		userPosition.Size = Size;
		userPosition.SizeStep = SizeStep;
		userPosition.TotalValueLong = TotalValueLong;
		ugDBou5pZj2QGL0pPKJ4(userPosition, TotalValue);
		userPosition.TotalQuantity = TotalQuantity;
		userPosition.MaxQuantity = MaxQuantity;
		hIofyf5pV22iOKwjqI7m(userPosition, Comission);
		userPosition.StartTime = StartTime;
		userPosition.OpenTime = OpenTime;
		userPosition.OpenPrice = OpenPrice;
		userPosition.LastTradeTime = LastTradeTime;
		userPosition.IsMt5TimeValid = IsMt5TimeValid;
		userPosition.LastTradeIDs = LastTradeIDs;
		userPosition.LastTradeCombinedIDs = LastTradeCombinedIDs;
		yfGrvh5pC4CX4mvj8gD7(userPosition, Hidden);
		userPosition.Strategy = (ExitStrategy)Strategy.Clone();
		return userPosition;
	}

	public bool Equals(ExitStrategy x)
	{
		if (x == null)
		{
			return false;
		}
		return YOggFV5prI8yxDyZ2SVj(x) == GetHashCode(Strategy);
		static int GetHashCode(ExitStrategy s)
		{
			hESIF2acGYroXCrZ6fr6 hESIF2acGYroXCrZ6fr = default(hESIF2acGYroXCrZ6fr6);
			List<ExitStrategyTarget>.Enumerator enumerator = s.Targets.GetEnumerator();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						ExitStrategyTarget current = enumerator.Current;
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossOffset);
						int num2 = 3;
						while (true)
						{
							switch (num2)
							{
							case 3:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossPrice);
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossTrailingRange);
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
								{
									num2 = 0;
								}
								continue;
							default:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossBreakevenPlus);
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossTrailingStep);
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitOffset);
								num2 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitPrice);
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitRange);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				return hESIF2acGYroXCrZ6fr.x5oacbn4NnT();
			}
		}
	}

	static UserPosition()
	{
		bPJkCg5pKumalIL8g144();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool e8OsaZ53Oe2pcmapBbDn()
	{
		return xpQ1Yy53MduWDmlr6vib == null;
	}

	internal static UserPosition rO02Ih53qFuKKfTsybkV()
	{
		return xpQ1Yy53MduWDmlr6vib;
	}

	internal static BigInteger PKQTfF53I4dQvRLJYZ28(long P_0)
	{
		return P_0;
	}

	internal static object OEWYWi53WJNxZvR5E5yp(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object Tl4JuY53twPXDUlPMSs0(object P_0)
	{
		return ((ConnectionInfo)P_0).TradeClientID;
	}

	internal static object d0siEs53UvSp529yPjQw(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static bool o2fJY853TIbSgPm7Nj9f(object P_0)
	{
		return ((Execution)P_0).IgnorePosition;
	}

	internal static bool IyVpIQ53yaOkcYJHjxuc(object P_0)
	{
		return ((Execution)P_0).IgnoreChecks;
	}

	internal static object R334q953ZsCOI6B8qnHr(object P_0)
	{
		return ((Execution)P_0).Account;
	}

	internal static bool wLodGY53VJ64TbZ6WAlE(object P_0)
	{
		return ((Account)P_0).Simulator;
	}

	internal static DateTime hcTrRj53CJxFOyiGdlSZ(object P_0)
	{
		return ((Execution)P_0).Time;
	}

	internal static bool RBrNw253rYsUGwaPbuhb(DateTime P_0, DateTime P_1)
	{
		return P_0 < P_1;
	}

	internal static object ENX6Xx53KwtvFRav8Lcc(object P_0)
	{
		return ((Execution)P_0).Symbol;
	}

	internal static object B7kyXD53mQxfcGEGNpJF(object P_0)
	{
		return ((Execution)P_0).ExecutionID;
	}

	internal static ApidlOGpzEFH7ruf5jBr v1Orcf53hWl3BtXOiQRx()
	{
		return Acj0FgGhg83F5A0lfPa4.P5TGhtyT00B();
	}

	internal static int axNP2r53wqjNRNLLk684(long P_0)
	{
		return Math.Sign(P_0);
	}

	internal static long qt7Y3l5378fsTeZHja1O(object P_0)
	{
		return ((ExitStrategyTarget)P_0).StopLossPrice;
	}

	internal static object PiEuWX538VWPLp6ubpk3(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static void yTbs1r53AQ5BG9EC6nAR(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).StopLossPrice = value;
	}

	internal static object HbnyT353PRRpbqLjBn1R(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static long Y9VUTD53JYJ73sbTvSnp(object P_0)
	{
		return ((ExitStrategyTarget)P_0).TakeProfitPrice;
	}

	internal static void pSbv0Z53Fjv58tErHQLi(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).TakeProfitPrice = value;
	}

	internal static long sLKBGL533wdFMtMbdMBc(object P_0)
	{
		return ((Execution)P_0).Quantity;
	}

	internal static uint fWBs7S53peICXXDpcO4r(object P_0)
	{
		return global::_003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool xSgGGP53uiMjA3t3Ub2c(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static SymbolType A48BdF53zP6RAiGCg0YB(object P_0)
	{
		return ((Symbol)P_0).Type;
	}

	internal static Side g2Wpbv5p02mRkdq0eEnA(object P_0)
	{
		return ((Execution)P_0).Side;
	}

	internal static object O5SFDL5p2suxy7S9FL7V(object P_0)
	{
		return ((Execution)P_0).ID;
	}

	internal static void qb7X4S5pHvX7Op6Yggdc(object P_0, object P_1)
	{
		((uioCmvGp6sXANp11eX6R)P_0).dNwGpW7R045 = (string)P_1;
	}

	internal static void KBo3WZ5pfBfiEJwPTfmg(object P_0, DateTime P_1)
	{
		((uioCmvGp6sXANp11eX6R)P_0).StartTime = P_1;
	}

	internal static long b30VrH5p9e7WyW09HYdQ(object P_0)
	{
		return ((Execution)P_0).Price;
	}

	internal static void k3Ddeu5pnZiTlclmger5(object P_0, long P_1)
	{
		((uioCmvGp6sXANp11eX6R)P_0).Price = P_1;
	}

	internal static object uAHNdh5pGxo0NqWkEOiA(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void MwfGgk5pYGJ8jEIUggWb(object P_0)
	{
		LogManager.WriteError((string)P_0);
	}

	internal static double wKJqaR5poCmfFV4QA1EF(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static long PceuLL5pv9AIVkG2B7q0(long P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double AZAb9c5pBee2VHBvHIx9(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Y58Gp8qAYyf;
	}

	internal static long bGu1Oy5paPL5b9ZouRwi(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Quantity;
	}

	internal static double lMdJmP5pifHlxTVihI5c(object P_0, long price)
	{
		return ((Symbol)P_0).GetRealPrice(price);
	}

	internal static long zjv1955pl3OT4ct0T5rw(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).Price;
	}

	internal static DateTime XONO5B5p4KlJSMnxxPrr(object P_0)
	{
		return ((uioCmvGp6sXANp11eX6R)P_0).StartTime;
	}

	internal static void A9HUHU5pDaOUKHvaTewL(object P_0, object P_1)
	{
		((n94DQwGu2NVuNQEJYC0O)P_0).Clear((UserPosition)P_1);
	}

	internal static BigInteger KJfAWQ5pb0otuBUOGjJ3(BigInteger P_0, BigInteger P_1)
	{
		return BigInteger.Multiply(P_0, P_1);
	}

	internal static object HVut1D5pNdq01rXOVHSW(object P_0)
	{
		return ((Symbol)P_0).Currency;
	}

	internal static void n5P1Q65pkVTcRtHR9YRA(object P_0, object P_1, object P_2)
	{
		((n94DQwGu2NVuNQEJYC0O)P_0).DTLlo4O5yI9((UserPosition)P_1, (uioCmvGp6sXANp11eX6R)P_2);
	}

	internal static void d0DZDD5p1jo2qGorW6we(object P_0, object P_1)
	{
		((UserDeal)P_0).SymbolName = (string)P_1;
	}

	internal static void HchkFx5p5pEceHZaJmEM(object P_0, object P_1)
	{
		((UserDeal)P_0).AccountID = (string)P_1;
	}

	internal static void tjxE2I5pSWkONHl4DLvj(object P_0, object P_1)
	{
		((UserDeal)P_0).AccountName = (string)P_1;
	}

	internal static void SOb79B5px8mSBrHt8jWF(object P_0, DateTime value)
	{
		((UserDeal)P_0).OpenTime = value;
	}

	internal static void CUCGru5pLxGGKhbRcijQ(object P_0, double value)
	{
		((UserDeal)P_0).OpenPrice = value;
	}

	internal static void hwMGXI5peVLH3sc3CWef(object P_0, DateTime value)
	{
		((UserDeal)P_0).CloseTime = value;
	}

	internal static void hTrqOU5psSBeNj4PZIAe(object P_0, double value)
	{
		((UserDeal)P_0).ClosePrice = value;
	}

	internal static void qrMFSC5pXOSpJtrNhcTI(object P_0, Side value)
	{
		((UserDeal)P_0).Side = value;
	}

	internal static double FKcbba5pcbWwrljIGrPe(object P_0, long size)
	{
		return ((SymbolBase)P_0).GetRealSize(size);
	}

	internal static void gF7K4m5pjMC60SHrfVdU(object P_0, double value)
	{
		((UserDeal)P_0).MaxQuantity = value;
	}

	internal static void leYEgS5pE3J2oB71N39a(object P_0, double value)
	{
		((UserDeal)P_0).Points = value;
	}

	internal static void LHYJ6q5pQa023hdfhypP(object P_0, DateTime value)
	{
		((UserDeal)P_0).LocalTime = value;
	}

	internal static long EYT9Gg5pdhqn4K82iOuQ(object P_0)
	{
		return ((UserPositionData)P_0).Size;
	}

	internal static long MB2RX65pgE4q1vNiD44K(object P_0)
	{
		return ((UserPositionData)P_0).Price;
	}

	internal static bool vw95ep5pRBkL45MBynvH(DateTime P_0, DateTime P_1)
	{
		return P_0 != P_1;
	}

	internal static DateTime dAw6kJ5p6fkVUJuqTySo()
	{
		return TimeHelper.LocalTime;
	}

	internal static double wr2enT5pMxIastqJc7xR(object P_0)
	{
		return ((Symbol)P_0).GetStepPrice();
	}

	internal static double QR2jic5pOC2mqUZj5sRC(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static bool AUMPNg5pqLoD7SAJ5ch3(object P_0)
	{
		return YtFfukajaSr17E52hP4h.d59ajl8LAnH((string)P_0);
	}

	internal static double MpIsnH5pIxLg3MSIcayT(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static object uIGmDL5pWsUhUMilRMD2(object P_0)
	{
		return ((Account)P_0).AccountID;
	}

	internal static void UIgppK5pt39QD4tct9TR(object P_0, object P_1)
	{
		((UserPosition)P_0).ConnectionID = (string)P_1;
	}

	internal static void jpJfhv5pUAKGJp5EFk1V(object P_0, object P_1)
	{
		((UserPosition)P_0).SymbolName = (string)P_1;
	}

	internal static void Godysi5pTgNtQT67Ax7o(object P_0, object P_1)
	{
		((UserPosition)P_0).AccountName = (string)P_1;
	}

	internal static void oXBEJD5pyYi0vIoRNHlR(object P_0, BigInteger value)
	{
		((UserPosition)P_0).PriceSum = value;
	}

	internal static void ugDBou5pZj2QGL0pPKJ4(object P_0, BigInteger value)
	{
		((UserPosition)P_0).TotalValue = value;
	}

	internal static void hIofyf5pV22iOKwjqI7m(object P_0, double value)
	{
		((UserPosition)P_0).Comission = value;
	}

	internal static void yfGrvh5pC4CX4mvj8gD7(object P_0, bool value)
	{
		((UserPosition)P_0).Hidden = value;
	}

	internal static int YOggFV5prI8yxDyZ2SVj(object P_0)
	{
		return GetHashCode((ExitStrategy)P_0);
		static int GetHashCode(ExitStrategy s)
		{
			hESIF2acGYroXCrZ6fr6 hESIF2acGYroXCrZ6fr = default(hESIF2acGYroXCrZ6fr6);
			List<ExitStrategyTarget>.Enumerator enumerator = s.Targets.GetEnumerator();
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			default:
				try
				{
					while (enumerator.MoveNext())
					{
						ExitStrategyTarget current = enumerator.Current;
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossOffset);
						int num2 = 3;
						while (true)
						{
							switch (num2)
							{
							case 3:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossPrice);
								num2 = 1;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 != 0)
								{
									num2 = 0;
								}
								continue;
							case 1:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossTrailingRange);
								num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
								{
									num2 = 0;
								}
								continue;
							default:
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossBreakevenPlus);
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.StopLossTrailingStep);
								hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitOffset);
								num2 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitPrice);
						hESIF2acGYroXCrZ6fr.KENacla2mpO(current.TakeProfitRange);
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				return hESIF2acGYroXCrZ6fr.x5oacbn4NnT();
			}
		}
	}

	internal static void bPJkCg5pKumalIL8g144()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
