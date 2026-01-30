using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Docking.Automation.Peers;
using ActiproSoftware.Windows.Input;
using ActiproSoftware.Windows.Media;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[ToolboxItem(false)]
[TemplateVisualState(Name = "Selected", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
public class StandardSwitcherItem : ContentControl
{
	private InputAdapter rr4;

	public static readonly DependencyProperty IsSelectedProperty;

	private static StandardSwitcherItem fnr;

	internal DockingWindow DockingWindow => base.Content as DockingWindow;

	public bool IsSelected
	{
		get
		{
			return (bool)GetValue(IsSelectedProperty);
		}
		set
		{
			SetValue(IsSelectedProperty, value);
		}
	}

	public StandardSwitcherItem()
	{
		IVH.CecNqz();
		base._002Ector();
		brF();
	}

	private void brF()
	{
		rr4 = new InputAdapter(this);
		rr4.PointerPressed += RrP;
		rr4.Tapped += wrf;
		rr4.AttachedEventKinds = InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.Tapped;
	}

	private static void lrV(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((StandardSwitcherItem)P_0).irU(_0020: true);
	}

	private void RrP(object P_0, InputPointerButtonEventArgs P_1)
	{
		VisualTreeHelperExtended.GetAncestor<StandardSwitcher>(this)?.hWB(this);
	}

	private void wrf(object P_0, InputTappedEventArgs P_1)
	{
		StandardSwitcher ancestor = VisualTreeHelperExtended.GetAncestor<StandardSwitcher>(this);
		if (ancestor != null && ancestor.IsOpen)
		{
			ancestor.Close();
		}
	}

	private void irU(bool P_0)
	{
		VisualStateManager.GoToState(this, IsSelected ? vVK.ssH(21660) : vVK.ssH(20450), P_0);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		irU(_0020: false);
	}

	protected override void OnContentChanged(object oldContent, object newContent)
	{
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new StandardSwitcherItemAutomationPeer(this);
	}

	static StandardSwitcherItem()
	{
		IVH.CecNqz();
		IsSelectedProperty = DependencyProperty.Register(vVK.ssH(8344), typeof(bool), typeof(StandardSwitcherItem), new PropertyMetadata(false, lrV));
	}

	internal static bool Xnz()
	{
		return fnr == null;
	}

	internal static StandardSwitcherItem NA0()
	{
		return fnr;
	}
}
