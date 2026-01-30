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
using pAKXU2YoTkTO4W6CCboK;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace a5MxemYYW1sJCTCqCbyP;

internal class H1ZaytYYIeatuahjeJk7 : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly aRvccXYoUAP8a6e7a0dX LCwYYt2n8Bi;

	internal ComboBox ComboBoxPaths;

	internal CheckBox CheckBoxAddClientCode;

	private bool NrPYYUDae0U;

	internal static H1ZaytYYIeatuahjeJk7 FHRKvbSv5OglD7PJ9X1A;

	public H1ZaytYYIeatuahjeJk7()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		TcEvents.RiseTrackWindow(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-203064540 ^ -203143066));
		InitializeComponent();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_67356183f8464ca6962cfffbcb53813d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public H1ZaytYYIeatuahjeJk7(aRvccXYoUAP8a6e7a0dX P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d16f1826810e44e5a44b39ad903bd707 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		LCwYYt2n8Bi = P_0;
	}

	private void QuikControl_Loaded(object sender, RoutedEventArgs e)
	{
		int num = 3;
		int num2 = num;
		List<string> list = default(List<string>);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		while (true)
		{
			switch (num2)
			{
			default:
				FJ1iY7Svsujw0fLfQUV5(ComboBoxPaths, 0);
				num2 = 4;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_c82b80986db149fc8e857dfed661c1a6 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				return;
			case 3:
				if (LCwYYt2n8Bi != null)
				{
					ComboBoxPaths.Items.Clear();
					list = aRvccXYoUAP8a6e7a0dX.eCdYoy90sK7();
					rJg6YNSvLjv9sjIL9bI4(ComboBoxPaths.Items, TigerTrade.Tc.Properties.Resources.QuikControlAutoDetectPath);
					enumerator = list.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_412406b3bc1045d18e68d87927fc0fc3 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
				}
				continue;
			case 1:
				try
				{
					while (enumerator.MoveNext())
					{
						string current = enumerator.Current;
						ComboBoxPaths.Items.Add(current);
					}
					int num3 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_0038f818f2704f70a8069fbdf675cc8a == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
				}
				if (list.Contains((string)VxPipYSve0GI9XEXCqyF(LCwYYt2n8Bi)))
				{
					ComboBoxPaths.SelectedItem = VxPipYSve0GI9XEXCqyF(LCwYYt2n8Bi);
					break;
				}
				goto default;
			case 4:
				break;
			}
			break;
		}
		CheckBoxAddClientCode.IsChecked = xrhe66SvXv4cwNDY7X66(LCwYYt2n8Bi);
	}

	public override void SaveSettings()
	{
		if (LCwYYt2n8Bi == null)
		{
			return;
		}
		if (lQBfZeSvc57fBehfTrUV(ComboBoxPaths) == null)
		{
			goto IL_00b9;
		}
		string text = ComboBoxPaths.SelectedItem as string;
		int num;
		if (text == TigerTrade.Tc.Properties.Resources.QuikControlAutoDetectPath)
		{
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_87bc9f389c844fd48eb0e7e8f7297794 == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_0023;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 2:
			return;
		case 1:
			break;
		case 3:
			goto IL_00b9;
		}
		text = "";
		goto IL_0023;
		IL_00b9:
		LCwYYt2n8Bi.YVhYoKw66qp = CheckBoxAddClientCode.IsChecked == true;
		LCwYYt2n8Bi.gpqG8g0ePAk();
		num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_99445506e7fb4478b8370a949ce4a2a6 == 0)
		{
			num = 0;
		}
		goto IL_0009;
		IL_0023:
		k3mysGSvjFbUE6EqAf2j(LCwYYt2n8Bi, text);
		num = 3;
		goto IL_0009;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
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
			case 0:
				return;
			case 1:
				if (!NrPYYUDae0U)
				{
					NrPYYUDae0U = true;
					Uri resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(-894902996 ^ -894833040), UriKind.Relative);
					Application.LoadComponent(this, resourceLocator);
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_262c45b675dc44e594e3edec7c08a152 == 0)
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
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		if (P_0 != 1)
		{
			if (P_0 != 2)
			{
				NrPYYUDae0U = true;
				return;
			}
			CheckBoxAddClientCode = (CheckBox)P_1;
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_eb6cefc1df37468ab8b9384866953722 != 0)
			{
				num = 0;
			}
		}
		else
		{
			ComboBoxPaths = (ComboBox)P_1;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_70b4b4a3c8d3471f9796e8c8caf6f35b != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	static H1ZaytYYIeatuahjeJk7()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		GGOWndSvEjtVdMAmWVX0();
	}

	internal static bool JoMGAASvSruhpNAJKSVG()
	{
		return FHRKvbSv5OglD7PJ9X1A == null;
	}

	internal static H1ZaytYYIeatuahjeJk7 Tf433SSvx5lq1LdWdoJ2()
	{
		return FHRKvbSv5OglD7PJ9X1A;
	}

	internal static int rJg6YNSvLjv9sjIL9bI4(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static object VxPipYSve0GI9XEXCqyF(object P_0)
	{
		return ((aRvccXYoUAP8a6e7a0dX)P_0).Path;
	}

	internal static void FJ1iY7Svsujw0fLfQUV5(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static bool xrhe66SvXv4cwNDY7X66(object P_0)
	{
		return ((aRvccXYoUAP8a6e7a0dX)P_0).YVhYoKw66qp;
	}

	internal static object lQBfZeSvc57fBehfTrUV(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static void k3mysGSvjFbUE6EqAf2j(object P_0, object P_1)
	{
		((aRvccXYoUAP8a6e7a0dX)P_0).Path = (string)P_1;
	}

	internal static void GGOWndSvEjtVdMAmWVX0()
	{
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}
}
