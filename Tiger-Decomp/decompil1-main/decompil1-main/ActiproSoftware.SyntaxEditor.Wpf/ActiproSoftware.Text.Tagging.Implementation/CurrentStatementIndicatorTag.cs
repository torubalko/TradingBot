using System;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class CurrentStatementIndicatorTag : IndicatorClassificationTagBase
{
	private static CurrentStatementIndicatorTag F59;

	public override IClassificationType ClassificationType => cT.CurrentStatement;

	public override void DrawGlyph(TextViewDrawContext context, ITextViewLine viewLine, TagSnapshotRange<IIndicatorTag> tagRange, Rect bounds)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Point location = GetLocation(bounds);
		Color color = Color.FromArgb(96, byte.MaxValue, byte.MaxValue, byte.MaxValue);
		Color color2 = Color.FromArgb(byte.MaxValue, 82, 78, 65);
		Color color3 = Color.FromArgb(byte.MaxValue, byte.MaxValue, 216, 56);
		int num = 3;
		int num2 = 3;
		PathGeometry pathGeometry = new PathGeometry();
		pathGeometry.Figures.Add(new PathFigure(new Point(0.5, 2.5), new PathSegment[8]
		{
			new LineSegment(new Point(4.5, 2.5), isStroked: true),
			new LineSegment(new Point(4.5, 0.5), isStroked: true),
			new LineSegment(new Point(6.75, 0.5), isStroked: true),
			new LineSegment(new Point(12.0, 5.5), isStroked: true),
			new LineSegment(new Point(6.75, 10.5), isStroked: true),
			new LineSegment(new Point(4.5, 10.5), isStroked: true),
			new LineSegment(new Point(4.5, 8.5), isStroked: true),
			new LineSegment(new Point(0.5, 8.5), isStroked: true)
		}, closed: true));
		PathGeometry geometry = pathGeometry;
		context.DrawGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color, LineKind.Solid, 1f);
		num = 4;
		num2 = 4;
		pathGeometry = new PathGeometry();
		pathGeometry.Figures.Add(new PathFigure(new Point(0.5, 2.5), new PathSegment[8]
		{
			new LineSegment(new Point(4.5, 2.5), isStroked: true),
			new LineSegment(new Point(4.5, 0.5), isStroked: true),
			new LineSegment(new Point(5.5, 0.5), isStroked: true),
			new LineSegment(new Point(9.5, 4.5), isStroked: true),
			new LineSegment(new Point(5.5, 8.5), isStroked: true),
			new LineSegment(new Point(4.5, 8.5), isStroked: true),
			new LineSegment(new Point(4.5, 6.5), isStroked: true),
			new LineSegment(new Point(0.5, 6.5), isStroked: true)
		}, closed: true));
		geometry = pathGeometry;
		context.FillGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color3);
		context.DrawGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color2, LineKind.Solid, 1f);
	}

	public CurrentStatementIndicatorTag()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool R5J()
	{
		return F59 == null;
	}

	internal static CurrentStatementIndicatorTag w5R()
	{
		return F59;
	}
}
