namespace MimeKit.Cryptography;

internal enum X509KeyUsageBits
{
	DigitalSignature,
	NonRepudiation,
	KeyEncipherment,
	DataEncipherment,
	KeyAgreement,
	KeyCertSign,
	CrlSign,
	EncipherOnly,
	DecipherOnly
}
