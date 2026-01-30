using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[Guid("177CD9E7-B6F5-451A-94A0-5D7A3A4C4141")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[TypeIdentifier]
public interface ICoreWebView2CookieManager
{
	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2Cookie CreateCookie([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string value, [In][MarshalAs(UnmanagedType.LPWStr)] string Domain, [In][MarshalAs(UnmanagedType.LPWStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2Cookie CopyCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookieParam);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void GetCookies([In][MarshalAs(UnmanagedType.LPWStr)] string uri, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2GetCookiesCompletedHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void AddOrUpdateCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookie);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void DeleteCookie([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2Cookie cookie);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void DeleteCookies([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string uri);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void DeleteCookiesWithDomainAndPath([In][MarshalAs(UnmanagedType.LPWStr)] string name, [In][MarshalAs(UnmanagedType.LPWStr)] string Domain, [In][MarshalAs(UnmanagedType.LPWStr)] string Path);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void DeleteAllCookies();
}
