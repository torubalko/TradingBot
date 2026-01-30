using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace yVClshHSpdJxIhgt4ZEe;

internal sealed class nITuJHHS30nqrsIO2mlC : IMultiValueConverter
{
	internal static nITuJHHS30nqrsIO2mlC cfNyvxDXiRRuEHLB5Lks;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		object result = default(object);
		try
		{
			string text = P_0[1].GetType().ToString();
			int num;
			if (!xH37NjDXbq2JbYpic84b(text, QJyMS8DXDyR3sj4tRYTt(-5977659 ^ -5903209)))
			{
				num = 3;
				goto IL_0021;
			}
			goto IL_00d5;
			IL_00d5:
			result = ((!(bool)P_0[0]) ? Visibility.Collapsed : Visibility.Visible);
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1a625a5fe3334df88082832236dff5be == 0)
			{
				num = 1;
			}
			goto IL_0021;
			IL_0021:
			while (true)
			{
				switch (num)
				{
				default:
					if (xH37NjDXbq2JbYpic84b(text, QJyMS8DXDyR3sj4tRYTt(0x68DEE0F ^ 0x68DE0E7)))
					{
						break;
					}
					result = Visibility.Collapsed;
					num = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
					{
						num = 2;
					}
					continue;
				case 1:
					goto end_IL_0021;
				case 3:
					if (!text.Contains(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x20B584D2 ^ 0x20B597F2)))
					{
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				case 2:
					goto end_IL_0021;
				}
				goto IL_00d5;
				continue;
				end_IL_0021:
				break;
			}
		}
		catch (Exception)
		{
			result = Visibility.Collapsed;
		}
		return result;
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public nITuJHHS30nqrsIO2mlC()
	{
		vtkrMVDXNri1jX8gJoHk();
		base._002Ector();
	}

	static nITuJHHS30nqrsIO2mlC()
	{
		ymYioqDXkXH1v5MX3E1a();
	}

	internal static object QJyMS8DXDyR3sj4tRYTt(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool xH37NjDXbq2JbYpic84b(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool UAQf3iDXllIUZ45T3sCw()
	{
		return cfNyvxDXiRRuEHLB5Lks == null;
	}

	internal static nITuJHHS30nqrsIO2mlC gTwxvGDX4gcygwusawSA()
	{
		return cfNyvxDXiRRuEHLB5Lks;
	}

	internal static void vtkrMVDXNri1jX8gJoHk()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static void ymYioqDXkXH1v5MX3E1a()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
