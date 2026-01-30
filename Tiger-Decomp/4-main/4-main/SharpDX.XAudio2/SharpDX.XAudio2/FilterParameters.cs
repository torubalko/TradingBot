using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public struct FilterParameters
{
	public FilterType Type;

	public float Frequency;

	public float OneOverQ;
}
