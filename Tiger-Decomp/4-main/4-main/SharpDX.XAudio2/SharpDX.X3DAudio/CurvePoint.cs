using System.Runtime.InteropServices;

namespace SharpDX.X3DAudio;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct CurvePoint
{
	public float Distance;

	public float DspSetting;
}
