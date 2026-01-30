using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAPO;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct BufferParameters
{
	public IntPtr Buffer;

	public BufferFlags BufferFlags;

	public int ValidFrameCount;
}
