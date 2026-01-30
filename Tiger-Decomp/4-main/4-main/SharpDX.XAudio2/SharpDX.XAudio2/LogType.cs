using System;

namespace SharpDX.XAudio2;

[Flags]
public enum LogType
{
	Errors = 1,
	Warnings = 2,
	Information = 4,
	Detail = 8,
	ApiCalls = 0x10,
	FunctionCalls = 0x20,
	Timing = 0x40,
	Locks = 0x80,
	Memory = 0x100,
	Streaming = 0x1000
}
