namespace Microsoft.IdentityModel.Tokens;

internal delegate AuthenticatedEncryptionResult EncryptionDelegate(byte[] plaintText, byte[] authenticatedData, byte[] iv);
