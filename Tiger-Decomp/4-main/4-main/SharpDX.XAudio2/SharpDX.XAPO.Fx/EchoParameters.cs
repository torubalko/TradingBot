using System.Runtime.InteropServices;

namespace SharpDX.XAPO.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct EchoParameters
{
	public float WetDryMix;

	public float Feedback;

	public float Delay;
}
