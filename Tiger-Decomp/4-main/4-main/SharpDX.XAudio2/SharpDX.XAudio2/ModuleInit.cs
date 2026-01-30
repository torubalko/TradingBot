namespace SharpDX.XAudio2;

internal class ModuleInit
{
	[Tag("SharpDX.ModuleInit")]
	internal static void Setup()
	{
		ResultDescriptor.RegisterProvider(typeof(ResultCode));
	}
}
