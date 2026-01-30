using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Primitives;

namespace ActiproSoftware.Windows.Controls.Editors.Automation.Peers;

public class PickerBaseAutomationPeer : FrameworkElementAutomationPeer
{
	internal static PickerBaseAutomationPeer sA3;

	public PickerBaseAutomationPeer(PickerBase owner)
	{
		awj.QuEwGz();
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

	[SuppressMessage("Microsoft.Globalization", "CA1308:NormalizeStringsToUppercase")]
	protected override string GetLocalizedControlTypeCore()
	{
		string text = base.Owner.GetType().Name.ToLowerInvariant();
		if (!text.EndsWith(QdM.AR8(30230), StringComparison.OrdinalIgnoreCase))
		{
			return text;
		}
		return text.Substring(0, text.Length - 6) + QdM.AR8(30246);
	}

	internal static bool EAb()
	{
		return sA3 == null;
	}

	internal static PickerBaseAutomationPeer jAd()
	{
		return sA3;
	}
}
