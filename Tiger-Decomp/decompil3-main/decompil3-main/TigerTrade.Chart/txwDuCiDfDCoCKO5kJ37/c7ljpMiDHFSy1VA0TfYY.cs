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
using sMFne2GHAlf89keFJ43Q;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Base.Enums;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Chart.Indicators.List;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;
using TigerTrade.Dx.Enums;

namespace txwDuCiDfDCoCKO5kJ37;

[Indicator("BarTimer", "BarTimer", true, Type = typeof(c7ljpMiDHFSy1VA0TfYY))]
[DataContract(Name = "BarTimerIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class c7ljpMiDHFSy1VA0TfYY : IndicatorBase
{
	private BarTimerLocation Gk2iDS9vlgC;

	private int J1wiDx01AOt;

	private int vMIiDLIdWVw;

	private ChartAlertSettings qk4iDeQikcY;

	private XBrush L19iDsETnTx;

	private XColor WMTiDX1hxPN;

	private XBrush TGBiDc0iKai;

	private XPen KOoiDj4pyNP;

	private XColor BhRiDEix4SU;

	private XBrush lYAiDQQ2t9P;

	private XColor SJeiDd7Wo4n;

	private int sbwiDgHloJB;

	private DateTime UG9iDRH7U4F;

	private long PJOiD664ffL;

	private static c7ljpMiDHFSy1VA0TfYY sj02fAelrHYvWK1QY23D;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[DefaultValue(BarTimerLocation.RightBottom)]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[DataMember(Name = "Location")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLocation")]
	public BarTimerLocation Location
	{
		get
		{
			return Gk2iDS9vlgC;
		}
		set
		{
			if (barTimerLocation != Gk2iDS9vlgC)
			{
				Gk2iDS9vlgC = barTimerLocation;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1799510641 ^ -1799539235));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_739f779654714fe286f27606d950a9d9 == 0)
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

	[DataMember(Name = "OffsetX")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsOffsetX")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public int OffsetX
	{
		get
		{
			return J1wiDx01AOt;
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
					num3 = Math.Max(0, Math.Min(1000, num3));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_db5715c3607e44409516f9862a59965c != 0)
					{
						num2 = 0;
					}
					break;
				default:
					if (num3 != J1wiDx01AOt)
					{
						J1wiDx01AOt = num3;
						OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-225822163 ^ -225793461));
					}
					return;
				}
			}
		}
	}

	[DataMember(Name = "OffsetY")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsOffsetY")]
	public int OffsetY
	{
		get
		{
			return vMIiDLIdWVw;
		}
		set
		{
			num = Math.Max(0, A7XLUYelh2SLjOXuQcNs(1000, num));
			if (num != vMIiDLIdWVw)
			{
				vMIiDLIdWVw = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1736566656 ^ -1736537864));
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a0f7dd9205eb40fbb542085b90a19faa == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		}
	}

	[DataMember(Name = "Alert")]
	[Browsable(true)]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public ChartAlertSettings Alert
	{
		get
		{
			return qk4iDeQikcY ?? (qk4iDeQikcY = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, qk4iDeQikcY))
			{
				qk4iDeQikcY = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-29702950 ^ -29705892));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
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

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "BackColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBackColor")]
	public XColor BackColor
	{
		get
		{
			return WMTiDX1hxPN;
		}
		set
		{
			if (!fJ5B8helwVMoKJXOLwA8(xColor, WMTiDX1hxPN))
			{
				WMTiDX1hxPN = xColor;
				L19iDsETnTx = new XBrush(WMTiDX1hxPN);
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_abb7f19926ed4d07ba9755366ca9a059 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x16AD7E76 ^ 0x16ADF946));
			}
		}
	}

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "BorderColor")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsBorderColor")]
	public XColor BorderColor
	{
		get
		{
			return BhRiDEix4SU;
		}
		set
		{
			if (xColor == BhRiDEix4SU)
			{
				return;
			}
			BhRiDEix4SU = xColor;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9a8381dfafdf4cd0bdbdde184d2abaf1 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-123775059 ^ -123746521));
					return;
				}
				TGBiDc0iKai = new XBrush(BhRiDEix4SU);
				KOoiDj4pyNP = new XPen(TGBiDc0iKai, 1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f == 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "TextColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsTextColor")]
	public XColor TextColor
	{
		get
		{
			return SJeiDd7Wo4n;
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
					if (xColor == SJeiDd7Wo4n)
					{
						num2 = 0;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4f0cf0da7be4416c854b8885e7290889 != 0)
						{
							num2 = 0;
						}
						break;
					}
					SJeiDd7Wo4n = xColor;
					lYAiDQQ2t9P = new XBrush(SJeiDd7Wo4n);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-203064540 ^ -203094918));
					return;
				case 0:
					return;
				}
			}
		}
	}

	[DataMember(Name = "TextSize")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsTextSize")]
	public int TextSize
	{
		get
		{
			return sbwiDgHloJB;
		}
		set
		{
			num = oGL3sCel73SDomcldNLo(8, Math.Min(50, num));
			if (num == sbwiDgHloJB)
			{
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_ffb93a04ce4c4a8e857e2e7fd646df59 != 0)
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
				sbwiDgHloJB = num;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1161619942 ^ -1161598568));
			}
		}
	}

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	public c7ljpMiDHFSy1VA0TfYY()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		PJOiD664ffL = long.MinValue;
		base._002Ector();
		ShowIndicatorTitle = false;
		int num = 1;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9f8132c088e4447e83ec74ef15b8e944 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				OffsetX = 10;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_025edf4a83be4acb8c8326612d0fc8c2 == 0)
				{
					num = 2;
				}
				break;
			case 1:
				Location = BarTimerLocation.RightBottom;
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_86d84d52ab13483783040bb945a786b2 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				OffsetY = 10;
				BackColor = SZahOeel8eAaOSNSkVi4();
				num = 3;
				break;
			case 3:
				BorderColor = GyqkgtelArpmboTXQw4a();
				TextColor = Colors.White;
				TextSize = 16;
				return;
			}
		}
	}

	protected override void Execute()
	{
		if (base.ClearData)
		{
			PJOiD664ffL = long.MinValue;
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		UG9iDRH7U4F = aUvdW7elPmpB6q1sxkyy();
	}

	public override void Render(DxVisualQueue P_0)
	{
		int num = 9;
		string text = default(string);
		long num9 = default(long);
		DateTime dateTime3 = default(DateTime);
		IChartCluster cluster = default(IChartCluster);
		double y = default(double);
		Rect rect = default(Rect);
		double num4 = default(double);
		double num7 = default(double);
		Size size = default(Size);
		string text2 = default(string);
		IChartPeriod period = default(IChartPeriod);
		bool flag = default(bool);
		TimeSpan timeSpan = default(TimeSpan);
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = default(DateTime);
		int num11 = default(int);
		BarTimerLocation barTimerLocation = default(BarTimerLocation);
		long num14 = default(long);
		IChartSymbol symbol = default(IChartSymbol);
		double num5 = default(double);
		int num6 = default(int);
		int num8 = default(int);
		long num13 = default(long);
		ChartPeriodType type = default(ChartPeriodType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				long num12;
				long num3;
				Rect rect2;
				long num10;
				switch (num2)
				{
				case 11:
					text = (string)yY8QmLelJ7lokUc69Hr9(0x68C7EAE6 ^ 0x68C77A42);
					num2 = 24;
					continue;
				case 40:
					PJOiD664ffL = num9;
					num2 = 38;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
					{
						num2 = 41;
					}
					continue;
				case 38:
					dateTime3 = HH24PSelFDpAy5EQdsmK(cluster);
					num2 = 36;
					continue;
				case 2:
					y = 0.0;
					num2 = 5;
					continue;
				case 23:
					num7 = rect.Right - (rect.Width + num4) / 2.0;
					num7 = Math.Max(num7, rect.Left);
					goto IL_0644;
				case 16:
				case 17:
				case 27:
					size = new XFont((string)F4P8R0e4HIeNJCD6ySYY(LOwOoTe42CSQUg7VWSPy(base.Canvas)), TextSize).GetSize(text2);
					num7 = 0.0;
					num2 = 2;
					continue;
				case 8:
					if (cluster == null)
					{
						return;
					}
					period = base.DataProvider.Period;
					flag = false;
					num2 = 22;
					continue;
				case 42:
					flag = true;
					num2 = 40;
					continue;
				case 25:
					if (timeSpan > TimeSpan.FromTicks(PJOiD664ffL))
					{
						flag = true;
					}
					goto IL_0166;
				case 15:
				case 44:
					if (dateTime2 < dateTime)
					{
						dateTime2 = dateTime2.AddSeconds(num11);
						num2 = 44;
						continue;
					}
					num2 = 17;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9b268a4ae6bd40e28461cca24d9b841f == 0)
					{
						num2 = 26;
					}
					continue;
				case 7:
					flag = true;
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_be0348d4881e4572932fccb8442b1a1a == 0)
					{
						num2 = 30;
					}
					continue;
				case 32:
					barTimerLocation = Location;
					num2 = 43;
					continue;
				case 1:
					goto IL_045c;
				case 14:
					if (PJOiD664ffL != long.MinValue && num14 > PJOiD664ffL)
					{
						flag = true;
						num2 = 4;
						continue;
					}
					goto case 4;
				case 34:
					goto IL_04ce;
				case 12:
					if (!TimeHelper.PlayerTimeProvider.IsPlayerModeOn)
					{
						dateTime3 = TimeHelper.GetCurrTime(base.DataProvider.Symbol.Exchange);
						dateTime = dateTime3.AddMilliseconds(TimeHelper.NtpTimeDiff);
						num = 15;
					}
					else
					{
						symbol = base.DataProvider.Symbol;
						num = 33;
					}
					break;
				case 18:
					rect = base.Canvas.Rect;
					barTimerLocation = Location;
					switch (barTimerLocation)
					{
					default:
						num2 = 32;
						continue;
					case BarTimerLocation.LeftTop:
					case BarTimerLocation.CenterTop:
					case BarTimerLocation.RightTop:
						y = rect.Top + (double)OffsetY - 1.0;
						break;
					case BarTimerLocation.LeftBottom:
					case BarTimerLocation.CenterBottom:
					case BarTimerLocation.RightBottom:
						y = rect.Bottom - (double)OffsetY - num5 - 1.0;
						break;
					case BarTimerLocation.LeftMiddle:
					case BarTimerLocation.CenterMiddle:
					case BarTimerLocation.RightMiddle:
						y = (rect.Top + rect.Bottom - num5) / 2.0;
						break;
					}
					goto case 32;
				case 26:
					timeSpan = ecnx0delucXVfYh4oTJL(dateTime2, dateTime);
					if (PJOiD664ffL != long.MinValue)
					{
						num2 = 25;
						continue;
					}
					goto IL_0166;
				case 46:
					if (num6 > PJOiD664ffL)
					{
						num2 = 7;
						continue;
					}
					goto case 30;
				case 3:
					if (PJOiD664ffL != long.MinValue && num9 > PJOiD664ffL)
					{
						num2 = 42;
						continue;
					}
					goto case 40;
				case 37:
					num8 = ((num6 > 0) ? num6 : aMAoGXelzrJ6eeH45Pqc(period));
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (Alert.IsActive)
					{
						AddAlert(Alert, yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1192989954 ^ -1192953310));
					}
					return;
				case 22:
					switch (period.Type)
					{
					case ChartPeriodType.Range:
						break;
					case ChartPeriodType.Volume:
						goto IL_04ce;
					default:
						return;
					case ChartPeriodType.Delta:
						goto IL_0658;
					case ChartPeriodType.Day:
					case ChartPeriodType.Week:
					case ChartPeriodType.Month:
					case ChartPeriodType.Year:
						return;
					case ChartPeriodType.Tick:
						goto IL_0996;
					case ChartPeriodType.Second:
					case ChartPeriodType.Minute:
					case ChartPeriodType.Hour:
						goto IL_0a57;
					}
					num13 = aMAoGXelzrJ6eeH45Pqc(period) - (long)((cluster.High - cluster.Low) / (decimal)base.DataProvider.Step);
					if (PJOiD664ffL != long.MinValue && num13 > PJOiD664ffL)
					{
						num2 = 10;
						continue;
					}
					goto case 31;
				case 35:
					num12 = period.Interval;
					goto IL_0ae7;
				case 9:
					cluster = base.DataProvider.GetCluster(base.DataProvider.Count - 1);
					num2 = 8;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_6b60de74857647159a2dc2ecd595d1bd != 0)
					{
						num2 = 7;
					}
					continue;
				case 13:
					goto IL_0644;
				case 19:
					goto IL_0658;
				case 36:
					dateTime2 = dateTime3.AddSeconds(num11);
					num2 = 12;
					continue;
				case 41:
					if (num9 <= 0)
					{
						num2 = 28;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
						{
							num2 = 14;
						}
						continue;
					}
					num3 = num9;
					goto IL_0ade;
				default:
					text2 = num8.ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x42D899B5 ^ 0x42D80961));
					num2 = 17;
					continue;
				case 47:
					num7 = hK33gNe4fPpbOnSdPyZM(num7, rect.Left);
					goto IL_0644;
				case 29:
					if (PJOiD664ffL != long.MinValue)
					{
						num2 = 46;
						continue;
					}
					goto case 30;
				case 43:
					switch (barTimerLocation)
					{
					case BarTimerLocation.CenterTop:
					case BarTimerLocation.CenterMiddle:
					case BarTimerLocation.CenterBottom:
						break;
					case BarTimerLocation.LeftTop:
					case BarTimerLocation.LeftMiddle:
					case BarTimerLocation.LeftBottom:
						goto IL_0304;
					case BarTimerLocation.RightTop:
					case BarTimerLocation.RightMiddle:
					case BarTimerLocation.RightBottom:
						goto IL_045c;
					default:
						goto IL_0644;
					}
					goto case 23;
				case 45:
					if (dateTime == DateTime.MinValue)
					{
						dateTime = dateTime2;
					}
					goto case 15;
				case 31:
					PJOiD664ffL = num13;
					text2 = ((num13 > 0) ? num13 : period.Interval).ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D313048 ^ 0x2D31A09C));
					num2 = 27;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0cda726836d64094b2c4c18a328cd3aa != 0)
					{
						num2 = 4;
					}
					continue;
				case 20:
					text2 = timeSpan.ToString(text);
					num2 = 16;
					continue;
				case 10:
					flag = true;
					num2 = 31;
					continue;
				case 24:
				case 39:
					num11 = d4QiD9Jgqeb();
					num2 = 38;
					continue;
				case 5:
					num4 = size.Width + 10.0;
					num5 = size.Height + 10.0;
					num2 = 18;
					continue;
				case 4:
					PJOiD664ffL = num14;
					if (num14 <= 0)
					{
						num2 = 35;
						continue;
					}
					num12 = num14;
					goto IL_0ae7;
				case 33:
					dateTime = kxA0sselpB2Fvnhn7YYx(TimeHelper.PlayerTimeProvider, ORqSkWel3wcvhWJlHfQZ(symbol));
					num2 = 45;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_88a7c33625fa4b38aecf07f72758e410 == 0)
					{
						num2 = 9;
					}
					continue;
				case 28:
					num3 = period.Interval;
					goto IL_0ade;
				case 21:
					if (type != ChartPeriodType.Minute)
					{
						text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60824921);
						num2 = 39;
						continue;
					}
					text = yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-837284864 ^ -837247828);
					goto case 24;
				case 30:
					{
						PJOiD664ffL = num6;
						num2 = 37;
						continue;
					}
					IL_0304:
					num7 = rect.X + (double)OffsetX - 1.0;
					num2 = 13;
					continue;
					IL_0644:
					rect2 = new Rect(num7, y, num4, num5);
					MPPjc0e49NDvw8nVXLYb(P_0, L19iDsETnTx, rect2);
					P_0.DrawRectangle(KOoiDj4pyNP, rect2);
					FQFMS7e4nncJm9fmMWLh(P_0, text2, new XFont(((XFont)LOwOoTe42CSQUg7VWSPy(base.Canvas)).Name, TextSize), lYAiDQQ2t9P, rect2, XTextAlignment.Center);
					if (!flag)
					{
						return;
					}
					num = 6;
					break;
					IL_0ade:
					num10 = num3;
					text2 = num10.ToString((string)yY8QmLelJ7lokUc69Hr9(0x78D396D8 ^ 0x78D3060C));
					goto case 16;
					IL_0a57:
					type = period.Type;
					if (type == ChartPeriodType.Second)
					{
						num = 11;
						break;
					}
					goto case 21;
					IL_04ce:
					num9 = period.Interval - (long)cluster.Volume;
					num2 = 3;
					continue;
					IL_0ae7:
					num10 = num12;
					text2 = num10.ToString(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-842040449 ^ -842011733));
					goto case 16;
					IL_0996:
					num6 = aMAoGXelzrJ6eeH45Pqc(period) - YV8ujCe4071ghpjfc8Ki(cluster);
					num2 = 13;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf5c5dff42eb4dbcb67f23c8a54dc750 == 0)
					{
						num2 = 29;
					}
					continue;
					IL_0658:
					num14 = period.Interval - (long)Math.Abs(cluster.Delta);
					num2 = 14;
					continue;
					IL_0166:
					PJOiD664ffL = timeSpan.Ticks;
					num2 = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
					{
						num2 = 10;
					}
					continue;
					IL_045c:
					num7 = rect.Right - num4 - (double)OffsetX;
					num2 = 47;
					continue;
				}
				break;
			}
		}
	}

	public int d4QiD9Jgqeb()
	{
		switch (((IChartPeriod)KIKU3Pe4GtVvDLwVxUCo(base.DataProvider)).Type)
		{
		case ChartPeriodType.Second:
			return base.DataProvider.Period.Interval;
		case ChartPeriodType.Minute:
			return aMAoGXelzrJ6eeH45Pqc(KIKU3Pe4GtVvDLwVxUCo(base.DataProvider)) * 60;
		case ChartPeriodType.Hour:
			return base.DataProvider.Period.Interval * 60 * 60;
		case ChartPeriodType.Day:
			return aMAoGXelzrJ6eeH45Pqc(KIKU3Pe4GtVvDLwVxUCo(base.DataProvider)) * 60 * 60 * 24;
		case ChartPeriodType.Week:
			return base.DataProvider.Period.Interval * 60 * 60 * 24 * 7;
		case ChartPeriodType.Month:
			return base.DataProvider.Period.Interval * 60 * 60 * 24 * 30;
		default:
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => 0, 
			};
		}
		}
	}

	public override bool CheckNeedRedraw()
	{
		int num = 1;
		int num2 = num;
		DateTime localTimeWithNtpCorrection = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (base.DataProvider == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0450b8b54d9e402da4e2f9dc872984ee == 0)
					{
						num2 = 0;
					}
					break;
				}
				ChartPeriodType chartPeriodType = CfDfu8e4Y5C5lVWsNIM0(base.DataProvider.Period);
				if ((uint)(chartPeriodType - 3) <= 7u)
				{
					return false;
				}
				localTimeWithNtpCorrection = TimeHelper.GetLocalTimeWithNtpCorrection();
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_26c70faf0c9c44d6abdd5939b8657847 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 2:
				if (tPwtnAe4o7lC8ltOpGw7(localTimeWithNtpCorrection - UG9iDRH7U4F, TimeSpan.FromSeconds(1.0)))
				{
					return false;
				}
				UG9iDRH7U4F = localTimeWithNtpCorrection;
				return true;
			default:
				return false;
			}
		}
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		BackColor = P_0.ChartBackColor;
		BorderColor = P_0.ChartAxisColor;
		TextColor = TZSwCae4vgjafyTLG5ZW(P_0);
		base.ApplyColors(P_0);
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 != 0)
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
		c7ljpMiDHFSy1VA0TfYY c7ljpMiDHFSy1VA0TfYY2 = (c7ljpMiDHFSy1VA0TfYY)P_0;
		Location = iRvOIce4Brax7aU2XkGo(c7ljpMiDHFSy1VA0TfYY2);
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				base.CopyTemplate(P_0, P_1);
				return;
			case 2:
				OffsetX = c7ljpMiDHFSy1VA0TfYY2.OffsetX;
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				BorderColor = c7ljpMiDHFSy1VA0TfYY2.BorderColor;
				TextColor = c7ljpMiDHFSy1VA0TfYY2.TextColor;
				TextSize = uFGlBme4iPNfatTwNUYU(c7ljpMiDHFSy1VA0TfYY2);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f7a77ea7857147f9bcad1eccff0c940f == 0)
				{
					num = 0;
				}
				break;
			case 1:
				OffsetY = u7rSjhe4aQVmweX5trVS(c7ljpMiDHFSy1VA0TfYY2);
				Alert.Copy(c7ljpMiDHFSy1VA0TfYY2.Alert, !P_1);
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-60853733 ^ -60878947));
				BackColor = c7ljpMiDHFSy1VA0TfYY2.BackColor;
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	static c7ljpMiDHFSy1VA0TfYY()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		wu8jste4lANirxlXL7dR();
	}

	internal static bool oTmhHBelKX4yFMscMJ0W()
	{
		return sj02fAelrHYvWK1QY23D == null;
	}

	internal static c7ljpMiDHFSy1VA0TfYY C2klK1elmhYuCpV0ofXN()
	{
		return sj02fAelrHYvWK1QY23D;
	}

	internal static int A7XLUYelh2SLjOXuQcNs(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static bool fJ5B8helwVMoKJXOLwA8(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static int oGL3sCel73SDomcldNLo(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static Color SZahOeel8eAaOSNSkVi4()
	{
		return Colors.Black;
	}

	internal static Color GyqkgtelArpmboTXQw4a()
	{
		return Colors.Silver;
	}

	internal static DateTime aUvdW7elPmpB6q1sxkyy()
	{
		return TimeHelper.GetLocalTimeWithNtpCorrection();
	}

	internal static object yY8QmLelJ7lokUc69Hr9(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static DateTime HH24PSelFDpAy5EQdsmK(object P_0)
	{
		return ((IChartCluster)P_0).Time;
	}

	internal static object ORqSkWel3wcvhWJlHfQZ(object P_0)
	{
		return ((IChartSymbol)P_0).Code;
	}

	internal static DateTime kxA0sselpB2Fvnhn7YYx(object P_0, object P_1)
	{
		return ((C9uTJdGH8bibVknh46Q6)P_0).GetCurrentPlayerTime((string)P_1);
	}

	internal static TimeSpan ecnx0delucXVfYh4oTJL(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static int aMAoGXelzrJ6eeH45Pqc(object P_0)
	{
		return ((IChartPeriod)P_0).Interval;
	}

	internal static int YV8ujCe4071ghpjfc8Ki(object P_0)
	{
		return ((IChartCluster)P_0).Trades;
	}

	internal static object LOwOoTe42CSQUg7VWSPy(object P_0)
	{
		return ((IChartCanvas)P_0).ChartFont;
	}

	internal static object F4P8R0e4HIeNJCD6ySYY(object P_0)
	{
		return ((XFont)P_0).Name;
	}

	internal static double hK33gNe4fPpbOnSdPyZM(double P_0, double P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void MPPjc0e49NDvw8nVXLYb(object P_0, object P_1, Rect P_2)
	{
		((DxVisualQueue)P_0).FillRectangle((XBrush)P_1, P_2);
	}

	internal static void FQFMS7e4nncJm9fmMWLh(object P_0, object P_1, object P_2, object P_3, Rect P_4, XTextAlignment P_5)
	{
		((DxVisualQueue)P_0).DrawString((string)P_1, (XFont)P_2, (XBrush)P_3, P_4, P_5);
	}

	internal static object KIKU3Pe4GtVvDLwVxUCo(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static ChartPeriodType CfDfu8e4Y5C5lVWsNIM0(object P_0)
	{
		return ((IChartPeriod)P_0).Type;
	}

	internal static bool tPwtnAe4o7lC8ltOpGw7(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static XColor TZSwCae4vgjafyTLG5ZW(object P_0)
	{
		return ((IChartTheme)P_0).ChartFontColor;
	}

	internal static BarTimerLocation iRvOIce4Brax7aU2XkGo(object P_0)
	{
		return ((c7ljpMiDHFSy1VA0TfYY)P_0).Location;
	}

	internal static int u7rSjhe4aQVmweX5trVS(object P_0)
	{
		return ((c7ljpMiDHFSy1VA0TfYY)P_0).OffsetY;
	}

	internal static int uFGlBme4iPNfatTwNUYU(object P_0)
	{
		return ((c7ljpMiDHFSy1VA0TfYY)P_0).TextSize;
	}

	internal static void wu8jste4lANirxlXL7dR()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
