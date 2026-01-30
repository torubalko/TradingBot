using System;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Internal;

internal static class UAw
{
	private static UAw PWo;

	public static IHighlightingStyle oLD(this IHighlightingStyleRegistry P_0, object P_1, IClassificationType P_2)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(194414));
		}
		IHighlightingStyle highlightingStyle = null;
		int num = 0;
		if (KWy() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		default:
			if (P_1 is IHighlightingStyleRegistryProvider { HighlightingStyleRegistry: { } highlightingStyleRegistry })
			{
				highlightingStyle = highlightingStyleRegistry[P_2];
			}
			if (highlightingStyle == null)
			{
				highlightingStyle = P_0[P_2];
			}
			return highlightingStyle;
		}
	}

	internal static bool BWQ()
	{
		return PWo == null;
	}

	internal static UAw KWy()
	{
		return PWo;
	}
}
