using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("E59EE362-ACBD-4857-9A8E-D3644D9459A9")]
[TypeIdentifier]
public interface ICoreWebView2Environment6 : ICoreWebView2Environment5
{
	void _VtblGap1_11();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2PrintSettings CreatePrintSettings();
}
