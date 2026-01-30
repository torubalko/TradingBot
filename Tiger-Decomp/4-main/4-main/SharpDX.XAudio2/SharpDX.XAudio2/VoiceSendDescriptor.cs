using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAudio2;

public struct VoiceSendDescriptor
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	internal struct __Native
	{
		public VoiceSendFlags Flags;

		public IntPtr OutputVoice;
	}

	public VoiceSendFlags Flags;

	public Voice OutputVoice;

	public VoiceSendDescriptor(Voice outputVoice)
		: this(VoiceSendFlags.None, outputVoice)
	{
	}

	public VoiceSendDescriptor(VoiceSendFlags flags, Voice outputVoice)
	{
		Flags = flags;
		OutputVoice = outputVoice;
	}

	internal void __MarshalFree(ref __Native @ref)
	{
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		Flags = @ref.Flags;
		if (@ref.OutputVoice != IntPtr.Zero)
		{
			OutputVoice = new Voice(@ref.OutputVoice);
		}
		else
		{
			OutputVoice = null;
		}
	}

	internal void __MarshalTo(ref __Native @ref)
	{
		@ref.Flags = Flags;
		@ref.OutputVoice = CppObject.ToCallbackPtr<Voice>(OutputVoice);
	}
}
