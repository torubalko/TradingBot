using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Text.RegularExpressions;
using ActiproSoftware.Text.Utility;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Searching.Implementation;

internal abstract class SearchPatternProviderBase : ISearchPatternProvider, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string HA3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string yAJ;

	private static SearchPatternProviderBase wV6;

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return HA3;
		}
		[CompilerGenerated]
		private set
		{
			HA3 = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return yAJ;
		}
		[CompilerGenerated]
		private set
		{
			yAJ = value;
		}
	}

	public virtual bool RequiresCaseSensitivity => false;

	protected SearchPatternProviderBase(string key, string description)
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5194));
		}
		if (description == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(6304));
		}
		Key = key;
		Description = description;
	}

	public virtual string GetFindPattern(string pattern)
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496) + RegexHelper.Escape(pattern) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(5496);
	}

	public virtual string GetReplacePattern(string pattern)
	{
		return RegexHelper.Escape(pattern, isReplacePattern: true);
	}

	internal static bool MVE()
	{
		return wV6 == null;
	}

	internal static SearchPatternProviderBase vVG()
	{
		return wV6;
	}
}
