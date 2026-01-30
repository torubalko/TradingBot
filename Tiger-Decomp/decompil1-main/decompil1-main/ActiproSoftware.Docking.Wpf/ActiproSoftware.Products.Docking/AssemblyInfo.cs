using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.Docking;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo LRY;

	internal static AssemblyInfo jK1;

	public static AssemblyInfo Instance
	{
		get
		{
			if (LRY == null)
			{
				LRY = new AssemblyInfo();
			}
			return LRY;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => vVK.ssH(24256);

	public sealed override int ProductId => 32;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(vVK.ssH(24266));

	private AssemblyInfo()
	{
		IVH.CecNqz();
		base._002Ector();
	}

	internal static bool SKH()
	{
		return jK1 == null;
	}

	internal static AssemblyInfo nKf()
	{
		return jK1;
	}
}
