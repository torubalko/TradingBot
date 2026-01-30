using System.Collections;
using System.Collections.Generic;
using ActiproSoftware.Text.Utility;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins;

public interface IPrinterViewMarginCollection : IKeyedObservableCollection<IPrinterViewMargin>, IObservableCollection<IPrinterViewMargin>, IList<IPrinterViewMargin>, ICollection<IPrinterViewMargin>, IEnumerable<IPrinterViewMargin>, IEnumerable
{
}
