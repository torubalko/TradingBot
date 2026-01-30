using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using LxkBMPH3MZ8ObkVk5Atk;
using OWUMXkHkWgCUprHQ3jb9;
using TuAMtrl1Nd3XoZQQUXf0;

namespace BxvQJX2UvLEbel59KSXV;

internal class cfqEpY2UoAWV2FrHv83Z : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	private p4gwA9H36qTSRys5LY33 F3R2U4iAR0a;

	internal Button ButtonClose;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	private bool nqZ2UDV35Pr;

	private static cfqEpY2UoAWV2FrHv83Z MP3RS14phFJurA5AQTCX;

	public p4gwA9H36qTSRys5LY33 Settings
	{
		get
		{
			return F3R2U4iAR0a;
		}
		set
		{
			if (!object.Equals(p4gwA9H36qTSRys5LY, F3R2U4iAR0a))
			{
				F3R2U4iAR0a = p4gwA9H36qTSRys5LY;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 != 0)
				{
					num = 0;
				}
				switch (num)
				{
				}
				ifWlfmRSlkr(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C8368CA));
			}
		}
	}

	public cfqEpY2UoAWV2FrHv83Z()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				PropertyGrid.Columns[1].Width = new GridLength(3.0, GridUnitType.Star);
				return;
			}
			mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F55E538 ^ 0x7F55349E));
			InitializeComponent();
			PropertyGrid.Columns[0].Width = new GridLength(7.0, GridUnitType.Star);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
			{
				num = 1;
			}
		}
	}

	public static void teg2UB9MLr2(Window P_0, p4gwA9H36qTSRys5LY33 P_1)
	{
		cfqEpY2UoAWV2FrHv83Z obj = new cfqEpY2UoAWV2FrHv83Z
		{
			Settings = P_1
		};
		Pfbnc84p8yas870p61ky(obj, P_0);
		obj.ShowDialog();
	}

	private void rqM2UaYPOKP(object P_0, RoutedEventArgs P_1)
	{
		Close();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!nqZ2UDV35Pr)
		{
			nqZ2UDV35Pr = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri((string)Kdktbv4pAjmTw6hdn5DL(-44540535 ^ -44528549), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)XdPOn34pPCBdv2rVHR1m(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (P_0 != 1)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34759ce292e54c39852852efd3a55773 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				ButtonClose = (Button)P_1;
				TqmoYq4pJXLv3fHLgEc6(ButtonClose, new RoutedEventHandler(rqM2UaYPOKP));
				return;
			case 3:
				nqZ2UDV35Pr = true;
				return;
			case 1:
				if (P_0 != 2)
				{
					num2 = 3;
					break;
				}
				PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
				return;
			}
		}
	}

	static cfqEpY2UoAWV2FrHv83Z()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool pBjjX24pw1MnHnWkLcAN()
	{
		return MP3RS14phFJurA5AQTCX == null;
	}

	internal static cfqEpY2UoAWV2FrHv83Z OmNSp94p7v2f07cShSm8()
	{
		return MP3RS14phFJurA5AQTCX;
	}

	internal static void Pfbnc84p8yas870p61ky(object P_0, object P_1)
	{
		((Window)P_0).Owner = (Window)P_1;
	}

	internal static object Kdktbv4pAjmTw6hdn5DL(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object XdPOn34pPCBdv2rVHR1m(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void TqmoYq4pJXLv3fHLgEc6(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
