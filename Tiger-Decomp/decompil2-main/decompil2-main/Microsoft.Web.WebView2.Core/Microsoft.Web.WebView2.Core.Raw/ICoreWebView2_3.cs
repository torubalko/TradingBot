using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("A0D6DF20-3B92-416D-AA0C-437A9C727857")]
[TypeIdentifier]
public interface ICoreWebView2_3 : ICoreWebView2_2
{
	void _VtblGap1_65();

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void TrySuspend([In][MarshalAs(UnmanagedType.Interface)] ICoreWebView2TrySuspendCompletedHandler handler);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void Resume();

	[DispId(1610809346)]
	int IsSuspended
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void SetVirtualHostNameToFolderMapping([In][MarshalAs(UnmanagedType.LPWStr)] string hostName, [In][MarshalAs(UnmanagedType.LPWStr)] string folderPath, [In] COREWEBVIEW2_HOST_RESOURCE_ACCESS_KIND accessKind);

	[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
	void ClearVirtualHostNameToFolderMapping([In][MarshalAs(UnmanagedType.LPWStr)] string hostName);
}
