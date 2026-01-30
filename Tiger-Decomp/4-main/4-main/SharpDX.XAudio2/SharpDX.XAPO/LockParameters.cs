using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.XAPO;

public struct LockParameters
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	internal struct __Native
	{
		public IntPtr FormatPointer;

		public int MaxFrameCount;

		internal void __MarshalFree()
		{
			if (FormatPointer != IntPtr.Zero)
			{
				Marshal.FreeCoTaskMem(FormatPointer);
			}
		}
	}

	internal IntPtr FormatPointer;

	public int MaxFrameCount;

	public WaveFormat Format { get; set; }

	internal void __MarshalFree(ref __Native @ref)
	{
		@ref.__MarshalFree();
	}

	internal void __MarshalTo(ref __Native @ref)
	{
		@ref.FormatPointer = IntPtr.Zero;
		if (Format != null)
		{
			int cb = Marshal.SizeOf((object)Format);
			@ref.FormatPointer = Marshal.AllocCoTaskMem(cb);
			Marshal.StructureToPtr((object)Format, @ref.FormatPointer, fDeleteOld: false);
		}
		@ref.MaxFrameCount = MaxFrameCount;
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		Format = null;
		FormatPointer = @ref.FormatPointer;
		if (FormatPointer != IntPtr.Zero)
		{
			Format = WaveFormat.MarshalFrom(FormatPointer);
		}
		MaxFrameCount = @ref.MaxFrameCount;
	}

	internal unsafe void __MarshalFrom(__Native* @ref)
	{
		Format = null;
		FormatPointer = @ref->FormatPointer;
		if (FormatPointer != IntPtr.Zero)
		{
			Format = WaveFormat.MarshalFrom(FormatPointer);
		}
		MaxFrameCount = @ref->MaxFrameCount;
	}
}
