namespace MimeKit.Cryptography;

public enum SecureMimeType
{
	Unknown = -1,
	CompressedData,
	EnvelopedData,
	SignedData,
	CertsOnly,
	AuthEnvelopedData
}
