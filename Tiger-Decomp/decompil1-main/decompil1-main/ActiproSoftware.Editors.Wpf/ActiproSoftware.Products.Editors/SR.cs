using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Editors;

public sealed class SR : SRBase
{
	private static volatile SR RuG;

	internal static SR WAT;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	[SpecialName]
	private static SR tub()
	{
		if (RuG == null)
		{
			RuG = new SR();
		}
		return RuG;
	}

	public static void ClearCustomStrings()
	{
		tub().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return tub().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return tub().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return tub().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return tub().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		tub().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		tub().SetCustomStringCore(name, value);
	}

	internal static bool fAk()
	{
		return WAT == null;
	}

	internal static SR iAf()
	{
		return WAT;
	}
}
