using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

internal class EngineShadow : CppObjectShadow
{
	public class EngineVtbl : CppObjectVtbl
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void OnProcessingPassStartDelegate(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void OnProcessingPassEndDelegate(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void OnCriticalErrorDelegate(IntPtr thisObject, int error);

		public EngineVtbl()
			: base(3)
		{
			AddMethod(new OnProcessingPassStartDelegate(OnProcessingPassStartImpl));
			AddMethod(new OnProcessingPassEndDelegate(OnProcessingPassEndImpl));
			AddMethod(new OnCriticalErrorDelegate(OnCriticalErrorImpl));
		}

		private static void OnProcessingPassStartImpl(IntPtr thisObject)
		{
			((EngineCallback)CppObjectShadow.ToShadow<EngineShadow>(thisObject).Callback).OnProcessingPassStart();
		}

		private static void OnProcessingPassEndImpl(IntPtr thisObject)
		{
			((EngineCallback)CppObjectShadow.ToShadow<EngineShadow>(thisObject).Callback).OnProcessingPassEnd();
		}

		private static void OnCriticalErrorImpl(IntPtr thisObject, int error)
		{
			((EngineCallback)CppObjectShadow.ToShadow<EngineShadow>(thisObject).Callback).OnCriticalError(new Result(error));
		}
	}

	private static readonly EngineVtbl Vtbl = new EngineVtbl();

	protected override CppObjectVtbl GetVtbl => Vtbl;

	public static IntPtr ToIntPtr(EngineCallback callback)
	{
		return CppObject.ToCallbackPtr<EngineCallback>(callback);
	}
}
