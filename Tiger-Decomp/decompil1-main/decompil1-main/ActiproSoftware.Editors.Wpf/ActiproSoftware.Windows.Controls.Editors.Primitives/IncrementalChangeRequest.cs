using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

public class IncrementalChangeRequest<T>
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T sIq;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IncrementalChangeRequestKind oIu;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private T oIK;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private T KIR;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int? DId;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private T vI9;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private SpinWrapping oI5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private T NIc;

	private static object eGz;

	public T LargeChange
	{
		[CompilerGenerated]
		get
		{
			return sIq;
		}
		[CompilerGenerated]
		set
		{
			sIq = value;
		}
	}

	public IncrementalChangeRequestKind Kind
	{
		[CompilerGenerated]
		get
		{
			return oIu;
		}
		[CompilerGenerated]
		set
		{
			oIu = value;
		}
	}

	public T Maximum
	{
		[CompilerGenerated]
		get
		{
			return oIK;
		}
		[CompilerGenerated]
		set
		{
			oIK = value;
		}
	}

	public T Minimum
	{
		[CompilerGenerated]
		get
		{
			return KIR;
		}
		[CompilerGenerated]
		set
		{
			KIR = value;
		}
	}

	public int? RoundingDecimalPlace
	{
		[CompilerGenerated]
		get
		{
			return DId;
		}
		[CompilerGenerated]
		set
		{
			DId = value;
		}
	}

	public T SmallChange
	{
		[CompilerGenerated]
		get
		{
			return vI9;
		}
		[CompilerGenerated]
		set
		{
			vI9 = value;
		}
	}

	public SpinWrapping SpinWrapping
	{
		[CompilerGenerated]
		get
		{
			return oI5;
		}
		[CompilerGenerated]
		set
		{
			oI5 = value;
		}
	}

	public T Value
	{
		[CompilerGenerated]
		get
		{
			return NIc;
		}
		[CompilerGenerated]
		set
		{
			NIc = value;
		}
	}

	public IncrementalChangeRequest()
	{
		awj.QuEwGz();
		base._002Ector();
		Kind = IncrementalChangeRequestKind.Increase;
		RoundingDecimalPlace = 8;
		SpinWrapping = SpinWrapping.NoWrap;
	}

	internal static bool LJF()
	{
		return eGz == null;
	}

	internal static object AJB()
	{
		return eGz;
	}
}
