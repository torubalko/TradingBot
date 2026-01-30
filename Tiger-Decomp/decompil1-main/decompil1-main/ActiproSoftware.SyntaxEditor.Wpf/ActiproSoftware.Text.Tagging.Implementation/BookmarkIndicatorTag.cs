using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.Rendering;
using ActiproSoftware.Windows.Controls.SyntaxEditor;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Implementation;

namespace ActiproSoftware.Text.Tagging.Implementation;

public class BookmarkIndicatorTag : IndicatorTagBase, INotifyPropertyChanged
{
	private bool H8p;

	private static BookmarkIndicatorTag p5q;

	public bool IsEnabled
	{
		get
		{
			return H8p;
		}
		set
		{
			if (H8p != value)
			{
				H8p = value;
				NotifyPropertyChanged(Q7Z.tqM(197946));
			}
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	protected void NotifyPropertyChanged(string propertyName)
	{
		OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
	}

	protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
	{
		this.PropertyChanged?.Invoke(this, e);
	}

	public override void DrawGlyph(TextViewDrawContext context, ITextViewLine viewLine, TagSnapshotRange<IIndicatorTag> tagRange, Rect bounds)
	{
		if (context == null)
		{
			throw new ArgumentNullException(Q7Z.tqM(7756));
		}
		Point location = GetLocation(bounds);
		Color color = Color.FromArgb(byte.MaxValue, 246, 246, 246);
		Color color2 = Color.FromArgb(byte.MaxValue, 66, 66, 66);
		Color color3 = Color.FromArgb(byte.MaxValue, 192, 192, 192);
		if (!IsEnabled)
		{
			int num = 5;
			int num2 = 2;
			PathGeometry pathGeometry = new PathGeometry();
			pathGeometry.Figures.Add(new PathFigure(new Point(0.5, 0.5), new PathSegment[4]
			{
				new LineSegment(new Point(6.5, 0.5), isStroked: true),
				new LineSegment(new Point(6.5, 12.5), isStroked: true),
				new LineSegment(new Point(3.5, 10.5), isStroked: true),
				new LineSegment(new Point(0.5, 12.5), isStroked: true)
			}, closed: true));
			PathGeometry geometry = pathGeometry;
			context.FillGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color2);
			context.DrawGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color, LineKind.Solid, 1f);
			num = 7;
			num2 = 4;
			pathGeometry = new PathGeometry();
			pathGeometry.Figures.Add(new PathFigure(new Point(0.0, 0.0), new PathSegment[4]
			{
				new LineSegment(new Point(3.0, 0.0), isStroked: true),
				new LineSegment(new Point(3.0, 8.0), isStroked: true),
				new LineSegment(new Point(1.5, 6.5), isStroked: true),
				new LineSegment(new Point(0.0, 8.0), isStroked: true)
			}, closed: true));
			geometry = pathGeometry;
			context.FillGeometry(new Point(location.X + (double)num, location.Y + (double)num2), geometry, color3);
		}
		else
		{
			int num3 = 3;
			int num4 = 1;
			PathGeometry pathGeometry = new PathGeometry();
			pathGeometry.Figures.Add(new PathFigure(new Point(0.5, 0.5), new PathSegment[4]
			{
				new LineSegment(new Point(10.5, 0.5), isStroked: true),
				new LineSegment(new Point(10.5, 14.5), isStroked: true),
				new LineSegment(new Point(5.5, 11.5), isStroked: true),
				new LineSegment(new Point(0.5, 14.5), isStroked: true)
			}, closed: true));
			PathGeometry geometry2 = pathGeometry;
			context.FillGeometry(new Point(location.X + (double)num3, location.Y + (double)num4), geometry2, color2);
			context.DrawGeometry(new Point(location.X + (double)num3, location.Y + (double)num4), geometry2, color, LineKind.Solid, 1f);
		}
	}

	public BookmarkIndicatorTag()
	{
		grA.DaB7cz();
		H8p = true;
		base._002Ector();
	}

	internal static bool G5x()
	{
		return p5q == null;
	}

	internal static BookmarkIndicatorTag Y5a()
	{
		return p5q;
	}
}
