using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Primitives;
using Beq7rVHb9tpwOWxquPXs;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace ClHOqKHxQLFfEREoMqlh;

public class WFAA0VHxEu22uoHrmQVS
{
	private static class IsNumbersOnly
	{
		private static IsNumbersOnly as9VTwNLWB5qaGKyngnS;

		public static void ynCnyembQ8j(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
		{
			if (!(P_0 is UIElement uIElement))
			{
				return;
			}
			int num = 2;
			object newValue = default(object);
			while (true)
			{
				switch (num)
				{
				case 3:
					return;
				default:
					uIElement.PreviewTextInput -= OOLHxg0Qufr;
					num = 3;
					break;
				case 2:
					newValue = P_1.NewValue;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_12e8a768a5674e7d88b4e5ccd4fb7295 != 0)
					{
						num = 1;
					}
					break;
				case 1:
					if (!(newValue is bool))
					{
						return;
					}
					if ((bool)newValue)
					{
						DBcnKCNLTBTfxJxykq4V(uIElement, new KeyEventHandler(I9xHxdb9bDI));
						uIElement.PreviewTextInput += OOLHxg0Qufr;
						return;
					}
					nMuvsYNLycGpHY84NGyl(uIElement, new KeyEventHandler(I9xHxdb9bDI));
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f3775e6a3cb04c0998106e46ff04d8ab != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		static IsNumbersOnly()
		{
			BI6yfKNLZvrOQmL6asIC();
		}

		internal static void DBcnKCNLTBTfxJxykq4V(object P_0, object P_1)
		{
			((UIElement)P_0).KeyDown += (KeyEventHandler)P_1;
		}

		internal static void nMuvsYNLycGpHY84NGyl(object P_0, object P_1)
		{
			((UIElement)P_0).KeyDown -= (KeyEventHandler)P_1;
		}

		internal static bool ziT4gsNLtUjNpQvu072A()
		{
			return as9VTwNLWB5qaGKyngnS == null;
		}

		internal static IsNumbersOnly e11GQLNLUcSODaD8MNqZ()
		{
			return as9VTwNLWB5qaGKyngnS;
		}

		internal static void BI6yfKNLZvrOQmL6asIC()
		{
			stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		}
	}

	public static readonly DependencyProperty IsNumbersOnlyProperty;

	public static readonly DependencyProperty IsNegativeAvailableProperty;

	public static readonly DependencyProperty IsDoubleAvailableProperty;

	private static WFAA0VHxEu22uoHrmQVS xEfUvEDc1pFr7vVgWmPr;

	private static void I9xHxdb9bDI(object P_0, KeyEventArgs P_1)
	{
		if (!(P_0 is UIElement element))
		{
			return;
		}
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				if (!GetIsDoubleAvailable(element))
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f6b8a9ae320a40f994b0db08d42c2a95 == 0)
					{
						num = 0;
					}
					break;
				}
				YvDS2EDcxLkNOy1VblMN(P_1);
				return;
			case 0:
				return;
			}
		}
	}

	private static void OOLHxg0Qufr(object P_0, TextCompositionEventArgs P_1)
	{
		int num = 5;
		int num2 = num;
		UIElement uIElement = default(UIElement);
		int num3 = default(int);
		string text = default(string);
		TextBox textBox = default(TextBox);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 7:
				P_1.Handled = true;
				return;
			case 4:
				if (!char.IsDigit(P_1.Text.Last()))
				{
					num2 = 3;
					break;
				}
				return;
			default:
				if (uIElement == null)
				{
					return;
				}
				num3 = 0;
				text = string.Empty;
				if (!(cZwEJTDce384VSLnbWvH(P_1) is EmbeddedTextBox embeddedTextBox))
				{
					textBox = P_1.OriginalSource as TextBox;
					if (textBox != null)
					{
						num2 = 8;
						break;
					}
					goto case 2;
				}
				num3 = QDpZ3mDcsSy7x3Y41FGN(embeddedTextBox);
				text = embeddedTextBox.Text;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				uIElement = P_0 as UIElement;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_a8990374f0e04177b45918e3dd7a2d4b == 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				if ((string)VBE0OuDcjSa2w6X6YxKP(P_1) == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6D18F862 ^ 0x6D18DC08))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 2:
				if (!WrjshCDccentncDkLsUS(uIElement))
				{
					num2 = 7;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 5:
				if (!oyj2W2DcL0dGNxNHBMt0(P_1.Text))
				{
					num2 = 4;
					break;
				}
				return;
			case 1:
				if (num3 == 0 && !text.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-842040449 ^ -842047723)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_426282f87bb443dbbfe9ea3327b81bb7 == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 7;
			case 8:
				num3 = textBox.CaretIndex;
				text = (string)v0b9x6DcX7wggb0KrnfG(textBox);
				goto case 2;
			}
		}
	}

	public static bool GetIsNumbersOnly(UIElement element)
	{
		return (bool)GsbElKDcEGM1hPXKc3FA(element, IsNumbersOnlyProperty);
	}

	public static void SetIsNumbersOnly(UIElement element, bool value)
	{
		lAEVSMDcQtx3vMy7hGtU(element, IsNumbersOnlyProperty, value);
	}

	public static bool GetIsNegativeAvailable(UIElement element)
	{
		return (bool)element.GetValue(IsNegativeAvailableProperty);
	}

	public static void SetIsNegativeAvailable(UIElement element, bool value)
	{
		element.SetValue(IsNegativeAvailableProperty, value);
	}

	public static bool GetIsDoubleAvailable(UIElement element)
	{
		return (bool)GsbElKDcEGM1hPXKc3FA(element, IsDoubleAvailableProperty);
	}

	public static void SetIsDoubleAvailable(UIElement element, bool value)
	{
		lAEVSMDcQtx3vMy7hGtU(element, IsDoubleAvailableProperty, value);
	}

	public WFAA0VHxEu22uoHrmQVS()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static WFAA0VHxEu22uoHrmQVS()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				IsNegativeAvailableProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-371631841 ^ -371687633), Type.GetTypeFromHandle(qepqETDcg5knBHXpypXN(16777221)), Type.GetTypeFromHandle(qepqETDcg5knBHXpypXN(33555366)), new UIPropertyMetadata(false));
				IsDoubleAvailableProperty = (DependencyProperty)tYngjlDcR9GbWevVE42i(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x3544E813 ^ 0x3545CE49), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555366)), new UIPropertyMetadata(true));
				return;
			case 1:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1b729872d4424497a28393432ab4c541 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
			IsNumbersOnlyProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x1EFE0A28 ^ 0x1EFF2C3A), KPKcPRDcd4rLKYdTY3HM(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(qepqETDcg5knBHXpypXN(33555366)), new UIPropertyMetadata(false, IsNumbersOnly.ynCnyembQ8j));
			num2 = 2;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1c0cedb54d2b44a7af3d63420e8a1767 == 0)
			{
				num2 = 0;
			}
		}
	}

	internal static void YvDS2EDcxLkNOy1VblMN(object P_0)
	{
		Q1ZfpCHbfg8xj4pZQvis.LX5HbneePbI((KeyEventArgs)P_0);
	}

	internal static bool pjVD2ODc56gNVwp7AmuZ()
	{
		return xEfUvEDc1pFr7vVgWmPr == null;
	}

	internal static WFAA0VHxEu22uoHrmQVS hjmbKPDcSTR69d0Dcv3L()
	{
		return xEfUvEDc1pFr7vVgWmPr;
	}

	internal static bool oyj2W2DcL0dGNxNHBMt0(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object cZwEJTDce384VSLnbWvH(object P_0)
	{
		return ((RoutedEventArgs)P_0).OriginalSource;
	}

	internal static int QDpZ3mDcsSy7x3Y41FGN(object P_0)
	{
		return ((TextBox)P_0).CaretIndex;
	}

	internal static object v0b9x6DcX7wggb0KrnfG(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static bool WrjshCDccentncDkLsUS(object P_0)
	{
		return GetIsNegativeAvailable((UIElement)P_0);
	}

	internal static object VBE0OuDcjSa2w6X6YxKP(object P_0)
	{
		return ((TextCompositionEventArgs)P_0).Text;
	}

	internal static object GsbElKDcEGM1hPXKc3FA(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void lAEVSMDcQtx3vMy7hGtU(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static Type KPKcPRDcd4rLKYdTY3HM(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static RuntimeTypeHandle qepqETDcg5knBHXpypXN(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}

	internal static object tYngjlDcR9GbWevVE42i(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.RegisterAttached((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}
}
