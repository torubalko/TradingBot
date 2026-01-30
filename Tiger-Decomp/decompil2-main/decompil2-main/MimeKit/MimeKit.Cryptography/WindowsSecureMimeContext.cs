using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using MimeKit.IO;
using Org.BouncyCastle.Asn1.Smime;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Cms;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Collections;
using Org.BouncyCastle.X509;

namespace MimeKit.Cryptography;

public class WindowsSecureMimeContext : SecureMimeContext
{
	private const X509KeyStorageFlags DefaultKeyStorageFlags = X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet;

	public StoreLocation StoreLocation { get; private set; }

	public WindowsSecureMimeContext(StoreLocation location)
	{
		StoreLocation = location;
		Disable(EncryptionAlgorithm.Camellia256);
		Disable(EncryptionAlgorithm.Camellia192);
		Disable(EncryptionAlgorithm.Camellia192);
		Disable(EncryptionAlgorithm.Blowfish);
		Disable(EncryptionAlgorithm.Twofish);
		Disable(EncryptionAlgorithm.Cast5);
		Disable(EncryptionAlgorithm.Idea);
		Disable(EncryptionAlgorithm.Seed);
	}

	public WindowsSecureMimeContext()
		: this(StoreLocation.CurrentUser)
	{
	}

	public override bool CanSign(MailboxAddress signer)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		return GetSignerCertificate(signer) != null;
	}

	public override bool CanEncrypt(MailboxAddress mailbox)
	{
		if (mailbox == null)
		{
			throw new ArgumentNullException("mailbox");
		}
		return GetRecipientCertificate(mailbox) != null;
	}

	protected virtual X509Certificate2 GetRecipientCertificate(MailboxAddress mailbox)
	{
		StoreName[] array = new StoreName[3]
		{
			StoreName.AddressBook,
			StoreName.My,
			StoreName.TrustedPeople
		};
		SecureMailboxAddress secureMailboxAddress = mailbox as SecureMailboxAddress;
		DateTime utcNow = DateTime.UtcNow;
		StoreName[] array2 = array;
		foreach (StoreName storeName in array2)
		{
			X509Store x509Store = new X509Store(storeName, StoreLocation);
			x509Store.Open(OpenFlags.ReadOnly);
			try
			{
				X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
				while (enumerator.MoveNext())
				{
					X509Certificate2 current = enumerator.Current;
					if (current.NotBefore > utcNow || current.NotAfter < utcNow || (current.Extensions[X509Extensions.KeyUsage.Id] is X509KeyUsageExtension x509KeyUsageExtension && (x509KeyUsageExtension.KeyUsages & System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.KeyEncipherment) == 0))
					{
						continue;
					}
					if (secureMailboxAddress != null)
					{
						if (!current.Thumbprint.Equals(secureMailboxAddress.Fingerprint, StringComparison.OrdinalIgnoreCase))
						{
							continue;
						}
					}
					else
					{
						string nameInfo = current.GetNameInfo(X509NameType.EmailName, forIssuer: false);
						if (!nameInfo.Equals(mailbox.Address, StringComparison.InvariantCultureIgnoreCase))
						{
							continue;
						}
					}
					return current;
				}
			}
			finally
			{
				x509Store.Close();
			}
		}
		return null;
	}

	protected virtual System.Security.Cryptography.Pkcs.CmsRecipient GetCmsRecipient(MailboxAddress mailbox)
	{
		X509Certificate2 recipientCertificate;
		if ((recipientCertificate = GetRecipientCertificate(mailbox)) == null)
		{
			throw new CertificateNotFoundException(mailbox, "A valid certificate could not be found.");
		}
		return new System.Security.Cryptography.Pkcs.CmsRecipient(recipientCertificate);
	}

	private System.Security.Cryptography.Pkcs.CmsRecipientCollection GetCmsRecipients(IEnumerable<MailboxAddress> mailboxes)
	{
		System.Security.Cryptography.Pkcs.CmsRecipientCollection cmsRecipientCollection = new System.Security.Cryptography.Pkcs.CmsRecipientCollection();
		foreach (MailboxAddress mailbox in mailboxes)
		{
			cmsRecipientCollection.Add(GetCmsRecipient(mailbox));
		}
		if (cmsRecipientCollection.Count == 0)
		{
			throw new ArgumentException("No recipients specified.", "mailboxes");
		}
		return cmsRecipientCollection;
	}

	private System.Security.Cryptography.Pkcs.CmsRecipientCollection GetCmsRecipients(CmsRecipientCollection recipients)
	{
		System.Security.Cryptography.Pkcs.CmsRecipientCollection cmsRecipientCollection = new System.Security.Cryptography.Pkcs.CmsRecipientCollection();
		foreach (CmsRecipient recipient2 in recipients)
		{
			X509Certificate2 certificate = new X509Certificate2(recipient2.Certificate.GetEncoded());
			System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType = ((recipient2.RecipientIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier) ? System.Security.Cryptography.Pkcs.SubjectIdentifierType.IssuerAndSerialNumber : System.Security.Cryptography.Pkcs.SubjectIdentifierType.SubjectKeyIdentifier);
			RsaEncryptionPadding rsaEncryptionPadding = recipient2.RsaEncryptionPadding;
			if ((object)rsaEncryptionPadding != null && rsaEncryptionPadding.Scheme == RsaEncryptionPaddingScheme.Oaep)
			{
				throw new NotSupportedException("The RSAES-OAEP encryption padding scheme is not supported by the WindowsSecureMimeContext. You must use a subclass of BouncyCastleSecureMimeContext to get this feature.");
			}
			System.Security.Cryptography.Pkcs.CmsRecipient recipient = new System.Security.Cryptography.Pkcs.CmsRecipient(recipientIdentifierType, certificate);
			cmsRecipientCollection.Add(recipient);
		}
		return cmsRecipientCollection;
	}

	protected virtual X509Certificate2 GetSignerCertificate(MailboxAddress mailbox)
	{
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation);
		SecureMailboxAddress secureMailboxAddress = mailbox as SecureMailboxAddress;
		DateTime utcNow = DateTime.UtcNow;
		x509Store.Open(OpenFlags.ReadOnly);
		try
		{
			X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
			while (enumerator.MoveNext())
			{
				X509Certificate2 current = enumerator.Current;
				if (current.NotBefore > utcNow || current.NotAfter < utcNow || (current.Extensions[X509Extensions.KeyUsage.Id] is X509KeyUsageExtension x509KeyUsageExtension && (x509KeyUsageExtension.KeyUsages & (System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.NonRepudiation | System.Security.Cryptography.X509Certificates.X509KeyUsageFlags.DigitalSignature)) == 0) || !current.HasPrivateKey)
				{
					continue;
				}
				if (secureMailboxAddress != null)
				{
					if (!current.Thumbprint.Equals(secureMailboxAddress.Fingerprint, StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
				}
				else
				{
					string nameInfo = current.GetNameInfo(X509NameType.EmailName, forIssuer: false);
					if (!nameInfo.Equals(mailbox.Address, StringComparison.InvariantCultureIgnoreCase))
					{
						continue;
					}
				}
				return current;
			}
		}
		finally
		{
			x509Store.Close();
		}
		return null;
	}

	private AsnEncodedData GetSecureMimeCapabilities()
	{
		SmimeCapabilitiesAttribute secureMimeCapabilitiesAttribute = GetSecureMimeCapabilitiesAttribute(includeRsaesOaep: false);
		return new AsnEncodedData(secureMimeCapabilitiesAttribute.AttrType.Id, secureMimeCapabilitiesAttribute.AttrValues[0].GetEncoded());
	}

	private System.Security.Cryptography.Pkcs.CmsSigner GetRealCmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType type, X509Certificate2 certificate, DigestAlgorithm digestAlgo)
	{
		System.Security.Cryptography.Pkcs.CmsSigner cmsSigner = new System.Security.Cryptography.Pkcs.CmsSigner(type, certificate);
		cmsSigner.DigestAlgorithm = new Oid(SecureMimeContext.GetDigestOid(digestAlgo));
		cmsSigner.SignedAttributes.Add(GetSecureMimeCapabilities());
		cmsSigner.SignedAttributes.Add(new Pkcs9SigningTime());
		cmsSigner.IncludeOption = X509IncludeOption.ExcludeRoot;
		return cmsSigner;
	}

	private System.Security.Cryptography.Pkcs.CmsSigner GetRealCmsSigner(CmsSigner signer)
	{
		if (signer.RsaSignaturePadding == RsaSignaturePadding.Pss)
		{
			throw new NotSupportedException("The RSASSA-PSS signature padding scheme is not supported by the WindowsSecureMimeContext. You must use a subclass of BouncyCastleSecureMimeContext to get this feature.");
		}
		System.Security.Cryptography.Pkcs.SubjectIdentifierType type = ((signer.SignerIdentifierType != SubjectIdentifierType.SubjectKeyIdentifier) ? System.Security.Cryptography.Pkcs.SubjectIdentifierType.IssuerAndSerialNumber : System.Security.Cryptography.Pkcs.SubjectIdentifierType.SubjectKeyIdentifier);
		X509Certificate2 certificate;
		if (signer.WindowsCertificate != null)
		{
			certificate = signer.WindowsCertificate;
		}
		else
		{
			using MemoryStream memoryStream = new MemoryStream();
			X509CertificateEntry[] array = new X509CertificateEntry[signer.CertificateChain.Count];
			AsymmetricKeyEntry keyEntry = new AsymmetricKeyEntry(signer.PrivateKey);
			string text = Guid.NewGuid().ToString();
			SecureRandom random = new SecureRandom();
			Pkcs12Store pkcs12Store = new Pkcs12Store();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new X509CertificateEntry(signer.CertificateChain[i]);
			}
			pkcs12Store.SetKeyEntry("signer", keyEntry, array);
			pkcs12Store.Save(memoryStream, text.ToCharArray(), random);
			byte[] rawData = memoryStream.ToArray();
			certificate = new X509Certificate2(rawData, text);
		}
		return GetRealCmsSigner(type, certificate, signer.DigestAlgorithm);
	}

	protected virtual System.Security.Cryptography.Pkcs.CmsSigner GetCmsSigner(MailboxAddress mailbox, DigestAlgorithm digestAlgo)
	{
		X509Certificate2 signerCertificate;
		if ((signerCertificate = GetSignerCertificate(mailbox)) == null)
		{
			throw new CertificateNotFoundException(mailbox, "A valid signing certificate could not be found.");
		}
		return GetRealCmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType.IssuerAndSerialNumber, signerCertificate, digestAlgo);
	}

	protected virtual void UpdateSecureMimeCapabilities(X509Certificate2 certificate, EncryptionAlgorithm[] algorithms, DateTime timestamp)
	{
	}

	private static byte[] ReadAllBytes(Stream stream)
	{
		if (stream is MemoryBlockStream)
		{
			return ((MemoryBlockStream)stream).ToArray();
		}
		if (stream is MemoryStream)
		{
			return ((MemoryStream)stream).ToArray();
		}
		using MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		stream.CopyTo(memoryBlockStream, 4096);
		return memoryBlockStream.ToArray();
	}

	private static async Task<byte[]> ReadAllBytesAsync(Stream stream, CancellationToken cancellationToken)
	{
		if (stream is MemoryBlockStream)
		{
			return ((MemoryBlockStream)stream).ToArray();
		}
		if (stream is MemoryStream)
		{
			return ((MemoryStream)stream).ToArray();
		}
		using MemoryBlockStream memory = new MemoryBlockStream();
		await stream.CopyToAsync(memory, 4096, cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
		return memory.ToArray();
	}

	private Stream Sign(System.Security.Cryptography.Pkcs.CmsSigner signer, Stream content, bool detach)
	{
		ContentInfo contentInfo = new ContentInfo(ReadAllBytes(content));
		SignedCms signedCms = new SignedCms(contentInfo, detach);
		try
		{
			signedCms.ComputeSignature(signer, silent: false);
		}
		catch (CryptographicException)
		{
			signer.IncludeOption = X509IncludeOption.EndCertOnly;
			signedCms.ComputeSignature(signer, silent: false);
		}
		byte[] buffer = signedCms.Encode();
		return new MemoryStream(buffer, writable: false);
	}

	public override ApplicationPkcs7Mime EncapsulatedSign(CmsSigner signer, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		System.Security.Cryptography.Pkcs.CmsSigner realCmsSigner = GetRealCmsSigner(signer);
		return new ApplicationPkcs7Mime(SecureMimeType.SignedData, Sign(realCmsSigner, content, detach: false));
	}

	public override ApplicationPkcs7Mime EncapsulatedSign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		System.Security.Cryptography.Pkcs.CmsSigner cmsSigner = GetCmsSigner(signer, digestAlgo);
		return new ApplicationPkcs7Mime(SecureMimeType.SignedData, Sign(cmsSigner, content, detach: false));
	}

	public override ApplicationPkcs7Signature Sign(CmsSigner signer, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		System.Security.Cryptography.Pkcs.CmsSigner realCmsSigner = GetRealCmsSigner(signer);
		return new ApplicationPkcs7Signature(Sign(realCmsSigner, content, detach: true));
	}

	public override MimePart Sign(MailboxAddress signer, DigestAlgorithm digestAlgo, Stream content)
	{
		if (signer == null)
		{
			throw new ArgumentNullException("signer");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		System.Security.Cryptography.Pkcs.CmsSigner cmsSigner = GetCmsSigner(signer, digestAlgo);
		return new ApplicationPkcs7Signature(Sign(cmsSigner, content, detach: true));
	}

	protected internal static bool TryGetDigestAlgorithm(Oid identifier, out DigestAlgorithm algorithm)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		return SecureMimeContext.TryGetDigestAlgorithm(identifier.Value, out algorithm);
	}

	private DigitalSignatureCollection GetDigitalSignatures(SignedCms signed)
	{
		List<IDigitalSignature> list = new List<IDigitalSignature>();
		SignerInfoEnumerator enumerator = signed.SignerInfos.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SignerInfo current = enumerator.Current;
			WindowsSecureMimeDigitalSignature windowsSecureMimeDigitalSignature = new WindowsSecureMimeDigitalSignature(current);
			if (windowsSecureMimeDigitalSignature.EncryptionAlgorithms.Length != 0 && windowsSecureMimeDigitalSignature.CreationDate.Ticks != 0L)
			{
				UpdateSecureMimeCapabilities(current.Certificate, windowsSecureMimeDigitalSignature.EncryptionAlgorithms, windowsSecureMimeDigitalSignature.CreationDate);
			}
			else
			{
				try
				{
					Import(current.Certificate);
				}
				catch
				{
				}
			}
			list.Add(windowsSecureMimeDigitalSignature);
		}
		return new DigitalSignatureCollection(list);
	}

	public override DigitalSignatureCollection Verify(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (signatureData == null)
		{
			throw new ArgumentNullException("signatureData");
		}
		ContentInfo contentInfo = new ContentInfo(ReadAllBytes(content));
		SignedCms signedCms = new SignedCms(contentInfo, detached: true);
		signedCms.Decode(ReadAllBytes(signatureData));
		return GetDigitalSignatures(signedCms);
	}

	public override async Task<DigitalSignatureCollection> VerifyAsync(Stream content, Stream signatureData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		if (signatureData == null)
		{
			throw new ArgumentNullException("signatureData");
		}
		ContentInfo contentInfo = new ContentInfo(await ReadAllBytesAsync(content, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		SignedCms signed = new SignedCms(contentInfo, detached: true);
		SignedCms signedCms = signed;
		signedCms.Decode(await ReadAllBytesAsync(signatureData, cancellationToken).ConfigureAwait(continueOnCapturedContext: false));
		return GetDigitalSignatures(signed);
	}

	public override DigitalSignatureCollection Verify(Stream signedData, out MimeEntity entity, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		byte[] encodedMessage = ReadAllBytes(signedData);
		SignedCms signedCms = new SignedCms();
		signedCms.Decode(encodedMessage);
		MemoryStream memoryStream = new MemoryStream(signedCms.ContentInfo.Content, writable: false);
		try
		{
			entity = MimeEntity.Load(memoryStream, persistent: true, cancellationToken);
		}
		catch
		{
			memoryStream.Dispose();
			throw;
		}
		return GetDigitalSignatures(signedCms);
	}

	public override Stream Verify(Stream signedData, out DigitalSignatureCollection signatures, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (signedData == null)
		{
			throw new ArgumentNullException("signedData");
		}
		byte[] encodedMessage = ReadAllBytes(signedData);
		SignedCms signedCms = new SignedCms();
		signedCms.Decode(encodedMessage);
		signatures = GetDigitalSignatures(signedCms);
		return new MemoryStream(signedCms.ContentInfo.Content, writable: false);
	}

	protected virtual EncryptionAlgorithm GetPreferredEncryptionAlgorithm(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients)
	{
		int[] array = new int[SecureMimeContext.EncryptionAlgorithmCount];
		int count = recipients.Count;
		CmsRecipientEnumerator enumerator = recipients.GetEnumerator();
		while (enumerator.MoveNext())
		{
			System.Security.Cryptography.Pkcs.CmsRecipient current = enumerator.Current;
			EncryptionAlgorithm[] encryptionAlgorithms = current.Certificate.GetEncryptionAlgorithms();
			EncryptionAlgorithm[] array2 = encryptionAlgorithms;
			foreach (EncryptionAlgorithm encryptionAlgorithm in array2)
			{
				array[(int)encryptionAlgorithm]++;
			}
		}
		EncryptionAlgorithm result = EncryptionAlgorithm.TripleDes;
		int num = 0;
		array[8] = count;
		EncryptionAlgorithm[] array3 = base.EncryptionAlgorithmRank;
		foreach (EncryptionAlgorithm encryptionAlgorithm2 in array3)
		{
			if (IsEnabled(encryptionAlgorithm2) && array[(int)encryptionAlgorithm2] > num)
			{
				num = array[(int)encryptionAlgorithm2];
				result = encryptionAlgorithm2;
			}
		}
		return result;
	}

	internal System.Security.Cryptography.Pkcs.AlgorithmIdentifier GetAlgorithmIdentifier(EncryptionAlgorithm algorithm)
	{
		return algorithm switch
		{
			EncryptionAlgorithm.Aes256 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.Aes256Cbc)), 
			EncryptionAlgorithm.Aes192 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.Aes192Cbc)), 
			EncryptionAlgorithm.Aes128 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.Aes128Cbc)), 
			EncryptionAlgorithm.TripleDes => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.DesEde3Cbc)), 
			EncryptionAlgorithm.Des => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(SmimeCapability.DesCbc.Id)), 
			EncryptionAlgorithm.RC2128 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.RC2Cbc), 128), 
			EncryptionAlgorithm.RC264 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.RC2Cbc), 64), 
			EncryptionAlgorithm.RC240 => new System.Security.Cryptography.Pkcs.AlgorithmIdentifier(new Oid(CmsEnvelopedGenerator.RC2Cbc), 40), 
			_ => throw new NotSupportedException($"The {algorithm} encryption algorithm is not supported by the {GetType().Name}."), 
		};
	}

	private Stream Envelope(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients, Stream content, EncryptionAlgorithm encryptionAlgorithm)
	{
		ContentInfo contentInfo = new ContentInfo(ReadAllBytes(content));
		System.Security.Cryptography.Pkcs.AlgorithmIdentifier algorithmIdentifier = GetAlgorithmIdentifier(encryptionAlgorithm);
		EnvelopedCms envelopedCms = new EnvelopedCms(contentInfo, algorithmIdentifier);
		envelopedCms.Encrypt(recipients);
		return new MemoryStream(envelopedCms.Encode(), writable: false);
	}

	private Stream Envelope(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients, Stream content)
	{
		EncryptionAlgorithm preferredEncryptionAlgorithm = GetPreferredEncryptionAlgorithm(recipients);
		return Envelope(recipients, content, preferredEncryptionAlgorithm);
	}

	private Stream Envelope(CmsRecipientCollection recipients, Stream content)
	{
		EncryptionAlgorithm preferredEncryptionAlgorithm = GetPreferredEncryptionAlgorithm(recipients);
		return Envelope(GetCmsRecipients(recipients), content, preferredEncryptionAlgorithm);
	}

	public override ApplicationPkcs7Mime Encrypt(CmsRecipientCollection recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		return new ApplicationPkcs7Mime(SecureMimeType.EnvelopedData, Envelope(recipients, content));
	}

	public override MimePart Encrypt(IEnumerable<MailboxAddress> recipients, Stream content)
	{
		if (recipients == null)
		{
			throw new ArgumentNullException("recipients");
		}
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		System.Security.Cryptography.Pkcs.CmsRecipientCollection cmsRecipients = GetCmsRecipients(recipients);
		return new ApplicationPkcs7Mime(SecureMimeType.EnvelopedData, Envelope(cmsRecipients, content));
	}

	public override MimeEntity Decrypt(Stream encryptedData, CancellationToken cancellationToken = default(CancellationToken))
	{
		if (encryptedData == null)
		{
			throw new ArgumentNullException("encryptedData");
		}
		EnvelopedCms envelopedCms = new EnvelopedCms();
		CryptographicException ex = null;
		envelopedCms.Decode(ReadAllBytes(encryptedData));
		RecipientInfoEnumerator enumerator = envelopedCms.RecipientInfos.GetEnumerator();
		while (enumerator.MoveNext())
		{
			RecipientInfo current = enumerator.Current;
			try
			{
				envelopedCms.Decrypt(current);
				ex = null;
			}
			catch (CryptographicException ex2)
			{
				ex = ex2;
				continue;
			}
			break;
		}
		if (ex != null)
		{
			throw ex;
		}
		byte[] buffer = envelopedCms.Encode();
		MemoryStream stream = new MemoryStream(buffer, writable: false);
		return MimeEntity.Load(stream, persistent: true, cancellationToken);
	}

	public override void DecryptTo(Stream encryptedData, Stream decryptedData)
	{
		if (encryptedData == null)
		{
			throw new ArgumentNullException("encryptedData");
		}
		if (decryptedData == null)
		{
			throw new ArgumentNullException("decryptedData");
		}
		EnvelopedCms envelopedCms = new EnvelopedCms();
		envelopedCms.Decode(ReadAllBytes(encryptedData));
		envelopedCms.Decrypt();
		byte[] array = envelopedCms.Encode();
		decryptedData.Write(array, 0, array.Length);
	}

	public void Import(StoreName storeName, X509Certificate2 certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		X509Store x509Store = new X509Store(storeName, StoreLocation);
		x509Store.Open(OpenFlags.ReadWrite);
		x509Store.Add(certificate);
		x509Store.Close();
	}

	public void Import(X509Certificate2 certificate)
	{
		Import(StoreName.AddressBook, certificate);
	}

	public void Import(StoreName storeName, Org.BouncyCastle.X509.X509Certificate certificate)
	{
		if (certificate == null)
		{
			throw new ArgumentNullException("certificate");
		}
		Import(storeName, new X509Certificate2(certificate.GetEncoded()));
	}

	public override void Import(Org.BouncyCastle.X509.X509Certificate certificate)
	{
		Import(StoreName.AddressBook, certificate);
	}

	public override void Import(X509Crl crl)
	{
		if (crl == null)
		{
			throw new ArgumentNullException("crl");
		}
		ISet revokedCertificates = crl.GetRevokedCertificates();
		if (revokedCertificates == null)
		{
			return;
		}
		foreach (Org.BouncyCastle.X509.X509Certificate item in revokedCertificates)
		{
			Import(StoreName.Disallowed, item);
		}
	}

	public void Import(Stream stream, string password, X509KeyStorageFlags flags)
	{
		if (stream == null)
		{
			throw new ArgumentNullException("stream");
		}
		if (password == null)
		{
			throw new ArgumentNullException("password");
		}
		byte[] rawData = ReadAllBytes(stream);
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation);
		X509Certificate2Collection x509Certificate2Collection = new X509Certificate2Collection();
		x509Store.Open(OpenFlags.ReadWrite);
		x509Certificate2Collection.Import(rawData, password, flags);
		x509Store.AddRange(x509Certificate2Collection);
		x509Store.Close();
	}

	public override void Import(Stream stream, string password)
	{
		Import(stream, password, X509KeyStorageFlags.UserKeySet | X509KeyStorageFlags.Exportable | X509KeyStorageFlags.PersistKeySet);
	}

	public override MimePart Export(IEnumerable<MailboxAddress> mailboxes)
	{
		if (mailboxes == null)
		{
			throw new ArgumentNullException("mailboxes");
		}
		X509CertificateStore x509CertificateStore = new X509CertificateStore();
		int num = 0;
		foreach (MailboxAddress mailbox in mailboxes)
		{
			X509Certificate2 recipientCertificate = GetRecipientCertificate(mailbox);
			if (recipientCertificate != null)
			{
				x509CertificateStore.Add(recipientCertificate.AsBouncyCastleCertificate());
			}
			num++;
		}
		if (num == 0)
		{
			throw new ArgumentException("No mailboxes specified.", "mailboxes");
		}
		CmsSignedDataStreamGenerator cmsSignedDataStreamGenerator = new CmsSignedDataStreamGenerator();
		cmsSignedDataStreamGenerator.AddCertificates(x509CertificateStore);
		MemoryBlockStream memoryBlockStream = new MemoryBlockStream();
		cmsSignedDataStreamGenerator.Open(memoryBlockStream).Dispose();
		memoryBlockStream.Position = 0L;
		return new ApplicationPkcs7Mime(SecureMimeType.CertsOnly, memoryBlockStream);
	}
}
