namespace SharpDX.XAudio2;

public enum DeviceRole
{
	NotDefaultDevice = 0,
	DefaultConsoleDevice = 1,
	DefaultMultimediaDevice = 2,
	DefaultCommunicationsDevice = 4,
	DefaultGameDevice = 8,
	GlobalDefaultDevice = 15,
	InvalidDeviceRole = -16
}
