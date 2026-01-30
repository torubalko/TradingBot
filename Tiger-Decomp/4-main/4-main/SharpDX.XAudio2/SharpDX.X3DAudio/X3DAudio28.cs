using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.X3DAudio;

internal class X3DAudio28
{
	public unsafe static void X3DAudioCalculate(ref X3DAudioHandle instance, Listener listenerRef, Emitter emitterRef, CalculateFlags flags, IntPtr dSPSettingsRef)
	{
		Listener.__Native @ref = default(Listener.__Native);
		listenerRef.__MarshalTo(ref @ref);
		Emitter.__Native ref2 = default(Emitter.__Native);
		emitterRef.__MarshalTo(ref ref2);
		fixed (X3DAudioHandle* ptr = &instance)
		{
			void* arg = ptr;
			X3DAudioCalculate_(arg, &@ref, &ref2, (int)flags, (void*)dSPSettingsRef);
		}
		listenerRef.__MarshalFree(ref @ref);
		emitterRef.__MarshalFree(ref ref2);
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "X3DAudioCalculate")]
	private unsafe static extern void X3DAudioCalculate_(void* arg0, void* arg1, void* arg2, int arg3, void* arg4);

	public unsafe static void X3DAudioInitialize(Speakers speakerChannelMask, float speedOfSound, out X3DAudioHandle instance)
	{
		instance = default(X3DAudioHandle);
		Result result;
		fixed (X3DAudioHandle* ptr = &instance)
		{
			void* arg = ptr;
			result = X3DAudioInitialize_((int)speakerChannelMask, speedOfSound, arg);
		}
		result.CheckError();
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "X3DAudioInitialize")]
	private unsafe static extern int X3DAudioInitialize_(int arg0, float arg1, void* arg2);
}
