using System.Windows.Media;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Products.SyntaxEditor;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo n5p;

	private static AssemblyInfo nGY;

	public static AssemblyInfo Instance
	{
		get
		{
			if (n5p == null)
			{
				n5p = new AssemblyInfo();
			}
			return n5p;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => Q7Z.tqM(202150);

	public sealed override int ProductId => 2;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(Q7Z.tqM(202160));

	private AssemblyInfo()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool DGb()
	{
		return nGY == null;
	}

	internal static AssemblyInfo qGs()
	{
		return nGY;
	}
}
