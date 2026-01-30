using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using ActiproSoftware.Windows.Interop;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[TemplatePart(Name = "PART_Presenter", Type = typeof(ContentPresenter))]
[TemplatePart(Name = "PART_Gripper", Type = typeof(Thumb))]
public class ResizableContentControl : ContentControl
{
	private Thumb DC9;

	private Point sCh;

	private Size PCm;

	private Point gCw;

	public static readonly DependencyProperty CanAutoSizeProperty;

	public static readonly DependencyProperty GripperBackgroundProperty;

	public static readonly DependencyProperty GripperForegroundProperty;

	public static readonly DependencyProperty ResizeModeProperty;

	public static readonly DependencyProperty UseAlternateScrollViewerStyleProperty;

	internal static ResizableContentControl aGV;

	public bool CanAutoSize
	{
		get
		{
			return (bool)GetValue(CanAutoSizeProperty);
		}
		set
		{
			SetValue(CanAutoSizeProperty, value);
		}
	}

	public Brush GripperBackground
	{
		get
		{
			return (Brush)GetValue(GripperBackgroundProperty);
		}
		set
		{
			SetValue(GripperBackgroundProperty, value);
		}
	}

	public Brush GripperForeground
	{
		get
		{
			return (Brush)GetValue(GripperForegroundProperty);
		}
		set
		{
			SetValue(GripperForegroundProperty, value);
		}
	}

	public ControlResizeMode ResizeMode
	{
		get
		{
			return (ControlResizeMode)GetValue(ResizeModeProperty);
		}
		set
		{
			SetValue(ResizeModeProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
	static ResizableContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CanAutoSizeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116306), typeof(bool), typeof(ResizableContentControl), new FrameworkPropertyMetadata(true));
		GripperBackgroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116332), typeof(Brush), typeof(ResizableContentControl), new FrameworkPropertyMetadata(Brushes.Transparent));
		GripperForegroundProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116370), typeof(Brush), typeof(ResizableContentControl), new FrameworkPropertyMetadata(new SolidColorBrush(Color.FromRgb(184, 180, 162))));
		ResizeModeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116408), typeof(ControlResizeMode), typeof(ResizableContentControl), new FrameworkPropertyMetadata(ControlResizeMode.Both));
		UseAlternateScrollViewerStyleProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116432), typeof(bool), typeof(ResizableContentControl), new FrameworkPropertyMetadata(false, fCf));
		Control.IsTabStopProperty.OverrideMetadata(typeof(ResizableContentControl), new FrameworkPropertyMetadata(false));
		FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(ResizableContentControl), new FrameworkPropertyMetadata(typeof(ResizableContentControl)));
		FrameworkElement.MinHeightProperty.OverrideMetadata(typeof(ResizableContentControl), new FrameworkPropertyMetadata(4.0));
		FrameworkElement.MinWidthProperty.OverrideMetadata(typeof(ResizableContentControl), new FrameworkPropertyMetadata(4.0));
		UIElement.FocusableProperty.OverrideMetadata(typeof(ResizableContentControl), new FrameworkPropertyMetadata(false));
	}

	public ResizableContentControl()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		sCh = new Point(1.0, 1.0);
		base._002Ector();
	}

	public ResizableContentControl(object content)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector();
		base.Content = content;
	}

	[SpecialName]
	private Thumb UCS()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(116494)) as Thumb;
	}

	private void gCp(object P_0, DragDeltaEventArgs P_1)
	{
		Size size = new Size(double.PositiveInfinity, double.PositiveInfinity);
		Size size2 = new Size(base.MinWidth, base.MinHeight);
		FrameworkElement frameworkElement = base.Content as FrameworkElement;
		while (frameworkElement is ContentPresenter)
		{
			frameworkElement = ((ContentPresenter)frameworkElement).Content as FrameworkElement;
		}
		if (frameworkElement != null)
		{
			Rect rect = frameworkElement.TransformToAncestor(this).TransformBounds(new Rect(new Point(0.0, 0.0), frameworkElement.RenderSize));
			double num = Math.Max(0.0, base.RenderSize.Width - rect.Width);
			double num2 = Math.Max(0.0, base.RenderSize.Height - rect.Height);
			size2.Width = Math.Max(size2.Width, frameworkElement.MinWidth + num);
			size2.Height = Math.Max(size2.Height, frameworkElement.MinHeight + num2);
			if (!double.IsNaN(frameworkElement.MaxWidth) && frameworkElement.MaxWidth < 100000.0)
			{
				size.Width = Math.Min(size.Width, frameworkElement.MaxWidth + num);
			}
			if (!double.IsNaN(frameworkElement.MaxHeight) && frameworkElement.MaxHeight < 100000.0)
			{
				size.Height = Math.Min(size.Height, frameworkElement.MaxHeight + num2);
			}
		}
		if (BrowserInteropHelper.IsBrowserHosted)
		{
			if (ResizeMode == ControlResizeMode.Both || ResizeMode == ControlResizeMode.Horizontal)
			{
				base.Width = Math.Min(size.Width, Math.Max(size2.Width, base.RenderSize.Width + P_1.HorizontalChange));
			}
			if (ResizeMode == ControlResizeMode.Both || ResizeMode == ControlResizeMode.Vertical)
			{
				base.Height = Math.Min(size.Height, Math.Max(size2.Height, base.RenderSize.Height + P_1.VerticalChange));
			}
			return;
		}
		Point point = PointToScreen(Mouse.GetPosition(this));
		if (ResizeMode == ControlResizeMode.Both || ResizeMode == ControlResizeMode.Horizontal)
		{
			base.Width = Math.Min(size.Width, Math.Max(size2.Width, PCm.Width + (double)((base.FlowDirection == FlowDirection.LeftToRight) ? 1 : (-1)) * (point.X - gCw.X) / sCh.X));
		}
		if (ResizeMode == ControlResizeMode.Both || ResizeMode == ControlResizeMode.Vertical)
		{
			base.Height = Math.Min(size.Height, Math.Max(size2.Height, PCm.Height + (point.Y - gCw.Y) / sCh.X));
		}
	}

	private void mCb(object P_0, DragStartedEventArgs P_1)
	{
		if (!BrowserInteropHelper.IsBrowserHosted)
		{
			gCw = PointToScreen(Mouse.GetPosition(this));
			PCm = base.RenderSize;
			ICi();
		}
	}

	private void RCy(object P_0, MouseButtonEventArgs P_1)
	{
		if (CanAutoSize)
		{
			AutoSize();
		}
	}

	private static void fCf(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		if (!(P_0 is FrameworkElement frameworkElement) || !(frameworkElement.TryFindResource(SharedResourceKeys.ScrollViewerStyleKey) is Style basedOn))
		{
			return;
		}
		if ((bool)P_1.NewValue)
		{
			frameworkElement.Resources.Add(typeof(ScrollViewer), new Style(typeof(ScrollViewer), basedOn));
			int num = 0;
			if (!tGT())
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}
		else
		{
			frameworkElement.Resources.Remove(typeof(ScrollViewer));
		}
	}

	[SpecialName]
	private ContentPresenter tCt()
	{
		return GetTemplateChild(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(110364)) as ContentPresenter;
	}

	private void ICi()
	{
		sCh = new Point(1.0, 1.0);
		Window window = Window.GetWindow(this);
		if (window != null)
		{
			sCh = NativeMethods.GetDpiMultiplier(new WindowInteropHelper(window).Handle);
		}
	}

	public void AutoSize()
	{
		base.Width = double.NaN;
		base.Height = double.NaN;
	}

	public override void OnApplyTemplate()
	{
		base.OnApplyTemplate();
		if (DC9 != null)
		{
			DC9.DragDelta -= gCp;
			DC9.DragStarted -= mCb;
			DC9.MouseDoubleClick -= RCy;
		}
		DC9 = UCS();
		if (DC9 != null)
		{
			DC9.DragDelta += gCp;
			DC9.DragStarted += mCb;
			DC9.MouseDoubleClick += RCy;
		}
	}

	public static bool GetUseAlternateScrollViewerStyle(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(UseAlternateScrollViewerStyleProperty);
	}

	public static void SetUseAlternateScrollViewerStyle(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(UseAlternateScrollViewerStyleProperty, value);
	}

	internal static bool tGT()
	{
		return aGV == null;
	}

	internal static ResizableContentControl RGX()
	{
		return aGV;
	}
}
