using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAPO;

[Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
internal class ParameterProviderNative : ComObject, ParameterProvider, ParameterProvider27, IUnknown, ICallbackable, IDisposable
{
	public void SetParameters(DataStream parameters)
	{
		SetParameters_(parameters.PositionPointer, (int)(parameters.Length - parameters.Position));
	}

	public void GetParameters(DataStream parameters)
	{
		GetParameters_(parameters.DataPointer, (int)(parameters.Length - parameters.Position));
	}

	public ParameterProviderNative(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	public static explicit operator ParameterProviderNative(IntPtr nativePtr)
	{
		if (!(nativePtr == IntPtr.Zero))
		{
			return new ParameterProviderNative(nativePtr);
		}
		return null;
	}

	internal unsafe void SetParameters_(IntPtr parametersRef, int parameterByteSize)
	{
		((delegate* unmanaged[Stdcall]<void*, void*, int, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)3 * (nint)sizeof(void*))))(_nativePointer, (void*)parametersRef, parameterByteSize);
	}

	internal unsafe void GetParameters_(IntPtr parametersRef, int parameterByteSize)
	{
		((delegate* unmanaged[Stdcall]<void*, void*, int, void>)(*(IntPtr*)((nint)(*(IntPtr*)_nativePointer) + (nint)4 * (nint)sizeof(void*))))(_nativePointer, (void*)parametersRef, parameterByteSize);
	}
}
