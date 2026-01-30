using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows.Interop;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Actipro")]
public class ActiproLicense : License
{
	private AssemblyInfo OnH;

	private DateTime On6;

	private int onV;

	private byte jn5;

	private string KnR;

	private string GnE;

	private AssemblyLicenseType Uns;

	private byte pnL;

	private byte gnd;

	private ushort FnN;

	private AssemblyPlatform wnM;

	private uint MnK;

	private ActiproLicenseSourceLocation xng;

	internal static ActiproLicense V19;

	internal AssemblyInfo AssemblyInfo => OnH;

	internal int ExceptionType => onV;

	internal ushort OrganizationID => FnN;

	internal AssemblyPlatform Platform => wnM;

	internal uint ProductIDs => MnK;

	public DateTime ExpirationDate
	{
		get
		{
			if (Uns == AssemblyLicenseType.Full)
			{
				return DateTime.MaxValue;
			}
			return On6;
		}
	}

	public string ExpandedLicenseKey => xnW(GnE ?? string.Empty);

	public bool IsUnlicensedProduct => onV == 42;

	public bool IsValid => onV == 0;

	public bool IsSiteLicense => jn5 == byte.MaxValue;

	public byte LicenseCount => jn5;

	public string Licensee => KnR;

	public override string LicenseKey => GnE;

	public AssemblyLicenseType LicenseType => Uns;

	public byte MajorVersion => pnL;

	public byte MinorVersion => gnd;

	public ActiproLicenseSourceLocation SourceLocation => xng;

	internal ActiproLicense(AssemblyInfo assemblyInfo, string licensee, string licenseKey, ActiproLicenseSourceLocation sourceLocation, int exceptionType)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		OnH = assemblyInfo;
		KnR = licensee;
		GnE = snq(licenseKey);
		xng = sourceLocation;
		onV = exceptionType;
	}

	internal ActiproLicense(AssemblyInfo assemblyInfo, string licensee, string licenseKey, ActiproLicenseSourceLocation sourceLocation, int exceptionType, uint productIDs, byte majorVersion, byte minorVersion, AssemblyLicenseType licenseType, byte licenseCount, AssemblyPlatform platform, ushort organizationID, DateTime date)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		this._002Ector(assemblyInfo, licensee, licenseKey, sourceLocation, exceptionType);
		MnK = productIDs;
		pnL = majorVersion;
		gnd = minorVersion;
		Uns = licenseType;
		jn5 = licenseCount;
		wnM = platform;
		FnN = organizationID;
		On6 = date;
		if (exceptionType == 0)
		{
			QnU();
		}
	}

	~ActiproLicense()
	{
		Dispose(disposing: false);
	}

	private static string snq(string P_0)
	{
		return P_0?.Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106636), string.Empty).Replace(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224), string.Empty);
	}

	private static string xnW(string P_0)
	{
		if (P_0 == null || P_0.Length < 21)
		{
			return P_0;
		}
		return P_0.Substring(0, 6) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(6, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(11, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(16, 5) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123224) + P_0.Substring(21);
	}

	private void QnU()
	{
		if (!GnE.StartsWith(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123230), StringComparison.OrdinalIgnoreCase))
		{
			onV = 100;
			return;
		}
		Version assemblyVersion = OnH.GetAssemblyVersion();
		if (pnL != assemblyVersion.Major || gnd != assemblyVersion.Minor)
		{
			onV = 101;
			return;
		}
		if (Uns != OnH.LicenseType && (Uns != AssemblyLicenseType.Evaluation || OnH.LicenseType != AssemblyLicenseType.Full))
		{
			onV = 102;
			return;
		}
		if (wnM != OnH.Platform && OnH.Platform != AssemblyPlatform.Independent)
		{
			onV = 103;
			return;
		}
		AssemblyLicenseType uns = Uns;
		AssemblyLicenseType assemblyLicenseType = uns;
		if ((uint)assemblyLicenseType <= 2u && (DateTime.Now > On6 || FnN == 0))
		{
			onV = 50;
		}
	}

	public sealed override void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			KnR = null;
			GnE = null;
		}
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public string GetDetails()
	{
		return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123240) + ((OnH != null) ? (OnH.Product + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(106636) + OnH.Version + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123262) + OnH.LicenseType.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123270)) : null) + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123276) + Uns.ToString() + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123308) + KnR + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123332) + ((GnE != null && GnE.Length > 20) ? (ExpandedLicenseKey.Substring(0, 18) + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123364)) : GnE) + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123418) + wnM.ToString() + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123442) + FnN + Environment.NewLine + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123454) + onV;
	}

	[SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate")]
	public string GetQuickInfo()
	{
		switch (ExceptionType)
		{
		case 0:
		{
			AssemblyLicenseType uns = Uns;
			AssemblyLicenseType assemblyLicenseType2 = uns;
			if (assemblyLicenseType2 == AssemblyLicenseType.Full)
			{
				return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123482), new object[2]
				{
					KnR,
					IsSiteLicense ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123656) : jn5.ToString(CultureInfo.InvariantCulture)
				});
			}
			return WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123678);
		}
		case 41:
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(123950));
		case 50:
		{
			AssemblyLicenseType licenseType = OnH.LicenseType;
			AssemblyLicenseType assemblyLicenseType = licenseType;
			if ((uint)(assemblyLicenseType - 1) <= 1u)
			{
				return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(124174), new object[1] { ExpirationDate });
			}
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(124384), new object[1] { ExpirationDate });
		}
		case 40:
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(124812));
		case 42:
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(125056));
		case 1:
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(125318));
		default:
			if (GnE != null && GnE.Length > 0)
			{
				return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(125530));
			}
			if (BrowserInteropHelper.IsBrowserHosted)
			{
				return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(125758));
			}
			return string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(126146));
		}
	}

	public void SetExceptionType(int value)
	{
		if (value > 0)
		{
			onV = value;
		}
	}

	internal static bool J1c()
	{
		return V19 == null;
	}

	internal static ActiproLicense R1u()
	{
		return V19;
	}
}
