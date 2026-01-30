using System.Resources;
using System.Runtime.CompilerServices;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Shared;

public sealed class SR : SRBase
{
	private static volatile SR iqr;

	private static SR wg5;

	public override ResourceManager ResourceManager => Resources.ResourceManager;

	private SR()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	[SpecialName]
	private static SR AqI()
	{
		if (iqr == null)
		{
			iqr = new SR();
		}
		return iqr;
	}

	public static void ClearCustomStrings()
	{
		AqI().ClearCustomStringsCore();
	}

	public static bool ContainsCustomString(string name)
	{
		return AqI().ContainsCustomStringCore(name);
	}

	public static string GetCustomString(string name)
	{
		return AqI().GetCustomStringCore(name);
	}

	public static string GetString(string name)
	{
		return AqI().GetStringCore(name, null);
	}

	public static string GetString(SRName name)
	{
		return GetString(name.ToString());
	}

	public static string GetString(string name, params object[] args)
	{
		return AqI().GetStringCore(name, args);
	}

	public static string GetString(SRName name, params object[] args)
	{
		return GetString(name.ToString(), args);
	}

	public static void RemoveCustomString(string name)
	{
		AqI().RemoveCustomStringCore(name);
	}

	public static void SetCustomString(string name, string value)
	{
		AqI().SetCustomStringCore(name, value);
	}

	internal static bool Rgm()
	{
		return wg5 == null;
	}

	internal static SR HgZ()
	{
		return wg5;
	}
}
