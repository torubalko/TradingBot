using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using ActiproSoftware.Windows.Data;
using ActiproSoftware.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

[ValueConversion(typeof(Uri), typeof(Image))]
[ValueConversion(typeof(BitmapSource), typeof(Image))]
[ValueConversion(typeof(string), typeof(Image))]
public class ImageConverter : DependencyObject, IValueConverter
{
	public static readonly DependencyProperty HeightProperty;

	public static readonly DependencyProperty ImageProviderProperty;

	public static readonly DependencyProperty UriPrefixProperty;

	public static readonly DependencyProperty WidthProperty;

	private static ImageConverter sG1;

	public double Height
	{
		get
		{
			return (double)GetValue(HeightProperty);
		}
		set
		{
			SetValue(HeightProperty, value);
		}
	}

	public ImageProvider ImageProvider
	{
		get
		{
			return (ImageProvider)GetValue(ImageProviderProperty);
		}
		set
		{
			SetValue(ImageProviderProperty, value);
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
	public string UriPrefix
	{
		get
		{
			return (string)GetValue(UriPrefixProperty);
		}
		set
		{
			SetValue(UriPrefixProperty, value);
		}
	}

	public double Width
	{
		get
		{
			return (double)GetValue(WidthProperty);
		}
		set
		{
			SetValue(WidthProperty, value);
		}
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		BitmapSource bitmapSource = null;
		Uri uri = value as Uri;
		int num;
		string text = default(string);
		if ((object)uri != null)
		{
			num = 0;
			if (GG8() != null)
			{
				goto IL_0005;
			}
		}
		else
		{
			text = value as string;
			num = 1;
			if (GG8() != null)
			{
				goto IL_0005;
			}
		}
		goto IL_0009;
		IL_0009:
		switch (num)
		{
		default:
			bitmapSource = new BitmapImage(uri);
			break;
		case 1:
			if (text != null)
			{
				Uri uriSource = new Uri((UriPrefix ?? string.Empty) + text, UriKind.RelativeOrAbsolute);
				bitmapSource = new BitmapImage(uriSource);
			}
			else
			{
				bitmapSource = value as BitmapSource;
			}
			break;
		}
		if (bitmapSource != null)
		{
			ImageProvider imageProvider = ImageProvider;
			if (imageProvider != null)
			{
				ImageProvider.SetProvider(bitmapSource, imageProvider);
			}
			return CreateImage(bitmapSource);
		}
		return null;
		IL_0005:
		int num2 = default(int);
		num = num2;
		goto IL_0009;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return null;
	}

	protected virtual Image CreateImage(ImageSource imageSource)
	{
		if (imageSource == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114550));
		}
		DynamicImage dynamicImage = new DynamicImage();
		dynamicImage.Width = Width;
		dynamicImage.Height = Height;
		dynamicImage.Source = imageSource;
		return dynamicImage;
	}

	public ImageConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static ImageConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		HeightProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114576), typeof(double), typeof(ImageConverter), new FrameworkPropertyMetadata(double.NaN));
		ImageProviderProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114592), typeof(ImageProvider), typeof(ImageConverter), new FrameworkPropertyMetadata(null));
		UriPrefixProperty = UriConverter.UriPrefixProperty.AddOwner(typeof(ImageConverter));
		WidthProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114622), typeof(double), typeof(ImageConverter), new FrameworkPropertyMetadata(double.NaN));
	}

	internal static bool xGg()
	{
		return sG1 == null;
	}

	internal static ImageConverter GG8()
	{
		return sG1;
	}
}
