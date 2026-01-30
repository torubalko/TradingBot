using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideOuterTop : DockGuideBase
{
	private static DockGuideOuterTop AnA;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Top;

	public DockGuideOuterTop()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideOuterTop);
	}

	internal static bool unY()
	{
		return AnA == null;
	}

	internal static DockGuideOuterTop JnC()
	{
		return AnA;
	}
}
