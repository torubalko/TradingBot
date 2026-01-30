using System;

namespace SharpDX.XAudio2;

public class SubmixVoice : Voice
{
	public SubmixVoice(XAudio2 device)
		: this(device, 2)
	{
	}

	public SubmixVoice(XAudio2 device, int inputChannels)
		: this(device, inputChannels, 44100)
	{
	}

	public SubmixVoice(XAudio2 device, int inputChannels, int inputSampleRate)
		: this(device, inputChannels, inputSampleRate, SubmixVoiceFlags.None, 0)
	{
	}

	public SubmixVoice(XAudio2 device, int inputChannels, int inputSampleRate, SubmixVoiceFlags flags, int processingStage)
		: this(device, inputChannels, inputSampleRate, flags, processingStage, null)
	{
	}

	public unsafe SubmixVoice(XAudio2 device, int inputChannels, int inputSampleRate, SubmixVoiceFlags flags, int processingStage, EffectDescriptor[] effectDescriptors)
		: base(device)
	{
		if (effectDescriptors != null)
		{
			EffectChain value = default(EffectChain);
			EffectDescriptor.__Native[] array = new EffectDescriptor.__Native[effectDescriptors.Length];
			for (int i = 0; i < array.Length; i++)
			{
				effectDescriptors[i].__MarshalTo(ref array[i]);
			}
			value.EffectCount = array.Length;
			fixed (EffectDescriptor.__Native* ptr = &array[0])
			{
				void* ptr2 = ptr;
				value.EffectDescriptorPointer = (IntPtr)ptr2;
				device.CreateSubmixVoice(this, inputChannels, inputSampleRate, (int)flags, processingStage, null, value);
			}
		}
		else
		{
			device.CreateSubmixVoice(this, inputChannels, inputSampleRate, (int)flags, processingStage, null, null);
		}
	}

	public SubmixVoice(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator SubmixVoice(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new SubmixVoice(nativePtr);
		}
		return null;
	}
}
