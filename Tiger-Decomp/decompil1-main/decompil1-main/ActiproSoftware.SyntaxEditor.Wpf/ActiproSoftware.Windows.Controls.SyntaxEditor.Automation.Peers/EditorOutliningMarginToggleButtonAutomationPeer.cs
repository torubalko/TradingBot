using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;

public class EditorOutliningMarginToggleButtonAutomationPeer : AutomationPeer, IExpandCollapseProvider
{
	private EditorOutliningMargin Enf;

	private Rect hnD;

	private TextSnapshotRange Fng;

	internal static EditorOutliningMarginToggleButtonAutomationPeer GOm;

	public ExpandCollapseState ExpandCollapseState
	{
		get
		{
			IEditorView view = Enf.View;
			if (view != null)
			{
				IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
				if (outliningManager != null)
				{
					OutliningState outliningState = outliningManager.GetOutliningState(new TextSnapshotRange(view.CurrentSnapshot, Fng.StartOffset, Fng.EndOffset));
					return ((outliningState & OutliningState.HasCollapsedNode) != OutliningState.HasCollapsedNode) ? ExpandCollapseState.Expanded : ExpandCollapseState.Collapsed;
				}
			}
			return ExpandCollapseState.Expanded;
		}
	}

	public EditorOutliningMarginToggleButtonAutomationPeer(EditorOutliningMargin owner, TextSnapshotRange viewLineSnapshotRange, Rect viewLineBounds)
	{
		grA.DaB7cz();
		base._002Ector();
		Enf = owner;
		Fng = viewLineSnapshotRange;
		hnD = viewLineBounds;
	}

	public void Collapse()
	{
		IEditorView view = Enf.View;
		if (view == null)
		{
			return;
		}
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(Fng);
		if (startingNodes == null)
		{
			return;
		}
		foreach (IOutliningNode item in startingNodes)
		{
			if (!item.IsCollapsed)
			{
				item.IsCollapsed = true;
			}
			InvalidatePeer();
		}
	}

	public void Expand()
	{
		IEditorView view = Enf.View;
		if (view == null)
		{
			return;
		}
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(Fng);
		if (startingNodes == null)
		{
			return;
		}
		foreach (IOutliningNode item in startingNodes)
		{
			if (item.IsCollapsed)
			{
				item.IsCollapsed = false;
			}
			InvalidatePeer();
		}
	}

	protected override string GetAcceleratorKeyCore()
	{
		return null;
	}

	protected override string GetAccessKeyCore()
	{
		return null;
	}

	protected override AutomationControlType GetAutomationControlTypeCore()
	{
		return AutomationControlType.Button;
	}

	protected override string GetAutomationIdCore()
	{
		return Q7Z.tqM(196578) + Fng.StartPosition.DisplayLine;
	}

	protected override Rect GetBoundingRectangleCore()
	{
		AutomationPeer automationPeer = UIElementAutomationPeer.FromElement(Enf);
		if (automationPeer != null)
		{
			int num = 0;
			if (cO4() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
			{
				Rect boundingRectangle = automationPeer.GetBoundingRectangle();
				return new Rect(boundingRectangle.Left, boundingRectangle.Top + hnD.Y, boundingRectangle.Width, hnD.Height);
			}
			}
		}
		return default(Rect);
	}

	protected override string GetClassNameCore()
	{
		return Q7Z.tqM(196610);
	}

	[SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists")]
	protected override List<AutomationPeer> GetChildrenCore()
	{
		return null;
	}

	protected override Point GetClickablePointCore()
	{
		return default(Point);
	}

	protected override string GetHelpTextCore()
	{
		return null;
	}

	protected override string GetItemStatusCore()
	{
		StringBuilder stringBuilder = new StringBuilder();
		IEditorView view = Enf.View;
		if (view != null)
		{
			IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
			if (outliningManager != null)
			{
				IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(Fng);
				if (startingNodes != null)
				{
					foreach (IOutliningNode item in startingNodes)
					{
						if (stringBuilder.Length > 0)
						{
							stringBuilder.Append(Q7Z.tqM(191762));
						}
						TextSnapshotRange snapshotRange = item.SnapshotRange;
						stringBuilder.Append(snapshotRange.StartPosition.DisplayLine);
						stringBuilder.Append(Q7Z.tqM(196626));
						stringBuilder.Append(snapshotRange.StartPosition.DisplayCharacter);
						stringBuilder.Append(Q7Z.tqM(196632));
						if (!item.IsOpen)
						{
							stringBuilder.Append(snapshotRange.EndPosition.DisplayLine);
							stringBuilder.Append(Q7Z.tqM(196626));
							stringBuilder.Append(snapshotRange.EndPosition.DisplayCharacter);
						}
					}
				}
			}
		}
		return stringBuilder.ToString();
	}

	protected override string GetItemTypeCore()
	{
		return null;
	}

	protected override AutomationPeer GetLabeledByCore()
	{
		return null;
	}

	protected override string GetLocalizedControlTypeCore()
	{
		return Q7Z.tqM(196638);
	}

	protected override string GetNameCore()
	{
		return Q7Z.tqM(196668);
	}

	protected override AutomationOrientation GetOrientationCore()
	{
		return AutomationOrientation.None;
	}

	public override object GetPattern(PatternInterface patternInterface)
	{
		if (patternInterface == PatternInterface.ExpandCollapse)
		{
			return this;
		}
		return null;
	}

	protected override bool HasKeyboardFocusCore()
	{
		return false;
	}

	protected override bool IsContentElementCore()
	{
		return true;
	}

	protected override bool IsControlElementCore()
	{
		return true;
	}

	protected override bool IsEnabledCore()
	{
		return true;
	}

	protected override bool IsKeyboardFocusableCore()
	{
		return false;
	}

	protected override bool IsOffscreenCore()
	{
		return false;
	}

	protected override bool IsPasswordCore()
	{
		return false;
	}

	protected override bool IsRequiredForFormCore()
	{
		return false;
	}

	protected override void SetFocusCore()
	{
	}

	internal static bool vOp()
	{
		return GOm == null;
	}

	internal static EditorOutliningMarginToggleButtonAutomationPeer cO4()
	{
		return GOm;
	}
}
