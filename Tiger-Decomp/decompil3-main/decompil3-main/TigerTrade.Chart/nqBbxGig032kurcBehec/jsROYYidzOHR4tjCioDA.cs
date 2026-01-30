using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Dx;

namespace nqBbxGig032kurcBehec;

[Indicator("WeisWaveVolume", "WeisWaveVolume", false, Type = typeof(jsROYYidzOHR4tjCioDA))]
[DataContract(Name = "WeisWaveVolumeIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class jsROYYidzOHR4tjCioDA : IndicatorBase
{
	private class vKN7MTimIIhE17mCaOFT
	{
		public int fNyimWqeNFt;

		public double Volume;

		private static vKN7MTimIIhE17mCaOFT bveijYeT9nN0sE3xLPVC;

		public vKN7MTimIIhE17mCaOFT()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			base._002Ector();
		}

		static vKN7MTimIIhE17mCaOFT()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool tbOJMZeTn29q9hDULJFN()
		{
			return bveijYeT9nN0sE3xLPVC == null;
		}

		internal static vKN7MTimIIhE17mCaOFT QO0NdFeTGDxoSGlVBopg()
		{
			return bveijYeT9nN0sE3xLPVC;
		}
	}

	private int Ifgigvdxw3C;

	private XBrush hHXigBxyW3k;

	private XPen QguigaKxmha;

	private XColor VX1igi8R5aW;

	private XBrush LcsiglqKgKf;

	private XPen NCrig4YGBZJ;

	private XColor iAxigDeJLI3;

	private XBrush h55igboQspo;

	private XPen ieaigN8Dv6j;

	private XColor Yt5igkk2qRP;

	private List<vKN7MTimIIhE17mCaOFT> Ixiig1FElyn;

	private static jsROYYidzOHR4tjCioDA jvnlJ4eeugW3IW5ptrN1;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.None;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	public int Period
	{
		get
		{
			return Ifgigvdxw3C;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == Ifgigvdxw3C)
			{
				return;
			}
			Ifgigvdxw3C = num;
			int num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60820051));
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799539541));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsWeisWaveUpVolumeColor")]
	[DataMember(Name = "UpColor")]
	public XColor UpColor
	{
		get
		{
			return VX1igi8R5aW;
		}
		set
		{
			if (xColor == VX1igi8R5aW)
			{
				return;
			}
			VX1igi8R5aW = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					hHXigBxyW3k = new XBrush(VX1igi8R5aW);
					QguigaKxmha = new XPen(hHXigBxyW3k, 1);
					OnPropertyChanged((string)CMOSMyes2qZAn9i1ftcX(0x24085900 ^ 0x2408CD74));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsWeisWaveDownVolumeColor")]
	[DataMember(Name = "DownColor")]
	public XColor DownColor
	{
		get
		{
			return iAxigDeJLI3;
		}
		set
		{
			if (xColor == iAxigDeJLI3)
			{
				return;
			}
			iAxigDeJLI3 = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					NCrig4YGBZJ = new XPen(LcsiglqKgKf, 1);
					OnPropertyChanged((string)CMOSMyes2qZAn9i1ftcX(0x28B345BB ^ 0x28B3D13D));
					return;
				}
				LcsiglqKgKf = new XBrush(iAxigDeJLI3);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsWeisWaveTempVolumeColor")]
	[DataMember(Name = "TempColor")]
	public XColor TempColor
	{
		get
		{
			return Yt5igkk2qRP;
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
				case 0:
					return;
				case 2:
					h55igboQspo = new XBrush(Yt5igkk2qRP);
					ieaigN8Dv6j = new XPen(h55igboQspo, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x741B85CB ^ 0x741B24CF));
					return;
				case 1:
					if (!(xColor == Yt5igkk2qRP))
					{
						Yt5igkk2qRP = xColor;
						num2 = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}
	}

	public jsROYYidzOHR4tjCioDA()
	{
		qBZUOoesHQbqE9um023x();
		base._002Ector();
		Period = 3;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				TempColor = Colors.Orange;
				return;
			}
			UpColor = Colors.Green;
			DownColor = DbBBYMesfERX6GgodDMA();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
			{
				num = 0;
			}
		}
	}

	protected override void Execute()
	{
		int num;
		if (base.ClearData)
		{
			Ixiig1FElyn = null;
			num = 43;
			goto IL_0009;
		}
		goto IL_033e;
		IL_033e:
		IChartDataProvider dataProvider = base.DataProvider;
		num = 9;
		goto IL_0009;
		IL_0009:
		double num15 = default(double);
		int num11 = default(int);
		double[] close = default(double[]);
		double[] array = default(double[]);
		double[] array3 = default(double[]);
		double[] array2 = default(double[]);
		int num9 = default(int);
		double num16 = default(double);
		int num5 = default(int);
		int num3 = default(int);
		double[] volume = default(double[]);
		int num10 = default(int);
		double num12 = default(double);
		double num6 = default(double);
		int num14 = default(int);
		int num2 = default(int);
		double num7 = default(double);
		int num13 = default(int);
		int num8 = default(int);
		while (true)
		{
			int num4;
			switch (num)
			{
			case 2:
				num15 = 0.0;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 == 0)
				{
					num = 0;
				}
				continue;
			case 47:
			case 50:
				if (num11 >= dataProvider.Count)
				{
					close = base.Helper.Close;
					num = 18;
					continue;
				}
				goto case 38;
			case 46:
				array = new double[F1eWRwes9ZdlWwObcjHs(dataProvider)];
				array3 = new double[dataProvider.Count];
				array2 = new double[F1eWRwes9ZdlWwObcjHs(dataProvider)];
				num9 = 0;
				num16 = 0.0;
				num5 = 0;
				goto IL_03a4;
			case 44:
				array[num3] = 1.0;
				goto IL_0113;
			case 18:
				volume = base.Helper.Volume;
				num = 11;
				continue;
			case 49:
				Ixiig1FElyn = new List<vKN7MTimIIhE17mCaOFT>(F1eWRwes9ZdlWwObcjHs(dataProvider));
				num11 = 0;
				num = 50;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
				{
					num = 16;
				}
				continue;
			default:
				num10 = 0;
				num = 35;
				continue;
			case 24:
				Ixiig1FElyn[num3].fNyimWqeNFt = -1;
				goto IL_01cf;
			case 34:
				num12 = 0.0;
				if (array2[num3 - 1] == 1.0)
				{
					num12 = num6;
				}
				if (array2[num3 - 1] == -1.0)
				{
					num = 17;
					continue;
				}
				goto case 10;
			case 39:
				array3[num5] = double.NaN;
				array2[num5] = double.NaN;
				num = 13;
				continue;
			case 5:
			case 26:
				if (array[num3] != 0.0 && array[num3] != array[num3 - 1])
				{
					array3[num3] = array[num3];
					num = 34;
					continue;
				}
				goto case 36;
			case 23:
				num14 = num3;
				num = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 3;
				}
				continue;
			case 20:
				num15 = 0.0;
				num = 6;
				continue;
			case 42:
				if (close[num3] < close[num3 - 1])
				{
					array[num3] = -1.0;
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
					{
						num = 2;
					}
					continue;
				}
				goto case 3;
			case 25:
				num2 = num3;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
				{
					num = 26;
				}
				continue;
			case 43:
				break;
			case 32:
				num7 = close[num3];
				num = 48;
				continue;
			case 48:
				num14 = num3;
				num13 = num2;
				goto case 12;
			case 22:
				if (num9 == 0)
				{
					num = 31;
					continue;
				}
				goto case 16;
			case 12:
				num16 = 0.0;
				num8 = num13 + 1;
				goto IL_07ea;
			case 16:
			case 19:
			case 27:
				if (array2[num3] != array2[num3 - 1])
				{
					if (array2[num3] == 1.0)
					{
						num6 = close[num3];
						num2 = num3;
						num = 33;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
						{
							num = 10;
						}
						continue;
					}
					goto case 32;
				}
				goto case 28;
			case 6:
				num10++;
				goto case 35;
			case 45:
				num14 = 0;
				num = 46;
				continue;
			case 35:
				if (num10 >= dataProvider.Count)
				{
					return;
				}
				if (num9 != 0)
				{
					num = 7;
					continue;
				}
				goto IL_081e;
			case 10:
				if (array3[num3] != array2[num3 - 1])
				{
					if (lg21hgesn66ADpo65uE1(num12 - close[num3]) >= (double)Period * lB5dJIesGZOgZFMnxJki(base.DataProvider))
					{
						array2[num3] = array3[num3];
						num9 = 0;
						num = 27;
						continue;
					}
					goto case 37;
				}
				array2[num3] = array2[num3 - 1];
				num9 = 0;
				num4 = 19;
				goto IL_0005;
			case 36:
				array3[num3] = array3[num3 - 1];
				goto case 34;
			case 33:
				num13 = num14;
				num = 12;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
				{
					num = 7;
				}
				continue;
			case 4:
				num7 = close[0];
				num = 40;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
				{
					num = 38;
				}
				continue;
			case 8:
				array2[num3 - 1] = array[num3];
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 1;
				}
				continue;
			case 21:
				if (close[num3] > close[num3 - 1])
				{
					num = 44;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
					{
						num = 8;
					}
					continue;
				}
				goto IL_0113;
			case 1:
				if (close[num3] > num6)
				{
					num6 = close[num3];
					num = 25;
					continue;
				}
				if (close[num3] < num7)
				{
					num7 = close[num3];
					num = 23;
					continue;
				}
				goto case 5;
			case 31:
				num9 = num3;
				num = 16;
				continue;
			case 3:
				if (double.IsNaN(array[num3 - 1]))
				{
					array[num3 - 1] = array[num3];
				}
				if (double.IsNaN(array3[num3 - 1]))
				{
					array3[num3 - 1] = array[num3];
				}
				if (double.IsNaN(array2[num3 - 1]))
				{
					num4 = 8;
					goto IL_0005;
				}
				goto case 1;
			case 29:
				if (num3 >= dataProvider.Count - 1)
				{
					num4 = 2;
					goto IL_0005;
				}
				goto case 21;
			case 28:
				num16 += volume[num3];
				goto IL_09f2;
			case 17:
				num12 = num7;
				num = 10;
				continue;
			case 41:
				Ixiig1FElyn[num3].fNyimWqeNFt = 1;
				goto IL_044f;
			case 30:
				array[num3] = 0.0;
				num = 42;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f == 0)
				{
					num = 12;
				}
				continue;
			case 38:
				Ixiig1FElyn.Add(new vKN7MTimIIhE17mCaOFT());
				num11++;
				num = 38;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
				{
					num = 47;
				}
				continue;
			case 37:
				array2[num3] = array2[num3 - 1];
				num = 22;
				continue;
			case 11:
				num6 = close[0];
				num = 4;
				continue;
			case 7:
				if (num9 <= num10)
				{
					goto IL_07db;
				}
				goto IL_081e;
			case 15:
				Ixiig1FElyn[num8].fNyimWqeNFt = -1;
				goto IL_0775;
			case 9:
				if (dataProvider.Count == 0)
				{
					return;
				}
				num = 49;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
				{
					num = 34;
				}
				continue;
			case 13:
				num5++;
				goto IL_03a4;
			case 14:
				array[num5] = double.NaN;
				num = 39;
				continue;
			case 40:
				{
					num2 = 0;
					num = 45;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f11cc1d6b7f3456db092304ccadade75 != 0)
					{
						num = 44;
					}
					continue;
				}
				IL_081e:
				if (num10 != dataProvider.Count - 1)
				{
					goto case 20;
				}
				goto IL_07db;
				IL_07db:
				num15 += volume[num10];
				Ixiig1FElyn[num10].Volume = num15;
				Ixiig1FElyn[num10].fNyimWqeNFt = 0;
				goto case 6;
				IL_0113:
				if (close[num3] == close[num3 - 1])
				{
					num = 30;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f77fe62e8d47b39673b4a8ce5cbdc5 == 0)
					{
						num = 3;
					}
					continue;
				}
				goto case 42;
				IL_07ea:
				if (num8 <= num3)
				{
					num16 += volume[num8];
					if (array2[num3] == 1.0)
					{
						Ixiig1FElyn[num8].Volume = num16;
						Ixiig1FElyn[num8].fNyimWqeNFt = 1;
					}
					if (array2[num3] == -1.0)
					{
						Ixiig1FElyn[num8].Volume = num16;
						num = 15;
						continue;
					}
					goto IL_0775;
				}
				goto IL_09f2;
				IL_09f2:
				if (array2[num3] == 1.0)
				{
					Ixiig1FElyn[num3].Volume = num16;
					num4 = 41;
					goto IL_0005;
				}
				goto IL_044f;
				IL_03a4:
				if (num5 >= F1eWRwes9ZdlWwObcjHs(dataProvider))
				{
					num3 = 1;
					num = 25;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
					{
						num = 29;
					}
					continue;
				}
				goto case 14;
				IL_044f:
				if (array2[num3] == -1.0)
				{
					Ixiig1FElyn[num3].Volume = num16;
					num = 9;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8a171556332640fb8bbbc9cecf94e253 == 0)
					{
						num = 24;
					}
					continue;
				}
				goto IL_01cf;
				IL_0005:
				num = num4;
				continue;
				IL_0775:
				num8++;
				goto IL_07ea;
				IL_01cf:
				num3++;
				goto case 29;
			}
			break;
		}
		goto IL_033e;
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		P_0 = double.MaxValue;
		P_1 = double.MinValue;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
		{
			num = 1;
		}
		int num3 = default(int);
		vKN7MTimIIhE17mCaOFT vKN7MTimIIhE17mCaOFT = default(vKN7MTimIIhE17mCaOFT);
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (num3 < Ixiig1FElyn.Count)
				{
					vKN7MTimIIhE17mCaOFT = Ixiig1FElyn[num3];
					P_0 = AIwei0eso9WWxP0wAP3V(P_0, vKN7MTimIIhE17mCaOFT.Volume);
					num = 3;
					continue;
				}
				goto default;
			case 1:
				num2 = 0;
				break;
			case 3:
				P_1 = Math.Max(P_1, vKN7MTimIIhE17mCaOFT.Volume);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
				{
					num = 0;
				}
				continue;
			default:
				num2++;
				break;
			}
			if (num2 < base.Canvas.Count)
			{
				num3 = b1tKDbesYSC1LHPhLeWj(base.Canvas, num2);
				num = 2;
				continue;
			}
			break;
		}
		return true;
	}

	public override void Render(DxVisualQueue P_0)
	{
		if (Ixiig1FElyn == null)
		{
			return;
		}
		int num = default(int);
		double num2 = default(double);
		int num3;
		if (Ixiig1FElyn.Count != 0)
		{
			num = (int)GetY(0.0);
			num2 = Math.Max(base.Canvas.ColumnWidth - 1.0, 1.0);
			num3 = 9;
		}
		else
		{
			num3 = 3;
		}
		XBrush lcsiglqKgKf = default(XBrush);
		double x = default(double);
		double num5 = default(double);
		int num4 = default(int);
		vKN7MTimIIhE17mCaOFT vKN7MTimIIhE17mCaOFT = default(vKN7MTimIIhE17mCaOFT);
		int num6 = default(int);
		while (true)
		{
			int index;
			switch (num3)
			{
			default:
				return;
			case 6:
				lcsiglqKgKf = LcsiglqKgKf;
				goto IL_00ae;
			case 0:
				return;
			case 8:
			{
				Rect rect = new Rect(x - num2 / 2.0, num5, num2, num4);
				P_0.FillRectangle(lcsiglqKgKf, rect);
				goto IL_00dc;
			}
			case 2:
				if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt > 0)
				{
					num3 = 7;
					continue;
				}
				if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt < 0)
				{
					num3 = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
					{
						num3 = 5;
					}
					continue;
				}
				goto IL_00ae;
			case 3:
				return;
			case 4:
				num4 = -num4;
				num3 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
				{
					num3 = 5;
				}
				continue;
			case 1:
				lcsiglqKgKf = h55igboQspo;
				num3 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e == 0)
				{
					num3 = 2;
				}
				continue;
			case 11:
				P_0.DrawLine(new XPen(lcsiglqKgKf, 1), x, num5, x, num5 + (double)num4);
				goto IL_00dc;
			case 7:
				lcsiglqKgKf = hHXigBxyW3k;
				goto IL_00ae;
			case 9:
				num6 = 0;
				goto IL_0072;
			case 10:
				if ((double)num4 < 0.0)
				{
					num5 += (double)num4;
					num3 = 4;
					continue;
				}
				break;
			case 5:
				break;
				IL_00dc:
				num6++;
				goto IL_0072;
				IL_00ae:
				if (num2 > 1.0)
				{
					num3 = 8;
					continue;
				}
				goto case 11;
				IL_0072:
				if (num6 >= rRtVh8esv7TKDeUFMgdP(base.Canvas))
				{
					num3 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 != 0)
					{
						num3 = 0;
					}
					continue;
				}
				index = base.Canvas.GetIndex(num6);
				if (index < Ixiig1FElyn.Count)
				{
					vKN7MTimIIhE17mCaOFT = Ixiig1FElyn[index];
					x = base.Canvas.GetX(index);
					num5 = GetY(vKN7MTimIIhE17mCaOFT.Volume);
					num4 = num - (int)num5;
					num3 = 10;
					continue;
				}
				goto IL_00dc;
			}
			num4 = Math.Max(1, num4);
			num3 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
			{
				num3 = 1;
			}
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		if (Ixiig1FElyn == null || Ixiig1FElyn.Count == 0 || cursorPos < 0 || Ixiig1FElyn.Count < cursorPos)
		{
			return list;
		}
		vKN7MTimIIhE17mCaOFT vKN7MTimIIhE17mCaOFT = Ixiig1FElyn[cursorPos];
		string value = base.Canvas.FormatValue(vKN7MTimIIhE17mCaOFT.Volume);
		XBrush lcsiglqKgKf = h55igboQspo;
		if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt > 0)
		{
			lcsiglqKgKf = hHXigBxyW3k;
		}
		else if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt < 0)
		{
			lcsiglqKgKf = LcsiglqKgKf;
		}
		list.Add(new IndicatorValueInfo(value, lcsiglqKgKf));
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (F1eWRwes9ZdlWwObcjHs(base.DataProvider) <= P3bp7gesBB1Bv4ZkXZU0(base.Canvas))
		{
			return;
		}
		int num = base.DataProvider.Count - 1 - base.Canvas.Start;
		int num2 = 2;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 == 0)
		{
			num2 = 1;
		}
		XColor color = default(XColor);
		vKN7MTimIIhE17mCaOFT vKN7MTimIIhE17mCaOFT = default(vKN7MTimIIhE17mCaOFT);
		while (true)
		{
			switch (num2)
			{
			default:
				color = TempColor;
				if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt > 0)
				{
					color = UpColor;
					goto IL_0041;
				}
				goto case 1;
			case 3:
				if (Ixiig1FElyn.Count == 0 || Ixiig1FElyn.Count < num)
				{
					return;
				}
				vKN7MTimIIhE17mCaOFT = Ixiig1FElyn[num];
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 1:
				if (vKN7MTimIIhE17mCaOFT.fNyimWqeNFt < 0)
				{
					color = DownColor;
				}
				goto IL_0041;
			case 2:
				{
					if (Ixiig1FElyn == null)
					{
						return;
					}
					num2 = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c == 0)
					{
						num2 = 2;
					}
					break;
				}
				IL_0041:
				P_0.Add(new IndicatorLabelInfo(vKN7MTimIIhE17mCaOFT.Volume, color));
				num2 = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		UpColor = L83HUXesa5LfhPuMmNab(P_0);
		DownColor = P_0.PaletteColor7;
		TempColor = upFCDPeslqoMXouLyTHR(rQUnyyesi5eyDxCS8s4B());
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		jsROYYidzOHR4tjCioDA jsROYYidzOHR4tjCioDA2 = (jsROYYidzOHR4tjCioDA)P_0;
		Period = jsROYYidzOHR4tjCioDA2.Period;
		UpColor = EEwin6es4Mup0Psp4Qp1(jsROYYidzOHR4tjCioDA2);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				DownColor = jsROYYidzOHR4tjCioDA2.DownColor;
				TempColor = NcZJowesDv8t6S6bjE0b(jsROYYidzOHR4tjCioDA2);
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583312202), base.Name, Period);
	}

	static jsROYYidzOHR4tjCioDA()
	{
		EGIDWResbZPFKftDPBnc();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool SEXU0oeezpRgqJTJQpUr()
	{
		return jvnlJ4eeugW3IW5ptrN1 == null;
	}

	internal static jsROYYidzOHR4tjCioDA yRxfates09yMd0wbUbIP()
	{
		return jvnlJ4eeugW3IW5ptrN1;
	}

	internal static object CMOSMyes2qZAn9i1ftcX(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void qBZUOoesHQbqE9um023x()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static Color DbBBYMesfERX6GgodDMA()
	{
		return Colors.Red;
	}

	internal static int F1eWRwes9ZdlWwObcjHs(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static double lg21hgesn66ADpo65uE1(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double lB5dJIesGZOgZFMnxJki(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static int b1tKDbesYSC1LHPhLeWj(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static double AIwei0eso9WWxP0wAP3V(double P_0, double P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static int rRtVh8esv7TKDeUFMgdP(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static int P3bp7gesBB1Bv4ZkXZU0(object P_0)
	{
		return ((IChartCanvas)P_0).Start;
	}

	internal static XColor L83HUXesa5LfhPuMmNab(object P_0)
	{
		return ((IChartTheme)P_0).PaletteColor6;
	}

	internal static Color rQUnyyesi5eyDxCS8s4B()
	{
		return Colors.Orange;
	}

	internal static XColor upFCDPeslqoMXouLyTHR(Color P_0)
	{
		return P_0;
	}

	internal static XColor EEwin6es4Mup0Psp4Qp1(object P_0)
	{
		return ((jsROYYidzOHR4tjCioDA)P_0).UpColor;
	}

	internal static XColor NcZJowesDv8t6S6bjE0b(object P_0)
	{
		return ((jsROYYidzOHR4tjCioDA)P_0).TempColor;
	}

	internal static void EGIDWResbZPFKftDPBnc()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}
}
