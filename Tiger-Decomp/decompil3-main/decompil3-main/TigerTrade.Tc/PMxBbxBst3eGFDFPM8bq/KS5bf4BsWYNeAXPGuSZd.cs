using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using DAjk0YBsZ5Me31LmYIsJ;
using jhuDCPG8d8bbdl4R91vn;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace PMxBbxBst3eGFDFPM8bq;

internal class KS5bf4BsWYNeAXPGuSZd : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly eneyF5BsyCBAIt1jQPu8 K5nBsUN4xAA;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	private bool RKrBsTthvrX;

	internal static KS5bf4BsWYNeAXPGuSZd yEBCLgxcOie16l8Asslp;

	public KS5bf4BsWYNeAXPGuSZd()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2eeb07b76a6b47ee89babb98850d4c1d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		TcEvents.RiseTrackWindow((string)sP9kaRxcWdsIWDUG7W6I(-842040449 ^ -842090729));
		InitializeComponent();
	}

	public KS5bf4BsWYNeAXPGuSZd(eneyF5BsyCBAIt1jQPu8 P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		K5nBsUN4xAA = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_866557b8dea94de48f2b3dad62e01c00 == 0)
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
		if (K5nBsUN4xAA == null)
		{
			return;
		}
		TextBoxApiKey.Text = K5nBsUN4xAA.ORwBsrCoZ5J;
		JdmDGuxcUqJrBsGF6V7u(TextBoxApiSecret, mW54dXxctarqifuyATIw(K5nBsUN4xAA));
		n6IWYOxcyW98hw0VqjVC(TextBoxProxy, GU1Cs8xcTO2YF8bpKgCP(K5nBsUN4xAA));
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				TextBoxProxyUser.Text = K5nBsUN4xAA.akJBszHPk9a;
				JdmDGuxcUqJrBsGF6V7u(TextBoxProxyPass, zluVmexcZpp7HPg4K1So(K5nBsUN4xAA));
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7a1d7fffd3b3456599571ecbfd877437 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		if (K5nBsUN4xAA == null)
		{
			return;
		}
		RUQKeLxcCQ4LABXkCTpH(K5nBsUN4xAA, DjVBhVxcVaOnJ2QH7kOy(TextBoxApiKey.Text));
		SLxriexcrYu7BeHT0dcb(K5nBsUN4xAA, TextBoxApiSecret.Password.Trim());
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9c60d0dfafa6408a9dd7ce15e9c500ee != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				K5nBsUN4xAA.Proxy = TextBoxProxy.Text.Trim();
				K5nBsUN4xAA.akJBszHPk9a = TextBoxProxyUser.Text.Trim();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
				{
					num = 0;
				}
				break;
			default:
				dEiYn7xcmntpbGL1ZgMt(K5nBsUN4xAA, DjVBhVxcVaOnJ2QH7kOy(RSFStAxcKS93mQg4M9xU(TextBoxProxyPass)));
				WyoZ8Axchi1975O3scJ7(K5nBsUN4xAA);
				return;
			case 2:
				return;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!RKrBsTthvrX)
		{
			RKrBsTthvrX = true;
			int num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc != 0)
			{
				num = 1;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
			{
				Uri uri = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-90307782 ^ -90189904), UriKind.Relative);
				zThgfDxcwZCJvIgtGCZm(this, uri);
				break;
			}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)ov7lcHxc7SOaWLAXoNSx(delegateType, this, handler);
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
			TextBoxProxyUser = (TextBox)P_1;
			num = 2;
			goto IL_0009;
		case 3:
			TextBoxProxy = (TextBox)P_1;
			break;
		default:
			RKrBsTthvrX = true;
			break;
		case 2:
			TextBoxApiSecret = (PasswordBox)P_1;
			break;
		case 5:
			TextBoxProxyPass = (PasswordBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_df9cc36c31bd47b69eead74fc374d2af == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			{
				TextBoxApiKey = (TextBox)P_1;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_fc8d4bf9d00d4601a17ae4647e849014 == 0)
				{
					num = 1;
				}
				goto IL_0009;
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
			}
			break;
		}
	}

	static KS5bf4BsWYNeAXPGuSZd()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		wUZLaZxc80HFlDTmeR7C();
	}

	internal static object sP9kaRxcWdsIWDUG7W6I(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static bool S9kdukxcqf9Ojw2ctAcC()
	{
		return yEBCLgxcOie16l8Asslp == null;
	}

	internal static KS5bf4BsWYNeAXPGuSZd oNv9VIxcIw7XF72K7G5g()
	{
		return yEBCLgxcOie16l8Asslp;
	}

	internal static object mW54dXxctarqifuyATIw(object P_0)
	{
		return ((eneyF5BsyCBAIt1jQPu8)P_0).VPoBsw9RhFa();
	}

	internal static void JdmDGuxcUqJrBsGF6V7u(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static object GU1Cs8xcTO2YF8bpKgCP(object P_0)
	{
		return ((eneyF5BsyCBAIt1jQPu8)P_0).Proxy;
	}

	internal static void n6IWYOxcyW98hw0VqjVC(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static object zluVmexcZpp7HPg4K1So(object P_0)
	{
		return ((eneyF5BsyCBAIt1jQPu8)P_0).xP6BXH226t7;
	}

	internal static object DjVBhVxcVaOnJ2QH7kOy(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void RUQKeLxcCQ4LABXkCTpH(object P_0, object P_1)
	{
		((eneyF5BsyCBAIt1jQPu8)P_0).ORwBsrCoZ5J = (string)P_1;
	}

	internal static void SLxriexcrYu7BeHT0dcb(object P_0, object P_1)
	{
		((eneyF5BsyCBAIt1jQPu8)P_0).vcUBs75x0CK((string)P_1);
	}

	internal static object RSFStAxcKS93mQg4M9xU(object P_0)
	{
		return ((PasswordBox)P_0).Password;
	}

	internal static void dEiYn7xcmntpbGL1ZgMt(object P_0, object P_1)
	{
		((eneyF5BsyCBAIt1jQPu8)P_0).xP6BXH226t7 = (string)P_1;
	}

	internal static void WyoZ8Axchi1975O3scJ7(object P_0)
	{
		((gpnr5oG8Q1cRMmiYT0Ut)P_0).gpqG8g0ePAk();
	}

	internal static void zThgfDxcwZCJvIgtGCZm(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object ov7lcHxc7SOaWLAXoNSx(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void wUZLaZxc80HFlDTmeR7C()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
