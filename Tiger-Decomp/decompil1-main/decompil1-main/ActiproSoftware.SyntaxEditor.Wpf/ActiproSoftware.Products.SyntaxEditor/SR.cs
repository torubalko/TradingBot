using System.Resources;
using System.Runtime.CompilerServices;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.SyntaxEditor;

public sealed class SR : SRBase
{
	private static volatile SR Y0P;

	private static SR uGK;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	[SpecialName]
	private static SR O5z()
	{
		if (Y0P == null)
		{
			Y0P = new SR();
		}
		return Y0P;
	}

	public static void ClearCustomStrings()
	{
		O5z().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return O5z().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return O5z().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return O5z().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return O5z().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		O5z().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		O5z().SetCustomStringCore(name, value);
	}

	internal static bool qGC()
	{
		return uGK == null;
	}

	internal static SR DGr()
	{
		return uGK;
	}
}
