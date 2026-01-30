using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace MimeKit.Cryptography;

public abstract class CryptographyContext : IDisposable
{
	private const string SubclassAndRegisterFormat = "You need to subclass {0} and then register it with MimeKit.Cryptography.CryptographyContext.Register().";

	private static Func<SecureMimeContext> SecureMimeContextFactory;

	private static Func<OpenPgpContextBase> PgpContextFactory;

	private static readonly object mutex = new object();

	private EncryptionAlgorithm[] encryptionAlgorithmRank;

	private DigestAlgorithm[] digestAlgorithmRank;

	private int enabledEncryptionAlgorithms;

	private int enabledDigestAlgorithms;

	public abstract string SignatureProtocol { get; }

	public abstract string EncryptionProtocol { get; }

	public abstract string KeyExchangeProtocol { get; }

	protected EncryptionAlgorithm[] EncryptionAlgorithmRank
	{
		get
		{
			return encryptionAlgorithmRank;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("The array of encryption algorithms cannot be empty.", "value");
			}
			encryptionAlgorithmRank = value;
		}
	}

	public EncryptionAlgorithm[] EnabledEncryptionAlgorithms
	{
		get
		{
			List<EncryptionAlgorithm> list = new List<EncryptionAlgorithm>();
			EncryptionAlgorithm[] array = EncryptionAlgorithmRank;
			foreach (EncryptionAlgorithm encryptionAlgorithm in array)
			{
				if (IsEnabled(encryptionAlgorithm))
				{
					list.Add(encryptionAlgorithm);
				}
			}
			return list.ToArray();
		}
	}

	protected DigestAlgorithm[] DigestAlgorithmRank
	{
		get
		{
			return digestAlgorithmRank;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (value.Length == 0)
			{
				throw new ArgumentException("The array of digest algorithms cannot be empty.", "value");
			}
			digestAlgorithmRank = value;
		}
	}

	public DigestAlgorithm[] EnabledDigestAlgorithms
	{
		get
		{
			List<DigestAlgorithm> list = new List<DigestAlgorithm>();
			DigestAlgorithm[] array = DigestAlgorithmRank;
			foreach (DigestAlgorithm digestAlgorithm in array)
			{
				if (IsEnabled(digestAlgorithm))
				{
					list.Add(digestAlgorithm);
				}
			}
			return list.ToArray();
		}
	}

	protected CryptographyContext()
	{
		encryptionAlgorithmRank = new EncryptionAlgorithm[1] { EncryptionAlgorithm.TripleDes };
		Enable(EncryptionAlgorithm.TripleDes);
		digestAlgorithmRank = new DigestAlgorithm[1] { DigestAlgorithm.Sha1 };
		Enable(DigestAlgorithm.Sha1);
	}

	public void Enable(EncryptionAlgorithm algorithm)
	{
		enabledEncryptionAlgorithms |= 1 << (int)algorithm;
	}

	public void Disable(EncryptionAlgorithm algorithm)
	{
		enabledEncryptionAlgorithms &= ~(1 << (int)algorithm);
	}

	public bool IsEnabled(EncryptionAlgorithm algorithm)
	{
		return (enabledEncryptionAlgorithms & (1 << (int)algorithm)) != 0;
	}

	public void Enable(DigestAlgorithm algorithm)
	{
		enabledDigestAlgorithms |= 1 << (int)algorithm;
	}

	public void Disable(DigestAlgorithm algorithm)
	{
		enabledDigestAlgorithms &= ~(1 << (int)algorithm);
	}

	public bool IsEnabled(DigestAlgorithm algorithm)
	{
		return (enabledDigestAlgorithms & (1 << (int)algorithm)) != 0;
	}

	public abstract bool Supports(string protocol);

	public abstract string GetDigestAlgorithmName(DigestAlgorithm micalg);

	public abstract DigestAlgorithm GetDigestAlgorithm(string micalg);

	public abstract bool CanSign(MailboxAddress signer);

	public abstract bool CanEncrypt(MailboxAddress mailbox);

	public abstract MimePart Sign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content);

	public abstract DigitalSignatureCollection Verify(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken));

	public abstract Task<DigitalSignatureCollection> VerifyAsync(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken));

	public abstract MimePart Encrypt(IEnumerable<MailboxAddress> recipients, Stream content);

	public abstract MimeEntity Decrypt(Stream encryptedData, CancellationToken cancellationToken = default(CancellationToken));

	public abstract void Import(Stream stream);

	public abstract MimePart Export(IEnumerable<MailboxAddress> mailboxes);

	protected virtual void Dispose(bool disposing)
	{
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	public static CryptographyContext Create(string protocol)
	{
		if (protocol == null)
		{
			throw new ArgumentNullException("protocol");
		}
		protocol = protocol.ToLowerInvariant();
		lock (mutex)
		{
			switch (protocol)
			{
			case "application/x-pkcs7-signature":
			case "application/pkcs7-signature":
			case "application/x-pkcs7-mime":
			case "application/pkcs7-mime":
			case "application/x-pkcs7-keys":
			case "application/pkcs7-keys":
				if (SecureMimeContextFactory != null)
				{
					return SecureMimeContextFactory();
				}
				return new DefaultSecureMimeContext();
			case "application/x-pgp-signature":
			case "application/pgp-signature":
			case "application/x-pgp-encrypted":
			case "application/pgp-encrypted":
			case "application/x-pgp-keys":
			case "application/pgp-keys":
				if (PgpContextFactory != null)
				{
					return PgpContextFactory();
				}
				throw new NotSupportedException(string.Format("You need to subclass {0} and then register it with MimeKit.Cryptography.CryptographyContext.Register().", "MimeKit.Cryptography.OpenPgpContext or MimeKit.Cryptography.GnuPGContext"));
			default:
				throw new NotSupportedException();
			}
		}
	}

	public static void Register(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		ConstructorInfo ctor = type.GetConstructor(new Type[0]);
		if (ctor == null)
		{
			throw new ArgumentException("The specified type must have a parameterless constructor.", "type");
		}
		if (type.IsSubclassOf(typeof(SecureMimeContext)))
		{
			lock (mutex)
			{
				SecureMimeContextFactory = () => (SecureMimeContext)ctor.Invoke(new object[0]);
				return;
			}
		}
		if (type.IsSubclassOf(typeof(OpenPgpContextBase)))
		{
			lock (mutex)
			{
				PgpContextFactory = () => (OpenPgpContextBase)ctor.Invoke(new object[0]);
				return;
			}
		}
		throw new ArgumentException("The specified type must be a subclass of SecureMimeContext or OpenPgpContext.", "type");
	}

	public static void Register(Func<SecureMimeContext> factory)
	{
		if (factory == null)
		{
			throw new ArgumentNullException("factory");
		}
		lock (mutex)
		{
			SecureMimeContextFactory = factory;
		}
	}

	public static void Register(Func<OpenPgpContextBase> factory)
	{
		if (factory == null)
		{
			throw new ArgumentNullException("factory");
		}
		lock (mutex)
		{
			PgpContextFactory = factory;
		}
	}
}
