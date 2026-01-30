using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

public static class NavigableRequestContexts
{
	private static INavigableRequestContext hCX;

	internal static NavigableRequestContexts hxI;

	public static INavigableRequestContext NavigableSymbolSelector
	{
		get
		{
			if (hCX == null)
			{
				hCX = new Ps(Q7Z.tqM(12372));
			}
			return hCX;
		}
	}

	internal static bool Sxc()
	{
		return hxI == null;
	}

	internal static NavigableRequestContexts Axd()
	{
		return hxI;
	}
}
