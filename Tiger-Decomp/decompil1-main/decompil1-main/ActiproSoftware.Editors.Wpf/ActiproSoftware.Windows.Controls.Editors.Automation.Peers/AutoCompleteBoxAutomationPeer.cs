using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class AutoCompleteBoxAutomationPeer : FrameworkElementAutomationPeer, IExpandCollapseProvider, IValueProvider
{
	internal static AutoCompleteBoxAutomationPeer nAm;

	public ExpandCollapseState ExpandCollapseState
	{
		get
		{
			AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
			return autoCompleteBox.IsPopupOpen ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
			return autoCompleteBox.IsReadOnly;
		}
	}

	public string Value
	{
		get
		{
			AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
			return autoCompleteBox.Text;
		}
	}

	public AutoCompleteBoxAutomationPeer(AutoCompleteBox owner)
	{
		awj.QuEwGz();
		base._002Ector(owner);
	}

	public void Collapse()
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
		autoCompleteBox.IsPopupOpen = false;
	}

	public void Expand()
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
		autoCompleteBox.IsPopupOpen = true;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Edit;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	protected override string GetLocalizedControlTypeCore()
	{
		return QdM.AR8(30032);
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.Value || patternInterface == PatternInterface.ExpandCollapse)
		{
			return this;
		}
		return base.GetPattern(patternInterface);
	}

	public void SetValue(string value)
	{
		AutoCompleteBox autoCompleteBox = (AutoCompleteBox)base.Owner;
		autoCompleteBox.Text = value;
	}

	internal static bool oAP()
	{
		return nAm == null;
	}

	internal static AutoCompleteBoxAutomationPeer sA8()
	{
		return nAm;
	}
}
