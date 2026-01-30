using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public struct DebugConfiguration
{
	public int TraceMask;

	public int BreakMask;

	public RawBool LogThreadID;

	public RawBool LogFileline;

	public RawBool LogFunctionName;

	public RawBool LogTiming;
}
