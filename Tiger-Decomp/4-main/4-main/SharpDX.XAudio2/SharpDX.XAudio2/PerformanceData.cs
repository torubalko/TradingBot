using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
public struct PerformanceData
{
	public long AudioCyclesSinceLastQuery;

	public long TotalCyclesSinceLastQuery;

	public int MinimumCyclesPerQuantum;

	public int MaximumCyclesPerQuantum;

	public int MemoryUsageInBytes;

	public int CurrentLatencyInSamples;

	public int GlitchesSinceEngineStarted;

	public int ActiveSourceVoiceCount;

	public int TotalSourceVoiceCount;

	public int ActiveSubmixVoiceCount;

	public int ActiveResamplerCount;

	public int ActiveMatrixMixCount;

	public int ActiveXmaSourceVoices;

	public int ActiveXmaStreams;
}
