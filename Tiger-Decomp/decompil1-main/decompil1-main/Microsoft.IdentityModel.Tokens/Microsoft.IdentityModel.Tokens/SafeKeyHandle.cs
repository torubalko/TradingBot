using System;
using System.Runtime.InteropServices;

namespace Microsoft.IdentityModel.Tokens;

internal sealed class SafeKeyHandle : SafeBCryptHandle
{
	private SafeAlgorithmHandle _parentHandle;

	public void SetParentHandle(SafeAlgorithmHandle parentHandle)
	{
		bool success = false;
		parentHandle.DangerousAddRef(ref success);
		_parentHandle = parentHandle;
	}

	protected sealed override bool ReleaseHandle()
	{
		if (_parentHandle != null)
		{
			_parentHandle.DangerousRelease();
			_parentHandle = null;
		}
		return BCryptDestroyKey(handle) == 0;
	}

	[DllImport("BCrypt.dll")]
	private static extern uint BCryptDestroyKey(IntPtr hKey);
}
