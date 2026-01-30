using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;
using SharpDX.Multimedia;

namespace SharpDX.XAPO;

[Guid("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
public class AudioProcessorNative : ComObject, AudioProcessor, AudioProcessor27, IUnknown, ICallbackable, IDisposable
{
	public RegistrationProperties RegistrationProperties
	{
		get
		{
			GetRegistrationProperties_(out var registrationPropertiesOut);
			return registrationPropertiesOut;
		}
	}

	public RegistrationProperties RegistrationProperties_
	{
		get
		{
			GetRegistrationProperties_(out var registrationPropertiesOut);
			return registrationPropertiesOut;
		}
	}

	public bool IsInputFormatSupported(WaveFormat outputFormat, WaveFormat requestedInputFormat, out WaveFormat supportedInputFormat)
	{
		return IsInputFormatSupported_(ref outputFormat, ref requestedInputFormat, out supportedInputFormat).Success;
	}

	public bool IsOutputFormatSupported(WaveFormat inputFormat, WaveFormat requestedOutputFormat, out WaveFormat supportedOutputFormat)
	{
		return IsOutputFormatSupported_(ref inputFormat, ref requestedOutputFormat, out supportedOutputFormat).Success;
	}

	public void Initialize(DataStream stream)
	{
		if (stream == null)
		{
			Initialize_(IntPtr.Zero, 0);
		}
		else
		{
			Initialize_(stream.PositionPointer, (int)(stream.Length - stream.Position));
		}
	}

	public void Reset()
	{
		Reset_();
	}

	public void LockForProcess(LockParameters[] inputLockedParameters, LockParameters[] outputLockedParameters)
	{
		LockForProcess_(inputLockedParameters.Length, inputLockedParameters, outputLockedParameters.Length, outputLockedParameters);
	}

	public void UnlockForProcess()
	{
		UnlockForProcess_();
	}

	public void Process(BufferParameters[] inputProcessParameters, BufferParameters[] outputProcessParameters, bool isEnabled)
	{
		Process_(inputProcessParameters.Length, inputProcessParameters, outputProcessParameters.Length, outputProcessParameters, isEnabled);
	}

	public int CalcInputFrames(int outputFrameCount)
	{
		return CalcInputFrames(outputFrameCount);
	}

	public int CalcOutputFrames(int inputFrameCount)
	{
		return CalcOutputFrames(inputFrameCount);
	}

	public AudioProcessorNative(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator AudioProcessorNative(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new AudioProcessorNative(nativePtr);
		}
		return null;
	}

	internal unsafe void GetRegistrationProperties_(out RegistrationProperties registrationPropertiesOut)
	{
		RegistrationProperties.__Native @ref = default(RegistrationProperties.__Native);
		registrationPropertiesOut = default(RegistrationProperties);
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)3 * (nint)sizeof(void*))))(_nativePointer, &@ref);
		registrationPropertiesOut.__MarshalFrom(ref @ref);
		result.CheckError();
	}

	internal unsafe Result IsInputFormatSupported_(ref WaveFormat outputFormatRef, ref WaveFormat requestedInputFormatRef, out WaveFormat supportedInputFormatOut)
	{
		WaveFormat.__Native @ref = default(WaveFormat.__Native);
		WaveFormat.__Native ref2 = default(WaveFormat.__Native);
		WaveFormat.__Native ref3 = default(WaveFormat.__Native);
		supportedInputFormatOut = null;
		outputFormatRef.__MarshalTo(ref @ref);
		requestedInputFormatRef.__MarshalTo(ref ref2);
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)4 * (nint)sizeof(void*))))(_nativePointer, &@ref, &ref2, &ref3);
		supportedInputFormatOut.__MarshalFrom(ref ref3);
		outputFormatRef.__MarshalFree(ref @ref);
		requestedInputFormatRef.__MarshalFree(ref ref2);
		return result;
	}

	internal unsafe Result IsOutputFormatSupported_(ref WaveFormat inputFormatRef, ref WaveFormat requestedOutputFormatRef, out WaveFormat supportedOutputFormatOut)
	{
		WaveFormat.__Native @ref = default(WaveFormat.__Native);
		WaveFormat.__Native ref2 = default(WaveFormat.__Native);
		WaveFormat.__Native ref3 = default(WaveFormat.__Native);
		supportedOutputFormatOut = null;
		inputFormatRef.__MarshalTo(ref @ref);
		requestedOutputFormatRef.__MarshalTo(ref ref2);
		Result result = ((delegate* unmanaged[Stdcall]<void*, void*, void*, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)5 * (nint)sizeof(void*))))(_nativePointer, &@ref, &ref2, &ref3);
		supportedOutputFormatOut.__MarshalFrom(ref ref3);
		inputFormatRef.__MarshalFree(ref @ref);
		requestedOutputFormatRef.__MarshalFree(ref ref2);
		return result;
	}

	internal unsafe void Initialize_(IntPtr dataRef, int dataByteSize)
	{
		((Result)((delegate* unmanaged[Stdcall]<void*, void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)6 * (nint)sizeof(void*))))(_nativePointer, (void*)dataRef, dataByteSize)).CheckError();
	}

	internal unsafe void Reset_()
	{
		((delegate* unmanaged[Stdcall]<void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)7 * (nint)sizeof(void*))))(_nativePointer);
	}

	internal unsafe void LockForProcess_(int inputLockedParameterCount, LockParameters[] inputLockedParametersRef, int outputLockedParameterCount, LockParameters[] outputLockedParametersRef)
	{
		LockParameters.__Native[] array = new LockParameters.__Native[inputLockedParametersRef.Length];
		LockParameters.__Native[] array2 = new LockParameters.__Native[outputLockedParametersRef.Length];
		for (int i = 0; i < inputLockedParametersRef.Length; i++)
		{
			inputLockedParametersRef[i].__MarshalTo(ref array[i]);
		}
		for (int j = 0; j < outputLockedParametersRef.Length; j++)
		{
			outputLockedParametersRef[j].__MarshalTo(ref array2[j]);
		}
		Result result;
		fixed (LockParameters.__Native* ptr = array2)
		{
			void* ptr2 = ptr;
			fixed (LockParameters.__Native* ptr3 = array)
			{
				void* ptr4 = ptr3;
				result = ((delegate* unmanaged[Stdcall]<void*, int, void*, int, void*, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)8 * (nint)sizeof(void*))))(_nativePointer, inputLockedParameterCount, ptr4, outputLockedParameterCount, ptr2);
			}
		}
		for (int k = 0; k < inputLockedParametersRef.Length; k++)
		{
			inputLockedParametersRef[k].__MarshalFree(ref array[k]);
		}
		for (int l = 0; l < outputLockedParametersRef.Length; l++)
		{
			outputLockedParametersRef[l].__MarshalFree(ref array2[l]);
		}
		result.CheckError();
	}

	internal unsafe void UnlockForProcess_()
	{
		((delegate* unmanaged[Stdcall]<void*, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)9 * (nint)sizeof(void*))))(_nativePointer);
	}

	internal unsafe void Process_(int inputProcessParameterCount, BufferParameters[] inputProcessParametersRef, int outputProcessParameterCount, BufferParameters[] outputProcessParametersRef, RawBool isEnabled)
	{
		fixed (BufferParameters* ptr = outputProcessParametersRef)
		{
			void* ptr2 = ptr;
			fixed (BufferParameters* ptr3 = inputProcessParametersRef)
			{
				void* ptr4 = ptr3;
				((delegate* unmanaged[Stdcall]<void*, int, void*, int, void*, RawBool, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)10 * (nint)sizeof(void*))))(_nativePointer, inputProcessParameterCount, ptr4, outputProcessParameterCount, ptr2, isEnabled);
			}
		}
	}

	internal unsafe int CalcInputFrames_(int outputFrameCount)
	{
		return ((delegate* unmanaged[Stdcall]<void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)11 * (nint)sizeof(void*))))(_nativePointer, outputFrameCount);
	}

	internal unsafe int CalcOutputFrames_(int inputFrameCount)
	{
		return ((delegate* unmanaged[Stdcall]<void*, int, int>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)12 * (nint)sizeof(void*))))(_nativePointer, inputFrameCount);
	}
}
