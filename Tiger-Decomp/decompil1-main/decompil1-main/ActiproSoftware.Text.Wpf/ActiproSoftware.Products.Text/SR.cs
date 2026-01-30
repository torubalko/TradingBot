using System.Resources;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Text;

public sealed class SR : SRTextBase
{
	private static volatile SR SLI;

	private static SR rqE;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		hHEYokUTtehNq5ji0d.BN1hJz();
		base._002Ector();
	}

	[SpecialName]
	private static SR eLq()
	{
		if (SLI == null)
		{
			SLI = new SR();
		}
		return SLI;
	}

	public static void ClearCustomStrings()
	{
		eLq().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return eLq().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return eLq().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return eLq().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return eLq().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		eLq().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		eLq().SetCustomStringCore(name, value);
	}

	internal static bool xqG()
	{
		return rqE == null;
	}

	internal static SR Mqh()
	{
		return rqE;
	}
}
