using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;

public sealed class AdornmentLayerDefinition : IOrderable, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string anF;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> yn3;

	internal static AdornmentLayerDefinition aOV;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return anF;
		}
		[CompilerGenerated]
		private set
		{
			anF = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return yn3;
		}
		[CompilerGenerated]
		private set
		{
			yn3 = value;
		}
	}

	public AdornmentLayerDefinition(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, (IEnumerable<Ordering>)null);
	}

	public AdornmentLayerDefinition(string key, params Ordering[] orderings)
	{
		grA.DaB7cz();
		this._002Ector(key, (IEnumerable<Ordering>)orderings);
	}

	public AdornmentLayerDefinition(string key, IEnumerable<Ordering> orderings)
	{
		grA.DaB7cz();
		base._002Ector();
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		Orderings = orderings;
	}

	internal static bool zOI()
	{
		return aOV == null;
	}

	internal static AdornmentLayerDefinition WOc()
	{
		return aOV;
	}
}
