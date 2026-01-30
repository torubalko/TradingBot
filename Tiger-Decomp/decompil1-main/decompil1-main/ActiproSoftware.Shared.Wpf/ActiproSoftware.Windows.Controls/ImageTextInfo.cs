using System.Windows;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Controls;

public class ImageTextInfo : DependencyObject
{
	public static readonly DependencyProperty ImageSourceLargeProperty;

	public static readonly DependencyProperty ImageSourceSmallProperty;

	public static readonly DependencyProperty TagProperty;

	public static readonly DependencyProperty TextProperty;

	private static ImageTextInfo QGj;

	public ImageSource ImageSourceLarge
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceLargeProperty);
		}
		set
		{
			SetValue(ImageSourceLargeProperty, value);
		}
	}

	public ImageSource ImageSourceSmall
	{
		get
		{
			return (ImageSource)GetValue(ImageSourceSmallProperty);
		}
		set
		{
			SetValue(ImageSourceSmallProperty, value);
		}
	}

	public object Tag
	{
		get
		{
			return GetValue(TagProperty);
		}
		set
		{
			SetValue(TagProperty, value);
		}
	}

	[Localizability(LocalizationCategory.Title)]
	public string Text
	{
		get
		{
			return (string)GetValue(TextProperty);
		}
		set
		{
			SetValue(TextProperty, value);
		}
	}

	public override string ToString()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114636) + ((Text != null) ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114666) + Text + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(114672)) : string.Empty);
	}

	public ImageTextInfo()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	static ImageTextInfo()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		ImageSourceLargeProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111180), typeof(ImageSource), typeof(ImageTextInfo), new FrameworkPropertyMetadata(null));
		ImageSourceSmallProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111216), typeof(ImageSource), typeof(ImageTextInfo), new FrameworkPropertyMetadata(null));
		TagProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(111360), typeof(object), typeof(ImageTextInfo), new FrameworkPropertyMetadata(null));
		TextProperty = DependencyProperty.Register(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(113414), typeof(string), typeof(ImageTextInfo), new FrameworkPropertyMetadata(null));
	}

	internal static bool gGe()
	{
		return QGj == null;
	}

	internal static ImageTextInfo wG6()
	{
		return QGj;
	}
}
