using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public abstract class CompletionProviderBase : ICompletionProvider, IOrderable, IKeyedObject
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string f1A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IEnumerable<Ordering> G1v;

	internal static CompletionProviderBase cL7;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return f1A;
		}
		[CompilerGenerated]
		private set
		{
			f1A = value;
		}
	}

	public IEnumerable<Ordering> Orderings
	{
		[CompilerGenerated]
		get
		{
			return G1v;
		}
		[CompilerGenerated]
		private set
		{
			G1v = value;
		}
	}

	protected CompletionProviderBase()
	{
		grA.DaB7cz();
		this._002Ector(Guid.NewGuid().ToString(), (Ordering[])null);
	}

	protected CompletionProviderBase(string key)
	{
		grA.DaB7cz();
		this._002Ector(key, (Ordering[])null);
	}

	protected CompletionProviderBase(string key, params Ordering[] orderings)
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

	public abstract bool RequestSession(IEditorView view, bool canCommitWithoutPopup);

	internal static bool sLn()
	{
		return cL7 == null;
	}

	internal static CompletionProviderBase mLq()
	{
		return cL7;
	}
}
