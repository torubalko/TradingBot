using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2.Fx;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct VolumeMeterLevels
{
	internal IntPtr PeakLevelPointer;

	internal IntPtr RmsLevelsPointer;

	public int ChannelCount;
}
