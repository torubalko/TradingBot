using System.ComponentModel;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class DockingWindowContainerTabItem : AdvancedTabItem
{
	internal static DockingWindowContainerTabItem nnl;

	public DockingWindowContainerTabItem()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(DockingWindowContainerTabItem);
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new DockingWindowContainerTabItemAutomationPeer(this);
	}

	internal static bool in9()
	{
		return nnl == null;
	}

	internal static DockingWindowContainerTabItem lnm()
	{
		return nnl;
	}
}
