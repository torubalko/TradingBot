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
using JoC9YwvXX6FtS9NdER5x;
using K1GcsD5GTtMSlaiJI0Xh;
using Nq0mxGvXiwhdIf1u8I6m;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace BhTwZBvXoqVDLwT8uLVg;

internal class bgCuMCvXYuVNGu09K40w : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly b2Lm2SvXsUjn3rkVJISr vEIvXvfT7gh;

	internal ComboBox ComboBoxServer;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	internal CheckBox CheckBoxInternalPositions;

	private bool HUVvXBFrqHl;

	internal static bgCuMCvXYuVNGu09K40w gf6QrbxldKheNFoyiX0o;

	public bgCuMCvXYuVNGu09K40w()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow((string)DT8jdOxl6JHUahM8hCDd(-1009517961 ^ -1009625947));
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		InitializeComponent();
	}

	public bgCuMCvXYuVNGu09K40w(b2Lm2SvXsUjn3rkVJISr P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6f5dc499481a49afb38f5cf60a5c6a60 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		vEIvXvfT7gh = P_0;
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (vEIvXvfT7gh == null)
		{
			return;
		}
		ComboBoxServer.Items.Clear();
		List<S9UXjOvXaThWTwRaUnO3>.Enumerator enumerator = b2Lm2SvXsUjn3rkVJISr.Servers.GetEnumerator();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				try
				{
					while (enumerator.MoveNext())
					{
						while (true)
						{
							S9UXjOvXaThWTwRaUnO3 current = enumerator.Current;
							ComboBoxServer.Items.Add(current);
							if ((string)wxPN93xlMvd9Z1KBbBNu(vEIvXvfT7gh) == (string)OMyQEAxlOOapXKlyVIoZ(current))
							{
								int num2 = 0;
								if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_cf97b2c5010b479fbed313b322c2166c == 0)
								{
									num2 = 0;
								}
								switch (num2)
								{
								case 1:
									continue;
								}
								ComboBoxServer.SelectedItem = current;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				goto case 2;
			case 2:
				TextBoxApiKey.Text = vEIvXvfT7gh.DJ9vXMvkSZp;
				QN8VfTxlIo8FWU18k4iZ(TextBoxApiSecret, QfTUcRxlqxf2wcmvGA6C(vEIvXvfT7gh));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				YbGgkGxlW1q0EyQd5vXT(TextBoxProxy, vEIvXvfT7gh.Proxy);
				TextBoxProxyUser.Text = vEIvXvfT7gh.xXZvXmICpUJ;
				TextBoxProxyPass.Password = (string)suqMEvxltFj62XpO3hMj(vEIvXvfT7gh);
				CheckBoxInternalPositions.IsChecked = vEIvXvfT7gh.ArOvXPC5SBl;
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_a17177e4a01d43aa800589a27b3f7313 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vEIvXvfT7gh != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_bdd0830849fd42b0a6744b7ce88daa30 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				vEIvXvfT7gh.gpqG8g0ePAk();
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				return;
			default:
				ATI5o2xlTT3OOcTP5RVD(vEIvXvfT7gh, (j19OlKxlUtKgK4VpbvaY(ComboBoxServer) is S9UXjOvXaThWTwRaUnO3 s9UXjOvXaThWTwRaUnO) ? s9UXjOvXaThWTwRaUnO.lC6vX1V9xpe() : "");
				vEIvXvfT7gh.DJ9vXMvkSZp = (string)Md8xBrxlZMYpAVT0bFLK(Tel8yTxlyFo67mu8gLM4(TextBoxApiKey));
				vEIvXvfT7gh.nkqvXtNCmI9(TextBoxApiSecret.Password.Trim());
				Ao22VaxlVjoNZeJw6QgH(vEIvXvfT7gh, TextBoxProxy.Text.Trim());
				vEIvXvfT7gh.xXZvXmICpUJ = TextBoxProxyUser.Text.Trim();
				vEIvXvfT7gh.XXIvX7sx4gA = (string)Md8xBrxlZMYpAVT0bFLK(TextBoxProxyPass.Password);
				vEIvXvfT7gh.ArOvXPC5SBl = CheckBoxInternalPositions.IsChecked == true;
				num2 = 4;
				break;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!HUVvXBFrqHl)
		{
			HUVvXBFrqHl = true;
			Uri uri = new Uri((string)DT8jdOxl6JHUahM8hCDd(-1009517961 ^ -1009625977), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			kuCN1AxlCWpfrvQHtdUQ(this, uri);
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				return;
			case 4:
				ComboBoxServer = (ComboBox)P_1;
				num2 = 3;
				break;
			case 1:
				switch (P_0)
				{
				case 5:
					TextBoxProxyUser = (TextBox)P_1;
					return;
				case 4:
					TextBoxProxy = (TextBox)P_1;
					num2 = 2;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
					{
						num2 = 2;
					}
					goto end_IL_0012;
				case 3:
					TextBoxApiSecret = (PasswordBox)P_1;
					return;
				case 7:
					CheckBoxInternalPositions = (CheckBox)P_1;
					return;
				case 2:
					TextBoxApiKey = (TextBox)P_1;
					return;
				case 1:
					break;
				default:
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_13f4cb14997f405fab62a06554ad1ec9 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case 6:
					TextBoxProxyPass = (PasswordBox)P_1;
					return;
				}
				goto case 4;
			default:
				{
					HUVvXBFrqHl = true;
					return;
				}
				end_IL_0012:
				break;
			}
		}
	}

	static bgCuMCvXYuVNGu09K40w()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		jXKnuGxlr0cxNauv7Jjn();
	}

	internal static object DT8jdOxl6JHUahM8hCDd(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool eGBZxrxlgbgaLUhAfZqt()
	{
		return gf6QrbxldKheNFoyiX0o == null;
	}

	internal static bgCuMCvXYuVNGu09K40w ztpnFvxlR3jIHlNnOvDU()
	{
		return gf6QrbxldKheNFoyiX0o;
	}

	internal static object wxPN93xlMvd9Z1KBbBNu(object P_0)
	{
		return ((b2Lm2SvXsUjn3rkVJISr)P_0).rhlvXgKgmFj;
	}

	internal static object OMyQEAxlOOapXKlyVIoZ(object P_0)
	{
		return ((S9UXjOvXaThWTwRaUnO3)P_0).lC6vX1V9xpe();
	}

	internal static object QfTUcRxlqxf2wcmvGA6C(object P_0)
	{
		return ((b2Lm2SvXsUjn3rkVJISr)P_0).bS6vXWrqoj9();
	}

	internal static void QN8VfTxlIo8FWU18k4iZ(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static void YbGgkGxlW1q0EyQd5vXT(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object suqMEvxltFj62XpO3hMj(object P_0)
	{
		return ((b2Lm2SvXsUjn3rkVJISr)P_0).XXIvX7sx4gA;
	}

	internal static object j19OlKxlUtKgK4VpbvaY(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static void ATI5o2xlTT3OOcTP5RVD(object P_0, object P_1)
	{
		((b2Lm2SvXsUjn3rkVJISr)P_0).rhlvXgKgmFj = (string)P_1;
	}

	internal static object Tel8yTxlyFo67mu8gLM4(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static object Md8xBrxlZMYpAVT0bFLK(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void Ao22VaxlVjoNZeJw6QgH(object P_0, object P_1)
	{
		((b2Lm2SvXsUjn3rkVJISr)P_0).Proxy = (string)P_1;
	}

	internal static void kuCN1AxlCWpfrvQHtdUQ(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void jXKnuGxlr0cxNauv7Jjn()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
