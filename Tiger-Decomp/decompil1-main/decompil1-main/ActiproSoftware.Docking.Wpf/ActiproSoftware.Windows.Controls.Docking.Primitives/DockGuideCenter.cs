using System.ComponentModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockGuideCenter : DockGuideBase
{
	private static DockGuideCenter N8d;

	public override Side? Side => null;

	public DockGuideCenter()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockGuideCenter);
	}

	internal static bool z87()
	{
		return N8d == null;
	}

	internal static DockGuideCenter u8O()
	{
		return N8d;
	}
}
