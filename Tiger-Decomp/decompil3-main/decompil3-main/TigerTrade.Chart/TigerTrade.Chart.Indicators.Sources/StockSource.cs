using System.Collections.Generic;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TigerTrade.Chart.Indicators.Common;

namespace TigerTrade.Chart.Indicators.Sources;

[IndicatorSource("Stock", Type = typeof(StockSource))]
[DataContract(Name = "StockSource", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
public sealed class StockSource : IndicatorSourceBase
{
	internal static StockSource MxN5tjeiS91gpjFjGNeE;

	public StockSource()
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
		base.SelectedSeries = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4297C3EB ^ 0x42974DAF);
	}

	public override IEnumerable<string> GetSeriesList()
	{
		return new List<string>
		{
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673650413),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002286707),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xC1DDB3B ^ 0xC1D5551),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D31BA8D),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1380525184 ^ -1380559372),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530020707),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002286779),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7C57F),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAB198),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x385FFAB ^ 0x385716B),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x28BBDCA ^ 0x28B3300),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161586482),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1309555870 ^ -1309586048),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x20B584D2 ^ 0x20B50A2C),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A3836),
			yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x5CD4F15 ^ 0x5CDC039)
		};
	}

	public override double[] GetSeries(IndicatorsHelper helper)
	{
		string selectedSeries = base.SelectedSeries;
		uint num = OjIYTFeiedWgfFLZkl5V(selectedSeries);
		int num2 = 10;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
		{
			num2 = 0;
		}
		while (true)
		{
			switch (num2)
			{
			default:
				if (num != 3050396832u)
				{
					num2 = 29;
					break;
				}
				goto case 23;
			case 28:
				if (num <= 1962243759)
				{
					num2 = 14;
					break;
				}
				if (num != 2096980402)
				{
					num2 = 19;
					break;
				}
				if (Af9gUfeis2lr0A51oF6H(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-123775059 ^ -123741849)))
				{
					return (double[])z1l0TneidcCNE1CbTKn1(helper);
				}
				goto case 4;
			case 15:
				if (!(selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673650241)))
				{
					goto case 4;
				}
				return helper.OpenPosChg;
			case 23:
				if (!Af9gUfeis2lr0A51oF6H(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-45476899 ^ -45441763)))
				{
					goto case 4;
				}
				return (double[])KCb784eiQB6xsFeTXtZR(helper);
			case 4:
			case 5:
			case 6:
			case 7:
			case 11:
			case 22:
			case 24:
			case 27:
			case 29:
				return null;
			case 17:
				if (num == 394669695)
				{
					if (selectedSeries == (string)DvYboheiXxNTS0pVIrkG(-1736566656 ^ -1736534430))
					{
						return (double[])YJpyIHeiRdttSG8xxPZS(helper);
					}
					goto case 4;
				}
				num2 = 24;
				break;
			case 9:
				if (Af9gUfeis2lr0A51oF6H(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-448941864 ^ -448971252)))
				{
					return (double[])QPYwaReigCaxoRAE3lh7(helper);
				}
				goto case 4;
			case 13:
				switch (num)
				{
				case 3906748599u:
					if (Af9gUfeis2lr0A51oF6H(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x3544E813 ^ 0x35446667)))
					{
						return helper.MedianPrice();
					}
					num2 = 4;
					goto end_IL_0009;
				case 3802236886u:
					if (selectedSeries == (string)DvYboheiXxNTS0pVIrkG(-2108526692 ^ -2108497744))
					{
						return helper.OpenPosAskChg;
					}
					num2 = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
					{
						num2 = 27;
					}
					goto end_IL_0009;
				}
				goto case 4;
			case 18:
				if (num != 1220732478)
				{
					goto case 4;
				}
				if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--500511424 ^ 0x1DD5BC60))
				{
					return helper.Trades;
				}
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
				{
					num2 = 5;
				}
				break;
			case 21:
				if (Af9gUfeis2lr0A51oF6H(selectedSeries, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838810550)))
				{
					return helper.Open;
				}
				goto case 4;
			case 3:
				if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-5977659 ^ -6011071))
				{
					return helper.TypicalPrice();
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 != 0)
				{
					num2 = 11;
				}
				break;
			case 2:
				if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1461949456 ^ -1461918310))
				{
					return (double[])vuHt6EeicgQRQPdbvm7U(helper);
				}
				goto case 4;
			case 1:
				if (num == 3448155331u && selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB48737))
				{
					return (double[])yEVQoQeij68nbR8IEJmb(helper);
				}
				goto case 4;
			case 10:
				if (num <= 2149759021u)
				{
					num2 = 26;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 25;
			case 12:
				if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB1817C))
				{
					return helper.OpenPosBidChg;
				}
				num2 = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num2 = 7;
				}
				break;
			case 16:
				if (num != 1962243759)
				{
					goto case 4;
				}
				if (Af9gUfeis2lr0A51oF6H(selectedSeries, DvYboheiXxNTS0pVIrkG(--737722733 ^ 0x2BF84FDD)))
				{
					return helper.Volume;
				}
				num2 = 22;
				break;
			case 26:
				if (num > 1220732478)
				{
					goto case 28;
				}
				if (num <= 394669695)
				{
					num2 = 8;
					break;
				}
				if (num != 1023147713)
				{
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
					{
						num2 = 18;
					}
					break;
				}
				goto case 9;
			case 19:
				if (num != 2149759021u)
				{
					num2 = 6;
					break;
				}
				goto case 15;
			case 14:
				if (num != 1401622761)
				{
					int num3 = 16;
					num2 = num3;
					break;
				}
				goto case 21;
			case 25:
				if (num <= 3050396832u)
				{
					if (num > 2312670803u)
					{
						goto case 20;
					}
					if (num == 2296932281u)
					{
						if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153173257))
						{
							return (double[])oaitbEeiE4HZK954Ek5s(helper);
						}
					}
					else if (num == 2312670803u)
					{
						goto case 3;
					}
				}
				else
				{
					if (num > 3448155331u)
					{
						goto case 13;
					}
					if (num != 3188327965u)
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
						{
							num2 = 1;
						}
						break;
					}
					if (selectedSeries == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878917736))
					{
						return helper.High;
					}
				}
				goto case 4;
			case 20:
				if (num != 2984088865u)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 8:
				{
					if (num != 316210056)
					{
						num2 = 10;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b != 0)
						{
							num2 = 17;
						}
						break;
					}
					goto case 12;
				}
				end_IL_0009:
				break;
			}
		}
	}

	public override void CopySettings(IndicatorSourceBase source)
	{
		if (source is StockSource stockSource)
		{
			base.SelectedSeries = (string)aHFtfJei6f7srym3LaPW(stockSource);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 != 0)
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

	public override string ToString()
	{
		if (string.IsNullOrEmpty(base.SelectedSeries))
		{
			return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-838841832 ^ -838808068);
		}
		return base.SelectedSeries;
	}

	static StockSource()
	{
		Ep8WMBeiMbYjpJA1pM7t();
		s0cygeeiONrx5pr3FsiI();
	}

	internal static bool A43TQZeixwvRhKP3DTpJ()
	{
		return MxN5tjeiS91gpjFjGNeE == null;
	}

	internal static StockSource xesQA4eiL20rHhUoumfY()
	{
		return MxN5tjeiS91gpjFjGNeE;
	}

	internal static uint OjIYTFeiedWgfFLZkl5V(object P_0)
	{
		return global::_003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool Af9gUfeis2lr0A51oF6H(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object DvYboheiXxNTS0pVIrkG(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static object vuHt6EeicgQRQPdbvm7U(object P_0)
	{
		return ((IndicatorsHelper)P_0).Low;
	}

	internal static object yEVQoQeij68nbR8IEJmb(object P_0)
	{
		return ((IndicatorsHelper)P_0).Close;
	}

	internal static object oaitbEeiE4HZK954Ek5s(object P_0)
	{
		return ((IndicatorsHelper)P_0).Poc;
	}

	internal static object KCb784eiQB6xsFeTXtZR(object P_0)
	{
		return ((IndicatorsHelper)P_0).Bid;
	}

	internal static object z1l0TneidcCNE1CbTKn1(object P_0)
	{
		return ((IndicatorsHelper)P_0).Ask;
	}

	internal static object QPYwaReigCaxoRAE3lh7(object P_0)
	{
		return ((IndicatorsHelper)P_0).Delta;
	}

	internal static object YJpyIHeiRdttSG8xxPZS(object P_0)
	{
		return ((IndicatorsHelper)P_0).OpenPos;
	}

	internal static object aHFtfJei6f7srym3LaPW(object P_0)
	{
		return ((IndicatorSourceBase)P_0).SelectedSeries;
	}

	internal static void Ep8WMBeiMbYjpJA1pM7t()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void s0cygeeiONrx5pr3FsiI()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
