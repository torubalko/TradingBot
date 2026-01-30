using System;
using System.Runtime.CompilerServices;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Core.Utils.Binary;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.History;

public sealed class TicksReader : BinReader<TickEvent>, IDataReader<TickEvent>
{
	[Flags]
	internal enum N82P9Qaq9FfglKiBQlDC
	{
		None = 0,
		Last = 2,
		LastSize = 4,
		Bid = 8,
		Ask = 0x10,
		Conditions = 0x80
	}

	private static readonly string BuyStr;

	private static readonly string SellStr;

	private long _lastTimeStamp;

	private long _lastLast;

	private long _lastLastSize;

	private long _lastBid;

	private long _lastAsk;

	private long _lastOpenInterest;

	private long _lastMarketCenter;

	private byte _lastConditions;

	private readonly Symbol _symbol;

	private readonly double _realPriceStep;

	private readonly double _realSizeStep;

	private readonly bool _correctPrice;

	private readonly decimal _correctPriceFactor;

	private readonly bool _correctSize;

	private readonly decimal _correctSizeFactor;

	private readonly bool _forex;

	private readonly TimeSpan _timeOffset;

	private long _prevBid;

	private long _prevAsk;

	private Side _prevSide;

	internal static TicksReader fQ4S2L5wSA4w5POZkpph;

	public int Version { get; private set; }

	public double PriceStep { get; private set; }

	public double SizeStep { get; private set; }

	public TicksReader(Symbol symbol, byte[] data, double realPriceStep, double realSizeStep, TimeSpan timeOffset, bool forex = false)
	{
		AZGdma5weX71Usiqn240();
		base._002Ector(data);
		int num = 6;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				_correctPriceFactor = eGOGBF5wck1LwuFaZL8l(PriceStep) / eGOGBF5wck1LwuFaZL8l(_realPriceStep);
				goto IL_0135;
			case 5:
				_correctSizeFactor = (decimal)SizeStep / eGOGBF5wck1LwuFaZL8l(_realSizeStep);
				return;
			case 3:
				if (_correctPrice)
				{
					num = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
					{
						num = 2;
					}
					break;
				}
				goto IL_0135;
			default:
				PriceStep = o7qmcp5wXj93UxwoIFpx(this);
				if (Version == 3)
				{
					SizeStep = ReadDouble();
					num = 4;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a93fb37f4fb14fd7a8fe9a7679ccbe04 != 0)
					{
						num = 3;
					}
					break;
				}
				goto case 4;
			case 7:
				Version = RVdQFv5wsDVZZpao8dpJ(this);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
				{
					num = 0;
				}
				break;
			case 6:
				if (base.IsEmpty)
				{
					return;
				}
				_symbol = symbol;
				_realPriceStep = realPriceStep;
				_realSizeStep = realSizeStep;
				_forex = forex;
				_timeOffset = timeOffset;
				num = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 != 0)
				{
					num = 7;
				}
				break;
			case 4:
				_correctPrice = _realPriceStep > 0.0 && _realPriceStep != PriceStep;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				{
					_correctSize = _realSizeStep > 0.0 && SizeStep > 0.0 && _realSizeStep != SizeStep;
					num = 3;
					break;
				}
				IL_0135:
				if (_correctSize)
				{
					num = 5;
					break;
				}
				return;
			}
		}
	}

	protected override TickEvent ReadItem()
	{
		byte num = ReadByte();
		_prevBid = _lastBid;
		_prevAsk = _lastAsk;
		if ((num & 1) != 0)
		{
			_lastTimeStamp += o4Y6KG5wj13M6GgytK46(this);
		}
		if ((num & 2) != 0)
		{
			_lastLast += ReadLeb128();
		}
		if ((num & 4) != 0)
		{
			_lastLastSize = o4Y6KG5wj13M6GgytK46(this);
		}
		if ((num & 8) != 0)
		{
			_lastBid += o4Y6KG5wj13M6GgytK46(this);
		}
		if ((num & 0x10) != 0)
		{
			_lastAsk += ReadLeb128();
		}
		if ((num & 0x20) != 0)
		{
			_lastOpenInterest += ReadLeb128();
		}
		if ((num & 0x40) != 0)
		{
			_lastMarketCenter = o4Y6KG5wj13M6GgytK46(this);
		}
		if ((num & 0x80) != 0)
		{
			byte[] array = ReadStringAsBytes();
			_lastConditions = (byte)((array.Length != 0) ? array[0] : 0);
		}
		long num2 = _lastLast;
		int num3 = 10;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
		{
			num3 = 10;
		}
		long num6 = default(long);
		Side side = default(Side);
		long num8 = default(long);
		long num4 = default(long);
		while (true)
		{
			int num5;
			int num7;
			switch (num3)
			{
			case 5:
				num6 = NeU8eb5wE2m7pD9l0lIS(Math.Round(Ik0B905wQe5B2M1QjPS5(num6) * _correctPriceFactor, MidpointRounding.AwayFromZero));
				num3 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
				{
					num3 = 0;
				}
				continue;
			case 7:
				num5 = 1;
				goto IL_046a;
			case 11:
				if (_lastBid <= _prevBid)
				{
					if (_lastBid < _prevBid)
					{
						num3 = 14;
						continue;
					}
					if (_lastAsk <= _prevAsk)
					{
						if (_lastAsk < _prevAsk)
						{
							int num9 = 13;
							num3 = num9;
							continue;
						}
						side = _prevSide;
						goto case 4;
					}
					num3 = 16;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a00a0a595d0940febaa0173bc44df36c == 0)
					{
						num3 = 13;
					}
					continue;
				}
				side = Side.Buy;
				num3 = 3;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
				{
					num3 = 4;
				}
				continue;
			default:
				num8 = _lastLastSize;
				if (_correctSize)
				{
					num8 = (long)Math.Round(fpWI2R5wdvfrHyHRRlgD(num8, _correctSizeFactor), MidpointRounding.AwayFromZero);
					num3 = 6;
					continue;
				}
				goto case 6;
			case 10:
				num4 = _lastBid;
				num6 = _lastAsk;
				if (_correctPrice)
				{
					num2 = NeU8eb5wE2m7pD9l0lIS(Math.Round((decimal)num2 * _correctPriceFactor, MidpointRounding.AwayFromZero));
					num3 = 9;
					continue;
				}
				goto default;
			case 1:
				if (_lastBid == 0L)
				{
					num3 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
					{
						num3 = 2;
					}
					continue;
				}
				goto case 3;
			case 16:
				side = Side.Buy;
				num3 = 8;
				continue;
			case 15:
				num7 = 1;
				goto IL_0477;
			case 3:
				if (_lastLast < _lastAsk)
				{
					goto case 15;
				}
				num7 = 0;
				goto IL_0477;
			case 14:
				side = Side.Sell;
				goto case 4;
			case 13:
				side = Side.Sell;
				goto case 4;
			case 6:
				if (_forex)
				{
					num3 = 11;
					continue;
				}
				goto case 1;
			case 4:
			case 8:
				_prevSide = side;
				break;
			case 2:
				if (_lastAsk != 0L)
				{
					goto case 3;
				}
				if (_lastConditions != 66)
				{
					num3 = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
					{
						num3 = 7;
					}
					continue;
				}
				num5 = 0;
				goto IL_046a;
			case 9:
				num4 = (long)Math.Round(Ik0B905wQe5B2M1QjPS5(num4) * _correctPriceFactor, MidpointRounding.AwayFromZero);
				num3 = 5;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
				{
					num3 = 1;
				}
				continue;
			case 12:
				break;
				IL_0477:
				side = (Side)num7;
				break;
				IL_046a:
				side = (Side)num5;
				num3 = 12;
				continue;
			}
			break;
		}
		TickEvent tickEvent = IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY(_symbol);
		tickEvent.Time = new DateTime(_lastTimeStamp).Add(_timeOffset);
		tickEvent.Price = num2;
		tickEvent.Size = (_forex ? 100000000 : num8);
		tickEvent.Bid = num4;
		tickEvent.Ask = num6;
		lGrPHP5wg8Gg1Zfu9VaE(tickEvent, _lastOpenInterest);
		ffQJRU5wRLwO4U38jxL7(tickEvent, _lastMarketCenter);
		tickEvent.Conditions = ((_lastConditions == 66) ? BuyStr : SellStr);
		tickEvent.Side = side;
		return tickEvent;
	}

	public override void Reset()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				_lastTimeStamp = 0L;
				_lastLast = 0L;
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_lastLastSize = 0L;
				_lastBid = 0L;
				_lastAsk = 0L;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_lastConditions = 0;
				_prevBid = 0L;
				_prevAsk = 0L;
				_prevSide = Side.Sell;
				return;
			case 4:
				if (Version == 3)
				{
					SizeStep = ReadDouble();
					num2 = 5;
					break;
				}
				goto case 5;
			case 3:
				base.Reset();
				num2 = 2;
				break;
			default:
				_lastOpenInterest = 0L;
				_lastMarketCenter = 0L;
				num2 = 6;
				break;
			case 7:
				PriceStep = o7qmcp5wXj93UxwoIFpx(this);
				num2 = 4;
				break;
			case 2:
				if (!JcNTB05w65vPyDiVIbFO(this))
				{
					Version = RVdQFv5wsDVZZpao8dpJ(this);
					num2 = 7;
					break;
				}
				goto case 5;
			}
		}
	}

	static TicksReader()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		f8hgc55wMDvNYJkdRZDm();
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		BuyStr = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(--871424829 ^ 0x33F00689);
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
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
				SellStr = F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x741B85CB ^ 0x741B6071);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_5a00a8f236ab4094a78e373adc786558 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[SpecialName]
	bool IDataReader<TickEvent>.get_IsEmpty()
	{
		return base.IsEmpty;
	}

	[SpecialName]
	TickEvent IDataReader<TickEvent>.get_LastItem()
	{
		return base.LastItem;
	}

	[SpecialName]
	TickEvent IDataReader<TickEvent>.get_PrevItem()
	{
		return base.PrevItem;
	}

	bool IDataReader<TickEvent>.Read()
	{
		return oCCqxD5wOf9V0Wk0koab(this);
	}

	internal static bool gBlLUp5wxEvWp7ThMn0C()
	{
		return fQ4S2L5wSA4w5POZkpph == null;
	}

	internal static TicksReader EIDMPA5wLMRrs4JUrx7W()
	{
		return fQ4S2L5wSA4w5POZkpph;
	}

	internal static void AZGdma5weX71Usiqn240()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static int RVdQFv5wsDVZZpao8dpJ(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).ReadInt32();
	}

	internal static double o7qmcp5wXj93UxwoIFpx(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).ReadDouble();
	}

	internal static decimal eGOGBF5wck1LwuFaZL8l(double P_0)
	{
		return (decimal)P_0;
	}

	internal static long o4Y6KG5wj13M6GgytK46(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).ReadLeb128();
	}

	internal static long NeU8eb5wE2m7pD9l0lIS(decimal P_0)
	{
		return (long)P_0;
	}

	internal static decimal Ik0B905wQe5B2M1QjPS5(long P_0)
	{
		return P_0;
	}

	internal static decimal fpWI2R5wdvfrHyHRRlgD(decimal P_0, decimal P_1)
	{
		return P_0 * P_1;
	}

	internal static void lGrPHP5wg8Gg1Zfu9VaE(object P_0, long P_1)
	{
		((TickEvent)P_0).OpenInterest = P_1;
	}

	internal static void ffQJRU5wRLwO4U38jxL7(object P_0, long P_1)
	{
		((TickEvent)P_0).MarketCenter = P_1;
	}

	internal static bool JcNTB05w65vPyDiVIbFO(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).IsEmpty;
	}

	internal static void f8hgc55wMDvNYJkdRZDm()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool oCCqxD5wOf9V0Wk0koab(object P_0)
	{
		return ((BinReader<TickEvent>)P_0).Read();
	}
}
