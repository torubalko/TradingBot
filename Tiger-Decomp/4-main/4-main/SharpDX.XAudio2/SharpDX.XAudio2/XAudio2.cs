using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.XAudio2;

[Guid("2B02E3CF-2E0B-4ec3-BE45-1B2A3FE7210D")]
public class XAudio2 : ComObject
{
	private class EngineCallbackImpl : CallbackBase, EngineCallback, ICallbackable, IDisposable
	{
		private XAudio2 XAudio2 { get; set; }

		IDisposable ICallbackable.Shadow { get; set; }

		public EngineCallbackImpl(XAudio2 xAudio2)
		{
			XAudio2 = xAudio2;
		}

		public void OnProcessingPassStart()
		{
			XAudio2.ProcessingPassStart?.Invoke(this, EventArgs.Empty);
		}

		public void OnProcessingPassEnd()
		{
			XAudio2.ProcessingPassEnd?.Invoke(this, EventArgs.Empty);
		}

		public void OnCriticalError(Result error)
		{
			XAudio2.CriticalError?.Invoke(this, new ErrorEventArgs(error));
		}
	}

	private EngineCallbackImpl engineCallbackImpl;

	private IntPtr engineShadowPtr;

	private static Guid CLSID_XAudio27 = new Guid("5a508685-a254-4fba-9b82-9a24b00306af");

	private static Guid CLSID_XAudio27_Debug = new Guid("db05ea35-0329-4d4b-a53a-6dead03d3852");

	private static Guid IID_IXAudio2 = new Guid("8bcf1f58-9fe7-4583-8ac6-e2adc465c8bb");

	public const int MaximumBufferBytes = int.MinValue;

	public const int MaximumQueuedBuffers = 64;

	public const int MaximumAudioChannels = 64;

	public const int MinimumSampleRate = 1000;

	public const int MaximumSampleRate = 200000;

	public const float MaximumVolumeLevel = 16777216f;

	public const float MinimumFrequencyRatio = 0.0009765625f;

	public const float MaximumFrequencyRatio = 1024f;

	public const float DefaultFrequencyRatio = 2f;

	public const float MaximumFilterOneOverQ = 1.5f;

	public const float MaximumFilterFrequency = 1f;

	public const int MaximumLoopCount = 254;

	public const int CommitNow = 0;

	public const int CommitAll = 0;

	public const int NoLoopRegion = 0;

	public const int DefaultChannels = 0;

	public const int DefaultSampleRate = 0;

	private int RegisterForCallbacks__vtbl_index = 3;

	private int UnregisterForCallbacks__vtbl_index = 4;

	private int CreateSourceVoice__vtbl_index = 5;

	private int CreateSubmixVoice__vtbl_index = 6;

	private int CreateMasteringVoice__vtbl_index = 7;

	private int StartEngine__vtbl_index = 8;

	private int StopEngine__vtbl_index = 9;

	private int CommitChanges__vtbl_index = 10;

	private int GetPerformanceData__vtbl_index = 11;

	private int SetDebugConfiguration__vtbl_index = 12;

	public XAudio2Version Version { get; private set; }

	public int DeviceCount
	{
		get
		{
			CheckVersion27();
			GetDeviceCount(out var countRef);
			return countRef;
		}
	}

	public PerformanceData PerformanceData
	{
		get
		{
			GetPerformanceData(out var perfDataRef);
			return perfDataRef;
		}
	}

	public event EventHandler ProcessingPassStart;

	public event EventHandler ProcessingPassEnd;

	public event EventHandler<ErrorEventArgs> CriticalError;

	public XAudio2()
		: this(XAudio2Version.Default)
	{
	}

	public XAudio2(XAudio2Version requestedVersion)
		: this(XAudio2Flags.None, ProcessorSpecifier.Processor1, requestedVersion)
	{
	}

	public XAudio2(XAudio2Flags flags, ProcessorSpecifier processorSpecifier, XAudio2Version requestedVersion = XAudio2Version.Default)
		: base(IntPtr.Zero)
	{
		XAudio2Version[] array = ((requestedVersion != XAudio2Version.Default) ? new XAudio2Version[1] { requestedVersion } : new XAudio2Version[3]
		{
			XAudio2Version.Version29,
			XAudio2Version.Version28,
			XAudio2Version.Version27
		});
		for (int i = 0; i < array.Length; i++)
		{
			switch (array[i])
			{
			case XAudio2Version.Version27:
			{
				Guid clsid = ((flags == XAudio2Flags.DebugEngine) ? CLSID_XAudio27_Debug : CLSID_XAudio27);
				if ((requestedVersion == XAudio2Version.Default || requestedVersion == XAudio2Version.Version27) && Utilities.TryCreateComInstance(clsid, Utilities.CLSCTX.ClsctxInprocServer, IID_IXAudio2, this))
				{
					SetupVtblFor27();
					Initialize(0, processorSpecifier);
					Version = XAudio2Version.Version27;
				}
				break;
			}
			case XAudio2Version.Version28:
				try
				{
					XAudio28Functions.XAudio2Create(this, 0, (int)processorSpecifier);
					Version = XAudio2Version.Version28;
				}
				catch (DllNotFoundException)
				{
				}
				break;
			}
			if (Version != XAudio2Version.Default)
			{
				break;
			}
		}
		if (Version == XAudio2Version.Default)
		{
			throw new DllNotFoundException(string.Format("Unable to find XAudio2 dlls for requested versions [{0}], not installed on this machine", (requestedVersion == XAudio2Version.Default) ? "2.7, 2.8 or 2.9" : requestedVersion.ToString()));
		}
		engineCallbackImpl = new EngineCallbackImpl(this);
		engineShadowPtr = EngineShadow.ToIntPtr(engineCallbackImpl);
		RegisterForCallbacks(engineCallbackImpl);
	}

	private void SetupVtblFor27()
	{
		RegisterForCallbacks__vtbl_index += 3;
		UnregisterForCallbacks__vtbl_index += 3;
		CreateSourceVoice__vtbl_index += 3;
		CreateSubmixVoice__vtbl_index += 3;
		CreateMasteringVoice__vtbl_index += 3;
		StartEngine__vtbl_index += 3;
		StopEngine__vtbl_index += 3;
		CommitChanges__vtbl_index += 3;
		GetPerformanceData__vtbl_index += 3;
		SetDebugConfiguration__vtbl_index += 3;
	}

	private void CheckVersion27()
	{
		if (Version != XAudio2Version.Version27)
		{
			throw new InvalidOperationException(string.Concat("This method is only valid on the XAudio 2.7 requestedVersion [Current is: ", Version, "]"));
		}
	}

	private unsafe void GetDeviceCount(out int countRef)
	{
		Result result;
		fixed (int* ptr = &countRef)
		{
			void* ptr2 = ptr;
			result = ((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)3 * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
		result.CheckError();
	}

	internal unsafe void CreateMasteringVoice27(MasteringVoice masteringVoiceOut, int inputChannels, int inputSampleRate, int flags, int deviceIndex, EffectChain? effectChainRef)
	{
		IntPtr zero = IntPtr.Zero;
		EffectChain value = default(EffectChain);
		if (effectChainRef.HasValue)
		{
			value = effectChainRef.Value;
		}
		void* nativePointer = _nativePointer;
		IntPtr* num = &zero;
		void* intPtr = (effectChainRef.HasValue ? (&value) : ((void*)IntPtr.Zero));
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, int, int, int, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)10 * (nint)sizeof(void*))))(nativePointer, num, inputChannels, inputSampleRate, flags, deviceIndex, intPtr);
		masteringVoiceOut.NativePointer = zero;
		result.CheckError();
	}

	public DeviceDetails GetDeviceDetails(int index)
	{
		CheckVersion27();
		GetDeviceDetails(index, out var deviceDetailsRef);
		return deviceDetailsRef;
	}

	private unsafe void GetDeviceDetails(int index, out DeviceDetails deviceDetailsRef)
	{
		DeviceDetails.__Native @ref = default(DeviceDetails.__Native);
		Result result = ((delegate* unmanaged[Stdcall]<void*, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)4 * (nint)sizeof(void*))))(_nativePointer, index, &@ref);
		deviceDetailsRef = default(DeviceDetails);
		deviceDetailsRef.__MarshalFrom(ref @ref);
		result.CheckError();
	}

	private unsafe void Initialize(int flags, ProcessorSpecifier xAudio2Processor)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)5 * (nint)sizeof(void*))))(_nativePointer, flags, (int)xAudio2Processor)).CheckError();
	}

	public static float AmplitudeRatioToDecibels(float volume)
	{
		if (volume == 0f)
		{
			return float.MinValue;
		}
		return (float)(Math.Log10(volume) * 20.0);
	}

	public static float CutoffFrequencyToRadians(float cutoffFrequency, int sampleRate)
	{
		if ((double)(int)cutoffFrequency * 6.0 >= (double)sampleRate)
		{
			return 1f;
		}
		return (float)(Math.Sin((double)cutoffFrequency * Math.PI / (double)sampleRate) * 2.0);
	}

	public static float RadiansToCutoffFrequency(float radians, float sampleRate)
	{
		return (float)(Math.Asin((double)radians * 0.5) * (double)sampleRate / Math.PI);
	}

	public static float DecibelsToAmplitudeRatio(float decibels)
	{
		return (float)Math.Pow(10.0, decibels / 20f);
	}

	public static float FrequencyRatioToSemitones(float frequencyRatio)
	{
		return (float)(Math.Log10(frequencyRatio) * 12.0 * Math.PI);
	}

	public static float SemitonesToFrequencyRatio(float semitones)
	{
		return (float)Math.Pow(2.0, semitones / 12f);
	}

	public void CommitChanges()
	{
		CommitChanges(0);
	}

	protected override void Dispose(bool disposing)
	{
		if (engineCallbackImpl != null)
		{
			UnregisterForCallbacks(engineCallbackImpl);
		}
		if (disposing && engineCallbackImpl != null)
		{
			engineCallbackImpl.Dispose();
		}
		Version = XAudio2Version.Default;
		base.Dispose(disposing);
	}

	public XAudio2(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator XAudio2(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new XAudio2(nativePtr);
		}
		return null;
	}

	internal unsafe void RegisterForCallbacks(EngineCallback callbackRef)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CppObject.ToCallbackPtr<EngineCallback>(callbackRef);
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)RegisterForCallbacks__vtbl_index * (nint)sizeof(void*))))(_nativePointer, (void*)zero)).CheckError();
	}

	internal unsafe void UnregisterForCallbacks(EngineCallback callbackRef)
	{
		IntPtr zero = IntPtr.Zero;
		zero = CppObject.ToCallbackPtr<EngineCallback>(callbackRef);
		((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)UnregisterForCallbacks__vtbl_index * (nint)sizeof(void*))))(_nativePointer, (void*)zero);
	}

	internal unsafe void CreateSourceVoice(SourceVoice sourceVoiceOut, IntPtr sourceFormatRef, VoiceFlags flags, float maxFrequencyRatio, VoiceCallback callbackRef, VoiceSendDescriptors? sendListRef, EffectChain? effectChainRef)
	{
		IntPtr zero = IntPtr.Zero;
		IntPtr zero2 = IntPtr.Zero;
		zero2 = CppObject.ToCallbackPtr<VoiceCallback>(callbackRef);
		VoiceSendDescriptors value = default(VoiceSendDescriptors);
		if (sendListRef.HasValue)
		{
			value = sendListRef.Value;
		}
		EffectChain value2 = default(EffectChain);
		if (effectChainRef.HasValue)
		{
			value2 = effectChainRef.Value;
		}
		void* nativePointer = _nativePointer;
		IntPtr* num = &zero;
		void* intPtr = (void*)sourceFormatRef;
		void* intPtr2 = (void*)zero2;
		VoiceSendDescriptors* intPtr3 = ((!sendListRef.HasValue) ? null : (&value));
		EffectChain* intPtr4 = ((!effectChainRef.HasValue) ? null : (&value2));
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, int, float, void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)CreateSourceVoice__vtbl_index * (nint)sizeof(void*))))(nativePointer, num, intPtr, (int)flags, maxFrequencyRatio, intPtr2, intPtr3, intPtr4);
		sourceVoiceOut.NativePointer = zero;
		result.CheckError();
	}

	internal unsafe void CreateSubmixVoice(SubmixVoice submixVoiceOut, int inputChannels, int inputSampleRate, int flags, int processingStage, VoiceSendDescriptors? sendListRef, EffectChain? effectChainRef)
	{
		IntPtr zero = IntPtr.Zero;
		VoiceSendDescriptors value = default(VoiceSendDescriptors);
		if (sendListRef.HasValue)
		{
			value = sendListRef.Value;
		}
		EffectChain value2 = default(EffectChain);
		if (effectChainRef.HasValue)
		{
			value2 = effectChainRef.Value;
		}
		void* nativePointer = _nativePointer;
		IntPtr* num = &zero;
		VoiceSendDescriptors* intPtr = ((!sendListRef.HasValue) ? null : (&value));
		EffectChain* intPtr2 = ((!effectChainRef.HasValue) ? null : (&value2));
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, int, int, int, int, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)CreateSubmixVoice__vtbl_index * (nint)sizeof(void*))))(nativePointer, num, inputChannels, inputSampleRate, flags, processingStage, intPtr, intPtr2);
		submixVoiceOut.NativePointer = zero;
		result.CheckError();
	}

	internal unsafe void CreateMasteringVoice(MasteringVoice masteringVoiceOut, int inputChannels, int inputSampleRate, int flags, string szDeviceId, EffectChain? effectChainRef, AudioStreamCategory streamCategory)
	{
		IntPtr zero = IntPtr.Zero;
		EffectChain value = default(EffectChain);
		if (effectChainRef.HasValue)
		{
			value = effectChainRef.Value;
		}
		Result result;
		fixed (char* ptr = szDeviceId)
		{
			void* nativePointer = _nativePointer;
			IntPtr* num = &zero;
			EffectChain* intPtr = ((!effectChainRef.HasValue) ? null : (&value));
			result = ((delegate* unmanaged[Stdcall]<void*, void*, int, int, int, void*, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)CreateMasteringVoice__vtbl_index * (nint)sizeof(void*))))(nativePointer, num, inputChannels, inputSampleRate, flags, ptr, intPtr, (int)streamCategory);
		}
		masteringVoiceOut.NativePointer = zero;
		result.CheckError();
	}

	public unsafe void StartEngine()
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)StartEngine__vtbl_index * (nint)sizeof(void*))))(_nativePointer)).CheckError();
	}

	public unsafe void StopEngine()
	{
		((delegate* unmanaged[Stdcall]<void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)StopEngine__vtbl_index * (nint)sizeof(void*))))(_nativePointer);
	}

	public unsafe void CommitChanges(int operationSet = 0)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)CommitChanges__vtbl_index * (nint)sizeof(void*))))(_nativePointer, operationSet)).CheckError();
	}

	internal unsafe void GetPerformanceData(out PerformanceData perfDataRef)
	{
		perfDataRef = default(PerformanceData);
		fixed (PerformanceData* ptr = &perfDataRef)
		{
			void* ptr2 = ptr;
			((delegate* unmanaged[Stdcall]<void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)GetPerformanceData__vtbl_index * (nint)sizeof(void*))))(_nativePointer, ptr2);
		}
	}

	public unsafe void SetDebugConfiguration(DebugConfiguration debugConfigurationRef, IntPtr reservedRef)
	{
		((delegate* unmanaged[Stdcall]<void*, void*, void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)SetDebugConfiguration__vtbl_index * (nint)sizeof(void*))))(_nativePointer, &debugConfigurationRef, (void*)reservedRef);
	}
}
