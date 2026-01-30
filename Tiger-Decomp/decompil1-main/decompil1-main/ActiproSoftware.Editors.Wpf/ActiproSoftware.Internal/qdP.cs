using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class qdP
{
	private static qdP bS5;

	public static string SDl(double? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> tDX(string P_0, CultureInfo P_1)
	{
		P_0 = uD0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		yU yU2 = new yU();
		yU2.Format = P_0;
		list.Add(yU2);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static int TDx(double P_0)
	{
		int i;
		for (i = 0; i < 15 && Math.Round(P_0, i, MidpointRounding.AwayFromZero) != P_0; i++)
		{
		}
		return i;
	}

	public static string uD0(string P_0, CultureInfo P_1)
	{
		if (P_1 == null)
		{
			P_1 = CultureInfo.CurrentCulture;
		}
		if (P_0 != null)
		{
			P_0 = P_0.Trim();
		}
		if (string.IsNullOrEmpty(P_0))
		{
			P_0 = QdM.AR8(2648);
		}
		return P_0;
	}

	public static double wDY(double P_0, double P_1, double? P_2, double? P_3, SpinWrapping P_4, int? P_5)
	{
		double num = P_2 ?? double.MinValue;
		double num2 = P_3 ?? double.MaxValue;
		if (double.IsNaN(P_0))
		{
			return jDO(0.0, num, num2, P_5);
		}
		if (double.IsNegativeInfinity(P_0))
		{
			return num;
		}
		if (double.IsPositiveInfinity(P_0))
		{
			return num2;
		}
		try
		{
			P_0 = ((P_1 >= 0.0) ? ((!(P_0 > num2 - P_1)) ? jDO(Math.Round(P_0, TDx(P_1), MidpointRounding.AwayFromZero) + P_1, num, num2, P_5) : ((P_0 < num2 || P_4 == SpinWrapping.NoWrap) ? num2 : num)) : ((!(P_0 < num - P_1)) ? jDO(Math.Round(P_0, TDx(P_1), MidpointRounding.AwayFromZero) + P_1, num, num2, P_5) : ((P_0 > num || P_4 == SpinWrapping.NoWrap) ? num : num2)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0.0) ? num2 : num);
		}
		return P_0;
	}

	public static double tDg(double P_0, double P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static double xDo(double P_0, double P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string GDb()
	{
		return cdY.zDN();
	}

	public static double jDO(double P_0, double P_1, double P_2, int? P_3)
	{
		double num = tDg(P_1, xDo(P_0, P_2));
		if (P_3.HasValue && P_3.Value >= 0)
		{
			return Math.Round(num, Math.Min(15, P_3.Value), MidpointRounding.AwayFromZero);
		}
		return num;
	}

	public static double JDT(double P_0, double P_1, double P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		if (double.IsNaN(P_0) && P_4)
		{
			return P_0;
		}
		if (double.IsNegativeInfinity(P_0) && P_5)
		{
			return P_0;
		}
		if (double.IsPositiveInfinity(P_0) && P_6)
		{
			return P_0;
		}
		return jDO(P_0, P_1, P_2, P_3);
	}

	public static bool DDI(string P_0, string P_1, out double? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		bool flag = P_1?.StartsWith(QdM.AR8(16712), StringComparison.OrdinalIgnoreCase) ?? false;
		if (flag)
		{
			string percentSymbol = CultureInfo.CurrentCulture.NumberFormat.PercentSymbol;
			if (!string.IsNullOrEmpty(percentSymbol) && P_0.Contains(percentSymbol))
			{
				P_0 = P_0.Replace(percentSymbol, string.Empty);
			}
		}
		string[] array = wdv.nGG(P_0, P_1);
		if (!string.IsNullOrEmpty(array[1]) && (double.TryParse(array[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out var result) || double.TryParse(array[1], NumberStyles.Any, CultureInfo.CurrentCulture, out result)))
		{
			double num = 0.0 - Math.Abs(result);
			string text = SDl(num, P_1);
			if (P_0 == text)
			{
				P_2 = num / (flag ? 100.0 : 1.0);
				return true;
			}
		}
		if (double.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || double.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result / (flag ? 100.0 : 1.0);
			return true;
		}
		return false;
	}

	internal static bool hSI()
	{
		return bS5 == null;
	}

	internal static qdP dS6()
	{
		return bS5;
	}
}
