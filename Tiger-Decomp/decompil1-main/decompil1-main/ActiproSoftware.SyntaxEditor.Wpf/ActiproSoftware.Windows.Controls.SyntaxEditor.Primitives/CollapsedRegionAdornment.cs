using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class CollapsedRegionAdornment : ContentControl
{
	private InputAdapter OXO;

	private DateTime gXU;

	private Point QXJ;

	private TagSnapshotRange<CM.w7A> LXt;

	internal static CollapsedRegionAdornment aDo;

	internal string Text => LXt.Tag.Text;

	internal CollapsedRegionAdornment(TagSnapshotRange<CM.w7A> tagRange)
	{
		grA.DaB7cz();
		gXU = DateTime.Today;
		base._002Ector();
		if (tagRange == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7610));
		}
		LXt = tagRange;
		base.DefaultStyleKey = typeof(CollapsedRegionAdornment);
		oX2();
	}

	private void oX2()
	{
		OXO = new InputAdapter(this);
		OXO.PointerPressed += HX7;
		OXO.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	private void HX7(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || !P_1.IsPrimaryButton)
		{
			return;
		}
		P_1.Handled = true;
		DateTime dateTime = gXU;
		Point qXJ = QXJ;
		gXU = DateTime.Now;
		QXJ = P_1.GetPosition(this);
		IOutliningNode outliningNode = null;
		if (LXt.SnapshotRange.Snapshot.Document is IEditorDocument { OutliningManager: not null } editorDocument)
		{
			TextSnapshotRange textSnapshotRange = LXt.SnapshotRange.TranslateTo(editorDocument.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
			if (!textSnapshotRange.IsDeleted)
			{
				outliningNode = editorDocument.OutliningManager.RootNode.FindNodeRecursive(textSnapshotRange.StartOffset);
			}
		}
		if (outliningNode == null)
		{
			return;
		}
		EditorView ancestor = VisualTreeHelperExtended.GetAncestor<EditorView>(this);
		if (ancestor == null)
		{
			return;
		}
		TextSnapshotRange textSnapshotRange2 = outliningNode.SnapshotRange;
		if (textSnapshotRange2.Snapshot.Document == ancestor.CurrentSnapshot.Document)
		{
			textSnapshotRange2 = textSnapshotRange2.TranslateTo(ancestor.CurrentSnapshot, TextRangeTrackingModes.DeleteWhenZeroLength);
		}
		ancestor.Focus();
		if (vAE.L0A(qXJ, QXJ, dateTime, gXU, P_1.DeviceKind == InputDeviceKind.Touch))
		{
			if (outliningNode.Definition.IsCollapsible)
			{
				outliningNode.IsCollapsed = false;
				if (!textSnapshotRange2.IsDeleted)
				{
					ancestor.Selection.StartOffset = textSnapshotRange2.StartOffset;
				}
			}
		}
		else if (!textSnapshotRange2.IsDeleted)
		{
			if (ancestor.Selection.TextRange.NormalizedTextRange != textSnapshotRange2.TextRange || !ancestor.SyntaxEditor.AllowDrag)
			{
				ancestor.Selection.SelectRange(textSnapshotRange2.TextRange, SelectionModes.ContinuousStream);
			}
			else
			{
				P_1.Handled = false;
			}
		}
	}

	[SpecialName]
	internal TextSnapshotRange WXi()
	{
		return LXt.SnapshotRange;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new CollapsedRegionAdornmentAutomationPeer(this);
	}

	internal static bool DDQ()
	{
		return aDo == null;
	}

	internal static CollapsedRegionAdornment zDy()
	{
		return aDo;
	}
}
