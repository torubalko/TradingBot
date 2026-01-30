using System.Globalization;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Windows.Controls.Primitives;
using TuAMtrl1Nd3XoZQQUXf0;

namespace Beq7rVHb9tpwOWxquPXs;

internal static class Q1ZfpCHbfg8xj4pZQvis
{
	internal static Q1ZfpCHbfg8xj4pZQvis scvhWbD5J8bXUj8qFIbt;

	public static void LX5HbneePbI(KeyEventArgs P_0)
	{
		if (!(Keyboard.FocusedElement is EmbeddedTextBox embeddedTextBox))
		{
			return;
		}
		int num;
		if (P_0.Key != Key.OemPeriod && P_0.Key != Key.OemComma)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0120;
		IL_0009:
		int num2 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			case 4:
				embeddedTextBox.Text = (string)xYRCJfDS2fhF94lZ77vN(ItwwTQD5z18NeIVZrXNW(embeddedTextBox), num2, text);
				embeddedTextBox.CaretIndex = num2 + 1;
				return;
			default:
				if (P_0.Key != Key.Decimal)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0aea3f4dc28f4bcb92a1f998dc5afbed == 0)
					{
						num = 3;
					}
					continue;
				}
				break;
			case 3:
				if (P_0.Key == Key.Oem2)
				{
					break;
				}
				return;
			case 2:
				P_0.Handled = true;
				num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7d3c6a8bf09f4ec887f577858231a719 != 0)
				{
					num = 1;
				}
				continue;
			case 1:
				if (((string)ItwwTQD5z18NeIVZrXNW(embeddedTextBox)).Contains(text))
				{
					return;
				}
				num2 = qgKDkeDS0FpfQW6Xupql(embeddedTextBox);
				num = 4;
				continue;
			}
			break;
		}
		goto IL_0120;
		IL_0120:
		KeyConverter keyConverter = new KeyConverter();
		text = (string)yJFsuID5pKTs5T4gZ8tA(CultureInfo.CurrentCulture.NumberFormat);
		if (nWw4y3D5uKP7sNMWYTaO(keyConverter.ConvertToString(P_0.Key), text))
		{
			int num3 = 2;
			num = num3;
			goto IL_0009;
		}
	}

	static Q1ZfpCHbfg8xj4pZQvis()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object yJFsuID5pKTs5T4gZ8tA(object P_0)
	{
		return ((NumberFormatInfo)P_0).CurrencyDecimalSeparator;
	}

	internal static bool nWw4y3D5uKP7sNMWYTaO(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object ItwwTQD5z18NeIVZrXNW(object P_0)
	{
		return ((TextBox)P_0).Text;
	}

	internal static int qgKDkeDS0FpfQW6Xupql(object P_0)
	{
		return ((TextBox)P_0).CaretIndex;
	}

	internal static object xYRCJfDS2fhF94lZ77vN(object P_0, int P_1, object P_2)
	{
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	internal static bool jvoI5uD5FNFK001Boepw()
	{
		return scvhWbD5J8bXUj8qFIbt == null;
	}

	internal static Q1ZfpCHbfg8xj4pZQvis SQ3SWGD534UWqPhhoqWo()
	{
		return scvhWbD5J8bXUj8qFIbt;
	}
}
