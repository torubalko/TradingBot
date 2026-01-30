using System;
using SharpDX.Multimedia;

namespace SharpDX.XAPO;

public abstract class AudioProcessorBase<T> : CallbackBase, AudioProcessor, AudioProcessor27, IUnknown, ICallbackable, IDisposable, ParameterProvider, ParameterProvider27 where T : struct
{
	private RegistrationProperties _registrationProperies;

	private T _parameters;

	private WaveFormat _inputFormatLocked;

	private WaveFormat _outputFormatLocked;

	private int _maxFrameCountLocked;

	public virtual T Parameters
	{
		get
		{
			return _parameters;
		}
		set
		{
			_parameters = value;
		}
	}

	protected WaveFormat InputFormatLocked => _inputFormatLocked;

	protected WaveFormat OutputFormatLocked => _outputFormatLocked;

	protected int MaxFrameCountLocked => _maxFrameCountLocked;

	public RegistrationProperties RegistrationProperties
	{
		get
		{
			return _registrationProperies;
		}
		protected set
		{
			_registrationProperies = value;
		}
	}

	public bool IsInputFormatSupported(WaveFormat outputFormat, WaveFormat requestedInputFormat, out WaveFormat supportedInputFormat)
	{
		supportedInputFormat = requestedInputFormat;
		return true;
	}

	public bool IsOutputFormatSupported(WaveFormat inputFormat, WaveFormat requestedOutputFormat, out WaveFormat supportedOutputFormat)
	{
		supportedOutputFormat = requestedOutputFormat;
		return true;
	}

	public void Initialize(DataStream stream)
	{
	}

	public void Reset()
	{
	}

	public void LockForProcess(LockParameters[] inputLockedParameters, LockParameters[] outputLockedParameters)
	{
		_inputFormatLocked = inputLockedParameters[0].Format;
		_outputFormatLocked = outputLockedParameters[0].Format;
		_maxFrameCountLocked = inputLockedParameters[0].MaxFrameCount;
	}

	public void UnlockForProcess()
	{
	}

	public abstract void Process(BufferParameters[] inputProcessParameters, BufferParameters[] outputProcessParameters, bool isEnabled);

	public int CalcInputFrames(int outputFrameCount)
	{
		return outputFrameCount;
	}

	public int CalcOutputFrames(int inputFrameCount)
	{
		return inputFrameCount;
	}

	void ParameterProvider.SetParameters(DataStream parameters)
	{
		Utilities.Read(parameters.PositionPointer, ref _parameters);
	}

	void ParameterProvider.GetParameters(DataStream parameters)
	{
		Utilities.Write(parameters.PositionPointer, ref _parameters);
	}
}
