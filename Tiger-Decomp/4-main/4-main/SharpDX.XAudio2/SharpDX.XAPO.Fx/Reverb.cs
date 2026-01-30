using SharpDX.XAudio2;

namespace SharpDX.XAPO.Fx;

public class Reverb : AudioProcessorParamNative<ReverbParameters>
{
	public const float MinimumDiffusion = 0f;

	public const float MaximumDiffusion = 1f;

	public const float DefaultDiffusion = 0.9f;

	public const float MinimumRoomsize = 0.0001f;

	public const float MaximumRoomsize = 1f;

	public const float DefaultRoomsize = 0.6f;

	public Reverb(SharpDX.XAudio2.XAudio2 device)
		: base(device)
	{
		XAPOFx.CreateFX(device, XAPOFx.CLSID_FXReverb, this);
	}
}
