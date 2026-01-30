namespace SharpDX.XAudio2;

public class ResultCode
{
	public static readonly ResultDescriptor InvalidCall = new ResultDescriptor(2291531777u, "SharpDX.XAudio2", "XAUDIO2_E_INVALID_CALL", "InvalidCall");

	public static readonly ResultDescriptor XmaDecoderError = new ResultDescriptor(2291531778u, "SharpDX.XAudio2", "XAUDIO2_E_XMA_DECODER_ERROR", "XmaDecoderError");

	public static readonly ResultDescriptor XapoCreationFailed = new ResultDescriptor(2291531779u, "SharpDX.XAudio2", "XAUDIO2_E_XAPO_CREATION_FAILED", "XapoCreationFailed");

	public static readonly ResultDescriptor DeviceInvalidated = new ResultDescriptor(2291531780u, "SharpDX.XAudio2", "XAUDIO2_E_DEVICE_INVALIDATED", "DeviceInvalidated");
}
