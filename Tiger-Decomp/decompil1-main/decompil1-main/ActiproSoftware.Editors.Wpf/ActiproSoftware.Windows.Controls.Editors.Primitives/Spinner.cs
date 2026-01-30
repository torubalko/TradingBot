using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ActiproSoftware.Internal;
using ActiproSoftware.Products.Editors;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[TemplateVisualState(Name = "Horizontal", GroupName = "OrientationStates")]
[TemplateVisualState(Name = "Vertical", GroupName = "OrientationStates")]
public class Spinner : Control
{
	public static readonly DependencyProperty CommandParameterProperty;

	public static readonly DependencyProperty DecrementCommandProperty;

	public static readonly DependencyProperty DecrementToolTipProperty;

	public static readonly DependencyProperty IncrementCommandProperty;

	public static readonly DependencyProperty IncrementToolTipProperty;

	public static readonly DependencyProperty OrientationProperty;

	internal static Spinner xhg;

	public object CommandParameter
	{
		get
		{
			return GetValue(CommandParameterProperty);
		}
		set
		{
			SetValue(CommandParameterProperty, value);
		}
	}

	public ICommand DecrementCommand
	{
		get
		{
			return (ICommand)GetValue(DecrementCommandProperty);
		}
		set
		{
			SetValue(DecrementCommandProperty, value);
		}
	}

	public object DecrementToolTip
	{
		get
		{
			return GetValue(DecrementToolTipProperty);
		}
		set
		{
			SetValue(DecrementToolTipProperty, value);
		}
	}

	public ICommand IncrementCommand
	{
		get
		{
			return (ICommand)GetValue(IncrementCommandProperty);
		}
		set
		{
			SetValue(IncrementCommandProperty, value);
		}
	}

	public object IncrementToolTip
	{
		get
		{
			return GetValue(IncrementToolTipProperty);
		}
		set
		{
			SetValue(IncrementToolTipProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public Spinner()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(Spinner);
	}

	private static void YIB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		Spinner spinner = (Spinner)P_0;
		spinner.NIh(_0020: false);
	}

	private void NIh(bool P_0)
	{
		VisualStateManager.GoToState(this, (Orientation == Orientation.Horizontal) ? QdM.AR8(26402) : QdM.AR8(26382), P_0);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		NIh(_0020: false);
	}

	static Spinner()
	{
		awj.QuEwGz();
		CommandParameterProperty = DependencyProperty.Register(QdM.AR8(22132), typeof(object), typeof(Spinner), new PropertyMetadata(null));
		DecrementCommandProperty = DependencyProperty.Register(QdM.AR8(26426), typeof(ICommand), typeof(Spinner), new PropertyMetadata(null));
		DecrementToolTipProperty = DependencyProperty.Register(QdM.AR8(26462), typeof(object), typeof(Spinner), new PropertyMetadata(SR.GetString(SRName.UISpinnerDecrementButtonToolTip)));
		IncrementCommandProperty = DependencyProperty.Register(QdM.AR8(26498), typeof(ICommand), typeof(Spinner), new PropertyMetadata(null));
		IncrementToolTipProperty = DependencyProperty.Register(QdM.AR8(26534), typeof(object), typeof(Spinner), new PropertyMetadata(SR.GetString(SRName.UISpinnerIncrementButtonToolTip)));
		OrientationProperty = DependencyProperty.Register(QdM.AR8(22356), typeof(Orientation), typeof(Spinner), new PropertyMetadata(Orientation.Vertical, YIB));
	}

	internal static bool Lhs()
	{
		return xhg == null;
	}

	internal static Spinner IhY()
	{
		return xhg;
	}
}
