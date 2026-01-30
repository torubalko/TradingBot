using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class ParameterInfoProviderBase : IParameterInfoProvider, IOrderable, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string k3Q;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private IEnumerable<Ordering> b3e;

	internal static ParameterInfoProviderBase ULu;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return k3Q;
		}
		[CompilerGenerated]
		private set
		{
			k3Q = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return b3e;
		}
		[CompilerGenerated]
		private set
		{
			b3e = value;
		}
	}

	protected ParameterInfoProviderBase()
	{
		grA.DaB7cz();
		this._002Ector(Guid.NewGuid().ToString(), (Ordering[])null);
	}

	protected ParameterInfoProviderBase(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, (Ordering[])null);
	}

	protected ParameterInfoProviderBase(string key, params Ordering[] orderings)
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

	public abstract bool RequestSession(IEditorView view);

	internal static bool zL8()
	{
		return ULu == null;
	}

	internal static ParameterInfoProviderBase nLU()
	{
		return ULu;
	}
}
