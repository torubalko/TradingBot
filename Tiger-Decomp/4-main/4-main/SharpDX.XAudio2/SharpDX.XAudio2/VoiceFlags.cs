using System;

namespace SharpDX.XAudio2;

[Flags]
public enum VoiceFlags
{
	NoPitch = 2,
	NoSampleRateConversion = 4,
	UseFilter = 8,
	Nosamplesplayed = 0x100,
	None = 0
}
