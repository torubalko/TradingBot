using System;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Interop;
using ActiproSoftware.Windows.Media;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class DynamicImage : Image
{
	private bool GAX;

	private string FAT;

	private Color vAB;

	private double? cAp;

	public static readonly DependencyProperty BackgroundHintProperty;

	public static readonly DependencyProperty ForegroundProperty;

	public static readonly DependencyProperty DisabledOpacityProperty;

	public static readonly DependencyProperty OriginalSourceProperty;

	public static readonly DependencyProperty UseMonochromeProperty;

	internal static DynamicImage eGf;

	public Brush BackgroundHint
	{
		get
		{
			return (Brush)GetValue(BackgroundHintProperty);
		}
		set
		{
			SetValue(BackgroundHintProperty, value);
		}
	}

	public double DisabledOpacity
	{
		get
		{
			return (double)GetValue(DisabledOpacityProperty);
		}
		set
		{
			SetValue(DisabledOpacityProperty, value);
		}
	}

	public Brush Foreground
	{
		get
		{
			return (Brush)GetValue(ForegroundProperty);
		}
		set
		{
			SetValue(ForegroundProperty, value);
		}
	}

	public ImageSource OriginalSource
	{
		get
		{
			return (ImageSource)GetValue(OriginalSourceProperty);
		}
		private set
		{
			SetValue(OriginalSourceProperty, value);
		}
	}

	public bool UseMonochrome
	{
		get
		{
			return (bool)GetValue(UseMonochromeProperty);
		}
		set
		{
			SetValue(UseMonochromeProperty, value);
		}
	}

	static DynamicImage()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		BackgroundHintProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114176), typeof(Brush), typeof(DynamicImage), new FrameworkPropertyMetadata(null, Wl1));
		ForegroundProperty = TextElement.ForegroundProperty.AddOwner(typeof(DynamicImage), new FrameworkPropertyMetadata(SystemColors.ControlTextBrush, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.Inherits, Rlz));
		DisabledOpacityProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(97558), typeof(double), typeof(DynamicImage), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender), (object obj) => ValidationHelper.ValidateDoubleIsPercentage(obj));
		OriginalSourceProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114208), typeof(ImageSource), typeof(DynamicImage), new FrameworkPropertyMetadata(null));
		UseMonochromeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114240), typeof(bool), typeof(DynamicImage), new FrameworkPropertyMetadata(false, vAj));
		UIElement.IsEnabledProperty.OverrideMetadata(typeof(DynamicImage), new FrameworkPropertyMetadata(true, uAc));
		Image.SourceProperty.OverrideMetadata(typeof(DynamicImage), new FrameworkPropertyMetadata(null, null, rlG));
	}

	public DynamicImage()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		wlD();
	}

	private void wlD()
	{
		EventInfo eventInfo = GetType().GetEvent(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114270));
		if (!(eventInfo != null))
		{
			return;
		}
		MethodInfo method = GetType().GetMethod(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114294), BindingFlags.Instance | BindingFlags.NonPublic);
		if (method != null)
		{
			Delegate handler = Delegate.CreateDelegate(eventInfo.EventHandlerType, this, method);
			eventInfo.AddEventHandler(this, handler);
			int num = 0;
			if (UGH() != null)
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
	}

	private bool mlP()
	{
		string currentTheme = ThemeManager.CurrentTheme;
		if (FAT != currentTheme)
		{
			ImageSource originalSource = OriginalSource;
			if (originalSource != null)
			{
				ImageProvider imageProvider = ImageProvider.GetProvider(originalSource) ?? ImageProvider.Default;
				if (imageProvider != null)
				{
					if (imageProvider.HasThemeVariation(originalSource, FAT, currentTheme))
					{
						return true;
					}
					if (imageProvider.UseMonochromeInHighContrast && (ThemeManager.IsHighContrastTheme(currentTheme) || ThemeManager.IsHighContrastTheme(FAT)))
					{
						return true;
					}
				}
			}
		}
		else if (ThemeManager.IsHighContrastTheme(currentTheme) && vAB != SystemColors.WindowColor)
		{
			return true;
		}
		return false;
	}

	private static object rlG(DependencyObject P_0, object P_1)
	{
		DynamicImage dynamicImage = (DynamicImage)P_0;
		ImageSource imageSource = (dynamicImage.OriginalSource = P_1 as ImageSource);
		dynamicImage.FAT = ThemeManager.CurrentTheme;
		dynamicImage.vAB = SystemColors.WindowColor;
		int num;
		if (imageSource != null)
		{
			BitmapSource bitmapSource = imageSource as BitmapSource;
			dynamicImage.GAX = bitmapSource != null && !ImageProvider.IsBitmapSourceCreated(bitmapSource);
			num = 1;
			if (!eG7())
			{
				goto IL_0005;
			}
			goto IL_0009;
		}
		goto IL_004d;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
		IL_004d:
		return imageSource;
		IL_0009:
		ImageProvider imageProvider = default(ImageProvider);
		while (true)
		{
			ImageProvider obj;
			switch (num)
			{
			case 1:
				if (!dynamicImage.GAX)
				{
					obj = ImageProvider.GetProvider(imageSource) ?? ImageProvider.Default;
					goto IL_0157;
				}
				return imageSource;
			}
			break;
			IL_0157:
			imageProvider = obj;
			num = 0;
			if (UGH() == null)
			{
				continue;
			}
			goto IL_0005;
		}
		ImageProviderRequest imageProviderRequest = dynamicImage.CreateImageProviderRequest(imageProvider);
		if (imageProviderRequest != null)
		{
			imageSource = imageProvider.GetImageSource(imageSource, imageProviderRequest);
		}
		goto IL_004d;
	}

	private static void Wl1(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DynamicImage dynamicImage = (DynamicImage)P_0;
		ImageSource originalSource = dynamicImage.OriginalSource;
		if (originalSource == null)
		{
			return;
		}
		ImageProvider imageProvider = ImageProvider.GetProvider(originalSource) ?? ImageProvider.Default;
		if (imageProvider == null)
		{
			return;
		}
		int num = 0;
		if (UGH() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		if (imageProvider.ChromaticAdaptationMode == ImageChromaticAdaptationMode.Always)
		{
			dynamicImage.CoerceValue(Image.SourceProperty);
		}
	}

	private void OnDpiChangedCore(object sender, EventArgs e)
	{
		double? num = null;
		PropertyInfo property = e.GetType().GetProperty(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114330));
		if (property != null)
		{
			object value = property.GetValue(e, null);
			if (value != null)
			{
				PropertyInfo property2 = value.GetType().GetProperty(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114346));
				if (property2 != null)
				{
					num = property2.GetValue(value, null) as double?;
				}
			}
		}
		bool hasValue = cAp.HasValue;
		if (num.HasValue)
		{
			cAp = num.Value;
		}
		else
		{
			cAp = NativeMethods.GetVisualDpiMultiplier(this).X;
		}
		if (!hasValue)
		{
			return;
		}
		ImageSource originalSource = OriginalSource;
		if (originalSource != null)
		{
			ImageProvider imageProvider = ImageProvider.GetProvider(originalSource) ?? ImageProvider.Default;
			if (imageProvider != null && imageProvider.HasNonDefaultScales(originalSource))
			{
				CoerceValue(Image.SourceProperty);
			}
		}
	}

	private static void Rlz(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DynamicImage dynamicImage = (DynamicImage)P_0;
		ImageSource originalSource = dynamicImage.OriginalSource;
		if (originalSource != null)
		{
			ImageProvider imageProvider = ImageProvider.GetProvider(originalSource) ?? ImageProvider.Default;
			if (imageProvider != null && (dynamicImage.UseMonochrome || imageProvider.DesignForegroundColor.HasValue || (imageProvider.UseMonochromeInHighContrast && ThemeManager.IsHighContrastTheme(ThemeManager.CurrentTheme))))
			{
				dynamicImage.CoerceValue(Image.SourceProperty);
			}
		}
	}

	private static void uAc(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DynamicImage dynamicImage = (DynamicImage)P_0;
		dynamicImage.CoerceValue(Image.SourceProperty);
	}

	private static void vAj(DependencyObject P_0, DependencyPropertyChangedEventArgs P_1)
	{
		DynamicImage dynamicImage = (DynamicImage)P_0;
		dynamicImage.CoerceValue(Image.SourceProperty);
	}

	protected override Size ArrangeOverride(Size finalSize)
	{
		bool flag = mlP();
		if (!flag && GAX)
		{
			BitmapSource bitmapSource = OriginalSource as BitmapSource;
			flag = ImageProvider.IsBitmapSourceCreated(bitmapSource);
		}
		if (flag)
		{
			CoerceValue(Image.SourceProperty);
		}
		return base.ArrangeOverride(finalSize);
	}

	protected virtual ImageProviderRequest CreateImageProviderRequest(ImageProvider imageProvider)
	{
		ImageProviderRequest result = null;
		if (imageProvider != null)
		{
			result = new ImageProviderRequest
			{
				BackgroundColor = ((imageProvider.ChromaticAdaptationMode == ImageChromaticAdaptationMode.Always) ? ImageProvider.GetColorFromBrush(BackgroundHint) : ((Color?)null)),
				ForegroundColor = ImageProvider.GetColorFromBrush(Foreground),
				Scale = (cAp ?? 1.0),
				ThemeName = FAT,
				UseGrayscale = !base.IsEnabled,
				UseMonochrome = UseMonochrome
			};
		}
		return result;
	}

	protected override void OnRender(DrawingContext drawingContext)
	{
		if (drawingContext == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111048));
		}
		if (!base.IsEnabled)
		{
			double disabledOpacity = DisabledOpacity;
			if (disabledOpacity < 1.0)
			{
				drawingContext.PushOpacity(disabledOpacity);
				base.OnRender(drawingContext);
				drawingContext.Pop();
				int num = 0;
				if (UGH() != null)
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				case 0:
					break;
				}
				return;
			}
		}
		base.OnRender(drawingContext);
	}

	internal static bool eG7()
	{
		return eGf == null;
	}

	internal static DynamicImage UGH()
	{
		return eGf;
	}
}
