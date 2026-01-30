using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.SyntaxEditor;
using ActiproSoftware.Text;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Adornments;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Automation.Peers;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Outlining;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorOutliningMargin : EditorViewMarginBase
{
	private InputAdapter jKF;

	private TextSnapshotRange? QK3;

	private DateTime eKR;

	private Point PKY;

	private static EditorOutliningMargin uD8;

	public EditorOutliningMargin(IEditorView view)
	{
		grA.DaB7cz();
		eKR = DateTime.Today;
		base._002Ector(view, Q7Z.tqM(7734), EditorViewMarginPlacement.ScrollableLeft, null);
		base.DefaultStyleKey = typeof(EditorOutliningMargin);
		vAE.P01(this, CustomCursors.ReverseArrow);
		jKf();
		wKK();
	}

	private void wKK()
	{
		base.View.GetAdornmentLayer(AdornmentLayerDefinitions.Highlight)?.AddAdornment(AdornmentChangeReason.Other, VKe, default(Rect), this, null);
	}

	private void jKf()
	{
		jKF = new InputAdapter(this);
		jKF.PointerExited += HKl;
		jKF.PointerMoved += RKA;
		jKF.PointerPressed += yKv;
		jKF.AttachedEventKinds = InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed;
	}

	private void OKD(IOutliningNode P_0)
	{
		if (P_0 == null)
		{
			return;
		}
		foreach (IOutliningNode item in P_0)
		{
			if (item == null || item.IsCollapsed || item.SnapshotRange.StartPosition.Line != P_0.SnapshotRange.StartPosition.Line)
			{
				break;
			}
			OKD(item);
		}
		P_0.IsCollapsed = true;
	}

	private static Rect DKg(Rect P_0)
	{
		int num = Math.Max(5, (int)Math.Min(P_0.Width - 2.0, P_0.Height));
		if (num % 2 == 0)
		{
			num--;
		}
		return new Rect(P_0.X + (double)(int)Math.Round((P_0.Width - (double)num) / 2.0, MidpointRounding.AwayFromZero), P_0.Y + (double)(int)Math.Round((P_0.Height - (double)num) / 2.0, MidpointRounding.AwayFromZero), num, num);
	}

	private IOutliningNode RKQ(ITextViewLine P_0)
	{
		IEditorView view = base.View;
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return null;
		}
		IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(new TextSnapshotRange(view.CurrentSnapshot, P_0.StartOffset, P_0.EndOffsetIncludingLineTerminator));
		if (startingNodes == null)
		{
			return null;
		}
		IOutliningNode outliningNode = null;
		foreach (IOutliningNode item in startingNodes)
		{
			if (item == null)
			{
				continue;
			}
			if (item.IsCollapsed)
			{
				return null;
			}
			outliningNode = item;
			break;
		}
		if (outliningNode == null && outliningManager.RootNode != null && outliningManager.GetOutliningState(new TextSnapshotRange(view.CurrentSnapshot, P_0.StartOffset, P_0.EndOffsetIncludingLineTerminator)) != OutliningState.None)
		{
			outliningNode = outliningManager.RootNode.FindNodeRecursive(P_0.StartOffset);
			while (outliningNode != null && (outliningNode.IsCollapsed || outliningNode.IsRoot))
			{
				outliningNode = outliningNode.ParentNode;
			}
		}
		return outliningNode;
	}

	[SpecialName]
	internal TextSnapshotRange? zKC()
	{
		return QK3;
	}

	[SpecialName]
	internal void GKu(TextSnapshotRange? value)
	{
		if (QK3 != value)
		{
			QK3 = value;
			if (base.View is EditorView editorView)
			{
				editorView.Gf1((vTP)4);
			}
		}
	}

	private void VKe(TextViewDrawContext P_0, IAdornment P_1)
	{
		if (base.Visibility != Visibility.Visible || !QK3.HasValue)
		{
			return;
		}
		Brush collapsibleRegionBackground = P_0.CollapsibleRegionBackground;
		if (collapsibleRegionBackground != null)
		{
			Rect? rect = YAT.B6w(base.View, QK3.Value);
			if (rect.HasValue)
			{
				double num = 0.0 - base.View.SyntaxEditor.BorderThickness.Top;
				Rect value = rect.Value;
				value.Y += (base.View.TextAreaViewportBounds.Y + num) / base.View.ZoomLevel;
				Rect clipBounds = P_0.ClipBounds;
				clipBounds.Intersect(value);
				P_0.FillRectangle(clipBounds, collapsibleRegionBackground);
			}
		}
	}

	private void HKl(object P_0, InputPointerEventArgs P_1)
	{
		GKu(null);
	}

	private void RKA(object P_0, InputPointerEventArgs P_1)
	{
		IEditorView view = base.View;
		if (view != null && P_1 != null)
		{
			Point position = P_1.GetPosition(view.SyntaxEditor);
			IHitTestResult hitTestResult = view.SyntaxEditor.HitTest(position);
			YKm(hitTestResult);
		}
	}

	private void yKv(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 == null || !P_1.IsPrimaryButton)
		{
			return;
		}
		IEditorView view = base.View;
		DateTime dateTime = eKR;
		Point pKY = PKY;
		eKR = DateTime.Now;
		PKY = P_1.GetPosition(view.SyntaxEditor);
		bool flag = vAE.L0A(pKY, PKY, dateTime, eKR, P_1.DeviceKind == InputDeviceKind.Touch);
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		IHitTestResult hitTestResult = view.SyntaxEditor.HitTest(PKY);
		ITextViewLine textViewLine = ((hitTestResult.ViewMargin == this) ? hitTestResult.ViewLine : null);
		if (textViewLine == null)
		{
			return;
		}
		double actualWidth = base.ActualWidth;
		Rect textBounds = textViewLine.TextBounds;
		Rect rect = new Rect(0.0, textBounds.Y, actualWidth, textBounds.Height);
		Point position = P_1.GetPosition(this);
		if (DKg(rect).Contains(position))
		{
			P_1.Handled = true;
			IEnumerable<IOutliningNode> startingNodes = outliningManager.GetStartingNodes(new TextSnapshotRange(view.CurrentSnapshot, textViewLine.StartOffset, textViewLine.EndOffsetIncludingLineTerminator));
			if (startingNodes != null)
			{
				bool flag2 = false;
				bool flag3 = true;
				TextRange textRange = TextRange.Deleted;
				foreach (IOutliningNode item in startingNodes)
				{
					if (item != null && item.IsCollapsed)
					{
						TextRange textRange2 = item.SnapshotRange.TextRange;
						if (!textRange.IsDeleted && textRange.Contains(textRange2))
						{
							break;
						}
						textRange = textRange2;
						item.IsCollapsed = false;
						flag3 = false;
						flag2 = true;
					}
				}
				if (flag3)
				{
					foreach (IOutliningNode item2 in startingNodes)
					{
						if (item2 != null && !item2.IsCollapsed)
						{
							OKD(item2);
							flag2 = true;
						}
					}
				}
				if (flag2)
				{
					eKR = EditorView.LDA;
					return;
				}
			}
		}
		if (flag)
		{
			IOutliningNode outliningNode = RKQ(textViewLine);
			if (outliningNode != null)
			{
				outliningNode.IsCollapsed = true;
			}
		}
	}

	private void YKm(IHitTestResult P_0)
	{
		if (P_0 != null)
		{
			IEditorView view = base.View;
			if (view != null && view.SyntaxEditor != null && view.SyntaxEditor.IsCollapsibleRegionHighlightingEnabled)
			{
				ITextViewLine viewLine = P_0.ViewLine;
				if (viewLine != null)
				{
					GKu(RKQ(viewLine)?.SnapshotRange);
					int num = 0;
					if (EDe() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					case 0:
						break;
					}
					return;
				}
			}
		}
		GKu(null);
	}

	public override void Draw(TextViewDrawContext context)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Rect bounds = context.Bounds;
		Brush outliningMarginBackground = context.OutliningMarginBackground;
		if (outliningMarginBackground != null)
		{
			context.FillRectangle(bounds, outliningMarginBackground);
		}
		IEditorView view = base.View;
		IOutliningManager outliningManager = view.SyntaxEditor.Document.OutliningManager;
		if (outliningManager == null)
		{
			return;
		}
		Brush collapsibleRegionForeground = context.CollapsibleRegionForeground;
		Brush outliningMarginSquareBackground = context.OutliningMarginSquareBackground;
		Pen pen = context.pbW();
		Pen pen2 = context.aHd();
		ITextViewLineCollection visibleViewLines = view.VisibleViewLines;
		foreach (ITextViewLine item in visibleViewLines)
		{
			OutliningState outliningState = outliningManager.GetOutliningState(new TextSnapshotRange(view.CurrentSnapshot, item.StartOffset, item.EndOffsetIncludingLineTerminator));
			if (outliningState == OutliningState.None)
			{
				continue;
			}
			bool flag = (outliningState & OutliningState.HasExpandedNodeStart) == OutliningState.HasExpandedNodeStart;
			bool flag2 = (outliningState & OutliningState.HasCollapsedNode) == OutliningState.HasCollapsedNode;
			bool flag3 = (outliningState & OutliningState.HasExpandedNodeEnd) == OutliningState.HasExpandedNodeEnd;
			bool flag4 = (outliningState & OutliningState.IsTopLevel) == OutliningState.IsTopLevel;
			bool flag5 = (outliningState & OutliningState.IsOpen) == OutliningState.IsOpen;
			Rect textBounds = item.TextBounds;
			Rect rect = new Rect(bounds.X, bounds.Y + textBounds.Y, bounds.Width, textBounds.Height);
			Rect bounds2 = DKg(rect);
			rect.Y -= item.TopMargin;
			rect.Height += item.TopMargin + item.BottomMargin;
			double x = bounds2.X + (double)(int)(bounds2.Width / 2.0);
			if (rect.Height > 0.0 && zKC().HasValue && zKC().Value.TextRange.OverlapsWith(item.TextRange))
			{
				if (flag || flag2)
				{
					if (bounds2.Top - rect.Top >= 2.0)
					{
						context.FillRectangle(new Rect(rect.X, rect.Y, rect.Width, bounds2.Y - 1.0 - rect.Y), collapsibleRegionForeground);
					}
					if (rect.Bottom - bounds2.Bottom >= 2.0)
					{
						context.FillRectangle(new Rect(rect.X, bounds2.Bottom + 1.0, rect.Width, rect.Bottom - (bounds2.Bottom + 1.0)), collapsibleRegionForeground);
					}
				}
				else
				{
					context.FillRectangle(new Rect(rect.X, rect.Y, rect.Width, rect.Height), collapsibleRegionForeground);
				}
			}
			if (flag || flag2)
			{
				if (flag2)
				{
					context.FillRectangle(bounds2, outliningMarginSquareBackground);
				}
				context.DrawRectangle(bounds2, pen2);
				if (bounds2.Width > 5.0)
				{
					double y = bounds2.Y + (double)(int)(bounds2.Height / 2.0);
					context.DrawLine(new Point(bounds2.X + 2.0, y), new Point(bounds2.Right - 3.0, y), pen);
					if (flag2)
					{
						context.DrawLine(new Point(x, bounds2.Y + 2.0), new Point(x, bounds2.Bottom - 3.0), pen);
					}
				}
				if (!flag4 && bounds2.Top - rect.Top >= 2.0)
				{
					context.DrawLine(new Point(x, rect.Y), new Point(x, bounds2.Y - 2.0), pen2);
				}
				if ((flag3 || flag5) && rect.Bottom - bounds2.Bottom >= 2.0)
				{
					context.DrawLine(new Point(x, bounds2.Bottom + 1.0), new Point(x, rect.Bottom - 1.0), pen2);
				}
			}
			else if (!flag4)
			{
				context.DrawLine(new Point(x, rect.Top), new Point(x, rect.Bottom - 1.0), pen2);
			}
			if (flag3 && rect.Width >= 3.0)
			{
				context.DrawLine(new Point(x, rect.Bottom - 1.0), new Point(rect.Right - 2.0, rect.Bottom - 1.0), pen2);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new EditorOutliningMarginAutomationPeer(this);
	}

	public override void UpdateVisibility()
	{
		base.Visibility = ((!base.View.SyntaxEditor.IsOutliningMarginVisible) ? Visibility.Collapsed : Visibility.Visible);
	}

	internal static bool ADU()
	{
		return uD8 == null;
	}

	internal static EditorOutliningMargin EDe()
	{
		return uD8;
	}
}
