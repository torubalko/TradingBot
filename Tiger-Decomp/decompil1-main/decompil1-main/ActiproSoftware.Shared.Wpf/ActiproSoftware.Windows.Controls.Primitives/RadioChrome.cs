using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public sealed class RadioChrome : BulletChrome
{
	private static Geometry yxM;

	private static Geometry lxK;

	private static object kxg;

	internal static RadioChrome Ybw;

	[SpecialName]
	private static Geometry oxs()
	{
		if (yxM == null)
		{
			lock (kxg)
			{
				bool flag = yxM == null;
				int num = 0;
				if (!Vbk())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				default:
					if (flag)
					{
						StreamGeometry streamGeometry = new StreamGeometry();
						StreamGeometryContext streamGeometryContext = streamGeometry.Open();
						streamGeometryContext.BeginFigure(new Point(2.0, 10.0), isFilled: true, isClosed: false);
						streamGeometryContext.ArcTo(new Point(10.0, 2.0), new Size(4.0, 4.0), 0.0, isLargeArc: false, SweepDirection.Counterclockwise, isStroked: true, isSmoothJoin: false);
						streamGeometryContext.Close();
						streamGeometry.Freeze();
						yxM = streamGeometry;
					}
					break;
				}
			}
		}
		return yxM;
	}

	[SpecialName]
	private static Geometry Mxd()
	{
		if (lxK == null)
		{
			lock (kxg)
			{
				if (lxK == null)
				{
					StreamGeometry streamGeometry = new StreamGeometry();
					StreamGeometryContext streamGeometryContext = streamGeometry.Open();
					streamGeometryContext.BeginFigure(new Point(2.0, 10.0), isFilled: true, isClosed: false);
					streamGeometryContext.ArcTo(new Point(10.0, 2.0), new Size(4.0, 4.0), 0.0, isLargeArc: false, SweepDirection.Clockwise, isStroked: true, isSmoothJoin: false);
					streamGeometryContext.Close();
					int num = 0;
					if (tbF() != null)
					{
						int num2 = default(int);
						num = num2;
					}
					switch (num)
					{
					default:
						streamGeometry.Freeze();
						lxK = streamGeometry;
						break;
					}
				}
			}
		}
		return lxK;
	}

	private double YxE()
	{
		double num = Math.Max(0.0, base.BorderWidth - 1.0);
		return (0.2 * base.ActualHeight + num).Round(RoundMode.Round);
	}

	protected override Size MeasureOverride(Size constraint)
	{
		double fontSize = TextElement.GetFontSize(this);
		double num = 1.0;
		BulletChromeRelativeSize relativeSize = base.RelativeSize;
		BulletChromeRelativeSize bulletChromeRelativeSize = relativeSize;
		if (bulletChromeRelativeSize != BulletChromeRelativeSize.Medium)
		{
			if (bulletChromeRelativeSize == BulletChromeRelativeSize.Large)
			{
				num = 4.0;
			}
		}
		else
		{
			num = 2.5;
		}
		double num2 = num * Math.Max(2.0, fontSize * 0.2).Round(RoundMode.Round);
		int num3 = 0;
		if (!Vbk())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		default:
		{
			double num5 = Math.Max(14.0, fontSize + num2).Round(RoundMode.CeilingToEven);
			return new Size(num5, num5);
		}
		}
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
		Point center = new Point(bounds.Left + bounds.Width * 0.5, bounds.Top + bounds.Height * 0.5);
		double radiusX = (bounds.Width - borderWidth) * 0.5;
		double radiusY = (bounds.Height - borderWidth) * 0.5;
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = GetBackgroundForState(state, base.IsChecked) ?? GetBackgroundForState(BulletChromeState.Normal, base.IsChecked);
			drawingContext.DrawEllipse(brush, null, center, radiusX, radiusY);
			return;
		}
		drawingContext.DrawEllipse(base.Background, null, center, radiusX, radiusY);
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
					drawingContext.DrawEllipse(backgroundForState, null, center, radiusX, radiusY);
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
			drawingContext.DrawEllipse(backgroundForState2, null, center, radiusX, radiusY);
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
		if (bounds.Width <= 5.0 || bounds.Height <= 5.0)
		{
			return;
		}
		double borderWidth = base.BorderWidth;
		if (bounds.Width <= 2.0 * borderWidth || bounds.Height <= 2.0 * borderWidth)
		{
			return;
		}
		Point center = new Point(bounds.Left + bounds.Width * 0.5, bounds.Top + bounds.Height * 0.5);
		double radiusX = (bounds.Width - borderWidth) * 0.5;
		double radiusY = (bounds.Height - borderWidth) * 0.5;
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Pen pen = new Pen(GetBorderBrushForState(state, base.IsChecked) ?? GetBorderBrushForState(BulletChromeState.Normal, base.IsChecked), borderWidth);
			drawingContext.DrawEllipse(null, pen, center, radiusX, radiusY);
			return;
		}
		drawingContext.DrawEllipse(null, new Pen(base.BorderBrush, borderWidth), center, radiusX, radiusY);
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
					drawingContext.DrawEllipse(null, new Pen(borderBrushForState, borderWidth), center, radiusX, radiusY);
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
			drawingContext.DrawEllipse(null, new Pen(borderBrushForState2, borderWidth), center, radiusX, radiusY);
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
		if (!(bounds.Width < 12.0) || !(bounds.Height < 12.0))
		{
			drawingContext.DrawGeometry(SystemColors.ControlDarkDarkBrush, new Pen(SystemColors.ControlDarkBrush, 1.0), Mxd());
			drawingContext.DrawGeometry(SystemColors.ControlLightBrush, new Pen(SystemColors.ControlLightLightBrush, 1.0), oxs());
			BulletChromeState state = base.State;
			Brush backgroundForState = GetBackgroundForState(state, base.IsChecked);
			drawingContext.DrawEllipse(backgroundForState, null, new Point(6.0, 6.0), 4.0, 4.0);
		}
	}

	protected override void RenderGlyph(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double num = Math.Max(3.0, YxE());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		Point center = new Point(bounds.Left + bounds.Width * 0.5, bounds.Top + bounds.Height * 0.5);
		double num2 = (bounds.Width - 2.0 * num) * 0.5;
		double num3 = (bounds.Height - 2.0 * num) * 0.5;
		BulletChromeState state = base.State;
		bool? isChecked = base.IsChecked;
		if (isChecked == false && state != BulletChromeState.Pressed)
		{
			return;
		}
		double thickness = 1.0;
		Brush brush = GetGlyphBackgroundForState(state, isChecked);
		Brush brush2 = GetGlyphBorderBrushForState(state, isChecked);
		if (!isChecked.HasValue)
		{
			if (brush2 != null && brush2 is SolidColorBrush { Color: { A: 0 } })
			{
				brush2 = null;
			}
			thickness = 2.0;
			num2 -= 1.0;
			num3 -= 1.0;
			if (brush2 == null)
			{
				brush2 = brush;
			}
			brush = null;
		}
		if (brush != null || brush2 != null)
		{
			drawingContext.DrawEllipse(brush, (brush2 != null) ? new Pen(brush2, thickness) : null, center, num2, num3);
		}
	}

	protected override void RenderInnerBackground(DrawingContext drawingContext, Rect bounds)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		double num = Math.Max(3.0, YxE());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		Point center = new Point(bounds.Left + bounds.Width * 0.5, bounds.Top + bounds.Height * 0.5);
		double radiusX = (bounds.Width - 2.0 * num) * 0.5;
		double radiusY = (bounds.Height - 2.0 * num) * 0.5;
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Brush brush = GetInnerBackgroundForState(state) ?? GetInnerBackgroundForState(BulletChromeState.Normal);
			drawingContext.DrawEllipse(brush, null, center, radiusX, radiusY);
			return;
		}
		drawingContext.DrawEllipse(base.InnerBackground, null, center, radiusX, radiusY);
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
					drawingContext.DrawEllipse(innerBackgroundForState, null, center, radiusX, radiusY);
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
			drawingContext.DrawEllipse(innerBackgroundForState2, null, center, radiusX, radiusY);
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
		double num = Math.Max(3.0, YxE());
		if (bounds.Width <= 2.0 * num || bounds.Height <= 2.0 * num)
		{
			return;
		}
		int num2 = 1;
		Point center = new Point(bounds.Left + bounds.Width * 0.5, bounds.Top + bounds.Height * 0.5);
		double radiusX = (bounds.Width - 2.0 * num + (double)num2) * 0.5;
		double radiusY = (bounds.Height - 2.0 * num + (double)num2) * 0.5;
		BulletChromeState state = base.State;
		if (state == BulletChromeState.Disabled || !base.IsAnimationEnabledResolved)
		{
			Pen pen = new Pen(GetInnerBorderBrushForState(state) ?? GetInnerBorderBrushForState(BulletChromeState.Normal), num2);
			drawingContext.DrawEllipse(null, pen, center, radiusX, radiusY);
			return;
		}
		drawingContext.DrawEllipse(null, new Pen(base.InnerBorderBrush, num2), center, radiusX, radiusY);
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
					drawingContext.DrawEllipse(null, new Pen(innerBorderBrushForState, num2), center, radiusX, radiusY);
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
			drawingContext.DrawEllipse(null, new Pen(innerBorderBrushForState2, num2), center, radiusX, radiusY);
		}
		finally
		{
			drawingContext.Pop();
		}
	}

	public RadioChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static RadioChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		kxg = new object();
	}

	internal static bool Vbk()
	{
		return Ybw == null;
	}

	internal static RadioChrome tbF()
	{
		return Ybw;
	}
}
