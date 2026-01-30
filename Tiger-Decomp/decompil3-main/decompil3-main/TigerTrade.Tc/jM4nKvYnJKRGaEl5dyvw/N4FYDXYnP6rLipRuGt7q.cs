using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using blUbhuYGrP1RZFCOGcw1;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using R73uqWYnuNemEnvgLjdO;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace jM4nKvYnJKRGaEl5dyvw;

internal class N4FYDXYnP6rLipRuGt7q : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly pTUY25YGCEN5dn8fwd3g WXpYnFXP9v7;

	internal TextBox TextBoxLogin;

	internal PasswordBox TextBoxPassword;

	internal ComboBox ComboBoxServer;

	private bool BmiYn3TAXLc;

	internal static N4FYDXYnP6rLipRuGt7q LmiyeJSGQE4BZRkb2sBX;

	public N4FYDXYnP6rLipRuGt7q()
	{
		JgMJW2SGRRA3R1PELann();
		base._002Ector();
		TcEvents.RiseTrackWindow((string)xElq0pSG6Uw9HsHFeyom(-45476899 ^ -45412057));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	public N4FYDXYnP6rLipRuGt7q(pTUY25YGCEN5dn8fwd3g P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		WXpYnFXP9v7 = P_0;
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		List<zqUHQqYnpwFsIpgX42kQ>.Enumerator enumerator = default(List<zqUHQqYnpwFsIpgX42kQ>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				try
				{
					while (enumerator.MoveNext())
					{
						zqUHQqYnpwFsIpgX42kQ current = enumerator.Current;
						((ItemCollection)eKLtSrSGMrvCBaCXHfdN(ComboBoxServer)).Add((object)current);
						int num3 = 2;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 2:
								if (!((string)J6hOeHSGObh3O0A4e8iU(WXpYnFXP9v7) == current.tetYnzQExYo()))
								{
									num3 = 1;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_023d36f28198465ebfedbcf888e46336 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto default;
							default:
								DS6DRqSGqbp0DJcdKs1U(ComboBoxServer, current);
								break;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				TextBoxLogin.Text = (string)I29Q4nSGIIhRkgNxvYwt(WXpYnFXP9v7);
				kUX8gfSGtliHcZmM0pu5(TextBoxPassword, TiePgeSGWdmIdy01p0be(WXpYnFXP9v7));
				return;
			case 1:
				if (WXpYnFXP9v7 == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
					{
						num2 = 0;
					}
					break;
				}
				((ItemCollection)eKLtSrSGMrvCBaCXHfdN(ComboBoxServer)).Clear();
				enumerator = pTUY25YGCEN5dn8fwd3g.Servers.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void SaveSettings()
	{
		if (WXpYnFXP9v7 == null)
		{
			return;
		}
		WXpYnFXP9v7.j6xYG7dGmSe = ((ComboBoxServer.SelectedItem is zqUHQqYnpwFsIpgX42kQ zqUHQqYnpwFsIpgX42kQ) ? zqUHQqYnpwFsIpgX42kQ.tetYnzQExYo() : "");
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				uVCwukSGVOep3WJ1QrAQ(WXpYnFXP9v7);
				return;
			}
			fiJplhSGT7993msko8QE(WXpYnFXP9v7, tjlshGSGUZnmR3CUpqIO(TextBoxLogin.Text));
			SwRgW4SGZyBwSGV6Htwm(WXpYnFXP9v7, tjlshGSGUZnmR3CUpqIO(F626SeSGyElS18bFBLui(TextBoxPassword)));
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 != 0)
			{
				num = 1;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-377195341 ^ -377129047), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
				return;
			}
			case 1:
				BmiYn3TAXLc = true;
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (BmiYn3TAXLc)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)xmDSQPSGCYF80UY3y2St(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				BmiYn3TAXLc = true;
				return;
			case 1:
				switch (P_0)
				{
				case 1:
					TextBoxLogin = (TextBox)P_1;
					return;
				case 3:
					ComboBoxServer = (ComboBox)P_1;
					return;
				default:
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					TextBoxPassword = (PasswordBox)P_1;
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
					{
						num2 = 2;
					}
					break;
				}
				break;
			}
		}
	}

	static N4FYDXYnP6rLipRuGt7q()
	{
		LsVevNSGrhpHTfMMU7Dh();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void JgMJW2SGRRA3R1PELann()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object xElq0pSG6Uw9HsHFeyom(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool QZPVATSGdh3GoGt6KBPm()
	{
		return LmiyeJSGQE4BZRkb2sBX == null;
	}

	internal static N4FYDXYnP6rLipRuGt7q Lr9XIVSGgQKVogo9MIJa()
	{
		return LmiyeJSGQE4BZRkb2sBX;
	}

	internal static object eKLtSrSGMrvCBaCXHfdN(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object J6hOeHSGObh3O0A4e8iU(object P_0)
	{
		return ((pTUY25YGCEN5dn8fwd3g)P_0).j6xYG7dGmSe;
	}

	internal static void DS6DRqSGqbp0DJcdKs1U(object P_0, object P_1)
	{
		((Selector)P_0).SelectedItem = P_1;
	}

	internal static object I29Q4nSGIIhRkgNxvYwt(object P_0)
	{
		return ((pTUY25YGCEN5dn8fwd3g)P_0).Login;
	}

	internal static object TiePgeSGWdmIdy01p0be(object P_0)
	{
		return ((pTUY25YGCEN5dn8fwd3g)P_0).Password;
	}

	internal static void kUX8gfSGtliHcZmM0pu5(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static object tjlshGSGUZnmR3CUpqIO(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void fiJplhSGT7993msko8QE(object P_0, object P_1)
	{
		((pTUY25YGCEN5dn8fwd3g)P_0).Login = (string)P_1;
	}

	internal static object F626SeSGyElS18bFBLui(object P_0)
	{
		return ((PasswordBox)P_0).Password;
	}

	internal static void SwRgW4SGZyBwSGV6Htwm(object P_0, object P_1)
	{
		((pTUY25YGCEN5dn8fwd3g)P_0).Password = (string)P_1;
	}

	internal static void uVCwukSGVOep3WJ1QrAQ(object P_0)
	{
		((gpnr5oG8Q1cRMmiYT0Ut)P_0).gpqG8g0ePAk();
	}

	internal static object xmDSQPSGCYF80UY3y2St(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void LsVevNSGrhpHTfMMU7Dh()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
