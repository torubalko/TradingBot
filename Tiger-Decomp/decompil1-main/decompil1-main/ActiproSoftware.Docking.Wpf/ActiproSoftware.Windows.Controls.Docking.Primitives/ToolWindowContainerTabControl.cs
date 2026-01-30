using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class ToolWindowContainerTabControl : AdvancedTabControl
{
	private static ToolWindowContainerTabControl NAB;

	public ToolWindowContainerTabControl()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(ToolWindowContainerTabControl);
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is AdvancedTabItem advancedTabItem && (advancedTabItem != item || !advancedTabItem.owZ()))
		{
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.CanCloseProperty);
			int num = 0;
			if (VAj() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ContextContentTemplateProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.FlashColorProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.FlashModeProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.ImageSourceProperty);
			BindingOperations.ClearBinding(advancedTabItem, AdvancedTabItem.TintColorProperty);
			BindingOperations.ClearBinding(advancedTabItem, ToolTipService.ToolTipProperty);
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
		int num = 0;
		if (VAj() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (advancedTabItem != null && dockingWindow != null && (advancedTabItem != item || !advancedTabItem.owZ()))
		{
			advancedTabItem.BindToProperty(AdvancedTabItem.CanCloseProperty, dockingWindow, vVK.ssH(7550), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.ContextContentTemplateProperty, dockingWindow, vVK.ssH(17702), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.FlashColorProperty, dockingWindow, vVK.ssH(8702), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.FlashModeProperty, dockingWindow, vVK.ssH(8732), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.ImageSourceProperty, dockingWindow, vVK.ssH(6138), BindingMode.OneWay);
			advancedTabItem.BindToProperty(AdvancedTabItem.TintColorProperty, dockingWindow, vVK.ssH(8926), BindingMode.OneWay);
			advancedTabItem.BindToProperty(ToolTipService.ToolTipProperty, dockingWindow, vVK.ssH(8954), BindingMode.OneWay);
		}
	}

	internal static bool PA5()
	{
		return NAB == null;
	}

	internal static ToolWindowContainerTabControl VAj()
	{
		return NAB;
	}
}
