using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Markup;
using dg3ypDAonQcOidMs0w;
using rE4lpnT863QnijKQK5;

namespace ActiproSoftware.Products;

[ToolboxItem(false)]
public partial class LicenseAdornerPopup : UserControl, IComponentConnector
{
	private bool Rqb;

	private static LicenseAdornerPopup BgG;

	internal LicenseAdornerPopup(ActiproLicense license)
	{
		hHEYokUTtehNq5ji0d.LrmWXz();
		base._002Ector();
		InitializeComponent();
		productDescriptionTextBlock.Text = license.AssemblyInfo.Description;
		productNameTextBlock.Text = license.AssemblyInfo.Product;
		versionTextBlock.Text = string.Format(CultureInfo.CurrentCulture, WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129664), new object[1] { license.AssemblyInfo.Version });
		string text = null;
		text = license.AssemblyInfo.LicenseType switch
		{
			AssemblyLicenseType.Beta => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129690), 
			AssemblyLicenseType.Prerelease => WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129718), 
			_ => (license.LicenseType != AssemblyLicenseType.Full) ? WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129772) : WP6RZJql8gZrNhVA9v.L3hoFlcqP6(129744), 
		};
		licenseTypeTextBlock.Text = text;
		licenseQuickInfoTextBlock.Text = license.GetQuickInfo();
	}

	internal static bool Lgn()
	{
		return BgG == null;
	}

	internal static LicenseAdornerPopup Ug0()
	{
		return BgG;
	}
}
