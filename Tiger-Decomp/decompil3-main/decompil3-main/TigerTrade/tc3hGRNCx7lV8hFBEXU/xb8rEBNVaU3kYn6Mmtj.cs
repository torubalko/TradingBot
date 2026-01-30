using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using a6E6CUH2PT7TfmHbyCgL;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace tc3hGRNCx7lV8hFBEXU;

[TemplateVisualState(Name = "FullScreen", GroupName = "PlayerStates")]
[TemplateVisualState(Name = "Normal", GroupName = "PlayerStates")]
[TemplatePart(Name = "Player", Type = typeof(iCUiOSH2AYlVlZsCyfhf))]
public class xb8rEBNVaU3kYn6Mmtj : UserControl, IComponentConnector
{
	private iCUiOSH2AYlVlZsCyfhf bAiNJoGfRl;

	public static readonly DependencyProperty wqvNFRivwr;

	public static readonly DependencyProperty tifN3VD56Z;

	internal xb8rEBNVaU3kYn6Mmtj Root;

	private bool L9mNpbU2GO;

	internal static xb8rEBNVaU3kYn6Mmtj ysxnFsluljYlSk8NDPN9;

	public ICommand RequestFullScreenCommand
	{
		get
		{
			return (ICommand)GetValue(wqvNFRivwr);
		}
		set
		{
			kigF2blubygDpMf8ZDK5(this, wqvNFRivwr, command);
		}
	}

	public bool IsFullScreen
	{
		get
		{
			return (bool)GetValue(tifN3VD56Z);
		}
		set
		{
			SetValue(tifN3VD56Z, flag);
		}
	}

	public xb8rEBNVaU3kYn6Mmtj()
	{
		nUCufbluNA4H0gxD7Ew2();
		base._002Ector();
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (bAiNJoGfRl == null)
				{
					break;
				}
				goto default;
			case 2:
				bAiNJoGfRl = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x240843C8)) as iCUiOSH2AYlVlZsCyfhf;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
				{
					num2 = 1;
				}
				continue;
			default:
				bAiNJoGfRl.dwcHHnaZnJt(d7vNrjOo66);
				break;
			}
			break;
		}
		base.OnApplyTemplate();
	}

	private void d7vNrjOo66(object P_0, bool P_1)
	{
		(RequestFullScreenCommand as RoutedCommand)?.Execute(P_1, this);
		IsFullScreen = P_1;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		VisualStateManager.GoToState(this, (string)(P_1 ? BMNFXLlukpwddASIxJnM(-342738082 ^ -342739998) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-45476899 ^ -45473435)), useTransitions: false);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		int num2 = num;
		Uri uri = default(Uri);
		while (true)
		{
			switch (num2)
			{
			default:
				L9mNpbU2GO = true;
				uri = new Uri((string)BMNFXLlukpwddASIxJnM(0x68DEE0F ^ 0x68DDCC7), UriKind.Relative);
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (L9mNpbU2GO)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				cfSW24lu1bmIaxBMUP5d(this, uri);
				return;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 1)
		{
			L9mNpbU2GO = true;
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1693d43c67f14e0eba9f86b0171ecbd6 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			Root = (xb8rEBNVaU3kYn6Mmtj)P_1;
		}
	}

	static xb8rEBNVaU3kYn6Mmtj()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				wqvNFRivwr = DependencyProperty.Register((string)BMNFXLlukpwddASIxJnM(-1127423276 ^ -1127427698), Type.GetTypeFromHandle(fus8BOlu5abvHD2ZFIli(16777377)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33554622)));
				tifN3VD56Z = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2C8374E4 ^ 0x2C83476A), Type.GetTypeFromHandle(fus8BOlu5abvHD2ZFIli(16777221)), Type.GetTypeFromHandle(fus8BOlu5abvHD2ZFIli(33554622)));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool sC3tP8lu4TRtj6MJSwnK()
	{
		return ysxnFsluljYlSk8NDPN9 == null;
	}

	internal static xb8rEBNVaU3kYn6Mmtj V9bhe9luDl1SxxT3k7cX()
	{
		return ysxnFsluljYlSk8NDPN9;
	}

	internal static void kigF2blubygDpMf8ZDK5(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void nUCufbluNA4H0gxD7Ew2()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object BMNFXLlukpwddASIxJnM(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void cfSW24lu1bmIaxBMUP5d(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static RuntimeTypeHandle fus8BOlu5abvHD2ZFIli(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
