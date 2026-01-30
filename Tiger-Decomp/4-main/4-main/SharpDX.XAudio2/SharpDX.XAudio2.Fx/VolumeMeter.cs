using System;
using SharpDX.XAPO;

namespace SharpDX.XAudio2.Fx;

public class VolumeMeter : AudioProcessorParamNative<VolumeMeterLevels>
{
	public VolumeMeter(XAudio2 device)
		: this(device, isUsingDebug: false)
	{
	}

	public VolumeMeter(XAudio2 device, bool isUsingDebug)
		: base(device)
	{
		if (device.Version == XAudio2Version.Version27)
		{
			Utilities.CreateComInstance(isUsingDebug ? XAudio2FxContants.CLSID_AudioVolumeMeter_Debug : XAudio2FxContants.CLSID_AudioVolumeMeter, Utilities.CLSCTX.ClsctxInprocServer, XAudio2FxContants.CLSID_IAudioProcessor, this);
			return;
		}
		if (device.Version == XAudio2Version.Version28)
		{
			XAudio28Functions.CreateAudioVolumeMeter(this);
			return;
		}
		throw new InvalidOperationException("XAudio2 must be initialized before calling this constructor");
	}
}
