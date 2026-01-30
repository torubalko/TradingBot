using System;
using System.Runtime.InteropServices;
using SharpDX.XAudio2;

namespace SharpDX.XAPO.Fx;

internal static class XAPOFx
{
	internal static Guid CLSID_FXEcho = new Guid("5039D740-F736-449A-84D3-A56202557B87");

	internal static Guid CLSID_FXEQ = new Guid("F5E01117-D6C4-485A-A3F5-695196F3DBFA");

	internal static Guid CLSID_FXMasteringLimiter = new Guid("C4137916-2BE1-46FD-8599-441536F49856");

	internal static Guid CLSID_FXReverb = new Guid("7D9ACA56-CB68-4807-B632-B137352E8596");

	private static Guid CLSID_FXEcho_15 = new Guid("a90bc001-e897-e897-7439-435500000003");

	private static Guid CLSID_FXEQ_15 = new Guid("a90bc001-e897-e897-7439-435500000000");

	private static Guid CLSID_FXMasteringLimiter_15 = new Guid("a90bc001-e897-e897-7439-435500000001");

	private static Guid CLSID_FXReverb_15 = new Guid("a90bc001-e897-e897-7439-435500000002");

	public static void CreateFX(SharpDX.XAudio2.XAudio2 device, Guid clsid, ComObject effectRef)
	{
		if (device.Version == XAudio2Version.Version27)
		{
			Guid guid = clsid;
			if (guid == CLSID_FXEcho)
			{
				guid = CLSID_FXEcho_15;
			}
			else if (guid == CLSID_FXEQ)
			{
				guid = CLSID_FXEQ_15;
			}
			else if (guid == CLSID_FXMasteringLimiter)
			{
				guid = CLSID_FXMasteringLimiter_15;
			}
			else if (guid == CLSID_FXReverb)
			{
				guid = CLSID_FXReverb_15;
			}
			if (((Result)CreateFX15(ref guid, out var arg)).Success)
			{
				effectRef.NativePointer = arg;
				return;
			}
		}
		if (device.Version == XAudio2Version.Version28)
		{
			CreateFX28(clsid, effectRef, IntPtr.Zero, 0);
			return;
		}
		throw new NotSupportedException($"XAudio2 Version [{device.Version}] is not supported for this effect");
	}

	[DllImport("XAPOFX1_5.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateFX")]
	private static extern int CreateFX15(ref Guid guid, out IntPtr arg1);

	public unsafe static void CreateFX28(Guid clsid, ComObject effectRef, IntPtr initDataRef, int initDataByteSize)
	{
		IntPtr zero = IntPtr.Zero;
		Result result = CreateFX_28(&clsid, &zero, (void*)initDataRef, initDataByteSize);
		effectRef.NativePointer = zero;
		result.CheckError();
	}

	[DllImport("xaudio2_8.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateFX")]
	private unsafe static extern int CreateFX_28(void* arg0, void* arg1, void* arg2, int arg3);
}
