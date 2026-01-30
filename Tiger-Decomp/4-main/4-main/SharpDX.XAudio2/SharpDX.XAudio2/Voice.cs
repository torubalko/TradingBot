using System;
using SharpDX.Mathematics.Interop;

namespace SharpDX.XAudio2;

public class Voice : CppObject
{
	protected readonly XAudio2 device;

	public VoiceDetails VoiceDetails
	{
		get
		{
			GetVoiceDetails(out var voiceDetailsRef);
			if (device.Version == XAudio2Version.Version27)
			{
				voiceDetailsRef.InputSampleRate = voiceDetailsRef.InputChannelCount;
				voiceDetailsRef.InputChannelCount = voiceDetailsRef.ActiveFlags;
				voiceDetailsRef.ActiveFlags = 0;
			}
			return voiceDetailsRef;
		}
	}

	internal VoiceSendDescriptors OutputVoices
	{
		set
		{
			SetOutputVoices(value);
		}
	}

	protected Voice(XAudio2 device)
		: base(IntPtr.Zero)
	{
		this.device = device;
	}

	public void EnableEffect(int effectIndex)
	{
		EnableEffect(effectIndex, 0);
	}

	public void DisableEffect(int effectIndex)
	{
		DisableEffect(effectIndex, 0);
	}

	public unsafe T GetEffectParameters<T>(int effectIndex) where T : struct
	{
		T data = default(T);
		byte* ptr = stackalloc byte[(int)(uint)Utilities.SizeOf<T>()];
		GetEffectParameters(effectIndex, (IntPtr)ptr, Utilities.SizeOf<T>());
		Utilities.Read((IntPtr)ptr, ref data);
		return data;
	}

	public unsafe void GetEffectParameters(int effectIndex, byte[] effectParameters)
	{
		fixed (byte* ptr = &effectParameters[0])
		{
			void* ptr2 = ptr;
			GetEffectParameters(effectIndex, (IntPtr)ptr2, effectParameters.Length);
		}
	}

	public void SetEffectParameters(int effectIndex, byte[] effectParameter)
	{
		SetEffectParameters(effectIndex, effectParameter, 0);
	}

	public unsafe void SetEffectParameters(int effectIndex, byte[] effectParameter, int operationSet)
	{
		fixed (byte* ptr = &effectParameter[0])
		{
			void* ptr2 = ptr;
			SetEffectParameters(effectIndex, (IntPtr)ptr2, effectParameter.Length, operationSet);
		}
	}

	public void SetEffectParameters<T>(int effectIndex, T effectParameter) where T : struct
	{
		SetEffectParameters(effectIndex, effectParameter, 0);
	}

	public unsafe void SetEffectParameters<T>(int effectIndex, T effectParameter, int operationSet) where T : struct
	{
		byte* ptr = stackalloc byte[(int)(uint)Utilities.SizeOf<T>()];
		Utilities.Write((IntPtr)ptr, ref effectParameter);
		SetEffectParameters(effectIndex, (IntPtr)ptr, Utilities.SizeOf<T>(), operationSet);
	}

	public unsafe void SetEffectChain(params EffectDescriptor[] effectDescriptors)
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
				SetEffectChain(value);
			}
		}
		else
		{
			SetEffectChain((EffectChain?)null);
		}
	}

	public unsafe void SetOutputVoices(params VoiceSendDescriptor[] outputVoices)
	{
		if (outputVoices != null)
		{
			VoiceSendDescriptors value = new VoiceSendDescriptors
			{
				SendCount = outputVoices.Length
			};
			if (outputVoices.Length != 0)
			{
				VoiceSendDescriptor.__Native[] array = new VoiceSendDescriptor.__Native[outputVoices.Length];
				for (int i = 0; i < outputVoices.Length; i++)
				{
					outputVoices[i].__MarshalTo(ref array[i]);
				}
				fixed (VoiceSendDescriptor.__Native* ptr = &array[0])
				{
					void* ptr2 = ptr;
					value.SendPointer = (IntPtr)ptr2;
					SetOutputVoices(value);
				}
			}
			else
			{
				value.SendPointer = IntPtr.Zero;
			}
		}
		else
		{
			SetOutputVoices((VoiceSendDescriptors?)null);
		}
	}

	public void SetOutputMatrix(int sourceChannels, int destinationChannels, float[] levelMatrixRef)
	{
		SetOutputMatrix(sourceChannels, destinationChannels, levelMatrixRef, 0);
	}

	public void SetOutputMatrix(Voice destinationVoiceRef, int sourceChannels, int destinationChannels, float[] levelMatrixRef)
	{
		SetOutputMatrix(destinationVoiceRef, sourceChannels, destinationChannels, levelMatrixRef, 0);
	}

	public void SetOutputMatrix(int sourceChannels, int destinationChannels, float[] levelMatrixRef, int operationSet)
	{
		SetOutputMatrix(null, sourceChannels, destinationChannels, levelMatrixRef, operationSet);
	}

	public Voice(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator Voice(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new Voice(nativePtr);
		}
		return null;
	}

	public unsafe void GetVoiceDetails(out VoiceDetails voiceDetailsRef)
	{
		voiceDetailsRef = default(VoiceDetails);
		fixed (VoiceDetails* ptr = &voiceDetailsRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(*(IntPtr**)_nativePointer)))(_nativePointer, ptr2);
		}
	}

	internal unsafe void SetOutputVoices(VoiceSendDescriptors? sendListRef)
	{
		VoiceSendDescriptors value = default(VoiceSendDescriptors);
		if (sendListRef.HasValue)
		{
			value = sendListRef.Value;
		}
		void* nativePointer = _nativePointer;
		VoiceSendDescriptors* intPtr = ((!sendListRef.HasValue) ? null : (&value));
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + sizeof(void*))))(nativePointer, intPtr)).CheckError();
	}

	internal unsafe void SetEffectChain(EffectChain? effectChainRef)
	{
		EffectChain value = default(EffectChain);
		if (effectChainRef.HasValue)
		{
			value = effectChainRef.Value;
		}
		void* nativePointer = _nativePointer;
		EffectChain* intPtr = ((!effectChainRef.HasValue) ? null : (&value));
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)2 * (nint)sizeof(void*))))(nativePointer, intPtr)).CheckError();
	}

	public unsafe void EnableEffect(int effectIndex, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)3 * (nint)sizeof(void*))))(_nativePointer, effectIndex, operationSet)).CheckError();
	}

	public unsafe void DisableEffect(int effectIndex, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)4 * (nint)sizeof(void*))))(_nativePointer, effectIndex, operationSet)).CheckError();
	}

	public unsafe void IsEffectEnabled(int effectIndex, out RawBool enabledRef)
	{
		enabledRef = default(RawBool);
		fixed (RawBool* ptr = &enabledRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, int, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)5 * (nint)sizeof(void*))))(_nativePointer, effectIndex, ptr2);
		}
	}

	internal unsafe void SetEffectParameters(int effectIndex, IntPtr parametersRef, int parametersByteSize, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)6 * (nint)sizeof(void*))))(_nativePointer, effectIndex, (void*)parametersRef, parametersByteSize, operationSet)).CheckError();
	}

	internal unsafe void GetEffectParameters(int effectIndex, IntPtr parametersRef, int parametersByteSize)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)7 * (nint)sizeof(void*))))(_nativePointer, effectIndex, (void*)parametersRef, parametersByteSize)).CheckError();
	}

	public unsafe void SetFilterParameters(FilterParameters parametersRef, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)8 * (nint)sizeof(void*))))(_nativePointer, &parametersRef, operationSet)).CheckError();
	}

	public unsafe void GetFilterParameters(out FilterParameters parametersRef)
	{
		parametersRef = default(FilterParameters);
		fixed (FilterParameters* ptr = &parametersRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)9 * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
	}

	public unsafe void SetOutputFilterParameters(Voice destinationVoiceRef, FilterParameters parametersRef, int operationSet = 0)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CppObject.ToCallbackPtr<Voice>(destinationVoiceRef);
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)10 * (nint)sizeof(void*))))(_nativePointer, (void*)zero, &parametersRef, operationSet)).CheckError();
	}

	public unsafe void GetOutputFilterParameters(Voice destinationVoiceRef, out FilterParameters parametersRef)
	{
		IntPtr zero = IntPtr.Zero;
		parametersRef = default(FilterParameters);
		zero = CppObject.ToCallbackPtr<Voice>(destinationVoiceRef);
		fixed (FilterParameters* ptr = &parametersRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)11 * (nint)sizeof(void*))))(_nativePointer, (void*)zero, ptr2);
		}
	}

	public unsafe void SetVolume(float volume, int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, float, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)12 * (nint)sizeof(void*))))(_nativePointer, volume, operationSet)).CheckError();
	}

	public unsafe void GetVolume(out float volumeRef)
	{
		fixed (float* ptr = &volumeRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)13 * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
	}

	public unsafe void SetChannelVolumes(int channels, float[] volumesRef, int operationSet = 0)
	{
		Result result;
		fixed (float* ptr = volumesRef)
		{
			void* ptr2 = ptr;
			result = ((delegate* unmanaged[Stdcall]<void*, int, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)14 * (nint)sizeof(void*))))(_nativePointer, channels, ptr2, operationSet);
		}
		result.CheckError();
	}

	public unsafe void GetChannelVolumes(int channels, float[] volumesRef)
	{
		fixed (float* ptr = volumesRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, int, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)15 * (nint)sizeof(void*))))(_nativePointer, channels, ptr2);
		}
	}

	public unsafe void SetOutputMatrix(Voice destinationVoiceRef, int sourceChannels, int destinationChannels, float[] levelMatrixRef, int operationSet = 0)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CppObject.ToCallbackPtr<Voice>(destinationVoiceRef);
		Result result;
		fixed (float* ptr = levelMatrixRef)
		{
			void* ptr2 = ptr;
			result = ((delegate* unmanaged[Stdcall]<void*, void*, int, int, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)16 * (nint)sizeof(void*))))(_nativePointer, (void*)zero, sourceChannels, destinationChannels, ptr2, operationSet);
		}
		result.CheckError();
	}

	public unsafe void GetOutputMatrix(Voice destinationVoiceRef, int sourceChannels, int destinationChannels, float[] levelMatrixRef)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CppObject.ToCallbackPtr<Voice>(destinationVoiceRef);
		fixed (float* ptr = levelMatrixRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, int, int, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)17 * (nint)sizeof(void*))))(_nativePointer, (void*)zero, sourceChannels, destinationChannels, ptr2);
		}
	}

	public unsafe void DestroyVoice()
	{
		((delegate* unmanaged[Stdcall]<void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)18 * (nint)sizeof(void*))))(_nativePointer);
	}
}
