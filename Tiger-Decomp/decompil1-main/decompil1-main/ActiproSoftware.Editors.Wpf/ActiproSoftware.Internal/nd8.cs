using System;
using System.Collections.Generic;
using System.Globalization;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal static class nd8
{
	public static int sGu(IList<IPart> P_0, int P_1)
	{
		if (P_0 == null || P_0.Count == 0)
		{
			return -1;
		}
		for (int i = 0; i < P_0.Count; i++)
		{
			IPart part = P_0[i];
			if (part == null)
			{
				continue;
			}
			if (P_1 == part.StartOffset)
			{
				if (part.Length > 0)
				{
					return i;
				}
				if (!part.IsOptional)
				{
					IPart part2 = MGK(P_0, i + 1);
					if (part2 != null && part2.IsLiteral)
					{
						return i;
					}
				}
			}
			else if (P_1 == part.StartOffset + part.Length)
			{
				IPart part3 = MGK(P_0, i + 1);
				if (part3 != null && part3.IsLiteral)
				{
					return i;
				}
			}
			else if (P_1 < part.StartOffset + part.Length)
			{
				return i;
			}
		}
		return P_0.Count - 1;
	}

	public static IPart MGK(IList<IPart> P_0, int P_1)
	{
		if (P_0 != null && P_1 >= 0 && P_1 < P_0.Count)
		{
			return P_0[P_1];
		}
		return null;
	}

	public static void oGR(IList<IPart> P_0, string P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		int offset = 0;
		for (int i = 0; i < P_0.Count; i++)
		{
			IPart part = P_0[i];
			if (part != null)
			{
				part.StartOffset = offset;
				if (part.TryParseText(P_0, P_1, part.StartOffset, CultureInfo.CurrentCulture, out offset))
				{
					offset = Math.Max(part.StartOffset, Math.Min(offset, P_1.Length));
					part.Length = offset - part.StartOffset;
					part.StringValue = P_1.Substring(part.StartOffset, part.Length);
				}
				else
				{
					part.Length = 0;
					part.StringValue = string.Empty;
				}
			}
		}
	}
}
