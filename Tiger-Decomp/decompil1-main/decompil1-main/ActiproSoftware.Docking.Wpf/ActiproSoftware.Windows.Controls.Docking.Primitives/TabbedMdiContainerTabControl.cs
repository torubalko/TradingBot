using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class TabbedMdiContainerTabControl : AdvancedTabControl
{
	private bool Uxw;

	internal static TabbedMdiContainerTabControl mA8;

	public TabbedMdiContainerTabControl()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(TabbedMdiContainerTabControl);
		base.ItemContainerGenerator.StatusChanged += delegate
		{
			if (Uxw)
			{
				UpdateHighlightBrushes();
			}
		};
	}

	private void Txi()
	{
		if (XdF() != null)
		{
			UpdateHighlightBrushes();
		}
		else
		{
			Uxw = true;
		}
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		AdvancedTabItem advancedTabItem = element as AdvancedTabItem;
		DockingWindow dockingWindow = item as DockingWindow;
		if (advancedTabItem != null && dockingWindow != null && (advancedTabItem != item || !advancedTabItem.owZ()))
		{
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CanCloseProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ContextContentTemplateProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.FlashColorProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.FlashModeProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ImageSourceProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.LayoutKindProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.TintColorProperty);
			BindingOperations.ClearBinding(advancedTabItem, ToolTipService.ToolTipProperty);
			if (dockingWindow is DocumentWindow)
			{
				BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.IsReadOnlyProperty);
			}
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new DockingWindowContainerTabItem();
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		AdvancedTabItem advancedTabItem = element as AdvancedTabItem;
		DockingWindow dockingWindow = item as DockingWindow;
		if (advancedTabItem != null && dockingWindow != null && (advancedTabItem != item || !advancedTabItem.owZ()))
		{
			advancedTabItem.BindToProperty(AdvancedTabItem.CanCloseProperty, dockingWindow, vVK.ssH(7550), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.ContextContentTemplateProperty, dockingWindow, vVK.ssH(8802), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.FlashColorProperty, dockingWindow, vVK.ssH(8702), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.FlashModeProperty, dockingWindow, vVK.ssH(8732), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.ImageSourceProperty, dockingWindow, vVK.ssH(6138), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.LayoutKindProperty, dockingWindow, vVK.ssH(8760), BindingMode.TwoWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.TintColorProperty, dockingWindow, vVK.ssH(8926), BindingMode.OneWay);
			advancedTabItem.BindToProperty(ToolTipService.ToolTipProperty, dockingWindow, vVK.ssH(8954), BindingMode.OneWay);
			if (dockingWindow is DocumentWindow)
			{
				advancedTabItem.BindToProperty(AdvancedTabItem.IsReadOnlyProperty, dockingWindow, vVK.ssH(6330), BindingMode.OneWay);
			}
		}
	}

	protected override void OnSelectionChanged(SelectionChangedEventArgs e)
	{
		Txi();
		base.OnSelectionChanged(e);
	}

	protected internal override void UpdateHighlightBrushes()
	{
		AdvancedTabItem advancedTabItem = XdF();
		if (advancedTabItem != null)
		{
			Uxw = false;
			Brush brush = hW.RlQ((advancedTabItem.LayoutKind == TabLayoutKind.Preview) ? advancedTabItem.BorderBrushPreviewActiveSelected : advancedTabItem.BorderBrushActiveSelected);
			Brush brush2 = hW.RlQ(advancedTabItem.BorderBrushInactiveSelected);
			Color tintColor = advancedTabItem.TintColor;
			if (tintColor != Colors.Transparent)
			{
				brush = hW.ylm(brush, tintColor, _0020: false);
				brush2 = hW.ylm(brush2, tintColor, _0020: false);
			}
			base.HighlightBrushActive = brush;
			base.HighlightBrushInactive = brush2;
		}
	}

	[CompilerGenerated]
	private void xxd(object P_0, EventArgs P_1)
	{
		if (Uxw)
		{
			UpdateHighlightBrushes();
		}
	}

	internal static bool AAn()
	{
		return mA8 == null;
	}

	internal static TabbedMdiContainerTabControl OAA()
	{
		return mA8;
	}
}
