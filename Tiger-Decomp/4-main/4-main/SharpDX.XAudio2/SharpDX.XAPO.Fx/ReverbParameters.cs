using System.Runtime.InteropServices;

namespace SharpDX.XAPO.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct ReverbParameters
{
	public float Diffusion;

	public float RoomSize;
}
