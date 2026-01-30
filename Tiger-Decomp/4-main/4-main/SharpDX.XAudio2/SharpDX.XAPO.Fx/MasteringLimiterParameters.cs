using System.Runtime.InteropServices;

namespace SharpDX.XAPO.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct MasteringLimiterParameters
{
	public int Release;

	public int Loudness;
}
