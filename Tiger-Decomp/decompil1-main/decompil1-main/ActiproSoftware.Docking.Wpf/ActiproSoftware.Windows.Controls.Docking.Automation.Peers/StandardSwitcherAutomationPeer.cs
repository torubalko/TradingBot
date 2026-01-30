using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Primitives;

namespace ActiproSoftware.Windows.Controls.Docking.Automation.Peers;

public class StandardSwitcherAutomationPeer : FrameworkElementAutomationPeer, ISelectionProvider
{
	internal static StandardSwitcherAutomationPeer MC7;

	public bool CanSelectMultiple => false;

	public bool IsSelectionRequired => true;

	public StandardSwitcherAutomationPeer(StandardSwitcher owner)
	{
		IVH.CecNqz();
		base._002Ector(owner);
	}

	internal void YR7()
	{
		RaiseAutomationEvent(AutomationEvents.SelectionPatternOnInvalidated);
		if (base.Owner is StandardSwitcher standardSwitcher)
		{
			StandardSwitcherItem standardSwitcherItem = standardSwitcher.qWN();
			if (standardSwitcherItem != null)
			{
				UIElementAutomationPeer.CreatePeerForElement(standardSwitcherItem)?.RaiseAutomationEvent(AutomationEvents.SelectionItemPatternOnElementSelected);
			}
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.List;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = new List<AutomationPeer>();
		if (base.Owner is StandardSwitcher standardSwitcher && standardSwitcher.rWp() != null)
		{
			foreach (object child in standardSwitcher.rWp().Children)
			{
				if (child is StandardSwitcherItem element)
				{
					AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(element);
					if (automationPeer != null)
					{
						list.Add(automationPeer);
					}
				}
			}
		}
		return list;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	protected override Point GetClickablePointCore()
	{
		return new Point(double.NaN, double.NaN);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return vVK.ssH(24002);
	}

	protected override string GetNameCore()
	{
		return vVK.ssH(12938);
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Selection)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	public IRawElementProviderSimple[] GetSelection()
	{
		List<IRawElementProviderSimple> list = new List<IRawElementProviderSimple>();
		if (base.Owner is StandardSwitcher standardSwitcher)
		{
			StandardSwitcherItem standardSwitcherItem = standardSwitcher.qWN();
			if (standardSwitcherItem != null)
			{
				AutomationPeer automationPeer = UIElementAutomationPeer.CreatePeerForElement(standardSwitcherItem);
				if (automationPeer != null)
				{
					IRawElementProviderSimple rawElementProviderSimple = ProviderFromPeer(automationPeer);
					if (rawElementProviderSimple != null)
					{
						list.Add(rawElementProviderSimple);
					}
				}
			}
		}
		return list.ToArray();
	}

	internal static bool qCO()
	{
		return MC7 == null;
	}

	internal static StandardSwitcherAutomationPeer eCb()
	{
		return MC7;
	}
}
