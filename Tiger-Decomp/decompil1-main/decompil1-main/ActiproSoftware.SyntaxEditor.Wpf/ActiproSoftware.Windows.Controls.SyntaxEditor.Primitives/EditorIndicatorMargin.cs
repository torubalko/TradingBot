using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Text;
using ActiproSoftware.Text.Tagging;
using ActiproSoftware.Text.Tagging.Implementation;
using ActiproSoftware.Text.Utility;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorIndicatorMargin : EditorViewMarginBase
{
	private ITagAggregator<IIndicatorTag> zXz;

	private static EditorIndicatorMargin QDC;

	public EditorIndicatorMargin(IEditorView view)
	{
		grA.DaB7cz();
		base._002Ector(view, Q7Z.tqM(7664), EditorViewMarginPlacement.ScrollableLeft, new Ordering[3]
		{
			new Ordering(Q7Z.tqM(7686), OrderPlacement.After),
			new Ordering(Q7Z.tqM(7712), OrderPlacement.After),
			new Ordering(Q7Z.tqM(7734), OrderPlacement.After)
		});
		base.DefaultStyleKey = typeof(EditorIndicatorMargin);
		zXz = view.CreateTagAggregator<IIndicatorTag>();
		zXz.TagsChanged += sXN;
		view.MarginsDestroyed += aXd;
	}

	private bool cXh(TagSnapshotRange<IIndicatorTag> P_0)
	{
		bool flag = P_0.Tag is BookmarkIndicatorTag;
		TextSnapshotRange snapshotRange = P_0.SnapshotRange;
		TextSnapshotRange collapsedRange = base.View.CollapsedRegionManager.GetCollapsedRange(new TextSnapshotOffset(snapshotRange.Snapshot, snapshotRange.StartOffset));
		if (flag)
		{
			return !collapsedRange.IsDeleted && collapsedRange.StartOffset < snapshotRange.StartOffset && collapsedRange.EndOffset > snapshotRange.StartOffset;
		}
		return !collapsedRange.IsDeleted && (snapshotRange.IsZeroLength || collapsedRange.Contains(snapshotRange.EndOffset - 1));
	}

	private void sXN(object P_0, TagsChangedEventArgs P_1)
	{
		base.View.InvalidateRender();
	}

	private void aXd(object P_0, EventArgs P_1)
	{
		base.View.MarginsDestroyed -= aXd;
		if (zXz != null)
		{
			zXz.TagsChanged -= sXN;
			zXz.Dispose();
			zXz = null;
		}
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
		Thickness padding = base.Padding;
		Brush indicatorMarginBackground = context.IndicatorMarginBackground;
		if (indicatorMarginBackground != null)
		{
			context.FillRectangle(bounds, indicatorMarginBackground);
		}
		bool flag = zXz != null;
		int num = 0;
		if (TDX() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (!flag)
		{
			return;
		}
		ITextViewLineCollection visibleViewLines = base.View.VisibleViewLines;
		foreach (DAp item in visibleViewLines)
		{
			IEnumerable<TagSnapshotRange<IIndicatorTag>> tags = zXz.GetTags(new NormalizedTextSnapshotRangeCollection(item.SnapshotRangeIncludingLineTerminator), null);
			if (tags == null)
			{
				continue;
			}
			foreach (TagSnapshotRange<IIndicatorTag> item2 in tags)
			{
				IIndicatorTag tag = item2.Tag;
				if (tag != null && item.SnapshotRange.IntersectsWith(item2.SnapshotRange.StartOffset) && !cXh(item2))
				{
					Rect bounds2 = new Rect(bounds.X + padding.Left, bounds.Y + item.TextBounds.Y, Math.Max(0.0, bounds.Width - padding.Left - padding.Right), item.TextBounds.Height);
					tag.DrawGlyph(context, item, item2, bounds2);
				}
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorIndicatorMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsIndicatorMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static bool dDr()
	{
		return QDC == null;
	}

	internal static EditorIndicatorMargin TDX()
	{
		return QDC;
	}
}
