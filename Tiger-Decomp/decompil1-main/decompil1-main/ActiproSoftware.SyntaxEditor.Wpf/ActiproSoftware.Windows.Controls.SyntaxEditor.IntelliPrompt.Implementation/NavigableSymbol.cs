using System.Diagnostics;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt.Implementation;

public class NavigableSymbol : INavigableSymbol
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private IContentProvider R3P;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private int h3E;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotOffset? r3c;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TextSnapshotRange g3a;

	internal static NavigableSymbol xLy;

	public IContentProvider ContentProvider
	{
		[CompilerGenerated]
		get
		{
			return R3P;
		}
		[CompilerGenerated]
		set
		{
			R3P = value;
		}
	}

	public int HierarchyLevel
	{
		[CompilerGenerated]
		get
		{
			return h3E;
		}
		[CompilerGenerated]
		set
		{
			h3E = value;
		}
	}

	public TextSnapshotOffset? NavigationSnapshotOffset
	{
		[CompilerGenerated]
		get
		{
			return r3c;
		}
		[CompilerGenerated]
		set
		{
			r3c = value;
		}
	}

	public TextSnapshotRange SnapshotRange
	{
		[CompilerGenerated]
		get
		{
			return g3a;
		}
		[CompilerGenerated]
		set
		{
			g3a = value;
		}
	}

	public NavigableSymbol()
	{
		grA.DaB7cz();
		base._002Ector();
		SnapshotRange = TextSnapshotRange.Deleted;
	}

	internal static bool xLh()
	{
		return xLy == null;
	}

	internal static NavigableSymbol jL6()
	{
		return xLy;
	}
}
