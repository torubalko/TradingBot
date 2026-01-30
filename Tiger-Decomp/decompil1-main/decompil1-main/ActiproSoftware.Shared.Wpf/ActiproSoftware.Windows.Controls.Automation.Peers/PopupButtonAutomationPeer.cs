using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Automation.Peers;

public class PopupButtonAutomationPeer : ButtonAutomationPeer, IExpandCollapseProvider
{
	internal static PopupButtonAutomationPeer f1k;

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	ExpandCollapseState IExpandCollapseProvider.ExpandCollapseState
	{
		get
		{
			PopupButton popupButton = (PopupButton)base.Owner;
			ExpandCollapseState result;
			if (PopupButtonDisplayMode.ButtonOnly != popupButton.DisplayMode)
			{
				if (!popupButton.IsPopupOpen)
				{
					result = ExpandCollapseState.Collapsed;
					int num = 0;
					if (!R1F())
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					}
				}
				else
				{
					result = ExpandCollapseState.Expanded;
				}
			}
			else
			{
				result = ExpandCollapseState.LeafNode;
			}
			return result;
		}
	}

	public PopupButtonAutomationPeer(PopupButton owner)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector(owner);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
	{
		if (oldValue != newValue)
		{
			RaisePropertyChangedEvent(ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, oldValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed, newValue ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed);
		}
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		PopupButton popupButton = (PopupButton)base.Owner;
		if (PopupButtonDisplayMode.Split != popupButton.DisplayMode)
		{
			return base.GetAutomationControlTypeCore();
		}
		return AutomationControlType.SplitButton;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Invoke)
		{
			PopupButton popupButton = (PopupButton)base.Owner;
			if (PopupButtonDisplayMode.PopupOnly != popupButton.DisplayMode)
			{
				return this;
			}
		}
		else if (PatternInterface.ExpandCollapse == patternInterface)
		{
			int num = 0;
			if (k1d() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			PopupButton popupButton2 = (PopupButton)base.Owner;
			if (PopupButtonDisplayMode.ButtonOnly != popupButton2.DisplayMode)
			{
				return this;
			}
		}
		return null;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IExpandCollapseProvider.Collapse()
	{
		PopupButton popupButton = (PopupButton)base.Owner;
		popupButton.IsPopupOpen = false;
	}

	[SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
	void IExpandCollapseProvider.Expand()
	{
		PopupButton popupButton = (PopupButton)base.Owner;
		popupButton.IsPopupOpen = true;
	}

	internal static bool R1F()
	{
		return f1k == null;
	}

	internal static PopupButtonAutomationPeer k1d()
	{
		return f1k;
	}
}
