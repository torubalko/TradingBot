using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.XAudio2;

public class SourceVoice : Voice
{
	public delegate void VoidAction();

	public struct VoiceErrorArgs
	{
		public IntPtr Pointer;

		public Result Result;

		public VoiceErrorArgs(IntPtr pointer, Result result)
		{
			Pointer = pointer;
			Result = result;
		}
	}

	private class VoiceCallbackImpl : CallbackBase, VoiceCallback, ICallbackable, IDisposable
	{
		private SourceVoice Voice { get; set; }

		public VoiceCallbackImpl(SourceVoice voice)
		{
			Voice = voice;
		}

		void VoiceCallback.OnVoiceProcessingPassStart(int bytesRequired)
		{
			if (Voice.ProcessingPassStart != null)
			{
				Voice.ProcessingPassStart(bytesRequired);
			}
		}

		void VoiceCallback.OnVoiceProcessingPassEnd()
		{
			if (Voice.ProcessingPassEnd != null)
			{
				Voice.ProcessingPassEnd();
			}
		}

		void VoiceCallback.OnStreamEnd()
		{
			if (Voice.StreamEnd != null)
			{
				Voice.StreamEnd();
			}
		}

		void VoiceCallback.OnBufferStart(IntPtr context)
		{
			if (Voice.BufferStart != null)
			{
				Voice.BufferStart(context);
			}
		}

		void VoiceCallback.OnBufferEnd(IntPtr context)
		{
			if (Voice.BufferEnd != null)
			{
				Voice.BufferEnd(context);
			}
		}

		void VoiceCallback.OnLoopEnd(IntPtr context)
		{
			if (Voice.LoopEnd != null)
			{
				Voice.LoopEnd(context);
			}
		}

		void VoiceCallback.OnVoiceError(IntPtr context, Result error)
		{
			if (Voice.VoiceError != null)
			{
				Voice.VoiceError(new VoiceErrorArgs(context, error));
			}
		}
	}

	private VoiceCallbackImpl voiceCallbackImpl;

	public VoiceState State => GetState(0);

	public int SourceSampleRate
	{
		set
		{
			SetSourceSampleRate(value);
		}
	}

	public event Action<int> ProcessingPassStart;

	public event VoidAction ProcessingPassEnd;

	public event VoidAction StreamEnd;

	public event Action<IntPtr> BufferStart;

	public event Action<IntPtr> BufferEnd;

	public event Action<IntPtr> LoopEnd;

	public event Action<VoiceErrorArgs> VoiceError;

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat)
		: this(device, sourceFormat, enableCallbackEvents: true)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, bool enableCallbackEvents)
		: this(device, sourceFormat, VoiceFlags.None, 1f, enableCallbackEvents)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags)
		: this(device, sourceFormat, flags, enableCallbackEvents: true)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, bool enableCallbackEvents)
		: this(device, sourceFormat, flags, 1f, enableCallbackEvents)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio)
		: this(device, sourceFormat, flags, maxFrequencyRatio, enableCallbackEvents: true)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio, VoiceCallback callback)
		: this(device, sourceFormat, flags, maxFrequencyRatio, callback, null)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio, bool enableCallbackEvents)
		: this(device, sourceFormat, flags, maxFrequencyRatio, enableCallbackEvents, null)
	{
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio, VoiceCallback callback, EffectDescriptor[] effectDescriptors)
		: base(device)
	{
		CreateSourceVoice(device, sourceFormat, flags, maxFrequencyRatio, callback, effectDescriptors);
	}

	public SourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio, bool enableCallbackEvents, EffectDescriptor[] effectDescriptors)
		: base(device)
	{
		CreateSourceVoice(device, sourceFormat, flags, maxFrequencyRatio, enableCallbackEvents ? (voiceCallbackImpl = new VoiceCallbackImpl(this)) : null, effectDescriptors);
	}

	private unsafe void CreateSourceVoice(XAudio2 device, WaveFormat sourceFormat, VoiceFlags flags, float maxFrequencyRatio, VoiceCallback callback, EffectDescriptor[] effectDescriptors)
	{
		IntPtr intPtr = WaveFormat.MarshalToPtr(sourceFormat);
		try
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
					device.CreateSourceVoice(this, intPtr, flags, maxFrequencyRatio, callback, null, value);
					return;
				}
			}
			device.CreateSourceVoice(this, intPtr, flags, maxFrequencyRatio, callback, null, null);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	public void Start()
	{
		Start(0, 0);
	}

	public void SetFrequencyRatio(float ratio)
	{
		SetFrequencyRatio(ratio, 0);
	}

	public void Start(int operationSet)
	{
		Start(0, operationSet);
	}

	public void Stop()
	{
		Stop(PlayFlags.None);
	}

	public void Stop(int operationSet)
	{
		Stop(PlayFlags.None, operationSet);
	}

	public unsafe void SubmitSourceBuffer(AudioBuffer bufferRef, uint[] decodedXMWAPacketInfo)
	{
		if (decodedXMWAPacketInfo != null)
		{
			fixed (uint* ptr = decodedXMWAPacketInfo)
			{
				void* ptr2 = ptr;
				BufferWma value = default(BufferWma);
				value.PacketCount = decodedXMWAPacketInfo.Length;
				value.DecodedPacketCumulativeBytesPointer = (IntPtr)ptr2;
				SubmitSourceBuffer(bufferRef, value);
			}
		}
		else
		{
			SubmitSourceBuffer(bufferRef, (BufferWma?)null);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			Utilities.Dispose(ref voiceCallbackImpl);
		}
		base.Dispose(disposing);
	}

	public SourceVoice(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator SourceVoice(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new SourceVoice(nativePtr);
		}
		return null;
	}

	internal unsafe void Start(int flags, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)19 * (nint)sizeof(void*))))(_nativePointer, flags, operationSet)).CheckError();
	}

	public unsafe void Stop(PlayFlags flags, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)20 * (nint)sizeof(void*))))(_nativePointer, (int)flags, operationSet)).CheckError();
	}

	internal unsafe void SubmitSourceBuffer(AudioBuffer bufferRef, BufferWma? bufferWMARef)
	{
		AudioBuffer.__Native @ref = default(AudioBuffer.__Native);
		bufferRef.__MarshalTo(ref @ref);
		BufferWma value = default(BufferWma);
		if (bufferWMARef.HasValue)
		{
			value = bufferWMARef.Value;
		}
		void* nativePointer = _nativePointer;
		AudioBuffer.__Native* num = &@ref;
		BufferWma* intPtr = ((!bufferWMARef.HasValue) ? null : (&value));
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)21 * (nint)sizeof(void*))))(nativePointer, num, intPtr);
		bufferRef.__MarshalFree(ref @ref);
		result.CheckError();
	}

	public unsafe void FlushSourceBuffers()
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)22 * (nint)sizeof(void*))))(_nativePointer)).CheckError();
	}

	public unsafe void Discontinuity()
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)23 * (nint)sizeof(void*))))(_nativePointer)).CheckError();
	}

	public unsafe void ExitLoop(int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)24 * (nint)sizeof(void*))))(_nativePointer, operationSet)).CheckError();
	}

	internal unsafe VoiceState GetState(int flags)
	{
		VoiceState result = default(VoiceState);
		((delegate* unmanaged[Stdcall]<void*, void*, int, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)25 * (nint)sizeof(void*))))(_nativePointer, &result, flags);
		return result;
	}

	public unsafe void SetFrequencyRatio(float ratio, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, float, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)26 * (nint)sizeof(void*))))(_nativePointer, ratio, operationSet)).CheckError();
	}

	public unsafe void GetFrequencyRatio(out float ratioRef)
	{
		fixed (float* ptr = &ratioRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)27 * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
	}

	internal unsafe void SetSourceSampleRate(int newSourceSampleRate)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)28 * (nint)sizeof(void*))))(_nativePointer, newSourceSampleRate)).CheckError();
	}
}
