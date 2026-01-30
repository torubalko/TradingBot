using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.IntelliPrompt;

[ValueConversion(typeof(IImageSourceProvider), typeof(ImageSource))]
public class ImageSourceProviderConverter : IValueConverter
{
	private static ImageSourceProviderConverter Oqe;

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (!(value is IImageSourceProvider imageSourceProvider))
		{
			return null;
		}
		return imageSourceProvider.GetImageSource();
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}

	public ImageSourceProviderConverter()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool sqz()
	{
		return Oqe == null;
	}

	internal static ImageSourceProviderConverter hxm()
	{
		return Oqe;
	}
}
