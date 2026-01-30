using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Automation.Peers;

public class PropertyGridAutomationPeer : TreeListViewAutomationPeer
{
	private static PropertyGridAutomationPeer Jsp;

	public PropertyGridAutomationPeer(PropertyGrid owner)
	{
		fc.taYSkz();
		base._002Ector(owner);
	}

	protected override ItemAutomationPeer CreateItemAutomationPeer(object item)
	{
		return new PropertyGridItemAutomationPeer(item, this);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return xv.hTz(10228);
	}

	internal static bool Xsr()
	{
		return Jsp == null;
	}

	internal static PropertyGridAutomationPeer Lsd()
	{
		return Jsp;
	}
}
