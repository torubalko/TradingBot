using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ActiproSoftware.Windows.Data;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls.Primitives;

[ToolboxItem(false)]
public abstract class BulletChrome : ChromeBase
{
	private static readonly DependencyPropertyKey EIP;

	public static readonly DependencyProperty BackgroundProperty;

	public static readonly DependencyProperty BackgroundCheckedProperty;

	public static readonly DependencyProperty BackgroundCheckedHoverProperty;

	public static readonly DependencyProperty BackgroundCheckedPressedProperty;

	public static readonly DependencyProperty BackgroundDisabledProperty;

	public static readonly DependencyProperty BackgroundHoverProperty;

	public static readonly DependencyProperty BackgroundPressedProperty;

	public static readonly DependencyProperty BorderBrushProperty;

	public static readonly DependencyProperty BorderBrushCheckedProperty;

	public static readonly DependencyProperty BorderBrushCheckedHoverProperty;

	public static readonly DependencyProperty BorderBrushCheckedPressedProperty;

	public static readonly DependencyProperty BorderBrushDisabledProperty;

	public static readonly DependencyProperty BorderBrushHoverProperty;

	public static readonly DependencyProperty BorderBrushPressedProperty;

	public static readonly DependencyProperty BorderStyleProperty;

	public static readonly DependencyProperty BorderWidthProperty;

	public static readonly DependencyProperty GlyphBackgroundCheckedProperty;

	public static readonly DependencyProperty GlyphBackgroundCheckedDisabledProperty;

	public static readonly DependencyProperty GlyphBackgroundCheckedHoverProperty;

	public static readonly DependencyProperty GlyphBackgroundCheckedPressedProperty;

	public static readonly DependencyProperty GlyphBorderBrushCheckedProperty;

	public static readonly DependencyProperty GlyphBorderBrushCheckedDisabledProperty;

	public static readonly DependencyProperty GlyphBackgroundIndeterminateProperty;

	public static readonly DependencyProperty GlyphBackgroundIndeterminateDisabledProperty;

	public static readonly DependencyProperty GlyphBackgroundIndeterminateHoverProperty;

	public static readonly DependencyProperty GlyphBackgroundIndeterminatePressedProperty;

	public static readonly DependencyProperty GlyphBorderBrushIndeterminateProperty;

	public static readonly DependencyProperty GlyphBorderBrushIndeterminateDisabledProperty;

	public static readonly DependencyProperty GlyphBorderBrushIndeterminateHoverProperty;

	public static readonly DependencyProperty GlyphBorderBrushIndeterminatePressedProperty;

	public static readonly DependencyProperty InnerBackgroundProperty;

	public static readonly DependencyProperty InnerBackgroundDisabledProperty;

	public static readonly DependencyProperty InnerBackgroundHoverProperty;

	public static readonly DependencyProperty InnerBackgroundPressedProperty;

	public static readonly DependencyProperty InnerBorderBrushProperty;

	public static readonly DependencyProperty InnerBorderBrushDisabledProperty;

	public static readonly DependencyProperty InnerBorderBrushHoverProperty;

	public static readonly DependencyProperty InnerBorderBrushPressedProperty;

	public static readonly DependencyProperty IsCheckedProperty;

	public static readonly DependencyProperty LastStateProperty;

	public static readonly DependencyProperty RelativeSizeProperty;

	public static readonly DependencyProperty StateProperty;

	private static readonly DependencyProperty eIG;

	private static readonly DependencyProperty eI1;

	public static readonly DependencyProperty UseAlternateGeometryProperty;

	internal static BulletChrome n0x;

	private double StateHoverOpacity => (double)GetValue(eIG);

	private double StatePressedOpacity => (double)GetValue(eI1);

	public Brush Background
	{
		get
		{
			return (Brush)GetValue(BackgroundProperty);
		}
		set
		{
			SetValue(BackgroundProperty, value);
		}
	}

	public Brush BackgroundChecked
	{
		get
		{
			return (Brush)GetValue(BackgroundCheckedProperty);
		}
		set
		{
			SetValue(BackgroundCheckedProperty, value);
		}
	}

	public Brush BackgroundCheckedHover
	{
		get
		{
			return (Brush)GetValue(BackgroundCheckedHoverProperty);
		}
		set
		{
			SetValue(BackgroundCheckedHoverProperty, value);
		}
	}

	public Brush BackgroundCheckedPressed
	{
		get
		{
			return (Brush)GetValue(BackgroundCheckedPressedProperty);
		}
		set
		{
			SetValue(BackgroundCheckedPressedProperty, value);
		}
	}

	public Brush BackgroundDisabled
	{
		get
		{
			return (Brush)GetValue(BackgroundDisabledProperty);
		}
		set
		{
			SetValue(BackgroundDisabledProperty, value);
		}
	}

	public Brush BackgroundHover
	{
		get
		{
			return (Brush)GetValue(BackgroundHoverProperty);
		}
		set
		{
			SetValue(BackgroundHoverProperty, value);
		}
	}

	public Brush BackgroundPressed
	{
		get
		{
			return (Brush)GetValue(BackgroundPressedProperty);
		}
		set
		{
			SetValue(BackgroundPressedProperty, value);
		}
	}

	public Brush BorderBrush
	{
		get
		{
			return (Brush)GetValue(BorderBrushProperty);
		}
		set
		{
			SetValue(BorderBrushProperty, value);
		}
	}

	public Brush BorderBrushChecked
	{
		get
		{
			return (Brush)GetValue(BorderBrushCheckedProperty);
		}
		set
		{
			SetValue(BorderBrushCheckedProperty, value);
		}
	}

	public Brush BorderBrushCheckedHover
	{
		get
		{
			return (Brush)GetValue(BorderBrushCheckedHoverProperty);
		}
		set
		{
			SetValue(BorderBrushCheckedHoverProperty, value);
		}
	}

	public Brush BorderBrushCheckedPressed
	{
		get
		{
			return (Brush)GetValue(BorderBrushCheckedPressedProperty);
		}
		set
		{
			SetValue(BorderBrushCheckedPressedProperty, value);
		}
	}

	public Brush BorderBrushDisabled
	{
		get
		{
			return (Brush)GetValue(BorderBrushDisabledProperty);
		}
		set
		{
			SetValue(BorderBrushDisabledProperty, value);
		}
	}

	public Brush BorderBrushHover
	{
		get
		{
			return (Brush)GetValue(BorderBrushHoverProperty);
		}
		set
		{
			SetValue(BorderBrushHoverProperty, value);
		}
	}

	public Brush BorderBrushPressed
	{
		get
		{
			return (Brush)GetValue(BorderBrushPressedProperty);
		}
		set
		{
			SetValue(BorderBrushPressedProperty, value);
		}
	}

	public BulletChromeBorderStyle BorderStyle
	{
		get
		{
			return (BulletChromeBorderStyle)GetValue(BorderStyleProperty);
		}
		set
		{
			SetValue(BorderStyleProperty, value);
		}
	}

	public double BorderWidth
	{
		get
		{
			return (double)GetValue(BorderWidthProperty);
		}
		set
		{
			SetValue(BorderWidthProperty, value);
		}
	}

	public Brush GlyphBackgroundChecked
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundCheckedProperty);
		}
		set
		{
			SetValue(GlyphBackgroundCheckedProperty, value);
		}
	}

	public Brush GlyphBackgroundCheckedDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundCheckedDisabledProperty);
		}
		set
		{
			SetValue(GlyphBackgroundCheckedDisabledProperty, value);
		}
	}

	public Brush GlyphBackgroundCheckedHover
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundCheckedHoverProperty);
		}
		set
		{
			SetValue(GlyphBackgroundCheckedHoverProperty, value);
		}
	}

	public Brush GlyphBackgroundCheckedPressed
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundCheckedPressedProperty);
		}
		set
		{
			SetValue(GlyphBackgroundCheckedPressedProperty, value);
		}
	}

	public Brush GlyphBorderBrushChecked
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushCheckedProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushCheckedProperty, value);
		}
	}

	public Brush GlyphBorderBrushCheckedDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushCheckedDisabledProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushCheckedDisabledProperty, value);
		}
	}

	public Brush GlyphBackgroundIndeterminate
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundIndeterminateProperty);
		}
		set
		{
			SetValue(GlyphBackgroundIndeterminateProperty, value);
		}
	}

	public Brush GlyphBackgroundIndeterminateDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundIndeterminateDisabledProperty);
		}
		set
		{
			SetValue(GlyphBackgroundIndeterminateDisabledProperty, value);
		}
	}

	public Brush GlyphBackgroundIndeterminateHover
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundIndeterminateHoverProperty);
		}
		set
		{
			SetValue(GlyphBackgroundIndeterminateHoverProperty, value);
		}
	}

	public Brush GlyphBackgroundIndeterminatePressed
	{
		get
		{
			return (Brush)GetValue(GlyphBackgroundIndeterminatePressedProperty);
		}
		set
		{
			SetValue(GlyphBackgroundIndeterminatePressedProperty, value);
		}
	}

	public Brush GlyphBorderBrushIndeterminate
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushIndeterminateProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushIndeterminateProperty, value);
		}
	}

	public Brush GlyphBorderBrushIndeterminateDisabled
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushIndeterminateDisabledProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushIndeterminateDisabledProperty, value);
		}
	}

	public Brush GlyphBorderBrushIndeterminateHover
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushIndeterminateHoverProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushIndeterminateHoverProperty, value);
		}
	}

	public Brush GlyphBorderBrushIndeterminatePressed
	{
		get
		{
			return (Brush)GetValue(GlyphBorderBrushIndeterminatePressedProperty);
		}
		set
		{
			SetValue(GlyphBorderBrushIndeterminatePressedProperty, value);
		}
	}

	public Brush InnerBackground
	{
		get
		{
			return (Brush)GetValue(InnerBackgroundProperty);
		}
		set
		{
			SetValue(InnerBackgroundProperty, value);
		}
	}

	public Brush InnerBackgroundDisabled
	{
		get
		{
			return (Brush)GetValue(InnerBackgroundDisabledProperty);
		}
		set
		{
			SetValue(InnerBackgroundDisabledProperty, value);
		}
	}

	public Brush InnerBackgroundHover
	{
		get
		{
			return (Brush)GetValue(InnerBackgroundHoverProperty);
		}
		set
		{
			SetValue(InnerBackgroundHoverProperty, value);
		}
	}

	public Brush InnerBackgroundPressed
	{
		get
		{
			return (Brush)GetValue(InnerBackgroundPressedProperty);
		}
		set
		{
			SetValue(InnerBackgroundPressedProperty, value);
		}
	}

	public Brush InnerBorderBrush
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushProperty);
		}
		set
		{
			SetValue(InnerBorderBrushProperty, value);
		}
	}

	public Brush InnerBorderBrushDisabled
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushDisabledProperty);
		}
		set
		{
			SetValue(InnerBorderBrushDisabledProperty, value);
		}
	}

	public Brush InnerBorderBrushHover
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushHoverProperty);
		}
		set
		{
			SetValue(InnerBorderBrushHoverProperty, value);
		}
	}

	public Brush InnerBorderBrushPressed
	{
		get
		{
			return (Brush)GetValue(InnerBorderBrushPressedProperty);
		}
		set
		{
			SetValue(InnerBorderBrushPressedProperty, value);
		}
	}

	public bool? IsChecked
	{
		get
		{
			return (bool?)GetValue(IsCheckedProperty);
		}
		set
		{
			SetValue(IsCheckedProperty, value);
		}
	}

	public BulletChromeState LastState
	{
		get
		{
			return (BulletChromeState)GetValue(LastStateProperty);
		}
		private set
		{
			SetValue(EIP, value);
		}
	}

	public BulletChromeRelativeSize RelativeSize
	{
		get
		{
			return (BulletChromeRelativeSize)GetValue(RelativeSizeProperty);
		}
		set
		{
			SetValue(RelativeSizeProperty, value);
		}
	}

	public BulletChromeState State
	{
		get
		{
			return (BulletChromeState)GetValue(StateProperty);
		}
		set
		{
			SetValue(StateProperty, value);
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

	internal Brush GetBackgroundForState(BulletChromeState state, bool? isChecked)
	{
		bool flag = !false.Equals(IsChecked);
		return state switch
		{
			BulletChromeState.Disabled => BackgroundDisabled, 
			BulletChromeState.Hover => (flag ? BackgroundCheckedHover : null) ?? BackgroundHover, 
			BulletChromeState.Pressed => (flag ? BackgroundCheckedPressed : null) ?? BackgroundPressed, 
			_ => (flag ? BackgroundChecked : null) ?? Background, 
		};
	}

	internal Brush GetBorderBrushForState(BulletChromeState state, bool? isChecked)
	{
		bool flag = !false.Equals(IsChecked);
		return state switch
		{
			BulletChromeState.Disabled => BorderBrushDisabled, 
			BulletChromeState.Hover => (flag ? BorderBrushCheckedHover : null) ?? BorderBrushHover, 
			BulletChromeState.Pressed => (flag ? BorderBrushCheckedPressed : null) ?? BorderBrushPressed, 
			_ => (flag ? BorderBrushChecked : null) ?? BorderBrush, 
		};
	}

	internal Brush GetGlyphBackgroundForState(BulletChromeState state, bool? isChecked)
	{
		if (!isChecked.HasValue)
		{
			return state switch
			{
				BulletChromeState.Disabled => GlyphBackgroundIndeterminateDisabled, 
				BulletChromeState.Hover => GlyphBackgroundIndeterminateHover, 
				BulletChromeState.Pressed => GlyphBackgroundIndeterminatePressed, 
				_ => GlyphBackgroundIndeterminate, 
			};
		}
		return state switch
		{
			BulletChromeState.Disabled => GlyphBackgroundCheckedDisabled, 
			BulletChromeState.Hover => GlyphBackgroundCheckedHover, 
			BulletChromeState.Pressed => GlyphBackgroundCheckedPressed, 
			_ => GlyphBackgroundChecked, 
		};
	}

	internal Brush GetGlyphBorderBrushForState(BulletChromeState state, bool? isChecked)
	{
		if (!isChecked.HasValue)
		{
			return state switch
			{
				BulletChromeState.Disabled => GlyphBorderBrushIndeterminateDisabled, 
				BulletChromeState.Hover => GlyphBorderBrushIndeterminateHover, 
				BulletChromeState.Pressed => GlyphBorderBrushIndeterminatePressed, 
				_ => GlyphBorderBrushIndeterminate, 
			};
		}
		if (state == BulletChromeState.Disabled)
		{
			return GlyphBorderBrushCheckedDisabled;
		}
		return GlyphBorderBrushChecked;
	}

	internal Brush GetInnerBackgroundForState(BulletChromeState state)
	{
		return state switch
		{
			BulletChromeState.Pressed => InnerBackgroundPressed, 
			BulletChromeState.Hover => InnerBackgroundHover, 
			BulletChromeState.Disabled => InnerBackgroundDisabled, 
			_ => InnerBackground, 
		};
	}

	internal Brush GetInnerBorderBrushForState(BulletChromeState state)
	{
		return state switch
		{
			BulletChromeState.Disabled => InnerBorderBrushDisabled, 
			BulletChromeState.Hover => InnerBorderBrushHover, 
			BulletChromeState.Pressed => InnerBorderBrushPressed, 
			_ => InnerBorderBrush, 
		};
	}

	internal double GetOpacityForState(BulletChromeState state)
	{
		return state switch
		{
			BulletChromeState.Hover => StateHoverOpacity, 
			BulletChromeState.Pressed => StatePressedOpacity, 
			_ => 1.0, 
		};
	}

	private static void KIK(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is BulletChrome bulletChrome))
		{
			return;
		}
		BulletChromeState value = (BulletChromeState)P_1.OldValue;
		bulletChrome.LastState = value;
		if (!bulletChrome.IsAnimationEnabledResolved)
		{
			bulletChrome.InvalidateVisual();
			return;
		}
		switch ((BulletChromeState)P_1.NewValue)
		{
		default:
			bulletChrome.InvalidateVisual();
			return;
		case BulletChromeState.Disabled:
			bulletChrome.BeginAnimation(eIG, null);
			bulletChrome.BeginAnimation(eI1, null);
			return;
		case BulletChromeState.Hover:
		{
			Duration duration2 = new Duration(TimeSpan.FromSeconds(0.3));
			bulletChrome.BeginAnimation(eI1, new DoubleAnimation
			{
				Duration = duration2
			});
			bulletChrome.BeginAnimation(eIG, new DoubleAnimation
			{
				To = 1.0,
				Duration = duration2
			});
			return;
		}
		case BulletChromeState.Normal:
			break;
		case BulletChromeState.Pressed:
			{
				Duration duration = new Duration(TimeSpan.FromSeconds(0.1));
				int num = 2;
				if (c0B() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					goto end_IL_0099;
				case 2:
					bulletChrome.BeginAnimation(eIG, new DoubleAnimation
					{
						Duration = duration
					});
					bulletChrome.BeginAnimation(eI1, new DoubleAnimation
					{
						To = 1.0,
						Duration = duration
					});
					return;
				}
				goto default;
			}
			end_IL_0099:
			break;
		}
		Duration duration3 = new Duration(TimeSpan.FromSeconds(0.2));
		bulletChrome.BeginAnimation(eIG, new DoubleAnimation
		{
			Duration = duration3
		});
		bulletChrome.BeginAnimation(eI1, new DoubleAnimation
		{
			Duration = duration3
		});
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		Rect bounds = new Rect(0.0, 0.0, base.ActualWidth, base.ActualHeight);
		if (bounds.Width != 0.0 && bounds.Height != 0.0)
		{
			RenderBackground(drawingContext, bounds);
			switch (BorderStyle)
			{
			case BulletChromeBorderStyle.Sunken:
				RenderClassicSunkenBorder(drawingContext, bounds);
				break;
			default:
				RenderInnerBackground(drawingContext, bounds);
				RenderInnerBorder(drawingContext, bounds);
				RenderBorder(drawingContext, bounds);
				break;
			case BulletChromeBorderStyle.None:
				break;
			}
			RenderGlyph(drawingContext, bounds);
		}
	}

	protected abstract void RenderBackground(DrawingContext drawingContext, Rect bounds);

	protected abstract void RenderBorder(DrawingContext drawingContext, Rect bounds);

	protected abstract void RenderClassicSunkenBorder(DrawingContext drawingContext, Rect bounds);

	protected abstract void RenderGlyph(DrawingContext drawingContext, Rect bounds);

	protected abstract void RenderInnerBackground(DrawingContext drawingContext, Rect bounds);

	protected abstract void RenderInnerBorder(DrawingContext drawingContext, Rect bounds);

	protected BulletChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static BulletChrome()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		EIP = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117922), typeof(BulletChromeState), typeof(BulletChrome), new FrameworkPropertyMetadata(BulletChromeState.Normal));
		BackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117944), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(117968), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundCheckedHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118006), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundCheckedPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118054), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118106), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118146), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BackgroundPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118180), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118218), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118244), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushCheckedHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118284), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushCheckedPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118334), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118388), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118430), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderBrushPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118466), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderStyleProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118506), typeof(BulletChromeBorderStyle), typeof(BulletChrome), new FrameworkPropertyMetadata(BulletChromeBorderStyle.Default, FrameworkPropertyMetadataOptions.AffectsRender));
		BorderWidthProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118532), typeof(double), typeof(BulletChrome), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118558), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundCheckedDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118606), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundCheckedHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118670), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundCheckedPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118728), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118790), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushCheckedDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118840), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundIndeterminateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118906), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundIndeterminateDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(118966), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundIndeterminateHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119042), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBackgroundIndeterminatePressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119112), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushIndeterminateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119186), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushIndeterminateDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119248), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushIndeterminateHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119326), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		GlyphBorderBrushIndeterminatePressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119398), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119474), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBackgroundDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119508), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBackgroundHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119558), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBackgroundPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119602), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119650), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushDisabledProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119686), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushHoverProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119738), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		InnerBorderBrushPressedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119784), typeof(Brush), typeof(BulletChrome), new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));
		IsCheckedProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119834), typeof(bool?), typeof(BulletChrome), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));
		LastStateProperty = EIP.DependencyProperty;
		RelativeSizeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119856), typeof(BulletChromeRelativeSize), typeof(BulletChrome), new FrameworkPropertyMetadata(BulletChromeRelativeSize.Small, FrameworkPropertyMetadataOptions.AffectsMeasure));
		StateProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97386), typeof(BulletChromeState), typeof(BulletChrome), new FrameworkPropertyMetadata(BulletChromeState.Normal, FrameworkPropertyMetadataOptions.AffectsRender, KIK));
		eIG = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119884), typeof(double), typeof(BulletChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		eI1 = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119922), typeof(double), typeof(BulletChrome), new FrameworkPropertyMetadata(0.0, FrameworkPropertyMetadataOptions.AffectsRender), (object o) => ValidationHelper.ValidateDoubleIsBetweenInclusive(o, 0.0, 1.0));
		UseAlternateGeometryProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(119964), typeof(bool), typeof(BulletChrome), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.AffectsRender));
	}

	internal static bool w0S()
	{
		return n0x == null;
	}

	internal static BulletChrome c0B()
	{
		return n0x;
	}
}
