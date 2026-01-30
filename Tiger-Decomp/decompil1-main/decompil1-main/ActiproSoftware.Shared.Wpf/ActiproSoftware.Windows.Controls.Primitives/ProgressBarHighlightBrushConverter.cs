using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

public class ProgressBarHighlightBrushConverter : IMultiValueConverter
{
	private static ProgressBarHighlightBrushConverter Nb1;

	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || 3 != values.Length || values[0] == null || values[1] == null || values[2] == null || !typeof(Brush).IsAssignableFrom(values[0].GetType()) || !typeof(double).IsAssignableFrom(values[1].GetType()) || !typeof(double).IsAssignableFrom(values[2].GetType()))
		{
			return null;
		}
		Brush brush = (Brush)values[0];
		double num = (double)values[1];
		double num2 = (double)values[2];
		if (num <= 0.0 || double.IsInfinity(num) || double.IsNaN(num) || num2 <= 0.0 || double.IsInfinity(num2) || double.IsNaN(num2))
		{
			return null;
		}
		double num3 = num * 2.0;
		DrawingBrush drawingBrush = new DrawingBrush();
		Rect viewport = (drawingBrush.Viewbox = new Rect(0.0 - num, 0.0, num3, num2));
		drawingBrush.Viewport = viewport;
		BrushMappingMode viewportUnits = (drawingBrush.ViewboxUnits = BrushMappingMode.Absolute);
		drawingBrush.ViewportUnits = viewportUnits;
		drawingBrush.TileMode = TileMode.None;
		drawingBrush.Stretch = Stretch.None;
		DrawingGroup drawingGroup = new DrawingGroup();
		DrawingContext drawingContext = drawingGroup.Open();
		try
		{
			drawingContext.DrawRectangle(brush, null, new Rect(0.0 - num, 0.0, num, num2));
			TimeSpan timeSpan = TimeSpan.FromSeconds(1.5);
			DoubleAnimationUsingKeyFrames animation = new DoubleAnimationUsingKeyFrames
			{
				BeginTime = TimeSpan.Zero,
				Duration = new Duration(timeSpan + TimeSpan.FromSeconds(0.5)),
				RepeatBehavior = RepeatBehavior.Forever,
				KeyFrames = { (DoubleKeyFrame)new LinearDoubleKeyFrame(num3, timeSpan) }
			};
			TranslateTransform translateTransform = new TranslateTransform();
			translateTransform.BeginAnimation(TranslateTransform.XProperty, animation);
			drawingBrush.Transform = translateTransform;
		}
		finally
		{
			drawingContext.Close();
		}
		drawingBrush.Drawing = drawingGroup;
		return drawingBrush;
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		return null;
	}

	public ProgressBarHighlightBrushConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Cbg()
	{
		return Nb1 == null;
	}

	internal static ProgressBarHighlightBrushConverter Eb8()
	{
		return Nb1;
	}
}
