using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

public class CountryComboBox : ComboBox
{
	private static CountryComboBox NBW;

	public CountryComboBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(CountryComboBox);
		base.DisplayMemberPath = QdM.AR8(14704);
		base.SelectedValuePath = QdM.AR8(14716);
		base.ItemsSource = Country.Countries;
	}

	internal static bool GBr()
	{
		return NBW == null;
	}

	internal static CountryComboBox BBa()
	{
		return NBW;
	}
}
