using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using itVSfmo7rAiI3gADmeU0;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace uGdxmmo7yHbH38vPE6Ds;

internal class lIKNKEo7Tj2gcBAWtEL1 : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly FA6wN9o7CZeE9asNIlya U1Vo7ZbLgpM;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	private bool cQRo7VbRhMh;

	internal static lIKNKEo7Tj2gcBAWtEL1 HGWWgeSukj1ojVdgoX0a;

	public lIKNKEo7Tj2gcBAWtEL1()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-5977659 ^ -5939501));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1ffb673338994bcebbf04b5423a4e95d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public lIKNKEo7Tj2gcBAWtEL1(FA6wN9o7CZeE9asNIlya P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		U1Vo7ZbLgpM = P_0;
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (U1Vo7ZbLgpM == null)
		{
			return;
		}
		TextBoxApiKey.Text = U1Vo7ZbLgpM.W6fo78lwkAS;
		TextBoxApiSecret.Password = (string)mbkSvsSuSdpjouVpMRLB(U1Vo7ZbLgpM);
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7101152ce069403f9cf307c1d31372ac == 0)
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
			YNl2vjSux5RV4OtUNUyo(TextBoxProxy, U1Vo7ZbLgpM.Proxy);
			TextBoxProxyUser.Text = U1Vo7ZbLgpM.AUbo8nKkM5C;
			WMZbj4SuLt2Y4jZjkfLj(TextBoxProxyPass, U1Vo7ZbLgpM.sGpo8o2tVOq);
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
			{
				num = 0;
			}
		}
	}

	public override void SaveSettings()
	{
		if (U1Vo7ZbLgpM == null)
		{
			return;
		}
		U1Vo7ZbLgpM.W6fo78lwkAS = TextBoxApiKey.Text.Trim();
		U1Vo7ZbLgpM.N4bo73ye0fJ(TextBoxApiSecret.Password.Trim());
		U1Vo7ZbLgpM.Proxy = TextBoxProxy.Text.Trim();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_863ddca33ab24df3a8c9a4e42ae6cbdc != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
			{
				U1Vo7ZbLgpM.sGpo8o2tVOq = (string)rUPm2pSueUKa1VVNjiHs(uDkWmqSusMDJ3ZcA1djK(TextBoxProxyPass));
				xlfXiNSuX3FlNxfCGpxK(U1Vo7ZbLgpM);
				int num2 = 2;
				num = num2;
				break;
			}
			case 1:
				U1Vo7ZbLgpM.AUbo8nKkM5C = (string)rUPm2pSueUKa1VVNjiHs(TextBoxProxyUser.Text);
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
				if (cQRo7VbRhMh)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
					{
						num2 = 0;
					}
					break;
				}
				cQRo7VbRhMh = true;
				Uri uri = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x7394D272 ^ 0x73954544), UriKind.Relative);
				OSfjoVSuc5kpcTO7lwSK(this, uri);
				return;
			}
			case 0:
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
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
			default:
				return;
			case 2:
				switch (P_0)
				{
				default:
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					TextBoxApiKey = (TextBox)P_1;
					return;
				case 2:
					TextBoxApiSecret = (PasswordBox)P_1;
					return;
				case 5:
					TextBoxProxyPass = (PasswordBox)P_1;
					return;
				case 3:
					TextBoxProxy = (TextBox)P_1;
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					TextBoxProxyUser = (TextBox)P_1;
					num2 = 3;
					break;
				}
				break;
			case 3:
				return;
			case 0:
				return;
			case 1:
				cQRo7VbRhMh = true;
				return;
			}
		}
	}

	static lIKNKEo7Tj2gcBAWtEL1()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		j8i4YqSuj8sEbLcAvFap();
	}

	internal static bool PPhbXqSu1e5gP47P8UI7()
	{
		return HGWWgeSukj1ojVdgoX0a == null;
	}

	internal static lIKNKEo7Tj2gcBAWtEL1 CjRII4Su5P26PUirV6u2()
	{
		return HGWWgeSukj1ojVdgoX0a;
	}

	internal static object mbkSvsSuSdpjouVpMRLB(object P_0)
	{
		return ((FA6wN9o7CZeE9asNIlya)P_0).Ia7o7Fa78vd();
	}

	internal static void YNl2vjSux5RV4OtUNUyo(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static void WMZbj4SuLt2Y4jZjkfLj(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static object rUPm2pSueUKa1VVNjiHs(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object uDkWmqSusMDJ3ZcA1djK(object P_0)
	{
		return ((PasswordBox)P_0).Password;
	}

	internal static void xlfXiNSuX3FlNxfCGpxK(object P_0)
	{
		((gpnr5oG8Q1cRMmiYT0Ut)P_0).gpqG8g0ePAk();
	}

	internal static void OSfjoVSuc5kpcTO7lwSK(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void j8i4YqSuj8sEbLcAvFap()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
