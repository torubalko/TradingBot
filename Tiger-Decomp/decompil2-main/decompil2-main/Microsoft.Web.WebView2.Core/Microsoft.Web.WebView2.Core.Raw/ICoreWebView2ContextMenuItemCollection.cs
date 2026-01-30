using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("F562A2F5-C415-45CF-B909-D4B7C1E276D3")]
[TypeIdentifier]
public interface ICoreWebView2ContextMenuItemCollection
{
	[DispId(1610678272)]
	uint Count
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ICoreWebView2ContextMenuItem GetValueAtIndex([In] uint index);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void RemoveValueAtIndex([In] uint index);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void InsertValueAtIndex([In] uint index, [In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2ContextMenuItem value);
}
