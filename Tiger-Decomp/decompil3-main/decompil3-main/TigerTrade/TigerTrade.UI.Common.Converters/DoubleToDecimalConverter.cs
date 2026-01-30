using System;
using System.Globalization;
using ECOEgqlSad8NUJZ2Dr9n;
using MyaWdtHSy6ythDGO9eDx;
using TuAMtrl1Nd3XoZQQUXf0;

namespace TigerTrade.UI.Common.Converters;

internal sealed class DoubleToDecimalConverter : wqu3BaHSTIpqeB2qWhad<DoubleToDecimalConverter>
{
	private static DoubleToDecimalConverter prswy7Ds0VOqD4UGD86X;

	public override object Convert(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		object result = default(object);
		try
		{
			result = System.Convert.ToDecimal(P_0).ToString((IFormatProvider)d7LkF6DsfNh4TNTlQKI9());
		}
		catch (OverflowException)
		{
			result = T1N4iiDs9m3jG05j0Mjq(0x28BBDCA ^ 0x28B80DC);
		}
		catch
		{
			if (P_0 is double num)
			{
				int num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_68b6172210394c1b93f49e43376ff3af != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						result = num.ToString(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x50C1C840 ^ 0x50C0ED6A));
						num2 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ff2c70a81f2141b98b88fc10875a3726 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
			}
			else
			{
				result = string.Empty;
			}
		}
		return result;
	}

	public override object ConvertBack(object P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		return F442jVDsnP8sejx6Ns7Z(P_0);
	}

	public DoubleToDecimalConverter()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static DoubleToDecimalConverter()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static object d7LkF6DsfNh4TNTlQKI9()
	{
		return CultureInfo.InvariantCulture;
	}

	internal static object T1N4iiDs9m3jG05j0Mjq(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static bool TpofPyDs2PAJtsVB3lub()
	{
		return prswy7Ds0VOqD4UGD86X == null;
	}

	internal static DoubleToDecimalConverter alF3ftDsHbApF8Oat3Uy()
	{
		return prswy7Ds0VOqD4UGD86X;
	}

	internal static double F442jVDsnP8sejx6Ns7Z(object P_0)
	{
		return System.Convert.ToDouble(P_0);
	}
}
