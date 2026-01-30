using System;
using SharpDX.XAPO;

namespace SharpDX.XAudio2.Fx;

public class Reverb : AudioProcessorParamNative<ReverbParameters>
{
	public const float MinWetDryMix = 0f;

	public const int MinReflectionsDelay = 0;

	public const byte MinReverbDelay = 0;

	public const byte MinRearDelay = 0;

	public const byte MinPosition = 0;

	public const byte MinDiffusion = 0;

	public const byte MinLowEqGain = 0;

	public const byte MinLowEqCutoff = 0;

	public const byte MinHighEqGain = 0;

	public const byte MinHighEqCutoff = 0;

	public const float MinRoomFilterFreq = 20f;

	public const float MinRoomFilterMain = -100f;

	public const float MinRoomFilterHf = -100f;

	public const float MinReflectionsGain = -100f;

	public const float MinReverbGain = -100f;

	public const float MinDecayTime = 0.1f;

	public const float MinDensity = 0f;

	public const float MinRoomSize = 0f;

	public const float MaxWetDryMix = 100f;

	public const int MaxReflectionsDelay = 300;

	public const byte MaxReverbDelay = 85;

	public const byte MaxRearDelay = 5;

	public const byte MaxPosition = 30;

	public const byte MaxDiffusion = 15;

	public const byte MaxLowEqGain = 12;

	public const byte MaxLowEqCutoff = 9;

	public const byte MaxHighEqGain = 8;

	public const byte MaxHighEqCutoff = 14;

	public const float MaxRoomFilterFreq = 20000f;

	public const float MaxRoomFilterMain = 0f;

	public const float MaxRoomFilterHf = 0f;

	public const float MaxReflectionsGain = 20f;

	public const float MaxReverbGain = 20f;

	public const float MaxDensity = 100f;

	public const float MaxRoomSize = 100f;

	public const float DefaultWetDryMix = 100f;

	public const int DefaultReflectionsDelay = 5;

	public const byte DefaultReverbDelay = 5;

	public const byte DefaultRearDelay = 5;

	public const byte DefaultPosition = 6;

	public const byte DefaultPositionMatrix = 27;

	public const byte DefaultEarlyDiffusion = 8;

	public const byte DefaultLateDiffusion = 8;

	public const byte DefaultLowEqGain = 8;

	public const byte DefaultLowEqCutoff = 4;

	public const byte DefaultHighEqGain = 8;

	public const byte DefaultHighEqCutoff = 4;

	public const float DefaultRoomFilterFreq = 5000f;

	public const float DefaultRoomFilterMain = 0f;

	public const float DefaultRoomFilterHf = 0f;

	public const float DefaultReflectionsGain = 0f;

	public const float DefaultReverbGain = 0f;

	public const float DefaultDecayTime = 1f;

	public const float DefaultDensity = 100f;

	public const float DefaultRoomSize = 100f;

	public Reverb(XAudio2 device)
		: this(device, isUsingDebug: false)
	{
	}

	public Reverb(XAudio2 device, bool isUsingDebug)
		: base(device)
	{
		if (device.Version == XAudio2Version.Version27)
		{
			Utilities.CreateComInstance(isUsingDebug ? XAudio2FxContants.CLSID_AudioReverb_Debug : XAudio2FxContants.CLSID_AudioReverb, Utilities.CLSCTX.ClsctxInprocServer, XAudio2FxContants.CLSID_IAudioProcessor, this);
			return;
		}
		if (device.Version == XAudio2Version.Version28)
		{
			XAudio28Functions.CreateAudioReverb(this);
			return;
		}
		throw new InvalidOperationException("XAudio2 must be initialized before calling this constructor");
	}
}
