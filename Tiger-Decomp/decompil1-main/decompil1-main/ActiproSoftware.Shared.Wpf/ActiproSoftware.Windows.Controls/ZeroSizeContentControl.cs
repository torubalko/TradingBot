using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class ZeroSizeContentControl : ContentControl
{
	private static readonly DependencyPropertyKey yCL;

	public static readonly DependencyProperty HasHeightProperty;

	public static readonly DependencyProperty HasWidthProperty;

	public static readonly DependencyProperty IdealSizeProperty;

	private static ZeroSizeContentControl pnq;

	public bool HasHeight
	{
		get
		{
			return (bool)GetValue(HasHeightProperty);
		}
		set
		{
			SetValue(HasHeightProperty, value);
		}
	}

	public bool HasWidth
	{
		get
		{
			return (bool)GetValue(HasWidthProperty);
		}
		set
		{
			SetValue(HasWidthProperty, value);
		}
	}

	public Size IdealSize
	{
		get
		{
			return (Size)GetValue(IdealSizeProperty);
		}
		private set
		{
			SetValue(yCL, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ZeroSizeContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		yCL = DependencyProperty.RegisterReadOnly(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116816), typeof(Size), typeof(ZeroSizeContentControl), new FrameworkPropertyMetadata(default(Size)));
		HasHeightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116838), typeof(bool), typeof(ZeroSizeContentControl), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsMeasure));
		HasWidthProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116860), typeof(bool), typeof(ZeroSizeContentControl), new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.AffectsMeasure));
		IdealSizeProperty = yCL.DependencyProperty;
		Control.IsTabStopProperty.OverrideMetadata(typeof(ZeroSizeContentControl), new FrameworkPropertyMetadata(false));
		UIElement.FocusableProperty.OverrideMetadata(typeof(ZeroSizeContentControl), new FrameworkPropertyMetadata(false));
	}

	public ZeroSizeContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public ZeroSizeContentControl(object content)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		base.Content = content;
	}

	protected override Size ArrangeOverride(Size arrangeBounds)
	{
		if (VisualChildrenCount > 0 && GetVisualChild(0) is UIElement uIElement)
		{
			Rect finalRect = new Rect(new Point(0.0, 0.0), IdealSize);
			HorizontalAlignment horizontalContentAlignment = base.HorizontalContentAlignment;
			HorizontalAlignment horizontalAlignment = horizontalContentAlignment;
			int num = 1;
			if (HnG())
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 1:
					switch (horizontalAlignment)
					{
					case HorizontalAlignment.Stretch:
						finalRect.Width = arrangeBounds.Width;
						break;
					case HorizontalAlignment.Center:
						finalRect.X = arrangeBounds.Width / 2.0 - IdealSize.Width / 2.0;
						break;
					case HorizontalAlignment.Right:
						finalRect.X = arrangeBounds.Width - IdealSize.Width;
						break;
					}
					goto case 2;
				case 2:
					switch (base.VerticalContentAlignment)
					{
					case VerticalAlignment.Stretch:
						finalRect.Height = arrangeBounds.Height;
						break;
					case VerticalAlignment.Center:
						finalRect.Y = arrangeBounds.Height / 2.0 - IdealSize.Height / 2.0;
						break;
					case VerticalAlignment.Bottom:
						finalRect.Y = arrangeBounds.Height - IdealSize.Height;
						num = 0;
						if (Lnn() != null)
						{
							num = num2;
						}
						continue;
					}
					break;
				}
				break;
			}
			uIElement.Arrange(finalRect);
		}
		return arrangeBounds;
	}

	protected override Size MeasureOverride(Size availableSize)
	{
		IdealSize = base.MeasureOverride(availableSize);
		return new Size(HasWidth ? IdealSize.Width : 0.0, HasHeight ? IdealSize.Height : 0.0);
	}

	internal static bool HnG()
	{
		return pnq == null;
	}

	internal static ZeroSizeContentControl Lnn()
	{
		return pnq;
	}
}
