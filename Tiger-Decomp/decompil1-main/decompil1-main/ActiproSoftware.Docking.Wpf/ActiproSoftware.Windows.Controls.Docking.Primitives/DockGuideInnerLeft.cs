using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideInnerLeft : DockGuideBase
{
	private static DockGuideInnerLeft p8k;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Left;

	public DockGuideInnerLeft()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideInnerLeft);
	}

	internal static bool V8q()
	{
		return p8k == null;
	}

	internal static DockGuideInnerLeft l8w()
	{
		return p8k;
	}
}
