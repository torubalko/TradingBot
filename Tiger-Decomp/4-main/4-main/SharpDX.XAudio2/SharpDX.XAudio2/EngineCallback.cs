using System;

namespace SharpDX.XAudio2;

[Shadow(typeof(EngineShadow))]
internal interface EngineCallback : ICallbackable, IDisposable
{
	void OnProcessingPassStart();

	void OnProcessingPassEnd();

	void OnCriticalError(Result error);
}
