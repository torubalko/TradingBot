using System;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Logging;

namespace Microsoft.IdentityModel.Tokens;

internal static class AesAead
{
	public static void CheckArgumentsForNull(byte[] nonce, byte[] plaintext, byte[] ciphertext, byte[] tag)
	{
		if (nonce == null)
		{
			throw LogHelper.LogArgumentNullException("nonce");
		}
		if (plaintext == null)
		{
			throw LogHelper.LogArgumentNullException("plaintext");
		}
		if (ciphertext == null)
		{
			throw LogHelper.LogArgumentNullException("ciphertext");
		}
		if (tag == null)
		{
			throw LogHelper.LogArgumentNullException("tag");
		}
	}

	public unsafe static void Decrypt(SafeKeyHandle keyHandle, byte[] nonce, byte[] associatedData, byte[] ciphertext, byte[] tag, byte[] plaintext, bool clearPlaintextOnFailure)
	{
		fixed (byte* pbOutput = plaintext)
		{
			fixed (byte* pbNonce = nonce)
			{
				fixed (byte* pbInput = ciphertext)
				{
					fixed (byte* pbTag = tag)
					{
						fixed (byte* pbAuthData = associatedData)
						{
							Interop.BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO = Interop.BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.Create();
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbNonce = pbNonce;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbNonce = nonce.Length;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbTag = pbTag;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbTag = tag.Length;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbAuthData = pbAuthData;
							if (associatedData == null)
							{
								bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbAuthData = 0;
							}
							else
							{
								bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbAuthData = associatedData.Length;
							}
							int cbResult;
							Interop.BCrypt.NTSTATUS nTSTATUS = Interop.BCrypt.BCryptDecrypt(keyHandle, pbInput, ciphertext.Length, new IntPtr(&bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO), null, 0, pbOutput, plaintext.Length, out cbResult, 0);
							switch (nTSTATUS)
							{
							case Interop.BCrypt.NTSTATUS.STATUS_SUCCESS:
								break;
							case Interop.BCrypt.NTSTATUS.STATUS_AUTH_TAG_MISMATCH:
								if (clearPlaintextOnFailure)
								{
									CryptographicOperations.ZeroMemory(plaintext);
								}
								throw LogHelper.LogExceptionMessage(new CryptographicException(LogHelper.FormatInvariant("IDX10714: Unable to perform the decryption. There is a authentication tag mismatch.")));
							default:
								throw LogHelper.LogExceptionMessage(Interop.BCrypt.CreateCryptographicException(nTSTATUS));
							}
						}
					}
				}
			}
		}
	}

	internal unsafe static void Encrypt(SafeKeyHandle keyHandle, byte[] nonce, byte[] associatedData, byte[] plaintext, byte[] ciphertext, byte[] tag)
	{
		fixed (byte* pbInput = plaintext)
		{
			fixed (byte* pbNonce = nonce)
			{
				fixed (byte* pbOutput = ciphertext)
				{
					fixed (byte* pbTag = tag)
					{
						fixed (byte* pbAuthData = associatedData)
						{
							Interop.BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO = Interop.BCrypt.BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.Create();
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbNonce = pbNonce;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbNonce = nonce.Length;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbTag = pbTag;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbTag = tag.Length;
							bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.pbAuthData = pbAuthData;
							if (associatedData == null)
							{
								bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbAuthData = 0;
							}
							else
							{
								bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO.cbAuthData = associatedData.Length;
							}
							int cbResult;
							Interop.BCrypt.NTSTATUS nTSTATUS = Interop.BCrypt.BCryptEncrypt(keyHandle, pbInput, plaintext.Length, new IntPtr(&bCRYPT_AUTHENTICATED_CIPHER_MODE_INFO), null, 0, pbOutput, ciphertext.Length, out cbResult, 0);
							if (nTSTATUS != Interop.BCrypt.NTSTATUS.STATUS_SUCCESS)
							{
								throw Interop.BCrypt.CreateCryptographicException(nTSTATUS);
							}
						}
					}
				}
			}
		}
	}
}
