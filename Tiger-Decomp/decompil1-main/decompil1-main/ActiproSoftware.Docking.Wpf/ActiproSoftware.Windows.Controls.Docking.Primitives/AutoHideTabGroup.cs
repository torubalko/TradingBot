using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class AutoHideTabGroup : ItemsControl
{
	public static readonly DependencyProperty PlacementProperty;

	internal static AutoHideTabGroup S8a;

	public Side Placement
	{
		get
		{
			return (Side)GetValue(PlacementProperty);
		}
		set
		{
			SetValue(PlacementProperty, value);
		}
	}

	public AutoHideTabGroup()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(AutoHideTabGroup);
	}

	internal void aTX()
	{
		if (base.DataContext is ToolWindowContainer target)
		{
			BindingOperations.GetBindingExpression(target, DockingWindowContainerBase.HasTabImagesProperty)?.UpdateTarget();
		}
		foreach (object item in (IEnumerable)base.Items)
		{
			if (base.ItemContainerGenerator.ContainerFromItem(item) is AutoHideTabItem autoHideTabItem)
			{
				autoHideTabItem.j8G();
			}
		}
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is AutoHideTabItem target)
		{
			BindingOperations.ClearBinding(target, AutoHideTabItem.IsAutoHidePopupOpenProperty);
			BindingOperations.ClearBinding(target, AutoHideTabItem.PlacementProperty);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new AutoHideTabItem();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is AutoHideTabItem;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AutoHideTabGroupAutomationPeer(this);
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (element is AutoHideTabItem autoHideTabItem)
		{
			autoHideTabItem.j8G();
			autoHideTabItem.BindToProperty(AutoHideTabItem.PlacementProperty, this, vVK.ssH(20362), BindingMode.OneWay);
			if (item is ToolWindow source)
			{
				autoHideTabItem.BindToProperty(AutoHideTabItem.IsAutoHidePopupOpenProperty, source, vVK.ssH(17660), BindingMode.OneWay);
			}
		}
	}

	static AutoHideTabGroup()
	{
		IVH.CecNqz();
		PlacementProperty = DependencyProperty.Register(vVK.ssH(20362), typeof(Side), typeof(AutoHideTabGroup), new PropertyMetadata(Side.Top));
	}

	internal static bool d8X()
	{
		return S8a == null;
	}

	internal static AutoHideTabGroup t8s()
	{
		return S8a;
	}
}
