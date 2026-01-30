using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace gdX3xCHx1fJSOYUoH2te;

public class yysv04Hxki4pUC4QX1EZ : DependencyObject
{
	public static readonly DependencyProperty CurrentMenuItemParameterProperty;

	internal static yysv04Hxki4pUC4QX1EZ FfbIDbDX7mtg3ULAtvOl;

	public static void SetCurrentMenuItemParameter(DependencyObject element, string value)
	{
		element.SetValue(CurrentMenuItemParameterProperty, value);
	}

	public static string GetCurrentMenuItemParameter(DependencyObject element)
	{
		return (string)element.GetValue(CurrentMenuItemParameterProperty);
	}

	private static void Nw7Hx57tCZE(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.NewValue == P_1.OldValue)
		{
			return;
		}
		if (P_0 is ContextMenu contextMenu)
		{
			IEnumerator enumerator = ((IEnumerable)contextMenu.Items).GetEnumerator();
			try
			{
				MenuItem menuItem = default(MenuItem);
				string text = default(string);
				while (true)
				{
					int num;
					if (!enumerator.MoveNext())
					{
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
						{
							num = 0;
						}
					}
					else
					{
						menuItem = enumerator.Current as MenuItem;
						if (menuItem == null)
						{
							continue;
						}
						text = P_1.NewValue?.ToString();
						num = 2;
					}
					while (true)
					{
						switch (num)
						{
						case 1:
							return;
						case 2:
							menuItem.IsChecked = !rtFTn5DXPvXlXY9grcqd(text) && text == rbOuyXDXJTVZInwPWJXq(menuItem)?.ToString();
							num = 0;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 == 0)
							{
								num = 0;
							}
							continue;
						}
						break;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					int num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 == 0)
					{
						num2 = 0;
					}
					switch (num2)
					{
					default:
						disposable.Dispose();
						break;
					}
				}
			}
		}
		int num3 = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 == 0)
		{
			num3 = 0;
		}
		switch (num3)
		{
		case 0:
			break;
		case 1:
			break;
		}
	}

	public yysv04Hxki4pUC4QX1EZ()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static yysv04Hxki4pUC4QX1EZ()
	{
		Wvj06nDXF1aojv5NVxis();
		TeWWZKDX3X3sApOHhH0y();
		CurrentMenuItemParameterProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-991861155 ^ -991935505), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777226)), g5YFXmDXpeEDjmy541c0(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555364)), new UIPropertyMetadata(null, Nw7Hx57tCZE));
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_53f0c1974ed349c3831704ecb4d3ce13 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MKl7INDX862Vi5RoNwuR()
	{
		return FfbIDbDX7mtg3ULAtvOl == null;
	}

	internal static yysv04Hxki4pUC4QX1EZ fO207YDXAn30b33teRQK()
	{
		return FfbIDbDX7mtg3ULAtvOl;
	}

	internal static bool rtFTn5DXPvXlXY9grcqd(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object rbOuyXDXJTVZInwPWJXq(object P_0)
	{
		return ((MenuItem)P_0).CommandParameter;
	}

	internal static void Wvj06nDXF1aojv5NVxis()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static void TeWWZKDX3X3sApOHhH0y()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type g5YFXmDXpeEDjmy541c0(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
