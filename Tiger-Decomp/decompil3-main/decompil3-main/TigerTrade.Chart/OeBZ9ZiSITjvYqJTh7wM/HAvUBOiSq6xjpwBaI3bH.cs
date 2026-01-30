using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Windows;
using System.Windows.Media;
using aAa0wvLVte7CLQrFHlCF;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace OeBZ9ZiSITjvYqJTh7wM;

[DataContract(Name = "ExternalChartIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("ExternalChart", "ExternalChart", true, Type = typeof(HAvUBOiSq6xjpwBaI3bH))]
internal sealed class HAvUBOiSq6xjpwBaI3bH : IndicatorBase
{
	private class TifW9uiKBVCPiAo0SCkb
	{
		public readonly int SuHiKi9Lou0;

		public int ESIiKlnU92j;

		public bool gEqiK4LOP9F;

		public decimal v9SiKDuqPH4;

		public decimal DIEiKbsRHYD;

		public decimal NG8iKN2XdPF;

		public decimal Close;

		private bool I9uiKknjity;

		private static TifW9uiKBVCPiAo0SCkb BySi5ueUsx7jW21VjOu8;

		public TifW9uiKBVCPiAo0SCkb(int P_0)
		{
			SCcCIqeUjdiiqXkmMJdK();
			base._002Ector();
			SuHiKi9Lou0 = P_0;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			I9uiKknjity = true;
		}

		public void tFEiKaRxmvb(IChartCluster P_0, int P_1, int P_2)
		{
			int num2;
			if (I9uiKknjity)
			{
				v9SiKDuqPH4 = y4TBy6eUETbJgskonGoV(P_0) * (decimal)P_2;
				int num = 2;
				num2 = num;
			}
			else
			{
				DIEiKbsRHYD = Math.Max(DIEiKbsRHYD, P_0.High * (decimal)P_2);
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
				{
					num2 = 1;
				}
			}
			while (true)
			{
				switch (num2)
				{
				case 3:
					Close = kXemv0eUgt5Ciya37itJ(P_0) * (decimal)P_2;
					ESIiKlnU92j = P_1;
					return;
				default:
					NG8iKN2XdPF = P_0.Low * (decimal)P_2;
					I9uiKknjity = false;
					num2 = 3;
					break;
				case 1:
					NG8iKN2XdPF = Math.Min(NG8iKN2XdPF, P_0.Low * lkidaaeUdlVnfelx4Njg(P_2));
					goto case 3;
				case 2:
					DIEiKbsRHYD = ErEG8DeUQAoVq15MLbbI(P_0.High, P_2);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static TifW9uiKBVCPiAo0SCkb()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			AphDuXeURyue9RI8seG2();
		}

		internal static void SCcCIqeUjdiiqXkmMJdK()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}

		internal static bool lCi5yDeUXQ9hxs9Gy8Bp()
		{
			return BySi5ueUsx7jW21VjOu8 == null;
		}

		internal static TifW9uiKBVCPiAo0SCkb wlTQ3eeUcDP1ky5B0gb9()
		{
			return BySi5ueUsx7jW21VjOu8;
		}

		internal static decimal y4TBy6eUETbJgskonGoV(object P_0)
		{
			return ((IChartCluster)P_0).Open;
		}

		internal static decimal ErEG8DeUQAoVq15MLbbI(decimal P_0, decimal P_1)
		{
			return P_0 * P_1;
		}

		internal static decimal lkidaaeUdlVnfelx4Njg(int P_0)
		{
			return P_0;
		}

		internal static decimal kXemv0eUgt5Ciya37itJ(object P_0)
		{
			return ((IChartCluster)P_0).Close;
		}

		internal static void AphDuXeURyue9RI8seG2()
		{
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}
	}

	private ExternalChartPeriodType IDOiSuHYjDx;

	private int QioiSz1wsuh;

	private bool yWgix09Omce;

	private XBrush DOcix2Nwmbu;

	private XColor NTQixHg3SRK;

	private bool j23ixf3wMsC;

	private XBrush E0qix9bumRp;

	private XPen V2oixnhSeBb;

	private XColor W4hixGD2EM5;

	private ExternalChartBorderType hlBixYPY31X;

	private int Sfmixoo86sF;

	private XBrush ja5ixvokcda;

	private XColor hjDixBmMkla;

	private List<TifW9uiKBVCPiAo0SCkb> ALvixarqD6l;

	private int UI6ixiH6sDC;

	internal static HAvUBOiSq6xjpwBaI3bH uZNWuZekcPDNFAoGUktb;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "PeriodType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	public ExternalChartPeriodType PeriodType
	{
		get
		{
			return IDOiSuHYjDx;
		}
		set
		{
			if (externalChartPeriodType == IDOiSuHYjDx)
			{
				return;
			}
			IDOiSuHYjDx = externalChartPeriodType;
			QioiSz1wsuh = ((IDOiSuHYjDx != ExternalChartPeriodType.Minute) ? 1 : 15);
			Clear();
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x12620268 ^ 0x12629B62));
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_555a94ebd4594650b107ef6bf239937f != 0)
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
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFDADE));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
				{
					num = 1;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodValue")]
	[DataMember(Name = "PeriodValue")]
	public int PeriodValue
	{
		get
		{
			return QioiSz1wsuh;
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num3 = Math.Max(1, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				if (num3 == QioiSz1wsuh)
				{
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				QioiSz1wsuh = num3;
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2074141628 ^ -2074114714));
				return;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowBack")]
	[DataMember(Name = "ShowBack")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsBack")]
	public bool ShowBack
	{
		get
		{
			return yWgix09Omce;
		}
		set
		{
			if (flag != yWgix09Omce)
			{
				yWgix09Omce = flag;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)kZ0tqZekQQnfkweZ6Khd(0x684F243E ^ 0x684FBD02));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackColor")]
	[DataMember(Name = "BackColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsBack")]
	public XColor BackColor
	{
		get
		{
			return NTQixHg3SRK;
		}
		set
		{
			if (!(xColor == NTQixHg3SRK))
			{
				NTQixHg3SRK = xColor;
				int num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
				{
					num = 1;
				}
				switch (num)
				{
				case 1:
					DOcix2Nwmbu = new XBrush(NTQixHg3SRK);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--871424829 ^ 0x33F0640D));
					break;
				case 0:
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsShowGrid")]
	[DataMember(Name = "ShowGrid")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsGrid")]
	public bool ShowGrid
	{
		get
		{
			return j23ixf3wMsC;
		}
		set
		{
			if (flag != j23ixf3wMsC)
			{
				j23ixf3wMsC = flag;
				OnPropertyChanged((string)kZ0tqZekQQnfkweZ6Khd(-342738082 ^ -342711794));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsGridColor")]
	[DataMember(Name = "GridColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsGrid")]
	public XColor GridColor
	{
		get
		{
			return W4hixGD2EM5;
		}
		set
		{
			if (!(xColor == W4hixGD2EM5))
			{
				W4hixGD2EM5 = xColor;
				E0qix9bumRp = new XBrush(W4hixGD2EM5);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90a598f03c844da79a9f9a1acc80d34f != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					return;
				}
				V2oixnhSeBb = new XPen(E0qix9bumRp, 1);
				OnPropertyChanged((string)kZ0tqZekQQnfkweZ6Khd(0x3E0426F0 ^ 0x3E04BF94));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderType")]
	[DataMember(Name = "BorderType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsBorder")]
	public ExternalChartBorderType BorderType
	{
		get
		{
			return hlBixYPY31X;
		}
		set
		{
			if (externalChartBorderType != hlBixYPY31X)
			{
				hlBixYPY31X = externalChartBorderType;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x706541F3 ^ 0x7065D889));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsBorder")]
	[DataMember(Name = "BorderWidth")]
	public int BorderWidth
	{
		get
		{
			return Sfmixoo86sF;
		}
		set
		{
			num = Math.Max(1, num);
			if (num == Sfmixoo86sF)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			else
			{
				Sfmixoo86sF = num;
				OnPropertyChanged((string)kZ0tqZekQQnfkweZ6Khd(0x7394D272 ^ 0x73944BE0));
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsBorder")]
	[DataMember(Name = "BorderColor")]
	public XColor BorderColor
	{
		get
		{
			return hjDixBmMkla;
		}
		set
		{
			if (!(xColor == hjDixBmMkla))
			{
				hjDixBmMkla = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ja5ixvokcda = new XBrush(hjDixBmMkla);
				OnPropertyChanged((string)kZ0tqZekQQnfkweZ6Khd(0x60620FC1 ^ 0x60629F4B));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnPriceChange;

	[SpecialName]
	private List<TifW9uiKBVCPiAo0SCkb> DD5iS3MQD7m()
	{
		return ALvixarqD6l ?? (ALvixarqD6l = new List<TifW9uiKBVCPiAo0SCkb>());
	}

	public HAvUBOiSq6xjpwBaI3bH()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				BorderWidth = 1;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b != 0)
				{
					num = 1;
				}
				continue;
			case 3:
				ShowIndicatorTitle = false;
				PeriodType = ExternalChartPeriodType.Hour;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5bc14e9093324ecc8c5d7e08f50abd26 == 0)
				{
					num = 0;
				}
				continue;
			case 2:
				BorderType = ExternalChartBorderType.ColoredBox;
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
				{
					num = 4;
				}
				continue;
			case 1:
				BorderColor = OY5Y1NekdujBVK8ygMtw(byte.MaxValue, 120, 120, 120);
				return;
			}
			PeriodValue = 1;
			ShowBack = true;
			BackColor = OY5Y1NekdujBVK8ygMtw(30, 70, 130, 180);
			ShowGrid = false;
			GridColor = veQlX1ekgH9rfZT0kQsf(Color.FromArgb(byte.MaxValue, 70, 130, 180));
			num = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_900fe0d7516743c1bc15292a67b06048 != 0)
			{
				num = 2;
			}
		}
	}

	private void Clear()
	{
		UI6ixiH6sDC = 0;
		DD5iS3MQD7m().Clear();
	}

	private int Vu7iSWKsvBg(DateTime P_0, double P_1)
	{
		ChartPeriodType type = ChartPeriodType.Hour;
		int num;
		switch (PeriodType)
		{
		case ExternalChartPeriodType.Day:
			type = ChartPeriodType.Day;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case ExternalChartPeriodType.Month:
			type = ChartPeriodType.Month;
			break;
		case ExternalChartPeriodType.Week:
			goto IL_006e;
		case ExternalChartPeriodType.Minute:
			goto IL_008d;
		case ExternalChartPeriodType.Hour:
			type = ChartPeriodType.Hour;
			break;
		default:
			{
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee != 0)
				{
					num = 2;
				}
				goto IL_0009;
			}
			IL_006e:
			type = ChartPeriodType.Week;
			break;
			IL_0009:
			switch (num)
			{
			case 3:
				break;
			default:
				goto IL_006e;
			case 4:
				goto IL_008d;
			case 1:
			case 2:
				goto end_IL_00eb;
			}
			goto case ExternalChartPeriodType.Month;
			IL_008d:
			type = ChartPeriodType.Minute;
			break;
			end_IL_00eb:
			break;
		}
		return base.DataProvider.Period.GetSequence(type, PeriodValue, P_0, P_1);
	}

	protected override void Execute()
	{
		int num;
		if (base.ClearData)
		{
			Clear();
			num = 9;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
			{
				num = 9;
			}
			goto IL_0009;
		}
		goto IL_028a;
		IL_028a:
		if (DD5iS3MQD7m().Count > 0 && !DD5iS3MQD7m()[DD5iS3MQD7m().Count - 1].gEqiK4LOP9F)
		{
			num = 7;
			goto IL_0009;
		}
		goto IL_0123;
		IL_0123:
		double num2 = UdOeDIek6k1WynukbTTw(base.DataProvider.Symbol.Exchange);
		int num3 = -1;
		num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
		{
			num = 1;
		}
		goto IL_0009;
		IL_0009:
		int num4 = default(int);
		int num5 = default(int);
		IChartCluster chartCluster = default(IChartCluster);
		while (true)
		{
			switch (num)
			{
			default:
				num4++;
				goto case 8;
			case 6:
				if (num4 > UI6ixiH6sDC)
				{
					num = 2;
					continue;
				}
				goto case 5;
			case 4:
				num3 = num5;
				if (DD5iS3MQD7m().Count > 0)
				{
					num = 6;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
					{
						num = 5;
					}
					continue;
				}
				goto case 5;
			case 5:
				DD5iS3MQD7m().Add(new TifW9uiKBVCPiAo0SCkb(num4));
				goto IL_0050;
			case 3:
				break;
			case 1:
				num4 = UI6ixiH6sDC;
				num = 8;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
				{
					num = 3;
				}
				continue;
			case 7:
				DD5iS3MQD7m().RemoveAt(I1IQDlekRe5MSaiGN2ie(DD5iS3MQD7m()) - 1);
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
				{
					num = 1;
				}
				continue;
			case 8:
				if (num4 < base.DataProvider.Count)
				{
					chartCluster = (IChartCluster)BdbUyRekMuqc67kSUypZ(base.DataProvider, num4);
					num5 = Vu7iSWKsvBg(chartCluster.Time, num2);
					if (DD5iS3MQD7m().Count == 0)
					{
						num = 4;
						continue;
					}
					if (num5 == num3)
					{
						goto IL_0050;
					}
					goto case 4;
				}
				return;
			case 2:
				UI6ixiH6sDC = num4;
				DD5iS3MQD7m()[I1IQDlekRe5MSaiGN2ie(DD5iS3MQD7m()) - 1].gEqiK4LOP9F = true;
				num = 5;
				continue;
			case 9:
				goto IL_028a;
				IL_0050:
				DD5iS3MQD7m()[I1IQDlekRe5MSaiGN2ie(DD5iS3MQD7m()) - 1].tFEiKaRxmvb(chartCluster, num4, base.DataProvider.Scale);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_0123;
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 4;
		int num2 = num;
		int num15 = default(int);
		double num16 = default(double);
		decimal num6 = default(decimal);
		decimal num20 = default(decimal);
		int num17 = default(int);
		List<TifW9uiKBVCPiAo0SCkb>.Enumerator enumerator = default(List<TifW9uiKBVCPiAo0SCkb>.Enumerator);
		int num3 = default(int);
		int num11 = default(int);
		int num7 = default(int);
		bool flag = default(bool);
		int num8 = default(int);
		XPen xPen = default(XPen);
		int num12 = default(int);
		int num14 = default(int);
		int num9 = default(int);
		int num5 = default(int);
		int num18 = default(int);
		int num10 = default(int);
		decimal num19 = default(decimal);
		XBrush brush = default(XBrush);
		double x = default(double);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num15 = base.Canvas.Stop + aVsAKcekqpv0gEfVcN3t(base.Canvas);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (DD5iS3MQD7m().Count != 0)
				{
					num2 = 3;
					break;
				}
				return;
			case 2:
				num16 = base.Canvas.ColumnWidth / 2.0;
				num6 = uD5wPjekIwVcYp3coUO9(num20, 2m);
				if (FQTXOdekWjhpKWYUJwcw(base.Canvas) != ChartStockType.Clusters && !ShowGrid)
				{
					num6 = default(decimal);
				}
				num17 = int.MinValue;
				enumerator = DD5iS3MQD7m().GetEnumerator();
				num2 = 5;
				break;
			default:
				num20 = (decimal)base.DataProvider.Step;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num3 = mgay5YekOQkvvgM2IeJn(base.Canvas);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				try
				{
					while (enumerator.MoveNext())
					{
						TifW9uiKBVCPiAo0SCkb current = enumerator.Current;
						if (current.ESIiKlnU92j < num3)
						{
							continue;
						}
						int num4 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
						{
							num4 = 3;
						}
						while (true)
						{
							double num13;
							XColor color;
							switch (num4)
							{
							case 7:
								if (num11 != current.SuHiKi9Lou0)
								{
									num4 = 4;
									continue;
								}
								num13 = num7;
								goto IL_07f7;
							case 5:
								flag = current.v9SiKDuqPH4 < current.Close;
								num8 = (int)GetY(current.DIEiKbsRHYD + num6);
								num4 = 11;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
								{
									num4 = 11;
								}
								continue;
							case 8:
								wbs0ZRekV7rBVk8X9pIY(P_0, xPen, new Rect(new Point(num7 + num12, num14), new Point(num9 - num12, num5)));
								P_0.DrawLine(xPen, new Point(num18, num8), new Point(num18, num14));
								P_0.DrawLine(xPen, new Point(num18, num5), new Point(num18, num10));
								num4 = 10;
								continue;
							case 16:
								num12 = (int)Math.Ceiling((double)Sfmixoo86sF / 2.0);
								num4 = 8;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
								{
									num4 = 6;
								}
								continue;
							case 23:
								if (!ShowGrid)
								{
									goto case 19;
								}
								num19 = current.DIEiKbsRHYD + num20;
								goto case 22;
							case 18:
								if (BorderType == ExternalChartBorderType.ColoredBox)
								{
									num4 = 2;
									continue;
								}
								goto IL_06c0;
							case 2:
								if (!flag)
								{
									num4 = 14;
									continue;
								}
								color = AcKQeHekZDoqtBaI3ai6(fucr1AekyeiEBLGNGAa2(base.Canvas));
								goto IL_0823;
							case 10:
							case 20:
								break;
							case 19:
								if (BorderType != ExternalChartBorderType.None)
								{
									brush = ja5ixvokcda;
									num4 = 9;
									continue;
								}
								break;
							case 3:
								if (current.SuHiKi9Lou0 <= num15)
								{
									double x2 = base.Canvas.GetX(current.SuHiKi9Lou0);
									double x3 = base.Canvas.GetX(current.ESIiKlnU92j);
									num7 = (int)(x2 - num16);
									num9 = (int)(x3 + num16 - 1.0);
									if (num17 != int.MinValue)
									{
										num7 = num17;
									}
									num17 = num9;
									num18 = (int)((x2 + x3) / 2.0);
									num4 = 5;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
									{
										num4 = 1;
									}
									continue;
								}
								break;
							case 14:
								color = base.Canvas.Theme.ClusterDownBarColor;
								goto IL_0823;
							case 13:
								P_0.DrawLine(V2oixnhSeBb, new Point(x, num8 - 1), new Point(x, num10));
								if (num11 == current.ESIiKlnU92j)
								{
									P_0.DrawLine(V2oixnhSeBb, new Point(num9, num8 - 1), new Point(num9, num10));
								}
								num11++;
								num4 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
								{
									num4 = 1;
								}
								continue;
							case 9:
								if (BorderType != ExternalChartBorderType.ColoredCandle)
								{
									num4 = 18;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 == 0)
									{
										num4 = 2;
									}
									continue;
								}
								goto case 2;
							case 4:
								num13 = base.Canvas.GetX(num11) - num16 - 1.0;
								goto IL_07f7;
							case 17:
								num11 = current.SuHiKi9Lou0;
								goto case 1;
							case 15:
								if (BorderType == ExternalChartBorderType.Candle)
								{
									goto case 16;
								}
								if (BorderType != ExternalChartBorderType.ColoredCandle)
								{
									if (BorderType != ExternalChartBorderType.Box)
									{
										num4 = 0;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7718f96c0b7741f0ab4250d28233bddf == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 6;
								}
								num4 = 12;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
								{
									num4 = 16;
								}
								continue;
							case 11:
								num10 = (int)GetY(current.NG8iKN2XdPF - num6);
								num14 = (flag ? ((int)GetY(X0OXQDektiurHTXneAxI(current.Close, num6))) : ((int)GetY(current.v9SiKDuqPH4 + num6)));
								num4 = 21;
								continue;
							case 6:
							{
								int num21 = (int)Math.Ceiling((double)Sfmixoo86sF / 2.0);
								P_0.DrawRectangle(xPen, new Rect(new Point(num7 + num21, num8), new Point(num9 - num21, num10)));
								num4 = 20;
								continue;
							}
							case 21:
								num5 = ((!flag) ? ((int)GetY(current.Close - num6)) : ((int)GetY(yviB1FekUhqhxTCcdK0Q(current.v9SiKDuqPH4, num6))));
								if (ShowBack)
								{
									FyRoXVekTtSR6jYWcuMi(P_0, DOcix2Nwmbu, new Rect(new Point(num7, num8 - 1), new Point(num9, num10)));
									num4 = 23;
									continue;
								}
								goto case 23;
							case 22:
								if (!(num19 >= current.NG8iKN2XdPF))
								{
									num4 = 17;
									continue;
								}
								goto case 12;
							default:
								if (BorderType == ExternalChartBorderType.ColoredBox)
								{
									num4 = 6;
									continue;
								}
								break;
							case 12:
							{
								int num22 = (int)GetY(yviB1FekUhqhxTCcdK0Q(num19, num20 / 2m)) - 1;
								P_0.DrawLine(V2oixnhSeBb, new Point(num7, num22), new Point(num9, num22));
								num19 = yviB1FekUhqhxTCcdK0Q(num19, num20);
								num4 = 22;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4c510febac3445efbec11458d423f537 == 0)
								{
									num4 = 10;
								}
								continue;
							}
							case 1:
								{
									if (num11 > current.ESIiKlnU92j)
									{
										num4 = 19;
										if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
										{
											num4 = 10;
										}
										continue;
									}
									goto case 7;
								}
								IL_07f7:
								x = num13;
								num4 = 6;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e767fb04e1fb471592fd70a4ebcca575 == 0)
								{
									num4 = 13;
								}
								continue;
								IL_06c0:
								xPen = new XPen(brush, BorderWidth);
								num4 = 14;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
								{
									num4 = 15;
								}
								continue;
								IL_0823:
								brush = new XBrush(color);
								goto IL_06c0;
							}
							break;
						}
					}
					return;
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		HAvUBOiSq6xjpwBaI3bH hAvUBOiSq6xjpwBaI3bH = (HAvUBOiSq6xjpwBaI3bH)P_0;
		PeriodType = hAvUBOiSq6xjpwBaI3bH.PeriodType;
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				base.CopyTemplate(P_0, P_1);
				return;
			default:
				PeriodValue = uBVngRekC5RJgmZbGyw8(hAvUBOiSq6xjpwBaI3bH);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
				{
					num = 1;
				}
				break;
			case 2:
				GridColor = hAvUBOiSq6xjpwBaI3bH.GridColor;
				BorderType = hAvUBOiSq6xjpwBaI3bH.BorderType;
				BorderWidth = QIGMivekKBaExe58YSRm(hAvUBOiSq6xjpwBaI3bH);
				BorderColor = hAvUBOiSq6xjpwBaI3bH.BorderColor;
				num = 3;
				break;
			case 1:
				ShowBack = hAvUBOiSq6xjpwBaI3bH.ShowBack;
				BackColor = FenYTJekrr6n03dpfMgs(hAvUBOiSq6xjpwBaI3bH);
				ShowGrid = hAvUBOiSq6xjpwBaI3bH.ShowGrid;
				num = 2;
				break;
			}
		}
	}

	static HAvUBOiSq6xjpwBaI3bH()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool gfQGLDekjkCg0aTd2MwP()
	{
		return uZNWuZekcPDNFAoGUktb == null;
	}

	internal static HAvUBOiSq6xjpwBaI3bH wIMLVvekE9rEATeHqyfS()
	{
		return uZNWuZekcPDNFAoGUktb;
	}

	internal static object kZ0tqZekQQnfkweZ6Khd(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static Color OY5Y1NekdujBVK8ygMtw(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static XColor veQlX1ekgH9rfZT0kQsf(Color P_0)
	{
		return P_0;
	}

	internal static int I1IQDlekRe5MSaiGN2ie(object P_0)
	{
		return ((List<TifW9uiKBVCPiAo0SCkb>)P_0).Count;
	}

	internal static double UdOeDIek6k1WynukbTTw(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static object BdbUyRekMuqc67kSUypZ(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetCluster(i);
	}

	internal static int mgay5YekOQkvvgM2IeJn(object P_0)
	{
		return ((IChartCanvas)P_0).Stop;
	}

	internal static int aVsAKcekqpv0gEfVcN3t(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static decimal uD5wPjekIwVcYp3coUO9(decimal P_0, decimal P_1)
	{
		return P_0 / P_1;
	}

	internal static ChartStockType FQTXOdekWjhpKWYUJwcw(object P_0)
	{
		return ((IChartCanvas)P_0).StockType;
	}

	internal static decimal X0OXQDektiurHTXneAxI(decimal P_0, decimal P_1)
	{
		return P_0 + P_1;
	}

	internal static decimal yviB1FekUhqhxTCcdK0Q(decimal P_0, decimal P_1)
	{
		return P_0 - P_1;
	}

	internal static void FyRoXVekTtSR6jYWcuMi(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static object fucr1AekyeiEBLGNGAa2(object P_0)
	{
		return ((IChartCanvas)P_0).Theme;
	}

	internal static XColor AcKQeHekZDoqtBaI3ai6(object P_0)
	{
		return ((IChartTheme)P_0).ClusterUpBarColor;
	}

	internal static void wbs0ZRekV7rBVk8X9pIY(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).DrawRectangle((XPen)P_1, P_2);
	}

	internal static int uBVngRekC5RJgmZbGyw8(object P_0)
	{
		return ((HAvUBOiSq6xjpwBaI3bH)P_0).PeriodValue;
	}

	internal static XColor FenYTJekrr6n03dpfMgs(object P_0)
	{
		return ((HAvUBOiSq6xjpwBaI3bH)P_0).BackColor;
	}

	internal static int QIGMivekKBaExe58YSRm(object P_0)
	{
		return ((HAvUBOiSq6xjpwBaI3bH)P_0).BorderWidth;
	}
}
