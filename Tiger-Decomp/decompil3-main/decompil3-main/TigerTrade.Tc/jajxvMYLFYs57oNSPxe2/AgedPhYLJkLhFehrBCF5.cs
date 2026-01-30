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
using K1GcsD5GTtMSlaiJI0Xh;
using qRmLnDYeDcI7ZkCw7JVI;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;
using XP3EJ9YLzrJfpg9e7rWs;

namespace jajxvMYLFYs57oNSPxe2;

internal class AgedPhYLJkLhFehrBCF5 : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly p5ZAiVYe4MwbvA9WYOBi G23YL3158fS;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxLogin;

	internal PasswordBox TextBoxPassword;

	private bool FlOYLpkw0ww;

	internal static AgedPhYLJkLhFehrBCF5 dHmfqpS1rR7XiS4biEH3;

	public AgedPhYLJkLhFehrBCF5()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		chfS5rS1hOIyhT74em7Z(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1309555870 ^ -1309635544));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_afc43ca45d1d4ff282cb9aa0629127c4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public AgedPhYLJkLhFehrBCF5(p5ZAiVYe4MwbvA9WYOBi P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		G23YL3158fS = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cda90b2e8c4e4a1095d682ebf3835244 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (G23YL3158fS == null)
		{
			return;
		}
		((ItemCollection)yPA8mTS1w1NJZNODUpQu(ComboBoxServer)).Clear();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ac3c5fcdf484302951e15fc405858a5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 1:
		{
			using (List<qpaDTwYLuXbF5ymVM6yv>.Enumerator enumerator = p5ZAiVYe4MwbvA9WYOBi.Servers.GetEnumerator())
			{
				while (true)
				{
					if (!enumerator.MoveNext())
					{
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_3d8a38b1cb21466e854270ec8942c6ca != 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						default:
							goto end_IL_00cd;
						case 1:
							break;
						case 0:
							goto end_IL_00cd;
						}
					}
					qpaDTwYLuXbF5ymVM6yv current = enumerator.Current;
					ComboBoxServer.Items.Add(current);
					if (G23YL3158fS.DKOYe5MLgCT == current.c8DYe00M9HM())
					{
						QdfNgiS17Ii0rZodbHVk(ComboBoxServer, current);
					}
					continue;
					end_IL_00cd:
					break;
				}
			}
			break;
		}
		}
		mPd6l7S18K9UHFBVXbQh(TextBoxLogin, G23YL3158fS.Login);
		TextBoxPassword.Password = G23YL3158fS.Password;
	}

	public override void SaveSettings()
	{
		if (G23YL3158fS == null)
		{
			return;
		}
		G23YL3158fS.DKOYe5MLgCT = (string)((ComboBoxServer.SelectedItem is qpaDTwYLuXbF5ymVM6yv qpaDTwYLuXbF5ymVM6yv) ? vN0YhZS1A4dMAGhLqU8j(qpaDTwYLuXbF5ymVM6yv) : "");
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				h25yGSS1JrGUhPbBbmDl(G23YL3158fS, ri62KoS1PMflgneYaM3G(TextBoxLogin.Text));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
				{
					num = 0;
				}
				break;
			default:
				a2akMUS1FIhFvamV0gQY(G23YL3158fS, TextBoxPassword.Password.Trim());
				G23YL3158fS.gpqG8g0ePAk();
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!FlOYLpkw0ww)
		{
			FlOYLpkw0ww = true;
			Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1736566656 ^ -1736484894), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f19bbaca9e82419ba66f0bdafd2c824a == 0)
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

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		switch (P_0)
		{
		default:
			FlOYLpkw0ww = true;
			return;
		case 3:
			TextBoxPassword = (PasswordBox)P_1;
			return;
		case 1:
			break;
		case 2:
		{
			TextBoxLogin = (TextBox)P_1;
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
			}
			break;
		}
		}
		ComboBoxServer = (ComboBox)P_1;
	}

	static AgedPhYLJkLhFehrBCF5()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		YI1CsZS13IprYkhOPBpr();
	}

	internal static void chfS5rS1hOIyhT74em7Z(object P_0)
	{
		TcEvents.RiseTrackWindow((string)P_0);
	}

	internal static bool omOYsvS1KVSIp7KBsMoo()
	{
		return dHmfqpS1rR7XiS4biEH3 == null;
	}

	internal static AgedPhYLJkLhFehrBCF5 zaxPylS1mfoDx4L6n6qO()
	{
		return dHmfqpS1rR7XiS4biEH3;
	}

	internal static object yPA8mTS1w1NJZNODUpQu(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void QdfNgiS17Ii0rZodbHVk(object P_0, object P_1)
	{
		((Selector)P_0).SelectedItem = P_1;
	}

	internal static void mPd6l7S18K9UHFBVXbQh(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object vN0YhZS1A4dMAGhLqU8j(object P_0)
	{
		return ((qpaDTwYLuXbF5ymVM6yv)P_0).c8DYe00M9HM();
	}

	internal static object ri62KoS1PMflgneYaM3G(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void h25yGSS1JrGUhPbBbmDl(object P_0, object P_1)
	{
		((p5ZAiVYe4MwbvA9WYOBi)P_0).Login = (string)P_1;
	}

	internal static void a2akMUS1FIhFvamV0gQY(object P_0, object P_1)
	{
		((p5ZAiVYe4MwbvA9WYOBi)P_0).Password = (string)P_1;
	}

	internal static void YI1CsZS13IprYkhOPBpr()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
