using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public class IconFrameConverter : IValueConverter
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double ooq;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double aoW;

	private static IconFrameConverter i7N;

	public double DesiredHeight
	{
		[CompilerGenerated]
		get
		{
			return ooq;
		}
		[CompilerGenerated]
		set
		{
			ooq = value;
		}
	}

	public double DesiredWidth
	{
		[CompilerGenerated]
		get
		{
			return aoW;
		}
		[CompilerGenerated]
		set
		{
			aoW = value;
		}
	}

	public IconFrameConverter()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		DesiredHeight = (DesiredWidth = 32.0);
	}

	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is BitmapFrame bitmapFrame && bitmapFrame.Decoder is IconBitmapDecoder)
		{
			foreach (BitmapFrame frame in bitmapFrame.Decoder.Frames)
			{
				if (frame.Height == DesiredHeight && frame.Width == DesiredWidth)
				{
					return frame;
				}
			}
		}
		return value;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		return value;
	}

	internal static bool H7O()
	{
		return i7N == null;
	}

	internal static IconFrameConverter z7q()
	{
		return i7N;
	}
}
