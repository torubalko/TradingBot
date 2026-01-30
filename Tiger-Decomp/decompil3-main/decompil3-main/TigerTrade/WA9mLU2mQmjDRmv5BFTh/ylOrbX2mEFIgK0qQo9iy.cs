using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Editors;
using ECOEgqlSad8NUJZ2Dr9n;
using IenDU62Z8y6qjQ0ljtre;
using lFsEWXfkgLYLS0FUKGT5;
using n4LmhZHDb0i8YpSGr2Xl;
using nC8oZVi8pvEIhb4vhIix;
using OWUMXkHkWgCUprHQ3jb9;
using sELy4Zl0XEVysWNf5u6X;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Market.Settings;
using TigerTrade.Properties;
using TigerTrade.Tc.Manager;
using TuAMtrl1Nd3XoZQQUXf0;
using UIKit.Core;

namespace WA9mLU2mQmjDRmv5BFTh;

internal class ylOrbX2mEFIgK0qQo9iy : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class vvUiBenOhvCDuDaqxqFe
	{
		public static readonly vvUiBenOhvCDuDaqxqFe QYTnO70JBnL;

		public static Func<string, string> endnO8xIUP1;

		internal static vvUiBenOhvCDuDaqxqFe Ke2vwANk11JRY54143xB;

		static vvUiBenOhvCDuDaqxqFe()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ba87d68105604f98a891a0549ef4b7f9 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					QYTnO70JBnL = new vvUiBenOhvCDuDaqxqFe();
					return;
				}
			}
		}

		public vvUiBenOhvCDuDaqxqFe()
		{
			EEQhjcNkxolcau5J5ipP();
			base._002Ector();
		}

		internal string VUOnOwxGvZd(string s)
		{
			return (string)Ad5IDgNkLWMAIwAZ9Y3t(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB15553A), s);
		}

		internal static bool dr0hebNk5LvrPRA0bV8A()
		{
			return Ke2vwANk11JRY54143xB == null;
		}

		internal static vvUiBenOhvCDuDaqxqFe Vr4IOaNkSKUMk1WyZAn7()
		{
			return Ke2vwANk11JRY54143xB;
		}

		internal static void EEQhjcNkxolcau5J5ipP()
		{
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		}

		internal static object Ad5IDgNkLWMAIwAZ9Y3t(object P_0, object P_1)
		{
			return (string)P_0 + (string)P_1;
		}
	}

	[CompilerGenerated]
	private MarketSettings eNJ2mr1iyY7;

	[CompilerGenerated]
	private MarketSettings A0j2mKMZ500;

	[CompilerGenerated]
	private readonly ICommand k9f2mmuS8pn;

	internal ylOrbX2mEFIgK0qQo9iy ThisWindow;

	internal DropDown ExchangeSelector;

	internal A7O9jTl0s6tkYZjLLIEY QuoteCurrencyCrypto;

	internal A7O9jTl0s6tkYZjLLIEY QuoteCurrencyFut;

	internal A7O9jTl0s6tkYZjLLIEY PercentsFut;

	internal A7O9jTl0s6tkYZjLLIEY SetAllPresets;

	private bool Bi12mhTk5PT;

	internal static ylOrbX2mEFIgK0qQo9iy Obr5tYDHIGPUBaHe37fE;

	public MarketSettings CryptoTemplate
	{
		[CompilerGenerated]
		get
		{
			return eNJ2mr1iyY7;
		}
		[CompilerGenerated]
		set
		{
			eNJ2mr1iyY7 = marketSettings;
		}
	}

	public MarketSettings FuturesTemplate
	{
		[CompilerGenerated]
		get
		{
			return A0j2mKMZ500;
		}
		[CompilerGenerated]
		set
		{
			A0j2mKMZ500 = a0j2mKMZ;
		}
	}

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return k9f2mmuS8pn;
		}
	}

	public ylOrbX2mEFIgK0qQo9iy()
	{
		bC6qJTDHU2jQGCu0gCnQ();
		base._002Ector();
		k9f2mmuS8pn = new RelayCommand(dYH2mOsh70Q);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	public static void VBQ2mdTHvLj(Window P_0)
	{
		qRUNhyHDDQmkuIovYJo1.RNwHD5QnkSR<ylOrbX2mEFIgK0qQo9iy>(P_0);
	}

	private void LotsSettingsWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
		CryptoTemplate = (MarketSettings)y57VPIDHy2UpE3bguUY8(bGWnWuDHT4Eats5vw5qG(0xC1DDB3B ^ 0xC1D01E3));
		FuturesTemplate = vGW2mgQs50L(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371620883));
		IEnumerable<string> allExchange = SymbolManager.GetAllExchange(isCrypto: true);
		ExchangeSelector.DataContext = new drYVSm2Z7pLZyeZ9yDdt(allExchange);
		ifWlfmRSlkr((string)bGWnWuDHT4Eats5vw5qG(-181342698 ^ -181390054));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
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
			ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1435596783 ^ -1435610307));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
			{
				num = 1;
			}
		}
	}

	private static MarketSettings vGW2mgQs50L(string P_0)
	{
		int num = 1;
		int num2 = num;
		MarketSettings marketSettings = default(MarketSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				marketSettings.LotsId = Guid.NewGuid().ToString();
				return marketSettings;
			default:
			{
				MarketSettings marketSettings2 = (MarketSettings)bxGxtHDHZtmGm2Dy9vux(P_0);
				if (marketSettings2 != null)
				{
					rRbylYDHV6leUGS3ubt5(marketSettings, marketSettings2);
					goto case 2;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fce1ea768b8d4ccdb3b71310761c1e52 == 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				marketSettings = new MarketSettings();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void OEs2mReMW4m(object P_0, RoutedEventArgs P_1)
	{
		using (List<string>.Enumerator enumerator = j5O2mMP7mdu().GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				string current;
				while (true)
				{
					current = enumerator.Current;
					EKVIQxfkdb0qc2T2DNLL.SZBfkUuQ09W(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4220DA8 ^ 0x422D770) + current, CryptoTemplate, 0);
					int num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
					{
						num = 0;
					}
					switch (num)
					{
					case 1:
						break;
					default:
						goto end_IL_00c1;
					}
					continue;
					end_IL_00c1:
					break;
				}
				EKVIQxfkdb0qc2T2DNLL.SZBfkUuQ09W(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x385FFAB ^ 0x3852559) + current, FuturesTemplate, 0);
			}
		}
		Close();
	}

	private string pew2m6YTkXc()
	{
		return (string)VKDMNuDHCeOW4DPjGEXp(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-602153869 ^ -602208451), ExchangeSelector.SelectedValue);
	}

	private List<string> j5O2mMP7mdu()
	{
		if (SetAllPresets.IsChecked != true)
		{
			return new List<string> { pew2m6YTkXc() };
		}
		return (from s in SymbolManager.GetAllExchange(isCrypto: true)
			select (string)vvUiBenOhvCDuDaqxqFe.Ad5IDgNkLWMAIwAZ9Y3t(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xB15786A ^ 0xB15553A), s)).ToList();
	}

	private void dYH2mOsh70Q(object P_0)
	{
		Close();
	}

	private void iS42mqvlwVE(object P_0, RoutedEventArgs P_1)
	{
		string fileName = (string)P201XeDHroYINByD5l39();
		try
		{
			Process.Start(new ProcessStartInfo(fileName));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
	}

	private void Cky2mI6Q2JA(object P_0, KeyEventArgs P_1)
	{
		if (P_0 is DoubleEditBox doubleEditBox && P_1.Key == Key.Return)
		{
			doubleEditBox.MoveFocus(new TraversalRequest(FocusNavigationDirection.Next));
			P_1.Handled = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
		}
	}

	private void Q4q2mWvgUG7(object P_0, SelectionChangedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				text = pew2m6YTkXc();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				CryptoTemplate = vGW2mgQs50L((string)bGWnWuDHT4Eats5vw5qG(0x706541F3 ^ 0x70659B2B) + text);
				FuturesTemplate = vGW2mgQs50L(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2D3134C9 ^ 0x2D31EE3B) + text);
				ifWlfmRSlkr((string)bGWnWuDHT4Eats5vw5qG(--134855371 ^ 0x80961C7));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7ADBF691 ^ 0x7ADB2DBD));
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!Bi12mhTk5PT)
		{
			Bi12mhTk5PT = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x5CD4F15 ^ 0x5CD944F), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 28:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 11;
			goto IL_0009;
		case 20:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			break;
		case 30:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 32:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 8;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
			{
				num = 3;
			}
			goto IL_0009;
		case 26:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 12:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			break;
		case 33:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			num = 2;
			goto IL_0009;
		case 29:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 36:
			PercentsFut = (A7O9jTl0s6tkYZjLLIEY)P_1;
			break;
		case 10:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 27:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 1:
			ThisWindow = (ylOrbX2mEFIgK0qQo9iy)P_1;
			break;
		case 3:
			ExchangeSelector = (DropDown)P_1;
			ExchangeSelector.SelectionChanged += Q4q2mWvgUG7;
			break;
		case 37:
			SetAllPresets = (A7O9jTl0s6tkYZjLLIEY)P_1;
			break;
		case 34:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 35:
			QuoteCurrencyFut = (A7O9jTl0s6tkYZjLLIEY)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 14:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			break;
		case 8:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 15:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 6;
			goto IL_0009;
		case 31:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_239772330c1f4196be911d4f334efb05 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 16:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 21:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 17:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
			{
				num = 4;
			}
			goto IL_0009;
		case 22:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			break;
		case 13:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			num = 10;
			goto IL_0009;
		case 18:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 13;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		default:
			Bi12mhTk5PT = true;
			num = 4;
			goto IL_0009;
		case 6:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			num = 17;
			goto IL_0009;
		case 7:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			break;
		case 9:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 5:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			num = 3;
			goto IL_0009;
		case 24:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 25:
			OVO3RMDHKoGho9qj4GGE((DoubleEditBox)P_1, new KeyEventHandler(Cky2mI6Q2JA));
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 == 0)
			{
				num = 12;
			}
			goto IL_0009;
		case 23:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			num = 16;
			goto IL_0009;
		case 11:
			((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
			break;
		case 2:
			((M02cpSi83xElTeNoV0cD)P_1).Click += iS42mqvlwVE;
			num = 9;
			goto IL_0009;
		case 38:
			((AccentButton)P_1).Click += OEs2mReMW4m;
			num = 14;
			goto IL_0009;
		case 19:
			QuoteCurrencyCrypto = (A7O9jTl0s6tkYZjLLIEY)P_1;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
			{
				num = 15;
			}
			goto IL_0009;
		case 4:
			{
				((DoubleEditBox)P_1).KeyDown += Cky2mI6Q2JA;
				break;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 15:
				return;
			case 1:
				return;
			case 12:
				return;
			case 8:
				return;
			case 11:
				return;
			case 0:
				return;
			case 7:
				break;
			case 9:
				return;
			case 2:
				return;
			case 10:
				return;
			case 6:
				return;
			case 5:
				return;
			case 14:
				return;
			case 3:
				return;
			case 17:
				return;
			case 16:
				return;
			case 4:
				return;
			case 13:
				return;
			}
			goto case 1;
		}
	}

	static ylOrbX2mEFIgK0qQo9iy()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool d1J9DKDHW2MQIjmTVFBW()
	{
		return Obr5tYDHIGPUBaHe37fE == null;
	}

	internal static ylOrbX2mEFIgK0qQo9iy Pr2nFXDHtsRGiCUybtI7()
	{
		return Obr5tYDHIGPUBaHe37fE;
	}

	internal static void bC6qJTDHU2jQGCu0gCnQ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object bGWnWuDHT4Eats5vw5qG(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object y57VPIDHy2UpE3bguUY8(object P_0)
	{
		return vGW2mgQs50L((string)P_0);
	}

	internal static object bxGxtHDHZtmGm2Dy9vux(object P_0)
	{
		return EKVIQxfkdb0qc2T2DNLL.TghfktGum0g((string)P_0);
	}

	internal static void rRbylYDHV6leUGS3ubt5(object P_0, object P_1)
	{
		((MarketSettings)P_0).CopyLots((MarketSettings)P_1);
	}

	internal static object VKDMNuDHCeOW4DPjGEXp(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object P201XeDHroYINByD5l39()
	{
		return TigerTrade.Properties.Resources.LotSettingsWindowManualUrl;
	}

	internal static void OVO3RMDHKoGho9qj4GGE(object P_0, object P_1)
	{
		((UIElement)P_0).KeyDown += (KeyEventHandler)P_1;
	}
}
