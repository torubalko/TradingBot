using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Editors.Primitives;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_HueRing", Type = typeof(HueRing))]
[TemplatePart(Name = "PART_Slider", Type = typeof(RadialSlider))]
public class RadialHuePicker : ContentControl
{
	private InputAdapter Nfe;

	private HueRing Qfk;

	private RadialSlider FfE;

	public static readonly DependencyProperty HueProperty;

	public static readonly DependencyProperty RadiusProperty;

	public static readonly DependencyProperty SliderRadiusProperty;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler vf7;

	private static RadialHuePicker TrJ;

	public double Hue
	{
		get
		{
			return (double)GetValue(HueProperty);
		}
		set
		{
			SetValue(HueProperty, value);
		}
	}

	public double Radius
	{
		get
		{
			return (double)GetValue(RadiusProperty);
		}
		set
		{
			SetValue(RadiusProperty, value);
		}
	}

	public double SliderRadius
	{
		get
		{
			return (double)GetValue(SliderRadiusProperty);
		}
		private set
		{
			SetValue(SliderRadiusProperty, value);
		}
	}

	public event EventHandler HueChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = vf7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vf7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = vf7;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref vf7, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public RadialHuePicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(RadialHuePicker);
		ef1();
	}

	private void ef1()
	{
		Nfe = new InputAdapter(this);
		Nfe.PointerPressed += Tfp;
		Nfe.AttachedEventKinds = InputAdapterEventKinds.PointerPressed;
	}

	private bool ff8(Point P_0)
	{
		if (Qfk != null)
		{
			double num = base.ActualWidth / 2.0;
			double num2 = base.ActualHeight / 2.0;
			if (sfr(num, num2, Radius, P_0) && !sfr(num, num2, Math.Max(0.0, Radius - Qfk.Length), P_0))
			{
				return true;
			}
		}
		return false;
	}

	private static bool sfr(double P_0, double P_1, double P_2, Point P_3)
	{
		double num = Math.Sqrt(Math.Pow(P_0 - P_3.X, 2.0) + Math.Pow(P_1 - P_3.Y, 2.0));
		return num <= P_2;
	}

	private static void xfv(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RadialHuePicker radialHuePicker = (RadialHuePicker)P_0;
		radialHuePicker.Vfi();
	}

	private void Tfp(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && FfE != null && Qfk != null && ff8(P_1.GetPosition(this)))
		{
			FfE.StartDrag(P_1);
		}
	}

	private static void dfW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RadialHuePicker radialHuePicker = (RadialHuePicker)P_0;
		radialHuePicker.ofZ();
	}

	private void Vfi()
	{
		vf7?.Invoke(this, EventArgs.Empty);
	}

	[SpecialName]
	private double Rft()
	{
		return Math.Max(0.0, Radius);
	}

	private void ofZ()
	{
		double height = (base.Width = 2.0 * Rft());
		base.Height = height;
		double num2 = Math.Max(0.0, (Qfk != null) ? (Qfk.Length / 2.0) : 20.0);
		SliderRadius = Math.Max(0.0, Rft() - num2);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Qfk = GetTemplateChild(QdM.AR8(22258)) as HueRing;
		FfE = GetTemplateChild(QdM.AR8(22286)) as RadialSlider;
		ofZ();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new RadialHuePickerAutomationPeer(this);
	}

	static RadialHuePicker()
	{
		awj.QuEwGz();
		HueProperty = DependencyProperty.Register(QdM.AR8(2608), typeof(double), typeof(RadialHuePicker), new PropertyMetadata(0.0, xfv));
		RadiusProperty = DependencyProperty.Register(QdM.AR8(22312), typeof(double), typeof(RadialHuePicker), new PropertyMetadata(130.0, dfW));
		SliderRadiusProperty = DependencyProperty.Register(QdM.AR8(22328), typeof(double), typeof(RadialHuePicker), new PropertyMetadata(110.0));
	}

	internal static bool Yrh()
	{
		return TrJ == null;
	}

	internal static RadialHuePicker RrS()
	{
		return TrJ;
	}
}
