using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Collections;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Drawings.Enums;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace ctyd23idW10sYCilggIA;

[Indicator("VWAP", "VWAP", true, Type = typeof(IqvjrUidI3MCkkWidjPn))]
[DataContract(Name = "VWAPIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class IqvjrUidI3MCkkWidjPn : IndicatorBase
{
	private IndicatorPeriodType hXuidAl7pV4;

	private TimeSpan? d80idPRXCii;

	private IndicatorPriceType eFvidJ6lQ4T;

	private List<decimal> OFFidFlPgW4;

	private ChartSeries ioDid3dYeKj;

	private ChartSeries qXvidprSgyf;

	private List<double> qvJiduD9wHu;

	internal static IqvjrUidI3MCkkWidjPn kYrxoWeeOThEdOpbi26w;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Period")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	public IndicatorPeriodType Period
	{
		get
		{
			return hXuidAl7pV4;
		}
		set
		{
			if (indicatorPeriodType != hXuidAl7pV4)
			{
				hXuidAl7pV4 = indicatorPeriodType;
				hRSid7JhThp().Clear();
				OnPropertyChanged((string)pfVGfTeeWo2ItY41dKlR(-1583344314 ^ -1583312144));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsTime")]
	[DataMember(Name = "StartTime")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public TimeSpan? StartTime
	{
		get
		{
			return d80idPRXCii;
		}
		set
		{
			if (!timeSpan.Equals(d80idPRXCii))
			{
				d80idPRXCii = timeSpan;
				hRSid7JhThp().Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x86EFEF6 ^ 0x86E6D86));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPrice")]
	[DataMember(Name = "PriceType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorPriceType PriceType
	{
		get
		{
			return eFvidJ6lQ4T;
		}
		set
		{
			if (indicatorPriceType != eFvidJ6lQ4T)
			{
				eFvidJ6lQ4T = indicatorPriceType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				PR2vnxeetcr8Adk5YRKs(hRSid7JhThp());
				OnPropertyChanged((string)pfVGfTeeWo2ItY41dKlR(-1161619942 ^ -1161578830));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "StdDevs")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsStdDevs")]
	public List<decimal> StdDevs
	{
		get
		{
			return OFFidFlPgW4 ?? (StdDevs = new List<decimal>());
		}
		set
		{
			if (!object.Equals(list, OFFidFlPgW4))
			{
				OFFidFlPgW4 = list;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2C8374E4 ^ 0x2C83D45A));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "VWAP")]
	[DisplayName("VWAP")]
	public ChartSeries VWAPSeries
	{
		get
		{
			return ioDid3dYeKj ?? (ioDid3dYeKj = new ChartSeries(ChartSeriesType.Line, Colors.Blue));
		}
		private set
		{
			if (!object.Equals(objA, ioDid3dYeKj))
			{
				ioDid3dYeKj = objA;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)pfVGfTeeWo2ItY41dKlR(-617064403 ^ -617023235));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DisplayName("StdDev")]
	[DataMember(Name = "StdDev")]
	public ChartSeries StdDevSeries
	{
		get
		{
			return qXvidprSgyf ?? (qXvidprSgyf = new ChartSeries(ChartSeriesType.Line, vIjiqOeeUEZZYJHhS658(Colors.Red)));
		}
		private set
		{
			if (!object.Equals(objA, qXvidprSgyf))
			{
				qXvidprSgyf = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799551641));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
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

	public IqvjrUidI3MCkkWidjPn()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				Period = IndicatorPeriodType.Day;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				PriceType = IndicatorPriceType.Median;
				StdDevs.Add(1m);
				StdDevs.Add(2m);
				return;
			default:
				StartTime = null;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[SpecialName]
	private List<double> hRSid7JhThp()
	{
		return qvJiduD9wHu ?? (qvJiduD9wHu = new List<double>(1000));
	}

	protected override void Execute()
	{
		int num = 12;
		int num2 = num;
		double num3 = default(double);
		double[] array5 = default(double[]);
		IndicatorSeriesData indicatorSeriesData5 = default(IndicatorSeriesData);
		double[] array6 = default(double[]);
		IndicatorSeriesData indicatorSeriesData3 = default(IndicatorSeriesData);
		double[] date = default(double[]);
		double[] array = default(double[]);
		double[] array3 = default(double[]);
		double num12 = default(double);
		bool[] array2 = default(bool[]);
		int num6 = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num4 = default(int);
		double num5 = default(double);
		double timeOffset = default(double);
		bool flag = default(bool);
		double num10 = default(double);
		double[] array4 = default(double[]);
		double[] volume = default(double[]);
		int i = default(int);
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			IEnumerator<IndicatorSeriesData> enumerator;
			switch (num2)
			{
			case 27:
				num3 = 0.0;
				num2 = 6;
				break;
			case 4:
			{
				using (List<decimal>.Enumerator enumerator2 = StdDevs.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						while (true)
						{
							decimal current2 = enumerator2.Current;
							int num11 = 3;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
							{
								num11 = 0;
							}
							while (true)
							{
								switch (num11)
								{
								case 5:
								{
									IndicatorSeriesData indicatorSeriesData4 = new IndicatorSeriesData(array5, StdDevSeries);
									indicatorSeriesData4.Style.DisableMinMax = true;
									indicatorSeriesData5 = indicatorSeriesData4;
									num11 = 6;
									continue;
								}
								case 1:
									break;
								case 3:
									goto IL_065d;
								case 6:
								{
									IndicatorSeriesData indicatorSeriesData2 = new IndicatorSeriesData(array6, StdDevSeries);
									indicatorSeriesData2.Style.DisableMinMax = true;
									indicatorSeriesData3 = indicatorSeriesData2;
									num11 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bddbd469f60045dea35a495487f8a4fb != 0)
									{
										num11 = 1;
									}
									continue;
								}
								case 4:
								{
									for (int j = 0; j < date.Length; j++)
									{
										array5[j] = array[j] + array3[j] * num12;
										array6[j] = array[j] - array3[j] * num12;
									}
									num11 = 5;
									continue;
								}
								default:
									goto end_IL_05c2;
								case 2:
								{
									num12 = BYr8X5eeheZAeLUvUy45(current2);
									int num13 = 4;
									num11 = num13;
									continue;
								}
								}
								Lc1aoreewEbt60xVDVeb(base.Series, indicatorSeriesData5, indicatorSeriesData3);
								goto end_IL_06e8;
								IL_065d:
								if (Vu67ojeemyg1M6DfBEax(current2, 0m))
								{
									goto end_IL_06e8;
								}
								array5 = new double[date.Length];
								array6 = new double[date.Length];
								num11 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae != 0)
								{
									num11 = 2;
								}
								continue;
								end_IL_05c2:
								break;
							}
							continue;
							end_IL_06e8:
							break;
						}
					}
				}
				goto IL_02a6;
			}
			case 17:
				array2 = new bool[date.Length];
				num2 = 3;
				break;
			case 25:
				if (num6 != num7)
				{
					num7 = num6;
					num8 = num4;
					num5 = 0.0;
					num3 = 0.0;
					array2[num4] = true;
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 1:
				num6 = -1;
				switch (Period)
				{
				case IndicatorPeriodType.Month:
					num6 = base.DataProvider.Period.GetSequence(ChartPeriodType.Month, 1, date[num4], timeOffset);
					break;
				case IndicatorPeriodType.Week:
					goto IL_0392;
				case IndicatorPeriodType.Day:
					num6 = base.DataProvider.Period.GetSequence(ChartPeriodType.Day, 1, date[num4], timeOffset);
					break;
				}
				goto case 25;
			case 22:
				if (flag)
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_02a6;
			case 16:
				if (date.Length < hRSid7JhThp().Count)
				{
					hRSid7JhThp().Clear();
					num2 = 19;
					break;
				}
				goto case 19;
			case 24:
				return;
			case 14:
				num10 = 0.0;
				num2 = 20;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
				{
					num2 = 20;
				}
				break;
			default:
				num5 += array4[num4] * volume[num4];
				num2 = 15;
				break;
			case 10:
				for (; i < num4; i++)
				{
					num10 += volume[i] / num3 * (array4[i] - array[num4]) * (array4[i] - array[num4]);
				}
				array3[num4] = uNcdHneeKvXhpfkvHmFt(num10);
				hRSid7JhThp().Add(array3[num4]);
				goto case 2;
			case 12:
				date = base.Helper.Date;
				num2 = 11;
				break;
			case 11:
				array4 = (double[])UxwXj6eeTpsFYC5GOVXx(base.Helper, eFvidJ6lQ4T);
				volume = base.Helper.Volume;
				num2 = 18;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 == 0)
				{
					num2 = 4;
				}
				break;
			case 20:
				i = num8;
				num2 = 10;
				break;
			case 9:
				num5 = 0.0;
				num2 = 27;
				break;
			case 8:
				if (!StartTime.HasValue)
				{
					timeOffset = zFd7jneeVvAOwNoqEKFF(base.DataProvider.Symbol.Exchange);
					goto IL_080d;
				}
				num2 = 23;
				break;
			case 19:
				num7 = -1;
				num2 = 9;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num2 = 9;
				}
				break;
			case 18:
				array = new double[date.Length];
				array3 = new double[date.Length];
				num2 = 17;
				break;
			case 6:
				num8 = 0;
				num2 = 8;
				break;
			case 13:
				goto IL_0392;
			case 23:
				dateTime2 = P5jXSEeeZZcbSQNSATcp(0.0);
				num2 = 10;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num2 = 26;
				}
				break;
			case 2:
				num4++;
				goto IL_054c;
			case 15:
				num3 += volume[num4];
				num2 = 5;
				break;
			case 7:
				timeOffset = 0.0 - dateTime.ToOADate();
				goto IL_080d;
			case 3:
				flag = PycgEieeyqnfjRt3rKvn(StdDevs) > 0;
				num2 = 16;
				break;
			case 21:
				if (num4 < hRSid7JhThp().Count)
				{
					array3[num4] = hRSid7JhThp()[num4];
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 14;
			case 5:
				if (num3 != 0.0)
				{
					array[num4] = num5 / num3;
					if (flag)
					{
						num2 = 21;
						break;
					}
				}
				goto case 2;
			case 26:
				{
					dateTime = dateTime2.Add(StartTime.Value);
					num2 = 7;
					break;
				}
				IL_02a6:
				enumerator = base.Series.GetEnumerator();
				try
				{
					while (aUbaiUee85sIVodsysZf(enumerator))
					{
						IndicatorSeriesData current = enumerator.Current;
						current.UserData[pfVGfTeeWo2ItY41dKlR(0x684F243E ^ 0x684FBCC2)] = array2;
						((Hashtable)oka6tmee7gnA9fjrwIH5(current))[pfVGfTeeWo2ItY41dKlR(-1047165041 ^ -1047191923)] = false;
						int num9 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						}
					}
					return;
				}
				finally
				{
					if (enumerator != null)
					{
						o7TPtJeeA73aKyiUYLW8(enumerator);
					}
				}
				IL_080d:
				num4 = 0;
				goto IL_054c;
				IL_054c:
				if (num4 >= date.Length)
				{
					IndicatorSeriesData indicatorSeriesData = new IndicatorSeriesData(array, VWAPSeries);
					indicatorSeriesData.Style.DisableMinMax = true;
					IndicatorSeriesData series = indicatorSeriesData;
					base.Series.Add(series);
					num2 = 22;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b6f1ae5199084abc84c46b275feb4dfd == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 1;
				IL_0392:
				num6 = M9FIy0eerkISeoBq0ogx(hp07LaeeCJAU5AfOpZtN(base.DataProvider), ChartPeriodType.Week, 1, date[num4], timeOffset);
				num2 = 25;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num2 = 23;
				}
				break;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				StdDevSeries.AllColors = P_0.GetNextColor();
				base.ApplyColors(P_0);
				return;
			case 1:
				VWAPSeries.AllColors = P_0.GetNextColor();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 3;
		int num2 = num;
		IqvjrUidI3MCkkWidjPn iqvjrUidI3MCkkWidjPn = default(IqvjrUidI3MCkkWidjPn);
		while (true)
		{
			switch (num2)
			{
			case 1:
				QYLRqOeeFck3OPCHMumO(StdDevSeries, YaR1EZeeJO3MieFUA1lA(iqvjrUidI3MCkkWidjPn));
				base.CopyTemplate(P_0, P_1);
				return;
			case 2:
				Period = iqvjrUidI3MCkkWidjPn.Period;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				iqvjrUidI3MCkkWidjPn = (IqvjrUidI3MCkkWidjPn)P_0;
				num2 = 2;
				continue;
			}
			PriceType = R1AuDMeePUWpicJswncB(iqvjrUidI3MCkkWidjPn);
			StdDevs = iqvjrUidI3MCkkWidjPn.StdDevs.ToList();
			VWAPSeries.CopyTheme(iqvjrUidI3MCkkWidjPn.VWAPSeries);
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
			{
				num2 = 0;
			}
		}
	}

	static IqvjrUidI3MCkkWidjPn()
	{
		AIA2PZee37uyhKlb77or();
		FdtAEgeep2B3EefjQsqh();
	}

	internal static object pfVGfTeeWo2ItY41dKlR(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool wuGByaeeqUZQxHyRNh6R()
	{
		return kYrxoWeeOThEdOpbi26w == null;
	}

	internal static IqvjrUidI3MCkkWidjPn Y37SjyeeI2cWqWMVkcxV()
	{
		return kYrxoWeeOThEdOpbi26w;
	}

	internal static void PR2vnxeetcr8Adk5YRKs(object P_0)
	{
		((List<double>)P_0).Clear();
	}

	internal static XColor vIjiqOeeUEZZYJHhS658(Color P_0)
	{
		return P_0;
	}

	internal static object UxwXj6eeTpsFYC5GOVXx(object P_0, IndicatorPriceType priceField)
	{
		return ((IndicatorsHelper)P_0).Price(priceField);
	}

	internal static int PycgEieeyqnfjRt3rKvn(object P_0)
	{
		return ((List<decimal>)P_0).Count;
	}

	internal static DateTime P5jXSEeeZZcbSQNSATcp(double P_0)
	{
		return DateTime.FromOADate(P_0);
	}

	internal static double zFd7jneeVvAOwNoqEKFF(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static object hp07LaeeCJAU5AfOpZtN(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static int M9FIy0eerkISeoBq0ogx(object P_0, ChartPeriodType type, int interval, double dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static double uNcdHneeKvXhpfkvHmFt(double P_0)
	{
		return Math.Sqrt(P_0);
	}

	internal static bool Vu67ojeemyg1M6DfBEax(decimal P_0, decimal P_1)
	{
		return P_0 <= P_1;
	}

	internal static double BYr8X5eeheZAeLUvUy45(decimal P_0)
	{
		return (double)P_0;
	}

	internal static void Lc1aoreewEbt60xVDVeb(object P_0, object P_1, object P_2)
	{
		((IndicatorSeries)P_0).Add((IndicatorSeriesData)P_1, (IndicatorSeriesData)P_2);
	}

	internal static object oka6tmee7gnA9fjrwIH5(object P_0)
	{
		return ((IndicatorSeriesData)P_0).UserData;
	}

	internal static bool aUbaiUee85sIVodsysZf(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void o7TPtJeeA73aKyiUYLW8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static IndicatorPriceType R1AuDMeePUWpicJswncB(object P_0)
	{
		return ((IqvjrUidI3MCkkWidjPn)P_0).PriceType;
	}

	internal static object YaR1EZeeJO3MieFUA1lA(object P_0)
	{
		return ((IqvjrUidI3MCkkWidjPn)P_0).StdDevSeries;
	}

	internal static void QYLRqOeeFck3OPCHMumO(object P_0, object P_1)
	{
		((ChartSeries)P_0).CopyTheme((ChartSeries)P_1);
	}

	internal static void AIA2PZee37uyhKlb77or()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void FdtAEgeep2B3EefjQsqh()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
