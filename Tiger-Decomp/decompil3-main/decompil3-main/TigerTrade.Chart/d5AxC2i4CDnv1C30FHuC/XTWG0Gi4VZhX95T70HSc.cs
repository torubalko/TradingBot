using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using aAa0wvLVte7CLQrFHlCF;
using AYIrOli4loNjInofRIKt;
using bBTBBlLyIEGksS1k92Xn;
using BpieHJLVgS3G3qRoeH8Z;
using ikPbM9i4qLEHKNuJMsoj;
using MIGrPZi4v1c8N1FGp0Vb;
using nPFdaZi4fnexuP6NaG7M;
using TigerTrade.Chart.Alerts;
using TigerTrade.Chart.Base;
using TigerTrade.Chart.Data;
using TigerTrade.Chart.Indicators.Common;
using TigerTrade.Chart.Indicators.Enums;
using TigerTrade.Core.Utils.Time;
using TigerTrade.Dx;

namespace d5AxC2i4CDnv1C30FHuC;

[Indicator("BarSearch", "BarSearch", true, Type = typeof(XTWG0Gi4VZhX95T70HSc))]
[DataContract(Name = "BarSearchIndicator", Namespace = "http://schemas.datacontract.org/2004/07/TigerTrade.Chart.Indicators")]
internal sealed class XTWG0Gi4VZhX95T70HSc : IndicatorBase, IContainsConditions
{
	private XBrush QkMi4JqKYyg;

	private XPen QvZi4FeIpP9;

	private XColor ft4i43JpPVj;

	private List<TmsYvii4iJ2QGnYSPoKC> btgi4puf9En;

	private ChartAlertSettings dd1i4uoFFOs;

	private int aIyi4zvGDT1;

	private Dictionary<int, bool> ljaiD0sL8Wr;

	private VUKqWxi4OihlVjONbNYE HQIiD2KOGRc;

	private static XTWG0Gi4VZhX95T70HSc wfOFwield8iYpc9ewl9c;

	[Browsable(false)]
	public override ChartDataType ChartDataType => ChartDataType.Bar;

	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsStyle")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsSelectionColor")]
	[DataMember(Name = "SelectionColor")]
	public XColor SelectionColor
	{
		get
		{
			return ft4i43JpPVj;
		}
		set
		{
			if (xColor == ft4i43JpPVj)
			{
				return;
			}
			ft4i43JpPVj = xColor;
			int num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_c0837a76d79b485ab2d4c68f864e6ad9 == 0)
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
					QkMi4JqKYyg = new XBrush(ft4i43JpPVj);
					QvZi4FeIpP9 = new XPen(QkMi4JqKYyg, 1);
					OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0xECA3F28 ^ 0xECAAF38));
					num = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_f6da77aaa5ff4528962aa5751faa8c0b == 0)
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

	[DataMember(Name = "Conditions")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsParametersConditions")]
	public List<TmsYvii4iJ2QGnYSPoKC> Conditions
	{
		get
		{
			return btgi4puf9En ?? (btgi4puf9En = new List<TmsYvii4iJ2QGnYSPoKC>());
		}
		set
		{
			btgi4puf9En = list;
		}
	}

	[Browsable(true)]
	[DataMember(Name = "Alert")]
	[IY0CXri4H6cGjAdYCVwG("ChartIndicatorsParameters")]
	[ye30Hki4oR4RQBdkwwe7("ChartIndicatorsAlert")]
	public ChartAlertSettings Alert
	{
		get
		{
			return dd1i4uoFFOs ?? (dd1i4uoFFOs = new ChartAlertSettings());
		}
		set
		{
			if (!object.Equals(objA, dd1i4uoFFOs))
			{
				dd1i4uoFFOs = objA;
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(--146713930 ^ 0x8BED0CC));
				int num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_daf6cb945fbc4987a518363c06ce80c2 != 0)
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

	[Browsable(false)]
	public override bool ShowIndicatorValues => false;

	[Browsable(false)]
	public override bool ShowIndicatorLabels => false;

	[Browsable(false)]
	public override IndicatorCalculation Calculation => IndicatorCalculation.OnBarClose;

	[SpecialName]
	private Dictionary<int, bool> jcXi4AZnJd7()
	{
		return ljaiD0sL8Wr ?? (ljaiD0sL8Wr = new Dictionary<int, bool>());
	}

	private void Clear()
	{
		aIyi4zvGDT1 = 0;
		jcXi4AZnJd7().Clear();
		int num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
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
			using (List<TmsYvii4iJ2QGnYSPoKC>.Enumerator enumerator = Conditions.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current.Clear();
				}
				int num2 = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_b716f3fea2e54566baa0901838405849 != 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
			VUKqWxi4OihlVjONbNYE hQIiD2KOGRc = HQIiD2KOGRc;
			if (hQIiD2KOGRc == null)
			{
				return;
			}
			hQIiD2KOGRc.Clear();
			num = 1;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9907a2dfacd24021aae0fe30c599035f != 0)
			{
				num = 1;
			}
		}
	}

	protected override void Execute()
	{
		int num = 9;
		int num2 = num;
		int num4 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		List<TmsYvii4iJ2QGnYSPoKC>.Enumerator enumerator = default(List<TmsYvii4iJ2QGnYSPoKC>.Enumerator);
		TmsYvii4iJ2QGnYSPoKC current = default(TmsYvii4iJ2QGnYSPoKC);
		while (true)
		{
			switch (num2)
			{
			case 5:
				aIyi4zvGDT1 = Math.Max(base.DataProvider.Count - 2, 0);
				return;
			case 4:
			case 10:
				num4++;
				num2 = 6;
				continue;
			case 3:
				if (!flag)
				{
					num2 = 7;
					continue;
				}
				goto IL_0273;
			case 2:
				jcXi4AZnJd7()[num4] = flag2;
				if (!flag2)
				{
					num2 = 4;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_16f1ffbaff15428c840c488e7b8380f5 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				if (aIyi4zvGDT1 > 0)
				{
					DZ7i4rokvHJ(num4);
					num2 = 10;
					continue;
				}
				goto case 4;
			case 7:
				if (!base.ClearData)
				{
					break;
				}
				goto IL_0273;
			case 8:
				if (_propChanged)
				{
					flag = true;
				}
				enumerator = Conditions.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_3619c4e2195548a982d8ce7a7eb0208e == 0)
				{
					num2 = 0;
				}
				continue;
			case 9:
				flag = false;
				num2 = 8;
				continue;
			default:
				if (num4 < vE5q0PelMpvJ04hPSbsY(base.DataProvider))
				{
					if (!jcXi4AZnJd7().ContainsKey(num4))
					{
						jcXi4AZnJd7().Add(num4, value: false);
					}
					flag2 = Conditions.Count > 0;
					enumerator = Conditions.GetEnumerator();
					try
					{
						int num5;
						while (true)
						{
							if (enumerator.MoveNext())
							{
								if (!enumerator.Current.Check(base.Helper, num4))
								{
									flag2 = false;
									num5 = 1;
									if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_35044ecf03034683aa5038f38795ec31 != 0)
									{
										num5 = 1;
									}
									break;
								}
								continue;
							}
							num5 = 0;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
							{
								num5 = 0;
							}
							break;
						}
						switch (num5)
						{
						case 1:
							break;
						case 0:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 2;
				}
				num2 = 5;
				continue;
			case 1:
				{
					try
					{
						while (true)
						{
							if (!enumerator.MoveNext())
							{
								int num3 = 0;
								if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_9086474a3ab6467d99a5717f01834bdb != 0)
								{
									num3 = 0;
								}
								switch (num3)
								{
								case 1:
									goto IL_02c9;
								case 2:
									goto IL_02d7;
								case 0:
									break;
								}
								break;
							}
							goto IL_02c9;
							IL_02c9:
							current = enumerator.Current;
							if (!current.kZbi4jebxh9)
							{
								continue;
							}
							goto IL_02d7;
							IL_02d7:
							IoOwGqel6S7AGS15IWQ7(current, false);
							flag = true;
						}
					}
					finally
					{
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
					goto case 3;
				}
				IL_0273:
				Clear();
				break;
			}
			num4 = aIyi4zvGDT1;
			num2 = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_1d290ee06e3247149fe255e31de353f8 != 0)
			{
				num2 = 0;
			}
		}
	}

	private void DZ7i4rokvHJ(int P_0)
	{
		int num;
		if (HQIiD2KOGRc == null)
		{
			HQIiD2KOGRc = new VUKqWxi4OihlVjONbNYE();
			num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_4200640706544f569f191265929ec243 == 0)
			{
				num = 3;
			}
			goto IL_0009;
		}
		goto IL_0039;
		IL_0009:
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num)
			{
			case 3:
				break;
			case 2:
				return;
			case 1:
				HQIiD2KOGRc.LastTime = dateTime2;
				AddAlert(Alert, (string)l9Ca52elWtVEgRfRLf8N(-1583344314 ^ -1583315594));
				num = 2;
				continue;
			default:
				_ = dateTime.AddMinutes(1.0) > dateTime2;
				vHoFmFelIlgs6In8nPww(HQIiD2KOGRc, P_0);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_89f5b3f1a0294191b0997cd0b778a845 != 0)
				{
					num = 1;
				}
				continue;
			}
			break;
		}
		goto IL_0039;
		IL_0039:
		if (!Alert.IsActive || yXx9EGelOcwBPjxE11qf(HQIiD2KOGRc) >= P_0)
		{
			return;
		}
		dateTime2 = ulD32yelqbFXK6cxHJOg();
		dateTime = HQIiD2KOGRc.LastTime;
		num = 0;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_feff692887f143cf88657f0c72ada1e9 == 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	public override void ApplyColors(IChartTheme P_0)
	{
		SelectionColor = Ft8rE1eltFnMPw15xPtD(P_0);
		base.ApplyColors(P_0);
	}

	public override void CopyTemplate(IndicatorBase P_0, bool P_1)
	{
		XTWG0Gi4VZhX95T70HSc xTWG0Gi4VZhX95T70HSc = (XTWG0Gi4VZhX95T70HSc)P_0;
		SelectionColor = xTWG0Gi4VZhX95T70HSc.SelectionColor;
		int num = 3;
		if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_e416c9fc31004f3e8e23d8bbcd45f47e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				OnPropertyChanged(yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(0x24B0B9E6 ^ 0x24B0C460));
				base.CopyTemplate(P_0, P_1);
				num = 0;
				if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_66132b7977414fa9a4eabdda3db7b75c == 0)
				{
					num = 1;
				}
				continue;
			case 1:
				return;
			case 3:
				JlWHCeelUut7XB4McC17(Conditions);
				if (P_1)
				{
					break;
				}
				foreach (TmsYvii4iJ2QGnYSPoKC item in xTWG0Gi4VZhX95T70HSc.Conditions)
				{
					TmsYvii4iJ2QGnYSPoKC tmsYvii4iJ2QGnYSPoKC = new TmsYvii4iJ2QGnYSPoKC();
					tmsYvii4iJ2QGnYSPoKC.OPhi4boAZTG(item);
					int num2 = 0;
					if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_51ae13532ac34475801f72e10929a614 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							break;
						default:
							Conditions.Add(tmsYvii4iJ2QGnYSPoKC);
							num2 = 1;
							if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_bb112ee1b0d04deb878f0e8052d708a1 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					}
				}
				break;
			}
			Alert.Copy(xTWG0Gi4VZhX95T70HSc.Alert, !P_1);
			num = 2;
		}
	}

	public XBrush GetBrush(int P_0, bool P_1)
	{
		if (P_0 > 0 && P_0 < jcXi4AZnJd7().Count && jcXi4AZnJd7()[P_0])
		{
			int num = 0;
			if (_003CModule_003E_007B6e4ccbfe_002D212e_002D46b3_002Db926_002D182a98f88a79_007D.m_2dae9e7b16644e7ca6575920d9bcb6e3 != 0)
			{
				num = 0;
			}
			return num switch
			{
				_ => QkMi4JqKYyg, 
			};
		}
		return null;
	}

	public XTWG0Gi4VZhX95T70HSc()
	{
		tal8OwLVdI5bqyp4edeZ.fvHeh9GrrU5();
		base._002Ector();
	}

	static XTWG0Gi4VZhX95T70HSc()
	{
		pVSJ9pelTmbeL7SLE5na();
		SnMTGwelytbuJvEKJvOh();
	}

	internal static bool sdNHfyelg9ivbUtl7v4M()
	{
		return wfOFwield8iYpc9ewl9c == null;
	}

	internal static XTWG0Gi4VZhX95T70HSc BA7UbdelREC7fkqKCxE5()
	{
		return wfOFwield8iYpc9ewl9c;
	}

	internal static void IoOwGqel6S7AGS15IWQ7(object P_0, bool P_1)
	{
		((TmsYvii4iJ2QGnYSPoKC)P_0).kZbi4jebxh9 = P_1;
	}

	internal static int vE5q0PelMpvJ04hPSbsY(object P_0)
	{
		return ((IChartDataProvider)P_0).Count;
	}

	internal static int yXx9EGelOcwBPjxE11qf(object P_0)
	{
		return ((VUKqWxi4OihlVjONbNYE)P_0).XHii4IWsMvm();
	}

	internal static DateTime ulD32yelqbFXK6cxHJOg()
	{
		return TimeHelper.LocalTime;
	}

	internal static void vHoFmFelIlgs6In8nPww(object P_0, int P_1)
	{
		((VUKqWxi4OihlVjONbNYE)P_0).N2Di4WFP4cf(P_1);
	}

	internal static object l9Ca52elWtVEgRfRLf8N(int P_0)
	{
		return yVbruBLyqe9BOsO9Yb5E.MyLLyuxXiJ7(P_0);
	}

	internal static XColor Ft8rE1eltFnMPw15xPtD(object P_0)
	{
		return ((IChartTheme)P_0).GetNextColor();
	}

	internal static void JlWHCeelUut7XB4McC17(object P_0)
	{
		((List<TmsYvii4iJ2QGnYSPoKC>)P_0).Clear();
	}

	internal static void pVSJ9pelTmbeL7SLE5na()
	{
		yVbruBLyqe9BOsO9Yb5E.rq3Ly8VsSFl();
	}

	internal static void SnMTGwelytbuJvEKJvOh()
	{
		ObwCXyLVWLAqZaA6biRs.kLjw4iIsCLsZtxc4lksN0j();
	}
}
