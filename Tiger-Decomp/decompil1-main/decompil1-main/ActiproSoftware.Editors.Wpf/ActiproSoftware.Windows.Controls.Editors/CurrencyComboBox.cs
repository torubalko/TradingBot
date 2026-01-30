using System.Windows.Controls;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.Editors;

public class CurrencyComboBox : ComboBox
{
	internal static CurrencyComboBox RBt;

	public CurrencyComboBox()
	{
		awj.QuEwGz();
		base._002Ector();
		base.DefaultStyleKey = typeof(CurrencyComboBox);
		base.DisplayMemberPath = QdM.AR8(18664);
		base.SelectedValuePath = QdM.AR8(18690);
		base.ItemsSource = Currency.Currencies;
	}

	internal static bool WBe()
	{
		return RBt == null;
	}

	internal static CurrencyComboBox YBO()
	{
		return RBt;
	}
}
