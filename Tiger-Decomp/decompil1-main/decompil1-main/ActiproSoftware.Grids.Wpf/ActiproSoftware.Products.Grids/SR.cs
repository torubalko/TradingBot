using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Grids;

public sealed class SR : SRBase
{
	private static volatile SR xlQ;

	internal static SR Acq;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		fc.taYSkz();
		base._002Ector();
	}

	[SpecialName]
	private static SR KlY()
	{
		if (xlQ == null)
		{
			xlQ = new SR();
		}
		return xlQ;
	}

	public static void ClearCustomStrings()
	{
		KlY().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return KlY().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return KlY().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return KlY().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return KlY().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		KlY().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		KlY().SetCustomStringCore(name, value);
	}

	internal static bool DcH()
	{
		return Acq == null;
	}

	internal static SR XcG()
	{
		return Acq;
	}
}
