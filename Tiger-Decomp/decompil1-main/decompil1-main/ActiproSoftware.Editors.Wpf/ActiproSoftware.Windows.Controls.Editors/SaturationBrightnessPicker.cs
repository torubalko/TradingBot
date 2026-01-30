using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Editors.Automation.Peers;
using ActiproSoftware.Windows.Controls.Primitives;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplatePart(Name = "PART_Thumb", Type = typeof(CircularThumb))]
public class SaturationBrightnessPicker : Control
{
	private InputAdapter BXl;

	private CircularThumb RXX;

	private InputAdapter LXx;

	private const double LargeChange = 0.05;

	private const double SmallChange = 0.01;

	public static readonly DependencyProperty BrightnessProperty;

	public static readonly DependencyProperty HueProperty;

	public static readonly DependencyProperty SaturationProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private EventHandler JX0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private EventHandler hXY;

	internal static SaturationBrightnessPicker nrc;

	public double Brightness
	{
		get
		{
			return (double)GetValue(BrightnessProperty);
		}
		set
		{
			SetValue(BrightnessProperty, value);
		}
	}

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

	public double Saturation
	{
		get
		{
			return (double)GetValue(SaturationProperty);
		}
		set
		{
			SetValue(SaturationProperty, value);
		}
	}

	public event EventHandler BrightnessChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = JX0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref JX0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = JX0;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref JX0, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public event EventHandler SaturationChanged
	{
		[CompilerGenerated]
		add
		{
			EventHandler eventHandler = hXY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hXY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler eventHandler = hXY;
			EventHandler eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
				eventHandler = Interlocked.CompareExchange(ref hXY, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public SaturationBrightnessPicker()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(SaturationBrightnessPicker);
		MlE();
		base.SizeChanged += qlw;
	}

	private void MlE()
	{
		BXl = new InputAdapter(this);
		BXl.PointerPressed += Tl4;
		BXl.PointerWheelChanged += ElB;
		BXl.AttachedEventKinds = InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerWheelChanged;
	}

	private static void nl7(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SaturationBrightnessPicker saturationBrightnessPicker = (SaturationBrightnessPicker)P_0;
		saturationBrightnessPicker.aXM();
		saturationBrightnessPicker.IXQ();
	}

	private void Tl4(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (RXX != null && P_1 != null && !P_1.Handled)
		{
			RXX.StartDrag(P_1);
			Dlz(P_1);
		}
	}

	private void ElB(object P_0, InputPointerWheelEventArgs P_1)
	{
		if (!P_1.Handled)
		{
			int delta = P_1.Delta;
			int singleUnitDelta = P_1.SingleUnitDelta;
			int num = ((delta > 0) ? Math.Max(singleUnitDelta, delta) : Math.Min(-singleUnitDelta, delta)) / singleUnitDelta;
			OXC(Brightness + (double)num * 0.05);
			P_1.Handled = true;
			int num2 = 0;
			if (Vry() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			case 0:
				break;
			}
		}
	}

	private static void Olh(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SaturationBrightnessPicker saturationBrightnessPicker = (SaturationBrightnessPicker)P_0;
		saturationBrightnessPicker.aXM();
		saturationBrightnessPicker.sXV();
	}

	private void qlw(object P_0, SizeChangedEventArgs P_1)
	{
		aXM();
	}

	private void xlN(object P_0, InputKeyEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled)
		{
			switch (P_1.Key)
			{
			case Key.Down:
				OXC(Brightness - 0.01);
				P_1.Handled = true;
				break;
			case Key.End:
				OXC(0.0);
				FX6(1.0);
				P_1.Handled = true;
				break;
			case Key.Home:
				OXC(1.0);
				FX6(0.0);
				P_1.Handled = true;
				break;
			case Key.Left:
				FX6(Saturation - 0.01);
				P_1.Handled = true;
				break;
			case Key.Next:
				OXC(Brightness - 0.05);
				P_1.Handled = true;
				break;
			case Key.Prior:
				OXC(Brightness + 0.05);
				P_1.Handled = true;
				break;
			case Key.Right:
				FX6(Saturation + 0.01);
				P_1.Handled = true;
				break;
			case Key.Up:
				OXC(Brightness + 0.01);
				P_1.Handled = true;
				break;
			}
		}
	}

	private void tlU(object P_0, InputPointerEventArgs P_1)
	{
		Dlz(P_1);
	}

	private void Dlz(InputPointerEventArgs P_0)
	{
		if (P_0 != null && RXX != null && RXX.IsDragging)
		{
			Point position = P_0.GetPosition(this);
			Size currentSize = this.GetCurrentSize();
			Point point = new Point(Math.Max(0.0, Math.Min(currentSize.Width, position.X)), Math.Max(0.0, Math.Min(currentSize.Height, position.Y)));
			OXC(1.0 - point.Y / currentSize.Height);
			FX6(point.X / currentSize.Width);
		}
	}

	private void IXQ()
	{
		JX0?.Invoke(this, EventArgs.Empty);
	}

	private void sXV()
	{
		hXY?.Invoke(this, EventArgs.Empty);
	}

	[SpecialName]
	private double nXs()
	{
		return Math.Max(0.0, Math.Min(1.0, Brightness));
	}

	[SpecialName]
	private double GXP()
	{
		return Hue.GetNormalizedDegreeAngle();
	}

	[SpecialName]
	private double rXa()
	{
		return Math.Max(0.0, Math.Min(1.0, Saturation));
	}

	private void OXC(double P_0)
	{
		Brightness = Math.Max(0.0, Math.Min(1.0, P_0));
	}

	private void FX6(double P_0)
	{
		Saturation = Math.Max(0.0, Math.Min(1.0, P_0));
	}

	private void aXM()
	{
		if (RXX == null)
		{
			return;
		}
		TranslateTransform translateTransform = RXX.RenderTransform as TranslateTransform;
		if (translateTransform == null)
		{
			translateTransform = new TranslateTransform();
			RXX.RenderTransform = translateTransform;
			int num = 0;
			if (Vry() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
		}
		Size currentSize = this.GetCurrentSize();
		translateTransform.X = (currentSize.Width - 1.0) * rXa() - currentSize.Width / 2.0;
		translateTransform.Y = (currentSize.Height - 1.0) * (1.0 - nXs()) - currentSize.Height / 2.0;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (LXx != null)
		{
			int num = 0;
			if (!grD())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			LXx.AttachedEventKinds = InputAdapterEventKinds.None;
			LXx.KeyDown -= xlN;
			LXx.PointerMoved -= tlU;
			LXx = null;
		}
		RXX = GetTemplateChild(QdM.AR8(22746)) as CircularThumb;
		if (RXX != null)
		{
			LXx = new InputAdapter(RXX);
			LXx.KeyDown += xlN;
			LXx.PointerMoved += tlU;
			LXx.AttachedEventKinds = InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.KeyDown;
		}
		aXM();
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return new SaturationBrightnessPickerAutomationPeer(this);
	}

	static SaturationBrightnessPicker()
	{
		awj.QuEwGz();
		BrightnessProperty = DependencyProperty.Register(QdM.AR8(2654), typeof(double), typeof(SaturationBrightnessPicker), new PropertyMetadata(1.0, nl7));
		HueProperty = DependencyProperty.Register(QdM.AR8(2608), typeof(double), typeof(SaturationBrightnessPicker), new PropertyMetadata(0.0));
		SaturationProperty = DependencyProperty.Register(QdM.AR8(2624), typeof(double), typeof(SaturationBrightnessPicker), new PropertyMetadata(1.0, Olh));
	}

	internal static bool grD()
	{
		return nrc == null;
	}

	internal static SaturationBrightnessPicker Vry()
	{
		return nrc;
	}
}
