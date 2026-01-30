using SharpDX.XAudio2;

namespace SharpDX.XAPO.Fx;

public class Equalizer : AudioProcessorParamNative<EqualizerParameters>
{
	public const float MinimumFrameRate = 22000f;

	public const float MaximumFrameRate = 48000f;

	public const float MinimumFrequencyCenter = 20f;

	public const float MaximumFrequencyCenter = 20000f;

	public const float DefaultFrequencyCenter0 = 100f;

	public const float DefaultFrequencyCenter1 = 800f;

	public const float DefaultFrequencyCenter2 = 2000f;

	public const float DefaultFrequencyCenter3 = 10000f;

	public const float MinimumGain = 0.126f;

	public const float MaximumGain = 7.94f;

	public const float DefaultGain = 1f;

	public const float MinimumBandwidth = 0.1f;

	public const float MaximumBandwidth = 2f;

	public const float DefaultBandwidth = 1f;

	public Equalizer(SharpDX.XAudio2.XAudio2 device)
		: base(device)
	{
		XAPOFx.CreateFX(device, XAPOFx.CLSID_FXEQ, this);
	}
}
