using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using dg3ypDAonQcOidMs0w;

namespace ActiproSoftware.Windows;

public static class ResourceHelper
{
	private static ResourceHelper vM0;

	[SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings")]
	public static string GetLocationUriStringBase(Assembly assembly)
	{
		return GetLocationUriString(assembly, string.Empty, includePackPrefix: true, includeAssemblyVersion: true);
	}

	[SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings")]
	public static string GetLocationUriString(Assembly assembly, string relativeLocation)
	{
		return GetLocationUriString(assembly, relativeLocation, includePackPrefix: true, includeAssemblyVersion: true);
	}

	[SuppressMessage("Microsoft.Design", "CA1055:UriReturnValuesShouldNotBeStrings")]
	public static string GetLocationUriString(Assembly assembly, string relativeLocation, bool includePackPrefix, bool includeAssemblyVersion)
	{
		if (assembly == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(210));
		}
		if (relativeLocation == null)
		{
			throw new ArgumentNullException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(230));
		}
		if (relativeLocation.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(266), StringComparison.OrdinalIgnoreCase))
		{
			throw new ArgumentException(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(272));
		}
		string text = assembly.FullName ?? string.Empty;
		string[] array = text.Split(',');
		string text2 = array[0].Trim();
		string text3 = string.Empty;
		if (includeAssemblyVersion && array.Length != 0)
		{
			text3 = array[1].Trim();
			int num = text3.IndexOf('=');
			text3 = ((num != -1) ? (WP6RZJql8gZrNhVA9v.L3hoFlcqP6(412) + text3.Substring(num + 1)) : string.Empty);
		}
		string text4 = (includePackPrefix ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(420) : string.Empty);
		return string.Format(CultureInfo.InvariantCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(468), text4, text2, text3, relativeLocation);
	}

	public static Uri GetLocationUri(Assembly assembly, string relativeLocation)
	{
		return new Uri(GetLocationUriString(assembly, relativeLocation), UriKind.RelativeOrAbsolute);
	}

	public static Uri GetLocationUri(Assembly assembly, string relativeLocation, bool includePackPrefix, bool includeAssemblyVersion)
	{
		return new Uri(GetLocationUriString(assembly, relativeLocation, includePackPrefix, includeAssemblyVersion), UriKind.RelativeOrAbsolute);
	}

	internal static bool sMb()
	{
		return vM0 == null;
	}

	internal static ResourceHelper YM1()
	{
		return vM0;
	}
}
