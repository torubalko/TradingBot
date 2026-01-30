using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using ActiproSoftware.Products.Shared;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
public sealed class ActiproLicenseProvider : LicenseProvider
{
	internal static ActiproLicenseProvider D1Z;

	public sealed override License GetLicense(LicenseContext context, Type type, object instance, bool allowExceptions)
	{
		ActiproLicense license = ActiproLicenseManager.GetLicense(ActiproSoftware.Products.Shared.AssemblyInfo.Instance, context);
		if (license != null)
		{
			if (license.IsValid)
			{
				int num = 0;
				if (!Q1r())
				{
					int num2 = default(int);
					num = num2;
				}
				switch (num)
				{
				}
				if (license.LicenseType == AssemblyLicenseType.Full)
				{
					goto IL_0058;
				}
			}
			ActiproLicenseManager.ShowLicenseUIAndThrowLicenseException(license, null, instance);
		}
		goto IL_0058;
		IL_0058:
		return license;
	}

	public ActiproLicenseProvider()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	internal static bool Q1r()
	{
		return D1Z == null;
	}

	internal static ActiproLicenseProvider g1I()
	{
		return D1Z;
	}
}
