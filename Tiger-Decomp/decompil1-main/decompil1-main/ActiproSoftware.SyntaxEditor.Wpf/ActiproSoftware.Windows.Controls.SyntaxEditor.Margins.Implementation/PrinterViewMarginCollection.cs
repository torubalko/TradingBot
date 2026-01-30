using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Internal;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class PrinterViewMarginCollection : KeyedObservableCollection<IPrinterViewMargin>, IPrinterViewMarginCollection, IKeyedObservableCollection<IPrinterViewMargin>, IObservableCollection<IPrinterViewMargin>, IList<IPrinterViewMargin>, ICollection<IPrinterViewMargin>, IEnumerable<IPrinterViewMargin>, IEnumerable
{
	private static PrinterViewMarginCollection hnk;

	public PrinterViewMarginCollection()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool vnZ()
	{
		return hnk == null;
	}

	internal static PrinterViewMarginCollection PnF()
	{
		return hnk;
	}
}
