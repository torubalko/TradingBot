using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using ActiproSoftware.Windows.Controls.Docking;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Themes;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using CFeB6OHv8QrfxKgMM5dw;
using CjttZVHEzEWfhqQAXjq2;
using dD5v4W2lzHtvpmJLPViS;
using DRCaMH27IQcwq20fEAYq;
using ECOEgqlSad8NUJZ2Dr9n;
using ft4IOl2kyqsXh3EvCREm;
using fvYjmt2i8adopaJWwpBD;
using Ifr3P625iTdDe3UJ4vQA;
using RNVda52xiPon1C9Km8N2;
using TigerTrade.Core.UI.Windows;
using TigerTrade.Properties;
using TigerTrade.Tc.Data;
using TuAMtrl1Nd3XoZQQUXf0;
using uZqyk925mKGgabaJGJq6;
using XahX8y2lxOU9joWvF1Mf;
using xfdMo0lS4TP9pN36Goka;
using yH1aSw95cBMPqRpT6nEr;

namespace fCaZmR2isgV0eJFLNp5S;

internal sealed class kq9RCq2iem0KToyvfhNJ : z6kMSs25KYyGVf55FxBT, IComponentConnector, IStyleConnector
{
	[CompilerGenerated]
	private YFgK5H2i7J5FGyU7TwRL lp22iZt1lft;

	private readonly Color B3p2iVJX5w3;

	private readonly Color mdp2iCfFK6K;

	private readonly ContextMenu WBW2ir8AY8t;

	private DispatcherTimer Chm2iKyjhRf;

	private Point? t142imyJRHY;

	private ListViewItem Lt62ihOYgba;

	internal kq9RCq2iem0KToyvfhNJ ControlRoot;

	internal DoubleEditBox DoubleEditBoxDeltaThreshold;

	internal lfeFPj27qiPQ1FwhnA4U ListView;

	private bool Ckd2iwZKNtK;

	private static kq9RCq2iem0KToyvfhNJ FdBlmc4Ic8sn8Wy7Ayb5;

	public YFgK5H2i7J5FGyU7TwRL ViewModel
	{
		[CompilerGenerated]
		get
		{
			return lp22iZt1lft;
		}
		[CompilerGenerated]
		private set
		{
			lp22iZt1lft = yFgK5H2i7J5FGyU7TwRL;
		}
	}

	public override int LinkGroup
	{
		get
		{
			return ViewModel.Settings.LinkGroupID.GetValueOrDefault();
		}
		protected set
		{
			ViewModel.Settings.LinkGroupID = value2;
			if (Vlkmmd4IWQBOGcMHgvvK(ViewModel) != null)
			{
				TQ525pb1OP3(ViewModel.SelectedSecurity.Symbol);
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
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
	}

	public kq9RCq2iem0KToyvfhNJ(DockingWindow P_0)
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		B3p2iVJX5w3 = Color.FromRgb(41, 43, 45);
		mdp2iCfFK6K = Color.FromRgb(240, 240, 241);
		WBW2ir8AY8t = new ContextMenu();
		base._002Ector(P_0, lOqyZR2xahfYNVbq7H4p.Screener);
		FWJAAg2lupa1qEYHl1Tv fWJAAg2lupa1qEYHl1Tv = aJ42S93GFJy<FWJAAg2lupa1qEYHl1Tv>(EGk2SmdrsFj()) ?? new FWJAAg2lupa1qEYHl1Tv();
		ViewModel = new YFgK5H2i7J5FGyU7TwRL(fWJAAg2lupa1qEYHl1Tv);
		ViewModel.Eu52lBfxUJf(TRy2iRTJeEZ);
		int num = 3;
		MenuItem menuItem2 = default(MenuItem);
		MenuItem menuItem = default(MenuItem);
		while (true)
		{
			switch (num)
			{
			case 9:
				RrnxHg4I6LZQu2nd1yLJ(this);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num = 0;
				}
				break;
			case 3:
			{
				DnXCjc4IQSlqj4M6AwNI(this, new MouseButtonEventHandler(yuH2iXCjZdJ));
				int num2 = 4;
				num = num2;
				break;
			}
			case 6:
				menuItem2 = new MenuItem
				{
					Header = TigerTrade.Properties.Resources.DomAllExchanges
				};
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_281cd373231b4974955fe570959430ac == 0)
				{
					num = 1;
				}
				break;
			default:
				eMVh7R4IMRlCbk59J1yZ(new EventHandler(VbZ2ic95uXF));
				num = 7;
				break;
			case 10:
				WBW2ir8AY8t.Items.Add(menuItem2);
				WBW2ir8AY8t.Items.Add(new Separator());
				((ItemCollection)iiOcD84IRPdiPKa0Qieq(WBW2ir8AY8t)).Add((object)menuItem);
				PpS2SH4LJi3(fWJAAg2lupa1qEYHl1Tv.vlP2kmioDGU);
				num = 8;
				break;
			case 4:
				InitializeComponent();
				menuItem = new MenuItem
				{
					Header = pxhwPc4IdOp6Kna4xGtK()
				};
				num = 2;
				break;
			case 1:
				menuItem2.Click += VFt2iQjWJ0g;
				WBW2ir8AY8t.Items.Add(new Separator());
				num = 10;
				break;
			case 2:
				ocOAGv4Ig5NcfKgl46uM(menuItem, new RoutedEventHandler(uxx2iEOkIYM));
				num = 6;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
				{
					num = 6;
				}
				break;
			case 8:
				ListView.VvO27JXCv8C(g7D2iggbjab);
				num = 9;
				break;
			case 5:
				return;
			case 7:
				LhV2ij1ufij();
				QFU2nH4IOnpDMXtk7cpK(ListView, kop2Sw1sSfc());
				num = 5;
				break;
			}
		}
	}

	private void yuH2iXCjZdJ(object P_0, MouseButtonEventArgs P_1)
	{
		if (VPPW0S4IIbrbym3HuBni(sdsxUp4Iq8dFZaZc3i95()) == IknmHh95XIeQvfxb4I0a.V6U95Eue85N)
		{
			TQ525pb1OP3(ViewModel.SelectedSecurity?.Symbol);
		}
	}

	private void VbZ2ic95uXF(object P_0, EventArgs P_1)
	{
		LhV2ij1ufij();
	}

	private void LhV2ij1ufij()
	{
		int num = 1;
		int num2 = num;
		AlternationConverter alternationConverter = default(AlternationConverter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				alternationConverter = base.Resources[stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44549123)] as AlternationConverter;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_390fe499a2cc4a5ca3d6279a99e6b610 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (alternationConverter != null)
				{
					((SolidColorBrush)alternationConverter.Values[1]).Color = (ThemeManager.GetThemeDefinition(ThemeManager.CurrentTheme).IsDarkTheme ? B3p2iVJX5w3 : mdp2iCfFK6K);
				}
				return;
			}
		}
	}

	private void ScreenerControl_Loaded(object sender, RoutedEventArgs e)
	{
		if (JR62S6js1Bp())
		{
			return;
		}
		mycy5LHEu3qqvRcny9Mb.oh3HQGPC2PW(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1A5F1B9E ^ 0x1A5F80DC));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Chm2iKyjhRf = new DispatcherTimer(TimeSpan.FromMilliseconds(500.0), DispatcherPriority.Normal, delegate
				{
					WDVW9H4WGlcOvJcHoUWf(ViewModel);
				}, base.Dispatcher);
				DoubleEditBoxDeltaThreshold.Value = ((FWJAAg2lupa1qEYHl1Tv)iTWpa94It0steCmL7SxI(ViewModel)).QJU24ftJ3Lk;
				uww2iMhGNmN();
				return;
			case 1:
				break;
			case 0:
				return;
			}
			rs92SMnpCBe(_0020: true);
			int num2 = 2;
			num = num2;
		}
	}

	private void ListView_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
	{
		int num = 2;
		int num2 = num;
		DependencyObject dependencyObject = default(DependencyObject);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				dependencyObject = (DependencyObject)uSgexR4IUbP9LSODv8md(dependencyObject);
				goto case 1;
			case 1:
				if (dependencyObject == null || dependencyObject is ListViewItem)
				{
					if (dependencyObject != null)
					{
						ListView.ContextMenu = WBW2ir8AY8t;
						num2 = 3;
						break;
					}
					return;
				}
				goto default;
			case 2:
				dependencyObject = (DependencyObject)e.OriginalSource;
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_495802897f05476f875528905eba9a89 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private void uxx2iEOkIYM(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		E4T3Td2lSCfJ2JbjriGj e4T3Td2lSCfJ2JbjriGj = default(E4T3Td2lSCfJ2JbjriGj);
		while (true)
		{
			switch (num2)
			{
			default:
				if (e4T3Td2lSCfJ2JbjriGj != null)
				{
					Nk1YpI4ITeY7pa2xQKyj();
					Clipboard.SetText((string)IgCYT34IyMtO5fEVBvbF(e4T3Td2lSCfJ2JbjriGj), TextDataFormat.UnicodeText);
				}
				return;
			case 1:
				e4T3Td2lSCfJ2JbjriGj = ListView.SelectedItem as E4T3Td2lSCfJ2JbjriGj;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8a9257c2b61741afa02a8ceb1f69ad69 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void VFt2iQjWJ0g(object P_0, RoutedEventArgs P_1)
	{
		E4T3Td2lSCfJ2JbjriGj e4T3Td2lSCfJ2JbjriGj = ListView.SelectedItem as E4T3Td2lSCfJ2JbjriGj;
		int num;
		if (e4T3Td2lSCfJ2JbjriGj == null)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		object obj = e4T3Td2lSCfJ2JbjriGj.Symbol;
		goto IL_0098;
		IL_0009:
		switch (num)
		{
		case 1:
			return;
		}
		obj = null;
		goto IL_0098;
		IL_0098:
		if (obj == null)
		{
			return;
		}
		jJAcgx25aGUj2nMDlUeN.fec25l5NG7Y(e4T3Td2lSCfJ2JbjriGj.Symbol);
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 != 0)
		{
			num = 1;
		}
		goto IL_0009;
	}

	private void hJR2idyUClG(object P_0, RoutedEventArgs P_1)
	{
		E4T3Td2lSCfJ2JbjriGj e4T3Td2lSCfJ2JbjriGj = MKRXVT4IZuVrxPo0DIhI(ListView) as E4T3Td2lSCfJ2JbjriGj;
		int num;
		if (e4T3Td2lSCfJ2JbjriGj?.Symbol != null)
		{
			jJAcgx25aGUj2nMDlUeN.fec25l5NG7Y((Symbol)uONLsk4IVhKH1pRPOuZv(e4T3Td2lSCfJ2JbjriGj));
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
			{
				num = 0;
			}
		}
		else
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
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

	private void g7D2iggbjab(object P_0, Dhk8R7Hv7omX9lDUcEce P_1)
	{
		ViewModel.SetSorting((string)rrbcdt4ICO1H6rdZCvEY(P_1), P_1.SortDirection);
	}

	private void TRy2iRTJeEZ(Symbol P_0)
	{
		TQ525pb1OP3(P_0);
	}

	protected override void SetSwitchMarketStatus(bool P_0)
	{
		base.SetSwitchMarketStatus(_0020: false);
	}

	protected override void Dispose(bool P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
			{
				ViewModel.Dispose();
				DispatcherTimer chm2iKyjhRf = Chm2iKyjhRf;
				if (chm2iKyjhRf == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_45006ec5334a406896281e648c9b6ca0 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				chm2iKyjhRf.Stop();
				break;
			}
			case 1:
				if (!Vsa2SyQkClw())
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_de1b6b238ba046ff8910d780c42f0e95 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		base.Dispose(P_0);
	}

	protected override void SaveSettings(string P_0, string P_1, int P_2)
	{
		n8S2SGJFdMU(ViewModel.Settings, P_0);
		ListView.Jr027AURSkr(P_1);
	}

	private void mvK2i6YOZbb(object P_0, RoutedEventArgs P_1)
	{
		string text = ((ButtonBase)P_0).CommandParameter.ToString();
		if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x33010CCB)))
		{
			int num2;
			E4T3Td2lSCfJ2JbjriGj e4T3Td2lSCfJ2JbjriGj = default(E4T3Td2lSCfJ2JbjriGj);
			if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225831007)))
			{
				if (!(text == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--737722733 ^ 0x2BF8A623)))
				{
					int num = 2;
					num2 = num;
				}
				else
				{
					e4T3Td2lSCfJ2JbjriGj = ListView.SelectedItem as E4T3Td2lSCfJ2JbjriGj;
					num2 = 5;
				}
			}
			else if (ViewModel.Securities.Count != 0)
			{
				if (!kvbSnN4Ir6xUhY0scFrY(base.ParentWindow, TigerTrade.Properties.Resources.MainWindowMenuScreener, TigerTrade.Properties.Resources.ScreenerConfirmClear))
				{
					return;
				}
				ViewModel.Securities.Clear();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
				{
					num2 = 0;
				}
			}
			else
			{
				num2 = 4;
			}
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					return;
				case 4:
					return;
				case 5:
					if (e4T3Td2lSCfJ2JbjriGj != null)
					{
						obj = e4T3Td2lSCfJ2JbjriGj.Symbol;
						break;
					}
					goto case 6;
				case 1:
					return;
				case 6:
					obj = null;
					break;
				case 3:
					jJAcgx25aGUj2nMDlUeN.fec25l5NG7Y((Symbol)uONLsk4IVhKH1pRPOuZv(e4T3Td2lSCfJ2JbjriGj));
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_976d29d6825c4c4995e3a2719d735c00 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 2:
					return;
				}
				if (obj == null)
				{
					break;
				}
				num2 = 3;
			}
		}
		else
		{
			ViewModel.OGL2l2Kbje0(DoubleEditBoxDeltaThreshold.Value ?? 0.1);
			uww2iMhGNmN();
		}
	}

	private void LinkGroupControl_GroupChanged(int groupID, bool isActiveWindow)
	{
		SsS253ZUwy8(groupID);
	}

	private void uww2iMhGNmN()
	{
		int num;
		object obj;
		string text = default(string);
		if (gsXFXF4IKNL2A5AJN4XQ(ViewModel.Settings) == double.MaxValue)
		{
			if (!YISbyg4IAs77Lni2B5Ei(ViewModel.Settings))
			{
				num = 3;
			}
			else
			{
				text = ViewModel.Settings.vlP2kmioDGU;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 1;
				}
			}
		}
		else
		{
			if (((KqZtUj2kTEAQfYBkeSKy)iTWpa94It0steCmL7SxI(ViewModel)).zDi2k7CwL38)
			{
				obj = ViewModel.Settings.vlP2kmioDGU;
				goto IL_0267;
			}
			num = 6;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 5;
			}
		}
		goto IL_0009;
		IL_0009:
		string text2 = default(string);
		while (true)
		{
			switch (num)
			{
			case 6:
				break;
			case 4:
				return;
			case 1:
				text = text.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D1863EC), "");
				PpS2SH4LJi3(text);
				return;
			case 3:
				PpS2SH4LJi3(ViewModel.Settings.DefaultTitle);
				num = 4;
				continue;
			case 2:
			case 5:
				PpS2SH4LJi3(text2);
				return;
			default:
				goto IL_01ef;
			}
			break;
		}
		obj = t3eLSp4ImJfHEJQ5Aq5q(j18iDj9nukSCmEyZs5lH.Settings);
		goto IL_0267;
		IL_0267:
		text2 = (string)obj;
		if (qU62r24IwFX7jcOk2myt(text2, bUNIKI4Ih9neFh8fqKOp(--737722733 ^ 0x2BF888A7)))
		{
			text2 = (string)DoTCqc4I7BHs6LTshGQa(text2, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6EC99CAF ^ 0x6EC9D565), ((KqZtUj2kTEAQfYBkeSKy)iTWpa94It0steCmL7SxI(ViewModel)).DefaultTitle);
		}
		if (!text2.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741B1E45)))
		{
			num = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 != 0)
			{
				num = 2;
			}
			goto IL_0009;
		}
		goto IL_01ef;
		IL_01ef:
		text2 = text2.Replace(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056680178), (string)zL1RuY4I8iS5Twq7RQBK(gsXFXF4IKNL2A5AJN4XQ(ViewModel.Settings).ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842067325)), bUNIKI4Ih9neFh8fqKOp(0x6E2DFBED ^ 0x6E2D6077)));
		num = 2;
		goto IL_0009;
	}

	public override void SetCustomTitle(string P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				ViewModel.Settings.vlP2kmioDGU = P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				VCGbjP4IJDqu2D7ij02O(ViewModel.Settings, !P8MZb44IPuOQhcRlIDPB(P_0));
				uww2iMhGNmN();
				return;
			}
		}
	}

	private void bpI2iOARrNV(object P_0, KeyEventArgs P_1)
	{
		if (P_1.Key.Equals(Key.Return))
		{
			Am82iq59hnI(Key.Tab);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			P_1.Handled = true;
		}
	}

	public static void Am82iq59hnI(Key P_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Keyboard.PrimaryDevice == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03df70ea72bf4e3e81ab05550292a7c9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (Keyboard.PrimaryDevice.ActiveSource != null)
				{
					KeyEventArgs input = new KeyEventArgs(Keyboard.PrimaryDevice, Keyboard.PrimaryDevice.ActiveSource, 0, P_0)
					{
						RoutedEvent = Keyboard.KeyDownEvent
					};
					InputManager.Current.ProcessInput(input);
				}
				return;
			}
		}
	}

	private void gnV2iIlKDuj(object P_0, MouseButtonEventArgs P_1)
	{
		if (P_1.LeftButton != MouseButtonState.Pressed)
		{
			return;
		}
		ListViewItem listViewItem = P_0 as ListViewItem;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf != 0)
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
			if (listViewItem != null)
			{
				t142imyJRHY = mAAZAW4IFe5tDfvECcyR(P_1, null);
				Lt62ihOYgba = listViewItem;
				return;
			}
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_eb223d2975554a51b6c4f9fa9a65a93d == 0)
			{
				num = 1;
			}
		}
	}

	private void hoT2iWNDJlo(object P_0, MouseEventArgs P_1)
	{
		Vector vector = default(Vector);
		int num;
		if (e4udAl4I3lygjTHCk7CS(P_1) == MouseButtonState.Pressed && t142imyJRHY.HasValue && Lt62ihOYgba != null)
		{
			Point position = P_1.GetPosition(null);
			vector = kj821H4IpDM4hZjE07Ej(t142imyJRHY.Value, position);
			num = 3;
		}
		else
		{
			t142imyJRHY = null;
			num = 6;
		}
		E4T3Td2lSCfJ2JbjriGj e4T3Td2lSCfJ2JbjriGj = default(E4T3Td2lSCfJ2JbjriGj);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!(U5w42r4IujR67WKX11w1(vector.X) > SystemParameters.MinimumHorizontalDragDistance))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_26fe5531b15948b7a2b6ffb2cd927204 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			case 4:
				if (e4T3Td2lSCfJ2JbjriGj != null)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
					{
						num = 2;
					}
					continue;
				}
				goto case 5;
			case 2:
			{
				DataObject dataObject = new DataObject(Type.GetTypeFromHandle(mUCVHm4W2tIg3mLNb9iA(16777446)), e4T3Td2lSCfJ2JbjriGj.Symbol);
				dataObject.SetData(VRjO2H4WHEM9RphjXJYU(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555016)), this);
				DragDrop.DoDragDrop(this, dataObject, DragDropEffects.Copy);
				num = 5;
				continue;
			}
			case 1:
				return;
			case 5:
				t142imyJRHY = null;
				Lt62ihOYgba = null;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 == 0)
				{
					num = 1;
				}
				continue;
			case 6:
				Lt62ihOYgba = null;
				return;
			default:
				if (!(Math.Abs(vector.Y) > ipRNLo4IzZVq7vFI6DnP()))
				{
					return;
				}
				break;
			}
			e4T3Td2lSCfJ2JbjriGj = HV0oS44W02DWworcnVca(Lt62ihOYgba) as E4T3Td2lSCfJ2JbjriGj;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
			{
				num = 4;
			}
		}
	}

	private void Xpt2itoEXVu(object P_0, MouseButtonEventArgs P_1)
	{
		t142imyJRHY = null;
		Lt62ihOYgba = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		if (!Ckd2iwZKNtK)
		{
			Ckd2iwZKNtK = true;
			Uri resourceLocator = new Uri((string)bUNIKI4Ih9neFh8fqKOp(-1606927328 ^ -1606899840), UriKind.Relative);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 1:
				return;
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	void IComponentConnector.Connect(int P_0, object P_1)
	{
		int num;
		switch (P_0)
		{
		case 5:
			GRvegh4WfadTjU3qZJRw((Button)P_1, new RoutedEventHandler(mvK2i6YOZbb));
			break;
		case 6:
			((Int64EditBox)P_1).KeyDown += bpI2iOARrNV;
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6938a97537c94834bed9381eb4051eec == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 2:
			DoubleEditBoxDeltaThreshold = (DoubleEditBox)P_1;
			break;
		case 1:
			ControlRoot = (kq9RCq2iem0KToyvfhNJ)P_1;
			break;
		case 3:
			GRvegh4WfadTjU3qZJRw((Button)P_1, new RoutedEventHandler(mvK2i6YOZbb));
			break;
		case 8:
			ListView = (lfeFPj27qiPQ1FwhnA4U)P_1;
			break;
		default:
			Ckd2iwZKNtK = true;
			num = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4badf00eaf04a4c91e3397f36a429cf == 0)
			{
				num = 0;
			}
			goto IL_0009;
		case 7:
			((Int64EditBox)P_1).KeyDown += bpI2iOARrNV;
			break;
		case 4:
			{
				((Button)P_1).Click += mvK2i6YOZbb;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f != 0)
				{
					num = 1;
				}
				goto IL_0009;
			}
			IL_0009:
			switch (num)
			{
			default:
				return;
			case 2:
				return;
			case 1:
				return;
			case 3:
				break;
			case 0:
				return;
			}
			goto case 1;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	void IStyleConnector.Connect(int P_0, object P_1)
	{
		if (P_0 != 9)
		{
			return;
		}
		EventSetter eventSetter = new EventSetter();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 4:
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.PreviewMouseUpEvent;
				eventSetter.Handler = new MouseButtonEventHandler(Xpt2itoEXVu);
				((Collection<SetterBase>)ip3w5x4Wn7mqVyqYjbg8((Style)P_1)).Add((SetterBase)eventSetter);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				((Style)P_1).Setters.Add(eventSetter);
				num = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3cfcda862e0540cbb9abf65446a10635 == 0)
				{
					num = 4;
				}
				break;
			case 0:
				return;
			case 2:
				BGlZVo4W90KFaHkkQ7Qr(eventSetter, new MouseEventHandler(hoT2iWNDJlo));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
				{
					num = 1;
				}
				break;
			case 3:
			{
				eventSetter.Event = UIElement.PreviewMouseDownEvent;
				eventSetter.Handler = new MouseButtonEventHandler(gnV2iIlKDuj);
				((Style)P_1).Setters.Add(eventSetter);
				eventSetter = new EventSetter();
				eventSetter.Event = UIElement.MouseMoveEvent;
				int num2 = 2;
				num = num2;
				break;
			}
			}
		}
	}

	[CompilerGenerated]
	private void px92iUvmyqu(object P_0, EventArgs P_1)
	{
		WDVW9H4WGlcOvJcHoUWf(ViewModel);
	}

	static kq9RCq2iem0KToyvfhNJ()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool cdudnh4IjaL3j3W7jjIe()
	{
		return FdBlmc4Ic8sn8Wy7Ayb5 == null;
	}

	internal static kq9RCq2iem0KToyvfhNJ Q0chKS4IENYmkZty4DiT()
	{
		return FdBlmc4Ic8sn8Wy7Ayb5;
	}

	internal static void DnXCjc4IQSlqj4M6AwNI(object P_0, object P_1)
	{
		((Control)P_0).MouseDoubleClick += (MouseButtonEventHandler)P_1;
	}

	internal static object pxhwPc4IdOp6Kna4xGtK()
	{
		return TigerTrade.Properties.Resources.WatchlistControlCopyTicker;
	}

	internal static void ocOAGv4Ig5NcfKgl46uM(object P_0, object P_1)
	{
		((MenuItem)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static object iiOcD84IRPdiPKa0Qieq(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void RrnxHg4I6LZQu2nd1yLJ(object P_0)
	{
		((z6kMSs25KYyGVf55FxBT)P_0).InitLink();
	}

	internal static void eMVh7R4IMRlCbk59J1yZ(object P_0)
	{
		ThemeManager.CurrentThemeChanged += (EventHandler)P_0;
	}

	internal static void QFU2nH4IOnpDMXtk7cpK(object P_0, object P_1)
	{
		((lfeFPj27qiPQ1FwhnA4U)P_0).nQ427P2tMLy((string)P_1);
	}

	internal static object sdsxUp4Iq8dFZaZc3i95()
	{
		return j18iDj9nukSCmEyZs5lH.Settings;
	}

	internal static IknmHh95XIeQvfxb4I0a VPPW0S4IIbrbym3HuBni(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).TickerSwitchingMode;
	}

	internal static object Vlkmmd4IWQBOGcMHgvvK(object P_0)
	{
		return ((YFgK5H2i7J5FGyU7TwRL)P_0).SelectedSecurity;
	}

	internal static object iTWpa94It0steCmL7SxI(object P_0)
	{
		return ((YFgK5H2i7J5FGyU7TwRL)P_0).Settings;
	}

	internal static object uSgexR4IUbP9LSODv8md(object P_0)
	{
		return VisualTreeHelper.GetParent((DependencyObject)P_0);
	}

	internal static void Nk1YpI4ITeY7pa2xQKyj()
	{
		Clipboard.Clear();
	}

	internal static object IgCYT34IyMtO5fEVBvbF(object P_0)
	{
		return ((E4T3Td2lSCfJ2JbjriGj)P_0).Name;
	}

	internal static object MKRXVT4IZuVrxPo0DIhI(object P_0)
	{
		return ((Selector)P_0).SelectedItem;
	}

	internal static object uONLsk4IVhKH1pRPOuZv(object P_0)
	{
		return ((E4T3Td2lSCfJ2JbjriGj)P_0).Symbol;
	}

	internal static object rrbcdt4ICO1H6rdZCvEY(object P_0)
	{
		return ((Dhk8R7Hv7omX9lDUcEce)P_0).PropertyName;
	}

	internal static bool kvbSnN4Ir6xUhY0scFrY(object P_0, object P_1, object P_2)
	{
		return YesNoWindow.ShowWindow((Window)P_0, (string)P_1, (string)P_2);
	}

	internal static double gsXFXF4IKNL2A5AJN4XQ(object P_0)
	{
		return ((FWJAAg2lupa1qEYHl1Tv)P_0).QJU24ftJ3Lk;
	}

	internal static object t3eLSp4ImJfHEJQ5Aq5q(object P_0)
	{
		return ((MhMDPU9v8rkigy1ao0Th)P_0).uAy9lvKwvoq;
	}

	internal static object bUNIKI4Ih9neFh8fqKOp(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool qU62r24IwFX7jcOk2myt(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object DoTCqc4I7BHs6LTshGQa(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object zL1RuY4I8iS5Twq7RQBK(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool YISbyg4IAs77Lni2B5Ei(object P_0)
	{
		return ((KqZtUj2kTEAQfYBkeSKy)P_0).zDi2k7CwL38;
	}

	internal static bool P8MZb44IPuOQhcRlIDPB(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void VCGbjP4IJDqu2D7ij02O(object P_0, bool P_1)
	{
		((KqZtUj2kTEAQfYBkeSKy)P_0).zDi2k7CwL38 = P_1;
	}

	internal static Point mAAZAW4IFe5tDfvECcyR(object P_0, object P_1)
	{
		return ((MouseEventArgs)P_0).GetPosition((IInputElement)P_1);
	}

	internal static MouseButtonState e4udAl4I3lygjTHCk7CS(object P_0)
	{
		return ((MouseEventArgs)P_0).LeftButton;
	}

	internal static Vector kj821H4IpDM4hZjE07Ej(Point P_0, Point P_1)
	{
		return P_0 - P_1;
	}

	internal static double U5w42r4IujR67WKX11w1(double P_0)
	{
		return Math.Abs(P_0);
	}

	internal static double ipRNLo4IzZVq7vFI6DnP()
	{
		return SystemParameters.MinimumVerticalDragDistance;
	}

	internal static object HV0oS44W02DWworcnVca(object P_0)
	{
		return ((ContentControl)P_0).Content;
	}

	internal static RuntimeTypeHandle mUCVHm4W2tIg3mLNb9iA(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type VRjO2H4WHEM9RphjXJYU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void GRvegh4WfadTjU3qZJRw(object P_0, object P_1)
	{
		((ButtonBase)P_0).Click += (RoutedEventHandler)P_1;
	}

	internal static void BGlZVo4W90KFaHkkQ7Qr(object P_0, object P_1)
	{
		((EventSetter)P_0).Handler = (Delegate)P_1;
	}

	internal static object ip3w5x4Wn7mqVyqYjbg8(object P_0)
	{
		return ((Style)P_0).Setters;
	}

	internal static void WDVW9H4WGlcOvJcHoUWf(object P_0)
	{
		((YFgK5H2i7J5FGyU7TwRL)P_0).ARS2iPJ1RRG();
	}
}
