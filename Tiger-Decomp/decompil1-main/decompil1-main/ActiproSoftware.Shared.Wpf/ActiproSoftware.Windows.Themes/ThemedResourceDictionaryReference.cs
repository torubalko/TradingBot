using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Themes;

public class ThemedResourceDictionaryReference
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool s4k;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Uri E4l;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<string> p4A;

	internal static ThemedResourceDictionaryReference PYN;

	public bool AreThemesExclusive
	{
		[CompilerGenerated]
		get
		{
			return s4k;
		}
		[CompilerGenerated]
		set
		{
			s4k = value;
		}
	}

	public Uri LocationUri
	{
		[CompilerGenerated]
		get
		{
			return E4l;
		}
		[CompilerGenerated]
		set
		{
			E4l = value;
		}
	}

	public IEnumerable<string> Themes
	{
		[CompilerGenerated]
		get
		{
			return p4A;
		}
		[CompilerGenerated]
		set
		{
			p4A = value;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	protected internal virtual ResourceDictionary GetResourceDictionary()
	{
		return new ResourceDictionary
		{
			Source = LocationUri
		};
	}

	public ThemedResourceDictionaryReference()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool yYO()
	{
		return PYN == null;
	}

	internal static ThemedResourceDictionaryReference QYq()
	{
		return PYN;
	}
}
