using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Web.WebView2.Core.Raw;

[ComImport]
[CompilerGenerated]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("183E7052-1D03-43A0-AB99-98E043B66B39")]
[TypeIdentifier]
public interface ICoreWebView2Settings5 : ICoreWebView2Settings4
{
	void _VtblGap1_26();

	[DispId(1610940416)]
	int IsPinchZoomEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[param: In]
		set;
	}
}
