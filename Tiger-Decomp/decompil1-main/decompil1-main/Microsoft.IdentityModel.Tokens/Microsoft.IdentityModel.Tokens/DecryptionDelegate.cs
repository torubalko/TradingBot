namespace Microsoft.IdentityModel.Tokens;

internal delegate byte[] DecryptionDelegate(byte[] cipherText, byte[] authenticatedData, byte[] iv, byte[] authenticationTag);
