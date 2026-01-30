using System.Windows.Controls;
using System.Windows.Media;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products.Shared;

public sealed class AssemblyInfo : ActiproSoftware.Products.AssemblyInfo
{
	private static AssemblyInfo qqA;

	internal static AssemblyInfo fga;

	public static ImageSource ActiproIconImageSource => Instance.GetImageSource(ImageResource.ActiproIcon);

	public static AssemblyInfo Instance
	{
		get
		{
			if (qqA == null)
			{
				qqA = new AssemblyInfo();
			}
			return qqA;
		}
	}

	public override AssemblyLicenseType LicenseType => AssemblyLicenseType.Full;

	public override AssemblyPlatform Platform => AssemblyPlatform.Wpf;

	public sealed override string ProductCode => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135502);

	public sealed override int ProductId => 0;

	public static ImageSource ProductLogoImageSource => Instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135512));

	public static ImageSource ThemesLogoImageSource => Instance.GetImageSource(WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135546));

	private AssemblyInfo()
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
	}

	public Image GetImage(ImageResource image)
	{
		if (image != ImageResource.ActiproIcon)
		{
			return GetImage(image.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135490));
		}
		return GetImage(image.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135478));
	}

	public ImageSource GetImageSource(ImageResource image)
	{
		if (image == ImageResource.ActiproIcon)
		{
			return GetImageSource(image.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135478));
		}
		return GetImageSource(image.ToString() + WP6RZJql8gZrNhVA9v.L3hoFlcqP6(135490));
	}

	internal static bool Sgy()
	{
		return fga == null;
	}

	internal static AssemblyInfo zgQ()
	{
		return fga;
	}
}
