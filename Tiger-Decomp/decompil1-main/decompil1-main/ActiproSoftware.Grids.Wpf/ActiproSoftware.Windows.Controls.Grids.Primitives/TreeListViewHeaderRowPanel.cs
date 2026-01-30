using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class TreeListViewHeaderRowPanel : TreeListViewRowPanelBase
{
	private int bCE;

	private km eCC;

	private double UCK;

	private double eCN;

	private int GCl;

	private TreeListViewColumnHeader BCg;

	private ScrollViewer ICm;

	internal static TreeListViewHeaderRowPanel tsY;

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private TreeListViewColumnHeader RC5
	{
		get
		{
			return BCg;
		}
		set
		{
			BCg = value;
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	private ScrollViewer YCp
	{
		get
		{
			return ICm;
		}
		set
		{
			if (ICm != value)
			{
				if (ICm != null)
				{
					ICm.ScrollChanged -= BCt;
				}
				ICm = value;
				if (ICm != null)
				{
					ICm.ScrollChanged += BCt;
				}
				UCU(ICm?.HorizontalOffset);
			}
		}
	}

	internal void kEz(double P_0)
	{
		UCK = P_0;
	}

	internal void TCI(TreeListViewColumnHeader P_0, Point P_1)
	{
		eCN = Math.Max(0.0, Math.Min(pCH() - P_0.ActualWidth, P_1.X + UCK));
		InvalidateArrange();
		GCl = -1;
		TreeItemDropArea treeItemDropArea = TreeItemDropArea.None;
		int num = -1;
		IList<Ne> list = mCL();
		if (P_1.X < 0.0)
		{
			for (int i = 0; i < list.Count; i++)
			{
				if (!(list[i].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader))
				{
					continue;
				}
				treeListViewColumnHeader.DropIndicatorArea = TreeItemDropArea.None;
				if (num == -1)
				{
					num = i;
					treeItemDropArea = TreeItemDropArea.Before;
					if (treeListViewColumnHeader != P_0)
					{
						GCl = i;
					}
				}
			}
		}
		else if (P_1.X >= pCH())
		{
			for (int num2 = list.Count - 1; num2 >= 0; num2--)
			{
				if (list[num2].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader2)
				{
					treeListViewColumnHeader2.DropIndicatorArea = TreeItemDropArea.None;
					if (num == -1)
					{
						num = num2;
						treeItemDropArea = TreeItemDropArea.After;
						if (treeListViewColumnHeader2 != P_0)
						{
							GCl = num2;
						}
					}
				}
			}
		}
		else
		{
			int num3 = -1;
			for (int j = 0; j < list.Count; j++)
			{
				if (!(list[j].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader3))
				{
					continue;
				}
				treeListViewColumnHeader3.DropIndicatorArea = TreeItemDropArea.None;
				Rect rect = treeListViewColumnHeader3.TransformToVisual(this).TransformBounds(new Rect(0.0, 0.0, treeListViewColumnHeader3.ActualWidth, treeListViewColumnHeader3.ActualHeight));
				if (P_1.X >= rect.X && P_1.X < rect.X + rect.Width)
				{
					num = j;
					if (P_1.X < rect.X + rect.Width / 2.0)
					{
						if (num3 != -1)
						{
							num = num3;
							treeItemDropArea = TreeItemDropArea.After;
						}
						else
						{
							treeItemDropArea = TreeItemDropArea.Before;
						}
					}
					else
					{
						treeItemDropArea = TreeItemDropArea.After;
					}
					if (j != bCE)
					{
						GCl = num + ((treeItemDropArea != TreeItemDropArea.Before) ? 1 : 0) - ((num > bCE) ? 1 : 0);
						if (treeItemDropArea == TreeItemDropArea.After && num == bCE)
						{
							GCl = -1;
						}
					}
				}
				num3 = j;
			}
		}
		if (num != -1 && list[num].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader4)
		{
			treeListViewColumnHeader4.DropIndicatorArea = treeItemDropArea;
		}
	}

	internal void LCP(TreeListViewColumnHeader P_0, Point P_1)
	{
		SC1(_0020: true);
		bCE = -1;
		IList<Ne> list = mCL();
		int num = list.Count - 1;
		int num3 = default(int);
		while (num >= 0)
		{
			if (list[num].Hmb() == P_0)
			{
				bCE = num;
				break;
			}
			num--;
			int num2 = 0;
			if (!DsM())
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		eCC = new km(P_0);
		base.Children.Add(eCC);
		TCI(P_0, P_1);
	}

	internal void SC1(bool P_0)
	{
		IList<Ne> list = mCL();
		int num = 0;
		int num3 = default(int);
		while (true)
		{
			int num2;
			if (num < list.Count)
			{
				if (!(list[num].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader))
				{
					goto IL_00b2;
				}
				treeListViewColumnHeader.DropIndicatorArea = TreeItemDropArea.None;
				num2 = 1;
				if (Xsy() != null)
				{
					num2 = 1;
				}
			}
			else
			{
				if (eCC != null)
				{
					base.Children.Remove(eCC);
					eCC = null;
				}
				if (P_0 || GCl == -1)
				{
					break;
				}
				num2 = 0;
				if (Xsy() != null)
				{
					num2 = num3;
				}
			}
			switch (num2)
			{
			case 1:
				goto IL_00b2;
			}
			GCl = Math.Max(0, Math.Min(list.Count - 1, GCl));
			if (bCE != GCl)
			{
				ug ug = qCx();
				if (ug != null)
				{
					ug.Move(bCE, GCl);
					vCb()?.C6T(new TreeListViewColumnEventArgs(ug[GCl]));
				}
			}
			break;
			IL_00b2:
			num++;
		}
		GCl = -1;
	}

	private void BCt(object P_0, ScrollChangedEventArgs P_1)
	{
		if (ICm != null)
		{
			UCU(ICm.HorizontalOffset);
		}
	}

	private void UCU(double? P_0)
	{
		base.Margin = new Thickness((0.0 - P_0).GetValueOrDefault(), 0.0, 0.0, 0.0);
	}

	private void VC6()
	{
		eCh(VisualTreeHelperExtended.GetAncestor<TreeListView>(this));
		if (ICm == null)
		{
			YCp = vCb()?.i14();
		}
		if (BCg != null)
		{
			return;
		}
		foreach (object child in base.Children)
		{
			if (child is TreeListViewColumnHeader treeListViewColumnHeader && treeListViewColumnHeader.Name == xv.hTz(9968))
			{
				RC5 = treeListViewColumnHeader;
				break;
			}
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		double num = cCd(finalSize, null, -1, null, null);
		if (BCg != null)
		{
			double num2 = Math.Max(0.0, finalSize.Width - num);
			double height = Math.Max(0.0, finalSize.Height);
			BCg.Arrange(new Rect(num, 0.0, num2, height));
			num += num2;
		}
		if (eCC != null)
		{
			eCC.Arrange(new Rect(eCN, -1.0, eCC.Width, eCC.Height));
		}
		TreeListView treeListView = vCb();
		if (treeListView != null)
		{
			int num3 = 0;
			if (Xsy() != null)
			{
				int num4 = default(int);
				num3 = num4;
			}
			switch (num3)
			{
			}
			treeListView.r6E(finalSize.Height);
		}
		return finalSize;
	}

	protected override Control CreateCellElement(TreeListViewColumn column)
	{
		if (column == null)
		{
			return null;
		}
		return new TreeListViewColumnHeader
		{
			BorderThickness = column.HeaderCellBorderThickness,
			Column = column,
			Style = column.HeaderContainerStyle,
			ContentTemplateSelector = column.HeaderTemplateSelector,
			ContentTemplate = column.HeaderTemplate,
			Content = column.Header,
			HorizontalContentAlignment = column.HeaderHorizontalAlignment,
			IsResizeGripperEnabled = column.IsResizeGripperEnabled,
			Padding = column.HeaderCellPadding,
			SortDirection = column.SortDirection
		};
	}

	protected override Geometry GetLayoutClip(Size layoutSlotSize)
	{
		return null;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		VC6();
		Size result = uCB(availableSize, null, -1, null, null);
		double num = Math.Max(0.0, availableSize.Width - result.Width);
		if (BCg != null)
		{
			double width = (double.IsPositiveInfinity(num) ? 0.0 : num);
			BCg.Measure(new Size(width, availableSize.Height));
			double width2 = BCg.DesiredSize.Width;
			num = Math.Max(0.0, num - width2);
			result.Width += width2;
			result.Height = Math.Max(result.Height, BCg.DesiredSize.Height);
		}
		return result;
	}

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	protected override void OnColumnPropertyChanged(TreeListViewColumn column, string propertyName)
	{
		if (column == null)
		{
			return;
		}
		ug ug = qCx();
		IList<Ne> list = mCL();
		int num = ug?.IndexOf(column) ?? (-1);
		if (num < 0 || num >= list.Count)
		{
			return;
		}
		Control control;
		switch (global::_003CPrivateImplementationDetails_003E.ComputeStringHash(propertyName))
		{
		case 2784292777u:
			if (!(propertyName == xv.hTz(6504)))
			{
				break;
			}
			goto IL_02ef;
		case 1647479251u:
			if (!(propertyName == xv.hTz(7186)))
			{
				break;
			}
			goto IL_02ef;
		case 4270317017u:
			if (!(propertyName == xv.hTz(7206)))
			{
				break;
			}
			goto IL_02ef;
		case 994238399u:
			if (!(propertyName == xv.hTz(7256)))
			{
				break;
			}
			goto IL_02ef;
		case 2799140153u:
			if (propertyName == xv.hTz(7270) && column.Width.GridUnitType != GridUnitType.Star)
			{
				InvalidateMeasure();
			}
			break;
		case 3445631609u:
			if (propertyName == xv.hTz(7296))
			{
				KCv(num);
			}
			break;
		case 1814664915u:
			if (propertyName == xv.hTz(7096))
			{
				Ne ne = list[num];
				if (ne.Hmb() != null)
				{
					TreeListViewRowPanelBase.WC3(ne.Hmb(), column.IsFrozen);
				}
			}
			break;
		case 1603625425u:
			if (propertyName == xv.hTz(7116) && list[num].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader3)
			{
				treeListViewColumnHeader3.IsResizeGripperEnabled = column.IsResizeGripperEnabled;
			}
			break;
		case 1619861713u:
		{
			if (!(propertyName == xv.hTz(7164)))
			{
				break;
			}
			Ne ne2 = list[num];
			if (column.IsVisible)
			{
				if (ne2.Hmb() == null)
				{
					Control control2 = CreateCellElement(column);
					ne2.Fmh(control2);
					base.Children.Add(control2);
					TreeListViewRowPanelBase.WC3(control2, column.IsFrozen);
					UpdateAllCellElementZIndexes();
				}
			}
			else if (ne2.Hmb() != null)
			{
				TreeListViewRowPanelBase.WC3(ne2.Hmb(), _0020: false);
				base.Children.Remove(ne2.Hmb());
				ne2.Fmh(null);
			}
			break;
		}
		case 47505276u:
			if (!(propertyName == xv.hTz(6826)))
			{
				break;
			}
			goto IL_03f9;
		case 1599489481u:
			if (!(propertyName == xv.hTz(6880)))
			{
				break;
			}
			goto IL_03f9;
		case 1893314904u:
			if (!(propertyName == xv.hTz(6918)))
			{
				break;
			}
			goto IL_03f9;
		case 2400901429u:
			if (!(propertyName == xv.hTz(6994)))
			{
				break;
			}
			goto IL_03f9;
		case 290429312u:
			if (!(propertyName == xv.hTz(6810)))
			{
				break;
			}
			goto IL_04c7;
		case 1424518058u:
			if (!(propertyName == xv.hTz(6962)))
			{
				break;
			}
			goto IL_04c7;
		case 3738038127u:
			if (!(propertyName == xv.hTz(7048)))
			{
				break;
			}
			goto IL_04c7;
		case 1780909830u:
			{
				if (propertyName == xv.hTz(7226) && list[num].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader)
				{
					treeListViewColumnHeader.SortDirection = column.SortDirection;
				}
				break;
			}
			IL_04c7:
			if (!(list[num].Hmb() is TreeListViewColumnHeader treeListViewColumnHeader2))
			{
				break;
			}
			if (!(propertyName == xv.hTz(6810)))
			{
				if (!(propertyName == xv.hTz(6962)))
				{
					if (propertyName == xv.hTz(7048))
					{
						DataTemplateSelector cellTemplateSelector = column.CellTemplateSelector;
						if (cellTemplateSelector != null)
						{
							treeListViewColumnHeader2.ContentTemplateSelector = cellTemplateSelector;
						}
						else
						{
							treeListViewColumnHeader2.ClearValue(ContentControl.ContentTemplateSelectorProperty);
						}
					}
				}
				else
				{
					DataTemplate cellTemplate = column.CellTemplate;
					if (cellTemplate != null)
					{
						treeListViewColumnHeader2.ContentTemplate = cellTemplate;
					}
					else
					{
						treeListViewColumnHeader2.ClearValue(ContentControl.ContentTemplateProperty);
					}
				}
			}
			else
			{
				object header = column.Header;
				if (header != null)
				{
					treeListViewColumnHeader2.Content = header;
				}
				else
				{
					treeListViewColumnHeader2.ClearValue(ContentControl.ContentProperty);
				}
			}
			break;
			IL_03f9:
			control = list[num].Hmb();
			if (control == null)
			{
				break;
			}
			if (!(propertyName == xv.hTz(6826)))
			{
				if (!(propertyName == xv.hTz(6880)))
				{
					if (!(propertyName == xv.hTz(6918)))
					{
						if (propertyName == xv.hTz(6994))
						{
							control.HorizontalContentAlignment = column.HeaderHorizontalAlignment;
							InvalidateMeasure();
						}
					}
					else
					{
						Style headerContainerStyle = column.HeaderContainerStyle;
						if (headerContainerStyle != null)
						{
							control.Style = headerContainerStyle;
						}
						else
						{
							control.ClearValue(FrameworkElement.StyleProperty);
						}
					}
				}
				else
				{
					control.Padding = column.HeaderCellPadding;
					InvalidateMeasure();
				}
			}
			else
			{
				control.BorderThickness = column.HeaderCellBorderThickness;
				InvalidateMeasure();
			}
			break;
			IL_02ef:
			InvalidateMeasure();
			break;
		}
	}

	protected internal override void UpdateAllCellElementZIndexes()
	{
		IList<Ne> list = mCL();
		int count = list.Count;
		ug ug = qCx();
		int num = count - 1;
		int num3 = default(int);
		while (num >= 0)
		{
			Control control = list[num].Hmb();
			if (control != null)
			{
				if (ug != null && ug[num].IsFrozen)
				{
					Panel.SetZIndex(control, 1000 + count - num);
				}
				else
				{
					Panel.SetZIndex(control, count - num);
				}
			}
			num--;
			int num2 = 0;
			if (Xsy() != null)
			{
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
	}

	public TreeListViewHeaderRowPanel()
	{
		fc.taYSkz();
		bCE = -1;
		GCl = -1;
		base._002Ector();
	}

	internal static bool DsM()
	{
		return tsY == null;
	}

	internal static TreeListViewHeaderRowPanel Xsy()
	{
		return tsY;
	}
}
