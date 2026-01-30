using System;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal static class Cng
{
	[Flags]
	public enum OpenAlgorithmProviderFlags
	{
		NONE = 0,
		BCRYPT_ALG_HANDLE_HMAC_FLAG = 8
	}

	public const string BCRYPT_AES_ALGORITHM = "AES";

	public const string BCRYPT_CHAIN_MODE_GCM = "ChainingModeGCM";

	public static SafeAlgorithmHandle BCryptOpenAlgorithmProvider(string pszAlgId, string pszImplementation, OpenAlgorithmProviderFlags dwFlags)
	{
		SafeAlgorithmHandle phAlgorithm;
		Interop.BCrypt.NTSTATUS nTSTATUS = Interop.BCrypt.BCryptOpenAlgorithmProvider(out phAlgorithm, pszAlgId, pszImplementation, (int)dwFlags);
		if (nTSTATUS != Interop.BCrypt.NTSTATUS.STATUS_SUCCESS)
		{
			throw LogHelper.LogExceptionMessage(CreateCryptographicException(nTSTATUS));
		}
		return phAlgorithm;
	}

	public static void SetCipherMode(this SafeAlgorithmHandle hAlg, string cipherMode)
	{
		Interop.BCrypt.NTSTATUS nTSTATUS = Interop.BCrypt.BCryptSetProperty(hAlg, "ChainingMode", cipherMode, (cipherMode.Length + 1) * 2, 0);
		if (nTSTATUS != Interop.BCrypt.NTSTATUS.STATUS_SUCCESS)
		{
			throw LogHelper.LogExceptionMessage(CreateCryptographicException(nTSTATUS));
		}
	}

	private static Exception CreateCryptographicException(Interop.BCrypt.NTSTATUS ntStatus)
	{
		return ((int)(ntStatus | (Interop.BCrypt.NTSTATUS)16777216u)).ToCryptographicException();
	}
}
