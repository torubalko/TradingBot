using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
internal struct EffectChain
{
	public int EffectCount;

	internal IntPtr EffectDescriptorPointer;
}
