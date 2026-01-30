using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.XAPO;

[Guid("a90bc001-e897-e897-55e4-9e4700000000")]
internal class AudioProcessorShadow : ComObjectShadow
{
	public class AudioProcessorVtbl : ComObjectVtbl
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int GetRegistrationPropertiesDelegate(IntPtr thisObject, out IntPtr output);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int IsInputFormatSupportedDelegate(IntPtr thisObject, IntPtr outputFormat, IntPtr requestedInputFormat, out IntPtr supportedInputFormat);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int IsOutputFormatSupportedDelegate(IntPtr thisObject, IntPtr outputFormat, IntPtr requestedInputFormat, out IntPtr supportedInputFormat);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int InitializeDelegate(IntPtr thisObject, IntPtr ptr, int dataSize);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void ResetDelegate(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private unsafe delegate int LockForProcessDelegate(IntPtr thisObject, int inputLockedParameterCount, LockParameters.__Native* pInputLockedParameters, int outputLockedParameterCount, LockParameters.__Native* pOutputLockedParameters);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void UnlockForProcessDelegate(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private unsafe delegate void ProcessDelegate(IntPtr thisObject, int inputProcessParameterCount, BufferParameters* pInputProcessParameters, int outputProcessParameterCount, BufferParameters* inputProcessParameters, int isEnabled);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int CalcInputFramesDelegate(IntPtr thisObject, int outputFrameCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int CalcOutputFramesDelegate(IntPtr thisObject, int inputFrameCount);

		public AudioProcessorVtbl()
			: base(10)
		{
			AddMethod(new GetRegistrationPropertiesDelegate(GetRegistrationPropertiesImpl));
			AddMethod(new IsInputFormatSupportedDelegate(IsInputFormatSupportedImpl));
			AddMethod(new IsOutputFormatSupportedDelegate(IsOutputFormatSupportedImpl));
			AddMethod(new InitializeDelegate(InitializeImpl));
			AddMethod(new ResetDelegate(ResetImpl));
			AddMethod(new LockForProcessDelegate(LockForProcessImpl));
			AddMethod(new UnlockForProcessDelegate(UnlockForProcessImpl));
			AddMethod(new ProcessDelegate(ProcessImpl));
			AddMethod(new CalcInputFramesDelegate(CalcInputFramesImpl));
			AddMethod(new CalcOutputFramesDelegate(CalcOutputFramesImpl));
		}

		private static int GetRegistrationPropertiesImpl(IntPtr thisObject, out IntPtr output)
		{
			output = IntPtr.Zero;
			try
			{
				AudioProcessor obj = (AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback;
				int cb = Utilities.SizeOf<RegistrationProperties.__Native>();
				output = Marshal.AllocCoTaskMem(cb);
				RegistrationProperties.__Native @ref = default(RegistrationProperties.__Native);
				obj.RegistrationProperties.__MarshalTo(ref @ref);
				Utilities.Write(output, ref @ref);
			}
			catch (Exception ex)
			{
				return (int)Result.GetResultFromException(ex);
			}
			return Result.Ok.Code;
		}

		private static int IsInputFormatSupportedImpl(IntPtr thisObject, IntPtr pOutputFormat, IntPtr pRequestedInputFormat, out IntPtr pSupportedInputFormat)
		{
			pSupportedInputFormat = IntPtr.Zero;
			try
			{
				AudioProcessor obj = (AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback;
				WaveFormat outputFormat = WaveFormat.MarshalFrom(pOutputFormat);
				WaveFormat requestedInputFormat = WaveFormat.MarshalFrom(pRequestedInputFormat);
				WaveFormat supportedInputFormat;
				bool num = obj.IsInputFormatSupported(outputFormat, requestedInputFormat, out supportedInputFormat);
				int cb = Marshal.SizeOf((object)supportedInputFormat);
				pSupportedInputFormat = Marshal.AllocCoTaskMem(cb);
				Marshal.StructureToPtr((object)supportedInputFormat, pSupportedInputFormat, fDeleteOld: false);
				return num ? Result.Ok.Code : (-2003369983);
			}
			catch (Exception ex)
			{
				return (int)Result.GetResultFromException(ex);
			}
		}

		private static int IsOutputFormatSupportedImpl(IntPtr thisObject, IntPtr pInputFormat, IntPtr pRequestedOutputFormat, out IntPtr pSupportedOutputFormat)
		{
			pSupportedOutputFormat = IntPtr.Zero;
			try
			{
				AudioProcessor obj = (AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback;
				WaveFormat inputFormat = WaveFormat.MarshalFrom(pInputFormat);
				WaveFormat requestedOutputFormat = WaveFormat.MarshalFrom(pRequestedOutputFormat);
				WaveFormat supportedOutputFormat;
				bool num = obj.IsOutputFormatSupported(inputFormat, requestedOutputFormat, out supportedOutputFormat);
				int cb = Marshal.SizeOf((object)supportedOutputFormat);
				pSupportedOutputFormat = Marshal.AllocCoTaskMem(cb);
				Marshal.StructureToPtr((object)supportedOutputFormat, pSupportedOutputFormat, fDeleteOld: false);
				return num ? Result.Ok.Code : (-2003369983);
			}
			catch (Exception ex)
			{
				return (int)Result.GetResultFromException(ex);
			}
		}

		private static int InitializeImpl(IntPtr thisObject, IntPtr ptr, int dataSize)
		{
			try
			{
				((AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback).Initialize(new DataStream(ptr, dataSize, canRead: true, canWrite: true));
			}
			catch (Exception ex)
			{
				return (int)Result.GetResultFromException(ex);
			}
			return Result.Ok.Code;
		}

		private static void ResetImpl(IntPtr thisObject)
		{
			((AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback).Reset();
		}

		private unsafe static int LockForProcessImpl(IntPtr thisObject, int inputLockedParameterCount, LockParameters.__Native* pInputLockedParameters, int outputLockedParameterCount, LockParameters.__Native* pOutputLockedParameters)
		{
			try
			{
				AudioProcessor audioProcessor = (AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback;
				LockParameters[] array = new LockParameters[inputLockedParameterCount];
				for (int i = 0; i < array.Length; i++)
				{
					LockParameters lockParameters = default(LockParameters);
					lockParameters.__MarshalFrom(pInputLockedParameters + i);
					array[i] = lockParameters;
				}
				LockParameters[] array2 = new LockParameters[outputLockedParameterCount];
				for (int j = 0; j < array2.Length; j++)
				{
					LockParameters lockParameters2 = default(LockParameters);
					lockParameters2.__MarshalFrom(pOutputLockedParameters + j);
					array2[j] = lockParameters2;
				}
				audioProcessor.LockForProcess(array, array2);
			}
			catch (Exception ex)
			{
				return (int)Result.GetResultFromException(ex);
			}
			return 0;
		}

		private static void UnlockForProcessImpl(IntPtr thisObject)
		{
			((AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback).UnlockForProcess();
		}

		private unsafe static void ProcessImpl(IntPtr thisObject, int inputProcessParameterCount, BufferParameters* pInputProcessParameters, int outputProcessParameterCount, BufferParameters* pOutputProcessParameters, int isEnabled)
		{
			AudioProcessor audioProcessor = (AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback;
			BufferParameters[] array = new BufferParameters[inputProcessParameterCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = pInputProcessParameters[i];
			}
			BufferParameters[] array2 = new BufferParameters[outputProcessParameterCount];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = pOutputProcessParameters[j];
			}
			audioProcessor.Process(array, array2, isEnabled == 1);
			for (int k = 0; k < array2.Length; k++)
			{
				pOutputProcessParameters[k].ValidFrameCount = array2[k].ValidFrameCount;
			}
		}

		private static int CalcInputFramesImpl(IntPtr thisObject, int outputFrameCount)
		{
			return ((AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback).CalcInputFrames(outputFrameCount);
		}

		private static int CalcOutputFramesImpl(IntPtr thisObject, int inputFrameCount)
		{
			return ((AudioProcessor)CppObjectShadow.ToShadow<AudioProcessorShadow>(thisObject).Callback).CalcOutputFrames(inputFrameCount);
		}
	}

	private static readonly AudioProcessorVtbl Vtbl = new AudioProcessorVtbl();

	protected override CppObjectVtbl GetVtbl => Vtbl;

	public static IntPtr ToIntPtr(AudioProcessor callback)
	{
		return CppObject.ToCallbackPtr<AudioProcessor>(callback);
	}
}
