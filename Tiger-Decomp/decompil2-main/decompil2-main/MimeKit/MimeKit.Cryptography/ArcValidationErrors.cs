using System;

namespace MimeKit.Cryptography;

[Flags]
public enum ArcValidationErrors
{
	None = 0,
	DuplicateArcAuthenticationResults = 1,
	DuplicateArcMessageSignature = 2,
	DuplicateArcSeal = 4,
	MissingArcAuthenticationResults = 8,
	MissingArcMessageSignature = 0x10,
	MissingArcSeal = 0x20,
	InvalidArcAuthenticationResults = 0x40,
	InvalidArcMessageSignature = 0x80,
	InvalidArcSeal = 0x100,
	InvalidArcSealChainValidationValue = 0x200,
	MissingArcSealChainValidationValue = 0x400,
	MessageSignatureValidationFailed = 0x800,
	SealValidationFailed = 0x1000
}
