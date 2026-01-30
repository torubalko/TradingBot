using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using aEpmU09nz6MEoNmc0pGJ;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using n4LmhZHDb0i8YpSGr2Xl;
using TigerTrade.Core.Utils.Logging;
using TigerTrade.Properties;
using TuAMtrl1Nd3XoZQQUXf0;

namespace fUPyo6271hOM9Fe7hUYY;

internal sealed class CeIuIp27kD4tVyFvjxKj : Window, IComponentConnector
{
	private static CeIuIp27kD4tVyFvjxKj tU327XetRnP;

	private DispatcherTimer EEi27cpnDJ6;

	internal Button ButtonOpenLogs;

	internal Button ButtonSaveLogs;

	internal Button ButtonClose;

	internal TabItem TabItemWork;

	internal SyntaxEditor TextBoxWorkLog;

	internal TabItem TabItemErrors;

	internal SyntaxEditor TextBoxErrorLog;

	private bool s0e27jUM9YE;

	internal static CeIuIp27kD4tVyFvjxKj SIKBJ1D9Qa1SD7tD7IiJ;

	public CeIuIp27kD4tVyFvjxKj()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)OOaL2SD9Rs3wStnMRLRk(0x1D7BA1ED ^ 0x1D7B4255));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b6bac13ae314900826ed96af7afc27b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void Window_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Hvl27LAwx7P();
				EEi27cpnDJ6 = new DispatcherTimer(NWyvgjD9McgQZ9Marc57(100.0), DispatcherPriority.Normal, delegate
				{
					Hvl27LAwx7P();
				}, base.Dispatcher);
				return;
			case 1:
				noeA7LD967xwjBv5PfPT(TextBoxErrorLog, LogManager.GetErrorLog());
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void Window_Closed(object sender, EventArgs e)
	{
		AnRNapD9OYjwxuqN5dyS(EEi27cpnDJ6);
	}

	private void MBW275d7RIn(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			if (Directory.Exists((string)g1SYDJD9qsQs47LbPWmo()))
			{
				Process.Start(j18iDj9nukSCmEyZs5lH.c1j9YzNyHvu());
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9cec884f01d949d294f11a9fcceef609 != 0)
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
		catch (Exception)
		{
			gNAgCOD9IFglMg3hVmx4();
		}
	}

	private void DmI27StAB0i(object P_0, RoutedEventArgs P_1)
	{
		try
		{
			OEwLoDD9WWNOWyyLTsdP();
		}
		catch (Exception)
		{
			LogManager.WriteFake();
		}
	}

	private void RLI27xDAiqH(object P_0, RoutedEventArgs P_1)
	{
		AnRNapD9OYjwxuqN5dyS(EEi27cpnDJ6);
		Close();
	}

	private void Hvl27LAwx7P()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				TabItemWork.Header = TigerTrade.Properties.Resources.DiagnosticsWindowWorkLog;
				return;
			case 2:
				if (base.IsActive)
				{
					TabItemWork.Header = SmlbXMD9tLfHSKLDc0d2();
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				TextBoxWorkLog.Text = LogManager.GetWorkLog();
				TextBoxWorkLog.ActiveView.Scroller.ScrollToDocumentEnd();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void Q7J27e2sfeX(Window P_0)
	{
		if (tU327XetRnP == null)
		{
			goto IL_005e;
		}
		while (!cHoLeMD9UiFLhrl1rRDc(tU327XetRnP))
		{
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 1:
				break;
			default:
				continue;
			}
			goto IL_005e;
		}
		goto IL_003a;
		IL_003a:
		if (!jNONmfD9TlUpDsvxuqwu(tU327XetRnP))
		{
			tU327XetRnP.Show();
		}
		return;
		IL_005e:
		tU327XetRnP = qRUNhyHDDQmkuIovYJo1.IbkHDxQT6V6<CeIuIp27kD4tVyFvjxKj>(P_0);
		goto IL_003a;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!s0e27jUM9YE)
		{
			s0e27jUM9YE = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1522697859 ^ -1522689373), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			ButtonOpenLogs = (Button)P_1;
			w9S1p3D9ycfli7y9oiVB(ButtonOpenLogs, new RoutedEventHandler(MBW275d7RIn));
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		default:
			s0e27jUM9YE = true;
			break;
		case 8:
			TextBoxErrorLog = (SyntaxEditor)P_1;
			break;
		case 5:
			TabItemWork = (TabItem)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 3:
			ButtonSaveLogs = (Button)P_1;
			ButtonSaveLogs.Click += DmI27StAB0i;
			num = 4;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 1:
			((CeIuIp27kD4tVyFvjxKj)P_1).Loaded += Window_Loaded;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 7:
			TabItemErrors = (TabItem)P_1;
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 != 0)
			{
				num = 3;
			}
			goto IL_0009;
		case 4:
			ButtonClose = (Button)P_1;
			w9S1p3D9ycfli7y9oiVB(ButtonClose, new RoutedEventHandler(RLI27xDAiqH));
			break;
		case 6:
			{
				TextBoxWorkLog = (SyntaxEditor)P_1;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed != 0)
				{
					num = 2;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 5:
				break;
			case 2:
				break;
			case 3:
				break;
			case 1:
				((CeIuIp27kD4tVyFvjxKj)P_1).Closed += Window_Closed;
				break;
			case 4:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	[CompilerGenerated]
	private void nsM27s7oZh8(object P_0, EventArgs P_1)
	{
		Hvl27LAwx7P();
	}

	static CeIuIp27kD4tVyFvjxKj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object OOaL2SD9Rs3wStnMRLRk(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool MWxJujD9dnEKCBpIGeDO()
	{
		return SIKBJ1D9Qa1SD7tD7IiJ == null;
	}

	internal static CeIuIp27kD4tVyFvjxKj Ne2kaRD9gbq8lA0HJUUV()
	{
		return SIKBJ1D9Qa1SD7tD7IiJ;
	}

	internal static void noeA7LD967xwjBv5PfPT(object P_0, object P_1)
	{
		((SyntaxEditor)P_0).Text = (string)P_1;
	}

	internal static TimeSpan NWyvgjD9McgQZ9Marc57(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static void AnRNapD9OYjwxuqN5dyS(object P_0)
	{
		((DispatcherTimer)P_0).Stop();
	}

	internal static object g1SYDJD9qsQs47LbPWmo()
	{
		return j18iDj9nukSCmEyZs5lH.c1j9YzNyHvu();
	}

	internal static void gNAgCOD9IFglMg3hVmx4()
	{
		LogManager.WriteFake();
	}

	internal static void OEwLoDD9WWNOWyyLTsdP()
	{
		LogManager.WriteLogs();
	}

	internal static object SmlbXMD9tLfHSKLDc0d2()
	{
		return TigerTrade.Properties.Resources.DiagnosticsWindowWorkLogFrozen;
	}

	internal static bool cHoLeMD9UiFLhrl1rRDc(object P_0)
	{
		return ((FrameworkElement)P_0).IsLoaded;
	}

	internal static bool jNONmfD9TlUpDsvxuqwu(object P_0)
	{
		return ((UIElement)P_0).IsVisible;
	}

	internal static void w9S1p3D9ycfli7y9oiVB(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
