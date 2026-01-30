using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using MimeKit.Utils;
using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Bcpg.Sig;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace MimeKit.Cryptography;

public abstract class OpenPgpContext : OpenPgpContextBase
{
	protected string PublicKeyRingPath { get; set; }

	protected string SecretKeyRingPath { get; set; }

	public PgpPublicKeyRingBundle PublicKeyRingBundle { get; protected set; }

	public PgpSecretKeyRingBundle SecretKeyRingBundle { get; protected set; }

	protected OpenPgpContext()
	{
	}

	protected OpenPgpContext(string pubring, string secring)
		: this()
	{
		if (pubring == null)
		{
			throw new ArgumentNullException("pubring");
		}
		if (secring == null)
		{
			throw new ArgumentNullException("secring");
		}
		PublicKeyRingPath = pubring;
		SecretKeyRingPath = secring;
		if (File.Exists(pubring))
		{
			using FileStream inputStream = File.OpenRead(pubring);
			PublicKeyRingBundle = new PgpPublicKeyRingBundle(inputStream);
		}
		else
		{
			PublicKeyRingBundle = new PgpPublicKeyRingBundle(new byte[0]);
		}
		if (File.Exists(secring))
		{
			using (FileStream inputStream2 = File.OpenRead(secring))
			{
				SecretKeyRingBundle = new PgpSecretKeyRingBundle(inputStream2);
				return;
			}
		}
		SecretKeyRingBundle = new PgpSecretKeyRingBundle(new byte[0]);
	}

	private bool TryGetPublicKeyRing(long keyId, out PgpPublicKeyRing keyring)
	{
		foreach (PgpPublicKeyRing keyRing in PublicKeyRingBundle.GetKeyRings())
		{
			foreach (PgpPublicKey publicKey in keyRing.GetPublicKeys())
			{
				if (publicKey.KeyId == keyId)
				{
					keyring = keyRing;
					return true;
				}
			}
		}
		keyring = null;
		return false;
	}

	protected override PgpPublicKeyRing GetPublicKeyRing(long keyId, CancellationToken cancellationToken)
	{
		if (TryGetPublicKeyRing(keyId, out var keyring))
		{
			return keyring;
		}
		if (base.AutoKeyRetrieve)
		{
			return RetrievePublicKeyRing(keyId, cancellationToken);
		}
		return null;
	}

	protected override async Task<PgpPublicKeyRing> GetPublicKeyRingAsync(long keyId, CancellationToken cancellationToken)
	{
		if (TryGetPublicKeyRing(keyId, out var keyring))
		{
			return keyring;
		}
		if (base.AutoKeyRetrieve)
		{
			return await RetrievePublicKeyRingAsync(keyId, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		}
		return null;
	}

	public virtual IEnumerable<PgpPublicKeyRing> EnumeratePublicKeyRings()
	{
		foreach (PgpPublicKeyRing keyRing in PublicKeyRingBundle.GetKeyRings())
		{
			yield return keyRing;
		}
	}

	public virtual IEnumerable<PgpPublicKey> EnumeratePublicKeys()
	{
		foreach (PgpPublicKeyRing item in EnumeratePublicKeyRings())
		{
			foreach (PgpPublicKey publicKey in item.GetPublicKeys())
			{
				yield return publicKey;
			}
		}
	}

	public virtual IEnumerable<PgpPublicKeyRing> EnumeratePublicKeyRings(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		foreach (PgpPublicKeyRing item in EnumeratePublicKeyRings())
		{
			if (OpenPgpContextBase.IsMatch(item.GetPublicKey(), mailbox))
			{
				yield return item;
			}
		}
	}

	public virtual IEnumerable<PgpPublicKey> EnumeratePublicKeys(MailboxAddress mailbox)
	{
		foreach (PgpPublicKeyRing item in EnumeratePublicKeyRings(mailbox))
		{
			foreach (PgpPublicKey publicKey in item.GetPublicKeys())
			{
				yield return publicKey;
			}
		}
	}

	public virtual IEnumerable<PgpSecretKeyRing> EnumerateSecretKeyRings()
	{
		foreach (PgpSecretKeyRing keyRing in SecretKeyRingBundle.GetKeyRings())
		{
			yield return keyRing;
		}
	}

	public virtual IEnumerable<PgpSecretKey> EnumerateSecretKeys()
	{
		foreach (PgpSecretKeyRing item in EnumerateSecretKeyRings())
		{
			foreach (PgpSecretKey secretKey in item.GetSecretKeys())
			{
				yield return secretKey;
			}
		}
	}

	public virtual IEnumerable<PgpSecretKeyRing> EnumerateSecretKeyRings(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		foreach (PgpSecretKeyRing item in EnumerateSecretKeyRings())
		{
			if (OpenPgpContextBase.IsMatch(item.GetSecretKey(), mailbox))
			{
				yield return item;
			}
		}
	}

	public virtual IEnumerable<PgpSecretKey> EnumerateSecretKeys(MailboxAddress mailbox)
	{
		foreach (PgpSecretKeyRing item in EnumerateSecretKeyRings(mailbox))
		{
			foreach (PgpSecretKey secretKey in item.GetSecretKeys())
			{
				yield return secretKey;
			}
		}
	}

	protected virtual PgpPublicKey GetPublicKey(MailboxAddress mailbox)
	{
		foreach (PgpPublicKey item in EnumeratePublicKeys(mailbox))
		{
			if (item.IsEncryptionKey && !item.IsRevoked() && !OpenPgpContextBase.IsExpired(item))
			{
				return item;
			}
		}
		throw new PublicKeyNotFoundException(mailbox, "The public key could not be found.");
	}

	public override IList<PgpPublicKey> GetPublicKeys(IEnumerable<MailboxAddress> mailboxes)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		List<PgpPublicKey> list = new List<PgpPublicKey>();
		foreach (MailboxAddress mailbox in mailboxes)
		{
			list.Add(GetPublicKey(mailbox));
		}
		return list;
	}

	protected override PgpSecretKey GetSecretKey(long keyId)
	{
		foreach (PgpSecretKey item in EnumerateSecretKeys())
		{
			if (item.KeyId == keyId)
			{
				return item;
			}
		}
		throw new PrivateKeyNotFoundException(keyId, "The secret key could not be found.");
	}

	public override PgpSecretKey GetSigningKey(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		foreach (PgpSecretKeyRing item in EnumerateSecretKeyRings(mailbox))
		{
			foreach (PgpSecretKey secretKey in item.GetSecretKeys())
			{
				if (secretKey.IsSigningKey)
				{
					PgpPublicKey publicKey = secretKey.PublicKey;
					if (!publicKey.IsRevoked() && !OpenPgpContextBase.IsExpired(publicKey))
					{
						return secretKey;
					}
				}
			}
		}
		throw new PrivateKeyNotFoundException(mailbox, "The private key could not be found.");
	}

	public override bool CanSign(MailboxAddress signer)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		foreach (PgpSecretKey item in EnumerateSecretKeys(signer))
		{
			if (item.IsSigningKey)
			{
				PgpPublicKey publicKey = item.PublicKey;
				if (!publicKey.IsRevoked() && !OpenPgpContextBase.IsExpired(publicKey))
				{
					return true;
				}
			}
		}
		return false;
	}

	public override bool CanEncrypt(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		foreach (PgpPublicKey item in EnumeratePublicKeys(mailbox))
		{
			if (item.IsEncryptionKey && !item.IsRevoked() && !OpenPgpContextBase.IsExpired(item))
			{
				return true;
			}
		}
		return false;
	}

	private void AddEncryptionKeyPair(PgpKeyRingGenerator keyRingGenerator, KeyGenerationParameters parameters, PublicKeyAlgorithmTag algorithm, DateTime now, long expirationTime, int[] encryptionAlgorithms, int[] digestAlgorithms)
	{
		IAsymmetricCipherKeyPairGenerator keyPairGenerator = GeneratorUtilities.GetKeyPairGenerator("RSA");
		keyPairGenerator.Init(parameters);
		PgpKeyPair keyPair = new PgpKeyPair(algorithm, keyPairGenerator.GenerateKeyPair(), now);
		PgpSignatureSubpacketGenerator pgpSignatureSubpacketGenerator = new PgpSignatureSubpacketGenerator();
		pgpSignatureSubpacketGenerator.SetKeyFlags(isCritical: false, 12);
		pgpSignatureSubpacketGenerator.SetPreferredSymmetricAlgorithms(isCritical: false, encryptionAlgorithms);
		pgpSignatureSubpacketGenerator.SetPreferredHashAlgorithms(isCritical: false, digestAlgorithms);
		if (expirationTime > 0)
		{
			pgpSignatureSubpacketGenerator.SetKeyExpirationTime(isCritical: false, expirationTime);
			pgpSignatureSubpacketGenerator.SetSignatureExpirationTime(isCritical: false, expirationTime);
		}
		keyRingGenerator.AddSubKey(keyPair, pgpSignatureSubpacketGenerator.Generate(), null);
	}

	private PgpKeyRingGenerator CreateKeyRingGenerator(MailboxAddress mailbox, EncryptionAlgorithm algorithm, long expirationTime, string password, DateTime now, SecureRandom random)
	{
		EncryptionAlgorithm[] array = base.EnabledEncryptionAlgorithms;
		DigestAlgorithm[] array2 = base.EnabledDigestAlgorithms;
		int[] array3 = new int[array.Length];
		int[] array4 = new int[array2.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array3[i] = (int)array[i];
		}
		for (int j = 0; j < array2.Length; j++)
		{
			array4[j] = (int)array2[j];
		}
		RsaKeyGenerationParameters parameters = new RsaKeyGenerationParameters(BigInteger.ValueOf(65537L), random, 2048, 12);
		PublicKeyAlgorithmTag algorithm2 = PublicKeyAlgorithmTag.RsaSign;
		IAsymmetricCipherKeyPairGenerator keyPairGenerator = GeneratorUtilities.GetKeyPairGenerator("RSA");
		keyPairGenerator.Init(parameters);
		PgpKeyPair masterKey = new PgpKeyPair(algorithm2, keyPairGenerator.GenerateKeyPair(), now);
		PgpSignatureSubpacketGenerator pgpSignatureSubpacketGenerator = new PgpSignatureSubpacketGenerator();
		pgpSignatureSubpacketGenerator.SetKeyFlags(isCritical: false, 3);
		pgpSignatureSubpacketGenerator.SetPreferredSymmetricAlgorithms(isCritical: false, array3);
		pgpSignatureSubpacketGenerator.SetPreferredHashAlgorithms(isCritical: false, array4);
		if (expirationTime > 0)
		{
			pgpSignatureSubpacketGenerator.SetKeyExpirationTime(isCritical: false, expirationTime);
			pgpSignatureSubpacketGenerator.SetSignatureExpirationTime(isCritical: false, expirationTime);
		}
		pgpSignatureSubpacketGenerator.SetFeature(isCritical: false, Features.FEATURE_MODIFICATION_DETECTION);
		PgpKeyRingGenerator pgpKeyRingGenerator = new PgpKeyRingGenerator(19, masterKey, mailbox.ToString(encode: false), OpenPgpContextBase.GetSymmetricKeyAlgorithm(algorithm), CharsetUtils.UTF8.GetBytes(password), useSha1: true, pgpSignatureSubpacketGenerator.Generate(), null, random);
		AddEncryptionKeyPair(pgpKeyRingGenerator, parameters, PublicKeyAlgorithmTag.RsaGeneral, now, expirationTime, array3, array4);
		return pgpKeyRingGenerator;
	}

	public void GenerateKeyPair(MailboxAddress mailbox, string password, DateTime? expirationDate = null, EncryptionAlgorithm algorithm = EncryptionAlgorithm.Aes256, SecureRandom random = null)
	{
		DateTime utcNow = DateTime.UtcNow;
		long expirationTime = 0L;
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		if (expirationDate.HasValue)
		{
			DateTime dateTime = expirationDate.Value.ToUniversalTime();
			if (dateTime <= utcNow)
			{
				throw new ArgumentException("expirationDate needs to be greater than DateTime.Now", "expirationDate");
			}
			if ((expirationTime = Convert.ToInt64(dateTime.Subtract(utcNow).TotalSeconds)) <= 0)
			{
				throw new ArgumentException("expirationDate needs to be greater than DateTime.Now", "expirationDate");
			}
		}
		if (random == null)
		{
			random = new SecureRandom(new CryptoApiRandomGenerator());
		}
		PgpKeyRingGenerator pgpKeyRingGenerator = CreateKeyRingGenerator(mailbox, algorithm, expirationTime, password, utcNow, random);
		Import(pgpKeyRingGenerator.GenerateSecretKeyRing());
		Import(pgpKeyRingGenerator.GeneratePublicKeyRing());
	}

	public void SignKey(PgpSecretKey secretKey, PgpPublicKey publicKey, DigestAlgorithm digestAlgo = DigestAlgorithm.Sha1, OpenPgpKeyCertification certification = OpenPgpKeyCertification.GenericCertification)
	{
		if (secretKey == null)
		{
			throw new ArgumentNullException("secretKey");
		}
		if (publicKey == null)
		{
			throw new ArgumentNullException("publicKey");
		}
		PgpPrivateKey privateKey = GetPrivateKey(secretKey);
		PgpSignatureGenerator pgpSignatureGenerator = new PgpSignatureGenerator(secretKey.PublicKey.Algorithm, OpenPgpContextBase.GetHashAlgorithm(digestAlgo));
		pgpSignatureGenerator.InitSign((int)certification, privateKey);
		pgpSignatureGenerator.GenerateOnePassVersion(isNested: false);
		PgpSignatureSubpacketGenerator pgpSignatureSubpacketGenerator = new PgpSignatureSubpacketGenerator();
		PgpSignatureSubpacketVector hashedSubpackets = pgpSignatureSubpacketGenerator.Generate();
		pgpSignatureGenerator.SetHashedSubpackets(hashedSubpackets);
		PgpPublicKey pgpPublicKey = PgpPublicKey.AddCertification(publicKey, pgpSignatureGenerator.Generate());
		PgpPublicKeyRing pgpPublicKeyRing = null;
		foreach (PgpPublicKeyRing item in EnumeratePublicKeyRings())
		{
			foreach (PgpPublicKey publicKey2 in item.GetPublicKeys())
			{
				if (publicKey2.KeyId == publicKey.KeyId)
				{
					PublicKeyRingBundle = PgpPublicKeyRingBundle.RemovePublicKeyRing(PublicKeyRingBundle, item);
					pgpPublicKeyRing = PgpPublicKeyRing.InsertPublicKey(item, pgpPublicKey);
					break;
				}
			}
		}
		if (pgpPublicKeyRing == null)
		{
			pgpPublicKeyRing = new PgpPublicKeyRing(pgpPublicKey.GetEncoded());
		}
		Import(pgpPublicKeyRing);
	}

	protected void SavePublicKeyRingBundle()
	{
		string text = Path.GetFileName(PublicKeyRingPath) + "~";
		string directoryName = Path.GetDirectoryName(PublicKeyRingPath);
		string text2 = Path.Combine(directoryName, "." + text);
		string destinationBackupFileName = Path.Combine(directoryName, text);
		Directory.CreateDirectory(directoryName);
		using (FileStream fileStream = File.Open(text2, FileMode.Create, FileAccess.Write))
		{
			PublicKeyRingBundle.Encode(fileStream);
			fileStream.Flush();
		}
		if (File.Exists(PublicKeyRingPath))
		{
			File.Replace(text2, PublicKeyRingPath, destinationBackupFileName);
		}
		else
		{
			File.Move(text2, PublicKeyRingPath);
		}
	}

	protected void SaveSecretKeyRingBundle()
	{
		string text = Path.GetFileName(SecretKeyRingPath) + "~";
		string directoryName = Path.GetDirectoryName(SecretKeyRingPath);
		string text2 = Path.Combine(directoryName, "." + text);
		string destinationBackupFileName = Path.Combine(directoryName, text);
		Directory.CreateDirectory(directoryName);
		using (FileStream fileStream = File.Open(text2, FileMode.Create, FileAccess.Write))
		{
			SecretKeyRingBundle.Encode(fileStream);
			fileStream.Flush();
		}
		if (File.Exists(SecretKeyRingPath))
		{
			File.Replace(text2, SecretKeyRingPath, destinationBackupFileName);
		}
		else
		{
			File.Move(text2, SecretKeyRingPath);
		}
	}

	public virtual void Import(PgpPublicKeyRing keyring)
	{
		if (keyring == null)
		{
			throw new ArgumentNullException("keyring");
		}
		PublicKeyRingBundle = PgpPublicKeyRingBundle.AddPublicKeyRing(PublicKeyRingBundle, keyring);
		SavePublicKeyRingBundle();
	}

	public override void Import(PgpPublicKeyRingBundle bundle)
	{
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		int num = 0;
		foreach (PgpPublicKeyRing keyRing in bundle.GetKeyRings())
		{
			PublicKeyRingBundle = PgpPublicKeyRingBundle.AddPublicKeyRing(PublicKeyRingBundle, keyRing);
			num++;
		}
		if (num > 0)
		{
			SavePublicKeyRingBundle();
		}
	}

	public override void Import(Stream stream)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		using ArmoredInputStream inputStream = new ArmoredInputStream(stream);
		Import(new PgpPublicKeyRingBundle(inputStream));
	}

	public virtual void Import(PgpSecretKeyRing keyring)
	{
		if (keyring == null)
		{
			throw new ArgumentNullException("keyring");
		}
		SecretKeyRingBundle = PgpSecretKeyRingBundle.AddSecretKeyRing(SecretKeyRingBundle, keyring);
		SaveSecretKeyRingBundle();
	}

	public virtual void Import(PgpSecretKeyRingBundle bundle)
	{
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		int num = 0;
		foreach (PgpSecretKeyRing keyRing in bundle.GetKeyRings())
		{
			SecretKeyRingBundle = PgpSecretKeyRingBundle.AddSecretKeyRing(SecretKeyRingBundle, keyRing);
			num++;
		}
		if (num > 0)
		{
			SaveSecretKeyRingBundle();
		}
	}

	public override MimePart Export(IEnumerable<MailboxAddress> mailboxes)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		List<PgpPublicKeyRing> list = new List<PgpPublicKeyRing>();
		foreach (MailboxAddress mailbox in mailboxes)
		{
			list.AddRange(EnumeratePublicKeyRings(mailbox));
		}
		PgpPublicKeyRingBundle keys = new PgpPublicKeyRingBundle(list);
		return Export(keys);
	}

	public MimePart Export(IEnumerable<PgpPublicKey> keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		IEnumerable<PgpPublicKeyRing> e = keys.Select((PgpPublicKey key) => new PgpPublicKeyRing(key.GetEncoded()));
		PgpPublicKeyRingBundle keys2 = new PgpPublicKeyRingBundle(e);
		return Export(keys2);
	}

	public MimePart Export(PgpPublicKeyRingBundle keys)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		Export(keys, memoryBlockStream, armor: true);
		memoryBlockStream.Position = 0L;
		return new MimePart("application", "pgp-keys")
		{
			ContentDisposition = new ContentDisposition("attachment"),
			Content = new MimeContent(memoryBlockStream)
		};
	}

	public void Export(IEnumerable<MailboxAddress> mailboxes, Stream stream, bool armor)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		List<PgpPublicKeyRing> list = new List<PgpPublicKeyRing>();
		foreach (MailboxAddress mailbox in mailboxes)
		{
			list.AddRange(EnumeratePublicKeyRings(mailbox));
		}
		PgpPublicKeyRingBundle keys = new PgpPublicKeyRingBundle(list);
		Export(keys, stream, armor);
	}

	public void Export(IEnumerable<PgpPublicKey> keys, Stream stream, bool armor)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		IEnumerable<PgpPublicKeyRing> e = keys.Select((PgpPublicKey key) => new PgpPublicKeyRing(key.GetEncoded()));
		PgpPublicKeyRingBundle keys2 = new PgpPublicKeyRingBundle(e);
		Export(keys2, stream, armor);
	}

	public void Export(PgpPublicKeyRingBundle keys, Stream stream, bool armor)
	{
		if (keys == null)
		{
			throw new ArgumentNullException("keys");
		}
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (armor)
		{
			using (ArmoredOutputStream armoredOutputStream = new ArmoredOutputStream(stream))
			{
				armoredOutputStream.SetHeader("Version", null);
				keys.Encode(armoredOutputStream);
				armoredOutputStream.Flush();
				return;
			}
		}
		keys.Encode(stream);
	}

	public virtual void Delete(PgpPublicKeyRing keyring)
	{
		if (keyring == null)
		{
			throw new ArgumentNullException("keyring");
		}
		PublicKeyRingBundle = PgpPublicKeyRingBundle.RemovePublicKeyRing(PublicKeyRingBundle, keyring);
		SavePublicKeyRingBundle();
	}

	public virtual void Delete(PgpSecretKeyRing keyring)
	{
		if (keyring == null)
		{
			throw new ArgumentNullException("keyring");
		}
		SecretKeyRingBundle = PgpSecretKeyRingBundle.RemoveSecretKeyRing(SecretKeyRingBundle, keyring);
		SaveSecretKeyRingBundle();
	}
}
