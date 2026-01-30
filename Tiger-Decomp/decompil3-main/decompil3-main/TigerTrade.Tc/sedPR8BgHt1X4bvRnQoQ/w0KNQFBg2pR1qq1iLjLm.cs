using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using o3QVrlBEmUDhylMevt7x;
using TigerTrade.Tc.Manager;
using TXVlbqBgXdIRlcg65aT2;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;
using zP8V5rBgqhIEeQJ7uiD4;

namespace sedPR8BgHt1X4bvRnQoQ;

internal class w0KNQFBg2pR1qq1iLjLm : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly MpQsYjBgOqMyWjPe8DXF UZmBgfv0e5A;

	private readonly ITdolSBEKZpwkQdpo7Ox E0jBg9nXkIX;

	internal ComboBox ComboBoxAccount;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	internal CheckBox CheckBoxReduceDom;

	private bool RKcBgnTuhGC;

	internal static w0KNQFBg2pR1qq1iLjLm DT7V2fxgUS4PLlKLwIJ4;

	public w0KNQFBg2pR1qq1iLjLm()
	{
		qN8YcGxgZbNnjMakqm0q();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1799510641 ^ -1799586775));
		InitializeComponent();
	}

	public w0KNQFBg2pR1qq1iLjLm(MpQsYjBgOqMyWjPe8DXF P_0, ITdolSBEKZpwkQdpo7Ox P_1)
	{
		qN8YcGxgZbNnjMakqm0q();
		this._002Ector();
		UZmBgfv0e5A = P_0;
		E0jBg9nXkIX = P_1;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_8ffeecc0bd5f4297ab0d20f3eed8f6a7 == 0)
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
		if (UZmBgfv0e5A == null)
		{
			return;
		}
		((ItemCollection)fjH5pZxgVSp0i7RyZLvy(ComboBoxAccount)).Clear();
		foreach (NX016EBgsUtma7PN82l2 item in MpQsYjBgOqMyWjPe8DXF.Accounts)
		{
			ComboBoxAccount.Items.Add(item);
			if (!xbT2m6xgr5q9oAiUuYrQ(UZmBgfv0e5A.Account, OinonrxgC8dGFVTJCOxf(item)))
			{
				continue;
			}
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					break;
				default:
					ComboBoxAccount.SelectedItem = item;
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9163e691086140c48f81f0e7fb53ce73 == 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			}
		}
		while (true)
		{
			ComboBoxAccount.IsEnabled = h5HaXeEc8DD();
			int num2 = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
			{
				num2 = 2;
			}
			while (true)
			{
				switch (num2)
				{
				case 3:
					CheckBoxReduceDom.IsChecked = XTN5noxgmvFaBGFFxlw5(UZmBgfv0e5A);
					return;
				case 2:
					GdIIuGxgKcWKV7P7u0lc(TextBoxApiKey, UZmBgfv0e5A.L3HBghhSZSI);
					TextBoxApiSecret.Password = UZmBgfv0e5A.zSHBgAXVRok();
					TextBoxProxy.Text = UZmBgfv0e5A.Proxy;
					GdIIuGxgKcWKV7P7u0lc(TextBoxProxyUser, UZmBgfv0e5A.sFbBRaXRf4L);
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					TextBoxProxyPass.Password = UZmBgfv0e5A.RcYBR4Utfcy;
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		if (UZmBgfv0e5A == null)
		{
			return;
		}
		UZmBgfv0e5A.Account = ((ComboBoxAccount.SelectedItem is NX016EBgsUtma7PN82l2 nX016EBgsUtma7PN82l) ? nX016EBgsUtma7PN82l.aylBgdQG8nj() : "");
		E0jBg9nXkIX.P5FBdYMkdCs();
		UZmBgfv0e5A.L3HBghhSZSI = (string)Ai2RM8xghViLnlGAyuRG(TextBoxApiKey.Text);
		UZmBgfv0e5A.eIqBgPEdNrr((string)Ai2RM8xghViLnlGAyuRG(TextBoxApiSecret.Password));
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				cq2Nyqxg8FxSeIdaQlQ5(UZmBgfv0e5A, CheckBoxReduceDom.IsChecked == true);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a6a8019a3a5d4ff4addfd8869f52f66e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				UZmBgfv0e5A.sFbBRaXRf4L = (string)Ai2RM8xghViLnlGAyuRG(TextBoxProxyUser.Text);
				BuhKUZxg7af0qcX8SURF(UZmBgfv0e5A, Ai2RM8xghViLnlGAyuRG(TextBoxProxyPass.Password));
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				UZmBgfv0e5A.Proxy = (string)Ai2RM8xghViLnlGAyuRG(xyKw30xgwK05Bm8fet6c(TextBoxProxy));
				num2 = 2;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				UZmBgfv0e5A.gpqG8g0ePAk();
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
				if (RKcBgnTuhGC)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09f5bdbb03464d38aa1686c9f4947f17 == 0)
					{
						num2 = 0;
					}
					break;
				}
				RKcBgnTuhGC = true;
				Uri resourceLocator = new Uri((string)PNDI3TxgAqUf9Xb8pKM5(0x769C7931 ^ 0x769DA0F7), UriKind.Relative);
				Application.LoadComponent(this, resourceLocator);
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
		return (Delegate)GS36pRxgP65R7atCmfj5(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
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
			case 4:
				return;
			default:
				RKcBgnTuhGC = true;
				return;
			case 1:
				switch (P_0)
				{
				case 3:
					TextBoxApiSecret = (PasswordBox)P_1;
					return;
				case 2:
					TextBoxApiKey = (TextBox)P_1;
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					ComboBoxAccount = (ComboBox)P_1;
					return;
				default:
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
					{
						num2 = 0;
					}
					break;
				case 6:
					TextBoxProxyPass = (PasswordBox)P_1;
					return;
				case 5:
					TextBoxProxyUser = (TextBox)P_1;
					return;
				case 4:
					TextBoxProxy = (TextBox)P_1;
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					CheckBoxReduceDom = (CheckBox)P_1;
					num2 = 4;
					break;
				}
				break;
			case 3:
				return;
			}
		}
	}

	static w0KNQFBg2pR1qq1iLjLm()
	{
		gb3EhnxgJfZEwCTtcERw();
		hcViaOxgFpAk8fs6jGxn();
	}

	internal static void qN8YcGxgZbNnjMakqm0q()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static bool Es0JGfxgTVpKx70SWNAE()
	{
		return DT7V2fxgUS4PLlKLwIJ4 == null;
	}

	internal static w0KNQFBg2pR1qq1iLjLm vQgHHgxgyAxsoyxNR1Wu()
	{
		return DT7V2fxgUS4PLlKLwIJ4;
	}

	internal static object fjH5pZxgVSp0i7RyZLvy(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object OinonrxgC8dGFVTJCOxf(object P_0)
	{
		return ((NX016EBgsUtma7PN82l2)P_0).aylBgdQG8nj();
	}

	internal static bool xbT2m6xgr5q9oAiUuYrQ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static void GdIIuGxgKcWKV7P7u0lc(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static bool XTN5noxgmvFaBGFFxlw5(object P_0)
	{
		return ((MpQsYjBgOqMyWjPe8DXF)P_0).cEKBRNwnRxJ;
	}

	internal static object Ai2RM8xghViLnlGAyuRG(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object xyKw30xgwK05Bm8fet6c(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void BuhKUZxg7af0qcX8SURF(object P_0, object P_1)
	{
		((MpQsYjBgOqMyWjPe8DXF)P_0).RcYBR4Utfcy = (string)P_1;
	}

	internal static void cq2Nyqxg8FxSeIdaQlQ5(object P_0, bool P_1)
	{
		((MpQsYjBgOqMyWjPe8DXF)P_0).cEKBRNwnRxJ = P_1;
	}

	internal static object PNDI3TxgAqUf9Xb8pKM5(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static object GS36pRxgP65R7atCmfj5(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void gb3EhnxgJfZEwCTtcERw()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}

	internal static void hcViaOxgFpAk8fs6jGxn()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
