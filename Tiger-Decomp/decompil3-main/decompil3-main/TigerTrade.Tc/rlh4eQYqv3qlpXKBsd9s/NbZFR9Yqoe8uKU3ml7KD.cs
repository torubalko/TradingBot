using System;
using bFLVeaGpb14YNScYcv2Q;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using U0vBVyGFnRQg4TAEWduY;
using u6fBRhYqedGKNWaNEwBZ;
using uja8AYYMLI5RuWOtt72J;
using x97CE55GhEYKgt7TSVZT;

namespace rlh4eQYqv3qlpXKBsd9s;

internal sealed class NbZFR9Yqoe8uKU3ml7KD
{
	[Flags]
	internal enum f4HUHaaUYX2bi01NMImL
	{
		None = 0,
		Last = 2,
		LastSize = 4,
		Bid = 8,
		BidSize = 0x10,
		Ask = 0x20,
		AskSize = 0x40,
		Market = 0x200,
		Conditions = 0x400
	}

	private long SYHYqaqoWKw;

	private long bdvYqifEwem;

	private long w4sYqlIAipN;

	private long MJ9Yq4yWOHJ;

	private long Uy5YqDOTuyO;

	private long mvJYqbaTvtN;

	private long jkpYqN7PdtR;

	private long Y7wYqkfvFdj;

	private long kmtYq1mJgWa;

	private string IxtYq5yA7cw;

	private string z1qYqSoQAyi;

	private readonly GFv7xXYMxkL3Kkru2j7I LekYqxpjIE3;

	internal static NbZFR9Yqoe8uKU3ml7KD RrMHfaSXgaHCLHgL7Bi1;

	public NbZFR9Yqoe8uKU3ml7KD(GFv7xXYMxkL3Kkru2j7I P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		LekYqxpjIE3 = P_0;
	}

	public TickEvent UJoYqBMVGuk(Symbol P_0, byte[] P_1)
	{
		int num = 1;
		int num2 = num;
		fSe09yYqLrWV6gXnueCG fSe09yYqLrWV6gXnueCG = default(fSe09yYqLrWV6gXnueCG);
		bool notQualified = default(bool);
		while (true)
		{
			Side side;
			object obj;
			switch (num2)
			{
			case 3:
				side = Side.Sell;
				goto IL_006e;
			case 2:
				side = Side.Buy;
				goto IL_006e;
			case 1:
				fSe09yYqLrWV6gXnueCG = new fSe09yYqLrWV6gXnueCG(P_1, _0020: true);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				{
					int num3 = J3CUUESXMIZqZE1Yf0Yk(fSe09yYqLrWV6gXnueCG);
					if ((num3 & 1) != 0)
					{
						SYHYqaqoWKw += sBqxN1SXOG9LUpHjEbhK(fSe09yYqLrWV6gXnueCG);
					}
					if ((num3 & 2) != 0)
					{
						bdvYqifEwem += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 4) != 0)
					{
						w4sYqlIAipN = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 8) != 0)
					{
						MJ9Yq4yWOHJ += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 0x10) != 0)
					{
						Uy5YqDOTuyO = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 0x20) != 0)
					{
						mvJYqbaTvtN += sBqxN1SXOG9LUpHjEbhK(fSe09yYqLrWV6gXnueCG);
					}
					if ((num3 & 0x40) != 0)
					{
						jkpYqN7PdtR = sBqxN1SXOG9LUpHjEbhK(fSe09yYqLrWV6gXnueCG);
					}
					if ((num3 & 0x80) != 0)
					{
						Y7wYqkfvFdj += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 0x100) != 0)
					{
						kmtYq1mJgWa = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					}
					if ((num3 & 0x200) != 0)
					{
						IxtYq5yA7cw = (string)UF2tQsSXqlPvykrMdXG1(fSe09yYqLrWV6gXnueCG);
					}
					if ((num3 & 0x400) != 0)
					{
						z1qYqSoQAyi = fSe09yYqLrWV6gXnueCG.Nr3Yqd6Guuu();
					}
					bool flag = (num3 & 0x800) != 0;
					bool flag2 = (num3 & 0x1000) != 0;
					notQualified = (num3 & 0x2000) != 0;
					side = Side.Sell;
					if (!flag)
					{
						if (flag2)
						{
							num2 = 3;
							break;
						}
						goto IL_006e;
					}
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
					{
						num2 = 2;
					}
					break;
				}
				IL_006e:
				obj = DJD07kSXIP2QhQJTk48U(P_0);
				MprwZpSXWfOPuvjuSqjb(obj, new DateTime(SYHYqaqoWKw));
				((TickEvent)obj).Price = P_0.GetShortPrice((double)bdvYqifEwem * LekYqxpjIE3.PriceStep);
				((TickEvent)obj).Size = v6j975SXteLUDN6vhxEP(P_0, (double)w4sYqlIAipN * LekYqxpjIE3.SizeStep);
				((TickEvent)obj).Bid = P_0.GetShortPrice((double)MJ9Yq4yWOHJ * LekYqxpjIE3.PriceStep);
				((TickEvent)obj).BidSize = P_0.GetShortSize((double)Uy5YqDOTuyO * LekYqxpjIE3.SizeStep);
				kmU8R3SXUK98yiR6hwtT(obj, P_0.GetShortPrice((double)mvJYqbaTvtN * LekYqxpjIE3.PriceStep));
				((TickEvent)obj).AskSize = P_0.GetShortSize((double)jkpYqN7PdtR * jYPw9mSXTj0cEPiG37YF(LekYqxpjIE3));
				Uguu1SSXyA1wkhERPFAI(obj, Y7wYqkfvFdj);
				((TickEvent)obj).MarketCenter = kmtYq1mJgWa;
				((TickEvent)obj).Market = IxtYq5yA7cw;
				((TickEvent)obj).Conditions = z1qYqSoQAyi;
				((TickEvent)obj).Side = side;
				((TickEvent)obj).NotQualified = notQualified;
				fSe09yYqLrWV6gXnueCG.Dispose();
				return (TickEvent)obj;
			}
		}
	}

	static NbZFR9Yqoe8uKU3ml7KD()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		Q2rLbHSXZbqKyrL3VZ5M();
	}

	internal static bool xB3lcdSXRRTYxGtNnUBF()
	{
		return RrMHfaSXgaHCLHgL7Bi1 == null;
	}

	internal static NbZFR9Yqoe8uKU3ml7KD YkNOoTSX6kKvmgjUcujn()
	{
		return RrMHfaSXgaHCLHgL7Bi1;
	}

	internal static int J3CUUESXMIZqZE1Yf0Yk(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).qPVYqjl7Fma();
	}

	internal static long sBqxN1SXOG9LUpHjEbhK(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).NjbYqs43VaK();
	}

	internal static object UF2tQsSXqlPvykrMdXG1(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).Nr3Yqd6Guuu();
	}

	internal static object DJD07kSXIP2QhQJTk48U(object P_0)
	{
		return IlvHiXGF9pA6U4gUK5bq.yxVGF4IeGkY((Symbol)P_0);
	}

	internal static void MprwZpSXWfOPuvjuSqjb(object P_0, DateTime P_1)
	{
		((TickEvent)P_0).Time = P_1;
	}

	internal static long v6j975SXteLUDN6vhxEP(object P_0, double size)
	{
		return ((SymbolBase)P_0).GetShortSize(size);
	}

	internal static void kmU8R3SXUK98yiR6hwtT(object P_0, long P_1)
	{
		((TickEvent)P_0).Ask = P_1;
	}

	internal static double jYPw9mSXTj0cEPiG37YF(object P_0)
	{
		return ((GFv7xXYMxkL3Kkru2j7I)P_0).SizeStep;
	}

	internal static void Uguu1SSXyA1wkhERPFAI(object P_0, long P_1)
	{
		((TickEvent)P_0).OpenInterest = P_1;
	}

	internal static void Q2rLbHSXZbqKyrL3VZ5M()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
