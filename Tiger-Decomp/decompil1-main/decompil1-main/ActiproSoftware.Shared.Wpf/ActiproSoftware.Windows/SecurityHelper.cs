using System.Reflection;
using System.Security;
using System.Security.Permissions;

namespace ActiproSoftware.Windows;

public static class SecurityHelper
{
	private static bool? BR;

	private static SecurityHelper uMk;

	public static bool IsFullTrust
	{
		get
		{
			if (!BR.HasValue)
			{
				BR = i5();
			}
			return BR.Value;
		}
	}

	private static bool i5()
	{
		try
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (executingAssembly == null || executingAssembly.IsFullyTrusted)
			{
				new UIPermission(PermissionState.Unrestricted).Demand();
				return true;
			}
		}
		catch (SecurityException)
		{
		}
		return false;
	}

	internal static bool fMF()
	{
		return uMk == null;
	}

	internal static SecurityHelper PMd()
	{
		return uMk;
	}
}
