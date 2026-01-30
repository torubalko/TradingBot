using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging;

public class TagSnapshotRange<T> where T : ITag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange o9U;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T J9a;

	internal static object Nng;

	public TextSnapshotRange SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return o9U;
		}
		[CompilerGenerated]
		private set
		{
			o9U = value;
		}
	}

	public T Tag
	{
		[CompilerGenerated]
		get
		{
			return J9a;
		}
		[CompilerGenerated]
		private set
		{
			J9a = value;
		}
	}

	public TagSnapshotRange(TextSnapshotRange snapshotRange, T tag)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		SnapshotRange = snapshotRange;
		Tag = tag;
	}

	public override bool Equals(object obj)
	{
		if (obj is TagSnapshotRange<T> tagSnapshotRange)
		{
			return Tag.Equals(tagSnapshotRange.Tag) && SnapshotRange.Equals(tagSnapshotRange.SnapshotRange);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return SnapshotRange.GetHashCode();
	}

	public override string ToString()
	{
		if (SnapshotRange.IsDeleted)
		{
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1696);
		}
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5572) + SnapshotRange.Snapshot.Version.Number + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1752) + SnapshotRange.StartOffset + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1598) + SnapshotRange.EndOffset + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5618) + Tag?.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(1418);
	}

	internal static bool Snp()
	{
		return Nng == null;
	}

	internal static object Lnm()
	{
		return Nng;
	}
}
