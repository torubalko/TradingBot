using System.Runtime.InteropServices;

namespace SharpDX.XAPO.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct EchoInitdata
{
	public float MaxDelay;
}
