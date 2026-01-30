using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0BE78E56-C193-4051-B943-23B460C08BDB")]
[TypeIdentifier]
public interface ICoreWebView2_11 : ICoreWebView2_10
{
	void _VtblGap1_96();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void CallDevToolsProtocolMethodForSession([In][MarshalAs(UnmanagedType.LPWStr)] string sessionId, [In][MarshalAs(UnmanagedType.LPWStr)] string methodName, [In][MarshalAs(UnmanagedType.LPWStr)] string parametersAsJson, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2CallDevToolsProtocolMethodCompletedHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void add_ContextMenuRequested([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuRequestedEventHandler eventHandler, out EventRegistrationToken token);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void remove_ContextMenuRequested([In] EventRegistrationToken token);
}
