using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using ActiproSoftware.Windows.Input;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
[TemplatePart(Name = "PART_Arrow", Type = typeof(UIElement))]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "PointerFocused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "PointerOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Pressed", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
public class CircularThumb : Control
{
	private InputAdapter kxh;

	private UIElement Xxm;

	private bool Wxw;

	private bool xx4;

	public static readonly DependencyProperty ArrowAngleProperty;

	public static readonly DependencyProperty IsDraggingProperty;

	public static readonly DependencyProperty PressedBackgroundProperty;

	private static CircularThumb KbM;

	public double ArrowAngle
	{
		get
		{
			return (double)GetValue(ArrowAngleProperty);
		}
		set
		{
			SetValue(ArrowAngleProperty, value);
		}
	}

	public bool IsDragging
	{
		get
		{
			return (bool)GetValue(IsDraggingProperty);
		}
		private set
		{
			SetValue(IsDraggingProperty, value);
		}
	}

	public Brush PressedBackground
	{
		get
		{
			return (Brush)GetValue(PressedBackgroundProperty);
		}
		set
		{
			SetValue(PressedBackgroundProperty, value);
		}
	}

	public CircularThumb()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DefaultStyleKey = typeof(CircularThumb);
		MxT();
	}

	private void MxT()
	{
		kxh = new InputAdapter(this);
		kxh.PointerCaptureLost += Xxp;
		int num = 0;
		if (!AbY())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		kxh.PointerEntered += qxb;
		kxh.PointerExited += Xxy;
		kxh.PointerMoved += Cxf;
		kxh.PointerPressed += wxi;
		kxh.PointerReleased += cxS;
		kxh.Tapped += Kx3;
		kxh.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerEntered | InputAdapterEventKinds.PointerExited | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased | InputAdapterEventKinds.Tapped;
	}

	private static void RxB(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		CircularThumb circularThumb = (CircularThumb)P_0;
		circularThumb.Fxt();
	}

	private void Xxp(object P_0, InputPointerEventArgs P_1)
	{
		IsDragging = false;
		zxJ(_0020: true);
	}

	private void qxb(object P_0, InputPointerEventArgs P_1)
	{
		xx4 = true;
		zxJ(_0020: true);
	}

	private void Xxy(object P_0, InputPointerEventArgs P_1)
	{
		xx4 = false;
		zxJ(_0020: true);
	}

	private void Cxf(object P_0, InputPointerEventArgs P_1)
	{
		xx4 = true;
		zxJ(_0020: true);
	}

	private void wxi(object P_0, InputPointerButtonEventArgs P_1)
	{
		StartDrag(P_1);
	}

	private void cxS(object P_0, InputPointerButtonEventArgs P_1)
	{
		IsDragging = false;
		zxJ(_0020: true);
		kxh.ReleasePointerCaptures();
	}

	private void Kx3(object P_0, InputTappedEventArgs P_1)
	{
		IsDragging = false;
		zxJ(_0020: true);
	}

	private void Fxt()
	{
		if (Xxm == null)
		{
			return;
		}
		RotateTransform rotateTransform = Xxm.RenderTransform as RotateTransform;
		bool flag = rotateTransform == null;
		int num = 0;
		if (xbt() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		case 1:
			rotateTransform = new RotateTransform();
			Xxm.RenderTransform = rotateTransform;
			break;
		default:
			if (!flag)
			{
				break;
			}
			goto case 1;
		}
		double num3 = this.GetCurrentSize().Height / 2.0;
		if (rotateTransform.CenterY != num3)
		{
			rotateTransform.CenterY = num3;
		}
		if (Xxm.RenderTransformOrigin != new Point(0.5, 0.0))
		{
			Xxm.RenderTransformOrigin = new Point(0.5, 0.0);
		}
		rotateTransform.Angle = ArrowAngle.GetNormalizedDegreeAngle();
	}

	private void zxJ(bool P_0)
	{
		if (!base.IsEnabled)
		{
			VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120170), P_0);
		}
		else if (IsDragging)
		{
			VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120190), P_0);
		}
		else if (xx4)
		{
			VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120208), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120234), P_0);
		}
		if (Wxw)
		{
			if (!base.IsKeyboardFocused)
			{
				VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120250), P_0);
			}
			else
			{
				VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120282), P_0);
			}
		}
		else
		{
			VisualStateManager.GoToState(this, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120300), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		Xxm = GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120322)) as UIElement;
		Fxt();
		zxJ(_0020: false);
	}

	protected override void OnGotFocus(RoutedEventArgs e)
	{
		base.OnGotFocus(e);
		Wxw = true;
		zxJ(_0020: true);
	}

	protected override void OnLostFocus(RoutedEventArgs e)
	{
		base.OnLostFocus(e);
		Wxw = false;
		zxJ(_0020: true);
	}

	[SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
	public void StartDrag(InputPointerButtonEventArgs sourceEventArgs)
	{
		if (sourceEventArgs != null)
		{
			sourceEventArgs.Handled = true;
			kxh.CapturePointer(sourceEventArgs, this);
			Focus();
			IsDragging = true;
			zxJ(_0020: true);
		}
	}

	static CircularThumb()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ArrowAngleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120346), typeof(double), typeof(CircularThumb), new PropertyMetadata(180.0, RxB));
		IsDraggingProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120370), typeof(bool), typeof(CircularThumb), new PropertyMetadata(false));
		PressedBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120394), typeof(Brush), typeof(CircularThumb), new PropertyMetadata(null));
	}

	internal static bool AbY()
	{
		return KbM == null;
	}

	internal static CircularThumb xbt()
	{
		return KbM;
	}
}
