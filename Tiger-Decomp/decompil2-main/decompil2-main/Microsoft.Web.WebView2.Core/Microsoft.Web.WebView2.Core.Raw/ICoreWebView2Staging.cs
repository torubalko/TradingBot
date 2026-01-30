using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[Guid("2C94DD56-E252-40A1-BA7E-B19417B26A60")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2Staging
{
	void AddHostObjectHelper(ICoreWebView2StagingHostObjectHelper helper);
}
