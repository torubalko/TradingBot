using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[Guid("DF362C62-3B8E-484A-8DE0-FE2CB31EDBC5")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface ICoreWebView2StagingHostObjectHelper
{
	int IsMethodMember(ref object rawObject, [In][MarshalAs(UnmanagedType.LPWStr)] string memberName);
}
