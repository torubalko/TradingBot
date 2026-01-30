using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class YdV
{
	internal static YdV pSE;

	public static string MD8(short? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> eDr(string P_0, CultureInfo P_1)
	{
		P_0 = jDv(P_0, P_1);
		List<IPart> list = new List<IPart>();
		TW tW = new TW();
		tW.Format = P_0;
		list.Add(tW);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string jDv(string P_0, CultureInfo P_1)
	{
		if (P_1 == null)
		{
			P_1 = CultureInfo.CurrentCulture;
			int num = 0;
			if (!IS3())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		if (P_0 != null)
		{
			P_0 = P_0.Trim();
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = QdM.AR8(1942);
		}
		return P_0;
	}

	public static short EDp(short P_0, int P_1, short? P_2, short? P_3, SpinWrapping P_4)
	{
		short num = P_2 ?? short.MinValue;
		short num2 = P_3 ?? short.MaxValue;
		try
		{
			P_0 = ((P_1 >= 0) ? ((P_0 <= num2 - P_1) ? zDZ((short)(P_0 + P_1), num, num2) : ((P_0 < num2 || P_4 == SpinWrapping.NoWrap) ? num2 : num)) : ((P_0 >= num - P_1) ? zDZ((short)(P_0 + P_1), num, num2) : ((P_0 > num || P_4 == SpinWrapping.NoWrap) ? num : num2)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0) ? num2 : num);
		}
		return P_0;
	}

	public static short xDW(short P_0, short P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static short xDi(short P_0, short P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string JDn()
	{
		char c = ',';
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		if (!string.IsNullOrEmpty(numberDecimalSeparator) && c == numberDecimalSeparator[0])
		{
			c = ';';
		}
		return c + QdM.AR8(23766);
	}

	public static short zDZ(short P_0, short P_1, short P_2)
	{
		return xDW(P_1, xDi(P_0, P_2));
	}

	public static bool pDt(string P_0, string P_1, out short? P_2)
	{
		P_2 = null;
		bool flag;
		int num;
		short result = default(short);
		if (!string.IsNullOrEmpty(P_0))
		{
			if (!P_1.StartsWith(QdM.AR8(20000), StringComparison.OrdinalIgnoreCase))
			{
				flag = P_1.StartsWith(QdM.AR8(23296), StringComparison.OrdinalIgnoreCase);
				num = 1;
				if (!IS3())
				{
					goto IL_0005;
				}
				goto IL_0009;
			}
			if (short.TryParse(P_0, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			goto IL_012a;
		}
		return true;
		IL_013c:
		if (!short.TryParse(P_0, NumberStyles.Currency, CultureInfo.CurrentCulture, out result))
		{
			return false;
		}
		int num2 = 4;
		goto IL_0005;
		IL_012a:
		return false;
		IL_0005:
		num = num2;
		goto IL_0009;
		IL_0009:
		string[] array = default(string[]);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 1:
				goto IL_01af;
			case 3:
				goto IL_0214;
			case 4:
				P_2 = result;
				return true;
			default:
				goto IL_02d6;
			}
			break;
			IL_02d6:
			if (!short.TryParse(array[1], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
			{
				goto IL_0194;
			}
			goto IL_0288;
			IL_01af:
			if (!flag)
			{
				array = wdv.nGG(P_0, P_1);
				if (string.IsNullOrEmpty(array[1]))
				{
					goto IL_0194;
				}
				if (!short.TryParse(array[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result))
				{
					num = 0;
					if (IS3())
					{
						continue;
					}
					goto IL_0005;
				}
				goto IL_0288;
			}
			goto IL_013c;
			IL_0288:
			short value = (short)(-Math.Abs(result));
			string text = MD8(value, P_1);
			if (P_0 == text)
			{
				P_2 = value;
				return true;
			}
			goto IL_0194;
			IL_0214:
			return false;
			IL_0194:
			if (short.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || short.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			goto IL_0214;
		}
		goto IL_012a;
	}

	internal static bool IS3()
	{
		return pSE == null;
	}

	internal static YdV wSb()
	{
		return pSE;
	}
}
