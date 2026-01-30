using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class cdY
{
	internal static cdY jSd;

	public static string JDe(int? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> oDk(string P_0, CultureInfo P_1)
	{
		P_0 = MDE(P_0, P_1);
		List<IPart> list = new List<IPart>();
		bq bq2 = new bq();
		bq2.Format = P_0;
		list.Add(bq2);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string MDE(string P_0, CultureInfo P_1)
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
			P_0 = QdM.AR8(1942);
		}
		return P_0;
	}

	public static int YD7(int P_0, int P_1, int? P_2, int? P_3, SpinWrapping P_4)
	{
		int num = P_2 ?? int.MinValue;
		int num2 = P_3 ?? int.MaxValue;
		try
		{
			P_0 = ((P_1 >= 0) ? ((P_0 <= num2 - P_1) ? vDh(P_0 + P_1, num, num2) : ((P_0 < num2 || P_4 == SpinWrapping.NoWrap) ? num2 : num)) : ((P_0 >= num - P_1) ? vDh(P_0 + P_1, num, num2) : ((P_0 > num || P_4 == SpinWrapping.NoWrap) ? num : num2)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0) ? num2 : num);
		}
		return P_0;
	}

	public static int fD4(int P_0, int P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static int eDB(int P_0, int P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string zDN()
	{
		char c = ',';
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		if (!string.IsNullOrEmpty(numberDecimalSeparator) && c == numberDecimalSeparator[0])
		{
			c = ';';
		}
		return c + QdM.AR8(23766);
	}

	public static int vDh(int P_0, int P_1, int P_2)
	{
		return fD4(P_1, eDB(P_0, P_2));
	}

	public static bool cDw(string P_0, string P_1, out int? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		int result;
		if (P_1.StartsWith(QdM.AR8(20000), StringComparison.OrdinalIgnoreCase))
		{
			if (int.TryParse(P_0, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		if (P_1.StartsWith(QdM.AR8(23296), StringComparison.OrdinalIgnoreCase))
		{
			if (int.TryParse(P_0, NumberStyles.Currency, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		string[] array = wdv.nGG(P_0, P_1);
		if (!string.IsNullOrEmpty(array[1]) && (int.TryParse(array[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || int.TryParse(array[1], NumberStyles.Any, CultureInfo.CurrentCulture, out result)))
		{
			int value = -Math.Abs(result);
			string text = JDe(value, P_1);
			if (P_0 == text)
			{
				P_2 = value;
				return true;
			}
		}
		if (int.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || int.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result;
			return true;
		}
		return false;
	}

	internal static bool iSv()
	{
		return jSd == null;
	}

	internal static cdY XSp()
	{
		return jSd;
	}
}
