using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using etmeuxouDNyDSK3EoyHZ;
using jXhQeeouy3wuGQsBBUtS;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Manager;
using WdgjuZo3OHSsLQSxlJe5;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace gW8p4gouBFO6ZbdhZsu3;

internal class b1bDgWouvjCHV3f5Sn8f : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly p8uvb4ouTBYe40i6SNXX eB6ouaefa52;

	private readonly I1kfceo3MHwW1lu5sDLN dGJouiCEm7O;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	internal CheckBox CheckBoxInternalPositions;

	private bool bBvoulKCQgy;

	internal static b1bDgWouvjCHV3f5Sn8f vvdwl4x9CUqXL6MGJRBS;

	public b1bDgWouvjCHV3f5Sn8f()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		nH8eg5x9ht0YF9kBHLVD(qRHlgZx9mH8xGrd25ViY(-1461292091 ^ -1461202223));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public b1bDgWouvjCHV3f5Sn8f(p8uvb4ouTBYe40i6SNXX P_0, I1kfceo3MHwW1lu5sDLN P_1)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		eB6ouaefa52 = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_db475a540dcc44d9a72c3f197bb7b1f7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		dGJouiCEm7O = P_1;
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				if (eB6ouaefa52 == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ceb7e581f1314bbd87cbf42baae4882f == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					IeYmq4x9w1N04y6ajaeo(ComboBoxServer.Items);
					num2 = 2;
				}
				continue;
			case 2:
				foreach (S1Y6QBou4S6yZX6W0bpb item in p8uvb4ouTBYe40i6SNXX.Servers)
				{
					((ItemCollection)SNhGcJx97tCfx8OLmcGm(ComboBoxServer)).Add((object)item);
					int num3;
					if (!(eB6ouaefa52.mGhouhUJwCE == (string)vpkGqfx98tMSi0WXveY6(item)))
					{
						num3 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
						{
							num3 = 0;
						}
						goto IL_00c7;
					}
					goto IL_00dd;
					IL_00c7:
					switch (num3)
					{
					case 2:
						break;
					default:
						continue;
					}
					goto IL_00dd;
					IL_00dd:
					ComboBoxServer.SelectedItem = item;
					num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
					{
						num3 = 0;
					}
					goto IL_00c7;
				}
				break;
			case 3:
				return;
			case 1:
				break;
			}
			BajxJOx9PmFaYrprGJdj(TextBoxApiKey, p3QgBdx9ARx3g636nbPU(eB6ouaefa52));
			TextBoxApiSecret.Password = eB6ouaefa52.SDBouFtBO7G();
			TextBoxProxy.Text = (string)VoXIfex9JrV6it5iNDSJ(eB6ouaefa52);
			TextBoxProxyUser.Text = eB6ouaefa52.hJBoznER3mU;
			e3XQb4x9FaMOt52CXGeI(TextBoxProxyPass, eB6ouaefa52.u1bozohyOgL);
			CheckBoxInternalPositions.IsChecked = eB6ouaefa52.rnyozLBodwV;
			num2 = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
			{
				num2 = 0;
			}
		}
	}

	public override void SaveSettings()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					eB6ouaefa52.Proxy = ((string)fLSL87x9zeDeBJVntT5e(TextBoxProxy)).Trim();
					eB6ouaefa52.hJBoznER3mU = ((string)fLSL87x9zeDeBJVntT5e(TextBoxProxyUser)).Trim();
					J7cX3vxn0vXeAK2p8fLP(eB6ouaefa52, TextBoxProxyPass.Password.Trim());
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a492d58832fc437f977bce5ba015cace != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 4:
					return;
				case 3:
					if (eB6ouaefa52 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_b6dfeebb9aa04a23846c37da6e9b7d4d != 0)
						{
							num2 = 2;
						}
						continue;
					}
					eB6ouaefa52.mGhouhUJwCE = (string)((ComboBoxServer.SelectedItem is S1Y6QBou4S6yZX6W0bpb s1Y6QBou4S6yZX6W0bpb) ? vpkGqfx98tMSi0WXveY6(s1Y6QBou4S6yZX6W0bpb) : "");
					dGJouiCEm7O.AUYopclifUc();
					bVZ4jwx9pnn0rWBypLSA(eB6ouaefa52, PSlq4rx93doriGfEJhPP(TextBoxApiKey.Text));
					eB6ouaefa52.K0lou33jFPC(((string)u4FP8cx9uXbY9EpNXmJu(TextBoxApiSecret)).Trim());
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_aec259916d0a4bcebababa49a58288c4 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			eB6ouaefa52.rnyozLBodwV = CheckBoxInternalPositions.IsChecked == true;
			eB6ouaefa52.gpqG8g0ePAk();
			num = 4;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!bBvoulKCQgy)
		{
			bBvoulKCQgy = true;
			Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1161619942 ^ -1161644246), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d != 0)
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
		int num;
		switch (P_0)
		{
		case 5:
			TextBoxProxyUser = (TextBox)P_1;
			break;
		case 3:
			TextBoxApiSecret = (PasswordBox)P_1;
			num = 2;
			goto IL_0009;
		default:
			bBvoulKCQgy = true;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 4:
			TextBoxProxy = (TextBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0069558de67b47d29bc64855b3a11e20 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			ComboBoxServer = (ComboBox)P_1;
			num = 3;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ca333d1f5b544c679e2f04abd45bbe97 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 7:
			CheckBoxInternalPositions = (CheckBox)P_1;
			break;
		case 6:
			TextBoxProxyPass = (PasswordBox)P_1;
			break;
		case 2:
			{
				TextBoxApiKey = (TextBox)P_1;
				break;
			}
			IL_0009:
			switch (num)
			{
			case 0:
				break;
			case 1:
				break;
			case 2:
				break;
			case 3:
				break;
			}
			break;
		}
	}

	static b1bDgWouvjCHV3f5Sn8f()
	{
		aSHp23xn2ExkO25HcZR3();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object qRHlgZx9mH8xGrd25ViY(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void nH8eg5x9ht0YF9kBHLVD(object P_0)
	{
		TcEvents.RiseTrackWindow((string)P_0);
	}

	internal static bool SA3Hj2x9rjRZ9iVgX0sI()
	{
		return vvdwl4x9CUqXL6MGJRBS == null;
	}

	internal static b1bDgWouvjCHV3f5Sn8f i8KPkDx9K3bFKj6ryGEO()
	{
		return vvdwl4x9CUqXL6MGJRBS;
	}

	internal static void IeYmq4x9w1N04y6ajaeo(object P_0)
	{
		((ItemCollection)P_0).Clear();
	}

	internal static object SNhGcJx97tCfx8OLmcGm(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object vpkGqfx98tMSi0WXveY6(object P_0)
	{
		return ((S1Y6QBou4S6yZX6W0bpb)P_0).E6uoucF3cr2();
	}

	internal static object p3QgBdx9ARx3g636nbPU(object P_0)
	{
		return ((p8uvb4ouTBYe40i6SNXX)P_0).IuJou8uNVfF;
	}

	internal static void BajxJOx9PmFaYrprGJdj(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object VoXIfex9JrV6it5iNDSJ(object P_0)
	{
		return ((p8uvb4ouTBYe40i6SNXX)P_0).Proxy;
	}

	internal static void e3XQb4x9FaMOt52CXGeI(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static object PSlq4rx93doriGfEJhPP(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void bVZ4jwx9pnn0rWBypLSA(object P_0, object P_1)
	{
		((p8uvb4ouTBYe40i6SNXX)P_0).IuJou8uNVfF = (string)P_1;
	}

	internal static object u4FP8cx9uXbY9EpNXmJu(object P_0)
	{
		return ((PasswordBox)P_0).Password;
	}

	internal static object fLSL87x9zeDeBJVntT5e(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void J7cX3vxn0vXeAK2p8fLP(object P_0, object P_1)
	{
		((p8uvb4ouTBYe40i6SNXX)P_0).u1bozohyOgL = (string)P_1;
	}

	internal static void aSHp23xn2ExkO25HcZR3()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
