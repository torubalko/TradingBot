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
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Drawings;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace NrKJsUieMVD6SNrtVixc;

[Indicator("Pivots", "Pivots", true, Type = typeof(VCJB32ie6fq7xLWs9D1G))]
[DataContract(Name = "PivotsIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class VCJB32ie6fq7xLWs9D1G : IndicatorBase
{
	private class jL0LsCiKs7bCTX4UMeQe
	{
		public double PWUiKXuhbyB;

		public double cooiKchjSkr;

		public double L9iiKj8SugA;

		public double UuBiKENGyvV;

		public double MrviKQweFCM;

		public double QDBiKdVllgU;

		public double wbNiKgXSF70;

		public double VKqiKRTTi1s;

		public double siFiK6Gwdot;

		public int StUiKM3gTSR;

		public int z2FiKOI7HvZ;

		internal static jL0LsCiKs7bCTX4UMeQe X0U1jkeUI9b7UDrZcoZQ;

		public jL0LsCiKs7bCTX4UMeQe()
		{
			jcbyTheUUQe2FpylViI0();
			base._002Ector();
		}

		static jL0LsCiKs7bCTX4UMeQe()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static void jcbyTheUUQe2FpylViI0()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		}

		internal static bool QMfrUReUWC2AqsTwTBcd()
		{
			return X0U1jkeUI9b7UDrZcoZQ == null;
		}

		internal static jL0LsCiKs7bCTX4UMeQe BHJqiJeUtaJGhmmIU7Co()
		{
			return X0U1jkeUI9b7UDrZcoZQ;
		}
	}

	private PivotPeriodType PdfissmCjHG;

	private int F9hisXGHQSm;

	private int a3XiscTZBqJ;

	private PivotCalculationType NwuisjvuGSt;

	private double zFkisEelMlj;

	private double ApTisQcPaag;

	private double qadisdp2Yec;

	private double jZVisgbgp1v;

	private XColor mmiisREbLDH;

	private XColor vtNis6rd0pk;

	private XColor cOpisMFHh5B;

	private XColor ikZisOwpy29;

	private XColor PsGisqlFv9d;

	private XColor grUisIw7CmL;

	private XColor XGXisWkKmZY;

	private XColor nLTistidJct;

	private ChartLine WhGisUvrBjY;

	private ChartLine FyPisTyRv7Q;

	private ChartLine G2Uisy53sai;

	private ChartLine j7MisZ8rDX7;

	private ChartLine z4bisV19AbO;

	private ChartLine FiPisCWB3aB;

	private ChartLine BWsisrQ5NSk;

	private ChartLine yUYisKeCsKU;

	private ChartLine Uhqismhhoh7;

	private List<jL0LsCiKs7bCTX4UMeQe> uaoish3R0Yt;

	private double ktViswEyiLJ;

	private double DjLis7EUk3P;

	private double XtLis8YaR6M;

	private double gMAisAPvDl8;

	private int rYWisPqOKFF;

	private List<IndicatorLabelInfo> NdMisJQKN9i;

	private int FfQisFYK5pg;

	internal static VCJB32ie6fq7xLWs9D1G p65qZbe5V0rVe0GlepjA;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DataMember(Name = "PeriodType")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodType")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	public PivotPeriodType PeriodType
	{
		get
		{
			return PdfissmCjHG;
		}
		set
		{
			if (pivotPeriodType == PdfissmCjHG)
			{
				return;
			}
			PdfissmCjHG = pivotPeriodType;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_14b81aa01f3b465ba9caee83d494621b == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					Clear();
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522671497));
					return;
				case 1:
					F9hisXGHQSm = ((PdfissmCjHG != PivotPeriodType.Minute) ? 1 : 15);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "PeriodValue")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriodValue")]
	public int PeriodValue
	{
		get
		{
			return F9hisXGHQSm;
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
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2002318893 ^ -2002284303));
					return;
				}
				if (num3 == F9hisXGHQSm)
				{
					return;
				}
				F9hisXGHQSm = num3;
				Clear();
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorPeriodsCount")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsPeriod")]
	[DataMember(Name = "PeriodsCount")]
	public int PeriodsCount
	{
		get
		{
			return a3XiscTZBqJ;
		}
		set
		{
			num = Math.Max(0, num);
			int num2;
			if (num != a3XiscTZBqJ)
			{
				a3XiscTZBqJ = num;
				Clear();
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-1962651919 ^ -1962618331));
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
				{
					num2 = 1;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				break;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorCalculationMethod")]
	[DataMember(Name = "Method")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public PivotCalculationType CalculationMethod
	{
		get
		{
			return NwuisjvuGSt;
		}
		set
		{
			if (pivotCalculationType == NwuisjvuGSt)
			{
				return;
			}
			NwuisjvuGSt = pivotCalculationType;
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						Clear();
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
						{
							num2 = 1;
						}
						continue;
					case 6:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181374968));
						return;
					case 4:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056680618));
						num2 = 1;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
						{
							num2 = 5;
						}
						continue;
					case 7:
						break;
					case 1:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--871424829 ^ 0x33F07FCD));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522670485));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1047165041 ^ -1047192919));
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x1487846E ^ 0x14871958));
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x37B74BDF ^ 0x37B7D699));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x50C1C840 ^ 0x50C15516));
						num2 = 7;
						continue;
					case 3:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x34407BB ^ 0x3449ACD));
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
						{
							num2 = 0;
						}
						continue;
					default:
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x4297C3EB ^ 0x42975E6D));
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x746ED405 ^ 0x746E4993));
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x5CD4F15 ^ 0x5CDD2B3));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-342738082 ^ -342710552));
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-490987856 ^ -490962058));
						num2 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
						{
							num2 = 4;
						}
						continue;
					case 5:
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1841489831 ^ -1841461833));
						OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-82860344 ^ -82888498));
						num2 = 6;
						continue;
					}
					break;
				}
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(--146713930 ^ 0x8BE302C));
				num = 3;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorFibonacci", "1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Fibonacci1")]
	public double Fibonacci1
	{
		get
		{
			return zFkisEelMlj;
		}
		set
		{
			num = Math.Max(0.0, num);
			int num2;
			if (num != zFkisEelMlj)
			{
				zFkisEelMlj = num;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7e45d53bf40748f9915553e145413be0 != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 0:
				break;
			case 1:
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1311293279 ^ -1311253129));
				break;
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorFibonacci", "2")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Fibonacci2")]
	public double Fibonacci2
	{
		get
		{
			return ApTisQcPaag;
		}
		set
		{
			num = Math.Max(0.0, num);
			if (num == ApTisQcPaag)
			{
				return;
			}
			ApTisQcPaag = num;
			int num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
			{
				num2 = 0;
			}
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					Clear();
					OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x446AB724 ^ 0x446A2ACA));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "Fibonacci3")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorFibonacci", "3")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public double Fibonacci3
	{
		get
		{
			return qadisdp2Yec;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					num3 = fkd3vDe5me5IycaW2jHo(0.0, num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					if (num3 != qadisdp2Yec)
					{
						qadisdp2Yec = num3;
						Clear();
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xAD5B8B3 ^ 0xAD526B5));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorFibonacci", "4")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Fibonacci4")]
	public double Fibonacci4
	{
		get
		{
			return jZVisgbgp1v;
		}
		set
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (num3 == jZVisgbgp1v)
					{
						return;
					}
					jZVisgbgp1v = num3;
					Clear();
					OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-2123795572 ^ -2123764334));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					num3 = Math.Max(0.0, num3);
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "R4")]
	[DataMember(Name = "R4Zone")]
	public XColor R4Zone
	{
		get
		{
			return mmiisREbLDH;
		}
		set
		{
			if (!kBgjqVe5hywJb10AqXyf(xColor, mmiisREbLDH))
			{
				mmiisREbLDH = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ff7ea8439ae74c169eea85409be2ee21 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-1087080834 ^ -1087050824));
			}
		}
	}

	[DataMember(Name = "R3Zone")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "R3")]
	public XColor R3Zone
	{
		get
		{
			return vtNis6rd0pk;
		}
		set
		{
			if (!(xColor == vtNis6rd0pk))
			{
				vtNis6rd0pk = xColor;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x34407BB ^ 0x3449A0D));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
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

	[DataMember(Name = "R2Zone")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "R2")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor R2Zone
	{
		get
		{
			return cOpisMFHh5B;
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
				case 1:
					if (xColor == cOpisMFHh5B)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7d6ed381220347c0b7bad07060beb773 != 0)
						{
							num2 = 0;
						}
						break;
					}
					cOpisMFHh5B = xColor;
					OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(0x1AB79299 ^ 0x1AB70F3F));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "R1Zone")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "R1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor R1Zone
	{
		get
		{
			return ikZisOwpy29;
		}
		set
		{
			if (!(xColor == ikZisOwpy29))
			{
				ikZisOwpy29 = xColor;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1878953018 ^ -1878921744));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
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

	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "S1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "S1Zone")]
	public XColor S1Zone
	{
		get
		{
			return PsGisqlFv9d;
		}
		set
		{
			if (!kBgjqVe5hywJb10AqXyf(xColor, PsGisqlFv9d))
			{
				PsGisqlFv9d = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530016673));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "S2")]
	[DataMember(Name = "S2Zone")]
	public XColor S2Zone
	{
		get
		{
			return grUisIw7CmL;
		}
		set
		{
			if (!kBgjqVe5hywJb10AqXyf(xColor, grUisIw7CmL))
			{
				grUisIw7CmL = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x22BF43FC ^ 0x22BFDE8A));
			}
		}
	}

	[DataMember(Name = "S3Zone")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "S3")]
	public XColor S3Zone
	{
		get
		{
			return XGXisWkKmZY;
		}
		set
		{
			if (!kBgjqVe5hywJb10AqXyf(xColor, XGXisWkKmZY))
			{
				XGXisWkKmZY = xColor;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_03398ebbe6224bea83047c33d24affe2 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-448941864 ^ -448975522));
			}
		}
	}

	[DataMember(Name = "S4Zone")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorZone", "S4")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public XColor S4Zone
	{
		get
		{
			return nLTistidJct;
		}
		set
		{
			if (!(xColor == nLTistidJct))
			{
				nLTistidJct = xColor;
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-3429745 ^ -3459303));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 != 0)
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

	[DataMember(Name = "R4Line")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "R4")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartLine R4Line
	{
		get
		{
			ChartLine chartLine = WhGisUvrBjY;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = Colors.Green
				};
				zyYAH3e5wdWYt2dmGwnc(obj, 1);
				obj.Style = XDashStyle.Dash;
				ChartLine chartLine2 = obj;
				WhGisUvrBjY = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (!object.Equals(chartLine, WhGisUvrBjY))
			{
				WhGisUvrBjY = chartLine;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x7ADBF691 ^ 0x7ADB6BF7));
			}
		}
	}

	[DataMember(Name = "R3Line")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "R3")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartLine R3Line
	{
		get
		{
			ChartLine chartLine = FyPisTyRv7Q;
			if (chartLine == null)
			{
				ChartLine chartLine2 = new ChartLine();
				NZ9eWye57RUdxoTgWxPM(chartLine2, Colors.Green);
				chartLine2.Width = 1;
				chartLine2.Style = XDashStyle.Dash;
				ChartLine chartLine3 = chartLine2;
				FyPisTyRv7Q = chartLine2;
				chartLine = chartLine3;
			}
			return chartLine;
		}
		private set
		{
			if (!object.Equals(chartLine, FyPisTyRv7Q))
			{
				FyPisTyRv7Q = chartLine;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-1380525184 ^ -1380563242));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "R2Line")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "R2")]
	public ChartLine R2Line
	{
		get
		{
			ChartLine chartLine = G2Uisy53sai;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = Colors.Green
				};
				zyYAH3e5wdWYt2dmGwnc(obj, 1);
				PJnhd9e58ol4fZKxjxyu(obj, XDashStyle.Dash);
				ChartLine chartLine2 = obj;
				G2Uisy53sai = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (!object.Equals(chartLine, G2Uisy53sai))
			{
				G2Uisy53sai = chartLine;
				Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(--134855371 ^ 0x809278D));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "R1Line")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "R1")]
	public ChartLine R1Line
	{
		get
		{
			ChartLine chartLine = j7MisZ8rDX7;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = Lh616ke5AEfWaeiAjwoD(),
					Width = 1,
					Style = XDashStyle.Dash
				};
				ChartLine chartLine2 = obj;
				j7MisZ8rDX7 = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (!object.Equals(objA, j7MisZ8rDX7))
			{
				j7MisZ8rDX7 = objA;
				Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x4220DA8 ^ 0x42293FE));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[DataMember(Name = "PPLine")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "PP")]
	public ChartLine PPLine
	{
		get
		{
			ChartLine chartLine = z4bisV19AbO;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = Colors.Orange,
					Width = 1,
					Style = XDashStyle.Dash
				};
				ChartLine chartLine2 = obj;
				z4bisV19AbO = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (i3uuTFe5PomyT9rmcWYR(chartLine, z4bisV19AbO))
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
						{
							num2 = 0;
						}
						break;
					}
					z4bisV19AbO = chartLine;
					Clear();
					OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-602153869 ^ -602193387));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "S1Line")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "S1")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	public ChartLine S1Line
	{
		get
		{
			ChartLine chartLine = FiPisCWB3aB;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = a5hZFse5JK2uSLrXb09Q(Colors.Red)
				};
				zyYAH3e5wdWYt2dmGwnc(obj, 1);
				PJnhd9e58ol4fZKxjxyu(obj, XDashStyle.Dash);
				ChartLine chartLine2 = obj;
				FiPisCWB3aB = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
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
				case 1:
					if (!i3uuTFe5PomyT9rmcWYR(chartLine, FiPisCWB3aB))
					{
						FiPisCWB3aB = chartLine;
						Clear();
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6D18F862 ^ 0x6D186614));
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "S2Line")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "S2")]
	public ChartLine S2Line
	{
		get
		{
			ChartLine chartLine = BWsisrQ5NSk;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = a5hZFse5JK2uSLrXb09Q(Colors.Red)
				};
				zyYAH3e5wdWYt2dmGwnc(obj, 1);
				obj.Style = XDashStyle.Dash;
				ChartLine chartLine2 = obj;
				BWsisrQ5NSk = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (!object.Equals(chartLine, BWsisrQ5NSk))
			{
				BWsisrQ5NSk = chartLine;
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-123775059 ^ -123745605));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "S3")]
	[DataMember(Name = "S3Line")]
	public ChartLine S3Line
	{
		get
		{
			ChartLine chartLine = yUYisKeCsKU;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = a5hZFse5JK2uSLrXb09Q(YlXJUEe5FRU3C97BPLWs()),
					Width = 1
				};
				PJnhd9e58ol4fZKxjxyu(obj, XDashStyle.Dash);
				ChartLine chartLine2 = obj;
				yUYisKeCsKU = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (object.Equals(objA, yUYisKeCsKU))
			{
				return;
			}
			yUYisKeCsKU = objA;
			Clear();
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
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
					OnPropertyChanged((string)qMpHi8e5KKJLrfh1Jrxe(-1346994499 ^ -1346968677));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "S4Line")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsCharts")]
	[ye30Hki4oR4RQBdkwwe7("PivotsIndicatorLine", "S4")]
	public ChartLine S4Line
	{
		get
		{
			ChartLine chartLine = Uhqismhhoh7;
			if (chartLine == null)
			{
				ChartLine obj = new ChartLine
				{
					Color = Colors.Red,
					Width = 1
				};
				PJnhd9e58ol4fZKxjxyu(obj, XDashStyle.Dash);
				ChartLine chartLine2 = obj;
				Uhqismhhoh7 = obj;
				chartLine = chartLine2;
			}
			return chartLine;
		}
		private set
		{
			if (i3uuTFe5PomyT9rmcWYR(chartLine, Uhqismhhoh7))
			{
				return;
			}
			Uhqismhhoh7 = chartLine;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
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
				Clear();
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31AD7E));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num = 1;
				}
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnBarClose;

	public VCJB32ie6fq7xLWs9D1G()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 5;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 == 0)
		{
			num = 4;
		}
		while (true)
		{
			int num2;
			switch (num)
			{
			case 6:
				CalculationMethod = PivotCalculationType.Classic;
				num2 = 7;
				goto IL_002f;
			case 1:
				S3Zone = Color.FromArgb(50, byte.MaxValue, 50, 50);
				S4Zone = a5hZFse5JK2uSLrXb09Q(wg4vvSe53sbiXBl3HTeg(50, byte.MaxValue, 0, 0));
				num = 3;
				break;
			case 3:
				return;
			case 2:
				PeriodType = PivotPeriodType.Hour;
				PeriodValue = 1;
				PeriodsCount = 0;
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc == 0)
				{
					num = 6;
				}
				break;
			case 5:
				ShowIndicatorTitle = false;
				num = 2;
				break;
			case 7:
				Fibonacci1 = 0.382;
				Fibonacci2 = 0.618;
				Fibonacci3 = 1.0;
				Fibonacci4 = 1.618;
				R4Zone = a5hZFse5JK2uSLrXb09Q(Color.FromArgb(50, 0, 205, 0));
				R3Zone = Color.FromArgb(50, 50, 205, 50);
				R2Zone = Color.FromArgb(50, 100, 205, 100);
				R1Zone = wg4vvSe53sbiXBl3HTeg(50, 150, 205, 150);
				S1Zone = a5hZFse5JK2uSLrXb09Q(wg4vvSe53sbiXBl3HTeg(50, byte.MaxValue, 150, 150));
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f02aef63891d4dd388caae3711d082ae == 0)
				{
					num = 0;
				}
				break;
			default:
				S1Zone = Color.FromArgb(50, byte.MaxValue, 150, 150);
				num2 = 4;
				goto IL_002f;
			case 4:
				{
					S2Zone = Color.FromArgb(50, byte.MaxValue, 100, 100);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 != 0)
					{
						num = 1;
					}
					break;
				}
				IL_002f:
				num = num2;
				break;
			}
		}
	}

	protected override void Execute()
	{
		int num = 16;
		int num3 = default(int);
		double num4 = default(double);
		int num5 = default(int);
		IRawCluster rawCluster = default(IRawCluster);
		double num7 = default(double);
		IChartDataProvider dataProvider = default(IChartDataProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				double num6;
				switch (num2)
				{
				case 11:
					return;
				case 16:
					if (base.ClearData)
					{
						num2 = 15;
						continue;
					}
					goto IL_0581;
				case 15:
					Clear();
					goto IL_0581;
				case 17:
					gMAisAPvDl8 = 0.0;
					goto IL_068d;
				case 2:
				case 14:
					uaoish3R0Yt.Add(new jL0LsCiKs7bCTX4UMeQe
					{
						StUiKM3gTSR = num3,
						z2FiKOI7HvZ = 0,
						MrviKQweFCM = num4 / 4.0,
						QDBiKdVllgU = num4 / 2.0 - ktViswEyiLJ,
						UuBiKENGyvV = num4 / 2.0 - DjLis7EUk3P,
						wbNiKgXSF70 = -1.0,
						L9iiKj8SugA = -1.0,
						VKqiKRTTi1s = -1.0,
						cooiKchjSkr = -1.0,
						siFiK6Gwdot = -1.0,
						PWUiKXuhbyB = -1.0
					});
					goto case 3;
				default:
					num5 = Wc1ieOuj7vS(rawCluster.Time, num7);
					num2 = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					if (Jr9eGYe5p6R3wk0NYpbW(dataProvider) == 0)
					{
						return;
					}
					if (uaoish3R0Yt != null)
					{
						num2 = 9;
						continue;
					}
					uaoish3R0Yt = new List<jL0LsCiKs7bCTX4UMeQe>();
					goto case 9;
				case 4:
					num4 = 2.0 * ktViswEyiLJ + DjLis7EUk3P + XtLis8YaR6M;
					num = 14;
					break;
				case 10:
					num3 = FfQisFYK5pg;
					goto IL_061a;
				case 13:
					rawCluster = base.DataProvider.GetRawCluster(num3);
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					DjLis7EUk3P = double.MaxValue;
					XtLis8YaR6M = 0.0;
					num2 = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8bad63f401844feb8b319ab89401e7b9 != 0)
					{
						num2 = 16;
					}
					continue;
				case 9:
					num7 = P5C1t1e5zQLVapoOQ4bs(iVbVLJe5ubqoPOiJnvqu(base.DataProvider.Symbol));
					num = 10;
					break;
				case 8:
				case 19:
					dataProvider = base.DataProvider;
					num2 = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd == 0)
					{
						num2 = 1;
					}
					continue;
				case 12:
					num6 = ktViswEyiLJ - DjLis7EUk3P;
					switch (CalculationMethod)
					{
					case PivotCalculationType.DeMark:
						break;
					case PivotCalculationType.Woodie:
						goto IL_00ea;
					case PivotCalculationType.Camarilla:
						goto IL_031e;
					default:
						goto IL_05b1;
					case PivotCalculationType.Fibonacci:
						goto IL_072a;
					case PivotCalculationType.Classic:
						goto IL_0805;
					}
					if (XtLis8YaR6M > gMAisAPvDl8)
					{
						num2 = 4;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_67043cdb3e78411cabdcd8aaa5ac8bc4 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					if (XtLis8YaR6M < gMAisAPvDl8)
					{
						num4 = ktViswEyiLJ + 2.0 * DjLis7EUk3P + XtLis8YaR6M;
					}
					else if (XtLis8YaR6M == gMAisAPvDl8)
					{
						num4 = ktViswEyiLJ + DjLis7EUk3P + 2.0 * XtLis8YaR6M;
						num2 = 2;
						continue;
					}
					goto case 2;
				case 3:
				case 21:
				case 23:
					FfQisFYK5pg = num3;
					ktViswEyiLJ = double.MinValue;
					num = 7;
					break;
				case 5:
					if (num5 != rYWisPqOKFF)
					{
						if (QZRAKCeS0U5TpKfZ4aYA(uaoish3R0Yt) > 0)
						{
							uaoish3R0Yt[uaoish3R0Yt.Count - 1].z2FiKOI7HvZ = num3 - 1;
						}
						rYWisPqOKFF = num5;
						if (num3 > FfQisFYK5pg)
						{
							num4 = (ktViswEyiLJ + DjLis7EUk3P + XtLis8YaR6M) / 3.0;
							num2 = 12;
							continue;
						}
						goto IL_068d;
					}
					goto case 20;
				case 24:
					XtLis8YaR6M = (double)rawCluster.Close * Qh7a4OeS2fRTGHE0IaPg(dataProvider);
					num2 = 18;
					continue;
				case 20:
					ktViswEyiLJ = Math.Max(ktViswEyiLJ, (double)rawCluster.High * Qh7a4OeS2fRTGHE0IaPg(dataProvider));
					DjLis7EUk3P = Math.Min(DjLis7EUk3P, (double)q3bBHPeSHpxQu39SPUAV(rawCluster) * dataProvider.Step);
					num2 = 24;
					continue;
				case 22:
					NdMisJQKN9i = new List<IndicatorLabelInfo>();
					num2 = 8;
					continue;
				case 6:
					uaoish3R0Yt.Add(new jL0LsCiKs7bCTX4UMeQe
					{
						StUiKM3gTSR = num3,
						z2FiKOI7HvZ = 0,
						MrviKQweFCM = num4,
						QDBiKdVllgU = num4 * 2.0 - ktViswEyiLJ,
						UuBiKENGyvV = num4 * 2.0 - DjLis7EUk3P,
						wbNiKgXSF70 = num4 - ktViswEyiLJ + DjLis7EUk3P,
						L9iiKj8SugA = num4 + ktViswEyiLJ - DjLis7EUk3P,
						VKqiKRTTi1s = -1.0,
						cooiKchjSkr = -1.0,
						siFiK6Gwdot = -1.0,
						PWUiKXuhbyB = -1.0
					});
					goto case 3;
				case 18:
					{
						num3++;
						goto IL_061a;
					}
					IL_061a:
					if (num3 >= dataProvider.Count - 1)
					{
						num2 = 11;
						continue;
					}
					goto case 13;
					IL_068d:
					gMAisAPvDl8 = (double)rawCluster.Open * dataProvider.Step;
					num2 = 20;
					continue;
					IL_0805:
					uaoish3R0Yt.Add(new jL0LsCiKs7bCTX4UMeQe
					{
						StUiKM3gTSR = num3,
						z2FiKOI7HvZ = 0,
						MrviKQweFCM = num4,
						QDBiKdVllgU = num4 * 2.0 - ktViswEyiLJ,
						UuBiKENGyvV = num4 * 2.0 - DjLis7EUk3P,
						wbNiKgXSF70 = num4 - num6,
						L9iiKj8SugA = num4 + num6,
						VKqiKRTTi1s = DjLis7EUk3P - 2.0 * (ktViswEyiLJ - num4),
						cooiKchjSkr = ktViswEyiLJ + 2.0 * (num4 - DjLis7EUk3P),
						siFiK6Gwdot = -1.0,
						PWUiKXuhbyB = -1.0
					});
					num2 = 3;
					continue;
					IL_072a:
					uaoish3R0Yt.Add(new jL0LsCiKs7bCTX4UMeQe
					{
						StUiKM3gTSR = num3,
						z2FiKOI7HvZ = 0,
						MrviKQweFCM = num4,
						UuBiKENGyvV = num4 + num6 * zFkisEelMlj,
						L9iiKj8SugA = num4 + num6 * ApTisQcPaag,
						cooiKchjSkr = num4 + num6 * qadisdp2Yec,
						PWUiKXuhbyB = num4 + num6 * jZVisgbgp1v,
						QDBiKdVllgU = num4 - num6 * zFkisEelMlj,
						wbNiKgXSF70 = num4 - num6 * ApTisQcPaag,
						VKqiKRTTi1s = num4 - num6 * qadisdp2Yec,
						siFiK6Gwdot = num4 - num6 * jZVisgbgp1v
					});
					num2 = 5;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee != 0)
					{
						num2 = 23;
					}
					continue;
					IL_0581:
					if (NdMisJQKN9i != null)
					{
						num2 = 19;
						continue;
					}
					goto case 22;
					IL_05b1:
					num2 = 21;
					continue;
					IL_031e:
					uaoish3R0Yt.Add(new jL0LsCiKs7bCTX4UMeQe
					{
						StUiKM3gTSR = num3,
						z2FiKOI7HvZ = 0,
						MrviKQweFCM = -1.0,
						UuBiKENGyvV = XtLis8YaR6M + num6 * 1.1 / 12.0,
						L9iiKj8SugA = XtLis8YaR6M + num6 * 1.1 / 6.0,
						cooiKchjSkr = XtLis8YaR6M + num6 * 1.1 / 4.0,
						PWUiKXuhbyB = XtLis8YaR6M + num6 * 1.1 / 2.0,
						QDBiKdVllgU = XtLis8YaR6M - num6 * 1.1 / 12.0,
						wbNiKgXSF70 = XtLis8YaR6M - num6 * 1.1 / 6.0,
						VKqiKRTTi1s = XtLis8YaR6M - num6 * 1.1 / 4.0,
						siFiK6Gwdot = XtLis8YaR6M - num6 * 1.1 / 2.0
					});
					goto case 3;
					IL_00ea:
					num4 = (ktViswEyiLJ + DjLis7EUk3P + 2.0 * XtLis8YaR6M) / 4.0;
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	private int Wc1ieOuj7vS(DateTime P_0, double P_1)
	{
		int num = 1;
		int num2 = num;
		ChartPeriodType type = default(ChartPeriodType);
		PivotPeriodType pivotPeriodType = default(PivotPeriodType);
		while (true)
		{
			switch (num2)
			{
			case 4:
			case 5:
				return Vx4OgIeSfRlQuYSnuU1X(base.DataProvider.Period, type, PeriodValue, P_0, P_1);
			case 1:
				type = ChartPeriodType.Hour;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				pivotPeriodType = PeriodType;
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				goto IL_00d3;
			case 2:
				{
					switch (pivotPeriodType)
					{
					case PivotPeriodType.Day:
						type = ChartPeriodType.Day;
						break;
					case PivotPeriodType.Hour:
						goto IL_00d3;
					case PivotPeriodType.Week:
						goto IL_00e5;
					case PivotPeriodType.Month:
						goto IL_00f2;
					case PivotPeriodType.Minute:
						type = ChartPeriodType.Minute;
						break;
					}
					goto case 4;
				}
				IL_00f2:
				type = ChartPeriodType.Month;
				num2 = 5;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_7618de9239454b7793ef28219529e5f8 == 0)
				{
					num2 = 5;
				}
				break;
				IL_00e5:
				type = ChartPeriodType.Week;
				num2 = 4;
				break;
				IL_00d3:
				type = ChartPeriodType.Hour;
				goto case 4;
			}
		}
	}

	private void Clear()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				XtLis8YaR6M = 0.0;
				uaoish3R0Yt = null;
				rYWisPqOKFF = -1;
				return;
			case 2:
				NdMisJQKN9i = null;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_849738dd5158436baf2d7aeadba27136 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				FfQisFYK5pg = 0;
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f != 0)
				{
					num2 = 2;
				}
				continue;
			}
			ktViswEyiLJ = double.MinValue;
			DjLis7EUk3P = double.MaxValue;
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
			{
				num2 = 0;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		if (uaoish3R0Yt == null)
		{
			return;
		}
		int num = thcfHmeS9M9AH9mwMknr(base.Canvas, base.Canvas.Count - 1);
		int num2 = 2;
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		List<jL0LsCiKs7bCTX4UMeQe>.Enumerator enumerator = default(List<jL0LsCiKs7bCTX4UMeQe>.Enumerator);
		jL0LsCiKs7bCTX4UMeQe current = default(jL0LsCiKs7bCTX4UMeQe);
		double num8 = default(double);
		ChartLine chartLine6 = default(ChartLine);
		ChartLine chartLine4 = default(ChartLine);
		double num7 = default(double);
		ChartLine chartLine5 = default(ChartLine);
		ChartLine chartLine7 = default(ChartLine);
		ChartLine chartLine10 = default(ChartLine);
		ChartLine chartLine11 = default(ChartLine);
		ChartLine chartLine2 = default(ChartLine);
		ChartLine chartLine8 = default(ChartLine);
		ChartLine chartLine9 = default(ChartLine);
		ChartLine chartLine = default(ChartLine);
		ChartLine chartLine3 = default(ChartLine);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num5 = thcfHmeS9M9AH9mwMknr(base.Canvas, 0);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_343b2874cf5f4ef7b098544546ed76b2 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				num3 = 0;
				num4 = QZRAKCeS0U5TpKfZ4aYA(uaoish3R0Yt) - PeriodsCount;
				enumerator = uaoish3R0Yt.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num6;
					if (enumerator.MoveNext())
					{
						current = enumerator.Current;
						num6 = 22;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 == 0)
						{
							num6 = 7;
						}
					}
					else
					{
						num6 = 3;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
						{
							num6 = 3;
						}
					}
					while (true)
					{
						int num9;
						switch (num6)
						{
						case 3:
							return;
						case 29:
							return;
						case 27:
							num8 = base.Canvas.Rect.Right;
							if (current.z2FiKOI7HvZ > 0)
							{
								num9 = 10;
								goto IL_00ab;
							}
							goto case 23;
						case 12:
							if (current.VKqiKRTTi1s >= 0.0)
							{
								chartLine6 = S3Line;
								num6 = 37;
								continue;
							}
							goto case 24;
						case 19:
							chartLine4 = R2Line;
							Fco0QseSBX7xCkxDVrUR(P_0, new XBrush(cOpisMFHh5B), new Rect(new Point(num7, GetY(current.L9iiKj8SugA)), new Point(num8, GetY(current.UuBiKENGyvV) - 1.0)));
							num6 = 18;
							continue;
						case 2:
							if (PeriodsCount <= 0 || num3 > num4)
							{
								num7 = base.Canvas.Rect.Left;
								num6 = 19;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_971675a329344000b7f54dccd3fcffa2 != 0)
								{
									num6 = 27;
								}
								continue;
							}
							break;
						case 8:
							if (aBgbbBeSokNogHKPBLLQ(chartLine5))
							{
								num6 = 34;
								continue;
							}
							goto case 12;
						case 14:
							if (current.PWUiKXuhbyB >= 0.0)
							{
								chartLine7 = R4Line;
								P_0.FillRectangle(new XBrush(mmiisREbLDH), new Rect(new Point(num7, GetY(current.PWUiKXuhbyB)), new Point(num8, GetY(current.cooiKchjSkr) - 1.0)));
								num6 = 28;
								continue;
							}
							goto IL_01de;
						case 28:
							if (chartLine7.Visible)
							{
								P_0.DrawLine(new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine7)), ypoL44eSYjWMjYBMtEl2(chartLine7), chartLine7.Style), new Point(num7, GetY(current.PWUiKXuhbyB)), new Point(num8, GetY(current.PWUiKXuhbyB)));
							}
							goto IL_01de;
						case 38:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.wbNiKgXSF70, S2Line.Color));
							goto IL_07c6;
						case 35:
							chartLine10 = PPLine;
							chartLine11 = S1Line;
							P_0.FillRectangle(new XBrush(ikZisOwpy29), new Rect(new Point(num7, GetY(current.UuBiKENGyvV)), new Point(num8, GetY(current.MrviKQweFCM) - 1.0)));
							if (chartLine2.Visible)
							{
								P_0.DrawLine(new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine2)), chartLine2.Width, wOguJueSvXN9uJgGq8ii(chartLine2)), new Point(num7, GetY(current.UuBiKENGyvV)), new Point(num8, GetY(current.UuBiKENGyvV)));
								num6 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							goto default;
						case 15:
						case 31:
							if (current.wbNiKgXSF70 >= 0.0)
							{
								chartLine5 = S2Line;
								num6 = 13;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
								{
									num6 = 33;
								}
								continue;
							}
							goto case 12;
						case 9:
							if (aBgbbBeSokNogHKPBLLQ(chartLine8))
							{
								P_0.DrawLine(new XPen(new XBrush(chartLine8.Color), chartLine8.Width, wOguJueSvXN9uJgGq8ii(chartLine8)), new Point(num7, GetY(current.cooiKchjSkr)), new Point(num8, GetY(current.cooiKchjSkr)));
								num6 = 5;
								continue;
							}
							goto case 5;
						case 16:
							P_0.DrawLine(new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine9)), ypoL44eSYjWMjYBMtEl2(chartLine9), wOguJueSvXN9uJgGq8ii(chartLine9)), new Point(num7, GetY(current.UuBiKENGyvV)), new Point(num8, GetY(current.UuBiKENGyvV)));
							num6 = 17;
							continue;
						case 11:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.L9iiKj8SugA, L6H03aeSGS0r5k2kWrXp(R2Line)));
							goto IL_0378;
						case 34:
							WUf2uceSaFvXRDA6KfJE(P_0, new XPen(new XBrush(chartLine5.Color), ypoL44eSYjWMjYBMtEl2(chartLine5), wOguJueSvXN9uJgGq8ii(chartLine5)), new Point(num7, GetY(current.wbNiKgXSF70)), new Point(num8, GetY(current.wbNiKgXSF70)));
							num6 = 12;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
							{
								num6 = 4;
							}
							continue;
						case 4:
							if (current.MrviKQweFCM >= 0.0)
							{
								num6 = 26;
								continue;
							}
							goto IL_03be;
						case 17:
							if (chartLine.Visible)
							{
								num9 = 25;
								goto IL_00ab;
							}
							goto case 15;
						case 5:
							if (current.L9iiKj8SugA >= 0.0)
							{
								num6 = 4;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
								{
									num6 = 19;
								}
								continue;
							}
							goto case 21;
						case 32:
							P_0.FillRectangle(new XBrush(vtNis6rd0pk), new Rect(new Point(num7, GetY(current.cooiKchjSkr)), new Point(num8, GetY(current.L9iiKj8SugA) - 1.0)));
							num9 = 9;
							goto IL_00ab;
						case 26:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.MrviKQweFCM, L6H03aeSGS0r5k2kWrXp(PPLine)));
							goto IL_03be;
						case 1:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.PWUiKXuhbyB, L6H03aeSGS0r5k2kWrXp(R4Line)));
							goto IL_0182;
						case 23:
							if (current.StUiKM3gTSR >= num)
							{
								num7 = GetX(current.StUiKM3gTSR);
							}
							num7 -= base.Canvas.ColumnWidth / 2.0;
							num6 = 13;
							continue;
						case 6:
							chartLine9 = R1Line;
							chartLine = S1Line;
							if (aBgbbBeSokNogHKPBLLQ(chartLine9))
							{
								num6 = 16;
								continue;
							}
							goto case 17;
						case 22:
							num3++;
							num6 = 2;
							continue;
						case 10:
							if (current.z2FiKOI7HvZ >= num)
							{
								num8 = Math.Min(GetX(current.z2FiKOI7HvZ), num8);
								num6 = 23;
								continue;
							}
							break;
						case 33:
							Fco0QseSBX7xCkxDVrUR(P_0, new XBrush(grUisIw7CmL), new Rect(new Point(num7, GetY(current.QDBiKdVllgU) + 1.0), new Point(num8, GetY(current.wbNiKgXSF70))));
							num6 = 8;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
							{
								num6 = 6;
							}
							continue;
						case 13:
							num8 += mSnk1IeSnff3fNXRDJFC(base.Canvas) / 2.0 - 1.0;
							num6 = 14;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2768cd202ec04d099c20ba8e1925b378 != 0)
							{
								num6 = 8;
							}
							continue;
						case 7:
							if (current.z2FiKOI7HvZ <= num5 && current.z2FiKOI7HvZ != 0)
							{
								break;
							}
							NdMisJQKN9i.Clear();
							if (current.PWUiKXuhbyB >= 0.0)
							{
								num6 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1c1cbcfc982140d18e7033a6f2f9ec87 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							goto IL_0182;
						case 37:
							P_0.FillRectangle(new XBrush(XGXisWkKmZY), new Rect(new Point(num7, GetY(current.wbNiKgXSF70) + 1.0), new Point(num8, GetY(current.VKqiKRTTi1s))));
							if (!aBgbbBeSokNogHKPBLLQ(chartLine6))
							{
								num6 = 24;
								continue;
							}
							goto case 36;
						case 18:
							if (aBgbbBeSokNogHKPBLLQ(chartLine4))
							{
								P_0.DrawLine(new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine4)), chartLine4.Width, chartLine4.Style), new Point(num7, GetY(current.L9iiKj8SugA)), new Point(num8, GetY(current.L9iiKj8SugA)));
								num6 = 1;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c == 0)
								{
									num6 = 21;
								}
								continue;
							}
							goto case 21;
						default:
							if (current.MrviKQweFCM >= 0.0 && chartLine10.Visible)
							{
								WUf2uceSaFvXRDA6KfJE(P_0, new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine10)), chartLine10.Width, chartLine10.Style), new Point(num7, GetY(current.MrviKQweFCM)), new Point(num8, GetY(current.MrviKQweFCM)));
							}
							P_0.FillRectangle(new XBrush(PsGisqlFv9d), new Rect(new Point(num7, GetY(current.MrviKQweFCM) + 1.0), new Point(num8, GetY(current.QDBiKdVllgU))));
							if (chartLine11.Visible)
							{
								P_0.DrawLine(new XPen(new XBrush(L6H03aeSGS0r5k2kWrXp(chartLine11)), chartLine11.Width, chartLine11.Style), new Point(num7, GetY(current.QDBiKdVllgU)), new Point(num8, GetY(current.QDBiKdVllgU)));
								num6 = 31;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_455a5cf7fae1454bbfd88da1f6361acc != 0)
								{
									num6 = 3;
								}
								continue;
							}
							goto case 15;
						case 24:
							if (current.siFiK6Gwdot >= 0.0)
							{
								chartLine3 = S4Line;
								P_0.FillRectangle(new XBrush(nLTistidJct), new Rect(new Point(num7, GetY(current.VKqiKRTTi1s) + 1.0), new Point(num8, GetY(current.siFiK6Gwdot))));
								num6 = 30;
								continue;
							}
							goto case 7;
						case 30:
							if (chartLine3.Visible)
							{
								P_0.DrawLine(new XPen(new XBrush(chartLine3.Color), ypoL44eSYjWMjYBMtEl2(chartLine3), chartLine3.Style), new Point(num7, GetY(current.siFiK6Gwdot)), new Point(num8, GetY(current.siFiK6Gwdot)));
								num6 = 2;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_5d6485f66cb24fc09096e66798254c7f == 0)
								{
									num6 = 7;
								}
								continue;
							}
							goto case 7;
						case 20:
							chartLine2 = R1Line;
							num9 = 35;
							goto IL_00ab;
						case 25:
							P_0.DrawLine(new XPen(new XBrush(chartLine.Color), ypoL44eSYjWMjYBMtEl2(chartLine), wOguJueSvXN9uJgGq8ii(chartLine)), new Point(num7, GetY(current.QDBiKdVllgU)), new Point(num8, GetY(current.QDBiKdVllgU)));
							num6 = 15;
							continue;
						case 36:
							P_0.DrawLine(new XPen(new XBrush(chartLine6.Color), chartLine6.Width, chartLine6.Style), new Point(num7, GetY(current.VKqiKRTTi1s)), new Point(num8, GetY(current.VKqiKRTTi1s)));
							goto case 24;
						case 21:
							{
								if (CalculationMethod != PivotCalculationType.Camarilla)
								{
									num6 = 20;
									continue;
								}
								goto case 6;
							}
							IL_07c6:
							if (current.VKqiKRTTi1s >= 0.0)
							{
								NdMisJQKN9i.Add(new IndicatorLabelInfo(current.VKqiKRTTi1s, S3Line.Color));
							}
							if (!(current.siFiK6Gwdot >= 0.0))
							{
								return;
							}
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.siFiK6Gwdot, S4Line.Color));
							num6 = 29;
							continue;
							IL_0182:
							if (current.cooiKchjSkr >= 0.0)
							{
								NdMisJQKN9i.Add(new IndicatorLabelInfo(current.cooiKchjSkr, R3Line.Color));
							}
							if (current.L9iiKj8SugA >= 0.0)
							{
								num6 = 11;
								continue;
							}
							goto IL_0378;
							IL_01de:
							if (current.cooiKchjSkr >= 0.0)
							{
								chartLine8 = R3Line;
								num6 = 17;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 != 0)
								{
									num6 = 32;
								}
								continue;
							}
							goto case 5;
							IL_03be:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.QDBiKdVllgU, S1Line.Color));
							if (current.wbNiKgXSF70 >= 0.0)
							{
								num6 = 38;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0f9979478ba842a39155e14f5980ecce == 0)
								{
									num6 = 18;
								}
								continue;
							}
							goto IL_07c6;
							IL_00ab:
							num6 = num9;
							continue;
							IL_0378:
							NdMisJQKN9i.Add(new IndicatorLabelInfo(current.UuBiKENGyvV, L6H03aeSGS0r5k2kWrXp(R1Line)));
							num6 = 4;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
							{
								num6 = 1;
							}
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
		}
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (uaoish3R0Yt != null)
		{
			P_0.AddRange(NdMisJQKN9i);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 != 0)
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

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		if (P_0 is VCJB32ie6fq7xLWs9D1G vCJB32ie6fq7xLWs9D1G)
		{
			PeriodType = hjVf1teSiSk5jE4rxuRw(vCJB32ie6fq7xLWs9D1G);
			int num = 8;
			while (true)
			{
				switch (num)
				{
				case 3:
					TQe2tleSbGA3TRrglHJN(S3Line, ea7I3ZeSkhgQWtGPES9N(vCJB32ie6fq7xLWs9D1G));
					TQe2tleSbGA3TRrglHJN(S4Line, EtstJkeS1qU5BXYjCw5Q(vCJB32ie6fq7xLWs9D1G));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_fbc3ce86e86648d0ab473d06282ebe5e != 0)
					{
						num = 0;
					}
					continue;
				default:
					S1Zone = vCJB32ie6fq7xLWs9D1G.S1Zone;
					S2Zone = FJue0IeS5GFabvQuwBOI(vCJB32ie6fq7xLWs9D1G);
					S3Zone = vCJB32ie6fq7xLWs9D1G.S3Zone;
					S4Zone = vCJB32ie6fq7xLWs9D1G.S4Zone;
					num = 4;
					continue;
				case 10:
					Fibonacci2 = oJWx5FeSDoDjHekbwQyo(vCJB32ie6fq7xLWs9D1G);
					Fibonacci3 = vCJB32ie6fq7xLWs9D1G.Fibonacci3;
					Fibonacci4 = vCJB32ie6fq7xLWs9D1G.Fibonacci4;
					TQe2tleSbGA3TRrglHJN(R4Line, vCJB32ie6fq7xLWs9D1G.R4Line);
					TQe2tleSbGA3TRrglHJN(R3Line, vCJB32ie6fq7xLWs9D1G.R3Line);
					R2Line.CopyTheme(vCJB32ie6fq7xLWs9D1G.R2Line);
					num = 2;
					continue;
				case 9:
				{
					S1Line.CopyTheme(vCJB32ie6fq7xLWs9D1G.S1Line);
					int num2 = 6;
					num = num2;
					continue;
				}
				case 4:
					R1Zone = vCJB32ie6fq7xLWs9D1G.R1Zone;
					R2Zone = vCJB32ie6fq7xLWs9D1G.R2Zone;
					R3Zone = h04bJ5eSSZR3S7lBFaXC(vCJB32ie6fq7xLWs9D1G);
					num = 5;
					continue;
				case 2:
					TQe2tleSbGA3TRrglHJN(R1Line, SH1EbXeSNWfpppUFf8QL(vCJB32ie6fq7xLWs9D1G));
					num = 7;
					continue;
				case 7:
					PPLine.CopyTheme(vCJB32ie6fq7xLWs9D1G.PPLine);
					num = 9;
					continue;
				case 8:
					PeriodValue = w6vhwbeSlJUEYahXZOB3(vCJB32ie6fq7xLWs9D1G);
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6a040d702266442f806ec7e63a06242e != 0)
					{
						num = 1;
					}
					continue;
				case 11:
					break;
				case 1:
					PeriodsCount = vCJB32ie6fq7xLWs9D1G.PeriodsCount;
					CalculationMethod = ea6ZxTeS4BPh7CV8PPBq(vCJB32ie6fq7xLWs9D1G);
					Fibonacci1 = vCJB32ie6fq7xLWs9D1G.Fibonacci1;
					num = 10;
					continue;
				case 5:
					R4Zone = HlggDteSxMRYN0BfMr3g(vCJB32ie6fq7xLWs9D1G);
					num = 7;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24721d7b74cc4b6284dde0332745cd84 != 0)
					{
						num = 11;
					}
					continue;
				case 6:
					TQe2tleSbGA3TRrglHJN(S2Line, vCJB32ie6fq7xLWs9D1G.S2Line);
					num = 3;
					continue;
				}
				break;
			}
		}
		base.CopyTemplate(P_0, P_1);
	}

	public override bool GetPropertyVisibility(string P_0)
	{
		uint num = global::_003CPrivateImplementationDetails_003E.ComputeStringHash(P_0);
		if (num > 2663623721u)
		{
			goto IL_05a5;
		}
		if (num > 2300972249u)
		{
			goto IL_0689;
		}
		if (num <= 1536002809)
		{
			goto IL_03b6;
		}
		int num2;
		if (num != 1536109936)
		{
			num2 = 14;
			goto IL_0009;
		}
		goto IL_04c4;
		IL_05a5:
		int num3;
		if (num <= 3100827687u)
		{
			if (num > 2798451350u)
			{
				goto IL_0700;
			}
			num2 = 16;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_842fd993a2b5414bb5dea11b59e24eb1 != 0)
			{
				num2 = 22;
			}
		}
		else if (num > 3564072640u)
		{
			if (num == 3865797127u)
			{
				if (!(P_0 == (string)qMpHi8e5KKJLrfh1Jrxe(-1416986301 ^ -1417012219)))
				{
					num3 = 20;
					goto IL_0005;
				}
				goto IL_01a8;
			}
			if (num != 4090617705u || !OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60821699)))
			{
				goto IL_03d6;
			}
			num2 = 15;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
			{
				num2 = 15;
			}
		}
		else if (num != 3175552892u)
		{
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
			{
				num2 = 0;
			}
		}
		else
		{
			if (OeICWWeSLd1Fyohh195m(P_0, qMpHi8e5KKJLrfh1Jrxe(-181342698 ^ -181374080)))
			{
				goto IL_0442;
			}
			num2 = 7;
		}
		goto IL_0009;
		IL_03b6:
		if (num != 1108912586)
		{
			if (num != 1536002809)
			{
				goto IL_03d6;
			}
			if (P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1583344314 ^ -1583314912))
			{
				goto IL_0442;
			}
			num2 = 29;
		}
		else
		{
			if (OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2056710528 ^ -2056680554)))
			{
				goto IL_01a8;
			}
			num2 = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0ab04f3efbe746ef961577ea88d00fe3 != 0)
			{
				num2 = 9;
			}
		}
		goto IL_0009;
		IL_0005:
		num2 = num3;
		goto IL_0009;
		IL_0442:
		if (CalculationMethod != PivotCalculationType.Classic)
		{
			num3 = 19;
			goto IL_0005;
		}
		goto IL_03d4;
		IL_0689:
		if (num <= 2610035523u)
		{
			if (num == 2593257904u)
			{
				if (OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-82860344 ^ -82888498)))
				{
					goto IL_019e;
				}
			}
			else if (num == 2610035523u)
			{
				goto IL_05b6;
			}
			goto IL_03d6;
		}
		if (num != 2626813142u)
		{
			num2 = 16;
			goto IL_0009;
		}
		goto IL_04a3;
		IL_0114:
		if (P_0 == (string)qMpHi8e5KKJLrfh1Jrxe(-1461949456 ^ -1461913978))
		{
			goto IL_01a8;
		}
		goto IL_03d6;
		IL_04a3:
		if (!OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-624753169 ^ -624715719)))
		{
			goto IL_03d6;
		}
		goto IL_019e;
		IL_0009:
		while (true)
		{
			switch (num2)
			{
			case 17:
				break;
			case 15:
				goto IL_01b5;
			default:
				if (num != 3564072640u)
				{
					goto IL_03d6;
				}
				goto case 5;
			case 21:
				goto IL_03b6;
			case 3:
				return CalculationMethod != PivotCalculationType.DeMark;
			case 1:
			case 6:
			case 7:
			case 8:
			case 9:
			case 10:
			case 11:
			case 12:
			case 20:
			case 23:
			case 25:
			case 29:
			case 30:
				goto IL_03d6;
			case 27:
				goto IL_041d;
			case 28:
				goto IL_0442;
			case 26:
				goto IL_04a3;
			case 24:
				goto IL_04c4;
			case 4:
				if (!OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1435596783 ^ -1435626025)))
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_8c0cafc031434e41bde083ffe3129211 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_0442;
			case 16:
				if (num == 2663623721u && P_0 == (string)qMpHi8e5KKJLrfh1Jrxe(-29702950 ^ -29730468))
				{
					goto IL_01b5;
				}
				goto IL_03d6;
			case 18:
				goto IL_05a5;
			case 13:
				goto IL_05b6;
			case 5:
				if (!(P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x446AB724 ^ 0x446A2A72)))
				{
					num2 = 6;
					continue;
				}
				goto IL_01b5;
			case 22:
				goto IL_0615;
			case 14:
				if (num != 2300972249u)
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b35db2c0f4de46efa9eb8ca63c778728 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				goto case 4;
			case 2:
				goto IL_0689;
			case 19:
				goto IL_06c0;
			case 31:
				goto IL_0700;
			}
			break;
			IL_06c0:
			if (CalculationMethod != PivotCalculationType.Woodie)
			{
				num2 = 3;
				continue;
			}
			goto IL_03d4;
			IL_041d:
			if (num != 2798451350u)
			{
				num2 = 8;
				continue;
			}
			goto IL_0114;
			IL_0615:
			if (num == 2710701237u)
			{
				if (OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-530053095 ^ -530016761)))
				{
					break;
				}
				num2 = 25;
				continue;
			}
			goto IL_0621;
		}
		goto IL_019e;
		IL_03d4:
		return false;
		IL_03d6:
		return base.GetPropertyVisibility(P_0);
		IL_01a8:
		return CalculationMethod != PivotCalculationType.DeMark;
		IL_01b5:
		if (CalculationMethod != PivotCalculationType.Woodie)
		{
			return CalculationMethod != PivotCalculationType.DeMark;
		}
		return false;
		IL_0700:
		if (num == 3027804076u)
		{
			if (P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-181342698 ^ -181374048))
			{
				goto IL_01b5;
			}
			num2 = 30;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f32eaaa08a29412b875fc15d2e235a1b == 0)
			{
				num2 = 9;
			}
		}
		else
		{
			if (num == 3100827687u)
			{
				if (OeICWWeSLd1Fyohh195m(P_0, qMpHi8e5KKJLrfh1Jrxe(--871424829 ^ 0x33F07E9B)))
				{
					goto IL_01a8;
				}
				goto IL_03d6;
			}
			num2 = 9;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e != 0)
			{
				num2 = 10;
			}
		}
		goto IL_0009;
		IL_019e:
		return CalculationMethod == PivotCalculationType.Fibonacci;
		IL_05b6:
		if (OeICWWeSLd1Fyohh195m(P_0, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x6AB40973 ^ 0x6AB4949D)))
		{
			goto IL_019e;
		}
		goto IL_03d6;
		IL_0621:
		num3 = 27;
		goto IL_0005;
		IL_04c4:
		if (!(P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x315AB1E3 ^ 0x315A2CD5)))
		{
			goto IL_03d6;
		}
		num2 = 28;
		goto IL_0009;
	}

	static VCJB32ie6fq7xLWs9D1G()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		iTXvsKeSeacxeqj74BhQ();
	}

	internal static bool DBEnoYe5CCpTVbyFUFCD()
	{
		return p65qZbe5V0rVe0GlepjA == null;
	}

	internal static VCJB32ie6fq7xLWs9D1G dboud0e5r9HUxkgRnrX4()
	{
		return p65qZbe5V0rVe0GlepjA;
	}

	internal static object qMpHi8e5KKJLrfh1Jrxe(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static double fkd3vDe5me5IycaW2jHo(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static bool kBgjqVe5hywJb10AqXyf(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static void zyYAH3e5wdWYt2dmGwnc(object P_0, int value)
	{
		((ChartLine)P_0).Width = value;
	}

	internal static void NZ9eWye57RUdxoTgWxPM(object P_0, XColor value)
	{
		((ChartLine)P_0).Color = value;
	}

	internal static void PJnhd9e58ol4fZKxjxyu(object P_0, XDashStyle value)
	{
		((ChartLine)P_0).Style = value;
	}

	internal static Color Lh616ke5AEfWaeiAjwoD()
	{
		return Colors.Green;
	}

	internal static bool i3uuTFe5PomyT9rmcWYR(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static XColor a5hZFse5JK2uSLrXb09Q(Color P_0)
	{
		return P_0;
	}

	internal static Color YlXJUEe5FRU3C97BPLWs()
	{
		return Colors.Red;
	}

	internal static Color wg4vvSe53sbiXBl3HTeg(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static int Jr9eGYe5p6R3wk0NYpbW(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static object iVbVLJe5ubqoPOiJnvqu(object P_0)
	{
		return ((IChartSymbol)P_0).Exchange;
	}

	internal static double P5C1t1e5zQLVapoOQ4bs(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static int QZRAKCeS0U5TpKfZ4aYA(object P_0)
	{
		return ((List<jL0LsCiKs7bCTX4UMeQe>)P_0).Count;
	}

	internal static double Qh7a4OeS2fRTGHE0IaPg(object P_0)
	{
		return ((IChartDataProvider)P_0).Step;
	}

	internal static long q3bBHPeSHpxQu39SPUAV(object P_0)
	{
		return ((IRawCluster)P_0).Low;
	}

	internal static int Vx4OgIeSfRlQuYSnuU1X(object P_0, ChartPeriodType type, int interval, DateTime dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static int thcfHmeS9M9AH9mwMknr(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static double mSnk1IeSnff3fNXRDJFC(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static XColor L6H03aeSGS0r5k2kWrXp(object P_0)
	{
		return ((ChartLine)P_0).Color;
	}

	internal static int ypoL44eSYjWMjYBMtEl2(object P_0)
	{
		return ((ChartLine)P_0).Width;
	}

	internal static bool aBgbbBeSokNogHKPBLLQ(object P_0)
	{
		return ((ChartLine)P_0).Visible;
	}

	internal static XDashStyle wOguJueSvXN9uJgGq8ii(object P_0)
	{
		return ((ChartLine)P_0).Style;
	}

	internal static void Fco0QseSBX7xCkxDVrUR(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void WUf2uceSaFvXRDA6KfJE(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static PivotPeriodType hjVf1teSiSk5jE4rxuRw(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).PeriodType;
	}

	internal static int w6vhwbeSlJUEYahXZOB3(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).PeriodValue;
	}

	internal static PivotCalculationType ea6ZxTeS4BPh7CV8PPBq(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).CalculationMethod;
	}

	internal static double oJWx5FeSDoDjHekbwQyo(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).Fibonacci2;
	}

	internal static void TQe2tleSbGA3TRrglHJN(object P_0, object P_1)
	{
		((ChartLine)P_0).CopyTheme((ChartLine)P_1);
	}

	internal static object SH1EbXeSNWfpppUFf8QL(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).R1Line;
	}

	internal static object ea7I3ZeSkhgQWtGPES9N(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).S3Line;
	}

	internal static object EtstJkeS1qU5BXYjCw5Q(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).S4Line;
	}

	internal static XColor FJue0IeS5GFabvQuwBOI(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).S2Zone;
	}

	internal static XColor h04bJ5eSSZR3S7lBFaXC(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).R3Zone;
	}

	internal static XColor HlggDteSxMRYN0BfMr3g(object P_0)
	{
		return ((VCJB32ie6fq7xLWs9D1G)P_0).R4Zone;
	}

	internal static bool OeICWWeSLd1Fyohh195m(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void iTXvsKeSeacxeqj74BhQ()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
