using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using aEpmU09nz6MEoNmc0pGJ;
using CjttZVHEzEWfhqQAXjq2;
using DQIo3790ym4PqFa5dl3o;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace a3l9Sb2wgUQjFEEyv9lc;

internal class BR6Uy42wdA7n9lDhqT1n : Window, IComponentConnector
{
	internal TextBox TextBoxFrom;

	internal TextBox TextBoxTo;

	internal TextBox TextBoxSmtpServer;

	internal TextBox TextBoxSmtpLogin;

	internal PasswordBox TextBoxSmtpPassword;

	internal CheckBox CheckBoxSmtpSsl;

	internal CheckBox CheckBoxEnable;

	internal Button ButtonOk;

	internal Button ButtonCancel;

	private bool qQC2wqP3L85;

	internal static BR6Uy42wdA7n9lDhqT1n QC59BtDfE7BE6Gs6Or4N;

	public BR6Uy42wdA7n9lDhqT1n()
	{
		UkFXi9DfgSFDNvX9nq0b();
		base._002Ector();
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)JFVtYyDfRBtudbDtXUFG(0x2BD86B18 ^ 0x2BD85A54));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f027e87a9f614f4a92c0338386fb11cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	private void kml2wRJtMLo(object P_0, RoutedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				CoKJyqDfOHRyD7YtXqJ7(TextBoxSmtpServer, j18iDj9nukSCmEyZs5lH.aFH9GeRevRU().nHI907hLrQI);
				TextBoxSmtpLogin.Text = j18iDj9nukSCmEyZs5lH.aFH9GeRevRU().Yw190PdupgM;
				nO6lqVDfIjvXF1UTdS8E(TextBoxSmtpPassword, YGXYTODfq4k6cSbnuAl2(j18iDj9nukSCmEyZs5lH.aFH9GeRevRU()));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				TextBoxFrom.Text = ((oPtcN290TuwfxN9qnftN)TWF6F5Df6TjxXwZGDFnI()).From;
				TextBoxTo.Text = (string)sPqbPCDfM9tCUx1ieJwB(j18iDj9nukSCmEyZs5lH.aFH9GeRevRU());
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_cab5688e7a6f4724836f4be9e8087801 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				CheckBoxEnable.IsChecked = ((oPtcN290TuwfxN9qnftN)TWF6F5Df6TjxXwZGDFnI()).Enable;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
				{
					num2 = 2;
				}
				break;
			default:
				CheckBoxSmtpSsl.IsChecked = ((oPtcN290TuwfxN9qnftN)TWF6F5Df6TjxXwZGDFnI()).sdk92H0QcFC;
				return;
			}
		}
	}

	private void dj62w6P8j8X(object P_0, RoutedEventArgs P_1)
	{
		j18iDj9nukSCmEyZs5lH.aFH9GeRevRU().Enable = CheckBoxEnable.IsChecked == true;
		E8pFmtDfWqSA7AO9hXQZ(TWF6F5Df6TjxXwZGDFnI(), TextBoxFrom.Text);
		j18iDj9nukSCmEyZs5lH.aFH9GeRevRU().To = TextBoxTo.Text;
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				oM5hy8DfUTGUhVJW1dtd(TWF6F5Df6TjxXwZGDFnI(), bgcYVrDftqEAfxhHTZLG(TextBoxSmtpServer));
				sKZ8qEDfTfjj9828DmZG(j18iDj9nukSCmEyZs5lH.aFH9GeRevRU(), TextBoxSmtpLogin.Text);
				num = 2;
				break;
			case 3:
				j18iDj9nukSCmEyZs5lH.aFH9GeRevRU().sdk92H0QcFC = CheckBoxSmtpSsl.IsChecked == true;
				h1t8dUDfZW50lkcxIAST();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 == 0)
				{
					num = 0;
				}
				break;
			default:
				Close();
				return;
			case 2:
				EvlwdNDfyTecGAnfr2Io(j18iDj9nukSCmEyZs5lH.aFH9GeRevRU(), TextBoxSmtpPassword.Password);
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private void eCF2wMUCiwe(object P_0, RoutedEventArgs P_1)
	{
		G4aCGJDfVTX79uvuRkx2(this);
	}

	public static void Yfx2wOWsTLo(Window P_0)
	{
		BR6Uy42wdA7n9lDhqT1n bR6Uy42wdA7n9lDhqT1n = new BR6Uy42wdA7n9lDhqT1n();
		bR6Uy42wdA7n9lDhqT1n.Owner = P_0;
		bR6Uy42wdA7n9lDhqT1n.ShowDialog();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!qQC2wqP3L85)
		{
			qQC2wqP3L85 = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1736566656 ^ -1736509436), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 8:
			CheckBoxEnable = (CheckBox)P_1;
			break;
		case 9:
			ButtonOk = (Button)P_1;
			ButtonOk.Click += dj62w6P8j8X;
			break;
		default:
			qQC2wqP3L85 = true;
			break;
		case 10:
			ButtonCancel = (Button)P_1;
			AY3NoeDfrjIakIhgWLru(ButtonCancel, new RoutedEventHandler(eCF2wMUCiwe));
			break;
		case 7:
			CheckBoxSmtpSsl = (CheckBox)P_1;
			break;
		case 6:
			TextBoxSmtpPassword = (PasswordBox)P_1;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 5:
			TextBoxSmtpLogin = (TextBox)P_1;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a337f255b1bd4e8290c28001e28630dc != 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 1:
			HBoZx7DfC1XMYMYgDdil((BR6Uy42wdA7n9lDhqT1n)P_1, new RoutedEventHandler(kml2wRJtMLo));
			num = 3;
			goto IL_0009;
		case 2:
			TextBoxFrom = (TextBox)P_1;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 4:
			TextBoxSmtpServer = (TextBox)P_1;
			num = 4;
			goto IL_0009;
		case 3:
			{
				TextBoxTo = (TextBox)P_1;
				num = 5;
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 2:
				break;
			case 4:
				break;
			case 3:
				break;
			case 5:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static BR6Uy42wdA7n9lDhqT1n()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void UkFXi9DfgSFDNvX9nq0b()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static object JFVtYyDfRBtudbDtXUFG(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool i013WZDfQUrASS9G9VHU()
	{
		return QC59BtDfE7BE6Gs6Or4N == null;
	}

	internal static BR6Uy42wdA7n9lDhqT1n tJliGCDfd78TkNdIvgRD()
	{
		return QC59BtDfE7BE6Gs6Or4N;
	}

	internal static object TWF6F5Df6TjxXwZGDFnI()
	{
		return j18iDj9nukSCmEyZs5lH.aFH9GeRevRU();
	}

	internal static object sPqbPCDfM9tCUx1ieJwB(object P_0)
	{
		return ((oPtcN290TuwfxN9qnftN)P_0).To;
	}

	internal static void CoKJyqDfOHRyD7YtXqJ7(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object YGXYTODfq4k6cSbnuAl2(object P_0)
	{
		return ((oPtcN290TuwfxN9qnftN)P_0).urH90pheTH7();
	}

	internal static void nO6lqVDfIjvXF1UTdS8E(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static void E8pFmtDfWqSA7AO9hXQZ(object P_0, object P_1)
	{
		((oPtcN290TuwfxN9qnftN)P_0).From = (string)P_1;
	}

	internal static object bgcYVrDftqEAfxhHTZLG(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void oM5hy8DfUTGUhVJW1dtd(object P_0, object P_1)
	{
		((oPtcN290TuwfxN9qnftN)P_0).nHI907hLrQI = (string)P_1;
	}

	internal static void sKZ8qEDfTfjj9828DmZG(object P_0, object P_1)
	{
		((oPtcN290TuwfxN9qnftN)P_0).Yw190PdupgM = (string)P_1;
	}

	internal static void EvlwdNDfyTecGAnfr2Io(object P_0, object P_1)
	{
		((oPtcN290TuwfxN9qnftN)P_0).Q1u90uU9bVo((string)P_1);
	}

	internal static void h1t8dUDfZW50lkcxIAST()
	{
		j18iDj9nukSCmEyZs5lH.Os19GalyoqM();
	}

	internal static void G4aCGJDfVTX79uvuRkx2(object P_0)
	{
		((Window)P_0).Close();
	}

	internal static void HBoZx7DfC1XMYMYgDdil(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static void AY3NoeDfrjIakIhgWLru(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}
}
