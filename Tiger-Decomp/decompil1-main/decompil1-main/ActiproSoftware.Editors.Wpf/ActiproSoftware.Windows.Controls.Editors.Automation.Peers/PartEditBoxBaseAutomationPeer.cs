using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class PartEditBoxBaseAutomationPeer<T> : FrameworkElementAutomationPeer, IExpandCollapseProvider, IToggleProvider, IValueProvider
{
	private static object XAK;

	public ExpandCollapseState ExpandCollapseState
	{
		get
		{
			PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
			return partEditBoxBase.IsPopupOpen ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed;
		}
	}

	public bool IsReadOnly
	{
		get
		{
			PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
			return partEditBoxBase.IsReadOnly;
		}
	}

	public ToggleState ToggleState => (ExpandCollapseState == ExpandCollapseState.Expanded) ? ToggleState.On : ToggleState.Off;

	public string Value
	{
		get
		{
			PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
			return partEditBoxBase.ConvertToString(partEditBoxBase.Value);
		}
	}

	public PartEditBoxBaseAutomationPeer(PartEditBoxBase<T> owner)
	{
		awj.QuEwGz();
		base._002Ector(owner);
	}

	public void Collapse()
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
		partEditBoxBase.IsPopupOpen = false;
	}

	public void Expand()
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
		partEditBoxBase.IsPopupOpen = true;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Spinner;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	protected override string GetLocalizedControlTypeCore()
	{
		string text = base.Owner.GetType().Name.ToLowerInvariant();
		if (text.EndsWith(QdM.AR8(30190), StringComparison.OrdinalIgnoreCase))
		{
			return text.Substring(0, text.Length - 7) + QdM.AR8(30208);
		}
		return text;
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface != PatternInterface.Value && patternInterface != PatternInterface.ExpandCollapse && patternInterface != PatternInterface.Toggle)
		{
			return base.GetPattern(patternInterface);
		}
		return this;
	}

	public void SetValue(string value)
	{
		PartEditBoxBase<T> partEditBoxBase = (PartEditBoxBase<T>)base.Owner;
		if (partEditBoxBase.TryConvertFromString(value, canCoerce: true, out var value2))
		{
			partEditBoxBase.Value = value2;
		}
	}

	public void Toggle()
	{
		if (ExpandCollapseState == ExpandCollapseState.Collapsed)
		{
			Expand();
		}
		else
		{
			Collapse();
		}
	}

	internal static bool vAC()
	{
		return XAK == null;
	}

	internal static object oAE()
	{
		return XAK;
	}
}
