using System;
using SharpDX.XAudio2;

namespace SharpDX.XAPO;

public abstract class AudioProcessorParamNative<T> : AudioProcessorNative where T : struct
{
	private readonly SharpDX.XAudio2.XAudio2 device;

	private static readonly Guid CLSID_ParameterProvider_27 = new Guid("a90bc001-e897-e897-55e4-9e4700000001");

	private ParameterProviderNative _parameterProviderNative;

	private int _sizeOfParamT = Utilities.SizeOf<T>();

	public unsafe T Parameter
	{
		get
		{
			T data = default(T);
			byte* ptr = stackalloc byte[(int)(uint)_sizeOfParamT];
			_parameterProviderNative.GetParameters(new DataStream(ptr, _sizeOfParamT, canRead: true, canWrite: true, makeCopy: false));
			Utilities.Read((IntPtr)ptr, ref data);
			return data;
		}
		set
		{
			byte* ptr = stackalloc byte[(int)(uint)_sizeOfParamT];
			Utilities.Write((IntPtr)ptr, ref value);
			_parameterProviderNative.SetParameters(new DataStream(ptr, _sizeOfParamT, canRead: true, canWrite: true, makeCopy: false));
		}
	}

	protected AudioProcessorParamNative(SharpDX.XAudio2.XAudio2 device)
		: base(IntPtr.Zero)
	{
		if (device == null)
		{
			throw new ArgumentNullException("device");
		}
		this.device = device;
	}

	protected override void NativePointerUpdated(IntPtr oldPointer)
	{
		base.NativePointerUpdated(oldPointer);
		if (base.NativePointer != IntPtr.Zero)
		{
			Guid guid = ((device.Version == XAudio2Version.Version27) ? CLSID_ParameterProvider_27 : Utilities.GetGuidFromType(typeof(ParameterProvider)));
			QueryInterface(guid, out var outPtr);
			_parameterProviderNative = new ParameterProviderNative(outPtr);
		}
	}
}
