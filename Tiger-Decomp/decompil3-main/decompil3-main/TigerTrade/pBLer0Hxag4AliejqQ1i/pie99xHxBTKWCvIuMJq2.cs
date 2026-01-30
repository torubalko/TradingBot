using System;
using System.Windows;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Media;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace pBLer0Hxag4AliejqQ1i;

public class pie99xHxBTKWCvIuMJq2
{
	public static DependencyProperty IsImmediateFormatProperty;

	internal static pie99xHxBTKWCvIuMJq2 OHi9bZDXU7yPWV008HGK;

	public static bool GetIsImmediateFormat(UIElement element)
	{
		return (bool)element.GetValue(IsImmediateFormatProperty);
	}

	public static void SetIsImmediateFormat(UIElement element, bool value)
	{
		element.SetValue(IsImmediateFormatProperty, value);
	}

	public static void oAbHxiTnPrk(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		object newValue = P_1.NewValue;
		if (!(newValue is bool))
		{
			return;
		}
		int num = 8;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b48af76ce0b4c779ac34c27953eddda == 0)
		{
			num = 9;
		}
		Int32EditBox int32EditBox = default(Int32EditBox);
		bool flag = default(bool);
		DoubleEditBox doubleEditBox = default(DoubleEditBox);
		Int64EditBox int64EditBox = default(Int64EditBox);
		while (true)
		{
			switch (num)
			{
			case 5:
				l1XEm6DXVx2Tm8EGU3XG(int32EditBox, new RoutedEventHandler(dUcHx41dhbi));
				return;
			case 7:
				if (flag)
				{
					int32EditBox.ValueChanged += WHFHxb1RfEC;
					int32EditBox.Unloaded += dUcHx41dhbi;
					return;
				}
				r9tHC7DXZv2qZKdgKWsn(int32EditBox, new EventHandler(WHFHxb1RfEC));
				num = 5;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d9af442440454effa9efd8da8e33ec96 == 0)
				{
					num = 4;
				}
				break;
			default:
				l1XEm6DXVx2Tm8EGU3XG(doubleEditBox, new RoutedEventHandler(ltxHxlc8XqO));
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num = 0;
				}
				break;
			case 9:
				flag = (bool)newValue;
				num = 10;
				break;
			case 6:
				aFrrtJDXrMBZCAo5ScIe(doubleEditBox, new RoutedEventHandler(ltxHxlc8XqO));
				return;
			case 1:
				return;
			case 2:
				if (doubleEditBox == null)
				{
					return;
				}
				if (!flag)
				{
					doubleEditBox.ValueChanged -= WHFHxb1RfEC;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 == 0)
					{
						num = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				doubleEditBox.ValueChanged += WHFHxb1RfEC;
				num = 6;
				break;
			case 10:
				int32EditBox = P_0 as Int32EditBox;
				if (int32EditBox != null)
				{
					int num2 = 7;
					num = num2;
					break;
				}
				int64EditBox = P_0 as Int64EditBox;
				if (int64EditBox == null)
				{
					doubleEditBox = P_0 as DoubleEditBox;
					num = 2;
					break;
				}
				if (!flag)
				{
					UrnyIODXCuKV6gu0NwFd(int64EditBox, new EventHandler(WHFHxb1RfEC));
					num = 3;
					break;
				}
				num = 8;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be != 0)
				{
					num = 0;
				}
				break;
			case 3:
				int64EditBox.Unloaded -= nOcHxDGe9tM;
				return;
			case 8:
				int64EditBox.ValueChanged += WHFHxb1RfEC;
				int64EditBox.Unloaded += nOcHxDGe9tM;
				return;
			}
		}
	}

	private static void ltxHxlc8XqO(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		DoubleEditBox doubleEditBox = default(DoubleEditBox);
		while (true)
		{
			switch (num2)
			{
			case 1:
				doubleEditBox = (DoubleEditBox)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				doubleEditBox.ValueChanged -= WHFHxb1RfEC;
				doubleEditBox.Unloaded -= ltxHxlc8XqO;
				return;
			}
			if (doubleEditBox.IsLoaded)
			{
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8ebd61b38044e13aca9bf7790883fb0 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			return;
		}
	}

	private static void dUcHx41dhbi(object P_0, RoutedEventArgs P_1)
	{
		int num = 1;
		int num2 = num;
		Int32EditBox int32EditBox = default(Int32EditBox);
		while (true)
		{
			switch (num2)
			{
			case 1:
				int32EditBox = (Int32EditBox)P_0;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1db4437ae4614880b2ad46efdc78cb73 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (int32EditBox.IsLoaded)
				{
					r9tHC7DXZv2qZKdgKWsn(int32EditBox, new EventHandler(WHFHxb1RfEC));
					l1XEm6DXVx2Tm8EGU3XG(int32EditBox, new RoutedEventHandler(dUcHx41dhbi));
				}
				return;
			}
		}
	}

	private static void nOcHxDGe9tM(object P_0, RoutedEventArgs P_1)
	{
		Int64EditBox int64EditBox = (Int64EditBox)P_0;
		if (int64EditBox.IsLoaded)
		{
			int64EditBox.ValueChanged -= WHFHxb1RfEC;
			l1XEm6DXVx2Tm8EGU3XG(int64EditBox, new RoutedEventHandler(dUcHx41dhbi));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_03c20a54a7dc45f8a5130d4984fa4aea != 0)
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

	private static void WHFHxb1RfEC(object P_0, EventArgs P_1)
	{
		if (!fkuHxNHVkek<int?>(P_0) && !fkuHxNHVkek<long?>(P_0))
		{
			fkuHxNHVkek<double?>(P_0);
		}
	}

	private static bool fkuHxNHVkek<SsJucGliXw3hu3D0fSCY>(object P_0)
	{
		if (!(P_0 is PartEditBoxBase<SsJucGliXw3hu3D0fSCY> partEditBoxBase))
		{
			return false;
		}
		EmbeddedTextBox descendant = VisualTreeHelperExtended.GetDescendant<EmbeddedTextBox>(partEditBoxBase, 0);
		if (descendant == null)
		{
			return false;
		}
		string text = descendant.Text;
		partEditBoxBase.Commit();
		string text2 = descendant.Text;
		if (text != text2)
		{
			int num = (text2?.Length ?? 0) - (text?.Length ?? 0);
			if (num > 0)
			{
				descendant.SelectionStart += num;
			}
		}
		return true;
	}

	public pie99xHxBTKWCvIuMJq2()
	{
		Oh96mGDXKqUy563Ewd4E();
		base._002Ector();
	}

	static pie99xHxBTKWCvIuMJq2()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Oh96mGDXKqUy563Ewd4E();
				IsImmediateFormatProperty = DependencyProperty.RegisterAttached((string)IPvoHODXhwTdy7k5CvsF(-225822163 ^ -225763423), beBHVDDXw83s85iEQ3Iy(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), beBHVDDXw83s85iEQ3Iy(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555363)), new UIPropertyMetadata(false, oAbHxiTnPrk));
				return;
			case 1:
				jdj9cPDXmjpgcGpZtfUS();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a849a254fa6841d5989e377890b7578f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool hpdf0xDXTuHKHCQnyMyO()
	{
		return OHi9bZDXU7yPWV008HGK == null;
	}

	internal static pie99xHxBTKWCvIuMJq2 JIpl6jDXyUfJ99Jw8DDs()
	{
		return OHi9bZDXU7yPWV008HGK;
	}

	internal static void r9tHC7DXZv2qZKdgKWsn(object P_0, object P_1)
	{
		((Int32EditBox)P_0).ValueChanged -= (EventHandler)P_1;
	}

	internal static void l1XEm6DXVx2Tm8EGU3XG(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Unloaded -= (RoutedEventHandler)P_1;
	}

	internal static void UrnyIODXCuKV6gu0NwFd(object P_0, object P_1)
	{
		((Int64EditBox)P_0).ValueChanged -= (EventHandler)P_1;
	}

	internal static void aFrrtJDXrMBZCAo5ScIe(object P_0, object P_1)
	{
		((FrameworkElement)P_0).Unloaded += (RoutedEventHandler)P_1;
	}

	internal static void Oh96mGDXKqUy563Ewd4E()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void jdj9cPDXmjpgcGpZtfUS()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object IPvoHODXhwTdy7k5CvsF(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static Type beBHVDDXw83s85iEQ3Iy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
