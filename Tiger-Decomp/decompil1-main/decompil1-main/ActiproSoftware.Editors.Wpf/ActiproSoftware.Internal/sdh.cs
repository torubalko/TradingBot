using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class sdh
{
	internal static sdh RSw;

	public static string VGX(long? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> LGx(string P_0, CultureInfo P_1)
	{
		P_0 = zG0(P_0, P_1);
		List<IPart> list = new List<IPart>();
		SQ sQ = new SQ();
		sQ.Format = P_0;
		list.Add(sQ);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string zG0(string P_0, CultureInfo P_1)
	{
		int num = 1;
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				case 1:
					break;
				default:
					if (flag)
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
				flag = P_1 == null;
				num2 = 0;
			}
			while (IS2() == null);
		}
	}

	public static long IGY(long P_0, long P_1, long? P_2, long? P_3, SpinWrapping P_4)
	{
		long num = P_2 ?? long.MinValue;
		long num2 = P_3 ?? long.MaxValue;
		try
		{
			P_0 = ((P_1 >= 0) ? ((P_0 <= num2 - P_1) ? hGO(P_0 + P_1, num, num2) : ((P_0 < num2 || P_4 == SpinWrapping.NoWrap) ? num2 : num)) : ((P_0 >= num - P_1) ? hGO(P_0 + P_1, num, num2) : ((P_0 > num || P_4 == SpinWrapping.NoWrap) ? num : num2)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0) ? num2 : num);
		}
		return P_0;
	}

	public static long jGg(long P_0, long P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static long cGo(long P_0, long P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string MGI()
	{
		char c = ',';
		string numberDecimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
		if (!string.IsNullOrEmpty(numberDecimalSeparator) && c == numberDecimalSeparator[0])
		{
			c = ';';
		}
		return c + QdM.AR8(23766);
	}

	public static long hGO(long P_0, long P_1, long P_2)
	{
		return jGg(P_1, cGo(P_0, P_2));
	}

	public static bool fGT(string P_0, string P_1, out long? P_2)
	{
		P_2 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return true;
		}
		long result;
		if (P_1.StartsWith(QdM.AR8(20000), StringComparison.OrdinalIgnoreCase))
		{
			if (long.TryParse(P_0, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		if (P_1.StartsWith(QdM.AR8(23296), StringComparison.OrdinalIgnoreCase))
		{
			if (long.TryParse(P_0, NumberStyles.Currency, CultureInfo.CurrentCulture, out result))
			{
				P_2 = result;
				return true;
			}
			return false;
		}
		string[] array = wdv.nGG(P_0, P_1);
		if (!string.IsNullOrEmpty(array[1]) && (long.TryParse(array[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || long.TryParse(array[1], NumberStyles.Any, CultureInfo.CurrentCulture, out result)))
		{
			long value = -Math.Abs(result);
			string text = VGX(value, P_1);
			if (P_0 == text)
			{
				P_2 = value;
				return true;
			}
		}
		if (long.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || long.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result;
			return true;
		}
		return false;
	}

	internal static bool ySo()
	{
		return RSw == null;
	}

	internal static sdh IS2()
	{
		return RSw;
	}
}
