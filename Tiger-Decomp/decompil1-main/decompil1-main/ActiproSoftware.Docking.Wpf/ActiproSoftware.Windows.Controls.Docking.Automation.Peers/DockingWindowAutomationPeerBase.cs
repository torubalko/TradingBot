using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public abstract class DockingWindowAutomationPeerBase : FrameworkElementAutomationPeer, IInvokeProvider
{
	private static DockingWindowAutomationPeerBase MCj;

	protected DockingWindowAutomationPeerBase(DockingWindow owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Pane;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetNameCore()
	{
		if (base.Owner is DockingWindow dockingWindow && !string.IsNullOrEmpty(dockingWindow.Title))
		{
			return dockingWindow.Title;
		}
		return base.GetNameCore();
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Invoke)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	public void Invoke()
	{
		if (base.Owner is DockingWindow { DockSite: not null } dockingWindow)
		{
			dockingWindow.Activate();
		}
		RaiseAutomationEvent(AutomationEvents.InvokePatternOnInvoked);
	}

	internal static bool xCt()
	{
		return MCj == null;
	}

	internal static DockingWindowAutomationPeerBase PCp()
	{
		return MCj;
	}
}
