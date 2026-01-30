using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDX.Direct2D1;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct Ellipse
{
	public RawVector2 Point;

	public float RadiusX;

	public float RadiusY;

	public Ellipse(RawVector2 center, float radiusX, float radiusY)
	{
		Point = center;
		RadiusX = radiusX;
		RadiusY = radiusY;
	}
}
