using System.Runtime.CompilerServices;
using ActiproSoftware.Windows.Controls.Grids;

namespace ActiproSoftware.Internal;

internal class Fl : ITreeItemVirtualPlaceholder
{
	[CompilerGenerated]
	private int uEs;

	internal static Fl Hsg;

	public int Index
	{
		[CompilerGenerated]
		get
		{
			return uEs;
		}
		[CompilerGenerated]
		private set
		{
			uEs = num;
		}
	}

	public Fl(int P_0)
	{
		fc.taYSkz();
		base._002Ector();
		Index = P_0;
	}

	internal static bool osP()
	{
		return Hsg == null;
	}

	internal static Fl ush()
	{
		return Hsg;
	}
}
