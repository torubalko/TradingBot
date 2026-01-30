using System;
using ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

namespace ActiproSoftware.Internal;

internal static class wI
{
	private static wI nnO;

	public static string BmU(this ICodeSnippet P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12064));
		}
		string text = P_0.CodeDelimiter ?? Q7Z.tqM(12090);
		return text + Q7Z.tqM(12096) + text;
	}

	public static string ImJ(this ICodeSnippet P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12064));
		}
		string text = P_0.CodeDelimiter ?? Q7Z.tqM(12090);
		return text + text;
	}

	public static string Mmt(this ICodeSnippet P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(12064));
		}
		string text = P_0.CodeDelimiter ?? Q7Z.tqM(12090);
		return text + Q7Z.tqM(12106) + text;
	}

	public static string UmZ(this ICodeSnippet P_0)
	{
		if (P_0 != null)
		{
			return P_0.CodeDelimiter ?? Q7Z.tqM(12090);
		}
		throw new ArgumentNullException(Q7Z.tqM(12064));
	}

	internal static bool Pn1()
	{
		return nnO == null;
	}

	internal static wI Jn5()
	{
		return nnO;
	}
}
