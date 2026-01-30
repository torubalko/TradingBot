using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Grids.Automation.Peers;
using ActiproSoftware.Windows.Controls.Grids.Primitives;
using ActiproSoftware.Windows.Controls.Grids.PropertyData;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Grids;

[ToolboxItem(false)]
public class PropertyGridItem : TreeListViewItem
{
	public static readonly DependencyProperty GridLineBrushProperty;

	public static readonly DependencyProperty IndentIndicatorBackgroundProperty;

	private WeakReference PP1;

	public static readonly DependencyProperty IsInactiveSelectionVisibleProperty;

	private static PropertyGridItem kP;

	public Brush GridLineBrush
	{
		get
		{
			return (Brush)GetValue(GridLineBrushProperty);
		}
		set
		{
			SetValue(GridLineBrushProperty, value);
		}
	}

	public Brush IndentIndicatorBackground
	{
		get
		{
			return (Brush)GetValue(IndentIndicatorBackgroundProperty);
		}
		set
		{
			SetValue(IndentIndicatorBackgroundProperty, value);
		}
	}

	public bool IsInactiveSelectionVisible
	{
		get
		{
			return (bool)GetValue(IsInactiveSelectionVisibleProperty);
		}
		set
		{
			SetValue(IsInactiveSelectionVisibleProperty, value);
		}
	}

	public PropertyGridItem()
	{
		fc.taYSkz();
		base._002Ector();
		base.DefaultStyleKey = typeof(PropertyGridItem);
	}

	private Control gf()
	{
		return VisualTreeHelperExtended.GetDescendant<PropertyGridItemRowPanel>(this, 0)?.SEy();
	}

	internal Control U0()
	{
		return VisualTreeHelperExtended.GetDescendant<PropertyGridItemRowPanel>(this, 0)?.CEB();
	}

	[SpecialName]
	private PropertyGrid h4()
	{
		return VisualTreeHelperExtended.GetAncestor<PropertyGrid>(this);
	}

	private bool wA(string P_0)
	{
		if (U0() != null)
		{
			Control firstTabStopDescendant = VisualTreeHelperExtended.GetFirstTabStopDescendant(this);
			if (firstTabStopDescendant != null)
			{
				PropertyGridItemActionHandler propertyGridItemActionHandler = PropertyGrid.StartPropertyValueEditHandlers.QPC(firstTabStopDescendant.GetType());
				if (propertyGridItemActionHandler != null)
				{
					return propertyGridItemActionHandler(new PropertyGridItemActionRequest(this, firstTabStopDescendant, P_0));
				}
			}
		}
		return false;
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new PropertyGridItemWrapperAutomationPeer(this);
	}

	protected override void OnDoubleTapped(InputPointerButtonEventArgs e)
	{
		if (base.Content is IPropertyModel propertyModel)
		{
			Control control = gf();
			if (control != null && e != null && e.IsPositionOver(control) && !propertyModel.IsReadOnly)
			{
				if (propertyModel.CycleToNextStandardValue() || wA(null))
				{
					return;
				}
			}
			else if (propertyModel.Children.Count == 0)
			{
				return;
			}
		}
		base.OnDoubleTapped(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		if (e != null && !e.Handled)
		{
			bool flag = base.Content is IPropertyModel;
			ModifierKeys modifierKeys = LY.hle();
			switch ((e.Key == Key.System) ? e.SystemKey : e.Key)
			{
			case Key.A:
				if (modifierKeys == ModifierKeys.Control)
				{
					return;
				}
				break;
			case Key.Back:
			case Key.Space:
			case Key.Multiply:
			case Key.Add:
			case Key.Subtract:
			case Key.Divide:
				if (flag)
				{
					return;
				}
				break;
			case Key.Return:
			{
				PropertyGrid propertyGrid = h4();
				if (propertyGrid == null || KeyboardNavigation.GetAcceptsReturn(propertyGrid))
				{
					e.Handled = TryCommitPropertyValueEdit();
				}
				if (flag)
				{
					return;
				}
				break;
			}
			case Key.Escape:
				e.Handled = TryCancelPropertyValueEdit();
				break;
			case Key.Tab:
				if (modifierKeys == ModifierKeys.None && LY.KlB(this))
				{
					e.Handled = wA(null);
				}
				break;
			}
		}
		base.OnKeyDown(e);
	}

	protected internal virtual bool TryCancelPropertyValueEdit()
	{
		if (base.Content is IPropertyModel && LY.zld() is FrameworkElement frameworkElement && frameworkElement != this && LY.OlM(this))
		{
			bool result = false;
			PropertyGridItemActionHandler propertyGridItemActionHandler = PropertyGrid.CancelPropertyValueEditHandlers.QPC(frameworkElement.GetType());
			if (propertyGridItemActionHandler != null)
			{
				result = propertyGridItemActionHandler(new PropertyGridItemActionRequest(this, frameworkElement, null));
			}
			Focus();
			return result;
		}
		return false;
	}

	protected internal virtual bool TryCommitPropertyValueEdit()
	{
		if (base.Content is IPropertyModel)
		{
			bool flag = false;
			FrameworkElement frameworkElement = null;
			if (LY.OlM(this))
			{
				frameworkElement = LY.zld() as FrameworkElement;
				flag = true;
			}
			else
			{
				frameworkElement = Yz() as FrameworkElement;
			}
			bool flag2 = false;
			if (frameworkElement != null && frameworkElement != this)
			{
				PropertyGridItemActionHandler propertyGridItemActionHandler = PropertyGrid.CommitPropertyValueEditHandlers.QPC(frameworkElement.GetType());
				if (propertyGridItemActionHandler != null)
				{
					flag2 = propertyGridItemActionHandler(new PropertyGridItemActionRequest(this, frameworkElement, null));
				}
			}
			if (flag)
			{
				flag2 |= Focus();
			}
			return flag2;
		}
		return false;
	}

	[SpecialName]
	private IInputElement Yz()
	{
		if (PP1 != null)
		{
			if (PP1.IsAlive)
			{
				return PP1.Target as IInputElement;
			}
			PP1 = null;
		}
		return null;
	}

	[SpecialName]
	private void TPI(IInputElement value)
	{
		PP1 = ((value != null) ? new WeakReference(value) : null);
	}

	protected override void OnGotKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		TPI(null);
		if (!base.IsTabStop && e.OriginalSource == this && base.Content is IPropertyModel)
		{
			wA(null);
		}
		base.OnGotKeyboardFocus(e);
	}

	protected override void OnLostKeyboardFocus(KeyboardFocusChangedEventArgs e)
	{
		TPI(null);
		if (e != null && e.OldFocus != null && e.OldFocus != this && !base.IsKeyboardFocusWithin)
		{
			TPI(e.OldFocus);
		}
		base.OnLostKeyboardFocus(e);
	}

	protected override void OnPreviewTextInput(TextCompositionEventArgs e)
	{
		if (e != null && base.IsKeyboardFocused && base.Content is IPropertyModel)
		{
			wA(e.Text);
		}
		base.OnPreviewTextInput(e);
	}

	static PropertyGridItem()
	{
		fc.taYSkz();
		GridLineBrushProperty = DependencyProperty.Register(xv.hTz(2966), typeof(Brush), typeof(PropertyGridItem), new PropertyMetadata(null));
		IndentIndicatorBackgroundProperty = DependencyProperty.Register(xv.hTz(2996), typeof(Brush), typeof(PropertyGridItem), new PropertyMetadata(null));
		IsInactiveSelectionVisibleProperty = DependencyProperty.Register(xv.hTz(3050), typeof(bool), typeof(PropertyGridItem), new PropertyMetadata(true));
	}

	internal static bool rh()
	{
		return kP == null;
	}

	internal static PropertyGridItem Su()
	{
		return kP;
	}
}
