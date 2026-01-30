using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Threading;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Chart.Base;
using TuAMtrl1Nd3XoZQQUXf0;
using UIKit.Core;
using xfdMo0lS4TP9pN36Goka;

namespace wOu7adH9ySPbXWlURJCL;

internal class wgyvRFH9TatlGu9hT9fS : System.Windows.Controls.Button
{
	private DispatcherTimer E8WHn9twTJC;

	private UIKit.Core.Popup SL7HnnAuqxV;

	public static readonly DependencyProperty lfkHnGeXXTY;

	public static readonly DependencyProperty kpnHnYBwbaq;

	public static readonly DependencyProperty cDbHnofRsUw;

	public static readonly DependencyProperty NZjHnvZOpAO;

	public static readonly DependencyProperty TksHnB7C9HZ;

	public static readonly DependencyProperty GuVHnaEFPiS;

	public static readonly DependencyProperty geNHniAJ8Gu;

	internal static wgyvRFH9TatlGu9hT9fS M2cr45DDnnwK2neRqiPQ;

	public string Title
	{
		get
		{
			return GetValue(lfkHnGeXXTY) as string;
		}
		set
		{
			SetValue(lfkHnGeXXTY, value2);
		}
	}

	public string Header
	{
		get
		{
			return xa5cSDDD4I6KImvL3FeP(this, kpnHnYBwbaq) as string;
		}
		set
		{
			tUhdHNDDDTpiWuU4HcYC(this, kpnHnYBwbaq, text);
		}
	}

	public string Body
	{
		get
		{
			return GetValue(cDbHnofRsUw) as string;
		}
		set
		{
			SetValue(cDbHnofRsUw, value2);
		}
	}

	public DataCycle Period
	{
		get
		{
			return (DataCycle)xa5cSDDD4I6KImvL3FeP(this, NZjHnvZOpAO);
		}
		set
		{
			tUhdHNDDDTpiWuU4HcYC(this, NZjHnvZOpAO, dataCycle);
		}
	}

	public DataCycle SelectedPeriod
	{
		get
		{
			return (DataCycle)GetValue(TksHnB7C9HZ);
		}
		set
		{
			SetValue(TksHnB7C9HZ, value2);
		}
	}

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(GuVHnaEFPiS);
		}
		private set
		{
			tUhdHNDDDTpiWuU4HcYC(this, GuVHnaEFPiS, flag);
		}
	}

	public Placement PopupPlacement
	{
		get
		{
			return (Placement)GetValue(geNHniAJ8Gu);
		}
		set
		{
			SetValue(geNHniAJ8Gu, placement);
		}
	}

	public wgyvRFH9TatlGu9hT9fS()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		base.DefaultStyleKey = SgRwBxDDoqNK5OZZyDQY(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231));
		E8WHn9twTJC = new DispatcherTimer();
		int num = 2;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ac6a9a8fc5c94cd6833091a6efebb474 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				IcVjZ2DDBpxQJIyONE40(E8WHn9twTJC, shII3KDDvigC9XoiBpcV(500.0));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bbcfc7b1c81d4568b6bd3ed19a340f5e == 0)
				{
					num = 0;
				}
				continue;
			case 3:
				return;
			case 1:
				rFU2tGDDir8JRQuAPT8F(this, new RoutedEventHandler(F7BH9Z7XnNo));
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 0;
				}
				continue;
			}
			mYhIcfDDa8QUfxo7oZVE(E8WHn9twTJC, new EventHandler(oBfH9VBb3A4));
			base.MouseEnter += R9DH9CqiS8A;
			base.MouseLeave += e4TH9r84ao9;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae == 0)
			{
				num = 1;
			}
		}
	}

	public override void OnApplyTemplate()
	{
		DependencyObject dependencyObject = (DependencyObject)v5ty4HDDlix0Rs5Pnkxd(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7F645F3C ^ 0x7F65525E));
		SL7HnnAuqxV = dependencyObject as UIKit.Core.Popup;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.OnApplyTemplate();
	}

	private void F7BH9Z7XnNo(object P_0, RoutedEventArgs P_1)
	{
		IsSelected = Period?.Equals(SelectedPeriod) ?? false;
	}

	private void oBfH9VBb3A4(object P_0, EventArgs P_1)
	{
		Q7GhepDDbhx7yB9rUTeb(E8WHn9twTJC);
		if (SL7HnnAuqxV != null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9d6f131f80d34ede83451138b928a86f == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			UfdICZDDNOYaheoPwKQ6(SL7HnnAuqxV, true);
		}
	}

	private void R9DH9CqiS8A(object P_0, MouseEventArgs P_1)
	{
		E8WHn9twTJC.Start();
	}

	private void e4TH9r84ao9(object P_0, MouseEventArgs P_1)
	{
		Q7GhepDDbhx7yB9rUTeb(E8WHn9twTJC);
		if (SL7HnnAuqxV != null)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_c16c36b6197f4f30be0a8035f04288b3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			UfdICZDDNOYaheoPwKQ6(SL7HnnAuqxV, false);
		}
	}

	private static void lPWH9KgfEC9(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is wgyvRFH9TatlGu9hT9fS wgyvRFH9TatlGu9hT9fS2))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_bcda8c444ccc4b27895bae9f13596743 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			wgyvRFH9TatlGu9hT9fS2.IsSelected = (P_1.NewValue as DataCycle)?.Equals(wgyvRFH9TatlGu9hT9fS2.SelectedPeriod) ?? false;
		}
	}

	private static void MPWH9mCdJj0(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is wgyvRFH9TatlGu9hT9fS wgyvRFH9TatlGu9hT9fS2))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			wgyvRFH9TatlGu9hT9fS2.IsSelected = (P_1.NewValue as DataCycle)?.Equals((DataCycle)g7GbbTDDkFmOsDXO5OBj(wgyvRFH9TatlGu9hT9fS2)) ?? false;
		}
	}

	static wgyvRFH9TatlGu9hT9fS()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		lTJCaUDD1y4GVK64QmH1();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				NZjHnvZOpAO = DependencyProperty.Register((string)eS5XQQDDSsWdGlsw3lWi(0x1EFE0A28 ^ 0x1EFF07AE), SgRwBxDDoqNK5OZZyDQY(z5tbwIDD52VU5nwWmD0a(33556088)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231)), new PropertyMetadata(lPWH9KgfEC9));
				num = 2;
				break;
			case 3:
				lfkHnGeXXTY = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-527080372 ^ -527096366), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(z5tbwIDD52VU5nwWmD0a(33555231)));
				kpnHnYBwbaq = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-530053095 ^ -530036329), SgRwBxDDoqNK5OZZyDQY(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231)));
				cDbHnofRsUw = DependencyProperty.Register((string)eS5XQQDDSsWdGlsw3lWi(-342738082 ^ -342673884), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), SgRwBxDDoqNK5OZZyDQY(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231)));
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb == 0)
				{
					num = 0;
				}
				break;
			case 1:
				geNHniAJ8Gu = (DependencyProperty)NBU8xLDDxlcnpa6hkfhU(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769D7487), Type.GetTypeFromHandle(z5tbwIDD52VU5nwWmD0a(16777310)), SgRwBxDDoqNK5OZZyDQY(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231)), new PropertyMetadata(Placement.Bottom));
				return;
			case 2:
				TksHnB7C9HZ = (DependencyProperty)NBU8xLDDxlcnpa6hkfhU(eS5XQQDDSsWdGlsw3lWi(-1522697859 ^ -1522764565), SgRwBxDDoqNK5OZZyDQY(z5tbwIDD52VU5nwWmD0a(33556088)), Type.GetTypeFromHandle(z5tbwIDD52VU5nwWmD0a(33555231)), new PropertyMetadata(MPWH9mCdJj0));
				GuVHnaEFPiS = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520134053), Type.GetTypeFromHandle(z5tbwIDD52VU5nwWmD0a(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555231)));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static Type SgRwBxDDoqNK5OZZyDQY(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static TimeSpan shII3KDDvigC9XoiBpcV(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static void IcVjZ2DDBpxQJIyONE40(object P_0, TimeSpan P_1)
	{
		((DispatcherTimer)P_0).Interval = P_1;
	}

	internal static void mYhIcfDDa8QUfxo7oZVE(object P_0, object P_1)
	{
		((DispatcherTimer)P_0).Tick += (EventHandler)P_1;
	}

	internal static void rFU2tGDDir8JRQuAPT8F(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Loaded += (RoutedEventHandler)P_1;
	}

	internal static bool yyMLxQDDGrs5bVcnXLJ0()
	{
		return M2cr45DDnnwK2neRqiPQ == null;
	}

	internal static wgyvRFH9TatlGu9hT9fS EInvYjDDYOTYckME9iXO()
	{
		return M2cr45DDnnwK2neRqiPQ;
	}

	internal static object v5ty4HDDlix0Rs5Pnkxd(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static object xa5cSDDD4I6KImvL3FeP(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void tUhdHNDDDTpiWuU4HcYC(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static void Q7GhepDDbhx7yB9rUTeb(object P_0)
	{
		((DispatcherTimer)P_0).Stop();
	}

	internal static void UfdICZDDNOYaheoPwKQ6(object P_0, bool P_1)
	{
		((System.Windows.Controls.Primitives.Popup)P_0).IsOpen = P_1;
	}

	internal static object g7GbbTDDkFmOsDXO5OBj(object P_0)
	{
		return ((wgyvRFH9TatlGu9hT9fS)P_0).Period;
	}

	internal static void lTJCaUDD1y4GVK64QmH1()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static RuntimeTypeHandle z5tbwIDD52VU5nwWmD0a(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object eS5XQQDDSsWdGlsw3lWi(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object NBU8xLDDxlcnpa6hkfhU(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
