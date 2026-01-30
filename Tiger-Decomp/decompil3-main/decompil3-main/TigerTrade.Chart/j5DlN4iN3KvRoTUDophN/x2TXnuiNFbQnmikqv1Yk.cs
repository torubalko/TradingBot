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
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace j5DlN4iN3KvRoTUDophN;

[DataContract(Name = "CumulativeDeltaIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
[Indicator("CumulativeDelta", "CumulativeDelta", false, Type = typeof(x2TXnuiNFbQnmikqv1Yk))]
internal sealed class x2TXnuiNFbQnmikqv1Yk : IndicatorBase
{
	private class dNCXEFirVmPpKkyHSPvn
	{
		public long bLlirC5r4vm;

		public long BtlirrXSjdA;

		public long CQIirK9bmno;

		public long Close;

		public int EFeirmS67S1;

		internal static dNCXEFirVmPpKkyHSPvn SP0JI1eUY4PnQTvVHPAG;

		public dNCXEFirVmPpKkyHSPvn()
		{
			tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
			EFeirmS67S1 = -1;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_90e464bd7efc478ab3dc53f1263e96d9 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static dNCXEFirVmPpKkyHSPvn()
		{
			RmsPBgeUBVke7LMLyZhM();
			ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
		}

		internal static bool Ho9AfveUo1b1qZYLg6ME()
		{
			return SP0JI1eUY4PnQTvVHPAG == null;
		}

		internal static dNCXEFirVmPpKkyHSPvn EikJKyeUv3nO0gwfyy9N()
		{
			return SP0JI1eUY4PnQTvVHPAG;
		}

		internal static void RmsPBgeUBVke7LMLyZhM()
		{
			yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		}
	}

	private IndicatorPeriodType nrXikBXYkNX;

	private IndicatorViewType u0Yika2MFm8;

	private XBrush cbNikif0YWH;

	private XPen QtFiklOZLUE;

	private XColor eaXik4L7eZm;

	private XBrush cTyikDiqwln;

	private XPen Eh3ikbWYA0x;

	private XColor cUCikNcNE3U;

	private XBrush cCMikk2XoJ9;

	private XPen MMgik1MHlNJ;

	private XColor nJXik5Ojnhr;

	private int ev5ikSbeMEP;

	private int KDiikxJKM06;

	private List<dNCXEFirVmPpKkyHSPvn> O6SikLsdlyr;

	internal static x2TXnuiNFbQnmikqv1Yk Ro9llYebbivHyMMQcPxs;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsPeriod")]
	[DataMember(Name = "Period")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	public IndicatorPeriodType Period
	{
		get
		{
			return nrXikBXYkNX;
		}
		set
		{
			if (indicatorPeriodType != nrXikBXYkNX)
			{
				nrXikBXYkNX = indicatorPeriodType;
				Clear();
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_05d722d67d874d6fa7bb056304182294 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				OnPropertyChanged((string)Cofn3Neb1LZuIrOXnyg1(0x4662F6AF ^ 0x46627119));
			}
		}
	}

	[DataMember(Name = "Type")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsType")]
	public IndicatorViewType Type
	{
		get
		{
			return u0Yika2MFm8;
		}
		set
		{
			if (indicatorViewType == u0Yika2MFm8)
			{
				return;
			}
			u0Yika2MFm8 = indicatorViewType;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1306877528 ^ -1306908874));
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9efcb4330c5f47718251cef6f720f6e6 == 0)
					{
						num = 1;
					}
					break;
				case 1:
					return;
				case 2:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-2108526692 ^ -2108490108));
					OnPropertyChanged((string)Cofn3Neb1LZuIrOXnyg1(-710503328 ^ -710541292));
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x2D3134C9 ^ 0x2D31A04F));
					OnPropertyChanged((string)Cofn3Neb1LZuIrOXnyg1(-671204305 ^ -671171929));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember(Name = "UpColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsUpColor")]
	public XColor UpColor
	{
		get
		{
			return eaXik4L7eZm;
		}
		set
		{
			if (yYKVV2eb5dLtMTyp1ylH(xColor, eaXik4L7eZm))
			{
				return;
			}
			eaXik4L7eZm = xColor;
			cbNikif0YWH = new XBrush(eaXik4L7eZm);
			QtFiklOZLUE = new XPen(cbNikif0YWH, 1);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_24c9cc26b2134967befd52549b065ea0 != 0)
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
				OnPropertyChanged((string)Cofn3Neb1LZuIrOXnyg1(-57768881 ^ -57798597));
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_cb7997a2f13d4554bdeb2d98b82239ee == 0)
				{
					num = 1;
				}
			}
		}
	}

	[DataMember(Name = "DownColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsDownColor")]
	public XColor DownColor
	{
		get
		{
			return cUCikNcNE3U;
		}
		set
		{
			if (xColor == cUCikNcNE3U)
			{
				return;
			}
			cUCikNcNE3U = xColor;
			cTyikDiqwln = new XBrush(cUCikNcNE3U);
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f827d36f09784758a58ee73d00be2977 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-338769610 ^ -338797136));
					return;
				}
				Eh3ikbWYA0x = new XPen(cTyikDiqwln, 1);
				num = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_69212809764745e695cbac66765a5c5c != 0)
				{
					num = 1;
				}
			}
		}
	}

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineColor")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[DataMember(Name = "LineColor")]
	public XColor LineColor
	{
		get
		{
			return nJXik5Ojnhr;
		}
		set
		{
			if (yYKVV2eb5dLtMTyp1ylH(xColor, nJXik5Ojnhr))
			{
				return;
			}
			nJXik5Ojnhr = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
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
					cCMikk2XoJ9 = new XBrush(nJXik5Ojnhr);
					MMgik1MHlNJ = new XPen(cCMikk2XoJ9, LineWidth);
					OnPropertyChanged((string)Cofn3Neb1LZuIrOXnyg1(0x68C7EAE6 ^ 0x68C76C6E));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d == 0)
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

	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsLineWidth")]
	[DataMember(Name = "LineWidth")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	public int LineWidth
	{
		get
		{
			return ev5ikSbeMEP;
		}
		set
		{
			num = CAFBalebSyuT3gHmTUON(1, Math.Min(9, num));
			int num2;
			if (num == ev5ikSbeMEP)
			{
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b != 0)
				{
					num2 = 1;
				}
			}
			else
			{
				ev5ikSbeMEP = num;
				MMgik1MHlNJ = new XPen(cCMikk2XoJ9, ev5ikSbeMEP);
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e9f58003753b4aa88a036bb6f675d81b == 0)
				{
					num2 = 0;
				}
			}
			switch (num2)
			{
			case 1:
				return;
			}
			OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1009517961 ^ -1009550103));
		}
	}

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnEachTick;

	private List<dNCXEFirVmPpKkyHSPvn> Items => O6SikLsdlyr ?? (O6SikLsdlyr = new List<dNCXEFirVmPpKkyHSPvn>());

	public override bool IntegerValues => true;

	private void Clear()
	{
		KDiikxJKM06 = 0;
		EmiMkYebxi0Ulo8U0Ynm(Items);
	}

	public x2TXnuiNFbQnmikqv1Yk()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c6d928b106694fcbadc87b1b898a5509 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				Type = IndicatorViewType.Columns;
				UpColor = B80S0iebLubccK6qmeep(Color.FromArgb(byte.MaxValue, 30, 144, byte.MaxValue));
				DownColor = B80S0iebLubccK6qmeep(Color.FromArgb(byte.MaxValue, 178, 34, 34));
				num = 2;
				continue;
			case 2:
				LineColor = xuRKqSebeEBnn5BTP9P4(byte.MaxValue, 30, 144, byte.MaxValue);
				LineWidth = 1;
				return;
			}
			Period = IndicatorPeriodType.Day;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_676dd0a5ee95448585b63eb0094d7f85 != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		if (base.ClearData)
		{
			Clear();
		}
		double timeOffset = chiNs4ebsAjocwxh24N9(base.DataProvider.Symbol.Exchange);
		int num = 10;
		int num3 = default(int);
		IRawCluster rawCluster = default(IRawCluster);
		int num2 = default(int);
		dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn2 = default(dNCXEFirVmPpKkyHSPvn);
		long num4 = default(long);
		dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn = default(dNCXEFirVmPpKkyHSPvn);
		while (true)
		{
			int num5;
			dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn3;
			switch (num)
			{
			case 2:
				num3 = 1;
				switch (Period)
				{
				case IndicatorPeriodType.Month:
					num3 = gpd68TebEBbBVAM4uH7s(base.DataProvider.Period, ChartPeriodType.Month, 1, rawCluster.Time, timeOffset);
					break;
				case IndicatorPeriodType.Day:
					num3 = gpd68TebEBbBVAM4uH7s(SQLktHebjrIUicH8Um0n(base.DataProvider), ChartPeriodType.Day, 1, rawCluster.Time, timeOffset);
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num = 0;
					}
					continue;
				case IndicatorPeriodType.Week:
					num3 = gpd68TebEBbBVAM4uH7s(base.DataProvider.Period, ChartPeriodType.Week, 1, IJfbakebQ4KKecOB4CXi(rawCluster), timeOffset);
					break;
				}
				goto case 4;
			case 10:
				num2 = KDiikxJKM06;
				goto case 11;
			case 12:
				if (Items.Count < num2 + 1)
				{
					Items.Add(new dNCXEFirVmPpKkyHSPvn());
				}
				dNCXEFirVmPpKkyHSPvn2 = Items[num2];
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bf9361639de74e0d899574b5f9abd2dd != 0)
				{
					num = 0;
				}
				continue;
			case 7:
				num2++;
				num = 11;
				continue;
			case 3:
				dNCXEFirVmPpKkyHSPvn2.CQIirK9bmno = num4 + (rawCluster.DeltaLow - qcCZhjebd8Gl6XZ2VRCc(rawCluster));
				num = 7;
				continue;
			case 8:
				dNCXEFirVmPpKkyHSPvn2.BtlirrXSjdA = num4 + (rawCluster.DeltaHigh - rawCluster.Delta);
				num = 3;
				continue;
			case 9:
				num4 = (dNCXEFirVmPpKkyHSPvn2.Close = num4 + rawCluster.Delta);
				num5 = 8;
				goto IL_0005;
			case 1:
				if (QxF67EebcKqG2nwBrPv4(Items) <= num2)
				{
					goto IL_0079;
				}
				dNCXEFirVmPpKkyHSPvn3 = Items[num2 - 1];
				break;
			case 4:
				num4 = 0L;
				if (num3 == dNCXEFirVmPpKkyHSPvn.EFeirmS67S1)
				{
					num = 14;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_331783b4349f408da28eb7270800e8f2 == 0)
					{
						num = 6;
					}
					continue;
				}
				goto case 5;
			case 11:
				if (num2 < njQ51TebgE51er33vSkr(base.DataProvider))
				{
					rawCluster = (IRawCluster)qoJtLqebXX22j1bYIx2U(base.DataProvider, num2);
					num = 12;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
					{
						num = 12;
					}
				}
				else
				{
					KDiikxJKM06 = Math.Max(base.DataProvider.Count - 2, 0);
					num = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_a103e6559ac3474e9e79ab00912c861c == 0)
					{
						num = 6;
					}
				}
				continue;
			case 13:
				dNCXEFirVmPpKkyHSPvn2.bLlirC5r4vm = num4;
				num = 9;
				continue;
			case 6:
				return;
			case 14:
				num4 = dNCXEFirVmPpKkyHSPvn.Close;
				num5 = 5;
				goto IL_0005;
			default:
				if (num2 > 0)
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_265fe44b237843c0af011f50c2e58924 != 0)
					{
						num = 1;
					}
					continue;
				}
				goto IL_0079;
			case 5:
				{
					dNCXEFirVmPpKkyHSPvn2.EFeirmS67S1 = num3;
					num = 10;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_22d3e151413e4c568d725fa731c4c03c != 0)
					{
						num = 13;
					}
					continue;
				}
				IL_0079:
				dNCXEFirVmPpKkyHSPvn3 = new dNCXEFirVmPpKkyHSPvn();
				break;
				IL_0005:
				num = num5;
				continue;
			}
			dNCXEFirVmPpKkyHSPvn = dNCXEFirVmPpKkyHSPvn3;
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_77d26139d1074373ba3d17cb18b3ec16 == 0)
			{
				num = 2;
			}
		}
	}

	public override bool GetMinMax(out double P_0, out double P_1)
	{
		int num = 14;
		int num2 = num;
		int num6 = default(int);
		long num4 = default(long);
		long num5 = default(long);
		int num3 = default(int);
		dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn = default(dNCXEFirVmPpKkyHSPvn);
		while (true)
		{
			switch (num2)
			{
			case 10:
				num6++;
				goto case 9;
			case 3:
				if (Items.Count != 0)
				{
					num4 = long.MaxValue;
					num2 = 11;
					continue;
				}
				goto case 12;
			case 12:
				return false;
			case 4:
			case 6:
				if (num4 > num5)
				{
					return false;
				}
				P_0 = (double)base.DataProvider.Symbol.GetSize(num4);
				P_1 = R5bglbebMsWNPD8hOUeE(base.DataProvider.Symbol.GetSize(num5));
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_929b6fa00f634070a51f43668e9cc32e != 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
			{
				if (num6 >= Gn0tBQeb6kGIDZ72rAnv(base.Canvas))
				{
					num2 = 4;
					continue;
				}
				int num7 = DNbSLTebRKRO98PXB1cU(base.Canvas, num6);
				if (num7 >= 0 && num7 < Items.Count)
				{
					dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn2 = Items[num7];
					if (num4 > dNCXEFirVmPpKkyHSPvn2.CQIirK9bmno)
					{
						num4 = dNCXEFirVmPpKkyHSPvn2.CQIirK9bmno;
					}
					if (num5 < dNCXEFirVmPpKkyHSPvn2.BtlirrXSjdA)
					{
						num5 = dNCXEFirVmPpKkyHSPvn2.BtlirrXSjdA;
						num2 = 10;
						if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e74f04d60e394f2bbc3b9757a3df6bbb != 0)
						{
							num2 = 6;
						}
						continue;
					}
				}
				goto case 10;
			}
			case 13:
				P_1 = double.MinValue;
				num2 = 3;
				continue;
			default:
				return true;
			case 8:
				num3++;
				num2 = 7;
				continue;
			case 14:
				P_0 = double.MaxValue;
				num2 = 13;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_96ae262178274a62bc28b3fded6ea751 != 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				if (num4 > dNCXEFirVmPpKkyHSPvn.Close)
				{
					num4 = dNCXEFirVmPpKkyHSPvn.Close;
				}
				if (num5 < dNCXEFirVmPpKkyHSPvn.Close)
				{
					num5 = dNCXEFirVmPpKkyHSPvn.Close;
					num2 = 8;
					continue;
				}
				goto case 8;
			case 5:
			{
				int index = base.Canvas.GetIndex(num3);
				if (index >= 0 && index < Items.Count)
				{
					dNCXEFirVmPpKkyHSPvn = Items[index];
					num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0fb675c372064c2d9cad17812d8d65ed == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 8;
			}
			case 11:
				num5 = long.MinValue;
				if (Type == IndicatorViewType.Candles)
				{
					num6 = 0;
					num2 = 9;
					continue;
				}
				break;
			case 2:
			case 7:
				if (num3 >= base.Canvas.Count)
				{
					num2 = 6;
					continue;
				}
				goto case 5;
			case 15:
				break;
			}
			num3 = 0;
			num2 = 2;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_93fc62fe1d9a4f94b94826853da8d94d != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void Render(DxVisualQueue P_0)
	{
		IChartSymbol chartSymbol = (IChartSymbol)hwpF3DebOSkCVPiSXbIO(base.DataProvider);
		IndicatorViewType indicatorViewType = Type;
		int num = 8;
		double num12 = default(double);
		dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn3 = default(dNCXEFirVmPpKkyHSPvn);
		int num10 = default(int);
		double y = default(double);
		bool flag = default(bool);
		int num2 = default(int);
		int index2 = default(int);
		int num4 = default(int);
		int num3 = default(int);
		double num11 = default(double);
		int index = default(int);
		Point[] array = default(Point[]);
		int num6 = default(int);
		int num13 = default(int);
		XPen xPen = default(XPen);
		int num7 = default(int);
		double num5 = default(double);
		int num9 = default(int);
		double x = default(double);
		int num17 = default(int);
		int num16 = default(int);
		XBrush brush2 = default(XBrush);
		int num14 = default(int);
		int num8 = default(int);
		while (true)
		{
			Rect rect;
			XBrush brush;
			switch (num)
			{
			case 3:
				return;
			case 4:
				num12 = GetY(F6WUGOebtSnO3TngWdOy(chartSymbol, dNCXEFirVmPpKkyHSPvn3.Close));
				num10 = (int)y - (int)num12;
				flag = num10 > 0;
				if ((double)num10 < 0.0)
				{
					num = 7;
					continue;
				}
				goto IL_0588;
			case 17:
			case 18:
				if (num2 >= base.Canvas.Count)
				{
					return;
				}
				index2 = base.Canvas.GetIndex(num2);
				if (index2 >= 0 && index2 < QxF67EebcKqG2nwBrPv4(Items))
				{
					num = 16;
					continue;
				}
				goto case 19;
			case 15:
				if (num4 > 1)
				{
					num = 21;
					continue;
				}
				goto case 5;
			case 14:
				num3++;
				goto IL_04b5;
			case 20:
				num11 = Math.Max(uasS2KebWtmQq0XrE7sv(base.Canvas) - 1.0, 1.0);
				num = 6;
				continue;
			case 22:
				if (index >= 0 && index < Items.Count)
				{
					dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn2 = Items[index];
					double x2 = base.Canvas.GetX(index);
					double y2 = GetY(chartSymbol.GetSize(dNCXEFirVmPpKkyHSPvn2.Close));
					array[num3] = new Point(x2, y2);
					num = 14;
					continue;
				}
				goto case 14;
			case 7:
				num12 += (double)num10;
				num10 = -num10;
				goto IL_0588;
			case 5:
				num6++;
				goto case 9;
			case 21:
				if (num13 == 0)
				{
					xnHxY5ebInfN5AQ2BnV7(P_0, xPen, new Point((double)num7 - num5, num9), new Point((double)num7 + num5 + 1.0, num9));
					goto case 5;
				}
				goto case 26;
			case 11:
				x = base.Canvas.GetX(index2);
				num = 4;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
				{
					num = 1;
				}
				continue;
			case 27:
			{
				xnHxY5ebInfN5AQ2BnV7(P_0, xPen, new Point(num7, num17), new Point(num7, num16));
				int num18 = 15;
				num = num18;
				continue;
			}
			case 2:
				P_0.DrawLines(MMgik1MHlNJ, array);
				num = 3;
				continue;
			case 16:
				dNCXEFirVmPpKkyHSPvn3 = Items[index2];
				num = 11;
				continue;
			case 26:
				P_0.FillRectangle(brush2, new Rect((double)num7 - num5, num9, num5 * 2.0 + 1.0, num13));
				num = 5;
				continue;
			case 25:
				if (num14 >= 0 && num14 < QxF67EebcKqG2nwBrPv4(Items))
				{
					num = 2;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_239bac6736df482c97654364ff867959 == 0)
					{
						num = 13;
					}
					continue;
				}
				goto case 5;
			case 13:
			{
				dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn = Items[num14];
				bool num15 = dNCXEFirVmPpKkyHSPvn.Close > dNCXEFirVmPpKkyHSPvn.bLlirC5r4vm;
				num7 = (int)MS0t7mebqLNkvUwcFKNl(base.Canvas, num14);
				int val = (int)GetY(chartSymbol.GetSize(dNCXEFirVmPpKkyHSPvn.bLlirC5r4vm));
				num8 = (int)GetY(chartSymbol.GetSize(dNCXEFirVmPpKkyHSPvn.BtlirrXSjdA));
				num16 = (int)GetY(chartSymbol.GetSize(dNCXEFirVmPpKkyHSPvn.CQIirK9bmno));
				int val2 = (int)GetY(chartSymbol.GetSize(dNCXEFirVmPpKkyHSPvn.Close));
				num9 = Math.Min(val, val2);
				num17 = Math.Max(val, val2);
				num13 = num17 - num9;
				brush2 = (num15 ? cbNikif0YWH : cTyikDiqwln);
				xPen = (num15 ? QtFiklOZLUE : Eh3ikbWYA0x);
				if (num13 != 0)
				{
					num = 28;
					continue;
				}
				goto case 23;
			}
			case 28:
				if (num4 > 1)
				{
					P_0.DrawLine(xPen, new Point(num7, num8), new Point(num7, num9));
					num = 27;
					continue;
				}
				num = 3;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_84ff815db08e468bb177d195221f5fb1 != 0)
				{
					num = 23;
				}
				continue;
			case 1:
				return;
			case 8:
				switch (indicatorViewType)
				{
				case IndicatorViewType.Line:
					if (Items.Count < 2)
					{
						return;
					}
					array = new Point[Gn0tBQeb6kGIDZ72rAnv(base.Canvas)];
					num = 10;
					break;
				case IndicatorViewType.Candles:
					num4 = (int)(base.Canvas.ColumnWidth * base.Canvas.ColumnPercent + 0.4);
					num5 = Math.Max((int)((double)num4 / 2.0), 1.0);
					num6 = 0;
					num = 3;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_0d19152025c94f0b9078922cd1ec6aff == 0)
					{
						num = 9;
					}
					break;
				default:
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
					{
						num = 1;
					}
					break;
				case IndicatorViewType.Columns:
					y = GetY(0.0);
					num = 20;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 == 0)
					{
						num = 9;
					}
					break;
				}
				continue;
			default:
				P_0.DrawLine(xPen, new Point(num7, num8), new Point(num7, num16));
				goto case 15;
			case 10:
				num3 = 0;
				goto IL_04b5;
			case 24:
				return;
			case 6:
				num2 = 0;
				num = 17;
				continue;
			case 19:
				num2++;
				num = 18;
				continue;
			case 9:
				if (num6 < base.Canvas.Count)
				{
					num14 = DNbSLTebRKRO98PXB1cU(base.Canvas, num6);
					num = 25;
				}
				else
				{
					num = 24;
				}
				continue;
			case 23:
				if (num8 == num16)
				{
					num16++;
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c != 0)
					{
						num = 0;
					}
					continue;
				}
				goto default;
			case 12:
				{
					P_0.DrawLine(flag ? QtFiklOZLUE : Eh3ikbWYA0x, x, num12, x, num12 + (double)num10);
					goto case 19;
				}
				IL_0588:
				num10 = Math.Max(1, num10);
				if (num11 > 1.0)
				{
					rect = new Rect(x - num11 / 2.0, num12, num11, num10);
					brush = (flag ? cbNikif0YWH : cTyikDiqwln);
					break;
				}
				goto case 12;
				IL_04b5:
				if (num3 < base.Canvas.Count)
				{
					index = base.Canvas.GetIndex(num3);
					num = 22;
					continue;
				}
				num = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c != 0)
				{
					num = 1;
				}
				continue;
			}
			P_0.FillRectangle(brush, rect);
			num = 19;
		}
	}

	public override List<IndicatorValueInfo> GetValues(int cursorPos)
	{
		List<IndicatorValueInfo> list = new List<IndicatorValueInfo>();
		if (cursorPos >= 0 && cursorPos < Items.Count)
		{
			string value = base.Canvas.FormatValue((double)base.DataProvider.Symbol.GetSize(Items[cursorPos].Close));
			list.Add(new IndicatorValueInfo(value, (Type == IndicatorViewType.Line) ? cCMikk2XoJ9 : base.Canvas.Theme.ChartFontBrush));
		}
		return list;
	}

	public override void GetLabels(ref List<IndicatorLabelInfo> P_0)
	{
		if (QxF67EebcKqG2nwBrPv4(Items) == 0)
		{
			return;
		}
		int num;
		dNCXEFirVmPpKkyHSPvn dNCXEFirVmPpKkyHSPvn = default(dNCXEFirVmPpKkyHSPvn);
		double num3 = default(double);
		bool flag = default(bool);
		IndicatorViewType indicatorViewType = default(IndicatorViewType);
		if (base.DataProvider.Count <= base.Canvas.Start)
		{
			num = 8;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_21e32bb06909412aa85d75d125f55184 != 0)
			{
				num = 6;
			}
		}
		else
		{
			int num2 = njQ51TebgE51er33vSkr(base.DataProvider) - 1 - base.Canvas.Start;
			if (num2 >= 0 || num2 < QxF67EebcKqG2nwBrPv4(Items))
			{
				dNCXEFirVmPpKkyHSPvn = Items[num2];
				num3 = (double)((IChartSymbol)hwpF3DebOSkCVPiSXbIO(base.DataProvider)).GetSize(dNCXEFirVmPpKkyHSPvn.Close);
				if (Type != IndicatorViewType.Line)
				{
					flag = false;
					indicatorViewType = Type;
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b == 0)
					{
						num = 1;
					}
				}
				else
				{
					P_0.Add(new IndicatorLabelInfo(num3, nJXik5Ojnhr));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c47f9ac95ef6414e90317ead219c477c == 0)
					{
						num = 0;
					}
				}
			}
			else
			{
				num = 4;
			}
		}
		while (true)
		{
			int num4;
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				switch (indicatorViewType)
				{
				case IndicatorViewType.Columns:
				case IndicatorViewType.Line:
					flag = !double.IsNaN(num3) && num3 > 0.0;
					goto end_IL_0009;
				case IndicatorViewType.Candles:
					break;
				default:
					goto end_IL_0009;
				}
				goto case 5;
			case 3:
				return;
			case 2:
				num4 = ((dNCXEFirVmPpKkyHSPvn.Close > dNCXEFirVmPpKkyHSPvn.bLlirC5r4vm) ? 1 : 0);
				goto IL_022b;
			case 5:
				if (double.IsNaN(num3))
				{
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 != 0)
					{
						num = 6;
					}
					continue;
				}
				goto case 2;
			case 8:
				return;
			case 4:
				return;
			case 6:
				num4 = 0;
				goto IL_022b;
			case 7:
				break;
				IL_022b:
				flag = (byte)num4 != 0;
				num = 7;
				continue;
				end_IL_0009:
				break;
			}
			P_0.Add(new IndicatorLabelInfo(num3, flag ? UpColor : DownColor));
			num = 3;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 == 0)
			{
				num = 0;
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
			case 1:
				UpColor = P_0.PaletteColor6;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1e4f0311079548309df28e40c8b3397b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				DownColor = P_0.PaletteColor7;
				LineColor = P_0.GetNextColor();
				base.ApplyColors(P_0);
				return;
			}
		}
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		int num = 1;
		int num2 = num;
		x2TXnuiNFbQnmikqv1Yk x2TXnuiNFbQnmikqv1Yk2 = default(x2TXnuiNFbQnmikqv1Yk);
		while (true)
		{
			switch (num2)
			{
			case 2:
				LineWidth = x2TXnuiNFbQnmikqv1Yk2.LineWidth;
				base.CopyTemplate(P_0, P_1);
				return;
			case 1:
				x2TXnuiNFbQnmikqv1Yk2 = (x2TXnuiNFbQnmikqv1Yk)P_0;
				num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3f2f2649293a4bcf83895b4d6c7abca6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Period = x2TXnuiNFbQnmikqv1Yk2.Period;
				Type = x2TXnuiNFbQnmikqv1Yk2.Type;
				UpColor = x2TXnuiNFbQnmikqv1Yk2.UpColor;
				DownColor = x2TXnuiNFbQnmikqv1Yk2.DownColor;
				num2 = 3;
				break;
			case 3:
				LineColor = S71SGOebUaeZZqNML84s(x2TXnuiNFbQnmikqv1Yk2);
				num2 = 2;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_95275e3d621141038abe728ac8c7fa6c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override string ToString()
	{
		return string.Format((string)Cofn3Neb1LZuIrOXnyg1(-2063361985 ^ -2063397725), base.Name, Period);
	}

	public override bool GetPropertyVisibility(string P_0)
	{
		if (!(P_0 == yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(-1522697859 ^ -1522663453)) && !vnGVSXebTkSIZV2U01x7(P_0, Cofn3Neb1LZuIrOXnyg1(-1127423276 ^ -1127455652)))
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_59aa80f4e54b43b381fcc4e95a4cfa2b != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return true;
				}
				if (!(P_0 == (string)Cofn3Neb1LZuIrOXnyg1(0x34407BB ^ 0x34493CF)) && !vnGVSXebTkSIZV2U01x7(P_0, Cofn3Neb1LZuIrOXnyg1(-842040449 ^ -842010631)))
				{
					num = 1;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
					{
						num = 1;
					}
					continue;
				}
				return Type != IndicatorViewType.Line;
			}
		}
		return Type == IndicatorViewType.Line;
	}

	static x2TXnuiNFbQnmikqv1Yk()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
		dcwv6Oeby0kh5RDmF6xa();
	}

	internal static object Cofn3Neb1LZuIrOXnyg1(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static bool ncemTnebNcacXMPonDaB()
	{
		return Ro9llYebbivHyMMQcPxs == null;
	}

	internal static x2TXnuiNFbQnmikqv1Yk cL2QgWebkKRYlKMnllSf()
	{
		return Ro9llYebbivHyMMQcPxs;
	}

	internal static bool yYKVV2eb5dLtMTyp1ylH(XColor P_0, XColor P_1)
	{
		return P_0 == P_1;
	}

	internal static int CAFBalebSyuT3gHmTUON(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void EmiMkYebxi0Ulo8U0Ynm(object P_0)
	{
		((List<dNCXEFirVmPpKkyHSPvn>)P_0).Clear();
	}

	internal static XColor B80S0iebLubccK6qmeep(Color P_0)
	{
		return P_0;
	}

	internal static Color xuRKqSebeEBnn5BTP9P4(byte P_0, byte P_1, byte P_2, byte P_3)
	{
		return Color.FromArgb(P_0, P_1, P_2, P_3);
	}

	internal static double chiNs4ebsAjocwxh24N9(object P_0)
	{
		return TimeHelper.GetSessionOffset((string)P_0);
	}

	internal static object qoJtLqebXX22j1bYIx2U(object P_0, int i)
	{
		return ((IChartDataProvider)P_0).GetRawCluster(i);
	}

	internal static int QxF67EebcKqG2nwBrPv4(object P_0)
	{
		return ((List<dNCXEFirVmPpKkyHSPvn>)P_0).Count;
	}

	internal static object SQLktHebjrIUicH8Um0n(object P_0)
	{
		return ((IChartDataProvider)P_0).Period;
	}

	internal static int gpd68TebEBbBVAM4uH7s(object P_0, ChartPeriodType type, int interval, DateTime dateTime, double timeOffset)
	{
		return ((IChartPeriod)P_0).GetSequence(type, interval, dateTime, timeOffset);
	}

	internal static DateTime IJfbakebQ4KKecOB4CXi(object P_0)
	{
		return ((IRawCluster)P_0).Time;
	}

	internal static long qcCZhjebd8Gl6XZ2VRCc(object P_0)
	{
		return ((IRawCluster)P_0).Delta;
	}

	internal static int njQ51TebgE51er33vSkr(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static int DNbSLTebRKRO98PXB1cU(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetIndex(i);
	}

	internal static int Gn0tBQeb6kGIDZ72rAnv(object P_0)
	{
		return ((IChartCanvas)P_0).Count;
	}

	internal static double R5bglbebMsWNPD8hOUeE(decimal P_0)
	{
		return (double)P_0;
	}

	internal static object hwpF3DebOSkCVPiSXbIO(object P_0)
	{
		return ((IChartDataProvider)P_0).Symbol;
	}

	internal static double MS0t7mebqLNkvUwcFKNl(object P_0, int i)
	{
		return ((IChartCanvas)P_0).GetX(i);
	}

	internal static void xnHxY5ebInfN5AQ2BnV7(object P_0, object P_1, Point P_2, Point P_3)
	{
		((DxVisualQueue)P_0).DrawLine((XPen)P_1, P_2, P_3);
	}

	internal static double uasS2KebWtmQq0XrE7sv(object P_0)
	{
		return ((IChartCanvas)P_0).ColumnWidth;
	}

	internal static decimal F6WUGOebtSnO3TngWdOy(object P_0, long rawSize)
	{
		return ((IChartSymbol)P_0).GetSize(rawSize);
	}

	internal static XColor S71SGOebUaeZZqNML84s(object P_0)
	{
		return ((x2TXnuiNFbQnmikqv1Yk)P_0).LineColor;
	}

	internal static bool vnGVSXebTkSIZV2U01x7(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void dcwv6Oeby0kh5RDmF6xa()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
