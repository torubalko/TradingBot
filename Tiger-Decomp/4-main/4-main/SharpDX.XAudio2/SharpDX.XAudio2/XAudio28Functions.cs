using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

internal static class XAudio28Functions
{
	public unsafe static void XAudio2Create(XAudio2 xAudio2Out, int flags, int xAudio2Processor)
	{
		IntPtr zero = IntPtr.Zero;
		Result result = XAudio2Create_(&zero, flags, xAudio2Processor);
		xAudio2Out.NativePointer = zero;
		result.CheckError();
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XAudio2Create")]
	private unsafe static extern int XAudio2Create_(void* arg0, int arg1, int arg2);

	public unsafe static void CreateAudioReverb(ComObject apoOut)
	{
		IntPtr zero = IntPtr.Zero;
		Result result = CreateAudioReverb_(&zero);
		apoOut.NativePointer = zero;
		result.CheckError();
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateAudioReverb")]
	private unsafe static extern int CreateAudioReverb_(void* arg0);

	public unsafe static void CreateAudioVolumeMeter(ComObject apoOut)
	{
		IntPtr zero = IntPtr.Zero;
		Result result = CreateAudioVolumeMeter_(&zero);
		apoOut.NativePointer = zero;
		result.CheckError();
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CreateAudioVolumeMeter")]
	private unsafe static extern int CreateAudioVolumeMeter_(void* arg0);
}
