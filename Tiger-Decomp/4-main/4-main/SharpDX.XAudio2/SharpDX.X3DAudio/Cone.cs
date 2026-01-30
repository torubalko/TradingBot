using System.Runtime.InteropServices;

namespace SharpDX.X3DAudio;

public class Cone
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct __Native
	{
		public float InnerAngle;

		public float OuterAngle;

		public float InnerVolume;

		public float OuterVolume;

		public float InnerLpf;

		public float OuterLpf;

		public float InnerReverb;

		public float OuterReverb;
	}

	public float InnerAngle;

	public float OuterAngle;

	public float InnerVolume;

	public float OuterVolume;

	public float InnerLpf;

	public float OuterLpf;

	public float InnerReverb;

	public float OuterReverb;

	internal void __MarshalFree(ref __Native @ref)
	{
	}

	internal void __MarshalFrom(ref __Native @ref)
	{
		InnerAngle = @ref.InnerAngle;
		OuterAngle = @ref.OuterAngle;
		InnerVolume = @ref.InnerVolume;
		OuterVolume = @ref.OuterVolume;
		InnerLpf = @ref.InnerLpf;
		OuterLpf = @ref.OuterLpf;
		InnerReverb = @ref.InnerReverb;
		OuterReverb = @ref.OuterReverb;
	}

	internal void __MarshalTo(ref __Native @ref)
	{
		@ref.InnerAngle = InnerAngle;
		@ref.OuterAngle = OuterAngle;
		@ref.InnerVolume = InnerVolume;
		@ref.OuterVolume = OuterVolume;
		@ref.InnerLpf = InnerLpf;
		@ref.OuterLpf = OuterLpf;
		@ref.InnerReverb = InnerReverb;
		@ref.OuterReverb = OuterReverb;
	}
}
