using System.Windows;
using System.Windows.Controls;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class PixelSnapper : Decorator
{
	public static readonly DependencyProperty HorizontalRoundModeProperty;

	public static readonly DependencyProperty VerticalRoundModeProperty;

	private static PixelSnapper wGR;

	public RoundMode HorizontalRoundMode
	{
		get
		{
			return (RoundMode)GetValue(HorizontalRoundModeProperty);
		}
		set
		{
			SetValue(HorizontalRoundModeProperty, value);
		}
	}

	public RoundMode VerticalRoundMode
	{
		get
		{
			return (RoundMode)GetValue(VerticalRoundModeProperty);
		}
		set
		{
			SetValue(VerticalRoundModeProperty, value);
		}
	}

	protected override Size MeasureOverride(Size constraint)
	{
		if (Child != null)
		{
			Child.Measure(constraint);
			return new Size(MathHelper.Round(HorizontalRoundMode, Child.DesiredSize.Width), MathHelper.Round(VerticalRoundMode, Child.DesiredSize.Height));
		}
		return default(Size);
	}

	public PixelSnapper()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static PixelSnapper()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		HorizontalRoundModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114678), typeof(RoundMode), typeof(PixelSnapper), new FrameworkPropertyMetadata(RoundMode.Ceiling, FrameworkPropertyMetadataOptions.AffectsMeasure));
		VerticalRoundModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114720), typeof(RoundMode), typeof(PixelSnapper), new FrameworkPropertyMetadata(RoundMode.Ceiling, FrameworkPropertyMetadataOptions.AffectsMeasure));
	}

	internal static bool GG9()
	{
		return wGR == null;
	}

	internal static PixelSnapper mGc()
	{
		return wGR;
	}
}
