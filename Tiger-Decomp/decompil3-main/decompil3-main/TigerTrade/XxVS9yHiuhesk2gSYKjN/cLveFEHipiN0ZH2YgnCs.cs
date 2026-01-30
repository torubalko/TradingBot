using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;
using System.Windows.Media;
using AjufQO2pCUwfjdgDEWh0;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Dx.Fonts;
using TuAMtrl1Nd3XoZQQUXf0;

namespace XxVS9yHiuhesk2gSYKjN;

internal sealed class cLveFEHipiN0ZH2YgnCs : Window
{
	private static cLveFEHipiN0ZH2YgnCs xps5bDD12AQA0IpUwfdi;

	public cLveFEHipiN0ZH2YgnCs()
	{
		sQyxh1D19bSPoHorkc7X();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				base.ShowInTaskbar = false;
				t50t0YD1nD2oQHtqMCRA(this, true);
				num = 3;
				continue;
			case 1:
				return;
			case 3:
				base.WindowStyle = WindowStyle.None;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6990919c9c0e45a99d17cb82a4a90a41 == 0)
				{
					num = 0;
				}
				continue;
			}
			base.AllowsTransparency = true;
			base.Background = (Brush)DO9TWPD1GPlOVDutRHTU();
			base.Content = LwaHizKQ8Wl();
			UWE2YZD1YxwTjDrVCPQi(this, false);
			base.Topmost = false;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num = 1;
			}
		}
	}

	private object LwaHizKQ8Wl()
	{
		Grid obj = new Grid
		{
			Background = new SolidColorBrush(Color.FromArgb(85, 0, 0, 0)),
			IsHitTestVisible = false
		};
		Image obj2 = new Image
		{
			Source = ueWFR52pVWCRFPWGds3X.R7m2pKV9nhV(FontAwesomeIcon.Lock, Brushes.White, 120.0)
		};
		JQ6WtPD1oFayxskgAdCh(obj2, 120.0);
		obj2.Height = 120.0;
		obj2.HorizontalAlignment = HorizontalAlignment.Center;
		obj2.VerticalAlignment = VerticalAlignment.Center;
		obj2.IsHitTestVisible = false;
		obj2.Opacity = 0.6;
		Image element = obj2;
		((UIElementCollection)GcMSkwD1v5WlOilWa0SB(obj)).Add((UIElement)element);
		return obj;
	}

	protected override void OnSourceInitialized(EventArgs P_0)
	{
		base.OnSourceInitialized(P_0);
		IntPtr intPtr = AV0pAxD1BnKpPQEuq9QT(new WindowInteropHelper(this));
		int num = rAeHl02UK4b(intPtr, -20);
		num |= 0x80000A0;
		sNjHl2U9aS8(intPtr, -20, num);
	}

	[DllImport("user32.dll", EntryPoint = "GetWindowLong")]
	private static extern int rAeHl02UK4b(IntPtr P_0, int P_1);

	[DllImport("user32.dll", EntryPoint = "SetWindowLong")]
	private static extern int sNjHl2U9aS8(IntPtr P_0, int P_1, int P_2);

	static cLveFEHipiN0ZH2YgnCs()
	{
		HmJUH2D1aZqLjsh9IHY0();
	}

	internal static void sQyxh1D19bSPoHorkc7X()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void t50t0YD1nD2oQHtqMCRA(object P_0, bool P_1)
	{
		((Window)P_0).ShowActivated = P_1;
	}

	internal static object DO9TWPD1GPlOVDutRHTU()
	{
		return Brushes.Transparent;
	}

	internal static void UWE2YZD1YxwTjDrVCPQi(object P_0, bool P_1)
	{
		((UIElement)P_0).Focusable = P_1;
	}

	internal static bool IjQDKqD1HCKqLVx8Xprp()
	{
		return xps5bDD12AQA0IpUwfdi == null;
	}

	internal static cLveFEHipiN0ZH2YgnCs a7Kv7SD1f9YGRW13vdSM()
	{
		return xps5bDD12AQA0IpUwfdi;
	}

	internal static void JQ6WtPD1oFayxskgAdCh(object P_0, double P_1)
	{
		((FrameworkElement)P_0).Width = P_1;
	}

	internal static object GcMSkwD1v5WlOilWa0SB(object P_0)
	{
		return ((Panel)P_0).Children;
	}

	internal static IntPtr AV0pAxD1BnKpPQEuq9QT(object P_0)
	{
		return ((WindowInteropHelper)P_0).Handle;
	}

	internal static void HmJUH2D1aZqLjsh9IHY0()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
