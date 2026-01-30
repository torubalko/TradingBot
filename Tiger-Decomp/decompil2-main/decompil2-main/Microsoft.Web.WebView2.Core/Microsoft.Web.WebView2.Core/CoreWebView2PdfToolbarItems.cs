using System;

namespace Microsoft.Web.WebView2.Core;

[Flags]
public enum CoreWebView2PdfToolbarItems
{
	None = 0,
	Save = 1,
	Print = 2,
	SaveAs = 4
}
