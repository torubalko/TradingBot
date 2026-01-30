using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class CollapsedRegionAdornmentAutomationPeer : FrameworkElementAutomationPeer
{
	private static CollapsedRegionAdornmentAutomationPeer PR6;

	public CollapsedRegionAdornmentAutomationPeer(CollapsedRegionAdornment owner)
	{
		grA.DaB7cz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Custom;
	}

	protected override string GetAutomationIdCore()
	{
		CollapsedRegionAdornment collapsedRegionAdornment = (CollapsedRegionAdornment)base.Owner;
		TextSnapshotRange textSnapshotRange = collapsedRegionAdornment.WXi();
		return base.GetAutomationIdCore() + Q7Z.tqM(196380) + textSnapshotRange.StartPosition.DisplayLine + Q7Z.tqM(196388) + textSnapshotRange.StartPosition.DisplayCharacter;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		return null;
	}

	protected override string GetClassNameCore()
	{
		return base.Owner.GetType().Name;
	}

	[SuppressMessage("Microsoft.Globalization", "CA1305:SpecifyIFormatProvider", MessageId = "System.String.Format(System.String,System.Object[])")]
	protected override string GetItemStatusCore()
	{
		CollapsedRegionAdornment collapsedRegionAdornment = (CollapsedRegionAdornment)base.Owner;
		TextSnapshotRange textSnapshotRange = collapsedRegionAdornment.WXi();
		return string.Format(Q7Z.tqM(196396), textSnapshotRange.StartPosition.DisplayLine, textSnapshotRange.StartPosition.DisplayCharacter, textSnapshotRange.EndPosition.DisplayLine, textSnapshotRange.EndPosition.DisplayCharacter);
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196430);
	}

	protected override string GetNameCore()
	{
		CollapsedRegionAdornment collapsedRegionAdornment = (CollapsedRegionAdornment)base.Owner;
		return collapsedRegionAdornment.Text;
	}

	internal static bool rRK()
	{
		return PR6 == null;
	}

	internal static CollapsedRegionAdornmentAutomationPeer vRC()
	{
		return PR6;
	}
}
