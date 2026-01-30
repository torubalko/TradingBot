using System;
using System.Runtime.InteropServices;

namespace SharpDX.X3DAudio;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct DistanceCurve
{
	internal IntPtr PointsPointer;

	public int PointCount;

	public unsafe static IntPtr FromCurvePoints(CurvePoint[] points)
	{
		if (points == null || points.Length == 0)
		{
			return IntPtr.Zero;
		}
		DistanceCurve* ptr = (DistanceCurve*)(void*)Marshal.AllocHGlobal(Utilities.SizeOf<DistanceCurve>() + points.Length * Utilities.SizeOf<CurvePoint>());
		CurvePoint* value = (CurvePoint*)(ptr + 1);
		ptr->PointCount = points.Length;
		ptr->PointsPointer = new IntPtr(value);
		Utilities.Write(ptr->PointsPointer, points, 0, points.Length);
		return (IntPtr)ptr;
	}
}
