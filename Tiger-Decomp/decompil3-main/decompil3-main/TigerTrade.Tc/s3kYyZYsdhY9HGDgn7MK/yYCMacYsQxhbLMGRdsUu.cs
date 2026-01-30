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
using pcNaAaYXICmvM8EDADY4;
using TigerTrade.Tc.Manager;
using TigerTrade.Tc.Properties;
using wRZx5aaX1rIduT2GytfS;
using x97CE55GhEYKgt7TSVZT;

namespace s3kYyZYsdhY9HGDgn7MK;

internal class yYCMacYsQxhbLMGRdsUu : SuSj0gaXkIlYcfCsT0qp, IComponentConnector
{
	private readonly TGsif1YXq0JNqauctK1A QOvYsgCKe9i;

	internal ComboBox ComboBoxPaths;

	internal CheckBox CheckBoxSlTp;

	private bool tb9YsRS2oPC;

	internal static yYCMacYsQxhbLMGRdsUu bnOfIDSxb2QPyo4oukaW;

	public yYCMacYsQxhbLMGRdsUu()
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		nBZ7RpSx5mb2Nga7PaFw(bdb3TBSx1LfjmFTwMXHT(-5977659 ^ -5923851));
		InitializeComponent();
	}

	public yYCMacYsQxhbLMGRdsUu(TGsif1YXq0JNqauctK1A P_0)
	{
		itlbck5GUdCiQcy9cfLX.MSJLykDwaZf();
		this._002Ector();
		QOvYsgCKe9i = P_0;
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_85518406d92c400aa3e0339f430d9d7a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	private void Mt5Control_Loaded(object sender, RoutedEventArgs e)
	{
		if (QOvYsgCKe9i == null)
		{
			return;
		}
		((ItemCollection)MNMRfiSxSMhBp7cpUgtn(ComboBoxPaths)).Clear();
		List<string> list = TGsif1YXq0JNqauctK1A.XMHYXWGGwMc();
		int num = 1;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_376f2bcb10134b91b6257ed8645d119a == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
				ComboBoxPaths.SelectedItem = QOvYsgCKe9i.Path;
				num = 3;
				break;
			case 2:
				return;
			case 1:
				g07JTBSxLT80I5sL8Ev8(ComboBoxPaths.Items, en4P8hSxxN0uqK96BVrf());
				foreach (string item in list)
				{
					((ItemCollection)MNMRfiSxSMhBp7cpUgtn(ComboBoxPaths)).Add((object)item);
					int num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_6914a7e965794704a147f3749924962d == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					}
				}
				if (!list.Contains(QOvYsgCKe9i.Path))
				{
					Od2WEHSxeLTNfavyOp8R(ComboBoxPaths, 0);
					return;
				}
				num = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_d4d2f19934534966b0e0752a1e79d0a3 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void SaveSettings()
	{
		if (QOvYsgCKe9i == null)
		{
			return;
		}
		int num;
		if (Np4l0ISxs6KkieDlF85c(ComboBoxPaths) != null)
		{
			num = 0;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_1d4a4f3099134e0e94d0aa5f4bb135c6 == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_001f;
		IL_001f:
		QOvYsgCKe9i.gpqG8g0ePAk();
		num = 2;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_394443c57c4a451f88906434ea248e7b != 0)
		{
			num = 2;
		}
		goto IL_0009;
		IL_0009:
		string text;
		while (true)
		{
			switch (num)
			{
			default:
				text = Np4l0ISxs6KkieDlF85c(ComboBoxPaths) as string;
				if (text == (string)en4P8hSxxN0uqK96BVrf())
				{
					num = 1;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9af6b53eda9a447491409b945b9ad16e == 0)
					{
						num = 1;
					}
					continue;
				}
				break;
			case 1:
				text = "";
				break;
			case 2:
				return;
			}
			break;
		}
		QOvYsgCKe9i.Path = text;
		goto IL_001f;
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		int num = 2;
		int num2 = num;
		Uri resourceLocator = default(Uri);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!tb9YsRS2oPC)
				{
					num2 = 0;
					if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_ac3f8b71231e4b108fd519d939438d5a == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			default:
				Application.LoadComponent(this, resourceLocator);
				return;
			case 1:
				tb9YsRS2oPC = true;
				resourceLocator = new Uri(F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(0x769C7931 ^ 0x769D2B79), UriKind.Relative);
				num2 = 0;
				if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_057f21bc6e4d4f6f9153b4ca132ac862 != 0)
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
		switch (P_0)
		{
		case 1:
			ComboBoxPaths = (ComboBox)P_1;
			return;
		case 2:
			CheckBoxSlTp = (CheckBox)P_1;
			return;
		}
		int num = 0;
		if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_2b9e363b0abc4a32a96694deb0f4f698 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			tb9YsRS2oPC = true;
			num = 1;
			if (_003CModule_003E_007B68812e8e_002D4b5b_002D44f2_002D9304_002D3f1c4ea04b49_007D.m_9db030806b504c748b649e391f655c9f != 0)
			{
				num = 1;
			}
		}
	}

	static yYCMacYsQxhbLMGRdsUu()
	{
		F71m3059rTj4gyFcUtWX.xiX5n2gNr23();
		pBBtaj5Gmf2YibAYEwgh.kLjw4iIsCLsZtxc4lksN0j();
	}

	internal static object bdb3TBSx1LfjmFTwMXHT(int P_0)
	{
		return F71m3059rTj4gyFcUtWX.JNO5no2YvQQ(P_0);
	}

	internal static void nBZ7RpSx5mb2Nga7PaFw(object P_0)
	{
		TcEvents.RiseTrackWindow((string)P_0);
	}

	internal static bool Su0ZkfSxNrQXoRGobIvg()
	{
		return bnOfIDSxb2QPyo4oukaW == null;
	}

	internal static yYCMacYsQxhbLMGRdsUu JyG9VISxkdJmO5yQGmub()
	{
		return bnOfIDSxb2QPyo4oukaW;
	}

	internal static object MNMRfiSxSMhBp7cpUgtn(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static object en4P8hSxxN0uqK96BVrf()
	{
		return TigerTrade.Tc.Properties.Resources.Mt5ControlAutoDetectPath;
	}

	internal static int g07JTBSxLT80I5sL8Ev8(object P_0, object P_1)
	{
		return ((ItemCollection)P_0).Add(P_1);
	}

	internal static void Od2WEHSxeLTNfavyOp8R(object P_0, int P_1)
	{
		((Selector)P_0).SelectedIndex = P_1;
	}

	internal static object Np4l0ISxs6KkieDlF85c(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}
}
