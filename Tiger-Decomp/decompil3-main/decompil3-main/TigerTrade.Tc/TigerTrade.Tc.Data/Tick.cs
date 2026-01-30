using System;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using x97CE55GhEYKgt7TSVZT;

namespace TigerTrade.Tc.Data;

public sealed class Tick
{
	private static Tick VyFTJD5zoyZUjVZSeIcE;

	public Symbol Symbol { get; set; }

	public DateTime Time { get; set; }

	public long Price { get; set; }

	public long Size { get; set; }

	public long Bid { get; set; }

	public long BidSize { get; set; }

	public long Ask { get; set; }

	public long AskSize { get; set; }

	public Side Side { get; set; }

	public long OpenInterest { get; set; }

	public long MarketCenter { get; set; }

	public string Market { get; set; }

	public string Conditions { get; set; }

	public bool NotQualified { get; set; }

	public long SizeQuote => Size * Price;

	public void Apply(TickEvent e)
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				MarketCenter = e.MarketCenter;
				Market = e.Market;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				Conditions = (string)lMTxOD5z4aOyi8wXbmI5(e);
				NotQualified = e.NotQualified;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13e7dc070b7c4c79a18cbee083c6ec1e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 4:
				Price = bvfrBj5zav2lHmfygKTN(e);
				Size = e.Size;
				Bid = e.Bid;
				BidSize = e.BidSize;
				Ask = e.Ask;
				AskSize = fAvjjk5ziQM1VsjjD5fi(e);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Side = RgaD625zlfYD052ROi0p(e);
				OpenInterest = e.OpenInterest;
				num2 = 2;
				break;
			case 5:
				Time = e.Time;
				num2 = 4;
				break;
			}
		}
	}

	public Tick()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
	}

	static Tick()
	{
		Us3nWL5zDrldIXXWf622();
		zWmBj65zbTgjLr7hWe95();
	}

	internal static bool Cg5PRy5zv6oCHoGgJOSv()
	{
		return VyFTJD5zoyZUjVZSeIcE == null;
	}

	internal static Tick HOZsb15zBldsaStZGHQb()
	{
		return VyFTJD5zoyZUjVZSeIcE;
	}

	internal static long bvfrBj5zav2lHmfygKTN(object P_0)
	{
		return ((TickEvent)P_0).Price;
	}

	internal static long fAvjjk5ziQM1VsjjD5fi(object P_0)
	{
		return ((TickEvent)P_0).AskSize;
	}

	internal static Side RgaD625zlfYD052ROi0p(object P_0)
	{
		return ((TickEvent)P_0).Side;
	}

	internal static object lMTxOD5z4aOyi8wXbmI5(object P_0)
	{
		return ((TickEvent)P_0).Conditions;
	}

	internal static void Us3nWL5zDrldIXXWf622()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void zWmBj65zbTgjLr7hWe95()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
