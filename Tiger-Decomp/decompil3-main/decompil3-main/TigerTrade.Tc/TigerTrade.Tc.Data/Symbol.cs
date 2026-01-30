using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Core.Utils.Time;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Symbol : SymbolBase
{
	private readonly DateTime _linkMinExpirationDate;

	private static Symbol gZD8ag5FIZ7vmQIeDf1X;

	public string ID { get; }

	public SymbolType Type { get; }

	internal string Code { get; set; }

	internal string Category { get; set; }

	public string LongCode { get; set; }

	public string Currency { get; internal set; }

	public int LotSize { get; internal set; }

	internal double PointValue { get; set; }

	public int Precision { get; internal set; }

	public int SizePrecision { get; set; }

	public int PnlPrecision { get; internal set; }

	public string Name { get; internal set; }

	public string Description { get; internal set; }

	public string Mapping { get; internal set; }

	public double LotStep { get; internal set; }

	public double MinQty { get; internal set; }

	public double MinNotional { get; internal set; }

	public string OptAsset { get; set; }

	public SymbolOptType OptType { get; set; }

	public double OptStrike { get; set; }

	public DateTime Expiration { get; private set; }

	private DateTime RolloverDate { get; }

	public Symbol Master { get; }

	private Symbol CurrentContract { get; set; }

	private List<Symbol> Contracts { get; }

	private List<Symbol> Strikes { get; }

	public Hashtable AdditionalData { get; set; }

	public bool IsMaster { get; }

	public bool IsDeleted { get; set; }

	public DateTime SpecChangeUtcDate { get; set; }

	public bool IsLinkable
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!IsCrypto)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (Type == SymbolType.Future)
					{
						if (!IsMaster)
						{
							return Expiration >= _linkMinExpirationDate;
						}
						return false;
					}
					return true;
				default:
					return false;
				}
			}
		}
	}

	public bool IsSplicedFutures { get; private set; }

	public bool IsBinance => base.Exchange.StartsWith((string)i91RyN5FAkoNOXEMw0s6(0x1A5F1B9E ^ 0x1A5FC4B8));

	public bool IsBinanceX => pASc0g5F7pO2Grc7aoEE(base.Exchange, i91RyN5FAkoNOXEMw0s6(-527080372 ^ -527073028));

	public bool IsTigerX
	{
		get
		{
			if (!IsBinanceX)
			{
				return IsOkxX;
			}
			return true;
		}
	}

	public bool IsBitMEX => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1311293279 ^ -1311267749);

	public bool IsBitFinex => base.Exchange == (string)i91RyN5FAkoNOXEMw0s6(-371631841 ^ -371606507);

	public bool IsDeribit => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-490987856 ^ -490933076);

	public bool IsBybit => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x28B345BB ^ 0x28B3A73B);

	public bool IsHitBTC => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7DB10E6E ^ 0x7DB1E462);

	public bool IsFTX => pASc0g5F7pO2Grc7aoEE(base.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F645F3C ^ 0x7F64B512));

	public bool IsOKX => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1AB79299 ^ 0x1AB74DA1);

	public bool IsOkxX => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416993389);

	public bool IsGateIo => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-991861155 ^ -991853899);

	public bool IsMEXC => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xECA3F28 ^ 0xECA9C0E);

	public bool IsBitget => pASc0g5F7pO2Grc7aoEE(base.Exchange, i91RyN5FAkoNOXEMw0s6(0x2CBEEA31 ^ 0x2CBE4903));

	public bool IsBackpack => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x6D18F862 ^ 0x6D185B20);

	public bool IsMoex => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x4220DA8 ^ 0x422E390);

	public bool IsSpbex => base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x315AB1E3 ^ 0x315A5FA7);

	public bool IsEurex => base.Exchange == (string)i91RyN5FAkoNOXEMw0s6(0x28C965BE ^ 0x28C98BEC);

	public bool IsIce => base.Exchange.StartsWith(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-53782092 ^ -53757996));

	public bool IsFxcm => base.Exchange == (string)i91RyN5FAkoNOXEMw0s6(-602153869 ^ -602197479);

	public bool IsNyse => base.Exchange == (string)i91RyN5FAkoNOXEMw0s6(-198991962 ^ -199003696);

	public bool IsNasdaq => pASc0g5F7pO2Grc7aoEE(base.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-842040449 ^ -842033667));

	public bool IsCme
	{
		get
		{
			if (!(base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346990033)))
			{
				while (!pASc0g5F7pO2Grc7aoEE(base.Exchange, F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1522697859 ^ -1522690079)))
				{
					int num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
					{
						num = 1;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						continue;
					}
					if (base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225782651))
					{
						break;
					}
					return base.Exchange == (string)i91RyN5FAkoNOXEMw0s6(0x706541F3 ^ 0x7065AF45);
				}
			}
			return true;
		}
	}

	public bool IsCrypto
	{
		get
		{
			if (!IsBinance && !IsBybit && !IsOKX)
			{
				int num = 3;
				while (true)
				{
					switch (num)
					{
					default:
						if (!IsFTX)
						{
							return IsBitget;
						}
						break;
					case 1:
						if (!IsBackpack)
						{
							num = 4;
							continue;
						}
						break;
					case 4:
						if (!IsBitFinex)
						{
							num = 2;
							continue;
						}
						break;
					case 2:
						if (!IsDeribit && !IsHitBTC)
						{
							num = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					case 3:
						if (!IsTigerX && !IsGateIo && !IsMEXC && !IsBitMEX)
						{
							num = 1;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 == 0)
							{
								num = 1;
							}
							continue;
						}
						break;
					}
					break;
				}
			}
			return true;
		}
	}

	public bool IsCryptoFuture
	{
		get
		{
			if (IsCrypto)
			{
				return Type == SymbolType.Future;
			}
			return false;
		}
	}

	public bool IsExcludedCommonLots
	{
		get
		{
			if (!(base.Exchange == F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0xAD5B8B3 ^ 0xAD5504B)))
			{
				if (IsBybit)
				{
					int num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 != 0)
					{
						num = 0;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							if (!AdditionalData.ContainsValue(i91RyN5FAkoNOXEMw0s6(0x741B85CB ^ 0x741B6C67)))
							{
								return AdditionalData.ContainsValue(i91RyN5FAkoNOXEMw0s6(0x1D7BA1ED ^ 0x1D7B4861));
							}
							return true;
						}
						if (AdditionalData == null)
						{
							break;
						}
						num = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
						{
							num = 1;
						}
					}
				}
				return false;
			}
			return true;
		}
	}

	internal Symbol(string id, SymbolType type)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		_linkMinExpirationDate = new DateTime(2049, 12, 31);
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				ID = id;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				Type = type;
				IsMaster = true;
				Contracts = new List<Symbol>();
				Strikes = new List<Symbol>();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca == 0)
				{
					num = 0;
				}
				break;
			default:
				base.ContractValue = 1.0;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num = 1;
				}
				break;
			case 1:
				IsSplicedFutures = false;
				return;
			}
		}
	}

	internal Symbol(string id, Symbol symbol, DateTime expiration, DateTime rolloverDate)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector(id, symbol.Type);
		Master = symbol;
		Expiration = expiration;
		RolloverDate = rolloverDate;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				Description = symbol.Description;
				num = 2;
				break;
			case 2:
				LotSize = symbol.LotSize;
				MinQty = symbol.MinQty;
				IsDeleted = symbol.IsDeleted;
				return;
			case 5:
				base.SizeStep = htS2iV5FZWf47paNGuIR(symbol);
				SizePrecision = vqV9JQ5FVKNABwoSNegm(symbol);
				PnlPrecision = ra7cl95FCjIPbZU6o5E9(symbol);
				num = 6;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee == 0)
				{
					num = 6;
				}
				break;
			default:
				IsMaster = false;
				num = 7;
				break;
			case 1:
				base.Exchange = (string)M3u6455FUxTDQCYe35DI(symbol);
				PointValue = symbol.PointValue;
				num = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				base.Step = y4JE2M5FToULnergOryK(symbol);
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
				{
					num = 1;
				}
				break;
			case 7:
				Currency = symbol.Currency;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				Precision = vFW0pV5FyNesDXLDAShB(symbol);
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	internal void AddContract(Symbol symbol)
	{
		Contracts.Add(symbol);
		IsSplicedFutures = Type == SymbolType.Future && IsMaster && (Contracts.Count > 1 || (Elj3825FrS65HtCgEHb4(Contracts) == 1 && dEmoAc5FKQGG8k7VWuQk(Contracts[0]).Year < 2100));
	}

	internal void AddStrike(Symbol symbol)
	{
		Strikes.Add(symbol);
	}

	internal void UpdateCurrentContract(DateTime currDate, bool isPlayerMode = false)
	{
		int num = 4;
		Symbol symbol = default(Symbol);
		Symbol current = default(Symbol);
		TimeSpan timeSpan2 = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					symbol = null;
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return;
				case 3:
				{
					TimeSpan timeSpan = TimeSpan.MaxValue;
					using (List<Symbol>.Enumerator enumerator = Contracts.GetEnumerator())
					{
						while (true)
						{
							int num3;
							if (enumerator.MoveNext())
							{
								current = enumerator.Current;
								if (!Ry8wcV5Fmeb5IiCYWHYX(current))
								{
									goto IL_0170;
								}
								if (!isPlayerMode)
								{
									continue;
								}
								num3 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 3;
							}
							goto IL_00e5;
							IL_00e5:
							while (true)
							{
								switch (num3)
								{
								case 1:
									break;
								default:
									goto IL_0170;
								case 2:
									timeSpan2 = Hs9KrR5FhuK5AK4DE6BN(current) - currDate;
									num3 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									goto end_IL_0110;
								}
								break;
							}
							if (timeSpan2 < timeSpan)
							{
								timeSpan = timeSpan2;
								symbol = current;
							}
							continue;
							IL_0170:
							if (current.RolloverDate <= currDate)
							{
								continue;
							}
							num3 = 2;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
							{
								num3 = 0;
							}
							goto IL_00e5;
							continue;
							end_IL_0110:
							break;
						}
					}
					goto default;
				}
				case 2:
					break;
				default:
					if (symbol == null && Contracts.Count > 0)
					{
						goto end_IL_0012;
					}
					break;
				}
				CurrentContract = symbol;
				if (CurrentContract == null)
				{
					return;
				}
				Expiration = CurrentContract.Expiration;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			symbol = Contracts[Contracts.Count - 1];
			num = 2;
		}
	}

	internal bool SameAsMaster()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 1:
				if (!IsCrypto)
				{
					if (!IsMaster)
					{
						return Master.CurrentContract == this;
					}
					goto default;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Symbol GetSymbol()
	{
		if (IsMaster && Type == SymbolType.Future)
		{
			return CurrentContract;
		}
		return this;
	}

	public Symbol GetSymbol(DateTime date)
	{
		int num = 4;
		int num2 = num;
		List<Symbol>.Enumerator enumerator = default(List<Symbol>.Enumerator);
		TimeSpan timeSpan = default(TimeSpan);
		Symbol symbol = default(Symbol);
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							Symbol current = enumerator.Current;
							int num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 == 0)
							{
								num3 = 0;
							}
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_0116;
								case 1:
									goto end_IL_009e;
								}
								if (current.RolloverDate <= date)
								{
									goto end_IL_012a;
								}
								num3 = 2;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
								{
									num3 = 2;
								}
								continue;
								IL_0116:
								TimeSpan timeSpan2 = WOt3uP5Fw6OlggGcEoqr(Hs9KrR5FhuK5AK4DE6BN(current), date);
								if (timeSpan2 < timeSpan)
								{
									timeSpan = timeSpan2;
									symbol = current;
								}
								goto end_IL_012a;
								continue;
								end_IL_009e:
								break;
							}
							continue;
							end_IL_012a:
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				if (symbol == null && Elj3825FrS65HtCgEHb4(Contracts) > 0)
				{
					symbol = Contracts[Contracts.Count - 1];
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				if (IsMaster)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 1:
				return symbol;
			case 3:
				if (Type == SymbolType.Future)
				{
					symbol = null;
					timeSpan = TimeSpan.MaxValue;
					enumerator = Contracts.GetEnumerator();
					num2 = 2;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cd6be7b090074d37a7e9c91ffedadb35 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	public bool CheckContract(string symbolID)
	{
		if (IsMaster && Type == SymbolType.Future && CurrentContract != null)
		{
			return pASc0g5F7pO2Grc7aoEE(CurrentContract.ID, symbolID);
		}
		return false;
	}

	public bool CheckContract(Symbol symbol)
	{
		if (!IsMaster || Type != SymbolType.Future || CurrentContract == null)
		{
			return false;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => pASc0g5F7pO2Grc7aoEE(CurrentContract.ID, symbol.ID), 
		};
	}

	public string CurrentSymbolID()
	{
		if (IsMaster && Type == SymbolType.Future)
		{
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (CurrentContract != null)
			{
				return CurrentContract.ID;
			}
		}
		return ID;
	}

	public List<Symbol> GetContracts()
	{
		return Contracts.ToList();
	}

	public double GetStepPrice()
	{
		return PointValue * base.Step;
	}

	public long GetShortPrice(double price)
	{
		return kTp7p75F83L6KO3emkNq(Math.Round((decimal)price / (decimal)base.Step, MidpointRounding.AwayFromZero));
	}

	public double GetRealPrice(long price)
	{
		return (double)price * base.Step;
	}

	public string GetRealPriceStr(long price)
	{
		return ((decimal)GetRealPrice(price)).ToString(CultureInfo.InvariantCulture);
	}

	public string FormatPrice(long price, bool f = false)
	{
		return GetRealPrice(price).ToString((string)(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--18459671 ^ 0x11941AF) : i91RyN5FAkoNOXEMw0s6(-342738082 ^ -342698260)) + Precision);
	}

	public string FormatPrice(long price, IFormatProvider provider, bool f = false)
	{
		return GetRealPrice(price).ToString((string)(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x37B74BDF ^ 0x37B7A667) : i91RyN5FAkoNOXEMw0s6(-1380525184 ^ -1380567502)) + Precision, provider);
	}

	public string FormatPrice(double price, bool f = false)
	{
		return price.ToString((string)(f ? i91RyN5FAkoNOXEMw0s6(-53782092 ^ -53758964) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-448941864 ^ -448963222)) + Precision);
	}

	public string FormatPrice(double? price, bool f = false)
	{
		if (price.HasValue)
		{
			return FormatPrice(price.Value, f);
		}
		return "";
	}

	public string FormatSize(long size)
	{
		return GetRealSize(size).ToString((string)DPSeZ05FPZ4YGyPprd0r(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1346994499 ^ -1346989297), SizePrecision.ToString()));
	}

	public string FormatSize(double size, bool f = false)
	{
		return size.ToString((string)DPSeZ05FPZ4YGyPprd0r(f ? i91RyN5FAkoNOXEMw0s6(-710503328 ^ -710510120) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-839659358 ^ -839697136), SizePrecision.ToString()));
	}

	public string FormatFullSize(double size, bool f = false)
	{
		if (SizePrecision <= 0)
		{
			return size.ToString((f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1251569705 ^ -1251581329) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--855742383 ^ 0x33017A1D)) + SizePrecision);
		}
		return size.ToString(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-203064540 ^ -203057510));
	}

	public string FormatAvgSize(double size, bool f = false)
	{
		if (SizePrecision <= 0)
		{
			return size.ToString((string)(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7F645F3C ^ 0x7F64B2D0) : i91RyN5FAkoNOXEMw0s6(--855742383 ^ 0x33017A4B)));
		}
		return size.ToString((string)DPSeZ05FPZ4YGyPprd0r(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-838841832 ^ -838817888) : i91RyN5FAkoNOXEMw0s6(-176525661 ^ -176520431), SizePrecision.ToString()));
	}

	public string FormatFullSize(long size, bool f = false)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SizePrecision <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return GetRealSize(size).ToString((string)i91RyN5FAkoNOXEMw0s6(-1153206687 ^ -1153197089));
			default:
				return GetRealSize(size).ToString(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-839659358 ^ -839699186) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1380525184 ^ -1380567436));
			}
		}
	}

	public string FormatFullSize(long size, IFormatProvider provider, bool f = false)
	{
		if (SizePrecision <= 0)
		{
			return GetRealSize(size).ToString(f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x78D396D8 ^ 0x78D37374) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1416986301 ^ -1416991561), provider);
		}
		double realSize = GetRealSize(size);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
		{
			num = 0;
		}
		return num switch
		{
			_ => realSize.ToString((string)i91RyN5FAkoNOXEMw0s6(-123775059 ^ -123749869), provider), 
		};
	}

	public string FormatFullSize(long? size, bool f = false)
	{
		if (size.HasValue)
		{
			return FormatFullSize(size.Value, f);
		}
		return "";
	}

	public string FormatPnl(double pnl, bool f = false)
	{
		return pnl.ToString((f ? F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x130FEA25 ^ 0x130F079D) : F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x22BF43FC ^ 0x22BFAE4E)) + PnlPrecision);
	}

	public string FormatPnl(double? pnl, bool f = false)
	{
		if (!pnl.HasValue)
		{
			return "";
		}
		return FormatPnl(pnl.Value, f);
	}

	public string FormatTime(DateTime dt, string format)
	{
		return TimeHelper.FormatTime(dt, format, base.Exchange);
	}

	public string FormatTime(DateTime dt, string dateFormat, string timeFormat)
	{
		return TimeHelper.FormatTime(dt, dateFormat, base.Exchange) + (string)i91RyN5FAkoNOXEMw0s6(0x28B345BB ^ 0x28B31461) + TimeHelper.FormatTime(dt, timeFormat, base.Exchange);
	}

	public DateTime ConvertTimeToLocal(DateTime dt)
	{
		return M42uai5FJ9sPpj5Re0cV(dt, base.Exchange, false);
	}

	public DateTime ConvertTimeFromLocal(DateTime dt)
	{
		return fd0gqU5FF9s6UVvuRuPN(dt, base.Exchange, false);
	}

	public int? GetOffset(int? offset, double? offsetPercent, long price, bool isPercent)
	{
		if (!isPercent)
		{
			return offset;
		}
		if (!offsetPercent.HasValue)
		{
			return null;
		}
		return (int)(Math.Round((double)price * offsetPercent.Value / base.Step / 100.0, MidpointRounding.AwayFromZero) * base.Step);
	}

	public bool UpdateFields(Symbol symbol)
	{
		if (ID != symbol.ID)
		{
			return false;
		}
		bool flag = false;
		int num2;
		if (Diff(base.Step, symbol.Step))
		{
			int num = 8;
			num2 = num;
			goto IL_0009;
		}
		goto IL_02a1;
		IL_02a1:
		if (Precision != symbol.Precision)
		{
			num2 = 3;
			goto IL_0009;
		}
		goto IL_00c0;
		IL_00c0:
		if (Diff(base.SizeStep, symbol.SizeStep))
		{
			base.SizeStep = symbol.SizeStep;
			num2 = 7;
			goto IL_0009;
		}
		goto IL_023d;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 13:
				flag = true;
				num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c != 0)
				{
					num2 = 10;
				}
				continue;
			case 6:
				if (flag)
				{
					num2 = 12;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 11;
			case 5:
				goto IL_00fb;
			case 8:
				goto IL_0141;
			case 3:
				goto IL_0181;
			case 10:
				goto IL_01b6;
			case 11:
				return flag;
			case 9:
				Mapping = (string)SqAROF5Fz6vVoymhI3tF(symbol);
				flag = true;
				num2 = 5;
				continue;
			case 7:
				goto IL_0200;
			case 2:
				goto IL_0208;
			case 1:
				AdditionalData = symbol.AdditionalData;
				num2 = 6;
				continue;
			case 4:
				SizePrecision = symbol.SizePrecision;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				fMXvwX53H3IVscWeLDjQ((string)i91RyN5FAkoNOXEMw0s6(0x6E2DFBED ^ 0x6E2D1611) + ID);
				num2 = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
				{
					num2 = 6;
				}
				continue;
			}
			break;
		}
		goto IL_004b;
		IL_023d:
		if (!enTylK5F38D0P9ecqt63(LotStep, symbol.LotStep))
		{
			goto IL_01b6;
		}
		goto IL_0208;
		IL_0181:
		Precision = symbol.Precision;
		flag = true;
		goto IL_00c0;
		IL_00fb:
		if (SizePrecision != symbol.SizePrecision)
		{
			num2 = 4;
			goto IL_0009;
		}
		goto IL_004b;
		IL_01b6:
		if (Diff(MinQty, mYfAsx5FpumRdcWxeIIw(symbol)))
		{
			MinQty = symbol.MinQty;
			flag = true;
		}
		if (v6x8S05Fuc3Yh6YLdOS5(Mapping, symbol.Mapping))
		{
			num2 = 9;
			goto IL_0009;
		}
		goto IL_00fb;
		IL_004b:
		PointValue = MDL3uy530mcLB62eWjCQ(symbol);
		if (LotSize != symbol.LotSize)
		{
			LotSize = symbol.LotSize;
		}
		MinNotional = cnU57A532pNZ56TXvONr(symbol);
		if (IsDeleted != symbol.IsDeleted)
		{
			IsDeleted = symbol.IsDeleted;
		}
		base.ContractValue = symbol.ContractValue;
		num2 = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
		{
			num2 = 1;
		}
		goto IL_0009;
		IL_0208:
		LotStep = symbol.LotStep;
		num2 = 13;
		goto IL_0009;
		IL_0141:
		base.Step = symbol.Step;
		flag = true;
		goto IL_02a1;
		IL_0200:
		flag = true;
		goto IL_023d;
	}

	private static bool Diff(double a, double b)
	{
		double num = Math.Max(sqKnAm53fTg6E4VYc3vg(a), Math.Abs(b));
		double num2 = h06C4p539A5hbepM0OH3(1E-20, num * 1E-12);
		return sqKnAm53fTg6E4VYc3vg(a - b) > num2;
	}

	public override string ToString()
	{
		return Name;
	}

	public string GetBaseCurrency(bool excludeMultiplier = false)
	{
		SymbolType type = Type;
		int num;
		object obj;
		if (type == SymbolType.Future)
		{
			if (!IsMaster)
			{
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 != 0)
				{
					num = 2;
				}
			}
			else
			{
				string name = Name;
				if (name != null)
				{
					obj = ((object[])lWeFJD53nUZ7JBRmtwpQ(name, new char[1] { '/' }))[0];
					goto IL_018a;
				}
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f0ba3007e7244cca15e3c59471bb079 == 0)
				{
					num = 0;
				}
			}
		}
		else
		{
			num = 3;
		}
		goto IL_0009;
		IL_0009:
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 3:
			{
				if (type != SymbolType.Crypto)
				{
					return null;
				}
				string name3 = Name;
				text = ((name3 != null) ? name3.Split('/')[0] : null);
				goto case 1;
			}
			case 1:
				if (IsCrypto && excludeMultiplier)
				{
					text = RemoveMultipliers(text);
					num = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_57928f9519d54fffa57a74bbdde213e4 == 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 5;
			case 5:
				return text;
			case 2:
			{
				Symbol master = Master;
				if (master == null)
				{
					num = 4;
					continue;
				}
				string name2 = master.Name;
				obj = ((name2 != null) ? ((object[])lWeFJD53nUZ7JBRmtwpQ(name2, new char[1] { '/' }))[0] : null);
				break;
			}
			case 4:
				obj = null;
				break;
			default:
				obj = null;
				break;
			}
			break;
		}
		goto IL_018a;
		IL_018a:
		text = (string)obj;
		num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fa8be6623d5e44eaab7d6eddb44c1bc4 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private static string RemoveMultipliers(string input)
	{
		string result = default(string);
		try
		{
			int num = 0;
			int num2 = 2;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
			{
				num2 = 0;
			}
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 7:
					while (num3 >= num)
					{
						if (b9vAfW53YZZYL6phDqpK(Flq8l153G83RsA7KVGsN(input, num3)))
						{
							num3--;
							continue;
						}
						goto IL_00e8;
					}
					goto default;
				case 3:
					while (num <= num3)
					{
						if (char.IsDigit(Flq8l153G83RsA7KVGsN(input, num)))
						{
							num++;
							continue;
						}
						goto IL_008e;
					}
					goto case 7;
				case 6:
					num3 = dTwPcJ53oF7sFf0k5yeG(input) - 1;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					if (input[0] != '0')
					{
						num2 = 3;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 7;
				case 2:
					num3 = input.Length - 1;
					num2 = 4;
					continue;
				default:
					if (num3 < input.Length - 1 && input[num3 + 1] == '0')
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				case 1:
					result = (string)((num > 0 || num3 < input.Length - 1) ? veUdZ953v8IwtyCFA6E0(input, num, num3 - num + 1) : input);
					num2 = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
					{
						num2 = 5;
					}
					continue;
				case 5:
					break;
					IL_00e8:
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
					{
						num2 = 0;
					}
					continue;
					IL_008e:
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
		}
		catch (Exception)
		{
			result = input;
		}
		return result;
	}

	static Symbol()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool hG7uqb5FWXtxibHvLB77()
	{
		return gZD8ag5FIZ7vmQIeDf1X == null;
	}

	internal static Symbol PqSqlh5FtoDA4sJHlwuT()
	{
		return gZD8ag5FIZ7vmQIeDf1X;
	}

	internal static object M3u6455FUxTDQCYe35DI(object P_0)
	{
		return ((SymbolBase)P_0).Exchange;
	}

	internal static double y4JE2M5FToULnergOryK(object P_0)
	{
		return ((SymbolBase)P_0).Step;
	}

	internal static int vFW0pV5FyNesDXLDAShB(object P_0)
	{
		return ((Symbol)P_0).Precision;
	}

	internal static double htS2iV5FZWf47paNGuIR(object P_0)
	{
		return ((SymbolBase)P_0).SizeStep;
	}

	internal static int vqV9JQ5FVKNABwoSNegm(object P_0)
	{
		return ((Symbol)P_0).SizePrecision;
	}

	internal static int ra7cl95FCjIPbZU6o5E9(object P_0)
	{
		return ((Symbol)P_0).PnlPrecision;
	}

	internal static int Elj3825FrS65HtCgEHb4(object P_0)
	{
		return ((List<Symbol>)P_0).Count;
	}

	internal static DateTime dEmoAc5FKQGG8k7VWuQk(object P_0)
	{
		return ((Symbol)P_0).Expiration;
	}

	internal static bool Ry8wcV5Fmeb5IiCYWHYX(object P_0)
	{
		return ((Symbol)P_0).IsDeleted;
	}

	internal static DateTime Hs9KrR5FhuK5AK4DE6BN(object P_0)
	{
		return ((Symbol)P_0).RolloverDate;
	}

	internal static TimeSpan WOt3uP5Fw6OlggGcEoqr(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static bool pASc0g5F7pO2Grc7aoEE(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static long kTp7p75F83L6KO3emkNq(decimal P_0)
	{
		return (long)P_0;
	}

	internal static object i91RyN5FAkoNOXEMw0s6(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object DPSeZ05FPZ4YGyPprd0r(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static DateTime M42uai5FJ9sPpj5Re0cV(DateTime P_0, object P_1, bool P_2)
	{
		return TimeHelper.ConvertTimeToLocal(P_0, (string)P_1, P_2);
	}

	internal static DateTime fd0gqU5FF9s6UVvuRuPN(DateTime P_0, object P_1, bool P_2)
	{
		return TimeHelper.ConvertTimeFromLocal(P_0, (string)P_1, P_2);
	}

	internal static bool enTylK5F38D0P9ecqt63(double a, double b)
	{
		return Diff(a, b);
	}

	internal static double mYfAsx5FpumRdcWxeIIw(object P_0)
	{
		return ((Symbol)P_0).MinQty;
	}

	internal static bool v6x8S05Fuc3Yh6YLdOS5(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object SqAROF5Fz6vVoymhI3tF(object P_0)
	{
		return ((Symbol)P_0).Mapping;
	}

	internal static double MDL3uy530mcLB62eWjCQ(object P_0)
	{
		return ((Symbol)P_0).PointValue;
	}

	internal static double cnU57A532pNZ56TXvONr(object P_0)
	{
		return ((Symbol)P_0).MinNotional;
	}

	internal static void fMXvwX53H3IVscWeLDjQ(object P_0)
	{
		LogManager.WriteInfo((string)P_0);
	}

	internal static double sqKnAm53fTg6E4VYc3vg(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double h06C4p539A5hbepM0OH3(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static object lWeFJD53nUZ7JBRmtwpQ(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static char Flq8l153G83RsA7KVGsN(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static bool b9vAfW53YZZYL6phDqpK(char P_0)
	{
		return char.IsDigit(P_0);
	}

	internal static int dTwPcJ53oF7sFf0k5yeG(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object veUdZ953v8IwtyCFA6E0(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
