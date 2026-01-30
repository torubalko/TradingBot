using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ECOEgqlSad8NUJZ2Dr9n;
using TuAMtrl1Nd3XoZQQUXf0;
using xfdMo0lS4TP9pN36Goka;

namespace vJABeM28jRE76a9iLula;

[TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
[Description("A control which when clicked or dragged toggles between on and off states.")]
[TemplatePart(Name = "SwitchChecked", Type = typeof(Control))]
[TemplatePart(Name = "SwitchUnchecked", Type = typeof(Control))]
[TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "DraggingUnchecked", GroupName = "CheckStates")]
[TemplatePart(Name = "SwitchTrack", Type = typeof(FrameworkElement))]
[TemplatePart(Name = "SwitchThumb", Type = typeof(Thumb))]
[TemplateVisualState(Name = "Unchecked", GroupName = "CheckStates")]
[TemplateVisualState(Name = "Checked", GroupName = "CheckStates")]
[TemplateVisualState(Name = "DraggingChecked", GroupName = "CheckStates")]
[TemplatePart(Name = "SwitchRoot", Type = typeof(FrameworkElement))]
[TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
internal abstract class rgMHiS28c6PxPCkpgqUg : Control
{
	private bool CO92Ahb6PfJ;

	private bool d0S2AwAf823;

	private bool ktX2A7Yw73w;

	private Point sNq2A8D4Usx;

	private bool rgt2AAoNvEV;

	[CompilerGenerated]
	private Thumb zQN2APtBB1i;

	[CompilerGenerated]
	private Control fH82AJjeyBW;

	[CompilerGenerated]
	private Control OjR2AFQ8CWx;

	[CompilerGenerated]
	private FrameworkElement mt72A3TXvh0;

	[CompilerGenerated]
	private FrameworkElement SOi2ApUhdCQ;

	[CompilerGenerated]
	private double g3e2AuLh0Ae;

	[CompilerGenerated]
	private double iJp2AzKN80o;

	[CompilerGenerated]
	private double vGs2P01n3U2;

	[CompilerGenerated]
	private bool faI2P2oirMK;

	[CompilerGenerated]
	private bool G8N2PHNQHiC;

	public static readonly DependencyProperty ech2PfESY82;

	public static readonly DependencyProperty MRR2P9iNCXR;

	public static readonly DependencyProperty YYc2PnVv4nj;

	public static readonly DependencyProperty QtB2PGOBxqM;

	public static readonly DependencyProperty ddG2PYJwytt;

	public static readonly DependencyProperty Yna2Po9QacE;

	public static readonly DependencyProperty s3o2Pv5lkhx;

	public static readonly DependencyProperty y6q2PB9a5sj;

	public static readonly DependencyProperty P1E2Pay2HE4;

	public static readonly DependencyProperty Myb2Pi5q2eR;

	public static readonly DependencyProperty id62PlieX0q;

	public static readonly DependencyProperty LCE2P4dPwLQ;

	[CompilerGenerated]
	private RoutedEventHandler m_Unchecked;

	[CompilerGenerated]
	private RoutedEventHandler m_Checked;

	internal static rgMHiS28c6PxPCkpgqUg tUSCmhDnCJJAOYYrSECS;

	protected Thumb SwitchThumb
	{
		[CompilerGenerated]
		get
		{
			return zQN2APtBB1i;
		}
		[CompilerGenerated]
		set
		{
			zQN2APtBB1i = thumb;
		}
	}

	protected Control SwitchChecked
	{
		[CompilerGenerated]
		get
		{
			return fH82AJjeyBW;
		}
		[CompilerGenerated]
		set
		{
			fH82AJjeyBW = control;
		}
	}

	protected Control SwitchUnchecked
	{
		[CompilerGenerated]
		get
		{
			return OjR2AFQ8CWx;
		}
		[CompilerGenerated]
		set
		{
			OjR2AFQ8CWx = ojR2AFQ8CWx;
		}
	}

	protected FrameworkElement SwitchRoot
	{
		[CompilerGenerated]
		get
		{
			return mt72A3TXvh0;
		}
		[CompilerGenerated]
		set
		{
			mt72A3TXvh0 = frameworkElement;
		}
	}

	protected FrameworkElement SwitchTrack
	{
		[CompilerGenerated]
		get
		{
			return SOi2ApUhdCQ;
		}
		[CompilerGenerated]
		set
		{
			SOi2ApUhdCQ = sOi2ApUhdCQ;
		}
	}

	protected abstract double Offset { get; set; }

	public bool IsPressed
	{
		[CompilerGenerated]
		get
		{
			return G8N2PHNQHiC;
		}
		[CompilerGenerated]
		protected set
		{
			G8N2PHNQHiC = g8N2PHNQHiC;
		}
	}

	protected abstract PropertyPath SlidePropertyPath { get; }

	[Description("The template applied to the Checked and Unchecked content properties.")]
	public ControlTemplate ContentTemplate
	{
		get
		{
			return (ControlTemplate)fE0MMwDnmoRYUwsswhnH(this, ech2PfESY82);
		}
		set
		{
			SetValue(ech2PfESY82, value2);
		}
	}

	[Category("Common Properties")]
	[Description("The content shown on the checked side of the toggle switch")]
	public object CheckedContent
	{
		get
		{
			return GetValue(MRR2P9iNCXR);
		}
		set
		{
			SetValue(MRR2P9iNCXR, value2);
		}
	}

	[Description("The brush used for the foreground of the checked side of the toggle switch.")]
	public Brush CheckedForeground
	{
		get
		{
			return (Brush)fE0MMwDnmoRYUwsswhnH(this, YYc2PnVv4nj);
		}
		set
		{
			SetValue(YYc2PnVv4nj, value2);
		}
	}

	[Description("The brush used for the background of the checked side of the toggle switch.")]
	public Brush CheckedBackground
	{
		get
		{
			return (Brush)GetValue(QtB2PGOBxqM);
		}
		set
		{
			ooNT98DnhGZ70Hj2bC9G(this, QtB2PGOBxqM, brush);
		}
	}

	[Description("The content shown on the unchecked side of the toggle switch.")]
	[Category("Common Properties")]
	public object UncheckedContent
	{
		get
		{
			return GetValue(ddG2PYJwytt);
		}
		set
		{
			SetValue(ddG2PYJwytt, value2);
		}
	}

	[Description("The brush used for the foreground of the Unchecked side of the toggle switch.")]
	public Brush UncheckedForeground
	{
		get
		{
			return (Brush)fE0MMwDnmoRYUwsswhnH(this, Yna2Po9QacE);
		}
		set
		{
			SetValue(Yna2Po9QacE, value2);
		}
	}

	[Description("The brush used for the background of the Unchecked side of the toggle switch.")]
	public Brush UncheckedBackground
	{
		get
		{
			return (Brush)GetValue(s3o2Pv5lkhx);
		}
		set
		{
			SetValue(s3o2Pv5lkhx, value2);
		}
	}

	[Category("Common Properties")]
	[Description("Determines the percentage of the way the thumb must be dragged before the switch changes it's IsChecked state.")]
	public double Elasticity
	{
		get
		{
			return (double)GetValue(y6q2PB9a5sj);
		}
		set
		{
			SetValue(y6q2PB9a5sj, num);
		}
	}

	[Description("The thumb's control template.")]
	public ControlTemplate ThumbTemplate
	{
		get
		{
			return (ControlTemplate)GetValue(P1E2Pay2HE4);
		}
		set
		{
			ooNT98DnhGZ70Hj2bC9G(this, P1E2Pay2HE4, controlTemplate);
		}
	}

	[Description("The brush used to fill the thumb.")]
	public Brush ThumbBrush
	{
		get
		{
			return (Brush)GetValue(Myb2Pi5q2eR);
		}
		set
		{
			SetValue(Myb2Pi5q2eR, value2);
		}
	}

	[Description("The size of the toggle switch's thumb.")]
	[Category("Appearance")]
	public double ThumbSize
	{
		get
		{
			return (double)fE0MMwDnmoRYUwsswhnH(this, id62PlieX0q);
		}
		set
		{
			SetValue(id62PlieX0q, num);
		}
	}

	[Category("Common Properties")]
	[Description("Gets or sets whether the control is in the checked state.")]
	public bool IsChecked
	{
		get
		{
			return (bool)fE0MMwDnmoRYUwsswhnH(this, LCE2P4dPwLQ);
		}
		set
		{
			SetValue(LCE2P4dPwLQ, flag);
		}
	}

	public event RoutedEventHandler Unchecked
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_Unchecked;
			RoutedEventHandler routedEventHandler2;
			RoutedEventHandler value2 = default(RoutedEventHandler);
			do
			{
				routedEventHandler2 = routedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_409738fae61f4f058345c98b7cfbcbac == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					default:
						value2 = (RoutedEventHandler)Delegate.Combine(routedEventHandler2, b);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 == 0)
						{
							num = 1;
						}
						continue;
					}
					break;
				}
				routedEventHandler = Interlocked.CompareExchange(ref this.m_Unchecked, value2, routedEventHandler2);
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			int num = 1;
			int num2 = num;
			RoutedEventHandler routedEventHandler = default(RoutedEventHandler);
			RoutedEventHandler value2 = default(RoutedEventHandler);
			RoutedEventHandler routedEventHandler2 = default(RoutedEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					routedEventHandler = this.m_Unchecked;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					routedEventHandler = Interlocked.CompareExchange(ref this.m_Unchecked, value2, routedEventHandler2);
					if ((object)routedEventHandler == routedEventHandler2)
					{
						return;
					}
					break;
				}
				routedEventHandler2 = routedEventHandler;
				value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value3);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d49d1aa54d194934871b103e21669e22 == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public event RoutedEventHandler Checked
	{
		[CompilerGenerated]
		add
		{
			RoutedEventHandler routedEventHandler = this.m_Checked;
			RoutedEventHandler routedEventHandler2;
			do
			{
				routedEventHandler2 = routedEventHandler;
				int num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_43d123ebfe574af38268397bb0ae2d1a == 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
					{
						RoutedEventHandler value2 = (RoutedEventHandler)EfJdXaDnwgfaqg7QvOvC(routedEventHandler2, routedEventHandler3);
						routedEventHandler = Interlocked.CompareExchange(ref this.m_Checked, value2, routedEventHandler2);
						num = 1;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_51aff79eb7764aeaade80ae2d6638ab5 == 0)
						{
							num = 1;
						}
						continue;
					}
					case 1:
						break;
					}
					break;
				}
			}
			while ((object)routedEventHandler != routedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			RoutedEventHandler routedEventHandler = this.m_Checked;
			while (true)
			{
				RoutedEventHandler routedEventHandler2 = routedEventHandler;
				RoutedEventHandler value2 = (RoutedEventHandler)Delegate.Remove(routedEventHandler2, value3);
				routedEventHandler = Interlocked.CompareExchange(ref this.m_Checked, value2, routedEventHandler2);
				int num = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fa74d46e0c824e0b89c71deca0488611 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						break;
					case 0:
						return;
					}
					if ((object)routedEventHandler != routedEventHandler2)
					{
						break;
					}
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_152544ed8bd2470d8638a522e4a24d02 != 0)
					{
						num = 0;
					}
				}
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	protected double eJa288LUcCy()
	{
		return g3e2AuLh0Ae;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void MJA28A1Vqey(double P_0)
	{
		g3e2AuLh0Ae = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected double R2e28JdLXSy()
	{
		return iJp2AzKN80o;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void xo328FLJG4y(double P_0)
	{
		iJp2AzKN80o = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected double VGd28pey9DJ()
	{
		return vGs2P01n3U2;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void yoe28ux6mVq(double P_0)
	{
		vGs2P01n3U2 = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	protected bool Gv82A0JPZe2()
	{
		return faI2P2oirMK;
	}

	[SpecialName]
	[CompilerGenerated]
	protected void kSg2A2Q6NXI(bool P_0)
	{
		faI2P2oirMK = P_0;
	}

	private static void La028ERWvs3(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		int num = 3;
		int num2 = num;
		rgMHiS28c6PxPCkpgqUg rgMHiS28c6PxPCkpgqUg2 = default(rgMHiS28c6PxPCkpgqUg);
		while (true)
		{
			switch (num2)
			{
			default:
				rgMHiS28c6PxPCkpgqUg2.Ny628Qp0RVR(new RoutedEventArgs());
				goto IL_002c;
			case 3:
				rgMHiS28c6PxPCkpgqUg2 = (rgMHiS28c6PxPCkpgqUg)P_0;
				num2 = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dfd8fb340d494755970617a38d3a8729 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 2:
				{
					if (P_1.NewValue != P_1.OldValue)
					{
						if (!(bool)P_1.NewValue)
						{
							goto default;
						}
						rgMHiS28c6PxPCkpgqUg2.t0f28dGfrOd(new RoutedEventArgs());
					}
					goto IL_002c;
				}
				IL_002c:
				rgMHiS28c6PxPCkpgqUg2.QaVlfFhUw1L(_0020: true);
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ad0a44f3eae14332b41c0c5ef48d2cbb != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected void Ny628Qp0RVR(RoutedEventArgs P_0)
	{
		this.Unchecked?.Invoke(this, P_0);
	}

	protected void t0f28dGfrOd(RoutedEventArgs P_0)
	{
		this.Checked?.Invoke(this, P_0);
	}

	protected rgMHiS28c6PxPCkpgqUg()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		base.Loaded += delegate
		{
			S2X28UT4h6n(_0020: false);
		};
		base.IsEnabledChanged += va428Obj8Ft;
	}

	protected abstract void OnDragDelta(object P_0, DragDeltaEventArgs P_1);

	protected abstract void OnDragCompleted(object P_0, DragCompletedEventArgs P_1);

	protected abstract void LayoutControls();

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		IcXlf8ptvO3();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				A5TlfwbFOf4();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6d472511f0d246a693dc7622dda5f390 == 0)
				{
					num = 0;
				}
				continue;
			case 1:
				Ehev2DDn7Xu8iRYhXQ5X(this, false);
				return;
			}
			GpGlf76fpaD();
			LayoutControls();
			VisualStateManager.GoToState(this, base.IsEnabled ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1325234765 ^ -1325222133) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0xECA3F28 ^ 0xECAD910), useTransitions: false);
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 1;
			}
		}
	}

	protected virtual void A5TlfwbFOf4()
	{
		SwitchRoot = GetTemplateChild((string)M2GlEaDn8BonkRGNVl0v(0x7394D272 ^ 0x7394343E)) as FrameworkElement;
		SwitchThumb = GetTemplateChild((string)M2GlEaDn8BonkRGNVl0v(-527080372 ^ -527072728)) as Thumb;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_b3744d11c0b24c8d993b100cbb22f9e7 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				SwitchUnchecked = GetTemplateChild(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x4297C3EB ^ 0x42972577)) as Control;
				SwitchTrack = X2NrGqDnAYRmOD7FDgcP(this, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x24085900 ^ 0x2408BFBE)) as FrameworkElement;
				return;
			}
			SwitchChecked = GetTemplateChild((string)M2GlEaDn8BonkRGNVl0v(-617064403 ^ -617038253)) as Control;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
			{
				num = 1;
			}
		}
	}

	protected virtual void GpGlf76fpaD()
	{
		if (SwitchThumb != null)
		{
			FAB8PdDnPCeKIP0mfGqf(SwitchThumb, new DragStartedEventHandler(qKAlfAgtfJj));
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					SwitchThumb.DragDelta += OnDragDelta;
					SwitchThumb.DragCompleted += OnDragCompleted;
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_267ca8254fa648cbaa1ba685784f79c7 == 0)
					{
						num = 0;
					}
					continue;
				}
				break;
			}
		}
		base.SizeChanged += i30lfPUWg9q;
	}

	protected virtual void IcXlf8ptvO3()
	{
		int num;
		if (SwitchThumb != null)
		{
			SwitchThumb.DragStarted -= qKAlfAgtfJj;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f63752baa0064bcb85a726ea90a210dc == 0)
			{
				num = 1;
			}
			goto IL_0009;
		}
		goto IL_007b;
		IL_0009:
		switch (num)
		{
		default:
			return;
		case 0:
			return;
		case 1:
			break;
		}
		SwitchThumb.DragDelta -= OnDragDelta;
		SwitchThumb.DragCompleted -= OnDragCompleted;
		goto IL_007b;
		IL_007b:
		s2dhFcDnJCAtcw30fMHM(this, new SizeChangedEventHandler(i30lfPUWg9q));
		num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_4aa3a79213674c27a6bc763076b8caed != 0)
		{
			num = 0;
		}
		goto IL_0009;
	}

	protected virtual void qKAlfAgtfJj(object P_0, DragStartedEventArgs P_1)
	{
		kSg2A2Q6NXI(_0020: true);
		yoe28ux6mVq(Offset);
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0b22b597497745f5ab911eaabff065eb != 0)
		{
			num = 0;
		}
		switch (num)
		{
		}
		QaVlfFhUw1L(_0020: false);
	}

	protected void X7Z28gKxVjN()
	{
		SetCurrentValue(LCE2P4dPwLQ, !IsChecked);
	}

	protected virtual void i30lfPUWg9q(object P_0, SizeChangedEventArgs P_1)
	{
		RjBU7GDnFj09mP2xeflS(this);
	}

	internal void qbs28RV753T()
	{
		if (!CO92Ahb6PfJ)
		{
			CO92Ahb6PfJ = CaptureMouse();
		}
	}

	protected internal void fIb2868rA5c()
	{
		ReleaseMouseCapture();
		CO92Ahb6PfJ = false;
	}

	private static void JiC28MfdPI1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (P_1.NewValue != P_1.OldValue)
		{
			RjBU7GDnFj09mP2xeflS((rgMHiS28c6PxPCkpgqUg)P_0);
		}
	}

	private void va428Obj8Ft(object P_0, DependencyPropertyChangedEventArgs P_1)
	{
		rgt2AAoNvEV = true;
		int num;
		if (!lrI2d0Dn3aZ4J0f8Fxwu(this))
		{
			IsPressed = false;
			CO92Ahb6PfJ = false;
			d0S2AwAf823 = false;
			num = 1;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f68538a410dc40459f303c1bac7938ac == 0)
			{
				num = 0;
			}
			goto IL_0009;
		}
		goto IL_0081;
		IL_0009:
		while (true)
		{
			switch (num)
			{
			case 2:
				S2X28UT4h6n();
				return;
			case 1:
				ktX2A7Yw73w = false;
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f2434d508b7b4b77853ea03e1bcda658 == 0)
				{
					num = 0;
				}
				continue;
			}
			break;
		}
		goto IL_0081;
		IL_0081:
		rgt2AAoNvEV = false;
		num = 2;
		goto IL_0009;
	}

	protected override void OnLostFocus(RoutedEventArgs P_0)
	{
		I4DcBgDnp3R6hei3mHQP(this, P_0);
		IsPressed = false;
		fIb2868rA5c();
		d0S2AwAf823 = false;
		int num = 0;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				rgt2AAoNvEV = false;
				S2X28UT4h6n();
				num = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_5350e02b39f542f78529ac5e3c3f8ec6 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void OnKeyDown(KeyEventArgs P_0)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				base.OnKeyDown(P_0);
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c == 0)
				{
					num2 = 1;
				}
				break;
			default:
				P_0.Handled = true;
				return;
			case 1:
				if (!P_0.Handled && NSg28q8UYD8(P_0.Key))
				{
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3023bd6c0f7846878513499bf5c36161 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			}
		}
	}

	private bool NSg28q8UYD8(Key P_0)
	{
		int num = 8;
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					qbs28RV753T();
					result = true;
					num2 = 9;
					continue;
				case 6:
				case 9:
					return result;
				case 1:
					IsPressed = true;
					num2 = 2;
					continue;
				case 5:
					if (P_0 != Key.Return)
					{
						if (d0S2AwAf823)
						{
							IsPressed = false;
							d0S2AwAf823 = false;
							fIb2868rA5c();
						}
						goto case 6;
					}
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					d0S2AwAf823 = false;
					IsPressed = false;
					num2 = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_3a7b10748dce4fec98054526a92d6ccf != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (base.IsEnabled)
					{
						if (P_0 != Key.Space)
						{
							goto case 5;
						}
						if (!CO92Ahb6PfJ && !d0S2AwAf823)
						{
							d0S2AwAf823 = true;
							num2 = 1;
							if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_7573e3aca29a46a9959af01ed2386da5 == 0)
							{
								num2 = 0;
							}
							continue;
						}
					}
					goto case 6;
				case 3:
					result = true;
					num2 = 6;
					continue;
				case 8:
					result = false;
					num2 = 7;
					continue;
				}
				break;
			}
			fIb2868rA5c();
			X7Z28gKxVjN();
			num = 3;
		}
	}

	protected override void OnKeyUp(KeyEventArgs P_0)
	{
		base.OnKeyUp(P_0);
		int num;
		if (P_0.Handled)
		{
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2088b9a28522490e83dc44062c40a7c0 == 0)
			{
				num = 0;
			}
		}
		else
		{
			if (krH28Ihq7JM(P_0.Key))
			{
				P_0.Handled = true;
				return;
			}
			num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 != 0)
			{
				num = 1;
			}
		}
		switch (num)
		{
		case 1:
			break;
		case 0:
			break;
		}
	}

	private bool krH28Ihq7JM(Key P_0)
	{
		bool result = false;
		if (lrI2d0Dn3aZ4J0f8Fxwu(this))
		{
			while (P_0 == Key.Space)
			{
				d0S2AwAf823 = false;
				int num;
				if (!ktX2A7Yw73w)
				{
					fIb2868rA5c();
					num = 6;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_f10da6c70e49485dae21f57ce3741184 != 0)
					{
						num = 3;
					}
				}
				else
				{
					if (!CO92Ahb6PfJ)
					{
						goto IL_0151;
					}
					num = 4;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						break;
					case 4:
						if (!(IsPressed = Lsy28Wj0HBc()))
						{
							fIb2868rA5c();
							num = 2;
							continue;
						}
						goto IL_0151;
					case 5:
						IsPressed = false;
						num = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_8bfdb836a7624a05a8616bddcf22e146 != 0)
						{
							num = 0;
						}
						continue;
					case 3:
					{
						X7Z28gKxVjN();
						int num2 = 5;
						num = num2;
						continue;
					}
					case 6:
						if (IsPressed)
						{
							num = 3;
							continue;
						}
						goto case 5;
					default:
						goto IL_0151;
					}
					break;
				}
				continue;
				IL_0151:
				result = true;
				break;
			}
		}
		return result;
	}

	protected override void OnMouseLeftButtonDown(MouseButtonEventArgs P_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				fmCgNuDnueomgvAKo3NC(this, P_0);
				num2 = 2;
				continue;
			case 5:
				rgt2AAoNvEV = false;
				S2X28UT4h6n();
				return;
			case 4:
				qbs28RV753T();
				if (CO92Ahb6PfJ)
				{
					break;
				}
				goto case 5;
			case 1:
				rgt2AAoNvEV = true;
				Focus();
				num2 = 4;
				continue;
			case 2:
				if (P_0.Handled)
				{
					return;
				}
				ktX2A7Yw73w = true;
				if (lrI2d0Dn3aZ4J0f8Fxwu(this))
				{
					q8e9TiDnzrOiZOMQo55H(P_0, true);
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2039997ab6194b398d07bcb5d664c971 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			}
			IsPressed = true;
			num2 = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_08ac0ac701064383a00c80bff8cd4e3f != 0)
			{
				num2 = 5;
			}
		}
	}

	protected override void OnMouseLeftButtonUp(MouseButtonEventArgs P_0)
	{
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				base.OnMouseLeftButtonUp(P_0);
				num2 = 4;
				break;
			case 3:
				IsPressed = false;
				return;
			case 1:
				if (d0S2AwAf823)
				{
					return;
				}
				fIb2868rA5c();
				num2 = 3;
				break;
			case 4:
				if (P_0.Handled)
				{
					return;
				}
				ktX2A7Yw73w = false;
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!base.IsEnabled)
				{
					return;
				}
				q8e9TiDnzrOiZOMQo55H(P_0, true);
				if (!d0S2AwAf823)
				{
					num2 = 2;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_ebf7ae5938c3406ea71c3b7147ea041c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 2:
				if (IsPressed)
				{
					X7Z28gKxVjN();
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fc665aa6b49746ab985cf6653d959552 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	protected override void OnMouseMove(MouseEventArgs P_0)
	{
		base.OnMouseMove(P_0);
		sNq2A8D4Usx = P_0.GetPosition(this);
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_fb3e1155cc384cc2a7c812423a76ea76 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				if (ktX2A7Yw73w)
				{
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_35216e71f4e34e739f4a05a1213f3579 != 0)
					{
						num = 0;
					}
					continue;
				}
				return;
			case 2:
				return;
			}
			if (lrI2d0Dn3aZ4J0f8Fxwu(this) && CO92Ahb6PfJ && !d0S2AwAf823)
			{
				IsPressed = Lsy28Wj0HBc();
				num = 2;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 != 0)
				{
					num = 2;
				}
				continue;
			}
			return;
		}
	}

	private bool Lsy28Wj0HBc()
	{
		if (sNq2A8D4Usx.X >= 0.0 && sNq2A8D4Usx.X <= base.ActualWidth)
		{
			int num = 0;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_d4c083a65c1546b8a09c928a8c95e140 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			}
			if (sNq2A8D4Usx.Y >= 0.0)
			{
				return sNq2A8D4Usx.Y <= JkDn3HDG0f5cUPu43eH3(this);
			}
		}
		return false;
	}

	protected bool QXn28twC6KF(bool P_0, string P_1)
	{
		return pyAKMDDG2HOhMfqUHeHb(this, P_1, P_0);
	}

	protected virtual void VQ9lfJBvEhK(bool P_0)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!base.IsEnabled)
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_dd6de048cd134da6b2674c002762ca45 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				QXn28twC6KF(P_0, (string)(base.IsMouseOver ? stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1161619942 ^ -1161563966) : M2GlEaDn8BonkRGNVl0v(0x2CBEEA31 ^ 0x2CBED889)));
				goto IL_002c;
			case 2:
				QXn28twC6KF(P_0, stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x7DB10E6E ^ 0x7DB1E856));
				goto IL_002c;
			case 0:
				return;
			case 1:
				{
					if (base.IsEnabled)
					{
						QXn28twC6KF(P_0, (string)M2GlEaDn8BonkRGNVl0v(0x28C965BE ^ 0x28C98350));
						num2 = 0;
						if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_e5dcb5c2a8274adf87bda91d76616538 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				IL_002c:
				if (P2ouHPDGHxASV1uODaAk(this))
				{
					num2 = 1;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_0a80f370f27d471fab60f042c9fa7b49 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			break;
		}
		QXn28twC6KF(P_0, (string)M2GlEaDn8BonkRGNVl0v(-894902996 ^ -894944724));
	}

	protected void S2X28UT4h6n(bool P_0 = true)
	{
		if (!rgt2AAoNvEV)
		{
			VQ9lfJBvEhK(P_0);
		}
	}

	protected virtual void QaVlfFhUw1L(bool P_0)
	{
		string text = (string)(IsChecked ? M2GlEaDn8BonkRGNVl0v(-123775059 ^ -123752319) : stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28B5ADC));
		int num = 1;
		if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_9aa9dbd12b8a4a4ea59acea051cdddbf == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 4:
				VisualStateManager.GoToState(this, text, P_0);
				if (SwitchThumb != null)
				{
					pyAKMDDG2HOhMfqUHeHb(SwitchThumb, text, P_0);
					num = 0;
					if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_6b9913e777f24c1abc91fbc34d2bcc9c != 0)
					{
						num = 0;
					}
					break;
				}
				goto default;
			default:
				if (SwitchThumb == null)
				{
					num = 3;
					break;
				}
				if (SwitchTrack != null)
				{
					Storyboard storyboard = new Storyboard();
					Duration duration = new Duration(P_0 ? TimeSpan.FromMilliseconds(100.0) : TimeSpan.Zero);
					DoubleAnimation doubleAnimation = new DoubleAnimation();
					DoubleAnimation doubleAnimation2 = new DoubleAnimation();
					N4RYsXDGfLqC1cTdXMZZ(doubleAnimation, duration);
					N4RYsXDGfLqC1cTdXMZZ(doubleAnimation2, duration);
					double value = (IsChecked ? eJa288LUcCy() : R2e28JdLXSy());
					doubleAnimation.To = value;
					doubleAnimation2.To = value;
					storyboard.Children.Add(doubleAnimation);
					L34MJYDGnNByrkpxsHZT(TUXxiYDG99JH5Uq2jNty(storyboard), doubleAnimation2);
					fewuVXDGGJeNufkDtBoT(doubleAnimation, SwitchTrack);
					Storyboard.SetTarget(doubleAnimation2, SwitchThumb);
					Storyboard.SetTargetProperty(doubleAnimation, SlidePropertyPath);
					Storyboard.SetTargetProperty(doubleAnimation2, SlidePropertyPath);
					storyboard.Begin();
				}
				return;
			case 1:
				if (Gv82A0JPZe2())
				{
					VisualStateManager.GoToState(this, (string)M2GlEaDn8BonkRGNVl0v(0xB15786A ^ 0xB159F54) + text, P_0);
					num = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	static rgMHiS28c6PxPCkpgqUg()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				Myb2Pi5q2eR = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB4E1D3), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), o2AiJ6DGo3lQDQs2wwVF(jqGIG6DGBJVdlbCLtjeL(33555147)), null);
				num2 = 6;
				continue;
			case 6:
				id62PlieX0q = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-5977659 ^ -6020739), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), new FrameworkPropertyMetadata(40.0, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, JiC28MfdPI1));
				LCE2P4dPwLQ = (DependencyProperty)iHXrORDGvtHaYYgvuf9r(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-1763895751 ^ -1763869287), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777221)), Type.GetTypeFromHandle(jqGIG6DGBJVdlbCLtjeL(33555147)), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsArrange, La028ERWvs3));
				return;
			case 3:
				P1E2Pay2HE4 = DependencyProperty.Register((string)M2GlEaDn8BonkRGNVl0v(0x706541F3 ^ 0x7065A971), Type.GetTypeFromHandle(jqGIG6DGBJVdlbCLtjeL(16777453)), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, JiC28MfdPI1));
				num2 = 4;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_2aa1113717a74eb69caa8952fdc78508 != 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
				y6q2PB9a5sj = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-490987856 ^ -490932518), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777262)), Type.GetTypeFromHandle(jqGIG6DGBJVdlbCLtjeL(33555147)), new PropertyMetadata(0.5));
				num2 = 3;
				continue;
			case 2:
				stmj4Ul1bF7178khnjLy.nWrl1glAtDi();
				num2 = 1;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_84569ba2345a4be7ac2af6ab5d67eaf9 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				ubruGuDGYEx6yy5pbTA2();
				num2 = 0;
				if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_1bb232d361564d93b9a5d5e53983bdb3 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			ech2PfESY82 = (DependencyProperty)iHXrORDGvtHaYYgvuf9r(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2017337494 ^ -2017380296), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777453)), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsArrange, JiC28MfdPI1));
			MRR2P9iNCXR = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x28BBDCA ^ 0x28B5ABE), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), new FrameworkPropertyMetadata(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(0x6AB40973 ^ 0x6AB4EEE7), FrameworkPropertyMetadataOptions.AffectsArrange, JiC28MfdPI1));
			YYc2PnVv4nj = DependencyProperty.Register((string)M2GlEaDn8BonkRGNVl0v(-1251569705 ^ -1251579829), o2AiJ6DGo3lQDQs2wwVF(jqGIG6DGBJVdlbCLtjeL(16777400)), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), null);
			QtB2PGOBxqM = DependencyProperty.Register((string)M2GlEaDn8BonkRGNVl0v(-2002318893 ^ -2002260463), o2AiJ6DGo3lQDQs2wwVF(jqGIG6DGBJVdlbCLtjeL(16777400)), Type.GetTypeFromHandle(jqGIG6DGBJVdlbCLtjeL(33555147)), null);
			ddG2PYJwytt = DependencyProperty.Register(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-2056710528 ^ -2056654488), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777240)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), new FrameworkPropertyMetadata(stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(-520155535 ^ -520100227), FrameworkPropertyMetadataOptions.AffectsArrange, JiC28MfdPI1));
			Yna2Po9QacE = DependencyProperty.Register((string)M2GlEaDn8BonkRGNVl0v(0x385FFAB ^ 0x38517BD), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), Type.GetTypeFromHandle(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(33555147)), null);
			s3o2Pv5lkhx = DependencyProperty.Register((string)M2GlEaDn8BonkRGNVl0v(-2123795572 ^ -2123785268), o2AiJ6DGo3lQDQs2wwVF(zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(16777400)), o2AiJ6DGo3lQDQs2wwVF(jqGIG6DGBJVdlbCLtjeL(33555147)), null);
			num2 = 5;
			if (_003CModule_003E_007Bce1afb0d_002D8724_002D4a3c_002D8977_002Dc81e93990fb1_007D.m_94f896a1c68c4274bf6a8960d175b5c2 == 0)
			{
				num2 = 3;
			}
		}
	}

	[CompilerGenerated]
	private void tvy28Tyfe3s(object P_0, RoutedEventArgs P_1)
	{
		S2X28UT4h6n(_0020: false);
	}

	internal static bool PUM6CcDnryTArpYr99fE()
	{
		return tUSCmhDnCJJAOYYrSECS == null;
	}

	internal static rgMHiS28c6PxPCkpgqUg ohawVIDnKp0qc6hvt37X()
	{
		return tUSCmhDnCJJAOYYrSECS;
	}

	internal static object fE0MMwDnmoRYUwsswhnH(object P_0, object P_1)
	{
		return ((DependencyObject)P_0).GetValue((DependencyProperty)P_1);
	}

	internal static void ooNT98DnhGZ70Hj2bC9G(object P_0, object P_1, object P_2)
	{
		((DependencyObject)P_0).SetValue((DependencyProperty)P_1, P_2);
	}

	internal static object EfJdXaDnwgfaqg7QvOvC(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static void Ehev2DDn7Xu8iRYhXQ5X(object P_0, bool P_1)
	{
		((rgMHiS28c6PxPCkpgqUg)P_0).QaVlfFhUw1L(P_1);
	}

	internal static object M2GlEaDn8BonkRGNVl0v(int P_0)
	{
		return stmj4Ul1bF7178khnjLy.BC1l1WXFcAt(P_0);
	}

	internal static object X2NrGqDnAYRmOD7FDgcP(object P_0, object P_1)
	{
		return ((FrameworkElement)P_0).GetTemplateChild((string)P_1);
	}

	internal static void FAB8PdDnPCeKIP0mfGqf(object P_0, object P_1)
	{
		((Thumb)P_0).DragStarted += (DragStartedEventHandler)P_1;
	}

	internal static void s2dhFcDnJCAtcw30fMHM(object P_0, object P_1)
	{
		((FrameworkElement)P_0).SizeChanged -= (SizeChangedEventHandler)P_1;
	}

	internal static void RjBU7GDnFj09mP2xeflS(object P_0)
	{
		((rgMHiS28c6PxPCkpgqUg)P_0).LayoutControls();
	}

	internal static bool lrI2d0Dn3aZ4J0f8Fxwu(object P_0)
	{
		return ((UIElement)P_0).IsEnabled;
	}

	internal static void I4DcBgDnp3R6hei3mHQP(object P_0, object P_1)
	{
		((UIElement)P_0).OnLostFocus((RoutedEventArgs)P_1);
	}

	internal static void fmCgNuDnueomgvAKo3NC(object P_0, object P_1)
	{
		((UIElement)P_0).OnMouseLeftButtonDown((MouseButtonEventArgs)P_1);
	}

	internal static void q8e9TiDnzrOiZOMQo55H(object P_0, bool P_1)
	{
		((RoutedEventArgs)P_0).Handled = P_1;
	}

	internal static double JkDn3HDG0f5cUPu43eH3(object P_0)
	{
		return ((FrameworkElement)P_0).ActualHeight;
	}

	internal static bool pyAKMDDG2HOhMfqUHeHb(object P_0, object P_1, bool P_2)
	{
		return VisualStateManager.GoToState((FrameworkElement)P_0, (string)P_1, P_2);
	}

	internal static bool P2ouHPDGHxASV1uODaAk(object P_0)
	{
		return ((UIElement)P_0).IsFocused;
	}

	internal static void N4RYsXDGfLqC1cTdXMZZ(object P_0, Duration P_1)
	{
		((Timeline)P_0).Duration = P_1;
	}

	internal static object TUXxiYDG99JH5Uq2jNty(object P_0)
	{
		return ((TimelineGroup)P_0).Children;
	}

	internal static void L34MJYDGnNByrkpxsHZT(object P_0, object P_1)
	{
		((TimelineCollection)P_0).Add((Timeline)P_1);
	}

	internal static void fewuVXDGGJeNufkDtBoT(object P_0, object P_1)
	{
		Storyboard.SetTarget((DependencyObject)P_0, (DependencyObject)P_1);
	}

	internal static void ubruGuDGYEx6yy5pbTA2()
	{
		bjBp4DlSBZNrmYFiJ2P5.uAtNhrIAcgj();
	}

	internal static Type o2AiJ6DGo3lQDQs2wwVF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object iHXrORDGvtHaYYgvuf9r(object P_0, Type P_1, Type P_2, object P_3)
	{
		return DependencyProperty.Register((string)P_0, P_1, P_2, (PropertyMetadata)P_3);
	}

	internal static RuntimeTypeHandle jqGIG6DGBJVdlbCLtjeL(int token)
	{
		return zmbXKdlSl1GXTTR8sFYK.OQfNhKXFGPG(token);
	}
}
