using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal class SearchResult : ISearchResult, ITextRangeProvider
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ISearchCaptureCollection rAR;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange SAf;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextSnapshotRange eAt;

	internal static SearchResult RVT;

	TextRange ITextRangeProvider.TextRange
	{
		get
		{
			return FindSnapshotRange.TextRange;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public ISearchCaptureCollection Captures
	{
		[CompilerGenerated]
		get
		{
			return rAR;
		}
		[CompilerGenerated]
		private set
		{
			rAR = value;
		}
	}

	public TextSnapshotRange FindSnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return SAf;
		}
		[CompilerGenerated]
		private set
		{
			SAf = value;
		}
	}

	public TextSnapshotRange ReplaceSnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return eAt;
		}
		[CompilerGenerated]
		internal set
		{
			eAt = value;
		}
	}

	internal SearchResult(TextSnapshotRange findSnapshotRange, ISearchCaptureCollection captures)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (findSnapshotRange.IsDeleted)
		{
			throw new ArgumentOutOfRangeException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6330));
		}
		FindSnapshotRange = findSnapshotRange;
		ReplaceSnapshotRange = TextSnapshotRange.Deleted;
		Captures = captures;
	}

	internal static bool eVk()
	{
		return RVT == null;
	}

	internal static SearchResult pVX()
	{
		return RVT;
	}
}
