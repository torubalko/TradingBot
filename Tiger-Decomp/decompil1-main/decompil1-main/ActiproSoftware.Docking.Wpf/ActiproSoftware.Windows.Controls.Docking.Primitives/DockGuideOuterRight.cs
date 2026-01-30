using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideOuterRight : DockGuideBase
{
	internal static DockGuideOuterRight Enf;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Right;

	public DockGuideOuterRight()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideOuterRight);
	}

	internal static bool Nn8()
	{
		return Enf == null;
	}

	internal static DockGuideOuterRight qnn()
	{
		return Enf;
	}
}
