using System;
using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace x4lDhaHkE50JmMQgoipc;

internal static class fYWYm8HkjGvomfyqBBJd
{
	public static readonly DependencyProperty AutoToolTipProperty;

	private static fYWYm8HkjGvomfyqBBJd WurqoNDx9HU6uNC3tGac;

	public static bool GetAutoToolTip(DependencyObject obj)
	{
		return (bool)obj.GetValue(AutoToolTipProperty);
	}

	public static void SetAutoToolTip(DependencyObject obj, bool value)
	{
		obj.SetValue(AutoToolTipProperty, value);
	}

	private static void DURHkQAUaxd(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 4;
		int num2 = num;
		TextBlock textBlock = default(TextBlock);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (textBlock == null)
				{
					return;
				}
				if (P_1.NewValue.Equals(true))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f == 0)
					{
						num2 = 0;
					}
					break;
				}
				textBlock.Loaded -= aSsHkd7YtXK;
				textBlock.SizeChanged -= RA6HkgvlUcc;
				return;
			case 2:
				textBlock.Loaded += aSsHkd7YtXK;
				GMxqpQDxoEroh9mYY4gw(textBlock, new SizeChangedEventHandler(RA6HkgvlUcc));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				textBlock = P_0 as TextBlock;
				num2 = 3;
				break;
			default:
				textBlock.TextTrimming = TextTrimming.CharacterEllipsis;
				d7MSTODxYJa3pd5jCS0M(textBlock);
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	private static void aSsHkd7YtXK(object P_0, RoutedEventArgs P_1)
	{
		eIVHkRbMeKW(P_0 as TextBlock);
	}

	private static void RA6HkgvlUcc(object P_0, SizeChangedEventArgs P_1)
	{
		eIVHkRbMeKW(P_0 as TextBlock);
	}

	private static void eIVHkRbMeKW(TextBlock P_0)
	{
		P_0.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
		double width = S2uu6nDxvCb3sYEUoYnl(P_0).Width;
		ToolTipService.SetToolTip(P_0, (P_0.ActualWidth < width) ? uAJQojDxBxLaeo1vmHUu(P_0) : null);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_44265f4417e640c7a760a59a950624e5 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static fYWYm8HkjGvomfyqBBJd()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		AutoToolTipProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x769C7931 ^ 0x769D589D), Type.GetTypeFromHandle(vSlv5PDxaoSMkWj3NQZP(16777221)), jeZS7XDxiMOYiIEpV2nj(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555309)), new PropertyMetadata(false, DURHkQAUaxd));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool L3F0KUDxndEQwQk9lbuh()
	{
		return WurqoNDx9HU6uNC3tGac == null;
	}

	internal static fYWYm8HkjGvomfyqBBJd v2LXlZDxGmeDuIV6Sq3I()
	{
		return WurqoNDx9HU6uNC3tGac;
	}

	internal static void d7MSTODxYJa3pd5jCS0M(object P_0)
	{
		eIVHkRbMeKW((TextBlock)P_0);
	}

	internal static void GMxqpQDxoEroh9mYY4gw(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged += (SizeChangedEventHandler)P_1;
	}

	internal static Size S2uu6nDxvCb3sYEUoYnl(object P_0)
	{
		return ((UIElement)P_0).DesiredSize;
	}

	internal static object uAJQojDxBxLaeo1vmHUu(object P_0)
	{
		return ((TextBlock)P_0).Text;
	}

	internal static RuntimeTypeHandle vSlv5PDxaoSMkWj3NQZP(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static Type jeZS7XDxiMOYiIEpV2nj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
