using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Grids.Primitives;

[ToolboxItem(false)]
public class TreeListViewItemRowPanel : TreeListViewRowPanelBase
{
	private FrameworkElement mCQ;

	private FrameworkElement oCy;

	private static TreeListViewItemRowPanel Csf;

	[SpecialName]
	private TreeListViewItem rCY()
	{
		return base.TemplatedParent as TreeListViewItem;
	}

	private void dCT()
	{
		FrameworkElement frameworkElement = mCQ;
		mCQ = null;
		oCy = null;
		int num2 = default(int);
		foreach (object child in base.Children)
		{
			if (!(child is FrameworkElement frameworkElement2))
			{
				continue;
			}
			int num = 0;
			if (psZ() != null)
			{
				num = num2;
			}
			switch (num)
			{
			}
			string name = frameworkElement2.Name;
			if (name == xv.hTz(9674))
			{
				mCQ = frameworkElement2;
				if (mCQ != frameworkElement)
				{
					UpdateAllCellElementZIndexes();
				}
				NCo();
			}
			else if (name == xv.hTz(10020))
			{
				oCy = frameworkElement2;
			}
			else if (name == xv.hTz(10064))
			{
				oCy = frameworkElement2;
			}
		}
	}

	private void NCo()
	{
		if (mCQ != null)
		{
			TreeListView treeListView = vCb();
			int num = treeListView?.ExpansionColumnIndex ?? 0;
			int num2 = treeListView?.FrozenColumnCount ?? 0;
			bool flag = num < num2;
			TreeListViewRowPanelBase.WC3(mCQ, flag);
		}
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		int num = vCb()?.ExpansionColumnIndex ?? 0;
		cCd(finalSize, rCY(), num, mCQ, oCy);
		return finalSize;
	}

	protected override Control CreateCellElement(TreeListViewColumn column)
	{
		if (column == null)
		{
			return null;
		}
		TreeListViewItemCell treeListViewItemCell = new TreeListViewItemCell(column)
		{
			BorderThickness = column.CellBorderThickness,
			HorizontalContentAlignment = column.CellHorizontalAlignment,
			VerticalContentAlignment = column.CellVerticalAlignment,
			Padding = column.CellPadding,
			Style = column.CellContainerStyle,
			ContentTemplateSelector = column.CellTemplateSelector,
			ContentTemplate = column.CellTemplate
		};
		BindingBase displayMemberBinding = column.DisplayMemberBinding;
		if (displayMemberBinding != null)
		{
			TextBlock textBlock = new TextBlock
			{
				DataContext = base.DataContext,
				TextTrimming = TextTrimming.CharacterEllipsis,
				TextWrapping = TextWrapping.NoWrap,
				VerticalAlignment = VerticalAlignment.Center
			};
			textBlock.SetBinding(TextBlock.TextProperty, displayMemberBinding);
			treeListViewItemCell.Content = new PixelSnapper
			{
				VerticalRoundMode = RoundMode.CeilingToEven,
				Child = textBlock
			};
		}
		else
		{
			treeListViewItemCell.Content = base.DataContext;
		}
		KeyboardNavigation.SetTabNavigation(treeListViewItemCell, KeyboardNavigationMode.Local);
		return treeListViewItemCell;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		dCT();
		int num = vCb()?.ExpansionColumnIndex ?? 0;
		Size size = uCB(availableSize, rCY(), num, mCQ, oCy);
		return new Size(size.Width, Math.Ceiling(size.Height));
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
		default:
			return;
		case 2784292777u:
			if (!(propertyName == xv.hTz(6504)))
			{
				return;
			}
			goto IL_02f9;
		case 1647479251u:
			if (!(propertyName == xv.hTz(7186)))
			{
				return;
			}
			goto IL_02f9;
		case 4270317017u:
			if (!(propertyName == xv.hTz(7206)))
			{
				return;
			}
			goto IL_02f9;
		case 994238399u:
			if (!(propertyName == xv.hTz(7256)))
			{
				return;
			}
			goto IL_02f9;
		case 2799140153u:
			if (propertyName == xv.hTz(7270) && column.Width.GridUnitType != GridUnitType.Star)
			{
				InvalidateMeasure();
			}
			return;
		case 3445631609u:
		{
			if (!(propertyName == xv.hTz(7296)))
			{
				return;
			}
			KCv(num);
			if (mCQ == null || !column.nqE())
			{
				return;
			}
			TreeListViewItem treeListViewItem = rCY();
			if (treeListViewItem != null)
			{
				double num2 = column.CellPadding.Left + treeListViewItem.IndentAmount - mCQ.DesiredSize.Width;
				TreeListViewRowPanelBase.OC8(mCQ, column, column.ActualWidth, base.ActualHeight, num2);
				if (oCy != null)
				{
					TreeListViewRowPanelBase.gC9(oCy, column, column.ActualWidth, base.ActualHeight);
				}
			}
			return;
		}
		case 1814664915u:
			if (propertyName == xv.hTz(7096))
			{
				Ne ne = list[num];
				if (ne.Hmb() != null)
				{
					TreeListViewRowPanelBase.WC3(ne.Hmb(), column.IsFrozen);
				}
				NCo();
			}
			return;
		case 1603625425u:
			if (propertyName == xv.hTz(7116) && list[num].Hmb() is TreeListViewItemCell treeListViewItemCell2)
			{
				treeListViewItemCell2.IsResizeGripperEnabled = column.IsResizeGripperEnabled;
			}
			return;
		case 1619861713u:
		{
			if (!(propertyName == xv.hTz(7164)))
			{
				return;
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
				}
			}
			else if (ne2.Hmb() != null)
			{
				TreeListViewRowPanelBase.WC3(ne2.Hmb(), _0020: false);
				base.Children.Remove(ne2.Hmb());
				ne2.Fmh(null);
			}
			return;
		}
		case 3401624015u:
			if (!(propertyName == xv.hTz(6534)))
			{
				return;
			}
			goto IL_0493;
		case 3723012541u:
			if (!(propertyName == xv.hTz(6576)))
			{
				return;
			}
			goto IL_0493;
		case 2254276582u:
			if (!(propertyName == xv.hTz(6666)))
			{
				return;
			}
			goto IL_0493;
		case 2605478530u:
			if (propertyName == xv.hTz(6616))
			{
				goto IL_0493;
			}
			return;
		case 3420846660u:
			if (!(propertyName == xv.hTz(6764)))
			{
				return;
			}
			goto IL_0493;
		case 4258700604u:
			if (propertyName == xv.hTz(7310) && list[num].Hmb() is TreeListViewItemCell treeListViewItemCell)
			{
				TextBlock textBlock = treeListViewItemCell.Content as TextBlock;
				BindingBase displayMemberBinding = column.DisplayMemberBinding;
				if (textBlock != null && displayMemberBinding != null)
				{
					textBlock.SetBinding(TextBlock.TextProperty, displayMemberBinding);
				}
				else
				{
					VC2(num, num);
				}
			}
			return;
		case 2377702555u:
			if (propertyName == xv.hTz(6692))
			{
				break;
			}
			return;
		case 1316933706u:
			{
				if (!(propertyName == xv.hTz(6720)))
				{
					return;
				}
				break;
			}
			IL_0493:
			control = list[num].Hmb();
			if (control == null)
			{
				return;
			}
			if (!(propertyName == xv.hTz(6534)))
			{
				if (!(propertyName == xv.hTz(6576)))
				{
					if (!(propertyName == xv.hTz(6666)))
					{
						if (!(propertyName == xv.hTz(6616)))
						{
							if (propertyName == xv.hTz(6764))
							{
								control.VerticalContentAlignment = column.CellVerticalAlignment;
							}
						}
						else
						{
							control.HorizontalContentAlignment = column.CellHorizontalAlignment;
						}
					}
					else
					{
						control.Padding = column.CellPadding;
					}
				}
				else
				{
					control.Style = column.CellContainerStyle;
				}
			}
			else
			{
				control.BorderThickness = column.CellBorderThickness;
			}
			InvalidateMeasure();
			return;
			IL_02f9:
			InvalidateMeasure();
			return;
		}
		if (!(list[num].Hmb() is TreeListViewItemCell treeListViewItemCell3))
		{
			return;
		}
		if (!(propertyName == xv.hTz(6692)))
		{
			if (propertyName == xv.hTz(6720))
			{
				DataTemplateSelector cellTemplateSelector = column.CellTemplateSelector;
				if (cellTemplateSelector != null)
				{
					treeListViewItemCell3.ContentTemplateSelector = cellTemplateSelector;
				}
				else
				{
					treeListViewItemCell3.ClearValue(ContentPresenter.ContentTemplateSelectorProperty);
				}
			}
		}
		else
		{
			DataTemplate cellTemplate = column.CellTemplate;
			if (cellTemplate != null)
			{
				treeListViewItemCell3.ContentTemplate = cellTemplate;
			}
			else
			{
				treeListViewItemCell3.ClearValue(ContentPresenter.ContentTemplateProperty);
			}
		}
	}

	protected override void UpdateAllCellElementContent()
	{
		IList<Ne> list = mCL();
		if (list.Count <= 0)
		{
			return;
		}
		object dataContext = base.DataContext;
		foreach (Ne item in list)
		{
			if (!(item.Hmb() is TreeListViewItemCell treeListViewItemCell))
			{
				continue;
			}
			if (!(treeListViewItemCell.Content is TextBlock textBlock))
			{
				if (treeListViewItemCell.Content != dataContext)
				{
					treeListViewItemCell.Content = dataContext;
				}
			}
			else
			{
				textBlock.DataContext = dataContext;
			}
		}
	}

	protected internal override void UpdateAllCellElementZIndexes()
	{
		int num = vCb()?.ExpansionColumnIndex ?? 0;
		IList<Ne> list = mCL();
		int count = list.Count;
		ug ug = qCx();
		int num2 = count - 1;
		int num4 = default(int);
		while (true)
		{
			int num3;
			if (num2 < 0)
			{
				num3 = 0;
				if (!wso())
				{
					num3 = num4;
				}
			}
			else
			{
				Control control = list[num2].Hmb();
				if (control == null)
				{
					goto IL_00d0;
				}
				if (control is TreeListViewItemCell treeListViewItemCell)
				{
					treeListViewItemCell.TabIndex = num2;
				}
				bool flag = ug?[num2].IsFrozen ?? false;
				if (flag)
				{
					Panel.SetZIndex(control, 1000 + count - num2);
				}
				else
				{
					Panel.SetZIndex(control, count - num2);
				}
				if (num2 != num || mCQ == null)
				{
					goto IL_00d0;
				}
				Panel.SetZIndex(mCQ, (flag ? 1000 : 0) + 999);
				num3 = 1;
				if (psZ() == null)
				{
					num3 = 1;
				}
			}
			switch (num3)
			{
			default:
				return;
			case 1:
				break;
			case 0:
				return;
			}
			goto IL_00d0;
			IL_00d0:
			num2--;
		}
	}

	public TreeListViewItemRowPanel()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool wso()
	{
		return Csf == null;
	}

	internal static TreeListViewItemRowPanel psZ()
	{
		return Csf;
	}
}
