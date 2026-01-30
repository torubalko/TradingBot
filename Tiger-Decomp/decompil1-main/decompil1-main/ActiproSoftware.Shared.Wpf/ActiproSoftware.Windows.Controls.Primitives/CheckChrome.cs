using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public sealed class CheckChrome : BulletChrome
{
	private static Geometry mxv;

	private static object ExX;

	public static readonly DependencyProperty CornerRadiusProperty;

	private static CheckChrome N0p;

	public CornerRadius CornerRadius
	{
		get
		{
			return (CornerRadius)GetValue(CornerRadiusProperty);
		}
		set
		{
			SetValue(CornerRadiusProperty, value);
		}
	}

	[SpecialName]
	private static Geometry Mxc()
	{
		if (mxv == null)
		{
			lock (ExX)
			{
				if (mxv == null)
				{
					Geometry geometry = Geometry.Parse(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(120008));
					geometry.Freeze();
					mxv = geometry;
				}
			}
		}
		return mxv;
	}

	private double sIz()
	{
		double num = Math.Max(0.0, base.BorderWidth - 1.0);
		return (0.2 * base.ActualHeight + num).Round(RoundMode.Round);
	}

	protected override Size MeasureOverride(Size constraint)
	{
		double fontSize = TextElement.GetFontSize(this);
		double num = 1.0;
		switch (base.RelativeSize)
		{
		case BulletChromeRelativeSize.Medium:
			num = 2.5;
			break;
		case BulletChromeRelativeSize.Large:
			num = 4.0;
			break;
		default:
		{
			int num2 = 0;
			if (!L0h())
			{
				int num3 = default(int);
				num2 = num3;
			}
			switch (num2)
			{
			}
			break;
		}
		}
		double num4 = num * Math.Max(2.0, fontSize * 0.2).Round(RoundMode.Round);
		double num5 = Math.Max(14.0, fontSize + num4).Round(RoundMode.CeilingToEven);
		return new Size(num5, num5);
	}

	protected override void RenderBackground(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double borderWidth = base.BorderWidth;
		if (bounds.Width <= 2.0 * borderWidth || bounds.Height <= 2.0 * borderWidth)
		{
			return;
		}
		CornerRadius cornerRadius = CornerRadius;
		Rect rectangle = bounds;
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = GetBackgroundForState(state, base.IsChecked) ?? GetBackgroundForState(BulletChromeState.Normal, base.IsChecked);
			drawingContext.DrawRoundedRectangle(brush, null, rectangle, cornerRadius);
			return;
		}
		drawingContext.DrawRoundedRectangle(base.Background, null, rectangle, cornerRadius);
		state = base.LastState;
		if (state != BulletChromeState.Normal && state != BulletChromeState.Disabled)
		{
			Brush backgroundForState = GetBackgroundForState(state, base.IsChecked);
			double opacityForState = GetOpacityForState(state);
			if (backgroundForState != null && opacityForState != 0.0)
			{
				drawingContext.PushOpacity(opacityForState);
				try
				{
					drawingContext.DrawRoundedRectangle(backgroundForState, null, rectangle, cornerRadius);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = base.State;
		if (state == BulletChromeState.Normal)
		{
			return;
		}
		Brush backgroundForState2 = GetBackgroundForState(state, base.IsChecked);
		double opacityForState2 = GetOpacityForState(state);
		if (backgroundForState2 == null || opacityForState2 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(opacityForState2);
		try
		{
			drawingContext.DrawRoundedRectangle(backgroundForState2, null, rectangle, cornerRadius);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	protected override void RenderBorder(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double borderWidth = base.BorderWidth;
		if (bounds.Width <= 2.0 * borderWidth || bounds.Height <= 2.0 * borderWidth)
		{
			return;
		}
		CornerRadius cornerRadius = CornerRadius;
		Rect rectangle = new Rect(bounds.Left + borderWidth / 2.0, bounds.Top + borderWidth / 2.0, bounds.Width - borderWidth, bounds.Height - borderWidth);
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Pen pen = new Pen(GetBorderBrushForState(state, base.IsChecked) ?? GetBorderBrushForState(BulletChromeState.Normal, base.IsChecked), borderWidth);
			drawingContext.DrawRoundedRectangle(null, pen, rectangle, cornerRadius);
			return;
		}
		drawingContext.DrawRoundedRectangle(null, new Pen(base.BorderBrush, borderWidth), rectangle, cornerRadius);
		state = base.LastState;
		if (state != BulletChromeState.Normal && state != BulletChromeState.Disabled)
		{
			Brush borderBrushForState = GetBorderBrushForState(state, base.IsChecked);
			double opacityForState = GetOpacityForState(state);
			if (borderBrushForState != null && opacityForState != 0.0)
			{
				drawingContext.PushOpacity(opacityForState);
				try
				{
					drawingContext.DrawRoundedRectangle(null, new Pen(borderBrushForState, borderWidth), rectangle, cornerRadius);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = base.State;
		if (state == BulletChromeState.Normal)
		{
			return;
		}
		Brush borderBrushForState2 = GetBorderBrushForState(state, base.IsChecked);
		double opacityForState2 = GetOpacityForState(state);
		if (borderBrushForState2 == null || opacityForState2 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(opacityForState2);
		try
		{
			drawingContext.DrawRoundedRectangle(null, new Pen(borderBrushForState2, borderWidth), rectangle, cornerRadius);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	protected override void RenderClassicSunkenBorder(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		drawingContext.DrawRectangle(SystemColors.ControlDarkBrush, null, new Rect(bounds.Left, bounds.Top, 1.0, bounds.Height));
		drawingContext.DrawRectangle(SystemColors.ControlDarkBrush, null, new Rect(bounds.Left, bounds.Top, bounds.Width, 1.0));
		drawingContext.DrawRectangle(SystemColors.ControlLightLightBrush, null, new Rect(bounds.Right - 1.0, bounds.Top, 1.0, bounds.Height));
		drawingContext.DrawRectangle(SystemColors.ControlLightLightBrush, null, new Rect(bounds.Left, bounds.Bottom - 1.0, bounds.Width, 1.0));
		bounds.Inflate(-1.0, -1.0);
		drawingContext.DrawRectangle(SystemColors.ControlDarkDarkBrush, null, new Rect(bounds.Left, bounds.Top, 1.0, bounds.Height));
		drawingContext.DrawRectangle(SystemColors.ControlDarkDarkBrush, null, new Rect(bounds.Left, bounds.Top, bounds.Width, 1.0));
		int num = 0;
		if (!L0h())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		drawingContext.DrawRectangle(SystemColors.ControlLightBrush, null, new Rect(bounds.Right - 1.0, bounds.Top, 1.0, bounds.Height));
		drawingContext.DrawRectangle(SystemColors.ControlLightBrush, null, new Rect(bounds.Left, bounds.Bottom - 1.0, bounds.Width, 1.0));
	}

	[SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Windows.Rect")]
	protected override void RenderGlyph(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		BulletChromeState state = base.State;
		bool? isChecked = base.IsChecked;
		if (isChecked == false && state != BulletChromeState.Pressed)
		{
			return;
		}
		double num = Math.Max(3.0, sIz());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		if (!isChecked.HasValue)
		{
			Brush glyphBackgroundForState = GetGlyphBackgroundForState(state, isChecked);
			if (glyphBackgroundForState != null)
			{
				Rect rectangle = new Rect(bounds.Left + num, bounds.Top + num, bounds.Width - 2.0 * num, bounds.Height - 2.0 * num);
				drawingContext.DrawRectangle(glyphBackgroundForState, null, rectangle);
			}
			glyphBackgroundForState = GetGlyphBorderBrushForState(state, isChecked);
			if (glyphBackgroundForState != null)
			{
				drawingContext.DrawRectangle(rectangle: new Rect(bounds.Left + num - 0.5, bounds.Top + num - 0.5, bounds.Width - 2.0 * num + 1.0, bounds.Height - 2.0 * num + 1.0), brush: null, pen: new Pen(glyphBackgroundForState, 1.0));
			}
			return;
		}
		bool flag = base.FlowDirection == FlowDirection.RightToLeft;
		if (flag)
		{
			drawingContext.PushTransform(new ScaleTransform(-1.0, 1.0, base.ActualWidth / 2.0, base.ActualHeight / 2.0));
		}
		double num2 = (base.ActualHeight - 2.0 * num + 2.0) / 10.0;
		if (num2 > 1.0)
		{
			drawingContext.PushTransform(new ScaleTransform(num2, num2, base.ActualWidth / 2.0, base.ActualHeight / 2.0));
		}
		double num3 = (base.ActualHeight - 10.0) / 2.0;
		drawingContext.PushTransform(new TranslateTransform(num3, num3));
		try
		{
			Brush glyphBorderBrushForState = GetGlyphBorderBrushForState(state, isChecked);
			if (glyphBorderBrushForState != null)
			{
				Rect rect = new Rect(bounds.Left + 3.0, bounds.Top + 3.0, bounds.Width - 6.0, bounds.Height - 6.0);
				drawingContext.DrawGeometry(null, new Pen(glyphBorderBrushForState, 1.5), Mxc());
			}
			glyphBorderBrushForState = GetGlyphBackgroundForState(state, isChecked);
			if (glyphBorderBrushForState != null)
			{
				drawingContext.DrawGeometry(glyphBorderBrushForState, null, Mxc());
			}
		}
		finally
		{
			if (flag)
			{
				drawingContext.Pop();
			}
			if (num2 > 1.0)
			{
				drawingContext.Pop();
			}
			drawingContext.Pop();
		}
	}

	protected override void RenderInnerBackground(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double num = Math.Max(3.0, sIz());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		CornerRadius cornerRadius = new CornerRadius(0.0);
		Rect rectangle = new Rect(bounds.Left + num, bounds.Top + num, bounds.Width - 2.0 * num, bounds.Height - 2.0 * num);
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = GetInnerBackgroundForState(state) ?? GetInnerBackgroundForState(BulletChromeState.Normal);
			drawingContext.DrawRoundedRectangle(brush, null, rectangle, cornerRadius);
			return;
		}
		drawingContext.DrawRoundedRectangle(base.InnerBackground, null, rectangle, cornerRadius);
		state = base.LastState;
		if (state != BulletChromeState.Normal && state != BulletChromeState.Disabled)
		{
			Brush innerBackgroundForState = GetInnerBackgroundForState(state);
			double opacityForState = GetOpacityForState(state);
			if (innerBackgroundForState != null && opacityForState != 0.0)
			{
				drawingContext.PushOpacity(opacityForState);
				try
				{
					drawingContext.DrawRoundedRectangle(innerBackgroundForState, null, rectangle, cornerRadius);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = base.State;
		if (state == BulletChromeState.Normal)
		{
			return;
		}
		Brush innerBackgroundForState2 = GetInnerBackgroundForState(state);
		double opacityForState2 = GetOpacityForState(state);
		if (innerBackgroundForState2 == null || opacityForState2 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(opacityForState2);
		try
		{
			drawingContext.DrawRoundedRectangle(innerBackgroundForState2, null, rectangle, cornerRadius);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	protected override void RenderInnerBorder(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double num = Math.Max(3.0, sIz());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		CornerRadius cornerRadius = new CornerRadius(0.0);
		Rect rectangle = new Rect(bounds.Left + num - 0.5, bounds.Top + num - 0.5, bounds.Width - 2.0 * num + 1.0, bounds.Height - 2.0 * num + 1.0);
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Pen pen = new Pen(GetInnerBorderBrushForState(state) ?? GetInnerBorderBrushForState(BulletChromeState.Normal), 1.0);
			drawingContext.DrawRectangle(null, pen, rectangle);
			return;
		}
		drawingContext.DrawRectangle(null, new Pen(base.InnerBorderBrush, 1.0), rectangle);
		state = base.LastState;
		if (state != BulletChromeState.Normal && state != BulletChromeState.Disabled)
		{
			Brush innerBorderBrushForState = GetInnerBorderBrushForState(state);
			double opacityForState = GetOpacityForState(state);
			if (innerBorderBrushForState != null && opacityForState != 0.0)
			{
				drawingContext.PushOpacity(opacityForState);
				try
				{
					drawingContext.DrawRectangle(null, new Pen(innerBorderBrushForState, 1.0), rectangle);
				}
				finally
				{
					drawingContext.Pop();
				}
			}
		}
		state = base.State;
		if (state == BulletChromeState.Normal)
		{
			return;
		}
		Brush innerBorderBrushForState2 = GetInnerBorderBrushForState(state);
		double opacityForState2 = GetOpacityForState(state);
		if (innerBorderBrushForState2 == null || opacityForState2 == 0.0)
		{
			return;
		}
		drawingContext.PushOpacity(opacityForState2);
		try
		{
			drawingContext.DrawRectangle(null, new Pen(innerBorderBrushForState2, 1.0), rectangle);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	public CheckChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static CheckChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ExX = new object();
		CornerRadiusProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97530), typeof(CornerRadius), typeof(BulletChrome), new FrameworkPropertyMetadata(new CornerRadius(0.0), FrameworkPropertyMetadataOptions.AffectsRender));
	}

	internal static bool L0h()
	{
		return N0p == null;
	}

	internal static CheckChrome W0P()
	{
		return N0p;
	}
}
