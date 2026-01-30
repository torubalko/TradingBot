using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.DataGrid.Contrib;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo oy;

	private static AssemblyInfo Uo;

	public static AssemblyInfo Instance
	{
		get
		{
			if (oy == null)
			{
				oy = new AssemblyInfo();
			}
			return oy;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => Ng.cn(904);

	public sealed override int ProductId => 0;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(Ng.cn(914));

	private AssemblyInfo()
	{
		ns.vQ9Sfz();
		base._002Ector();
	}

	internal static bool Ks()
	{
		return Uo == null;
	}

	internal static AssemblyInfo pn()
	{
		return Uo;
	}
}
