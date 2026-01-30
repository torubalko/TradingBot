namespace ActiproSoftware.Products;

internal enum KnownLicenseExceptionKind
{
	None = 0,
	Other = 1,
	DesignModeProhibited = 40,
	LicenseKeyDateTampering = 41,
	UnlicensedProduct = 42,
	Expired = 50,
	ConflictingAssemblyProductCode = 100,
	ConflictingAssemblyVersionNumber = 101,
	ConflictingAssemblyLicenseType = 102,
	ConflictingAssemblyPlatform = 103
}
