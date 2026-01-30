using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Controls.Grids.Primitives;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids;

[ToolboxItem(false)]
public class TreeListViewItem : TreeListBoxItem
{
	private TreeListView nJG;

	private TreeListViewItemRowPanel WJu;

	internal static TreeListViewItem IW1;

	public TreeListViewItem()
	{
		fc.taYSkz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TreeListViewItem);
	}

	[SpecialName]
	internal TreeListViewItemRowPanel RJM()
	{
		return WJu;
	}

	[SpecialName]
	internal void CJe(TreeListViewItemRowPanel value)
	{
		if (WJu != value)
		{
			if (WJu != null)
			{
				WJu.eCh(null);
			}
			WJu = value;
			if (WJu != null)
			{
				WJu.eCh(nJG);
			}
		}
	}

	internal void hJR(TreeListView P_0)
	{
		nJG = P_0;
		if (WJu != null)
		{
			WJu.eCh(P_0);
		}
	}

	protected override bool IsLocationOverBackground(Point location)
	{
		TreeListViewItemRowPanel descendant = VisualTreeHelperExtended.GetDescendant<TreeListViewItemRowPanel>(this, 0);
		if (descendant != null)
		{
			return location.X > descendant.pCH();
		}
		return false;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		CJe(VisualTreeHelperExtended.GetDescendant<TreeListViewItemRowPanel>(this, 0));
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new TreeListViewItemWrapperAutomationPeer(this);
	}

	protected override void OnIndentAmountChanged()
	{
		if (WJu != null)
		{
			WJu.InvalidateMeasure();
		}
	}

	internal static bool iWU()
	{
		return IW1 == null;
	}

	internal static TreeListViewItem EW5()
	{
		return IW1;
	}
}
