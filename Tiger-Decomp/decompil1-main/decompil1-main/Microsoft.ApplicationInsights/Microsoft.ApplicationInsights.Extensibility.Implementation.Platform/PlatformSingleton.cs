namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Platform;

internal static class PlatformSingleton
{
	private static IPlatform current;

	public static IPlatform Current
	{
		get
		{
			return current ?? (current = new PlatformImplementation());
		}
		set
		{
			current = value;
		}
	}
}
