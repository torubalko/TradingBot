using System;
using System.Runtime.CompilerServices;

namespace Microsoft.IdentityModel.Tokens;

internal static class CryptographicOperations
{
	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public static void ZeroMemory(byte[] buffer)
	{
		Array.Clear(buffer, 0, buffer.Length);
	}
}
