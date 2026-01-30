using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Input;

namespace ActiproSoftware.Windows.Controls.Docking.Primitives;

[TemplateVisualState(Name = "Horizontal", GroupName = "OrientationStates")]
[TemplateVisualState(Name = "Vertical", GroupName = "OrientationStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Highlighted", GroupName = "CommonStates")]
public abstract class SplitterBase : Control
{
	private InputAdapter qrM;

	private N7 Grv;

	public static readonly DependencyProperty IsHighlightedProperty;

	public static readonly DependencyProperty OrientationProperty;

	[CompilerGenerated]
	private double Nr7;

	internal static SplitterBase MnD;

	public bool IsHighlighted
	{
		get
		{
			return (bool)GetValue(IsHighlightedProperty);
		}
		set
		{
			SetValue(IsHighlightedProperty, value);
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

	protected SplitterBase()
	{
		IVH.CecNqz();
		base._002Ector();
		ArO();
		RrQ();
	}

	private void RrQ()
	{
		qrM = new InputAdapter(this);
		qrM.PointerCaptureLost += brB;
		qrM.PointerMoved += DrK;
		qrM.PointerPressed += ArJ;
		qrM.PointerReleased += crn;
		qrM.AttachedEventKinds = InputAdapterEventKinds.PointerCaptureLost | InputAdapterEventKinds.PointerMoved | InputAdapterEventKinds.PointerPressed | InputAdapterEventKinds.PointerReleased;
	}

	internal abstract N7 CreateSplitDragProcessor();

	internal Rect Nrm()
	{
		if (Orientation == Orientation.Horizontal)
		{
			return new Rect(kr8(), 0.0, base.ActualWidth, base.ActualHeight);
		}
		return new Rect(0.0, kr8(), base.ActualWidth, base.ActualHeight);
	}

	[SpecialName]
	[CompilerGenerated]
	internal double kr8()
	{
		return Nr7;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void CrD(double value)
	{
		Nr7 = value;
	}

	private static void Jra(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		((SplitterBase)P_0).vrT(_0020: false);
	}

	private static void WrW(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		SplitterBase obj = (SplitterBase)P_0;
		obj.vrT(_0020: false);
		obj.ArO();
	}

	private void brB(object P_0, InputPointerEventArgs P_1)
	{
		if (Grv != null)
		{
			Grv.GoW(P_1.GetPosition(Grv.Jm0()));
			Grv = null;
		}
	}

	private void DrK(object P_0, InputPointerEventArgs P_1)
	{
		if (Grv != null)
		{
			Grv.MmH(P_1.GetPosition(Grv.Jm0()));
		}
	}

	private void ArJ(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (P_1 != null && !P_1.Handled && P_0 == this && Grv == null)
		{
			N7 n = CreateSplitDragProcessor();
			if (n != null && qrM.CapturePointer(P_1))
			{
				Grv = n;
				Grv.Dmz(P_1.GetPosition(Grv.Jm0()));
				P_1.Handled = true;
			}
		}
	}

	private void crn(object P_0, InputPointerButtonEventArgs P_1)
	{
		if (Grv != null)
		{
			Grv.GoW(P_1.GetPosition(Grv.Jm0()));
			Grv = null;
			P_1.Handled = true;
			qrM.ReleasePointerCaptures();
		}
	}

	[SpecialName]
	internal double Srr()
	{
		if (!(base.RenderTransform is TranslateTransform translateTransform))
		{
			return 0.0;
		}
		if (Orientation != Orientation.Horizontal)
		{
			return translateTransform.Y;
		}
		return translateTransform.X;
	}

	[SpecialName]
	internal void Urx(double value)
	{
		TranslateTransform translateTransform = base.RenderTransform as TranslateTransform;
		if (translateTransform == null)
		{
			translateTransform = (TranslateTransform)(base.RenderTransform = new TranslateTransform());
		}
		if (Orientation == Orientation.Horizontal)
		{
			translateTransform.X = value;
			translateTransform.Y = 0.0;
		}
		else
		{
			translateTransform.X = 0.0;
			translateTransform.Y = value;
		}
	}

	private void ArO()
	{
		if (Orientation != Orientation.Horizontal)
		{
			Yp.ARc(this, Cursors.SizeNS);
		}
		else
		{
			Yp.ARc(this, Cursors.SizeWE);
		}
	}

	private void vrT(bool P_0)
	{
		if (!IsHighlighted)
		{
			VisualStateManager.GoToState(this, vVK.ssH(20450), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, vVK.ssH(21560), P_0);
		}
		if (Orientation == Orientation.Horizontal)
		{
			VisualStateManager.GoToState(this, vVK.ssH(21586), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, vVK.ssH(21610), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		vrT(_0020: false);
	}

	static SplitterBase()
	{
		IVH.CecNqz();
		IsHighlightedProperty = DependencyProperty.Register(vVK.ssH(21630), typeof(bool), typeof(SplitterBase), new PropertyMetadata(false, Jra));
		OrientationProperty = DependencyProperty.Register(vVK.ssH(15456), typeof(Orientation), typeof(SplitterBase), new PropertyMetadata(Orientation.Horizontal, WrW));
	}

	internal static bool WnE()
	{
		return MnD == null;
	}

	internal static SplitterBase bnk()
	{
		return MnD;
	}
}
