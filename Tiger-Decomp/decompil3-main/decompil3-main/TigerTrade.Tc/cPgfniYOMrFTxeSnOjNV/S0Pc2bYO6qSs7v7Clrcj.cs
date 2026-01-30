using System;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Data;
using u6fBRhYqedGKNWaNEwBZ;
using uja8AYYMLI5RuWOtt72J;
using x97CE55GhEYKgt7TSVZT;

namespace cPgfniYOMrFTxeSnOjNV;

internal sealed class S0Pc2bYO6qSs7v7Clrcj
{
	[Flags]
	internal enum roL9SvathgT5SAx4GYYi : long
	{
		None = 0L,
		BidPrice = 1L,
		BidSize = 2L,
		BidTime = 4L,
		AskPrice = 0x20L,
		AskSize = 0x40L,
		AskTime = 0x80L,
		LastSize = 0x800L,
		LastTime = 0x1000L,
		HighPrice = 0x80000L,
		LowPrice = 0x100000L,
		OpenPrice = 0x200000L,
		ClosePrice = 0x400000L,
		Volume = 0x800000L,
		Trades = 0x1000000L,
		OpenInt = 0x2000000L,
		MarginBuy = 0x10000000L,
		MarginSell = 0x20000000L,
		NetChange = 0x200000000L,
		Change = 0x400000000L
	}

	private long iVZYOqc3M3R;

	private long kfRYOI8dQK4;

	private long Q54YOWHkEeV;

	private long YAvYOt6HTrP;

	private long TccYOUyNGi5;

	private long tGgYOTSKbos;

	private long VnDYOyEi5Dj;

	private long s58YOZuGIbV;

	private long gcHYOVZrBeK;

	private long jniYOCPkYI8;

	private long TsfYOrkAyoP;

	private long IvSYOKPRf5Q;

	private long qdoYOm3vXJF;

	private long hVBYOhH6MkY;

	private string o4RYOw0S9rT;

	private string gROYO7xCIo0;

	private long tucYO8EDMOH;

	private long IRRYOArWI7e;

	private long E22YOPB3pe6;

	private long nocYOJo5H1D;

	private long hHvYOF2sQPm;

	private long LA7YO3Dk3kh;

	private long Gk1YOpYe2Se;

	private long VpoYOuhR1wm;

	private long HZSYOzgavGy;

	private long VEwYq0coe8T;

	private long TkLYq2gsFiU;

	private long Y9LYqHOybSY;

	private long k0xYqf2G1nt;

	private long dg8Yq9crZi9;

	private long oxSYqnyKup8;

	private long KSfYqGHlnDL;

	private readonly GFv7xXYMxkL3Kkru2j7I N0kYqYG8Dvw;

	internal static S0Pc2bYO6qSs7v7Clrcj Sd6mnASXDrkxf1OFQmOI;

	public S0Pc2bYO6qSs7v7Clrcj(GFv7xXYMxkL3Kkru2j7I P_0)
	{
		r5F7dpSXkkVRLbYfZTn4();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		N0kYqYG8Dvw = P_0;
	}

	public Security c3UYOO7x0ss(Security P_0, byte[] P_1, out bool P_2, out bool P_3)
	{
		Symbol symbol = P_0.Symbol;
		fSe09yYqLrWV6gXnueCG fSe09yYqLrWV6gXnueCG = new fSe09yYqLrWV6gXnueCG(P_1, _0020: true);
		roL9SvathgT5SAx4GYYi roL9SvathgT5SAx4GYYi = (roL9SvathgT5SAx4GYYi)fSe09yYqLrWV6gXnueCG.uSUYqEZ0jNv();
		int num = 28;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
		{
			num = 28;
		}
		bool lastIsNotQualified = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 27:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)2147483648L) != roL9SvathgT5SAx4GYYi.None)
				{
					goto case 14;
				}
				goto IL_0964;
			case 47:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.LastSize) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 3;
					break;
				}
				goto IL_07c0;
			case 37:
				P_0.BidDepthT = YAvYOt6HTrP;
				goto IL_0a1e;
			case 6:
				E22YOPB3pe6 += MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				num = 10;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af != 0)
				{
					num = 6;
				}
				break;
			case 38:
				P_0.OfferDepthT = gcHYOVZrBeK;
				goto IL_09f0;
			case 41:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.MarginBuy) != roL9SvathgT5SAx4GYYi.None)
				{
					VEwYq0coe8T = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					num = 42;
					break;
				}
				goto IL_048a;
			case 24:
			case 29:
				P_0.LastIsNotQualified = lastIsNotQualified;
				num = 35;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
				{
					num = 0;
				}
				break;
			case 12:
				dg8Yq9crZi9 = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				goto IL_0835;
			case 10:
				PmVAXCSXEmb3oeImmsH1(P_0, (double)E22YOPB3pe6 * QnB5U0SX5WyXurLRrewt(N0kYqYG8Dvw));
				goto IL_06bc;
			case 33:
				if (!flag)
				{
					num = 10;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a != 0)
					{
						num = 29;
					}
					break;
				}
				goto default;
			case 19:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)67108864L) != roL9SvathgT5SAx4GYYi.None)
				{
					VpoYOuhR1wm = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					num = 48;
					break;
				}
				goto case 9;
			case 32:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)8192L) != roL9SvathgT5SAx4GYYi.None)
				{
					hVBYOhH6MkY = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					P_0.LastMarketCenter = hVBYOhH6MkY;
				}
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)16384L) == roL9SvathgT5SAx4GYYi.None)
				{
					num2 = 16;
					goto IL_0005;
				}
				o4RYOw0S9rT = (string)f3tn1JSXsPk66JuuD8Ut(fSe09yYqLrWV6gXnueCG);
				P_0.LastMarket = o4RYOw0S9rT;
				goto case 16;
			case 20:
				P_0.LastSize = symbol.GetShortSize((double)IvSYOKPRf5Q * N0kYqYG8Dvw.SizeStep);
				goto IL_07c0;
			case 31:
				wQDQclSXQUq1Fv3evSIq(P_0, (double)Y9LYqHOybSY / 100000000.0);
				num2 = 27;
				goto IL_0005;
			case 23:
				LA7YO3Dk3kh = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				num = 11;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
				{
					num = 13;
				}
				break;
			case 22:
				oxSYqnyKup8 = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				P_0.NetChange = (double)oxSYqnyKup8 * QnB5U0SX5WyXurLRrewt(N0kYqYG8Dvw);
				num = 11;
				break;
			case 49:
				Qc5GMySXc0dERjhtThTD(P_0, (double)tucYO8EDMOH * N0kYqYG8Dvw.PriceStep);
				goto case 1;
			case 39:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.Trades) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 23;
					break;
				}
				goto IL_0109;
			case 35:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.HighPrice) != roL9SvathgT5SAx4GYYi.None)
				{
					tucYO8EDMOH += MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					num = 49;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13355397408e4ea79e81e5e0aa0e3a16 != 0)
					{
						num = 36;
					}
				}
				else
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 != 0)
					{
						num = 1;
					}
				}
				break;
			case 4:
				P_0.ClosePrice = (double)nocYOJo5H1D * N0kYqYG8Dvw.PriceStep;
				goto IL_0362;
			case 50:
				P_0.AskTime = new DateTime(s58YOZuGIbV);
				goto IL_0aea;
			case 17:
				jniYOCPkYI8 = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				P_0.NumOffers = jniYOCPkYI8;
				goto IL_01df;
			case 44:
				hHvYOF2sQPm = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				P_0.Volume = hHvYOF2sQPm;
				num = 39;
				break;
			case 2:
				gcHYOVZrBeK = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				num = 16;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
				{
					num = 38;
				}
				break;
			case 9:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)134217728L) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 7;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2ec9c2758b664327841cd485b12c52d3 != 0)
					{
						num = 7;
					}
					break;
				}
				goto case 41;
			case 42:
				P_0.MarginBuy = (double)VEwYq0coe8T / 100000000.0;
				goto IL_048a;
			case 14:
				k0xYqf2G1nt = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				num = 21;
				break;
			case 13:
				P_0.Trades = LA7YO3Dk3kh;
				goto IL_0109;
			case 34:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.AskPrice) != roL9SvathgT5SAx4GYYi.None)
				{
					tGgYOTSKbos += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					num = 15;
					break;
				}
				goto IL_092d;
			case 16:
			{
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)32768L) != roL9SvathgT5SAx4GYYi.None)
				{
					gROYO7xCIo0 = fSe09yYqLrWV6gXnueCG.Nr3Yqd6Guuu();
					P_0.LastConditions = gROYO7xCIo0;
				}
				bool num3 = (roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)65536L) != 0;
				flag = (roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)131072L) != 0;
				lastIsNotQualified = (roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)262144L) != 0;
				if (num3)
				{
					ok8FFpSXXKQGiL99Hh3u(P_0, Side.Buy);
					num = 24;
					break;
				}
				goto case 33;
			}
			case 5:
				Q54YOWHkEeV += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				P_0.BidTime = new DateTime(Q54YOWHkEeV);
				num = 40;
				break;
			case 28:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.BidPrice) != roL9SvathgT5SAx4GYYi.None)
				{
					iVZYOqc3M3R += MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					num = 30;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
					{
						num = 25;
					}
					break;
				}
				goto IL_0c5c;
			case 40:
			case 51:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)8L) != roL9SvathgT5SAx4GYYi.None)
				{
					YAvYOt6HTrP = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					num = 37;
					break;
				}
				goto IL_0a1e;
			case 8:
				TccYOUyNGi5 = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				P_0.NumBids = TccYOUyNGi5;
				num = 34;
				break;
			case 26:
				P_0.PriceMax = (double)HZSYOzgavGy * N0kYqYG8Dvw.PriceStep;
				num2 = 41;
				goto IL_0005;
			case 11:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.Change) != roL9SvathgT5SAx4GYYi.None)
				{
					KSfYqGHlnDL = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					P_0.Change = (double)KSfYqGHlnDL / 100000000.0;
				}
				H8pXDbSXdGasnDMHSK2e(fSe09yYqLrWV6gXnueCG);
				num = 18;
				break;
			case 30:
				P_0.BidPrice = symbol.GetShortPrice((double)iVZYOqc3M3R * QnB5U0SX5WyXurLRrewt(N0kYqYG8Dvw));
				goto IL_0c5c;
			case 7:
				HZSYOzgavGy = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				num2 = 26;
				goto IL_0005;
			case 3:
				IvSYOKPRf5Q = MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
				num = 20;
				break;
			default:
				P_0.LastSide = Side.Sell;
				goto case 24;
			case 21:
				P_0.TheoreticalPrice = (double)k0xYqf2G1nt * QnB5U0SX5WyXurLRrewt(N0kYqYG8Dvw);
				goto IL_0964;
			case 43:
				P_0.OpenInt = Gk1YOpYe2Se;
				goto case 19;
			case 36:
				nocYOJo5H1D += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				num2 = 4;
				goto IL_0005;
			case 45:
				NNlYoXSXeUi8bfvv9gKZ(P_0, new DateTime(qdoYOm3vXJF));
				num = 32;
				break;
			case 1:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.LowPrice) != roL9SvathgT5SAx4GYYi.None)
				{
					IRRYOArWI7e += MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					N2rlqPSXjgcAKjr22flR(P_0, (double)IRRYOArWI7e * N0kYqYG8Dvw.PriceStep);
				}
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.OpenPrice) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 6;
					break;
				}
				goto IL_06bc;
			case 48:
				P_0.PriceMin = (double)VpoYOuhR1wm * N0kYqYG8Dvw.PriceStep;
				num = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2417c17afc5747a7a781c50dbd7d5d7c == 0)
				{
					num = 9;
				}
				break;
			case 46:
				TsfYOrkAyoP += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				CX3qf7SXLivTS75kuMhg(P_0, symbol.GetShortPrice((double)TsfYOrkAyoP * N0kYqYG8Dvw.PriceStep));
				goto case 47;
			case 15:
				P_0.AskPrice = symbol.GetShortPrice((double)tGgYOTSKbos * N0kYqYG8Dvw.PriceStep);
				goto IL_092d;
			case 18:
				P_2 = (roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)34359738368L) != 0;
				P_3 = (roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)68719476736L) != 0;
				return P_0;
			case 25:
				{
					P_0.MarginSell = (double)TkLYq2gsFiU / 100000000.0;
					goto IL_06a9;
				}
				IL_048a:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.MarginSell) != roL9SvathgT5SAx4GYYi.None)
				{
					TkLYq2gsFiU = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					num = 25;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
					{
						num = 24;
					}
					break;
				}
				goto IL_06a9;
				IL_0c5c:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.BidSize) != roL9SvathgT5SAx4GYYi.None)
				{
					kfRYOI8dQK4 = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					P_0.BidSize = TTrWs0SXx3YZ3B2UtwAt(symbol, (double)kfRYOI8dQK4 * mPJym7SXS3BgP6oOFu41(N0kYqYG8Dvw));
				}
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.BidTime) == roL9SvathgT5SAx4GYYi.None)
				{
					num = 51;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e37b704f00fd438985274655b11b16b4 != 0)
					{
						num = 6;
					}
					break;
				}
				goto case 5;
				IL_06a9:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)1073741824L) != roL9SvathgT5SAx4GYYi.None)
				{
					Y9LYqHOybSY = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					num = 24;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f2a416e6ad3f40c68e350adb5940cd75 == 0)
					{
						num = 31;
					}
					break;
				}
				goto case 27;
				IL_07c0:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.LastTime) != roL9SvathgT5SAx4GYYi.None)
				{
					qdoYOm3vXJF += MgtODZSX1g2guNRwAulx(fSe09yYqLrWV6gXnueCG);
					num = 45;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1eae27ac5d434a80846c6543fc10c643 == 0)
					{
						num = 31;
					}
					break;
				}
				goto case 32;
				IL_0964:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)4294967296L) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 12;
					break;
				}
				goto IL_0835;
				IL_0a1e:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)16L) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 8;
					break;
				}
				goto case 34;
				IL_0835:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.NetChange) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 22;
					break;
				}
				goto case 11;
				IL_092d:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.AskSize) != roL9SvathgT5SAx4GYYi.None)
				{
					VnDYOyEi5Dj = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					P_0.AskSize = symbol.GetShortSize((double)VnDYOyEi5Dj * mPJym7SXS3BgP6oOFu41(N0kYqYG8Dvw));
				}
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.AskTime) != roL9SvathgT5SAx4GYYi.None)
				{
					s58YOZuGIbV += fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
					num = 32;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b == 0)
					{
						num = 50;
					}
					break;
				}
				goto IL_0aea;
				IL_0005:
				num = num2;
				break;
				IL_06bc:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.ClosePrice) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 36;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
					{
						num = 33;
					}
					break;
				}
				goto IL_0362;
				IL_0aea:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)256L) != roL9SvathgT5SAx4GYYi.None)
				{
					num2 = 2;
					goto IL_0005;
				}
				goto IL_09f0;
				IL_0362:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.Volume) != roL9SvathgT5SAx4GYYi.None)
				{
					num = 44;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
					{
						num = 29;
					}
					break;
				}
				goto case 39;
				IL_09f0:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)512L) == roL9SvathgT5SAx4GYYi.None)
				{
					goto IL_01df;
				}
				goto case 17;
				IL_0109:
				if ((roL9SvathgT5SAx4GYYi & roL9SvathgT5SAx4GYYi.OpenInt) == roL9SvathgT5SAx4GYYi.None)
				{
					num = 19;
					break;
				}
				Gk1YOpYe2Se = fSe09yYqLrWV6gXnueCG.NjbYqs43VaK();
				num = 43;
				break;
				IL_01df:
				if ((roL9SvathgT5SAx4GYYi & (roL9SvathgT5SAx4GYYi)1024L) == roL9SvathgT5SAx4GYYi.None)
				{
					num = 47;
					break;
				}
				goto case 46;
			}
		}
	}

	static S0Pc2bYO6qSs7v7Clrcj()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void r5F7dpSXkkVRLbYfZTn4()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool xjXoGDSXbK0c8bX3xvYF()
	{
		return Sd6mnASXDrkxf1OFQmOI == null;
	}

	internal static S0Pc2bYO6qSs7v7Clrcj Fsgb1lSXNed8EyjeUdHT()
	{
		return Sd6mnASXDrkxf1OFQmOI;
	}

	internal static long MgtODZSX1g2guNRwAulx(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).NjbYqs43VaK();
	}

	internal static double QnB5U0SX5WyXurLRrewt(object P_0)
	{
		return ((GFv7xXYMxkL3Kkru2j7I)P_0).PriceStep;
	}

	internal static double mPJym7SXS3BgP6oOFu41(object P_0)
	{
		return ((GFv7xXYMxkL3Kkru2j7I)P_0).SizeStep;
	}

	internal static long TTrWs0SXx3YZ3B2UtwAt(object P_0, double size)
	{
		return ((SymbolBase)P_0).GetShortSize(size);
	}

	internal static void CX3qf7SXLivTS75kuMhg(object P_0, long value)
	{
		((Security)P_0).LastPrice = value;
	}

	internal static void NNlYoXSXeUi8bfvv9gKZ(object P_0, DateTime value)
	{
		((Security)P_0).LastTime = value;
	}

	internal static object f3tn1JSXsPk66JuuD8Ut(object P_0)
	{
		return ((fSe09yYqLrWV6gXnueCG)P_0).Nr3Yqd6Guuu();
	}

	internal static void ok8FFpSXXKQGiL99Hh3u(object P_0, Side value)
	{
		((Security)P_0).LastSide = value;
	}

	internal static void Qc5GMySXc0dERjhtThTD(object P_0, double value)
	{
		((Security)P_0).HighPrice = value;
	}

	internal static void N2rlqPSXjgcAKjr22flR(object P_0, double value)
	{
		((Security)P_0).LowPrice = value;
	}

	internal static void PmVAXCSXEmb3oeImmsH1(object P_0, double value)
	{
		((Security)P_0).OpenPrice = value;
	}

	internal static void wQDQclSXQUq1Fv3evSIq(object P_0, double value)
	{
		((Security)P_0).Volatility = value;
	}

	internal static void H8pXDbSXdGasnDMHSK2e(object P_0)
	{
		((fSe09yYqLrWV6gXnueCG)P_0).Dispose();
	}
}
