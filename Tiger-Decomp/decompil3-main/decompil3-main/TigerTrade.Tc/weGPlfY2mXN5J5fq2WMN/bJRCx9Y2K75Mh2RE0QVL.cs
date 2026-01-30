using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Editors;
using BfZtb759KlUg4482QKym;
using K1GcsD5GTtMSlaiJI0Xh;
using mBGsntY28eyj8l4GH66O;
using TigerTrade.Tc.Manager;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace weGPlfY2mXN5J5fq2WMN;

internal class bJRCx9Y2K75Mh2RE0QVL : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly wsOd7pY2723sPIBRi7XY cvCY2h6Oyy6;

	internal TextBox TextBoxServer;

	internal Int32EditBox EditBoxPort;

	internal Int32EditBox EditBoxClientID;

	private bool LW5Y2wBt6xI;

	private static bJRCx9Y2K75Mh2RE0QVL ElHlRAS0EUOc0cHtE9g1;

	public bJRCx9Y2K75Mh2RE0QVL()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x1D7BA1ED ^ 0x1D7B5A93));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_e2046e9188d74371a6b184c7289810cf != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public bJRCx9Y2K75Mh2RE0QVL(wsOd7pY2723sPIBRi7XY P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		cvCY2h6Oyy6 = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
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
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				if (cvCY2h6Oyy6 != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_18fbecec0dfa44d6afb647cf0f10b685 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				liDbbLS0gG1SQwHUJYdD(TextBoxServer, cvCY2h6Oyy6.r5iY2J6bIr6);
				EditBoxPort.Value = z9KistS0R7qmBeynN3rs(cvCY2h6Oyy6);
				EditBoxClientID.Value = pKJnjSS06G33004R2ucK(cvCY2h6Oyy6);
				num2 = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		if (cvCY2h6Oyy6 == null)
		{
			return;
		}
		cdJW7xS0ORNOIkFQZr67(cvCY2h6Oyy6, HUB8k7S0MPWe9mZANPaH(TextBoxServer));
		xoK1t9S0q1tl4IVI62SI(cvCY2h6Oyy6, EditBoxPort.Value ?? 7496);
		cvCY2h6Oyy6.SUsYH0rIH7D = EditBoxClientID.Value ?? 1;
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ce4051eadf70452db4b28dca356319d1 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				cvCY2h6Oyy6.gpqG8g0ePAk();
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_21ad277cd47f4cf3b51c372634d8f584 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!LW5Y2wBt6xI)
		{
			LW5Y2wBt6xI = true;
			int num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c39cf65fb9834816b04c914d068177cc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Uri uri = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x34407BB ^ 0x344FC2D), UriKind.Relative);
			ubn2xJS0IHmwPnmiavMd(this, uri);
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return (Delegate)vrNcluS0WSISd03aqO8l(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 2:
			EditBoxPort = (Int32EditBox)P_1;
			break;
		case 3:
			EditBoxClientID = (Int32EditBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_09c5bd75193a4fbe995d693b67f9f226 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 1:
			TextBoxServer = (TextBox)P_1;
			break;
		default:
			{
				LW5Y2wBt6xI = true;
				num = 1;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_41689ce5632e46808b581b3ddff97952 != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			case 1:
				break;
			case 0:
				break;
			}
			break;
		}
	}

	static bJRCx9Y2K75Mh2RE0QVL()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		FyLmu3S0tpv7W5xU05jN();
	}

	internal static bool UvUuvlS0QOKeUAGZnjkT()
	{
		return ElHlRAS0EUOc0cHtE9g1 == null;
	}

	internal static bJRCx9Y2K75Mh2RE0QVL B9dFQvS0dvWRF3eSGd0i()
	{
		return ElHlRAS0EUOc0cHtE9g1;
	}

	internal static void liDbbLS0gG1SQwHUJYdD(object P_0, object P_1)
	{
		((TextBox)P_0).Text = (string)P_1;
	}

	internal static int z9KistS0R7qmBeynN3rs(object P_0)
	{
		return ((wsOd7pY2723sPIBRi7XY)P_0).b0oY2pkamTP;
	}

	internal static int pKJnjSS06G33004R2ucK(object P_0)
	{
		return ((wsOd7pY2723sPIBRi7XY)P_0).SUsYH0rIH7D;
	}

	internal static object HUB8k7S0MPWe9mZANPaH(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static void cdJW7xS0ORNOIkFQZr67(object P_0, object P_1)
	{
		((wsOd7pY2723sPIBRi7XY)P_0).r5iY2J6bIr6 = (string)P_1;
	}

	internal static void xoK1t9S0q1tl4IVI62SI(object P_0, int P_1)
	{
		((wsOd7pY2723sPIBRi7XY)P_0).b0oY2pkamTP = P_1;
	}

	internal static void ubn2xJS0IHmwPnmiavMd(object P_0, object P_1)
	{
		Application.LoadComponent(P_0, (Uri)P_1);
	}

	internal static object vrNcluS0WSISd03aqO8l(Type P_0, object P_1, object P_2)
	{
		return Delegate.CreateDelegate(P_0, P_1, (string)P_2);
	}

	internal static void FyLmu3S0tpv7W5xU05jN()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
