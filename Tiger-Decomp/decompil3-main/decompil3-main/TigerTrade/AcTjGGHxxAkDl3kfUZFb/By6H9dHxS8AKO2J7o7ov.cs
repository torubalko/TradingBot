using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using E4WgbSHDB8PvMrmn1Ivi;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace AcTjGGHxxAkDl3kfUZFb;

public class By6H9dHxS8AKO2J7o7ov
{
	public static readonly DependencyProperty IsDragOverProperty;

	public static readonly DependencyProperty IsEnabledProperty;

	internal static By6H9dHxS8AKO2J7o7ov G1u288DXuGQYiec0L70v;

	public static void SetIsDragOver(DependencyObject element, bool value)
	{
		element.SetValue(IsDragOverProperty, value);
	}

	public static bool GetIsDragOver(DependencyObject element)
	{
		return (bool)element.GetValue(IsDragOverProperty);
	}

	public static void SetIsEnabled(DependencyObject element, bool value)
	{
		element.SetValue(IsEnabledProperty, value);
	}

	public static bool GetIsEnabled(DependencyObject element)
	{
		return (bool)element.GetValue(IsEnabledProperty);
	}

	private static void nVIHxL3AeQa(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		bool flag = (bool)P_1.NewValue && !(bool)P_1.OldValue;
		int num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e38cca27b4f843e0acda58c2d2606b17 == 0)
		{
			num = 7;
		}
		ListBoxItem listBoxItem = default(ListBoxItem);
		ListBox listBox = default(ListBox);
		while (true)
		{
			switch (num)
			{
			case 6:
				listBoxItem.DragLeave += OnDragLeave;
				listBox.DragOver += fceHxes1rJc;
				num = 2;
				break;
			case 3:
				listBoxItem.Drop -= OnDrop;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 4:
				if (listBoxItem == null)
				{
					return;
				}
				listBox = KUIQKFHDvnXGoCOabJCv.Y4PHDagtCgH<ListBox>(listBoxItem);
				if (flag)
				{
					listBoxItem.MouseMove += MY3HxsfYEhr;
					listBoxItem.Drop += OnDrop;
					listBoxItem.DragOver += OnDragOver;
					num = 6;
				}
				else
				{
					listBoxItem.MouseMove -= MY3HxsfYEhr;
					num = 3;
				}
				break;
			case 1:
				listBoxItem.DragLeave -= OnDragLeave;
				yOPuU7Dc2tPUYpiAkffE(listBox, new DragEventHandler(fceHxes1rJc));
				num = 5;
				break;
			default:
				listBoxItem.DragOver -= OnDragOver;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7bbe761a662b44b5ba6c0923e11b90ae != 0)
				{
					num = 1;
				}
				break;
			case 7:
				listBoxItem = P_0 as ListBoxItem;
				num = 3;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_11b8736b0585457b9538011988d6d2f9 != 0)
				{
					num = 4;
				}
				break;
			case 5:
				return;
			}
		}
	}

	private static void fceHxes1rJc(object P_0, DragEventArgs P_1)
	{
		ListBox listBox = P_0 as ListBox;
		Point position = P_1.GetPosition(listBox);
		int num = 2;
		double y = default(double);
		ScrollViewer scrollViewer = default(ScrollViewer);
		while (true)
		{
			switch (num)
			{
			case 1:
				if (y < 24.0)
				{
					YkXFpTDcHJ9igZmi5aMZ(scrollViewer, scrollViewer.VerticalOffset - 1.0);
					return;
				}
				if (!(y > listBox.ActualHeight - 24.0))
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
				{
					num = 0;
				}
				break;
			default:
				scrollViewer.ScrollToVerticalOffset(IBln00DcfOXXCNLCOxS2(scrollViewer) + 1.0);
				return;
			case 2:
				y = position.Y;
				scrollViewer = KUIQKFHDvnXGoCOabJCv.aklHDiAUQEV<ScrollViewer>(listBox);
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_57c2433b06714a1299d736aebe42caa2 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	private static void OnDragLeave(object sender, DragEventArgs e)
	{
		if (!(sender is ListBoxItem element))
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
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
			SetIsDragOver(element, value: false);
		}
	}

	private static void OnDragOver(object sender, DragEventArgs e)
	{
		if (sender is ListBoxItem element)
		{
			SetIsDragOver(element, value: true);
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0fb8c8dbf8424ce68f439b7b66291a33 == 0)
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

	private static void MY3HxsfYEhr(object P_0, MouseEventArgs P_1)
	{
		int num;
		if (!(P_0 is ListBoxItem listBoxItem))
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5b6218c32bbf4af5965485469fa12538 != 0)
			{
				num = 0;
			}
		}
		else
		{
			if (!vIfHxX3RLsl(listBoxItem))
			{
				return;
			}
			if (TsIeSlDc9IG4Gf5f00Xc(P_1) == MouseButtonState.Pressed)
			{
				DragDrop.DoDragDrop(listBoxItem, listBoxItem, DragDropEffects.All);
				return;
			}
			Mouse.SetCursor((Cursor)aYDkANDcnVi5EIeLZyjj());
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_52f1b40ebe094208bc85ded04f1baa0b == 0)
			{
				num = 0;
			}
		}
		switch (num)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	private static bool vIfHxX3RLsl(ListBoxItem P_0)
	{
		Point point = BbO77yDcGM6knrwoi5g9(P_0);
		FrameworkElement obj = P_0.InputHitTest(point) as FrameworkElement;
		return (string)((obj != null) ? Bg9pv4DcYLqiJZmbQe07(obj) : null) == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x2CBEEA31 ^ 0x2CBFCFD7);
	}

	private static void OnDrop(object sender, DragEventArgs e)
	{
		int num = 3;
		int num2 = num;
		IList list = default(IList);
		int num3 = default(int);
		int num4 = default(int);
		ListBoxItem listBoxItem2 = default(ListBoxItem);
		ListBoxItem listBoxItem = default(ListBoxItem);
		ItemsControl itemsControl = default(ItemsControl);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
			{
				object value = list[num3];
				list[num3] = ckCkjiDc42M3Wsaug4PC(list, num4);
				list[num4] = value;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9267d25a572643c4b072d1d18111abbd == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
			{
				listBoxItem2 = sender as ListBoxItem;
				ItemsControl itemsControl2 = KUIQKFHDvnXGoCOabJCv.Y4PHDagtCgH<ItemsControl>(listBoxItem);
				itemsControl = KUIQKFHDvnXGoCOabJCv.Y4PHDagtCgH<ItemsControl>(listBoxItem2);
				if (itemsControl2 != itemsControl)
				{
					return;
				}
				num4 = xdXCEADcBnBJY3ucBmAk(itemsControl.Items, x3bqagDcvhsu578rHBCh(listBoxItem));
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			case 1:
				num3 = ((CollectionView)QoXxmLDcaWVHUykg7aqP(itemsControl)).IndexOf(listBoxItem2.DataContext);
				if (num4 == num3)
				{
					return;
				}
				vF8fesDcieEubLIvjwNj(listBoxItem2, false);
				list = e42Z8jDclmSyqRHCepV7(itemsControl) as IList;
				num2 = 4;
				break;
			case 3:
				listBoxItem = e.Data.GetData(DZAX7aDcoWcg1DBLFC2J(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777890))) as ListBoxItem;
				num2 = 2;
				break;
			}
		}
	}

	public By6H9dHxS8AKO2J7o7ov()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static By6H9dHxS8AKO2J7o7ov()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				IsDragOverProperty = (DependencyProperty)yZPqCtDcNaaohkdnYXN2(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3300B255), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(r3ScfIDcbyJ8hmAm4JvP(33555365)), new PropertyMetadata(false));
				IsEnabledProperty = DependencyProperty.RegisterAttached((string)iBJZSiDckJF6UJo4n5MK(-530053095 ^ -530041087), Type.GetTypeFromHandle(r3ScfIDcbyJ8hmAm4JvP(16777221)), Type.GetTypeFromHandle(r3ScfIDcbyJ8hmAm4JvP(33555365)), new PropertyMetadata(false, nVIHxL3AeQa));
				return;
			case 1:
				wgkItKDcDRNGTHahmHHI();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool J4xyMnDXzx5yUO5Uelt1()
	{
		return G1u288DXuGQYiec0L70v == null;
	}

	internal static By6H9dHxS8AKO2J7o7ov VwPn9VDc0JNmKCDqFcAg()
	{
		return G1u288DXuGQYiec0L70v;
	}

	internal static void yOPuU7Dc2tPUYpiAkffE(object P_0, object P_1)
	{
		((UIElement)P_0).DragOver -= (DragEventHandler)P_1;
	}

	internal static void YkXFpTDcHJ9igZmi5aMZ(object P_0, double P_1)
	{
		((ScrollViewer)P_0).ScrollToVerticalOffset(P_1);
	}

	internal static double IBln00DcfOXXCNLCOxS2(object P_0)
	{
		return ((ScrollViewer)P_0).VerticalOffset;
	}

	internal static MouseButtonState TsIeSlDc9IG4Gf5f00Xc(object P_0)
	{
		return ((MouseEventArgs)P_0).LeftButton;
	}

	internal static object aYDkANDcnVi5EIeLZyjj()
	{
		return Cursors.Hand;
	}

	internal static Point BbO77yDcGM6knrwoi5g9(object P_0)
	{
		return Mouse.GetPosition((IInputElement)P_0);
	}

	internal static object Bg9pv4DcYLqiJZmbQe07(object P_0)
	{
		return ((FrameworkElement)P_0).Name;
	}

	internal static Type DZAX7aDcoWcg1DBLFC2J(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object x3bqagDcvhsu578rHBCh(object P_0)
	{
		return ((FrameworkElement)P_0).DataContext;
	}

	internal static int xdXCEADcBnBJY3ucBmAk(object P_0, object P_1)
	{
		return ((CollectionView)P_0).IndexOf(P_1);
	}

	internal static object QoXxmLDcaWVHUykg7aqP(object P_0)
	{
		return ((ItemsControl)P_0).Items;
	}

	internal static void vF8fesDcieEubLIvjwNj(object P_0, bool value)
	{
		SetIsDragOver((DependencyObject)P_0, value);
	}

	internal static object e42Z8jDclmSyqRHCepV7(object P_0)
	{
		return ((ItemsControl)P_0).ItemsSource;
	}

	internal static object ckCkjiDc42M3Wsaug4PC(object P_0, int P_1)
	{
		return ((IList)P_0)[P_1];
	}

	internal static void wgkItKDcDRNGTHahmHHI()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static RuntimeTypeHandle r3ScfIDcbyJ8hmAm4JvP(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object yZPqCtDcNaaohkdnYXN2(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.RegisterAttached((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static object iBJZSiDckJF6UJo4n5MK(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}
}
