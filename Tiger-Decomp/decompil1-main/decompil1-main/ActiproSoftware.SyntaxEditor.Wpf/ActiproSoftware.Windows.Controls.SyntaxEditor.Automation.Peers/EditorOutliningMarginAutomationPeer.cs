using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorOutliningMarginAutomationPeer : FrameworkElementAutomationPeer
{
	internal static EditorOutliningMarginAutomationPeer tRU;

	public EditorOutliningMarginAutomationPeer(EditorOutliningMargin owner)
	{
		grA.DaB7cz();
		base._002Ector(owner);
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Pane;
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		List<AutomationPeer> list = base.GetChildrenCore();
		EditorOutliningMargin editorOutliningMargin = (EditorOutliningMargin)base.Owner;
		IEditorView view = editorOutliningMargin.View;
		if (view != null)
		{
			IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
			if (outliningManager != null)
			{
				ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
				foreach (ITextViewLine item in visibleViewLines)
				{
					OutliningState outliningState = outliningManager.GetOutliningState(new TextSnapshotRange(view.CurrentSnapshot, item.StartOffset, item.EndOffset));
					bool flag = (outliningState & OutliningState.HasExpandedNodeStart) == OutliningState.HasExpandedNodeStart;
					bool flag2 = (outliningState & OutliningState.HasCollapsedNode) == OutliningState.HasCollapsedNode;
					if (flag || flag2)
					{
						if (list == null)
						{
							list = new List<AutomationPeer>();
						}
						list.Add(new EditorOutliningMarginToggleButtonAutomationPeer(editorOutliningMargin, item.SnapshotRangeIncludingLineTerminator, item.Bounds));
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

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196542);
	}

	internal static bool xRe()
	{
		return tRU == null;
	}

	internal static EditorOutliningMarginAutomationPeer RRz()
	{
		return tRU;
	}
}
