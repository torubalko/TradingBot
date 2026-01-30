using System.Diagnostics.CodeAnalysis;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
public enum ActiproLicenseSourceLocation
{
	None,
	Fixed,
	Registry,
	AssemblySavedContext
}
