using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using ActiproSoftware.Windows.Controls.Grids.PropertyEditors;
using ActiproSoftware.Windows.Extensions;
using aEpmU09nz6MEoNmc0pGJ;
using bl7Or1fDrLHNeTtGhT82;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using lFsEWXfkgLYLS0FUKGT5;
using n4LmhZHDb0i8YpSGr2Xl;
using q6Lcl3fBRQ8ycXy3QOHi;
using rknQZnGPN5ryJDSSp6ls;
using tD39i62nM81VScsBfmmJ;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using w9hQBe20HnWxvgk0I5BS;
using zgMYdJf4fc58NIsUuLGN;

namespace GZ2P1p2nUOwcS3pa9CZv;

internal sealed class Y43KBu2nt2tdxWysSevH : Window, IComponentConnector
{
	private static NCopbS2n6A8BFZsh7eNY lB02n7fMXEL;

	private bool XCR2n8vfPwu;

	private readonly string PvS2nAkBVkX;

	private readonly string k9B2nPjyMxC;

	private readonly string Mbg2nJVa7Q8;

	internal StackPanel SpType;

	internal ComboBox CbType;

	internal ComboBox CbExchange;

	internal CheckBox CbNewWindow;

	internal Button ButtonAdvanced;

	internal Button ButtonClose;

	internal Button ButtonApply;

	internal zUNI16202mQmpx9T2Hxb TradeSettingsControl;

	private bool CkP2nFwfNf4;

	private static Y43KBu2nt2tdxWysSevH rDQouM4R8Vm463tQpFAN;

	public Y43KBu2nt2tdxWysSevH()
	{
		Er1R0n4RJ0WoZVWPE66O();
		PvS2nAkBVkX = (string)Ko87n64RFaNg01FOEdhA();
		k9B2nPjyMxC = TigerTrade.Properties.Resources.SymbolsWindowAll;
		Mbg2nJVa7Q8 = stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5EA8FF2A ^ 0x5EA86BCC);
		base._002Ector();
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x315AB1E3 ^ 0x315A2513));
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				TradeSettingsControl.zVp20iVy19x();
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				InitializeComponent();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public static void Lux2nT3jHei(NCopbS2n6A8BFZsh7eNY P_0)
	{
		lB02n7fMXEL = P_0;
	}

	private void UsQ2nyb7kt7(object P_0, RoutedEventArgs P_1)
	{
		if (XCR2n8vfPwu)
		{
			return;
		}
		XCR2n8vfPwu = true;
		int num;
		if (lB02n7fMXEL == (NCopbS2n6A8BFZsh7eNY)1)
		{
			fINLbX4R3UgCaG8EiSR5(ButtonAdvanced, Visibility.Visible);
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
			{
				num = 4;
			}
		}
		else if (lB02n7fMXEL != 0)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
			{
				num = 0;
			}
		}
		else
		{
			ButtonClose.Visibility = Visibility.Collapsed;
			ButtonApply.Visibility = Visibility.Visible;
			num = 6;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				TradeSettingsControl.TabItemGeneral.Visibility = Visibility.Collapsed;
				fINLbX4R3UgCaG8EiSR5(TradeSettingsControl.TabItemCluster, Visibility.Collapsed);
				TradeSettingsControl.TabItemTrading.Visibility = Visibility.Collapsed;
				fINLbX4R3UgCaG8EiSR5(TradeSettingsControl.TabItemSimplified, Visibility.Visible);
				num = 9;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 == 0)
				{
					num = 9;
				}
				break;
			case 4:
				TradeSettingsControl.PropertyGridSimplified.jj12zHToQKX(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-624753169 ^ -624717581), !j18iDj9nukSCmEyZs5lH.Settings.FixedPriceScaleMultiplier);
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num = 0;
				}
				break;
			case 8:
			{
				Ar0KPJ46H55u2Kt8VvZR(CbType, SymbolManager.GetAllTypes());
				ObservableCollection<string> observableCollection = new ObservableCollection<string> { PvS2nAkBVkX };
				observableCollection.AddRange(SymbolManager.GetAllExchange());
				CbExchange.ItemsSource = observableCollection;
				return;
			}
			case 5:
				base.Title = (string)wBMOyR4RzWEMbG1b7L5u();
				if (TradeSettingsControl.PropertyGridCluster.CategoryEditors.Count != 0)
				{
					X1bNL1462tbOBNBxNi3v(ln6BPm460Z9k3o3oHvsc(TradeSettingsControl.PropertyGridCluster), 0);
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
					{
						num = 8;
					}
					break;
				}
				goto case 8;
			case 2:
				return;
			case 9:
				yqpySD4RpvyHKAJRlyku(TradeSettingsControl.MarketSettings.VisualSettings);
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num = 2;
				}
				break;
			case 6:
				SpType.Visibility = Visibility.Visible;
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac != 0)
				{
					num = 3;
				}
				break;
			case 0:
				return;
			case 7:
				CbNewWindow.Visibility = Visibility.Visible;
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 3;
				}
				break;
			case 3:
				TradeSettingsControl.IsCommon = true;
				g11mbp4RuO7235vSNPZf(TradeSettingsControl);
				num = 5;
				break;
			}
		}
	}

	public static void OD82nZOqAAN(Window P_0)
	{
		lB02n7fMXEL = (NCopbS2n6A8BFZsh7eNY)0;
		qRUNhyHDDQmkuIovYJo1.RNwHD5QnkSR<Y43KBu2nt2tdxWysSevH>(P_0);
	}

	private void hSx2nVNmN8f(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	private void HiN2nCGENgU(object P_0, RoutedEventArgs P_1)
	{
		MarketSettings marketSettings = (MarketSettings)E1oUhQ46fZofXQuL2sWT(TradeSettingsControl);
		marketSettings.CommonTemplateID = Guid.NewGuid().ToString();
		string text = iQQ2nKMGYYj();
		marketSettings.IsRoot = text.Contains((string)Uj0HKW469A6iv5p4qPys(0x6D18F862 ^ 0x6D186D26));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
		{
			num = 5;
		}
		MarketSettings marketSettings2 = default(MarketSettings);
		string text2 = default(string);
		bool? flag = default(bool?);
		MarketSettings marketSettings3 = default(MarketSettings);
		while (true)
		{
			switch (num)
			{
			case 6:
				jnm8Ms46oGnlRH9iP99U(marketSettings2.VisualSettings.msVfizuWg5N);
				EKVIQxfkdb0qc2T2DNLL.SZBfkUuQ09W(text2, marketSettings2, 0, _0020: false, _0020: true);
				break;
			case 11:
				return;
			case 3:
				Close();
				num = 11;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
				{
					num = 4;
				}
				continue;
			case 8:
			{
				((CR1isWfDCD1A4fwfUJUf)UEEDgG46GFVYOftnxOtU(marketSettings)).yMPfNFJWcpk = zUNI16202mQmpx9T2Hxb.V7r209OQxxu(TradeSettingsControl.PropertyGridGeneral);
				marketSettings.ClusterSettings.opDfDNJE4j1 = zUNI16202mQmpx9T2Hxb.V7r209OQxxu(TradeSettingsControl.PropertyGridCluster);
				int num2 = 9;
				num = num2;
				continue;
			}
			case 4:
				cAj3C946nJoZPeeDf0HO(marketSettings, true);
				num = 8;
				continue;
			case 10:
				flag = TradeSettingsControl.IsIndividual;
				if (flag == true)
				{
					lB02n7fMXEL = (NCopbS2n6A8BFZsh7eNY)0;
					num = 4;
					continue;
				}
				goto default;
			case 7:
				marketSettings3 = EKVIQxfkdb0qc2T2DNLL.TghfktGum0g(text);
				if (marketSettings3 != null)
				{
					fl1vV346YrjXL75u7oLC(marketSettings3, marketSettings);
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			case 5:
				flag = CbNewWindow.IsChecked;
				num = 2;
				continue;
			case 2:
				if (flag.HasValue)
				{
					flag = CbNewWindow.IsChecked;
					marketSettings.SetNewSymbol = flag.Value;
					num = 10;
					continue;
				}
				goto case 10;
			case 1:
				EKVIQxfkdb0qc2T2DNLL.SZBfkUuQ09W(text, marketSettings3, 0, lB02n7fMXEL == (NCopbS2n6A8BFZsh7eNY)0, _0020: true);
				break;
			case 9:
				marketSettings.VisualSettings.msVfizuWg5N = zUNI16202mQmpx9T2Hxb.V7r209OQxxu(TradeSettingsControl.PropertyGridGraphDom);
				num = 7;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num = 0;
				}
				continue;
			default:
				text2 = iQQ2nKMGYYj(_0020: true);
				marketSettings2 = EKVIQxfkdb0qc2T2DNLL.TghfktGum0g(text2);
				if (marketSettings2 != null)
				{
					jnm8Ms46oGnlRH9iP99U(marketSettings2.TradeSettings.yMPfNFJWcpk);
					jnm8Ms46oGnlRH9iP99U(((LYn4tAf4HSV4yrcb7PrO)am2NeP46vK5LCGHEvjph(marketSettings2)).opDfDNJE4j1);
					num = 6;
					continue;
				}
				break;
			}
			flag = TradeSettingsControl.IsIndividual;
			EKVIQxfkdb0qc2T2DNLL.SZBfkUuQ09W(iQQ2nKMGYYj(flag == true), marketSettings, 0, lB02n7fMXEL == (NCopbS2n6A8BFZsh7eNY)0);
			num = 3;
		}
	}

	private void cQd2nrxdhEH(object P_0, RoutedEventArgs P_1)
	{
		ButtonAdvanced.Visibility = Visibility.Collapsed;
		TradeSettingsControl.TabItemGeneral.Visibility = Visibility.Visible;
		TradeSettingsControl.TabItemCluster.Visibility = Visibility.Visible;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
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
			TradeSettingsControl.TabItemTrading.Visibility = Visibility.Visible;
			TradeSettingsControl.TabItemSimplified.Visibility = Visibility.Collapsed;
			TradeSettingsControl.TabItemGeneral.IsSelected = true;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
			{
				num = 1;
			}
		}
	}

	private string iQQ2nKMGYYj(bool P_0 = false)
	{
		int num = 1;
		int num2 = num;
		object obj = default(object);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (obj as string == PvS2nAkBVkX)
				{
					obj = Mbg2nJVa7Q8;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 2;
			default:
				obj = XnaGOO46BcSx0i89HyoX(CbExchange);
				if (text == k9B2nPjyMxC)
				{
					text = Mbg2nJVa7Q8;
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2e936b892f094d0a971af950fe8f46f7 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 3;
			case 2:
				return (P_0 ? string.Format((string)Uj0HKW469A6iv5p4qPys(-2108526692 ^ -2108491018), text, obj) : string.Format((string)Uj0HKW469A6iv5p4qPys(0x28B345BB ^ 0x28B3D0EB), text, obj)).Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325264855), stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1153206687 ^ -1153178843));
			case 1:
				text = ((zExvlHGPbQsZv9T8F5T0)XnaGOO46BcSx0i89HyoX(CbType)).ShortName;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Dqo2nmpCdcW()
	{
		TradeSettingsControl.MarketSettings = EKVIQxfkdb0qc2T2DNLL.Fe6fkINKPiB(iQQ2nKMGYYj());
		TradeSettingsControl.Category = (zUNI16202mQmpx9T2Hxb.UJajCjnQr63UFbiRQ2if)0;
		KlCYs046aWCN9IXyASEo(TradeSettingsControl);
		TradeSettingsControl.PropertyGridCluster.jj12zHToQKX((string)Uj0HKW469A6iv5p4qPys(-1047165041 ^ -1047195101));
		TradeSettingsControl.PropertyGridGeneral.jj12zHToQKX(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2108526692 ^ -2108491216));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
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
				TradeSettingsControl.PropertyGridGraphDom.jj12zHToQKX((string)Uj0HKW469A6iv5p4qPys(-1311293279 ^ -1311255283));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void Whi2nhwJ1al(object P_0, SelectionChangedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				CbType.SelectedIndex = 0;
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (object.Equals(P_0, CbType))
				{
					num2 = 5;
					break;
				}
				goto IL_00e6;
			case 4:
				Dqo2nmpCdcW();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (CbExchange.SelectedValue == PvS2nAkBVkX)
				{
					qHpGCC46iKe5JGU9Au6M(CbExchange, 1);
				}
				goto IL_00e6;
			case 1:
				text = ((zExvlHGPbQsZv9T8F5T0)XnaGOO46BcSx0i89HyoX(CbType)).ShortName;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 5:
				{
					if (text == Mbg2nJVa7Q8)
					{
						CbExchange.SelectedIndex = 0;
						goto IL_00e6;
					}
					goto case 3;
				}
				IL_00e6:
				if (GXp2jD46l2qQvvmgyv6p(P_0, CbExchange))
				{
					if (CbExchange.SelectedValue == PvS2nAkBVkX)
					{
						num2 = 6;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (TbvhEO464bgUgRpEAcgV(text, Mbg2nJVa7Q8))
					{
						CbType.SelectedIndex = 1;
					}
				}
				goto case 4;
			}
		}
	}

	private void nr52nwltxxH(object P_0, RoutedEventArgs P_1)
	{
		Dqo2nmpCdcW();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 2;
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
			{
				CkP2nFwfNf4 = true;
				Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x42D899B5 ^ 0x42D80C79), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 2:
				if (CkP2nFwfNf4)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_213ef2c0a30c421096ba2b26b8d94124 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)eTfOUN46Dsg3QhWESPgb(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			GnSmdP46NokdobMZKwIp((CommandBinding)P_1, new ExecutedRoutedEventHandler(hSx2nVNmN8f));
			num = 6;
			goto IL_0009;
		case 1:
			G4K9w546bkuFvgwQnO4H((Y43KBu2nt2tdxWysSevH)P_1, new RoutedEventHandler(UsQ2nyb7kt7));
			break;
		case 9:
			ButtonClose = (Button)P_1;
			num = 5;
			goto IL_0009;
		case 8:
			ButtonAdvanced = (Button)P_1;
			ButtonAdvanced.Click += cQd2nrxdhEH;
			break;
		default:
			CkP2nFwfNf4 = true;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 6:
			CbNewWindow = (CheckBox)P_1;
			num = 7;
			goto IL_0009;
		case 4:
			CbType = (ComboBox)P_1;
			CbType.SelectionChanged += Whi2nhwJ1al;
			break;
		case 3:
			SpType = (StackPanel)P_1;
			break;
		case 10:
			ButtonApply = (Button)P_1;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 7:
			((CheckBox)P_1).Unchecked += nr52nwltxxH;
			num = 2;
			goto IL_0009;
		case 5:
			CbExchange = (ComboBox)P_1;
			Xxsxlj46k7Z5Qrir2RXb(CbExchange, new SelectionChangedEventHandler(Whi2nhwJ1al));
			break;
		case 11:
			{
				TradeSettingsControl = (zUNI16202mQmpx9T2Hxb)P_1;
				break;
			}
			IL_0009:
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					((CheckBox)P_1).Checked += nr52nwltxxH;
					num = 3;
					break;
				case 4:
					ButtonApply.Click += HiN2nCGENgU;
					return;
				case 5:
					pwTVSC4614ZiHhn8HI89(ButtonClose, new RoutedEventHandler(hSx2nVNmN8f));
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
					{
						num = 0;
					}
					break;
				case 3:
					return;
				case 0:
					return;
				case 6:
					return;
				case 1:
					return;
				case 7:
					return;
				}
			}
		}
	}

	static Y43KBu2nt2tdxWysSevH()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Ik2HFH465Ge0Nq1yPlRS();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a93c63471a5d4726b3bdf40a69cdb422 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				lB02n7fMXEL = NCopbS2n6A8BFZsh7eNY.None;
				return;
			}
		}
	}

	internal static void Er1R0n4RJ0WoZVWPE66O()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object Ko87n64RFaNg01FOEdhA()
	{
		return TigerTrade.Properties.Resources.SymbolAllExchanges;
	}

	internal static bool zxE14p4RAvRoDsGrVqqE()
	{
		return rDQouM4R8Vm463tQpFAN == null;
	}

	internal static Y43KBu2nt2tdxWysSevH AjY2YN4RP46qnMeyZZ92()
	{
		return rDQouM4R8Vm463tQpFAN;
	}

	internal static void fINLbX4R3UgCaG8EiSR5(object P_0, Visibility P_1)
	{
		((UIElement)P_0).Visibility = P_1;
	}

	internal static void yqpySD4RpvyHKAJRlyku(object P_0)
	{
		((SH4fZjfBgpnJAYxtUbu4)P_0).CmDfBqabLT3();
	}

	internal static void g11mbp4RuO7235vSNPZf(object P_0)
	{
		((zUNI16202mQmpx9T2Hxb)P_0).YMm20B2UNJT();
	}

	internal static object wBMOyR4RzWEMbG1b7L5u()
	{
		return TigerTrade.Properties.Resources.MainWindowMenuDomSettings;
	}

	internal static object ln6BPm460Z9k3o3oHvsc(object P_0)
	{
		return ((PropertyGrid)P_0).CategoryEditors;
	}

	internal static void X1bNL1462tbOBNBxNi3v(object P_0, int P_1)
	{
		((Collection<CategoryEditor>)P_0).RemoveAt(P_1);
	}

	internal static void Ar0KPJ46H55u2Kt8VvZR(object P_0, object P_1)
	{
		((ItemsControl)P_0).ItemsSource = (IEnumerable)P_1;
	}

	internal static object E1oUhQ46fZofXQuL2sWT(object P_0)
	{
		return ((zUNI16202mQmpx9T2Hxb)P_0).MarketSettings;
	}

	internal static object Uj0HKW469A6iv5p4qPys(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void cAj3C946nJoZPeeDf0HO(object P_0, bool value)
	{
		((MarketSettings)P_0).IsIndividual = value;
	}

	internal static object UEEDgG46GFVYOftnxOtU(object P_0)
	{
		return ((MarketSettings)P_0).TradeSettings;
	}

	internal static void fl1vV346YrjXL75u7oLC(object P_0, object P_1)
	{
		((MarketSettings)P_0).CopyIndividualSettings((MarketSettings)P_1);
	}

	internal static void jnm8Ms46oGnlRH9iP99U(object P_0)
	{
		((List<string>)P_0).Clear();
	}

	internal static object am2NeP46vK5LCGHEvjph(object P_0)
	{
		return ((MarketSettings)P_0).ClusterSettings;
	}

	internal static object XnaGOO46BcSx0i89HyoX(object P_0)
	{
		return ((Selector)P_0).SelectedValue;
	}

	internal static void KlCYs046aWCN9IXyASEo(object P_0)
	{
		((zUNI16202mQmpx9T2Hxb)P_0).jXC20GxSneC();
	}

	internal static void qHpGCC46iKe5JGU9Au6M(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static bool GXp2jD46l2qQvvmgyv6p(object P_0, object P_1)
	{
		return object.Equals(P_0, P_1);
	}

	internal static bool TbvhEO464bgUgRpEAcgV(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object eTfOUN46Dsg3QhWESPgb(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void G4K9w546bkuFvgwQnO4H(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void GnSmdP46NokdobMZKwIp(object P_0, object P_1)
	{
		((CommandBinding)P_0).Executed += (ExecutedRoutedEventHandler)P_1;
	}

	internal static void Xxsxlj46k7Z5Qrir2RXb(object P_0, object P_1)
	{
		((Selector)P_0).SelectionChanged += (SelectionChangedEventHandler)P_1;
	}

	internal static void pwTVSC4614ZiHhn8HI89(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void Ik2HFH465Ge0Nq1yPlRS()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
