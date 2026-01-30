using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Editors;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo huO;

	internal static AssemblyInfo GAV;

	public static AssemblyInfo Instance
	{
		get
		{
			if (huO == null)
			{
				huO = new AssemblyInfo();
			}
			return huO;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => QdM.AR8(30378);

	public sealed override int ProductId => 256;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(QdM.AR8(30388));

	private AssemblyInfo()
	{
		awj.QuEwGz();
		base._002Ector();
	}

	internal static bool WAu()
	{
		return GAV == null;
	}

	internal static AssemblyInfo TAH()
	{
		return GAV;
	}
}
