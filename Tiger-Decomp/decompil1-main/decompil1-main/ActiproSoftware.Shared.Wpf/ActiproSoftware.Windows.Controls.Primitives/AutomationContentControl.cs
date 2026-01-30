using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Windows.Controls.Automation.Peers;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public class AutomationContentControl : ContentControl
{
	public static readonly DependencyProperty ControlTypeProperty;

	private static AutomationContentControl a02;

	public AutomationControlType ControlType
	{
		get
		{
			return (AutomationControlType)GetValue(ControlTypeProperty);
		}
		set
		{
			SetValue(ControlTypeProperty, value);
		}
	}

	private static void dIM(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		AutomationContentControl element = (AutomationContentControl)P_0;
		if (UIElementAutomationPeer.FromElement(element) is AutomationContentControlAutomationPeer automationContentControlAutomationPeer)
		{
			automationContentControlAutomationPeer.InvalidatePeer();
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new AutomationContentControlAutomationPeer(this);
	}

	public AutomationContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static AutomationContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ControlTypeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117896), typeof(AutomationControlType), typeof(AutomationContentControl), new FrameworkPropertyMetadata(AutomationControlType.Pane, dIM));
	}

	internal static bool B0l()
	{
		return a02 == null;
	}

	internal static AutomationContentControl T0E()
	{
		return a02;
	}
}
