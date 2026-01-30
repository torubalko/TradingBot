using System;
using System.Security.Cryptography;

namespace Microsoft.IdentityModel.Tokens;

internal static class CryptoThrowHelper
{
	private sealed class WindowsCryptographicException : CryptographicException
	{
		public WindowsCryptographicException(int hr, string message)
			: base(message)
		{
			base.HResult = hr;
		}

		public WindowsCryptographicException(string message)
			: base(message)
		{
		}

		public WindowsCryptographicException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		public WindowsCryptographicException()
		{
		}
	}

	public static CryptographicException ToCryptographicException(this int hr)
	{
		string message = Interop.Kernel32.GetMessage(hr);
		if ((hr & 0x80000000u) != 2147483648u)
		{
			hr = (hr & 0xFFFF) | -2147024896;
		}
		return new WindowsCryptographicException(hr, message);
	}
}
