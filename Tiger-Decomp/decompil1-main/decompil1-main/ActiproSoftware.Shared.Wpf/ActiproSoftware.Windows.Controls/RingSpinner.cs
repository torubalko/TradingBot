using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplateVisualState(Name = "Stopped", GroupName = "SpinStates")]
[TemplateVisualState(Name = "Clockwise", GroupName = "SpinStates")]
[TemplatePart(Name = "PART_RingSlice", Type = typeof(RingSlice))]
public class RingSpinner : Control
{
	private RingSlice eCE;

	public static readonly DependencyProperty IsSpinningProperty;

	public static readonly DependencyProperty LineCapProperty;

	public static readonly DependencyProperty RadiusProperty;

	internal static RingSpinner OGh;

	public bool IsSpinning
	{
		get
		{
			return (bool)GetValue(IsSpinningProperty);
		}
		set
		{
			SetValue(IsSpinningProperty, value);
		}
	}

	public PenLineCap LineCap
	{
		get
		{
			return (PenLineCap)GetValue(LineCapProperty);
		}
		set
		{
			SetValue(LineCapProperty, value);
		}
	}

	public double Radius
	{
		get
		{
			return (double)GetValue(RadiusProperty);
		}
		private set
		{
			SetValue(RadiusProperty, value);
		}
	}

	public RingSpinner()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		base.DefaultStyleKey = typeof(RingSpinner);
	}

	private static void oCU(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RingSpinner ringSpinner = (RingSpinner)P_0;
		ringSpinner.iCH(_0020: true);
	}

	[SpecialName]
	private RingSlice oC6()
	{
		return eCE;
	}

	[SpecialName]
	private void MCV(RingSlice value)
	{
		eCE = value;
		if (eCE != null)
		{
			RotateTransform rotateTransform = eCE.RenderTransform as RotateTransform;
			if (rotateTransform == null)
			{
				eCE.RenderTransform = new RotateTransform();
			}
		}
	}

	private void iCH(bool P_0)
	{
		VisualStateManager.GoToState(this, IsSpinning ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116692) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116674), P_0);
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		base.ArrangeOverride(finalSize);
		if (eCE != null)
		{
			Thickness padding = base.Padding;
			double radius = Math.Min(Math.Max(0.0, finalSize.Width - padding.Left - padding.Right), Math.Max(0.0, finalSize.Height - padding.Top - padding.Bottom)) / 2.0;
			eCE.Radius = radius;
		}
		return finalSize;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		base.MeasureOverride(availableSize);
		double num = 16.0;
		if (double.IsPositiveInfinity(availableSize.Width))
		{
			if (!double.IsPositiveInfinity(availableSize.Height))
			{
				num = availableSize.Height;
			}
		}
		else
		{
			num = availableSize.Width;
			int num2 = 0;
			if (pGW() != null)
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
		}
		return new Size(num, num);
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		MCV(GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116714)) as RingSlice);
		iCH(_0020: false);
	}

	static RingSpinner()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		IsSpinningProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116746), typeof(bool), typeof(RingSpinner), new PropertyMetadata(false, oCU));
		LineCapProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116770), typeof(PenLineCap), typeof(RingSpinner), new PropertyMetadata(PenLineCap.Round));
		RadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(115726), typeof(double), typeof(RingSpinner), new PropertyMetadata(8.0));
	}

	internal static bool OGP()
	{
		return OGh == null;
	}

	internal static RingSpinner pGW()
	{
		return OGh;
	}
}
