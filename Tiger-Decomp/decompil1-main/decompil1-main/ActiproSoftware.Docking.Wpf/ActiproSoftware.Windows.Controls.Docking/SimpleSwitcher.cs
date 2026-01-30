using System.ComponentModel;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking;

[ToolboxItem(false)]
public class SimpleSwitcher : SwitcherBase
{
	internal static SimpleSwitcher cH0;

	public SimpleSwitcher()
	{
		IVH.CecNqz();
		base._002Ector(canSortByLastFocusedDateTime: false);
	}

	protected override void OnSelectedWindowChanged(DockingWindow oldValue, DockingWindow newValue)
	{
		base.OnSelectedWindowChanged(oldValue, newValue);
		if (newValue != null && !cP.NlZ(newValue))
		{
			newValue.Activate();
		}
	}

	internal static bool dH1()
	{
		return cH0 == null;
	}

	internal static SimpleSwitcher jHH()
	{
		return cH0;
	}
}
