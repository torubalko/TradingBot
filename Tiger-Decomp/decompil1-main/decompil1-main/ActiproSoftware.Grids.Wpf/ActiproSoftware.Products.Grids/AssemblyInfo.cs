using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Grids;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo clm;

	private static AssemblyInfo ycK;

	public static AssemblyInfo Instance
	{
		get
		{
			if (clm == null)
			{
				clm = new AssemblyInfo();
			}
			return clm;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => xv.hTz(10582);

	public sealed override int ProductId => 128;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(xv.hTz(10592));

	private AssemblyInfo()
	{
		fc.taYSkz();
		base._002Ector();
	}

	internal static bool ucE()
	{
		return ycK == null;
	}

	internal static AssemblyInfo Scg()
	{
		return ycK;
	}
}
