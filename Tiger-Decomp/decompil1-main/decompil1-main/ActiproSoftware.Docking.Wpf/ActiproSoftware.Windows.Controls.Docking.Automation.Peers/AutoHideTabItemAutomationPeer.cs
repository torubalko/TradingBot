using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class AutoHideTabItemAutomationPeer : FrameworkElementAutomationPeer, IInvokeProvider
{
	private static AutoHideTabItemAutomationPeer NCl;

	public AutoHideTabItemAutomationPeer(AutoHideTabItem owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Button;
	}

	protected override string GetAutomationIdCore()
	{
		string text = base.GetAutomationIdCore();
		if (string.IsNullOrEmpty(text) && base.Owner is AutoHideTabItem { DataContext: DockingWindow dataContext } && GetParent() is AutoHideTabGroupAutomationPeer autoHideTabGroupAutomationPeer)
		{
			if (string.IsNullOrEmpty(text) && autoHideTabGroupAutomationPeer.Owner is AutoHideTabGroup autoHideTabGroup)
			{
				int num = 0;
				if (sCm() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				int num3 = autoHideTabGroup.Items.IndexOf(dataContext);
				text = vVK.ssH(23700) + num3 + vVK.ssH(23652);
			}
			string automationId = autoHideTabGroupAutomationPeer.GetAutomationId();
			if (!string.IsNullOrEmpty(automationId))
			{
				text = automationId + vVK.ssH(23562) + text;
			}
		}
		return text;
	}

	protected override string GetHelpTextCore()
	{
		if (base.Owner is AutoHideTabItem { DataContext: DockingWindow dataContext } && !string.IsNullOrEmpty(dataContext.Title))
		{
			return dataContext.Title;
		}
		return base.GetHelpTextCore();
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(23736);
	}

	protected override string GetNameCore()
	{
		if (base.Owner is AutoHideTabItem { DataContext: DockingWindow dataContext } && !string.IsNullOrEmpty(dataContext.Title))
		{
			return dataContext.Title;
		}
		return base.GetNameCore();
	}

	protected override AutomationOrientation GetOrientationCore()
	{
		if (base.Owner is AutoHideTabItem { Placement: var placement })
		{
			if (placement == Side.Top || placement == Side.Bottom)
			{
				return AutomationOrientation.Horizontal;
			}
			return AutomationOrientation.Vertical;
		}
		return AutomationOrientation.Horizontal;
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
		if (base.Owner is AutoHideTabItem { DataContext: DockingWindow { DockSite: not null } dataContext })
		{
			dataContext.Activate();
		}
		RaiseAutomationEvent(AutomationEvents.InvokePatternOnInvoked);
	}

	internal static bool YC9()
	{
		return NCl == null;
	}

	internal static AutoHideTabItemAutomationPeer sCm()
	{
		return NCl;
	}
}
