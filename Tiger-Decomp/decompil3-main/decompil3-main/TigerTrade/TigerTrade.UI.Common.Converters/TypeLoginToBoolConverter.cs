using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using VJ6kkK2rEUqBQPITYLM8;

namespace TigerTrade.UI.Common.Converters;

public class TypeLoginToBoolConverter : IValueConverter
{
	internal static TypeLoginToBoolConverter tkA0TNDLr2D5RKqtrcRF;

	public object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		object result = default(object);
		try
		{
			if (P_0 is y5IHgU2rj0xU3aAfpAcM y5IHgU2rj0xU3aAfpAcM && y5IHgU2rj0xU3aAfpAcM == y5IHgU2rj0xU3aAfpAcM.ecm2rQxSO5q)
			{
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_34c8a548a4724373aa05c97fa43f690a == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						result = Visibility.Visible;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
						{
							num = 0;
						}
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			else
			{
				result = Visibility.Collapsed;
			}
		}
		catch (Exception)
		{
			result = Visibility.Collapsed;
		}
		return result;
	}

	public object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		throw new NotImplementedException();
	}

	public TypeLoginToBoolConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static TypeLoginToBoolConverter()
	{
		RAfwn2DLhqd1Xf7Z0KKj();
	}

	internal static bool XPO5aWDLKMwtA9Z5Sblc()
	{
		return tkA0TNDLr2D5RKqtrcRF == null;
	}

	internal static TypeLoginToBoolConverter DP39WADLmRWl4rMv3nMw()
	{
		return tkA0TNDLr2D5RKqtrcRF;
	}

	internal static void RAfwn2DLhqd1Xf7Z0KKj()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}
}
