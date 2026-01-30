using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Animation;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

public class ProgressBarSegmentedBrushConverter : IMultiValueConverter
{
	private static ProgressBarSegmentedBrushConverter Gbj;

	[SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		if (values == null || values.Length < 6 || values.Length > 7)
		{
			return null;
		}
		if (values[0] == null || values[1] == null || values[2] == null || values[3] == null || values[4] == null || values[5] == null || !typeof(bool).IsAssignableFrom(values[0].GetType()) || !typeof(Orientation).IsAssignableFrom(values[1].GetType()) || !typeof(double).IsAssignableFrom(values[2].GetType()) || !typeof(double).IsAssignableFrom(values[3].GetType()) || !typeof(double).IsAssignableFrom(values[4].GetType()) || !typeof(double).IsAssignableFrom(values[5].GetType()))
		{
			return null;
		}
		if (values.Length == 7 && (values[6] == null || !typeof(bool).IsAssignableFrom(values[6].GetType())))
		{
			return null;
		}
		bool flag = (bool)values[0];
		double num = (double)values[2];
		double num2 = (double)values[3];
		double num3 = (double)values[4];
		bool flag2 = values.Length == 7 && (bool)values[6];
		if (num <= 0.0 || double.IsInfinity(num) || double.IsNaN(num) || num2 <= 0.0 || double.IsInfinity(num2) || double.IsNaN(num2))
		{
			return null;
		}
		DrawingBrush drawingBrush = new DrawingBrush();
		Rect viewport = (drawingBrush.Viewbox = new Rect(0.0, 0.0, num, num2));
		drawingBrush.Viewport = viewport;
		BrushMappingMode viewportUnits = (drawingBrush.ViewboxUnits = BrushMappingMode.Absolute);
		drawingBrush.ViewportUnits = viewportUnits;
		drawingBrush.TileMode = TileMode.None;
		drawingBrush.Stretch = Stretch.None;
		DrawingGroup drawingGroup = new DrawingGroup();
		DrawingContext drawingContext = drawingGroup.Open();
		try
		{
			double num4 = 0.0;
			double num5 = 6.0;
			double num6 = num5 + 2.0;
			if (flag2)
			{
				double num7 = num * 0.3;
				double num8;
				DoubleAnimationUsingKeyFrames doubleAnimationUsingKeyFrames;
				if (flag)
				{
					num8 = 0.0 - num;
					viewport = (drawingBrush.Viewbox = new Rect(num8, 0.0, num7 - num8, num2));
					drawingBrush.Viewport = viewport;
					TimeSpan timeSpan = TimeSpan.FromMilliseconds(num3 / num6 * (17000.0 / Math.Max(num3, 300.0)));
					doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
					doubleAnimationUsingKeyFrames.Duration = new Duration(timeSpan);
					doubleAnimationUsingKeyFrames.RepeatBehavior = RepeatBehavior.Forever;
					doubleAnimationUsingKeyFrames.KeyFrames.Add(new LinearDoubleKeyFrame(num3, timeSpan));
				}
				else
				{
					int num9 = (int)Math.Ceiling(num / num6);
					num8 = (double)(-num9) * num6;
					viewport = (drawingBrush.Viewbox = new Rect(num8, 0.0, num7 - num8, num2));
					drawingBrush.Viewport = viewport;
					doubleAnimationUsingKeyFrames = new DoubleAnimationUsingKeyFrames();
					doubleAnimationUsingKeyFrames.Duration = new Duration(TimeSpan.FromMilliseconds((double)num9 * (17000.0 / Math.Max(num3, 300.0))));
					doubleAnimationUsingKeyFrames.RepeatBehavior = RepeatBehavior.Forever;
					for (int i = 1; i <= num9; i++)
					{
						doubleAnimationUsingKeyFrames.KeyFrames.Add(new DiscreteDoubleKeyFrame((double)i * num6, KeyTime.Uniform));
					}
				}
				TranslateTransform translateTransform = new TranslateTransform();
				translateTransform.BeginAnimation(TranslateTransform.XProperty, doubleAnimationUsingKeyFrames);
				drawingBrush.Transform = translateTransform;
				if (flag)
				{
					drawingContext.DrawRectangle(Brushes.Black, null, new Rect(num8 + num4, 0.0, num7, num2));
				}
				else
				{
					for (; num4 + num5 < num7; num4 += num6)
					{
						drawingContext.DrawRectangle(Brushes.Black, null, new Rect(num8 + num4, 0.0, num5, num2));
					}
				}
				num = num7;
				num4 = 0.0;
			}
			if (flag)
			{
				drawingContext.DrawRectangle(Brushes.Black, null, new Rect(0.0, 0.0, num, num2));
			}
			else
			{
				for (; num4 + num5 < num; num4 += num6)
				{
					drawingContext.DrawRectangle(Brushes.Black, null, new Rect(num4, 0.0, num5, num2));
				}
				double num10 = num - num4;
				if (!flag2 && num10 > 0.0 && Math.Abs(num - num3) < 1E-05)
				{
					drawingContext.DrawRectangle(Brushes.Black, null, new Rect(num4, 0.0, num10, num2));
				}
			}
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

	public ProgressBarSegmentedBrushConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool fbe()
	{
		return Gbj == null;
	}

	internal static ProgressBarSegmentedBrushConverter Gb6()
	{
		return Gbj;
	}
}
