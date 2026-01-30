using SharpDX.XAudio2;

namespace SharpDX.XAPO.Fx;

public class Echo : AudioProcessorParamNative<EchoParameters>
{
	public const float MinimumWetdrymix = 0f;

	public const float MaximumWetdrymix = 1f;

	public const float DefaultWetdrymix = 0.5f;

	public const float MinimumFeedback = 0f;

	public const float MaximumFeedback = 1f;

	public const float DefaultFeedback = 0.5f;

	public const float MinimumDelay = 1f;

	public const float MaximumDelay = 2000f;

	public const float DefaultDelay = 500f;

	public Echo(SharpDX.XAudio2.XAudio2 device)
		: base(device)
	{
		XAPOFx.CreateFX(device, XAPOFx.CLSID_FXEcho, this);
	}
}
