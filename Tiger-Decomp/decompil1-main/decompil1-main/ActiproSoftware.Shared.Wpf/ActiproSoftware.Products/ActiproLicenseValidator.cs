using System;
using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
public static class ActiproLicenseValidator
{
	internal static ActiproLicenseValidator N1B;

	public static AssemblyLicenseType ValidateLicense(AssemblyInfo assemblyInfo, Type type, object instance)
	{
		return ActiproLicenseManager.ValidateLicense(assemblyInfo, type, instance);
	}

	internal static bool U1A()
	{
		return N1B == null;
	}

	internal static ActiproLicenseValidator i1V()
	{
		return N1B;
	}
}
