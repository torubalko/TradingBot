using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class TagSearchOptions<T> : ITagSearchOptions<T> where T : ITag
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool l9y;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Predicate<TagVersionRange<T>> F9z;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool uAS;

	internal static object wA9;

	public bool CanWrap
	{
		[CompilerGenerated]
		get
		{
			return l9y;
		}
		[CompilerGenerated]
		set
		{
			l9y = value;
		}
	}

	public Predicate<TagVersionRange<T>> Filter
	{
		[CompilerGenerated]
		get
		{
			return F9z;
		}
		[CompilerGenerated]
		set
		{
			F9z = value;
		}
	}

	public bool SearchUp
	{
		[CompilerGenerated]
		get
		{
			return uAS;
		}
		[CompilerGenerated]
		set
		{
			uAS = value;
		}
	}

	public TagSearchOptions()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	internal static bool QA8()
	{
		return wA9 == null;
	}

	internal static object PAL()
	{
		return wA9;
	}
}
