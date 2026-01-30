using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using aEpmU09nz6MEoNmc0pGJ;
using aeXChk9vAhkf7Zm8SpOk;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace ghcHrkHxMgYSqbwowjbq;

public class WKRFk6Hx6YcvPJhcQ2t9
{
	private static class IsIsinCharsOnly
	{
		private static readonly Dictionary<Key, string> tXQnycOw1H2;

		internal static IsIsinCharsOnly qU5yVHNLVLehQSQmbymf;

		public static void OXtnysrcJMT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
		{
			if (!(P_0 is TextBox textBox))
			{
				return;
			}
			object newValue = P_1.NewValue;
			if (!(newValue is bool))
			{
				return;
			}
			int num;
			if ((bool)newValue)
			{
				textBox.KeyDown += pZFnyXr56I3;
				num = 3;
			}
			else
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8692846774e94af58ff2b2b243743e02 == 0)
				{
					num = 0;
				}
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					return;
				case 1:
					return;
				case 3:
					return;
				}
				textBox.KeyDown -= pZFnyXr56I3;
				num = 2;
			}
		}

		private static void pZFnyXr56I3(object P_0, KeyEventArgs P_1)
		{
			if (!Noi3m4NLKNOV0QZB9WqX(j18iDj9nukSCmEyZs5lH.Settings))
			{
				return;
			}
			TextBox textBox = P_0 as TextBox;
			string value = default(string);
			if (textBox != null)
			{
				if (!tXQnycOw1H2.TryGetValue(P_1.Key, out value))
				{
					goto IL_0033;
				}
				goto IL_00af;
			}
			int num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
			{
				num = 1;
			}
			goto IL_0009;
			IL_0009:
			Key key = default(Key);
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 4:
					break;
				default:
					goto IL_0079;
				case 3:
					return;
				case 1:
					return;
				case 6:
					key = P_1.Key;
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num = 7;
					}
					continue;
				case 5:
					goto IL_01bd;
				case 7:
					goto IL_01ce;
				case 2:
					textBox.CaretIndex = num2 + 1;
					num = 5;
					continue;
				}
				break;
				IL_01ce:
				value = key.ToString();
				goto IL_00af;
				IL_0079:
				if (ouNyDINLmpxJb9IcSkGu(P_1) <= Key.Z)
				{
					num = 4;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dbdafa2a3c4c4a799fde97744d4aedd0 != 0)
					{
						num = 6;
					}
					continue;
				}
				goto IL_00af;
			}
			goto IL_0033;
			IL_0033:
			if (P_1.Key >= Key.A)
			{
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5e7b68e9e95482ab88a9b839c4d448c == 0)
				{
					num = 0;
				}
				goto IL_0009;
			}
			goto IL_00af;
			IL_00af:
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			if (!string.IsNullOrEmpty(textBox.SelectedText))
			{
				textBox.SelectedText = value;
				textBox.SelectionLength = 0;
				textBox.CaretIndex += value.Length;
				goto IL_01bd;
			}
			num2 = S2dvUSNLhSgUpxJKDaRE(textBox);
			textBox.Text = textBox.Text.Insert(S2dvUSNLhSgUpxJKDaRE(textBox), value);
			num = 2;
			goto IL_0009;
			IL_01bd:
			P_1.Handled = true;
			num = 3;
			goto IL_0009;
		}

		static IsIsinCharsOnly()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
					tXQnycOw1H2 = new Dictionary<Key, string>
					{
						{
							Key.Oem2,
							stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1841489831 ^ -1841370497)
						},
						{
							Key.OemPeriod,
							stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--134855371 ^ 0x8099323)
						},
						{
							Key.OemMinus,
							(string)CjfEuxNLwkiKGqyqAVfZ(-1192989954 ^ -1192997228)
						}
					};
					return;
				case 1:
					stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static bool r7DWvCNLCCNI4Qyylcd8()
		{
			return qU5yVHNLVLehQSQmbymf == null;
		}

		internal static IsIsinCharsOnly HsdiE1NLrdhyVd0PbQ6m()
		{
			return qU5yVHNLVLehQSQmbymf;
		}

		internal static bool Noi3m4NLKNOV0QZB9WqX(object P_0)
		{
			return ((MhMDPU9v8rkigy1ao0Th)P_0).IgnoreKeyboardLayout;
		}

		internal static Key ouNyDINLmpxJb9IcSkGu(object P_0)
		{
			return ((KeyEventArgs)P_0).Key;
		}

		internal static int S2dvUSNLhSgUpxJKDaRE(object P_0)
		{
			return ((TextBox)P_0).CaretIndex;
		}

		internal static object CjfEuxNLwkiKGqyqAVfZ(int P_0)
		{
			return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
		}
	}

	public static readonly DependencyProperty IsIsinCharsOnlyProperty;

	private static WKRFk6Hx6YcvPJhcQ2t9 CGq2c8Dc6BBKdoFiUuC3;

	public static bool GetIsIsinCharsOnly(TextBox textBox)
	{
		return (bool)XpTg6uDcqERe3Z7TimUx(textBox, IsIsinCharsOnlyProperty);
	}

	public static void SetIsIsinCharsOnly(TextBox textBox, bool value)
	{
		textBox.SetValue(IsIsinCharsOnlyProperty, value);
	}

	public WKRFk6Hx6YcvPJhcQ2t9()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static WKRFk6Hx6YcvPJhcQ2t9()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		IsIsinCharsOnlyProperty = DependencyProperty.RegisterAttached(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x741B85CB ^ 0x741AA34B), Type.GetTypeFromHandle(UD7XlWDcIb70P1C2WxK5(16777221)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555368)), new UIPropertyMetadata(false, IsIsinCharsOnly.OXtnysrcJMT));
	}

	internal static object XpTg6uDcqERe3Z7TimUx(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static bool D92Iy6DcM14dNnG8CyPk()
	{
		return CGq2c8Dc6BBKdoFiUuC3 == null;
	}

	internal static WKRFk6Hx6YcvPJhcQ2t9 sNyvtwDcO9ho2B8rSWXP()
	{
		return CGq2c8Dc6BBKdoFiUuC3;
	}

	internal static RuntimeTypeHandle UD7XlWDcIb70P1C2WxK5(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
