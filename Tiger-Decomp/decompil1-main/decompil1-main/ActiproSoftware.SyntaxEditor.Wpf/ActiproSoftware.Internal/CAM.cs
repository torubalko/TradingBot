using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;

namespace ActiproSoftware.Internal;

internal class CAM
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IHighlightingStyle RHQ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextRange IHe;

	internal static CAM aWB;

	public CAM(TextRange P_0, IHighlightingStyle P_1)
	{
		grA.DaB7cz();
		base._002Ector();
		if (P_1 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(192400));
		}
		GHD(P_0);
		HHX(P_1);
	}

	[SpecialName]
	[CompilerGenerated]
	public IHighlightingStyle gHG()
	{
		return RHQ;
	}

	[SpecialName]
	[CompilerGenerated]
	private void HHX(IHighlightingStyle P_0)
	{
		RHQ = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public TextRange iHf()
	{
		return IHe;
	}

	[SpecialName]
	[CompilerGenerated]
	private void GHD(TextRange P_0)
	{
		IHe = P_0;
	}

	public void UHx(int P_0)
	{
		TextRange textRange = iHf();
		GHD(new TextRange(textRange.StartOffset + P_0, textRange.EndOffset + P_0));
	}

	internal static bool qW0()
	{
		return aWB == null;
	}

	internal static CAM cW7()
	{
		return aWB;
	}
}
