using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideOuterBottom : DockGuideBase
{
	internal static DockGuideOuterBottom s83;

	public override Side? Side => ActiproSoftware.Windows.Controls.Side.Bottom;

	public DockGuideOuterBottom()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideOuterBottom);
	}

	internal static bool S8r()
	{
		return s83 == null;
	}

	internal static DockGuideOuterBottom Y8z()
	{
		return s83;
	}
}
