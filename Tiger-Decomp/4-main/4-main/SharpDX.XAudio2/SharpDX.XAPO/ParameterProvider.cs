using System;
using System.Runtime.InteropServices;

namespace SharpDX.XAPO;

[Guid("26D95C66-80F2-499A-AD54-5AE7F01C6D98")]
[Shadow(typeof(ParameterProviderShadow))]
internal interface ParameterProvider : ParameterProvider27, IUnknown, ICallbackable, IDisposable
{
	void SetParameters(DataStream parameters);

	void GetParameters(DataStream parameters);
}
