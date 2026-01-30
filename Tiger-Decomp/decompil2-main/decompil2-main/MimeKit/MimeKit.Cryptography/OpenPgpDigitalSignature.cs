using System;
using System.Globalization;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace MimeKit.Cryptography;

public class OpenPgpDigitalSignature : IDigitalSignature
{
	private DigitalSignatureVerifyException vex;

	private bool? valid;

	internal PgpOnePassSignature OnePassSignature { get; private set; }

	internal PgpSignature Signature { get; set; }

	public IDigitalCertificate SignerCertificate { get; private set; }

	public PublicKeyAlgorithm PublicKeyAlgorithm { get; internal set; }

	public DigestAlgorithm DigestAlgorithm { get; internal set; }

	public DateTime CreationDate { get; internal set; }

	internal OpenPgpDigitalSignature(PgpPublicKeyRing keyring, PgpPublicKey pubkey, PgpOnePassSignature signature)
	{
		SignerCertificate = ((pubkey != null) ? new OpenPgpDigitalCertificate(keyring, pubkey) : null);
		OnePassSignature = signature;
	}

	internal OpenPgpDigitalSignature(PgpPublicKeyRing keyring, PgpPublicKey pubkey, PgpSignature signature)
	{
		SignerCertificate = ((pubkey != null) ? new OpenPgpDigitalCertificate(keyring, pubkey) : null);
		Signature = signature;
	}

	public bool Verify()
	{
		if (valid.HasValue)
		{
			return valid.Value;
		}
		if (vex != null)
		{
			throw vex;
		}
		if (SignerCertificate == null)
		{
			string message = string.Format(CultureInfo.InvariantCulture, "Failed to verify digital signature: no public key found for {0:X8}", (int)Signature.KeyId);
			vex = new DigitalSignatureVerifyException(Signature.KeyId, message);
			throw vex;
		}
		try
		{
			if (OnePassSignature != null)
			{
				valid = OnePassSignature.Verify(Signature);
			}
			else
			{
				valid = Signature.Verify();
			}
			return valid.Value;
		}
		catch (Exception ex)
		{
			string message2 = $"Failed to verify digital signature: {ex.Message}";
			vex = new DigitalSignatureVerifyException(Signature.KeyId, message2, ex);
			throw vex;
		}
	}

	public bool Verify(bool verifySignatureOnly)
	{
		return Verify();
	}
}
