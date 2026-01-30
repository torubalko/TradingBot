using ActiproSoftware.Internal;
using ActiproSoftware.Windows.Controls.SyntaxEditor.Primitives;

namespace ActiproSoftware.Windows.Controls.SyntaxEditor.Margins.Implementation;

public class DefaultPrinterViewMarginFactory : IPrinterViewMarginFactory
{
	internal static DefaultPrinterViewMarginFactory Inq;

	public virtual IPrinterViewMarginCollection CreateMargins(IPrinterView view)
	{
		IPrinterViewMarginCollection printerViewMarginCollection = new PrinterViewMarginCollection();
		printerViewMarginCollection.Add(new PrinterDocumentTitleMargin(view));
		printerViewMarginCollection.Add(new PrinterLineNumberMargin(view));
		printerViewMarginCollection.Add(new PrinterPageNumberMargin(view));
		printerViewMarginCollection.Add(new PrinterWordWrapGlyphMargin(view));
		return printerViewMarginCollection;
	}

	public DefaultPrinterViewMarginFactory()
	{
		grA.DaB7cz();
		base._002Ector();
	}

	internal static bool jnx()
	{
		return Inq == null;
	}

	internal static DefaultPrinterViewMarginFactory Vna()
	{
		return Inq;
	}
}
