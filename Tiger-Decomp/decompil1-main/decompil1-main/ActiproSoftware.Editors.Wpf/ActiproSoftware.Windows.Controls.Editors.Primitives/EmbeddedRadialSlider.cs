using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors.Primitives;

[TemplateVisualState(Name = "TotalCollapsed", GroupName = "TotalStates")]
[TemplateVisualState(Name = "TotalVisible", GroupName = "TotalStates")]
[ToolboxItem(false)]
[TemplatePart(Name = "PART_IncrementButton", Type = typeof(Button))]
[TemplatePart(Name = "PART_DecrementButton", Type = typeof(Button))]
[TemplateVisualState(Name = "Negative", GroupName = "ValueStates")]
[TemplateVisualState(Name = "Positive", GroupName = "ValueStates")]
public class EmbeddedRadialSlider : RadialSlider
{
	private ButtonBase SOc;

	private ButtonBase COH;

	private bool vOL;

	public static readonly DependencyProperty DecrementValueCommandProperty;

	public static readonly DependencyProperty IncrementValueCommandProperty;

	public static readonly DependencyProperty TotalEndAngleProperty;

	public static readonly DependencyProperty TotalStartAngleProperty;

	private static EmbeddedRadialSlider Dje;

	public ICommand DecrementValueCommand
	{
		get
		{
			return (ICommand)GetValue(DecrementValueCommandProperty);
		}
		set
		{
			SetValue(DecrementValueCommandProperty, value);
		}
	}

	public ICommand IncrementValueCommand
	{
		get
		{
			return (ICommand)GetValue(IncrementValueCommandProperty);
		}
		set
		{
			SetValue(IncrementValueCommandProperty, value);
		}
	}

	public double TotalEndAngle
	{
		get
		{
			return (double)GetValue(TotalEndAngleProperty);
		}
		set
		{
			SetValue(TotalEndAngleProperty, value);
		}
	}

	public double TotalStartAngle
	{
		get
		{
			return (double)GetValue(TotalStartAngleProperty);
		}
		set
		{
			SetValue(TotalStartAngleProperty, value);
		}
	}

	public EmbeddedRadialSlider()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(EmbeddedRadialSlider);
	}

	[SpecialName]
	private ButtonBase nOG()
	{
		return SOc;
	}

	[SpecialName]
	private void uOq(ButtonBase value)
	{
		if (SOc != value)
		{
			if (SOc != null)
			{
				SOc.Click -= AOO;
			}
			SOc = value;
			if (SOc != null)
			{
				SOc.Focusable = sO9();
				SOc.Click += AOO;
			}
		}
	}

	[SpecialName]
	private ButtonBase NOK()
	{
		return COH;
	}

	[SpecialName]
	private void pOR(ButtonBase value)
	{
		if (COH == value)
		{
			return;
		}
		if (COH != null)
		{
			COH.Click -= WOT;
		}
		COH = value;
		int num = 0;
		if (!wjO())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (COH != null)
		{
			COH.Focusable = sO9();
			COH.Click += WOT;
		}
	}

	[SpecialName]
	private bool sO9()
	{
		if (!(FocusManager.GetFocusScope(this) is Visual reference))
		{
			return true;
		}
		return VisualTreeHelper.GetParent(reference) == null;
	}

	private void AOO(object P_0, RoutedEventArgs P_1)
	{
		if (DecrementValueCommand == null)
		{
			SetValueCore(base.Value - base.SmallChange);
		}
		else
		{
			DecrementValueCommand.Execute(null);
		}
		P_1.Handled = true;
	}

	private void WOT(object P_0, RoutedEventArgs P_1)
	{
		if (IncrementValueCommand == null)
		{
			SetValueCore(base.Value + base.SmallChange);
		}
		else
		{
			IncrementValueCommand.Execute(null);
		}
		P_1.Handled = true;
	}

	private void sOI()
	{
		bool flag = base.Minimum < -360.0 || base.Maximum > 360.0;
		if (vOL != flag)
		{
			vOL = flag;
			bOD(_0020: true);
		}
	}

	private void xOb()
	{
		if (base.Value >= 0.0)
		{
			TotalStartAngle = 0.0;
			double maximum = base.Maximum;
			double num3;
			if (!(maximum > 0.0))
			{
				int num = 0;
				if (!wjO())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				num3 = 0.0;
			}
			else
			{
				num3 = base.Value / maximum * 360.0;
			}
			double num4 = num3;
			TotalEndAngle = ((num4 > 1.0) ? num4 : 0.0);
		}
		else
		{
			double minimum = base.Minimum;
			double num5 = ((minimum < 0.0) ? (360.0 - base.Value / minimum * 360.0) : 0.0);
			TotalStartAngle = ((360.0 - num5 > 1.0) ? num5 : 0.0);
			TotalEndAngle = 0.0;
		}
	}

	private void bOD(bool P_0)
	{
		if (base.Value >= 0.0)
		{
			int num = 0;
			if (!wjO())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			VisualStateManager.GoToState(this, QdM.AR8(24092), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(24112), P_0);
		}
		if (vOL)
		{
			VisualStateManager.GoToState(this, QdM.AR8(24132), P_0);
		}
		else
		{
			VisualStateManager.GoToState(this, QdM.AR8(24160), P_0);
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		uOq(GetTemplateChild(QdM.AR8(24192)) as ButtonBase);
		pOR(GetTemplateChild(QdM.AR8(24236)) as ButtonBase);
		bOD(_0020: false);
	}

	protected override void OnMaximumChanged(double oldMaximum, double newMaximum)
	{
		base.OnMaximumChanged(oldMaximum, newMaximum);
		xOb();
		sOI();
	}

	protected override void OnMinimumChanged(double oldMinimum, double newMinimum)
	{
		base.OnMinimumChanged(oldMinimum, newMinimum);
		xOb();
		sOI();
	}

	protected override void OnValueChanged(double oldValue, double newValue)
	{
		base.OnValueChanged(oldValue, newValue);
		xOb();
		bOD(_0020: true);
	}

	static EmbeddedRadialSlider()
	{
		awj.QuEwGz();
		DecrementValueCommandProperty = DependencyProperty.Register(QdM.AR8(24280), typeof(ICommand), typeof(EmbeddedRadialSlider), new PropertyMetadata(null));
		IncrementValueCommandProperty = DependencyProperty.Register(QdM.AR8(24326), typeof(ICommand), typeof(EmbeddedRadialSlider), new PropertyMetadata(null));
		TotalEndAngleProperty = DependencyProperty.Register(QdM.AR8(24372), typeof(double), typeof(EmbeddedRadialSlider), new PropertyMetadata(0.0));
		TotalStartAngleProperty = DependencyProperty.Register(QdM.AR8(24402), typeof(double), typeof(EmbeddedRadialSlider), new PropertyMetadata(0.0));
	}

	internal static bool wjO()
	{
		return Dje == null;
	}

	internal static EmbeddedRadialSlider ajm()
	{
		return Dje;
	}
}
