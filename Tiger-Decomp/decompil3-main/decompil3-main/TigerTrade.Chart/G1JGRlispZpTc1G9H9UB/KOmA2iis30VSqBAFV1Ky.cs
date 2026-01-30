using System;
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
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Dx;

namespace G1JGRlispZpTc1G9H9UB;

[DataContract(Name = "SessionColorIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("SessionColor", "SessionColor", true, Type = typeof(KOmA2iis30VSqBAFV1Ky))]
internal sealed class KOmA2iis30VSqBAFV1Ky : IndicatorBase
{
	private TimeSpan hU2iX9kAgxa;

	private TimeSpan fuEiXntHQey;

	private XBrush v1riXGj452O;

	private XColor Q2WiXY0H9pH;

	internal static KOmA2iis30VSqBAFV1Ky UvxY7PeSs7hAWVF0nPl3;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStartTime")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "StartTime")]
	public TimeSpan StartTime
	{
		get
		{
			return hU2iX9kAgxa;
		}
		set
		{
			if (!kqBbk2eSj3PXsacdH7yp(timeSpan, hU2iX9kAgxa))
			{
				hU2iX9kAgxa = timeSpan;
				OnPropertyChanged((string)o25faueSEnP8S2DmLDRD(0x7ADBF691 ^ 0x7ADB65E1));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 == 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsEndTime")]
	[DataMember(Name = "EndTime")]
	public TimeSpan EndTime
	{
		get
		{
			return fuEiXntHQey;
		}
		set
		{
			if (!(timeSpan == fuEiXntHQey))
			{
				fuEiXntHQey = timeSpan;
				OnPropertyChanged((string)o25faueSEnP8S2DmLDRD(-1736566656 ^ -1736537338));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
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

	[DataMember(Name = "BackColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor BackColor
	{
		get
		{
			return Q2WiXY0H9pH;
		}
		set
		{
			if (!bZD6HIeSQmACWkodRBFe(xColor, Q2WiXY0H9pH))
			{
				Q2WiXY0H9pH = xColor;
				v1riXGj452O = new XBrush(Q2WiXY0H9pH);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1153206687 ^ -1153175215));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public KOmA2iis30VSqBAFV1Ky()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		PhJPqgeSduIFCJIj30H0(this, false);
		StartTime = jyy5OpeSgIlEdmCt2cbO(0.0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3a22ea2a41c84163a97ae0a1f3b4c6b4 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				BackColor = Color.FromArgb(127, 30, 144, byte.MaxValue);
				return;
			}
			EndTime = TimeSpan.FromHours(12.0);
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
			{
				num = 0;
			}
		}
	}

	protected override void Execute()
	{
	}

	public override void Render(DxVisualQueue P_0)
	{
		DateTime dateTime = DateTime.MinValue;
		DateTime dateTime2 = DateTime.MinValue;
		Point point = default(Point);
		Point point2 = default(Point);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_d4f52eaa7d9d4aa09bb6fdf0b3adf8b6 == 0)
		{
			num = 0;
		}
		DateTime dateTime4 = default(DateTime);
		DateTime dateTime6 = default(DateTime);
		int num2 = default(int);
		DateTime dateTime5 = default(DateTime);
		DateTime dateTime7 = default(DateTime);
		DateTime date = default(DateTime);
		DateTime dateTime3 = default(DateTime);
		int index = default(int);
		while (true)
		{
			switch (num)
			{
			case 3:
				dateTime2 = DateTime.MinValue;
				point = default(Point);
				point2 = default(Point);
				num = 23;
				break;
			case 24:
				if (dateTime4 >= dateTime6)
				{
					point2 = new Point(base.Canvas.GetXX(num2 + 1) + base.Canvas.ColumnWidth / 2.0, base.Canvas.Rect.Bottom);
					dateTime2 = dateTime4;
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
					{
						num = 5;
					}
					break;
				}
				goto case 4;
			case 18:
				if (!(dateTime4 < dateTime5))
				{
					goto IL_03b0;
				}
				goto IL_0486;
			case 9:
				dateTime2 = dateTime4;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
				{
					num = 4;
				}
				break;
			case 12:
				MrduALeSte1oyg1x7TrU(P_0, v1riXGj452O, new Rect(point, point2));
				num = 16;
				break;
			case 20:
				dateTime2 = DateTime.MinValue;
				point2 = default(Point);
				num = 22;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e == 0)
				{
					num = 8;
				}
				break;
			default:
				num2 = base.Canvas.Count - 1;
				num = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 != 0)
				{
					num = 2;
				}
				break;
			case 25:
				if (dateTime4 >= dateTime7)
				{
					num = 11;
					break;
				}
				goto case 14;
			case 8:
				dateTime5 = date.Add(EndTime);
				if (!fQsBjweSqU9OiRRVNurM(dateTime, DateTime.MinValue))
				{
					goto IL_03b0;
				}
				if (!BLNCyMeSItdVm2y21uQs(dateTime4, dateTime3))
				{
					num = 18;
					break;
				}
				goto IL_0486;
			case 5:
				point2 = new Point(base.Canvas.GetXX(num2 + 1) + base.Canvas.ColumnWidth / 2.0, luPIpceSONBbZcZdlK2K(base.Canvas).Bottom);
				dateTime2 = dateTime4;
				num = 7;
				break;
			case 1:
				if (dateTime != DateTime.MinValue)
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
					{
						num = 2;
					}
					break;
				}
				return;
			case 10:
				if (num2 >= -pgLrpOeSUMe4tHyj6XRI(base.Canvas))
				{
					index = base.Canvas.GetIndex(num2);
					num = 21;
					break;
				}
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
				{
					num = 1;
				}
				break;
			case 19:
				return;
			case 21:
				dateTime4 = fv2cXYeSR2GdFqY1Eg4f(base.Canvas, base.Canvas.IndexToDate(index));
				if (!(StartTime < EndTime))
				{
					num = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_123010c01d0b4fbbba06aee53a0dc75d == 0)
					{
						num = 6;
					}
					break;
				}
				dateTime7 = dateTime4.Date.Add(StartTime);
				date = dateTime4.Date;
				dateTime6 = date.Add(EndTime);
				if (dateTime == DateTime.MinValue)
				{
					num = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c != 0)
					{
						num = 25;
					}
					break;
				}
				goto case 14;
			case 17:
				date = dateTime4.Date;
				num = 15;
				break;
			case 2:
				P_0.FillRectangle(v1riXGj452O, new Rect(point, new Point(base.Canvas.Rect.Right, base.Canvas.Rect.Bottom)));
				num = 19;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
				{
					num = 14;
				}
				break;
			case 16:
				dateTime = DateTime.MinValue;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
				{
					num = 2;
				}
				break;
			case 11:
				if (dateTime4 < dateTime6)
				{
					point = new Point(base.Canvas.GetXX(num2) - vvRo2ZeS6xCNKT0OYxWK(base.Canvas) / 2.0, 0.0);
					dateTime = dateTime4;
					num = 20;
				}
				else
				{
					num = 14;
				}
				break;
			case 15:
				dateTime3 = date.Add(StartTime);
				date = dateTime4.Date;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num = 8;
				}
				break;
			case 14:
			case 22:
				if (!mP5FYZeSMVaRmeQYWNnl(dateTime, DateTime.MinValue))
				{
					goto case 24;
				}
				if (!(dateTime.Date < dateTime4.Date))
				{
					num = 24;
					break;
				}
				goto case 5;
			case 23:
				num2--;
				goto case 10;
			case 4:
			case 6:
			case 7:
			case 13:
				{
					if (!fQsBjweSqU9OiRRVNurM(dateTime, DateTime.MinValue) && !fQsBjweSqU9OiRRVNurM(dateTime2, DateTime.MinValue))
					{
						num = 12;
						break;
					}
					goto case 23;
				}
				IL_03b0:
				if (dateTime4 >= dateTime5)
				{
					if (dateTime4 < dateTime3)
					{
						point2 = new Point(OMKyyneSWMTAOaG6YlY8(base.Canvas, num2 + 1) + vvRo2ZeS6xCNKT0OYxWK(base.Canvas) / 2.0, base.Canvas.Rect.Bottom);
						num = 2;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 != 0)
						{
							num = 9;
						}
					}
					else
					{
						num = 13;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
						{
							num = 6;
						}
					}
					break;
				}
				goto case 4;
				IL_0486:
				point = new Point(base.Canvas.GetXX(num2) - base.Canvas.ColumnWidth / 2.0, 0.0);
				dateTime = dateTime4;
				dateTime2 = DateTime.MinValue;
				point2 = default(Point);
				goto IL_03b0;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BackColor = P_0.GetNextColor();
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		KOmA2iis30VSqBAFV1Ky kOmA2iis30VSqBAFV1Ky = (KOmA2iis30VSqBAFV1Ky)P_0;
		BackColor = zF3laJeSTxComOQ7R30E(kOmA2iis30VSqBAFV1Ky);
		StartTime = kOmA2iis30VSqBAFV1Ky.StartTime;
		EndTime = kOmA2iis30VSqBAFV1Ky.EndTime;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1a52446ff7d24524a71087c98b41bbc6 != 0)
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
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static KOmA2iis30VSqBAFV1Ky()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool kqBbk2eSj3PXsacdH7yp(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 == P_1;
	}

	internal static object o25faueSEnP8S2DmLDRD(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool sg0OnReSXCh4dmIkawrb()
	{
		return UvxY7PeSs7hAWVF0nPl3 == null;
	}

	internal static KOmA2iis30VSqBAFV1Ky IQCjUZeScbtlNCIUc7sy()
	{
		return UvxY7PeSs7hAWVF0nPl3;
	}

	internal static bool bZD6HIeSQmACWkodRBFe(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void PhJPqgeSduIFCJIj30H0(object P_0, bool value)
	{
		((IndicatorBase)P_0).ShowIndicatorTitle = value;
	}

	internal static TimeSpan jyy5OpeSgIlEdmCt2cbO(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static DateTime fv2cXYeSR2GdFqY1Eg4f(object P_0, DateTime dt)
	{
		return ((IChartCanvas)P_0).ConvertTimeToLocal(dt);
	}

	internal static double vvRo2ZeS6xCNKT0OYxWK(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static bool mP5FYZeSMVaRmeQYWNnl(DateTime P_0, DateTime P_1)
	{
		return P_0 != P_1;
	}

	internal static Rect luPIpceSONBbZcZdlK2K(object P_0)
	{
		return ((IChartCanvas)P_0).Rect;
	}

	internal static bool fQsBjweSqU9OiRRVNurM(DateTime P_0, DateTime P_1)
	{
		return P_0 == P_1;
	}

	internal static bool BLNCyMeSItdVm2y21uQs(DateTime P_0, DateTime P_1)
	{
		return P_0 >= P_1;
	}

	internal static double OMKyyneSWMTAOaG6YlY8(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetXX(i);
	}

	internal static void MrduALeSte1oyg1x7TrU(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static int pgLrpOeSUMe4tHyj6XRI(object P_0)
	{
		return ((IChartCanvas)P_0).AfterBars;
	}

	internal static XColor zF3laJeSTxComOQ7R30E(object P_0)
	{
		return ((KOmA2iis30VSqBAFV1Ky)P_0).BackColor;
	}
}
