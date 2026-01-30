using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining.Implementation;

public class OutliningNodeDefinition : IOutliningNodeDefinition, IKeyedObject
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object Wv8;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool KvI;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool xv5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool Hv0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool SvB;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private string uvV;

	internal static OutliningNodeDefinition u7a;

	public object DefaultCollapsedContent
	{
		[CompilerGenerated]
		get
		{
			return Wv8;
		}
		[CompilerGenerated]
		set
		{
			Wv8 = value;
		}
	}

	public bool HasEndDelimiter
	{
		[CompilerGenerated]
		get
		{
			return KvI;
		}
		[CompilerGenerated]
		set
		{
			KvI = value;
		}
	}

	public bool IsCollapsible
	{
		[CompilerGenerated]
		get
		{
			return xv5;
		}
		[CompilerGenerated]
		set
		{
			xv5 = value;
		}
	}

	public bool IsDefaultCollapsed
	{
		[CompilerGenerated]
		get
		{
			return Hv0;
		}
		[CompilerGenerated]
		set
		{
			Hv0 = value;
		}
	}

	public bool IsImplementation
	{
		[CompilerGenerated]
		get
		{
			return SvB;
		}
		[CompilerGenerated]
		set
		{
			SvB = value;
		}
	}

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return uvV;
		}
		[CompilerGenerated]
		private set
		{
			uvV = value;
		}
	}

	public OutliningNodeDefinition(string key)
	{
		grA.DaB7cz();
		base._002Ector();
		if (string.IsNullOrEmpty(key))
		{
			throw new ArgumentNullException(Q7Z.tqM(11646));
		}
		Key = key;
		IsCollapsible = true;
		HasEndDelimiter = true;
	}

	public virtual object GetCollapsedContent(IOutliningNode node)
	{
		return DefaultCollapsedContent;
	}

	public override string ToString()
	{
		return Q7Z.tqM(11656) + Key + Q7Z.tqM(11640);
	}

	internal static bool R7L()
	{
		return u7a == null;
	}

	internal static OutliningNodeDefinition N7g()
	{
		return u7a;
	}
}
