using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class CompletionFilter : ICompletionFilter, IKeyedObject
{
	private CompletionFilterPredicate eud;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object zuz;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CompletionFilterDisplayMode L1W;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string N1P;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool j1E;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string V1c;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object C1a;

	private static CompletionFilter Lat;

	public object Content
	{
		[CompilerGenerated]
		get
		{
			return zuz;
		}
		[CompilerGenerated]
		set
		{
			zuz = value;
		}
	}

	public CompletionFilterDisplayMode DisplayMode
	{
		[CompilerGenerated]
		get
		{
			return L1W;
		}
		[CompilerGenerated]
		set
		{
			L1W = value;
		}
	}

	public string GroupName
	{
		[CompilerGenerated]
		get
		{
			return N1P;
		}
		[CompilerGenerated]
		set
		{
			N1P = value;
		}
	}

	public bool IsActive
	{
		[CompilerGenerated]
		get
		{
			return j1E;
		}
		[CompilerGenerated]
		set
		{
			j1E = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return V1c;
		}
		[CompilerGenerated]
		private set
		{
			V1c = value;
		}
	}

	public object ToolTip
	{
		[CompilerGenerated]
		get
		{
			return C1a;
		}
		[CompilerGenerated]
		set
		{
			C1a = value;
		}
	}

	public CompletionFilter(string key, CompletionFilterPredicate predicate)
	{
		grA.DaB7cz();
		base._002Ector();
		if (key == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		eud = predicate;
	}

	public virtual CompletionFilterResult Filter(ICompletionSession session, ICompletionItem item)
	{
		if (eud == null)
		{
			return CompletionFilterResult.Included;
		}
		return eud(session, item);
	}

	internal static bool haY()
	{
		return Lat == null;
	}

	internal static CompletionFilter Yab()
	{
		return Lat;
	}
}
