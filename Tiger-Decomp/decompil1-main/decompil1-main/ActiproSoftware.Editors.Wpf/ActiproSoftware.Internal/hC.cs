using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Internal;

internal abstract class hC<HM> : IPart
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int fIA;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int SI3;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private string uIy;

	internal static object AJv;

	public virtual bool IsEditable => true;

	public virtual bool IsLiteral => false;

	public virtual bool IsOptional => false;

	public int Length
	{
		[CompilerGenerated]
		get
		{
			return fIA;
		}
		[CompilerGenerated]
		set
		{
			fIA = num;
		}
	}

	public int StartOffset
	{
		[CompilerGenerated]
		get
		{
			return SI3;
		}
		[CompilerGenerated]
		set
		{
			SI3 = sI;
		}
	}

	public string StringValue
	{
		[CompilerGenerated]
		get
		{
			return uIy;
		}
		[CompilerGenerated]
		set
		{
			uIy = text;
		}
	}

	public abstract bool TryParseText(IList<IPart> P_0, string P_1, int P_2, CultureInfo P_3, out int P_4);

	protected hC()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool cJp()
	{
		return AJv == null;
	}

	internal static object zJ4()
	{
		return AJv;
	}
}
