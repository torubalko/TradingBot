using System;
using System.Runtime.Serialization;
using BfZtb759KlUg4482QKym;
using EyD6NKGhRYBSlyBqPfrJ;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Time;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

[DataContract(Name = "ExitStrategyTarget", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Tc.Storage")]
public sealed class ExitStrategyTarget : ICloneable
{
	private long _quantity;

	private long _stopLossPrice;

	private long? _stopLossSize;

	private long _stopLossTrailingRange;

	private long _stopLossTrailingStep;

	private long _stopLossBreakevenProfit;

	private long _stopLossBreakevenPlus;

	private int? _stopLossOffset;

	private bool _slSynchronized;

	private long _takeProfitPrice;

	private long? _takeProfitSize;

	private long _takeProfitRange;

	private int? _takeProfitOffset;

	private bool _takeProfitStopActive;

	private bool _tpSynchronized;

	internal static ExitStrategyTarget UKpqDI5JsVErmFdnAk3Q;

	public DateTime UpdateTime { get; private set; }

	[DataMember(Name = "ID")]
	public string ID { get; set; }

	[DataMember(Name = "Quantity")]
	public long Quantity
	{
		get
		{
			return _quantity;
		}
		set
		{
			_quantity = Math.Max(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossPrice")]
	public long StopLossPrice
	{
		get
		{
			return _stopLossPrice;
		}
		set
		{
			_stopLossPrice = Math.Max(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossSize")]
	public long? StopLossSize
	{
		get
		{
			return _stopLossSize;
		}
		set
		{
			if (value.HasValue)
			{
				value = Math.Max(0L, value.Value);
			}
			_stopLossSize = value;
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossRange")]
	public long StopLossTrailingRange
	{
		get
		{
			return _stopLossTrailingRange;
		}
		set
		{
			_stopLossTrailingRange = g0YMBJ5JjT1i4f156YjX(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossTrailingStep")]
	public long StopLossTrailingStep
	{
		get
		{
			return _stopLossTrailingStep;
		}
		set
		{
			_stopLossTrailingStep = g0YMBJ5JjT1i4f156YjX(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossBreakevenProfit")]
	public long StopLossBreakevenProfit
	{
		get
		{
			return _stopLossBreakevenProfit;
		}
		set
		{
			_stopLossBreakevenProfit = Math.Max(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "StopLossBreakevenPlus")]
	public long StopLossBreakevenPlus
	{
		get
		{
			return _stopLossBreakevenPlus;
		}
		set
		{
			_stopLossBreakevenPlus = Math.Max(0L, value);
			UpdateTime = hhAEV85JE1tX5dWv94oH();
		}
	}

	[DataMember(Name = "StopLossOffset")]
	public int? StopLossOffset
	{
		get
		{
			return _stopLossOffset;
		}
		set
		{
			if (value < 0)
			{
				value = null;
			}
			_stopLossOffset = value;
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	internal Order SlOrder { get; set; }

	[DataMember(Name = "SlOrderID")]
	public string SlOrderID { get; set; }

	public bool SlSynchronized
	{
		get
		{
			return _slSynchronized;
		}
		set
		{
			if (value != _slSynchronized)
			{
				_slSynchronized = value;
				int num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				UpdateTime = TimeHelper.LocalTime;
			}
		}
	}

	public bool IsSlSynchronizedOrLocal
	{
		get
		{
			if (Acj0FgGhg83F5A0lfPa4.Qj8Ghy1C3Ho())
			{
				return SlSynchronized;
			}
			return true;
		}
	}

	[DataMember(Name = "TakeProfitPrice")]
	public long TakeProfitPrice
	{
		get
		{
			return _takeProfitPrice;
		}
		set
		{
			_takeProfitPrice = Math.Max(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "TakeProfitSize")]
	public long? TakeProfitSize
	{
		get
		{
			return _takeProfitSize;
		}
		set
		{
			if (value.HasValue)
			{
				value = Math.Max(0L, value.Value);
			}
			_takeProfitSize = value;
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "TakeProfitRange")]
	public long TakeProfitRange
	{
		get
		{
			return _takeProfitRange;
		}
		set
		{
			_takeProfitRange = g0YMBJ5JjT1i4f156YjX(0L, value);
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "TakeProfitOffset")]
	public int? TakeProfitOffset
	{
		get
		{
			return _takeProfitOffset;
		}
		set
		{
			if (value < 0)
			{
				value = null;
			}
			_takeProfitOffset = value;
			UpdateTime = TimeHelper.LocalTime;
		}
	}

	[DataMember(Name = "TakeProfitStopActive")]
	public bool TakeProfitStopActive
	{
		get
		{
			return _takeProfitStopActive;
		}
		set
		{
			_takeProfitStopActive = value;
			UpdateTime = hhAEV85JE1tX5dWv94oH();
		}
	}

	internal Order TpOrder { get; set; }

	[DataMember(Name = "TpOrderID")]
	public string TpOrderID { get; set; }

	public bool TpSynchronized
	{
		get
		{
			return _tpSynchronized;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (value == _tpSynchronized)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
						{
							num2 = 0;
						}
						break;
					}
					_tpSynchronized = value;
					UpdateTime = TimeHelper.LocalTime;
					return;
				case 0:
					return;
				}
			}
		}
	}

	public bool IsTpSynchronizedOrLocal
	{
		get
		{
			if (Acj0FgGhg83F5A0lfPa4.vGkGhC0G3TP())
			{
				return TpSynchronized;
			}
			return true;
		}
	}

	public DateTime SlTpUpdateTime { get; set; }

	public bool IsServerOrderTP { get; set; }

	public bool IsServerOrderSl { get; set; }

	public ExitStrategyTarget()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		ID = Guid.NewGuid().ToString();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal void Update(UserPosition position, long bid, long ask, long lastPrice)
	{
		long size = position.Size;
		long num = RLhI0y5JQYDxMW6nrjeH(position);
		long num2 = ((size > 0) ? (lastPrice - num) : (num - lastPrice));
		int num3 = 11;
		while (true)
		{
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					if (StopLossBreakevenProfit > 0)
					{
						num4 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 != 0)
						{
							num4 = 1;
						}
						continue;
					}
					goto case 10;
				case 9:
					StopLossPrice = num + StopLossBreakevenPlus;
					num4 = 10;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
					{
						num4 = 5;
					}
					continue;
				case 3:
					StopLossPrice = num - StopLossBreakevenPlus;
					goto case 10;
				case 4:
				case 12:
				case 13:
					if (StopLossPrice > 0)
					{
						num4 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_4f84702cc6834fdb9f44daed1fd8e55b != 0)
						{
							num4 = 0;
						}
						continue;
					}
					goto case 10;
				case 7:
					if (StopLossPrice < num)
					{
						num3 = 9;
						break;
					}
					goto case 10;
				case 11:
					if (lastPrice == 0L)
					{
						num2 = s3TocU5JdwaWCHCH56Ey(position);
						num4 = 14;
						continue;
					}
					goto case 14;
				case 5:
					TakeProfitStopActive = true;
					return;
				case 2:
					if (StopLossTrailingRange > 0)
					{
						if (size <= 0)
						{
							if (StopLossPrice - ask <= StopLossTrailingRange + Math.Max(0L, StopLossTrailingStep - 1))
							{
								num4 = 12;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
								{
									num4 = 1;
								}
							}
							else
							{
								StopLossPrice = ask + StopLossTrailingRange;
								num4 = 4;
							}
							continue;
						}
						if (bid - StopLossPrice > StopLossTrailingRange + g0YMBJ5JjT1i4f156YjX(0L, StopLossTrailingStep - 1))
						{
							goto case 15;
						}
					}
					goto case 4;
				case 10:
					if (TakeProfitPrice <= 0 || TakeProfitRange <= 0)
					{
						return;
					}
					if (size <= 0)
					{
						if (TakeProfitPrice < ask)
						{
							return;
						}
						TakeProfitPrice = ask;
						num4 = 5;
					}
					else
					{
						num4 = 8;
					}
					continue;
				case 1:
					if (size > 0)
					{
						if (num2 >= StopLossBreakevenProfit)
						{
							num3 = 7;
							break;
						}
					}
					else if (num2 >= StopLossBreakevenProfit && StopLossPrice > num)
					{
						num4 = 3;
						continue;
					}
					goto case 10;
				case 15:
					StopLossPrice = bid - StopLossTrailingRange;
					num4 = 13;
					continue;
				case 6:
					TakeProfitStopActive = true;
					return;
				case 8:
					if (TakeProfitPrice > bid)
					{
						return;
					}
					TakeProfitPrice = bid;
					num4 = 5;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c != 0)
					{
						num4 = 6;
					}
					continue;
				case 14:
					if (StopLossPrice > 0)
					{
						num4 = 2;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	internal bool CheckStopLoss(UserPosition position, long lastPrice)
	{
		int num = 4;
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!KujNuh5JgHBsHeMDsapi(position.Symbol))
					{
						goto IL_005c;
					}
					goto case 5;
				case 1:
					return false;
				case 5:
					if (((Symbol)H0M8KM5JRxeLstLj74VC(position)).Type != SymbolType.Crypto)
					{
						goto IL_005c;
					}
					goto IL_005e;
				case 2:
					return StopLossPrice <= lastPrice;
				case 4:
					if (Acj0FgGhg83F5A0lfPa4.Qj8Ghy1C3Ho())
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_dcfa3a019743403299410dca8ba03e4c == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_005e;
				case 6:
					if (num3 >= 0)
					{
						return false;
					}
					num2 = 2;
					break;
				case 3:
					{
						if (position.Symbol != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_005c;
					}
					IL_005c:
					return false;
					IL_005e:
					num3 = taOBKU5J6R9ZF5Utl4ud(position);
					if (num3 == 0L)
					{
						num2 = 1;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 != 0)
						{
							num2 = 1;
						}
						break;
					}
					if (lastPrice > 0)
					{
						if (StopLossPrice > 0)
						{
							if (num3 > 0)
							{
								if (StopLossPrice >= lastPrice)
								{
									return true;
								}
								goto end_IL_0012;
							}
							goto case 6;
						}
						return false;
					}
					goto case 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 6;
		}
	}

	public void ClearSl()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				StopLossTrailingRange = 0L;
				StopLossTrailingStep = 0L;
				StopLossBreakevenProfit = 0L;
				StopLossBreakevenPlus = 0L;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				StopLossPrice = 0L;
				num2 = 2;
				break;
			case 1:
				StopLossOffset = null;
				SlOrderID = null;
				SlSynchronized = false;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void RemoveSlTrailing()
	{
		StopLossTrailingRange = 0L;
		StopLossTrailingStep = 0L;
	}

	internal bool CheckTakeProfit(UserPosition position, long bid, long ask, long lastPrice)
	{
		int num = 3;
		int num2 = num;
		long size = default(long);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return true;
			case 3:
				if (Acj0FgGhg83F5A0lfPa4.vGkGhC0G3TP())
				{
					num2 = 2;
					break;
				}
				goto case 6;
			case 12:
				if (TakeProfitPrice - TakeProfitRange < lastPrice)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_91fb7809389f4424adc9e876d4e4cb71 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				return false;
			case 6:
				size = position.Size;
				num2 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				if (TakeProfitPrice >= ask)
				{
					num2 = 8;
					break;
				}
				goto IL_022c;
			case 2:
				if (TakeProfitRange != 0L)
				{
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_01a9a95496084b1e91fc56ed159028fd == 0)
					{
						num2 = 6;
					}
					break;
				}
				if (H0M8KM5JRxeLstLj74VC(position) == null || !((Symbol)H0M8KM5JRxeLstLj74VC(position)).IsTigerX)
				{
					goto case 1;
				}
				if (((Symbol)H0M8KM5JRxeLstLj74VC(position)).Type != SymbolType.Crypto)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			case 5:
				if (size != 0L && TakeProfitPrice != 0L && bid > 0 && ask > 0 && lastPrice > 0)
				{
					if (TakeProfitRange <= 0)
					{
						if (size <= 0 || TakeProfitPrice > bid)
						{
							if (size < 0)
							{
								num2 = 11;
								break;
							}
							goto IL_022c;
						}
						goto case 8;
					}
					num2 = 10;
					break;
				}
				goto case 7;
			case 8:
				return true;
			default:
				if (size < 0 && TakeProfitPrice + TakeProfitRange <= lastPrice)
				{
					num2 = 4;
					break;
				}
				goto IL_022c;
			case 7:
				return false;
			case 10:
				{
					if (!TakeProfitStopActive)
					{
						return false;
					}
					if (TakeProfitPrice > 0)
					{
						if (size <= 0)
						{
							num2 = 9;
							break;
						}
						goto case 12;
					}
					goto IL_022c;
				}
				IL_022c:
				return false;
			}
		}
	}

	public void ClearTp()
	{
		TakeProfitPrice = 0L;
		TakeProfitRange = 0L;
		TakeProfitOffset = null;
		TakeProfitStopActive = false;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				TpSynchronized = false;
				return;
			}
			TpOrderID = null;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e68bfca50a3341a1ad5f97fbde9bcf8f != 0)
			{
				num = 1;
			}
		}
	}

	public void RemoveTpTrailing()
	{
		TakeProfitRange = 0L;
		TakeProfitStopActive = false;
	}

	internal void SaveOrderIDs()
	{
		if (!string.IsNullOrEmpty(SlOrder?.OrderID))
		{
			SlOrderID = SlOrder.OrderID;
		}
		Order tpOrder = TpOrder;
		int num;
		if (tpOrder == null)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		object value = tpOrder.OrderID;
		goto IL_00be;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				goto IL_0020;
			}
			break;
			IL_0020:
			TpOrderID = TpOrder.OrderID;
			num = 2;
		}
		value = null;
		goto IL_00be;
		IL_00be:
		if (string.IsNullOrEmpty((string)value))
		{
			return;
		}
		num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13a5ccb7e7c94d3d800c9001e431102c != 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public object Clone()
	{
		ExitStrategyTarget obj = new ExitStrategyTarget
		{
			ID = ID,
			Quantity = Quantity,
			StopLossPrice = StopLossPrice,
			StopLossSize = StopLossSize,
			StopLossTrailingRange = StopLossTrailingRange
		};
		w3jufx5JM2IxoDpgqZpa(obj, StopLossTrailingStep);
		obj.StopLossBreakevenProfit = StopLossBreakevenProfit;
		KfVxf85JOmStFC6joqnH(obj, StopLossBreakevenPlus);
		obj.StopLossOffset = StopLossOffset;
		eVR7Up5JqEBrsiW4j4Dj(obj, SlOrderID);
		U9MGVK5JI8nbCveU4nJP(obj, TakeProfitPrice);
		obj.TakeProfitSize = TakeProfitSize;
		Uq56Pr5JWgC7PDGvea1E(obj, TakeProfitRange);
		obj.TakeProfitOffset = TakeProfitOffset;
		LjnG1n5JtSQycCQ3DAwI(obj, TakeProfitStopActive);
		obj.TpOrderID = TpOrderID;
		return obj;
	}

	static ExitStrategyTarget()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		h2NqPf5JUXU29ylioR6R();
	}

	internal static bool qkaZRH5JXslDgvBSe4D8()
	{
		return UKpqDI5JsVErmFdnAk3Q == null;
	}

	internal static ExitStrategyTarget KPlT1K5Jcumtjw16sCbB()
	{
		return UKpqDI5JsVErmFdnAk3Q;
	}

	internal static long g0YMBJ5JjT1i4f156YjX(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static DateTime hhAEV85JE1tX5dWv94oH()
	{
		return TimeHelper.LocalTime;
	}

	internal static long RLhI0y5JQYDxMW6nrjeH(object P_0)
	{
		return ((UserPosition)P_0).Price;
	}

	internal static long s3TocU5JdwaWCHCH56Ey(object P_0)
	{
		return ((UserPosition)P_0).PositionPnl;
	}

	internal static bool KujNuh5JgHBsHeMDsapi(object P_0)
	{
		return ((Symbol)P_0).IsTigerX;
	}

	internal static object H0M8KM5JRxeLstLj74VC(object P_0)
	{
		return ((UserPosition)P_0).Symbol;
	}

	internal static long taOBKU5J6R9ZF5Utl4ud(object P_0)
	{
		return ((UserPosition)P_0).Size;
	}

	internal static void w3jufx5JM2IxoDpgqZpa(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).StopLossTrailingStep = value;
	}

	internal static void KfVxf85JOmStFC6joqnH(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).StopLossBreakevenPlus = value;
	}

	internal static void eVR7Up5JqEBrsiW4j4Dj(object P_0, object P_1)
	{
		((ExitStrategyTarget)P_0).SlOrderID = (string)P_1;
	}

	internal static void U9MGVK5JI8nbCveU4nJP(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).TakeProfitPrice = value;
	}

	internal static void Uq56Pr5JWgC7PDGvea1E(object P_0, long value)
	{
		((ExitStrategyTarget)P_0).TakeProfitRange = value;
	}

	internal static void LjnG1n5JtSQycCQ3DAwI(object P_0, bool value)
	{
		((ExitStrategyTarget)P_0).TakeProfitStopActive = value;
	}

	internal static void h2NqPf5JUXU29ylioR6R()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
