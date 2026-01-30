using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
public class StandardMdiItemsControl : ItemsControl
{
	internal static StandardMdiItemsControl hnq;

	public StandardMdiItemsControl()
	{
		IVH.CecNqz();
		base._002Ector();
		base.DefaultStyleKey = typeof(StandardMdiItemsControl);
	}

	private StandardMdiHost grR()
	{
		if (base.TemplatedParent is StandardMdiHost result)
		{
			return result;
		}
		return VisualTreeHelperExtended.GetAncestor<StandardMdiHost>(this);
	}

	protected override void ClearContainerForItemOverride(DependencyObject element, object item)
	{
		base.ClearContainerForItemOverride(element, item);
		if (element is StandardMdiWindowControl standardMdiWindowControl)
		{
			standardMdiWindowControl.SrY(null);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.ContextContentProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.ContextContentTemplateProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.HasCloseButtonProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.HasMaximizeButtonProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.HasMinimizeButtonProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.IconProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.IsMaximizedFrameVisibleProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.IsReadOnlyProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.RestoredBoundsProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.TitleProperty);
			BindingOperations.ClearBinding(standardMdiWindowControl, WindowControl.WindowStateProperty);
		}
	}

	protected override DependencyObject GetContainerForItemOverride()
	{
		return new StandardMdiWindowControl();
	}

	protected override bool IsItemItsOwnContainerOverride(object item)
	{
		return item is StandardMdiWindowControl;
	}

	protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
	{
		base.PrepareContainerForItemOverride(element, item);
		StandardMdiWindowControl standardMdiWindowControl = element as StandardMdiWindowControl;
		DockingWindow dockingWindow = item as DockingWindow;
		if (standardMdiWindowControl == null || dockingWindow == null)
		{
			return;
		}
		standardMdiWindowControl.SrY(grR());
		standardMdiWindowControl.BindToProperty(WindowControl.ContextContentProperty, dockingWindow, vVK.ssH(3840), BindingMode.OneWay, new NonUIElementConverter());
		standardMdiWindowControl.BindToProperty(WindowControl.ContextContentTemplateProperty, dockingWindow, vVK.ssH(8554), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.HasCloseButtonProperty, dockingWindow, vVK.ssH(7550), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.HasMaximizeButtonProperty, dockingWindow, vVK.ssH(7954), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.HasMinimizeButtonProperty, dockingWindow, vVK.ssH(8066), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.IconProperty, dockingWindow, vVK.ssH(6138), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.RestoredBoundsProperty, dockingWindow, vVK.ssH(8516), BindingMode.TwoWay);
		standardMdiWindowControl.BindToProperty(WindowControl.TitleProperty, dockingWindow, vVK.ssH(7338), BindingMode.OneWay);
		standardMdiWindowControl.BindToProperty(WindowControl.WindowStateProperty, dockingWindow, vVK.ssH(8640), BindingMode.TwoWay);
		if (dockingWindow is DocumentWindow)
		{
			standardMdiWindowControl.BindToProperty(WindowControl.IsReadOnlyProperty, dockingWindow, vVK.ssH(6330), BindingMode.OneWay);
		}
		if (standardMdiWindowControl.lr9() == null)
		{
			return;
		}
		standardMdiWindowControl.BindToProperty(WindowControl.IsMaximizedFrameVisibleProperty, standardMdiWindowControl.lr9(), vVK.ssH(15658), BindingMode.OneWay);
		if (standardMdiWindowControl.WindowState != WindowState.Maximized && (dockingWindow.SizeToContentModes & SizeToContentModes.StandardMdi) != SizeToContentModes.StandardMdi)
		{
			Rect standardMdiBounds = dockingWindow.StandardMdiBounds;
			if (!standardMdiBounds.IsEmpty)
			{
				standardMdiWindowControl.Width = standardMdiBounds.Width;
				standardMdiWindowControl.Height = standardMdiBounds.Height;
			}
		}
		int value = standardMdiWindowControl.lr9().EaS(dockingWindow);
		Panel.SetZIndex(standardMdiWindowControl, value);
	}

	internal static bool Gnw()
	{
		return hnq == null;
	}

	internal static StandardMdiItemsControl ang()
	{
		return hnq;
	}
}
