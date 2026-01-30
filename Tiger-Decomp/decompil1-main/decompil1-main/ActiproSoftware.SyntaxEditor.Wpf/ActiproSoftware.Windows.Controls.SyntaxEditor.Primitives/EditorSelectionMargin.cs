using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text.Undo;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Highlighting;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorSelectionMargin : EditorViewMarginBase
{
	private InputAdapter EKb;

	internal static EditorSelectionMargin rB0;

	public EditorSelectionMargin(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(7712), EditorViewMarginPlacement.ScrollableLeft, new Ordering[1]
		{
			new Ordering(Q7Z.tqM(7734), OrderPlacement.After)
		});
		base.DefaultStyleKey = typeof(EditorSelectionMargin);
		vAE.P01(this, CustomCursors.ReverseArrow);
		gK6();
	}

	private void gK6()
	{
		EKb = new InputAdapter(this);
		EKb.PointerPressed += KKH;
		EKb.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	private void KKH(object P_0, InputPointerButtonEventArgs P_1)
	{
		IEditorView view = base.View;
		if (view != null && P_1 != null && !P_1.Handled && P_1.IsPrimaryButton)
		{
			view.StartPointerSelection(P_1);
		}
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
		Brush selectionMarginBackground = context.SelectionMarginBackground;
		if (selectionMarginBackground != null)
		{
			context.FillRectangle(bounds, selectionMarginBackground);
		}
		if (!base.View.SyntaxEditor.AreLineModificationMarksVisible)
		{
			return;
		}
		Color? color = null;
		Color? color2 = null;
		Color? color3 = null;
		IHighlightingStyleRegistry highlightingStyleRegistry = base.View.HighlightingStyleRegistry;
		ITextViewLineCollection visibleViewLines = base.View.VisibleViewLines;
		foreach (ITextViewLine item in visibleViewLines)
		{
			Color? color4 = null;
			switch (item.SavePointChangeType)
			{
			case SavePointChangeType.RevertedChanges:
				if (!color.HasValue)
				{
					IHighlightingStyle highlightingStyle3 = highlightingStyleRegistry?[cT.RevertedChangesMark];
					color = ((highlightingStyle3 != null) ? highlightingStyle3.Background : new Color?(DisplayItemClassificationTypeProvider.uz));
				}
				color4 = color.Value;
				break;
			case SavePointChangeType.SavedChanges:
				if (!color2.HasValue)
				{
					IHighlightingStyle highlightingStyle2 = highlightingStyleRegistry?[cT.SavedChangesMark];
					color2 = ((highlightingStyle2 != null) ? highlightingStyle2.Background : new Color?(DisplayItemClassificationTypeProvider.gPW));
				}
				color4 = color2.Value;
				break;
			case SavePointChangeType.UnsavedChanges:
				if (!color3.HasValue)
				{
					IHighlightingStyle highlightingStyle = highlightingStyleRegistry?[cT.UnsavedChangesMark];
					color3 = ((highlightingStyle != null) ? highlightingStyle.Background : new Color?(DisplayItemClassificationTypeProvider.XPP));
				}
				color4 = color3.Value;
				break;
			}
			if (color4.HasValue)
			{
				Rect bounds2 = item.Bounds;
				context.FillRectangle(new Rect(bounds.X + 2.0, bounds.Y + bounds2.Y, Math.Max(1.0, bounds.Width - 4.0), bounds2.Height), color4.Value);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorSelectionMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsSelectionMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static bool UB7()
	{
		return rB0 == null;
	}

	internal static EditorSelectionMargin BBn()
	{
		return rB0;
	}
}
