using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

public class TextViewDrawContext : CanvasDrawContext
{
	private enum O7K
	{
		Count = 19
	}

	private enum P7N
	{
		Count = 6
	}

	private Brush[] Mbf;

	private Pen[] fbD;

	private TextView mbg;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Rect dbQ;

	private static TextViewDrawContext OWS;

	public Brush CollapsibleRegionBackground
	{
		get
		{
			Brush brush = Mbf[1];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.CollapsibleRegion]?.Background), DisplayItemClassificationTypeProvider.p8);
				Mbf[1] = brush;
			}
			return brush;
		}
	}

	public Brush CollapsibleRegionForeground
	{
		get
		{
			Brush brush = Mbf[2];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.CollapsibleRegion]?.Foreground), DisplayItemClassificationTypeProvider.KI);
				Mbf[2] = brush;
			}
			return brush;
		}
	}

	public Brush CurrentLineBackground
	{
		get
		{
			Brush brush = Mbf[3];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.CurrentLine]?.Background), DisplayItemClassificationTypeProvider.OH);
				Mbf[3] = brush;
			}
			return brush;
		}
	}

	public Pen CurrentLineBorderPen
	{
		get
		{
			int num = 1;
			Pen pen = default(Pen);
			while (true)
			{
				int num2 = num;
				do
				{
					switch (num2)
					{
					case 1:
						break;
					default:
						if (pen == null)
						{
							pen = WHn(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.CurrentLine]?.BorderColor), DisplayItemClassificationTypeProvider.A5, 2f);
							pen.StartLineCap = PenLineCap.Square;
							pen.EndLineCap = PenLineCap.Square;
							pen.Freeze();
							fbD[0] = pen;
						}
						return pen;
					}
					pen = fbD[0];
					num2 = 0;
				}
				while (uWZ() == null);
			}
		}
	}

	public Brush DelimiterMatchingBackground
	{
		get
		{
			Brush brush = Mbf[4];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.DelimiterMatching]?.Background), DisplayItemClassificationTypeProvider.I0);
				Mbf[4] = brush;
			}
			return brush;
		}
	}

	public Brush InactiveSelectedTextBackground
	{
		get
		{
			Brush brush = Mbf[5];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.InactiveSelectedTextBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.InactiveSelectedText]?.Background), DisplayItemClassificationTypeProvider.y2, DisplayItemClassificationTypeProvider.h6);
				Mbf[5] = brush;
			}
			return brush;
		}
	}

	public Brush IndentationGuidesBackground
	{
		get
		{
			Brush brush = Mbf[6];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.IndentationGuides]?.Background), DisplayItemClassificationTypeProvider.iV);
				Mbf[6] = brush;
			}
			return brush;
		}
	}

	public Brush IndicatorMarginBackground
	{
		get
		{
			Brush brush = Mbf[7];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.IndicatorMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Background), DisplayItemClassificationTypeProvider.m7);
				Mbf[7] = brush;
			}
			return brush;
		}
	}

	public Brush LineNumberMarginBackground
	{
		get
		{
			Brush brush = Mbf[8];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.LineNumberMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.LineNumbers]?.Background), DisplayItemClassificationTypeProvider.lb);
				Mbf[8] = brush;
			}
			return brush;
		}
	}

	public Brush LineNumberMarginForeground
	{
		get
		{
			Brush brush = Mbf[9];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.LineNumberMarginForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.LineNumbers]?.Foreground), DisplayItemClassificationTypeProvider.Bi);
				Mbf[9] = brush;
			}
			return brush;
		}
	}

	public Brush OutliningMarginBackground
	{
		get
		{
			Brush brush = Mbf[10];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.OutliningMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.PlainText]?.Background), DisplayItemClassificationTypeProvider.gT);
				Mbf[10] = brush;
			}
			return brush;
		}
	}

	public Brush OutliningMarginSquareBackground
	{
		get
		{
			Brush brush = Mbf[11];
			if (brush == null)
			{
				brush = fHL(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.OutliningMarginSquare]?.Background), DisplayItemClassificationTypeProvider.Mp);
				Mbf[11] = brush;
			}
			return brush;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "PlainText")]
	public Brush PlainTextBackground
	{
		get
		{
			Brush brush = Mbf[0];
			if (brush == null)
			{
				brush = fHL(Control.BackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.PlainText]?.Background), DisplayItemClassificationTypeProvider.qU);
				Mbf[0] = brush;
			}
			return brush;
		}
	}

	public Brush RulerMarginBackground
	{
		get
		{
			Brush brush = Mbf[12];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.RulerMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Background), DisplayItemClassificationTypeProvider.Et);
				Mbf[12] = brush;
			}
			return brush;
		}
	}

	public Brush RulerMarginForeground
	{
		get
		{
			Brush brush = Mbf[13];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.RulerMarginForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Foreground), DisplayItemClassificationTypeProvider.UZ);
				Mbf[13] = brush;
			}
			return brush;
		}
	}

	public Brush SelectedTextBackground
	{
		get
		{
			Brush brush = Mbf[14];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.SelectedTextBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.SelectedText]?.Background), DisplayItemClassificationTypeProvider.bh, DisplayItemClassificationTypeProvider.h6);
				Mbf[14] = brush;
			}
			return brush;
		}
	}

	public Brush SelectionMarginBackground
	{
		get
		{
			Brush brush = Mbf[15];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.SelectionMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.PlainText]?.Background), DisplayItemClassificationTypeProvider.wL);
				Mbf[15] = brush;
			}
			return brush;
		}
	}

	[SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly", MessageId = "Whitespace")]
	public Brush VisibleWhitespaceForeground
	{
		get
		{
			Brush brush = Mbf[16];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.VisibleWhitespaceForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground), DisplayItemClassificationTypeProvider.QN);
				Mbf[16] = brush;
			}
			return brush;
		}
	}

	public Brush WordWrapGlyphMarginBackground
	{
		get
		{
			Brush brush = Mbf[17];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.WordWrapGlyphMarginBackgroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.PlainText]?.Background), DisplayItemClassificationTypeProvider.on);
				Mbf[17] = brush;
			}
			return brush;
		}
	}

	public Brush WordWrapGlyphMarginForeground
	{
		get
		{
			Brush brush = Mbf[18];
			if (brush == null)
			{
				brush = fHL(SyntaxEditor.WordWrapGlyphMarginForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground), DisplayItemClassificationTypeProvider.Wd);
				Mbf[18] = brush;
			}
			return brush;
		}
	}

	public Rect TextAreaBounds
	{
		[CompilerGenerated]
		get
		{
			return dbQ;
		}
		[CompilerGenerated]
		internal set
		{
			dbQ = value;
		}
	}

	public ITextView View => mbg;

	internal TextViewDrawContext(TextView view, ICanvas canvas, DrawingContext platformRenderer, Rect bounds)
	{
		grA.DaB7cz();
		base._002Ector(canvas, platformRenderer, bounds);
		mbg = view;
		Mbf = new Brush[19];
		fbD = new Pen[6];
	}

	private static Color lH6(Color P_0, double? P_1)
	{
		if (P_0.A == byte.MaxValue && P_1.HasValue)
		{
			P_0.A = (byte)Math.Max(0.0, Math.Min(255.0, P_1.Value * 255.0));
		}
		return P_0;
	}

	private void nHH()
	{
		for (int num = Mbf.Length - 1; num >= 0; num--)
		{
			Mbf[num] = null;
		}
		for (int num2 = fbD.Length - 1; num2 >= 0; num2--)
		{
			fbD[num2] = null;
		}
	}

	[SpecialName]
	internal Pen aHd()
	{
		Pen pen = fbD[2];
		if (pen == null)
		{
			pen = WHn(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.OutliningMarginVerticalRule]?.Foreground), DisplayItemClassificationTypeProvider.uO, 1f);
			pen.StartLineCap = PenLineCap.Square;
			pen.EndLineCap = PenLineCap.Square;
			pen.Freeze();
			fbD[2] = pen;
		}
		return pen;
	}

	[SpecialName]
	internal Pen pbW()
	{
		Pen pen = fbD[1];
		if (pen == null)
		{
			pen = WHn(null, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.OutliningMarginSquare]?.Foreground), DisplayItemClassificationTypeProvider.uM, 1f);
			pen.StartLineCap = PenLineCap.Square;
			pen.EndLineCap = PenLineCap.Square;
			pen.Freeze();
			fbD[1] = pen;
		}
		return pen;
	}

	[SpecialName]
	internal Pen bbE()
	{
		Pen pen = fbD[3];
		if (pen == null)
		{
			pen = WHn(SyntaxEditor.VisibleWhitespaceForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground), DisplayItemClassificationTypeProvider.QN, 1f);
			pen.StartLineCap = PenLineCap.Square;
			pen.EndLineCap = PenLineCap.Square;
			pen.Freeze();
			fbD[3] = pen;
		}
		return pen;
	}

	[SpecialName]
	internal Pen Cba()
	{
		Pen pen = fbD[4];
		if (pen == null)
		{
			pen = WHn(SyntaxEditor.VisibleWhitespaceForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground), DisplayItemClassificationTypeProvider.QN, 0.65f);
			pen.StartLineCap = PenLineCap.Square;
			pen.EndLineCap = PenLineCap.Square;
			pen.Freeze();
			fbD[4] = pen;
		}
		Pen pen2 = pen;
		int num = 0;
		if (uWZ() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		return num switch
		{
			_ => pen2, 
		};
	}

	[SpecialName]
	internal Pen JbG()
	{
		Pen pen = fbD[5];
		if (pen == null)
		{
			pen = WHn(SyntaxEditor.WordWrapGlyphMarginForegroundProperty, new Lazy<Color?>(() => mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground), DisplayItemClassificationTypeProvider.Wd, 1f);
			pen.Freeze();
			fbD[5] = pen;
		}
		return pen;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			nHH();
		}
		base.Dispose(disposing);
	}

	[SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
	private Brush aHb(Brush P_0)
	{
		return P_0;
	}

	internal static Color? mHT(object P_0)
	{
		return (P_0 is SolidColorBrush solidColorBrush) ? new Color?(solidColorBrush.Color) : ((Color?)null);
	}

	private Brush fHL(DependencyProperty P_0, Lazy<Color?> P_1, Color? P_2, double? P_3 = null)
	{
		bool useSyntaxEditorDisplayItemProperties = mbg.UseSyntaxEditorDisplayItemProperties;
		if (useSyntaxEditorDisplayItemProperties && P_0 != null)
		{
			if (mbg.SyntaxEditor.ReadLocalValue(P_0) is Brush brush)
			{
				Color? color = mHT(brush);
				if (color.HasValue)
				{
					return mbg.aAY().GetSolidColorBrush(lH6(color.Value, P_3));
				}
				return aHb(brush);
			}
			if (mbg.SyntaxEditor.GetBindingExpression(P_0) != null && mbg.SyntaxEditor.GetValue(P_0) is Brush brush2)
			{
				Color? color2 = mHT(brush2);
				if (color2.HasValue)
				{
					return mbg.aAY().GetSolidColorBrush(lH6(color2.Value, P_3));
				}
				return aHb(brush2);
			}
		}
		if (P_1 != null)
		{
			Color? value = P_1.Value;
			if (value.HasValue)
			{
				return mbg.aAY().GetSolidColorBrush(lH6(value.Value, P_3));
			}
		}
		if (useSyntaxEditorDisplayItemProperties && P_0 != null && mbg.SyntaxEditor.GetValue(P_0) is Brush brush3)
		{
			Color? color3 = mHT(brush3);
			if (color3.HasValue)
			{
				return mbg.aAY().GetSolidColorBrush(lH6(color3.Value, P_3));
			}
			return aHb(brush3);
		}
		if (P_2.HasValue)
		{
			return mbg.aAY().GetSolidColorBrush(lH6(P_2.Value, P_3));
		}
		return null;
	}

	private Pen WHn(DependencyProperty P_0, Lazy<Color?> P_1, Color? P_2, float P_3)
	{
		bool useSyntaxEditorDisplayItemProperties = mbg.UseSyntaxEditorDisplayItemProperties;
		if (useSyntaxEditorDisplayItemProperties && P_0 != null)
		{
			if (mbg.SyntaxEditor.ReadLocalValue(P_0) is Brush brush)
			{
				Color? color = mHT(brush);
				if (color.HasValue)
				{
					return new Pen(mbg.aAY().GetSolidColorBrush(color.Value), P_3);
				}
				return new Pen(aHb(brush), P_3);
			}
			if (mbg.SyntaxEditor.GetBindingExpression(P_0) != null && mbg.SyntaxEditor.GetValue(P_0) is Brush brush2)
			{
				Color? color2 = mHT(brush2);
				if (color2.HasValue)
				{
					return new Pen(mbg.aAY().GetSolidColorBrush(color2.Value), P_3);
				}
				return new Pen(aHb(brush2), P_3);
			}
		}
		if (P_1 != null)
		{
			Color? value = P_1.Value;
			if (value.HasValue)
			{
				return new Pen(mbg.aAY().GetSolidColorBrush(value.Value), P_3);
			}
		}
		if (useSyntaxEditorDisplayItemProperties && P_0 != null && mbg.SyntaxEditor.GetValue(P_0) is Brush brush3)
		{
			Color? color3 = mHT(brush3);
			if (color3.HasValue)
			{
				return new Pen(mbg.aAY().GetSolidColorBrush(color3.Value), P_3);
			}
			return new Pen(aHb(brush3), P_3);
		}
		if (P_2.HasValue)
		{
			return new Pen(mbg.aAY().GetSolidColorBrush(P_2.Value), P_3);
		}
		return null;
	}

	[CompilerGenerated]
	private Color? aH8()
	{
		return mbg.HighlightingStyleRegistry[cT.OutliningMarginVerticalRule]?.Foreground;
	}

	[CompilerGenerated]
	private Color? CHI()
	{
		return mbg.HighlightingStyleRegistry[cT.OutliningMarginSquare]?.Foreground;
	}

	[CompilerGenerated]
	private Color? uH5()
	{
		return mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground;
	}

	[CompilerGenerated]
	private Color? VH0()
	{
		return mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground;
	}

	[CompilerGenerated]
	private Color? QHB()
	{
		return mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground;
	}

	[CompilerGenerated]
	private Color? mHV()
	{
		return mbg.HighlightingStyleRegistry[cT.CollapsibleRegion]?.Background;
	}

	[CompilerGenerated]
	private Color? NHr()
	{
		return mbg.HighlightingStyleRegistry[cT.CollapsibleRegion]?.Foreground;
	}

	[CompilerGenerated]
	private Color? THs()
	{
		return mbg.HighlightingStyleRegistry[cT.CurrentLine]?.Background;
	}

	[CompilerGenerated]
	private Color? NHk()
	{
		return mbg.HighlightingStyleRegistry[cT.CurrentLine]?.BorderColor;
	}

	[CompilerGenerated]
	private Color? PHS()
	{
		return mbg.HighlightingStyleRegistry[cT.DelimiterMatching]?.Background;
	}

	[CompilerGenerated]
	private Color? qH9()
	{
		return mbg.HighlightingStyleRegistry[cT.InactiveSelectedText]?.Background;
	}

	[CompilerGenerated]
	private Color? oHy()
	{
		return mbg.HighlightingStyleRegistry[cT.IndentationGuides]?.Background;
	}

	[CompilerGenerated]
	private Color? aHq()
	{
		return mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Background;
	}

	[CompilerGenerated]
	private Color? WH2()
	{
		return mbg.HighlightingStyleRegistry[cT.LineNumbers]?.Background;
	}

	[CompilerGenerated]
	private Color? eH7()
	{
		return mbg.HighlightingStyleRegistry[cT.LineNumbers]?.Foreground;
	}

	[CompilerGenerated]
	private Color? PHi()
	{
		return mbg.HighlightingStyleRegistry[cT.PlainText]?.Background;
	}

	[CompilerGenerated]
	private Color? nHp()
	{
		return mbg.HighlightingStyleRegistry[cT.OutliningMarginSquare]?.Background;
	}

	[CompilerGenerated]
	private Color? QHM()
	{
		return mbg.HighlightingStyleRegistry[cT.PlainText]?.Background;
	}

	[CompilerGenerated]
	private Color? fHO()
	{
		return mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Background;
	}

	[CompilerGenerated]
	private Color? lHU()
	{
		return mbg.HighlightingStyleRegistry[cT.IndicatorMargin]?.Foreground;
	}

	[CompilerGenerated]
	private Color? gHJ()
	{
		return mbg.HighlightingStyleRegistry[cT.SelectedText]?.Background;
	}

	[CompilerGenerated]
	private Color? XHt()
	{
		return mbg.HighlightingStyleRegistry[cT.PlainText]?.Background;
	}

	[CompilerGenerated]
	private Color? BHZ()
	{
		return mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground;
	}

	[CompilerGenerated]
	private Color? OHh()
	{
		return mbg.HighlightingStyleRegistry[cT.PlainText]?.Background;
	}

	[CompilerGenerated]
	private Color? hHN()
	{
		return mbg.HighlightingStyleRegistry[cT.VisibleWhitespace]?.Foreground;
	}

	internal static bool eWk()
	{
		return OWS == null;
	}

	internal static TextViewDrawContext uWZ()
	{
		return OWS;
	}
}
