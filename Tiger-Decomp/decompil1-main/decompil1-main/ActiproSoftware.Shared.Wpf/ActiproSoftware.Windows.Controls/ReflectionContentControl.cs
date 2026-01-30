using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class ReflectionContentControl : ContentControl
{
	public static readonly DependencyProperty ReflectionEndOffsetProperty;

	public static readonly DependencyProperty ReflectionEndOpacityProperty;

	public static readonly DependencyProperty ReflectionHeightProperty;

	public static readonly DependencyProperty ReflectionMarginProperty;

	public static readonly DependencyProperty ReflectionSkewAngleXProperty;

	public static readonly DependencyProperty ReflectionStartOpacityProperty;

	internal static ReflectionContentControl YGS;

	public double ReflectionEndOffset
	{
		get
		{
			return (double)GetValue(ReflectionEndOffsetProperty);
		}
		set
		{
			SetValue(ReflectionEndOffsetProperty, value);
		}
	}

	public double ReflectionEndOpacity
	{
		get
		{
			return (double)GetValue(ReflectionEndOpacityProperty);
		}
		set
		{
			SetValue(ReflectionEndOpacityProperty, value);
		}
	}

	public double ReflectionHeight
	{
		get
		{
			return (double)GetValue(ReflectionHeightProperty);
		}
		set
		{
			SetValue(ReflectionHeightProperty, value);
		}
	}

	public double ReflectionMargin
	{
		get
		{
			return (double)GetValue(ReflectionMarginProperty);
		}
		set
		{
			SetValue(ReflectionMarginProperty, value);
		}
	}

	public double ReflectionSkewAngleX
	{
		get
		{
			return (double)GetValue(ReflectionSkewAngleXProperty);
		}
		set
		{
			SetValue(ReflectionSkewAngleXProperty, value);
		}
	}

	public double ReflectionStartOpacity
	{
		get
		{
			return (double)GetValue(ReflectionStartOpacityProperty);
		}
		set
		{
			SetValue(ReflectionStartOpacityProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ReflectionContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ReflectionEndOffsetProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116056), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(0.9, FrameworkPropertyMetadataOptions.AffectsRender), ValidationHelper.ValidateDoubleIsPercentage);
		ReflectionEndOpacityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116098), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), ValidationHelper.ValidateDoubleIsPercentage);
		ReflectionHeightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116142), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(double.NaN, FrameworkPropertyMetadataOptions.AffectsRender), ValidationHelper.ValidateDoubleIsPositiveOrNaN);
		int num = 0;
		if (false)
		{
			int num2;
			num = num2;
		}
		switch (num)
		{
		}
		ReflectionMarginProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116178), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender));
		ReflectionSkewAngleXProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116214), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object obj) => ValidationHelper.ValidateDoubleIsBetweenInclusive(obj, -90.0, 90.0));
		ReflectionStartOpacityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116258), typeof(double), typeof(ReflectionContentControl), new FrameworkPropertyMetadata(0.4, FrameworkPropertyMetadataOptions.AffectsRender), ValidationHelper.ValidateDoubleIsPercentage);
		Control.IsTabStopProperty.OverrideMetadata(typeof(ReflectionContentControl), new FrameworkPropertyMetadata(false));
		UIElement.FocusableProperty.OverrideMetadata(typeof(ReflectionContentControl), new FrameworkPropertyMetadata(false));
	}

	public ReflectionContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public ReflectionContentControl(object content)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		base.Content = content;
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		base.OnRender(drawingContext);
		if (VisualChildrenCount == 0)
		{
			return;
		}
		Visual visualChild = GetVisualChild(0);
		VisualBrush visualBrush = new VisualBrush(visualChild);
		visualBrush.Stretch = Stretch.Fill;
		double num = 0.0;
		double num2 = 0.0;
		double num3 = base.ActualWidth;
		double num4 = base.ActualHeight;
		if (visualChild is ContentPresenter && VisualTreeHelper.GetChildrenCount(visualChild) > 0)
		{
			visualChild = VisualTreeHelper.GetChild(visualChild, 0) as Visual;
			if (visualChild is UIElement uIElement)
			{
				Point point = uIElement.TransformToAncestor(this).Transform(new Point(0.0, 0.0));
				num = point.X;
				num2 = point.Y;
				num3 = uIElement.RenderSize.Width;
				num4 = uIElement.RenderSize.Height;
				if (uIElement is TextBlock && uIElement.DesiredSize.Height == num4 && uIElement.DesiredSize.Width < num3)
				{
					num3 = uIElement.DesiredSize.Width;
				}
			}
		}
		double num5 = (double.IsNaN(ReflectionHeight) ? num4 : ReflectionHeight);
		if (base.FlowDirection == FlowDirection.RightToLeft && num3 == base.ActualWidth)
		{
			num = num3 - num;
		}
		TransformGroup transformGroup = new TransformGroup();
		transformGroup.Children.Add(new ScaleTransform(1.0, -1.0));
		if (ReflectionSkewAngleX != 0.0)
		{
			transformGroup.Children.Add(new SkewTransform(ReflectionSkewAngleX, 0.0, num3 / 2.0, num4));
		}
		drawingContext.PushTransform(transformGroup);
		try
		{
			LinearGradientBrush opacityMask = new LinearGradientBrush(Color.FromArgb((byte)(255.0 * ReflectionEndOpacity), 0, 0, 0), Color.FromArgb((byte)(255.0 * ReflectionStartOpacity), 0, 0, 0), new Point(0.0, 1.0 - ReflectionEndOffset), new Point(0.0, 1.0));
			drawingContext.PushOpacityMask(opacityMask);
			try
			{
				drawingContext.DrawRectangle(visualBrush, null, new Rect(num, 0.0 - num2 - num4 - ReflectionMargin - num5, num3, num5));
			}
			finally
			{
				drawingContext.Pop();
			}
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	internal static bool AGB()
	{
		return YGS == null;
	}

	internal static ReflectionContentControl UGA()
	{
		return YGS;
	}
}
