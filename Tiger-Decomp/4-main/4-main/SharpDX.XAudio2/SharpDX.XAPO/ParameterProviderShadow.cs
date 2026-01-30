using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAPO;

[Guid("a90bc001-e897-e897-55e4-9e4700000001")]
internal class ParameterProviderShadow : ComObjectShadow
{
	public class ParameterProviderVtbl : ComObjectVtbl
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate void GetSetParametersDelegate(IntPtr thisObject, IntPtr paramPointer, int paramSize);

		public ParameterProviderVtbl()
			: base(2)
		{
			AddMethod(new GetSetParametersDelegate(SetParametersImpl));
			AddMethod(new GetSetParametersDelegate(GetParameters));
		}

		private static void SetParametersImpl(IntPtr thisObject, IntPtr paramPointer, int paramSize)
		{
			((ParameterProvider)CppObjectShadow.ToShadow<ParameterProviderShadow>(thisObject).Callback).SetParameters(new DataStream(paramPointer, paramSize, canRead: true, canWrite: true));
		}

		private void GetParameters(IntPtr thisObject, IntPtr paramPointer, int paramSize)
		{
			((ParameterProvider)CppObjectShadow.ToShadow<ParameterProviderShadow>(thisObject).Callback).GetParameters(new DataStream(paramPointer, paramSize, canRead: true, canWrite: true));
		}
	}

	private static readonly ParameterProviderVtbl Vtbl = new ParameterProviderVtbl();

	protected override CppObjectVtbl GetVtbl => Vtbl;

	public static IntPtr ToIntPtr(ParameterProvider callback)
	{
		return CppObject.ToCallbackPtr<ParameterProvider>(callback);
	}
}
