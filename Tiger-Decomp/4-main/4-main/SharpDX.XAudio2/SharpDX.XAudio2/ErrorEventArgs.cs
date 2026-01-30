using System;

namespace SharpDX.XAudio2;

public class ErrorEventArgs : EventArgs
{
	public Result ErrorCode { get; private set; }

	public ErrorEventArgs(Result errorCode)
	{
		ErrorCode = errorCode;
	}
}
