using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Windows.Extensions;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public sealed class ScrollChrome : ElementChrome
{
	private static Geometry dre;

	private static Geometry Lr7;

	private static Geometry IrF;

	private static Geometry lro;

	private static Geometry erQ;

	private static Geometry JrO;

	private static Geometry ur0;

	private static Geometry Urk;

	private static Geometry Jrl;

	private static Geometry orA;

	private MatrixTransform vrC;

	private static object lrY;

	public static readonly DependencyProperty GlyphBackgroundProperty;

	public static readonly DependencyProperty GlyphBackgroundDisabledProperty;

	public static readonly DependencyProperty GlyphBackgroundHoverProperty;

	public static readonly DependencyProperty GlyphBackgroundPressedProperty;

	public static readonly DependencyProperty GlyphHighlightProperty;

	public static readonly DependencyProperty GlyphHighlightDisabledProperty;

	public static readonly DependencyProperty GlyphHighlightHoverProperty;

	public static readonly DependencyProperty GlyphHighlightPressedProperty;

	public static readonly DependencyProperty GlyphProperty;

	public static readonly DependencyProperty UseAlternateGeometryProperty;

	private static ScrollChrome fbd;

	public ScrollChromeGlyph Glyph
	{
		get
		{
			return (ScrollChromeGlyph)GetValue(GlyphProperty);
		}
		set
		{
			SetValue(GlyphProperty, value);
		}
	}

	public Brush GlyphBackground
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundProperty);
		}
		set
		{
			SetValue(GlyphBackgroundProperty, value);
		}
	}

	public Brush GlyphBackgroundDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundDisabledProperty);
		}
		set
		{
			SetValue(GlyphBackgroundDisabledProperty, value);
		}
	}

	public Brush GlyphBackgroundHover
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundHoverProperty);
		}
		set
		{
			SetValue(GlyphBackgroundHoverProperty, value);
		}
	}

	public Brush GlyphBackgroundPressed
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundPressedProperty);
		}
		set
		{
			SetValue(GlyphBackgroundPressedProperty, value);
		}
	}

	public Brush GlyphHighlight
	{
		get
		{
			return (Brush)GetValue(GlyphHighlightProperty);
		}
		set
		{
			SetValue(GlyphHighlightProperty, value);
		}
	}

	public Brush GlyphHighlightDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphHighlightDisabledProperty);
		}
		set
		{
			SetValue(GlyphHighlightDisabledProperty, value);
		}
	}

	public Brush GlyphHighlightHover
	{
		get
		{
			return (Brush)GetValue(GlyphHighlightHoverProperty);
		}
		set
		{
			SetValue(GlyphHighlightHoverProperty, value);
		}
	}

	public Brush GlyphHighlightPressed
	{
		get
		{
			return (Brush)GetValue(GlyphHighlightPressedProperty);
		}
		set
		{
			SetValue(GlyphHighlightPressedProperty, value);
		}
	}

	public bool UseAlternateGeometry
	{
		get
		{
			return (bool)GetValue(UseAlternateGeometryProperty);
		}
		set
		{
			SetValue(UseAlternateGeometryProperty, value);
		}
	}

	[SpecialName]
	private static Geometry mrv()
	{
		if (dre == null)
		{
			lock (lrY)
			{
				if (dre == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 2.5),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(4.5, 7.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(9.0, 2.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.5, 1.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(4.5, 4.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(1.5, 1.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					dre = pathGeometry;
				}
			}
		}
		return dre;
	}

	[SpecialName]
	private static Geometry brT()
	{
		if (Lr7 == null)
		{
			lock (lrY)
			{
				if (Lr7 == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 3.5),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(4.5, 8.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(9.0, 3.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.5, 2.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(4.5, 5.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(1.5, 2.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					Lr7 = pathGeometry;
				}
			}
		}
		return Lr7;
	}

	[SpecialName]
	private static Geometry Frp()
	{
		if (IrF == null)
		{
			lock (lrY)
			{
				if (IrF == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(5.5, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(1.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(5.5, 9.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.0, 7.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(4.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.0, 1.5), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					IrF = pathGeometry;
				}
			}
		}
		return IrF;
	}

	[SpecialName]
	private static Geometry mry()
	{
		if (lro == null)
		{
			lock (lrY)
			{
				if (lro == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(2.5, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(7.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(3.5, 9.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(1.0, 7.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(4.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(1.0, 1.5), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					lro = pathGeometry;
				}
			}
		}
		return lro;
	}

	[SpecialName]
	private static Geometry Jri()
	{
		if (erQ == null)
		{
			lock (lrY)
			{
				if (erQ == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 5.5),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(4.5, 1.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(9.0, 5.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.5, 7.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(4.5, 4.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(1.5, 7.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					erQ = pathGeometry;
				}
			}
		}
		return erQ;
	}

	[SpecialName]
	private static Geometry nr3()
	{
		if (JrO == null)
		{
			lock (lrY)
			{
				if (JrO == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(4.5, 5.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(9.0, 0.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					JrO = pathGeometry;
				}
			}
		}
		return JrO;
	}

	[SpecialName]
	private static Geometry qrJ()
	{
		if (ur0 == null)
		{
			lock (lrY)
			{
				if (ur0 == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(3.5, 4.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(7.0, 0.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					ur0 = pathGeometry;
				}
			}
		}
		return ur0;
	}

	private static MatrixTransform tx8(ScrollChromeGlyph P_0, bool P_1, Rect P_2)
	{
		double num = 9.0;
		double num2 = 5.0;
		if (P_1)
		{
			num = 9.0;
			num2 = 8.0;
		}
		else if (P_0 == ScrollChromeGlyph.DropDownArrow)
		{
			num = 7.0;
			num2 = 4.0;
		}
		if (P_0 == ScrollChromeGlyph.LeftArrow || P_0 == ScrollChromeGlyph.RightArrow)
		{
			double num3 = num;
			num = num2;
			num2 = num3;
		}
		Matrix matrix = default(Matrix);
		if (P_2.Width < num || P_2.Height < num2)
		{
			double num4 = Math.Min(num, P_2.Width) / num;
			double num5 = Math.Min(num2, P_2.Height) / num2;
			if (double.IsNaN(num4) || double.IsInfinity(num4) || double.IsNaN(num5) || double.IsInfinity(num5))
			{
				return null;
			}
			matrix.Scale(num4, num5);
			double num6 = (P_2.X + P_2.Width / 2.0) / num4 - num / 2.0;
			double num7 = (P_2.Y + P_2.Height / 2.0) / num5 - num2 / 2.0;
			if (double.IsNaN(num6) || double.IsInfinity(num6) || double.IsNaN(num7) || double.IsInfinity(num7))
			{
				return null;
			}
			num6 = Math.Round(num6, MidpointRounding.AwayFromZero);
			num7 = Math.Round(num7, MidpointRounding.AwayFromZero);
			matrix.Translate(num6, num7);
		}
		else
		{
			double offsetX = Math.Round(P_2.X + P_2.Width / 2.0 - num / 2.0, MidpointRounding.AwayFromZero);
			double offsetY = Math.Round(P_2.Y + P_2.Height / 2.0 - num2 / 2.0, MidpointRounding.AwayFromZero);
			matrix.Translate(offsetX, offsetY);
		}
		return new MatrixTransform
		{
			Matrix = matrix
		};
	}

	private Brush DxD(ElementChromeState P_0)
	{
		return P_0 switch
		{
			ElementChromeState.Disabled => GlyphBackgroundDisabled, 
			ElementChromeState.Pressed => GlyphBackgroundPressed, 
			ElementChromeState.Hover => GlyphBackgroundHover, 
			_ => GlyphBackground, 
		};
	}

	private Brush TxP(ElementChromeState P_0)
	{
		switch (P_0)
		{
		default:
		{
			int num = 0;
			if (!Jbv())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			goto case ElementChromeState.Focused;
		}
		case ElementChromeState.Disabled:
			return GlyphHighlightDisabled;
		case ElementChromeState.Focused:
			return GlyphHighlight;
		case ElementChromeState.Hover:
			return GlyphHighlightHover;
		case ElementChromeState.Pressed:
			return GlyphHighlightPressed;
		}
	}

	private static bool hxG(Brush P_0)
	{
		int num = 1;
		SolidColorBrush solidColorBrush = default(SolidColorBrush);
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					if (solidColorBrush != null && solidColorBrush.Color.A <= 80)
					{
						return true;
					}
					return false;
				case 1:
					break;
				}
				solidColorBrush = P_0 as SolidColorBrush;
				num2 = 0;
			}
			while (Jbv());
		}
	}

	[SpecialName]
	private static Geometry Trh()
	{
		if (Urk == null)
		{
			lock (lrY)
			{
				if (Urk == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(5.0, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(0.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(5.0, 9.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					Urk = pathGeometry;
				}
			}
		}
		return Urk;
	}

	private void Nx1(DrawingContext P_0, Brush P_1, Rect P_2)
	{
		ScrollChromeGlyph glyph = Glyph;
		bool useAlternateGeometry = UseAlternateGeometry;
		if (vrC == null)
		{
			vrC = tx8(glyph, useAlternateGeometry, P_2);
		}
		P_0.PushTransform(vrC);
		try
		{
			switch (Glyph)
			{
			case ScrollChromeGlyph.LeftArrow:
				P_0.DrawGeometry(P_1, null, (!useAlternateGeometry) ? Trh() : Frp());
				break;
			case ScrollChromeGlyph.RightArrow:
				P_0.DrawGeometry(P_1, null, (!useAlternateGeometry) ? prw() : mry());
				break;
			case ScrollChromeGlyph.UpArrow:
				P_0.DrawGeometry(P_1, null, (!useAlternateGeometry) ? Tru() : Jri());
				break;
			case ScrollChromeGlyph.DownArrow:
			{
				P_0.DrawGeometry(P_1, null, (!useAlternateGeometry) ? nr3() : mrv());
				int num = 0;
				if (!Jbv())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			case ScrollChromeGlyph.DropDownArrow:
				P_0.DrawGeometry(P_1, null, (!useAlternateGeometry) ? qrJ() : brT());
				break;
			case ScrollChromeGlyph.HorizontalGripper:
			case ScrollChromeGlyph.VerticalGripper:
				break;
			}
		}
		finally
		{
			P_0.Pop();
		}
	}

	private void lxz(DrawingContext P_0, Rect P_1)
	{
		if (P_1.Width == 0.0 || P_1.Height == 0.0)
		{
			return;
		}
		if (P_1.Width >= 2.0 && P_1.Height >= 2.0)
		{
			P_1.X += 1.0;
			P_1.Y += 1.0;
			P_1.Width -= 2.0;
			P_1.Height -= 2.0;
		}
		Brush brush = DxD(base.State);
		if (brush != null)
		{
			switch (Glyph)
			{
			case ScrollChromeGlyph.DownArrow:
			case ScrollChromeGlyph.LeftArrow:
			case ScrollChromeGlyph.RightArrow:
			case ScrollChromeGlyph.UpArrow:
			case ScrollChromeGlyph.DropDownArrow:
				Nx1(P_0, brush, P_1);
				break;
			case ScrollChromeGlyph.VerticalGripper:
				xrj(P_0, brush, P_1);
				break;
			case ScrollChromeGlyph.HorizontalGripper:
				brc(P_0, brush, P_1);
				break;
			case ScrollChromeGlyph.None:
				break;
			}
		}
	}

	private void brc(DrawingContext P_0, Brush P_1, Rect P_2)
	{
		if (P_2.Width <= 15.0 || P_2.Height <= 2.0)
		{
			return;
		}
		Brush brush = TxP(base.State);
		double num = default(double);
		double height = default(double);
		double num2 = default(double);
		double num3 = default(double);
		double[] guidelinesX = default(double[]);
		int num4;
		double num6 = default(double);
		if (!UseAlternateGeometry)
		{
			num = Math.Min(7.0, P_2.Height);
			height = num + 1.0;
			num2 = Math.Round(P_2.X + (P_2.Width / 2.0 - 4.0));
			num3 = Math.Round(P_2.Y + (P_2.Height - num) / 2.0);
			guidelinesX = new double[3]
			{
				num2,
				num2 + 3.0,
				num2 + 6.0
			};
			num4 = 2;
			if (sba() != null)
			{
				int num5 = default(int);
				num4 = num5;
			}
		}
		else
		{
			num6 = Math.Min(hxG(brush) ? 7.0 : 6.0, P_2.Height);
			num4 = 0;
			if (Jbv())
			{
				num4 = 0;
			}
		}
		switch (num4)
		{
		case 1:
			return;
		case 2:
		{
			double[] guidelinesY = new double[2]
			{
				num3,
				num3 + num
			};
			P_0.PushGuidelineSet(new GuidelineSet(guidelinesX, guidelinesY));
			try
			{
				for (int i = 0; i < 9; i += 3)
				{
					P_0.DrawRectangle(brush, null, new Rect(num2 + (double)i - 0.5, num3 - 0.5, 3.0, height));
					P_0.DrawRectangle(P_1, null, new Rect(Math.Round(num2 + (double)i), num3, 2.0, num));
				}
				return;
			}
			finally
			{
				P_0.Pop();
			}
		}
		}
		double num7 = Math.Round(P_2.X + (P_2.Width / 2.0 - 4.0));
		double num8 = Math.Round(P_2.Y + (P_2.Height - num6) / 2.0);
		double[] guidelinesX2 = new double[4]
		{
			num7,
			num7 + 2.0,
			num7 + 4.0,
			num7 + 6.0
		};
		double[] guidelinesY2 = new double[2]
		{
			num8,
			num8 + num6
		};
		P_0.PushGuidelineSet(new GuidelineSet(guidelinesX2, guidelinesY2));
		try
		{
			for (int j = 0; j < 8; j += 2)
			{
				P_0.DrawRectangle(brush, null, new Rect(num7 + (double)j + 1.0, num8 + 1.0, 1.0, num6));
				P_0.DrawRectangle(P_1, null, new Rect(Math.Round(num7 + (double)j), num8, 1.0, num6));
			}
		}
		finally
		{
			P_0.Pop();
		}
	}

	private void xrj(DrawingContext P_0, Brush P_1, Rect P_2)
	{
		if (P_2.Width <= 2.0 || P_2.Height <= 15.0)
		{
			return;
		}
		Brush brush = TxP(base.State);
		if (UseAlternateGeometry)
		{
			double num = Math.Min(hxG(brush) ? 7.0 : 6.0, P_2.Width);
			double num2 = Math.Round(P_2.X + (P_2.Width - num) / 2.0);
			double num3 = Math.Round(P_2.Y + (P_2.Height / 2.0 - 4.0));
			double[] guidelinesX = new double[2]
			{
				num2,
				num2 + num
			};
			double[] guidelinesY = new double[4]
			{
				num3,
				num3 + 2.0,
				num3 + 4.0,
				num3 + 6.0
			};
			P_0.PushGuidelineSet(new GuidelineSet(guidelinesX, guidelinesY));
			try
			{
				for (int i = 0; i < 8; i += 2)
				{
					P_0.DrawRectangle(brush, null, new Rect(num2 + 1.0, num3 + (double)i + 1.0, num, 1.0));
					P_0.DrawRectangle(P_1, null, new Rect(num2, Math.Round(num3 + (double)i), num, 1.0));
				}
				return;
			}
			finally
			{
				P_0.Pop();
			}
		}
		double num4 = Math.Min(7.0, P_2.Width);
		double width = num4 + 1.0;
		double num5 = Math.Round(P_2.X + (P_2.Width - num4) / 2.0);
		double num6 = Math.Round(P_2.Y + (P_2.Height / 2.0 - 4.0));
		double[] guidelinesX2 = new double[2]
		{
			num5,
			num5 + num4
		};
		double[] guidelinesY2 = new double[3]
		{
			num6,
			num6 + 3.0,
			num6 + 6.0
		};
		P_0.PushGuidelineSet(new GuidelineSet(guidelinesX2, guidelinesY2));
		try
		{
			for (int j = 0; j < 9; j += 3)
			{
				P_0.DrawRectangle(brush, null, new Rect(num5 - 0.5, num6 + (double)j - 0.5, width, 3.0));
				P_0.DrawRectangle(P_1, null, new Rect(num5, Math.Round(num6 + (double)j), num4, 2.0));
			}
		}
		finally
		{
			P_0.Pop();
		}
	}

	[SpecialName]
	private static Geometry prw()
	{
		if (Jrl == null)
		{
			lock (lrY)
			{
				if (Jrl == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 0.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(5.0, 4.5), isStroked: true),
							(PathSegment)new LineSegment(new Point(0.0, 9.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					Jrl = pathGeometry;
				}
			}
		}
		return Jrl;
	}

	[SpecialName]
	private static Geometry Tru()
	{
		if (orA == null)
		{
			lock (lrY)
			{
				if (orA == null)
				{
					PathFigure pathFigure = new PathFigure
					{
						StartPoint = new Point(0.0, 5.0),
						Segments = 
						{
							(PathSegment)new LineSegment(new Point(4.5, 0.0), isStroked: true),
							(PathSegment)new LineSegment(new Point(9.0, 5.0), isStroked: true)
						},
						IsClosed = true
					};
					pathFigure.Freeze();
					PathGeometry pathGeometry = new PathGeometry
					{
						Figures = { pathFigure }
					};
					pathGeometry.Freeze();
					orA = pathGeometry;
				}
			}
		}
		return orA;
	}

	protected override Size ArrangeOverride(Size arrangeSize)
	{
		vrC = null;
		base.ArrangeOverride(arrangeSize);
		return arrangeSize;
	}

	public static ScrollChromeGlyph GetGlyph(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (ScrollChromeGlyph)obj.GetValue(GlyphProperty);
	}

	public static void SetGlyph(DependencyObject obj, ScrollChromeGlyph value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(GlyphProperty, value);
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		vrC = null;
		base.MeasureOverride(availableSize);
		return new Size(0.0, 0.0);
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		Rect rect = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
		if (rect.Width == 0.0 || rect.Height == 0.0)
		{
			return;
		}
		ElementChromeBorderStyle borderStyle = base.BorderStyle;
		ElementChromeBorderStyle elementChromeBorderStyle = borderStyle;
		if ((uint)(elementChromeBorderStyle - 2) <= 4u)
		{
			base.OnRender(drawingContext);
		}
		else
		{
			Thickness borderThickness = base.BorderThickness;
			bool flag = false;
			if (!borderThickness.IsEffectivelyZero())
			{
				Brush brush = GetHighlightForState(base.State) ?? GetHighlightForState(ElementChromeState.Normal);
				if (brush != null)
				{
					flag = !hxG(brush);
				}
			}
			Thickness offset = new Thickness
			{
				Left = borderThickness.Left / 2.0,
				Top = borderThickness.Top / 2.0,
				Right = borderThickness.Right / 2.0,
				Bottom = borderThickness.Bottom / 2.0
			};
			if (flag)
			{
				rect.Width = Math.Max(0.0, rect.Width - 1.0);
				rect.Height = Math.Max(0.0, rect.Height - 1.0);
				Rect bounds = rect;
				bounds.Width += 1.5;
				bounds.Height += 1.5;
				CornerRadius cornerRadius = new CornerRadius(base.CornerRadius.TopLeft + 1.0, base.CornerRadius.TopRight + 1.0, base.CornerRadius.BottomRight + 1.0, base.CornerRadius.BottomLeft + 1.0);
				Geometry geometry = CreateRectangleGeometry(bounds, borderThickness, offset, cornerRadius);
				if (geometry != null)
				{
					RenderHighlight(drawingContext, geometry);
				}
			}
			Geometry geometry2 = CreateRectangleGeometry(rect, borderThickness, offset, base.CornerRadius);
			if (geometry2 == null)
			{
				return;
			}
			RenderBackground(drawingContext, geometry2);
			switch (base.BorderStyle)
			{
			default:
				RenderInnerBorder(drawingContext, rect);
				RenderBorder(drawingContext, geometry2);
				break;
			case ElementChromeBorderStyle.None:
				break;
			}
		}
		lxz(drawingContext, rect);
	}

	public ScrollChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static ScrollChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		lrY = new object();
		GlyphBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121138), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121172), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121222), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121266), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphHighlightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121314), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphHighlightDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121346), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphHighlightHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121394), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphHighlightPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121436), typeof(Brush), typeof(ScrollChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(121482), typeof(ScrollChromeGlyph), typeof(ScrollChrome), new FrameworkPropertyMetadata(ScrollChromeGlyph.None, FrameworkPropertyMetadataOptions.AffectsRender));
		UseAlternateGeometryProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119964), typeof(bool), typeof(ScrollChrome), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsMeasure | FrameworkPropertyMetadataOptions.AffectsRender));
	}

	internal static bool Jbv()
	{
		return fbd == null;
	}

	internal static ScrollChrome sba()
	{
		return fbd;
	}
}
