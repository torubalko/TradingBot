using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;
using a71ZFuG7YJso6BiY1tbu;
using ActiproSoftware.Windows.Controls.Editors;
using b2M78PYkLtfptaeGCInS;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using MCaveiYbwGxilEFWV6GP;
using mLe34MYNlri0sEPjP8s1;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Tc;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using TiTSM3YbukLCGDOnkNL0;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace xBbDb5YkN11WEe4KJVtZ;

internal class VkBNpDYkb2pY42Omp9aH : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly mGIEhqYkxBT6IGMf4xBp peiYk14Xwjs;

	private readonly xcOUD3YNiEOXMxkLcN0D L71Yk5Cv4D1;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxLogin;

	internal Button ButtonChangePassword;

	internal PasswordBox TextBoxPassword;

	internal ComboBox ComboBoxLogLevel;

	internal CheckBox CheckBoxAutoConnect;

	internal TimeSpanEditBox CheckBoxConnectTime;

	private bool hS4YkSFrRTP;

	internal static VkBNpDYkb2pY42Omp9aH euHTf3Si3xoWleG1GPO3;

	public VkBNpDYkb2pY42Omp9aH()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-44540535 ^ -44492257));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public VkBNpDYkb2pY42Omp9aH(mGIEhqYkxBT6IGMf4xBp P_0, xcOUD3YNiEOXMxkLcN0D P_1)
	{
		cvhrvESiz2YaAO32fEv2();
		this._002Ector();
		peiYk14Xwjs = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_067bb9a4251b4173906596508c60e32c == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		L71Yk5Cv4D1 = P_1;
	}

	private void TransaqControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (peiYk14Xwjs == null)
		{
			return;
		}
		((ItemCollection)fZea4SSl0hu3FmMLalGO(ComboBoxServer)).Clear();
		List<heg98JYbpBZy6O2537xL>.Enumerator enumerator = mGIEhqYkxBT6IGMf4xBp.Servers.GetEnumerator();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				foreach (fFPqqBYbhk8Y8IPjmali item in mGIEhqYkxBT6IGMf4xBp.E6UYkVTaC6B())
				{
					int num3 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							E2WGpQSlHoQfOfDotuwF(fZea4SSl0hu3FmMLalGO(ComboBoxLogLevel), item);
							num3 = 0;
							if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_52cc4e9134f2471cbe16e9a63df4155b == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					if (peiYk14Xwjs.XQqYkOZa6Uq == rnRrvDSlf8XjjmLm9yUF(item))
					{
						ComboBoxLogLevel.SelectedItem = item;
					}
				}
				KUaHuBSlnylweScBYnMU(TextBoxLogin, bqqnt5Sl9hC1xoHqYXi3(peiYk14Xwjs));
				T3fWcrSlGiDqlBwhBrDc(TextBoxPassword, peiYk14Xwjs.Password);
				CheckBoxAutoConnect.IsChecked = c8LVXMSlYuCGhn519RyF(peiYk14Xwjs);
				num = 2;
				continue;
			case 4:
				try
				{
					while (enumerator.MoveNext())
					{
						heg98JYbpBZy6O2537xL current = enumerator.Current;
						((ItemCollection)fZea4SSl0hu3FmMLalGO(ComboBoxServer)).Add((object)current);
						int num2 = 0;
						if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_f3678a7908b24fbf90f40bdd06f93585 == 0)
						{
							num2 = 1;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								ComboBoxServer.SelectedItem = current;
								break;
							case 1:
								if (peiYk14Xwjs.R2sYkjeVUfU == (string)b7dQ82Sl2R6rKr3gbS3p(current))
								{
									num2 = 0;
									if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1100fc9af5ab4ad2ab8cefa34e531240 != 0)
									{
										num2 = 0;
									}
									continue;
								}
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
				break;
			case 2:
				CheckBoxConnectTime.Value = t3lfBASlo1NrHhNKXEUs(peiYk14Xwjs);
				return;
			case 3:
				break;
			}
			ComboBoxLogLevel.Items.Clear();
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_34f7564c04fe45f19304e3f180fc4506 != 0)
			{
				num = 1;
			}
		}
	}

	public override void SaveSettings()
	{
		if (peiYk14Xwjs == null)
		{
			return;
		}
		M0hEhASlB8Vyk8eubNuD(peiYk14Xwjs, (AL3YQ6SlvmxZiSmSa3Yh(ComboBoxServer) is heg98JYbpBZy6O2537xL heg98JYbpBZy6O2537xL) ? heg98JYbpBZy6O2537xL.DjfYNGYeLYj() : "");
		peiYk14Xwjs.Login = (string)YpovvDSliMiDpwjrWxrs(s2nNFMSlaAJRxtmkPkCm(TextBoxLogin));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_267b6e28e0b84cf5a9effc88636b52de != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
			{
				fFPqqBYbhk8Y8IPjmali fFPqqBYbhk8Y8IPjmali = AL3YQ6SlvmxZiSmSa3Yh(ComboBoxLogLevel) as fFPqqBYbhk8Y8IPjmali;
				peiYk14Xwjs.XQqYkOZa6Uq = fFPqqBYbhk8Y8IPjmali?.WgVYbA0EZop() ?? 2;
				peiYk14Xwjs.AutoConnect = CheckBoxAutoConnect.IsChecked == true;
				peiYk14Xwjs.kJcYkUxjE93 = CheckBoxConnectTime.Value ?? TimeSpan.FromTicks(0L);
				peiYk14Xwjs.gpqG8g0ePAk();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7b7109b795404d83aab2ffb6bac7cdab != 0)
				{
					num = 3;
				}
				break;
			}
			default:
				peiYk14Xwjs.Password = TextBoxPassword.Password.Trim();
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void cZjYkk1mlc1(object P_0, RoutedEventArgs P_1)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		string value = default(string);
		while (true)
		{
			Window owner;
			string transaqControlPasswordChange;
			object message;
			switch (num2)
			{
			case 1:
				if (!((ConnectionInfo)wQIVOoSllyywblCyf1d0(L71Yk5Cv4D1)).IsConnected)
				{
					goto IL_00d5;
				}
				goto case 3;
			case 2:
				if (L71Yk5Cv4D1 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto IL_00d5;
			case 4:
				return;
			default:
				MessageWindow.ShowWindow(nP0aXS0QR5g(), TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange, (string)OJYQ7ASlDmHXSyWdCbhX());
				return;
			case 5:
				if (flag)
				{
					TextBoxPassword.Password = value;
				}
				return;
			case 3:
				{
					if (!InputWindow.ShowWindow(nP0aXS0QR5g(), TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange, TigerTrade.Tc.Properties.Resources.TransaqControlEnterNewPassword, out value) || !InputWindow.ShowWindow(nP0aXS0QR5g(), (string)CCw0xISl4tRBkjnRNoPM(), TigerTrade.Tc.Properties.Resources.TransaqControlConfirmPassword, out var value2))
					{
						return;
					}
					if (!(value != value2))
					{
						flag = L71Yk5Cv4D1.V9GYNbOTHs1((string)SIlbdbSlbyQGxHN0lgqQ(peiYk14Xwjs), value);
						owner = nP0aXS0QR5g();
						transaqControlPasswordChange = TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange;
						message = (flag ? TigerTrade.Tc.Properties.Resources.TransaqControlChangePasswordSucceeded : AS8swSSlNjdD82a2TvTt());
						break;
					}
					goto default;
				}
				IL_00d5:
				MessageWindow.ShowWindow(nP0aXS0QR5g(), TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange, (string)BOcsq4SlkKeJLNuyGqcr());
				num2 = 4;
				continue;
			}
			MessageWindow.ShowWindow(owner, transaqControlPasswordChange, (string)message);
			num2 = 5;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!hS4YkSFrRTP)
		{
			hS4YkSFrRTP = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x16AD7E76 ^ 0x16AC39C0), UriKind.Relative);
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 4:
			TextBoxPassword = (PasswordBox)P_1;
			return;
		case 2:
			TextBoxLogin = (TextBox)P_1;
			return;
		case 3:
			ButtonChangePassword = (Button)P_1;
			ButtonChangePassword.Click += cZjYkk1mlc1;
			num = 3;
			goto IL_0009;
		default:
			hS4YkSFrRTP = true;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 7:
			CheckBoxConnectTime = (TimeSpanEditBox)P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0f39f7e1a9544c369aecad65b3e6d6c4 == 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 5:
			ComboBoxLogLevel = (ComboBox)P_1;
			return;
		case 6:
			CheckBoxAutoConnect = (CheckBox)P_1;
			return;
		case 1:
			break;
			IL_0009:
			switch (num)
			{
			case 3:
				return;
			case 2:
				return;
			case 1:
				return;
			}
			break;
		}
		ComboBoxServer = (ComboBox)P_1;
	}

	static VkBNpDYkb2pY42Omp9aH()
	{
		dU854MSl1dvx2fQHwreh();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static bool C2Uu8OSipaHOZWQONOdg()
	{
		return euHTf3Si3xoWleG1GPO3 == null;
	}

	internal static VkBNpDYkb2pY42Omp9aH Eh2ugtSiucwMSKFvkn2D()
	{
		return euHTf3Si3xoWleG1GPO3;
	}

	internal static void cvhrvESiz2YaAO32fEv2()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object fZea4SSl0hu3FmMLalGO(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object b7dQ82Sl2R6rKr3gbS3p(object P_0)
	{
		return ((heg98JYbpBZy6O2537xL)P_0).DjfYNGYeLYj();
	}

	internal static int E2WGpQSlHoQfOfDotuwF(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static int rnRrvDSlf8XjjmLm9yUF(object P_0)
	{
		return ((fFPqqBYbhk8Y8IPjmali)P_0).WgVYbA0EZop();
	}

	internal static object bqqnt5Sl9hC1xoHqYXi3(object P_0)
	{
		return ((mGIEhqYkxBT6IGMf4xBp)P_0).Login;
	}

	internal static void KUaHuBSlnylweScBYnMU(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static void T3fWcrSlGiDqlBwhBrDc(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static bool c8LVXMSlYuCGhn519RyF(object P_0)
	{
		return ((mGIEhqYkxBT6IGMf4xBp)P_0).AutoConnect;
	}

	internal static TimeSpan t3lfBASlo1NrHhNKXEUs(object P_0)
	{
		return ((mGIEhqYkxBT6IGMf4xBp)P_0).kJcYkUxjE93;
	}

	internal static object AL3YQ6SlvmxZiSmSa3Yh(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static void M0hEhASlB8Vyk8eubNuD(object P_0, object P_1)
	{
		((mGIEhqYkxBT6IGMf4xBp)P_0).R2sYkjeVUfU = (string)P_1;
	}

	internal static object s2nNFMSlaAJRxtmkPkCm(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static object YpovvDSliMiDpwjrWxrs(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object wQIVOoSllyywblCyf1d0(object P_0)
	{
		return ((Yi88EJG7GEjfyLGpmx9j)P_0).mWXlYwTb86e;
	}

	internal static object CCw0xISl4tRBkjnRNoPM()
	{
		return TigerTrade.Tc.Properties.Resources.TransaqControlPasswordChange;
	}

	internal static object OJYQ7ASlDmHXSyWdCbhX()
	{
		return TigerTrade.Tc.Properties.Resources.TransaqControlPasswordsNotMatch;
	}

	internal static object SIlbdbSlbyQGxHN0lgqQ(object P_0)
	{
		return ((mGIEhqYkxBT6IGMf4xBp)P_0).Password;
	}

	internal static object AS8swSSlNjdD82a2TvTt()
	{
		return TigerTrade.Tc.Properties.Resources.TransaqControlChangePasswordFail;
	}

	internal static object BOcsq4SlkKeJLNuyGqcr()
	{
		return TigerTrade.Tc.Properties.Resources.TransaqControlConnectToServer;
	}

	internal static void dU854MSl1dvx2fQHwreh()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
