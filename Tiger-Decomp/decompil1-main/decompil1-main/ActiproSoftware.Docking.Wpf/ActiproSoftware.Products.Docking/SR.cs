using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Docking;

public sealed class SR : SRBase
{
	private static volatile SR fRV;

	private static SR gKY;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	[SpecialName]
	private static SR yRq()
	{
		if (fRV == null)
		{
			fRV = new SR();
		}
		return fRV;
	}

	public static void ClearCustomStrings()
	{
		yRq().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return yRq().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return yRq().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return yRq().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return yRq().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		yRq().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		yRq().SetCustomStringCore(name, value);
	}

	internal static bool xKC()
	{
		return gKY == null;
	}

	internal static SR qKK()
	{
		return gKY;
	}
}
