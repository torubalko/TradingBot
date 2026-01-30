using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;

namespace TigerTrade.Chart.Data;

public sealed class RawClusterItem : IRawClusterItem
{
	private static RawClusterItem oUcpkreWfdNjPUCOj4aD;

	public long Price { get; set; }

	public long Bid { get; set; }

	public long Ask { get; set; }

	public int BidTrades { get; set; }

	public int AskTrades { get; set; }

	public long OpenPosBid { get; set; }

	public long OpenPosAsk { get; set; }

	public long Volume => Ask + Bid;

	public long Delta => Ask - Bid;

	public int Trades => AskTrades + BidTrades;

	public long OpenPos => OpenPosBid + OpenPosAsk;

	public long BidQuote { get; set; }

	public long AskQuote { get; set; }

	public long VolumeQuote => AskQuote + BidQuote;

	public long DeltaQuote => AskQuote - BidQuote;

	public RawClusterItem(long price)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Price = price;
	}

	public RawClusterItem(IRawClusterItem item)
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		Price = item.Price;
		Add(item);
	}

	public void Add(IRawClusterItem item)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				Ask += item.Ask;
				BidTrades += item.BidTrades;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Bid += UfK8L6eWGTCJOVlSii5K(item);
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				AskTrades += item.AskTrades;
				OpenPosBid += item.OpenPosBid;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
				{
					num2 = 0;
				}
				break;
			default:
				OpenPosAsk += item.OpenPosAsk;
				BidQuote += item.BidQuote;
				AskQuote += MceivWeWY0N6yC7OxJDG(item);
				return;
			}
		}
	}

	static RawClusterItem()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool gILfEqeW98xOrmNcSbuy()
	{
		return oUcpkreWfdNjPUCOj4aD == null;
	}

	internal static RawClusterItem f41tvDeWnjW3NdMQPv0J()
	{
		return oUcpkreWfdNjPUCOj4aD;
	}

	internal static long UfK8L6eWGTCJOVlSii5K(object P_0)
	{
		return ((IRawClusterItem)P_0).Bid;
	}

	internal static long MceivWeWY0N6yC7OxJDG(object P_0)
	{
		return ((IRawClusterItem)P_0).AskQuote;
	}
}
