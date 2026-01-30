using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideInnerRight : DockGuideBase
{
	internal static DockGuideInnerRight d8g;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Right;

	public DockGuideInnerRight()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideInnerRight);
	}

	internal static bool h8i()
	{
		return d8g == null;
	}

	internal static DockGuideInnerRight P8Z()
	{
		return d8g;
	}
}
