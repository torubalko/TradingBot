using System.Runtime.InteropServices;
using SharpDX.Direct2D1;

namespace SharpDX.WIC;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct ImageParameters
{
	public SharpDX.Direct2D1.PixelFormat PixelFormat;

	public float DpiX;

	public float DpiY;

	public float Top;

	public float Left;

	public int PixelWidth;

	public int PixelHeight;

	public ImageParameters(SharpDX.Direct2D1.PixelFormat pixelFormat, float dpiX, float dpiY, float top, float left, int pixelWidth, int pixelHeight)
	{
		PixelFormat = pixelFormat;
		DpiX = dpiX;
		DpiY = dpiY;
		Top = top;
		Left = left;
		PixelWidth = pixelWidth;
		PixelHeight = pixelHeight;
	}
}
