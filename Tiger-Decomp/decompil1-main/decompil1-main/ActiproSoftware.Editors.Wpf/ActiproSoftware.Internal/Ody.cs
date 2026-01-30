using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class Ody
{
	internal static Ody cSX;

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	public static string aD3(Guid? P_0, string P_1)
	{
		if (!P_0.HasValue)
		{
			return null;
		}
		string text = P_0.Value.ToString(P_1);
		if (P_1 != null && P_1.Length == 1 && char.IsUpper(P_1[0]))
		{
			return text.ToUpperInvariant();
		}
		return text.ToLowerInvariant();
	}

	public static Guid oDy()
	{
		return Guid.NewGuid();
	}

	public static IList<IPart> nDm(string P_0)
	{
		P_0 = kDS(P_0);
		List<IPart> list = new List<IPart>();
		Ke ke = new Ke();
		ke.Format = P_0;
		list.Add(ke);
		return new ReadOnlyCollection<IPart>(list);
	}

	public static string kDS(string P_0)
	{
		if (P_0 != null)
		{
			P_0 = P_0.Trim();
		}
		if (P_0 != null)
		{
			int num = 0;
			if (xSC() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (P_0.Length == 1 && QdM.AR8(28198).Contains(P_0))
			{
				goto IL_0050;
			}
		}
		P_0 = QdM.AR8(1942);
		goto IL_0050;
		IL_0050:
		return P_0;
	}

	public static bool YD1(string P_0, out Guid? P_1)
	{
		P_1 = null;
		bool result2;
		if (!string.IsNullOrEmpty(P_0))
		{
			if (!Guid.TryParse(P_0, out var result))
			{
				result2 = false;
				int num = 0;
				if (!eSK())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
			}
			else
			{
				P_1 = result;
				result2 = true;
			}
		}
		else
		{
			result2 = true;
		}
		return result2;
	}

	internal static bool eSK()
	{
		return cSX == null;
	}

	internal static Ody xSC()
	{
		return cSX;
	}
}
