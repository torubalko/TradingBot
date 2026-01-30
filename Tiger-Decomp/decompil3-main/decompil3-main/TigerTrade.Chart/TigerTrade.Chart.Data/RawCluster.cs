using System;
using System.Collections.Generic;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using r50ZyQiVNgUadMUpmdGM;
using si2GxtiV7WWd0YCfRruL;

namespace TigerTrade.Chart.Data;

public sealed class RawCluster : IRawCluster
{
	private rcFMeOiVb9wNuGqUo22t _maxValues;

	private ALgewPiVwVgOfGidVVg6 _valueArea;

	private readonly Dictionary<long, RawClusterItem> _items;

	private readonly SortedSet<long> _prices;

	internal static RawCluster nDND7feIUqdYd51ODapi;

	public DateTime Time { get; }

	public DateTime OpenTime { get; private set; }

	public DateTime CloseTime { get; private set; }

	public long Open { get; set; }

	public long High { get; set; }

	public long Low { get; set; }

	public long Close { get; set; }

	public long Bid { get; private set; }

	public long Ask { get; private set; }

	public int BidTrades { get; private set; }

	public int AskTrades { get; private set; }

	public long OpenPos { get; private set; }

	public long OpenPosHigh { get; private set; }

	public long OpenPosLow { get; private set; }

	public long OpenPosBidChg { get; private set; }

	public long OpenPosAskChg { get; private set; }

	public long DeltaHigh { get; private set; }

	public long DeltaLow { get; private set; }

	public long Volume => Ask + Bid;

	public long Delta => Ask - Bid;

	public int Trades => AskTrades + BidTrades;

	public long OpenPosChg => OpenPosBidChg + OpenPosAskChg;

	public long BidQuote { get; private set; }

	public long AskQuote { get; private set; }

	public long VolumeQuote => AskQuote + BidQuote;

	public long DeltaQuote => AskQuote - BidQuote;

	public bool IsUp { get; set; }

	public IRawClusterMaxValues MaxValues
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
					if (_maxValues == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					_maxValues = new rcFMeOiVb9wNuGqUo22t();
					break;
				}
				break;
			}
			if (bdNSraeIZI99WEHTUuMo(_maxValues))
			{
				_maxValues.rX0iVkY9rYC(_items);
			}
			return _maxValues;
		}
	}

	IReadOnlyCollection<IRawClusterItem> IRawCluster.Items
	{
		get
		{
			try
			{
				return _items.Values;
			}
			catch (Exception)
			{
				return (IReadOnlyCollection<IRawClusterItem>)(object)Array.Empty<IRawClusterItem>();
			}
		}
	}

	SortedSet<long> IRawCluster.Prices
	{
		get
		{
			try
			{
				return _prices;
			}
			catch (Exception)
			{
				return new SortedSet<long>();
			}
		}
	}

	public RawCluster(DateTime time)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		_items = new Dictionary<long, RawClusterItem>();
		_prices = new SortedSet<long>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				OpenPosLow = long.MaxValue;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				Time = time;
				OpenPosHigh = long.MinValue;
				num = 2;
				break;
			}
		}
	}

	public void AddTick(IRawTick tick, int scale)
	{
		int num = 12;
		long num3 = default(long);
		RawClusterItem rawClusterItem = default(RawClusterItem);
		long num4 = default(long);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num6;
				switch (num2)
				{
				case 14:
					if (!_items.ContainsKey(num3))
					{
						num2 = 19;
						continue;
					}
					goto IL_0400;
				case 19:
					_items.Add(num3, new RawClusterItem(num3));
					_prices.Add(num3);
					goto IL_0400;
				case 11:
					num6 = f2mNTHeIVe1AbPMsKGPb(tick);
					goto IL_0505;
				case 21:
				{
					RawClusterItem rawClusterItem4 = rawClusterItem;
					rawClusterItem4.OpenPosAsk = NrO26oeIJ2HP08yDgrSr(rawClusterItem4) + num4;
					goto case 2;
				}
				case 15:
					OpenPosHigh = M2uNy7eIClufR7gxJZOQ(OpenPosHigh, OpenPos);
					OpenPosLow = Math.Min(OpenPosLow, OpenPos);
					goto IL_038e;
				default:
					Bid += IVEkwseIh9o0UL5Porfw(tick);
					BidQuote += ScaleValue(IVEkwseIh9o0UL5Porfw(tick) * f2mNTHeIVe1AbPMsKGPb(tick), scale);
					num5 = BidTrades++;
					OpenPosBidChg += num4;
					num2 = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
					{
						num2 = 17;
					}
					continue;
				case 8:
					if (!fJOxW0eImabrMQYP5JAx(tick))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						Ask += IVEkwseIh9o0UL5Porfw(tick);
						AskQuote += ScaleValue(tick.Size * f2mNTHeIVe1AbPMsKGPb(tick), scale);
						num2 = 9;
					}
					continue;
				case 9:
					num5 = AskTrades;
					num2 = 6;
					continue;
				case 6:
				{
					AskTrades = num5 + 1;
					OpenPosAskChg += num4;
					RawClusterItem rawClusterItem5 = rawClusterItem;
					oE9KaheIPMXKns4MYWDy(rawClusterItem5, IKckcyeIAGcLFDLJ6wMq(rawClusterItem5) + tick.Size);
					rawClusterItem.AskQuote += ScaleValue(IVEkwseIh9o0UL5Porfw(tick) * f2mNTHeIVe1AbPMsKGPb(tick), scale);
					num = 5;
					break;
				}
				case 20:
					OpenTime = tick.Time;
					num2 = 10;
					continue;
				case 18:
					Low = sAxyFleIrOU8H1uQFY3T(Low, num3);
					goto IL_00c7;
				case 10:
					Open = num3;
					High = num3;
					num2 = 3;
					continue;
				case 12:
					if (scale <= 1)
					{
						num2 = 11;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
						{
							num2 = 3;
						}
						continue;
					}
					num6 = ScaleValue(tick.Price, scale);
					goto IL_0505;
				case 5:
					num5 = rawClusterItem.AskTrades++;
					num2 = 21;
					continue;
				case 16:
					OpenPos = tick.OpenInterest;
					num2 = 15;
					continue;
				case 3:
					Low = num3;
					goto IL_00c7;
				case 4:
					if (tick.OpenInterest > 0)
					{
						num2 = 16;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto IL_038e;
				case 17:
				{
					RawClusterItem rawClusterItem3 = rawClusterItem;
					CFJQ8weIw2YPjU0DyQqZ(rawClusterItem3, rawClusterItem3.Bid + IVEkwseIh9o0UL5Porfw(tick));
					rawClusterItem.BidQuote += Jd1Qd2eI7OnUcPV4gxPN(tick.Size * f2mNTHeIVe1AbPMsKGPb(tick), scale);
					num = 13;
					break;
				}
				case 13:
				{
					RawClusterItem rawClusterItem2 = rawClusterItem;
					num5 = rawClusterItem2.BidTrades;
					XINX4oeI8rLXMNbfuks9(rawClusterItem2, num5 + 1);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				case 2:
					DeltaHigh = Math.Max(DeltaHigh, Delta);
					DeltaLow = Math.Min(DeltaLow, Delta);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					rawClusterItem.OpenPosBid += num4;
					num2 = 2;
					continue;
				case 7:
					{
						if (Open != 0L)
						{
							High = M2uNy7eIClufR7gxJZOQ(High, num3);
							num2 = 18;
							continue;
						}
						num2 = 20;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					IL_0400:
					rawClusterItem = _items[num3];
					num4 = ((OpenPos > 0 && tick.OpenInterest > 0) ? (tick.OpenInterest - OpenPos) : 0);
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
					{
						num2 = 8;
					}
					continue;
					IL_0505:
					num3 = num6;
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 == 0)
					{
						num2 = 2;
					}
					continue;
					IL_038e:
					UpdateData();
					return;
					IL_00c7:
					CloseTime = MLIp66eIKTmmPidIgh04(tick);
					Close = num3;
					num2 = 14;
					continue;
				}
				break;
			}
		}
	}

	public void AddCluster(IRawCluster cluster)
	{
		int num;
		if (Open == 0L)
		{
			Open = cluster.Open;
			num = 2;
			goto IL_0009;
		}
		goto IL_002b;
		IL_002b:
		Close = BtZP4EeIFKKKH4Epssi4(cluster);
		num = 4;
		goto IL_0009;
		IL_0009:
		long delta = default(long);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			default:
				DeltaHigh = M2uNy7eIClufR7gxJZOQ(DeltaHigh, delta + T1vDGKeIu5XfSQaORY5j(cluster));
				DeltaLow = Math.Min(DeltaLow, delta + cluster.DeltaLow);
				num = 5;
				continue;
			case 1:
				foreach (IRawClusterItem item in cluster.Items)
				{
					AddItem(item);
					int num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e != 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				goto case 3;
			case 5:
				return;
			case 4:
				if (OpenTime == DateTime.MinValue)
				{
					OpenTime = FA2GjeeI3RakdqjB0oVq(cluster);
				}
				CloseTime = bLvwcMeIp5mUIZBPrvHF(cluster);
				delta = Delta;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
				{
					num = 1;
				}
				continue;
			case 3:
				OpenPos = cluster.OpenPos;
				OpenPosHigh = Math.Max(OpenPosHigh, cluster.OpenPosHigh);
				OpenPosLow = Math.Min(OpenPosLow, cluster.OpenPosLow);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_002b;
	}

	public void AddItem(IRawClusterItem item)
	{
		long price = item.Price;
		int num;
		if (_items.ContainsKey(price))
		{
			num = 5;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
			{
				num = 1;
			}
		}
		else
		{
			_items.Add(price, new RawClusterItem(item));
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				_prices.Add(price);
				goto IL_0068;
			case 2:
				if (price > High)
				{
					High = price;
					num = 7;
					break;
				}
				goto case 7;
			default:
				_items[price].Add(item);
				goto IL_0068;
			case 4:
				AskTrades += item.AskTrades;
				OpenPosBidChg += qKxo0deIz2c5oaAv1Ova(item);
				OpenPosAskChg += item.OpenPosAsk;
				num = 2;
				break;
			case 3:
				return;
			case 7:
				if (Low == 0L || price < Low)
				{
					Low = price;
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
					{
						num = 3;
					}
					break;
				}
				return;
			case 1:
				{
					AskQuote += item.AskQuote;
					BidTrades += item.BidTrades;
					int num2 = 4;
					num = num2;
					break;
				}
				IL_0068:
				Bid += item.Bid;
				Ask += item.Ask;
				BidQuote += item.BidQuote;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public void UpdateData()
	{
		if (_maxValues != null)
		{
			_maxValues.SwniV6CASEO(_0020: true);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		if (_valueArea != null)
		{
			h2juaveW0qx1IMMHJGdG(_valueArea, true);
		}
	}

	public IRawClusterValueArea GetValueArea(int valueArea)
	{
		if (_valueArea == null)
		{
			_valueArea = new ALgewPiVwVgOfGidVVg6();
		}
		long num = 0L;
		int num2 = 4;
		long num10 = default(long);
		IRawClusterMaxValues maxValues = default(IRawClusterMaxValues);
		long num11 = default(long);
		long num8 = default(long);
		long num3 = default(long);
		double num5 = default(double);
		long num7 = default(long);
		long num4 = default(long);
		int num6 = default(int);
		while (true)
		{
			int num9;
			switch (num2)
			{
			case 17:
			case 23:
				_valueArea.e6aiV8h7AGD(valueArea, num, num10);
				num2 = 26;
				break;
			case 16:
				if (valueArea > 99)
				{
					num2 = 25;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 1;
			case 1:
				if (High != 0L && Low != 0L)
				{
					num = maxValues.Poc;
					num10 = maxValues.Poc;
					num2 = 27;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 17;
			case 12:
				if (_valueArea.jQHiVpsqbTp())
				{
					num9 = 5;
					goto IL_0005;
				}
				if (_valueArea.JG6iVJSW72u() == valueArea)
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
					{
						num2 = 15;
					}
					break;
				}
				goto case 5;
			case 7:
				if (High == num11)
				{
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto IL_046d;
			default:
				if (_items.Count != 0)
				{
					num2 = 20;
					break;
				}
				goto case 17;
			case 25:
				num = High;
				num10 = Low;
				num9 = 17;
				goto IL_0005;
			case 9:
				if (_items.ContainsKey(num8))
				{
					num2 = 2;
					break;
				}
				goto case 21;
			case 4:
				num10 = 0L;
				num2 = 12;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				num10 = num8;
				goto IL_046d;
			case 14:
				num = num11;
				num2 = 19;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num2 = 15;
				}
				break;
			case 11:
				if ((double)num3 >= num5)
				{
					goto case 17;
				}
				goto case 22;
			case 3:
			{
				for (int i = 0; i <= 1; i++)
				{
					if (High >= num11 + 1)
					{
						num11++;
						if (_items.ContainsKey(num11))
						{
							num7 += _items[num11].Volume;
						}
					}
				}
				num2 = 13;
				break;
			}
			case 15:
				return _valueArea;
			case 5:
				maxValues = MaxValues;
				if (maxValues != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 17;
			case 22:
				if (!((double)num3 < num5))
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
					{
						num2 = 23;
					}
					break;
				}
				goto case 18;
			case 2:
				num4 += _items[num8].Volume;
				num2 = 21;
				break;
			case 24:
				num7 = 0L;
				num4 = 0L;
				num11 = num;
				num9 = 10;
				goto IL_0005;
			case 18:
				if (num >= High)
				{
					if (num10 > Low)
					{
						num2 = 24;
						break;
					}
					goto case 17;
				}
				goto case 24;
			case 13:
				num6 = 0;
				goto IL_02a4;
			case 20:
				if (High - Low <= 100000)
				{
					if (valueArea >= 1)
					{
						goto case 16;
					}
					num = maxValues.Poc;
					num10 = Mi1MVHeW2bH6cBHd93Qu(maxValues);
				}
				goto case 17;
			case 10:
				num8 = num10;
				num2 = 3;
				break;
			case 27:
				num3 = yFgAH3eWHdIaIlDCEJPS(maxValues);
				num5 = (double)Volume * ((double)valueArea / 100.0);
				num2 = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
				{
					num2 = 7;
				}
				break;
			case 21:
				num6++;
				goto IL_02a4;
			case 19:
				if (num7 >= num4)
				{
					num = num11;
					num3 += num7;
					num2 = 11;
				}
				else
				{
					num10 = num8;
					num2 = 8;
				}
				break;
			case 26:
				return _valueArea;
			case 8:
				{
					num3 += num4;
					goto case 11;
				}
				IL_02a4:
				if (num6 > 1)
				{
					if (num7 == num4 && num7 == 0L)
					{
						goto case 7;
					}
					goto case 19;
				}
				if (Low <= num8 - 1)
				{
					num8--;
					num9 = 9;
					goto IL_0005;
				}
				goto case 21;
				IL_0005:
				num2 = num9;
				break;
				IL_046d:
				if (Low == num8)
				{
					num2 = 14;
					break;
				}
				goto case 19;
			}
		}
	}

	public IRawClusterItem GetItem(long price)
	{
		if (!_items.ContainsKey(price))
		{
			return null;
		}
		return _items[price];
	}

	private static long ScaleValue(long value, int scale)
	{
		return (value + value % scale) / scale;
	}

	static RawCluster()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool IBsPFVeITZQbnLurwly0()
	{
		return nDND7feIUqdYd51ODapi == null;
	}

	internal static RawCluster lAuDefeIyyL0W6ERgXVk()
	{
		return nDND7feIUqdYd51ODapi;
	}

	internal static bool bdNSraeIZI99WEHTUuMo(object P_0)
	{
		return ((rcFMeOiVb9wNuGqUo22t)P_0).mlFiVRLY8Vl();
	}

	internal static long f2mNTHeIVe1AbPMsKGPb(object P_0)
	{
		return ((IRawTick)P_0).Price;
	}

	internal static long M2uNy7eIClufR7gxJZOQ(long P_0, long P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static long sAxyFleIrOU8H1uQFY3T(long P_0, long P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static DateTime MLIp66eIKTmmPidIgh04(object P_0)
	{
		return ((IRawTick)P_0).Time;
	}

	internal static bool fJOxW0eImabrMQYP5JAx(object P_0)
	{
		return ((IRawTick)P_0).IsBuy;
	}

	internal static long IVEkwseIh9o0UL5Porfw(object P_0)
	{
		return ((IRawTick)P_0).Size;
	}

	internal static void CFJQ8weIw2YPjU0DyQqZ(object P_0, long value)
	{
		((RawClusterItem)P_0).Bid = value;
	}

	internal static long Jd1Qd2eI7OnUcPV4gxPN(long value, int scale)
	{
		return ScaleValue(value, scale);
	}

	internal static void XINX4oeI8rLXMNbfuks9(object P_0, int value)
	{
		((RawClusterItem)P_0).BidTrades = value;
	}

	internal static long IKckcyeIAGcLFDLJ6wMq(object P_0)
	{
		return ((RawClusterItem)P_0).Ask;
	}

	internal static void oE9KaheIPMXKns4MYWDy(object P_0, long value)
	{
		((RawClusterItem)P_0).Ask = value;
	}

	internal static long NrO26oeIJ2HP08yDgrSr(object P_0)
	{
		return ((RawClusterItem)P_0).OpenPosAsk;
	}

	internal static long BtZP4EeIFKKKH4Epssi4(object P_0)
	{
		return ((IRawCluster)P_0).Close;
	}

	internal static DateTime FA2GjeeI3RakdqjB0oVq(object P_0)
	{
		return ((IRawCluster)P_0).OpenTime;
	}

	internal static DateTime bLvwcMeIp5mUIZBPrvHF(object P_0)
	{
		return ((IRawCluster)P_0).CloseTime;
	}

	internal static long T1vDGKeIu5XfSQaORY5j(object P_0)
	{
		return ((IRawCluster)P_0).DeltaHigh;
	}

	internal static long qKxo0deIz2c5oaAv1Ova(object P_0)
	{
		return ((IRawClusterItem)P_0).OpenPosBid;
	}

	internal static void h2juaveW0qx1IMMHJGdG(object P_0, bool P_1)
	{
		((ALgewPiVwVgOfGidVVg6)P_0).YgtiVu91yIe(P_1);
	}

	internal static long Mi1MVHeW2bH6cBHd93Qu(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).Poc;
	}

	internal static long yFgAH3eWHdIaIlDCEJPS(object P_0)
	{
		return ((IRawClusterMaxValues)P_0).MaxVolume;
	}
}
