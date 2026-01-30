using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

[ToolboxItem(false)]
public class EditorViewHost : Panel
{
	private EditorViewSplitter rg8;

	internal static EditorViewHost oBl;

	public EditorViewHost()
	{
		grA.DaB7cz();
		base._002Ector();
		Ug4();
	}

	private void Ug4()
	{
		rg8 = new EditorViewSplitter();
		rg8.Visibility = Visibility.Collapsed;
		rg8.DragCompleted += wgw;
		rg8.DragDelta += rg6;
		rg8.Toggled += ugH;
		UIElementCollection uIElementCollection = this.v0D();
		uIElementCollection.Add(rg8);
	}

	private static double lgo(double P_0, double P_1)
	{
		return Math.Max(5.0, Math.Min(P_1 - 5.0, P_0));
	}

	private uTb ygj()
	{
		return VisualTreeHelperExtended.GetAncestor<SyntaxEditor>(this)?.gGw();
	}

	private void wgw(object P_0, InputPointerEventArgs P_1)
	{
		SyntaxEditor ancestor = VisualTreeHelperExtended.GetAncestor<SyntaxEditor>(this);
		if (ancestor == null)
		{
			return;
		}
		int num = 0;
		if (TBS() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		double actualHeight = base.ActualHeight;
		double num3 = lgo(P_1.GetPosition(this).Y, actualHeight);
		bool flag = num3 <= 16.0;
		bool flag2 = num3 >= actualHeight - 16.0;
		if (flag2 || flag)
		{
			ancestor.gGw()?.w4A(ancestor, flag);
		}
	}

	private void rg6(object P_0, InputPointerEventArgs P_1)
	{
		xgL(P_1);
	}

	private void ugH(object P_0, EventArgs P_1)
	{
		SyntaxEditor ancestor = VisualTreeHelperExtended.GetAncestor<SyntaxEditor>(this);
		if (ancestor != null)
		{
			ancestor.HasHorizontalSplit = !ancestor.HasHorizontalSplit;
		}
	}

	internal void Egb()
	{
		InvalidateMeasure();
	}

	internal void BgT(InputPointerButtonEventArgs P_0)
	{
		if (rg8 != null)
		{
			xgL(P_0);
			rg8.StartDrag(P_0);
		}
	}

	private void xgL(InputPointerEventArgs P_0)
	{
		SyntaxEditor ancestor = VisualTreeHelperExtended.GetAncestor<SyntaxEditor>(this);
		if (ancestor != null)
		{
			double actualHeight = base.ActualHeight;
			double num = Math.Max(rg8.MinHeight, rg8.DesiredSize.Height);
			Point position = P_0.GetPosition(this);
			int num2 = 0;
			if (TBS() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			double num4 = lgo(position.Y, actualHeight);
			ancestor.HorizontalSplitPercentage = Math.Max(0.0001, Math.Min(1.0, num4 / actualHeight));
			InvalidateArrange();
		}
	}

	internal void Kgn(SyntaxEditor P_0, bool P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(8238));
		}
		EditorView[] array = null;
		uTb uTb = P_0.gGw();
		if (uTb != null)
		{
			Visibility visibility = ((!uTb.HasHorizontalSplit) ? Visibility.Collapsed : Visibility.Visible);
			if (rg8.Visibility != visibility)
			{
				rg8.Visibility = visibility;
			}
			if (!P_1 && uTb != null)
			{
				array = new EditorView[2]
				{
					uTb.c4Q(EditorViewPlacement.Default),
					uTb.c4Q(EditorViewPlacement.Upper)
				};
			}
		}
		UIElementCollection uIElementCollection = this.v0D();
		for (int num = uIElementCollection.Count - 1; num >= 0; num--)
		{
			if (uIElementCollection[num] is EditorView value && (array == null || !array.Contains(value)))
			{
				uIElementCollection.RemoveAt(num);
			}
		}
		if (P_1 || array == null)
		{
			return;
		}
		EditorView[] array2 = array;
		foreach (EditorView editorView in array2)
		{
			if (editorView != null && !uIElementCollection.Contains(editorView))
			{
				uIElementCollection.Add(editorView);
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		Rect rect = new Rect(default(Point), finalSize);
		uTb uTb = ygj();
		int num = 0;
		if (!eBW())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_0009:
		EditorView editorView = default(EditorView);
		double num4 = default(double);
		double num5 = default(double);
		do
		{
			double num3;
			switch (num)
			{
			case 1:
				editorView?.Arrange(new Rect(rect.X, rect.Y, rect.Width, num4));
				rg8.Arrange(new Rect(rect.X, rect.Y + num4, rect.Width, rg8.DesiredSize.Height));
				uTb.c4Q(EditorViewPlacement.Default)?.Arrange(new Rect(rect.X, rect.Bottom - num5, rect.Width, num5));
				goto IL_0083;
			default:
				{
					if (uTb != null)
					{
						num3 = rect.Height;
						if (uTb.HasHorizontalSplit)
						{
							num3 = Math.Max(0.0, num3 - rg8.DesiredSize.Height);
						}
						break;
					}
					goto IL_0083;
				}
				IL_0083:
				return finalSize;
			}
			num4 = Math.Round(num3 * uTb.HorizontalSplitPercentage, MidpointRounding.AwayFromZero);
			num5 = num3 - num4;
			editorView = uTb.c4Q(EditorViewPlacement.Upper);
			num = 1;
		}
		while (eBW());
		goto IL_0005;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		Size result = default(Size);
		uTb uTb = ygj();
		if (uTb != null)
		{
			rg8.Measure(availableSize);
			double num = availableSize.Height;
			if (uTb.HasHorizontalSplit)
			{
				num = Math.Max(0.0, num - rg8.DesiredSize.Height);
				result.Height += rg8.DesiredSize.Height;
			}
			double num2 = (double.IsPositiveInfinity(num) ? double.PositiveInfinity : Math.Round(num * uTb.HorizontalSplitPercentage, MidpointRounding.AwayFromZero));
			double height = (double.IsPositiveInfinity(num) ? double.PositiveInfinity : (num - num2));
			EditorView editorView = uTb.c4Q(EditorViewPlacement.Upper);
			if (editorView != null)
			{
				editorView.Measure(new Size(availableSize.Width, num2));
				result.Width = Math.Max(result.Width, editorView.DesiredSize.Width);
				result.Height += editorView.DesiredSize.Height;
			}
			EditorView editorView2 = uTb.c4Q(EditorViewPlacement.Default);
			if (editorView2 != null)
			{
				editorView2.Measure(new Size(availableSize.Width, height));
				result.Width = Math.Max(result.Width, editorView2.DesiredSize.Width);
				result.Height += editorView2.DesiredSize.Height;
			}
		}
		return result;
	}

	internal static bool eBW()
	{
		return oBl == null;
	}

	internal static EditorViewHost TBS()
	{
		return oBl;
	}
}
