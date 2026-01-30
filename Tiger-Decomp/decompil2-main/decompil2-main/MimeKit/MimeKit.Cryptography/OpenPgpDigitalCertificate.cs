using System;
using System.Text;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace MimeKit.Cryptography;

public class OpenPgpDigitalCertificate : IDigitalCertificate
{
	public PgpPublicKeyRing KeyRing { get; private set; }

	public PgpPublicKey PublicKey { get; private set; }

	public PublicKeyAlgorithm PublicKeyAlgorithm => OpenPgpContextBase.GetPublicKeyAlgorithm(PublicKey.Algorithm);

	public DateTime CreationDate => PublicKey.CreationTime;

	public DateTime ExpirationDate
	{
		get
		{
			long validSeconds = PublicKey.GetValidSeconds();
			if (validSeconds <= 0)
			{
				return DateTime.MaxValue;
			}
			return CreationDate.AddSeconds(validSeconds);
		}
	}

	public string Fingerprint { get; private set; }

	public string Email { get; private set; }

	public string Name { get; private set; }

	internal OpenPgpDigitalCertificate(PgpPublicKeyRing keyring, PgpPublicKey pubkey)
	{
		byte[] fingerprint = pubkey.GetFingerprint();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < fingerprint.Length; i++)
		{
			stringBuilder.Append(fingerprint[i].ToString("X2"));
		}
		Fingerprint = stringBuilder.ToString();
		PublicKey = pubkey;
		KeyRing = keyring;
		if (UpdateUserId(pubkey) || pubkey.IsMasterKey)
		{
			return;
		}
		foreach (PgpPublicKey publicKey in keyring.GetPublicKeys())
		{
			if (publicKey.IsMasterKey)
			{
				UpdateUserId(publicKey);
				break;
			}
		}
	}

	private bool UpdateUserId(PgpPublicKey pubkey)
	{
		foreach (string userId in pubkey.GetUserIds())
		{
			byte[] bytes = Encoding.UTF8.GetBytes(userId);
			int index = 0;
			if (MailboxAddress.TryParse(ParserOptions.Default, bytes, ref index, bytes.Length, throwOnError: false, out var mailbox))
			{
				Email = mailbox.Address;
				Name = mailbox.Name;
				return true;
			}
		}
		return false;
	}
}
