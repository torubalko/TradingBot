using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Windows.Media;

public class IconFrameSelector : MarkupExtension
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double aoU;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double ToH;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ImageSource yo6;

	internal static IconFrameSelector U7G;

	public double DesiredHeight
	{
		[CompilerGenerated]
		get
		{
			return aoU;
		}
		[CompilerGenerated]
		set
		{
			aoU = value;
		}
	}

	public double DesiredWidth
	{
		[CompilerGenerated]
		get
		{
			return ToH;
		}
		[CompilerGenerated]
		set
		{
			ToH = value;
		}
	}

	public ImageSource ImageSource
	{
		[CompilerGenerated]
		get
		{
			return yo6;
		}
		[CompilerGenerated]
		set
		{
			yo6 = value;
		}
	}

	public IconFrameSelector()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(null);
	}

	public IconFrameSelector(ImageSource imageSource)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		ImageSource = imageSource;
		DesiredHeight = (DesiredWidth = 32.0);
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (ImageSource is BitmapFrame bitmapFrame && bitmapFrame.Decoder is IconBitmapDecoder)
		{
			foreach (BitmapFrame frame in bitmapFrame.Decoder.Frames)
			{
				if (frame.Height == DesiredHeight && frame.Width == DesiredWidth)
				{
					return frame;
				}
			}
		}
		return ImageSource;
	}

	internal static bool c7n()
	{
		return U7G == null;
	}

	internal static IconFrameSelector E70()
	{
		return U7G;
	}
}
