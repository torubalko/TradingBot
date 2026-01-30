using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorWordWrapGlyphMarginAutomationPeer : FrameworkElementAutomationPeer
{
	internal static EditorWordWrapGlyphMarginAutomationPeer aOW;

	public EditorWordWrapGlyphMarginAutomationPeer(EditorWordWrapGlyphMargin owner)
	{
		grA.DaB7cz();
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

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196850);
	}

	internal static bool UOS()
	{
		return aOW == null;
	}

	internal static EditorWordWrapGlyphMarginAutomationPeer aOk()
	{
		return aOW;
	}
}
