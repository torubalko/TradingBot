using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.Analysis;
using ActiproSoftware.Text.Tagging;

namespace ActiproSoftware.Internal;

internal class bAL : IDelimiterHighlightTag, ITag
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private StructureMatchEdges L8U;

	private static bAL a5G;

	public StructureMatchEdges MatchEdges
	{
		[CompilerGenerated]
		get
		{
			return L8U;
		}
		[CompilerGenerated]
		private set
		{
			L8U = l8U;
		}
	}

	public bAL(StructureMatchEdges P_0)
	{
		grA.DaB7cz();
		base._002Ector();
		MatchEdges = P_0;
	}

	internal static bool y5N()
	{
		return a5G == null;
	}

	internal static bAL t5H()
	{
		return a5G;
	}
}
