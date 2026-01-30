using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

internal class VoiceShadow : CppObjectShadow
{
	private class VoiceVtbl : CppObjectVtbl
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void VoidDelegate(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void IntDelegate(IntPtr thisObject, int bytes);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void IntPtrDelegate(IntPtr thisObject, IntPtr address);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void IntPtrIntDelegate(IntPtr thisObject, IntPtr address, int error);

		public VoiceVtbl()
			: base(7)
		{
			AddMethod(new IntDelegate(OnVoiceProcessingPassStartImpl));
			AddMethod(new VoidDelegate(OnVoiceProcessingPassEndImpl));
			AddMethod(new VoidDelegate(OnStreamEndImpl));
			AddMethod(new IntPtrDelegate(OnBufferStartImpl));
			AddMethod(new IntPtrDelegate(OnBufferEndImpl));
			AddMethod(new IntPtrDelegate(OnLoopEndImpl));
			AddMethod(new IntPtrIntDelegate(OnVoiceErrorImpl));
		}

		private static void OnVoiceProcessingPassStartImpl(IntPtr thisObject, int bytes)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnVoiceProcessingPassStart(bytes);
		}

		private static void OnVoiceProcessingPassEndImpl(IntPtr thisObject)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnVoiceProcessingPassEnd();
		}

		private static void OnStreamEndImpl(IntPtr thisObject)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnStreamEnd();
		}

		private static void OnBufferStartImpl(IntPtr thisObject, IntPtr address)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnBufferStart(address);
		}

		private static void OnBufferEndImpl(IntPtr thisObject, IntPtr address)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnBufferEnd(address);
		}

		private static void OnLoopEndImpl(IntPtr thisObject, IntPtr address)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnLoopEnd(address);
		}

		private static void OnVoiceErrorImpl(IntPtr thisObject, IntPtr bufferContextRef, int error)
		{
			((VoiceCallback)CppObjectShadow.ToShadow<VoiceShadow>(thisObject).Callback).OnVoiceError(bufferContextRef, new Result(error));
		}
	}

	private static readonly VoiceVtbl Vtbl = new VoiceVtbl();

	protected override CppObjectVtbl GetVtbl => Vtbl;

	public static IntPtr ToIntPtr(VoiceCallback callback)
	{
		return CppObject.ToCallbackPtr<VoiceCallback>(callback);
	}
}
