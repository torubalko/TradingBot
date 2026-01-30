using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideInnerTop : DockGuideBase
{
	private static DockGuideInnerTop B8u;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Top;

	public DockGuideInnerTop()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideInnerTop);
	}

	internal static bool G8y()
	{
		return B8u == null;
	}

	internal static DockGuideInnerTop Y8V()
	{
		return B8u;
	}
}
