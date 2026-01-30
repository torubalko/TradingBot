using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using TigerTrade.Tc.Manager;
using WK3NEBoLCURYTvsA8gL5;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace qiXe7BoLTwBoqbDdlWv8;

internal class hFhPfmoLUHnmx69Rl7vq : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly GNfS5voLVFmSIoXjbiS7 dWnoLyM6b3G;

	internal TextBox TextBoxApiKey;

	internal PasswordBox TextBoxApiSecret;

	internal TextBox TextBoxProxy;

	internal TextBox TextBoxProxyUser;

	internal PasswordBox TextBoxProxyPass;

	private bool jCloLZh3FFw;

	internal static hFhPfmoLUHnmx69Rl7vq TRD6hYSKpoyn8Fawj6v1;

	public hFhPfmoLUHnmx69Rl7vq()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		f7uAsuSm0xXa5jEnF723(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-1461949456 ^ -1461853704));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_633f94d6c17446778b227aa97d485f89 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public hFhPfmoLUHnmx69Rl7vq(GNfS5voLVFmSIoXjbiS7 P_0)
	{
		knsS4eSm26wiDYvF3TOP();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_17fedee5938443f6baffb805b38387d5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		dWnoLyM6b3G = P_0;
	}

	private void TradeClientControl_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (dWnoLyM6b3G == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_050e60e270a54079b1a645031ef33369 == 0)
					{
						num2 = 1;
					}
					break;
				}
				TextBoxApiKey.Text = dWnoLyM6b3G.hK3oLmwfscY;
				aR0Bq4SmfLGGdxjeZHyq(TextBoxApiSecret, yeZlaOSmH3OEGTuH3oK7(dWnoLyM6b3G));
				TextBoxProxy.Text = dWnoLyM6b3G.Proxy;
				TextBoxProxyUser.Text = (string)bFssHDSm9R693BO2xlFp(dWnoLyM6b3G);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_72ba3e053a3b4440a15c5dbd38bc37f7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				TextBoxProxyPass.Password = (string)bNDIGkSmn9Sb8ZQoICpG(dWnoLyM6b3G);
				return;
			case 1:
				return;
			}
		}
	}

	public override void SaveSettings()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				dWnoLyM6b3G.A8woe9GXk1L = ((string)GnALacSmBe89RZ6ShZd9(TextBoxProxyPass)).Trim();
				dWnoLyM6b3G.gpqG8g0ePAk();
				return;
			case 1:
				return;
			case 3:
				dWnoLyM6b3G.QrboLAXKcsC(TextBoxApiSecret.Password.Trim());
				dWnoLyM6b3G.Proxy = ((string)W6CpRiSmor6sZ9rJRrHM(TextBoxProxy)).Trim();
				qYZxMiSmvB2wCsH1tVqF(dWnoLyM6b3G, TextBoxProxyUser.Text.Trim());
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_82741674950e4c70a0407e3b1a670169 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (dWnoLyM6b3G != null)
				{
					IbpyxLSmY3mUuIVVA6Ur(dWnoLyM6b3G, NS3usJSmGl1aXRIYjcYM(TextBoxApiKey.Text));
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_7ea79d38f01f491fa0470ff9768a1574 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!jCloLZh3FFw)
		{
			jCloLZh3FFw = true;
			Uri uri = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-225822163 ^ -225726453), UriKind.Relative);
			ogU8pvSma59sJr9IGAav(this, uri);
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 != 0)
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
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		default:
			jCloLZh3FFw = true;
			break;
		case 4:
			TextBoxProxyUser = (TextBox)P_1;
			break;
		case 3:
			TextBoxProxy = (TextBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
			{
				num = 2;
			}
			goto IL_0009;
		case 1:
			TextBoxApiKey = (TextBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
			{
				num = 1;
			}
			goto IL_0009;
		case 5:
			TextBoxProxyPass = (PasswordBox)P_1;
			break;
		case 2:
			{
				TextBoxApiSecret = (PasswordBox)P_1;
				break;
			}
			IL_0009:
			switch (num)
			{
			case 2:
				return;
			case 1:
				return;
			}
			goto case 1;
		}
	}

	static hFhPfmoLUHnmx69Rl7vq()
	{
		lhfUsVSmiHi47I63L6HO();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static void f7uAsuSm0xXa5jEnF723(object P_0)
	{
		TcEvents.RiseTrackWindow((string)P_0);
	}

	internal static bool VHU6rESKuUhf6sRAPFM4()
	{
		return TRD6hYSKpoyn8Fawj6v1 == null;
	}

	internal static hFhPfmoLUHnmx69Rl7vq vASnJLSKzXuT24qk1xdg()
	{
		return TRD6hYSKpoyn8Fawj6v1;
	}

	internal static void knsS4eSm26wiDYvF3TOP()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
	}

	internal static object yeZlaOSmH3OEGTuH3oK7(object P_0)
	{
		return ((GNfS5voLVFmSIoXjbiS7)P_0).il4oL8kENSn();
	}

	internal static void aR0Bq4SmfLGGdxjeZHyq(object P_0, object P_1)
	{
		((PasswordBox)P_0).Password = (string)P_1;
	}

	internal static object bFssHDSm9R693BO2xlFp(object P_0)
	{
		return ((GNfS5voLVFmSIoXjbiS7)P_0).pqVoe2b1HQo;
	}

	internal static object bNDIGkSmn9Sb8ZQoICpG(object P_0)
	{
		return ((GNfS5voLVFmSIoXjbiS7)P_0).A8woe9GXk1L;
	}

	internal static object NS3usJSmGl1aXRIYjcYM(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static void IbpyxLSmY3mUuIVVA6Ur(object P_0, object P_1)
	{
		((GNfS5voLVFmSIoXjbiS7)P_0).hK3oLmwfscY = (string)P_1;
	}

	internal static object W6CpRiSmor6sZ9rJRrHM(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void qYZxMiSmvB2wCsH1tVqF(object P_0, object P_1)
	{
		((GNfS5voLVFmSIoXjbiS7)P_0).pqVoe2b1HQo = (string)P_1;
	}

	internal static object GnALacSmBe89RZ6ShZd9(object P_0)
	{
		return ((PasswordBox)P_0).Password;
	}

	internal static void ogU8pvSma59sJr9IGAav(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static void lhfUsVSmiHi47I63L6HO()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
	}
}
