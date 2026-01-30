using System;
using System.Runtime.InteropServices;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal class Interop
{
	internal static class BCrypt
	{
		internal struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO
		{
			private int cbSize;

			private uint dwInfoVersion;

			internal unsafe byte* pbNonce;

			internal int cbNonce;

			internal unsafe byte* pbAuthData;

			internal int cbAuthData;

			internal unsafe byte* pbTag;

			internal int cbTag;

			internal unsafe byte* pbMacContext;

			internal int cbMacContext;

			internal int cbAAD;

			internal ulong cbData;

			internal uint dwFlags;

			public unsafe static BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO Create()
			{
				return new BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO
				{
					cbSize = sizeof(BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO),
					dwInfoVersion = 1u
				};
			}
		}

		private struct BCRYPT_KEY_DATA_BLOB_HEADER
		{
			public uint dwMagic;

			public uint dwVersion;

			public uint cbKeyData;

			public const uint BCRYPT_KEY_DATA_BLOB_MAGIC = 1296188491u;

			public const uint BCRYPT_KEY_DATA_BLOB_VERSION1 = 1u;
		}

		internal enum NTSTATUS : uint
		{
			STATUS_SUCCESS = 0u,
			STATUS_NOT_FOUND = 3221226021u,
			STATUS_INVALID_PARAMETER = 3221225485u,
			STATUS_NO_MEMORY = 3221225495u,
			STATUS_AUTH_TAG_MISMATCH = 3221266434u
		}

		internal static class BCryptPropertyStrings
		{
			internal const string BCRYPT_CHAINING_MODE = "ChainingMode";

			internal const string BCRYPT_ECC_PARAMETERS = "ECCParameters";

			internal const string BCRYPT_EFFECTIVE_KEY_LENGTH = "EffectiveKeyLength";

			internal const string BCRYPT_HASH_LENGTH = "HashDigestLength";

			internal const string BCRYPT_MESSAGE_BLOCK_LENGTH = "MessageBlockLength";
		}

		internal static Exception CreateCryptographicException(NTSTATUS ntStatus)
		{
			return ((int)(ntStatus | (NTSTATUS)16777216u)).ToCryptographicException();
		}

		internal unsafe static SafeKeyHandle BCryptImportKey(SafeAlgorithmHandle hAlg, byte[] key)
		{
			int num = key.Length;
			int num2 = sizeof(BCRYPT_KEY_DATA_BLOB_HEADER) + num;
			byte[] array = new byte[num2];
			fixed (byte* ptr = array)
			{
				BCRYPT_KEY_DATA_BLOB_HEADER* ptr2 = (BCRYPT_KEY_DATA_BLOB_HEADER*)ptr;
				ptr2->dwMagic = 1296188491u;
				ptr2->dwVersion = 1u;
				ptr2->cbKeyData = (uint)num;
			}
			key.CopyTo(array, sizeof(BCRYPT_KEY_DATA_BLOB_HEADER));
			SafeKeyHandle hKey;
			NTSTATUS nTSTATUS = BCryptImportKey(hAlg, IntPtr.Zero, "KeyDataBlob", out hKey, IntPtr.Zero, 0, array, num2, 0);
			if (nTSTATUS != NTSTATUS.STATUS_SUCCESS)
			{
				throw LogHelper.LogExceptionMessage(CreateCryptographicException(nTSTATUS));
			}
			return hKey;
		}

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode)]
		public unsafe static extern NTSTATUS BCryptEncrypt(SafeKeyHandle hKey, byte* pbInput, int cbInput, IntPtr paddingInfo, [In][Out] byte[] pbIV, int cbIV, byte* pbOutput, int cbOutput, out int cbResult, int dwFlags);

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode)]
		public unsafe static extern NTSTATUS BCryptDecrypt(SafeKeyHandle hKey, byte* pbInput, int cbInput, IntPtr paddingInfo, [In][Out] byte[] pbIV, int cbIV, byte* pbOutput, int cbOutput, out int cbResult, int dwFlags);

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode)]
		private static extern NTSTATUS BCryptImportKey(SafeAlgorithmHandle hAlgorithm, IntPtr hImportKey, string pszBlobType, out SafeKeyHandle hKey, IntPtr pbKeyObject, int cbKeyObject, byte[] pbInput, int cbInput, int dwFlags);

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode)]
		public static extern NTSTATUS BCryptOpenAlgorithmProvider(out SafeAlgorithmHandle phAlgorithm, string pszAlgId, string pszImplementation, int dwFlags);

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode)]
		public static extern NTSTATUS BCryptSetProperty(SafeAlgorithmHandle hObject, string pszProperty, string pbInput, int cbInput, int dwFlags);

		[DllImport("BCrypt.dll", CharSet = CharSet.Unicode, EntryPoint = "BCryptSetProperty")]
		private static extern NTSTATUS BCryptSetIntPropertyPrivate(SafeBCryptHandle hObject, string pszProperty, ref int pdwInput, int cbInput, int dwFlags);

		public static NTSTATUS BCryptSetIntProperty(SafeBCryptHandle hObject, string pszProperty, ref int pdwInput, int dwFlags)
		{
			return BCryptSetIntPropertyPrivate(hObject, pszProperty, ref pdwInput, 4, dwFlags);
		}
	}

	internal static class Kernel32
	{
		private const int FORMAT_MESSAGE_IGNORE_INSERTS = 512;

		private const int FORMAT_MESSAGE_FROM_HMODULE = 2048;

		private const int FORMAT_MESSAGE_FROM_SYSTEM = 4096;

		private const int FORMAT_MESSAGE_ARGUMENT_ARRAY = 8192;

		private const int FORMAT_MESSAGE_ALLOCATE_BUFFER = 256;

		private const int ERROR_INSUFFICIENT_BUFFER = 122;

		[DllImport("kernel32.dll", BestFitMapping = true, CharSet = CharSet.Unicode, EntryPoint = "FormatMessageW", ExactSpelling = true, SetLastError = true)]
		private unsafe static extern int FormatMessage(int dwFlags, IntPtr lpSource, uint dwMessageId, int dwLanguageId, void* lpBuffer, int nSize, IntPtr arguments);

		internal static string GetMessage(int errorCode)
		{
			return GetMessage(errorCode, IntPtr.Zero);
		}

		internal unsafe static string GetMessage(int errorCode, IntPtr moduleHandle)
		{
			int num = 12800;
			if (moduleHandle != IntPtr.Zero)
			{
				num |= 0x800;
			}
			char[] array = new char[256];
			fixed (char* lpBuffer = array)
			{
				int num2 = FormatMessage(num, moduleHandle, (uint)errorCode, 0, lpBuffer, array.Length, IntPtr.Zero);
				if (num2 > 0)
				{
					return GetAndTrimString(array, num2);
				}
			}
			if (Marshal.GetLastWin32Error() == 122)
			{
				IntPtr intPtr = default(IntPtr);
				try
				{
					int num3 = FormatMessage(num | 0x100, moduleHandle, (uint)errorCode, 0, &intPtr, 0, IntPtr.Zero);
					if (num3 > 0)
					{
						return GetAndTrimString(Marshal.PtrToStringAnsi(intPtr).ToCharArray(), num3);
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			return $"Unknown error (0x{errorCode:x})";
		}

		private static string GetAndTrimString(char[] buffer, int length)
		{
			while (length > 0 && buffer[length - 1] <= ' ')
			{
				length--;
			}
			return new string(buffer, 0, length);
		}
	}

	internal static class Libraries
	{
		internal const string BCrypt = "BCrypt.dll";

		internal const string Kernel32 = "kernel32.dll";
	}
}
