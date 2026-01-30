using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideOuterLeft : DockGuideBase
{
	internal static DockGuideOuterLeft Un0;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Left;

	public DockGuideOuterLeft()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideOuterLeft);
	}

	internal static bool Tn1()
	{
		return Un0 == null;
	}

	internal static DockGuideOuterLeft LnH()
	{
		return Un0;
	}
}
