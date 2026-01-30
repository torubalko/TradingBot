using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class StandardSwitcherItemAutomationPeer : FrameworkElementAutomationPeer, IInvokeProvider, ISelectionItemProvider
{
	private static StandardSwitcherItemAutomationPeer rCT;

	public bool IsSelected
	{
		get
		{
			if (!(base.Owner is StandardSwitcherItem standardSwitcherItem))
			{
				return false;
			}
			return standardSwitcherItem.IsSelected;
		}
	}

	public IRawElementProviderSimple SelectionContainer
	{
		get
		{
			if (GetParent() is StandardSwitcherAutomationPeer peer)
			{
				return ProviderFromPeer(peer);
			}
			return null;
		}
	}

	public StandardSwitcherItemAutomationPeer(StandardSwitcherItem owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	public void AddToSelection()
	{
		Select();
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.ListItem;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		return new List<AutomationPeer>();
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24040);
	}

	protected override string GetNameCore()
	{
		if (base.Owner is StandardSwitcherItem { DockingWindow: { } dockingWindow })
		{
			return dockingWindow.Title;
		}
		return base.GetNameCore();
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Invoke || patternInterface == PatternInterface.SelectionItem)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	public void Invoke()
	{
		if (base.Owner is StandardSwitcherItem { DockingWindow: { } dockingWindow })
		{
			dockingWindow.Activate();
		}
		RaiseAutomationEvent(AutomationEvents.InvokePatternOnInvoked);
	}

	public void RemoveFromSelection()
	{
	}

	public void Select()
	{
		if (base.Owner is StandardSwitcherItem { DockingWindow: { } selectedWindow } && GetParent() is StandardSwitcherAutomationPeer { Owner: StandardSwitcher owner })
		{
			owner.SelectedWindow = selectedWindow;
		}
	}

	internal static bool FCx()
	{
		return rCT == null;
	}

	internal static StandardSwitcherItemAutomationPeer tCR()
	{
		return rCT;
	}
}
