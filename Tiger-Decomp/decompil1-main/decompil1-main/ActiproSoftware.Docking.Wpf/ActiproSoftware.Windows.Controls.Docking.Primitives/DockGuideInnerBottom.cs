using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideInnerBottom : DockGuideBase
{
	private static DockGuideInnerBottom Q8R;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Bottom;

	public DockGuideInnerBottom()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideInnerBottom);
	}

	internal static bool f8D()
	{
		return Q8R == null;
	}

	internal static DockGuideInnerBottom c8E()
	{
		return Q8R;
	}
}
