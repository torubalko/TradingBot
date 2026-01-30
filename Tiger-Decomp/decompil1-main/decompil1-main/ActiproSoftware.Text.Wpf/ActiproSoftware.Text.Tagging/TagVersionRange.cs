using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging;

public class TagVersionRange<T> where T : ITag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private ITextVersionRange C9x;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T h9g;

	internal static object QnS;

	public ITextVersionRange VersionRange
	{
		[CompilerGenerated]
		get
		{
			return C9x;
		}
		[CompilerGenerated]
		private set
		{
			C9x = value;
		}
	}

	public T Tag
	{
		[CompilerGenerated]
		get
		{
			return h9g;
		}
		[CompilerGenerated]
		private set
		{
			h9g = value;
		}
	}

	public TagVersionRange(TextSnapshotRange snapshotRange, TextRangeTrackingModes trackingModes, T tag)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		this._002Ector(snapshotRange.ToVersionRange(trackingModes), tag);
	}

	public TagVersionRange(ITextVersionRange versionRange, T tag)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (versionRange == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5632));
		}
		if (tag == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5562));
		}
		VersionRange = versionRange;
		Tag = tag;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is TagVersionRange<T> tagVersionRange))
		{
			return false;
		}
		return Tag.Equals(tagVersionRange.Tag) && VersionRange.Equals(tagVersionRange.VersionRange);
	}

	public override int GetHashCode()
	{
		return VersionRange.GetHashCode();
	}

	internal static bool fnB()
	{
		return QnS == null;
	}

	internal static object Rnz()
	{
		return QnS;
	}
}
