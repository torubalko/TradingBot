using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using ECOEgqlSad8NUJZ2Dr9n;
using HOwnCsHPRLOMHipqYaaT;
using kAASckEI0Bg0Nbd6Vr7;
using ksQPwTiw35RnECmeKarT;
using nC8oZVi8pvEIhb4vhIix;
using nwrd0o9063oan8ctC0ZK;
using OWUMXkHkWgCUprHQ3jb9;
using sELy4Zl0XEVysWNf5u6X;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using UIKit.Core;
using xowxQfi3mG5J8fGOO2yt;

namespace v2xXoZ2mHcycsYxeEad7;

internal class aexvBi2m2EhZBVtrPpTK : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	[CompilerGenerated]
	private readonly ICommand MPg2m4yLSVq;

	[CompilerGenerated]
	private hY4hhhEq8mvJON07i15 eYJ2mD31Miv;

	internal aexvBi2m2EhZBVtrPpTK ApiSettings;

	internal A7O9jTl0s6tkYZjLLIEY CheckBoxEnable;

	internal n7oSZ9i3KgbNmyR22k0d TextInputPort;

	private bool BjS2mb6rGGg;

	internal static aexvBi2m2EhZBVtrPpTK i4sjELDHikBICQ9PXIXr;

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return MPg2m4yLSVq;
		}
	}

	[SpecialName]
	[CompilerGenerated]
	public hY4hhhEq8mvJON07i15 Xmd2mvEHGHt()
	{
		return eYJ2mD31Miv;
	}

	[SpecialName]
	[CompilerGenerated]
	public void mao2mBRUjFR(hY4hhhEq8mvJON07i15 P_0)
	{
		eYJ2mD31Miv = P_0;
	}

	public aexvBi2m2EhZBVtrPpTK()
	{
		NXQRcXDHDse2e1FiR7SC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				hY4hhhEq8mvJON07i15 hY4hhhEq8mvJON07i = new hY4hhhEq8mvJON07i15("", "");
				RhZgaQDHbghkBQ7RAOTZ(hY4hhhEq8mvJON07i, true);
				hY4hhhEq8mvJON07i.zmUjqBYVu5(n3n2mfaWBYD);
				mao2mBRUjFR(hY4hhhEq8mvJON07i);
				InitializeComponent();
				return;
			}
			default:
				MPg2m4yLSVq = new RelayCommand(cY02mnI4u8t);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private string n3n2mfaWBYD(string P_0)
	{
		if (int.TryParse(P_0, out var result) && result >= 1024)
		{
			if (result <= 49151)
			{
				return string.Empty;
			}
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
		}
		return (string)C1A1YQDHNAkJh0Kg47dc(TigerTrade.Properties.Resources.ApiServiceValidationPort, 1024, 49151);
	}

	public static void mrN2m915ev6(Window P_0)
	{
		aexvBi2m2EhZBVtrPpTK obj = new aexvBi2m2EhZBVtrPpTK();
		IajkqoDHkSEEFv3lnL1c(obj, P_0);
		obj.ShowDialog();
	}

	private void cY02mnI4u8t(object P_0)
	{
		x6FIqeDH1vKfIHOEgTAb(this);
	}

	private void ApiSettingsWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
		Xmd2mvEHGHt().Value = j18iDj9nukSCmEyZs5lH.Jly9GQYhP29().Jsl90WhVkc8.ToString();
		pVxRg9DH5vQht5iycSeJ(TextInputPort, Xmd2mvEHGHt());
		CheckBoxEnable.IsChecked = CDZo0mDHSkH0CAqouclb(j18iDj9nukSCmEyZs5lH.Jly9GQYhP29());
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void UIn2mG5OuEA(object P_0, RoutedEventArgs P_1)
	{
		string apiSettingsWindowManualUrl = TigerTrade.Properties.Resources.ApiSettingsWindowManualUrl;
		try
		{
			yNdFUKDHxcGHq1sB4V2L(new ProcessStartInfo(apiSettingsWindowManualUrl));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
	}

	private void ix62mYJDcY7(object P_0, RoutedEventArgs P_1)
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
				if (!B5vTbVDHLghIGU3uN0JO(Xmd2mvEHGHt()))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				j18iDj9nukSCmEyZs5lH.Jly9GQYhP29().Jsl90WhVkc8 = int.Parse(Xmd2mvEHGHt().Value);
				((u3qUF590RA7GwKS6JVMx)zGaIFfDHeO84hjim7p09()).Enable = CheckBoxEnable.IsChecked == true;
				j18iDj9nukSCmEyZs5lH.mF79Gl3VoKe();
				yOKvImHPgS3u1aiI0bEY.lPPHPC1vONs.A3EHPMrWHrG();
				Close();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
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
			{
				if (BjS2mb6rGGg)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
					{
						num2 = 0;
					}
					break;
				}
				BjS2mb6rGGg = true;
				Uri uri = new Uri((string)z6tnvQDHsROhFS8Z52Wt(-1325234765 ^ -1325245337), UriKind.Relative);
				MH93v4DHXSxknHPWXgO0(this, uri);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)dxyVYtDHc1RNemTkgQF0(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		default:
			BjS2mb6rGGg = true;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c7e1deb64093431d91d263a2e49f884b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 5:
			((AccentButton)P_1).Click += ix62mYJDcY7;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 4:
			TextInputPort = (n7oSZ9i3KgbNmyR22k0d)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			ApiSettings = (aexvBi2m2EhZBVtrPpTK)P_1;
			break;
		case 3:
			CheckBoxEnable = (A7O9jTl0s6tkYZjLLIEY)P_1;
			break;
		case 2:
			{
				((M02cpSi83xElTeNoV0cD)P_1).Click += UIn2mG5OuEA;
				break;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static aexvBi2m2EhZBVtrPpTK()
	{
		pBLBMgDHjPWVAute4MI1();
	}

	internal static bool nbFELIDHlCvHdKj3pS9Z()
	{
		return i4sjELDHikBICQ9PXIXr == null;
	}

	internal static aexvBi2m2EhZBVtrPpTK UQtB9hDH4M6aIeteFYio()
	{
		return i4sjELDHikBICQ9PXIXr;
	}

	internal static void NXQRcXDHDse2e1FiR7SC()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void RhZgaQDHbghkBQ7RAOTZ(object P_0, bool P_1)
	{
		((hY4hhhEq8mvJON07i15)P_0).Ea8Eybf2rv(P_1);
	}

	internal static object C1A1YQDHNAkJh0Kg47dc(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void IajkqoDHkSEEFv3lnL1c(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static void x6FIqeDH1vKfIHOEgTAb(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void pVxRg9DH5vQht5iycSeJ(object P_0, object P_1)
	{
		((FrameworkElement)P_0).DataContext = P_1;
	}

	internal static bool CDZo0mDHSkH0CAqouclb(object P_0)
	{
		return ((u3qUF590RA7GwKS6JVMx)P_0).Enable;
	}

	internal static object yNdFUKDHxcGHq1sB4V2L(object P_0)
	{
		return Process.Start((ProcessStartInfo)P_0);
	}

	internal static bool B5vTbVDHLghIGU3uN0JO(object P_0)
	{
		return ((L34dcYiwF8r2NgF7JX2P)P_0).IsValid();
	}

	internal static object zGaIFfDHeO84hjim7p09()
	{
		return j18iDj9nukSCmEyZs5lH.Jly9GQYhP29();
	}

	internal static object z6tnvQDHsROhFS8Z52Wt(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void MH93v4DHXSxknHPWXgO0(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object dxyVYtDHc1RNemTkgQF0(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void pBLBMgDHjPWVAute4MI1()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
