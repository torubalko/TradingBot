using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Analysis.Implementation;

public class StructureMatchResult : IStructureMatchResult, ITextRangeProvider
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private StructureMatchEdges JLA;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool wLu;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextSnapshotOffset? VL8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange aLT;

	private static StructureMatchResult lqu;

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return SnapshotRange.TextRange;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public StructureMatchEdges MatchEdges
	{
		[CompilerGenerated]
		get
		{
			return JLA;
		}
		[CompilerGenerated]
		set
		{
			JLA = value;
		}
	}

	public bool IsSource
	{
		[CompilerGenerated]
		get
		{
			return wLu;
		}
		[CompilerGenerated]
		set
		{
			wLu = value;
		}
	}

	public TextSnapshotOffset? NavigationSnapshotOffset
	{
		[CompilerGenerated]
		get
		{
			return VL8;
		}
		[CompilerGenerated]
		set
		{
			VL8 = value;
		}
	}

	public TextSnapshotRange SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return aLT;
		}
		[CompilerGenerated]
		set
		{
			aLT = value;
		}
	}

	public StructureMatchResult(TextSnapshotRange snapshotRange)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (snapshotRange.IsDeleted)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5724));
		}
		MatchEdges = StructureMatchEdges.Both;
		SnapshotRange = snapshotRange;
	}

	internal static bool FqR()
	{
		return lqu == null;
	}

	internal static StructureMatchResult Iq0()
	{
		return lqu;
	}
}
