using System;

namespace SharpDX.XAudio2;

[Flags]
public enum BufferFlags
{
	EndOfStream = 0x40,
	None = 0
}
