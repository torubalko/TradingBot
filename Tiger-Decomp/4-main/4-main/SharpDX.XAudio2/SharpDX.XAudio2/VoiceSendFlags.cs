using System;

namespace SharpDX.XAudio2;

[Flags]
public enum VoiceSendFlags
{
	UseFilter = 0x80,
	None = 0
}
