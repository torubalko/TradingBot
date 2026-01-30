using System;

namespace Microsoft.IdentityModel.Tokens;

internal static class AesBCryptModes
{
	internal static Lazy<SafeAlgorithmHandle> OpenAesAlgorithm(string cipherMode)
	{
		return new Lazy<SafeAlgorithmHandle>(delegate
		{
			SafeAlgorithmHandle safeAlgorithmHandle = Cng.BCryptOpenAlgorithmProvider("AES", null, Cng.OpenAlgorithmProviderFlags.NONE);
			safeAlgorithmHandle.SetCipherMode(cipherMode);
			return safeAlgorithmHandle;
		});
	}
}
