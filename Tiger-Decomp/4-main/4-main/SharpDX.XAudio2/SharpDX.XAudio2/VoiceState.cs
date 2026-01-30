using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public struct VoiceState
{
	public IntPtr Context;

	public int BuffersQueued;

	public long SamplesPlayed;
}
