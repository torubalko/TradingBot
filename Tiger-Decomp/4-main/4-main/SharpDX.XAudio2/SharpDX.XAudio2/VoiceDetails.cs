using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public struct VoiceDetails
{
	public VoiceFlags CreationFlags;

	public int ActiveFlags;

	public int InputChannelCount;

	public int InputSampleRate;
}
