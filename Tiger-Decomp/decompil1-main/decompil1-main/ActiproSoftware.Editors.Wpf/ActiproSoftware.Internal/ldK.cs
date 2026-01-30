using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class ldK
{
	private static ldK XSz;

	public static string Hq2(float? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		return P_0.Value.ToString(P_1, CultureInfo.CurrentCulture);
	}

	public static IList<IPart> mqa(string P_0, CultureInfo P_1)
	{
		P_0 = Kqf(P_0, P_1);
		List<IPart> list = new List<IPart>();
		qdi qdi2 = new qdi();
		qdi2.Format = P_0;
		list.Add(qdi2);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string Kqf(string P_0, CultureInfo P_1)
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

	public static float iql(float P_0, float P_1, float? P_2, float? P_3, SpinWrapping P_4, int? P_5)
	{
		float num = P_2 ?? float.MinValue;
		float num2 = P_3 ?? float.MaxValue;
		if (float.IsNaN(P_0))
		{
			return vq0(0f, num, num2, P_5);
		}
		if (float.IsNegativeInfinity(P_0))
		{
			return num;
		}
		if (float.IsPositiveInfinity(P_0))
		{
			return num2;
		}
		try
		{
			P_0 = ((P_1 >= 0f) ? ((!(P_0 > num2 - P_1)) ? vq0((float)Math.Round(P_0, qdP.TDx(P_1), MidpointRounding.AwayFromZero) + P_1, num, num2, P_5) : ((P_0 < num2 || P_4 == SpinWrapping.NoWrap) ? num2 : num)) : ((!(P_0 < num - P_1)) ? vq0((float)Math.Round(P_0, qdP.TDx(P_1), MidpointRounding.AwayFromZero) + P_1, num, num2, P_5) : ((P_0 > num || P_4 == SpinWrapping.NoWrap) ? num : num2)));
		}
		catch (OverflowException)
		{
			P_0 = ((P_1 > 0f) ? num2 : num);
		}
		return P_0;
	}

	public static float TqX(float P_0, float P_1)
	{
		return (P_0 > P_1) ? P_0 : P_1;
	}

	public static float rqx(float P_0, float P_1)
	{
		return (P_0 < P_1) ? P_0 : P_1;
	}

	[SpecialName]
	public static string Tqo()
	{
		return cdY.zDN();
	}

	public static float vq0(float P_0, float P_1, float P_2, int? P_3)
	{
		float num = TqX(P_1, rqx(P_0, P_2));
		if (P_3.HasValue && P_3.Value >= 0)
		{
			return (float)Math.Round(num, Math.Min(15, P_3.Value), MidpointRounding.AwayFromZero);
		}
		return num;
	}

	public static float kqY(float P_0, float P_1, float P_2, int? P_3, bool P_4, bool P_5, bool P_6)
	{
		if (float.IsNaN(P_0) && P_4)
		{
			return P_0;
		}
		if (float.IsNegativeInfinity(P_0) && P_5)
		{
			return P_0;
		}
		if (float.IsPositiveInfinity(P_0) && P_6)
		{
			return P_0;
		}
		return vq0(P_0, P_1, P_2, P_3);
	}

	public static bool Gqg(string P_0, string P_1, out float? P_2)
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
		if (!string.IsNullOrEmpty(array[1]) && (float.TryParse(array[1], NumberStyles.Integer, CultureInfo.CurrentCulture, out var result) || float.TryParse(array[1], NumberStyles.Any, CultureInfo.CurrentCulture, out result)))
		{
			float num = 0f - Math.Abs(result);
			string text = Hq2(num, P_1);
			if (P_0 == text)
			{
				P_2 = num / (flag ? 100f : 1f);
				return true;
			}
		}
		if (float.TryParse(array[0], NumberStyles.Integer, CultureInfo.CurrentCulture, out result) || float.TryParse(array[0], NumberStyles.Any, CultureInfo.CurrentCulture, out result))
		{
			P_2 = result / (flag ? 100f : 1f);
			return true;
		}
		return false;
	}

	internal static bool TAF()
	{
		return XSz == null;
	}

	internal static ldK FAB()
	{
		return XSz;
	}
}
