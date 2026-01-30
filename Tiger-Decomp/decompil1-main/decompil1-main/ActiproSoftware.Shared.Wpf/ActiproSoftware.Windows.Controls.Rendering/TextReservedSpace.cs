using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Rendering;

internal class TextReservedSpace : TextEmbeddedObject
{
	private class pE : TextRunProperties
	{
		private BaselineAlignment YH6;

		private TextRunProperties JHV;

		private static pE m6n;

		public override Brush BackgroundBrush => JHV.BackgroundBrush;

		public override BaselineAlignment BaselineAlignment => YH6;

		public override CultureInfo CultureInfo => JHV.CultureInfo;

		public override double FontHintingEmSize => JHV.FontHintingEmSize;

		public override double FontRenderingEmSize => JHV.FontRenderingEmSize;

		public override Brush ForegroundBrush => JHV.ForegroundBrush;

		public override TextDecorationCollection TextDecorations => JHV.TextDecorations;

		public override TextEffectCollection TextEffects => JHV.TextEffects;

		public override Typeface Typeface => JHV.Typeface;

		public pE(TextRunProperties P_0, BaselineAlignment P_1)
		{
			hHEYokUTtehNq5ji0d.LrmWXz();
			base._002Ector();
			JHV = P_0;
			YH6 = P_1;
		}

		internal static bool Y60()
		{
			return m6n == null;
		}

		internal static pE f6b()
		{
			return m6n;
		}
	}

	private double OIr;

	private TextRunProperties zIZ;

	private Size sIn;

	internal static TextReservedSpace M0t;

	public override LineBreakCondition BreakAfter => LineBreakCondition.BreakPossible;

	public override LineBreakCondition BreakBefore => LineBreakCondition.BreakPossible;

	public override CharacterBufferReference CharacterBufferReference => new CharacterBufferReference(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117070), 1);

	public override bool HasFixedSize => true;

	public override int Length => 1;

	public override TextRunProperties Properties => zIZ;

	public TextReservedSpace(Size size, double baseline, TextRunProperties defaultProperties)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		sIn = size;
		OIr = (double.IsNaN(baseline) ? size.Height : baseline);
		zIZ = new pE(defaultProperties, BaselineAlignment.Baseline);
	}

	public override Rect ComputeBoundingBox(bool rightToLeft, bool sideways)
	{
		return new Rect(0.0, 0.0, sIn.Width, sIn.Height);
	}

	public override void Draw(DrawingContext drawingContext, Point origin, bool rightToLeft, bool sideways)
	{
	}

	public override TextEmbeddedObjectMetrics Format(double remainingParagraphWidth)
	{
		return new TextEmbeddedObjectMetrics(sIn.Width, sIn.Height, OIr);
	}

	internal static bool z0f()
	{
		return M0t == null;
	}

	internal static TextReservedSpace G07()
	{
		return M0t;
	}
}
