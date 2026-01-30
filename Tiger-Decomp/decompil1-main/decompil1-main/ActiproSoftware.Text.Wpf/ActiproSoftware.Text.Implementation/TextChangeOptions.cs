using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Implementation;

public class TextChangeOptions : ITextChangeOptions
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool ecQ;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private object mcn;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool tcG;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool uce;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextChangeOffsetDelta icy;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object ocz;

	private static TextChangeOptions q2i;

	public bool CanMergeIntoPreviousChange
	{
		[CompilerGenerated]
		get
		{
			return ecQ;
		}
		[CompilerGenerated]
		set
		{
			ecQ = value;
		}
	}

	public object CustomData
	{
		[CompilerGenerated]
		get
		{
			return mcn;
		}
		[CompilerGenerated]
		set
		{
			mcn = value;
		}
	}

	public bool CheckReadOnly
	{
		[CompilerGenerated]
		get
		{
			return tcG;
		}
		[CompilerGenerated]
		set
		{
			tcG = value;
		}
	}

	public bool RetainSelection
	{
		[CompilerGenerated]
		get
		{
			return uce;
		}
		[CompilerGenerated]
		set
		{
			uce = value;
		}
	}

	public TextChangeOffsetDelta OffsetDelta
	{
		[CompilerGenerated]
		get
		{
			return icy;
		}
		[CompilerGenerated]
		set
		{
			icy = value;
		}
	}

	public object Source
	{
		[CompilerGenerated]
		get
		{
			return ocz;
		}
		[CompilerGenerated]
		set
		{
			ocz = value;
		}
	}

	public TextChangeOptions()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		OffsetDelta = TextChangeOffsetDelta.None;
	}

	internal static bool U2t()
	{
		return q2i == null;
	}

	internal static TextChangeOptions u2W()
	{
		return q2i;
	}
}
