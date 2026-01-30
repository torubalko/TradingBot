using System;
using System.Runtime.InteropServices;

namespace Microsoft.IdentityModel.Tokens;

internal sealed class SafeAlgorithmHandle : SafeBCryptHandle
{
	protected sealed override bool ReleaseHandle()
	{
		return BCryptCloseAlgorithmProvider(handle, 0) == 0;
	}

	[DllImport("BCrypt.dll")]
	private static extern uint BCryptCloseAlgorithmProvider(IntPtr hAlgorithm, int dwFlags);
}
