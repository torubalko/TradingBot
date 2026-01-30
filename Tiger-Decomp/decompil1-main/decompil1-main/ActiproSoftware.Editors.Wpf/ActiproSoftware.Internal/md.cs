using System;

namespace ActiproSoftware.Internal;

internal static class md
{
	internal static md Ra;

	public static bool yV(this string P_0, int P_1)
	{
		if (!string.IsNullOrEmpty(P_0) && P_1 < P_0.Length)
		{
			return char.IsNumber(P_0[P_1]);
		}
		return false;
	}

	public static bool WC(this string P_0, string P_1, int P_2, StringComparison P_3)
	{
		if (!string.IsNullOrEmpty(P_0) && !string.IsNullOrEmpty(P_1) && P_2 + P_1.Length <= P_0.Length)
		{
			return string.Compare(P_0.Substring(P_2, P_1.Length), P_1, P_3) == 0;
		}
		return false;
	}

	internal static bool Nj()
	{
		return Ra == null;
	}

	internal static md tG()
	{
		return Ra;
	}
}
