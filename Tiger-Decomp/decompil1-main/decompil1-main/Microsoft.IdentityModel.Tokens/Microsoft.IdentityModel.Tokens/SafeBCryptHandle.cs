using System;
using System.Runtime.InteropServices;

namespace Microsoft.IdentityModel.Tokens;

internal abstract class SafeBCryptHandle : SafeHandle
{
	public sealed override bool IsInvalid => handle == IntPtr.Zero;

	protected SafeBCryptHandle()
		: base(IntPtr.Zero, ownsHandle: true)
	{
	}

	protected abstract override bool ReleaseHandle();
}
