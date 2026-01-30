using System;
using System.Runtime.InteropServices;
using SharpDX.Mathematics.Interop;
using SharpDX.XAPO;

namespace SharpDX.XAudio2;

public class EffectDescriptor
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	internal struct __Native
	{
		public IntPtr EffectPointer;

		public RawBool InitialState;

		public int OutputChannelCount;
	}

	private AudioProcessor _effect;

	internal IUnknown EffectPointer;

	public RawBool InitialState;

	public int OutputChannelCount;

	public AudioProcessor Effect
	{
		get
		{
			return _effect;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value", "Effect cannot be set to null");
			}
			if (_effect != null)
			{
				throw new ArgumentException("Cannot set Effect twice on the same EffectDescriptor");
			}
			_effect = value;
			EffectPointer = _effect;
		}
	}

	public EffectDescriptor(AudioProcessor effect)
		: this(effect, 2)
	{
	}

	public EffectDescriptor(AudioProcessor effect, int outputChannelCount)
	{
		EffectPointer = null;
		Effect = effect;
		InitialState = true;
		OutputChannelCount = outputChannelCount;
	}

	internal void __MarshalFree(ref __Native @ref)
	{
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		if (@ref.EffectPointer != IntPtr.Zero)
		{
			EffectPointer = new ComObject(@ref.EffectPointer);
		}
		else
		{
			EffectPointer = null;
		}
		InitialState = @ref.InitialState;
		OutputChannelCount = @ref.OutputChannelCount;
	}

	internal void __MarshalTo(ref __Native @ref)
	{
		@ref.EffectPointer = CppObject.ToCallbackPtr<IUnknown>(EffectPointer);
		@ref.InitialState = InitialState;
		@ref.OutputChannelCount = OutputChannelCount;
	}
}
