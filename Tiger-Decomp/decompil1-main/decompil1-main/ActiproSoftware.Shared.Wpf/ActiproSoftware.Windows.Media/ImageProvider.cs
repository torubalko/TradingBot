using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ActiproSoftware.Windows.Themes;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public class ImageProvider
{
	private static PropertyInfo pog;

	private static PropertyInfo eo8;

	public static readonly DependencyProperty CanAdaptProperty;

	public static readonly DependencyProperty ProviderProperty;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageChromaticAdaptationMode foD;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static ImageProvider BoP;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Color? moG;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private byte eo1;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly IList<double> foz;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private readonly IList<string> eQc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool EQj;

	private static ImageProvider W78;

	public ImageChromaticAdaptationMode ChromaticAdaptationMode
	{
		[CompilerGenerated]
		get
		{
			return foD;
		}
		[CompilerGenerated]
		set
		{
			foD = value;
		}
	}

	public static ImageProvider Default
	{
		[CompilerGenerated]
		get
		{
			return BoP;
		}
		[CompilerGenerated]
		set
		{
			BoP = value;
		}
	}

	public Color? DesignForegroundColor
	{
		[CompilerGenerated]
		get
		{
			return moG;
		}
		[CompilerGenerated]
		set
		{
			moG = value;
		}
	}

	public byte MonochromeBrightnessThreshold
	{
		[CompilerGenerated]
		get
		{
			return eo1;
		}
		[CompilerGenerated]
		set
		{
			eo1 = value;
		}
	}

	public IList<double> Scales
	{
		[CompilerGenerated]
		get
		{
			return foz;
		}
	}

	public IList<string> ThemeNames
	{
		[CompilerGenerated]
		get
		{
			return eQc;
		}
	}

	public bool UseMonochromeInHighContrast
	{
		[CompilerGenerated]
		get
		{
			return EQj;
		}
		[CompilerGenerated]
		set
		{
			EQj = value;
		}
	}

	static ImageProvider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		CanAdaptProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106438), typeof(bool), typeof(ImageProvider), new FrameworkPropertyMetadata(true));
		ProviderProperty = DependencyProperty.RegisterAttached(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106458), typeof(ImageProvider), typeof(ImageProvider), new FrameworkPropertyMetadata(null));
		Default = new ImageProvider();
		pog = typeof(BitmapSource).GetProperty(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106478), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		eo8 = typeof(BitmapSource).GetProperty(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106516), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
	}

	[SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
	private ImageSource JoV(BitmapSource P_0, ImageProviderRequest P_1)
	{
		if (IsBitmapSourceCreated(P_0))
		{
			try
			{
				if (P_0.Format != PixelFormats.Bgra32)
				{
					P_0 = new FormatConvertedBitmap(P_0, PixelFormats.Bgra32, null, 0.0);
				}
				int pixelWidth = P_0.PixelWidth;
				int num = 0;
				if (r7e() != null)
				{
					num = 0;
				}
				byte[] array = default(byte[]);
				int num4 = default(int);
				Color color = default(Color);
				int num3 = default(int);
				int pixelHeight = default(int);
				int num2 = default(int);
				int num5 = default(int);
				while (true)
				{
					switch (num)
					{
					case 1:
						array[num4] = color.B;
						num3++;
						break;
					default:
						pixelHeight = P_0.PixelHeight;
						num2 = pixelWidth * 4;
						array = new byte[num2 * pixelHeight];
						P_0.CopyPixels(array, num2, 0);
						num3 = 0;
						break;
					}
					if (num3 >= pixelWidth * pixelHeight)
					{
						break;
					}
					num4 = num3 * 4;
					color = AdaptColor(Color.FromArgb(array[num4 + 3], array[num4 + 2], array[num4 + 1], array[num4]), P_1);
					array[num4 + 3] = color.A;
					array[num4 + 2] = color.R;
					array[num4 + 1] = color.G;
					num = 1;
					if (r7e() != null)
					{
						num = num5;
					}
				}
				WriteableBitmap writeableBitmap = new WriteableBitmap(P_0.PixelWidth, P_0.PixelHeight, P_0.DpiX, P_0.DpiY, PixelFormats.Bgra32, null);
				writeableBitmap.WritePixels(new Int32Rect(0, 0, P_0.PixelWidth, P_0.PixelHeight), array, num2, 0);
				return writeableBitmap;
			}
			catch
			{
			}
		}
		return P_0;
	}

	private Brush to5(Brush P_0, ImageProviderRequest P_1)
	{
		SolidColorBrush solidColorBrush = P_0 as SolidColorBrush;
		if (solidColorBrush != null)
		{
			Color color = AdaptColor(solidColorBrush.Color, P_1);
			if (color == solidColorBrush.Color)
			{
				return solidColorBrush;
			}
			if (solidColorBrush.IsFrozen)
			{
				solidColorBrush = new SolidColorBrush(color);
				solidColorBrush.Freeze();
			}
			else
			{
				solidColorBrush.Color = color;
			}
			return solidColorBrush;
		}
		GradientBrush gradientBrush = P_0 as GradientBrush;
		if (gradientBrush != null)
		{
			bool isFrozen = gradientBrush.IsFrozen;
			if (isFrozen)
			{
				gradientBrush = gradientBrush.Clone();
			}
			foreach (GradientStop gradientStop in gradientBrush.GradientStops)
			{
				if (gradientStop != null)
				{
					gradientStop.Color = AdaptColor(gradientStop.Color, P_1);
				}
			}
			if (isFrozen)
			{
				gradientBrush.Freeze();
			}
			return gradientBrush;
		}
		return P_0;
	}

	private ImageSource woR(DrawingImage P_0, ImageProviderRequest P_1)
	{
		if (P_0 != null)
		{
			P_0 = P_0.Clone();
			EoE(P_0.Drawing, P_1);
		}
		return P_0;
	}

	private void EoE(Drawing P_0, ImageProviderRequest P_1)
	{
		if (P_0 == null || !CoL(P_0, P_1))
		{
			return;
		}
		if (P_0 is ImageDrawing imageDrawing)
		{
			if (imageDrawing.ImageSource is BitmapSource bitmapSource)
			{
				imageDrawing.ImageSource = JoV(bitmapSource, P_1);
			}
		}
		else if (P_0 is DrawingGroup drawingGroup)
		{
			for (int i = 0; i < drawingGroup.Children.Count; i++)
			{
				Drawing drawing = drawingGroup.Children[i];
				if (drawing != null)
				{
					EoE(drawing, P_1);
				}
			}
		}
		else if (P_0 is GeometryDrawing { IsFrozen: false } geometryDrawing)
		{
			geometryDrawing.Brush = to5(geometryDrawing.Brush, P_1);
			geometryDrawing.Pen = gos(geometryDrawing.Pen, P_1);
		}
	}

	private Pen gos(Pen P_0, ImageProviderRequest P_1)
	{
		if (P_0 != null)
		{
			Brush brush = P_0.Brush;
			if (brush != null)
			{
				brush = to5(brush, P_1);
				if (P_0.IsFrozen)
				{
					Pen pen = P_0;
					P_0 = new Pen(brush, P_0.Thickness);
					P_0.DashCap = pen.DashCap;
					P_0.DashStyle = pen.DashStyle;
					P_0.EndLineCap = pen.EndLineCap;
					P_0.LineJoin = pen.LineJoin;
					P_0.MiterLimit = pen.MiterLimit;
					P_0.StartLineCap = pen.StartLineCap;
					P_0.Freeze();
				}
				else
				{
					P_0.Brush = brush;
				}
			}
		}
		return P_0;
	}

	private bool CoL(DependencyObject P_0, ImageProviderRequest P_1)
	{
		int num = 2;
		int num2 = num;
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 2:
				flag = P_0 != null;
				num2 = 0;
				if (Q7j())
				{
					num2 = 1;
				}
				break;
			default:
				return false;
			case 1:
				if (flag)
				{
					if (P_1.UseGrayscale)
					{
						return true;
					}
					if (GetCanAdapt(P_0))
					{
						if (P_1.UseMonochrome)
						{
							return true;
						}
						if (DesignForegroundColor.HasValue && P_1.ForegroundColor.HasValue)
						{
							return true;
						}
						return P_1.ChromaticAdaptationBackgroundColor.HasValue;
					}
				}
				goto default;
			}
		}
	}

	private BitmapSource aod(BitmapSource P_0, ImageProviderRequest P_1)
	{
		if (!(P_0 is BitmapImage bitmapImage))
		{
			if (P_0 is BitmapFrame bitmapFrame)
			{
				string text = bitmapFrame.ToString();
				if (!string.IsNullOrEmpty(text) && text.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106548), StringComparison.Ordinal))
				{
					Uri uri = new Uri(text, UriKind.RelativeOrAbsolute);
					P_0 = noN(bitmapFrame.BaseUri, uri, P_1) ?? P_0;
				}
			}
		}
		else
		{
			P_0 = noN(bitmapImage.BaseUri, bitmapImage.UriSource, P_1) ?? P_0;
		}
		return P_0;
	}

	private BitmapSource noN(Uri P_0, Uri P_1, ImageProviderRequest P_2)
	{
		if (P_1 != null)
		{
			Uri uri = TransformBaseImageUriSource(P_1, P_2);
			if (uri != P_1)
			{
				try
				{
					if (!uri.IsAbsoluteUri && P_0 != null)
					{
						uri = new Uri(P_0, uri);
					}
					BitmapImage bitmapImage = new BitmapImage();
					bitmapImage.BeginInit();
					bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
					bitmapImage.CreateOptions = BitmapCreateOptions.IgnoreImageCache;
					bitmapImage.UriSource = uri;
					bitmapImage.EndInit();
					if (bitmapImage.CanFreeze)
					{
						bitmapImage.Freeze();
					}
					return bitmapImage;
				}
				catch
				{
				}
			}
		}
		return null;
	}

	private static Color? XoM()
	{
		if (Application.Current.TryFindResource(AssetResourceKeys.ContainerBackgroundLowBrushKey) is Brush brush)
		{
			return GetColorFromBrush(brush);
		}
		return null;
	}

	private static Color? aoK()
	{
		if (Application.Current.TryFindResource(AssetResourceKeys.ContainerForegroundLowNormalBrushKey) is Brush brush)
		{
			return GetColorFromBrush(brush);
		}
		return null;
	}

	internal bool HasNonDefaultScales(ImageSource imageSource)
	{
		return imageSource is BitmapSource && Scales.Any((double s) => s > 1.0);
	}

	internal bool HasThemeVariation(ImageSource imageSource, string oldThemeName, string newThemeName)
	{
		switch (ChromaticAdaptationMode)
		{
		case ImageChromaticAdaptationMode.Always:
			return true;
		case ImageChromaticAdaptationMode.DarkThemes:
		{
			bool flag = ThemeManager.IsDarkTheme(oldThemeName);
			bool flag2 = ThemeManager.IsDarkTheme(newThemeName);
			return flag != flag2 || (newThemeName?.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106566), StringComparison.OrdinalIgnoreCase) ?? false);
		}
		default:
			if (imageSource is BitmapSource)
			{
				if (HasThemeVariation(oldThemeName))
				{
					return true;
				}
				if (HasThemeVariation(newThemeName))
				{
					return true;
				}
			}
			return false;
		}
	}

	internal static bool IsBitmapSourceCreated(BitmapSource bitmapSource)
	{
		bool flag = false;
		if (bitmapSource != null)
		{
			try
			{
				if (pog != null)
				{
					flag = (bool)pog.GetValue(bitmapSource, null);
				}
				if (!flag && eo8 != null)
				{
					flag = (bool)eo8.GetValue(bitmapSource, null);
				}
			}
			catch
			{
			}
		}
		return flag;
	}

	protected virtual Color AdaptColor(Color color, ImageProviderRequest request)
	{
		if (request != null)
		{
			UIColor uIColor = UIColor.FromColor(color);
			if (request.UseMonochrome)
			{
				if (uIColor.W3CBrightness >= MonochromeBrightnessThreshold)
				{
					uIColor.A = 0;
				}
				else
				{
					uIColor.R = request.MonochromeColor.R;
					uIColor.G = request.MonochromeColor.G;
					uIColor.B = request.MonochromeColor.B;
				}
			}
			else if (DesignForegroundColor.HasValue && request.ForegroundColor.HasValue && uIColor.R == DesignForegroundColor.Value.R && uIColor.G == DesignForegroundColor.Value.G && uIColor.B == DesignForegroundColor.Value.B)
			{
				uIColor = UIColor.FromArgb(uIColor.A, request.ForegroundColor.Value.R, request.ForegroundColor.Value.G, request.ForegroundColor.Value.B);
				if (request.UseGrayscale)
				{
					uIColor.Grayscale();
				}
			}
			else
			{
				if (request.UseGrayscale)
				{
					uIColor.Grayscale();
				}
				if (request.ChromaticAdaptationBackgroundColor.HasValue)
				{
					uIColor.AdaptToBackground(request.ChromaticAdaptationBackgroundColor.Value, request.IsHighContrastTheme);
				}
			}
			return uIColor.ToColor();
		}
		return color;
	}

	[AttachedPropertyBrowsableForType(typeof(Drawing))]
	[AttachedPropertyBrowsableForType(typeof(ImageSource))]
	public static bool GetCanAdapt(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (bool)obj.GetValue(CanAdaptProperty);
	}

	public static void SetCanAdapt(DependencyObject obj, bool value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(CanAdaptProperty, value);
	}

	protected virtual double FindBestScale(double targetScale)
	{
		double num = double.MaxValue;
		if (targetScale != 1.0)
		{
			foreach (double scale in Scales)
			{
				if (scale == targetScale)
				{
					return scale;
				}
				if (scale > targetScale && scale < num)
				{
					num = scale;
				}
			}
		}
		if (num == double.MaxValue)
		{
			num = 1.0;
		}
		return num;
	}

	public static Color? GetColorFromBrush(Brush brush)
	{
		if (brush != null)
		{
			if (brush is SolidColorBrush solidColorBrush)
			{
				return solidColorBrush.Color;
			}
			if (brush is GradientBrush gradientBrush)
			{
				int num = Math.Min(gradientBrush.GradientStops.Count - 1, gradientBrush.GradientStops.Count / 2);
				if (num > -1)
				{
					if (num < gradientBrush.GradientStops.Count - 1)
					{
						return UIColor.FromMix(gradientBrush.GradientStops[num].Color, gradientBrush.GradientStops[num + 1].Color, 0.5).ToColor();
					}
					return gradientBrush.GradientStops[num].Color;
				}
			}
		}
		return null;
	}

	public virtual ImageSource GetImageSource(ImageSource originalImageSource, ImageProviderRequest request)
	{
		if (request == null)
		{
			goto IL_0071;
		}
		ImageChromaticAdaptationMode chromaticAdaptationMode = ChromaticAdaptationMode;
		ImageChromaticAdaptationMode imageChromaticAdaptationMode = chromaticAdaptationMode;
		if (imageChromaticAdaptationMode != ImageChromaticAdaptationMode.DarkThemes)
		{
			if (imageChromaticAdaptationMode == ImageChromaticAdaptationMode.Always)
			{
				goto IL_0226;
			}
		}
		else
		{
			request.ChromaticAdaptationBackgroundColor = (ThemeManager.IsDarkTheme(request.ThemeName) ? XoM() : ((Color?)null));
		}
		goto IL_0281;
		IL_0051:
		BitmapSource bitmapSource = aod(bitmapSource, request);
		if (!CoL(bitmapSource, request))
		{
			return bitmapSource;
		}
		return JoV(bitmapSource, request);
		IL_02a3:
		int num = 0;
		goto IL_02a4;
		IL_02a4:
		bool flag = (byte)num != 0;
		int num2 = 3;
		goto IL_0009;
		IL_0009:
		DrawingImage drawingImage = default(DrawingImage);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 3:
				break;
			case 1:
				return woR(drawingImage, request);
			default:
				goto end_IL_0009;
			case 2:
				goto IL_0226;
			}
			if (flag)
			{
				request.UseMonochrome = true;
			}
			if (request.UseMonochrome)
			{
				request.MonochromeColor = request.ForegroundColor ?? aoK() ?? Colors.White;
			}
			bitmapSource = originalImageSource as BitmapSource;
			if (bitmapSource == null)
			{
				drawingImage = originalImageSource as DrawingImage;
				if (drawingImage != null && CoL(drawingImage, request))
				{
					num2 = 1;
					if (r7e() != null)
					{
						num2 = num3;
					}
					continue;
				}
				goto IL_0071;
			}
			goto IL_0051;
			continue;
			end_IL_0009:
			break;
		}
		if (!UseMonochromeInHighContrast)
		{
			goto IL_02a3;
		}
		num = (request.IsHighContrastTheme ? 1 : 0);
		goto IL_02a4;
		IL_0071:
		return originalImageSource;
		IL_0226:
		request.ChromaticAdaptationBackgroundColor = request.BackgroundColor ?? XoM();
		goto IL_0281;
		IL_0281:
		request.IsHighContrastTheme = ThemeManager.IsHighContrastTheme(request.ThemeName ?? ThemeManager.CurrentTheme);
		if (!request.UseMonochrome)
		{
			num2 = 0;
			if (r7e() == null)
			{
				num2 = 0;
			}
			goto IL_0009;
		}
		goto IL_02a3;
	}

	protected virtual string GetScalePathPath(double scale)
	{
		if (scale != 1.0 && Scales.Contains(scale))
		{
			return string.Format(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106598), Math.Round(scale * 100.0, MidpointRounding.AwayFromZero));
		}
		return string.Empty;
	}

	protected virtual string GetThemeNamePathPart(string themeName)
	{
		if (!string.IsNullOrEmpty(themeName) && ThemeNames.Contains(themeName))
		{
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106620) + themeName.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106636), string.Empty);
		}
		return string.Empty;
	}

	protected virtual bool HasThemeVariation(string themeName)
	{
		return ThemeNames.Contains(themeName);
	}

	[AttachedPropertyBrowsableForType(typeof(ImageSource))]
	public static ImageProvider GetProvider(DependencyObject obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		return (ImageProvider)obj.GetValue(ProviderProperty);
	}

	public static void SetProvider(DependencyObject obj, ImageProvider value)
	{
		if (obj == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(95322));
		}
		obj.SetValue(ProviderProperty, value);
	}

	protected virtual Uri TransformBaseImageUriSource(Uri uriSource, ImageProviderRequest request)
	{
		string text = uriSource?.OriginalString;
		if (!string.IsNullOrEmpty(text))
		{
			string themeNamePathPart = GetThemeNamePathPart(request.ThemeName);
			double scale = FindBestScale(request.Scale);
			string scalePathPath = GetScalePathPath(scale);
			if (!string.IsNullOrEmpty(themeNamePathPart) || !string.IsNullOrEmpty(scalePathPath))
			{
				int num = text.LastIndexOf('.');
				if (num != -1)
				{
					text = text.Substring(0, num) + ((!string.IsNullOrEmpty(themeNamePathPart)) ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106642) + themeNamePathPart) : null) + ((!string.IsNullOrEmpty(scalePathPath)) ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106642) + scalePathPath) : null) + text.Substring(num);
				}
			}
			uriSource = new Uri(text, UriKind.RelativeOrAbsolute);
		}
		return uriSource;
	}

	public ImageProvider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		eo1 = 230;
		foz = new List<double>();
		eQc = new List<string>();
		base._002Ector();
	}

	internal static bool Q7j()
	{
		return W78 == null;
	}

	internal static ImageProvider r7e()
	{
		return W78;
	}
}
