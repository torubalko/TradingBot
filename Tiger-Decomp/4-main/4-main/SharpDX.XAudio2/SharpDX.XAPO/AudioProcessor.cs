using System;
using System.Runtime.InteropServices;
using SharpDX.Multimedia;

namespace SharpDX.XAPO;

[Shadow(typeof(AudioProcessorShadow))]
[Guid("A410B984-9839-4819-A0BE-2856AE6B3ADB")]
public interface AudioProcessor : AudioProcessor27, IUnknown, ICallbackable, IDisposable
{
	RegistrationProperties RegistrationProperties { get; }

	bool IsInputFormatSupported(WaveFormat outputFormat, WaveFormat requestedInputFormat, out WaveFormat supportedInputFormat);

	bool IsOutputFormatSupported(WaveFormat inputFormat, WaveFormat requestedOutputFormat, out WaveFormat supportedOutputFormat);

	void Initialize(DataStream stream);

	void Reset();

	void LockForProcess(LockParameters[] inputLockedParameters, LockParameters[] outputLockedParameters);

	void UnlockForProcess();

	void Process(BufferParameters[] inputProcessParameters, BufferParameters[] outputProcessParameters, bool isEnabled);

	int CalcInputFrames(int outputFrameCount);

	int CalcOutputFrames(int inputFrameCount);
}
