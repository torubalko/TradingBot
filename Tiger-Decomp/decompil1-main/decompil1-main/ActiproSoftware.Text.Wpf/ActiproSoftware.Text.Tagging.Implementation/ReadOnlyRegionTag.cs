using System.Diagnostics;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class ReadOnlyRegionTag : ClassificationTag, IReadOnlyRegionTag, ITag
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool R9K;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool O9k;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool G9E;

	internal static ReadOnlyRegionTag XA5;

	public bool IncludeFirstEdge
	{
		[CompilerGenerated]
		get
		{
			return R9K;
		}
		[CompilerGenerated]
		set
		{
			R9K = value;
		}
	}

	public bool IncludeLastEdge
	{
		[CompilerGenerated]
		get
		{
			return O9k;
		}
		[CompilerGenerated]
		set
		{
			O9k = value;
		}
	}

	public bool IsReadOnly
	{
		[CompilerGenerated]
		get
		{
			return G9E;
		}
		[CompilerGenerated]
		set
		{
			G9E = value;
		}
	}

	public ReadOnlyRegionTag()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
		IsReadOnly = true;
		base.ClassificationType = ClassificationTypes.ReadOnlyRegion;
	}

	internal static bool tAP()
	{
		return XA5 == null;
	}

	internal static ReadOnlyRegionTag yAU()
	{
		return XA5;
	}
}
