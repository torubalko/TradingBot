using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;

namespace hp6VfhHS1296vU2kgQEm;

public class uD5F25HSkYT1CDQSding : IMultiValueConverter
{
	private static uD5F25HSkYT1CDQSding iYg1BUDekcdiTJwgGJPo;

	public object Convert(object[] P_0, Type P_1, object P_2, CultureInfo P_3)
	{
		int num = 1;
		int num2 = num;
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (P_0.Length < 2)
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 != 0)
					{
						num2 = 0;
					}
					break;
				}
				IEnumerator<object> enumerator = P_0.Skip(1).GetEnumerator();
				try
				{
					while (fOvHicDeSAu6GtVRgRZW(enumerator))
					{
						if (enumerator.Current.Equals(P_0[0]))
						{
							continue;
						}
						int num3 = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 1:
								result = false;
								num3 = 0;
								if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a057f43d61f46eca6f419bc48c31d04 == 0)
								{
									num3 = 0;
								}
								break;
							}
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						J87LQpDexSDJ56mXDY1b(enumerator);
					}
				}
				return true;
			}
			default:
				return true;
			}
		}
	}

	public object[] ConvertBack(object P_0, Type[] P_1, object P_2, CultureInfo P_3)
	{
		return Array.Empty<object>();
	}

	public uD5F25HSkYT1CDQSding()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
	}

	static uD5F25HSkYT1CDQSding()
	{
		stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
	}

	internal static bool fOvHicDeSAu6GtVRgRZW(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void J87LQpDexSDJ56mXDY1b(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool I7LtauDe10XxmBaWAg8O()
	{
		return iYg1BUDekcdiTJwgGJPo == null;
	}

	internal static uD5F25HSkYT1CDQSding ikHIWKDe5rGMaNIUKxxm()
	{
		return iYg1BUDekcdiTJwgGJPo;
	}
}
