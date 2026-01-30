using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

[TemplateVisualState(Name = "Active", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Average", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Selected", GroupName = "CommonStates")]
[TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
[TemplatePart(Name = "PART_ForegroundGlyphContentPresenter", Type = typeof(ContentPresenter))]
public class RatingItem : ContentControl, IOrientedElement
{
	private ContentPresenter Bld;

	public static readonly DependencyProperty ActiveGlyphTemplateProperty;

	public static readonly DependencyProperty AverageGlyphTemplateProperty;

	public static readonly DependencyProperty ClipPercentageProperty;

	public static readonly DependencyProperty NormalGlyphTemplateProperty;

	public static readonly DependencyProperty OrientationProperty;

	public static readonly DependencyProperty SelectedGlyphTemplateProperty;

	public static readonly DependencyProperty StateProperty;

	private static RatingItem OrO;

	public DataTemplate ActiveGlyphTemplate
	{
		get
		{
			return (DataTemplate)GetValue(ActiveGlyphTemplateProperty);
		}
		set
		{
			SetValue(ActiveGlyphTemplateProperty, value);
		}
	}

	public DataTemplate AverageGlyphTemplate
	{
		get
		{
			return (DataTemplate)GetValue(AverageGlyphTemplateProperty);
		}
		set
		{
			SetValue(AverageGlyphTemplateProperty, value);
		}
	}

	public double ClipPercentage
	{
		get
		{
			return (double)GetValue(ClipPercentageProperty);
		}
		internal set
		{
			SetValue(ClipPercentageProperty, value);
		}
	}

	public DataTemplate NormalGlyphTemplate
	{
		get
		{
			return (DataTemplate)GetValue(NormalGlyphTemplateProperty);
		}
		set
		{
			SetValue(NormalGlyphTemplateProperty, value);
		}
	}

	public Orientation Orientation
	{
		get
		{
			return (Orientation)GetValue(OrientationProperty);
		}
		internal set
		{
			SetValue(OrientationProperty, value);
		}
	}

	public DataTemplate SelectedGlyphTemplate
	{
		get
		{
			return (DataTemplate)GetValue(SelectedGlyphTemplateProperty);
		}
		set
		{
			SetValue(SelectedGlyphTemplateProperty, value);
		}
	}

	public RatingItemState State
	{
		get
		{
			return (RatingItemState)GetValue(StateProperty);
		}
		internal set
		{
			SetValue(StateProperty, value);
		}
	}

	public RatingItem()
	{
		awj.QuEwGz();
		Bld = null;
		base._002Ector();
		base.DefaultStyleKey = typeof(RatingItem);
		base.SizeChanged += jlO;
	}

	[SpecialName]
	private ContentPresenter klD()
	{
		return Bld;
	}

	[SpecialName]
	private void IlG(ContentPresenter value)
	{
		Bld = value;
		IlI();
	}

	private static void xlo(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RatingItem ratingItem = (RatingItem)P_0;
		ratingItem.IlI();
	}

	private void jlO(object P_0, SizeChangedEventArgs P_1)
	{
		IlI();
	}

	private static void tlT(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		RatingItem ratingItem = (RatingItem)P_0;
		ratingItem.llb(_0020: true);
	}

	private void IlI()
	{
		if (Bld == null)
		{
			return;
		}
		int num = 1;
		if (!Crm())
		{
			goto IL_0005;
		}
		goto IL_0009;
		IL_0009:
		do
		{
			switch (num)
			{
			case 1:
			{
				double num2 = ClipPercentage;
				if (!double.IsNaN(num2))
				{
					num2 = Math.Max(0.0, Math.Min(1.0, num2));
					if (num2 == 1.0)
					{
						num2 = double.NaN;
					}
				}
				if (!double.IsNaN(num2))
				{
					if (Orientation != Orientation.Vertical)
					{
						Bld.Clip = new RectangleGeometry
						{
							Rect = new Rect(0.0, (1.0 - num2) * base.ActualHeight, base.ActualWidth, num2 * base.ActualHeight)
						};
					}
					else
					{
						Bld.Clip = new RectangleGeometry
						{
							Rect = new Rect(0.0, 0.0, num2 * base.ActualWidth, base.ActualHeight)
						};
					}
					return;
				}
				break;
			}
			default:
				Bld.Clip = null;
				return;
			}
			num = 0;
		}
		while (Crm());
		goto IL_0005;
		IL_0005:
		int num3 = default(int);
		num = num3;
		goto IL_0009;
	}

	private void llb(bool P_0)
	{
		switch (State)
		{
		case RatingItemState.Selected:
			VisualStateManager.GoToState(this, QdM.AR8(21938), P_0);
			break;
		default:
			VisualStateManager.GoToState(this, QdM.AR8(64), P_0);
			break;
		case RatingItemState.Average:
			VisualStateManager.GoToState(this, QdM.AR8(22432), P_0);
			break;
		case RatingItemState.Active:
			VisualStateManager.GoToState(this, QdM.AR8(22078), P_0);
			break;
		}
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		IlG(GetTemplateChild(QdM.AR8(22450)) as ContentPresenter);
		llb(_0020: false);
	}

	static RatingItem()
	{
		awj.QuEwGz();
		ActiveGlyphTemplateProperty = DependencyProperty.Register(QdM.AR8(22526), typeof(DataTemplate), typeof(RatingItem), new PropertyMetadata(null));
		AverageGlyphTemplateProperty = DependencyProperty.Register(QdM.AR8(22568), typeof(DataTemplate), typeof(RatingItem), new PropertyMetadata(null));
		ClipPercentageProperty = DependencyProperty.Register(QdM.AR8(22612), typeof(double), typeof(RatingItem), new PropertyMetadata(double.NaN, xlo));
		NormalGlyphTemplateProperty = DependencyProperty.Register(QdM.AR8(22644), typeof(DataTemplate), typeof(RatingItem), new PropertyMetadata(null));
		OrientationProperty = DependencyProperty.Register(QdM.AR8(22356), typeof(Orientation), typeof(RatingItem), new PropertyMetadata(Orientation.Vertical));
		SelectedGlyphTemplateProperty = DependencyProperty.Register(QdM.AR8(22686), typeof(DataTemplate), typeof(RatingItem), new PropertyMetadata(null));
		StateProperty = DependencyProperty.Register(QdM.AR8(22732), typeof(RatingItemState), typeof(RatingItem), new PropertyMetadata(RatingItemState.Normal, tlT));
	}

	internal static bool Crm()
	{
		return OrO == null;
	}

	internal static RatingItem ErP()
	{
		return OrO;
	}
}
