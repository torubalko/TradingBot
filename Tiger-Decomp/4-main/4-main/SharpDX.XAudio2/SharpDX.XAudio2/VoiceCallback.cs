using System;

namespace SharpDX.XAudio2;

[Shadow(typeof(VoiceShadow))]
public interface VoiceCallback : ICallbackable, IDisposable
{
	void OnVoiceProcessingPassStart(int bytesRequired);

	void OnVoiceProcessingPassEnd();

	void OnStreamEnd();

	void OnBufferStart(IntPtr context);

	void OnBufferEnd(IntPtr context);

	void OnLoopEnd(IntPtr context);

	void OnVoiceError(IntPtr context, Result error);
}
