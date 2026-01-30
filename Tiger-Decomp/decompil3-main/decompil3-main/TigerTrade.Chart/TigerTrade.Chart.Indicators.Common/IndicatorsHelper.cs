using System;
using System.Linq;
using System.Runtime.CompilerServices;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using TicTacTec.TA.Library;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Enums;

namespace TigerTrade.Chart.Indicators.Common;

public sealed class IndicatorsHelper
{
	[CompilerGenerated]
	private sealed class WV9NUOimyeI0UnMEOe1m
	{
		public double woqimrf1yvK;

		private static WV9NUOimyeI0UnMEOe1m qPyB30eTalTh2VPKLnej;

		public WV9NUOimyeI0UnMEOe1m()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		internal double c5VimZ1BFrr(double x)
		{
			return x / woqimrf1yvK;
		}

		internal double HUtimVr4iMP(double x)
		{
			return x / woqimrf1yvK;
		}

		internal double uDrimCPm8bY(double x)
		{
			return x / woqimrf1yvK;
		}

		static WV9NUOimyeI0UnMEOe1m()
		{
			JWKVvoeT42hY4LQuuiij();
			fVif2jeTDhG23O6KH76A();
		}

		internal static bool C3OVPOeTicJZENLArCh5()
		{
			return qPyB30eTalTh2VPKLnej == null;
		}

		internal static WV9NUOimyeI0UnMEOe1m G0YPhgeTlwemZgHXwoQB()
		{
			return qPyB30eTalTh2VPKLnej;
		}

		internal static void JWKVvoeT42hY4LQuuiij()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}

		internal static void fVif2jeTDhG23O6KH76A()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	internal static IndicatorsHelper EsmcTceOSspOU8918K7C;

	public IChartDataProvider DataProvider { get; private set; }

	public double[] Date => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-176525661 ^ -176503521));

	public double[] Open => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-671204305 ^ -671180825));

	public double[] High => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24085900 ^ 0x2408DBAA));

	public double[] Low => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-44540535 ^ -44507329));

	public double[] Close => GetDataFromProvider((string)n2VEhHeOsde6eEQfNdsU(-371631841 ^ -371598461));

	public double[] Poc => GetDataFromProvider((string)n2VEhHeOsde6eEQfNdsU(0xECA3F28 ^ 0xECAB1BE));

	public double[] Trades => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECA94FC));

	public double[] Volume => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4A297));

	public double[] Bid => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799549317));

	public double[] Ask => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x37B74BDF ^ 0x37B7E021));

	public double[] Delta => GetDataFromProvider((string)n2VEhHeOsde6eEQfNdsU(-1999650146 ^ -1999671658));

	public double[] OpenPos => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181386752));

	public double[] OpenPosChg => GetDataFromProvider(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-690510723 ^ -690550699));

	public double[] OpenPosAskChg => GetDataFromProvider((string)n2VEhHeOsde6eEQfNdsU(-1306877528 ^ -1306915352));

	public double[] OpenPosBidChg => GetDataFromProvider((string)n2VEhHeOsde6eEQfNdsU(--737722733 ^ 0x2BF86D33));

	public int Count => DataProvider.Count;

	public void SetDataProvider(IChartDataProvider dp)
	{
		DataProvider = dp;
	}

	private double[] GetDataFromProvider(string dataName)
	{
		return (double[])RSXrKdeOe3pxLdZCQpiK(DataProvider, dataName);
	}

	public double[] Price(IndicatorPriceType priceField)
	{
		double[] result = Close;
		int num;
		switch (priceField)
		{
		case IndicatorPriceType.Low:
			result = Low;
			num = 3;
			goto IL_0009;
		case IndicatorPriceType.Typical:
			result = TypicalPrice();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case IndicatorPriceType.High:
			goto IL_00a6;
		case IndicatorPriceType.Median:
			result = MedianPrice();
			break;
		case IndicatorPriceType.Open:
			goto IL_0119;
			IL_00a6:
			result = High;
			break;
			IL_0009:
			switch (num)
			{
			case 2:
				break;
			default:
				goto IL_00a6;
			case 1:
			case 3:
				goto end_IL_00ea;
			case 4:
				goto IL_0119;
			}
			goto case IndicatorPriceType.Low;
			IL_0119:
			result = Open;
			break;
			end_IL_00ea:
			break;
		}
		return result;
	}

	public double[] MedianPrice()
	{
		int count = Count;
		double[] high = High;
		double[] low = Low;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
		{
			num = 1;
		}
		double[] array = default(double[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				array[num2] = (high[num2] + low[num2]) / 2.0;
				num2++;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return array;
			case 3:
				if (num2 >= count)
				{
					int num3 = 2;
					num = num3;
					break;
				}
				goto default;
			case 1:
				array = new double[count];
				num2 = 0;
				goto case 3;
			}
		}
	}

	public double[] TypicalPrice()
	{
		int count = Count;
		double[] high = High;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
		{
			num = 1;
		}
		int i = default(int);
		double[] array = default(double[]);
		double[] low = default(double[]);
		double[] close = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 2:
			{
				for (; i < count; i++)
				{
					array[i] = (high[i] + low[i] + close[i]) / 3.0;
				}
				int num2 = 3;
				num = num2;
				continue;
			}
			case 1:
				low = Low;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				return array;
			}
			close = Close;
			array = new double[count];
			i = 0;
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
			{
				num = 0;
			}
		}
	}

	private TicTacTec.TA.Library.Core.MAType ConvertMaType(IndicatorMaType maType)
	{
		TicTacTec.TA.Library.Core.MAType result = TicTacTec.TA.Library.Core.MAType.Sma;
		int num;
		switch (maType)
		{
		case IndicatorMaType.TEMA:
			result = TicTacTec.TA.Library.Core.MAType.Tema;
			break;
		case IndicatorMaType.SMA:
			result = TicTacTec.TA.Library.Core.MAType.Sma;
			break;
		case IndicatorMaType.TMA:
			result = TicTacTec.TA.Library.Core.MAType.Trima;
			break;
		case IndicatorMaType.T3:
			result = TicTacTec.TA.Library.Core.MAType.T3;
			break;
		case IndicatorMaType.MAMA:
			result = TicTacTec.TA.Library.Core.MAType.Mama;
			num = 7;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		case IndicatorMaType.WMA:
			goto IL_00f0;
		case IndicatorMaType.EMA:
			goto IL_013c;
		case IndicatorMaType.KAMA:
			goto IL_0144;
		case IndicatorMaType.DEMA:
			goto IL_015b;
			IL_0009:
			switch (num)
			{
			case 5:
				break;
			case 2:
			case 4:
			case 7:
				goto end_IL_010e;
			case 3:
				goto IL_00f0;
			default:
				goto IL_013c;
			case 1:
				goto IL_0144;
			case 6:
				goto IL_015b;
			}
			goto case IndicatorMaType.MAMA;
			IL_015b:
			result = TicTacTec.TA.Library.Core.MAType.Dema;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
			{
				num = 2;
			}
			goto IL_0009;
			IL_0144:
			result = TicTacTec.TA.Library.Core.MAType.Kama;
			break;
			IL_013c:
			result = TicTacTec.TA.Library.Core.MAType.Ema;
			break;
			IL_00f0:
			result = TicTacTec.TA.Library.Core.MAType.Wma;
			num = 4;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
			{
				num = 4;
			}
			goto IL_0009;
			end_IL_010e:
			break;
		}
		return result;
	}

	private static void MinMax(double[] d, int period, out double[] min, out double[] max)
	{
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		double[] array = default(double[]);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				min[num3] = array[num3 - outBegIdx];
				num2 = 8;
				break;
			case 8:
				max[num3] = array2[num3 - outBegIdx];
				goto IL_0114;
			default:
				if (num4 >= d.Length)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 6:
				max[num4] = double.NaN;
				num4++;
				goto default;
			case 2:
				min = new double[d.Length];
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				max = new double[d.Length];
				num4 = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
			{
				if (TicTacTec.TA.Library.Core.MinMax(0, d.Length - 1, d, period, out outBegIdx, out var _, array, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					return;
				}
				num3 = 0;
				goto IL_00d2;
			}
			case 5:
				array = new double[d.Length];
				array2 = new double[d.Length];
				num2 = 3;
				break;
			case 7:
				{
					min[num4] = double.NaN;
					num2 = 6;
					break;
				}
				IL_0114:
				num3++;
				goto IL_00d2;
				IL_00d2:
				if (num3 >= d.Length)
				{
					return;
				}
				if (num3 >= outBegIdx)
				{
					num2 = 4;
					break;
				}
				goto IL_0114;
			}
		}
	}

	public double[] Max(double[] d, int period)
	{
		double[] array = new double[d.Length];
		int i = 0;
		int num = 4;
		int num2 = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				for (; i < d.Length; i++)
				{
					array[i] = double.NaN;
				}
				num = 5;
				break;
			case 3:
				if (num2 >= d.Length)
				{
					goto default;
				}
				if (num2 >= outBegIdx)
				{
					array[num2] = array2[num2 - outBegIdx];
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
					{
						num = 0;
					}
					break;
				}
				goto case 1;
			case 5:
			{
				array2 = new double[d.Length];
				if (TicTacTec.TA.Library.Core.Max(0, d.Length - 1, d, period, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 2;
			}
			case 2:
				num2 = 0;
				num = 3;
				break;
			case 1:
				num2++;
				goto case 3;
			default:
				return array;
			}
		}
	}

	public double[] Min(double[] d, int period)
	{
		double[] array = new double[d.Length];
		int num = 0;
		int num2 = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
		{
			num2 = 0;
		}
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return array;
			case 2:
			{
				array2 = new double[d.Length];
				if (TicTacTec.TA.Library.Core.Min(0, d.Length - 1, d, period, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					goto case 1;
				}
				num3 = 0;
				goto case 4;
			}
			case 3:
				if (num3 >= outBegIdx)
				{
					array[num3] = array2[num3 - outBegIdx];
				}
				num3++;
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				if (num3 >= d.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				if (num < d.Length)
				{
					array[num] = double.NaN;
					num++;
					num2 = 5;
				}
				else
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public double[] Subtraction(double[] d1, double[] d2)
	{
		double[] array = new double[d1.Length];
		int num = 0;
		while (num < d1.Length)
		{
			while (true)
			{
				array[num] = d1[num] - d2[num];
				num++;
				int num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num2 = 1;
				}
				switch (num2)
				{
				default:
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		return array;
	}

	private double[] Sum(double[] d, int n)
	{
		int num = 3;
		int num2 = num;
		double[] array = default(double[]);
		int num4 = default(int);
		double num3 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 5:
				array[num4] = num3;
				num2 = 7;
				break;
			case 6:
				num3 += d[num4];
				num2 = 4;
				break;
			case 7:
				num4++;
				goto default;
			case 3:
				array = new double[d.Length];
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (n != 0)
				{
					if (num4 > n && !double.IsNaN(d[num4 - n - 1]))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 8;
				}
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				num3 = (array[num4] = num3 - d[num4 - n - 1]);
				goto case 7;
			case 2:
				num3 = 0.0;
				num4 = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				array[num4] = double.NaN;
				goto case 7;
			default:
				if (num4 < d.Length)
				{
					if (!ldB66OeOXEUBNkqICWju(d[num4]))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
						{
							num2 = 6;
						}
						break;
					}
					array[num4] = double.NaN;
					goto case 7;
				}
				return array;
			}
		}
	}

	public double[] ShiftData(double[] data, int shift)
	{
		int num = 8;
		int i = default(int);
		int num3 = default(int);
		int num4 = default(int);
		double[] array = default(double[]);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (shift > 0)
					{
						i = 0;
						num2 = 10;
						continue;
					}
					goto case 2;
				case 4:
					if (num3 > data.Length - 1 + shift)
					{
						goto default;
					}
					num4 = data.Length - 1;
					goto case 1;
				case 7:
					if (shift == 0)
					{
						goto IL_01f8;
					}
					array = new double[data.Length + Math.Max(0, shift)];
					num2 = 6;
					continue;
				case 10:
					for (; i < shift; i++)
					{
						array[i] = double.NaN;
					}
					num5 = 0;
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num2 = 9;
					}
					continue;
				default:
					array[num3] = double.NaN;
					num2 = 5;
					continue;
				case 9:
				case 11:
					if (num5 >= data.Length)
					{
						goto case 3;
					}
					array[num5 + shift] = data[num5];
					num5++;
					num = 11;
					break;
				case 3:
					return array;
				case 1:
					if (num4 >= -shift)
					{
						array[num4 + shift] = data[num4];
						num4--;
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num = 3;
					break;
				case 8:
					if (data.Length >= -shift)
					{
						num2 = 7;
						continue;
					}
					goto IL_01f8;
				case 5:
					num3--;
					goto case 4;
				case 2:
					{
						num3 = data.Length - 1;
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
						{
							num2 = 3;
						}
						continue;
					}
					IL_01f8:
					return data;
				}
				break;
			}
		}
	}

	public double[] SAR(double step, double maxp)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 0;
		int num2 = 5;
		int num3 = num2;
		int num4 = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		while (true)
		{
			switch (num3)
			{
			case 2:
				if (num4 >= count)
				{
					goto IL_00f0;
				}
				if (num4 >= outBegIdx)
				{
					array[num4] = array2[num4 - outBegIdx];
				}
				num4++;
				num3 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
				{
					num3 = 1;
				}
				break;
			default:
				if (num >= count)
				{
					array2 = new double[count];
					num3 = 3;
					break;
				}
				goto case 1;
			case 3:
			{
				if (TicTacTec.TA.Library.Core.Sar(0, count - 1, High, Low, step, maxp, out outBegIdx, out var _, array2) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num4 = 0;
					goto case 2;
				}
				goto IL_00f0;
			}
			case 1:
				array[num] = double.NaN;
				num3 = 4;
				break;
			case 4:
				{
					num++;
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
					{
						num3 = 0;
					}
					break;
				}
				IL_00f0:
				return array;
			}
		}
	}

	public void MACD(double[] d, int fastPeriod, int slowPeriod, int signalPeriod, out double[] macd, out double[] macdSignal, out double[] macdHist)
	{
		double[] array = (double[])d.Clone();
		macd = new double[array.Length];
		int num = 6;
		int num3 = default(int);
		int outBegIdx = default(int);
		double[] array3 = default(double[]);
		double[] array4 = default(double[]);
		int num2 = default(int);
		double[] array2 = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 8:
				if (num3 >= outBegIdx)
				{
					macd[num3] = array3[num3 - outBegIdx];
					num = 7;
					break;
				}
				goto IL_017a;
			case 7:
				macdSignal[num3] = array4[num3 - outBegIdx];
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_64274e2af1ab4c6db7e1ad660e8beb8f == 0)
				{
					num = 1;
				}
				break;
			case 4:
				array[num2] = 0.0;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num = 0;
				}
				break;
			case 10:
				if (num2 >= array.Length)
				{
					num = 2;
					break;
				}
				goto case 1;
			case 5:
				num2++;
				num = 10;
				break;
			case 1:
				macd[num2] = double.NaN;
				macdSignal[num2] = double.NaN;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
				{
					num = 0;
				}
				break;
			case 3:
				macdHist[num3] = array2[num3 - outBegIdx];
				goto IL_017a;
			case 2:
				array3 = new double[array.Length];
				array4 = new double[array.Length];
				num = 9;
				break;
			case 6:
				macdSignal = new double[array.Length];
				macdHist = new double[array.Length];
				num2 = 0;
				goto case 10;
			case 9:
			{
				array2 = new double[array.Length];
				if (TicTacTec.TA.Library.Core.Macd(0, array.Length - 1, array, fastPeriod, slowPeriod, Math.Max(1, signalPeriod), out outBegIdx, out var _, array3, array4, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					return;
				}
				num3 = 0;
				goto IL_00b1;
			}
			default:
				{
					macdHist[num2] = double.NaN;
					if (ldB66OeOXEUBNkqICWju(array[num2]))
					{
						num = 4;
						break;
					}
					goto case 5;
				}
				IL_00b1:
				if (num3 >= array.Length)
				{
					return;
				}
				goto case 8;
				IL_017a:
				num3++;
				goto IL_00b1;
			}
		}
	}

	public void Stoch(int fastKPeriod, int slowKPeriod, IndicatorMaType slowKMaType, int slowDPeriod, IndicatorMaType slowDMaType, out double[] slowK, out double[] slowD)
	{
		int num = 1;
		int num2 = num;
		int count = default(int);
		int num3 = default(int);
		int num4 = default(int);
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		double[] array = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				count = Count;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				slowK[num3] = double.NaN;
				slowD[num3] = double.NaN;
				num2 = 3;
				break;
			case 5:
				slowD[num4] = array2[num4 - outBegIdx];
				num2 = 6;
				break;
			case 4:
				num4 = 0;
				goto IL_01d5;
			case 2:
				slowK[num4] = array[num4 - outBegIdx];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				num4++;
				goto IL_01d5;
			case 3:
				num3++;
				goto IL_00dd;
			default:
				slowK = new double[count];
				slowD = new double[count];
				num3 = 0;
				goto IL_00dd;
			case 8:
				{
					if (num4 >= outBegIdx)
					{
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 6;
				}
				IL_00dd:
				if (num3 >= count)
				{
					array = new double[count];
					array2 = new double[count];
					if (TicTacTec.TA.Library.Core.Stoch(0, count - 1, High, Low, Close, fastKPeriod, slowKPeriod, ConvertMaType(slowKMaType), slowDPeriod, ConvertMaType(slowDMaType), out outBegIdx, out var _, array, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						return;
					}
					num2 = 4;
					break;
				}
				goto case 7;
				IL_01d5:
				if (num4 >= count)
				{
					return;
				}
				goto case 8;
			}
		}
	}

	public void BBands(double[] d, int period, double devUp, double devDown, IndicatorMaType maType, out double[] upperBand, out double[] middleBand, out double[] lowerBand)
	{
		double[] array = (double[])d.Clone();
		upperBand = new double[array.Length];
		int num = 6;
		int num3 = default(int);
		double[] array2 = default(double[]);
		double[] array3 = default(double[]);
		int num2 = default(int);
		int outBegIdx = default(int);
		double[] array4 = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				middleBand[num3] = double.NaN;
				lowerBand[num3] = double.NaN;
				num = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb == 0)
				{
					num = 9;
				}
				break;
			case 6:
				middleBand = new double[array.Length];
				lowerBand = new double[array.Length];
				num3 = 0;
				num = 7;
				break;
			default:
				array2 = new double[array.Length];
				array3 = new double[array.Length];
				num = 2;
				break;
			case 1:
			case 10:
				if (num2 >= array.Length)
				{
					num = 11;
					break;
				}
				goto case 3;
			case 2:
			{
				if (TicTacTec.TA.Library.Core.Bbands(0, array.Length - 1, array, period, devUp, devDown, ConvertMaType(maType), out outBegIdx, out var _, array4, array2, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num = 8;
					}
					break;
				}
				return;
			}
			case 3:
				if (num2 >= outBegIdx)
				{
					upperBand[num2] = array4[num2 - outBegIdx] / 100000000.0;
					middleBand[num2] = array2[num2 - outBegIdx] / 100000000.0;
					lowerBand[num2] = array3[num2 - outBegIdx] / 100000000.0;
				}
				num2++;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
				{
					num = 0;
				}
				break;
			case 9:
				if (!double.IsNaN(array[num3]))
				{
					array[num3] *= 100000000.0;
				}
				else
				{
					array[num3] = 0.0;
				}
				num3++;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
				{
					num = 5;
				}
				break;
			case 11:
				return;
			case 5:
			case 7:
				if (num3 < array.Length)
				{
					upperBand[num3] = double.NaN;
					int num4 = 4;
					num = num4;
					break;
				}
				array4 = new double[array.Length];
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 0;
				}
				break;
			case 8:
				num2 = 0;
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	public void Aroon(int period, out double[] aroonUp, out double[] aroonDown)
	{
		int count = Count;
		aroonUp = new double[count];
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
		{
			num = 1;
		}
		double[] array = default(double[]);
		int num3 = default(int);
		int outBegIdx = default(int);
		int num2 = default(int);
		double[] array2 = default(double[]);
		while (true)
		{
			switch (num)
			{
			case 4:
				array = new double[count];
				num = 3;
				break;
			case 1:
				aroonDown = new double[count];
				num = 5;
				break;
			case 2:
				if (num3 >= outBegIdx)
				{
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
					{
						num = 0;
					}
					break;
				}
				goto IL_0033;
			case 5:
				num2 = 0;
				goto IL_00e1;
			case 7:
				aroonUp[num3] = array2[num3 - outBegIdx];
				aroonDown[num3] = array[num3 - outBegIdx];
				goto IL_0033;
			case 6:
				num3 = 0;
				goto IL_00c6;
			case 3:
			{
				if (TicTacTec.TA.Library.Core.Aroon(0, count - 1, High, Low, period, out outBegIdx, out var _, array, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					return;
				}
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num = 6;
				}
				break;
			}
			default:
				{
					num2++;
					goto IL_00e1;
				}
				IL_00e1:
				if (num2 >= count)
				{
					array2 = new double[count];
					num = 4;
					break;
				}
				aroonUp[num2] = double.NaN;
				aroonDown[num2] = double.NaN;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
				{
					num = 0;
				}
				break;
				IL_0033:
				num3++;
				goto IL_00c6;
				IL_00c6:
				if (num3 >= count)
				{
					return;
				}
				goto case 2;
			}
		}
	}

	public double[] SMMA(double[] d, int period)
	{
		int num = 7;
		double[] array3 = default(double[]);
		int num6 = default(int);
		double[] array = default(double[]);
		int num5 = default(int);
		double num3 = default(double);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					array3[num6] = double.NaN;
					if (double.IsNaN(array[num6]))
					{
						num2 = 3;
						break;
					}
					goto case 5;
				case 5:
					num6++;
					goto IL_0155;
				case 3:
					array[num6] = 0.0;
					num2 = 5;
					break;
				default:
					array3[num5] = num3;
					num2 = 8;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
					{
						num2 = 9;
					}
					break;
				case 9:
					num5++;
					goto case 1;
				case 6:
					num4 = array.Length;
					array3 = new double[num4];
					num6 = 0;
					goto IL_0155;
				case 2:
					if (num4 >= period)
					{
						double[] array2 = new double[period];
						Array.Copy(array, array2, period);
						num3 = (array3[period - 1] = array2.Average());
					}
					num5 = period;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					if (num5 >= num4)
					{
						return array3;
					}
					num3 = (num3 * (double)(period - 1) + array[num5]) / (double)period;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
					{
						num2 = 0;
					}
					break;
				case 7:
					array = (double[])aG9sJYeOcqYe7oqOsjPr(d);
					num2 = 6;
					break;
				case 4:
					{
						num3 = 0.0;
						num2 = 2;
						break;
					}
					IL_0155:
					if (num6 >= num4)
					{
						goto end_IL_0012;
					}
					goto case 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public double[] MovingAverage(IndicatorMaType maType, double[] d, int period)
	{
		int num = 8;
		int num2 = num;
		int num4 = default(int);
		int outBegIdx = default(int);
		double[] array = default(double[]);
		double[] array3 = default(double[]);
		double[] array2 = default(double[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (num4 >= outBegIdx)
				{
					array[num4] = array3[num4 - outBegIdx];
				}
				num4++;
				goto default;
			case 6:
				array2[num3] = 0.0;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if (maType == IndicatorMaType.SMMA)
				{
					num2 = 7;
					break;
				}
				array2 = (double[])d.Clone();
				num2 = 2;
				break;
			case 7:
				return SMMA(d, period);
			default:
				if (num4 < array2.Length)
				{
					goto case 5;
				}
				goto IL_0076;
			case 3:
				if (num3 >= array2.Length)
				{
					num2 = 4;
					break;
				}
				array[num3] = double.NaN;
				if (double.IsNaN(array2[num3]))
				{
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 1;
			case 1:
				num3++;
				goto case 3;
			case 4:
			{
				array3 = new double[array2.Length];
				if (TicTacTec.TA.Library.Core.MovingAverage(0, array2.Length - 1, array2, period, ConvertMaType(maType), out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num4 = 0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0076;
			}
			case 2:
				{
					array = new double[array2.Length];
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
					{
						num2 = 3;
					}
					break;
				}
				IL_0076:
				return array;
			}
		}
	}

	public double[] PPO(IndicatorMaType maType, double[] d, int shortPeriod, int longPeriod)
	{
		double num = ztWkbPeOEtpK1GEYpZDC(xRfTVEeOjmRrb6eBCiTs(DataProvider.Symbol));
		double[] array = (double[])d.Clone();
		double[] array2 = new double[array.Length];
		int num2 = 0;
		double[] array3 = default(double[]);
		int outBegIdx = default(int);
		int num5 = default(int);
		while (true)
		{
			IL_00e7:
			int num3;
			if (num2 >= array.Length)
			{
				array3 = new double[d.Length];
				num3 = 8;
				goto IL_0009;
			}
			goto IL_014e;
			IL_0097:
			array[num2] = 0.0;
			goto IL_00aa;
			IL_014e:
			array2[num2] = double.NaN;
			if (double.IsNaN(array[num2]))
			{
				goto IL_0097;
			}
			if (((IChartSymbol)kEBaBIeOQmiGFK8T3pJG(DataProvider)).IsDenomination)
			{
				num3 = 5;
				goto IL_0009;
			}
			goto IL_00aa;
			IL_00aa:
			num2++;
			num3 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
			{
				num3 = 0;
			}
			goto IL_0009;
			IL_0009:
			while (true)
			{
				switch (num3)
				{
				case 3:
					return array2;
				case 8:
				{
					if (TicTacTec.TA.Library.Core.Ppo(0, array.Length - 1, array, shortPeriod, longPeriod, ConvertMaType(maType), out outBegIdx, out var _, array3) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						goto case 3;
					}
					goto case 7;
				}
				case 9:
					break;
				case 2:
					goto IL_00aa;
				case 7:
					num5 = 0;
					num3 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51365cbe57344dc59bfcbecc60361463 == 0)
					{
						num3 = 4;
					}
					continue;
				default:
					goto IL_00e7;
				case 1:
					goto IL_014e;
				case 4:
				case 6:
					goto IL_0194;
				case 5:
				{
					array[num2] /= num;
					int num4 = 2;
					num3 = num4;
					continue;
				}
				}
				break;
				IL_0194:
				if (num5 >= d.Length)
				{
					num3 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
					{
						num3 = 2;
					}
					continue;
				}
				if (num5 >= outBegIdx)
				{
					array2[num5] = array3[num5 - outBegIdx];
				}
				num5++;
				num3 = 4;
			}
			goto IL_0097;
		}
	}

	public double[] CO(IndicatorMaType maType, int shortPeriod, int longPeriod)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 5;
		int num2 = num;
		int num4 = default(int);
		double[] array2 = default(double[]);
		int num3 = default(int);
		int outBegIdx = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 4:
				if (num4 < count)
				{
					array[num4] = double.NaN;
					num4++;
					num2 = 2;
					break;
				}
				array2 = new double[count];
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				num4 = 0;
				num2 = 4;
				break;
			default:
				num3++;
				goto IL_00cd;
			case 3:
				return array;
			case 1:
				{
					if (TicTacTec.TA.Library.Core.AdOsc(0, count - 1, High, Low, Close, Volume, shortPeriod, longPeriod, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						goto case 3;
					}
					num3 = 0;
					goto IL_00cd;
				}
				IL_00cd:
				if (num3 < count)
				{
					if (num3 >= outBegIdx)
					{
						array[num3] = array2[num3 - outBegIdx];
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
				num2 = 3;
				break;
			}
		}
	}

	public double[] RSI(double[] d, int period)
	{
		double[] array = (double[])aG9sJYeOcqYe7oqOsjPr(d);
		double[] array2 = new double[array.Length];
		int num = 6;
		int outBegIdx = default(int);
		double[] array3 = default(double[]);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				if (TicTacTec.TA.Library.Core.Rsi(0, array.Length - 1, array, period, out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num2 = 0;
					num = 5;
					break;
				}
				goto IL_0135;
			}
			case 2:
				num3++;
				goto case 7;
			default:
				array[num3] = 0.0;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num = 2;
				}
				break;
			case 3:
				array2[num3] = double.NaN;
				if (!double.IsNaN(array[num3]))
				{
					goto case 2;
				}
				goto default;
			case 6:
				num3 = 0;
				num = 7;
				break;
			case 7:
				if (num3 >= array.Length)
				{
					array3 = new double[array.Length];
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 3;
			case 4:
			case 5:
				{
					if (num2 < array.Length)
					{
						if (num2 >= outBegIdx)
						{
							array2[num2] = array3[num2 - outBegIdx];
						}
						num2++;
						num = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 != 0)
						{
							num = 3;
						}
						break;
					}
					goto IL_0135;
				}
				IL_0135:
				return array2;
			}
		}
	}

	public double[] ATR(int period)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
		{
			num = 4;
		}
		int num2 = default(int);
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				num2 = 0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num = 0;
				}
				break;
			default:
				if (num2 >= count)
				{
					array2 = new double[count];
					if (TicTacTec.TA.Library.Core.Atr(0, count - 1, High, Low, Close, period, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						num = 2;
						break;
					}
					goto case 3;
				}
				array[num2] = double.NaN;
				num2++;
				num = 5;
				break;
			case 3:
				num3 = 0;
				goto IL_0132;
			case 1:
			case 2:
				return array;
			case 6:
				{
					num3++;
					goto IL_0132;
				}
				IL_0132:
				if (num3 < count)
				{
					if (num3 >= outBegIdx)
					{
						array[num3] = array2[num3 - outBegIdx];
						num = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa == 0)
						{
							num = 6;
						}
						break;
					}
					goto case 6;
				}
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public double[] ATR(int period, IndicatorMaType maType)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 5;
		int i = default(int);
		int num2 = default(int);
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				for (; i < count; i++)
				{
					array[i] = double.NaN;
				}
				num = 4;
				continue;
			case 3:
				num2 = 0;
				goto case 1;
			case 5:
				i = 0;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
				{
					num = 2;
				}
				continue;
			case 4:
				array2 = new double[count];
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				if (num2 < count)
				{
					if (num2 >= outBegIdx)
					{
						array[num2] = array2[num2 - outBegIdx];
					}
					num2++;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num = 1;
					}
					continue;
				}
				return MovingAverage(maType, array, period);
			}
			if (TicTacTec.TA.Library.Core.TrueRange(0, Count - 1, High, Low, Close, out outBegIdx, out var _, array2) == TicTacTec.TA.Library.Core.RetCode.Success)
			{
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
				{
					num = 1;
				}
				continue;
			}
			return array;
		}
	}

	public double CloseCorrelation(int correlationPeriod, double[] close2, int excludeLastElements1 = 0, int excludeLastElements2 = 0)
	{
		double num = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		int num5 = 7;
		double num9 = default(double);
		double num10 = default(double);
		int num8 = default(int);
		double num11 = default(double);
		double num12 = default(double);
		double num14 = default(double);
		int num13 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num15;
			switch (num5)
			{
			case 7:
				num9 = 0.0;
				num5 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num5 = 5;
				}
				break;
			case 8:
				num10 = fZZypueOdLpGyoLbTwdw(num2 / (double)num8 - num * num / (double)num8 / (double)num8);
				num11 = Math.Sqrt(num4 / (double)num8 - num3 * num3 / (double)num8 / (double)num8);
				num5 = 4;
				break;
			case 1:
				num3 += num12;
				num4 += num12 * num12;
				num15 = 2;
				goto IL_0005;
			case 4:
				return (num9 / (double)num8 - num * num3 / (double)num8 / (double)num8) / num10 / num11;
			case 6:
				num2 += num14 * num14;
				num5 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
				{
					num5 = 1;
				}
				break;
			default:
				num13 = 1;
				goto IL_0188;
			case 2:
				num9 += num14 * num12;
				num13++;
				goto IL_0188;
			case 3:
				num12 = close2[num7 - num13];
				num += num14;
				num15 = 6;
				goto IL_0005;
			case 5:
				{
					num6 = Close.Length - excludeLastElements1;
					num7 = close2.Length - excludeLastElements2;
					num8 = Math.Min(correlationPeriod, Math.Min(num6, num7));
					num5 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num5 = 0;
					}
					break;
				}
				IL_0188:
				if (num13 <= num8)
				{
					num14 = Close[num6 - num13];
					num5 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
					{
						num5 = 3;
					}
				}
				else
				{
					num5 = 8;
				}
				break;
				IL_0005:
				num5 = num15;
				break;
			}
		}
	}

	public double[] CCI(int period)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 2;
		int num2 = num;
		double[] array2 = default(double[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				array2 = new double[count];
				num2 = 3;
				continue;
			case 2:
				num3 = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (num3 >= count)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num2 = 1;
					}
					continue;
				}
				array[num3] = double.NaN;
				num3++;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
				{
					num2 = 4;
				}
				continue;
			case 3:
			{
				if (TicTacTec.TA.Library.Core.Cci(0, count - 1, High, Low, Close, period, out var outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					break;
				}
				for (int i = 0; i < count; i++)
				{
					if (i >= outBegIdx)
					{
						array[i] = array2[i - outBegIdx];
					}
				}
				num2 = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5c9da2ed0d9f4b4dbc84580bf3b83e9f == 0)
				{
					num2 = 5;
				}
				continue;
			}
			case 5:
				break;
			}
			break;
		}
		return array;
	}

	public double[] Momentum(double[] d, int period)
	{
		double[] array = (double[])d.Clone();
		double[] array2 = new double[array.Length];
		int num = 7;
		double[] array3 = default(double[]);
		int num3 = default(int);
		int num2 = default(int);
		int outBegIdx = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				array3 = new double[array.Length];
				num = 5;
				continue;
			case 7:
				num3 = 0;
				num = 6;
				continue;
			default:
				if (num2 >= array.Length)
				{
					break;
				}
				if (num2 >= outBegIdx)
				{
					array2[num2] = array3[num2 - outBegIdx];
					num = 4;
					continue;
				}
				goto case 4;
			case 6:
				if (num3 >= array.Length)
				{
					int num4 = 2;
					num = num4;
					continue;
				}
				array2[num3] = double.NaN;
				if (ldB66OeOXEUBNkqICWju(array[num3]))
				{
					array[num3] = 0.0;
					goto case 3;
				}
				num = 3;
				continue;
			case 4:
				num2++;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 1;
				}
				continue;
			case 3:
				num3++;
				goto case 6;
			case 5:
			{
				if (TicTacTec.TA.Library.Core.Mom(0, array.Length - 1, array, period, out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num2 = 0;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
			}
			break;
		}
		return array2;
	}

	public double[] ROC(double[] d, int period)
	{
		double[] array = (double[])aG9sJYeOcqYe7oqOsjPr(d);
		double[] array2 = new double[array.Length];
		int num = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
		{
			num = 2;
		}
		int outBegIdx = default(int);
		double[] array3 = default(double[]);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				if (TicTacTec.TA.Library.Core.Roc(0, array.Length - 1, array, period, out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num = 6;
					break;
				}
				goto IL_00b6;
			}
			case 4:
				num2++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 == 0)
				{
					num = 1;
				}
				break;
			case 1:
			case 5:
				if (num2 >= array.Length)
				{
					num = 3;
					break;
				}
				array2[num2] = double.NaN;
				if (ldB66OeOXEUBNkqICWju(array[num2]))
				{
					array[num2] = 0.0;
					int num3 = 4;
					num = num3;
					break;
				}
				goto case 4;
			case 3:
				array3 = new double[array.Length];
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
				{
					num = 0;
				}
				break;
			case 6:
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (i >= outBegIdx)
					{
						array2[i] = array3[i - outBegIdx];
					}
				}
				goto IL_00b6;
			}
			case 2:
				{
					num2 = 0;
					num = 5;
					break;
				}
				IL_00b6:
				return array2;
			}
		}
	}

	public double[] ADX(int period)
	{
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		int count = default(int);
		double[] array = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (num3 >= count)
				{
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto default;
			case 5:
			{
				double[] array2 = new double[count];
				if (TicTacTec.TA.Library.Core.Adx(0, count - 1, High, Low, Close, period, out var outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num2 = 7;
					continue;
				}
				for (int i = 0; i < count; i++)
				{
					if (i >= outBegIdx)
					{
						array[i] = array2[i - outBegIdx];
					}
				}
				break;
			}
			case 4:
				num3 = 0;
				num2 = 6;
				continue;
			case 2:
				count = Count;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				array = new double[count];
				num2 = 4;
				continue;
			default:
				array[num3] = double.NaN;
				num2 = 3;
				continue;
			case 3:
				num3++;
				goto case 6;
			case 7:
				break;
			}
			break;
		}
		return array;
	}

	public double[] PlusDI(int period)
	{
		int num = 7;
		int num2 = num;
		int num3 = default(int);
		int count = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		double[] array = default(double[]);
		int num4 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				num3++;
				goto case 4;
			case 4:
				if (num3 >= count)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e == 0)
					{
						num2 = 0;
					}
					break;
				}
				if (num3 >= outBegIdx)
				{
					array2[num3] = array[num3 - outBegIdx];
					num2 = 3;
					break;
				}
				goto case 3;
			case 7:
				count = Count;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				num4 = 0;
				goto default;
			case 6:
				array2 = new double[count];
				num2 = 5;
				break;
			case 2:
			{
				if (TicTacTec.TA.Library.Core.PlusDI(0, count - 1, High, Low, Close, period, out outBegIdx, out var _, array) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num3 = 0;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 1;
			}
			default:
				if (num4 >= count)
				{
					array = new double[count];
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
					{
						num2 = 2;
					}
					break;
				}
				array2[num4] = double.NaN;
				num4++;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return array2;
			}
		}
	}

	public double[] MinusDI(int period)
	{
		int num = 2;
		int num2 = num;
		int num4 = default(int);
		int count = default(int);
		double[] array = default(double[]);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				if (num4 >= count)
				{
					goto case 6;
				}
				goto case 4;
			case 6:
				return array;
			case 4:
				if (num4 >= outBegIdx)
				{
					array[num4] = array2[num4 - outBegIdx];
					num2 = 3;
					continue;
				}
				break;
			case 5:
				if (num3 >= count)
				{
					array2 = new double[count];
					if (TicTacTec.TA.Library.Core.MinusDI(0, count - 1, High, Low, Close, period, out outBegIdx, out var _, array2) == TicTacTec.TA.Library.Core.RetCode.Success)
					{
						num4 = 0;
						goto default;
					}
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
					{
						num2 = 6;
					}
					continue;
				}
				array[num3] = double.NaN;
				num2 = 7;
				continue;
			case 7:
				num3++;
				goto case 5;
			case 2:
				count = Count;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				array = new double[count];
				num3 = 0;
				num2 = 5;
				continue;
			case 3:
				break;
			}
			num4++;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 == 0)
			{
				num2 = 0;
			}
		}
	}

	public double[] Variance(double[] d, int period, double dev)
	{
		double[] array = (double[])d.Clone();
		double[] array2 = new double[array.Length];
		int num = 5;
		int num2 = default(int);
		double[] array3 = default(double[]);
		int outBegIdx = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
			{
				if (num2 < array.Length)
				{
					array2[num2] = double.NaN;
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
					{
						num = 3;
					}
					break;
				}
				array3 = new double[array.Length];
				if (TicTacTec.TA.Library.Core.Variance(0, array.Length - 1, array, period, dev, out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num3 = 0;
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
					{
						num = 2;
					}
					break;
				}
				goto IL_015b;
			}
			case 2:
			case 3:
				if (num3 >= array.Length)
				{
					goto IL_015b;
				}
				if (num3 >= outBegIdx)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num = 0;
					}
					break;
				}
				goto IL_013b;
			case 6:
				if (double.IsNaN(array[num2]))
				{
					array[num2] = 0.0;
				}
				num2++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f != 0)
				{
					num = 0;
				}
				break;
			case 1:
				array2[num3] = array3[num3 - outBegIdx];
				goto IL_013b;
			case 5:
				{
					num2 = 0;
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
					{
						num = 4;
					}
					break;
				}
				IL_015b:
				return array2;
				IL_013b:
				num3++;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	public double[] WilliamsR(int period)
	{
		int num = 4;
		int num2 = num;
		double[] array = default(double[]);
		int count = default(int);
		int num4 = default(int);
		int num3 = default(int);
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				array = new double[count];
				num4 = 0;
				goto IL_00ba;
			case 2:
				array[num3] = array2[num3 - outBegIdx];
				break;
			case 1:
			{
				array2 = new double[count];
				if (TicTacTec.TA.Library.Core.WillR(0, count - 1, High, Low, Close, period, out outBegIdx, out var _, array2) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num3 = 0;
					num2 = 7;
					continue;
				}
				goto IL_0057;
			}
			case 6:
				if (num3 >= outBegIdx)
				{
					num2 = 2;
					continue;
				}
				break;
			default:
				num4++;
				goto IL_00ba;
			case 4:
				count = Count;
				num2 = 3;
				continue;
			case 5:
			case 7:
				{
					if (num3 >= count)
					{
						goto IL_0057;
					}
					goto case 6;
				}
				IL_0057:
				return array;
				IL_00ba:
				if (num4 >= count)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
					{
						num2 = 1;
					}
					continue;
				}
				array[num4] = double.NaN;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			num3++;
			num2 = 5;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
			{
				num2 = 3;
			}
		}
	}

	public double[] StdDev(double[] d, int period)
	{
		int num = 7;
		double[] array3 = default(double[]);
		double[] array = default(double[]);
		int num3 = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					array3 = (double[])aG9sJYeOcqYe7oqOsjPr(d);
					num2 = 6;
					break;
				case 3:
					array[num3] = double.NaN;
					if (!ldB66OeOXEUBNkqICWju(array3[num3]))
					{
						array3[num3] *= 100000000.0;
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
						{
							num2 = 0;
						}
					}
					break;
				case 8:
				{
					if (TicTacTec.TA.Library.Core.StdDev(0, array3.Length - 1, array3, period, 1.0, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						goto IL_00eb;
					}
					num4 = 0;
					goto IL_0167;
				}
				case 1:
					array3[num3] = 0.0;
					num2 = 2;
					break;
				case 5:
					num3 = 0;
					goto IL_0177;
				case 6:
					array = new double[array3.Length];
					num2 = 5;
					break;
				default:
					array[num4] = array2[num4 - outBegIdx] / 100000000.0;
					goto IL_01c6;
				case 2:
				case 4:
					{
						num3++;
						goto IL_0177;
					}
					IL_0177:
					if (num3 >= array3.Length)
					{
						goto end_IL_0012;
					}
					goto case 3;
					IL_01c6:
					num4++;
					goto IL_0167;
					IL_0167:
					if (num4 >= array3.Length)
					{
						goto IL_00eb;
					}
					if (num4 >= outBegIdx)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_01c6;
					IL_00eb:
					return array;
				}
				continue;
				end_IL_0012:
				break;
			}
			array2 = new double[array3.Length];
			num = 8;
		}
	}

	public double[] UltOsc(int period1, int period2, int period3)
	{
		int num = 10;
		int count = default(int);
		double[] inHigh = default(double[]);
		double[] inLow = default(double[]);
		double[] inClose = default(double[]);
		int outBegIdx = default(int);
		double[] array3 = default(double[]);
		int num3 = default(int);
		WV9NUOimyeI0UnMEOe1m wV9NUOimyeI0UnMEOe1m = default(WV9NUOimyeI0UnMEOe1m);
		double[] array = default(double[]);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			double[] obj;
			while (true)
			{
				double[] array2;
				switch (num2)
				{
				case 2:
				{
					if (TicTacTec.TA.Library.Core.UltOsc(0, count - 1, inHigh, inLow, inClose, period1, period2, period3, out outBegIdx, out var _, array3) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						goto case 11;
					}
					num3 = 0;
					goto IL_01ad;
				}
				case 5:
					obj = (Q1DZh4eOg8EaMTj4Lb11(kEBaBIeOQmiGFK8T3pJG(DataProvider)) ? Low.Select(wV9NUOimyeI0UnMEOe1m.HUtimVr4iMP).ToArray() : Low);
					break;
				case 7:
					num3++;
					goto IL_01ad;
				case 8:
					array2 = High;
					goto IL_026a;
				case 10:
					wV9NUOimyeI0UnMEOe1m = new WV9NUOimyeI0UnMEOe1m();
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					return array;
				case 3:
				case 4:
					if (num4 >= count)
					{
						array3 = new double[count];
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 6:
					array[num4] = double.NaN;
					num4++;
					num2 = 3;
					continue;
				case 1:
					num4 = 0;
					num2 = 4;
					continue;
				default:
					wV9NUOimyeI0UnMEOe1m.woqimrf1yvK = (double)DataProvider.Symbol.StepPrice;
					if (!Q1DZh4eOg8EaMTj4Lb11(DataProvider.Symbol))
					{
						num2 = 8;
						continue;
					}
					array2 = High.Select(wV9NUOimyeI0UnMEOe1m.c5VimZ1BFrr).ToArray();
					goto IL_026a;
				case 9:
					{
						count = Count;
						array = new double[count];
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_026a:
					inHigh = array2;
					num2 = 5;
					continue;
					IL_01ad:
					if (num3 >= count)
					{
						num2 = 11;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					if (num3 >= outBegIdx)
					{
						array[num3] = array3[num3 - outBegIdx];
						num2 = 7;
						continue;
					}
					goto case 7;
				}
				break;
			}
			inLow = obj;
			inClose = (Q1DZh4eOg8EaMTj4Lb11(DataProvider.Symbol) ? Close.Select(wV9NUOimyeI0UnMEOe1m.uDrimCPm8bY).ToArray() : Close);
			num = 2;
		}
	}

	public double[] AD()
	{
		int count = Count;
		double[] array = new double[count];
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
		{
			num = 1;
		}
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		int num4 = default(int);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
			{
				if (TicTacTec.TA.Library.Core.Ad(0, count - 1, High, Low, Close, Volume, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
					{
						num = 0;
					}
					break;
				}
				num4 = 0;
				goto default;
			}
			case 1:
				num2 = 0;
				num = 6;
				break;
			default:
				if (num4 >= count)
				{
					goto case 2;
				}
				if (num4 >= outBegIdx)
				{
					array[num4] = array2[num4 - outBegIdx];
					num = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
					{
						num = 2;
					}
					break;
				}
				goto case 5;
			case 2:
				return array;
			case 5:
				num4++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
				{
					num = 0;
				}
				break;
			case 3:
			case 6:
				if (num2 < count)
				{
					array[num2] = double.NaN;
					num2++;
					int num3 = 3;
					num = num3;
				}
				else
				{
					array2 = new double[count];
					num = 4;
				}
				break;
			}
		}
	}

	public double[] OBV()
	{
		int num = 5;
		int count = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		int num4 = default(int);
		double[] array = default(double[]);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					count = Count;
					num2 = 4;
					continue;
				case 6:
					break;
				default:
				{
					if (TicTacTec.TA.Library.Core.Obv(0, count - 1, Close, Volume, out outBegIdx, out var _, array2) != TicTacTec.TA.Library.Core.RetCode.Success)
					{
						goto IL_0058;
					}
					num4 = 0;
					goto IL_0069;
				}
				case 4:
					array = new double[count];
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num4++;
					goto IL_0069;
				case 1:
				case 3:
					{
						if (num3 < count)
						{
							array[num3] = double.NaN;
							num3++;
							num2 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
							{
								num2 = 0;
							}
						}
						else
						{
							array2 = new double[count];
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
							{
								num2 = 0;
							}
						}
						continue;
					}
					IL_0069:
					if (num4 < count)
					{
						if (num4 >= outBegIdx)
						{
							array[num4] = array2[num4 - outBegIdx];
							num2 = 2;
							continue;
						}
						goto case 2;
					}
					goto IL_0058;
					IL_0058:
					return array;
				}
				break;
			}
			num3 = 0;
			num = 3;
		}
	}

	public double[] TRIX(int period)
	{
		int num = 4;
		int num2 = num;
		double[] array2 = default(double[]);
		int num3 = default(int);
		int num4 = default(int);
		double[] array = default(double[]);
		int outBegIdx = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				array2[num3] = double.NaN;
				num3++;
				num2 = 7;
				break;
			case 3:
				array2 = new double[num4];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			case 7:
			{
				if (num3 < num4)
				{
					goto case 2;
				}
				array = new double[num4];
				if (TicTacTec.TA.Library.Core.Trix(0, num4 - 1, Close, period, out outBegIdx, out var _, array) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					goto IL_0100;
				}
				num5 = 0;
				goto case 1;
			}
			case 6:
				num5++;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (num5 >= num4)
				{
					goto IL_0100;
				}
				if (num5 >= outBegIdx)
				{
					array2[num5] = array[num5 - outBegIdx];
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 6;
			case 4:
				num4 = Close.Length;
				num2 = 3;
				break;
			default:
				{
					num3 = 0;
					num2 = 5;
					break;
				}
				IL_0100:
				return array2;
			}
		}
	}

	public double[] MFI(int period)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 0;
		int num4 = default(int);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		while (true)
		{
			int num2;
			if (num >= count)
			{
				num2 = 2;
			}
			else
			{
				array[num] = double.NaN;
				num++;
				int num3 = 3;
				num2 = num3;
			}
			while (true)
			{
				switch (num2)
				{
				case 5:
					num4 = 0;
					goto case 1;
				case 3:
					break;
				case 1:
					if (num4 < count)
					{
						goto case 4;
					}
					goto IL_00b2;
				case 4:
					if (num4 >= outBegIdx)
					{
						array[num4] = array2[num4 - outBegIdx];
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				case 2:
				{
					array2 = new double[count];
					if (TicTacTec.TA.Library.Core.Mfi(0, count - 1, High, Low, Close, Volume, period, out outBegIdx, out var _, array2) == TicTacTec.TA.Library.Core.RetCode.Success)
					{
						num2 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto IL_00b2;
				}
				default:
					{
						num4++;
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					IL_00b2:
					return array;
				}
				break;
			}
		}
	}

	public double[] CMO(double[] d, int period)
	{
		int num = 3;
		int num2 = num;
		int num5 = default(int);
		int num3 = default(int);
		double[] array3 = default(double[]);
		double[] array = default(double[]);
		int outBegIdx = default(int);
		double[] array2 = default(double[]);
		double num4 = default(double);
		while (true)
		{
			switch (num2)
			{
			case 4:
				num5++;
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
				{
					num2 = 5;
				}
				break;
			case 7:
			{
				array3 = new double[array.Length];
				if (TicTacTec.TA.Library.Core.Cmo(0, array.Length - 1, array, period, out outBegIdx, out var _, array3) == TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num2 = 8;
					break;
				}
				goto IL_00f9;
			}
			case 5:
				if (num5 >= array.Length)
				{
					goto IL_00f9;
				}
				if (num5 >= outBegIdx)
				{
					array2[num5] = array3[num5 - outBegIdx];
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 4;
			default:
				array2[num3] = double.NaN;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (num3 >= array.Length)
				{
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22e7feb62ce84fd89a7a86f584263fcc == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto default;
			case 8:
				num5 = 0;
				goto case 5;
			case 2:
				array = (double[])aG9sJYeOcqYe7oqOsjPr(d);
				array2 = new double[array.Length];
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
				{
					num2 = 9;
				}
				break;
			case 3:
				num4 = (double)xRfTVEeOjmRrb6eBCiTs(kEBaBIeOQmiGFK8T3pJG(DataProvider));
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				{
					if (!ldB66OeOXEUBNkqICWju(array[num3]))
					{
						if (DataProvider.Symbol.IsDenomination)
						{
							array[num3] /= num4;
						}
					}
					else
					{
						array[num3] = 0.0;
					}
					num3++;
					goto case 6;
				}
				IL_00f9:
				return array2;
			}
		}
	}

	public double[] LinReg(double[] d, int period)
	{
		int num = 4;
		int num2 = num;
		double[] array3 = default(double[]);
		int num3 = default(int);
		double[] array2 = default(double[]);
		int outBegIdx = default(int);
		double[] array = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 7:
			case 8:
				return array3;
			default:
				num3++;
				goto IL_0152;
			case 4:
				array2 = (double[])aG9sJYeOcqYe7oqOsjPr(d);
				num2 = 3;
				break;
			case 6:
			{
				for (int i = 0; i < array2.Length; i++)
				{
					if (i >= outBegIdx)
					{
						array3[i] = array[i - outBegIdx];
					}
				}
				num2 = 7;
				break;
			}
			case 3:
				array3 = new double[array2.Length];
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
			{
				array = new double[array2.Length];
				if (TicTacTec.TA.Library.Core.LinearReg(0, array2.Length - 1, array2, period, out outBegIdx, out var _, array) != TicTacTec.TA.Library.Core.RetCode.Success)
				{
					num2 = 8;
					break;
				}
				goto case 6;
			}
			case 1:
				array3[num3] = double.NaN;
				if (!double.IsNaN(array2[num3]))
				{
					goto default;
				}
				array2[num3] = 0.0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				{
					num3 = 0;
					goto IL_0152;
				}
				IL_0152:
				if (num3 >= array2.Length)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			}
		}
	}

	public void Ichimoku(int period1, int period2, int period3, int period4, int period5, out double[] tenkan, out double[] kijun, out double[] senkouA, out double[] senkouB, out double[] chikou)
	{
		int num = 7;
		int num2 = num;
		double[] close = default(double[]);
		double[] min3 = default(double[]);
		double[] max3 = default(double[]);
		double[] array = default(double[]);
		double[] array2 = default(double[]);
		double[] min2 = default(double[]);
		double[] max2 = default(double[]);
		int num3 = default(int);
		double[] max = default(double[]);
		double[] min = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 5:
				MinMax(close, period4, out min3, out max3);
				tenkan = new double[close.Length];
				kijun = new double[close.Length];
				array = new double[close.Length];
				array2 = new double[close.Length];
				num2 = 2;
				break;
			case 3:
				MinMax(close, period2, out min2, out max2);
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num2 = 5;
				}
				break;
			default:
				chikou = ShiftData(close, -period5);
				return;
			case 2:
				num3 = 0;
				num2 = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num2 = 8;
				}
				break;
			case 1:
				senkouA = ShiftData(array, period3);
				senkouB = ShiftData(array2, period3);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				tenkan[num3] = (max[num3] + min[num3]) / 2.0;
				kijun[num3] = (max2[num3] + min2[num3]) / 2.0;
				array[num3] = (tenkan[num3] + kijun[num3]) / 2.0;
				array2[num3] = (max3[num3] + min3[num3]) / 2.0;
				num3++;
				goto case 8;
			case 6:
				MinMax(close, period1, out min, out max);
				num2 = 3;
				break;
			case 8:
				if (num3 >= close.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 7:
				close = Close;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public double[] CumDelta()
	{
		double[] delta = Delta;
		double[] array = new double[delta.Length];
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				num2 = 0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb != 0)
				{
					num = 1;
				}
				continue;
			case 2:
				num2++;
				goto case 1;
			case 1:
				if (num2 >= delta.Length)
				{
					return array;
				}
				if (num2 == 0)
				{
					break;
				}
				array[num2] = array[num2 - 1] + delta[num2];
				goto case 2;
			}
			array[0] = delta[0];
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
			{
				num = 2;
			}
		}
	}

	public void KeltnerChannel(double[] d, IndicatorMaType type, int n, double factor, out double[] avg, out double[] upper, out double[] lower)
	{
		int num = 4;
		int num2 = num;
		double[] array = default(double[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 4:
				array = ATR(n);
				num2 = 3;
				continue;
			case 3:
				avg = MovingAverage(type, d, n);
				upper = new double[d.Length];
				lower = new double[d.Length];
				num3 = 0;
				goto IL_0030;
			case 2:
				return;
			case 1:
				{
					num3++;
					goto IL_0030;
				}
				IL_0030:
				if (num3 >= d.Length)
				{
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
					{
						num2 = 2;
					}
					continue;
				}
				upper[num3] = avg[num3] + factor * array[num3];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			lower[num3] = avg[num3] - factor * array[num3];
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
			{
				num2 = 1;
			}
		}
	}

	public void Envelopes(double[] d, IndicatorMaType type, int n, int k, out double[] avg, out double[] upper, out double[] lower)
	{
		int num = 4;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				upper[num3] = avg[num3] * (1.0 + (double)k / 1000.0);
				lower[num3] = avg[num3] * (1.0 - (double)k / 1000.0);
				num3++;
				goto IL_005a;
			case 1:
				lower = new double[d.Length];
				num3 = 0;
				goto IL_005a;
			case 3:
				upper = new double[d.Length];
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				{
					avg = MovingAverage(type, d, n);
					num2 = 3;
					break;
				}
				IL_005a:
				if (num3 >= d.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public void PriceChannel(int n, out double[] avg, out double[] upper, out double[] lower)
	{
		upper = Max(High, n);
		lower = Min(Low, n);
		int count = Count;
		avg = new double[count];
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b != 0)
		{
			num = 1;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 1:
				num2 = 0;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				return;
			}
			if (num2 >= count)
			{
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 1;
				}
				continue;
			}
			avg[num2] = (upper[num2] + lower[num2]) / 2.0;
			num2++;
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 == 0)
			{
				num = 0;
			}
		}
	}

	public double[] VolumeOscillator(IndicatorMaType type, int shortN, int longN)
	{
		int num = 4;
		int num2 = num;
		double[] array2 = default(double[]);
		int count = default(int);
		double[] array = default(double[]);
		double[] array3 = default(double[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				array2 = MovingAverage(type, Volume, shortN);
				count = Count;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return array;
			case 4:
				array3 = MovingAverage(type, Volume, longN);
				num2 = 3;
				break;
			case 1:
				array = new double[count];
				num3 = 0;
				goto IL_006a;
			case 2:
				{
					array[num3] = (array2[num3] - array3[num3]) / array3[num3] * 100.0;
					num3++;
					goto IL_006a;
				}
				IL_006a:
				if (num3 >= count)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public double[] BWMFI(IndicatorBWMFIType volumeType = IndicatorBWMFIType.Ticks)
	{
		int count = Count;
		double[] array = new double[count];
		double[] high = High;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
		{
			num = 0;
		}
		int num2 = default(int);
		double[] low = default(double[]);
		double[] array2 = default(double[]);
		double num3 = default(double);
		while (true)
		{
			double[] array3;
			switch (num)
			{
			case 1:
				array3 = Trades;
				break;
			case 5:
				return array;
			case 3:
				num2++;
				num = 4;
				continue;
			default:
				low = Low;
				if (volumeType != IndicatorBWMFIType.Real)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0b86e69c2a884980a2238f7088b49732 == 0)
					{
						num = 1;
					}
					continue;
				}
				array3 = Volume;
				break;
			case 2:
				num2 = 0;
				goto case 4;
			case 4:
				if (num2 < count)
				{
					array[num2] = (high[num2] - low[num2]) / array2[num2] * num3;
					num = 3;
				}
				else
				{
					num = 5;
				}
				continue;
			}
			array2 = array3;
			num3 = ((volumeType == IndicatorBWMFIType.Real) ? 1.0 : PM9KxIeO66Di4W4f5amL(10.0, CountDecimalPlaces(DnmriueORkWZIZAWjuTR(DataProvider))));
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
			{
				num = 0;
			}
		}
	}

	private static int CountDecimalPlaces(double step)
	{
		if (step < 1.0)
		{
			return ((byte[])XQg4PceOMqLA2vLNbmS4(decimal.GetBits((decimal)step)[3]))[2];
		}
		return (int)Math.Log10(step);
	}

	public double[] AO(IndicatorMaType type, int shortN, int longN)
	{
		int num = 1;
		int num2 = num;
		double[] d = default(double[]);
		while (true)
		{
			switch (num2)
			{
			default:
			{
				double[] d2 = MovingAverage(type, d, shortN);
				double[] d3 = MovingAverage(type, d, longN);
				return Subtraction(d2, d3);
			}
			case 1:
				d = Price(IndicatorPriceType.Median);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public double[] AC(IndicatorMaType type, int shortN, int longN)
	{
		double[] array = AO(type, shortN, longN);
		double[] d = MovingAverage(type, array, shortN);
		return Subtraction(array, d);
	}

	public double[] BearsPower(int n)
	{
		return Subtraction(Low, MovingAverage(IndicatorMaType.EMA, Close, n));
	}

	public double[] BullsPower(int n)
	{
		return Subtraction(High, MovingAverage(IndicatorMaType.EMA, Close, n));
	}

	public void Fractal(int n, out double[] up, out double[] down)
	{
		int count = Count;
		up = new double[count];
		int num = 7;
		int num2 = num;
		int num6 = default(int);
		int num4 = default(int);
		double[] high = default(double[]);
		double[] low = default(double[]);
		int num5 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 7:
				down = new double[count];
				num6 = 0;
				num2 = 14;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3086d3efc49e46839e3f8d95f5cafecb == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				num4 = n / 2;
				high = High;
				low = Low;
				num5 = 0;
				goto case 10;
			case 12:
				n++;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (flag)
				{
					up[num5 + num4] = high[num5 + num4];
					goto default;
				}
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (flag2)
				{
					down[num5 + num4] = low[num5 + num4];
					num2 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 6;
			case 4:
				down[num6] = double.NaN;
				num6++;
				num2 = 13;
				break;
			case 11:
				flag = true;
				flag2 = true;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				flag = false;
				num2 = 8;
				break;
			case 9:
				return;
			case 13:
			case 14:
				if (num6 < count)
				{
					up[num6] = double.NaN;
					num2 = 4;
					break;
				}
				if (n % 2 != 1)
				{
					num2 = 12;
					break;
				}
				goto case 2;
			case 6:
				num5++;
				num2 = 6;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
				{
					num2 = 10;
				}
				break;
			case 1:
				num3 = 0;
				goto IL_0226;
			case 8:
				if (low[num3 + num5] < low[num4 + num5])
				{
					flag2 = false;
				}
				goto IL_0107;
			case 10:
				{
					if (num5 >= count - n)
					{
						num2 = 9;
						break;
					}
					goto case 11;
				}
				IL_0226:
				if (num3 < n)
				{
					if (num3 == num4)
					{
						goto IL_0107;
					}
					if (high[num3 + num5] > high[num4 + num5])
					{
						num2 = 5;
						break;
					}
					goto case 8;
				}
				num2 = 3;
				break;
				IL_0107:
				num3++;
				goto IL_0226;
			}
		}
	}

	public double[] CMF(int n)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 0;
		int num5 = default(int);
		double[] array2 = default(double[]);
		int num4 = default(int);
		double num8 = default(double);
		int num3 = default(int);
		double num7 = default(double);
		double[] high = default(double[]);
		double[] low = default(double[]);
		double[] close = default(double[]);
		double[] volume = default(double[]);
		while (true)
		{
			int num2;
			if (num < count)
			{
				array[num] = double.NaN;
				num2 = 4;
			}
			else
			{
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
				{
					num2 = 10;
				}
			}
			while (true)
			{
				int num6;
				switch (num2)
				{
				case 8:
					if (num5 >= n)
					{
						num2 = 3;
						continue;
					}
					goto case 6;
				case 7:
					array2 = new double[count];
					num4 = 0;
					goto IL_01a9;
				case 1:
					num8 = 0.0;
					num2 = 2;
					continue;
				case 12:
					num3 = n;
					goto IL_0102;
				case 11:
					return array;
				case 9:
					num7 += array2[num3 - num5];
					goto IL_0090;
				case 3:
					array[num3] = num7 / num8;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					num5 = 0;
					goto case 8;
				case 10:
					if (count - 1 - n < 0)
					{
						return array;
					}
					high = High;
					low = Low;
					close = Close;
					volume = Volume;
					num2 = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 != 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					array2[num4] = volume[num4] * (close[num4] - low[num4] - (high[num4] - close[num4])) / (high[num4] - low[num4]);
					num4++;
					goto IL_01a9;
				case 5:
					num7 = 0.0;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					break;
				case 6:
					num8 += volume[num3 - num5];
					if (high[num3 - num5] - low[num3 - num5] > 0.0)
					{
						num2 = 9;
						continue;
					}
					goto IL_0090;
				default:
					{
						num3++;
						goto IL_0102;
					}
					IL_01a9:
					if (num4 >= count)
					{
						num2 = 8;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6dab837cad8c4ebe913fccce41c2f99a == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 13;
					IL_0090:
					num5++;
					num6 = 8;
					num2 = num6;
					continue;
					IL_0102:
					if (num3 >= count)
					{
						num2 = 11;
						continue;
					}
					goto case 5;
				}
				break;
			}
			num++;
		}
	}

	public double[] EFI(double[] d, IndicatorMaType type, int n)
	{
		int num = 3;
		double[] volume = default(double[]);
		int num4 = default(int);
		int num3 = default(int);
		double[] array = default(double[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					volume = Volume;
					num2 = 2;
					continue;
				case 1:
					num4++;
					goto IL_007b;
				case 2:
					break;
				case 4:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					{
						if (num3 >= d.Length)
						{
							num4 = 1;
							goto IL_007b;
						}
						array[num3] = double.NaN;
						num3++;
						num2 = 5;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					IL_007b:
					if (num4 >= d.Length)
					{
						return MovingAverage(type, array, n);
					}
					array[num4] = (d[num4] - d[num4 - 1]) * volume[num4];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			array = new double[d.Length];
			num = 4;
		}
	}

	public double[] ChaikinsVolatility(IndicatorMaType type, int n)
	{
		double[] array = MovingAverage(type, Subtraction(High, Low), n);
		int count = Count;
		double[] array2 = new double[count];
		int num = 3;
		int num2 = default(int);
		int i = default(int);
		while (true)
		{
			switch (num)
			{
			case 4:
				if (num2 < count)
				{
					array2[num2] = (array[num2] - array[num2 - n]) / array[num2 - n] * 100.0;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num = 1;
					}
					break;
				}
				return array2;
			default:
				num2 = n;
				goto case 4;
			case 3:
			{
				i = 0;
				int num3 = 2;
				num = num3;
				break;
			}
			case 2:
				for (; i < count; i++)
				{
					array2[i] = double.NaN;
				}
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				num2++;
				num = 4;
				break;
			}
		}
	}

	public double[] WilliamsAD()
	{
		double[] high = High;
		double[] low = Low;
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2578ed133ed94d7cbc9cc23542d314a1 == 0)
		{
			num = 1;
		}
		double[] close = default(double[]);
		int count = default(int);
		double[] array = default(double[]);
		int num2 = default(int);
		double num3 = default(double);
		while (true)
		{
			switch (num)
			{
			case 3:
				close = Close;
				count = Count;
				array = new double[count];
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
				{
					num = 6;
				}
				break;
			case 5:
				return array;
			default:
				if (num2 >= count)
				{
					num = 5;
					break;
				}
				num3 = 0.0;
				if (!(close[num2] > close[num2 - 1]))
				{
					if (close[num2] < close[num2 - 1])
					{
						num3 = close[num2] - Math.Max(close[num2 - 1], high[num2]);
						num = 4;
						break;
					}
				}
				else
				{
					num3 = close[num2] - ma5RSJeOOWxTB2SNObcE(close[num2 - 1], low[num2]);
				}
				goto case 4;
			case 1:
				num2++;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
				{
					num = 0;
				}
				break;
			case 4:
				array[num2] = array[num2 - 1] + num3;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
				{
					num = 1;
				}
				break;
			case 6:
				num2 = 1;
				num = 2;
				break;
			}
		}
	}

	public double[] VHF(int n)
	{
		int num = 6;
		int num2 = num;
		int num4 = default(int);
		int count = default(int);
		double[] array3 = default(double[]);
		double[] array = default(double[]);
		double[] close = default(double[]);
		double[] array2 = default(double[]);
		int num5 = default(int);
		int num3 = default(int);
		double[] min = default(double[]);
		double[] max = default(double[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (num4 >= count)
				{
					array3 = Sum(array, n);
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					array[num4] = Math.Abs(close[num4] - close[num4 - 1]);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 5:
				count = Count;
				array2 = new double[count];
				array = new double[count];
				num5 = 0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				num3 = n;
				goto IL_0051;
			case 9:
				array2[num5] = double.NaN;
				num2 = 3;
				break;
			case 6:
				MinMax(Close, n, out min, out max);
				num2 = 5;
				break;
			case 1:
			case 2:
				if (num5 >= count)
				{
					close = Close;
					num4 = 1;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 3:
				array[num5] = double.NaN;
				num5++;
				num2 = 2;
				break;
			default:
				num4++;
				goto case 4;
			case 8:
				{
					num3++;
					goto IL_0051;
				}
				IL_0051:
				if (num3 >= count)
				{
					return array2;
				}
				array2[num3] = (max[num3] - min[num3]) / array3[num3];
				num2 = 8;
				break;
			}
		}
	}

	public double[] ZIGZAG(int depth, int deviation, int backstep, bool reg = true)
	{
		int count = Count;
		double[] array = new double[count];
		int num = 32;
		int num16 = default(int);
		int num14 = default(int);
		double[] array2 = default(double[]);
		int num20 = default(int);
		double[] low = default(double[]);
		double[] array3 = default(double[]);
		double[] high = default(double[]);
		int num12 = default(int);
		double num15 = default(double);
		double num10 = default(double);
		double num4 = default(double);
		double[] array5 = default(double[]);
		int num18 = default(int);
		int num19 = default(int);
		double[] array4 = default(double[]);
		double num9 = default(double);
		double num3 = default(double);
		int num7 = default(int);
		int num13 = default(int);
		int num21 = default(int);
		double num11 = default(double);
		double num5 = default(double);
		double num6 = default(double);
		int num17 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 28:
					num16 = -1;
					num14 = depth;
					num2 = 14;
					continue;
				case 45:
					array2[num14] = 0.0;
					num2 = 42;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
					{
						num2 = 21;
					}
					continue;
				case 49:
					if (num20 >= low.Length)
					{
						num2 = 12;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3ef08b277e78467b833a3119d7297528 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					if (array3[num20] != 0.0)
					{
						num2 = 7;
						continue;
					}
					if (array2[num20] != 0.0)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 5;
				case 47:
					high = High;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num2 = 11;
					}
					continue;
				case 50:
					if (num12 <= backstep)
					{
						goto case 48;
					}
					goto case 39;
				case 14:
					if (num14 < low.Length)
					{
						num15 = array2[num14];
						num10 = array3[num14];
						num2 = 44;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
						{
							num2 = 34;
						}
					}
					else
					{
						num20 = 0;
						num2 = 49;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
						{
							num2 = 28;
						}
					}
					continue;
				case 4:
					num4 = 0.0;
					num2 = 39;
					continue;
				case 5:
					num20++;
					goto case 49;
				case 11:
					array5 = Min(Low, depth);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					array[num20] = array3[num20];
					num2 = 5;
					continue;
				case 17:
					if (!reg)
					{
						num2 = 12;
						continue;
					}
					num18 = -1;
					num19 = 0;
					goto IL_08a8;
				case 3:
					array4 = Max(High, depth);
					array3 = new double[count];
					array2 = new double[count];
					num9 = 0.0;
					num3 = 0.0;
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
					{
						num2 = 13;
					}
					continue;
				case 34:
					if (num15 == 0.0)
					{
						goto case 18;
					}
					if (num3 > 0.0)
					{
						if (!(num3 > num15))
						{
							goto case 45;
						}
						array2[num16] = 0.0;
					}
					goto case 42;
				case 30:
					if (num7 >= low.Length)
					{
						num9 = -1.0;
						num3 = -1.0;
						num13 = -1;
						num2 = 28;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 36;
				case 44:
					if (num15 == 0.0)
					{
						num2 = 6;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 16;
				case 1:
					if (num18 >= 0)
					{
						num2 = 46;
						continue;
					}
					goto IL_011b;
				case 32:
					num21 = 0;
					goto IL_01b6;
				case 2:
					num21++;
					goto IL_01b6;
				case 6:
					if (num10 != 0.0)
					{
						num2 = 16;
						continue;
					}
					goto case 18;
				case 18:
					num14++;
					goto case 14;
				case 9:
					num12 = 1;
					num2 = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_39ef76bd8f0947d084200e4afe419409 == 0)
					{
						num2 = 50;
					}
					continue;
				case 26:
					array[num20] = array2[num20];
					goto case 5;
				case 8:
					if (num9 < 0.0)
					{
						goto IL_05ba;
					}
					goto case 37;
				case 48:
					num11 = array3[num7 - num12];
					if (num11 != 0.0)
					{
						num2 = 24;
						continue;
					}
					goto case 10;
				case 19:
					if (num5 != 0.0)
					{
						num2 = 23;
						continue;
					}
					goto IL_03ee;
				case 31:
				case 41:
					if (!(num9 < num10))
					{
						num2 = 8;
						continue;
					}
					goto IL_05ba;
				case 29:
					if (depth < backstep)
					{
						goto IL_06b2;
					}
					goto case 21;
				default:
					if (num4 == num9)
					{
						num2 = 4;
						continue;
					}
					num9 = num4;
					if (!(num4 - high[num7] > (double)deviation * DnmriueORkWZIZAWjuTR(DataProvider)))
					{
						goto case 9;
					}
					num4 = 0.0;
					goto case 39;
				case 13:
					num7 = 0;
					num2 = 23;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
					{
						num2 = 30;
					}
					continue;
				case 21:
					num6 = array5[num7];
					num2 = 43;
					continue;
				case 38:
					num6 = 0.0;
					num2 = 15;
					continue;
				case 10:
					num12++;
					goto case 50;
				case 46:
					num17 = num18 + 1;
					goto IL_097b;
				case 33:
					num17++;
					goto IL_097b;
				case 20:
					num7++;
					goto case 30;
				case 40:
					if (depth > 0)
					{
						num2 = 51;
						continue;
					}
					goto IL_033c;
				case 43:
					if (num6 != num3)
					{
						num3 = num6;
						if (!(low[num7] - num6 > (double)deviation * DataProvider.Step))
						{
							num8 = 1;
							goto case 25;
						}
						num2 = 38;
						continue;
					}
					num6 = 0.0;
					break;
				case 25:
					if (num8 > backstep)
					{
						break;
					}
					num5 = array2[num7 - num8];
					num2 = 19;
					continue;
				case 42:
					if (!(num15 < num3))
					{
						num2 = 35;
						continue;
					}
					goto IL_05c3;
				case 24:
					if (num11 < num4)
					{
						array3[num7 - num12] = 0.0;
						num2 = 10;
						continue;
					}
					goto case 10;
				case 23:
					if (num5 > num6)
					{
						array2[num7 - num8] = 0.0;
					}
					goto IL_03ee;
				case 22:
					array[num21] = double.NaN;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num2 = 2;
					}
					continue;
				case 51:
					if (count >= depth)
					{
						low = Low;
						num2 = 47;
						continue;
					}
					goto IL_033c;
				case 35:
					if (!(num3 < 0.0))
					{
						goto end_IL_0009;
					}
					goto IL_05c3;
				case 37:
					num3 = -1.0;
					num2 = 34;
					continue;
				case 27:
					array[num17] = (array[num19] - array[num18]) / (double)(num19 - num18) * (double)(num17 - num18) + array[num18];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num2 = 33;
					}
					continue;
				case 36:
					if (num7 >= depth)
					{
						num2 = 29;
						continue;
					}
					goto IL_06b2;
				case 16:
					if (num10 == 0.0)
					{
						goto case 34;
					}
					if (num9 > 0.0)
					{
						if (num9 < num10)
						{
							array3[num13] = 0.0;
							num2 = 41;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
							{
								num2 = 3;
							}
						}
						else
						{
							array3[num14] = 0.0;
							num2 = 31;
						}
						continue;
					}
					goto case 31;
				case 12:
					return array;
				case 15:
					break;
				case 39:
					{
						array3[num7] = ((high[num7] == num4) ? num4 : 0.0);
						goto case 20;
					}
					IL_05ba:
					num9 = num10;
					num13 = num14;
					num2 = 37;
					continue;
					IL_06b2:
					array2[num7] = 0.0;
					array3[num7] = 0.0;
					num2 = 20;
					continue;
					IL_033c:
					return array;
					IL_097b:
					if (num17 >= num19)
					{
						goto IL_011b;
					}
					goto case 27;
					IL_05c3:
					num3 = num15;
					num16 = num14;
					goto end_IL_0009;
					IL_03ee:
					num8++;
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
					{
						num2 = 25;
					}
					continue;
					IL_08a8:
					if (num19 < array.Length)
					{
						if (!double.IsNaN(array[num19]))
						{
							num2 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_578c88adb68d4c08b45439ab0955bb9b == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto IL_089d;
					}
					return array;
					IL_01b6:
					if (num21 >= count)
					{
						num2 = 40;
						continue;
					}
					goto case 22;
					IL_011b:
					num18 = num19;
					goto IL_089d;
					IL_089d:
					num19++;
					goto IL_08a8;
				}
				array2[num7] = ((low[num7] == num6) ? num6 : 0.0);
				num4 = array4[num7];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0009:
				break;
			}
			num9 = -1.0;
			num = 18;
		}
	}

	public IndicatorsHelper()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static IndicatorsHelper()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		gVSciseOqDxQhnW4jSc4();
	}

	internal static bool PVTfyfeOxwel6OEe9yZ5()
	{
		return EsmcTceOSspOU8918K7C == null;
	}

	internal static IndicatorsHelper AIInBreOLSsTa62oXmkH()
	{
		return EsmcTceOSspOU8918K7C;
	}

	internal static object RSXrKdeOe3pxLdZCQpiK(object P_0, object P_1)
	{
		return ((IChartDataProvider)P_0)[(string)P_1];
	}

	internal static object n2VEhHeOsde6eEQfNdsU(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool ldB66OeOXEUBNkqICWju(double P_0)
	{
		return double.IsNaN(P_0);
	}

	internal static object aG9sJYeOcqYe7oqOsjPr(object P_0)
	{
		return ((Array)P_0).Clone();
	}

	internal static decimal xRfTVEeOjmRrb6eBCiTs(object P_0)
	{
		return ((IChartSymbol)P_0).StepPrice;
	}

	internal static double ztWkbPeOEtpK1GEYpZDC(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object kEBaBIeOQmiGFK8T3pJG(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static double fZZypueOdLpGyoLbTwdw(double P_0)
	{
		return Math.Sqrt(P_0);
	}

	internal static bool Q1DZh4eOg8EaMTj4Lb11(object P_0)
	{
		return ((IChartSymbol)P_0).IsDenomination;
	}

	internal static double DnmriueORkWZIZAWjuTR(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static double PM9KxIeO66Di4W4f5amL(double P_0, double P_1)
	{
		return Math.Pow(P_0, P_1);
	}

	internal static object XQg4PceOMqLA2vLNbmS4(int P_0)
	{
		return BitConverter.GetBytes(P_0);
	}

	internal static double ma5RSJeOOWxTB2SNObcE(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static void gVSciseOqDxQhnW4jSc4()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
