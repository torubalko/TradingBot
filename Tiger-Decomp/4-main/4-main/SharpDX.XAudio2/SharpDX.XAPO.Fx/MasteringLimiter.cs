using SharpDX.XAudio2;

namespace SharpDX.XAPO.Fx;

public class MasteringLimiter : AudioProcessorParamNative<MasteringLimiterParameters>
{
	public const int MinimumRelease = 1;

	public const int MaximumRelease = 20;

	public const int DefaultRelease = 6;

	public const int MinimumLoudness = 1;

	public const int MaximumLoudness = 1800;

	public const int DefaultLoudness = 1000;

	public MasteringLimiter(SharpDX.XAudio2.XAudio2 device)
		: base(device)
	{
		XAPOFx.CreateFX(device, XAPOFx.CLSID_FXMasteringLimiter, this);
	}
}
