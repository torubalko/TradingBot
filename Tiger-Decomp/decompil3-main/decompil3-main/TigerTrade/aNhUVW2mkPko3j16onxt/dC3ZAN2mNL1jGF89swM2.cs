using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using ECOEgqlSad8NUJZ2Dr9n;
using NbnQZP9f9sQhvfLCna5N;
using nC8oZVi8pvEIhb4vhIix;
using TigerTrade.Core.UI.Commands;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;
using UIKit.Core;

namespace aNhUVW2mkPko3j16onxt;

internal class dC3ZAN2mNL1jGF89swM2 : Window, IComponentConnector, IStyleConnector
{
	private readonly bZXqyS9ffarMXhySBLjG Etk2mXjOnjb;

	[CompilerGenerated]
	private readonly ICommand tL12mcmWJgO;

	internal dC3ZAN2mNL1jGF89swM2 ThisWindow;

	private bool xBc2mjrSliK;

	internal static dC3ZAN2mNL1jGF89swM2 yh1fuKDHErovgrjg1H09;

	public ICommand CloseCommand
	{
		[CompilerGenerated]
		get
		{
			return tL12mcmWJgO;
		}
	}

	public dC3ZAN2mNL1jGF89swM2(bZXqyS9ffarMXhySBLjG P_0)
	{
		VkhQMTDHgUyQLfuxXfhZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 != 0)
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
			Etk2mXjOnjb = P_0;
			tL12mcmWJgO = new RelayCommand(Euv2mL4tMSV);
			InitializeComponent();
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b != 0)
			{
				num = 1;
			}
		}
	}

	public static void WHO2m1rMKqy(Window P_0, bZXqyS9ffarMXhySBLjG P_1)
	{
		dC3ZAN2mNL1jGF89swM2 obj = new dC3ZAN2mNL1jGF89swM2(P_1);
		obj.Owner = P_0;
		obj.ShowDialog();
	}

	private void LotsSettingsWindow_OnLoaded(object sender, RoutedEventArgs e)
	{
		U45GQBDHRjeCu1LDjUL2(this, Etk2mXjOnjb);
	}

	private void N0r2m5LEqm9(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	private void De22mSRHwot(object P_0, RoutedEventArgs P_1)
	{
		if (!(P_0 is M02cpSi83xElTeNoV0cD m02cpSi83xElTeNoV0cD))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
			return;
		}
		try
		{
			dnNPH7DH6OdIncdKcyjG(new ProcessStartInfo((string)m02cpSi83xElTeNoV0cD.Tag));
		}
		catch (Exception)
		{
			IAtmgEDHMd1xZKlRomTh();
		}
	}

	private void N8d2mxhUkKt(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			Process.Start(new ProcessStartInfo(Etk2mXjOnjb.DescriptionUrl));
		}
		catch (Exception)
		{
			IAtmgEDHMd1xZKlRomTh();
		}
	}

	private void Euv2mL4tMSV(object P_0)
	{
		Close();
	}

	private void gGl2meUZ3GD(object P_0, RoutedEventArgs P_1)
	{
		string howToCreatePubllicConfigUrl = TigerTrade.Properties.Resources.HowToCreatePubllicConfigUrl;
		try
		{
			Process.Start(new ProcessStartInfo(howToCreatePubllicConfigUrl));
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!xBc2mjrSliK)
		{
			xBc2mjrSliK = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2BD86B18 ^ 0x2BD8B14C), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			mStrJQDHq0pG7vpxAI8m((M02cpSi83xElTeNoV0cD)P_1, new RoutedEventHandler(gGl2meUZ3GD));
			break;
		default:
			xBc2mjrSliK = true;
			num = 2;
			goto IL_0009;
		case 3:
			((M02cpSi83xElTeNoV0cD)P_1).Click += N8d2mxhUkKt;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cf96ea40632b4cc9a71884e2b5dceb8b == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			ThisWindow = (dC3ZAN2mNL1jGF89swM2)P_1;
			cTYHhGDHOdieYyKsUVBD(ThisWindow, new RoutedEventHandler(LotsSettingsWindow_OnLoaded));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 5:
			{
				((AccentButton)P_1).Click += N0r2m5LEqm9;
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IStyleConnector.Connect(int P_0, object P_1)
	{
		if (P_0 == 4)
		{
			((M02cpSi83xElTeNoV0cD)P_1).Click += De22mSRHwot;
		}
	}

	static dC3ZAN2mNL1jGF89swM2()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void VkhQMTDHgUyQLfuxXfhZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static bool BlalB0DHQSuZUfxa5ocE()
	{
		return yh1fuKDHErovgrjg1H09 == null;
	}

	internal static dC3ZAN2mNL1jGF89swM2 LgupsgDHdPqqv4nAgFEu()
	{
		return yh1fuKDHErovgrjg1H09;
	}

	internal static void U45GQBDHRjeCu1LDjUL2(object P_0, object P_1)
	{
		((FrameworkElement)P_0).DataContext = P_1;
	}

	internal static object dnNPH7DH6OdIncdKcyjG(object P_0)
	{
		return Process.Start((ProcessStartInfo)P_0);
	}

	internal static void IAtmgEDHMd1xZKlRomTh()
	{
		LogManager.WriteFake();
	}

	internal static void cTYHhGDHOdieYyKsUVBD(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void mStrJQDHq0pG7vpxAI8m(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
