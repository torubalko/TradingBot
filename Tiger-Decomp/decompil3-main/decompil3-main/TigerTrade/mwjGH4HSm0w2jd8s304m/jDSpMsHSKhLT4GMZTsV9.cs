using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using aEpmU09nz6MEoNmc0pGJ;
using bqeVc6Hkcwja5r4ba3lC;
using ECOEgqlSad8NUJZ2Dr9n;
using TigerTrade.Config.Common;
using TuAMtrl1Nd3XoZQQUXf0;

namespace mwjGH4HSm0w2jd8s304m;

internal sealed class jDSpMsHSKhLT4GMZTsV9 : IMultiValueConverter
{
	private static readonly SolidColorBrush F33HSh09tWF;

	private static readonly SolidColorBrush nieHSwtZjEi;

	private static readonly SolidColorBrush VxuHS7XvMUh;

	private static readonly SolidColorBrush RblHS8TXSXL;

	internal static jDSpMsHSKhLT4GMZTsV9 OHWpNHDs80gIU3Pt6Gux;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		SUjI66HkXtx9pE409e96 sUjI66HkXtx9pE409e = P_0[1] as SUjI66HkXtx9pE409e96;
		string text = P_2 as string;
		string text2 = "";
		if (sUjI66HkXtx9pE409e != null && text != null)
		{
			goto IL_01b4;
		}
		goto IL_01c4;
		IL_01b4:
		text2 = (string)PcywAQDsJoUZ4wEjVKyI(sUjI66HkXtx9pE409e, text);
		goto IL_01c4;
		IL_01c4:
		bool flag = j18iDj9nukSCmEyZs5lH.Settings.AppTheme == AppTheme.MetroLight;
		int num = 4;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!flag)
				{
					return F33HSh09tWF;
				}
				return fe16DTDs31IAFsUuv4Pv();
			case 4:
				if (!(text2 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(--855742383 ^ 0x3301F1E3)))
				{
					num = 5;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 3;
			case 2:
				return VxuHS7XvMUh;
			case 5:
				if (!(text2 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-225822163 ^ -225813433)))
				{
					if (text2 == (string)qkVa3HDsFXSh2CWb51d5(0xC1DDB3B ^ 0xC1DBD61))
					{
						if (flag)
						{
							return Brushes.WhiteSmoke;
						}
						num = 2;
					}
					else
					{
						num = 7;
					}
					continue;
				}
				if (!flag)
				{
					return nieHSwtZjEi;
				}
				return Brushes.LightPink;
			case 1:
				return RblHS8TXSXL;
			case 7:
				if (!(text2 == stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-44540535 ^ -44549195)))
				{
					if (!flag)
					{
						int num2 = 6;
						num = num2;
						continue;
					}
					return Brushes.Black;
				}
				if (!flag)
				{
					num = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 != 0)
					{
						num = 0;
					}
					continue;
				}
				return Brushes.Khaki;
			case 6:
				return weyw1IDsprq8pcoC2caI();
			}
			break;
		}
		goto IL_01b4;
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return null;
	}

	public jDSpMsHSKhLT4GMZTsV9()
	{
		WsSmOJDsuo8pIVeHpqn3();
		base._002Ector();
	}

	static jDSpMsHSKhLT4GMZTsV9()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8b8f48487ce54157a86b0385feea16a6 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				VxuHS7XvMUh = new SolidColorBrush(Color.FromArgb(90, 119, 136, 153));
				RblHS8TXSXL = new SolidColorBrush(Color.FromArgb(160, byte.MaxValue, 165, 0));
				return;
			case 1:
				bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
				F33HSh09tWF = new SolidColorBrush(Color.FromArgb(90, 36, 194, 203));
				nieHSwtZjEi = new SolidColorBrush(Color.FromArgb(90, 219, 7, 61));
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f8c53e9716bd4846babfdefcdb92a575 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object PcywAQDsJoUZ4wEjVKyI(object P_0, object P_1)
	{
		return ((SUjI66HkXtx9pE409e96)P_0).qgqlfxHoAfJ((string)P_1);
	}

	internal static object qkVa3HDsFXSh2CWb51d5(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object fe16DTDs31IAFsUuv4Pv()
	{
		return Brushes.LightGreen;
	}

	internal static object weyw1IDsprq8pcoC2caI()
	{
		return Brushes.White;
	}

	internal static bool gZucAMDsAmi2lgkHXZNJ()
	{
		return OHWpNHDs80gIU3Pt6Gux == null;
	}

	internal static jDSpMsHSKhLT4GMZTsV9 HM9VQfDsPnrbY5am2IxR()
	{
		return OHWpNHDs80gIU3Pt6Gux;
	}

	internal static void WsSmOJDsuo8pIVeHpqn3()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}
}
