using System;
using SharpDX.Multimedia;

namespace SharpDX.XAudio2;

public class MasteringVoice : Voice
{
	public int ChannelMask
	{
		get
		{
			if (device.Version == XAudio2Version.Version27)
			{
				return 0;
			}
			GetChannelMask(out var channelmaskRef);
			return channelmaskRef;
		}
	}

	public MasteringVoice(XAudio2 device, int inputChannels = 2, int inputSampleRate = 44100)
		: base(device)
	{
		if (device.Version == XAudio2Version.Version27)
		{
			device.CreateMasteringVoice27(this, inputChannels, inputSampleRate, 0, 0, null);
		}
		else
		{
			device.CreateMasteringVoice(this, inputChannels, inputSampleRate, 0, null, null, AudioStreamCategory.GameEffects);
		}
	}

	public MasteringVoice(XAudio2 device, int inputChannels, int inputSampleRate, string deviceId)
		: base(device)
	{
		device.CreateMasteringVoice(this, inputChannels, inputSampleRate, 0, deviceId, null, AudioStreamCategory.GameEffects);
	}

	public MasteringVoice(XAudio2 device, int inputChannels, int inputSampleRate, int deviceIndex)
		: base(device)
	{
		device.CreateMasteringVoice27(this, inputChannels, inputSampleRate, 0, deviceIndex, null);
	}

	public MasteringVoice(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator MasteringVoice(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new MasteringVoice(nativePtr);
		}
		return null;
	}

	public unsafe void GetChannelMask(out int channelmaskRef)
	{
		Result result;
		fixed (int* ptr = &channelmaskRef)
		{
			void* ptr2 = ptr;
			result = ((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)19 * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
		result.CheckError();
	}
}
