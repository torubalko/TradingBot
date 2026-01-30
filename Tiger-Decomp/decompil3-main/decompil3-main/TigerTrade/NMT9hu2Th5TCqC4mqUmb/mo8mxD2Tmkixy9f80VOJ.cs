using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using ActiproSoftware.Windows.Controls.Grids;
using B5A5hB2z2EVuSQ5VHGmu;
using CjttZVHEzEWfhqQAXjq2;
using ECOEgqlSad8NUJZ2Dr9n;
using n4LmhZHDb0i8YpSGr2Xl;
using nPSrw5fYUXeiMC9Ux0xS;
using OWUMXkHkWgCUprHQ3jb9;
using TuAMtrl1Nd3XoZQQUXf0;

namespace NMT9hu2Th5TCqC4mqUmb;

internal class mo8mxD2Tmkixy9f80VOJ : PbGEeJHkI13kYvWpne18, IComponentConnector
{
	internal Button ButtonClose;

	internal VoU9lv2z05uTExIsC3Ip PropertyGrid;

	private bool LmW2TPN5Yhg;

	private static mo8mxD2Tmkixy9f80VOJ aToQWO4umwsnXYsdcevY;

	public object Settings => uWMQXb4u7s1eeKP28pDd();

	public mo8mxD2Tmkixy9f80VOJ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		TyQx4k4uAc8IP89NfkV0(EZj1VC4u8T8DmWo58xFk(0x7ADBF691 ^ 0x7ADB25FD));
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				PropertyGrid.Columns[1].Width = new GridLength(4.0, GridUnitType.Star);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				InitializeComponent();
				MRGkRy4uPcOaV9lP0A7A(PropertyGrid.Columns[0], new GridLength(6.0, GridUnitType.Star));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
				{
					num = 1;
				}
				break;
			default:
				HVr2TwBAAI4();
				return;
			}
		}
	}

	private void HVr2TwBAAI4()
	{
		TreeListViewColumn obj = new TreeListViewColumn
		{
			CellBorderThickness = new Thickness(0.0, 0.0, 1.0, 0.0),
			CellPadding = new Thickness(3.0, 0.0, 3.0, 0.0)
		};
		zo2Gvn4uJAVeceHFVcoW(obj, FindResource(EZj1VC4u8T8DmWo58xFk(0x78D396D8 ^ 0x78D34550)) as DataTemplate);
		obj.MinWidth = 30.0;
		obj.MaxWidth = 30.0;
		obj.Width = new GridLength(30.0, GridUnitType.Pixel);
		lnIPwq4uFj2rbdP0EIXl(obj, true);
		TreeListViewColumn item = obj;
		PropertyGrid.Columns.Insert(1, item);
	}

	public static void UbY2T7BWB9X(Window P_0)
	{
		qRUNhyHDDQmkuIovYJo1.RNwHD5QnkSR<mo8mxD2Tmkixy9f80VOJ>(P_0);
	}

	private void wWK2T8E2Mxa(object P_0, RoutedEventArgs P_1)
	{
		lCPQ2x4u34Hc8u926Oj7();
		Close();
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		if (!LmW2TPN5Yhg)
		{
			LmW2TPN5Yhg = true;
			Uri resourceLocator = new Uri(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-962524685 ^ -962471353), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			Application.LoadComponent(this, resourceLocator);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	internal Delegate _CreateDelegate(Type delegateType, string handler)
	{
		return Delegate.CreateDelegate(delegateType, this, handler);
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num2;
		if (P_0 != 1)
		{
			if (P_0 != 2)
			{
				int num = 2;
				num2 = num;
				goto IL_0009;
			}
			PropertyGrid = (VoU9lv2z05uTExIsC3Ip)P_1;
			return;
		}
		goto IL_0066;
		IL_0009:
		switch (num2)
		{
		default:
			return;
		case 1:
			break;
		case 2:
			LmW2TPN5Yhg = true;
			return;
		case 0:
			return;
		}
		goto IL_0066;
		IL_0066:
		ButtonClose = (Button)P_1;
		ButtonClose.Click += wWK2T8E2Mxa;
		num2 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 != 0)
		{
			num2 = 0;
		}
		goto IL_0009;
	}

	static mo8mxD2Tmkixy9f80VOJ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object uWMQXb4u7s1eeKP28pDd()
	{
		return oZu29WfYtbVlhlMVGiDk.SoundAlerts;
	}

	internal static object EZj1VC4u8T8DmWo58xFk(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static void TyQx4k4uAc8IP89NfkV0(object P_0)
	{
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW((string)P_0);
	}

	internal static void MRGkRy4uPcOaV9lP0A7A(object P_0, GridLength P_1)
	{
		((TreeListViewColumn)P_0).Width = P_1;
	}

	internal static bool stZOPy4uh9Rs0JO0Of7J()
	{
		return aToQWO4umwsnXYsdcevY == null;
	}

	internal static mo8mxD2Tmkixy9f80VOJ VaKnDe4uwxLv83jwpgiL()
	{
		return aToQWO4umwsnXYsdcevY;
	}

	internal static void zo2Gvn4uJAVeceHFVcoW(object P_0, object P_1)
	{
		((TreeListViewColumn)P_0).CellTemplate = (DataTemplate)P_1;
	}

	internal static void lnIPwq4uFj2rbdP0EIXl(object P_0, bool P_1)
	{
		((TreeListViewColumn)P_0).IsVisible = P_1;
	}

	internal static void lCPQ2x4u34Hc8u926Oj7()
	{
		oZu29WfYtbVlhlMVGiDk.pF5fYTVx55q();
	}
}
