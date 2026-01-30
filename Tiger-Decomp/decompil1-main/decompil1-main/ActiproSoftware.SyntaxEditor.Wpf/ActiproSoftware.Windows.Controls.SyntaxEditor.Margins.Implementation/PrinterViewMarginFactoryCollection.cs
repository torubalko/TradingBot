using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ActiproSoftware.Internal;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class PrinterViewMarginFactoryCollection : ObservableCollection<IPrinterViewMarginFactory>, IPrinterViewMarginFactoryCollection, IList<IPrinterViewMarginFactory>, ICollection<IPrinterViewMarginFactory>, IEnumerable<IPrinterViewMarginFactory>, IEnumerable, IList, ICollection
{
	private static PrinterViewMarginFactoryCollection Tn9;

	public PrinterViewMarginFactoryCollection()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool knJ()
	{
		return Tn9 == null;
	}

	internal static PrinterViewMarginFactoryCollection wnR()
	{
		return Tn9;
	}
}
