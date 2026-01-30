using System;
using System.Collections;
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
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;

namespace mTtuvEiqb7Xwv9KWoQ2x;

[Indicator("BWMFI", "BWMFI", false, Type = typeof(yu3tXdiqDgpkAS9bjrYe))]
[DataContract(Name = "BWMFIIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class yu3tXdiqDgpkAS9bjrYe : IndicatorBase
{
	private XBrush EjpiqEAUWKk;

	private XPen de3iqQ1EUNs;

	private XColor GcLiqdsNoiI;

	private XBrush WbDiqg1finB;

	private XPen UCdiqRN19m4;

	private XColor QMViq6Au0g6;

	private XBrush boxiqMeNE6n;

	private XPen gTciqOecFjk;

	private XColor AvfiqqnDQdq;

	private XBrush T3DiqIdyZMg;

	private XPen fwmiqWJEQso;

	private XColor beqiqtv5K7W;

	private IndicatorBWMFIType cMViqU8FPuQ;

	private static yu3tXdiqDgpkAS9bjrYe SaSYjCecPGi7r6y1H357;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "MfiUpVolumeUpColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMfiUpVolumeUpColor")]
	public XColor MfiUpVolumeUpColor
	{
		get
		{
			return GcLiqdsNoiI;
		}
		set
		{
			if (xColor == GcLiqdsNoiI)
			{
				return;
			}
			GcLiqdsNoiI = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					de3iqQ1EUNs = new XPen(EjpiqEAUWKk, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82903012));
					return;
				case 1:
					EjpiqEAUWKk = new XBrush(GcLiqdsNoiI);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMfiDownVolumeDownColor")]
	[DataMember(Name = "MfiDownVolumeDownColor")]
	public XColor MfiDownVolumeDownColor
	{
		get
		{
			return QMViq6Au0g6;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (Yp2jyPec38rG0T8uIGRs(xColor, QMViq6Au0g6))
					{
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 == 0)
						{
							num2 = 1;
						}
						break;
					}
					QMViq6Au0g6 = xColor;
					WbDiqg1finB = new XBrush(QMViq6Au0g6);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
					{
						num2 = 0;
					}
					break;
				default:
					UCdiqRN19m4 = new XPen(WbDiqg1finB, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4AF8F));
					return;
				case 1:
					return;
				}
			}
		}
	}

	[DataMember(Name = "MfiUpVolumeDownColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMfiUpVolumeDownColor")]
	public XColor MfiUpVolumeDownColor
	{
		get
		{
			return AvfiqqnDQdq;
		}
		set
		{
			if (xColor == AvfiqqnDQdq)
			{
				return;
			}
			AvfiqqnDQdq = xColor;
			boxiqMeNE6n = new XBrush(AvfiqqnDQdq);
			gTciqOecFjk = new XPen(boxiqMeNE6n, 1);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-673683647 ^ -673660819));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 == 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "MfiDownVolumeUpColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMfiDownVolumeUpColor")]
	public XColor MfiDownVolumeUpColor
	{
		get
		{
			return beqiqtv5K7W;
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
				case 2:
					OnPropertyChanged((string)dcBBLwecpbUWDtiLZBaC(0x37B74BDF ^ 0x37B7EC87));
					return;
				case 1:
					if (xColor == beqiqtv5K7W)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f866dbb44e884db6a20dd750c320252b == 0)
						{
							num2 = 0;
						}
						break;
					}
					beqiqtv5K7W = xColor;
					T3DiqIdyZMg = new XBrush(beqiqtv5K7W);
					fwmiqWJEQso = new XPen(T3DiqIdyZMg, 1);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
					{
						num2 = 2;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLevels")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsLevels")]
	public List<ChartLevel> vUwiqXYleCK => base.Levels;

	[DefaultValue(IndicatorBWMFIType.Ticks)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsIndicator")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsMfiVolume")]
	[DataMember(Name = "MfiVolumeType")]
	public IndicatorBWMFIType MfiVolumeType
	{
		get
		{
			return cMViqU8FPuQ;
		}
		set
		{
			if (indicatorBWMFIType != cMViqU8FPuQ)
			{
				cMViqU8FPuQ = indicatorBWMFIType;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x769C7931 ^ 0x769CDEB5));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
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
	}

	public yu3tXdiqDgpkAS9bjrYe()
	{
		YagQ9Necuht1txSdffHL();
		base._002Ector();
	}

	protected override void Execute()
	{
		int num = 1;
		int num2 = num;
		IndicatorSeriesData indicatorSeriesData = default(IndicatorSeriesData);
		while (true)
		{
			switch (num2)
			{
			case 1:
				indicatorSeriesData = new IndicatorSeriesData(base.Helper.BWMFI(MfiVolumeType));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				indicatorSeriesData.UserData[yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7DB10E6E ^ 0x7DB17542)] = ((cMViqU8FPuQ == IndicatorBWMFIType.Real) ? base.Helper.Volume : base.Helper.Trades);
				base.Series.Add(indicatorSeriesData);
				return;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		if (vbNwG1eczPKCy6T9KIN8(base.Series) == 0)
		{
			return;
		}
		double[] array = (double[])eo12qrej0AhQX58XEtkb(base.Series[0]);
		double[] array2 = (double[])((Hashtable)y2HwxAej2POISLdBw4CC(base.Series[0]))[dcBBLwecpbUWDtiLZBaC(-1999650146 ^ -1999652430)];
		double y = base.Canvas.GetY(0.0);
		bool flag = false;
		int num = 9;
		int num5 = default(int);
		bool flag2 = default(bool);
		double num2 = default(double);
		double num3 = default(double);
		int num4 = default(int);
		double num6 = default(double);
		int index = default(int);
		Rect rect = default(Rect);
		while (true)
		{
			int num7;
			switch (num)
			{
			default:
				num5++;
				goto IL_00b2;
			case 9:
				flag2 = false;
				num = 7;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 == 0)
				{
					num = 20;
				}
				break;
			case 4:
				if (flag || flag2)
				{
					if (flag)
					{
						num = 12;
						break;
					}
					goto IL_02db;
				}
				num = 11;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8df0e84d43a842eca742d74a9772b346 == 0)
				{
					num = 21;
				}
				break;
			case 16:
				P_0.DrawLine(fwmiqWJEQso, num2, num3, num2, num3 + (double)num4);
				num = 14;
				break;
			case 24:
				if (num6 > 1.0)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 3;
			case 22:
				if (flag)
				{
					num7 = 23;
					goto IL_0005;
				}
				goto IL_03ca;
			case 23:
				if (!flag2)
				{
					num = 7;
					break;
				}
				goto IL_03ca;
			case 12:
				if (flag2)
				{
					goto IL_02db;
				}
				goto case 11;
			case 19:
				num3 = base.Canvas.GetY(array[index]);
				num4 = (int)y - (int)num3;
				flag = ((index > 0 && index < array.Length) ? (array[index - 1] < array[index]) : flag);
				flag2 = ((index > 0 && index < array2.Length) ? (array2[index - 1] < array2[index]) : flag2);
				num7 = 18;
				goto IL_0005;
			case 20:
				num6 = Math.Max(base.Canvas.ColumnWidth - 1.0, 1.0);
				num = 8;
				break;
			case 15:
				num2 = UwKAyEejHPDEYnAaONiq(base.Canvas, index);
				num = 19;
				break;
			case 5:
				return;
			case 10:
				if (!flag2)
				{
					P_0.DrawLine(UCdiqRN19m4, num2, num3, num2, num3 + (double)num4);
					num = 13;
					break;
				}
				goto case 22;
			case 11:
				fibCnrejf73pupkLpHTR(P_0, boxiqMeNE6n, rect);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				if (flag && flag2)
				{
					P_0.DrawLine(de3iqQ1EUNs, num2, num3, num2, num3 + (double)num4);
					num = 17;
					break;
				}
				if (!flag)
				{
					num = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
					{
						num = 3;
					}
					break;
				}
				goto case 22;
			case 18:
				if ((double)num4 < 0.0)
				{
					num3 += (double)num4;
					num4 = -num4;
					num = 24;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f == 0)
					{
						num = 16;
					}
					break;
				}
				goto case 24;
			case 1:
				rect = new Rect(num2 - num6 / 2.0, num3, num6, num4);
				num7 = 2;
				goto IL_0005;
			case 21:
				P_0.FillRectangle(WbDiqg1finB, rect);
				goto default;
			case 8:
				num5 = 0;
				goto IL_00b2;
			case 2:
				if (flag && flag2)
				{
					fibCnrejf73pupkLpHTR(P_0, EjpiqEAUWKk, rect);
					goto default;
				}
				goto case 4;
			case 7:
				{
					P_0.DrawLine(gTciqOecFjk, num2, num3, num2, num3 + (double)num4);
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
					{
						num = 2;
					}
					break;
				}
				IL_0005:
				num = num7;
				break;
				IL_00b2:
				if (num5 >= zIa8xhej9ieRNVPxZEMN(base.Canvas))
				{
					num = 5;
					break;
				}
				index = base.Canvas.GetIndex(num5);
				num = 15;
				break;
				IL_03ca:
				if (!flag && flag2)
				{
					num = 16;
					break;
				}
				goto default;
				IL_02db:
				if (!flag && flag2)
				{
					P_0.FillRectangle(T3DiqIdyZMg, rect);
				}
				goto default;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		MfiUpVolumeUpColor = NFnHq3ejnoUi5fqPxGBF();
		MfiDownVolumeDownColor = YbC0vlejYwWcnNWvOIHp(SSSmqZejG3hCS3UG9WIW());
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				base.ApplyColors(P_0);
				return;
			}
			MfiUpVolumeDownColor = Colors.Blue;
			MfiDownVolumeUpColor = nvpRC1ejo3iEyukgaml2();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
			{
				num = 1;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		yu3tXdiqDgpkAS9bjrYe yu3tXdiqDgpkAS9bjrYe2 = (yu3tXdiqDgpkAS9bjrYe)P_0;
		MfiUpVolumeUpColor = yu3tXdiqDgpkAS9bjrYe2.MfiUpVolumeUpColor;
		MfiDownVolumeDownColor = yu3tXdiqDgpkAS9bjrYe2.MfiDownVolumeDownColor;
		MfiUpVolumeDownColor = yu3tXdiqDgpkAS9bjrYe2.MfiUpVolumeDownColor;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				MfiVolumeType = UOGlpoejBMvMkHsjkISA(yu3tXdiqDgpkAS9bjrYe2);
				base.CopyTemplate(P_0, P_1);
				num = 2;
				continue;
			case 2:
				return;
			}
			MfiDownVolumeUpColor = GKuHlIejvkFdAZ0TNkS4(yu3tXdiqDgpkAS9bjrYe2);
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
			{
				num = 1;
			}
		}
	}

	static yu3tXdiqDgpkAS9bjrYe()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		cStlCUejapKRXWp8FTGr();
	}

	internal static bool wnNrjPecJCxnTAnV4LCK()
	{
		return SaSYjCecPGi7r6y1H357 == null;
	}

	internal static yu3tXdiqDgpkAS9bjrYe zLhJWCecFjaQaFrHUIjn()
	{
		return SaSYjCecPGi7r6y1H357;
	}

	internal static bool Yp2jyPec38rG0T8uIGRs(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static object dcBBLwecpbUWDtiLZBaC(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static void YagQ9Necuht1txSdffHL()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
	}

	internal static int vbNwG1eczPKCy6T9KIN8(object P_0)
	{
		return ((IndicatorSeries)P_0).Count;
	}

	internal static object eo12qrej0AhQX58XEtkb(object P_0)
	{
		return ((IndicatorSeriesData)P_0).Data;
	}

	internal static object y2HwxAej2POISLdBw4CC(object P_0)
	{
		return ((IndicatorSeriesData)P_0).UserData;
	}

	internal static double UwKAyEejHPDEYnAaONiq(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static void fibCnrejf73pupkLpHTR(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int zIa8xhej9ieRNVPxZEMN(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static Color NFnHq3ejnoUi5fqPxGBF()
	{
		return Colors.Lime;
	}

	internal static Color SSSmqZejG3hCS3UG9WIW()
	{
		return Colors.SaddleBrown;
	}

	internal static XColor YbC0vlejYwWcnNWvOIHp(Color P_0)
	{
		return P_0;
	}

	internal static Color nvpRC1ejo3iEyukgaml2()
	{
		return Colors.Pink;
	}

	internal static XColor GKuHlIejvkFdAZ0TNkS4(object P_0)
	{
		return ((yu3tXdiqDgpkAS9bjrYe)P_0).MfiDownVolumeUpColor;
	}

	internal static IndicatorBWMFIType UOGlpoejBMvMkHsjkISA(object P_0)
	{
		return ((yu3tXdiqDgpkAS9bjrYe)P_0).MfiVolumeType;
	}

	internal static void cStlCUejapKRXWp8FTGr()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
