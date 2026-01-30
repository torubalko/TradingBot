using System.Collections;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class AutoHideTabStrip : ItemsControl
{
	private InputAdapter h8E;

	public static readonly DependencyProperty IsHorizontalProperty;

	public static readonly DependencyProperty PlacementProperty;

	public static readonly DependencyProperty TabItemTemplateProperty;

	public static readonly DependencyProperty TabItemTemplateSelectorProperty;

	internal static AutoHideTabStrip W8S;

	public bool IsHorizontal
	{
		get
		{
			return (bool)GetValue(IsHorizontalProperty);
		}
		private set
		{
			SetValue(IsHorizontalProperty, value);
		}
	}

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

	public DataTemplate TabItemTemplate
	{
		get
		{
			return (DataTemplate)GetValue(TabItemTemplateProperty);
		}
		set
		{
			SetValue(TabItemTemplateProperty, value);
		}
	}

	public DataTemplateSelector TabItemTemplateSelector
	{
		get
		{
			return (DataTemplateSelector)GetValue(TabItemTemplateSelectorProperty);
		}
		set
		{
			SetValue(TabItemTemplateSelectorProperty, value);
		}
	}

	public AutoHideTabStrip()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(AutoHideTabStrip);
		a8J();
	}

	private void a8J()
	{
		h8E = new InputAdapter(this);
		h8E.PointerReleased += j8O;
		h8E.AttachedEventKinds = InputAdapterEventKinds.PointerReleased;
	}

	private static void f8n(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutoHideTabStrip autoHideTabStrip = (AutoHideTabStrip)P_0;
		Side placement = autoHideTabStrip.Placement;
		if (placement == Side.Top || placement == Side.Bottom)
		{
			autoHideTabStrip.IsHorizontal = true;
		}
		else
		{
			autoHideTabStrip.IsHorizontal = false;
		}
	}

	private void j8O(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && P_1.ButtonKind == InputPointerButtonKind.Secondary)
		{
			P_1.Handled = true;
			p8T(P_1, null);
		}
	}

	internal void p8T(InputPointerButtonEventArgs P_0, ToolWindow P_1)
	{
		DockHost ancestor = VisualTreeHelperExtended.GetAncestor<DockHost>(this);
		if (ancestor == null)
		{
			return;
		}
		DockSite dockSite = ancestor.DockSite;
		if (dockSite != null)
		{
			DockingMenuEventArgs e = new DockingMenuEventArgs(DockingMenuKind.AutoHideContextMenu)
			{
				Window = P_1
			};
			e.Menu = DockSite.pNE(ancestor, Placement);
			dockSite.C19(e);
			ContextMenu menu = e.Menu;
			if (!e.Cancel && menu != null && menu.Items.Count > 0)
			{
				menu.PlacementTarget = this;
				menu.Placement = PlacementMode.MousePoint;
				menu.IsOpen = true;
				P_0.Handled = true;
			}
		}
	}

	internal void T88()
	{
		foreach (object item in (IEnumerable)base.Items)
		{
			if (base.ItemContainerGenerator.ContainerFromItem(item) is AutoHideTabGroup autoHideTabGroup)
			{
				autoHideTabGroup.aTX();
			}
		}
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is AutoHideTabGroup target)
		{
			BindingOperations.ClearBinding(target, ItemsControl.ItemsSourceProperty);
			BindingOperations.ClearBinding(target, ItemsControl.ItemTemplateProperty);
			BindingOperations.ClearBinding(target, ItemsControl.ItemTemplateSelectorProperty);
			BindingOperations.ClearBinding(target, AutoHideTabGroup.PlacementProperty);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new AutoHideTabGroup();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is AutoHideTabGroup;
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		if (element is AutoHideTabGroup element2)
		{
			element2.BindToProperty(ItemsControl.ItemsSourceProperty, item, vVK.ssH(20466), BindingMode.OneWay);
			element2.BindToProperty(ItemsControl.ItemTemplateProperty, this, vVK.ssH(20484), BindingMode.OneWay);
			element2.BindToProperty(ItemsControl.ItemTemplateSelectorProperty, this, vVK.ssH(20518), BindingMode.OneWay);
			element2.BindToProperty(AutoHideTabGroup.PlacementProperty, this, vVK.ssH(20362), BindingMode.OneWay);
		}
	}

	static AutoHideTabStrip()
	{
		IVH.CecNqz();
		IsHorizontalProperty = DependencyProperty.Register(vVK.ssH(20568), typeof(bool), typeof(AutoHideTabStrip), new PropertyMetadata(true));
		PlacementProperty = DependencyProperty.Register(vVK.ssH(20362), typeof(Side), typeof(AutoHideTabStrip), new PropertyMetadata(Side.Top, f8n));
		TabItemTemplateProperty = DependencyProperty.Register(vVK.ssH(20484), typeof(DataTemplate), typeof(AutoHideTabStrip), new PropertyMetadata(null));
		TabItemTemplateSelectorProperty = DependencyProperty.Register(vVK.ssH(20518), typeof(DataTemplateSelector), typeof(AutoHideTabStrip), new PropertyMetadata(null));
	}

	internal static bool h8P()
	{
		return W8S == null;
	}

	internal static AutoHideTabStrip i8e()
	{
		return W8S;
	}
}
